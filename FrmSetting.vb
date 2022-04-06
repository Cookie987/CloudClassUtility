Public Class FrmSetting
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Log = Log + System.DateTime.Now + " TrackBar1.Scroll" + vbCrLf
        TextBox1.Text = TrackBar1.Value
        Delay = TrackBar1.Value
        Log = Log + System.DateTime.Now + " Delay changed to " + CStr(Delay) + vbCrLf
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbxCustom.TextChanged
        cbxCustom.Checked = True
        Log = Log + System.DateTime.Now + " tbxCustom.TextChanged" + vbCrLf
        Log = Log + System.DateTime.Now + " tbxCustom Changed to " + tbxCustom.Text + vbCrLf
        If tbxCustom.Text = "" Then
            cbxCustom.Checked = False
        End If
    End Sub

    Private Sub FrmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log = Log + System.DateTime.Now + " FrmSetting.Load" + vbCrLf
    End Sub
End Class