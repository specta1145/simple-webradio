Imports WebRadio.CustomControls
Imports System.IO

''' <summary>
''' Repräsentiert einen Sender. Enthält shared Funktionen zum lesen und erstellen von List(of Sender)
''' </summary>
''' <remarks></remarks>
<Author("Ronny Witzgall")> _
Public Class Sender
    Implements IComparable(Of Sender)

    ''' <summary>
    ''' Name des Senders
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Name As String = ""

    ''' <summary>
    ''' URL zum Sender
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property URL As String = ""

    Public Sub New(Url As String, Name As String)
        Me.URL = Url
        Me.Name = Name
    End Sub

    ''' <summary>
    ''' Lädt eine INI Datei mit den Sendern und gibt diese zurück
    ''' </summary>
    ''' <param name="Filename"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function LoadSenderListe(Filename As String) As List(Of Sender)
        Dim ls As New List(Of Sender)
        Dim ini As New INIDatei(Filename)

        Dim sAbschnitte As String   'Abschnitte als String
        Dim Abschnitt() As String   'Rückgabe Stringarray der INIDatei
        Dim sSchluessel As String       'RückgabeString aus der INIDatei
        ' Rückgabe-String vorbereiten
        sAbschnitte = Space$(32767 * 4) 'Puffer vorbelegen
        ' vbNullString Übergeben, um alle gespeicherten Abschnittsnamen zu ermitteln
        sAbschnitte = ini.WertLesen(vbNullString, "", "", sAbschnitte.Length)
        ' Sind überhaupt Abschnitte vorhanden?
        If sAbschnitte <> "" Then
            ' Rückgabestring "splitten"
            Abschnitt = Split(sAbschnitte, vbNullChar)
            For I = 0 To UBound(Abschnitt)
                If Abschnitt(I) <> "" Then
                    sSchluessel = Space$(2048)
                    sSchluessel = ini.WertLesen(Abschnitt(I), "url", "", sSchluessel.Length)
                    If sSchluessel.Length > 0 Then
                        Dim s As New Sender(sSchluessel, Abschnitt(I))
                        ls.Add(s)
                    End If
                End If
            Next
        End If
        ls.Sort()
        Return ls
    End Function

    ''' <summary>
    ''' Schreibt eine neue Senderliste oder erweitert eine vorhandene. Dabei wird nicht geprüft ob ein Sender bereits vorhanden ist. Er wird einfach überschrieben.
    ''' </summary>
    ''' <param name="sender">Die Liste der Sender</param>
    ''' <param name="Filename">Die Datei die dabei angelegt wird. Fehlt die .ini Erweiterung wird sie angelegt.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function WriteSenderListe(sender As List(Of Sender), Filename As String) As Boolean
        Try
            If Filename.EndsWith(".ini") = False Then
                Filename = Filename & ".ini"
            End If
            Dim ini As New INIDatei(Filename)
            For Each s As Sender In sender
                ini.WertSchreiben(s.Name, "url", s.URL)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function RemoveSenderFromList(s As Sender, FileName As String) As Boolean
        Dim ini As New INIDatei(FileName)
        ini.SektionLöschen(s.Name)
        Return True
    End Function

    ''' <summary>
    ''' Funktion zum sortieren Vergleichen der Sender nach Namen
    ''' </summary>
    ''' <param name="other"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CompareTo(other As Sender) As Integer Implements System.IComparable(Of Sender).CompareTo
        Return Me.Name.CompareTo(other.Name)
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim other As Sender = TryCast(obj, Sender)
        If IsNothing(other) Then Return False
        If Not other.Name.Equals(Me.Name) Then Return False
        If Not other.URL.Equals(Me.URL) Then Return False
        Return True
    End Function

End Class
