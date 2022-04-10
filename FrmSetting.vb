Public Class FrmSetting

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TbxCustom.TextChanged
        CbxCustom.Checked = True
        Log += Date.Now + " tbxCustom.TextChanged" + vbCrLf
        Log += Date.Now + " tbxCustom Changed to " + TbxCustom.Text + vbCrLf
        If TbxCustom.Text = "" Then
            CbxCustom.Checked = False
        End If
    End Sub

    Private Sub FrmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log += Date.Now + " FrmSetting.Load" + vbCrLf
    End Sub

    Private Sub TrackBar1_ValueChanged() Handles TrackBar1.ValueChanged
        Log += Date.Now + " TrackBar1.Scroll" + vbCrLf
        TextBox1.Text = TrackBar1.Value
        Delay = TrackBar1.Value
        Log += Date.Now + " Delay changed to " + CStr(Delay) + vbCrLf
    End Sub
End Class