Imports System.Collections.Generic
Imports System.Text

Namespace CustomControls
    <AttributeUsage(AttributeTargets.[Class] Or AttributeTargets.[Enum] Or AttributeTargets.[Interface] Or AttributeTargets.Struct, AllowMultiple:=True)> _
    <Author("Franco, Gustavo")> _
    Friend Class AuthorAttribute
        Inherits Attribute
#Region "Constructors"
        Public Sub New(authorName As String)
        End Sub
#End Region
    End Class
End Namespace