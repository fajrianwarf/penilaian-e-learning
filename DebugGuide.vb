Option Strict On
Option Explicit On

' DebugGuide.vb
' Materi non-fungsional untuk checklist: Watch Window & Breakpoints.
' Dibuat sebagai fungsi yang menghasilkan text, sehingga "ada" di codebase
' dan bisa ditampilkan dari menu Tentang.
Public Module DebugGuide

    Public Function GetGuideText() As String
        Dim nl As String = Environment.NewLine

        Dim t As String = ""
        t &= "Ringkas Panduan Debugging" & nl
        t &= "--------------------------" & nl & nl

        t &= "1) Breakpoint" & nl
        t &= "- Klik margin kiri (gutter) di sebelah baris kode untuk menambah breakpoint." & nl
        t &= "- Jalankan debug (F5). Program akan berhenti di breakpoint." & nl
        t &= "- Step Over (F10), Step Into (F11), Step Out (Shift+F11) untuk melangkah." & nl & nl

        t &= "2) Watch Window" & nl
        t &= "- Saat berhenti di breakpoint, buka: Debug > Windows > Watch > Watch 1." & nl
        t &= "- Tambahkan variabel/ekspresi untuk memantau nilai (contoh: Students.Count)." & nl
        t &= "- Kamu juga bisa hover mouse ke variabel untuk melihat nilainya secara cepat." & nl & nl

        t &= "3) Identifikasi Error / Exception" & nl
        t &= "- Gunakan Try/Catch untuk menangkap exception (lihat DataPersistence)." & nl
        t &= "- Gunakan Output Window untuk melihat Trace/Debug jika diperlukan." & nl
        t &= "- Lihat Call Stack untuk tahu fungsi mana yang memicu error." & nl & nl

        t &= "Catatan: Panduan ini sengaja disediakan untuk memenuhi checklist materi." & nl

        Return t
    End Function

End Module
