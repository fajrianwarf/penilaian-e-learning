Option Strict On
Option Explicit On

Imports System.IO

' DataPersistence.vb
' Menangani Save/Upload data ke CSV.
' Di sini dimasukkan materi:
' - handling exceptions (Try/Catch/Finally)
' - files + file dates/times
' - direktori
' - string parsing (CsvHelper)
' - arrays + collections (List)
' - if statements + select case
' - for/foreach/while/do loops
' - ByVal/ByRef
Public Module DataPersistence

    Private Const StudentsFileName As String = "students.csv"
    Private Const CoursesFileName As String = "courses.csv"
    Private Const GradesFileName As String = "grades.csv"
    Private Const ManifestFileName As String = "manifest.txt"

    Public Function SaveAllToCsv(ByVal baseFolder As String, ByRef info As String) As Boolean
        Dim outDir As String = AppStorage.EnsureSubDirectory(baseFolder, "export")
        Dim exportStamp As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        Dim exportDir As String = AppStorage.EnsureSubDirectory(outDir, exportStamp)

        Dim studentsPath As String = Path.Combine(exportDir, StudentsFileName)
        Dim coursesPath As String = Path.Combine(exportDir, CoursesFileName)
        Dim gradesPath As String = Path.Combine(exportDir, GradesFileName)
        Dim manifestPath As String = Path.Combine(exportDir, ManifestFileName)

        Dim linesWritten As Integer = 0

        Try
            ' ============ STUDENTS ============
            Using sw As New StreamWriter(studentsPath, False, System.Text.Encoding.UTF8)
                sw.WriteLine(CsvHelper.ToCsvLine(New String() {"NIM", "Nama", "Kelas", "JenisKelamin", "Aktif", "TanggalDaftar"}))
                For Each s As Student In Students
                    Dim fields As String() = {
                        s.NIM,
                        s.Nama,
                        s.Kelas,
                        s.JenisKelamin,
                        If(s.Aktif, "1", "0"),
                        s.TanggalDaftar.ToString("yyyy-MM-dd")
                    }
                    sw.WriteLine(CsvHelper.ToCsvLine(fields))
                    linesWritten += 1
                Next
            End Using

            ' ============ COURSES ============
            Using sw As New StreamWriter(coursesPath, False, System.Text.Encoding.UTF8)
                sw.WriteLine(CsvHelper.ToCsvLine(New String() {"Kode", "Nama", "SKS", "Kategori"}))
                For Each c As Course In Courses
                    Dim fields As String() = {
                        c.Kode,
                        c.Nama,
                        c.SKS.ToString(),
                        c.Kategori.ToString()
                    }
                    sw.WriteLine(CsvHelper.ToCsvLine(fields))
                    linesWritten += 1
                Next
            End Using

            ' ============ GRADES ============
            Using sw As New StreamWriter(gradesPath, False, System.Text.Encoding.UTF8)
                sw.WriteLine(CsvHelper.ToCsvLine(New String() {"NamaSiswa", "Kelas", "NamaMapel", "NilaiTugas", "NilaiQuiz", "NilaiUTS", "NilaiUAS", "NilaiAkhir", "Grade", "Status"}))
                For Each g As GradeRecord In Grades
                    Dim fields As String() = {
                        g.NamaSiswa,
                        g.Kelas,
                        g.NamaMapel,
                        g.NilaiTugas.ToString(Globalization.CultureInfo.InvariantCulture),
                        g.NilaiQuiz.ToString(Globalization.CultureInfo.InvariantCulture),
                        g.NilaiUTS.ToString(Globalization.CultureInfo.InvariantCulture),
                        g.NilaiUAS.ToString(Globalization.CultureInfo.InvariantCulture),
                        g.NilaiAkhir.ToString(Globalization.CultureInfo.InvariantCulture),
                        g.Grade.ToString(),
                        g.Status
                    }
                    sw.WriteLine(CsvHelper.ToCsvLine(fields))
                    linesWritten += 1
                Next
            End Using

            ' ============ MANIFEST ============
            Using sw As New StreamWriter(manifestPath, False, System.Text.Encoding.UTF8)
                sw.WriteLine("Export At : " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                sw.WriteLine("Students  : " & Students.Count)
                sw.WriteLine("Courses   : " & Courses.Count)
                sw.WriteLine("Grades    : " & Grades.Count)
                sw.WriteLine("---- File Dates/Times ----")
                sw.WriteLine(StudentsFileName & " lastWrite: " & File.GetLastWriteTime(studentsPath).ToString("yyyy-MM-dd HH:mm:ss"))
                sw.WriteLine(CoursesFileName & " lastWrite: " & File.GetLastWriteTime(coursesPath).ToString("yyyy-MM-dd HH:mm:ss"))
                sw.WriteLine(GradesFileName & " lastWrite: " & File.GetLastWriteTime(gradesPath).ToString("yyyy-MM-dd HH:mm:ss"))
            End Using

            info = "Berhasil menyimpan data ke:" & Environment.NewLine &
                   exportDir & Environment.NewLine & Environment.NewLine &
                   "Ringkasan:" & Environment.NewLine &
                   "- Students: " & Students.Count & Environment.NewLine &
                   "- Courses: " & Courses.Count & Environment.NewLine &
                   "- Grades: " & Grades.Count

            Return True

        Catch ex As UnauthorizedAccessException
            info = "Gagal menyimpan data. Akses ditolak: " & ex.Message
            Return False
        Catch ex As IOException
            info = "Gagal menyimpan data. Masalah file I/O: " & ex.Message
            Return False
        Catch ex As Exception
            info = "Gagal menyimpan data. Error: " & ex.Message
            Return False
        Finally
            ' Contoh Finally: di sini bisa dipakai untuk logging jika dibutuhkan.
            Dim dummyLinesWritten As Integer = linesWritten
        End Try
    End Function

    Public Function LoadAllFromCsv(ByVal baseFolder As String, ByRef info As String) As Boolean
        ' Mendukung: user memilih folder "export\<timestamp>" atau parent folder.
        Dim resolvedFolder As String = ResolveImportFolder(baseFolder)

        Dim studentsPath As String = Path.Combine(resolvedFolder, StudentsFileName)
        Dim coursesPath As String = Path.Combine(resolvedFolder, CoursesFileName)
        Dim gradesPath As String = Path.Combine(resolvedFolder, GradesFileName)

        If Not File.Exists(studentsPath) OrElse Not File.Exists(coursesPath) OrElse Not File.Exists(gradesPath) Then
            info = "File CSV tidak lengkap. Pastikan ada: " & StudentsFileName & ", " & CoursesFileName & ", " & GradesFileName
            Return False
        End If

        Dim tmpStudents As New List(Of Student)()
        Dim tmpCourses As New List(Of Course)()
        Dim tmpGrades As New List(Of GradeRecord)()
        Dim errors As New List(Of String)()

        Try
            ' ==== STUDENTS ====
            ReadCsvFile(studentsPath,
                        Sub(fields, lineNo)
                            If lineNo = 1 Then Return ' header

                            ' Minimal 6 kolom
                            If fields.Length < 6 Then
                                errors.Add("students.csv baris " & lineNo & " kolom kurang")
                                Return
                            End If

                            Dim s As New Student()
                            s.NIM = fields(0).Trim()
                            s.Nama = fields(1).Trim()
                            s.Kelas = fields(2).Trim()
                            s.JenisKelamin = fields(3).Trim()

                            Dim aktif As Boolean
                            If Not CsvHelper.TryParseBoolean(fields(4), aktif) Then
                                ' identifikasi string: kalau berisi karakter tertentu
                                If fields(4).Trim().Contains("aktif", StringComparison.OrdinalIgnoreCase) Then
                                    aktif = True
                                Else
                                    aktif = False
                                End If
                            End If
                            s.Aktif = aktif

                            Dim tgl As Date
                            If Not CsvHelper.TryParseDate(fields(5), tgl) Then
                                tgl = Date.Today
                            End If
                            s.TanggalDaftar = tgl

                            If String.IsNullOrWhiteSpace(s.NIM) OrElse String.IsNullOrWhiteSpace(s.Nama) Then
                                errors.Add("students.csv baris " & lineNo & " NIM/Nama kosong")
                                Return
                            End If

                            tmpStudents.Add(s)
                        End Sub)

            ' ==== COURSES ====
            ReadCsvFile(coursesPath,
                        Sub(fields, lineNo)
                            If lineNo = 1 Then Return
                            If fields.Length < 4 Then
                                errors.Add("courses.csv baris " & lineNo & " kolom kurang")
                                Return
                            End If

                            Dim c As New Course()
                            c.Kode = fields(0).Trim()
                            c.Nama = fields(1).Trim()

                            Dim sks As Integer
                            If Not Integer.TryParse(fields(2).Trim(), sks) Then
                                sks = 0
                            End If
                            c.SKS = sks

                            ' Select Case demo untuk mapping enum
                            Dim rawKategori As String = fields(3).Trim()
                            Select Case rawKategori.ToLowerInvariant()
                                Case "teori"
                                    c.Kategori = KategoriMapel.Teori
                                Case "praktik"
                                    c.Kategori = KategoriMapel.Praktik
                                Case "project"
                                    c.Kategori = KategoriMapel.Project
                                Case Else
                                    c.Kategori = KategoriMapel.Teori
                            End Select

                            If String.IsNullOrWhiteSpace(c.Kode) OrElse String.IsNullOrWhiteSpace(c.Nama) Then
                                errors.Add("courses.csv baris " & lineNo & " Kode/Nama kosong")
                                Return
                            End If

                            tmpCourses.Add(c)
                        End Sub)

            ' ==== GRADES ====
            ReadCsvFile(gradesPath,
                        Sub(fields, lineNo)
                            If lineNo = 1 Then Return
                            If fields.Length < 10 Then
                                errors.Add("grades.csv baris " & lineNo & " kolom kurang")
                                Return
                            End If

                            Dim rec As New GradeRecord()
                            rec.NamaSiswa = fields(0).Trim()
                            rec.Kelas = fields(1).Trim()
                            rec.NamaMapel = fields(2).Trim()

                            Dim tugas, quiz, uts, uas, akhir As Double
                            CsvHelper.TryParseDouble(fields(3), tugas)
                            CsvHelper.TryParseDouble(fields(4), quiz)
                            CsvHelper.TryParseDouble(fields(5), uts)
                            CsvHelper.TryParseDouble(fields(6), uas)
                            CsvHelper.TryParseDouble(fields(7), akhir)

                            rec.NilaiTugas = tugas
                            rec.NilaiQuiz = quiz
                            rec.NilaiUTS = uts
                            rec.NilaiUAS = uas
                            rec.NilaiAkhir = akhir

                            Dim rawGrade As String = fields(8).Trim().ToUpperInvariant()
                            Select Case rawGrade
                                Case "A"
                                    rec.Grade = GradeHuruf.A
                                Case "B"
                                    rec.Grade = GradeHuruf.B
                                Case "C"
                                    rec.Grade = GradeHuruf.C
                                Case "D"
                                    rec.Grade = GradeHuruf.D
                                Case Else
                                    rec.Grade = GradeHuruf.E
                            End Select

                            rec.Status = fields(9).Trim()

                            tmpGrades.Add(rec)
                        End Sub)

            ' Jika ada error parse, tetap load namun tampilkan ringkasan.
            Students.Clear()
            Courses.Clear()
            Grades.Clear()

            Students.AddRange(tmpStudents)
            Courses.AddRange(tmpCourses)
            Grades.AddRange(tmpGrades)

            Dim errSummary As String = ""
            If errors.Count > 0 Then
                ' tampilkan maksimal 10 error agar tidak terlalu panjang
                Dim max As Integer = Math.Min(10, errors.Count)
                errSummary &= Environment.NewLine & Environment.NewLine & "Catatan (" & errors.Count & "):" & Environment.NewLine
                For i As Integer = 0 To max - 1
                    errSummary &= "- " & errors(i) & Environment.NewLine
                Next
                If errors.Count > max Then
                    errSummary &= "- ... (lihat file CSV untuk perbaikan)" & Environment.NewLine
                End If
            End If

            info = "Berhasil upload data dari:" & Environment.NewLine &
                   resolvedFolder & Environment.NewLine & Environment.NewLine &
                   "Ringkasan:" & Environment.NewLine &
                   "- Students: " & Students.Count & Environment.NewLine &
                   "- Courses: " & Courses.Count & Environment.NewLine &
                   "- Grades: " & Grades.Count & errSummary

            Return True

        Catch ex As Exception
            info = "Gagal upload data. Error: " & ex.Message
            Return False
        End Try
    End Function

    ' =============== Helpers ===============

    Private Function ResolveImportFolder(ByVal baseFolder As String) As String
        ' Jika user memilih parent folder, cari folder export terbaru.
        Dim exportDir As String = Path.Combine(baseFolder, "export")

        If Directory.Exists(exportDir) Then
            ' Cari subdir timestamp terbaru.
            Dim subdirs As String() = Directory.GetDirectories(exportDir)

            If subdirs.Length > 0 Then
                Array.Sort(subdirs) ' urutkan naik, timestamp format yyyymmdd_hhmmss
                Return subdirs(subdirs.Length - 1)
            End If
        End If

        ' Kalau folder yang dipilih langsung berisi students.csv, pakai itu.
        If File.Exists(Path.Combine(baseFolder, StudentsFileName)) Then
            Return baseFolder
        End If

        ' Kalau tidak ketemu, fallback ke baseFolder.
        Return baseFolder
    End Function

    Private Sub ReadCsvFile(ByVal path As String, ByVal onRow As Action(Of String(), Integer))
        Using sr As New StreamReader(path, System.Text.Encoding.UTF8)
            Dim lineNo As Integer = 0
            Dim line As String = sr.ReadLine()

            ' While loop demo
            While line IsNot Nothing
                lineNo += 1

                ' Skip baris kosong atau komentar
                If String.IsNullOrWhiteSpace(line) OrElse line.Trim().StartsWith("#") Then
                    line = sr.ReadLine()
                    Continue While
                End If

                Dim fields As String() = CsvHelper.ParseCsvLine(line)
                onRow(fields, lineNo)

                line = sr.ReadLine()
            End While
        End Using
    End Sub

End Module
