Public Class FrmSetting
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        TextBox1.Text = TrackBar1.Value
        delay = TrackBar1.Value

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbxCustom.TextChanged
        cbxCustom.Checked = True
        If tbxCustom.Text = "" Then
            cbxCustom.Checked = False
        End If
    End Sub
End Class