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
        Me.Button2.Location = New System.Drawing.Point(989, -11)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(1)
        Me.Button2.Size = New System.Drawing.Size(39, 44)
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
        Me.Button1.Location = New System.Drawing.Point(1028, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(1)
        Me.Button1.Size = New System.Drawing.Size(39, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblSueldoBase
        '
        Me.lblSueldoBase.AutoSize = True
        Me.lblSueldoBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSueldoBase.Location = New System.Drawing.Point(567, 107)
        Me.lblSueldoBase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSueldoBase.Name = "lblSueldoBase"
        Me.lblSueldoBase.Size = New System.Drawing.Size(149, 29)
        Me.lblSueldoBase.TabIndex = 28
        Me.lblSueldoBase.Text = "Sueldo base"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(717, 196)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 29)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Tipo Empleado"
        '
        'cboTipo
        '
        Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(601, 246)
        Me.cboTipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(409, 37)
        Me.cboTipo.TabIndex = 26
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.BackColor = System.Drawing.Color.White
        Me.txtSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoApellido.Location = New System.Drawing.Point(299, 406)
        Me.txtSegundoApellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(235, 27)
        Me.txtSegundoApellido.TabIndex = 22
        '
        'lblSegundoApellido
        '
        Me.lblSegundoApellido.AutoSize = True
        Me.lblSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundoApellido.Location = New System.Drawing.Point(21, 412)
        Me.lblSegundoApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSegundoApellido.Name = "lblSegundoApellido"
        Me.lblSegundoApellido.Size = New System.Drawing.Size(206, 29)
        Me.lblSegundoApellido.TabIndex = 25
        Me.lblSegundoApellido.Text = "Segundo Apellido"
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.BackColor = System.Drawing.Color.White
        Me.txtPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerApellido.Location = New System.Drawing.Point(299, 330)
        Me.txtPrimerApellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(235, 27)
        Me.txtPrimerApellido.TabIndex = 20
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.AutoSize = True
        Me.lblPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerApellido.Location = New System.Drawing.Point(21, 337)
        Me.lblPrimerApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(180, 29)
        Me.lblPrimerApellido.TabIndex = 24
        Me.lblPrimerApellido.Text = "Primer Apellido"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.BackColor = System.Drawing.Color.White
        Me.txtSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSegundoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoNombre.Location = New System.Drawing.Point(299, 246)
        Me.txtSegundoNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(235, 27)
        Me.txtSegundoNombre.TabIndex = 19
        '
        'lblSegundoNombre
        '
        Me.lblSegundoNombre.AutoSize = True
        Me.lblSegundoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundoNombre.Location = New System.Drawing.Point(21, 254)
        Me.lblSegundoNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSegundoNombre.Name = "lblSegundoNombre"
        Me.lblSegundoNombre.Size = New System.Drawing.Size(205, 29)
        Me.lblSegundoNombre.TabIndex = 21
        Me.lblSegundoNombre.Text = "Segundo Nombre"
        '
        'lblPrimerNombre
        '
        Me.lblPrimerNombre.AutoSize = True
        Me.lblPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerNombre.Location = New System.Drawing.Point(20, 172)
        Me.lblPrimerNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrimerNombre.Name = "lblPrimerNombre"
        Me.lblPrimerNombre.Size = New System.Drawing.Size(179, 29)
        Me.lblPrimerNombre.TabIndex = 18
        Me.lblPrimerNombre.Text = "Primer Nombre"
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.White
        Me.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(135, 101)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(139, 27)
        Me.txtCedula.TabIndex = 16
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(21, 107)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(90, 29)
        Me.lblCedula.TabIndex = 15
        Me.lblCedula.Text = "Cédula"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(135, 134)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(139, 2)
        Me.Panel1.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(299, 283)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(235, 2)
        Me.Panel2.TabIndex = 31
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(299, 367)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(235, 2)
        Me.Panel4.TabIndex = 32
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(299, 443)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(235, 2)
        Me.Panel5.TabIndex = 33
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(299, 208)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(235, 2)
        Me.Panel3.TabIndex = 35
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.BackColor = System.Drawing.Color.White
        Me.txtPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerNombre.Location = New System.Drawing.Point(299, 171)
        Me.txtPrimerNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(235, 27)
        Me.txtPrimerNombre.TabIndex = 34
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(744, 145)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(231, 2)
        Me.Panel6.TabIndex = 37
        '
        'txtSueldo
        '
        Me.txtSueldo.BackColor = System.Drawing.Color.White
        Me.txtSueldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSueldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSueldo.Location = New System.Drawing.Point(744, 110)
        Me.txtSueldo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(231, 27)
        Me.txtSueldo.TabIndex = 36
        '
        'pnlAdmin
        '
        Me.pnlAdmin.BackColor = System.Drawing.Color.Black
        Me.pnlAdmin.Location = New System.Drawing.Point(703, 382)
        Me.pnlAdmin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlAdmin.Name = "pnlAdmin"
        Me.pnlAdmin.Size = New System.Drawing.Size(235, 2)
        Me.pnlAdmin.TabIndex = 39
        Me.pnlAdmin.Visible = False
        '
        'txtIncentivo
        '
        Me.txtIncentivo.BackColor = System.Drawing.Color.White
        Me.txtIncentivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIncentivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncentivo.Location = New System.Drawing.Point(703, 346)
        Me.txtIncentivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIncentivo.Name = "txtIncentivo"
        Me.txtIncentivo.Size = New System.Drawing.Size(235, 27)
        Me.txtIncentivo.TabIndex = 38
        Me.txtIncentivo.Visible = False
        '
        'pnlCantHoras
        '
        Me.pnlCantHoras.BackColor = System.Drawing.Color.Black
        Me.pnlCantHoras.Location = New System.Drawing.Point(573, 443)
        Me.pnlCantHoras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlCantHoras.Name = "pnlCantHoras"
        Me.pnlCantHoras.Size = New System.Drawing.Size(235, 2)
        Me.pnlCantHoras.TabIndex = 41
        Me.pnlCantHoras.Visible = False
        '
        'txtCantHoras
        '
        Me.txtCantHoras.BackColor = System.Drawing.Color.White
        Me.txtCantHoras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantHoras.Location = New System.Drawing.Point(573, 407)
        Me.txtCantHoras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCantHoras.Name = "txtCantHoras"
        Me.txtCantHoras.Size = New System.Drawing.Size(235, 27)
        Me.txtCantHoras.TabIndex = 40
        Me.txtCantHoras.Visible = False
        '
        'txtPrecioHora
        '
        Me.txtPrecioHora.BackColor = System.Drawing.Color.White
        Me.txtPrecioHora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecioHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioHora.Location = New System.Drawing.Point(824, 407)
        Me.txtPrecioHora.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioHora.Name = "txtPrecioHora"
        Me.txtPrecioHora.Size = New System.Drawing.Size(235, 27)
        Me.txtPrecioHora.TabIndex = 42
        Me.txtPrecioHora.Visible = False
        '
        'pnlPrecioHora
        '
        Me.pnlPrecioHora.BackColor = System.Drawing.Color.Black
        Me.pnlPrecioHora.Location = New System.Drawing.Point(824, 443)
        Me.pnlPrecioHora.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlPrecioHora.Name = "pnlPrecioHora"
        Me.pnlPrecioHora.Size = New System.Drawing.Size(235, 2)
        Me.pnlPrecioHora.TabIndex = 43
        Me.pnlPrecioHora.Visible = False
        '
        'txtGerente
        '
        Me.txtGerente.BackColor = System.Drawing.Color.White
        Me.txtGerente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGerente.Location = New System.Drawing.Point(703, 343)
        Me.txtGerente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGerente.Name = "txtGerente"
        Me.txtGerente.Size = New System.Drawing.Size(235, 27)
        Me.txtGerente.TabIndex = 44
        Me.txtGerente.Visible = False
        '
        'pnlGerente
        '
        Me.pnlGerente.BackColor = System.Drawing.Color.Black
        Me.pnlGerente.Location = New System.Drawing.Point(703, 380)
        Me.pnlGerente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlGerente.Name = "pnlGerente"
        Me.pnlGerente.Size = New System.Drawing.Size(235, 2)
        Me.pnlGerente.TabIndex = 45
        Me.pnlGerente.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(439, 494)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 62)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'lblGerente
        '
        Me.lblGerente.AutoSize = True
        Me.lblGerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGerente.Location = New System.Drawing.Point(717, 309)
        Me.lblGerente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGerente.Name = "lblGerente"
        Me.lblGerente.Size = New System.Drawing.Size(161, 29)
        Me.lblGerente.TabIndex = 47
        Me.lblGerente.Text = "Nivel Gerente"
        Me.lblGerente.Visible = False
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(659, 309)
        Me.lblAdmin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(264, 29)
        Me.lblAdmin.TabIndex = 48
        Me.lblAdmin.Text = "Incentivo Administrativo"
        Me.lblAdmin.Visible = False
        '
        'lblCantHoras
        '
        Me.lblCantHoras.AutoSize = True
        Me.lblCantHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantHoras.Location = New System.Drawing.Point(567, 367)
        Me.lblCantHoras.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCantHoras.Name = "lblCantHoras"
        Me.lblCantHoras.Size = New System.Drawing.Size(213, 29)
        Me.lblCantHoras.TabIndex = 49
        Me.lblCantHoras.Text = "Cantidad de Horas"
        Me.lblCantHoras.Visible = False
        '
        'lblPrecioHora
        '
        Me.lblPrecioHora.AutoSize = True
        Me.lblPrecioHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioHora.Location = New System.Drawing.Point(841, 367)
        Me.lblPrecioHora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecioHora.Name = "lblPrecioHora"
        Me.lblPrecioHora.Size = New System.Drawing.Size(160, 29)
        Me.lblPrecioHora.TabIndex = 50
        Me.lblPrecioHora.Text = "Precio  / Hora"
        Me.lblPrecioHora.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(28, 15)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 31)
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(308, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(406, 42)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Registro de Empleados"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 581)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
