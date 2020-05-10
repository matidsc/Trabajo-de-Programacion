<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblSueldoBase = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.lblSegundoApellido = New System.Windows.Forms.Label()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.lblPrimerApellido = New System.Windows.Forms.Label()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.lblSegundoNombre = New System.Windows.Forms.Label()
        Me.lblPrimerNombre = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.pnlAdmin = New System.Windows.Forms.Panel()
        Me.txtIncentivo = New System.Windows.Forms.TextBox()
        Me.pnlCantHoras = New System.Windows.Forms.Panel()
        Me.txtCantHoras = New System.Windows.Forms.TextBox()
        Me.txtPrecioHora = New System.Windows.Forms.TextBox()
        Me.pnlPrecioHora = New System.Windows.Forms.Panel()
        Me.txtGerente = New System.Windows.Forms.TextBox()
        Me.pnlGerente = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblGerente = New System.Windows.Forms.Label()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.lblCantHoras = New System.Windows.Forms.Label()
        Me.lblPrecioHora = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(742, -9)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(1)
        Me.Button2.Size = New System.Drawing.Size(29, 36)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "_"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(771, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(1)
        Me.Button1.Size = New System.Drawing.Size(29, 27)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblSueldoBase
        '
        Me.lblSueldoBase.AutoSize = True
        Me.lblSueldoBase.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSueldoBase.Location = New System.Drawing.Point(425, 87)
        Me.lblSueldoBase.Name = "lblSueldoBase"
        Me.lblSueldoBase.Size = New System.Drawing.Size(127, 26)
        Me.lblSueldoBase.TabIndex = 28
        Me.lblSueldoBase.Text = "Sueldo base"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(538, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 26)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Tipo Empleado"
        '
        'cboTipo
        '
        Me.cboTipo.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(451, 200)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(308, 34)
        Me.cboTipo.TabIndex = 26
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.BackColor = System.Drawing.Color.White
        Me.txtSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSegundoApellido.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoApellido.Location = New System.Drawing.Point(224, 330)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(176, 24)
        Me.txtSegundoApellido.TabIndex = 22
        '
        'lblSegundoApellido
        '
        Me.lblSegundoApellido.AutoSize = True
        Me.lblSegundoApellido.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundoApellido.Location = New System.Drawing.Point(16, 335)
        Me.lblSegundoApellido.Name = "lblSegundoApellido"
        Me.lblSegundoApellido.Size = New System.Drawing.Size(182, 26)
        Me.lblSegundoApellido.TabIndex = 25
        Me.lblSegundoApellido.Text = "Segundo Apellido"
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.BackColor = System.Drawing.Color.White
        Me.txtPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrimerApellido.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerApellido.Location = New System.Drawing.Point(224, 268)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(176, 24)
        Me.txtPrimerApellido.TabIndex = 20
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.AutoSize = True
        Me.lblPrimerApellido.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerApellido.Location = New System.Drawing.Point(16, 274)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(161, 26)
        Me.lblPrimerApellido.TabIndex = 24
        Me.lblPrimerApellido.Text = "Primer Apellido"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.BackColor = System.Drawing.Color.White
        Me.txtSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSegundoNombre.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoNombre.Location = New System.Drawing.Point(224, 200)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(176, 24)
        Me.txtSegundoNombre.TabIndex = 19
        '
        'lblSegundoNombre
        '
        Me.lblSegundoNombre.AutoSize = True
        Me.lblSegundoNombre.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundoNombre.Location = New System.Drawing.Point(16, 206)
        Me.lblSegundoNombre.Name = "lblSegundoNombre"
        Me.lblSegundoNombre.Size = New System.Drawing.Size(183, 26)
        Me.lblSegundoNombre.TabIndex = 21
        Me.lblSegundoNombre.Text = "Segundo Nombre"
        '
        'lblPrimerNombre
        '
        Me.lblPrimerNombre.AutoSize = True
        Me.lblPrimerNombre.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerNombre.Location = New System.Drawing.Point(15, 140)
        Me.lblPrimerNombre.Name = "lblPrimerNombre"
        Me.lblPrimerNombre.Size = New System.Drawing.Size(162, 26)
        Me.lblPrimerNombre.TabIndex = 18
        Me.lblPrimerNombre.Text = "Primer Nombre"
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.White
        Me.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCedula.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(101, 82)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(104, 24)
        Me.txtCedula.TabIndex = 16
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(16, 87)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(79, 26)
        Me.lblCedula.TabIndex = 15
        Me.lblCedula.Text = "Cédula"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(101, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(104, 2)
        Me.Panel1.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(224, 230)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(176, 2)
        Me.Panel2.TabIndex = 31
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(224, 298)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(176, 2)
        Me.Panel4.TabIndex = 32
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(224, 360)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(176, 2)
        Me.Panel5.TabIndex = 33
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(224, 169)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(176, 2)
        Me.Panel3.TabIndex = 35
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.BackColor = System.Drawing.Color.White
        Me.txtPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrimerNombre.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerNombre.Location = New System.Drawing.Point(224, 139)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(176, 24)
        Me.txtPrimerNombre.TabIndex = 34
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(558, 118)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(173, 2)
        Me.Panel6.TabIndex = 37
        '
        'txtSueldo
        '
        Me.txtSueldo.BackColor = System.Drawing.Color.White
        Me.txtSueldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSueldo.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSueldo.Location = New System.Drawing.Point(558, 89)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(173, 24)
        Me.txtSueldo.TabIndex = 36
        '
        'pnlAdmin
        '
        Me.pnlAdmin.BackColor = System.Drawing.Color.Black
        Me.pnlAdmin.Location = New System.Drawing.Point(527, 310)
        Me.pnlAdmin.Name = "pnlAdmin"
        Me.pnlAdmin.Size = New System.Drawing.Size(176, 2)
        Me.pnlAdmin.TabIndex = 39
        Me.pnlAdmin.Visible = False
        '
        'txtIncentivo
        '
        Me.txtIncentivo.BackColor = System.Drawing.Color.White
        Me.txtIncentivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIncentivo.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncentivo.Location = New System.Drawing.Point(527, 281)
        Me.txtIncentivo.Name = "txtIncentivo"
        Me.txtIncentivo.Size = New System.Drawing.Size(176, 24)
        Me.txtIncentivo.TabIndex = 38
        Me.txtIncentivo.Visible = False
        '
        'pnlCantHoras
        '
        Me.pnlCantHoras.BackColor = System.Drawing.Color.Black
        Me.pnlCantHoras.Location = New System.Drawing.Point(430, 360)
        Me.pnlCantHoras.Name = "pnlCantHoras"
        Me.pnlCantHoras.Size = New System.Drawing.Size(176, 2)
        Me.pnlCantHoras.TabIndex = 41
        Me.pnlCantHoras.Visible = False
        '
        'txtCantHoras
        '
        Me.txtCantHoras.BackColor = System.Drawing.Color.White
        Me.txtCantHoras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantHoras.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantHoras.Location = New System.Drawing.Point(430, 331)
        Me.txtCantHoras.Name = "txtCantHoras"
        Me.txtCantHoras.Size = New System.Drawing.Size(176, 24)
        Me.txtCantHoras.TabIndex = 40
        Me.txtCantHoras.Visible = False
        '
        'txtPrecioHora
        '
        Me.txtPrecioHora.BackColor = System.Drawing.Color.White
        Me.txtPrecioHora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecioHora.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioHora.Location = New System.Drawing.Point(618, 331)
        Me.txtPrecioHora.Name = "txtPrecioHora"
        Me.txtPrecioHora.Size = New System.Drawing.Size(176, 24)
        Me.txtPrecioHora.TabIndex = 42
        Me.txtPrecioHora.Visible = False
        '
        'pnlPrecioHora
        '
        Me.pnlPrecioHora.BackColor = System.Drawing.Color.Black
        Me.pnlPrecioHora.Location = New System.Drawing.Point(618, 360)
        Me.pnlPrecioHora.Name = "pnlPrecioHora"
        Me.pnlPrecioHora.Size = New System.Drawing.Size(176, 2)
        Me.pnlPrecioHora.TabIndex = 43
        Me.pnlPrecioHora.Visible = False
        '
        'txtGerente
        '
        Me.txtGerente.BackColor = System.Drawing.Color.White
        Me.txtGerente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGerente.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGerente.Location = New System.Drawing.Point(527, 279)
        Me.txtGerente.Name = "txtGerente"
        Me.txtGerente.Size = New System.Drawing.Size(176, 24)
        Me.txtGerente.TabIndex = 44
        Me.txtGerente.Visible = False
        '
        'pnlGerente
        '
        Me.pnlGerente.BackColor = System.Drawing.Color.Black
        Me.pnlGerente.Location = New System.Drawing.Point(527, 309)
        Me.pnlGerente.Name = "pnlGerente"
        Me.pnlGerente.Size = New System.Drawing.Size(176, 2)
        Me.pnlGerente.TabIndex = 45
        Me.pnlGerente.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(329, 401)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 50)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'lblGerente
        '
        Me.lblGerente.AutoSize = True
        Me.lblGerente.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGerente.Location = New System.Drawing.Point(538, 251)
        Me.lblGerente.Name = "lblGerente"
        Me.lblGerente.Size = New System.Drawing.Size(140, 26)
        Me.lblGerente.TabIndex = 47
        Me.lblGerente.Text = "Nivel Gerente"
        Me.lblGerente.Visible = False
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(494, 251)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(247, 26)
        Me.lblAdmin.TabIndex = 48
        Me.lblAdmin.Text = "Incentivo Administrativo"
        Me.lblAdmin.Visible = False
        '
        'lblCantHoras
        '
        Me.lblCantHoras.AutoSize = True
        Me.lblCantHoras.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantHoras.Location = New System.Drawing.Point(425, 298)
        Me.lblCantHoras.Name = "lblCantHoras"
        Me.lblCantHoras.Size = New System.Drawing.Size(189, 26)
        Me.lblCantHoras.TabIndex = 49
        Me.lblCantHoras.Text = "Cantidad de Horas"
        Me.lblCantHoras.Visible = False
        '
        'lblPrecioHora
        '
        Me.lblPrecioHora.AutoSize = True
        Me.lblPrecioHora.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioHora.Location = New System.Drawing.Point(631, 298)
        Me.lblPrecioHora.Name = "lblPrecioHora"
        Me.lblPrecioHora.Size = New System.Drawing.Size(140, 26)
        Me.lblPrecioHora.TabIndex = 50
        Me.lblPrecioHora.Text = "Precio  / Hora"
        Me.lblPrecioHora.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(231, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(359, 40)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Registro de Empleados"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 472)
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
        Me.Controls.Add(Me.Panel1)
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
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblSueldoBase As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents txtSegundoApellido As TextBox
    Friend WithEvents lblSegundoApellido As Label
    Friend WithEvents txtPrimerApellido As TextBox
    Friend WithEvents lblPrimerApellido As Label
    Friend WithEvents txtSegundoNombre As TextBox
    Friend WithEvents lblSegundoNombre As Label
    Friend WithEvents lblPrimerNombre As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents lblCedula As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPrimerNombre As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents pnlAdmin As Panel
    Friend WithEvents txtIncentivo As TextBox
    Friend WithEvents pnlCantHoras As Panel
    Friend WithEvents txtCantHoras As TextBox
    Friend WithEvents txtPrecioHora As TextBox
    Friend WithEvents pnlPrecioHora As Panel
    Friend WithEvents txtGerente As TextBox
    Friend WithEvents pnlGerente As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblGerente As Label
    Friend WithEvents lblAdmin As Label
    Friend WithEvents lblCantHoras As Label
    Friend WithEvents lblPrecioHora As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
End Class
