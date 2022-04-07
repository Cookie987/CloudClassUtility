Public Class FrmUdpAttack
    Private Sub FrmUdpAttack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbxOutput.Text = Date.Now + " 核心版本: 1.4" + vbCrLf
        TbxOutput.Text += Date.Now + " 本功能原理由 ht0Ruial 大佬提供" + vbCrLf
    End Sub

    Private Sub SendText_Click(sender As Object, e As EventArgs) Handles SendText.Click
        Log += Date.Now + " SendText.Click"
        '一添加判断就会提示异常
        'If TbxIPAddress.Text = "" Then
        '    TbxOutput.Text += Date.Now + "IP地址不能为空!" + vbCrLf
        'ElseIf TbxPort.Text = "" Then
        '    TbxOutput.Text += Date.Now + "端口地址不能为空!" + vbCrLf
        'ElseIf TbxSendText.Text = "" & TbxCommand.Text = "" Then
        '    TbxOutput.Text += Date.Now + "请输入内容!" + vbCrLf
        'Else
        TbxOutput.Text += Date.Now + vbCrLf +
                runCmd("\ProgramData\CloudClassUtility\UdpAttack.exe" + " " +
                "-ip" + " " + TbxIPAddress.Text + " " +
                "-p" + " " + TbxPort.Text + " " +
                "-msg" + " " + TbxSendText.Text)
        'End If
    End Sub

    Private Sub BtnSendCommand_Click(sender As Object, e As EventArgs) Handles BtnSendCommand.Click
        Log += Date.Now + " BtnSendCommand.Click"
        '一添加判断就会提示异常
        'If TbxIPAddress.Text = "" Then
        '    TbxOutput.Text += Date.Now + "IP地址不能为空!" + vbCrLf
        'ElseIf TbxPort.Text = "" Then
        '    TbxOutput.Text += Date.Now + "端口地址不能为空!" + vbCrLf
        'ElseIf TbxSendText.Text = "" & TbxCommand.Text = "" Then
        '    TbxOutput.Text += Date.Now + "请输入内容!" + vbCrLf
        'Else
        TbxOutput.Text += Date.Now + vbCrLf +
                runCmd("\ProgramData\CloudClassUtility\UdpAttack.exe" + " " +
                "-ip" + " " + TbxIPAddress.Text + " " +
                "-p" + " " + TbxPort.Text + " " +
                "-c" + " " + TbxCommand.Text)
        'End If
    End Sub
End Class