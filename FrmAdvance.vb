Public Class FrmAdvance

    Private Sub GetJiyuPasswd_Click(sender As Object, e As EventArgs) Handles GetJiyuPasswd.Click
        Log += Date.Now + " GetJiyuPasswd.Click" + vbCrLf
        Dim beforDT = Date.Now '计时
        Dim JiyuPasswd
        ''' 测试计时用
        'Using getUrl As New Net.WebClient()
        'Dim data As Byte() = getUrl.DownloadData("https://drive.cookie987.tk/public/CloudClassUtility/notice.rtf")
        'End Using
        '''
        TextBoxOutput.Text = TextBoxOutput.Text + vbCrLf + Date.Now + " " + "1>---已启动任务: 读取极域密码 ---" + vbCrLf
        JiyuPasswd = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\TopDomain\e-learning Class Standard\1.00\", "UninstallPasswd", Nothing)
        If JiyuPasswd = Nothing Then
            TextBoxOutput.Text = TextBoxOutput.Text + Date.Now + " " + "1>读取失败, 请检查是否有管理员权限或极域是否安装." + vbCrLf + Date.Now + "=== 任务: 成功 0 个, 失败 1 个 ===" + vbCrLf
        ElseIf JiyuPasswd = "passwd[123456]" Then
            TextBoxOutput.Text = TextBoxOutput.Text + Date.Now + " " + "1>警告: 读取到的密码为 123456 ,可能为假密码. 如果解锁失败, 可尝试使用超级密码: mythware_super_password" + vbCrLf + "1>读取到的密码 ([ ]内即密码): " + JiyuPasswd + vbCrLf + "=== 任务: 成功 1 个, 失败 0 个 ===" + vbCrLf
        Else
            TextBoxOutput.Text = TextBoxOutput.Text + Date.Now + " " + "1>读取到的密码 ([ ]内即密码): " + JiyuPasswd + vbCrLf + Date.Now + "=== 任务: 成功 1 个, 失败 0 个 ===" + vbCrLf
        End If
        Dim afterDT = Date.Now '计时
        Dim UseageTime = CStr(DateDiff(DateInterval.Second, beforDT, afterDT))
        TextBoxOutput.Text = TextBoxOutput.Text + Date.Now + " " + "用时: " + UseageTime + "s" + vbCrLf
        Log += Date.Now + vbCrLf + TextBoxOutput.Text + vbCrLf
    End Sub

    Private Sub FrmAdvance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log += Date.Now + " FrmAdvance.Load" + vbCrLf
        TextBoxOutput.Text = Date.Now + " " + "当前版本: " + LocalVersion + vbCrLf
    End Sub

    Private Sub BtnUniJiyuUsbDriver_Click(sender As Object, e As EventArgs) Handles BtnUniJiyuUsbDriver.Click
        Log += Date.Now + " BtnUniJiyuUsbDriver.Click" + vbCrLf
        TextBoxOutput.Text = TextBoxOutput.Text + Date.Now + " " + "1>---已启动任务: 卸载极域驱动 ---" + vbCrLf
        TextBoxOutput.Text = TextBoxOutput.Text + Date.Now + " " + "1>Tips: 如果未生效,请尝试使用管理员权限运行" + vbCrLf
        TextBoxOutput.Text = TextBoxOutput.Text + Date.Now + " " + "1>执行 sc stop TDFileFilter" + vbCrLf
        Shell("sc stop TDFileFilter", vbHide)
        TextBoxOutput.Text = TextBoxOutput.Text + Date.Now + " " + "1>执行 sc delete TDFileFilter" + vbCrLf
        Shell("sc delete TDFileFilter", vbHide)
        TextBoxOutput.Text = TextBoxOutput.Text + Date.Now + " " + "1>完成" + vbCrLf + Date.Now + " " + "=== 任务: 成功 1 个, 失败 0 个 ===" + vbCrLf
        Log += TextBoxOutput.Text
    End Sub

    Private Sub BtnUdpAttack_Click(sender As Object, e As EventArgs) Handles BtnUdpAttack.Click
        FrmWait.MdiParent = Form1
        FrmWait.Show()
        Log += Date.Now + " BtnUdpAttack.Click" + vbCrLf
        Log += Date.Now + " Start unzip UdpAttack.exe" + vbCrLf
        My.Computer.FileSystem.CreateDirectory("\ProgramData\CloudClassUtility\")
        My.Computer.FileSystem.DeleteFile("\ProgramData\CloudClassUtility\UdpAttack.exe")
        My.Computer.FileSystem.WriteAllBytes("\ProgramData\CloudClassUtility\UdpAttack.exe", My.Resources.UdpAttack, True)
        Log += Date.Now + " Done" + vbCrLf
        FrmWait.Hide()
        FrmUdpAttack.MdiParent = Form1
        FrmUdpAttack.Show()
    End Sub
End Class