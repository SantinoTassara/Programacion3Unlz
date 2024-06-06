Public Class Form1
    Dim dtLatas As DataTable

    Private Sub inicializarDataTable()
        Dim dt As New DataTable

        dt.Columns.Add("Codigo")
        dt.Columns.Add("Color")
        dt.Columns.Add("Litros")

        Me.setDtLatas(dt)

    End Sub

    Private Sub setDtLatas(dt As DataTable)
        Me.dtLatas = dt

        dataGrid1.DataSource = dt

    End Sub

    Private Sub recargarEstadisticas()

        Dim totalLitrosRoja = 0
        Dim acumAzules = 0
        Dim contAzules = 0


        For Each renglon As DataRow In dtLatas.Rows

            Dim colorRenglon As String = renglon("Color")

            If colorRenglon.ToUpper() = "ROJO" Then
                totalLitrosRoja += renglon("Litros")
            ElseIf colorRenglon.ToUpper() = "AZUL" Then
                contAzules += 1
                acumAzules += renglon("Litros")
            End If

        Next



        If totalLitrosRoja > 0 Then
            totalRLabel.Text = totalLitrosRoja.ToString("Total de Litros de Pintura Roja: " + "#0.00")
        Else
            totalRLabel.Text = "Total de Litros de Pintura Roja: " + "#0.00"
        End If


        If acumAzules > 0 Then
            Dim promAzules = acumAzules / contAzules
            promALabel.Text = promAzules.ToString("Promedio de litros de pintura Azul: " + "#0.00")
        Else
            promALabel.Text = "Promedio de litros de pintura Azul: " + "0.00"
        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.inicializarDataTable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim codigo As String = codigoTB.Text
            Dim litros = Double.Parse(litrosTB.Text)
            Dim color As String = colorTB.Text

            For Each renglon As DataRow In dtLatas.Rows
                If codigo = renglon("Codigo") Then
                    MessageBox.Show("El codigo del producto tiene que ser unico")
                    Return
                End If
            Next

            If codigo = "" Or color = "" Then
                MessageBox.Show("No pueden quedar casilleros en blanco")
                Return
            End If

            If litros < 0 Then
                MessageBox.Show("La cantidad de litro tiene que se positiva")
                Return
            End If

            dtLatas.Rows.Add(codigo, color, litros)

        Catch ex As Exception
            MessageBox.Show("ERROR: verifique los datos")
        End Try
        Me.recargarEstadisticas()
        codigoTB.Text = ""
        litrosTB.Text = ""
        colorTB.Text = ""

    End Sub
End Class
