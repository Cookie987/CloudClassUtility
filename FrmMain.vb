Public Class Form1
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        localVersion = "3.400 (03400)"
        delay = 200
        FrmSetting.MdiParent = Me
        FrmSetting.Show()
        FrmMaster.MdiParent = Me
        FrmMaster.Show()
    End Sub

    Private Sub 检测更新UToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 检测更新UToolStripMenuItem.Click
        FrmUpdate.MdiParent = Me
        FrmUpdate.Show()
    End Sub

    Private Sub 关于CloudClassUtilityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于CloudClassUtilityToolStripMenuItem.Click
        FrmAbout.MdiParent = Me
        FrmAbout.Show()
    End Sub

    Private Sub 主窗口MToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 主窗口MToolStripMenuItem.Click
        FrmMaster.MdiParent = Me
        FrmMaster.Show()
    End Sub

    Private Sub 设置SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 设置SToolStripMenuItem.Click
        FrmSetting.MdiParent = Me
        FrmSetting.Show()
    End Sub
End Class
