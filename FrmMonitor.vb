Public Class FrmMonitor
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CheckApplicationIsRun("StudentMain.exe") Then
            JiyuCard.Text2 = "运行中"
            JiyuCard.Text3 = "上次刷新时间: " + DateTime.Now
        Else
            JiyuCard.Text2 = "未运行"
            JiyuCard.Text3 = "上次刷新时间: " + vbCrLf + DateTime.Now
        End If
        If CheckApplicationIsRun("REDAGENT.exe") Then
            RedSpiderCard.Text2 = "运行中"
            RedSpiderCard.Text3 = "上次刷新时间: " + vbCrLf + DateTime.Now
        Else
            RedSpiderCard.Text2 = "未运行"
            RedSpiderCard.Text3 = "上次刷新时间: " + vbCrLf + DateTime.Now
        End If
        If CheckApplicationIsRun("ClassManagerApp.exe") Then
            RccCard.Text2 = "运行中"
            RccCard.Text3 = "上次刷新时间: " + vbCrLf + DateTime.Now
        Else
            RccCard.Text2 = "未运行"
            RccCard.Text3 = "上次刷新时间: " + vbCrLf + DateTime.Now
        End If
    End Sub
End Class