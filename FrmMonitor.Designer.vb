<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMonitor
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.JiyuCard = New ReaLTaiizor.Controls.ParrotCard()
        Me.RedSpiderCard = New ReaLTaiizor.Controls.ParrotCard()
        Me.RccCard = New ReaLTaiizor.Controls.ParrotCard()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'JiyuCard
        '
        Me.JiyuCard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.JiyuCard.BackColor = System.Drawing.Color.Transparent
        Me.JiyuCard.Color1 = System.Drawing.Color.DodgerBlue
        Me.JiyuCard.Color2 = System.Drawing.Color.LimeGreen
        Me.JiyuCard.ForeColor = System.Drawing.Color.White
        Me.JiyuCard.Location = New System.Drawing.Point(12, 12)
        Me.JiyuCard.Name = "JiyuCard"
        Me.JiyuCard.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.JiyuCard.Size = New System.Drawing.Size(222, 150)
        Me.JiyuCard.TabIndex = 0
        Me.JiyuCard.Text = "ParrotCard1"
        Me.JiyuCard.Text1 = "极域"
        Me.JiyuCard.Text2 = ""
        Me.JiyuCard.Text3 = ""
        Me.JiyuCard.TextRenderingType = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'RedSpiderCard
        '
        Me.RedSpiderCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.RedSpiderCard.BackColor = System.Drawing.Color.Transparent
        Me.RedSpiderCard.Color1 = System.Drawing.Color.DodgerBlue
        Me.RedSpiderCard.Color2 = System.Drawing.Color.LimeGreen
        Me.RedSpiderCard.ForeColor = System.Drawing.Color.White
        Me.RedSpiderCard.Location = New System.Drawing.Point(240, 12)
        Me.RedSpiderCard.Name = "RedSpiderCard"
        Me.RedSpiderCard.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.RedSpiderCard.Size = New System.Drawing.Size(222, 150)
        Me.RedSpiderCard.TabIndex = 1
        Me.RedSpiderCard.Text1 = "红蜘蛛"
        Me.RedSpiderCard.Text2 = ""
        Me.RedSpiderCard.Text3 = ""
        Me.RedSpiderCard.TextRenderingType = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'RccCard
        '
        Me.RccCard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RccCard.BackColor = System.Drawing.Color.Transparent
        Me.RccCard.Color1 = System.Drawing.Color.DodgerBlue
        Me.RccCard.Color2 = System.Drawing.Color.LimeGreen
        Me.RccCard.ForeColor = System.Drawing.Color.White
        Me.RccCard.Location = New System.Drawing.Point(468, 12)
        Me.RccCard.Name = "RccCard"
        Me.RccCard.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.RccCard.Size = New System.Drawing.Size(222, 150)
        Me.RccCard.TabIndex = 2
        Me.RccCard.Text1 = "云课堂"
        Me.RccCard.Text2 = ""
        Me.RccCard.Text3 = ""
        Me.RccCard.TextRenderingType = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'FrmMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 174)
        Me.Controls.Add(Me.RccCard)
        Me.Controls.Add(Me.RedSpiderCard)
        Me.Controls.Add(Me.JiyuCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimumSize = New System.Drawing.Size(261, 61)
        Me.Name = "FrmMonitor"
        Me.Text = "监视器"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents JiyuCard As ReaLTaiizor.Controls.ParrotCard
    Friend WithEvents RedSpiderCard As ReaLTaiizor.Controls.ParrotCard
    Friend WithEvents RccCard As ReaLTaiizor.Controls.ParrotCard
End Class
