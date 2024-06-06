<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGridView()
        Me.marcaLabel = New System.Windows.Forms.Label()
        Me.descLabel = New System.Windows.Forms.Label()
        Me.capacidadLabel = New System.Windows.Forms.Label()
        Me.envaseLabel = New System.Windows.Forms.Label()
        Me.alcoholLabel = New System.Windows.Forms.Label()
        Me.cantBotellaLabel = New System.Windows.Forms.Label()
        Me.mayorAlcoholLabel = New System.Windows.Forms.Label()
        Me.contLoboLabel = New System.Windows.Forms.Label()
        Me.marcaTB = New System.Windows.Forms.TextBox()
        Me.descTB = New System.Windows.Forms.TextBox()
        Me.capacidadTB = New System.Windows.Forms.TextBox()
        Me.alcoholTB = New System.Windows.Forms.TextBox()
        Me.envaseCB = New System.Windows.Forms.ComboBox()
        Me.cargarBT = New System.Windows.Forms.Button()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid1.Location = New System.Drawing.Point(517, 12)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(271, 358)
        Me.DataGrid1.TabIndex = 0
        '
        'marcaLabel
        '
        Me.marcaLabel.AutoSize = True
        Me.marcaLabel.Location = New System.Drawing.Point(12, 12)
        Me.marcaLabel.Name = "marcaLabel"
        Me.marcaLabel.Size = New System.Drawing.Size(40, 13)
        Me.marcaLabel.TabIndex = 1
        Me.marcaLabel.Text = "Marca:"
        '
        'descLabel
        '
        Me.descLabel.AutoSize = True
        Me.descLabel.Location = New System.Drawing.Point(12, 39)
        Me.descLabel.Name = "descLabel"
        Me.descLabel.Size = New System.Drawing.Size(66, 13)
        Me.descLabel.TabIndex = 2
        Me.descLabel.Text = "Descripcion:"
        '
        'capacidadLabel
        '
        Me.capacidadLabel.AutoSize = True
        Me.capacidadLabel.Location = New System.Drawing.Point(13, 62)
        Me.capacidadLabel.Name = "capacidadLabel"
        Me.capacidadLabel.Size = New System.Drawing.Size(61, 13)
        Me.capacidadLabel.TabIndex = 3
        Me.capacidadLabel.Text = "Capacidad:"
        '
        'envaseLabel
        '
        Me.envaseLabel.AutoSize = True
        Me.envaseLabel.Location = New System.Drawing.Point(12, 86)
        Me.envaseLabel.Name = "envaseLabel"
        Me.envaseLabel.Size = New System.Drawing.Size(87, 13)
        Me.envaseLabel.TabIndex = 4
        Me.envaseLabel.Text = "Tipo De Envase:"
        '
        'alcoholLabel
        '
        Me.alcoholLabel.AutoSize = True
        Me.alcoholLabel.Location = New System.Drawing.Point(12, 111)
        Me.alcoholLabel.Name = "alcoholLabel"
        Me.alcoholLabel.Size = New System.Drawing.Size(114, 13)
        Me.alcoholLabel.TabIndex = 5
        Me.alcoholLabel.Text = "Porcentaje de Alcohol:"
        '
        'cantBotellaLabel
        '
        Me.cantBotellaLabel.AutoSize = True
        Me.cantBotellaLabel.Location = New System.Drawing.Point(13, 215)
        Me.cantBotellaLabel.Name = "cantBotellaLabel"
        Me.cantBotellaLabel.Size = New System.Drawing.Size(145, 13)
        Me.cantBotellaLabel.TabIndex = 6
        Me.cantBotellaLabel.Text = "Cantidad de vinos en Botella:"
        '
        'mayorAlcoholLabel
        '
        Me.mayorAlcoholLabel.AutoSize = True
        Me.mayorAlcoholLabel.Location = New System.Drawing.Point(12, 257)
        Me.mayorAlcoholLabel.Name = "mayorAlcoholLabel"
        Me.mayorAlcoholLabel.Size = New System.Drawing.Size(159, 13)
        Me.mayorAlcoholLabel.TabIndex = 7
        Me.mayorAlcoholLabel.Text = "Bebida con mayor % de Alcohol:"
        '
        'contLoboLabel
        '
        Me.contLoboLabel.AutoSize = True
        Me.contLoboLabel.Location = New System.Drawing.Point(12, 301)
        Me.contLoboLabel.Name = "contLoboLabel"
        Me.contLoboLabel.Size = New System.Drawing.Size(118, 13)
        Me.contLoboLabel.TabIndex = 8
        Me.contLoboLabel.Text = "Productos Marca Lobo:"
        '
        'marcaTB
        '
        Me.marcaTB.Location = New System.Drawing.Point(128, 9)
        Me.marcaTB.Name = "marcaTB"
        Me.marcaTB.Size = New System.Drawing.Size(155, 20)
        Me.marcaTB.TabIndex = 9
        '
        'descTB
        '
        Me.descTB.Location = New System.Drawing.Point(128, 36)
        Me.descTB.Name = "descTB"
        Me.descTB.Size = New System.Drawing.Size(155, 20)
        Me.descTB.TabIndex = 10
        '
        'capacidadTB
        '
        Me.capacidadTB.Location = New System.Drawing.Point(128, 62)
        Me.capacidadTB.Name = "capacidadTB"
        Me.capacidadTB.Size = New System.Drawing.Size(155, 20)
        Me.capacidadTB.TabIndex = 11
        '
        'alcoholTB
        '
        Me.alcoholTB.Location = New System.Drawing.Point(128, 108)
        Me.alcoholTB.Name = "alcoholTB"
        Me.alcoholTB.Size = New System.Drawing.Size(155, 20)
        Me.alcoholTB.TabIndex = 12
        '
        'envaseCB
        '
        Me.envaseCB.FormattingEnabled = True
        Me.envaseCB.Items.AddRange(New Object() {"Botella", "Carton", "Damajuana"})
        Me.envaseCB.Location = New System.Drawing.Point(128, 86)
        Me.envaseCB.Name = "envaseCB"
        Me.envaseCB.Size = New System.Drawing.Size(155, 21)
        Me.envaseCB.TabIndex = 13
        Me.envaseCB.Text = "Botella"
        '
        'cargarBT
        '
        Me.cargarBT.Location = New System.Drawing.Point(95, 150)
        Me.cargarBT.Name = "cargarBT"
        Me.cargarBT.Size = New System.Drawing.Size(143, 26)
        Me.cargarBT.TabIndex = 14
        Me.cargarBT.Text = "Cargar"
        Me.cargarBT.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cargarBT)
        Me.Controls.Add(Me.envaseCB)
        Me.Controls.Add(Me.alcoholTB)
        Me.Controls.Add(Me.capacidadTB)
        Me.Controls.Add(Me.descTB)
        Me.Controls.Add(Me.marcaTB)
        Me.Controls.Add(Me.contLoboLabel)
        Me.Controls.Add(Me.mayorAlcoholLabel)
        Me.Controls.Add(Me.cantBotellaLabel)
        Me.Controls.Add(Me.alcoholLabel)
        Me.Controls.Add(Me.envaseLabel)
        Me.Controls.Add(Me.capacidadLabel)
        Me.Controls.Add(Me.descLabel)
        Me.Controls.Add(Me.marcaLabel)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGrid1 As DataGridView
    Friend WithEvents marcaLabel As Label
    Friend WithEvents descLabel As Label
    Friend WithEvents capacidadLabel As Label
    Friend WithEvents envaseLabel As Label
    Friend WithEvents alcoholLabel As Label
    Friend WithEvents cantBotellaLabel As Label
    Friend WithEvents mayorAlcoholLabel As Label
    Friend WithEvents contLoboLabel As Label
    Friend WithEvents marcaTB As TextBox
    Friend WithEvents descTB As TextBox
    Friend WithEvents capacidadTB As TextBox
    Friend WithEvents alcoholTB As TextBox
    Friend WithEvents envaseCB As ComboBox
    Friend WithEvents cargarBT As Button
End Class
