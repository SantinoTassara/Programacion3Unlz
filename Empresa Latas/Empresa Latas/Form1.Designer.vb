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
        Me.dataGrid1 = New System.Windows.Forms.DataGridView()
        Me.codigoLabel = New System.Windows.Forms.Label()
        Me.codigoTB = New System.Windows.Forms.TextBox()
        Me.colorLabel = New System.Windows.Forms.Label()
        Me.litrosLabel = New System.Windows.Forms.Label()
        Me.colorTB = New System.Windows.Forms.TextBox()
        Me.litrosTB = New System.Windows.Forms.TextBox()
        Me.totalRLabel = New System.Windows.Forms.Label()
        Me.promALabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGrid1
        '
        Me.dataGrid1.AllowUserToAddRows = False
        Me.dataGrid1.AllowUserToDeleteRows = False
        Me.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid1.Location = New System.Drawing.Point(12, 12)
        Me.dataGrid1.Name = "dataGrid1"
        Me.dataGrid1.ReadOnly = True
        Me.dataGrid1.Size = New System.Drawing.Size(259, 356)
        Me.dataGrid1.TabIndex = 0
        '
        'codigoLabel
        '
        Me.codigoLabel.AutoSize = True
        Me.codigoLabel.Location = New System.Drawing.Point(354, 36)
        Me.codigoLabel.Name = "codigoLabel"
        Me.codigoLabel.Size = New System.Drawing.Size(93, 13)
        Me.codigoLabel.TabIndex = 1
        Me.codigoLabel.Text = "Codigo de la Lata:"
        '
        'codigoTB
        '
        Me.codigoTB.Location = New System.Drawing.Point(382, 52)
        Me.codigoTB.Name = "codigoTB"
        Me.codigoTB.Size = New System.Drawing.Size(278, 20)
        Me.codigoTB.TabIndex = 2
        '
        'colorLabel
        '
        Me.colorLabel.AutoSize = True
        Me.colorLabel.Location = New System.Drawing.Point(357, 84)
        Me.colorLabel.Name = "colorLabel"
        Me.colorLabel.Size = New System.Drawing.Size(34, 13)
        Me.colorLabel.TabIndex = 3
        Me.colorLabel.Text = "Color:"
        '
        'litrosLabel
        '
        Me.litrosLabel.AutoSize = True
        Me.litrosLabel.Location = New System.Drawing.Point(357, 128)
        Me.litrosLabel.Name = "litrosLabel"
        Me.litrosLabel.Size = New System.Drawing.Size(35, 13)
        Me.litrosLabel.TabIndex = 4
        Me.litrosLabel.Text = "Litros:"
        '
        'colorTB
        '
        Me.colorTB.Location = New System.Drawing.Point(382, 105)
        Me.colorTB.Name = "colorTB"
        Me.colorTB.Size = New System.Drawing.Size(278, 20)
        Me.colorTB.TabIndex = 5
        '
        'litrosTB
        '
        Me.litrosTB.Location = New System.Drawing.Point(382, 144)
        Me.litrosTB.Name = "litrosTB"
        Me.litrosTB.Size = New System.Drawing.Size(278, 20)
        Me.litrosTB.TabIndex = 6
        '
        'totalRLabel
        '
        Me.totalRLabel.AutoSize = True
        Me.totalRLabel.Location = New System.Drawing.Point(379, 242)
        Me.totalRLabel.Name = "totalRLabel"
        Me.totalRLabel.Size = New System.Drawing.Size(153, 13)
        Me.totalRLabel.TabIndex = 7
        Me.totalRLabel.Text = "Total de Litros de Pintura Roja:"
        '
        'promALabel
        '
        Me.promALabel.AutoSize = True
        Me.promALabel.Location = New System.Drawing.Point(379, 276)
        Me.promALabel.Name = "promALabel"
        Me.promALabel.Size = New System.Drawing.Size(166, 13)
        Me.promALabel.TabIndex = 8
        Me.promALabel.Text = "Promedio de litros de pintura Azul:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(354, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Estadisticas:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(465, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.promALabel)
        Me.Controls.Add(Me.totalRLabel)
        Me.Controls.Add(Me.litrosTB)
        Me.Controls.Add(Me.colorTB)
        Me.Controls.Add(Me.litrosLabel)
        Me.Controls.Add(Me.colorLabel)
        Me.Controls.Add(Me.codigoTB)
        Me.Controls.Add(Me.codigoLabel)
        Me.Controls.Add(Me.dataGrid1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataGrid1 As DataGridView
    Friend WithEvents codigoLabel As Label
    Friend WithEvents codigoTB As TextBox
    Friend WithEvents colorLabel As Label
    Friend WithEvents litrosLabel As Label
    Friend WithEvents colorTB As TextBox
    Friend WithEvents litrosTB As TextBox
    Friend WithEvents totalRLabel As Label
    Friend WithEvents promALabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
End Class
