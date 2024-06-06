Imports StockProductosService.Daos
Imports StockProductosService.Models

Public Class Form1

    Dim Dao As New ProductoDao
    Private Sub setGridProducto()

        Dim Productos = Dao.getAllProductos()

        DataGridView1.DataSource = Productos


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setGridProducto()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nombreProducto = productoTb.Text
        Dim stock = StockTb.Text
        Dim tipo = TipoCb.Text

        Dim nuevoProducto As New Producto(nombreProducto, stock, tipo)

        Dao.insert(nuevoProducto)

        setGridProducto()

    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        Dim tipoABuscar = filtradoCb.Text
        Dim productosBuscado = Dao.buscarPorTipo(tipoABuscar)
        DataGridView1.DataSource = productosBuscado
    End Sub
End Class
