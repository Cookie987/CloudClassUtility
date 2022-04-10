<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMaster
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New ReaLTaiizor.Controls.MaterialButton()
        Me.btnStop = New ReaLTaiizor.Controls.MaterialButton()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'btnStart
        '
        Me.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnStart.Depth = 0
        Me.btnStart.DrawShadows = True
        Me.btnStart.HighEmphasis = True
        Me.btnStart.Icon = Nothing
        Me.btnStart.Location = New System.Drawing.Point(13, 6)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnStart.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(53, 36)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "开始"
        Me.btnStart.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.btnStart.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnStart.UseAccentColor = False
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnStop.Depth = 0
        Me.btnStop.DrawShadows = True
        Me.btnStop.HighEmphasis = True
        Me.btnStop.Icon = Nothing
        Me.btnStop.Location = New System.Drawing.Point(121, 6)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnStop.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(53, 36)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "停止"
        Me.btnStop.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.btnStop.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnStop.UseAccentColor = False
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'FrmMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(187, 49)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.MaximumSize = New System.Drawing.Size(203, 88)
        Me.MinimumSize = New System.Drawing.Size(203, 88)
        Me.Name = "FrmMaster"
        Me.Text = "主窗口"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnStart As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents btnStop As ReaLTaiizor.Controls.MaterialButton
End Class
