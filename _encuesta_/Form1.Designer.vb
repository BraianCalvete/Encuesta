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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Apellido = New System.Windows.Forms.TextBox()
        Me.Serie_favorita = New System.Windows.Forms.ComboBox()
        Me.BEnviar = New System.Windows.Forms.Button()
        Me.TEncuesta = New System.Windows.Forms.DataGridView()
        Me.BBorrar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        CType(Me.TEncuesta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ENCUESTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Series"
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(164, 64)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(100, 20)
        Me.Nombre.TabIndex = 4
        '
        'Apellido
        '
        Me.Apellido.Location = New System.Drawing.Point(164, 106)
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Size = New System.Drawing.Size(100, 20)
        Me.Apellido.TabIndex = 5
        '
        'Serie_favorita
        '
        Me.Serie_favorita.FormattingEnabled = True
        Me.Serie_favorita.Items.AddRange(New Object() {"La Casa de Papel", "Poco Ortodoxa", "GOT", "Stranger Things", "Ninguna de las anteriores"})
        Me.Serie_favorita.Location = New System.Drawing.Point(164, 149)
        Me.Serie_favorita.Name = "Serie_favorita"
        Me.Serie_favorita.Size = New System.Drawing.Size(121, 21)
        Me.Serie_favorita.TabIndex = 6
        '
        'BEnviar
        '
        Me.BEnviar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BEnviar.Location = New System.Drawing.Point(58, 208)
        Me.BEnviar.Name = "BEnviar"
        Me.BEnviar.Size = New System.Drawing.Size(57, 36)
        Me.BEnviar.TabIndex = 7
        Me.BEnviar.Text = "Enviar"
        Me.BEnviar.UseVisualStyleBackColor = True
        '
        'TEncuesta
        '
        Me.TEncuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TEncuesta.Location = New System.Drawing.Point(320, 64)
        Me.TEncuesta.Name = "TEncuesta"
        Me.TEncuesta.Size = New System.Drawing.Size(423, 211)
        Me.TEncuesta.TabIndex = 8
        '
        'BBorrar
        '
        Me.BBorrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BBorrar.Location = New System.Drawing.Point(152, 208)
        Me.BBorrar.Name = "BBorrar"
        Me.BBorrar.Size = New System.Drawing.Size(57, 36)
        Me.BBorrar.TabIndex = 9
        Me.BBorrar.Text = "Borrar"
        Me.BBorrar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BCancelar.Location = New System.Drawing.Point(245, 208)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(57, 36)
        Me.BCancelar.TabIndex = 10
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BBorrar)
        Me.Controls.Add(Me.TEncuesta)
        Me.Controls.Add(Me.BEnviar)
        Me.Controls.Add(Me.Serie_favorita)
        Me.Controls.Add(Me.Apellido)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TEncuesta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Nombre As TextBox
    Friend WithEvents Apellido As TextBox
    Friend WithEvents Serie_favorita As ComboBox
    Friend WithEvents BEnviar As Button
    Friend WithEvents TEncuesta As DataGridView
    Friend WithEvents BBorrar As Button
    Friend WithEvents BCancelar As Button
End Class
