' Models.vb

' ==== DATA SISWA ====
Public Class Student
    Public Property NIS As String
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

' ==== PENYIMPANAN DATA DI MEMORI ====
Module AppData
    Public Students As New List(Of Student)
    Public Courses As New List(Of Course)   ' <<-- tambah ini
End Module
