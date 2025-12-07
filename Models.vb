' Models.vb

' ==== DATA SISWA ====
Public Class Student
    Public Property NIM As String
    Public Property Nama As String
    Public Property Kelas As String
    Public Property JenisKelamin As String
    Public Property Aktif As Boolean
    Public Property TanggalDaftar As Date
End Class

' ==== DATA MATA PELAJARAN ====
Public Enum KategoriMapel
    Teori
    Praktik
    Project
End Enum

Public Class Course
    Public Property Kode As String
    Public Property Nama As String
    Public Property SKS As Integer
    Public Property Kategori As KategoriMapel
End Class

Public Enum GradeHuruf
    A
    B
    C
    D
    E
End Enum

Public Class GradeRecord
    Public Property NamaSiswa As String
    Public Property Kelas As String
    Public Property NamaMapel As String
    Public Property NilaiTugas As Double
    Public Property NilaiQuiz As Double
    Public Property NilaiUTS As Double
    Public Property NilaiUAS As Double
    Public Property NilaiAkhir As Double
    Public Property Grade As GradeHuruf
    Public Property Status As String
End Class

' ==== PENYIMPANAN DATA DI MEMORI ====
Module AppData
    Public Students As New List(Of Student)
    Public Courses As New List(Of Course)

    Public Grades As New List(Of GradeRecord)

    ' Konstanta bobot nilai
    Public Const BobotTugas As Double = 0.2
    Public Const BobotQuiz As Double = 0.1
    Public Const BobotUTS As Double = 0.3
    Public Const BobotUAS As Double = 0.4
    Public Const NilaiMinimalLulus As Integer = 70

    ' Konstanta batas minimal grade
    Public Const GradeAMin As Integer = 85
    Public Const GradeBMin As Integer = 75
    Public Const GradeCMin As Integer = 65
    Public Const GradeDMin As Integer = 50
    ' E otomatis < GradeDMin

End Module
