<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdvance
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBoxJiyu = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxJiyuOutput = New System.Windows.Forms.GroupBox()
        Me.TextBoxOutput = New System.Windows.Forms.TextBox()
        Me.GetJiyuPasswd = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxJiyu.SuspendLayout()
        Me.GroupBoxJiyuOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxJiyu
        '
        Me.GroupBoxJiyu.Controls.Add(Me.Label1)
        Me.GroupBoxJiyu.Controls.Add(Me.GetJiyuPasswd)
        Me.GroupBoxJiyu.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxJiyu.Name = "GroupBoxJiyu"
        Me.GroupBoxJiyu.Size = New System.Drawing.Size(576, 56)
        Me.GroupBoxJiyu.TabIndex = 0
        Me.GroupBoxJiyu.TabStop = False
        Me.GroupBoxJiyu.Text = "极域类"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(139, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "警告: 本页面所有功能均未经实机测试, 不保证全部有效!"
        '
        'GroupBoxJiyuOutput
        '
        Me.GroupBoxJiyuOutput.Controls.Add(Me.TextBoxOutput)
        Me.GroupBoxJiyuOutput.Location = New System.Drawing.Point(12, 74)
        Me.GroupBoxJiyuOutput.Name = "GroupBoxJiyuOutput"
        Me.GroupBoxJiyuOutput.Size = New System.Drawing.Size(576, 310)
        Me.GroupBoxJiyuOutput.TabIndex = 2
        Me.GroupBoxJiyuOutput.TabStop = False
        Me.GroupBoxJiyuOutput.Text = "输出"
        '
        'TextBoxOutput
        '
        Me.TextBoxOutput.AcceptsReturn = True
        Me.TextBoxOutput.Location = New System.Drawing.Point(6, 21)
        Me.TextBoxOutput.Multiline = True
        Me.TextBoxOutput.Name = "TextBoxOutput"
        Me.TextBoxOutput.ReadOnly = True
        Me.TextBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxOutput.Size = New System.Drawing.Size(564, 283)
        Me.TextBoxOutput.TabIndex = 1
        '
        'GetJiyuPasswd
        '
        Me.GetJiyuPasswd.Location = New System.Drawing.Point(6, 21)
        Me.GetJiyuPasswd.Name = "GetJiyuPasswd"
        Me.GetJiyuPasswd.Size = New System.Drawing.Size(95, 23)
        Me.GetJiyuPasswd.TabIndex = 0
        Me.GetJiyuPasswd.Text = "获取极域密码"
        Me.GetJiyuPasswd.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'FrmAdvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 396)
        Me.Controls.Add(Me.GroupBoxJiyu)
        Me.Controls.Add(Me.GroupBoxJiyuOutput)
        Me.Name = "FrmAdvance"
        Me.Text = "高级"
        Me.GroupBoxJiyu.ResumeLayout(False)
        Me.GroupBoxJiyu.PerformLayout()
        Me.GroupBoxJiyuOutput.ResumeLayout(False)
        Me.GroupBoxJiyuOutput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxJiyu As GroupBox
    Friend WithEvents GetJiyuPasswd As Button
    Friend WithEvents GroupBoxJiyuOutput As GroupBox
    Friend WithEvents TextBoxOutput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
