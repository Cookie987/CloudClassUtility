<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUdpAttack
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TbxOutput = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnSendText = New ReaLTaiizor.Controls.MaterialButton()
        Me.BtnSendCommand = New ReaLTaiizor.Controls.MaterialButton()
        Me.TbxIPAddress = New ReaLTaiizor.Controls.MaterialSingleTextBox()
        Me.TbxPort = New ReaLTaiizor.Controls.MaterialSingleTextBox()
        Me.TbxSendText = New ReaLTaiizor.Controls.MaterialSingleTextBox()
        Me.TbxCommand = New ReaLTaiizor.Controls.MaterialSingleTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "警告: 因使用此功能而造成的任何后果, 与作者无关!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 105)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tips: 如果对方也在使用本软件,那么本页的功能" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "可能不会生效" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "指定目标IP时, 可以有以下几种指定方式:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "指定单个IP, 如 192.168.80.12" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "指定IP范围, 如 192.168.80.10-56" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "指定IP所在C段, 如 192.168.80.1/24" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* IP 地址和端口为必填项"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "IP 地址: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "端口: "
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(60, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "本功能原理由 ht0Ruial 大佬提供"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "发送文字: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "发送命令: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(74, 318)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 15)
        Me.Label8.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(73, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "* 最多100个字符"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TbxOutput)
        Me.GroupBox1.Location = New System.Drawing.Point(292, 9)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(233, 324)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 369)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "输出"
        '
        'TbxOutput
        '
        Me.TbxOutput.AcceptsReturn = True
        Me.TbxOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbxOutput.Location = New System.Drawing.Point(6, 18)
        Me.TbxOutput.MaxLength = 0
        Me.TbxOutput.Multiline = True
        Me.TbxOutput.Name = "TbxOutput"
        Me.TbxOutput.ReadOnly = True
        Me.TbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TbxOutput.Size = New System.Drawing.Size(300, 345)
        Me.TbxOutput.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(74, 310)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 30)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "* 如果输入的命令有空格, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "可能不会显示执行结果"
        '
        'BtnSendText
        '
        Me.BtnSendText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSendText.Depth = 0
        Me.BtnSendText.DrawShadows = True
        Me.BtnSendText.HighEmphasis = True
        Me.BtnSendText.Icon = Nothing
        Me.BtnSendText.Location = New System.Drawing.Point(224, 237)
        Me.BtnSendText.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnSendText.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.BtnSendText.Name = "BtnSendText"
        Me.BtnSendText.Size = New System.Drawing.Size(53, 36)
        Me.BtnSendText.TabIndex = 4
        Me.BtnSendText.Text = "发送"
        Me.BtnSendText.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.BtnSendText.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnSendText.UseAccentColor = False
        Me.BtnSendText.UseVisualStyleBackColor = True
        '
        'BtnSendCommand
        '
        Me.BtnSendCommand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSendCommand.Depth = 0
        Me.BtnSendCommand.DrawShadows = True
        Me.BtnSendCommand.HighEmphasis = True
        Me.BtnSendCommand.Icon = Nothing
        Me.BtnSendCommand.Location = New System.Drawing.Point(224, 316)
        Me.BtnSendCommand.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnSendCommand.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.BtnSendCommand.Name = "BtnSendCommand"
        Me.BtnSendCommand.Size = New System.Drawing.Size(53, 36)
        Me.BtnSendCommand.TabIndex = 6
        Me.BtnSendCommand.Text = "发送"
        Me.BtnSendCommand.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.BtnSendCommand.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnSendCommand.UseAccentColor = False
        Me.BtnSendCommand.UseVisualStyleBackColor = True
        '
        'TbxIPAddress
        '
        Me.TbxIPAddress.Depth = 0
        Me.TbxIPAddress.Location = New System.Drawing.Point(74, 141)
        Me.TbxIPAddress.MaxLength = 32767
        Me.TbxIPAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.TbxIPAddress.Name = "TbxIPAddress"
        Me.TbxIPAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbxIPAddress.SelectedText = ""
        Me.TbxIPAddress.SelectionLength = 0
        Me.TbxIPAddress.SelectionStart = 0
        Me.TbxIPAddress.Size = New System.Drawing.Size(203, 25)
        Me.TbxIPAddress.TabIndex = 1
        Me.TbxIPAddress.UseAccentColor = False
        Me.TbxIPAddress.UseSystemPasswordChar = False
        '
        'TbxPort
        '
        Me.TbxPort.Depth = 0
        Me.TbxPort.Location = New System.Drawing.Point(73, 172)
        Me.TbxPort.MaxLength = 32767
        Me.TbxPort.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.TbxPort.Name = "TbxPort"
        Me.TbxPort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbxPort.SelectedText = ""
        Me.TbxPort.SelectionLength = 0
        Me.TbxPort.SelectionStart = 0
        Me.TbxPort.Size = New System.Drawing.Size(204, 25)
        Me.TbxPort.TabIndex = 2
        Me.TbxPort.Text = "4705"
        Me.TbxPort.UseAccentColor = False
        Me.TbxPort.UseSystemPasswordChar = False
        '
        'TbxSendText
        '
        Me.TbxSendText.Depth = 0
        Me.TbxSendText.Location = New System.Drawing.Point(73, 203)
        Me.TbxSendText.MaxLength = 100
        Me.TbxSendText.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.TbxSendText.Name = "TbxSendText"
        Me.TbxSendText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbxSendText.SelectedText = ""
        Me.TbxSendText.SelectionLength = 0
        Me.TbxSendText.SelectionStart = 0
        Me.TbxSendText.Size = New System.Drawing.Size(204, 25)
        Me.TbxSendText.TabIndex = 3
        Me.TbxSendText.UseAccentColor = False
        Me.TbxSendText.UseSystemPasswordChar = False
        '
        'TbxCommand
        '
        Me.TbxCommand.Depth = 0
        Me.TbxCommand.Location = New System.Drawing.Point(74, 282)
        Me.TbxCommand.MaxLength = 32767
        Me.TbxCommand.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.TbxCommand.Name = "TbxCommand"
        Me.TbxCommand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbxCommand.SelectedText = ""
        Me.TbxCommand.SelectionLength = 0
        Me.TbxCommand.SelectionStart = 0
        Me.TbxCommand.Size = New System.Drawing.Size(203, 25)
        Me.TbxCommand.TabIndex = 5
        Me.TbxCommand.UseAccentColor = False
        Me.TbxCommand.UseSystemPasswordChar = False
        '
        'FrmUdpAttack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 390)
        Me.Controls.Add(Me.TbxCommand)
        Me.Controls.Add(Me.TbxSendText)
        Me.Controls.Add(Me.TbxPort)
        Me.Controls.Add(Me.TbxIPAddress)
        Me.Controls.Add(Me.BtnSendCommand)
        Me.Controls.Add(Me.BtnSendText)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(549, 420)
        Me.Name = "FrmUdpAttack"
        Me.Text = "极域 UDP 攻击"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TbxOutput As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnSendText As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents BtnSendCommand As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents TbxIPAddress As ReaLTaiizor.Controls.MaterialSingleTextBox
    Friend WithEvents TbxPort As ReaLTaiizor.Controls.MaterialSingleTextBox
    Friend WithEvents TbxSendText As ReaLTaiizor.Controls.MaterialSingleTextBox
    Friend WithEvents TbxCommand As ReaLTaiizor.Controls.MaterialSingleTextBox
End Class
