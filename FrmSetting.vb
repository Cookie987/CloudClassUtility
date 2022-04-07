Public Class FrmSetting
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Log+= Date.Now + " TrackBar1.Scroll" + vbCrLf
        TextBox1.Text = TrackBar1.Value
        Delay = TrackBar1.Value
        Log+= Date.Now + " Delay changed to " + CStr(Delay) + vbCrLf
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbxCustom.TextChanged
        cbxCustom.Checked = True
        Log+= Date.Now + " tbxCustom.TextChanged" + vbCrLf
        Log+= Date.Now + " tbxCustom Changed to " + tbxCustom.Text + vbCrLf
        If tbxCustom.Text = "" Then
            cbxCustom.Checked = False
        End If
    End Sub

    Private Sub FrmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log+= Date.Now + " FrmSetting.Load" + vbCrLf
    End Sub
End Class