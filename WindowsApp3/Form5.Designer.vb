<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblPrecioHora = New System.Windows.Forms.Label()
        Me.lblCantHoras = New System.Windows.Forms.Label()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.lblGerente = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtGerente = New System.Windows.Forms.TextBox()
        Me.pnlGerente = New System.Windows.Forms.Panel()
        Me.txtPrecioHora = New System.Windows.Forms.TextBox()
        Me.pnlPrecioHora = New System.Windows.Forms.Panel()
        Me.txtCantHoras = New System.Windows.Forms.TextBox()
        Me.pnlAdmin = New System.Windows.Forms.Panel()
        Me.pnlCantHoras = New System.Windows.Forms.Panel()
        Me.txtIncentivo = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSueldoBase = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.lblSegundoApellido = New System.Windows.Forms.Label()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.lblPrimerApellido = New System.Windows.Forms.Label()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.lblSegundoNombre = New System.Windows.Forms.Label()
        Me.lblPrimerNombre = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(14, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox2.TabIndex = 92
        Me.PictureBox2.TabStop = False
        '
        'lblPrecioHora
        '
        Me.lblPrecioHora.AutoSize = True
        Me.lblPrecioHora.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioHora.Location = New System.Drawing.Point(623, 302)
        Me.lblPrecioHora.Name = "lblPrecioHora"
        Me.lblPrecioHora.Size = New System.Drawing.Size(133, 22)
        Me.lblPrecioHora.TabIndex = 91
        Me.lblPrecioHora.Text = "Precio  / Hora"
        Me.lblPrecioHora.Visible = False
        '
        'lblCantHoras
        '
        Me.lblCantHoras.AutoSize = True
        Me.lblCantHoras.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantHoras.Location = New System.Drawing.Point(418, 302)
        Me.lblCantHoras.Name = "lblCantHoras"
        Me.lblCantHoras.Size = New System.Drawing.Size(185, 22)
        Me.lblCantHoras.TabIndex = 90
        Me.lblCantHoras.Text = "Cantidad de Horas"
        Me.lblCantHoras.Visible = False
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(487, 255)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(234, 22)
        Me.lblAdmin.TabIndex = 89
        Me.lblAdmin.Text = "Incentivo Administrativo"
        Me.lblAdmin.Visible = False
        '
        'lblGerente
        '
        Me.lblGerente.AutoSize = True
        Me.lblGerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGerente.Location = New System.Drawing.Point(530, 255)
        Me.lblGerente.Name = "lblGerente"
        Me.lblGerente.Size = New System.Drawing.Size(125, 24)
        Me.lblGerente.TabIndex = 88
        Me.lblGerente.Text = "Nivel Gerente"
        Me.lblGerente.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(328, 386)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 52)
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'txtGerente
        '
        Me.txtGerente.BackColor = System.Drawing.Color.White
        Me.txtGerente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGerente.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGerente.Location = New System.Drawing.Point(520, 283)
        Me.txtGerente.Name = "txtGerente"
        Me.txtGerente.Size = New System.Drawing.Size(176, 24)
        Me.txtGerente.TabIndex = 85
        Me.txtGerente.Visible = False
        '
        'pnlGerente
        '
        Me.pnlGerente.BackColor = System.Drawing.Color.Black
        Me.pnlGerente.Location = New System.Drawing.Point(520, 313)
        Me.pnlGerente.Name = "pnlGerente"
        Me.pnlGerente.Size = New System.Drawing.Size(176, 2)
        Me.pnlGerente.TabIndex = 86
        Me.pnlGerente.Visible = False
        '
        'txtPrecioHora
        '
        Me.txtPrecioHora.BackColor = System.Drawing.Color.White
        Me.txtPrecioHora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecioHora.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioHora.Location = New System.Drawing.Point(610, 335)
        Me.txtPrecioHora.Name = "txtPrecioHora"
        Me.txtPrecioHora.Size = New System.Drawing.Size(176, 24)
        Me.txtPrecioHora.TabIndex = 83
        Me.txtPrecioHora.Visible = False
        '
        'pnlPrecioHora
        '
        Me.pnlPrecioHora.BackColor = System.Drawing.Color.Black
        Me.pnlPrecioHora.Location = New System.Drawing.Point(610, 364)
        Me.pnlPrecioHora.Name = "pnlPrecioHora"
        Me.pnlPrecioHora.Size = New System.Drawing.Size(176, 2)
        Me.pnlPrecioHora.TabIndex = 84
        Me.pnlPrecioHora.Visible = False
        '
        'txtCantHoras
        '
        Me.txtCantHoras.BackColor = System.Drawing.Color.White
        Me.txtCantHoras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantHoras.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantHoras.Location = New System.Drawing.Point(422, 335)
        Me.txtCantHoras.Name = "txtCantHoras"
        Me.txtCantHoras.Size = New System.Drawing.Size(176, 24)
        Me.txtCantHoras.TabIndex = 81
        Me.txtCantHoras.Visible = False
        '
        'pnlAdmin
        '
        Me.pnlAdmin.BackColor = System.Drawing.Color.Black
        Me.pnlAdmin.Location = New System.Drawing.Point(520, 314)
        Me.pnlAdmin.Name = "pnlAdmin"
        Me.pnlAdmin.Size = New System.Drawing.Size(176, 2)
        Me.pnlAdmin.TabIndex = 80
        Me.pnlAdmin.Visible = False
        '
        'pnlCantHoras
        '
        Me.pnlCantHoras.BackColor = System.Drawing.Color.Black
        Me.pnlCantHoras.Location = New System.Drawing.Point(422, 364)
        Me.pnlCantHoras.Name = "pnlCantHoras"
        Me.pnlCantHoras.Size = New System.Drawing.Size(176, 2)
        Me.pnlCantHoras.TabIndex = 82
        Me.pnlCantHoras.Visible = False
        '
        'txtIncentivo
        '
        Me.txtIncentivo.BackColor = System.Drawing.Color.White
        Me.txtIncentivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIncentivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncentivo.Location = New System.Drawing.Point(520, 285)
        Me.txtIncentivo.Name = "txtIncentivo"
        Me.txtIncentivo.Size = New System.Drawing.Size(176, 22)
        Me.txtIncentivo.TabIndex = 79
        Me.txtIncentivo.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(550, 122)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(173, 2)
        Me.Panel6.TabIndex = 78
        '
        'txtSueldo
        '
        Me.txtSueldo.BackColor = System.Drawing.Color.White
        Me.txtSueldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSueldo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSueldo.Location = New System.Drawing.Point(550, 93)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(173, 24)
        Me.txtSueldo.TabIndex = 77
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(233, 132)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(176, 2)
        Me.Panel3.TabIndex = 76
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.BackColor = System.Drawing.Color.White
        Me.txtPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrimerNombre.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerNombre.Location = New System.Drawing.Point(233, 102)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(176, 24)
        Me.txtPrimerNombre.TabIndex = 75
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(233, 323)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(176, 2)
        Me.Panel5.TabIndex = 74
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(233, 261)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(176, 2)
        Me.Panel4.TabIndex = 73
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(233, 193)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(176, 2)
        Me.Panel2.TabIndex = 72
        '
        'lblSueldoBase
        '
        Me.lblSueldoBase.AutoSize = True
        Me.lblSueldoBase.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSueldoBase.Location = New System.Drawing.Point(418, 102)
        Me.lblSueldoBase.Name = "lblSueldoBase"
        Me.lblSueldoBase.Size = New System.Drawing.Size(121, 22)
        Me.lblSueldoBase.TabIndex = 70
        Me.lblSueldoBase.Text = "Sueldo base"
        '
        'cboTipo
        '
        Me.cboTipo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(443, 204)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(308, 30)
        Me.cboTipo.TabIndex = 68
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.BackColor = System.Drawing.Color.White
        Me.txtSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSegundoApellido.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoApellido.Location = New System.Drawing.Point(233, 293)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(176, 24)
        Me.txtSegundoApellido.TabIndex = 65
        '
        'lblSegundoApellido
        '
        Me.lblSegundoApellido.AutoSize = True
        Me.lblSegundoApellido.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundoApellido.Location = New System.Drawing.Point(25, 297)
        Me.lblSegundoApellido.Name = "lblSegundoApellido"
        Me.lblSegundoApellido.Size = New System.Drawing.Size(172, 22)
        Me.lblSegundoApellido.TabIndex = 67
        Me.lblSegundoApellido.Text = "Segundo Apellido"
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.BackColor = System.Drawing.Color.White
        Me.txtPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrimerApellido.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerApellido.Location = New System.Drawing.Point(233, 231)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(176, 24)
        Me.txtPrimerApellido.TabIndex = 63
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.AutoSize = True
        Me.lblPrimerApellido.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerApellido.Location = New System.Drawing.Point(25, 237)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(144, 22)
        Me.lblPrimerApellido.TabIndex = 66
        Me.lblPrimerApellido.Text = "Primer Apellido"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.BackColor = System.Drawing.Color.White
        Me.txtSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSegundoNombre.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoNombre.Location = New System.Drawing.Point(233, 163)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(176, 24)
        Me.txtSegundoNombre.TabIndex = 62
        '
        'lblSegundoNombre
        '
        Me.lblSegundoNombre.AutoSize = True
        Me.lblSegundoNombre.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundoNombre.Location = New System.Drawing.Point(25, 169)
        Me.lblSegundoNombre.Name = "lblSegundoNombre"
        Me.lblSegundoNombre.Size = New System.Drawing.Size(172, 22)
        Me.lblSegundoNombre.TabIndex = 64
        Me.lblSegundoNombre.Text = "Segundo Nombre"
        '
        'lblPrimerNombre
        '
        Me.lblPrimerNombre.AutoSize = True
        Me.lblPrimerNombre.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerNombre.Location = New System.Drawing.Point(24, 102)
        Me.lblPrimerNombre.Name = "lblPrimerNombre"
        Me.lblPrimerNombre.Size = New System.Drawing.Size(144, 22)
        Me.lblPrimerNombre.TabIndex = 61
        Me.lblPrimerNombre.Text = "Primer Nombre"
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(743, -5)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(1)
        Me.Button2.Size = New System.Drawing.Size(29, 36)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "_"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(772, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(1)
        Me.Button1.Size = New System.Drawing.Size(29, 27)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(530, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 22)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Tipo Empleado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(261, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(310, 36)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Modificar Empleado"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblPrecioHora)
        Me.Controls.Add(Me.lblCantHoras)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.lblGerente)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtGerente)
        Me.Controls.Add(Me.pnlGerente)
        Me.Controls.Add(Me.txtPrecioHora)
        Me.Controls.Add(Me.pnlPrecioHora)
        Me.Controls.Add(Me.txtCantHoras)
        Me.Controls.Add(Me.pnlAdmin)
        Me.Controls.Add(Me.pnlCantHoras)
        Me.Controls.Add(Me.txtIncentivo)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtPrimerNombre)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblSueldoBase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.txtSegundoApellido)
        Me.Controls.Add(Me.lblSegundoApellido)
        Me.Controls.Add(Me.txtPrimerApellido)
        Me.Controls.Add(Me.lblPrimerApellido)
        Me.Controls.Add(Me.txtSegundoNombre)
        Me.Controls.Add(Me.lblSegundoNombre)
        Me.Controls.Add(Me.lblPrimerNombre)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblPrecioHora As Label
    Friend WithEvents lblCantHoras As Label
    Friend WithEvents lblAdmin As Label
    Friend WithEvents lblGerente As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtGerente As TextBox
    Friend WithEvents pnlGerente As Panel
    Friend WithEvents txtPrecioHora As TextBox
    Friend WithEvents pnlPrecioHora As Panel
    Friend WithEvents txtCantHoras As TextBox
    Friend WithEvents pnlAdmin As Panel
    Friend WithEvents pnlCantHoras As Panel
    Friend WithEvents txtIncentivo As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPrimerNombre As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSueldoBase As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents txtSegundoApellido As TextBox
    Friend WithEvents lblSegundoApellido As Label
    Friend WithEvents txtPrimerApellido As TextBox
    Friend WithEvents lblPrimerApellido As Label
    Friend WithEvents txtSegundoNombre As TextBox
    Friend WithEvents lblSegundoNombre As Label
    Friend WithEvents lblPrimerNombre As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
