Public Class FormUtama
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Now.Hour >= 12) Then
            LabelWaktu.Text = "Waktu Sudah Siang"
        Else
            LabelWaktu.Text = "Waktu Belum Siang"
        End If
    End Sub
End Class