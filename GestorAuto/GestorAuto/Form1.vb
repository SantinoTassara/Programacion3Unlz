Imports VehiculosServices.Daos
Imports VehiculosServices.Models

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim patente As String = TextBox1.Text
        Dim tipo = TextBox2.Text
        Dim velocidad = TextBox3.Text

        Dim nuevoVehiculo As New Vehiculo(patente, tipo, velocidad)

        Dim dao As New VehiculoDao

        dao.insert(nuevoVehiculo)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dao As New VehiculoDao

        Dim vehiculos = dao.getAll()

        DataGridView1.DataSource = vehiculos
    End Sub
End Class
