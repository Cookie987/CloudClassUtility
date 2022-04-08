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
        Me.TbxIPAddress = New System.Windows.Forms.TextBox()
        Me.TbxPort = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbxSendText = New System.Windows.Forms.TextBox()
        Me.SendText = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbxCommand = New System.Windows.Forms.TextBox()
        Me.BtnSendCommand = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TbxOutput = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.Label2.Text = "Tips: 如果对方也在使用本软件,那么本页的功能" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "可能不会生效" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "指定目标IP时, 可以有以下几种指定方式:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "指定单个IP, 如 192.168.80." &
    "12" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "指定IP范围, 如 192.168.80.10-56" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "指定IP所在C段, 如 192.168.80.1/24"
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
        Me.Label4.Location = New System.Drawing.Point(36, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "端口: "
        '
        'TbxIPAddress
        '
        Me.TbxIPAddress.Location = New System.Drawing.Point(73, 138)
        Me.TbxIPAddress.Name = "TbxIPAddress"
        Me.TbxIPAddress.Size = New System.Drawing.Size(204, 22)
        Me.TbxIPAddress.TabIndex = 4
        '
        'TbxPort
        '
        Me.TbxPort.Location = New System.Drawing.Point(73, 166)
        Me.TbxPort.Name = "TbxPort"
        Me.TbxPort.Size = New System.Drawing.Size(204, 22)
        Me.TbxPort.TabIndex = 5
        Me.TbxPort.Text = "4705"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(60, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "本功能原理由 ht0Ruial 大佬提供"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "发送文字: "
        '
        'TbxSendText
        '
        Me.TbxSendText.Location = New System.Drawing.Point(73, 192)
        Me.TbxSendText.Name = "TbxSendText"
        Me.TbxSendText.Size = New System.Drawing.Size(204, 22)
        Me.TbxSendText.TabIndex = 9
        '
        'SendText
        '
        Me.SendText.Location = New System.Drawing.Point(202, 220)
        Me.SendText.Name = "SendText"
        Me.SendText.Size = New System.Drawing.Size(75, 23)
        Me.SendText.TabIndex = 10
        Me.SendText.Text = "发送"
        Me.SendText.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "发送命令: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(74, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 15)
        Me.Label8.TabIndex = 12
        '
        'TbxCommand
        '
        Me.TbxCommand.Location = New System.Drawing.Point(73, 249)
        Me.TbxCommand.Name = "TbxCommand"
        Me.TbxCommand.Size = New System.Drawing.Size(204, 22)
        Me.TbxCommand.TabIndex = 13
        '
        'BtnSendCommand
        '
        Me.BtnSendCommand.Location = New System.Drawing.Point(202, 277)
        Me.BtnSendCommand.Name = "BtnSendCommand"
        Me.BtnSendCommand.Size = New System.Drawing.Size(75, 23)
        Me.BtnSendCommand.TabIndex = 14
        Me.BtnSendCommand.Text = "发送"
        Me.BtnSendCommand.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(73, 217)
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
        Me.GroupBox1.Size = New System.Drawing.Size(233, 324)
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
        Me.TbxOutput.Size = New System.Drawing.Size(221, 300)
        Me.TbxOutput.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(72, 274)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 45)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "* 如果输入的命令有空" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "格, 可能不会显示执行" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "结果"
        '
        'FrmUdpAttack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 345)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnSendCommand)
        Me.Controls.Add(Me.TbxCommand)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SendText)
        Me.Controls.Add(Me.TbxSendText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbxPort)
        Me.Controls.Add(Me.TbxIPAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents TbxIPAddress As TextBox
    Friend WithEvents TbxPort As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TbxSendText As TextBox
    Friend WithEvents SendText As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TbxCommand As TextBox
    Friend WithEvents BtnSendCommand As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TbxOutput As TextBox
    Friend WithEvents Label10 As Label
End Class
