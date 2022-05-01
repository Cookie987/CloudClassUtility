<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdvance
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
        Me.GroupBoxJiyuOutput = New System.Windows.Forms.GroupBox()
        Me.TextBoxOutput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxRedSpider = New System.Windows.Forms.GroupBox()
        Me.BtnCrackRedSpider = New ReaLTaiizor.Controls.MaterialButton()
        Me.GetJiyuPasswd = New ReaLTaiizor.Controls.MaterialButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnUdpAttack = New ReaLTaiizor.Controls.MaterialButton()
        Me.BtnUniJiyuUsbDriver = New ReaLTaiizor.Controls.MaterialButton()
        Me.GroupBoxJiyuOutput.SuspendLayout()
        Me.GroupBoxRedSpider.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxJiyuOutput
        '
        Me.GroupBoxJiyuOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxJiyuOutput.Controls.Add(Me.TextBoxOutput)
        Me.GroupBoxJiyuOutput.Location = New System.Drawing.Point(12, 176)
        Me.GroupBoxJiyuOutput.Name = "GroupBoxJiyuOutput"
        Me.GroupBoxJiyuOutput.Size = New System.Drawing.Size(490, 217)
        Me.GroupBoxJiyuOutput.TabIndex = 2
        Me.GroupBoxJiyuOutput.TabStop = False
        Me.GroupBoxJiyuOutput.Text = "输出"
        '
        'TextBoxOutput
        '
        Me.TextBoxOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxOutput.Location = New System.Drawing.Point(6, 21)
        Me.TextBoxOutput.MaxLength = 0
        Me.TextBoxOutput.Multiline = True
        Me.TextBoxOutput.Name = "TextBoxOutput"
        Me.TextBoxOutput.ReadOnly = True
        Me.TextBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxOutput.Size = New System.Drawing.Size(478, 190)
        Me.TextBoxOutput.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(96, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "警告: 本页面所有功能均未经实机测试, 不保证全部有效!"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'GroupBoxRedSpider
        '
        Me.GroupBoxRedSpider.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxRedSpider.Controls.Add(Me.BtnCrackRedSpider)
        Me.GroupBoxRedSpider.Location = New System.Drawing.Point(12, 93)
        Me.GroupBoxRedSpider.Name = "GroupBoxRedSpider"
        Me.GroupBoxRedSpider.Size = New System.Drawing.Size(490, 77)
        Me.GroupBoxRedSpider.TabIndex = 4
        Me.GroupBoxRedSpider.TabStop = False
        Me.GroupBoxRedSpider.Text = "红蜘蛛类"
        '
        'BtnCrackRedSpider
        '
        Me.BtnCrackRedSpider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnCrackRedSpider.Depth = 0
        Me.BtnCrackRedSpider.DrawShadows = True
        Me.BtnCrackRedSpider.Enabled = False
        Me.BtnCrackRedSpider.HighEmphasis = True
        Me.BtnCrackRedSpider.Icon = Nothing
        Me.BtnCrackRedSpider.Location = New System.Drawing.Point(7, 24)
        Me.BtnCrackRedSpider.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnCrackRedSpider.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.BtnCrackRedSpider.Name = "BtnCrackRedSpider"
        Me.BtnCrackRedSpider.Size = New System.Drawing.Size(101, 36)
        Me.BtnCrackRedSpider.TabIndex = 4
        Me.BtnCrackRedSpider.Text = "破解红蜘蛛"
        Me.BtnCrackRedSpider.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.BtnCrackRedSpider.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnCrackRedSpider.UseAccentColor = False
        Me.BtnCrackRedSpider.UseVisualStyleBackColor = True
        '
        'GetJiyuPasswd
        '
        Me.GetJiyuPasswd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GetJiyuPasswd.Depth = 0
        Me.GetJiyuPasswd.DrawShadows = True
        Me.GetJiyuPasswd.Font = New System.Drawing.Font("更纱黑体 UI SC", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GetJiyuPasswd.HighEmphasis = True
        Me.GetJiyuPasswd.Icon = Nothing
        Me.GetJiyuPasswd.Location = New System.Drawing.Point(7, 24)
        Me.GetJiyuPasswd.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GetJiyuPasswd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.GetJiyuPasswd.Name = "GetJiyuPasswd"
        Me.GetJiyuPasswd.Size = New System.Drawing.Size(117, 36)
        Me.GetJiyuPasswd.TabIndex = 1
        Me.GetJiyuPasswd.Text = "获取极域密码"
        Me.GetJiyuPasswd.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.GetJiyuPasswd.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.GetJiyuPasswd.UseAccentColor = False
        Me.GetJiyuPasswd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnUdpAttack)
        Me.GroupBox1.Controls.Add(Me.BtnUniJiyuUsbDriver)
        Me.GroupBox1.Controls.Add(Me.GetJiyuPasswd)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 75)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "极域类"
        '
        'BtnUdpAttack
        '
        Me.BtnUdpAttack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnUdpAttack.Depth = 0
        Me.BtnUdpAttack.DrawShadows = True
        Me.BtnUdpAttack.HighEmphasis = True
        Me.BtnUdpAttack.Icon = Nothing
        Me.BtnUdpAttack.Location = New System.Drawing.Point(291, 24)
        Me.BtnUdpAttack.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnUdpAttack.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.BtnUdpAttack.Name = "BtnUdpAttack"
        Me.BtnUdpAttack.Size = New System.Drawing.Size(117, 36)
        Me.BtnUdpAttack.TabIndex = 3
        Me.BtnUdpAttack.Text = "UDP 重放攻击"
        Me.BtnUdpAttack.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.BtnUdpAttack.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnUdpAttack.UseAccentColor = False
        Me.BtnUdpAttack.UseVisualStyleBackColor = True
        '
        'BtnUniJiyuUsbDriver
        '
        Me.BtnUniJiyuUsbDriver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnUniJiyuUsbDriver.Depth = 0
        Me.BtnUniJiyuUsbDriver.DrawShadows = True
        Me.BtnUniJiyuUsbDriver.HighEmphasis = True
        Me.BtnUniJiyuUsbDriver.Icon = Nothing
        Me.BtnUniJiyuUsbDriver.Location = New System.Drawing.Point(132, 24)
        Me.BtnUniJiyuUsbDriver.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnUniJiyuUsbDriver.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.BtnUniJiyuUsbDriver.Name = "BtnUniJiyuUsbDriver"
        Me.BtnUniJiyuUsbDriver.Size = New System.Drawing.Size(151, 36)
        Me.BtnUniJiyuUsbDriver.TabIndex = 2
        Me.BtnUniJiyuUsbDriver.Text = "卸载极域 USB 驱动"
        Me.BtnUniJiyuUsbDriver.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.BtnUniJiyuUsbDriver.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnUniJiyuUsbDriver.UseAccentColor = False
        Me.BtnUniJiyuUsbDriver.UseVisualStyleBackColor = True
        '
        'FrmAdvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 405)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxRedSpider)
        Me.Controls.Add(Me.GroupBoxJiyuOutput)
        Me.MinimumSize = New System.Drawing.Size(419, 327)
        Me.Name = "FrmAdvance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "高级"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GroupBoxJiyuOutput.ResumeLayout(False)
        Me.GroupBoxJiyuOutput.PerformLayout()
        Me.GroupBoxRedSpider.ResumeLayout(False)
        Me.GroupBoxRedSpider.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxJiyuOutput As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBoxRedSpider As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GetJiyuPasswd As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnUdpAttack As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents BtnUniJiyuUsbDriver As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents TextBoxOutput As TextBox
    Friend WithEvents BtnCrackRedSpider As ReaLTaiizor.Controls.MaterialButton
End Class
