Public Class FrmUpdate
    Private Sub FrmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log+= Date.Now + " FrmUpdate.Load" + vbCrLf
        FrmWait.MdiParent = Form1
        FrmWait.Show()
        Using getUrl As New Net.WebClient()
            Try
                Log+= Date.Now + " Start check update" + vbCrLf
                Dim data As Byte() = getUrl.DownloadData("https://drive.cookie987.tk/public/CloudClassUtility/notice.rtf")
                Dim content As String = System.Text.Encoding.Default.GetString(data)
                RichTextBox1.Rtf = content
                data = getUrl.DownloadData("https://drive.cookie987.tk/public/CloudClassUtility/version.txt")
                content = System.Text.Encoding.Default.GetString(data)
                TextBox1.Text = "云端版本: " + content + vbCrLf + "本地版本: " + localVersion
            Catch ex As Exception
                FrmWait.Hide()
                Log+= Date.Now + " Error 0x01 Network Problem" + vbCrLf
                MessageBox.Show("错误 0x01 网络无法连接或服务器出现问题" + vbCrLf + "技术信息:" + vbCrLf + "引发的异常:'System.Net.WebException'(位于 System.Net.WebClient.dll 中)", "CloudClassUtility", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            FrmWait.Hide()
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Log+= Date.Now + " FrmUpdate.Load" + vbCrLf
        FrmWait.MdiParent = Form1
        FrmWait.Show()
        Using getUrl As New Net.WebClient()
            Try
                Log+= Date.Now + " Start check update" + vbCrLf
                Dim data As Byte() = getUrl.DownloadData("https://drive.cookie987.tk/public/CloudClassUtility/notice.rtf")
                Dim content As String = System.Text.Encoding.Default.GetString(data)
                RichTextBox1.Rtf = content
                data = getUrl.DownloadData("https://drive.cookie987.tk/public/CloudClassUtility/version.txt")
                content = System.Text.Encoding.Default.GetString(data)
                TextBox1.Text = "云端版本: " + content + vbCrLf + "本地版本: " + LocalVersion
                Log+= Date.Now + " Check update done" + vbCrLf
            Catch ex As Exception
                FrmWait.Hide()
                Log+= Date.Now + " Error 0x01 Network Problem" + vbCrLf
                MessageBox.Show("错误 0x01 网络无法连接或服务器出现问题" + vbCrLf + "技术信息:" + vbCrLf + "引发的异常:'System.Net.WebException'(位于 System.Net.WebClient.dll 中)", "CloudClassUtility", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            FrmWait.Hide()
        End Using
    End Sub
End Class
