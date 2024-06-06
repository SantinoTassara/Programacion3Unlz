Public Class Form1

    Dim dtVino As DataTable

    Private Sub inicializarDataTable()
        Dim dt As New DataTable

        dt.Columns.Add("Marca")
        dt.Columns.Add("Descripcion")
        dt.Columns.Add("Capacidad")
        dt.Columns.Add("EnvaseTipo")
        dt.Columns.Add("%Alcohol")

        Me.setDtVino(dt)

    End Sub

    Private Sub setDtVino(dt As DataTable)
        Me.dtVino = dt

        Me.DataGrid1.DataSource = dt

    End Sub

    Private Sub recargarPromedio()
        Dim cantVinosBotella = 0
        Dim bebidaMasPorcentaje As String = ""
        Dim porcentajeMasAlto = 0
        Dim contLobo = 0

        Dim indice = 0

        For Each renglon As DataRow In dtVino.Rows

            If renglon("EnvaseTipo") = "Botella" Then
                cantVinosBotella += 1
            End If

            If renglon("%Alcohol") > porcentajeMasAlto Or indice = 0 Then
                bebidaMasPorcentaje = renglon("Marca")
                porcentajeMasAlto = renglon("%Alcohol")
            End If

            Dim marca As String = renglon("Marca")

            If marca.ToUpper = "LOBO" Then
                contLobo += 1
            End If

            indice += 1

        Next

        cantBotellaLabel.Text = cantVinosBotella.ToString("Cantidad de vinos en botella: " + "#0.00")

        mayorAlcoholLabel.Text = "Bebida Con mayor % de alcohol: " + bebidaMasPorcentaje

        contLoboLabel.Text = contLobo.ToString("Productos Marca Lobo: " + "#0.00")



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarDataTable()
    End Sub

    Private Sub cargarBT_Click(sender As Object, e As EventArgs) Handles cargarBT.Click
        Dim marca As String = marcaTB.Text
        Dim descripcion As String = descTB.Text
        Dim capacidad = Double.Parse(capacidadTB.Text)
        Dim tipoEnvase As String = envaseCB.Text
        Dim porcentajeAlcohol = Double.Parse(alcoholTB.Text)

        Me.dtVino.Rows.Add(marca, descripcion, capacidad, tipoEnvase, porcentajeAlcohol)

        recargarPromedio()

    End Sub
End Class
