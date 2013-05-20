<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.CB_MinimizeOnClose = New System.Windows.Forms.CheckBox()
        Me.CB_ShowInTaskbar = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_Panik = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_SenderWahl = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CB_MinimizeOnClose
        '
        Me.CB_MinimizeOnClose.AutoSize = True
        Me.CB_MinimizeOnClose.Location = New System.Drawing.Point(6, 19)
        Me.CB_MinimizeOnClose.Name = "CB_MinimizeOnClose"
        Me.CB_MinimizeOnClose.Size = New System.Drawing.Size(258, 17)
        Me.CB_MinimizeOnClose.TabIndex = 1
        Me.CB_MinimizeOnClose.Text = "Fenster beim Beenden minimieren, statt schließen"
        Me.CB_MinimizeOnClose.UseVisualStyleBackColor = True
        '
        'CB_ShowInTaskbar
        '
        Me.CB_ShowInTaskbar.AutoSize = True
        Me.CB_ShowInTaskbar.Location = New System.Drawing.Point(6, 42)
        Me.CB_ShowInTaskbar.Name = "CB_ShowInTaskbar"
        Me.CB_ShowInTaskbar.Size = New System.Drawing.Size(296, 17)
        Me.CB_ShowInTaskbar.TabIndex = 1
        Me.CB_ShowInTaskbar.Text = "Fenster beim Minimieren weiter in der Taskleiste anzeigen"
        Me.CB_ShowInTaskbar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CB_MinimizeOnClose)
        Me.GroupBox1.Controls.Add(Me.CB_ShowInTaskbar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 254)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 68)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Verhalten"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TXT_Panik)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(413, 122)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Paniktaste"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(294, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Paniktaste ist in den Optionen deaktiviert."
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Deaktiviert auf Knopfdruck das Abspielen des Webradios und versteckt es. Globaler" & _
    " Hotkey"
        '
        'TXT_Panik
        '
        Me.TXT_Panik.Location = New System.Drawing.Point(78, 55)
        Me.TXT_Panik.Name = "TXT_Panik"
        Me.TXT_Panik.Size = New System.Drawing.Size(116, 20)
        Me.TXT_Panik.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Paniktaste"
        '
        'Btn_Close
        '
        Me.Btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Close.Location = New System.Drawing.Point(343, 333)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(89, 23)
        Me.Btn_Close.TabIndex = 4
        Me.Btn_Close.Text = "Schliessen"
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.CB_SenderWahl)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 140)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(413, 108)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sender bei Start"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sender"
        '
        'CB_SenderWahl
        '
        Me.CB_SenderWahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SenderWahl.FormattingEnabled = True
        Me.CB_SenderWahl.Location = New System.Drawing.Point(80, 36)
        Me.CB_SenderWahl.Name = "CB_SenderWahl"
        Me.CB_SenderWahl.Size = New System.Drawing.Size(329, 21)
        Me.CB_SenderWahl.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(401, 34)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Wähle einen Sender, der bei Start des Programmes automatisch gestartet werden sol" & _
    "l."
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 368)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Optionen - Webradio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CB_MinimizeOnClose As System.Windows.Forms.CheckBox
    Friend WithEvents CB_ShowInTaskbar As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_Panik As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Close As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CB_SenderWahl As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
