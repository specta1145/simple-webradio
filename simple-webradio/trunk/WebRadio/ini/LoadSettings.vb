''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class LoadSettings

    Dim MyIniDatei As INIDatei = Nothing
    ''' <summary>
    ''' initialisierung der Settingsdatei
    ''' </summary>
    ''' <param name="iniDateiWithPath"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal iniDateiWithPath As String)
        MyIniDatei = New INIDatei(iniDateiWithPath)
    End Sub

    ''' <summary>
    ''' Gibt einen SchluesselWert als String zurück, der aus der EinstellungsINI den Abschnitt mit Schluessel entspricht. 
    ''' [Abschnitt]
    ''' Schluessel = "Dies wird zurück gegeben"
    ''' </summary>
    ''' <param name="Abschnitt">[Abschnitt]</param>
    ''' <param name="Schluessel">Schluesselwort</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function LoadSetting(ByVal Abschnitt As String, ByVal Schluessel As String) As String
        Dim Result = MyIniDatei.WertLesen(Abschnitt, Schluessel, "", 32767)
        If Result <> "" Then
            Return Result
        End If
        Return ""
    End Function

    ''' <summary>
    ''' Gibt ein StringArray zurück das alle Schluessel und dessen Werte enthält. Wobei Array(Index)(0) den Schluessel darstellt und Array(Index)(1) dessen zugehörigen Wert
    ''' </summary>
    ''' <param name="Abschnitt">[Abschnitt]</param>
    ''' <returns>Array(Index)(0) = Schluessel, Array(Index)(1) = Wert</returns>
    ''' <remarks></remarks>
    Public Function LoadSetting(ByVal Abschnitt As String) As String()()
        Dim Result = MyIniDatei.WertLesen(Abschnitt, vbNullString, "", 32767)
        Dim Schluessel() As String
        Dim Ausgabe()() As String = Nothing
        If Result <> "" Then
            Schluessel = Split(Result, vbNullChar)
            Dim A = 0
            For I = 0 To UBound(Schluessel) - 1
                Dim Wert = MyIniDatei.WertLesen(Abschnitt, Schluessel(I), "", 32767)
                If Wert <> "" Then
                    ReDim Preserve Ausgabe(A)
                    Ausgabe(A) = New String() {Schluessel(I), Wert}
                    A = A + 1
                End If
            Next I
            Return Ausgabe
        End If
        Return Nothing
    End Function

    Public Sub SchreibeEinstellung(Abschnitt As String, Schluessel As String, Wert As String)
        MyIniDatei.WertSchreiben(Abschnitt, Schluessel, Wert)
    End Sub

    Public Sub LoescheEinstellung(Abschnitt As String)
        MyIniDatei.SektionLöschen(Abschnitt)
    End Sub

    Public Sub LoescheEinstellung(Abschnitt As String, Sektion As String)
        MyIniDatei.SchlüsselLöschen(Abschnitt, Sektion)
    End Sub

End Class
