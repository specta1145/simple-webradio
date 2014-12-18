Imports System.Runtime.InteropServices
Imports WebRadio.CustomControls

''' <summary>
''' Hier wird die Laustärke in der Anwendung geregelt.
''' </summary>
''' <remarks></remarks>
<Author("Ronny Witzgall")> _
Public Class Volume

    ''' <summary>
    ''' Aktuelle Lautstärke auslesen
    ''' </summary>
    ''' <param name="hwo"></param>
    ''' <param name="dwVolume"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DllImport("winmm.dll")> _
    Public Shared Function waveOutGetVolume(ByVal hwo As IntPtr, ByRef dwVolume As UInteger) As Integer
    End Function

    ''' <summary>
    ''' Lautstärke setzen
    ''' </summary>
    ''' <param name="hwo"></param>
    ''' <param name="dwVolume"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DllImport("winmm.dll")> _
    Public Shared Function waveOutSetVolume(ByVal hwo As IntPtr, ByVal dwVolume As UInteger) As Integer
    End Function

    ''' <summary>
    ''' Maximale Lautstärke, sollte so eingestellt werden, das der Lautstärkeregler und dieser Wert indentisch sind.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MaxValue As Integer = 10

    ''' <summary>
    ''' Für den Property Volume
    ''' </summary>
    ''' <remarks></remarks>
    Private _Volume As Integer = 2

    Public Sub New()

    End Sub

    ''' <summary>
    ''' Konstruktor mit Lautstärkeübergabe
    ''' </summary>
    ''' <param name="Volume">Lautstärkewert</param>
    ''' <remarks></remarks>
    Public Sub New(Volume As Integer)
        Me.new()
        Me.Volume = Volume
    End Sub

    ''' <summary>
    ''' Ruft die Lautstärke ab, oder setzt diese
    ''' </summary>
    ''' <value>Lautstärke</value>
    ''' <returns>Gibt die Laustärke zurück</returns>
    ''' <remarks></remarks>
    Public Property Volume As Integer
        Set(value As Integer)
            _Volume = value
            SetVolume(value)
        End Set
        Get
            Return _Volume
        End Get
    End Property

    ''' <summary>
    ''' Lautstärke in Windows setzen
    ''' </summary>
    ''' <param name="Vol">Irgend ein Wert, der aber kleiner der Trackbar.Maximum sein sollte.</param>
    ''' <remarks></remarks>
    Private Sub SetVolume(Vol As Integer)
        Dim NewVolume As Integer = CInt(((UShort.MaxValue / Me.MaxValue) * Vol))
        Dim NewVolumeAllChannels As UInteger = CUInt(((CUInt(NewVolume) And &HFFFF) Or (CUInt(NewVolume) << 16)))
        waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels)
    End Sub

End Class
