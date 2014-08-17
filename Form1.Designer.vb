<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    'Inherits System.Windows.Forms.Form
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel5 = New DevComponents.DotNetBar.TabControlPanel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabItem5 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCon = New DevComponents.DotNetBar.ButtonX()
        Me.cbCon = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbShow = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
        Me.btnCheck = New DevComponents.DotNetBar.ButtonX()
        Me.cbCheck = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbEnd = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbHideMe = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.cbTask = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbNoNew = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbNoStop = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbNoStart = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbXFC = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbAuto = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbStartup = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.TabItem4 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListViewEx1 = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.cdName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cdMac = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cdIP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.nIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.cms.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.Transparent
        Me.TabControl1.CanReorderTabs = False
        Me.TabControl1.Controls.Add(Me.TabControlPanel5)
        Me.TabControl1.Controls.Add(Me.TabControlPanel4)
        Me.TabControl1.Controls.Add(Me.TabControlPanel3)
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ForeColor = System.Drawing.Color.Black
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(467, 237)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro
        Me.TabControl1.TabIndex = 3
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        Me.TabControl1.Tabs.Add(Me.TabItem3)
        Me.TabControl1.Tabs.Add(Me.TabItem4)
        Me.TabControl1.Tabs.Add(Me.TabItem5)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel5
        '
        Me.TabControlPanel5.Controls.Add(Me.LinkLabel1)
        Me.TabControlPanel5.Controls.Add(Me.Label15)
        Me.TabControlPanel5.Controls.Add(Me.PictureBox2)
        Me.TabControlPanel5.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel5.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel5.Name = "TabControlPanel5"
        Me.TabControlPanel5.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel5.Size = New System.Drawing.Size(467, 210)
        Me.TabControlPanel5.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControlPanel5.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel5.Style.GradientAngle = 90
        Me.TabControlPanel5.TabIndex = 5
        Me.TabControlPanel5.TabItem = Me.TabItem5
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 121)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(171, 17)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://mwifi.moefactory.com"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(9, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(394, 136)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "mWiFi - 网络共享程序" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "版本: 3.1(Build 0024, 内部版本号 3.2.0.24)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copyright © 2014 MoeFactory " & _
    "All Rights Reserved." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "致谢: 萌萌哒腹黑猫提供部分图片，小熊受积极参与测试并反馈 Bug" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mWiFi 在 GPL v2 协议" & _
    "下开放源代码，请访问官方网站以了解更多信息。"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.ForeColor = System.Drawing.Color.Black
        Me.PictureBox2.Image = Global.mWiFi.My.Resources.Resources.banner
        Me.PictureBox2.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(250, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'TabItem5
        '
        Me.TabItem5.AttachedControl = Me.TabControlPanel5
        Me.TabItem5.Name = "TabItem5"
        Me.TabItem5.Text = "关于 mWiFi"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.TextBox1)
        Me.TabControlPanel1.Controls.Add(Me.Label7)
        Me.TabControlPanel1.Controls.Add(Me.Label6)
        Me.TabControlPanel1.Controls.Add(Me.Label5)
        Me.TabControlPanel1.Controls.Add(Me.btnCon)
        Me.TabControlPanel1.Controls.Add(Me.cbCon)
        Me.TabControlPanel1.Controls.Add(Me.TextBoxX1)
        Me.TabControlPanel1.Controls.Add(Me.Label3)
        Me.TabControlPanel1.Controls.Add(Me.Label1)
        Me.TabControlPanel1.Controls.Add(Me.Label2)
        Me.TabControlPanel1.Controls.Add(Me.cbShow)
        Me.TabControlPanel1.Controls.Add(Me.TextBoxX2)
        Me.TabControlPanel1.Controls.Add(Me.PictureBox1)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(467, 210)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(7, 214)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(780, 190)
        Me.TextBox1.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(4, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(222, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "支持英文、数字、符号，8~20 个字符。"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(4, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "默认自动选择，否则请手动选择已联网的连接。"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "要共享的连接:"
        '
        'btnCon
        '
        Me.btnCon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCon.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCon.Location = New System.Drawing.Point(73, 161)
        Me.btnCon.Name = "btnCon"
        Me.btnCon.Size = New System.Drawing.Size(111, 36)
        Me.btnCon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCon.TabIndex = 10
        Me.btnCon.Text = "开始共享"
        '
        'cbCon
        '
        Me.cbCon.DisplayMember = "Text"
        Me.cbCon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCon.ForeColor = System.Drawing.Color.Black
        Me.cbCon.FormattingEnabled = True
        Me.cbCon.ItemHeight = 17
        Me.cbCon.Location = New System.Drawing.Point(93, 115)
        Me.cbCon.Name = "cbCon"
        Me.cbCon.Size = New System.Drawing.Size(158, 23)
        Me.cbCon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbCon.TabIndex = 9
        '
        'TextBoxX1
        '
        Me.TextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX1.Location = New System.Drawing.Point(93, 4)
        Me.TextBoxX1.MaxLength = 13
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.PreventEnterBeep = True
        Me.TextBoxX1.Size = New System.Drawing.Size(158, 23)
        Me.TextBoxX1.TabIndex = 3
        Me.TextBoxX1.Text = "mWiFi-Free"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "无线网络密码:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "无线网络名称:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "支持中文、英文、数字、符号，1~13 个字符。"
        '
        'cbShow
        '
        Me.cbShow.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.cbShow.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbShow.Checked = True
        Me.cbShow.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbShow.CheckValue = "Y"
        Me.cbShow.ForeColor = System.Drawing.Color.Black
        Me.cbShow.Location = New System.Drawing.Point(7, 96)
        Me.cbShow.Name = "cbShow"
        Me.cbShow.Size = New System.Drawing.Size(70, 17)
        Me.cbShow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbShow.TabIndex = 6
        Me.cbShow.Text = "显示密码"
        '
        'TextBoxX2
        '
        Me.TextBoxX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX2.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX2.Location = New System.Drawing.Point(93, 50)
        Me.TextBoxX2.MaxLength = 20
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.PreventEnterBeep = True
        Me.TextBoxX2.Size = New System.Drawing.Size(158, 23)
        Me.TextBoxX2.TabIndex = 5
        Me.TextBoxX2.Text = "12345678"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.mWiFi.My.Resources.Resources._3
        Me.PictureBox1.Location = New System.Drawing.Point(265, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "无线网络设置"
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.btnCheck)
        Me.TabControlPanel4.Controls.Add(Me.cbCheck)
        Me.TabControlPanel4.Controls.Add(Me.cbEnd)
        Me.TabControlPanel4.Controls.Add(Me.cbHideMe)
        Me.TabControlPanel4.Controls.Add(Me.btnSave)
        Me.TabControlPanel4.Controls.Add(Me.cbTask)
        Me.TabControlPanel4.Controls.Add(Me.GroupBox1)
        Me.TabControlPanel4.Controls.Add(Me.cbXFC)
        Me.TabControlPanel4.Controls.Add(Me.cbAuto)
        Me.TabControlPanel4.Controls.Add(Me.cbStartup)
        Me.TabControlPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(467, 210)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 4
        Me.TabControlPanel4.TabItem = Me.TabItem4
        '
        'btnCheck
        '
        Me.btnCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCheck.Location = New System.Drawing.Point(4, 176)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(94, 23)
        Me.btnCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCheck.TabIndex = 9
        Me.btnCheck.Text = "手动检查更新"
        '
        'cbCheck
        '
        Me.cbCheck.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.cbCheck.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbCheck.ForeColor = System.Drawing.Color.Black
        Me.cbCheck.Location = New System.Drawing.Point(4, 146)
        Me.cbCheck.Name = "cbCheck"
        Me.cbCheck.Size = New System.Drawing.Size(177, 23)
        Me.cbCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbCheck.TabIndex = 7
        Me.cbCheck.Text = "在启动时检查 mWiFi 更新"
        '
        'cbEnd
        '
        Me.cbEnd.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.cbEnd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbEnd.ForeColor = System.Drawing.Color.Black
        Me.cbEnd.Location = New System.Drawing.Point(4, 86)
        Me.cbEnd.Name = "cbEnd"
        Me.cbEnd.Size = New System.Drawing.Size(163, 23)
        Me.cbEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbEnd.TabIndex = 6
        Me.cbEnd.Text = "关闭主界面时退出 mWiFi"
        '
        'cbHideMe
        '
        Me.cbHideMe.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.cbHideMe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbHideMe.ForeColor = System.Drawing.Color.Black
        Me.cbHideMe.Location = New System.Drawing.Point(4, 56)
        Me.cbHideMe.Name = "cbHideMe"
        Me.cbHideMe.Size = New System.Drawing.Size(163, 23)
        Me.cbHideMe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbHideMe.TabIndex = 5
        Me.cbHideMe.Text = "启动程序时不显示主界面"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Location = New System.Drawing.Point(380, 175)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "保存"
        '
        'cbTask
        '
        Me.cbTask.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.cbTask.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbTask.Checked = True
        Me.cbTask.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTask.CheckValue = "Y"
        Me.cbTask.ForeColor = System.Drawing.Color.Black
        Me.cbTask.Location = New System.Drawing.Point(263, 0)
        Me.cbTask.Name = "cbTask"
        Me.cbTask.Size = New System.Drawing.Size(110, 23)
        Me.cbTask.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbTask.TabIndex = 0
        Me.cbTask.Text = "显示任务栏图标"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbNoNew)
        Me.GroupBox1.Controls.Add(Me.cbNoStop)
        Me.GroupBox1.Controls.Add(Me.cbNoStart)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(255, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 112)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                          "
        '
        'cbNoNew
        '
        Me.cbNoNew.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.cbNoNew.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbNoNew.Checked = True
        Me.cbNoNew.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbNoNew.CheckValue = "Y"
        Me.cbNoNew.ForeColor = System.Drawing.Color.Black
        Me.cbNoNew.Location = New System.Drawing.Point(8, 86)
        Me.cbNoNew.Name = "cbNoNew"
        Me.cbNoNew.Size = New System.Drawing.Size(122, 23)
        Me.cbNoNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbNoNew.TabIndex = 2
        Me.cbNoNew.Text = "新设备连接时提示"
        '
        'cbNoStop
        '
        Me.cbNoStop.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.cbNoStop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbNoStop.Checked = True
        Me.cbNoStop.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbNoStop.CheckValue = "Y"
        Me.cbNoStop.ForeColor = System.Drawing.Color.Black
        Me.cbNoStop.Location = New System.Drawing.Point(8, 56)
        Me.cbNoStop.Name = "cbNoStop"
        Me.cbNoStop.Size = New System.Drawing.Size(110, 23)
        Me.cbNoStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbNoStop.TabIndex = 1
        Me.cbNoStop.Text = "停止共享时提示"
        '
        'cbNoStart
        '
        Me.cbNoStart.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.cbNoStart.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbNoStart.Checked = True
        Me.cbNoStart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbNoStart.CheckValue = "Y"
        Me.cbNoStart.ForeColor = System.Drawing.Color.Black
        Me.cbNoStart.Location = New System.Drawing.Point(8, 26)
        Me.cbNoStart.Name = "cbNoStart"
        Me.cbNoStart.Size = New System.Drawing.Size(110, 23)
        Me.cbNoStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbNoStart.TabIndex = 0
        Me.cbNoStart.Text = "启动共享时提示"
        '
        'cbXFC
        '
        Me.cbXFC.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.cbXFC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbXFC.Checked = True
        Me.cbXFC.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbXFC.CheckValue = "Y"
        Me.cbXFC.ForeColor = System.Drawing.Color.Black
        Me.cbXFC.Location = New System.Drawing.Point(4, 116)
        Me.cbXFC.Name = "cbXFC"
        Me.cbXFC.Size = New System.Drawing.Size(100, 23)
        Me.cbXFC.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbXFC.TabIndex = 2
        Me.cbXFC.Text = "显示悬浮窗"
        '
        'cbAuto
        '
        Me.cbAuto.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.cbAuto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbAuto.ForeColor = System.Drawing.Color.Black
        Me.cbAuto.Location = New System.Drawing.Point(4, 26)
        Me.cbAuto.Name = "cbAuto"
        Me.cbAuto.Size = New System.Drawing.Size(177, 23)
        Me.cbAuto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbAuto.TabIndex = 1
        Me.cbAuto.Text = "启动 mWiFi 时自动开始共享"
        '
        'cbStartup
        '
        Me.cbStartup.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.cbStartup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbStartup.ForeColor = System.Drawing.Color.Black
        Me.cbStartup.Location = New System.Drawing.Point(4, 0)
        Me.cbStartup.Name = "cbStartup"
        Me.cbStartup.Size = New System.Drawing.Size(100, 23)
        Me.cbStartup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbStartup.TabIndex = 0
        Me.cbStartup.Text = "开机自动启动"
        '
        'TabItem4
        '
        Me.TabItem4.AttachedControl = Me.TabControlPanel4
        Me.TabItem4.Name = "TabItem4"
        Me.TabItem4.Text = "mWiFi 设置"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.Label18)
        Me.TabControlPanel3.Controls.Add(Me.Label17)
        Me.TabControlPanel3.Controls.Add(Me.Label16)
        Me.TabControlPanel3.Controls.Add(Me.Label14)
        Me.TabControlPanel3.Controls.Add(Me.Label13)
        Me.TabControlPanel3.Controls.Add(Me.Label12)
        Me.TabControlPanel3.Controls.Add(Me.Label11)
        Me.TabControlPanel3.Controls.Add(Me.Label10)
        Me.TabControlPanel3.Controls.Add(Me.Label9)
        Me.TabControlPanel3.Controls.Add(Me.Label8)
        Me.TabControlPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(467, 210)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        Me.TabControlPanel3.TabItem = Me.TabItem3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(260, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 17)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "设备接收流量: 0 KB"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(4, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 17)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "无线电波类型: 不详"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(260, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 17)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "设备上传速度: 0 KB/s"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(260, 146)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(125, 17)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "设备下载速度: 0 KB/s"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(260, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 17)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "设备发送流量: 0 KB"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(260, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "累计节省流量: 0 KB"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(4, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "设备数量上限: [MaxUser]"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(4, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "已连接设备数: 0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(4, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "无线网络频道: 不详"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(4, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "网络物理地址: 不详"
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel3
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "无线网络状态"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.Label4)
        Me.TabControlPanel2.Controls.Add(Me.ListViewEx1)
        Me.TabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(467, 210)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(447, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "点击设备名称可以修改，不能为空。设备 IP 地址需要在连接后等待一段时间出现。"
        '
        'ListViewEx1
        '
        Me.ListViewEx1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.ListViewEx1.Border.Class = "ListViewBorder"
        Me.ListViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ListViewEx1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cdName, Me.cdMac, Me.cdIP})
        Me.ListViewEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.ListViewEx1.ForeColor = System.Drawing.Color.Black
        Me.ListViewEx1.FullRowSelect = True
        Me.ListViewEx1.Location = New System.Drawing.Point(0, 26)
        Me.ListViewEx1.Name = "ListViewEx1"
        Me.ListViewEx1.Size = New System.Drawing.Size(467, 182)
        Me.ListViewEx1.TabIndex = 0
        Me.ListViewEx1.UseCompatibleStateImageBehavior = False
        Me.ListViewEx1.View = System.Windows.Forms.View.Details
        '
        'cdName
        '
        Me.cdName.Text = "设备名称"
        Me.cdName.Width = 118
        '
        'cdMac
        '
        Me.cdMac.Text = "设备 MAC 地址"
        Me.cdMac.Width = 155
        '
        'cdIP
        '
        Me.cdIP.Text = "设备 IP 地址"
        Me.cdIP.Width = 147
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "已连接的设备"
        '
        'Timer1
        '
        Me.Timer1.Interval = 2500
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'nIcon
        '
        Me.nIcon.Text = "mWiFi"
        Me.nIcon.Visible = True
        '
        'cms
        '
        Me.cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsShow, Me.cmdExit})
        Me.cms.Name = "cms"
        Me.cms.Size = New System.Drawing.Size(150, 48)
        '
        'cmsShow
        '
        Me.cmsShow.Name = "cmsShow"
        Me.cmsShow.Size = New System.Drawing.Size(149, 22)
        Me.cmsShow.Text = "显示主界面(&S)"
        '
        'cmdExit
        '
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(149, 22)
        Me.cmdExit.Text = "退出(&E)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 237)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "mWiFi"
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel5.ResumeLayout(False)
        Me.TabControlPanel5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControlPanel3.ResumeLayout(False)
        Me.TabControlPanel3.PerformLayout()
        Me.TabControlPanel2.ResumeLayout(False)
        Me.TabControlPanel2.PerformLayout()
        Me.cms.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents cbCon As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbShow As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCon As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents cbStartup As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabItem4 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents cbAuto As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabControlPanel5 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabItem5 As DevComponents.DotNetBar.TabItem
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ListViewEx1 As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents cdName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cdMac As System.Windows.Forms.ColumnHeader
    Friend WithEvents nIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbTask As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbNoNew As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbNoStop As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbNoStart As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbXFC As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cbHideMe As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbEnd As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cdIP As System.Windows.Forms.ColumnHeader
    Friend WithEvents cbCheck As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btnCheck As DevComponents.DotNetBar.ButtonX

End Class
