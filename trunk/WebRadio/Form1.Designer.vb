<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TxtBoxURL = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CM_Edit = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_ACCEPT = New System.Windows.Forms.Button()
        Me.BTN_ADD = New System.Windows.Forms.Button()
        Me.txtBoxUrlEdit = New System.Windows.Forms.TextBox()
        Me.txtBoxNameEdit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernunterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Lbl_Volume = New System.Windows.Forms.Label()
        Me.Lbl_current = New System.Windows.Forms.Label()
        Me.NotifyIcon_Webradio = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CM_Notify = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.WebradioAnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbspielenWiederaufnehmenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.MUteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnMuteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeiserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LauterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.VorherigerSenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NächsterSenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeendenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBTN_PlayStop = New System.Windows.Forms.ToolStripButton()
        Me.TSBTN_Prev = New System.Windows.Forms.ToolStripButton()
        Me.TSBTN_Next = New System.Windows.Forms.ToolStripButton()
        Me.TSBTN_MuteUnmute = New System.Windows.Forms.ToolStripButton()
        Me.TSBTN_Panik = New System.Windows.Forms.ToolStripButton()
        Me.TSBTN_Maximize = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.SFDNew = New System.Windows.Forms.SaveFileDialog()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.CM_Edit.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CM_Notify.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(767, 377)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(759, 351)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "WebRadio"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.WebBrowser1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtBoxURL)
        Me.SplitContainer1.Size = New System.Drawing.Size(753, 342)
        Me.SplitContainer1.SplitterDistance = 216
        Me.SplitContainer1.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(216, 342)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Radio"
        Me.ColumnHeader1.Width = 180
        '
        'TxtBoxURL
        '
        Me.TxtBoxURL.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtBoxURL.Location = New System.Drawing.Point(0, 0)
        Me.TxtBoxURL.Name = "TxtBoxURL"
        Me.TxtBoxURL.Size = New System.Drawing.Size(533, 20)
        Me.TxtBoxURL.TabIndex = 1
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 20)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(533, 322)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://www.google.de", System.UriKind.Absolute)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(779, 371)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sender bearbeiten"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 46)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ListView2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.BTN_ACCEPT)
        Me.SplitContainer2.Panel2.Controls.Add(Me.BTN_ADD)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtBoxUrlEdit)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtBoxNameEdit)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer2.Size = New System.Drawing.Size(773, 367)
        Me.SplitContainer2.SplitterDistance = 257
        Me.SplitContainer2.TabIndex = 4
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView2.ContextMenuStrip = Me.CM_Edit
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(0, 0)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(257, 367)
        Me.ListView2.TabIndex = 8
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Radio"
        Me.ColumnHeader2.Width = 179
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "URL"
        Me.ColumnHeader3.Width = 320
        '
        'CM_Edit
        '
        Me.CM_Edit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BearbeitenToolStripMenuItem, Me.ToolStripSeparator1, Me.LöschenToolStripMenuItem})
        Me.CM_Edit.Name = "ContextMenuStrip1"
        Me.CM_Edit.Size = New System.Drawing.Size(131, 54)
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.BearbeitenToolStripMenuItem.Text = "&Bearbeiten"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(127, 6)
        '
        'LöschenToolStripMenuItem
        '
        Me.LöschenToolStripMenuItem.Name = "LöschenToolStripMenuItem"
        Me.LöschenToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.LöschenToolStripMenuItem.Text = "&Löschen"
        '
        'BTN_ACCEPT
        '
        Me.BTN_ACCEPT.Location = New System.Drawing.Point(245, 75)
        Me.BTN_ACCEPT.Name = "BTN_ACCEPT"
        Me.BTN_ACCEPT.Size = New System.Drawing.Size(92, 23)
        Me.BTN_ACCEPT.TabIndex = 14
        Me.BTN_ACCEPT.Text = "Übernehmen"
        Me.BTN_ACCEPT.UseVisualStyleBackColor = True
        '
        'BTN_ADD
        '
        Me.BTN_ADD.Location = New System.Drawing.Point(153, 75)
        Me.BTN_ADD.Name = "BTN_ADD"
        Me.BTN_ADD.Size = New System.Drawing.Size(86, 23)
        Me.BTN_ADD.TabIndex = 13
        Me.BTN_ADD.Text = "Hinzufügen"
        Me.BTN_ADD.UseVisualStyleBackColor = True
        '
        'txtBoxUrlEdit
        '
        Me.txtBoxUrlEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBoxUrlEdit.Location = New System.Drawing.Point(50, 42)
        Me.txtBoxUrlEdit.Name = "txtBoxUrlEdit"
        Me.txtBoxUrlEdit.Size = New System.Drawing.Size(457, 20)
        Me.txtBoxUrlEdit.TabIndex = 12
        '
        'txtBoxNameEdit
        '
        Me.txtBoxNameEdit.Location = New System.Drawing.Point(50, 16)
        Me.txtBoxNameEdit.Name = "txtBoxNameEdit"
        Me.txtBoxNameEdit.Size = New System.Drawing.Size(277, 20)
        Me.txtBoxNameEdit.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "URL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(773, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.ExtrasToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(773, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.ÖffnenToolStripMenuItem, Me.toolStripSeparator, Me.SpeichernToolStripMenuItem, Me.SpeichernunterToolStripMenuItem, Me.toolStripSeparator2, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Image = CType(resources.GetObject("NeuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NeuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.NeuToolStripMenuItem.Text = "&Neu"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Image = CType(resources.GetObject("ÖffnenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ÖffnenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Ö&ffnen"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(165, 6)
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Image = CType(resources.GetObject("SpeichernToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SpeichernToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SpeichernToolStripMenuItem.Text = "&Speichern"
        '
        'SpeichernunterToolStripMenuItem
        '
        Me.SpeichernunterToolStripMenuItem.Name = "SpeichernunterToolStripMenuItem"
        Me.SpeichernunterToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SpeichernunterToolStripMenuItem.Text = "Speichern &unter"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(165, 6)
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'ExtrasToolStripMenuItem
        '
        Me.ExtrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionenToolStripMenuItem})
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ExtrasToolStripMenuItem.Text = "E&xtras"
        '
        'OptionenToolStripMenuItem
        '
        Me.OptionenToolStripMenuItem.Name = "OptionenToolStripMenuItem"
        Me.OptionenToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.OptionenToolStripMenuItem.Text = "&Optionen"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "&Hilfe"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.InfoToolStripMenuItem.Text = "Inf&o..."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BTN_CLOSE)
        Me.Panel1.Controls.Add(Me.TrackBar1)
        Me.Panel1.Controls.Add(Me.Lbl_Volume)
        Me.Panel1.Controls.Add(Me.Lbl_current)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 383)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 51)
        Me.Panel1.TabIndex = 2
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CLOSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLOSE.Location = New System.Drawing.Point(730, 11)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(36, 28)
        Me.BTN_CLOSE.TabIndex = 3
        Me.BTN_CLOSE.Text = "X"
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.Location = New System.Drawing.Point(517, 3)
        Me.TrackBar1.Maximum = 25
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(199, 45)
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBar1.Value = 5
        '
        'Lbl_Volume
        '
        Me.Lbl_Volume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Volume.AutoSize = True
        Me.Lbl_Volume.Location = New System.Drawing.Point(425, 20)
        Me.Lbl_Volume.Name = "Lbl_Volume"
        Me.Lbl_Volume.Size = New System.Drawing.Size(86, 13)
        Me.Lbl_Volume.TabIndex = 2
        Me.Lbl_Volume.Text = "Lautstärke 100%"
        '
        'Lbl_current
        '
        Me.Lbl_current.AutoSize = True
        Me.Lbl_current.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_current.Location = New System.Drawing.Point(12, 16)
        Me.Lbl_current.Name = "Lbl_current"
        Me.Lbl_current.Size = New System.Drawing.Size(102, 18)
        Me.Lbl_current.TabIndex = 1
        Me.Lbl_current.Text = "Label Current"
        '
        'NotifyIcon_Webradio
        '
        Me.NotifyIcon_Webradio.ContextMenuStrip = Me.CM_Notify
        Me.NotifyIcon_Webradio.Icon = CType(resources.GetObject("NotifyIcon_Webradio.Icon"), System.Drawing.Icon)
        Me.NotifyIcon_Webradio.Text = "WebRadio"
        Me.NotifyIcon_Webradio.Visible = True
        '
        'CM_Notify
        '
        Me.CM_Notify.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WebradioAnzeigenToolStripMenuItem, Me.AbspielenWiederaufnehmenToolStripMenuItem, Me.ToolStripSeparator5, Me.MUteToolStripMenuItem, Me.UnMuteToolStripMenuItem, Me.LeiserToolStripMenuItem, Me.LauterToolStripMenuItem, Me.ToolStripSeparator3, Me.VorherigerSenderToolStripMenuItem, Me.NächsterSenderToolStripMenuItem, Me.SenderToolStripMenuItem, Me.ToolStripSeparator4, Me.BeendenToolStripMenuItem1})
        Me.CM_Notify.Name = "CM_Notify"
        Me.CM_Notify.Size = New System.Drawing.Size(242, 402)
        '
        'WebradioAnzeigenToolStripMenuItem
        '
        Me.WebradioAnzeigenToolStripMenuItem.Image = Global.WebRadio.My.Resources.Resources.move
        Me.WebradioAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.WebradioAnzeigenToolStripMenuItem.Name = "WebradioAnzeigenToolStripMenuItem"
        Me.WebradioAnzeigenToolStripMenuItem.Size = New System.Drawing.Size(241, 38)
        Me.WebradioAnzeigenToolStripMenuItem.Text = "Webradio anzeigen"
        '
        'AbspielenWiederaufnehmenToolStripMenuItem
        '
        Me.AbspielenWiederaufnehmenToolStripMenuItem.Image = Global.WebRadio.My.Resources.Resources.play
        Me.AbspielenWiederaufnehmenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AbspielenWiederaufnehmenToolStripMenuItem.Name = "AbspielenWiederaufnehmenToolStripMenuItem"
        Me.AbspielenWiederaufnehmenToolStripMenuItem.Size = New System.Drawing.Size(241, 38)
        Me.AbspielenWiederaufnehmenToolStripMenuItem.Text = "Abspielen wiederaufnehmen"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(238, 6)
        '
        'MUteToolStripMenuItem
        '
        Me.MUteToolStripMenuItem.Image = Global.WebRadio.My.Resources.Resources.mute_2
        Me.MUteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MUteToolStripMenuItem.Name = "MUteToolStripMenuItem"
        Me.MUteToolStripMenuItem.Size = New System.Drawing.Size(241, 38)
        Me.MUteToolStripMenuItem.Text = "Mute"
        '
        'UnMuteToolStripMenuItem
        '
        Me.UnMuteToolStripMenuItem.Image = Global.WebRadio.My.Resources.Resources.volume_2
        Me.UnMuteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UnMuteToolStripMenuItem.Name = "UnMuteToolStripMenuItem"
        Me.UnMuteToolStripMenuItem.Size = New System.Drawing.Size(241, 38)
        Me.UnMuteToolStripMenuItem.Text = "UnMute"
        '
        'LeiserToolStripMenuItem
        '
        Me.LeiserToolStripMenuItem.Image = Global.WebRadio.My.Resources.Resources.minus
        Me.LeiserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LeiserToolStripMenuItem.Name = "LeiserToolStripMenuItem"
        Me.LeiserToolStripMenuItem.Size = New System.Drawing.Size(241, 38)
        Me.LeiserToolStripMenuItem.Text = "Leiser"
        '
        'LauterToolStripMenuItem
        '
        Me.LauterToolStripMenuItem.Image = Global.WebRadio.My.Resources.Resources.plus
        Me.LauterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LauterToolStripMenuItem.Name = "LauterToolStripMenuItem"
        Me.LauterToolStripMenuItem.Size = New System.Drawing.Size(241, 38)
        Me.LauterToolStripMenuItem.Text = "Lauter"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(238, 6)
        '
        'VorherigerSenderToolStripMenuItem
        '
        Me.VorherigerSenderToolStripMenuItem.Image = Global.WebRadio.My.Resources.Resources.previous_track
        Me.VorherigerSenderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VorherigerSenderToolStripMenuItem.Name = "VorherigerSenderToolStripMenuItem"
        Me.VorherigerSenderToolStripMenuItem.Size = New System.Drawing.Size(241, 38)
        Me.VorherigerSenderToolStripMenuItem.Text = "Vorheriger Sender"
        '
        'NächsterSenderToolStripMenuItem
        '
        Me.NächsterSenderToolStripMenuItem.Image = Global.WebRadio.My.Resources.Resources.next_track
        Me.NächsterSenderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NächsterSenderToolStripMenuItem.Name = "NächsterSenderToolStripMenuItem"
        Me.NächsterSenderToolStripMenuItem.Size = New System.Drawing.Size(241, 38)
        Me.NächsterSenderToolStripMenuItem.Text = "Nächster Sender"
        '
        'SenderToolStripMenuItem
        '
        Me.SenderToolStripMenuItem.Image = Global.WebRadio.My.Resources.Resources._432
        Me.SenderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SenderToolStripMenuItem.Name = "SenderToolStripMenuItem"
        Me.SenderToolStripMenuItem.Size = New System.Drawing.Size(241, 38)
        Me.SenderToolStripMenuItem.Text = "Sender"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(238, 6)
        '
        'BeendenToolStripMenuItem1
        '
        Me.BeendenToolStripMenuItem1.Image = Global.WebRadio.My.Resources.Resources.close
        Me.BeendenToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BeendenToolStripMenuItem1.Name = "BeendenToolStripMenuItem1"
        Me.BeendenToolStripMenuItem1.Size = New System.Drawing.Size(241, 38)
        Me.BeendenToolStripMenuItem1.Text = "Beenden"
        '
        'OFD
        '
        Me.OFD.DefaultExt = "ini"
        Me.OFD.Filter = "Senderliste (*.ini)|*.ini"
        Me.OFD.Title = "Senderliste öffnen..."
        '
        'SFD
        '
        Me.SFD.DefaultExt = "ini"
        Me.SFD.Filter = "Senderliste (*.ini)|*.ini"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBTN_PlayStop, Me.TSBTN_Prev, Me.TSBTN_Next, Me.TSBTN_MuteUnmute, Me.TSBTN_Panik, Me.TSBTN_Maximize})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(228, 39)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSBTN_PlayStop
        '
        Me.TSBTN_PlayStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBTN_PlayStop.Image = CType(resources.GetObject("TSBTN_PlayStop.Image"), System.Drawing.Image)
        Me.TSBTN_PlayStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBTN_PlayStop.ImageTransparentColor = System.Drawing.Color.White
        Me.TSBTN_PlayStop.Name = "TSBTN_PlayStop"
        Me.TSBTN_PlayStop.Size = New System.Drawing.Size(36, 36)
        Me.TSBTN_PlayStop.Tag = "Play"
        Me.TSBTN_PlayStop.Text = "Play"
        '
        'TSBTN_Prev
        '
        Me.TSBTN_Prev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBTN_Prev.Image = CType(resources.GetObject("TSBTN_Prev.Image"), System.Drawing.Image)
        Me.TSBTN_Prev.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBTN_Prev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBTN_Prev.Name = "TSBTN_Prev"
        Me.TSBTN_Prev.Size = New System.Drawing.Size(36, 36)
        Me.TSBTN_Prev.Text = "Vorheriger Sender"
        '
        'TSBTN_Next
        '
        Me.TSBTN_Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBTN_Next.Image = CType(resources.GetObject("TSBTN_Next.Image"), System.Drawing.Image)
        Me.TSBTN_Next.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBTN_Next.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBTN_Next.Name = "TSBTN_Next"
        Me.TSBTN_Next.Size = New System.Drawing.Size(36, 36)
        Me.TSBTN_Next.Text = "Nächster Sender"
        '
        'TSBTN_MuteUnmute
        '
        Me.TSBTN_MuteUnmute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBTN_MuteUnmute.Image = CType(resources.GetObject("TSBTN_MuteUnmute.Image"), System.Drawing.Image)
        Me.TSBTN_MuteUnmute.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBTN_MuteUnmute.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBTN_MuteUnmute.Name = "TSBTN_MuteUnmute"
        Me.TSBTN_MuteUnmute.Size = New System.Drawing.Size(36, 36)
        Me.TSBTN_MuteUnmute.Tag = "Mute"
        Me.TSBTN_MuteUnmute.Text = "Mute"
        '
        'TSBTN_Panik
        '
        Me.TSBTN_Panik.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBTN_Panik.Image = CType(resources.GetObject("TSBTN_Panik.Image"), System.Drawing.Image)
        Me.TSBTN_Panik.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBTN_Panik.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBTN_Panik.Name = "TSBTN_Panik"
        Me.TSBTN_Panik.Size = New System.Drawing.Size(36, 36)
        Me.TSBTN_Panik.Text = "Panik"
        '
        'TSBTN_Maximize
        '
        Me.TSBTN_Maximize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBTN_Maximize.Image = CType(resources.GetObject("TSBTN_Maximize.Image"), System.Drawing.Image)
        Me.TSBTN_Maximize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBTN_Maximize.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBTN_Maximize.Name = "TSBTN_Maximize"
        Me.TSBTN_Maximize.Size = New System.Drawing.Size(36, 36)
        Me.TSBTN_Maximize.Text = "Vollbild"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(773, 0)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(773, 38)
        Me.ToolStripContainer1.TabIndex = 4
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'SFDNew
        '
        Me.SFDNew.DefaultExt = "ini"
        Me.SFDNew.Filter = "Senderliste (*.ini)|*.ini"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 62)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(773, 434)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 496)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "WebRadio"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.CM_Edit.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CM_Notify.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SpeichernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpeichernunterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Lbl_current As System.Windows.Forms.Label
    Friend WithEvents Lbl_Volume As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon_Webradio As System.Windows.Forms.NotifyIcon
    Friend WithEvents TxtBoxURL As System.Windows.Forms.TextBox
    Friend WithEvents BTN_CLOSE As System.Windows.Forms.Button
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CM_Edit As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BearbeitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BTN_ACCEPT As System.Windows.Forms.Button
    Friend WithEvents BTN_ADD As System.Windows.Forms.Button
    Friend WithEvents txtBoxUrlEdit As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxNameEdit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CM_Notify As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents WebradioAnzeigenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VorherigerSenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NächsterSenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BeendenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbspielenWiederaufnehmenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MUteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UnMuteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents TSBTN_PlayStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSBTN_Prev As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSBTN_Next As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSBTN_MuteUnmute As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSBTN_Panik As System.Windows.Forms.ToolStripButton
    Friend WithEvents LeiserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LauterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSBTN_Maximize As System.Windows.Forms.ToolStripButton
    Friend WithEvents SenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SFDNew As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel


End Class
