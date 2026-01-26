Option Strict On
Option Explicit On

Imports System.Text

' CsvHelper.vb
' Helper CSV sederhana (mendukung tanda kutip).
' Di dalamnya sengaja dipakai:
' - String methods: Trim, Replace, Contains, Substring
' - Array (String())
' - Collection: List(Of String)
' - Do loop / While loop
' - Function, parameter, ByVal/ByRef, passing arrays
Public Module CsvHelper

    Public Function ToCsvLine(ByVal fields As String()) As String
        Dim sb As New StringBuilder()

        For i As Integer = 0 To fields.Length - 1
            If i > 0 Then sb.Append(",")
            sb.Append(EscapeField(fields(i)))
        Next

        Return sb.ToString()
    End Function

    Private Function EscapeField(ByVal raw As String) As String
        If raw Is Nothing Then raw = ""

        Dim v As String = raw.Replace(vbCrLf, " ").Replace(vbLf, " ").Trim()

        ' Jika berisi koma atau kutip ganda, bungkus dengan quotes.
        ' Catatan VB: kutip ganda di string literal ditulis """".
        If v.Contains(",") OrElse v.Contains("""") Then
            v = """" & v.Replace("""", """""") & """"
        End If

        Return v
    End Function

    Public Function ParseCsvLine(ByVal line As String) As String()
        If line Is Nothing Then Return Array.Empty(Of String)()

        Dim result As New List(Of String)()
        Dim sb As New StringBuilder()
        Dim inQuotes As Boolean = False
        Dim i As Integer = 0

        ' Do While loop (contoh do/while).
        Do While i < line.Length
            Dim ch As Char = line(i)

            If inQuotes Then
                If ch = """"c Then
                    ' Dua quote berurutan berarti escape.
                    Dim nextIsQuote As Boolean = (i + 1 < line.Length AndAlso line(i + 1) = """"c)
                    If nextIsQuote Then
                        sb.Append(""""c)
                        i += 1
                    Else
                        inQuotes = False
                    End If
                Else
                    sb.Append(ch)
                End If
            Else
                If ch = """"c Then
                    inQuotes = True
                ElseIf ch = ","c Then
                    result.Add(sb.ToString().Trim())
                    sb.Clear()
                Else
                    sb.Append(ch)
                End If
            End If

            i += 1
        Loop

        result.Add(sb.ToString().Trim())
        Return result.ToArray()
    End Function

    Public Function IsSkippableLine(ByVal line As String) As Boolean
        If String.IsNullOrWhiteSpace(line) Then Return True

        Dim trimmed As String = line.Trim()
        ' String methods: StartsWith/Contains.
        If trimmed.StartsWith("#") OrElse trimmed.StartsWith("//") Then Return True
        If trimmed.Contains(";--") Then Return True

        Return False
    End Function

    Public Function TryGetBoolean(ByVal raw As String, ByRef value As Boolean) As Boolean
        raw = If(raw, "").Trim()

        Select Case raw.ToLowerInvariant()
            Case "true", "1", "ya", "yes", "aktif"
                value = True
                Return True
            Case "false", "0", "tidak", "no", "nonaktif"
                value = False
                Return True
            Case Else
                value = False
                Return False
        End Select
    End Function

    Public Function TryGetInteger(ByVal raw As String, ByRef value As Integer) As Boolean
        raw = If(raw, "").Trim()
        Return Integer.TryParse(raw, value)
    End Function

    Public Function TryGetDouble(ByVal raw As String, ByRef value As Double) As Boolean
        raw = If(raw, "").Trim()
        Return Double.TryParse(raw, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, value) OrElse
               Double.TryParse(raw, value)
    End Function

    Public Function TryGetDate(ByVal raw As String, ByRef value As Date) As Boolean
        raw = If(raw, "").Trim()

        ' Terima beberapa format tanggal (contoh select case + date parsing).
        Dim formats As String() = {
            "yyyy-MM-dd",
            "yyyy-MM-ddTHH:mm:ss",
            "dd/MM/yyyy",
            "d/M/yyyy",
            "M/d/yyyy",
            "MM/dd/yyyy"
        }

        For Each fmt In formats
            If Date.TryParseExact(raw, fmt, Globalization.CultureInfo.InvariantCulture,
                                  Globalization.DateTimeStyles.None, value) Then
                Return True
            End If
        Next

        Return Date.TryParse(raw, value)
    End Function

    ' === Compatibility wrappers (dipakai oleh DataPersistence.vb) ===
    Public Function TryParseBoolean(ByVal raw As String, ByRef value As Boolean) As Boolean
        Return TryGetBoolean(raw, value)
    End Function

    Public Function TryParseDate(ByVal raw As String, ByRef value As Date) As Boolean
        Return TryGetDate(raw, value)
    End Function

    Public Function TryParseDouble(ByVal raw As String, ByRef value As Double) As Boolean
        Return TryGetDouble(raw, value)
    End Function


End Module
