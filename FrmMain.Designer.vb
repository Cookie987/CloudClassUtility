<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.CrownMenuStrip1 = New ReaLTaiizor.Controls.CrownMenuStrip()
        Me.窗口WToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.主窗口MToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.高级AToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.监视器VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.设置SToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.测试窗口TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.日志LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查看日志VToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.导出日志ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.清除日志CToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助HToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.检测更新UToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于CloudClassUtilityToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialTabControl1 = New ReaLTaiizor.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CardNotice = New ReaLTaiizor.Controls.MaterialCard()
        Me.TcNotice = New ReaLTaiizor.Controls.MetroTabControl()
        Me.TpNotice1 = New System.Windows.Forms.TabPage()
        Me.LabNotice1_2 = New ReaLTaiizor.Controls.MaterialLabel()
        Me.TpNotice2 = New System.Windows.Forms.TabPage()
        Me.LabNotice2 = New ReaLTaiizor.Controls.MaterialLabel()
        Me.LabNotice = New ReaLTaiizor.Controls.MaterialLabel()
        Me.TpNotice3 = New System.Windows.Forms.TabPage()
        Me.MaterialLabel1 = New ReaLTaiizor.Controls.MaterialLabel()
        Me.TpPreview = New System.Windows.Forms.TabPage()
        Me.MaterialLabel2 = New ReaLTaiizor.Controls.MaterialLabel()
        Me.SmallLabel1 = New ReaLTaiizor.Controls.SmallLabel()
        Me.MaterialCard1 = New ReaLTaiizor.Controls.MaterialCard()
        Me.SliDelay = New MaterialSkin.Controls.MaterialSlider()
        Me.SmallLabel2 = New ReaLTaiizor.Controls.SmallLabel()
        Me.CardCho = New MaterialSkin.Controls.MaterialCard()
        Me.LabChooseWay = New ReaLTaiizor.Controls.SmallLabel()
        Me.CbxCustom = New ReaLTaiizor.Controls.MaterialCheckBox()
        Me.TbxCustom = New ReaLTaiizor.Controls.MaterialSingleTextBox()
        Me.CbxRcc = New ReaLTaiizor.Controls.MaterialCheckBox()
        Me.CbxJiyu = New ReaLTaiizor.Controls.MaterialCheckBox()
        Me.CbxRedSpider = New ReaLTaiizor.Controls.MaterialCheckBox()
        Me.BtnStop = New ReaLTaiizor.Controls.MaterialButton()
        Me.BtnStart = New ReaLTaiizor.Controls.MaterialButton()
        Me.StatCard = New ReaLTaiizor.Controls.ParrotCard()
        Me.CardWelcome = New MaterialSkin.Controls.MaterialCard()
        Me.LabWelcome = New ReaLTaiizor.Controls.MaterialLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CardOutput = New ReaLTaiizor.Controls.MaterialCard()
        Me.TbxOutput = New System.Windows.Forms.TextBox()
        Me.LabOutput = New ReaLTaiizor.Controls.SmallLabel()
        Me.MaterialCard2 = New ReaLTaiizor.Controls.MaterialCard()
        Me.LabRedSpider = New ReaLTaiizor.Controls.SmallLabel()
        Me.CardJiyu = New ReaLTaiizor.Controls.MaterialCard()
        Me.BtnUniJiyuUsbDriver = New ReaLTaiizor.Controls.MaterialButton()
        Me.GetJiyuPasswd = New ReaLTaiizor.Controls.MaterialButton()
        Me.LabJiyu = New ReaLTaiizor.Controls.SmallLabel()
        Me.CardUDPAttack = New ReaLTaiizor.Controls.MaterialCard()
        Me.BtnReboot = New ReaLTaiizor.Controls.MaterialButton()
        Me.BtnHalt = New ReaLTaiizor.Controls.MaterialButton()
        Me.TbxCommand = New ReaLTaiizor.Controls.MaterialSingleTextBox()
        Me.TbxSendText = New ReaLTaiizor.Controls.MaterialSingleTextBox()
        Me.TbxPort = New ReaLTaiizor.Controls.MaterialSingleTextBox()
        Me.TbxIPAddress = New ReaLTaiizor.Controls.MaterialSingleTextBox()
        Me.BtnSendCommand = New ReaLTaiizor.Controls.MaterialButton()
        Me.BtnSendText = New ReaLTaiizor.Controls.MaterialButton()
        Me.LabUDPTips2 = New System.Windows.Forms.Label()
        Me.LabUDPTips1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabUDPAuthor = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabUDPWarn = New System.Windows.Forms.Label()
        Me.LabUDP = New ReaLTaiizor.Controls.SmallLabel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.CardLog = New ReaLTaiizor.Controls.MaterialCard()
        Me.BtnCleanLog = New ReaLTaiizor.Controls.MaterialButton()
        Me.BtnExportLog = New ReaLTaiizor.Controls.MaterialButton()
        Me.TbxLog = New System.Windows.Forms.TextBox()
        Me.LabLog = New ReaLTaiizor.Controls.SmallLabel()
        Me.CardUpdate = New ReaLTaiizor.Controls.MaterialCard()
        Me.BtnReCheckUpdate = New ReaLTaiizor.Controls.MaterialButton()
        Me.GbxLog = New System.Windows.Forms.GroupBox()
        Me.RtbUpdate = New System.Windows.Forms.RichTextBox()
        Me.GbxVersion = New System.Windows.Forms.GroupBox()
        Me.TbxVersion = New System.Windows.Forms.TextBox()
        Me.LabUpdate = New ReaLTaiizor.Controls.SmallLabel()
        Me.CardSettingGeneral = New ReaLTaiizor.Controls.MaterialCard()
        Me.SwitchStat = New ReaLTaiizor.Controls.MaterialSwitch()
        Me.SwitchLog = New ReaLTaiizor.Controls.MaterialSwitch()
        Me.LabSettingGeneral = New ReaLTaiizor.Controls.SmallLabel()
        Me.SwitchNotice = New ReaLTaiizor.Controls.MaterialSwitch()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.CardAbout = New ReaLTaiizor.Controls.ParrotCard()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MaterialDivider1 = New ReaLTaiizor.Controls.MaterialDivider()
        Me.PbtnMenu = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.PbtnClose = New System.Windows.Forms.PictureBox()
        Me.PbtnMinimize = New System.Windows.Forms.PictureBox()
        Me.TimStat = New System.Windows.Forms.Timer(Me.components)
        Me.TimMain = New System.Windows.Forms.Timer(Me.components)
        Me.TimNotice = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialDrawer1 = New ReaLTaiizor.Controls.MaterialDrawer()
        Me.TimLog = New System.Windows.Forms.Timer(Me.components)
        Me.CrownMenuStrip1.SuspendLayout()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.CardNotice.SuspendLayout()
        Me.TcNotice.SuspendLayout()
        Me.TpNotice1.SuspendLayout()
        Me.TpNotice2.SuspendLayout()
        Me.TpNotice3.SuspendLayout()
        Me.TpPreview.SuspendLayout()
        Me.MaterialCard1.SuspendLayout()
        Me.CardCho.SuspendLayout()
        Me.CardWelcome.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.CardOutput.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        Me.CardJiyu.SuspendLayout()
        Me.CardUDPAttack.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.CardLog.SuspendLayout()
        Me.CardUpdate.SuspendLayout()
        Me.GbxLog.SuspendLayout()
        Me.GbxVersion.SuspendLayout()
        Me.CardSettingGeneral.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PbtnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbtnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrownMenuStrip1
        '
        Me.CrownMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CrownMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.CrownMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.窗口WToolStripMenuItem1, Me.日志LToolStripMenuItem, Me.帮助HToolStripMenuItem1})
        Me.CrownMenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.CrownMenuStrip1.MdiWindowListItem = Me.窗口WToolStripMenuItem1
        Me.CrownMenuStrip1.Name = "CrownMenuStrip1"
        Me.CrownMenuStrip1.Padding = New System.Windows.Forms.Padding(3, 2, 0, 2)
        Me.CrownMenuStrip1.Size = New System.Drawing.Size(902, 27)
        Me.CrownMenuStrip1.TabIndex = 3
        Me.CrownMenuStrip1.Text = "CrownMenuStrip1"
        Me.CrownMenuStrip1.Visible = False
        '
        '窗口WToolStripMenuItem1
        '
        Me.窗口WToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.窗口WToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.主窗口MToolStripMenuItem1, Me.高级AToolStripMenuItem1, Me.监视器VToolStripMenuItem, Me.设置SToolStripMenuItem1, Me.测试窗口TToolStripMenuItem})
        Me.窗口WToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.窗口WToolStripMenuItem1.Name = "窗口WToolStripMenuItem1"
        Me.窗口WToolStripMenuItem1.Size = New System.Drawing.Size(64, 23)
        Me.窗口WToolStripMenuItem1.Text = "窗口(&W)"
        '
        '主窗口MToolStripMenuItem1
        '
        Me.主窗口MToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.主窗口MToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.主窗口MToolStripMenuItem1.Name = "主窗口MToolStripMenuItem1"
        Me.主窗口MToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.主窗口MToolStripMenuItem1.Text = "主窗口(&M)"
        '
        '高级AToolStripMenuItem1
        '
        Me.高级AToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.高级AToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.高级AToolStripMenuItem1.Name = "高级AToolStripMenuItem1"
        Me.高级AToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.高级AToolStripMenuItem1.Text = "高级(&A)"
        '
        '监视器VToolStripMenuItem
        '
        Me.监视器VToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.监视器VToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.监视器VToolStripMenuItem.Name = "监视器VToolStripMenuItem"
        Me.监视器VToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.监视器VToolStripMenuItem.Text = "监视器(&V)"
        '
        '设置SToolStripMenuItem1
        '
        Me.设置SToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.设置SToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.设置SToolStripMenuItem1.Name = "设置SToolStripMenuItem1"
        Me.设置SToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.设置SToolStripMenuItem1.Text = "设置(&S)"
        '
        '测试窗口TToolStripMenuItem
        '
        Me.测试窗口TToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.测试窗口TToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.测试窗口TToolStripMenuItem.Name = "测试窗口TToolStripMenuItem"
        Me.测试窗口TToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.测试窗口TToolStripMenuItem.Text = "测试窗口(&T)"
        '
        '日志LToolStripMenuItem
        '
        Me.日志LToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.日志LToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.查看日志VToolStripMenuItem1, Me.导出日志ToolStripMenuItem, Me.清除日志CToolStripMenuItem1})
        Me.日志LToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.日志LToolStripMenuItem.Name = "日志LToolStripMenuItem"
        Me.日志LToolStripMenuItem.Size = New System.Drawing.Size(58, 23)
        Me.日志LToolStripMenuItem.Text = "日志(&L)"
        '
        '查看日志VToolStripMenuItem1
        '
        Me.查看日志VToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.查看日志VToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.查看日志VToolStripMenuItem1.Name = "查看日志VToolStripMenuItem1"
        Me.查看日志VToolStripMenuItem1.Size = New System.Drawing.Size(140, 22)
        Me.查看日志VToolStripMenuItem1.Text = "查看日志(&V)"
        '
        '导出日志ToolStripMenuItem
        '
        Me.导出日志ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.导出日志ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.导出日志ToolStripMenuItem.Name = "导出日志ToolStripMenuItem"
        Me.导出日志ToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.导出日志ToolStripMenuItem.Text = "导出日志(&E)"
        '
        '清除日志CToolStripMenuItem1
        '
        Me.清除日志CToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.清除日志CToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.清除日志CToolStripMenuItem1.Name = "清除日志CToolStripMenuItem1"
        Me.清除日志CToolStripMenuItem1.Size = New System.Drawing.Size(140, 22)
        Me.清除日志CToolStripMenuItem1.Text = "清除日志(&C)"
        '
        '帮助HToolStripMenuItem1
        '
        Me.帮助HToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.帮助HToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.检测更新UToolStripMenuItem1, Me.关于CloudClassUtilityToolStripMenuItem1})
        Me.帮助HToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.帮助HToolStripMenuItem1.Name = "帮助HToolStripMenuItem1"
        Me.帮助HToolStripMenuItem1.Size = New System.Drawing.Size(61, 23)
        Me.帮助HToolStripMenuItem1.Text = "帮助(&H)"
        '
        '检测更新UToolStripMenuItem1
        '
        Me.检测更新UToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.检测更新UToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.检测更新UToolStripMenuItem1.Name = "检测更新UToolStripMenuItem1"
        Me.检测更新UToolStripMenuItem1.Size = New System.Drawing.Size(200, 22)
        Me.检测更新UToolStripMenuItem1.Text = "检测更新(&U)"
        '
        '关于CloudClassUtilityToolStripMenuItem1
        '
        Me.关于CloudClassUtilityToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.关于CloudClassUtilityToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.关于CloudClassUtilityToolStripMenuItem1.Name = "关于CloudClassUtilityToolStripMenuItem1"
        Me.关于CloudClassUtilityToolStripMenuItem1.Size = New System.Drawing.Size(200, 22)
        Me.关于CloudClassUtilityToolStripMenuItem1.Text = "关于 CloudClassUtility"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage3)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage4)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.ImageList = Me.ImageList1
        Me.MaterialTabControl1.Location = New System.Drawing.Point(0, 40)
        Me.MaterialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialTabControl1.Multiline = True
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(902, 579)
        Me.MaterialTabControl1.TabIndex = 5
        Me.MaterialTabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage1.Controls.Add(Me.CardNotice)
        Me.TabPage1.Controls.Add(Me.MaterialCard1)
        Me.TabPage1.Controls.Add(Me.CardCho)
        Me.TabPage1.Controls.Add(Me.BtnStop)
        Me.TabPage1.Controls.Add(Me.BtnStart)
        Me.TabPage1.Controls.Add(Me.StatCard)
        Me.TabPage1.Controls.Add(Me.CardWelcome)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(894, 544)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "主页"
        '
        'CardNotice
        '
        Me.CardNotice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CardNotice.Controls.Add(Me.TcNotice)
        Me.CardNotice.Controls.Add(Me.SmallLabel1)
        Me.CardNotice.Depth = 0
        Me.CardNotice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CardNotice.Location = New System.Drawing.Point(17, 207)
        Me.CardNotice.Margin = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardNotice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.CardNotice.Name = "CardNotice"
        Me.CardNotice.Padding = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardNotice.Size = New System.Drawing.Size(861, 104)
        Me.CardNotice.TabIndex = 17
        '
        'TcNotice
        '
        Me.TcNotice.AnimateEasingType = ReaLTaiizor.[Enum].Metro.EasingType.CubeOut
        Me.TcNotice.AnimateTime = 1000
        Me.TcNotice.BackgroundColor = System.Drawing.Color.White
        Me.TcNotice.Controls.Add(Me.TpNotice1)
        Me.TcNotice.Controls.Add(Me.TpNotice2)
        Me.TcNotice.Controls.Add(Me.TpNotice3)
        Me.TcNotice.Controls.Add(Me.TpPreview)
        Me.TcNotice.ControlsVisible = True
        Me.TcNotice.IsDerivedStyle = True
        Me.TcNotice.ItemSize = New System.Drawing.Size(100, 8)
        Me.TcNotice.Location = New System.Drawing.Point(17, 23)
        Me.TcNotice.MCursor = System.Windows.Forms.Cursors.Hand
        Me.TcNotice.Multiline = True
        Me.TcNotice.Name = "TcNotice"
        Me.TcNotice.SelectedIndex = 0
        Me.TcNotice.SelectedTextColor = System.Drawing.Color.White
        Me.TcNotice.Size = New System.Drawing.Size(838, 78)
        Me.TcNotice.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TcNotice.Speed = 100
        Me.TcNotice.Style = ReaLTaiizor.[Enum].Metro.Style.Light
        Me.TcNotice.StyleManager = Nothing
        Me.TcNotice.TabIndex = 17
        Me.TcNotice.TabStop = False
        Me.TcNotice.TabStyle = ReaLTaiizor.[Enum].Metro.TabStyle.Style2
        Me.TcNotice.ThemeAuthor = "Taiizor"
        Me.TcNotice.ThemeName = "MetroLight"
        Me.TcNotice.UnselectedTextColor = System.Drawing.Color.Gray
        '
        'TpNotice1
        '
        Me.TpNotice1.Controls.Add(Me.LabNotice1_2)
        Me.TpNotice1.Location = New System.Drawing.Point(4, 12)
        Me.TpNotice1.Name = "TpNotice1"
        Me.TpNotice1.Padding = New System.Windows.Forms.Padding(3)
        Me.TpNotice1.Size = New System.Drawing.Size(830, 62)
        Me.TpNotice1.TabIndex = 0
        '
        'LabNotice1_2
        '
        Me.LabNotice1_2.AutoSize = True
        Me.LabNotice1_2.Depth = 0
        Me.LabNotice1_2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LabNotice1_2.Location = New System.Drawing.Point(249, 22)
        Me.LabNotice1_2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.LabNotice1_2.Name = "LabNotice1_2"
        Me.LabNotice1_2.Size = New System.Drawing.Size(338, 19)
        Me.LabNotice1_2.TabIndex = 1
        Me.LabNotice1_2.Text = "Tips: 按下 F4 即可在脱离和恢复控制之间切换！"
        '
        'TpNotice2
        '
        Me.TpNotice2.Controls.Add(Me.LabNotice2)
        Me.TpNotice2.Controls.Add(Me.LabNotice)
        Me.TpNotice2.Location = New System.Drawing.Point(4, 12)
        Me.TpNotice2.Name = "TpNotice2"
        Me.TpNotice2.Padding = New System.Windows.Forms.Padding(3)
        Me.TpNotice2.Size = New System.Drawing.Size(830, 62)
        Me.TpNotice2.TabIndex = 1
        '
        'LabNotice2
        '
        Me.LabNotice2.AutoSize = True
        Me.LabNotice2.Depth = 0
        Me.LabNotice2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LabNotice2.Location = New System.Drawing.Point(331, 29)
        Me.LabNotice2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.LabNotice2.Name = "LabNotice2"
        Me.LabNotice2.Size = New System.Drawing.Size(169, 19)
        Me.LabNotice2.TabIndex = 13
        Me.LabNotice2.Text = "在 Github 上提出 Issue !"
        '
        'LabNotice
        '
        Me.LabNotice.AutoSize = True
        Me.LabNotice.Depth = 0
        Me.LabNotice.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LabNotice.Location = New System.Drawing.Point(312, 8)
        Me.LabNotice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.LabNotice.Name = "LabNotice"
        Me.LabNotice.Size = New System.Drawing.Size(207, 19)
        Me.LabNotice.TabIndex = 12
        Me.LabNotice.Text = "对于我们的新 UI 有什么建议?"
        '
        'TpNotice3
        '
        Me.TpNotice3.Controls.Add(Me.MaterialLabel1)
        Me.TpNotice3.Location = New System.Drawing.Point(4, 12)
        Me.TpNotice3.Name = "TpNotice3"
        Me.TpNotice3.Size = New System.Drawing.Size(830, 62)
        Me.TpNotice3.TabIndex = 2
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(281, 20)
        Me.MaterialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(268, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "遇到问题? 在 Github 给我们提出建议 !"
        '
        'TpPreview
        '
        Me.TpPreview.Controls.Add(Me.MaterialLabel2)
        Me.TpPreview.Location = New System.Drawing.Point(4, 12)
        Me.TpPreview.Name = "TpPreview"
        Me.TpPreview.Size = New System.Drawing.Size(830, 62)
        Me.TpPreview.TabIndex = 3
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(347, 20)
        Me.MaterialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(137, 19)
        Me.MaterialLabel2.TabIndex = 0
        Me.MaterialLabel2.Text = "您正在使用正式版 !"
        '
        'SmallLabel1
        '
        Me.SmallLabel1.AutoSize = True
        Me.SmallLabel1.BackColor = System.Drawing.Color.Transparent
        Me.SmallLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SmallLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.SmallLabel1.Location = New System.Drawing.Point(2, 5)
        Me.SmallLabel1.Name = "SmallLabel1"
        Me.SmallLabel1.Size = New System.Drawing.Size(33, 13)
        Me.SmallLabel1.TabIndex = 15
        Me.SmallLabel1.Text = "公告"
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.SliDelay)
        Me.MaterialCard1.Controls.Add(Me.SmallLabel2)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(17, 100)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.MaterialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.MaterialCard1.Size = New System.Drawing.Size(288, 77)
        Me.MaterialCard1.TabIndex = 15
        '
        'SliDelay
        '
        Me.SliDelay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SliDelay.Depth = 0
        Me.SliDelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.SliDelay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SliDelay.Location = New System.Drawing.Point(11, 19)
        Me.SliDelay.MouseState = MaterialSkin.MouseState.HOVER
        Me.SliDelay.Name = "SliDelay"
        Me.SliDelay.RangeMax = 2000
        Me.SliDelay.RangeMin = 200
        Me.SliDelay.ShowText = False
        Me.SliDelay.Size = New System.Drawing.Size(260, 40)
        Me.SliDelay.TabIndex = 4
        Me.SliDelay.Text = "MaterialSlider1"
        Me.SliDelay.Value = 500
        '
        'SmallLabel2
        '
        Me.SmallLabel2.AutoSize = True
        Me.SmallLabel2.BackColor = System.Drawing.Color.Transparent
        Me.SmallLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SmallLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.SmallLabel2.Location = New System.Drawing.Point(2, 5)
        Me.SmallLabel2.Name = "SmallLabel2"
        Me.SmallLabel2.Size = New System.Drawing.Size(33, 13)
        Me.SmallLabel2.TabIndex = 16
        Me.SmallLabel2.Text = "周期"
        '
        'CardCho
        '
        Me.CardCho.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CardCho.Controls.Add(Me.LabChooseWay)
        Me.CardCho.Controls.Add(Me.CbxCustom)
        Me.CardCho.Controls.Add(Me.TbxCustom)
        Me.CardCho.Controls.Add(Me.CbxRcc)
        Me.CardCho.Controls.Add(Me.CbxJiyu)
        Me.CardCho.Controls.Add(Me.CbxRedSpider)
        Me.CardCho.Depth = 0
        Me.CardCho.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CardCho.Location = New System.Drawing.Point(317, 100)
        Me.CardCho.Margin = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardCho.MouseState = MaterialSkin.MouseState.HOVER
        Me.CardCho.Name = "CardCho"
        Me.CardCho.Padding = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardCho.Size = New System.Drawing.Size(561, 77)
        Me.CardCho.TabIndex = 14
        '
        'LabChooseWay
        '
        Me.LabChooseWay.AutoSize = True
        Me.LabChooseWay.BackColor = System.Drawing.Color.Transparent
        Me.LabChooseWay.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabChooseWay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.LabChooseWay.Location = New System.Drawing.Point(2, 5)
        Me.LabChooseWay.Name = "LabChooseWay"
        Me.LabChooseWay.Size = New System.Drawing.Size(33, 13)
        Me.LabChooseWay.TabIndex = 14
        Me.LabChooseWay.Text = "方案"
        '
        'CbxCustom
        '
        Me.CbxCustom.AutoSize = True
        Me.CbxCustom.Depth = 0
        Me.CbxCustom.Location = New System.Drawing.Point(283, 22)
        Me.CbxCustom.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxCustom.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CbxCustom.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.CbxCustom.Name = "CbxCustom"
        Me.CbxCustom.Ripple = True
        Me.CbxCustom.Size = New System.Drawing.Size(91, 37)
        Me.CbxCustom.TabIndex = 8
        Me.CbxCustom.Text = "自定义: "
        Me.CbxCustom.UseVisualStyleBackColor = True
        '
        'TbxCustom
        '
        Me.TbxCustom.Depth = 0
        Me.TbxCustom.Location = New System.Drawing.Point(377, 32)
        Me.TbxCustom.MaxLength = 32767
        Me.TbxCustom.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.TbxCustom.Name = "TbxCustom"
        Me.TbxCustom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbxCustom.SelectedText = ""
        Me.TbxCustom.SelectionLength = 0
        Me.TbxCustom.SelectionStart = 0
        Me.TbxCustom.Size = New System.Drawing.Size(166, 25)
        Me.TbxCustom.TabIndex = 9
        Me.TbxCustom.TabStop = False
        Me.TbxCustom.UseAccentColor = False
        Me.TbxCustom.UseSystemPasswordChar = False
        '
        'CbxRcc
        '
        Me.CbxRcc.AutoSize = True
        Me.CbxRcc.Depth = 0
        Me.CbxRcc.Location = New System.Drawing.Point(183, 22)
        Me.CbxRcc.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxRcc.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CbxRcc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.CbxRcc.Name = "CbxRcc"
        Me.CbxRcc.Ripple = True
        Me.CbxRcc.Size = New System.Drawing.Size(83, 37)
        Me.CbxRcc.TabIndex = 7
        Me.CbxRcc.Text = "云课堂"
        Me.CbxRcc.UseVisualStyleBackColor = True
        '
        'CbxJiyu
        '
        Me.CbxJiyu.AutoSize = True
        Me.CbxJiyu.Depth = 0
        Me.CbxJiyu.Location = New System.Drawing.Point(12, 22)
        Me.CbxJiyu.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxJiyu.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CbxJiyu.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.CbxJiyu.Name = "CbxJiyu"
        Me.CbxJiyu.Ripple = True
        Me.CbxJiyu.Size = New System.Drawing.Size(67, 37)
        Me.CbxJiyu.TabIndex = 5
        Me.CbxJiyu.Text = "极域"
        Me.CbxJiyu.UseVisualStyleBackColor = True
        '
        'CbxRedSpider
        '
        Me.CbxRedSpider.AutoSize = True
        Me.CbxRedSpider.Depth = 0
        Me.CbxRedSpider.Location = New System.Drawing.Point(90, 22)
        Me.CbxRedSpider.Margin = New System.Windows.Forms.Padding(0)
        Me.CbxRedSpider.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CbxRedSpider.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.CbxRedSpider.Name = "CbxRedSpider"
        Me.CbxRedSpider.Ripple = True
        Me.CbxRedSpider.Size = New System.Drawing.Size(83, 37)
        Me.CbxRedSpider.TabIndex = 6
        Me.CbxRedSpider.Text = "红蜘蛛"
        Me.CbxRedSpider.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnStop.Depth = 0
        Me.BtnStop.DrawShadows = True
        Me.BtnStop.Enabled = False
        Me.BtnStop.HighEmphasis = True
        Me.BtnStop.Icon = Nothing
        Me.BtnStop.Location = New System.Drawing.Point(763, 20)
        Me.BtnStop.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.BtnStop.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(115, 36)
        Me.BtnStop.TabIndex = 3
        Me.BtnStop.Text = "恢复控制 (F4)"
        Me.BtnStop.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.BtnStop.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnStop.UseAccentColor = False
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BtnStart
        '
        Me.BtnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnStart.Depth = 0
        Me.BtnStart.DrawShadows = True
        Me.BtnStart.HighEmphasis = True
        Me.BtnStart.Icon = Nothing
        Me.BtnStart.Location = New System.Drawing.Point(634, 20)
        Me.BtnStart.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.BtnStart.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(115, 36)
        Me.BtnStart.TabIndex = 2
        Me.BtnStart.Text = "脱离控制 (F4)"
        Me.BtnStart.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.BtnStart.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnStart.UseAccentColor = False
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'StatCard
        '
        Me.StatCard.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.StatCard.BackColor = System.Drawing.Color.Transparent
        Me.StatCard.Color1 = System.Drawing.Color.DodgerBlue
        Me.StatCard.Color2 = System.Drawing.Color.LimeGreen
        Me.StatCard.ForeColor = System.Drawing.Color.White
        Me.StatCard.Location = New System.Drawing.Point(17, 377)
        Me.StatCard.Name = "StatCard"
        Me.StatCard.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.StatCard.Size = New System.Drawing.Size(861, 125)
        Me.StatCard.TabIndex = 12
        Me.StatCard.Text = "ParrotCard1"
        Me.StatCard.Text1 = "当前状态"
        Me.StatCard.Text2 = "实时刷新运行状态已关闭"
        Me.StatCard.Text3 = "CloudClassUtility 3.410"
        Me.StatCard.TextRenderingType = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'CardWelcome
        '
        Me.CardWelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CardWelcome.Controls.Add(Me.LabWelcome)
        Me.CardWelcome.Depth = 0
        Me.CardWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CardWelcome.Location = New System.Drawing.Point(17, 16)
        Me.CardWelcome.Margin = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardWelcome.MouseState = MaterialSkin.MouseState.HOVER
        Me.CardWelcome.Name = "CardWelcome"
        Me.CardWelcome.Padding = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardWelcome.Size = New System.Drawing.Size(288, 52)
        Me.CardWelcome.TabIndex = 0
        '
        'LabWelcome
        '
        Me.LabWelcome.AutoSize = True
        Me.LabWelcome.Depth = 0
        Me.LabWelcome.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LabWelcome.Location = New System.Drawing.Point(17, 16)
        Me.LabWelcome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.LabWelcome.Name = "LabWelcome"
        Me.LabWelcome.Size = New System.Drawing.Size(249, 19)
        Me.LabWelcome.TabIndex = 0
        Me.LabWelcome.Text = "欢迎使用 CloudClassUtility v3.410 !"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CardOutput)
        Me.TabPage2.Controls.Add(Me.MaterialCard2)
        Me.TabPage2.Controls.Add(Me.CardJiyu)
        Me.TabPage2.Controls.Add(Me.CardUDPAttack)
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(894, 544)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "高级"
        '
        'CardOutput
        '
        Me.CardOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CardOutput.Controls.Add(Me.TbxOutput)
        Me.CardOutput.Controls.Add(Me.LabOutput)
        Me.CardOutput.Depth = 0
        Me.CardOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CardOutput.Location = New System.Drawing.Point(361, 19)
        Me.CardOutput.Margin = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardOutput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.CardOutput.Name = "CardOutput"
        Me.CardOutput.Padding = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardOutput.Size = New System.Drawing.Size(514, 367)
        Me.CardOutput.TabIndex = 3
        '
        'TbxOutput
        '
        Me.TbxOutput.AcceptsReturn = True
        Me.TbxOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbxOutput.Location = New System.Drawing.Point(17, 23)
        Me.TbxOutput.MaxLength = 0
        Me.TbxOutput.Multiline = True
        Me.TbxOutput.Name = "TbxOutput"
        Me.TbxOutput.ReadOnly = True
        Me.TbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TbxOutput.Size = New System.Drawing.Size(480, 325)
        Me.TbxOutput.TabIndex = 8
        '
        'LabOutput
        '
        Me.LabOutput.AutoSize = True
        Me.LabOutput.BackColor = System.Drawing.Color.Transparent
        Me.LabOutput.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.LabOutput.Location = New System.Drawing.Point(2, 5)
        Me.LabOutput.Name = "LabOutput"
        Me.LabOutput.Size = New System.Drawing.Size(33, 13)
        Me.LabOutput.TabIndex = 0
        Me.LabOutput.Text = "输出"
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.LabRedSpider)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(361, 418)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.MaterialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.MaterialCard2.Size = New System.Drawing.Size(514, 71)
        Me.MaterialCard2.TabIndex = 2
        '
        'LabRedSpider
        '
        Me.LabRedSpider.AutoSize = True
        Me.LabRedSpider.BackColor = System.Drawing.Color.Transparent
        Me.LabRedSpider.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabRedSpider.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.LabRedSpider.Location = New System.Drawing.Point(2, 5)
        Me.LabRedSpider.Name = "LabRedSpider"
        Me.LabRedSpider.Size = New System.Drawing.Size(59, 13)
        Me.LabRedSpider.TabIndex = 17
        Me.LabRedSpider.Text = "红蜘蛛类"
        '
        'CardJiyu
        '
        Me.CardJiyu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CardJiyu.Controls.Add(Me.BtnUniJiyuUsbDriver)
        Me.CardJiyu.Controls.Add(Me.GetJiyuPasswd)
        Me.CardJiyu.Controls.Add(Me.LabJiyu)
        Me.CardJiyu.Depth = 0
        Me.CardJiyu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CardJiyu.Location = New System.Drawing.Point(19, 418)
        Me.CardJiyu.Margin = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardJiyu.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.CardJiyu.Name = "CardJiyu"
        Me.CardJiyu.Padding = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardJiyu.Size = New System.Drawing.Size(312, 71)
        Me.CardJiyu.TabIndex = 1
        '
        'BtnUniJiyuUsbDriver
        '
        Me.BtnUniJiyuUsbDriver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnUniJiyuUsbDriver.Depth = 0
        Me.BtnUniJiyuUsbDriver.DrawShadows = True
        Me.BtnUniJiyuUsbDriver.HighEmphasis = True
        Me.BtnUniJiyuUsbDriver.Icon = Nothing
        Me.BtnUniJiyuUsbDriver.Location = New System.Drawing.Point(143, 23)
        Me.BtnUniJiyuUsbDriver.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.BtnUniJiyuUsbDriver.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.BtnUniJiyuUsbDriver.Name = "BtnUniJiyuUsbDriver"
        Me.BtnUniJiyuUsbDriver.Size = New System.Drawing.Size(151, 36)
        Me.BtnUniJiyuUsbDriver.TabIndex = 10
        Me.BtnUniJiyuUsbDriver.Text = "卸载极域 USB 驱动"
        Me.BtnUniJiyuUsbDriver.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.BtnUniJiyuUsbDriver.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnUniJiyuUsbDriver.UseAccentColor = False
        Me.BtnUniJiyuUsbDriver.UseVisualStyleBackColor = True
        '
        'GetJiyuPasswd
        '
        Me.GetJiyuPasswd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GetJiyuPasswd.Depth = 0
        Me.GetJiyuPasswd.DrawShadows = True
        Me.GetJiyuPasswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GetJiyuPasswd.HighEmphasis = True
        Me.GetJiyuPasswd.Icon = Nothing
        Me.GetJiyuPasswd.Location = New System.Drawing.Point(18, 23)
        Me.GetJiyuPasswd.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.GetJiyuPasswd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.GetJiyuPasswd.Name = "GetJiyuPasswd"
        Me.GetJiyuPasswd.Size = New System.Drawing.Size(117, 36)
        Me.GetJiyuPasswd.TabIndex = 9
        Me.GetJiyuPasswd.Text = "获取极域密码"
        Me.GetJiyuPasswd.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.GetJiyuPasswd.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.GetJiyuPasswd.UseAccentColor = False
        Me.GetJiyuPasswd.UseVisualStyleBackColor = True
        '
        'LabJiyu
        '
        Me.LabJiyu.AutoSize = True
        Me.LabJiyu.BackColor = System.Drawing.Color.Transparent
        Me.LabJiyu.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabJiyu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.LabJiyu.Location = New System.Drawing.Point(2, 5)
        Me.LabJiyu.Name = "LabJiyu"
        Me.LabJiyu.Size = New System.Drawing.Size(46, 13)
        Me.LabJiyu.TabIndex = 17
        Me.LabJiyu.Text = "极域类"
        '
        'CardUDPAttack
        '
        Me.CardUDPAttack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CardUDPAttack.Controls.Add(Me.BtnReboot)
        Me.CardUDPAttack.Controls.Add(Me.BtnHalt)
        Me.CardUDPAttack.Controls.Add(Me.TbxCommand)
        Me.CardUDPAttack.Controls.Add(Me.TbxSendText)
        Me.CardUDPAttack.Controls.Add(Me.TbxPort)
        Me.CardUDPAttack.Controls.Add(Me.TbxIPAddress)
        Me.CardUDPAttack.Controls.Add(Me.BtnSendCommand)
        Me.CardUDPAttack.Controls.Add(Me.BtnSendText)
        Me.CardUDPAttack.Controls.Add(Me.LabUDPTips2)
        Me.CardUDPAttack.Controls.Add(Me.LabUDPTips1)
        Me.CardUDPAttack.Controls.Add(Me.Label8)
        Me.CardUDPAttack.Controls.Add(Me.Label7)
        Me.CardUDPAttack.Controls.Add(Me.Label6)
        Me.CardUDPAttack.Controls.Add(Me.LabUDPAuthor)
        Me.CardUDPAttack.Controls.Add(Me.Label4)
        Me.CardUDPAttack.Controls.Add(Me.Label3)
        Me.CardUDPAttack.Controls.Add(Me.LabUDPWarn)
        Me.CardUDPAttack.Controls.Add(Me.LabUDP)
        Me.CardUDPAttack.Depth = 0
        Me.CardUDPAttack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CardUDPAttack.Location = New System.Drawing.Point(19, 19)
        Me.CardUDPAttack.Margin = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardUDPAttack.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.CardUDPAttack.Name = "CardUDPAttack"
        Me.CardUDPAttack.Padding = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardUDPAttack.Size = New System.Drawing.Size(312, 367)
        Me.CardUDPAttack.TabIndex = 0
        '
        'BtnReboot
        '
        Me.BtnReboot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnReboot.Depth = 0
        Me.BtnReboot.DrawShadows = True
        Me.BtnReboot.HighEmphasis = True
        Me.BtnReboot.Icon = Nothing
        Me.BtnReboot.Location = New System.Drawing.Point(167, 282)
        Me.BtnReboot.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.BtnReboot.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.BtnReboot.Name = "BtnReboot"
        Me.BtnReboot.Size = New System.Drawing.Size(117, 36)
        Me.BtnReboot.TabIndex = 7
        Me.BtnReboot.Text = "填入重启指令"
        Me.BtnReboot.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.BtnReboot.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnReboot.UseAccentColor = False
        Me.BtnReboot.UseVisualStyleBackColor = True
        '
        'BtnHalt
        '
        Me.BtnHalt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnHalt.Depth = 0
        Me.BtnHalt.DrawShadows = True
        Me.BtnHalt.HighEmphasis = True
        Me.BtnHalt.Icon = Nothing
        Me.BtnHalt.Location = New System.Drawing.Point(28, 282)
        Me.BtnHalt.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.BtnHalt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.BtnHalt.Name = "BtnHalt"
        Me.BtnHalt.Size = New System.Drawing.Size(117, 36)
        Me.BtnHalt.TabIndex = 6
        Me.BtnHalt.Text = "填入关机指令"
        Me.BtnHalt.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.BtnHalt.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnHalt.UseAccentColor = False
        Me.BtnHalt.UseVisualStyleBackColor = True
        '
        'TbxCommand
        '
        Me.TbxCommand.Depth = 0
        Me.TbxCommand.Location = New System.Drawing.Point(86, 189)
        Me.TbxCommand.MaxLength = 100
        Me.TbxCommand.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.TbxCommand.Name = "TbxCommand"
        Me.TbxCommand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbxCommand.SelectedText = ""
        Me.TbxCommand.SelectionLength = 0
        Me.TbxCommand.SelectionStart = 0
        Me.TbxCommand.Size = New System.Drawing.Size(203, 25)
        Me.TbxCommand.TabIndex = 4
        Me.TbxCommand.TabStop = False
        Me.TbxCommand.UseAccentColor = False
        Me.TbxCommand.UseSystemPasswordChar = False
        '
        'TbxSendText
        '
        Me.TbxSendText.Depth = 0
        Me.TbxSendText.Location = New System.Drawing.Point(85, 100)
        Me.TbxSendText.MaxLength = 100
        Me.TbxSendText.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.TbxSendText.Name = "TbxSendText"
        Me.TbxSendText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbxSendText.SelectedText = ""
        Me.TbxSendText.SelectionLength = 0
        Me.TbxSendText.SelectionStart = 0
        Me.TbxSendText.Size = New System.Drawing.Size(204, 25)
        Me.TbxSendText.TabIndex = 2
        Me.TbxSendText.TabStop = False
        Me.TbxSendText.UseAccentColor = False
        Me.TbxSendText.UseSystemPasswordChar = False
        '
        'TbxPort
        '
        Me.TbxPort.Depth = 0
        Me.TbxPort.Location = New System.Drawing.Point(85, 65)
        Me.TbxPort.MaxLength = 32767
        Me.TbxPort.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.TbxPort.Name = "TbxPort"
        Me.TbxPort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbxPort.SelectedText = ""
        Me.TbxPort.SelectionLength = 0
        Me.TbxPort.SelectionStart = 0
        Me.TbxPort.Size = New System.Drawing.Size(204, 25)
        Me.TbxPort.TabIndex = 1
        Me.TbxPort.TabStop = False
        Me.TbxPort.Text = "4705"
        Me.TbxPort.UseAccentColor = False
        Me.TbxPort.UseSystemPasswordChar = False
        '
        'TbxIPAddress
        '
        Me.TbxIPAddress.Depth = 0
        Me.TbxIPAddress.Location = New System.Drawing.Point(86, 29)
        Me.TbxIPAddress.MaxLength = 32767
        Me.TbxIPAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.TbxIPAddress.Name = "TbxIPAddress"
        Me.TbxIPAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbxIPAddress.SelectedText = ""
        Me.TbxIPAddress.SelectionLength = 0
        Me.TbxIPAddress.SelectionStart = 0
        Me.TbxIPAddress.Size = New System.Drawing.Size(203, 25)
        Me.TbxIPAddress.TabIndex = 0
        Me.TbxIPAddress.TabStop = False
        Me.TbxIPAddress.UseAccentColor = False
        Me.TbxIPAddress.UseSystemPasswordChar = False
        '
        'BtnSendCommand
        '
        Me.BtnSendCommand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSendCommand.Depth = 0
        Me.BtnSendCommand.DrawShadows = True
        Me.BtnSendCommand.HighEmphasis = True
        Me.BtnSendCommand.Icon = Nothing
        Me.BtnSendCommand.Location = New System.Drawing.Point(236, 228)
        Me.BtnSendCommand.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.BtnSendCommand.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.BtnSendCommand.Name = "BtnSendCommand"
        Me.BtnSendCommand.Size = New System.Drawing.Size(53, 36)
        Me.BtnSendCommand.TabIndex = 5
        Me.BtnSendCommand.Text = "发送"
        Me.BtnSendCommand.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.BtnSendCommand.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnSendCommand.UseAccentColor = False
        Me.BtnSendCommand.UseVisualStyleBackColor = True
        '
        'BtnSendText
        '
        Me.BtnSendText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSendText.Depth = 0
        Me.BtnSendText.DrawShadows = True
        Me.BtnSendText.HighEmphasis = True
        Me.BtnSendText.Icon = Nothing
        Me.BtnSendText.Location = New System.Drawing.Point(236, 138)
        Me.BtnSendText.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.BtnSendText.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.BtnSendText.Name = "BtnSendText"
        Me.BtnSendText.Size = New System.Drawing.Size(53, 36)
        Me.BtnSendText.TabIndex = 3
        Me.BtnSendText.Text = "发送"
        Me.BtnSendText.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.BtnSendText.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnSendText.UseAccentColor = False
        Me.BtnSendText.UseVisualStyleBackColor = True
        '
        'LabUDPTips2
        '
        Me.LabUDPTips2.AutoSize = True
        Me.LabUDPTips2.Location = New System.Drawing.Point(86, 221)
        Me.LabUDPTips2.Name = "LabUDPTips2"
        Me.LabUDPTips2.Size = New System.Drawing.Size(106, 17)
        Me.LabUDPTips2.TabIndex = 36
        Me.LabUDPTips2.Text = "* 最多 100 个字符"
        '
        'LabUDPTips1
        '
        Me.LabUDPTips1.AutoSize = True
        Me.LabUDPTips1.Location = New System.Drawing.Point(85, 131)
        Me.LabUDPTips1.Name = "LabUDPTips1"
        Me.LabUDPTips1.Size = New System.Drawing.Size(106, 17)
        Me.LabUDPTips1.TabIndex = 35
        Me.LabUDPTips1.Text = "* 最多 100 个字符"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(86, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 17)
        Me.Label8.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "发送命令: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 17)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "发送文字: "
        '
        'LabUDPAuthor
        '
        Me.LabUDPAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabUDPAuthor.AutoSize = True
        Me.LabUDPAuthor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabUDPAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabUDPAuthor.Location = New System.Drawing.Point(66, 347)
        Me.LabUDPAuthor.Name = "LabUDPAuthor"
        Me.LabUDPAuthor.Size = New System.Drawing.Size(182, 17)
        Me.LabUDPAuthor.TabIndex = 31
        Me.LabUDPAuthor.Text = "本功能原理由 ht0Ruial 大佬提供"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "端口: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "IP 地址: "
        '
        'LabUDPWarn
        '
        Me.LabUDPWarn.AutoSize = True
        Me.LabUDPWarn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabUDPWarn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabUDPWarn.Location = New System.Drawing.Point(19, 330)
        Me.LabUDPWarn.Name = "LabUDPWarn"
        Me.LabUDPWarn.Size = New System.Drawing.Size(278, 17)
        Me.LabUDPWarn.TabIndex = 21
        Me.LabUDPWarn.Text = "警告: 因使用此功能而造成的任何后果, 与作者无关!"
        '
        'LabUDP
        '
        Me.LabUDP.AutoSize = True
        Me.LabUDP.BackColor = System.Drawing.Color.Transparent
        Me.LabUDP.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabUDP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.LabUDP.Location = New System.Drawing.Point(2, 5)
        Me.LabUDP.Name = "LabUDP"
        Me.LabUDP.Size = New System.Drawing.Size(87, 13)
        Me.LabUDP.TabIndex = 16
        Me.LabUDP.Text = "极域 UDP 攻击"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CardLog)
        Me.TabPage3.Controls.Add(Me.CardUpdate)
        Me.TabPage3.Controls.Add(Me.CardSettingGeneral)
        Me.TabPage3.ImageIndex = 2
        Me.TabPage3.Location = New System.Drawing.Point(4, 31)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(894, 544)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "设置"
        '
        'CardLog
        '
        Me.CardLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CardLog.Controls.Add(Me.BtnCleanLog)
        Me.CardLog.Controls.Add(Me.BtnExportLog)
        Me.CardLog.Controls.Add(Me.TbxLog)
        Me.CardLog.Controls.Add(Me.LabLog)
        Me.CardLog.Depth = 0
        Me.CardLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CardLog.Location = New System.Drawing.Point(16, 380)
        Me.CardLog.Margin = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardLog.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.CardLog.Name = "CardLog"
        Me.CardLog.Padding = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardLog.Size = New System.Drawing.Size(864, 144)
        Me.CardLog.TabIndex = 3
        '
        'BtnCleanLog
        '
        Me.BtnCleanLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnCleanLog.Depth = 0
        Me.BtnCleanLog.DrawShadows = True
        Me.BtnCleanLog.HighEmphasis = True
        Me.BtnCleanLog.Icon = Nothing
        Me.BtnCleanLog.Location = New System.Drawing.Point(761, 84)
        Me.BtnCleanLog.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.BtnCleanLog.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.BtnCleanLog.Name = "BtnCleanLog"
        Me.BtnCleanLog.Size = New System.Drawing.Size(85, 36)
        Me.BtnCleanLog.TabIndex = 6
        Me.BtnCleanLog.Text = "清除日志"
        Me.BtnCleanLog.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.BtnCleanLog.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnCleanLog.UseAccentColor = False
        Me.BtnCleanLog.UseVisualStyleBackColor = True
        '
        'BtnExportLog
        '
        Me.BtnExportLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnExportLog.Depth = 0
        Me.BtnExportLog.DrawShadows = True
        Me.BtnExportLog.HighEmphasis = True
        Me.BtnExportLog.Icon = Nothing
        Me.BtnExportLog.Location = New System.Drawing.Point(761, 23)
        Me.BtnExportLog.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.BtnExportLog.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.BtnExportLog.Name = "BtnExportLog"
        Me.BtnExportLog.Size = New System.Drawing.Size(85, 36)
        Me.BtnExportLog.TabIndex = 5
        Me.BtnExportLog.Text = "导出日志"
        Me.BtnExportLog.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.BtnExportLog.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnExportLog.UseAccentColor = False
        Me.BtnExportLog.UseVisualStyleBackColor = True
        '
        'TbxLog
        '
        Me.TbxLog.Location = New System.Drawing.Point(19, 23)
        Me.TbxLog.MaxLength = 0
        Me.TbxLog.Multiline = True
        Me.TbxLog.Name = "TbxLog"
        Me.TbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TbxLog.Size = New System.Drawing.Size(731, 101)
        Me.TbxLog.TabIndex = 4
        '
        'LabLog
        '
        Me.LabLog.AutoSize = True
        Me.LabLog.BackColor = System.Drawing.Color.Transparent
        Me.LabLog.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.LabLog.Location = New System.Drawing.Point(2, 5)
        Me.LabLog.Name = "LabLog"
        Me.LabLog.Size = New System.Drawing.Size(33, 13)
        Me.LabLog.TabIndex = 0
        Me.LabLog.Text = "日志"
        '
        'CardUpdate
        '
        Me.CardUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CardUpdate.Controls.Add(Me.BtnReCheckUpdate)
        Me.CardUpdate.Controls.Add(Me.GbxLog)
        Me.CardUpdate.Controls.Add(Me.GbxVersion)
        Me.CardUpdate.Controls.Add(Me.LabUpdate)
        Me.CardUpdate.Depth = 0
        Me.CardUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CardUpdate.Location = New System.Drawing.Point(14, 121)
        Me.CardUpdate.Margin = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardUpdate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.CardUpdate.Name = "CardUpdate"
        Me.CardUpdate.Padding = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardUpdate.Size = New System.Drawing.Size(866, 227)
        Me.CardUpdate.TabIndex = 2
        '
        'BtnReCheckUpdate
        '
        Me.BtnReCheckUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnReCheckUpdate.Depth = 0
        Me.BtnReCheckUpdate.DrawShadows = True
        Me.BtnReCheckUpdate.HighEmphasis = True
        Me.BtnReCheckUpdate.Icon = Nothing
        Me.BtnReCheckUpdate.Location = New System.Drawing.Point(21, 171)
        Me.BtnReCheckUpdate.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.BtnReCheckUpdate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.BtnReCheckUpdate.Name = "BtnReCheckUpdate"
        Me.BtnReCheckUpdate.Size = New System.Drawing.Size(85, 36)
        Me.BtnReCheckUpdate.TabIndex = 2
        Me.BtnReCheckUpdate.Text = "检查更新"
        Me.BtnReCheckUpdate.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal
        Me.BtnReCheckUpdate.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnReCheckUpdate.UseAccentColor = False
        Me.BtnReCheckUpdate.UseVisualStyleBackColor = True
        '
        'GbxLog
        '
        Me.GbxLog.Controls.Add(Me.RtbUpdate)
        Me.GbxLog.Location = New System.Drawing.Point(427, 23)
        Me.GbxLog.Name = "GbxLog"
        Me.GbxLog.Size = New System.Drawing.Size(419, 189)
        Me.GbxLog.TabIndex = 4
        Me.GbxLog.TabStop = False
        Me.GbxLog.Text = "更新日志"
        '
        'RtbUpdate
        '
        Me.RtbUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RtbUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RtbUpdate.Location = New System.Drawing.Point(6, 24)
        Me.RtbUpdate.Name = "RtbUpdate"
        Me.RtbUpdate.ReadOnly = True
        Me.RtbUpdate.Size = New System.Drawing.Size(407, 155)
        Me.RtbUpdate.TabIndex = 3
        Me.RtbUpdate.Text = ""
        '
        'GbxVersion
        '
        Me.GbxVersion.Controls.Add(Me.TbxVersion)
        Me.GbxVersion.Location = New System.Drawing.Point(21, 23)
        Me.GbxVersion.Name = "GbxVersion"
        Me.GbxVersion.Size = New System.Drawing.Size(379, 138)
        Me.GbxVersion.TabIndex = 3
        Me.GbxVersion.TabStop = False
        Me.GbxVersion.Text = "版本"
        '
        'TbxVersion
        '
        Me.TbxVersion.Location = New System.Drawing.Point(6, 24)
        Me.TbxVersion.Multiline = True
        Me.TbxVersion.Name = "TbxVersion"
        Me.TbxVersion.ReadOnly = True
        Me.TbxVersion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TbxVersion.Size = New System.Drawing.Size(367, 107)
        Me.TbxVersion.TabIndex = 1
        '
        'LabUpdate
        '
        Me.LabUpdate.AutoSize = True
        Me.LabUpdate.BackColor = System.Drawing.Color.Transparent
        Me.LabUpdate.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.LabUpdate.Location = New System.Drawing.Point(2, 5)
        Me.LabUpdate.Name = "LabUpdate"
        Me.LabUpdate.Size = New System.Drawing.Size(33, 13)
        Me.LabUpdate.TabIndex = 0
        Me.LabUpdate.Text = "更新"
        '
        'CardSettingGeneral
        '
        Me.CardSettingGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CardSettingGeneral.Controls.Add(Me.SwitchStat)
        Me.CardSettingGeneral.Controls.Add(Me.SwitchLog)
        Me.CardSettingGeneral.Controls.Add(Me.LabSettingGeneral)
        Me.CardSettingGeneral.Controls.Add(Me.SwitchNotice)
        Me.CardSettingGeneral.Depth = 0
        Me.CardSettingGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CardSettingGeneral.Location = New System.Drawing.Point(14, 16)
        Me.CardSettingGeneral.Margin = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardSettingGeneral.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.CardSettingGeneral.Name = "CardSettingGeneral"
        Me.CardSettingGeneral.Padding = New System.Windows.Forms.Padding(14, 16, 14, 16)
        Me.CardSettingGeneral.Size = New System.Drawing.Size(866, 74)
        Me.CardSettingGeneral.TabIndex = 1
        '
        'SwitchStat
        '
        Me.SwitchStat.AutoSize = True
        Me.SwitchStat.Checked = True
        Me.SwitchStat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SwitchStat.Depth = 0
        Me.SwitchStat.Location = New System.Drawing.Point(322, 21)
        Me.SwitchStat.Margin = New System.Windows.Forms.Padding(0)
        Me.SwitchStat.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.SwitchStat.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.SwitchStat.Name = "SwitchStat"
        Me.SwitchStat.Ripple = True
        Me.SwitchStat.Size = New System.Drawing.Size(186, 37)
        Me.SwitchStat.TabIndex = 3
        Me.SwitchStat.Text = "实时刷新运行状态"
        Me.SwitchStat.UseAccentColor = False
        Me.SwitchStat.UseVisualStyleBackColor = True
        '
        'SwitchLog
        '
        Me.SwitchLog.AutoSize = True
        Me.SwitchLog.Checked = True
        Me.SwitchLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SwitchLog.Depth = 0
        Me.SwitchLog.Location = New System.Drawing.Point(168, 21)
        Me.SwitchLog.Margin = New System.Windows.Forms.Padding(0)
        Me.SwitchLog.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.SwitchLog.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.SwitchLog.Name = "SwitchLog"
        Me.SwitchLog.Ripple = True
        Me.SwitchLog.Size = New System.Drawing.Size(154, 37)
        Me.SwitchLog.TabIndex = 1
        Me.SwitchLog.Text = "实时刷新日志"
        Me.SwitchLog.UseAccentColor = False
        Me.SwitchLog.UseVisualStyleBackColor = True
        '
        'LabSettingGeneral
        '
        Me.LabSettingGeneral.AutoSize = True
        Me.LabSettingGeneral.BackColor = System.Drawing.Color.Transparent
        Me.LabSettingGeneral.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabSettingGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.LabSettingGeneral.Location = New System.Drawing.Point(2, 5)
        Me.LabSettingGeneral.Name = "LabSettingGeneral"
        Me.LabSettingGeneral.Size = New System.Drawing.Size(33, 13)
        Me.LabSettingGeneral.TabIndex = 2
        Me.LabSettingGeneral.Text = "通用"
        '
        'SwitchNotice
        '
        Me.SwitchNotice.AutoSize = True
        Me.SwitchNotice.Checked = True
        Me.SwitchNotice.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SwitchNotice.Depth = 0
        Me.SwitchNotice.Location = New System.Drawing.Point(14, 21)
        Me.SwitchNotice.Margin = New System.Windows.Forms.Padding(0)
        Me.SwitchNotice.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.SwitchNotice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.SwitchNotice.Name = "SwitchNotice"
        Me.SwitchNotice.Ripple = True
        Me.SwitchNotice.Size = New System.Drawing.Size(154, 37)
        Me.SwitchNotice.TabIndex = 0
        Me.SwitchNotice.Text = "主页公告轮播"
        Me.SwitchNotice.UseAccentColor = False
        Me.SwitchNotice.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.CardAbout)
        Me.TabPage4.ImageIndex = 3
        Me.TabPage4.Location = New System.Drawing.Point(4, 31)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(894, 544)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "关于"
        '
        'CardAbout
        '
        Me.CardAbout.BackColor = System.Drawing.Color.Transparent
        Me.CardAbout.Color1 = System.Drawing.Color.DodgerBlue
        Me.CardAbout.Color2 = System.Drawing.Color.LimeGreen
        Me.CardAbout.ForeColor = System.Drawing.Color.White
        Me.CardAbout.Location = New System.Drawing.Point(-6, 0)
        Me.CardAbout.Name = "CardAbout"
        Me.CardAbout.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.CardAbout.Size = New System.Drawing.Size(912, 592)
        Me.CardAbout.TabIndex = 0
        Me.CardAbout.Text = "ParrotCard1"
        Me.CardAbout.Text1 = ""
        Me.CardAbout.Text2 = " CloudClassUtility -- 一款简易, 快速的微机课工具."
        Me.CardAbout.Text3 = " [C] 2022 Cookie987"
        Me.CardAbout.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "baseline_home_black_18dp.png")
        Me.ImageList1.Images.SetKeyName(1, "baseline_extension_black_18dp.png")
        Me.ImageList1.Images.SetKeyName(2, "baseline_settings_black_18dp.png")
        Me.ImageList1.Images.SetKeyName(3, "baseline_info_black_18dp.png")
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(902, 43)
        Me.MaterialDivider1.TabIndex = 8
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'PbtnMenu
        '
        Me.PbtnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.PbtnMenu.Image = Global.CloudClassUtility.My.Resources.Resources.baseline_menu_white_18dp
        Me.PbtnMenu.Location = New System.Drawing.Point(9, 9)
        Me.PbtnMenu.Name = "PbtnMenu"
        Me.PbtnMenu.Size = New System.Drawing.Size(24, 27)
        Me.PbtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbtnMenu.TabIndex = 2
        Me.PbtnMenu.TabStop = False
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Title.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(34, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(796, 27)
        Me.Title.TabIndex = 9
        Me.Title.Text = "CloudClassUtility"
        '
        'PbtnClose
        '
        Me.PbtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.PbtnClose.Image = Global.CloudClassUtility.My.Resources.Resources.baseline_close_white_18dp
        Me.PbtnClose.Location = New System.Drawing.Point(866, 9)
        Me.PbtnClose.Name = "PbtnClose"
        Me.PbtnClose.Size = New System.Drawing.Size(24, 27)
        Me.PbtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbtnClose.TabIndex = 2
        Me.PbtnClose.TabStop = False
        '
        'PbtnMinimize
        '
        Me.PbtnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbtnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.PbtnMinimize.Image = Global.CloudClassUtility.My.Resources.Resources.baseline_minimize_white_18dp
        Me.PbtnMinimize.Location = New System.Drawing.Point(836, 9)
        Me.PbtnMinimize.Name = "PbtnMinimize"
        Me.PbtnMinimize.Size = New System.Drawing.Size(24, 27)
        Me.PbtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbtnMinimize.TabIndex = 10
        Me.PbtnMinimize.TabStop = False
        '
        'TimStat
        '
        Me.TimStat.Enabled = True
        Me.TimStat.Interval = 2000
        '
        'TimMain
        '
        Me.TimMain.Interval = 200
        '
        'TimNotice
        '
        Me.TimNotice.Enabled = True
        Me.TimNotice.Interval = 5000
        '
        'MaterialDrawer1
        '
        Me.MaterialDrawer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MaterialDrawer1.AutoHide = True
        Me.MaterialDrawer1.BackgroundWithAccent = False
        Me.MaterialDrawer1.BaseTabControl = Nothing
        Me.MaterialDrawer1.Depth = 0
        Me.MaterialDrawer1.DrawerHideTabName = New String(-1) {}
        Me.MaterialDrawer1.DrawerNonClickTabPage = New System.Windows.Forms.TabPage(-1) {}
        Me.MaterialDrawer1.HighlightWithAccent = True
        Me.MaterialDrawer1.IndicatorWidth = 0
        Me.MaterialDrawer1.IsOpen = False
        Me.MaterialDrawer1.Location = New System.Drawing.Point(-254, 40)
        Me.MaterialDrawer1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        Me.MaterialDrawer1.Name = "MaterialDrawer1"
        Me.MaterialDrawer1.ShowIconsWhenHidden = False
        Me.MaterialDrawer1.ShowTabControl = Me.MaterialTabControl1
        Me.MaterialDrawer1.Size = New System.Drawing.Size(254, 575)
        Me.MaterialDrawer1.TabIndex = 11
        Me.MaterialDrawer1.Text = "MaterialDrawer1"
        Me.MaterialDrawer1.UseColors = True
        '
        'TimLog
        '
        Me.TimLog.Enabled = True
        Me.TimLog.Interval = 500
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(902, 618)
        Me.ControlBox = False
        Me.Controls.Add(Me.MaterialDrawer1)
        Me.Controls.Add(Me.PbtnMinimize)
        Me.Controls.Add(Me.PbtnClose)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.PbtnMenu)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.CrownMenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(126, 51)
        Me.Name = "FrmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "CloudClassUtility"
        Me.CrownMenuStrip1.ResumeLayout(False)
        Me.CrownMenuStrip1.PerformLayout()
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.CardNotice.ResumeLayout(False)
        Me.CardNotice.PerformLayout()
        Me.TcNotice.ResumeLayout(False)
        Me.TpNotice1.ResumeLayout(False)
        Me.TpNotice1.PerformLayout()
        Me.TpNotice2.ResumeLayout(False)
        Me.TpNotice2.PerformLayout()
        Me.TpNotice3.ResumeLayout(False)
        Me.TpNotice3.PerformLayout()
        Me.TpPreview.ResumeLayout(False)
        Me.TpPreview.PerformLayout()
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.CardCho.ResumeLayout(False)
        Me.CardCho.PerformLayout()
        Me.CardWelcome.ResumeLayout(False)
        Me.CardWelcome.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.CardOutput.ResumeLayout(False)
        Me.CardOutput.PerformLayout()
        Me.MaterialCard2.ResumeLayout(False)
        Me.MaterialCard2.PerformLayout()
        Me.CardJiyu.ResumeLayout(False)
        Me.CardJiyu.PerformLayout()
        Me.CardUDPAttack.ResumeLayout(False)
        Me.CardUDPAttack.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.CardLog.ResumeLayout(False)
        Me.CardLog.PerformLayout()
        Me.CardUpdate.ResumeLayout(False)
        Me.CardUpdate.PerformLayout()
        Me.GbxLog.ResumeLayout(False)
        Me.GbxVersion.ResumeLayout(False)
        Me.GbxVersion.PerformLayout()
        Me.CardSettingGeneral.ResumeLayout(False)
        Me.CardSettingGeneral.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.PbtnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbtnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents CrownMenuStrip1 As ReaLTaiizor.Controls.CrownMenuStrip
    Friend WithEvents 窗口WToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 主窗口MToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 高级AToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 设置SToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 日志LToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 查看日志VToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 导出日志ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 清除日志CToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 帮助HToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 检测更新UToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 关于CloudClassUtilityToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 监视器VToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 测试窗口TToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialTabControl1 As ReaLTaiizor.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents CardWelcome As MaterialSkin.Controls.MaterialCard
    Friend WithEvents LabWelcome As ReaLTaiizor.Controls.MaterialLabel
    Friend WithEvents MaterialDivider1 As ReaLTaiizor.Controls.MaterialDivider
    Friend WithEvents PbtnMenu As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents PbtnClose As PictureBox
    Friend WithEvents PbtnMinimize As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents StatCard As ReaLTaiizor.Controls.ParrotCard
    Friend WithEvents TimStat As Timer
    Friend WithEvents BtnStop As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents BtnStart As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents TimMain As Timer
    Friend WithEvents CbxCustom As ReaLTaiizor.Controls.MaterialCheckBox
    Friend WithEvents CbxRcc As ReaLTaiizor.Controls.MaterialCheckBox
    Friend WithEvents CbxRedSpider As ReaLTaiizor.Controls.MaterialCheckBox
    Friend WithEvents CbxJiyu As ReaLTaiizor.Controls.MaterialCheckBox
    Friend WithEvents TbxCustom As ReaLTaiizor.Controls.MaterialSingleTextBox
    Friend WithEvents CardCho As MaterialSkin.Controls.MaterialCard
    Friend WithEvents LabChooseWay As ReaLTaiizor.Controls.SmallLabel
    Friend WithEvents MaterialCard1 As ReaLTaiizor.Controls.MaterialCard
    Friend WithEvents SliDelay As MaterialSkin.Controls.MaterialSlider
    Friend WithEvents SmallLabel2 As ReaLTaiizor.Controls.SmallLabel
    Friend WithEvents CardNotice As ReaLTaiizor.Controls.MaterialCard
    Friend WithEvents TcNotice As ReaLTaiizor.Controls.MetroTabControl
    Friend WithEvents TpNotice1 As TabPage
    Friend WithEvents TpNotice2 As TabPage
    Friend WithEvents LabNotice2 As ReaLTaiizor.Controls.MaterialLabel
    Friend WithEvents LabNotice As ReaLTaiizor.Controls.MaterialLabel
    Friend WithEvents TpNotice3 As TabPage
    Friend WithEvents MaterialLabel1 As ReaLTaiizor.Controls.MaterialLabel
    Friend WithEvents SmallLabel1 As ReaLTaiizor.Controls.SmallLabel
    Friend WithEvents TimNotice As Timer
    Friend WithEvents TpPreview As TabPage
    Friend WithEvents MaterialLabel2 As ReaLTaiizor.Controls.MaterialLabel
    Friend WithEvents CardUDPAttack As ReaLTaiizor.Controls.MaterialCard
    Friend WithEvents LabUDP As ReaLTaiizor.Controls.SmallLabel
    Friend WithEvents BtnReboot As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents BtnHalt As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents TbxCommand As ReaLTaiizor.Controls.MaterialSingleTextBox
    Friend WithEvents TbxSendText As ReaLTaiizor.Controls.MaterialSingleTextBox
    Friend WithEvents TbxPort As ReaLTaiizor.Controls.MaterialSingleTextBox
    Friend WithEvents TbxIPAddress As ReaLTaiizor.Controls.MaterialSingleTextBox
    Friend WithEvents BtnSendCommand As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents BtnSendText As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents LabUDPTips2 As Label
    Friend WithEvents LabUDPTips1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabUDPAuthor As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabUDPWarn As Label
    Friend WithEvents CardJiyu As ReaLTaiizor.Controls.MaterialCard
    Friend WithEvents LabJiyu As ReaLTaiizor.Controls.SmallLabel
    Friend WithEvents BtnUniJiyuUsbDriver As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents GetJiyuPasswd As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents MaterialCard2 As ReaLTaiizor.Controls.MaterialCard
    Friend WithEvents LabRedSpider As ReaLTaiizor.Controls.SmallLabel
    Friend WithEvents CardOutput As ReaLTaiizor.Controls.MaterialCard
    Friend WithEvents TbxOutput As TextBox
    Friend WithEvents LabOutput As ReaLTaiizor.Controls.SmallLabel
    Friend WithEvents SwitchNotice As ReaLTaiizor.Controls.MaterialSwitch
    Friend WithEvents CardSettingGeneral As ReaLTaiizor.Controls.MaterialCard
    Friend WithEvents LabSettingGeneral As ReaLTaiizor.Controls.SmallLabel
    Friend WithEvents MaterialDrawer1 As ReaLTaiizor.Controls.MaterialDrawer
    Friend WithEvents CardUpdate As ReaLTaiizor.Controls.MaterialCard
    Friend WithEvents LabUpdate As ReaLTaiizor.Controls.SmallLabel
    Friend WithEvents BtnReCheckUpdate As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents GbxLog As GroupBox
    Friend WithEvents RtbUpdate As RichTextBox
    Friend WithEvents GbxVersion As GroupBox
    Friend WithEvents TbxVersion As TextBox
    Friend WithEvents CardLog As ReaLTaiizor.Controls.MaterialCard
    Friend WithEvents TbxLog As TextBox
    Friend WithEvents LabLog As ReaLTaiizor.Controls.SmallLabel
    Friend WithEvents BtnExportLog As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents BtnCleanLog As ReaLTaiizor.Controls.MaterialButton
    Friend WithEvents TimLog As Timer
    Friend WithEvents CardAbout As ReaLTaiizor.Controls.ParrotCard
    Friend WithEvents SwitchLog As ReaLTaiizor.Controls.MaterialSwitch
    Friend WithEvents LabNotice1_2 As ReaLTaiizor.Controls.MaterialLabel
    Friend WithEvents SwitchStat As ReaLTaiizor.Controls.MaterialSwitch
End Class
