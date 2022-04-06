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
        Me.tbxCustom = New System.Windows.Forms.TextBox()
        Me.cbxCustom = New System.Windows.Forms.CheckBox()
        Me.cbxRedSpider = New System.Windows.Forms.CheckBox()
        Me.cbxRcc = New System.Windows.Forms.CheckBox()
        Me.cbxJiyu = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox3.Controls.Add(Me.tbxCustom)
        Me.GroupBox3.Controls.Add(Me.cbxCustom)
        Me.GroupBox3.Controls.Add(Me.cbxRedSpider)
        Me.GroupBox3.Controls.Add(Me.cbxRcc)
        Me.GroupBox3.Controls.Add(Me.cbxJiyu)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 127)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(312, 129)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "方案"
        '
        'tbxCustom
        '
        Me.tbxCustom.Location = New System.Drawing.Point(106, 71)
        Me.tbxCustom.Name = "tbxCustom"
        Me.tbxCustom.Size = New System.Drawing.Size(100, 22)
        Me.tbxCustom.TabIndex = 4
        Me.tbxCustom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxCustom
        '
        Me.cbxCustom.AutoSize = True
        Me.cbxCustom.Location = New System.Drawing.Point(36, 46)
        Me.cbxCustom.Name = "cbxCustom"
        Me.cbxCustom.Size = New System.Drawing.Size(241, 19)
        Me.cbxCustom.TabIndex = 3
        Me.cbxCustom.Text = "自定义 (请在下面的编辑框中输入进程名)"
        Me.cbxCustom.UseVisualStyleBackColor = True
        '
        'cbxRedSpider
        '
        Me.cbxRedSpider.AutoSize = True
        Me.cbxRedSpider.Location = New System.Drawing.Point(119, 21)
        Me.cbxRedSpider.Name = "cbxRedSpider"
        Me.cbxRedSpider.Size = New System.Drawing.Size(62, 19)
        Me.cbxRedSpider.TabIndex = 2
        Me.cbxRedSpider.Text = "红蜘蛛"
        Me.cbxRedSpider.UseVisualStyleBackColor = True
        '
        'cbxRcc
        '
        Me.cbxRcc.AutoSize = True
        Me.cbxRcc.Location = New System.Drawing.Point(187, 21)
        Me.cbxRcc.Name = "cbxRcc"
        Me.cbxRcc.Size = New System.Drawing.Size(62, 19)
        Me.cbxRcc.TabIndex = 1
        Me.cbxRcc.Text = "云课堂"
        Me.cbxRcc.UseVisualStyleBackColor = True
        '
        'cbxJiyu
        '
        Me.cbxJiyu.AutoSize = True
        Me.cbxJiyu.Location = New System.Drawing.Point(63, 21)
        Me.cbxJiyu.Name = "cbxJiyu"
        Me.cbxJiyu.Size = New System.Drawing.Size(50, 19)
        Me.cbxJiyu.TabIndex = 0
        Me.cbxJiyu.Text = "极域"
        Me.cbxJiyu.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TrackBar1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "延时时间"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(130, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(53, 22)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "200"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(6, 49)
        Me.TrackBar1.Maximum = 2000
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(300, 45)
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.Value = 200
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
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbxCustom As CheckBox
    Friend WithEvents cbxRedSpider As CheckBox
    Friend WithEvents cbxRcc As CheckBox
    Friend WithEvents cbxJiyu As CheckBox
    Friend WithEvents tbxCustom As TextBox
End Class
