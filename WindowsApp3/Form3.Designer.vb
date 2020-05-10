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
        Me.lbl_sueldo_base = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_tipo = New System.Windows.Forms.ComboBox()
        Me.txt_segundo_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_segundo_apellido = New System.Windows.Forms.Label()
        Me.txt_primer_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_primer_apellido = New System.Windows.Forms.Label()
        Me.txt_segundo_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_segundo_nombre = New System.Windows.Forms.Label()
        Me.lbl_primer_nombre = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.lbl_cedula = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_primer_nombre = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txt_sueldo = New System.Windows.Forms.TextBox()
        Me.pnlAdmin = New System.Windows.Forms.Panel()
        Me.txt_incentivo = New System.Windows.Forms.TextBox()
        Me.pnlCantHoras = New System.Windows.Forms.Panel()
        Me.txt_cant_horas = New System.Windows.Forms.TextBox()
        Me.txt_precio_hora = New System.Windows.Forms.TextBox()
        Me.pnlPrecioHora = New System.Windows.Forms.Panel()
        Me.txt_gerente = New System.Windows.Forms.TextBox()
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
        'lbl_sueldo_base
        '
        Me.lbl_sueldo_base.AutoSize = True
        Me.lbl_sueldo_base.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sueldo_base.Location = New System.Drawing.Point(425, 87)
        Me.lbl_sueldo_base.Name = "lbl_sueldo_base"
        Me.lbl_sueldo_base.Size = New System.Drawing.Size(127, 26)
        Me.lbl_sueldo_base.TabIndex = 28
        Me.lbl_sueldo_base.Text = "Sueldo base"
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
        'cbo_tipo
        '
        Me.cbo_tipo.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tipo.FormattingEnabled = True
        Me.cbo_tipo.Location = New System.Drawing.Point(451, 200)
        Me.cbo_tipo.Name = "cbo_tipo"
        Me.cbo_tipo.Size = New System.Drawing.Size(308, 34)
        Me.cbo_tipo.TabIndex = 26
        '
        'txt_segundo_apellido
        '
        Me.txt_segundo_apellido.BackColor = System.Drawing.Color.White
        Me.txt_segundo_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_segundo_apellido.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_segundo_apellido.Location = New System.Drawing.Point(224, 330)
        Me.txt_segundo_apellido.Name = "txt_segundo_apellido"
        Me.txt_segundo_apellido.Size = New System.Drawing.Size(176, 24)
        Me.txt_segundo_apellido.TabIndex = 22
        '
        'lbl_segundo_apellido
        '
        Me.lbl_segundo_apellido.AutoSize = True
        Me.lbl_segundo_apellido.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_segundo_apellido.Location = New System.Drawing.Point(16, 335)
        Me.lbl_segundo_apellido.Name = "lbl_segundo_apellido"
        Me.lbl_segundo_apellido.Size = New System.Drawing.Size(182, 26)
        Me.lbl_segundo_apellido.TabIndex = 25
        Me.lbl_segundo_apellido.Text = "Segundo Apellido"
        '
        'txt_primer_apellido
        '
        Me.txt_primer_apellido.BackColor = System.Drawing.Color.White
        Me.txt_primer_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_primer_apellido.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_primer_apellido.Location = New System.Drawing.Point(224, 268)
        Me.txt_primer_apellido.Name = "txt_primer_apellido"
        Me.txt_primer_apellido.Size = New System.Drawing.Size(176, 24)
        Me.txt_primer_apellido.TabIndex = 20
        '
        'lbl_primer_apellido
        '
        Me.lbl_primer_apellido.AutoSize = True
        Me.lbl_primer_apellido.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_primer_apellido.Location = New System.Drawing.Point(16, 274)
        Me.lbl_primer_apellido.Name = "lbl_primer_apellido"
        Me.lbl_primer_apellido.Size = New System.Drawing.Size(161, 26)
        Me.lbl_primer_apellido.TabIndex = 24
        Me.lbl_primer_apellido.Text = "Primer Apellido"
        '
        'txt_segundo_nombre
        '
        Me.txt_segundo_nombre.BackColor = System.Drawing.Color.White
        Me.txt_segundo_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_segundo_nombre.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_segundo_nombre.Location = New System.Drawing.Point(224, 200)
        Me.txt_segundo_nombre.Name = "txt_segundo_nombre"
        Me.txt_segundo_nombre.Size = New System.Drawing.Size(176, 24)
        Me.txt_segundo_nombre.TabIndex = 19
        '
        'lbl_segundo_nombre
        '
        Me.lbl_segundo_nombre.AutoSize = True
        Me.lbl_segundo_nombre.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_segundo_nombre.Location = New System.Drawing.Point(16, 206)
        Me.lbl_segundo_nombre.Name = "lbl_segundo_nombre"
        Me.lbl_segundo_nombre.Size = New System.Drawing.Size(183, 26)
        Me.lbl_segundo_nombre.TabIndex = 21
        Me.lbl_segundo_nombre.Text = "Segundo Nombre"
        '
        'lbl_primer_nombre
        '
        Me.lbl_primer_nombre.AutoSize = True
        Me.lbl_primer_nombre.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_primer_nombre.Location = New System.Drawing.Point(15, 140)
        Me.lbl_primer_nombre.Name = "lbl_primer_nombre"
        Me.lbl_primer_nombre.Size = New System.Drawing.Size(162, 26)
        Me.lbl_primer_nombre.TabIndex = 18
        Me.lbl_primer_nombre.Text = "Primer Nombre"
        '
        'txt_cedula
        '
        Me.txt_cedula.BackColor = System.Drawing.Color.White
        Me.txt_cedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cedula.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cedula.Location = New System.Drawing.Point(101, 82)
        Me.txt_cedula.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(104, 24)
        Me.txt_cedula.TabIndex = 16
        '
        'lbl_cedula
        '
        Me.lbl_cedula.AutoSize = True
        Me.lbl_cedula.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cedula.Location = New System.Drawing.Point(16, 87)
        Me.lbl_cedula.Name = "lbl_cedula"
        Me.lbl_cedula.Size = New System.Drawing.Size(79, 26)
        Me.lbl_cedula.TabIndex = 15
        Me.lbl_cedula.Text = "Cédula"
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
        'txt_primer_nombre
        '
        Me.txt_primer_nombre.BackColor = System.Drawing.Color.White
        Me.txt_primer_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_primer_nombre.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_primer_nombre.Location = New System.Drawing.Point(224, 139)
        Me.txt_primer_nombre.Name = "txt_primer_nombre"
        Me.txt_primer_nombre.Size = New System.Drawing.Size(176, 24)
        Me.txt_primer_nombre.TabIndex = 34
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(558, 118)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(173, 2)
        Me.Panel6.TabIndex = 37
        '
        'txt_sueldo
        '
        Me.txt_sueldo.BackColor = System.Drawing.Color.White
        Me.txt_sueldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_sueldo.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sueldo.Location = New System.Drawing.Point(558, 89)
        Me.txt_sueldo.Name = "txt_sueldo"
        Me.txt_sueldo.Size = New System.Drawing.Size(173, 24)
        Me.txt_sueldo.TabIndex = 36
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
        'txt_incentivo
        '
        Me.txt_incentivo.BackColor = System.Drawing.Color.White
        Me.txt_incentivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_incentivo.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_incentivo.Location = New System.Drawing.Point(527, 281)
        Me.txt_incentivo.Name = "txt_incentivo"
        Me.txt_incentivo.Size = New System.Drawing.Size(176, 24)
        Me.txt_incentivo.TabIndex = 38
        Me.txt_incentivo.Visible = False
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
        'txt_cant_horas
        '
        Me.txt_cant_horas.BackColor = System.Drawing.Color.White
        Me.txt_cant_horas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cant_horas.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cant_horas.Location = New System.Drawing.Point(430, 331)
        Me.txt_cant_horas.Name = "txt_cant_horas"
        Me.txt_cant_horas.Size = New System.Drawing.Size(176, 24)
        Me.txt_cant_horas.TabIndex = 40
        Me.txt_cant_horas.Visible = False
        '
        'txt_precio_hora
        '
        Me.txt_precio_hora.BackColor = System.Drawing.Color.White
        Me.txt_precio_hora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_precio_hora.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio_hora.Location = New System.Drawing.Point(618, 331)
        Me.txt_precio_hora.Name = "txt_precio_hora"
        Me.txt_precio_hora.Size = New System.Drawing.Size(176, 24)
        Me.txt_precio_hora.TabIndex = 42
        Me.txt_precio_hora.Visible = False
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
        'txt_gerente
        '
        Me.txt_gerente.BackColor = System.Drawing.Color.White
        Me.txt_gerente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_gerente.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_gerente.Location = New System.Drawing.Point(527, 279)
        Me.txt_gerente.Name = "txt_gerente"
        Me.txt_gerente.Size = New System.Drawing.Size(176, 24)
        Me.txt_gerente.TabIndex = 44
        Me.txt_gerente.Visible = False
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
        Me.Controls.Add(Me.txt_gerente)
        Me.Controls.Add(Me.pnlGerente)
        Me.Controls.Add(Me.txt_precio_hora)
        Me.Controls.Add(Me.pnlPrecioHora)
        Me.Controls.Add(Me.txt_cant_horas)
        Me.Controls.Add(Me.pnlAdmin)
        Me.Controls.Add(Me.pnlCantHoras)
        Me.Controls.Add(Me.txt_incentivo)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txt_sueldo)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txt_primer_nombre)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_sueldo_base)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_tipo)
        Me.Controls.Add(Me.txt_segundo_apellido)
        Me.Controls.Add(Me.lbl_segundo_apellido)
        Me.Controls.Add(Me.txt_primer_apellido)
        Me.Controls.Add(Me.lbl_primer_apellido)
        Me.Controls.Add(Me.txt_segundo_nombre)
        Me.Controls.Add(Me.lbl_segundo_nombre)
        Me.Controls.Add(Me.lbl_primer_nombre)
        Me.Controls.Add(Me.txt_cedula)
        Me.Controls.Add(Me.lbl_cedula)
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
    Friend WithEvents lbl_sueldo_base As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_tipo As ComboBox
    Friend WithEvents txt_segundo_apellido As TextBox
    Friend WithEvents lbl_segundo_apellido As Label
    Friend WithEvents txt_primer_apellido As TextBox
    Friend WithEvents lbl_primer_apellido As Label
    Friend WithEvents txt_segundo_nombre As TextBox
    Friend WithEvents lbl_segundo_nombre As Label
    Friend WithEvents lbl_primer_nombre As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents lbl_cedula As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_primer_nombre As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txt_sueldo As TextBox
    Friend WithEvents pnlAdmin As Panel
    Friend WithEvents txt_incentivo As TextBox
    Friend WithEvents pnlCantHoras As Panel
    Friend WithEvents txt_cant_horas As TextBox
    Friend WithEvents txt_precio_hora As TextBox
    Friend WithEvents pnlPrecioHora As Panel
    Friend WithEvents txt_gerente As TextBox
    Friend WithEvents pnlGerente As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblGerente As Label
    Friend WithEvents lblAdmin As Label
    Friend WithEvents lblCantHoras As Label
    Friend WithEvents lblPrecioHora As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
End Class
