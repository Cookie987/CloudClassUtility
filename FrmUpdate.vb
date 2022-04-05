Public Class FrmUpdate
    Private Sub FrmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmWait.MdiParent = Form1
        FrmWait.Show()
        Using getUrl As New Net.WebClient()
            Dim data As Byte() = getUrl.DownloadData("https://drive.cookie987.tk/public/CloudClassUtility/notice.rtf")
            Dim content As String = System.Text.Encoding.Default.GetString(data)
            RichTextBox1.Rtf = content
            data = getUrl.DownloadData("https://drive.cookie987.tk/public/CloudClassUtility/version.txt")
            content = System.Text.Encoding.Default.GetString(data)
            TextBox1.Text = "云端版本: " + content + vbCrLf + "本地版本: " + localVersion
            FrmWait.Hide()
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmWait.MdiParent = Form1
        FrmWait.Show()
        Using getUrl As New Net.WebClient()
            Dim data As Byte() = getUrl.DownloadData("https://drive.cookie987.tk/public/CloudClassUtility/notice.rtf")
            Dim content As String = System.Text.Encoding.Default.GetString(data)
            RichTextBox1.Rtf = content
            data = getUrl.DownloadData("https://drive.cookie987.tk/public/CloudClassUtility/version.txt")
            content = System.Text.Encoding.Default.GetString(data)
            TextBox1.Text = "云端版本: " + content + vbCrLf + "本地版本: " + localVersion
            FrmWait.Hide()
        End Using
    End Sub
End Class
