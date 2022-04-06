Public Class FrmWait
    Private Sub FrmWait_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log = Log + System.DateTime.Now + " FrmWait.Load" + vbCrLf
    End Sub
End Class