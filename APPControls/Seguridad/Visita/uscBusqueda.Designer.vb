Namespace Visita
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscBusqueda
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscBusqueda))
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.lblRegPersonas = New System.Windows.Forms.Label()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rdbTipoVisita = New System.Windows.Forms.RadioButton()
            Me.rdbParentescoTodos = New System.Windows.Forms.RadioButton()
            Me.rdbParentesco = New System.Windows.Forms.RadioButton()
            Me.cbbParentesco = New APPControls.uscComboParametrica()
            Me.pnlFecha = New System.Windows.Forms.Panel()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.cbbTipoRegimen = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.gb_menores = New System.Windows.Forms.GroupBox()
            Me.rb_menor_menor = New System.Windows.Forms.RadioButton()
            Me.rb_menor_todos = New System.Windows.Forms.RadioButton()
            Me.rb_menor_adulto = New System.Windows.Forms.RadioButton()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.rdbTodos = New System.Windows.Forms.RadioButton()
            Me.rdbSinSal = New System.Windows.Forms.RadioButton()
            Me.rdbConSal = New System.Windows.Forms.RadioButton()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.rdbFechaRango = New System.Windows.Forms.RadioButton()
            Me.rdbFechaUni = New System.Windows.Forms.RadioButton()
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.dtpFechaIni = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.dtpFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtIntNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtIntApeNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label8 = New System.Windows.Forms.Label()
            Me.GroupBox8 = New System.Windows.Forms.GroupBox()
            Me.cbbTipoDoc = New APPControls.uscComboParametrica()
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.chk_visitante_menor = New Legolas.APPUIComponents.myCheckBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtpasenumero = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtVisNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtVisApeNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.pnlDetalle = New System.Windows.Forms.Panel()
            Me.dgwMovi = New Legolas.APPUIComponents.myDatagridView()
            Me.col_mov_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mov_id_pdr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_men_tip = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pas_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_ape_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_ape_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_hor_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_ing_por = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.UsuarioAutorizaSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_hor_sal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_sal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_min_per = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ico_nin_men = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_men_can = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fot_vis = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.UscFoto1 = New APPControls.Foto.uscFotografia()
            Me.pnlBusqueda.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.pnlFecha.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.gb_menores.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox8.SuspendLayout()
            Me.cbbTipoDoc.SuspendLayout()
            Me.pnlDetalle.SuspendLayout()
            CType(Me.dgwMovi, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.Controls.Add(Me.grbBuscar)
            Me.pnlBusqueda.Controls.Add(Me.GroupBox4)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(1024, 198)
            Me.pnlBusqueda.TabIndex = 71
            '
            'grbBuscar
            '
            Me.grbBuscar.Controls.Add(Me.lblRegPersonas)
            Me.grbBuscar.Controls.Add(Me.lblReg)
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Left
            Me.grbBuscar.Location = New System.Drawing.Point(934, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(83, 198)
            Me.grbBuscar.TabIndex = 62
            Me.grbBuscar.TabStop = False
            '
            'lblRegPersonas
            '
            Me.lblRegPersonas.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblRegPersonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRegPersonas.Location = New System.Drawing.Point(3, 151)
            Me.lblRegPersonas.Name = "lblRegPersonas"
            Me.lblRegPersonas.Size = New System.Drawing.Size(77, 22)
            Me.lblRegPersonas.TabIndex = 91
            Me.lblRegPersonas.Text = "0 Vis."
            Me.lblRegPersonas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblReg.Location = New System.Drawing.Point(3, 173)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(77, 22)
            Me.lblReg.TabIndex = 34
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblReg.Visible = False
            '
            'ToolStrip1
            '
            Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar})
            Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 179)
            Me.ToolStrip1.TabIndex = 90
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
            Me.tsbBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscar.Name = "tsbBuscar"
            Me.tsbBuscar.Size = New System.Drawing.Size(75, 43)
            Me.tsbBuscar.Text = "Buscar"
            Me.tsbBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.GroupBox1)
            Me.GroupBox4.Controls.Add(Me.pnlFecha)
            Me.GroupBox4.Controls.Add(Me.GroupBox3)
            Me.GroupBox4.Controls.Add(Me.GroupBox8)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(934, 198)
            Me.GroupBox4.TabIndex = 65
            Me.GroupBox4.TabStop = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rdbTipoVisita)
            Me.GroupBox1.Controls.Add(Me.rdbParentescoTodos)
            Me.GroupBox1.Controls.Add(Me.rdbParentesco)
            Me.GroupBox1.Controls.Add(Me.cbbParentesco)
            Me.GroupBox1.Location = New System.Drawing.Point(326, 95)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(179, 87)
            Me.GroupBox1.TabIndex = 72
            Me.GroupBox1.TabStop = False
            '
            'rdbTipoVisita
            '
            Me.rdbTipoVisita.AutoSize = True
            Me.rdbTipoVisita.Location = New System.Drawing.Point(94, 14)
            Me.rdbTipoVisita.Name = "rdbTipoVisita"
            Me.rdbTipoVisita.Size = New System.Drawing.Size(74, 17)
            Me.rdbTipoVisita.TabIndex = 68
            Me.rdbTipoVisita.Text = "Tipo Visita"
            Me.rdbTipoVisita.UseVisualStyleBackColor = True
            '
            'rdbParentescoTodos
            '
            Me.rdbParentescoTodos.AutoSize = True
            Me.rdbParentescoTodos.Checked = True
            Me.rdbParentescoTodos.Location = New System.Drawing.Point(7, 37)
            Me.rdbParentescoTodos.Name = "rdbParentescoTodos"
            Me.rdbParentescoTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbParentescoTodos.TabIndex = 66
            Me.rdbParentescoTodos.TabStop = True
            Me.rdbParentescoTodos.Text = "Todos"
            Me.rdbParentescoTodos.UseVisualStyleBackColor = True
            '
            'rdbParentesco
            '
            Me.rdbParentesco.AutoSize = True
            Me.rdbParentesco.Location = New System.Drawing.Point(7, 14)
            Me.rdbParentesco.Name = "rdbParentesco"
            Me.rdbParentesco.Size = New System.Drawing.Size(79, 17)
            Me.rdbParentesco.TabIndex = 67
            Me.rdbParentesco.Text = "Parentesco"
            Me.rdbParentesco.UseVisualStyleBackColor = True
            '
            'cbbParentesco
            '
            Me.cbbParentesco._NoIndica = False
            Me.cbbParentesco._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbParentesco._Todos = False
            Me.cbbParentesco._TodosMensaje = ""
            Me.cbbParentesco._Visible_Add = False
            Me.cbbParentesco._Visible_Buscar = False
            Me.cbbParentesco._Visible_Eliminar = False
            Me.cbbParentesco.CodigoPadre = -1
            Me.cbbParentesco.ComboTipo = CType(49, Short)
            Me.cbbParentesco.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbParentesco.DropDownWidth = 81
            Me.cbbParentesco.DropDownWidthAuto = True
            Me.cbbParentesco.ListaIdsParaExcluir = Nothing
            Me.cbbParentesco.Location = New System.Drawing.Point(7, 58)
            Me.cbbParentesco.ModuloTratamiento = False
            Me.cbbParentesco.Name = "cbbParentesco"
            Me.cbbParentesco.Parametro1 = -1
            Me.cbbParentesco.Parametro2 = -1
            Me.cbbParentesco.SelectedIndex = -1
            Me.cbbParentesco.SelectedValue = 0
            Me.cbbParentesco.Size = New System.Drawing.Size(156, 22)
            Me.cbbParentesco.TabIndex = 36
            Me.cbbParentesco.verToolTipItemSeleccionado = False
            '
            'pnlFecha
            '
            Me.pnlFecha.Controls.Add(Me.GroupBox6)
            Me.pnlFecha.Controls.Add(Me.gb_menores)
            Me.pnlFecha.Controls.Add(Me.GroupBox5)
            Me.pnlFecha.Controls.Add(Me.GroupBox2)
            Me.pnlFecha.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlFecha.Location = New System.Drawing.Point(3, 16)
            Me.pnlFecha.Name = "pnlFecha"
            Me.pnlFecha.Size = New System.Drawing.Size(928, 77)
            Me.pnlFecha.TabIndex = 65
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.cbbTipoRegimen)
            Me.GroupBox6.Controls.Add(Me.Label3)
            Me.GroupBox6.Location = New System.Drawing.Point(662, 3)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(162, 71)
            Me.GroupBox6.TabIndex = 71
            Me.GroupBox6.TabStop = False
            '
            'cbbTipoRegimen
            '
            Me.cbbTipoRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbTipoRegimen.FormattingEnabled = True
            Me.cbbTipoRegimen.Location = New System.Drawing.Point(6, 41)
            Me.cbbTipoRegimen.Name = "cbbTipoRegimen"
            Me.cbbTipoRegimen.Size = New System.Drawing.Size(150, 21)
            Me.cbbTipoRegimen.TabIndex = 71
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(6, 19)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(88, 13)
            Me.Label3.TabIndex = 70
            Me.Label3.Text = "Tipo de Regimen"
            '
            'gb_menores
            '
            Me.gb_menores.Controls.Add(Me.rb_menor_menor)
            Me.gb_menores.Controls.Add(Me.rb_menor_todos)
            Me.gb_menores.Controls.Add(Me.rb_menor_adulto)
            Me.gb_menores.Location = New System.Drawing.Point(323, 40)
            Me.gb_menores.Name = "gb_menores"
            Me.gb_menores.Size = New System.Drawing.Size(333, 34)
            Me.gb_menores.TabIndex = 65
            Me.gb_menores.TabStop = False
            Me.gb_menores.Text = "Ingreso por Edad"
            '
            'rb_menor_menor
            '
            Me.rb_menor_menor.AutoSize = True
            Me.rb_menor_menor.Location = New System.Drawing.Point(143, 13)
            Me.rb_menor_menor.Name = "rb_menor_menor"
            Me.rb_menor_menor.Size = New System.Drawing.Size(66, 17)
            Me.rb_menor_menor.TabIndex = 68
            Me.rb_menor_menor.Text = "Menores"
            Me.rb_menor_menor.UseVisualStyleBackColor = True
            '
            'rb_menor_todos
            '
            Me.rb_menor_todos.AutoSize = True
            Me.rb_menor_todos.Checked = True
            Me.rb_menor_todos.Location = New System.Drawing.Point(263, 13)
            Me.rb_menor_todos.Name = "rb_menor_todos"
            Me.rb_menor_todos.Size = New System.Drawing.Size(55, 17)
            Me.rb_menor_todos.TabIndex = 66
            Me.rb_menor_todos.TabStop = True
            Me.rb_menor_todos.Text = "Todos"
            Me.rb_menor_todos.UseVisualStyleBackColor = True
            '
            'rb_menor_adulto
            '
            Me.rb_menor_adulto.AutoSize = True
            Me.rb_menor_adulto.Location = New System.Drawing.Point(27, 13)
            Me.rb_menor_adulto.Name = "rb_menor_adulto"
            Me.rb_menor_adulto.Size = New System.Drawing.Size(60, 17)
            Me.rb_menor_adulto.TabIndex = 67
            Me.rb_menor_adulto.Text = "Adultos"
            Me.rb_menor_adulto.UseVisualStyleBackColor = True
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.rdbTodos)
            Me.GroupBox5.Controls.Add(Me.rdbSinSal)
            Me.GroupBox5.Controls.Add(Me.rdbConSal)
            Me.GroupBox5.Location = New System.Drawing.Point(323, 3)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(333, 34)
            Me.GroupBox5.TabIndex = 60
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Estado de Movimiento"
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Location = New System.Drawing.Point(263, 13)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbTodos.TabIndex = 68
            Me.rdbTodos.Text = "Todos"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbSinSal
            '
            Me.rdbSinSal.AutoSize = True
            Me.rdbSinSal.Checked = True
            Me.rdbSinSal.Location = New System.Drawing.Point(27, 13)
            Me.rdbSinSal.Name = "rdbSinSal"
            Me.rdbSinSal.Size = New System.Drawing.Size(106, 17)
            Me.rdbSinSal.TabIndex = 66
            Me.rdbSinSal.TabStop = True
            Me.rdbSinSal.Text = "Ingreso sin salida"
            Me.rdbSinSal.UseVisualStyleBackColor = True
            '
            'rdbConSal
            '
            Me.rdbConSal.AutoSize = True
            Me.rdbConSal.Location = New System.Drawing.Point(143, 13)
            Me.rdbConSal.Name = "rdbConSal"
            Me.rdbConSal.Size = New System.Drawing.Size(111, 17)
            Me.rdbConSal.TabIndex = 67
            Me.rdbConSal.Text = "Ingreso con salida"
            Me.rdbConSal.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.rdbFechaRango)
            Me.GroupBox2.Controls.Add(Me.rdbFechaUni)
            Me.GroupBox2.Controls.Add(Me.dtpFechaFin)
            Me.GroupBox2.Controls.Add(Me.dtpFechaIni)
            Me.GroupBox2.Controls.Add(Me.dtpFecha)
            Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(312, 68)
            Me.GroupBox2.TabIndex = 64
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Periodo"
            '
            'rdbFechaRango
            '
            Me.rdbFechaRango.AutoSize = True
            Me.rdbFechaRango.Enabled = False
            Me.rdbFechaRango.Location = New System.Drawing.Point(6, 43)
            Me.rdbFechaRango.Name = "rdbFechaRango"
            Me.rdbFechaRango.Size = New System.Drawing.Size(107, 17)
            Me.rdbFechaRango.TabIndex = 6
            Me.rdbFechaRango.Text = "Rango de fechas"
            Me.rdbFechaRango.UseVisualStyleBackColor = True
            '
            'rdbFechaUni
            '
            Me.rdbFechaUni.AutoSize = True
            Me.rdbFechaUni.Checked = True
            Me.rdbFechaUni.Location = New System.Drawing.Point(6, 17)
            Me.rdbFechaUni.Name = "rdbFechaUni"
            Me.rdbFechaUni.Size = New System.Drawing.Size(84, 17)
            Me.rdbFechaUni.TabIndex = 5
            Me.rdbFechaUni.TabStop = True
            Me.rdbFechaUni.Text = "Fecha unica"
            Me.rdbFechaUni.UseVisualStyleBackColor = True
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Location = New System.Drawing.Point(221, 42)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 4
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'dtpFechaIni
            '
            Me.dtpFechaIni.Location = New System.Drawing.Point(117, 42)
            Me.dtpFechaIni.Name = "dtpFechaIni"
            Me.dtpFechaIni.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIni.TabIndex = 3
            Me.dtpFechaIni.Value = "/  /"
            Me.dtpFechaIni.ValueLong = CType(0, Long)
            '
            'dtpFecha
            '
            Me.dtpFecha.Enabled = False
            Me.dtpFecha.Location = New System.Drawing.Point(117, 13)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpFecha.TabIndex = 2
            Me.dtpFecha.Value = "/  /"
            Me.dtpFecha.ValueLong = CType(0, Long)
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.Label5)
            Me.GroupBox3.Controls.Add(Me.txtIntNumDoc)
            Me.GroupBox3.Controls.Add(Me.txtIntApeNom)
            Me.GroupBox3.Controls.Add(Me.Label8)
            Me.GroupBox3.Location = New System.Drawing.Point(512, 95)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(315, 87)
            Me.GroupBox3.TabIndex = 64
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Interno"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(6, 17)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(61, 13)
            Me.Label5.TabIndex = 35
            Me.Label5.Text = "Nro D.N.I. :"
            '
            'txtIntNumDoc
            '
            Me.txtIntNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtIntNumDoc._BloquearPaste = False
            Me.txtIntNumDoc._SeleccionarTodo = True
            Me.txtIntNumDoc.Location = New System.Drawing.Point(110, 13)
            Me.txtIntNumDoc.Name = "txtIntNumDoc"
            Me.txtIntNumDoc.Size = New System.Drawing.Size(135, 20)
            Me.txtIntNumDoc.TabIndex = 34
            Me.txtIntNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtIntNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtIntApeNom
            '
            Me.txtIntApeNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtIntApeNom._BloquearPaste = False
            Me.txtIntApeNom._SeleccionarTodo = True
            Me.txtIntApeNom.Location = New System.Drawing.Point(9, 58)
            Me.txtIntApeNom.Name = "txtIntApeNom"
            Me.txtIntApeNom.Size = New System.Drawing.Size(300, 20)
            Me.txtIntApeNom.TabIndex = 0
            Me.txtIntApeNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtIntApeNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(6, 39)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(108, 13)
            Me.Label8.TabIndex = 2
            Me.Label8.Text = "Apellidos y Nombres :"
            '
            'GroupBox8
            '
            Me.GroupBox8.Controls.Add(Me.cbbTipoDoc)
            Me.GroupBox8.Controls.Add(Me.chk_visitante_menor)
            Me.GroupBox8.Controls.Add(Me.Label2)
            Me.GroupBox8.Controls.Add(Me.txtpasenumero)
            Me.GroupBox8.Controls.Add(Me.Label4)
            Me.GroupBox8.Controls.Add(Me.txtVisNumDoc)
            Me.GroupBox8.Controls.Add(Me.txtVisApeNom)
            Me.GroupBox8.Controls.Add(Me.Label1)
            Me.GroupBox8.Location = New System.Drawing.Point(6, 95)
            Me.GroupBox8.Name = "GroupBox8"
            Me.GroupBox8.Size = New System.Drawing.Size(312, 87)
            Me.GroupBox8.TabIndex = 61
            Me.GroupBox8.TabStop = False
            Me.GroupBox8.Text = "Visitante"
            '
            'cbbTipoDoc
            '
            Me.cbbTipoDoc._NoIndica = False
            Me.cbbTipoDoc._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipoDoc._Todos = False
            Me.cbbTipoDoc._TodosMensaje = ""
            Me.cbbTipoDoc._Visible_Add = False
            Me.cbbTipoDoc._Visible_Buscar = False
            Me.cbbTipoDoc._Visible_Eliminar = False
            Me.cbbTipoDoc.CodigoPadre = -1
            Me.cbbTipoDoc.ComboTipo = CType(0, Short)
            Me.cbbTipoDoc.Controls.Add(Me.ComboBox1)
            Me.cbbTipoDoc.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoDoc.DropDownWidth = 105
            Me.cbbTipoDoc.DropDownWidthAuto = False
            Me.cbbTipoDoc.ListaIdsParaExcluir = Nothing
            Me.cbbTipoDoc.Location = New System.Drawing.Point(120, 11)
            Me.cbbTipoDoc.ModuloTratamiento = False
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Parametro1 = -1
            Me.cbbTipoDoc.Parametro2 = -1
            Me.cbbTipoDoc.SelectedIndex = -1
            Me.cbbTipoDoc.SelectedValue = 0
            Me.cbbTipoDoc.Size = New System.Drawing.Size(100, 22)
            Me.cbbTipoDoc.TabIndex = 95
            Me.cbbTipoDoc.verToolTipItemSeleccionado = False
            '
            'ComboBox1
            '
            Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.DropDownWidth = 105
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
            Me.ComboBox1.TabIndex = 2
            '
            'chk_visitante_menor
            '
            Me.chk_visitante_menor.AutoSize = True
            Me.chk_visitante_menor.Location = New System.Drawing.Point(191, 62)
            Me.chk_visitante_menor.Name = "chk_visitante_menor"
            Me.chk_visitante_menor.Size = New System.Drawing.Size(114, 17)
            Me.chk_visitante_menor.TabIndex = 40
            Me.chk_visitante_menor.Text = "Ingresa con menor"
            Me.chk_visitante_menor.UseVisualStyleBackColor = True
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(6, 65)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(37, 13)
            Me.Label2.TabIndex = 39
            Me.Label2.Text = "Pase :"
            '
            'txtpasenumero
            '
            Me.txtpasenumero._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtpasenumero._BloquearPaste = False
            Me.txtpasenumero._SeleccionarTodo = True
            Me.txtpasenumero.Location = New System.Drawing.Point(120, 62)
            Me.txtpasenumero.Name = "txtpasenumero"
            Me.txtpasenumero.Size = New System.Drawing.Size(57, 20)
            Me.txtpasenumero.TabIndex = 38
            Me.txtpasenumero.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtpasenumero.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(6, 15)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(114, 13)
            Me.Label4.TabIndex = 35
            Me.Label4.Text = "Tipo Doc. / Nro Doc. :"
            '
            'txtVisNumDoc
            '
            Me.txtVisNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtVisNumDoc._BloquearPaste = False
            Me.txtVisNumDoc._SeleccionarTodo = True
            Me.txtVisNumDoc.Location = New System.Drawing.Point(226, 11)
            Me.txtVisNumDoc.Name = "txtVisNumDoc"
            Me.txtVisNumDoc.Size = New System.Drawing.Size(82, 20)
            Me.txtVisNumDoc.TabIndex = 34
            Me.txtVisNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtVisNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtVisApeNom
            '
            Me.txtVisApeNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtVisApeNom._BloquearPaste = False
            Me.txtVisApeNom._SeleccionarTodo = True
            Me.txtVisApeNom.Location = New System.Drawing.Point(120, 37)
            Me.txtVisApeNom.Name = "txtVisApeNom"
            Me.txtVisApeNom.Size = New System.Drawing.Size(188, 20)
            Me.txtVisApeNom.TabIndex = 0
            Me.txtVisApeNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtVisApeNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(6, 41)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(108, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Apellidos y Nombres :"
            '
            'pnlDetalle
            '
            Me.pnlDetalle.Controls.Add(Me.dgwMovi)
            Me.pnlDetalle.Controls.Add(Me.UscFoto1)
            Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDetalle.Location = New System.Drawing.Point(0, 198)
            Me.pnlDetalle.Name = "pnlDetalle"
            Me.pnlDetalle.Size = New System.Drawing.Size(1024, 295)
            Me.pnlDetalle.TabIndex = 72
            '
            'dgwMovi
            '
            Me.dgwMovi.AllowUserToAddRows = False
            Me.dgwMovi.AllowUserToDeleteRows = False
            Me.dgwMovi.AllowUserToResizeRows = False
            Me.dgwMovi.BackgroundColor = System.Drawing.Color.White
            Me.dgwMovi.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwMovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwMovi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_mov_id, Me.col_mov_id_pdr, Me.col_men_tip, Me.Column14, Me.col_int_id, Me.Column13, Me.col_vis_id, Me.Column4, Me.Column5, Me.col_pas_num, Me.col_vis_ape_nom, Me.col_edad, Me.Column8, Me.DataGridViewTextBoxColumn14, Me.col_int_ape_nom, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn13, Me.col_fec_ing, Me.col_hor_ing, Me.col_tip_ing_por, Me.Column9, Me.Column7, Me.UsuarioAutorizaSalida, Me.col_hor_sal, Me.col_fec_sal, Me.col_min_per, Me.Column10, Me.Column11, Me.Column12, Me.Column6, Me.Column1, Me.Column2, Me.Column3, Me.col_ico_nin_men, Me.col_men_can, Me.col_fot_vis})
            Me.dgwMovi.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwMovi.GridColor = System.Drawing.Color.LightGray
            Me.dgwMovi.Location = New System.Drawing.Point(0, 0)
            Me.dgwMovi.MultiSelect = False
            Me.dgwMovi.Name = "dgwMovi"
            Me.dgwMovi.ReadOnly = True
            Me.dgwMovi.RowHeadersVisible = False
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwMovi.RowsDefaultCellStyle = DataGridViewCellStyle7
            Me.dgwMovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwMovi.Size = New System.Drawing.Size(827, 295)
            Me.dgwMovi.TabIndex = 9
            Me.dgwMovi.VisibleCampos = False
            '
            'col_mov_id
            '
            Me.col_mov_id.DataPropertyName = "Codigo"
            Me.col_mov_id.DividerWidth = 1
            Me.col_mov_id.HeaderText = "Movimiento"
            Me.col_mov_id.Name = "col_mov_id"
            Me.col_mov_id.ReadOnly = True
            Me.col_mov_id.Visible = False
            '
            'col_mov_id_pdr
            '
            Me.col_mov_id_pdr.DataPropertyName = "MovimientoPadre"
            Me.col_mov_id_pdr.DividerWidth = 1
            Me.col_mov_id_pdr.HeaderText = "MovimientoIDPadre"
            Me.col_mov_id_pdr.Name = "col_mov_id_pdr"
            Me.col_mov_id_pdr.ReadOnly = True
            Me.col_mov_id_pdr.Visible = False
            '
            'col_men_tip
            '
            Me.col_men_tip.DataPropertyName = "MenoresTipo"
            Me.col_men_tip.DividerWidth = 1
            Me.col_men_tip.HeaderText = "MenoresTipo"
            Me.col_men_tip.Name = "col_men_tip"
            Me.col_men_tip.ReadOnly = True
            Me.col_men_tip.Visible = False
            '
            'Column14
            '
            Me.Column14.DataPropertyName = "TipoInterno"
            Me.Column14.DividerWidth = 1
            Me.Column14.HeaderText = "TipoInterno"
            Me.Column14.Name = "Column14"
            Me.Column14.ReadOnly = True
            Me.Column14.Visible = False
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "InternoID"
            Me.col_int_id.DividerWidth = 1
            Me.col_int_id.HeaderText = "InternoID"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'Column13
            '
            Me.Column13.DataPropertyName = "IDInternoPJ"
            Me.Column13.DividerWidth = 1
            Me.Column13.HeaderText = "IDInternoPJ"
            Me.Column13.Name = "Column13"
            Me.Column13.ReadOnly = True
            Me.Column13.Visible = False
            '
            'col_vis_id
            '
            Me.col_vis_id.DataPropertyName = "VisitaID"
            Me.col_vis_id.DividerWidth = 1
            Me.col_vis_id.HeaderText = "VisitanteID"
            Me.col_vis_id.Name = "col_vis_id"
            Me.col_vis_id.ReadOnly = True
            Me.col_vis_id.Visible = False
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "VisitanteTipoDocyNumeroDoc"
            Me.Column4.HeaderText = "Tipo Doc. - N� Doc."
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "VisitanteSexoNombre"
            Me.Column5.HeaderText = "Sexo"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Visible = False
            Me.Column5.Width = 80
            '
            'col_pas_num
            '
            Me.col_pas_num.DataPropertyName = "PaseNumero"
            Me.col_pas_num.HeaderText = "Pase"
            Me.col_pas_num.Name = "col_pas_num"
            Me.col_pas_num.ReadOnly = True
            Me.col_pas_num.Width = 50
            '
            'col_vis_ape_nom
            '
            Me.col_vis_ape_nom.DataPropertyName = "VisitanteApellidosyNombres"
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.col_vis_ape_nom.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_vis_ape_nom.DividerWidth = 1
            Me.col_vis_ape_nom.HeaderText = "Visitante"
            Me.col_vis_ape_nom.Name = "col_vis_ape_nom"
            Me.col_vis_ape_nom.ReadOnly = True
            Me.col_vis_ape_nom.Width = 185
            '
            'col_edad
            '
            Me.col_edad.DataPropertyName = "VisitanteEdadString"
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.col_edad.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_edad.HeaderText = "Edad"
            Me.col_edad.Name = "col_edad"
            Me.col_edad.ReadOnly = True
            Me.col_edad.Width = 40
            '
            'Column8
            '
            Me.Column8.DataPropertyName = "VisitanteValidadoReniecNombreReadonly"
            Me.Column8.HeaderText = "Vis. Validado"
            Me.Column8.Name = "Column8"
            Me.Column8.ReadOnly = True
            Me.Column8.ToolTipText = "Visitante Validado por Reniec o Migraciones"
            Me.Column8.Width = 70
            '
            'DataGridViewTextBoxColumn14
            '
            Me.DataGridViewTextBoxColumn14.DataPropertyName = "ParentescoNombre"
            Me.DataGridViewTextBoxColumn14.HeaderText = "Paren. / Visita"
            Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
            Me.DataGridViewTextBoxColumn14.ReadOnly = True
            Me.DataGridViewTextBoxColumn14.ToolTipText = "Parentesco / Tipo Visita"
            Me.DataGridViewTextBoxColumn14.Width = 80
            '
            'col_int_ape_nom
            '
            Me.col_int_ape_nom.DataPropertyName = "InternoApellidosyNombres"
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.col_int_ape_nom.DefaultCellStyle = DataGridViewCellStyle3
            Me.col_int_ape_nom.HeaderText = "Interno / Otros"
            Me.col_int_ape_nom.Name = "col_int_ape_nom"
            Me.col_int_ape_nom.ReadOnly = True
            Me.col_int_ape_nom.Width = 170
            '
            'DataGridViewTextBoxColumn15
            '
            Me.DataGridViewTextBoxColumn15.DataPropertyName = "MotivoNombre"
            Me.DataGridViewTextBoxColumn15.DividerWidth = 1
            Me.DataGridViewTextBoxColumn15.HeaderText = "Motivo"
            Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
            Me.DataGridViewTextBoxColumn15.ReadOnly = True
            Me.DataGridViewTextBoxColumn15.Visible = False
            '
            'DataGridViewTextBoxColumn13
            '
            Me.DataGridViewTextBoxColumn13.DataPropertyName = "PabellonNombre"
            Me.DataGridViewTextBoxColumn13.HeaderText = "Pabellon"
            Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
            Me.DataGridViewTextBoxColumn13.ReadOnly = True
            Me.DataGridViewTextBoxColumn13.Visible = False
            Me.DataGridViewTextBoxColumn13.Width = 80
            '
            'col_fec_ing
            '
            Me.col_fec_ing.DataPropertyName = "FechaIngreso"
            DataGridViewCellStyle4.Format = "d"
            Me.col_fec_ing.DefaultCellStyle = DataGridViewCellStyle4
            Me.col_fec_ing.HeaderText = "Fecha Ingreso"
            Me.col_fec_ing.Name = "col_fec_ing"
            Me.col_fec_ing.ReadOnly = True
            Me.col_fec_ing.Width = 75
            '
            'col_hor_ing
            '
            Me.col_hor_ing.DataPropertyName = "HoraIngreso"
            Me.col_hor_ing.HeaderText = "Hora Ingreso"
            Me.col_hor_ing.Name = "col_hor_ing"
            Me.col_hor_ing.ReadOnly = True
            Me.col_hor_ing.Width = 60
            '
            'col_tip_ing_por
            '
            Me.col_tip_ing_por.DataPropertyName = "TipoIngresoPor"
            Me.col_tip_ing_por.DividerWidth = 1
            Me.col_tip_ing_por.HeaderText = "TipoIngresoPor"
            Me.col_tip_ing_por.Name = "col_tip_ing_por"
            Me.col_tip_ing_por.ReadOnly = True
            Me.col_tip_ing_por.Visible = False
            Me.col_tip_ing_por.Width = 140
            '
            'Column9
            '
            Me.Column9.DataPropertyName = "TipoIngresoPorNombreReadonly"
            Me.Column9.HeaderText = "Vis. Ing. con"
            Me.Column9.Name = "Column9"
            Me.Column9.ReadOnly = True
            Me.Column9.ToolTipText = "Visitante ingresa con"
            Me.Column9.Width = 140
            '
            'Column7
            '
            Me.Column7.DataPropertyName = "Observacion"
            Me.Column7.HeaderText = "Obs. Entrada"
            Me.Column7.Name = "Column7"
            Me.Column7.ReadOnly = True
            Me.Column7.Visible = False
            '
            'UsuarioAutorizaSalida
            '
            Me.UsuarioAutorizaSalida.DataPropertyName = "Audit_UsuarioCreacion"
            Me.UsuarioAutorizaSalida.HeaderText = "Usu. Aut. Ing."
            Me.UsuarioAutorizaSalida.Name = "UsuarioAutorizaSalida"
            Me.UsuarioAutorizaSalida.ReadOnly = True
            Me.UsuarioAutorizaSalida.ToolTipText = "Usuario que autoriza el ingreso"
            Me.UsuarioAutorizaSalida.Visible = False
            Me.UsuarioAutorizaSalida.Width = 180
            '
            'col_hor_sal
            '
            Me.col_hor_sal.DataPropertyName = "HoraSalida"
            Me.col_hor_sal.HeaderText = "Hora Salida"
            Me.col_hor_sal.Name = "col_hor_sal"
            Me.col_hor_sal.ReadOnly = True
            Me.col_hor_sal.Width = 60
            '
            'col_fec_sal
            '
            Me.col_fec_sal.DataPropertyName = "FechaSalida"
            DataGridViewCellStyle5.Format = "d"
            Me.col_fec_sal.DefaultCellStyle = DataGridViewCellStyle5
            Me.col_fec_sal.HeaderText = "Fecha Salida"
            Me.col_fec_sal.Name = "col_fec_sal"
            Me.col_fec_sal.ReadOnly = True
            Me.col_fec_sal.Width = 75
            '
            'col_min_per
            '
            Me.col_min_per.DataPropertyName = "Permanencia"
            Me.col_min_per.HeaderText = "Perman."
            Me.col_min_per.Name = "col_min_per"
            Me.col_min_per.ReadOnly = True
            Me.col_min_per.ToolTipText = "Tiempo de permanencia"
            Me.col_min_per.Width = 60
            '
            'Column10
            '
            Me.Column10.DataPropertyName = "UsuarioAutorizaSalida"
            Me.Column10.HeaderText = "Usu. Aut. Sal."
            Me.Column10.Name = "Column10"
            Me.Column10.ReadOnly = True
            Me.Column10.ToolTipText = "Usuario que autoriza la salida"
            Me.Column10.Visible = False
            Me.Column10.Width = 180
            '
            'Column11
            '
            Me.Column11.DataPropertyName = "TipoSalidaPorNombreReadonly"
            Me.Column11.HeaderText = "Vis. Sal. con"
            Me.Column11.Name = "Column11"
            Me.Column11.ReadOnly = True
            Me.Column11.ToolTipText = "Visitante sale con"
            Me.Column11.Width = 110
            '
            'Column12
            '
            Me.Column12.DataPropertyName = "UsuarioAutorizaSalidaSinHuella"
            Me.Column12.HeaderText = "Usu. Aut. Sal. Sin. Hue."
            Me.Column12.Name = "Column12"
            Me.Column12.ReadOnly = True
            Me.Column12.ToolTipText = "Usuario que autoriza la salida sin huella"
            Me.Column12.Width = 180
            '
            'Column6
            '
            Me.Column6.DataPropertyName = "ObservacionSalida"
            Me.Column6.HeaderText = "Obs. Salida"
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            Me.Column6.Visible = False
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "RegimenVisitaNombreCortoReadonly"
            Me.Column1.HeaderText = "Reg. Visita"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Visible = False
            Me.Column1.Width = 90
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "TipoNombre"
            Me.Column2.HeaderText = "Tip. Nom."
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Visible = False
            Me.Column2.Width = 80
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "EtapaNombre"
            Me.Column3.HeaderText = "Etapa"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Visible = False
            Me.Column3.Width = 90
            '
            'col_ico_nin_men
            '
            Me.col_ico_nin_men.DataPropertyName = "IconoMenor"
            Me.col_ico_nin_men.HeaderText = "Men."
            Me.col_ico_nin_men.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_ico_nin_men.Name = "col_ico_nin_men"
            Me.col_ico_nin_men.ReadOnly = True
            Me.col_ico_nin_men.ToolTipText = "El visitante viene acompa�ado de menor(es) de edad"
            Me.col_ico_nin_men.Width = 35
            '
            'col_men_can
            '
            Me.col_men_can.DataPropertyName = "MenoresCantidadString"
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.col_men_can.DefaultCellStyle = DataGridViewCellStyle6
            Me.col_men_can.HeaderText = "Cant. Men."
            Me.col_men_can.Name = "col_men_can"
            Me.col_men_can.ReadOnly = True
            Me.col_men_can.ToolTipText = "Cantidad de Menores"
            Me.col_men_can.Width = 50
            '
            'col_fot_vis
            '
            Me.col_fot_vis.DataPropertyName = "VisitanteFotoName"
            Me.col_fot_vis.DividerWidth = 1
            Me.col_fot_vis.HeaderText = "FotoVisitante"
            Me.col_fot_vis.Name = "col_fot_vis"
            Me.col_fot_vis.ReadOnly = True
            Me.col_fot_vis.Visible = False
            '
            'UscFoto1
            '
            Me.UscFoto1._CheckImagen = True
            Me.UscFoto1._EnabledDobleClick = True
            Me.UscFoto1._HasImagen = False
            Me.UscFoto1._PanelAutorizacion = False
            Me.UscFoto1._PanelCheck = False
            Me.UscFoto1.Dock = System.Windows.Forms.DockStyle.Right
            Me.UscFoto1.Location = New System.Drawing.Point(827, 0)
            Me.UscFoto1.Name = "UscFoto1"
            Me.UscFoto1.Size = New System.Drawing.Size(197, 295)
            Me.UscFoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFoto1.TabIndex = 71
            '
            'uscBusqueda
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlDetalle)
            Me.Controls.Add(Me.pnlBusqueda)
            Me.Name = "uscBusqueda"
            Me.Size = New System.Drawing.Size(1024, 493)
            Me.pnlBusqueda.ResumeLayout(False)
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.pnlFecha.ResumeLayout(False)
            Me.GroupBox6.ResumeLayout(False)
            Me.GroupBox6.PerformLayout()
            Me.gb_menores.ResumeLayout(False)
            Me.gb_menores.PerformLayout()
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox5.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox8.ResumeLayout(False)
            Me.GroupBox8.PerformLayout()
            Me.cbbTipoDoc.ResumeLayout(False)
            Me.pnlDetalle.ResumeLayout(False)
            CType(Me.dgwMovi, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtIntNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtIntApeNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtVisNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtVisApeNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbFechaRango As System.Windows.Forms.RadioButton
        Friend WithEvents rdbFechaUni As System.Windows.Forms.RadioButton
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents dtpFechaIni As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents dtpFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents dgwMovi As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents pnlFecha As System.Windows.Forms.Panel
        Friend WithEvents rdbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbSinSal As System.Windows.Forms.RadioButton
        Friend WithEvents rdbConSal As System.Windows.Forms.RadioButton
        Friend WithEvents cbbParentesco As APPControls.uscComboParametrica
        'Friend WithEvents UscGrillaCampo1 As APPControls.Grilla.uscGrillaCampo
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtpasenumero As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents gb_menores As System.Windows.Forms.GroupBox
        Friend WithEvents rb_menor_menor As System.Windows.Forms.RadioButton
        Friend WithEvents rb_menor_todos As System.Windows.Forms.RadioButton
        Friend WithEvents rb_menor_adulto As System.Windows.Forms.RadioButton
        Friend WithEvents chk_visitante_menor As Legolas.APPUIComponents.myCheckBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbTipoVisita As System.Windows.Forms.RadioButton
        Friend WithEvents rdbParentescoTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbParentesco As System.Windows.Forms.RadioButton
        Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents lblRegPersonas As System.Windows.Forms.Label
        Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents cbbTipoRegimen As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents UscFoto1 As APPControls.Foto.uscFotografia
        Friend WithEvents col_mov_id As DataGridViewTextBoxColumn
        Friend WithEvents col_mov_id_pdr As DataGridViewTextBoxColumn
        Friend WithEvents col_men_tip As DataGridViewTextBoxColumn
        Friend WithEvents Column14 As DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As DataGridViewTextBoxColumn
        Friend WithEvents Column13 As DataGridViewTextBoxColumn
        Friend WithEvents col_vis_id As DataGridViewTextBoxColumn
        Friend WithEvents Column4 As DataGridViewTextBoxColumn
        Friend WithEvents Column5 As DataGridViewTextBoxColumn
        Friend WithEvents col_pas_num As DataGridViewTextBoxColumn
        Friend WithEvents col_vis_ape_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_edad As DataGridViewTextBoxColumn
        Friend WithEvents Column8 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
        Friend WithEvents col_int_ape_nom As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_ing As DataGridViewTextBoxColumn
        Friend WithEvents col_hor_ing As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_ing_por As DataGridViewTextBoxColumn
        Friend WithEvents Column9 As DataGridViewTextBoxColumn
        Friend WithEvents Column7 As DataGridViewTextBoxColumn
        Friend WithEvents UsuarioAutorizaSalida As DataGridViewTextBoxColumn
        Friend WithEvents col_hor_sal As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_sal As DataGridViewTextBoxColumn
        Friend WithEvents col_min_per As DataGridViewTextBoxColumn
        Friend WithEvents Column10 As DataGridViewTextBoxColumn
        Friend WithEvents Column11 As DataGridViewTextBoxColumn
        Friend WithEvents Column12 As DataGridViewTextBoxColumn
        Friend WithEvents Column6 As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents Column2 As DataGridViewTextBoxColumn
        Friend WithEvents Column3 As DataGridViewTextBoxColumn
        Friend WithEvents col_ico_nin_men As DataGridViewImageColumn
        Friend WithEvents col_men_can As DataGridViewTextBoxColumn
        Friend WithEvents col_fot_vis As DataGridViewTextBoxColumn
    End Class
End Namespace

