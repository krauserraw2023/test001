Namespace Registro.Movimientos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMovimientoInternamientoCarceleta
        Inherits Legolas.APPUIComponents.FormPopup

        'Form overrides dispose to clean up the component list.
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
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.grpMovimiento = New System.Windows.Forms.GroupBox()
            Me.PnlInferior = New System.Windows.Forms.Panel()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.grpDocumentoJudicial = New System.Windows.Forms.GroupBox()
            Me.dtpDocJudFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.txtNumDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpDocJudFecRecep = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.UscDelito1 = New APPControls.Registro.Documento.uscDelito()
            Me.UscMovExpediente1 = New APPControls.Registro.uscMovExpediente()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.uscMovDet = New APPControls.Registro.uscMovimientoDetalle()
            Me.btnCargarDocumento = New Legolas.APPUIComponents.myButton()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.grpMovimiento.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.grpDocumentoJudicial.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.grpDocumentoJudicial)
            Me.gbxFormChildContainer.Controls.Add(Me.UscAuditUser1)
            Me.gbxFormChildContainer.Controls.Add(Me.grpMovimiento)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlInferior)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(670, 525)
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(98, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(3, 3)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(93, 40)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'grpMovimiento
            '
            Me.grpMovimiento.Controls.Add(Me.uscMovDet)
            Me.grpMovimiento.Dock = System.Windows.Forms.DockStyle.Top
            Me.grpMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpMovimiento.Location = New System.Drawing.Point(0, 0)
            Me.grpMovimiento.Name = "grpMovimiento"
            Me.grpMovimiento.Size = New System.Drawing.Size(670, 176)
            Me.grpMovimiento.TabIndex = 0
            Me.grpMovimiento.TabStop = False
            Me.grpMovimiento.Text = "Movimiento"
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PnlInferior.Location = New System.Drawing.Point(3, 432)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(670, 45)
            Me.PnlInferior.TabIndex = 101
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnAceptar)
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotones.Location = New System.Drawing.Point(470, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(200, 45)
            Me.PnlBotones.TabIndex = 1
            '
            'grpDocumentoJudicial
            '
            Me.grpDocumentoJudicial.Controls.Add(Me.btnCargarDocumento)
            Me.grpDocumentoJudicial.Controls.Add(Me.UscDelito1)
            Me.grpDocumentoJudicial.Controls.Add(Me.dtpDocJudFecha)
            Me.grpDocumentoJudicial.Controls.Add(Me.UscMovExpediente1)
            Me.grpDocumentoJudicial.Controls.Add(Me.Label30)
            Me.grpDocumentoJudicial.Controls.Add(Me.txtNumDocumento)
            Me.grpDocumentoJudicial.Controls.Add(Me.dtpDocJudFecRecep)
            Me.grpDocumentoJudicial.Controls.Add(Me.Label6)
            Me.grpDocumentoJudicial.Controls.Add(Me.Label12)
            Me.grpDocumentoJudicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpDocumentoJudicial.Location = New System.Drawing.Point(6, 176)
            Me.grpDocumentoJudicial.Name = "grpDocumentoJudicial"
            Me.grpDocumentoJudicial.Size = New System.Drawing.Size(655, 255)
            Me.grpDocumentoJudicial.TabIndex = 1
            Me.grpDocumentoJudicial.TabStop = False
            Me.grpDocumentoJudicial.Text = "Documento Judicial"
            '
            'dtpDocJudFecha
            '
            Me.dtpDocJudFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dtpDocJudFecha.Enabled = False
            Me.dtpDocJudFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDocJudFecha.Location = New System.Drawing.Point(330, 34)
            Me.dtpDocJudFecha.Name = "dtpDocJudFecha"
            Me.dtpDocJudFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecha.TabIndex = 3
            Me.dtpDocJudFecha.Value = "/  /"
            Me.dtpDocJudFecha.ValueLong = CType(0, Long)
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(237, 12)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(83, 13)
            Me.Label30.TabIndex = 0
            Me.Label30.Text = "N� Documento :"
            '
            'txtNumDocumento
            '
            Me.txtNumDocumento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDocumento._BloquearPaste = False
            Me.txtNumDocumento._SeleccionarTodo = False
            Me.txtNumDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumDocumento.Location = New System.Drawing.Point(330, 7)
            Me.txtNumDocumento.MaxLength = 120
            Me.txtNumDocumento.Name = "txtNumDocumento"
            Me.txtNumDocumento.ReadOnly = True
            Me.txtNumDocumento.Size = New System.Drawing.Size(320, 20)
            Me.txtNumDocumento.TabIndex = 1
            Me.txtNumDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'dtpDocJudFecRecep
            '
            Me.dtpDocJudFecRecep.Enabled = False
            Me.dtpDocJudFecRecep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDocJudFecRecep.Location = New System.Drawing.Point(566, 34)
            Me.dtpDocJudFecRecep.Name = "dtpDocJudFecRecep"
            Me.dtpDocJudFecRecep.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecRecep.TabIndex = 5
            Me.dtpDocJudFecRecep.Value = "/  /"
            Me.dtpDocJudFecRecep.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(237, 39)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(60, 13)
            Me.Label6.TabIndex = 2
            Me.Label6.Text = "Fec. Doc. :"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(463, 39)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(89, 13)
            Me.Label12.TabIndex = 4
            Me.Label12.Text = "Fec. Recepci�n :"
            '
            'UscDelito1
            '
            Me.UscDelito1._ExpedienteID = -1
            Me.UscDelito1._IngresoID = -1
            Me.UscDelito1._IngresoInpeId = -1
            Me.UscDelito1._InternoID = -1
            Me.UscDelito1._TipoDocumentoID = -1
            Me.UscDelito1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscDelito1._TipoMovimineto = -1
            Me.UscDelito1.AutoScroll = True
            Me.UscDelito1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UscDelito1.Location = New System.Drawing.Point(0, 150)
            Me.UscDelito1.Name = "UscDelito1"
            Me.UscDelito1.Size = New System.Drawing.Size(650, 100)
            Me.UscDelito1.TabIndex = 1
            '
            'UscMovExpediente1
            '
            Me.UscMovExpediente1._CargarExpedientes = False
            Me.UscMovExpediente1._DocumentoJudicialID = -1
            Me.UscMovExpediente1._ExpedienteID = -1
            Me.UscMovExpediente1._GrillaExpId = -1
            Me.UscMovExpediente1._IngresoID = -1
            Me.UscMovExpediente1._InternoID = -1
            Me.UscMovExpediente1._InternoIngresoInpeId = -1
            Me.UscMovExpediente1._ListaCopy = Nothing
            Me.UscMovExpediente1._ListaExpedienteId = Nothing
            Me.UscMovExpediente1._ListaExpedienteOKID = Nothing
            Me.UscMovExpediente1._ListaExpedienteTotalID = Nothing
            Me.UscMovExpediente1._ListaExpNoEliminados = Nothing
            Me.UscMovExpediente1._ListaExpOK_IN = Nothing
            Me.UscMovExpediente1._ListaExpOK_OUT = Nothing
            Me.UscMovExpediente1._MovimientoID = -1
            Me.UscMovExpediente1._MovimientoTipoID = -1
            Me.UscMovExpediente1._RetornaOKEliminado = False
            Me.UscMovExpediente1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscMovExpediente1._TipoListado = ""
            Me.UscMovExpediente1._VisibleColumna = False
            Me.UscMovExpediente1._VisibleGrabar = False
            Me.UscMovExpediente1.AutoScroll = True
            Me.UscMovExpediente1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UscMovExpediente1.GrillaCountExp = 0
            Me.UscMovExpediente1.Location = New System.Drawing.Point(0, 54)
            Me.UscMovExpediente1.Name = "UscMovExpediente1"
            Me.UscMovExpediente1.Size = New System.Drawing.Size(650, 95)
            Me.UscMovExpediente1.TabIndex = 0
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 478)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(670, 47)
            Me.UscAuditUser1.TabIndex = 0
            '
            'uscMovDet
            '
            Me.uscMovDet._blnNuevo = False
            Me.uscMovDet._blnVisiblecbbMotivo = True
            Me.uscMovDet._blnVisiblelblMotivo = True
            Me.uscMovDet._blnVisibleOrigenDestino = True
            Me.uscMovDet._CargarExpedientes = -1
            Me.uscMovDet._Codigo = 0
            Me.uscMovDet._Documentos_sin_mov = False
            Me.uscMovDet._DocumJudicialD = -1
            Me.uscMovDet._FechaMovimiento = CType(0, Long)
            Me.uscMovDet._IngresoID = -1
            Me.uscMovDet._intCondicionGrupo = -1
            Me.uscMovDet._InternoID = -1
            Me.uscMovDet._InternoIngresoInpeId = -1
            Me.uscMovDet._MovimientoTipoID = -1
            Me.uscMovDet._PenalDestinoID = -1
            Me.uscMovDet._PenalID = 0
            Me.uscMovDet._PenalID1 = -1
            Me.uscMovDet._PenalID2 = -1
            Me.uscMovDet._PenalMovID = 0
            Me.uscMovDet._PenalOrigenID = -1
            Me.uscMovDet._RegionDestinoID = -1
            Me.uscMovDet._RegionID = 0
            Me.uscMovDet._RegionMovID = 0
            Me.uscMovDet._RegionOrigenID = -1
            Me.uscMovDet._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.uscMovDet.BackColor = System.Drawing.Color.Transparent
            Me.uscMovDet.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscMovDet.Enabletcontrol = False
            Me.uscMovDet.EstadoAuxID = 0
            Me.uscMovDet.EstadoID = -1
            Me.uscMovDet.EstadoTramite = ""
            Me.uscMovDet.EstadoTramiteID = -1
            Me.uscMovDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.uscMovDet.Location = New System.Drawing.Point(3, 16)
            Me.uscMovDet.MovimientoGrupo = 0
            Me.uscMovDet.MovimientoGrupoNom = ""
            Me.uscMovDet.MovimientoMotivoIngreso = 0
            Me.uscMovDet.MovimientoTipo = 0
            Me.uscMovDet.Name = "uscMovDet"
            Me.uscMovDet.Observacion = ""
            Me.uscMovDet.Size = New System.Drawing.Size(664, 157)
            Me.uscMovDet.TabIndex = 0
            '
            'btnCargarDocumento
            '
            Me.btnCargarDocumento.Image = Global.SIPPOPE.My.Resources.Resources._1345240399_search_button
            Me.btnCargarDocumento.Location = New System.Drawing.Point(212, 7)
            Me.btnCargarDocumento.Name = "btnCargarDocumento"
            Me.btnCargarDocumento.Size = New System.Drawing.Size(22, 22)
            Me.btnCargarDocumento.TabIndex = 7
            Me.btnCargarDocumento.UseVisualStyleBackColor = True
            '
            'frmMovimientoInternamientoCarceleta
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(670, 525)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmMovimientoInternamientoCarceleta"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Internamiento"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.grpMovimiento.ResumeLayout(False)
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.grpDocumentoJudicial.ResumeLayout(False)
            Me.grpDocumentoJudicial.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents PnlInferior As System.Windows.Forms.Panel
        Friend WithEvents grpMovimiento As System.Windows.Forms.GroupBox
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents uscMovDet As APPControls.Registro.uscMovimientoDetalle
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents grpDocumentoJudicial As System.Windows.Forms.GroupBox
        Friend WithEvents UscDelito1 As APPControls.Registro.Documento.uscDelito
        Friend WithEvents dtpDocJudFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents UscMovExpediente1 As APPControls.Registro.uscMovExpediente
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents txtNumDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents dtpDocJudFecRecep As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents btnCargarDocumento As Legolas.APPUIComponents.myButton
    End Class
End Namespace

