Public Class FrmAdvance

    Private Sub GetJiyuPasswd_Click(sender As Object, e As EventArgs) Handles GetJiyuPasswd.Click
        Log = Log + System.DateTime.Now + " GetJiyuPasswd.Click" + vbCrLf
        Dim beforDT = System.DateTime.Now
        Dim JiyuPasswd
        ''' 测试计时用
        'Using getUrl As New Net.WebClient()
        'Dim data As Byte() = getUrl.DownloadData("https://drive.cookie987.tk/public/CloudClassUtility/notice.rtf")
        'End Using
        '''
        TextBoxOutput.Text = TextBoxOutput.Text + vbCrLf + "1>---已启动任务: 读取极域密码 ---" + vbCrLf
        JiyuPasswd = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\TopDomain\e-learning Class Standard\1.00\", "UninstallPasswd", Nothing)
        If JiyuPasswd = Nothing Then
            TextBoxOutput.Text = TextBoxOutput.Text + "1>读取失败, 请检查是否有管理员权限或极域是否安装." + vbCrLf + "=== 任务: 成功 0 个, 失败 1 个 ===" + vbCrLf
        ElseIf JiyuPasswd = "passwd[123456]" Then
            TextBoxOutput.Text = TextBoxOutput.Text + "1>警告: 读取到的密码为 123456 ,可能为假密码. 如果解锁失败, 可尝试使用超级密码: mythware_super_password" + vbCrLf + "1>读取到的密码 ([ ]内即密码): " + JiyuPasswd + vbCrLf + "=== 任务: 成功 1 个, 失败 0 个 ===" + vbCrLf
        Else
            TextBoxOutput.Text = TextBoxOutput.Text + "1>读取到的密码 ([ ]内即密码): " + JiyuPasswd + vbCrLf + "=== 任务: 成功 1 个, 失败 0 个 ===" + vbCrLf
        End If
        Dim afterDT = System.DateTime.Now
        Dim UseageTime = CStr(DateDiff(DateInterval.Second, beforDT, afterDT))
        TextBoxOutput.Text = TextBoxOutput.Text + "用时: " + UseageTime + "s" + vbCrLf
        Log = Log + System.DateTime.Now + vbCrLf + TextBoxOutput.Text + vbCrLf
    End Sub

    Private Sub FrmAdvance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log = Log + System.DateTime.Now + " FrmAdvance.Load" + vbCrLf
        TextBoxOutput.Text = "当前版本: " + LocalVersion + vbCrLf
    End Sub


End Class