Public Class FrmUdpAttack
    Private Sub FrmUdpAttack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbxOutput.Text = Date.Now + " 核心版本: 1.4" + vbCrLf
        TbxOutput.Text += Date.Now + " 本功能原理由 ht0Ruial 大佬提供" + vbCrLf
    End Sub

    Private Sub SendText_Click(sender As Object, e As EventArgs) Handles SendText.Click
        Log += Date.Now + " SendText.Click" + vbCrLf
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
                        "-msg" + " " + TbxSendText.Text)
        TbxOutput.Text += Date.Now + vbCrLf + runResult
        Log += Date.Now + " Done. Result:" + runResult
        'End If
    End Sub

    Private Sub BtnSendCommand_Click(sender As Object, e As EventArgs) Handles BtnSendCommand.Click
        Log += Date.Now + " BtnSendCommand.Click" + vbCrLf
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
            "-c" + " " + "" & Chr(34) + TbxCommand.Text & Chr(34) + vbCrLf
        Dim runResult = RunCmd("\ProgramData\CloudClassUtility\UdpAttack.exe" + " " +
                        "-ip" + " " + TbxIPAddress.Text + " " +
                        "-p" + " " + TbxPort.Text + " " +
                        "-c" + " " + TbxCommand.Text)
        TbxOutput.Text += Date.Now + vbCrLf + runResult
        Log += Date.Now + " Done. Result:" + runResult
        'End If
    End Sub
End Class