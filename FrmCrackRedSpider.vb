Public Class FrmCrackRedSpider
    Private Sub FrmCrackRedSpider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log += DateTime.Now + " Start crack RedSpider" + vbCrLf
        Log += DateTime.Now + " 1.Stop RedSpider..." + vbCrLf
        Shell("taskkill /F /T /IM REDAGENT.exe", vbHide)
        Cbx1.Text = "1.结束进程 (25%)"
        Shell("taskkill /F /T /IM checkrs.exe", vbHide)
        Cbx1.Text = "1.结束进程 (50%)"
        Shell("taskkill /F /T /IM rscheck.exe", vbHide)
        Cbx1.Text = "1.结束进程 (75%)"
        Shell("taskkill /F /T /IM epointer.exe ", vbHide)
        Cbx1.Text = "1.结束进程 (100%)"
        Cbx1.Checked = True
        Pi1.Visible = False
        Log += DateTime.Now + " 2.Replace files..." + vbCrLf
        Cbx2.Text = "2.替换文件 (0%)"
        Pi2.Visible = True
        My.Computer.FileSystem.CreateDirectory("\ProgramData\CloudClassUtility\")
        Try
            My.Computer.FileSystem.DeleteFile("\ProgramData\CloudClassUtility\REDAgent.exe")
        Catch
        End Try
        Cbx2.Text = "2.替换文件 (33%)"
        Try
            My.Computer.FileSystem.WriteAllBytes("C:\3000soft\Red Spider\REDAgent.exe", My.Resources.REDAgent, True)
        Catch
            Cbx2.Text = "2.替换文件 (33%) (失败)"
            Log += DateTime.Now + " Failed" + vbCrLf
        End Try
        Cbx2.Text = "2.替换文件 (66%)"
        Try
            My.Computer.FileSystem.WriteAllBytes("C:\Windows\SysWOW64\redhooks.dll", My.Resources.redhooks, True)
            Cbx2.Text = "2.替换文件 (100%)"
            Cbx2.Checked = True
            Pi2.Visible = False
            Log += DateTime.Now + " 3.Run final step..." + vbCrLf
            Cbx3.Text = "3.完成破解 (0%)"
            Pi3.Visible = True
            Shell("start /d C:\3000soft\Red Spider\REDAgent.exe", vbHide)
            Cbx3.Text = "3.完成破解 (100%)"
            Log += DateTime.Now + " Done" + vbCrLf
            Cbx3.Checked = True
            Pi3.Visible = False
        Catch
            Cbx2.Text = "2.替换文件 (66%) (失败)"
            Log += DateTime.Now + " Failed" + vbCrLf
        End Try
    End Sub
End Class