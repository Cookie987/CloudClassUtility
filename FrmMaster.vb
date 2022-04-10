Public Class FrmMaster
    Private Sub FrmMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log += Date.Now + " FrmMaster.Load" + vbCrLf
        btnStart.Enabled = True
        btnStop.Enabled = False
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Log += Date.Now + " btnStart.Click" + vbCrLf
        Timer1.Interval = Delay
        Timer1.Enabled = True
        btnStop.Enabled = True
        btnStart.Enabled = False
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Log += Date.Now + " btnStop.Click" + vbCrLf
        Timer1.Enabled = False
        btnStart.Enabled = True
        btnStop.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If frmSetting.cbxJiyu.Checked = True Then
            Shell("taskkill /F /T /IM StudentMain.exe", vbHide)
        ElseIf frmSetting.CbxRcc.Checked = True Then
            Shell("taskkill /F /T /IM ClassManagerApp.exe", vbHide)
            Shell("taskkill /F /T /IM RJRemoteserver.exe", vbHide)
            Shell("taskkill /F /T /IM RjUsbController.exe", vbHide)
        ElseIf frmSetting.cbxRedSpider.Checked = True Then
            Shell("taskkill /F /T /IM REDAGENT.exe", vbHide)
            Shell("taskkill /F /T /IM checkrs.exe", vbHide)
            Shell("taskkill /F /T /IM rscheck.exe", vbHide)
        ElseIf frmSetting.cbxCustom.Checked = True Then
            Shell("taskkill /F /T /IM" + " " + frmSetting.tbxCustom.Text, vbHide)
        End If
    End Sub
End Class