Imports System.Runtime.InteropServices
Imports System.IO
Imports WebRadio.CustomControls

<Author("Ronny Witzgall")> _
Public Class Form1

#Region "Paniktaste"

    Dim WithEvents Timer1 As New Timer With {.Enabled = True, .Interval = 10} 'Timer
    Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short 'Api declare
    Dim pressed As Short = -32767 'Api pressed Event

    'Na was wohl :)
    Friend PanikKey As Keys = Keys.Pause 'Default Pause - Change on Settings

    ''' <summary>
    ''' Paniktaste checken, alle 10 ms
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'If GetAsyncKeyState(Keys.ControlKey) = pressed And GetAsyncKeyState(Keys.ShiftKey) = pressed And GetAsyncKeyState(Keys.P) = pressed Then
        If GetAsyncKeyState(PanikKey) = pressed AndAlso PanikButtonPressed = False Then
            'Paniktaste
            WebBrowser1.Navigate("about:blank")
            Application.DoEvents()
            Me.Close()
            PanikButtonPressed = True
            My.Computer.Audio.Stop()
        ElseIf GetAsyncKeyState(PanikKey) = pressed AndAlso PanikButtonPressed = True Then
            PanikButtonPressed = False
            Dim lvi As ListViewItem = ListView1.SelectedItems.Item(0)
            lvi.Selected = False
            lvi.Selected = True
            Me.WindowState = CurrentWindowState
            Me.ShowsInTaskBar = CurrentShowInTaskbar
        End If
    End Sub

#End Region

#Region "Declare"

    ''' <summary>
    ''' Senderliste
    ''' </summary>
    ''' <remarks></remarks>
    Friend _sender As New List(Of Sender)

    ''' <summary>
    ''' Senderliste wird kurz zwischen gespeichert.
    ''' </summary>
    ''' <remarks></remarks>
    Private EditSenderL As New List(Of Sender)

    ''' <summary>
    ''' Hier wird der gerade editierte Sender zwischen gespeichert
    ''' </summary>
    ''' <remarks></remarks>
    Private EditSender As Sender

    ''' <summary>
    ''' Wenn ein Sender editiert wird ist dies true
    ''' </summary>
    ''' <remarks></remarks>
    Private EditMode As Boolean = False

    ''' <summary>
    ''' Radiosuche
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared _SearchProperty As String = ""

    ''' <summary>
    ''' Die Ini mit der Senderliste
    ''' </summary>
    ''' <remarks></remarks>
    Friend Property SenderListe As String = Application.StartupPath & "\sender.ini"

    ''' <summary>
    ''' Pfad zu den Einstellungen
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property Settings As String = Application.StartupPath & "\settings.ini"

    ''' <summary>
    ''' Wird auf true gesetzt wenn die Anwendung tatsächlich geschlossen werden soll
    ''' </summary>
    ''' <remarks></remarks>
    Private Property CloseApp As Boolean = False

    ''' <summary>
    ''' Aktuelle FensterStatus zwischen speichern
    ''' </summary>
    ''' <remarks></remarks>
    Private Property CurrentWindowState As FormWindowState

    ''' <summary>
    ''' Wir das Fenster gerade in der Taskbar angezeigt
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property CurrentShowInTaskbar As Boolean = False

    ''' <summary>
    ''' Leider brauchen wir ihn, weil bei der Paniktaste sonst der Browser wieder anfängt zu dudeln.
    ''' </summary>
    ''' <remarks></remarks>
    Private Property PanikButtonPressed As Boolean = False

    ''' <summary>
    ''' Lautstärke
    ''' </summary>
    ''' <remarks></remarks>
    Private Vol As Volume

    ''' <summary>
    ''' Die aktuelle Lautstärke
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property Volume As Integer = 5

    ''' <summary>
    ''' Soll die Anwendung minimiert werden, anstatt geschlossen
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property MinimizeOnClose As Boolean = True

    ''' <summary>
    ''' Soll beim minimieren, die Anwendung aus der in der Taskbar angezeigt werden
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property ShowsInTaskBar As Boolean = False

    ''' <summary>
    ''' True wenn der Maximize Button für den Browser geklickt wurde, False wenn der Button erneut geklickt wird
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property WebbrowserMaximized As Boolean = False

    ''' <summary>
    ''' Hier speichern wir die Größe des ursprünglichen Controls vor dem Maximieren ab.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property WebbrowserSize As New System.Drawing.Size

#End Region

#Region "Form_Events"

    ''' <summary>
    ''' Beim Start laden wir eine Basis Radioliste, die nutzen wir falls noch keine INI erzeugt wurde.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        'Radio vorbefüllen
        _sender.Add(New Sender("http://webradio.ffh.de/", "FFH"))
        _sender.Add(New Sender("http://webradio.ffh.de/index/wController/Webradio/wAction/showstation/wWebradio/electro/wNewquality/hq.html", "FFH Elektro"))
        _sender.Add(New Sender("http://webradio.ffh.de/index/wController/Webradio/wAction/showstation/wWebradio/eurodance/wNewquality/hq.html", "FHH Dance"))
        _sender.Add(New Sender("http://www.hr-online.de/website/static/streaming_popup/mp3streamer.jsp?client=hr3", "HR3"))
        _sender.Add(New Sender("http://www.hr-online.de/website/static/streaming_popup/mp3streamer.jsp?client=hrinfo", "HR Info"))
        _sender.Add(New Sender("http://www.surfmusik.de/radio/antenne-thueringen,1030.html", "Antenne Thüringen"))
        _sender.Add(New Sender("http://www.surfmusik.de/radio/antenne1,914.html", "Antenne1"))
        _sender.Add(New Sender("http://player.sunshine-live.de/sunshine_live/", "SunShine Live"))
        _sender.Add(New Sender("http://player.sunshine-live.de/classics/", "Sunshine Live - Classic"))
        _sender.Add(New Sender("http://player.sunshine-live.de/be_easy/", "Sunshine Live - Be Easy"))
        _sender.Add(New Sender("http://player.sunshine-live.de/be_ahead/", "Sunshine Live - Be Ahead"))
        _sender.Add(New Sender("http://player.sunshine-live.de/be_dj/", "Sunshine Live - Be DJ"))
        _sender.Add(New Sender("http://player.sunshine-live.de/hard/", "Sunshine Live - Hard"))
        _sender.Add(New Sender("http://player.sunshine-live.de/house/", "Sunshine Live - House"))
        _sender.Add(New Sender("http://player.sunshine-live.de/trance/", "Sunshine Live - Trance"))
        _sender.Add(New Sender("http://www.surfmusik.de/radio/radio-sunshine-live,917.html", "SunShine Live 2"))
        _sender.Add(New Sender("http://www.rautemusik.fm/radio/webplayer/main/", "Rautemusik.FM"))
        _sender.Add(New Sender("http://www.n-joy.de/onaircenter121-onaircenterpopup.html", "N-Joy"))
        _sender.Add(New Sender("http://www.surfmusik.de/radio/di-fm-tech-house-dsl,14612.html", "(DI) Tech House"))
        _sender.Add(New Sender("http://www.surfmusik.de/radio/di-fm-dj-mixes-dsl,1525.html", "(DI) DJ Mixes"))
        _sender.Add(New Sender("http://www.surfmusik.de/radio/absolut-relax,15000.html", "Absolut Relax"))
        _sender.Add(New Sender("http://www.surfmusik.de/radio/alternativefm,15211.html", "Alternate.FM"))
        _sender.Add(New Sender("http://www.surfmusik.de/radio/coolradio-jazz,14120.html", "Coolradio Jazz"))
        _sender.Add(New Sender("http://www.surfmusik.de/radio/dasding-live-dsl,12158.html", "DasDing Live"))
        _sender.Add(New Sender("http://www.surfmusik.de/radio/dasding-plattenleger-dsl,12161.html", "DasDing Plattenleger"))
        _sender.Add(New Sender("http://www.surfmusik.de/radio/radio-z,6775.html", "Radio Z"))
        _sender.Add(New Sender("http://www.surfmusik.de/radio/jam-fm,6029.html", "Jam FM"))
        _sender.Add(New Sender("http://www.surfmusik.de/radio/tranceradio-ch-dsl,5229.html", "TranceRadio.ch"))
        _sender.Add(New Sender("http://www.surfmusik.de/radio/101-ru-nrj-techno-radio,14147.html", "101.ru NRJ Techno Radio"))
        _sender.Add(New Sender("http://webradio.ffh.de/index/wController/Webradio/wAction/showstation/wWebradio/schlager/wNewquality/hq.html", "FHH Schlager"))
        _sender.Add(New Sender("http://www.twitch.tv/sagan9ne/b/405559248?t=66m37s", "Mouz vs DD - International West Qualifiers"))

        'Sender sortieren
        _sender.Sort()

        'Senderlisten Check
        Dim fi As New FileInfo(SenderListe)
        If fi.Exists = False Then
            CreateSenderListe()
        End If

        'Settings
        fi = New FileInfo(Settings)
        If fi.Exists = False Then
            CreateSettings()
        End If

        LoadSettings()

        'aktuelle Lautstärke festlegen
        Vol = New Volume(Volume)
        Vol.Volume = Volume
        Vol.MaxValue = TrackBar1.Maximum
        TrackBar1.Value = Volume
        SetVolumeLabel()

    End Sub

    Private Sub Form1_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        'fertig zeichnen lassen
        Application.DoEvents()
        FillListViews()
        'Wurde ein Sender als Startoption festgelegt
        If _SearchProperty.Length > 0 Then
            Dim s As Sender = _sender.Find(AddressOf FindRadio)
            Dim lvi As ListViewItem = ListView1.FindItemWithText(s.Name)
            lvi.Selected = True
        End If

        'hier sorgen wir dafür das wir auch wirklich als vorderstes Fenster da sind.
        Me.BringToFront()
        'Wenn wir das auf true lassen, ist das Fenster permanent im Vordergrund
        Me.TopMost = True
        '250ms warten
        Threading.Thread.Sleep(250)
        'Topmost wieder deaktivieren
        Me.TopMost = False
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Wenn Windows herunter gefahren wird, sollten wir das nicht verhindern.
        If e.CloseReason = CloseReason.WindowsShutDown Then
            CloseApp = True
        End If
        If CloseApp = True Then
            'Entgültig beenden
        Else
            If MinimizeOnClose = True Then
                'Schliessen abbrechen
                e.Cancel = True
                'Aktuellen Status zwischen speichern
                CurrentWindowState = Me.WindowState
                'Minimieren
                Me.WindowState = FormWindowState.Minimized
                If ShowsInTaskBar = False Then
                    'Ausblenden
                    CurrentShowInTaskbar = Me.ShowInTaskbar
                    Me.ShowInTaskbar = False
                End If
            End If
        End If
    End Sub

#End Region

#Region "Functions"

    ''' <summary>
    ''' Einstellungen laden
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadSettings()
        'Senderliste wieder überschreiben.
        _sender = Sender.LoadSenderListe(SenderListe)
        Dim ini As New INIDatei(Settings)
        Try
            'Panikkey setzen
            Dim key As String = ini.WertLesen("Panikbutton", "Name")
            Dim t As New System.Windows.Forms.KeysConverter
            PanikKey = CType(t.ConvertFromString(key), Keys)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler - Panikbutton", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Volume = CInt(ini.WertLesen("Settings", "Volume"))
        MinimizeOnClose = CBool(ini.WertLesen("Settings", "MinimizeOnClose"))
        ShowsInTaskBar = CBool(ini.WertLesen("Settings", "ShowInTaskbar"))
        Dim startSender As String = ini.WertLesen("Settings", "SenderOnStart")
        If startSender.Length > 0 Then
            _SearchProperty = startSender
        End If

        GenerateCMNotifySender()

    End Sub

    Private Sub GenerateCMNotifySender()
        'Dynamisches Sendermenu erzeugen... 
        SenderToolStripMenuItem.DropDownItems.Clear()
        For Each s As Sender In _sender
            Dim t As New ToolStripMenuItem
            t.Checked = True
            t.CheckState = CheckState.Unchecked
            If s.Name.Equals(_SearchProperty) Then
                t.CheckState = CheckState.Checked
            End If
            t.Name = s.Name
            t.Tag = s.Name
            t.Text = s.Name
            AddHandler t.Click, AddressOf CMSenderClick
            SenderToolStripMenuItem.DropDownItems.Add(t)
        Next
    End Sub

    ''' <summary>
    ''' Fenster wieder herstellen
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BringWindowBack()
        Me.ShowInTaskbar = True
        Me.WindowState = CurrentWindowState
        Application.DoEvents()
        Me.BringToFront()
        Me.TopMost = True
        Threading.Thread.Sleep(250)
        Me.TopMost = False
    End Sub

    ''' <summary>
    ''' Suchfunktion um in der Senderliste nach Namen zu suchen. Wird intern von _sender.Find(of (t)) benutzt.
    ''' </summary>
    ''' <param name="sendr"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function FindRadio(sendr As Sender) As Boolean
        If sendr.Name.Equals(_SearchProperty) Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Listviews füllen
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FillListViews()
        ListView1.Items.Clear()
        ListView2.Items.Clear()
        'Sender in den Listview schreiben
        For Each s As Sender In _sender
            ListView1.Items.Add(s.Name)
            ListView2.Items.Add(New ListViewItem({s.Name, s.URL}))
        Next
    End Sub

    ''' <summary>
    ''' Setzt den Text des Lautstärkelabels
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetVolumeLabel()
        Dim percent As Integer = CInt(TrackBar1.Value * 100 / TrackBar1.Maximum)
        Lbl_Volume.Text = "Lautstärke " & percent & "%"
    End Sub

    ''' <summary>
    ''' Kreiert die Sender.ini
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CreateSenderListe()
        Sender.WriteSenderListe(_sender, SenderListe)
    End Sub

    ''' <summary>
    ''' Generiert die settings.ini mit Voreinstellungen
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CreateSettings()
        Dim ini As New INIDatei(Settings)
        ini.WertSchreiben("Panikbutton", "Name", "Pause")
        ini.WertSchreiben("Settings", "Volume", "5")
        ini.WertSchreiben("Settings", "MinimizeOnClose", MinimizeOnClose.ToString)
        ini.WertSchreiben("Settings", "ShowInTaskbar", ShowsInTaskBar.ToString)
        ini.WertSchreiben("Settings", "SenderOnStart", "")
    End Sub

#End Region

#Region "AboutBox"

    ''' <summary>
    ''' AboutBox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub InfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        Dim t As New AboutBox1
        t.ShowDialog()
    End Sub

#End Region

#Region "RadioTab"

    ''' <summary>
    ''' Wenn der Sender gewechselt wird
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            'For Schleife für genau einen Eintrag. Multiselect des Listview ist deaktiviert
            For Each it As ListViewItem In ListView1.SelectedItems
                'Für die Suchfunktion FindRadio
                _SearchProperty = it.Text
            Next
            'Sender suchen
            Dim s As Sender = _sender.Find(AddressOf FindRadio)
            WebBrowser1.Navigate(s.URL)
        End If
    End Sub

    ''' <summary>
    ''' Event bei der TrackBar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Volume = TrackBar1.Value
        Vol.Volume = TrackBar1.Value
        SetVolumeLabel()
        Dim ini As New INIDatei(Settings)
        ini.WertSchreiben("Settings", "Volume", Vol.Volume.ToString)
    End Sub

    'Beenden
    Private Sub BeendenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        CloseApp = True
        Me.Close()
    End Sub

    ''' <summary>
    ''' Setzt die korrekte URL im Browser
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
            Vol.Volume = Volume
            'Uri setzen
            TxtBoxURL.Text = WebBrowser1.Url.AbsoluteUri
            'Aktuell Label setzen
            Lbl_current.Text = "Aktuell: " & WebBrowser1.DocumentTitle
            'Fenstertitle setzen
            Me.Text = "WebRadio [" & WebBrowser1.DocumentTitle & "]"
            'Das Notify Icon kann nur 64 Zeichen beinhalten
            If Me.Text.Length > 63 Then
                NotifyIcon_Webradio.Text = Me.Text.Substring(0, 63)
            Else
                NotifyIcon_Webradio.Text = Me.Text
            End If
        End If
    End Sub

    ''' <summary>
    ''' Die Anwendung wirlich beenden
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BTN_CLOSE_Click(sender As System.Object, e As System.EventArgs) Handles BTN_CLOSE.Click
        CloseApp = True
        Me.Close()
    End Sub

    ''' <summary>
    ''' Wenn auf das Symbol in der Leiste geklickt wird.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub NotifyIcon1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon_Webradio.MouseDoubleClick
        If WebbrowserMaximized = False Then
            PanikButtonPressed = False
            BringWindowBack()
        End If
    End Sub

    ''' <summary>
    ''' Webbrowser Navigation checken. Betrifft den Panikmodus, sonst fängt der wieder an zu dudeln.
    ''' Wieso weiß ich nicht. Wenn man das Fenster minimiert, wird irgendwie die letzt gewählte Website neu geladen. Genauso beim wiederherstellen des Fensters
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub WebBrowser1_Navigating(sender As System.Object, e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        If PanikButtonPressed = True Then
            'Browsen abbrechen
            e.Cancel = True
        End If
    End Sub

#End Region

#Region "SenderBearbeiten"

    ''' <summary>
    ''' Wenn ein anderer Sender in der Listview angeklickt wird. Multiselect ist aktiviert, deswegen müssen wir das Bearbeiten im Kontextmenu ausblenden, wenn mehr als 1 Zeile markiert ist
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ListView2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView2.SelectedIndexChanged
        If ListView2.SelectedItems.Count > 1 Then
            'mehr als eine Zeile angeklickt, das Bearbeiten deaktivieren
            BearbeitenToolStripMenuItem.Enabled = False
            EditSenderL = New List(Of Sender)
            For Each it As ListViewItem In ListView2.SelectedItems
                Dim s As New Sender(it.SubItems(1).Text, it.SubItems(0).Text)
                Debug.WriteLine(s.ToString & " zum löschen markiert.")
                EditSenderL.Add(s)
            Next
        Else
            'Nur eine Zeile ausgewählt Bearbeiten aktivieren
            BearbeitenToolStripMenuItem.Enabled = True
            EditSenderL = New List(Of Sender)
            For Each it As ListViewItem In ListView2.SelectedItems
                EditSender = New Sender(it.SubItems(1).Text, it.SubItems(0).Text)
                EditSenderL.Add(EditSender)
            Next
        End If

    End Sub

    ''' <summary>
    ''' Bearbeiten
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BearbeitenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BearbeitenToolStripMenuItem.Click
        txtBoxNameEdit.Text = EditSender.Name
        txtBoxUrlEdit.Text = EditSender.URL
        'wir deaktivieren den Hinzufügen Button und minimieren hier Fehlklicks
        BTN_ADD.Enabled = False
        EditMode = True
        ListView2.Enabled = False
    End Sub

    ''' <summary>
    ''' Durchreichen an das Event zum Bearbeiten
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ListView2_DoubleClick(sender As System.Object, e As System.EventArgs) Handles ListView2.DoubleClick
        BearbeitenToolStripMenuItem_Click(sender, e)
    End Sub

    ''' <summary>
    ''' Löschen der ausgewählten  Sender
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub LöschenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LöschenToolStripMenuItem.Click
        Dim msgResult As DialogResult = MessageBox.Show("Du hast " & EditSenderL.Count & " Sender zum löschen markiert." & vbCrLf & "Möchtest du diese(n) jetzt löschen?", "Sicherheitsabfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgResult = Windows.Forms.DialogResult.Yes Then
            Dim newSenderList As New List(Of Sender)
            For Each _s As Sender In EditSenderL
                _sender.Remove(_s)
                WebRadio.Sender.RemoveSenderFromList(_s, SenderListe)
            Next
            FillListViews()
            GenerateCMNotifySender()
        End If
    End Sub

    ''' <summary>
    ''' Übernehmen wurde geklickt. Funktioniert nur wenn man im EditMode ist.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BTN_ACCEPT_Click(sender As System.Object, e As System.EventArgs) Handles BTN_ACCEPT.Click
        If EditMode = True Then
            If txtBoxNameEdit.Text.Length > 0 Then
                'Alten Sender löschen
                WebRadio.Sender.RemoveSenderFromList(EditSender, SenderListe)
                _sender.Remove(EditSender)
                Dim s As New Sender(txtBoxUrlEdit.Text, txtBoxNameEdit.Text)
                _sender.Add(s)
                _sender.Sort()
                WebRadio.Sender.WriteSenderListe(_sender, SenderListe)
                FillListViews()
                txtBoxNameEdit.Text = ""
                txtBoxUrlEdit.Text = ""
                BTN_ADD.Enabled = True
                EditMode = False
                ListView2.Enabled = True
            Else
                MessageBox.Show("Der Name darf nicht leer sein!", "Ungültiger Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            GenerateCMNotifySender()
        End If
    End Sub

    ''' <summary>
    ''' Hinzuzfügen eines Senders.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BTN_ADD_Click(sender As System.Object, e As System.EventArgs) Handles BTN_ADD.Click
        If txtBoxNameEdit.Text.Length > 0 AndAlso txtBoxUrlEdit.Text.Length > 0 Then
            For Each s As Sender In _sender
                If s.Name.ToLower.Equals(txtBoxNameEdit.Text.ToLower) Then
                    MessageBox.Show("Ein Sender mit diesem Namen existiert bereits." & vbCrLf & vbCrLf & "Bitte wählen einen anderen Namen.", "Doppelter Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Next

            Dim nS As New Sender(txtBoxUrlEdit.Text, txtBoxNameEdit.Text)
            _sender.Add(nS)
            _sender.Sort()
            WebRadio.Sender.WriteSenderListe(_sender, SenderListe)
            FillListViews()
            GenerateCMNotifySender()
        End If
    End Sub

#End Region

#Region "Optionen"

    ''' <summary>
    ''' Optionen anzeigen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub OptionenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OptionenToolStripMenuItem.Click
        Dim f2 As New Form2(Me)
        f2.ShowDialog() 'modal anzeigen
        'Wenn das Optionenfenster weg ist, laden wir die Einstellungen neu
        LoadSettings()
    End Sub

#End Region

#Region "File Open, Save"

    Private Sub ÖffnenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ÖffnenToolStripMenuItem.Click
        OFD.ShowDialog()
        If OFD.FileName.Length > 0 Then
            SenderListe = OFD.FileName
            LoadSettings()
            FillListViews()
            GenerateCMNotifySender()
        End If
    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SpeichernToolStripMenuItem.Click
        WebRadio.Sender.WriteSenderListe(_sender, SenderListe)
    End Sub


    Private Sub SpeichernunterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SpeichernunterToolStripMenuItem.Click
        If SFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim filename As String = SFD.FileName
            WebRadio.Sender.WriteSenderListe(_sender, filename)
        End If
    End Sub

    Private Sub NeuToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NeuToolStripMenuItem.Click
        SFDNew.InitialDirectory = Application.StartupPath
        If SFDNew.ShowDialog = Windows.Forms.DialogResult.OK Then
            _sender = New List(Of Sender)
            SenderListe = SFDNew.FileName
            WebRadio.Sender.WriteSenderListe(_sender, SenderListe)
            FillListViews()
            GenerateCMNotifySender()
        End If
    End Sub

#End Region

#Region "CM Notify"

    ''' <summary>
    ''' Wird aufgerufen, wenn ein Sender im Contextmenu des NotifyIcons angeklickt wird.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CMSenderClick(sender As Object, e As EventArgs)
        Dim t As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        For Each senderItem As ToolStripMenuItem In SenderToolStripMenuItem.DropDownItems
            senderItem.CheckState = CheckState.Unchecked
        Next
        t.CheckState = CheckState.Checked
        For Each it As ListViewItem In ListView1.Items
            If it.Text.Equals(t.Name) Then
                it.Selected = True
            End If
        Next
    End Sub

    Private Sub WebradioAnzeigenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WebradioAnzeigenToolStripMenuItem.Click
        If WebbrowserMaximized = False Then
            PanikButtonPressed = False
            BringWindowBack()
        Else
            TSBTN_Maximize_Click(sender, e)
        End If
    End Sub

    Private Sub VorherigerSenderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VorherigerSenderToolStripMenuItem.Click
        If _SearchProperty.Length > 0 Then
            Dim cs As Sender = _sender.Find(AddressOf FindRadio)
            Dim counter As Integer = 0
            Dim index As Integer = 0
            For Each s As Sender In _sender
                If cs.Name.Equals(s.Name) Then
                    index = counter
                    Exit For
                End If
                counter += 1
            Next
            If index = 0 Then
                index = 1
            End If
            ListView1.Items(index - 1).Selected = True
        Else
            ListView1.Items(0).Selected = True
        End If
    End Sub

    Private Sub NächsterSenderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NächsterSenderToolStripMenuItem.Click
        If _SearchProperty.Length > 0 Then
            Dim cs As Sender = _sender.Find(AddressOf FindRadio)
            Dim counter As Integer = 0
            Dim index As Integer = 0
            For Each s As Sender In _sender
                If cs.Name.Equals(s.Name) Then
                    index = counter
                    Exit For
                End If
                counter += 1
            Next
            ListView1.Items(index + 1).Selected = True
        Else
            ListView1.Items(0).Selected = True
        End If

    End Sub

    Private Sub BeendenToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles BeendenToolStripMenuItem1.Click
        CloseApp = True
        Me.Close()
    End Sub

    Private Sub AbspielenWiederaufnehmenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AbspielenWiederaufnehmenToolStripMenuItem.Click
        PanikButtonPressed = False
        If ListView1.SelectedItems.Count > 0 Then
            Dim lvi As ListViewItem = ListView1.SelectedItems.Item(0)
            lvi.Selected = False
            lvi.Selected = True
        End If
    End Sub

    Private Sub MUteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MUteToolStripMenuItem.Click
        Volume = Vol.Volume
        Vol.Volume = 0
        TrackBar1.Value = Vol.Volume
        SetVolumeLabel()
    End Sub

    Private Sub UnMuteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UnMuteToolStripMenuItem.Click
        Vol.Volume = Volume
        TrackBar1.Value = Vol.Volume
        SetVolumeLabel()
    End Sub

    Private Sub LeiserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LeiserToolStripMenuItem.Click
        If Volume > 0 Then
            Vol.Volume = TrackBar1.Value - 1
            Volume = Vol.Volume
            TrackBar1.Value = Vol.Volume
            SetVolumeLabel()
        End If
    End Sub

    Private Sub LauterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LauterToolStripMenuItem.Click
        If Volume < Vol.MaxValue Then
            Vol.Volume = TrackBar1.Value + 1
            Volume = Vol.Volume
            TrackBar1.Value = Vol.Volume
            SetVolumeLabel()
        End If
    End Sub

#End Region

#Region "Menustrip"

    Private Sub TSBTN_Panik_Click(sender As System.Object, e As System.EventArgs) Handles TSBTN_Panik.Click
        'Paniktaste
        WebBrowser1.Navigate("about:blank")
        Application.DoEvents()
        Me.Close()
        PanikButtonPressed = True
        My.Computer.Audio.Stop()
    End Sub

    Private Sub TSBTN_PlayStop_Click(sender As System.Object, e As System.EventArgs) Handles TSBTN_PlayStop.Click
        If TSBTN_PlayStop.Tag.Equals("Play") Then
            TSBTN_PlayStop.Tag = "Stop"
            Me.TSBTN_PlayStop.Image = CType(My.Resources._stop, System.Drawing.Image)
            NächsterSenderToolStripMenuItem_Click(sender, e)
        Else
            TSBTN_PlayStop.Tag = "Play"
            Me.TSBTN_PlayStop.Image = CType(My.Resources.play, System.Drawing.Image)
            WebBrowser1.Navigate("about:blank")
        End If
    End Sub

    Private Sub TSBTN_Prev_Click(sender As System.Object, e As System.EventArgs) Handles TSBTN_Prev.Click
        VorherigerSenderToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub TSBTN_Next_Click(sender As System.Object, e As System.EventArgs) Handles TSBTN_Next.Click
        NächsterSenderToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub TSBTN_MuteUnmute_Click(sender As System.Object, e As System.EventArgs) Handles TSBTN_MuteUnmute.Click
        If TSBTN_MuteUnmute.Tag.Equals("Mute") Then
            TSBTN_MuteUnmute.Tag = "Volume"
            Me.TSBTN_MuteUnmute.Image = CType(My.Resources.volume_2, System.Drawing.Image)
            Volume = Vol.Volume
            Vol.Volume = 0
            TrackBar1.Value = Vol.Volume
            SetVolumeLabel()
        Else
            TSBTN_MuteUnmute.Tag = "Mute"
            Me.TSBTN_MuteUnmute.Image = CType(My.Resources.mute_2, System.Drawing.Image)
            Vol.Volume = Volume
            TrackBar1.Value = Vol.Volume
            SetVolumeLabel()
        End If
    End Sub

    Private Sub TSBTN_Maximize_Click(sender As System.Object, e As System.EventArgs) Handles TSBTN_Maximize.Click
        If WebbrowserMaximized = False Then

            'Wie groß ist denn der Webbrowser?
            WebbrowserSize = WebBrowser1.Size

            CurrentWindowState = Me.WindowState
            Me.WindowState = FormWindowState.Maximized

            'Menus ausblenden
            MenuStrip1.Visible = False
            ToolStripContainer1.Visible = True
            'Unteres Panel ausblenden
            Panel1.Visible = False

            'komplette Border des Windows entfernen
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

            'Mir selber den Webbrowser zuweisen
            Me.Controls.Add(WebBrowser1)
            'Das Control in den Vordergrund holen
            WebBrowser1.BringToFront()
            'Und alles komplett füllen
            WebBrowser1.Dock = DockStyle.Fill
            'Speichern, das wir maximiert sind
            WebbrowserMaximized = True

        Else
            'Wiederherstellen der eigentlichen Größe des Fensters
            Me.WindowState = CurrentWindowState
            'Webbrowser entfernen
            Me.Controls.Remove(WebBrowser1)
            'Menus wieder anzeigen
            MenuStrip1.Visible = True
            ToolStripContainer1.Visible = True
            'Das untere Panel wiederanzeigen
            Panel1.Visible = True
            'Die Form wiederherstellen
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            'Das Webbrowser Control seinen alten Eigentümer zurückgeben
            Me.SplitContainer1.Panel2.Controls.Add(Me.WebBrowser1)
            WebBrowser1.Dock = DockStyle.None
            Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
    Or System.Windows.Forms.AnchorStyles.Left) _
    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.WebBrowser1.Location = New System.Drawing.Point(3, 23)
            Me.WebBrowser1.Size = WebbrowserSize
            'Wir sind wieder normal
            WebbrowserMaximized = False
        End If
    End Sub

#End Region



End Class