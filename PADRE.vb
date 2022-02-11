Imports ADODB
Public Class PADRE

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub LeerXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeerXMLToolStripMenuItem.Click
        frmLeerXML.MdiParent = Me
        frmLeerXML.Show()
    End Sub

    Private Sub RutaArchivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RutaArchivosToolStripMenuItem.Click
        RutaArchivo.MdiParent = Me
        RutaArchivo.Show()
    End Sub

    Private Sub PADRE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ORACLEPasswordNOMBRE = "tempapps"
        'ORACLEUserNombre = "apps"
        'ORACLEDatabaseNombre = "DEV"
        'SQLOracle.ConnectionString = "Provider=OraOLEDB.Oracle.1;Password=" & ORACLEPasswordNOMBRE & ";Persist Security Info=True;User ID=" & ORACLEUserNombre & ";Data Source=" & ORACLEDatabaseNombre & ";"
        'Try
        '    SQLOracle.Open()
        '    MsgBox("SE CONECTO")
        'Catch ex As Exception
        '    MsgBox("NO SE CONECTO")
        'End Try

    End Sub
End Class