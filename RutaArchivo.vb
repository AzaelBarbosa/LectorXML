Public Class RutaArchivo
    Dim tmpruta As String
    Private Sub cmCancela_Click(sender As Object, e As EventArgs) Handles cmCancela.Click
        Me.Close()

    End Sub

    Private Sub cmdSeleccionar_Click(sender As Object, e As EventArgs) Handles cmdSeleccionar.Click

        If folder.ShowDialog = Windows.Forms.DialogResult.OK Then
            tmpruta = folder.SelectedPath
        End If

        txtruta.Text = tmpruta
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        ruta = tmpruta & "\"
        Me.Close()

    End Sub

    Private Sub RutaArchivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class