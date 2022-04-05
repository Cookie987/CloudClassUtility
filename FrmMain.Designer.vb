<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.窗口WToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.主窗口MToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.设置SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.检测更新UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于CloudClassUtilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.窗口WToolStripMenuItem, Me.帮助HToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.窗口WToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(781, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '窗口WToolStripMenuItem
        '
        Me.窗口WToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.主窗口MToolStripMenuItem, Me.设置SToolStripMenuItem})
        Me.窗口WToolStripMenuItem.Name = "窗口WToolStripMenuItem"
        Me.窗口WToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.窗口WToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.窗口WToolStripMenuItem.Text = "窗口(&W)"
        '
        '主窗口MToolStripMenuItem
        '
        Me.主窗口MToolStripMenuItem.Name = "主窗口MToolStripMenuItem"
        Me.主窗口MToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.主窗口MToolStripMenuItem.Text = "主窗口(&M)"
        '
        '设置SToolStripMenuItem
        '
        Me.设置SToolStripMenuItem.Name = "设置SToolStripMenuItem"
        Me.设置SToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.设置SToolStripMenuItem.Text = "设置(&S)"
        '
        '帮助HToolStripMenuItem
        '
        Me.帮助HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.检测更新UToolStripMenuItem, Me.关于CloudClassUtilityToolStripMenuItem})
        Me.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem"
        Me.帮助HToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.帮助HToolStripMenuItem.Text = "帮助(&H)"
        '
        '检测更新UToolStripMenuItem
        '
        Me.检测更新UToolStripMenuItem.Name = "检测更新UToolStripMenuItem"
        Me.检测更新UToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.检测更新UToolStripMenuItem.Text = "检测更新(&U)"
        '
        '关于CloudClassUtilityToolStripMenuItem
        '
        Me.关于CloudClassUtilityToolStripMenuItem.Name = "关于CloudClassUtilityToolStripMenuItem"
        Me.关于CloudClassUtilityToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.关于CloudClassUtilityToolStripMenuItem.Text = "关于 CloudClassUtility"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(781, 421)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "CloudClassUtility"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 窗口WToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助HToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 检测更新UToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于CloudClassUtilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 主窗口MToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 设置SToolStripMenuItem As ToolStripMenuItem
End Class
