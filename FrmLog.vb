Public Class FrmLog
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = Log
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Log = Log + System.DateTime.Now + " Button1.Click" + vbCrLf
        SaveFileDialog1.Filter = "日志文件 (*.log)|*.log|所有文件 (*.*)|*.*"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Log = Log + System.DateTime.Now + " Log writed" + vbCrLf
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, True)
        End If
    End Sub
End Class