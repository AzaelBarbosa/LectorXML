Imports System.Xml
Imports System.IO

Public Class frmLeerXML
    Dim Sql As String

    Dim intArchivos As Integer = 0
    Dim xmlRFC As String
    Dim xmlNOMBRE As String
    Dim xmlFecha As String
    Dim xmlFolio As String
    Dim xmlSerie As String
    Dim xmlTotal As String
    Dim xmlUUID As String
    Dim xmlUUIDRel As String
    Dim xmlTipoComprobante As String
    Dim ArchXml() As String
    Dim ArchPDF() As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ruta <> "" Then
            rutarchivos = ruta

            Dim folder As New DirectoryInfo(rutarchivos)

            For Each file As FileInfo In folder.GetFiles()
                intArchivos = intArchivos + 1
            Next

            lblcantarchivos.Text = intArchivos
        Else
            MsgBox("Por favor especofique la ruta de los archivos", MsgBoxStyle.Information, "PRESTAMO EXPRESS")

        End If

    End Sub

    Private Sub cmdExportar_Click(sender As Object, e As EventArgs) Handles cmdExportar.Click
        Dim folder As New DirectoryInfo(rutarchivos)
        intArchivos = 0

        For Each file As FileInfo In folder.GetFiles("*.xml", SearchOption.TopDirectoryOnly)
            nombrearchivo = file.Name
            'Elimino la extension .xml para comprobar si existe el mismo nombre en PDF
            Dim index As Integer = nombrearchivo.IndexOf("."c)
            nombrearchivo = nombrearchivo.Substring(0, index)
            nombrearchivo = nombrearchivo + ".xml"
            intArchivos = intArchivos + 1
            'Agrego la Extension .PDF al nombre del archivo
            'nombrearchivoPDF = nombrearchivo + ".pdf"
            'Compruebo si el archivo existe en el arreglo de PDFs
            'If (ArchPDF.Contains(rutarchivos + "\" + nombrearchivoPDF)) Then
            Sql = ""
            xmlUUIDRel = ""

            Try
                Dim doc As XmlDocument
                Dim concepto As XmlNodeList
                Dim concepto2 As XmlNodeList
                Dim concepto3 As XmlNodeList
                Dim Elemento As XmlNode
                Dim Elemento2 As XmlNode
                Dim Elemento3 As XmlNode
                Dim subnodo As XmlElement

                ' Creamos el "XML Document"
                doc = New XmlDocument()

                'Cargamos el archivo
                doc.Load(rutarchivos & nombrearchivo)

                'Obtenemos la lista de los nodos "cfdi:Comprobante""
                concepto = doc.GetElementsByTagName("cfdi:Comprobante")

                'Recorrer XML 
                For Each Elemento In concepto
                    xmlTotal = Class1.AtributoVacio(Elemento, "Total")
                    xmlFecha = Class1.AtributoVacio(Elemento, "Fecha")
                    xmlFolio = Class1.AtributoVacio(Elemento, "Folio")
                    xmlSerie = Class1.AtributoVacio(Elemento, "Serie")
                    xmlTipoComprobante = Class1.AtributoVacio(Elemento, "TipoDeComprobante")


                    For Each subnodo In Elemento

                        If subnodo.Name = "cfdi:Emisor" Then

                            xmlRFC = Class1.AtributoVacio(subnodo, "Rfc")
                            xmlNOMBRE = Class1.AtributoVacio(subnodo, "Nombre")

                        End If

                        If subnodo.Name = "cfdi:CfdiRelacionados" Then
                            concepto3 = doc.GetElementsByTagName("cfdi:CfdiRelacionado")
                            For Each Elemento3 In concepto3
                                xmlUUIDRel = Class1.AtributoVacio(Elemento3, "UUID")
                            Next
                        End If

                        If subnodo.Name = "cfdi:Complemento" Then
                            concepto2 = doc.GetElementsByTagName("tfd:TimbreFiscalDigital")
                            For Each Elemento2 In concepto2
                                xmlUUID = Class1.AtributoVacio(Elemento2, "UUID")
                            Next
                        End If



                    Next


                    'AGREGO DATOS A DATAGRID

                    DGWDatos.Rows.Add(xmlRFC, xmlNOMBRE, xmlFecha, xmlFolio, xmlTipoComprobante, xmlSerie, xmlTotal, UCase(xmlUUID), UCase(xmlUUIDRel))


                Next

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            'Else

            'End If



            If intArchivos = CInt(lblcantarchivos.Text) Then
                GridAExcel(DGWDatos)
            Else

            End If
        Next
    End Sub

    Private Sub exportarExcel()


    End Sub

    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()


            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try

        Return True

    End Function

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "ORGANIZACION TREVIÑO"
                rutarchivos = "\\192.168.2.41\modules\PO\EntradasOT\Facturas\Cargadas"

        End Select

        If rutarchivos <> "" Then
            intArchivos = 0
            Dim folder As New DirectoryInfo(rutarchivos)
            ArchXml = Directory.GetFiles(rutarchivos, "*.xml", SearchOption.TopDirectoryOnly)

            For Each FileName As String In ArchXml
                intArchivos = intArchivos + 1
            Next
            lblcantarchivos.Text = intArchivos

            ArchPDF = Directory.GetFiles(rutarchivos, "*.pdf", SearchOption.TopDirectoryOnly)
            intArchivos = 0
            For Each FileName As String In ArchPDF
                intArchivos = intArchivos + 1
            Next
            lblcantarchpdf.Text = intArchivos
        Else
            MsgBox("Por favor especofique la ruta de los archivos", MsgBoxStyle.Information, "PRESTAMO EXPRESS")

        End If

    End Sub
End Class
