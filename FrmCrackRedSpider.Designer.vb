<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrackRedSpider
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BigLabel1 = New ReaLTaiizor.Controls.BigLabel()
        Me.MetroLabel1 = New ReaLTaiizor.Controls.MetroLabel()
        Me.Cbx1 = New ReaLTaiizor.Controls.MaterialCheckBox()
        Me.Pi1 = New ReaLTaiizor.Controls.ProgressIndicator()
        Me.Pi2 = New ReaLTaiizor.Controls.ProgressIndicator()
        Me.Cbx2 = New ReaLTaiizor.Controls.MaterialCheckBox()
        Me.Pi3 = New ReaLTaiizor.Controls.ProgressIndicator()
        Me.Cbx3 = New ReaLTaiizor.Controls.MaterialCheckBox()
        Me.SuspendLayout()
        '
        'BigLabel1
        '
        Me.BigLabel1.AutoSize = True
        Me.BigLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BigLabel1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BigLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.BigLabel1.Location = New System.Drawing.Point(12, 9)
        Me.BigLabel1.Name = "BigLabel1"
        Me.BigLabel1.Size = New System.Drawing.Size(268, 32)
        Me.BigLabel1.TabIndex = 0
        Me.BigLabel1.Text = "破解红蜘蛛 v6.2.1160 ..."
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MetroLabel1.IsDerivedStyle = True
        Me.MetroLabel1.Location = New System.Drawing.Point(16, 41)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(100, 23)
        Me.MetroLabel1.Style = ReaLTaiizor.[Enum].Metro.Style.Light
        Me.MetroLabel1.StyleManager = Nothing
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "破解进程"
        Me.MetroLabel1.ThemeAuthor = "Taiizor"
        Me.MetroLabel1.ThemeName = "MetroLight"
        '
        'Cbx1
        '
        Me.Cbx1.AutoSize = True
        Me.Cbx1.Depth = 0
        Me.Cbx1.Enabled = False
        Me.Cbx1.Location = New System.Drawing.Point(88, 75)
        Me.Cbx1.Margin = New System.Windows.Forms.Padding(0)
        Me.Cbx1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Cbx1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.Cbx1.Name = "Cbx1"
        Me.Cbx1.Ripple = True
        Me.Cbx1.Size = New System.Drawing.Size(148, 37)
        Me.Cbx1.TabIndex = 2
        Me.Cbx1.Text = "1.结束进程 (0%)"
        Me.Cbx1.UseVisualStyleBackColor = True
        '
        'Pi1
        '
        Me.Pi1.Location = New System.Drawing.Point(45, 67)
        Me.Pi1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Pi1.Name = "Pi1"
        Me.Pi1.P_AnimationColor = System.Drawing.Color.DimGray
        Me.Pi1.P_AnimationSpeed = 100
        Me.Pi1.P_BaseColor = System.Drawing.Color.DarkGray
        Me.Pi1.Size = New System.Drawing.Size(50, 50)
        Me.Pi1.TabIndex = 3
        Me.Pi1.Text = "ProgressIndicator1"
        '
        'Pi2
        '
        Me.Pi2.Location = New System.Drawing.Point(45, 112)
        Me.Pi2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Pi2.Name = "Pi2"
        Me.Pi2.P_AnimationColor = System.Drawing.Color.DimGray
        Me.Pi2.P_AnimationSpeed = 100
        Me.Pi2.P_BaseColor = System.Drawing.Color.DarkGray
        Me.Pi2.Size = New System.Drawing.Size(50, 50)
        Me.Pi2.TabIndex = 5
        Me.Pi2.Text = "ProgressIndicator2"
        Me.Pi2.Visible = False
        '
        'Cbx2
        '
        Me.Cbx2.AutoSize = True
        Me.Cbx2.Depth = 0
        Me.Cbx2.Enabled = False
        Me.Cbx2.Location = New System.Drawing.Point(88, 120)
        Me.Cbx2.Margin = New System.Windows.Forms.Padding(0)
        Me.Cbx2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Cbx2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.Cbx2.Name = "Cbx2"
        Me.Cbx2.Ripple = True
        Me.Cbx2.Size = New System.Drawing.Size(112, 37)
        Me.Cbx2.TabIndex = 4
        Me.Cbx2.Text = "2.替换文件"
        Me.Cbx2.UseVisualStyleBackColor = True
        '
        'Pi3
        '
        Me.Pi3.Location = New System.Drawing.Point(45, 157)
        Me.Pi3.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Pi3.Name = "Pi3"
        Me.Pi3.P_AnimationColor = System.Drawing.Color.DimGray
        Me.Pi3.P_AnimationSpeed = 100
        Me.Pi3.P_BaseColor = System.Drawing.Color.DarkGray
        Me.Pi3.Size = New System.Drawing.Size(50, 50)
        Me.Pi3.TabIndex = 11
        Me.Pi3.Text = "ProgressIndicator5"
        Me.Pi3.Visible = False
        '
        'Cbx3
        '
        Me.Cbx3.AutoSize = True
        Me.Cbx3.Depth = 0
        Me.Cbx3.Enabled = False
        Me.Cbx3.Location = New System.Drawing.Point(88, 165)
        Me.Cbx3.Margin = New System.Windows.Forms.Padding(0)
        Me.Cbx3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Cbx3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.Cbx3.Name = "Cbx3"
        Me.Cbx3.Ripple = True
        Me.Cbx3.Size = New System.Drawing.Size(112, 37)
        Me.Cbx3.TabIndex = 10
        Me.Cbx3.Text = "3.完成破解"
        Me.Cbx3.UseVisualStyleBackColor = True
        '
        'FrmCrackRedSpider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 262)
        Me.Controls.Add(Me.Pi3)
        Me.Controls.Add(Me.Cbx3)
        Me.Controls.Add(Me.Pi2)
        Me.Controls.Add(Me.Cbx2)
        Me.Controls.Add(Me.Pi1)
        Me.Controls.Add(Me.Cbx1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.BigLabel1)
        Me.Name = "FrmCrackRedSpider"
        Me.Text = "破解红蜘蛛 v6.2.1160"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BigLabel1 As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents MetroLabel1 As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents Cbx1 As ReaLTaiizor.Controls.MaterialCheckBox
    Friend WithEvents Pi1 As ReaLTaiizor.Controls.ProgressIndicator
    Friend WithEvents Pi2 As ReaLTaiizor.Controls.ProgressIndicator
    Friend WithEvents Cbx2 As ReaLTaiizor.Controls.MaterialCheckBox
    Friend WithEvents Pi3 As ReaLTaiizor.Controls.ProgressIndicator
    Friend WithEvents Cbx3 As ReaLTaiizor.Controls.MaterialCheckBox
End Class
