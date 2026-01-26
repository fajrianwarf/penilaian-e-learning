Option Strict On
Option Explicit On

Imports System.Drawing
Imports System.Drawing.Printing

' ReportPrinting.vb
' Print report (multi-page) untuk seluruh data.
' Improvement:
' - NIM & Kode dipaksa align kiri (bukan numeric)
' - Grades lengkap: Tugas, Quiz, UTS, UAS, Akhir, Grade, Status
' - Layout lebih rapi: Landscape, table header shading, zebra rows, grid lines,
'   calculate text width (MeasureString), clipping yang lebih stabil, footer page number

Public Module ReportPrinting

    Private Enum ReportSection
        Dashboard
        Students
        Courses
        Grades
        Done
    End Enum

    Private Class ReportState
        Public Section As ReportSection = ReportSection.Dashboard
        Public RowIndex As Integer = 0
        Public PageNumber As Integer = 0
        Public DashboardBitmap As Bitmap = Nothing
    End Class

    Private Enum ColAlign
        Left
        Center
        Right
    End Enum

    Private Class ColumnDef
        Public Header As String
        Public WidthPct As Single
        Public Align As ColAlign

        Public Sub New(ByVal headerText As String, ByVal pct As Single, ByVal alignment As ColAlign)
            Header = headerText
            WidthPct = pct
            Align = alignment
        End Sub
    End Class

    Private _state As ReportState

    Public Function CreatePrintDocument(ByVal owner As Form) As PrintDocument
        Dim doc As New PrintDocument()
        doc.DocumentName = "Penilaian E-Learning - All Data"

        ' Biar tabel grades muat dan terlihat rapi
        doc.DefaultPageSettings.Landscape = True

        _state = New ReportState()

        ' Control Printing: snapshot ringkasan dashboard
        Try
            Dim main As FormMain = TryCast(owner, FormMain)
            If main IsNot Nothing AndAlso main.grpRingkasan IsNot Nothing Then
                Dim bmp As New Bitmap(main.grpRingkasan.Width, main.grpRingkasan.Height)
                main.grpRingkasan.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
                _state.DashboardBitmap = bmp
            End If
        Catch
            _state.DashboardBitmap = Nothing
        End Try

        AddHandler doc.BeginPrint, AddressOf Doc_BeginPrint
        AddHandler doc.PrintPage, AddressOf Doc_PrintPage
        AddHandler doc.EndPrint, AddressOf Doc_EndPrint

        Return doc
    End Function

    Private Sub Doc_BeginPrint(sender As Object, e As PrintEventArgs)
        If _state Is Nothing Then _state = New ReportState()
        _state.Section = ReportSection.Dashboard
        _state.RowIndex = 0
        _state.PageNumber = 0
    End Sub

    Private Sub Doc_EndPrint(sender As Object, e As PrintEventArgs)
        If _state IsNot Nothing AndAlso _state.DashboardBitmap IsNot Nothing Then
            _state.DashboardBitmap.Dispose()
            _state.DashboardBitmap = Nothing
        End If
    End Sub

    Private Sub Doc_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics
        g.PageUnit = GraphicsUnit.Display

        Dim bounds As RectangleF = e.MarginBounds
        Dim x As Single = bounds.Left
        Dim y As Single = bounds.Top
        Dim maxY As Single = bounds.Bottom

        _state.PageNumber += 1

        Dim titleFont As New Font("Segoe UI", 14, FontStyle.Bold)
        Dim headerFont As New Font("Segoe UI", 9, FontStyle.Bold)
        Dim bodyFont As New Font("Segoe UI", 9, FontStyle.Regular)
        Dim smallFont As New Font("Segoe UI", 8, FontStyle.Regular)

        Dim lineH As Single = g.MeasureString("Ag", bodyFont).Height + 4
        Dim titleH As Single = g.MeasureString("Ag", titleFont).Height

        DrawHeader(g, bounds, titleFont, headerFont, y)
        y += titleH + 10

        Dim hasMore As Boolean

        Select Case _state.Section
            Case ReportSection.Dashboard
                hasMore = PrintDashboardSection(g, bounds, bodyFont, lineH, y, maxY)

            Case ReportSection.Students
                hasMore = PrintStudentsSection(g, bounds, headerFont, bodyFont, lineH, y, maxY)

            Case ReportSection.Courses
                hasMore = PrintCoursesSection(g, bounds, headerFont, bodyFont, lineH, y, maxY)

            Case ReportSection.Grades
                hasMore = PrintGradesSection(g, bounds, headerFont, bodyFont, lineH, y, maxY)

            Case Else
                hasMore = False
        End Select

        DrawFooter(g, bounds, smallFont, _state.PageNumber)
        e.HasMorePages = hasMore
    End Sub

    Private Sub DrawHeader(ByVal g As Graphics, ByVal bounds As RectangleF, ByVal titleFont As Font, ByVal headerFont As Font, ByVal y As Single)
        Dim title As String = "Laporan Data Penilaian E-Learning"
        g.DrawString(title, titleFont, Brushes.Black, bounds.Left, y)

        Dim meta As String = "Dicetak: " & DateTime.Now.ToString("dd MMM yyyy HH:mm:ss")
        Dim fmtRight As New StringFormat() With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Near}
        g.DrawString(meta, headerFont, Brushes.Black, bounds.Right, y, fmtRight)

        Dim sepY As Single = y + g.MeasureString("Ag", titleFont).Height + 2
        g.DrawLine(New Pen(Color.Black, 1.2F), bounds.Left, sepY, bounds.Right, sepY)
    End Sub

    Private Sub DrawFooter(ByVal g As Graphics, ByVal bounds As RectangleF, ByVal font As Font, ByVal pageNo As Integer)
        Dim fmtCenter As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Near}
        g.DrawString("Halaman " & pageNo.ToString(), font, Brushes.Black, bounds.Left + (bounds.Width / 2), bounds.Bottom + 10, fmtCenter)
    End Sub

    ' =============================
    ' SECTION: DASHBOARD
    ' =============================
    Private Function PrintDashboardSection(ByVal g As Graphics, ByVal bounds As RectangleF, ByVal font As Font, ByVal lineH As Single, ByRef y As Single, ByVal maxY As Single) As Boolean
        DrawSectionTitle(g, bounds, "Ringkasan", y)
        y += lineH + 2

        If _state.DashboardBitmap IsNot Nothing Then
            Dim targetW As Single = Math.Min(_state.DashboardBitmap.Width, bounds.Width)
            Dim scale As Single = targetW / _state.DashboardBitmap.Width
            Dim targetH As Single = _state.DashboardBitmap.Height * scale

            If y + targetH > maxY Then
                Return True
            End If

            g.DrawImage(_state.DashboardBitmap, bounds.Left, y, targetW, targetH)
            y += targetH + 12
        Else
            g.DrawString("(Snapshot ringkasan tidak tersedia)", font, Brushes.Black, bounds.Left, y)
            y += lineH + 6
        End If

        _state.Section = ReportSection.Students
        _state.RowIndex = 0
        Return True
    End Function

    ' =============================
    ' SECTION: STUDENTS
    ' =============================
    Private Function PrintStudentsSection(ByVal g As Graphics, ByVal bounds As RectangleF, ByVal headerFont As Font, ByVal bodyFont As Font, ByVal lineH As Single, ByRef y As Single, ByVal maxY As Single) As Boolean
        DrawSectionTitle(g, bounds, "Data Siswa (" & Students.Count.ToString() & ")", y)
        y += lineH + 2

        If Students.Count = 0 Then
            g.DrawString("(Tidak ada data)", bodyFont, Brushes.Black, bounds.Left, y)
            y += lineH
            _state.Section = ReportSection.Courses
            _state.RowIndex = 0
            Return True
        End If

        ' NIM dipaksa align kiri agar tidak terlihat geser (walaupun angka)
        Dim cols As New List(Of ColumnDef) From {
            New ColumnDef("NIM", 0.18F, ColAlign.Left),
            New ColumnDef("Nama", 0.3F, ColAlign.Left),
            New ColumnDef("Kelas", 0.1F, ColAlign.Center),
            New ColumnDef("JK", 0.1F, ColAlign.Center),
            New ColumnDef("Aktif", 0.1F, ColAlign.Center),
            New ColumnDef("Tanggal Daftar", 0.22F, ColAlign.Center)
        }

        Dim startY As Single = y
        DrawTableHeader(g, bounds, headerFont, cols, y, lineH)
        y += lineH

        While _state.RowIndex < Students.Count
            If y + lineH > maxY Then
                Return True
            End If

            Dim s As Student = Students(_state.RowIndex)
            Dim jk As String = If(s.JenisKelamin = "L", "Laki-laki", If(s.JenisKelamin = "P", "Perempuan", s.JenisKelamin))
            Dim aktif As String = If(s.Aktif, "Aktif", "Tidak")

            Dim cells As String() = {
                SafeStr(s.NIM),
                SafeStr(s.Nama),
                SafeStr(s.Kelas),
                SafeStr(jk),
                SafeStr(aktif),
                s.TanggalDaftar.ToString("dd/MM/yyyy")
            }

            DrawTableRow(g, bounds, bodyFont, cols, cells, y, lineH, (_state.RowIndex Mod 2 = 0))
            y += lineH
            _state.RowIndex += 1
        End While

        ' garis penutup table
        g.DrawLine(Pens.Black, bounds.Left, y, bounds.Right, y)

        _state.Section = ReportSection.Courses
        _state.RowIndex = 0
        Return True
    End Function

    ' =============================
    ' SECTION: COURSES
    ' =============================
    Private Function PrintCoursesSection(ByVal g As Graphics, ByVal bounds As RectangleF, ByVal headerFont As Font, ByVal bodyFont As Font, ByVal lineH As Single, ByRef y As Single, ByVal maxY As Single) As Boolean
        DrawSectionTitle(g, bounds, "Data Mata Pelajaran (" & Courses.Count.ToString() & ")", y)
        y += lineH + 2

        If Courses.Count = 0 Then
            g.DrawString("(Tidak ada data)", bodyFont, Brushes.Black, bounds.Left, y)
            y += lineH
            _state.Section = ReportSection.Grades
            _state.RowIndex = 0
            Return True
        End If

        Dim cols As New List(Of ColumnDef) From {
            New ColumnDef("Kode", 0.16F, ColAlign.Left),
            New ColumnDef("Nama", 0.52F, ColAlign.Left),
            New ColumnDef("SKS", 0.08F, ColAlign.Right),
            New ColumnDef("Kategori", 0.24F, ColAlign.Center)
        }

        DrawTableHeader(g, bounds, headerFont, cols, y, lineH)
        y += lineH

        While _state.RowIndex < Courses.Count
            If y + lineH > maxY Then
                Return True
            End If

            Dim c As Course = Courses(_state.RowIndex)
            Dim cells As String() = {
                SafeStr(c.Kode),
                SafeStr(c.Nama),
                c.SKS.ToString(),
                SafeStr(c.Kategori.ToString())
            }

            DrawTableRow(g, bounds, bodyFont, cols, cells, y, lineH, (_state.RowIndex Mod 2 = 0))
            y += lineH
            _state.RowIndex += 1
        End While

        g.DrawLine(Pens.Black, bounds.Left, y, bounds.Right, y)

        _state.Section = ReportSection.Grades
        _state.RowIndex = 0
        Return True
    End Function

    ' =============================
    ' SECTION: GRADES (LENGKAP)
    ' =============================
    Private Function PrintGradesSection(ByVal g As Graphics, ByVal bounds As RectangleF, ByVal headerFont As Font, ByVal bodyFont As Font, ByVal lineH As Single, ByRef y As Single, ByVal maxY As Single) As Boolean
        DrawSectionTitle(g, bounds, "Data Penilaian (" & Grades.Count.ToString() & ")", y)
        y += lineH + 2

        If Grades.Count = 0 Then
            g.DrawString("(Tidak ada data)", bodyFont, Brushes.Black, bounds.Left, y)
            y += lineH
            _state.Section = ReportSection.Done
            Return False
        End If

        ' Landscape: muat untuk banyak kolom
        Dim cols As New List(Of ColumnDef) From {
            New ColumnDef("Siswa", 0.18F, ColAlign.Left),
            New ColumnDef("Kelas", 0.07F, ColAlign.Center),
            New ColumnDef("Mapel", 0.18F, ColAlign.Left),
            New ColumnDef("Tugas", 0.07F, ColAlign.Right),
            New ColumnDef("Quiz", 0.07F, ColAlign.Right),
            New ColumnDef("UTS", 0.07F, ColAlign.Right),
            New ColumnDef("UAS", 0.07F, ColAlign.Right),
            New ColumnDef("Akhir", 0.07F, ColAlign.Right),
            New ColumnDef("Grade", 0.06F, ColAlign.Center),
            New ColumnDef("Status", 0.09F, ColAlign.Center)
        }

        DrawTableHeader(g, bounds, headerFont, cols, y, lineH)
        y += lineH

        While _state.RowIndex < Grades.Count
            If y + lineH > maxY Then
                Return True
            End If

            Dim r As GradeRecord = Grades(_state.RowIndex)

            Dim cells As String() = {
                SafeStr(r.NamaSiswa),
                SafeStr(r.Kelas),
                SafeStr(r.NamaMapel),
                r.NilaiTugas.ToString("0.##"),
                r.NilaiQuiz.ToString("0.##"),
                r.NilaiUTS.ToString("0.##"),
                r.NilaiUAS.ToString("0.##"),
                r.NilaiAkhir.ToString("0.##"),
                SafeStr(r.Grade.ToString()),
                SafeStr(r.Status)
            }

            DrawTableRow(g, bounds, bodyFont, cols, cells, y, lineH, (_state.RowIndex Mod 2 = 0))
            y += lineH
            _state.RowIndex += 1
        End While

        g.DrawLine(Pens.Black, bounds.Left, y, bounds.Right, y)

        _state.Section = ReportSection.Done
        Return False
    End Function

    ' =============================
    ' Helpers: Section title & Table rendering
    ' =============================
    Private Sub DrawSectionTitle(ByVal g As Graphics, ByVal bounds As RectangleF, ByVal title As String, ByVal y As Single)
        Using f As New Font("Segoe UI", 11, FontStyle.Bold)
            g.DrawString(title, f, Brushes.Black, bounds.Left, y)
        End Using
        Dim yLine As Single = y + 18
        g.DrawLine(New Pen(Color.Black, 1.0F), bounds.Left, yLine, bounds.Right, yLine)
    End Sub

    Private Sub DrawTableHeader(ByVal g As Graphics, ByVal bounds As RectangleF, ByVal font As Font, ByVal cols As List(Of ColumnDef), ByVal y As Single, ByVal rowH As Single)
        ' Shaded header
        Dim headerRect As New RectangleF(bounds.Left, y, bounds.Width, rowH)
        Using b As New SolidBrush(Color.FromArgb(230, 230, 230))
            g.FillRectangle(b, headerRect)
        End Using
        g.DrawRectangle(Pens.Black, Rectangle.Round(headerRect))

        Dim colRects As List(Of RectangleF) = BuildColumnRects(bounds, cols, y, rowH)

        For i As Integer = 0 To cols.Count - 1
            Dim r As RectangleF = colRects(i)
            ' Vertical grid line
            g.DrawLine(Pens.Black, r.Left, y, r.Left, y + rowH)

            DrawCellText(g, font, cols(i).Header, r, cols(i).Align, isHeader:=True)
        Next

        ' Right border
        g.DrawLine(Pens.Black, bounds.Right, y, bounds.Right, y + rowH)
        ' Bottom line already included by rectangle, but keep it crisp
        g.DrawLine(Pens.Black, bounds.Left, y + rowH, bounds.Right, y + rowH)
    End Sub

    Private Sub DrawTableRow(ByVal g As Graphics, ByVal bounds As RectangleF, ByVal font As Font, ByVal cols As List(Of ColumnDef), ByVal cells As String(), ByVal y As Single, ByVal rowH As Single, ByVal zebra As Boolean)
        Dim rowRect As New RectangleF(bounds.Left, y, bounds.Width, rowH)

        If zebra Then
            Using b As New SolidBrush(Color.FromArgb(248, 248, 248))
                g.FillRectangle(b, rowRect)
            End Using
        End If

        Dim colRects As List(Of RectangleF) = BuildColumnRects(bounds, cols, y, rowH)

        ' Top line
        g.DrawLine(Pens.Black, bounds.Left, y, bounds.Right, y)

        For i As Integer = 0 To cols.Count - 1
            Dim r As RectangleF = colRects(i)

            ' Vertical grid line
            g.DrawLine(Pens.Black, r.Left, y, r.Left, y + rowH)

            Dim text As String = ""
            If i < cells.Length Then text = SafeStr(cells(i))

            DrawCellText(g, font, text, r, cols(i).Align, isHeader:=False)
        Next

        ' Right border
        g.DrawLine(Pens.Black, bounds.Right, y, bounds.Right, y + rowH)
    End Sub

    Private Function BuildColumnRects(ByVal bounds As RectangleF, ByVal cols As List(Of ColumnDef), ByVal y As Single, ByVal h As Single) As List(Of RectangleF)
        Dim rects As New List(Of RectangleF)()
        Dim curX As Single = bounds.Left

        For Each c As ColumnDef In cols
            Dim w As Single = bounds.Width * c.WidthPct
            rects.Add(New RectangleF(curX, y, w, h))
            curX += w
        Next

        ' Koreksi kecil agar kolom terakhir pas sampai bounds.Right (menghindari gap float)
        If rects.Count > 0 Then
            Dim lastIdx As Integer = rects.Count - 1
            Dim last As RectangleF = rects(lastIdx)
            Dim rightEdge As Single = bounds.Right
            rects(lastIdx) = New RectangleF(last.X, last.Y, rightEdge - last.X, last.Height)
        End If

        Return rects
    End Function

    Private Sub DrawCellText(ByVal g As Graphics, ByVal font As Font, ByVal text As String, ByVal rect As RectangleF, ByVal align As ColAlign, ByVal isHeader As Boolean)
        Dim padL As Single = 4
        Dim padR As Single = 4

        Dim fmt As New StringFormat() With {
            .LineAlignment = StringAlignment.Center,
            .FormatFlags = StringFormatFlags.NoWrap
        }

        Select Case align
            Case ColAlign.Left
                fmt.Alignment = StringAlignment.Near
            Case ColAlign.Center
                fmt.Alignment = StringAlignment.Center
            Case ColAlign.Right
                fmt.Alignment = StringAlignment.Far
        End Select

        Dim maxWidth As Single = rect.Width - (padL + padR)
        Dim clipped As String = ClipTextToWidth(g, font, text, maxWidth)

        Dim drawRect As New RectangleF(rect.X + padL, rect.Y, rect.Width - (padL + padR), rect.Height)

        g.DrawString(clipped, font, Brushes.Black, drawRect, fmt)
    End Sub

    Private Function ClipTextToWidth(ByVal g As Graphics, ByVal font As Font, ByVal text As String, ByVal maxWidth As Single) As String
        If String.IsNullOrEmpty(text) Then Return ""

        If g.MeasureString(text, font).Width <= maxWidth Then
            Return text
        End If

        Dim ellipsis As String = "..."
        Dim maxLen As Integer = text.Length

        Do While maxLen > 0
            Dim candidate As String = text.Substring(0, maxLen) & ellipsis
            If g.MeasureString(candidate, font).Width <= maxWidth Then
                Return candidate
            End If
            maxLen -= 1
        Loop

        Return ellipsis
    End Function

    Private Function SafeStr(ByVal s As String) As String
        If s Is Nothing Then Return ""
        Return s.Trim()
    End Function

End Module
