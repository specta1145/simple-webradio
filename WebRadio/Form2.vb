Public Class Form2
    Private WithEvents form1 As Form1

    Dim k As Keys
    Dim ini As INIDatei

    Public Sub New(f1 As Form1)
        InitializeComponent()
        Me.form1 = f1
        k = form1.PanikKey
        form1.PanikKey = Nothing
        ini = New INIDatei(form1.Settings)
        TXT_Panik.Text = ini.WertLesen("Panikbutton", "Name")
        CB_MinimizeOnClose.Checked = CBool(ini.WertLesen("Settings", "MinimizeOnClose"))
        CB_ShowInTaskbar.Checked = CBool(ini.WertLesen("Settings", "ShowInTaskbar"))
        Dim sender As String = ini.WertLesen("Settings", "SenderOnStart")
        CB_SenderWahl.Items.Clear()
        For Each s As Sender In form1._sender
            CB_SenderWahl.Items.Add(s.Name)
            If sender.Length > 0 Then
                If s.Name.Equals(sender) Then
                    CB_SenderWahl.SelectedItem = CB_SenderWahl.Items(CB_SenderWahl.Items.Count - 1)
                End If
            End If
        Next
    End Sub

    Private Sub TXT_Panik_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TXT_Panik.KeyUp
        TXT_Panik.Text = e.KeyData.ToString
        k = e.KeyCode
        ini.WertSchreiben("Panikbutton", "Name", e.KeyData.ToString)
    End Sub

    Private Sub Btn_Close_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Close.Click
        form1.PanikKey = k
        Me.Close()
    End Sub

    Private Sub CB_MinimizeOnClose_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CB_MinimizeOnClose.CheckedChanged
        ini.WertSchreiben("Settings", "MinimizeOnClose", CB_MinimizeOnClose.Checked.ToString)
    End Sub

    Private Sub CB_ShowInTaskbar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CB_ShowInTaskbar.CheckedChanged
        ini.WertSchreiben("Settings", "ShowInTaskbar", CB_ShowInTaskbar.Checked.ToString)
    End Sub

    Private Sub CB_SenderWahl_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_SenderWahl.SelectedIndexChanged
        ini.WertSchreiben("Settings", "SenderOnStart", CB_SenderWahl.Text)
    End Sub
End Class