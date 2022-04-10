<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSetting
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CbxCustom = New ReaLTaiizor.Controls.MaterialCheckBox()
        Me.CbxRcc = New ReaLTaiizor.Controls.MaterialCheckBox()
        Me.CbxRedSpider = New ReaLTaiizor.Controls.MaterialCheckBox()
        Me.CbxJiyu = New ReaLTaiizor.Controls.MaterialCheckBox()
        Me.TbxCustom = New ReaLTaiizor.Controls.MaterialSingleTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TrackBar1 = New ReaLTaiizor.Controls.TrackBar()
        Me.TextBox1 = New ReaLTaiizor.Controls.MaterialSingleTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 262)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "通用"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CbxCustom)
        Me.GroupBox3.Controls.Add(Me.CbxRcc)
        Me.GroupBox3.Controls.Add(Me.CbxRedSpider)
        Me.GroupBox3.Controls.Add(Me.CbxJiyu)
        Me.GroupBox3.Controls.Add(Me.TbxCustom)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 127)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(312, 129)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "方案"
        '
        'CbxCustom
        '
        Me.CbxCustom.AutoSize = True
        Me.CbxCustom.Depth = 0
        Me.CbxCustom.Location = New System.Drawing.Point(27, 70)
        Me.CbxCustom.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxCustom.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CbxCustom.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.CbxCustom.Name = "CbxCustom"
        Me.CbxCustom.Ripple = True
        Me.CbxCustom.Size = New System.Drawing.Size(91, 37)
        Me.CbxCustom.TabIndex = 6
        Me.CbxCustom.Text = "自定义: "
        Me.CbxCustom.UseVisualStyleBackColor = True
        '
        'CbxRcc
        '
        Me.CbxRcc.AutoSize = True
        Me.CbxRcc.Depth = 0
        Me.CbxRcc.Location = New System.Drawing.Point(200, 21)
        Me.CbxRcc.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxRcc.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CbxRcc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.CbxRcc.Name = "CbxRcc"
        Me.CbxRcc.Ripple = True
        Me.CbxRcc.Size = New System.Drawing.Size(83, 37)
        Me.CbxRcc.TabIndex = 5
        Me.CbxRcc.Text = "云课堂"
        Me.CbxRcc.UseVisualStyleBackColor = True
        '
        'CbxRedSpider
        '
        Me.CbxRedSpider.AutoSize = True
        Me.CbxRedSpider.Depth = 0
        Me.CbxRedSpider.Location = New System.Drawing.Point(107, 21)
        Me.CbxRedSpider.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxRedSpider.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CbxRedSpider.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.CbxRedSpider.Name = "CbxRedSpider"
        Me.CbxRedSpider.Ripple = True
        Me.CbxRedSpider.Size = New System.Drawing.Size(83, 37)
        Me.CbxRedSpider.TabIndex = 4
        Me.CbxRedSpider.Text = "红蜘蛛"
        Me.CbxRedSpider.UseVisualStyleBackColor = True
        '
        'CbxJiyu
        '
        Me.CbxJiyu.AutoSize = True
        Me.CbxJiyu.Depth = 0
        Me.CbxJiyu.Location = New System.Drawing.Point(29, 21)
        Me.CbxJiyu.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxJiyu.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CbxJiyu.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.CbxJiyu.Name = "CbxJiyu"
        Me.CbxJiyu.Ripple = True
        Me.CbxJiyu.Size = New System.Drawing.Size(67, 37)
        Me.CbxJiyu.TabIndex = 3
        Me.CbxJiyu.Text = "极域"
        Me.CbxJiyu.UseVisualStyleBackColor = True
        '
        'TbxCustom
        '
        Me.TbxCustom.Depth = 0
        Me.TbxCustom.Location = New System.Drawing.Point(119, 79)
        Me.TbxCustom.MaxLength = 32767
        Me.TbxCustom.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.TbxCustom.Name = "TbxCustom"
        Me.TbxCustom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbxCustom.SelectedText = ""
        Me.TbxCustom.SelectionLength = 0
        Me.TbxCustom.SelectionStart = 0
        Me.TbxCustom.Size = New System.Drawing.Size(166, 25)
        Me.TbxCustom.TabIndex = 5
        Me.TbxCustom.TabStop = False
        Me.TbxCustom.UseAccentColor = False
        Me.TbxCustom.UseSystemPasswordChar = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TrackBar1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "延时时间"
        '
        'TrackBar1
        '
        Me.TrackBar1.JumpToMouse = False
        Me.TrackBar1.Location = New System.Drawing.Point(14, 53)
        Me.TrackBar1.Maximum = 2000
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.MinimumSize = New System.Drawing.Size(47, 22)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(285, 22)
        Me.TrackBar1.TabIndex = 2
        Me.TrackBar1.Text = "TrackBar2"
        Me.TrackBar1.Value = 200
        Me.TrackBar1.ValueDivison = ReaLTaiizor.Controls.TrackBar.ValueDivisor.By1
        Me.TrackBar1.ValueToSet = 200.0!
        '
        'TextBox1
        '
        Me.TextBox1.Depth = 0
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(135, 21)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.SelectionLength = 0
        Me.TextBox1.SelectionStart = 0
        Me.TextBox1.Size = New System.Drawing.Size(42, 25)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "200"
        Me.TextBox1.UseAccentColor = False
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "2000ms"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1ms"
        '
        'FrmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 286)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmSetting"
        Me.Text = "设置"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TbxCustom As ReaLTaiizor.Controls.MaterialSingleTextBox
    Friend WithEvents TextBox1 As ReaLTaiizor.Controls.MaterialSingleTextBox
    Friend WithEvents CbxRedSpider As ReaLTaiizor.Controls.MaterialCheckBox
    Friend WithEvents CbxJiyu As ReaLTaiizor.Controls.MaterialCheckBox
    Friend WithEvents CbxCustom As ReaLTaiizor.Controls.MaterialCheckBox
    Friend WithEvents CbxRcc As ReaLTaiizor.Controls.MaterialCheckBox
    Friend WithEvents TrackBar1 As ReaLTaiizor.Controls.TrackBar
End Class
