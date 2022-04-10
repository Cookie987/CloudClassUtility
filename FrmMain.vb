Public Class Form1
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        localVersion = "3.400 (03400)"
        Delay = 200
        Log = Date.Now + " Program Started" + vbCrLf + Date.Now + " Version: " + LocalVersion + vbCrLf + Date.Now + " Start init" + vbCrLf
        FrmSetting.MdiParent = Me
        FrmSetting.Show()
        FrmAdvance.MdiParent = Me
        FrmAdvance.Show()
        FrmMaster.MdiParent = Me
        FrmMaster.Show()
        Log += Date.Now + " Init done" + vbCrLf
    End Sub

    Private Sub 检测更新UToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 检测更新UToolStripMenuItem1.Click
        Log += Date.Now + " 检测更新UToolStripMenuItem.Click" + vbCrLf
        FrmUpdate.MdiParent = Me
        FrmUpdate.Show()
    End Sub

    Private Sub 关于CloudClassUtilityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于CloudClassUtilityToolStripMenuItem1.Click
        Log += Date.Now + " 关于CloudClassUtilityToolStripMenuItem.Click" + vbCrLf
        FrmAbout.MdiParent = Me
        FrmAbout.Show()
    End Sub

    Private Sub 主窗口MToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 主窗口MToolStripMenuItem1.Click
        Log += Date.Now + " 主窗口MToolStripMenuItem.Click" + vbCrLf
        FrmMaster.MdiParent = Me
        FrmMaster.Show()
    End Sub

    Private Sub 设置SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 设置SToolStripMenuItem1.Click
        Log += Date.Now + " 设置SToolStripMenuItem.Click" + vbCrLf
        FrmSetting.MdiParent = Me
        FrmSetting.Show()
    End Sub

    Private Sub 高级AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 高级AToolStripMenuItem1.Click
        Log += Date.Now + " 高级AToolStripMenuItem.Click" + vbCrLf
        FrmAdvance.MdiParent = Me
        FrmAdvance.Show()
    End Sub

    Private Sub 查看日志VToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 查看日志VToolStripMenuItem1.Click
        Log += Date.Now + " 查看日志VToolStripMenuItem.Click" + vbCrLf
        FrmLog.MdiParent = Me
        FrmLog.Show()
    End Sub

    Private Sub 导出日志EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 导出日志ToolStripMenuItem.Click
        Log += Date.Now + " 导出日志SToolStripMenuItem.Click" + vbCrLf
        SaveFileDialog1.Filter = "日志文件 (*.log)|*.log|所有文件 (*.*)|*.*"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Log += Date.Now + " Log writed" + vbCrLf
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, Log, True)
        End If
    End Sub

    Private Sub 清除日志CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 清除日志CToolStripMenuItem1.Click
        Log += Date.Now + " 清除日志CToolStripMenuItem.Click" + vbCrLf
        Log = Nothing
    End Sub

    Private Sub 测试日志ZToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Log += Date.Now + " 测试日志ZToolStripMenuItem.Click" + vbCrLf
        'Do
        '    Log += Date.Now + vbCrLf
        'Loop
        'Log += Date.Now + vbCrLf
    End Sub
End Class
