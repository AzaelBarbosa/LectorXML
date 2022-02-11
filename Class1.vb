Imports System.Xml
Imports System.IO

Public Class Class1
    Public Shared Function AtributoVacio(ByVal pNodo As XmlNode, ByVal pNombreAtributo As String) As String
        Dim vRetvalor As String = String.Empty

        If pNodo IsNot Nothing Then

            If pNodo.Attributes IsNot Nothing Then
                Dim vAtributo As XmlNode = pNodo.Attributes.GetNamedItem(pNombreAtributo)

                If vAtributo IsNot Nothing Then
                    vRetvalor = vAtributo.Value.Trim()
                End If
            End If
        End If

        Return vRetvalor
    End Function
End Class
