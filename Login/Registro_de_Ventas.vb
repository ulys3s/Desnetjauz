Public Class Registro_de_Ventas
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Box = New Pantalla_Administracion()
        Box.Show()

        Me.Hide()

    End Sub
End Class
