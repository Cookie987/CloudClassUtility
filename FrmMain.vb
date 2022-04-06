Public Class Form1
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        localVersion = "3.400 (03400)"
        Delay = 200
        Log = System.DateTime.Now + " Program Started" + vbCrLf + System.DateTime.Now + " Version: " + LocalVersion + vbCrLf + System.DateTime.Now + " Start init" + vbCrLf
        FrmSetting.MdiParent = Me
        FrmSetting.Show()
        FrmAdvance.MdiParent = Me
        FrmAdvance.Show()
        FrmMaster.MdiParent = Me
        FrmMaster.Show()
        Log = Log + System.DateTime.Now + " Init done" + vbCrLf
    End Sub

    Private Sub 检测更新UToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 检测更新UToolStripMenuItem.Click
        Log = Log + System.DateTime.Now + " 检测更新UToolStripMenuItem.Click" + vbCrLf
        FrmUpdate.MdiParent = Me
        FrmUpdate.Show()
    End Sub

    Private Sub 关于CloudClassUtilityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于CloudClassUtilityToolStripMenuItem.Click
        Log = Log + System.DateTime.Now + " 关于CloudClassUtilityToolStripMenuItem.Click" + vbCrLf
        FrmAbout.MdiParent = Me
        FrmAbout.Show()
    End Sub

    Private Sub 主窗口MToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 主窗口MToolStripMenuItem.Click
        Log = Log + System.DateTime.Now + " 主窗口MToolStripMenuItem.Click" + vbCrLf
        FrmMaster.MdiParent = Me
        FrmMaster.Show()
    End Sub

    Private Sub 设置SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 设置SToolStripMenuItem.Click
        Log = Log + System.DateTime.Now + " 设置SToolStripMenuItem.Click" + vbCrLf
        FrmSetting.MdiParent = Me
        FrmSetting.Show()
    End Sub

    Private Sub 高级AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 高级AToolStripMenuItem.Click
        Log = Log + System.DateTime.Now + " 高级AToolStripMenuItem.Click" + vbCrLf
        FrmAdvance.MdiParent = Me
        FrmAdvance.Show()
    End Sub

    Private Sub 日志LToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 日志LToolStripMenuItem.Click
        Log = Log + System.DateTime.Now + " 日志LToolStripMenuItem.Click" + vbCrLf
        FrmLog.MdiParent = Me
        FrmLog.Show()
    End Sub
End Class
