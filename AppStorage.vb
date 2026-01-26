Option Strict On
Option Explicit On

Imports System.IO

Public Module AppStorage

    ' Folder app di Documents user (My namespace)
    Public ReadOnly Property AppRootDir As String
        Get
            Dim doc As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            Return Path.Combine(doc, "penilaian-e-learning")
        End Get
    End Property

    Public ReadOnly Property DataDir As String
        Get
            Return Path.Combine(AppRootDir, "data")
        End Get
    End Property

    Public ReadOnly Property ExportDir As String
        Get
            Return Path.Combine(AppRootDir, "export")
        End Get
    End Property

    ' Pastikan semua folder ada
    Public Sub EnsureAppDirectories()
        Try
            If Not Directory.Exists(AppRootDir) Then Directory.CreateDirectory(AppRootDir)
            If Not Directory.Exists(DataDir) Then Directory.CreateDirectory(DataDir)
            If Not Directory.Exists(ExportDir) Then Directory.CreateDirectory(ExportDir)
        Catch ex As Exception
            ' Handling exceptions: tampilkan error jelas
            Throw New IOException("Gagal membuat direktori aplikasi: " & ex.Message, ex)
        End Try
    End Sub

    ' Buat folder export timestamp, misal: export\20260125_101530
    Public Function CreateExportStampFolder() As String
        EnsureAppDirectories()

        Dim stamp As String = Date.Now.ToString("yyyyMMdd_HHmmss")
        Dim folder As String = Path.Combine(ExportDir, stamp)

        If Not Directory.Exists(folder) Then
            Directory.CreateDirectory(folder)
        End If

        Return folder
    End Function

    ' Cari folder export terbaru (berdasarkan LastWriteTime)
    Public Function TryGetLatestExportFolder(ByRef latestFolder As String) As Boolean
        EnsureAppDirectories()

        latestFolder = Nothing

        If Not Directory.Exists(ExportDir) Then Return False

        Dim dirs As String() = Directory.GetDirectories(ExportDir)
        If dirs Is Nothing OrElse dirs.Length = 0 Then Return False

        Dim latestTime As DateTime = DateTime.MinValue
        Dim best As String = Nothing

        For Each d As String In dirs
            Dim t As DateTime = Directory.GetLastWriteTime(d)
            If t > latestTime Then
                latestTime = t
                best = d
            End If
        Next

        If String.IsNullOrWhiteSpace(best) Then Return False

        latestFolder = best
        Return True
    End Function

    ' === Compatibility methods (dipakai kode lama: DataPersistence.vb / FormMain.vb) ===

    ' Pastikan subfolder ada, return full path-nya
    Public Function EnsureSubDirectory(ByVal parentDir As String, ByVal subDirName As String) As String
        If String.IsNullOrWhiteSpace(parentDir) Then
            Throw New ArgumentException("parentDir tidak boleh kosong.")
        End If

        If String.IsNullOrWhiteSpace(subDirName) Then
            Throw New ArgumentException("subDirName tidak boleh kosong.")
        End If

        If Not IO.Directory.Exists(parentDir) Then
            IO.Directory.CreateDirectory(parentDir)
        End If

        Dim full As String = IO.Path.Combine(parentDir, subDirName)

        If Not IO.Directory.Exists(full) Then
            IO.Directory.CreateDirectory(full)
        End If

        Return full
    End Function

    ' Folder default untuk data aplikasi (dipakai saat Save/Load)
    Public Function GetDefaultDataDirectory() As String
        EnsureAppDirectories()
        Return DataDir
    End Function


End Module
