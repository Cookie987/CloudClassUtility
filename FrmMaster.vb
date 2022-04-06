Public Class FrmMaster
    Private Sub FrmMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log = Log + System.DateTime.Now + " FrmMaster.Load" + vbCrLf
        btnStart.Enabled = True
        btnStop.Enabled = False
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Log = Log + System.DateTime.Now + " btnStart.Click" + vbCrLf
        Timer1.Interval = Delay
        Timer2.Enabled = True
        Timer1.Enabled = True
        btnStop.Enabled = True
        btnStart.Enabled = False
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Log = Log + System.DateTime.Now + " btnStop.Click" + vbCrLf
        Timer2.Enabled = False
        Timer1.Enabled = False
        ProgressBar1.Value = 0
        btnStart.Enabled = True
        btnStop.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If frmSetting.cbxJiyu.Checked = True Then
            Shell("taskkill /F /T /IM StudentMain.exe", vbHide)
        ElseIf frmSetting.cbxRcc.Checked = True Then
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

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value = 100 Then
            ProgressBar1.Value = 0
        End If
        If delay / 100 <= 100 Then
            ProgressBar1.Value = ProgressBar1.Value + delay / 100
        End If

    End Sub
End Class