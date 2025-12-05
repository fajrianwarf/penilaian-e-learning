Public Class Student
    Public Property NIS As String
    Public Property Nama As String
    Public Property Kelas As String
    Public Property JenisKelamin As String
    Public Property Aktif As Boolean
    Public Property TanggalDaftar As Date
End Class

Module AppData
    ' "Database" sederhana di memori
    Public Students As New List(Of Student)
End Module
