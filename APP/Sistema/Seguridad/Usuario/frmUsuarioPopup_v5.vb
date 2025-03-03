Imports System.Data.SqlClient
Imports System.Threading
Namespace Sistema.Seguridad.Usuario

    Public Class frmUsuarioPopup_v5
        Private objBss As Bussines.Seguridad.Usuario = Nothing
        Private objBssPermiso As Legolas.LBusiness.Seguridad.UsuarioModulo = Nothing
        Private objBssAccesoPenal As Bussines.Seguridad.Penal.Region = Nothing
        Private objEnt As Legolas.LEntity.Seguridad.Usuario = Nothing
        'agregado
        Private blTabOdontogramaCargado As Boolean = False

        Private xnivel As Integer = 0
        Private SigPos As String = "[+]"
        Private SigNeg As String = "[�]"
        Private CantRegEst As Integer = 1
        Private xVerifPadre As Boolean = True
        Private xAgruparModulos As Boolean = True 'para que se agrupe los registros de la grilla

        Public _limitarAccesoSoloHuella As Boolean = False

#Region "Propiedades"
        Private Property HabilitarLogin() As Boolean
            Get
                Return Me.chkLogin.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkLogin.Checked = value
            End Set
        End Property
        Public Property IDUsuario() As Integer = -1
        Private Property Login() As String
            Get
                Return Me.txtUsuario.Text.Trim.ToUpper
            End Get
            Set(ByVal value As String)
                Me.txtUsuario.Text = value.ToUpper
            End Set
        End Property

        Private ReadOnly Property ClaveEncript() As String
            Get
                Dim value As String = ""

                value = Legolas.Components.Cifrado.Encriptar(Me.Login)

                Return value

            End Get
        End Property
        Private Property TipoLicencia() As Integer
            Get
                Return Me.cbbNivelUsuario.SelectedIndex
            End Get
            Set(ByVal value As Integer)
                Try
                    Me.cbbNivelUsuario.SelectedIndex = value
                Catch ex As Exception

                End Try

            End Set
        End Property
        Private Property EstadoEliminado As Boolean = False
#End Region
#Region "Propiedades_Permiso"
        Private Property AdminValidarPC() As Boolean
            Get
                Return Me.chkValPC.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkValPC.Checked = value
            End Set
        End Property
        Private Property AdminModuloUsuario() As Boolean
            Get
                Return Me.chkModuloUsuarios.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkModuloUsuarios.Checked = value
            End Set
        End Property
#End Region
#Region "Propiedades_Trabajador"
        Private Property ApellidoPaterno() As String
            Get
                Return Me.txtApePaterno.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApePaterno.Text = value
            End Set
        End Property
        Private Property ApellidoMaterno() As String
            Get
                Return Me.txtApeMat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApeMat.Text = value
            End Set
        End Property
        Private Property Nombres() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
        Private Property Apellidosnombres() As String
            Get
                Return Me.txtApellidosnombres.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApellidosnombres.Text = value
            End Set
        End Property
        Private Property NumeroDocumento() As String
            Get
                Return Me.txtNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNumDoc.Text = value
            End Set
        End Property
        Private Property Perfil() As Integer
            Get
                Return Me.cbbDependencia.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbDependencia.SelectedValue = value
            End Set
        End Property
        Private Property Cargo() As String
            Get
                Return Me.txtCargo.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtCargo.Text = value
            End Set
        End Property
        Private Property Correo As String
            Get
                Return Me.txtCorreo.Text.Trim
            End Get
            Set(value As String)
                Me.txtCorreo.Text = value.Trim
            End Set
        End Property
        Private Property RegionId() As Integer
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
#End Region
#Region "Propiedades_Usuario"
        Private Property CUE_Usuario() As Integer
            Get
                Dim intValue As Integer = -1

                If IsNumeric(Me.txtCueUsuario.Text.Trim) = True Then
                    intValue = Integer.Parse(Me.txtCueUsuario.Text.Trim)
                End If

                Return intValue
            End Get
            Set(ByVal value As Integer)
                Me.txtCueUsuario.Text = value
            End Set
        End Property
        Private Property IDTrabajador() As Integer
            Get
                Dim intValue As Integer = -1

                If IsNumeric(Me.txtTrabajador.Text.Trim) = True Then
                    intValue = Integer.Parse(Me.txtTrabajador.Text.Trim)
                End If

                Return intValue
            End Get
            Set(ByVal value As Integer)
                Me.txtTrabajador.Text = value
            End Set
        End Property

#End Region
#Region "Propiedades_UsuarioNotificacion"

        Private FecharRegistro As Long
        Private NotificacionMotivo As String
        Private NotificacionEstadoId As Integer

#End Region
#Region "Propiedades_Grilla"
        Private intGrillaUsuarioPCID As Integer = -1
        Private intGrillaPCItem As Integer = -1
        Private ReadOnly Property GrillaUsuarioPCID() As Integer
            Get
                Return intGrillaUsuarioPCID
            End Get
        End Property
        Private ReadOnly Property GrillaPCItem() As Integer
            Get
                Return intGrillaPCItem
            End Get
        End Property
        Private ReadOnly Property GrillaCodigoUsuarioNotificacion() As Integer
            Get
                Return dgvListarPermisosAlertas.SelectedRows(0).Cells("col_usu_not_id").Value
            End Get
        End Property
#End Region
#Region "Propiedades_Otros"
        Private ReadOnly Property TabIndice As Integer
            Get
                Dim value As Integer = -1
                value = Me.TabControl1.SelectedIndex + 1
                Return value
            End Get
        End Property
#End Region
#Region "Combo"
        Private blnComboNivelUsuario As Boolean = False
        Private Sub ComboDependencia()

            Dim objBssDepe As New Bussines.Mantenimiento.General.Dependencia

            With Me.cbbDependencia
                .DataSource = objBssDepe.Listar(Me.TipoLicencia, False)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With

        End Sub

        Private Sub ComboTipoLicencia()

            With Me.cbbNivelUsuario
                .Items.Add("")
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.Sede.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana.ToString)
                .Items.Add(Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta.ToString)
            End With
            blnComboNivelUsuario = True
        End Sub

        Private Sub ComboRegion()
            With Me.cbbRegion
                .ComboTipo = Type.Combo.ComboTipo.Region
                ._Todos = False
                .LoadUsc()
            End With
        End Sub
#End Region
#Region "Listar"

        Private Sub ListarPC()

            If Me.IDUsuario < 1 Then
                Exit Sub
            End If

            Dim objBss As New Legolas.LBusiness.Seguridad.UsuarioPC
            Dim objEntCol As New Legolas.LEntity.Seguridad.UsuarioPCCol

            Me.dgwPC.Rows.Clear()

            objEntCol = objBss.Listar(-1, Me.IDUsuario, -1, False)

            For Each objEnt As Legolas.LEntity.Seguridad.UsuarioPC In objEntCol

                With objEnt
                    If ValidarPC(.PCID) = True Then
                        Dim row As New DataGridViewRow
                        row.CreateCells(Me.dgwPC)
                        row.Cells(0).Value = Me.dgwPC.RowCount + 1 'col_ite
                        row.Cells(1).Value = .Codigo 'col_usu_pc_id
                        row.Cells(2).Value = .PCID   'col_pc_id
                        row.Cells(3).Value = .HostName 'col_hos_nam
                        row.Cells(4).Value = .MAC  'col_mac        
                        Me.dgwPC.Rows.Add(row)
                    End If
                End With
            Next

        End Sub

        Private Sub ListarData()

            If Me.IDUsuario < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Seguridad.Usuario
            Dim objEnt As New Entity.Sistema.Seguridad.Usuario

            objEnt = objBss.Listar(Me.IDUsuario)

            With objEnt
                'cue
                Me.CUE_Usuario = .CueUsuario
                Me.IDTrabajador = .IDTrabajador
                '/*************/
                Me.Login = .Login
                Me.ApellidoPaterno = .ApellidoPaterno
                Me.ApellidoMaterno = .ApellidoMaterno
                Me.Nombres = .Nombres
                Me.Apellidosnombres = .ApellidoPaterno & " " & .ApellidoMaterno & " " & .Nombres
                Me.NumeroDocumento = .NumeroDocumento
                Me.Cargo = .CargoNombre
                Me.TipoLicencia = .NivelUsuario
                Me.Perfil = .Perfil
                Me.Correo = .Correo
                chkValidarPorHuella.Checked = .ValidarPorHUella
                '/*permisos*/

                '/*permisos otros*/
                Me.AdminValidarPC = .AdminValidarPC
                Me.AdminModuloUsuario = .AdminModuloUsuario
                Me.EstadoEliminado = .Audit_Eliminado

            End With

            If Me.EstadoEliminado = True Then
                Me.btnActivarUsuario.Enabled = True
            End If
            ListarPC()

            UscHuellaUsuarioVisor1._UsuarioId = Me.IDUsuario
        End Sub

        Private Sub CrearDataGridviewPermisos()

            Dim da As New SqlDataAdapter
            Dim dt As New DataTable
            Dim dr() As DataRow
            Dim sql As String = ""
            Dim i As Integer = 0
            Dim L As New DataGridViewCheckBoxColumn()
            Dim E As New DataGridViewCheckBoxColumn()
            Dim R As New DataGridViewCheckBoxColumn()
            Dim B As New DataGridViewCheckBoxColumn()
            Try

                Dim sqlCn As New SqlClient.SqlConnection(Legolas.Configuration.Data.ConexionIni)
                If sqlCn.State = ConnectionState.Open Then
                Else
                    sqlCn.Open()
                End If

                sql = "select max(mod_roo_id) as mod_roo_id from SEC_Modulo"
                da.SelectCommand = sqlCn.CreateCommand
                da.SelectCommand.CommandText = sql
                da.SelectCommand.CommandType = CommandType.Text
                da.SelectCommand.ExecuteNonQuery()
                da.Fill(dt)

                If sqlCn.State = ConnectionState.Open Then
                    sqlCn.Close()
                End If

                dr = dt.Select

                With dgwPermisos
                    .Rows.Clear()
                    .Columns.Clear()

                    For Each dr2 As DataRow In dr
                        xnivel = Val(dr2("mod_roo_id"))
                    Next

                    For i = 0 To xnivel
                        .Columns.Add("Sig" & i, "")
                        .Columns.Add("Des" & i, "")
                        .Columns("Sig" & i).Width = 20
                        .Columns("Des" & i).Width = 120 '40
                    Next

                    .Columns.Add(L)
                    .Columns.Add(E)
                    .Columns.Add(R)
                    .Columns.Add(B)
                    .Columns.Add("mod_obj", "mod_obj") 'mod_obj
                    .Columns.Add("mod_icn", "mod_icn") 'mod_icn
                    .Columns.Add("mod_ini", "mod_ini") 'mod_ini
                    .Columns.Add("mod_ord", "mod_ord") 'mod_ord
                    .Columns.Add("mod_vis", "mod_vis") 'mod_vis
                    .Columns.Add("mod_roo_id", "mod_roo_id") 'mod_roo_id 'IdNivel
                    .Columns.Add("mod_id", "mod_id") 'mod_id 'IdNodo
                    .Columns.Add("mod_prn_id", "mod_prn_id") 'mod_prn_id 'IdPadre

                    CantRegEst = 13 'cantidad de registros estaticos

                    .Columns(1).HeaderText = "M�dulos"
                    .Columns((xnivel * 2) + 2).HeaderText = "Lectura" : .Columns((xnivel * 2) + 2).Name = "L" : .Columns((xnivel * 2) + 2).Width = 50
                    .Columns((xnivel * 2) + 3).HeaderText = "Escritura" : .Columns((xnivel * 2) + 3).Name = "E" : .Columns((xnivel * 2) + 3).Width = 50
                    .Columns((xnivel * 2) + 4).HeaderText = "Reporte" : .Columns((xnivel * 2) + 4).Name = "R" : .Columns((xnivel * 2) + 4).Width = 50
                    .Columns((xnivel * 2) + 5).HeaderText = "Eliminar" : .Columns((xnivel * 2) + 5).Name = "B" : .Columns((xnivel * 2) + 5).Width = 50
                    .Columns((xnivel * 2) + 6).Visible = False : .Columns((xnivel * 2) + 7).Visible = False : .Columns((xnivel * 2) + 8).Visible = False
                    .Columns((xnivel * 2) + 9).Visible = False : .Columns((xnivel * 2) + 10).Visible = False : .Columns((xnivel * 2) + 11).Visible = False
                    .Columns((xnivel * 2) + 12).Visible = False : .Columns((xnivel * 2) + 13).Visible = False

                    For Each columna As DataGridViewColumn In .Columns
                        If .Columns(columna.Index).Width = 20 Then .Columns(columna.Index).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                        columna.SortMode = DataGridViewColumnSortMode.NotSortable
                    Next

                End With

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub ListarPermiso(ByVal CodigoPadre As Integer, ByVal NombrePadre As String)

            If Me.IDUsuario < 1 Then
                Exit Sub
            End If

            Dim objEntCol As Legolas.LEntity.Seguridad.UsuarioModuloCol
            Dim xcolumna As Integer = 0

            objBssPermiso = New Legolas.LBusiness.Seguridad.UsuarioModulo

            objEntCol = objBssPermiso.ListarModulos(Me.IDUsuario, CodigoPadre, -1)
            'objEntCol.Sort("", Legolas.LEntity.SortDirection.Desc)

            Dim NuevoNodoDGV As String

            For Each obj As Legolas.LEntity.Seguridad.UsuarioModulo In objEntCol
                NuevoNodoDGV = obj.ModuloNombre 'dr("mod_nom").ToString().Trim()

                With dgwPermisos
                    .Rows.Add()
                    If NombrePadre Is Nothing Then
                        .Item(0, .Rows.Count - 1).Value = IIf(xAgruparModulos = True, SigPos, SigNeg)
                        .Item(0, .Rows.Count - 1).Style.ForeColor = Color.Red
                        .Item(1, .Rows.Count - 1).Value = obj.ModuloNombre 'dr("mod_nom").ToString().Trim()
                        .Item(1, .Rows.Count - 1).Style.ForeColor = Color.Blue
                        .Item((xnivel * 2) + 2, .Rows.Count - 1).Value = obj.Lectura 'IIf(dr("flg_lec") = "0", False, True)
                        .Item((xnivel * 2) + 3, .Rows.Count - 1).Value = obj.Escritura 'IIf(dr("flg_esc") = "0", False, True)
                        .Item((xnivel * 2) + 4, .Rows.Count - 1).Value = obj.Reporte 'IIf(dr("flg_rep") = "0", False, True)
                        .Item((xnivel * 2) + 5, .Rows.Count - 1).Value = obj.Eliminar 'IIf(dr("flg_bor") = "0", False, True)
                        .Item((xnivel * 2) + 6, .Rows.Count - 1).Value = "" 'dr("mod_obj")
                        .Item((xnivel * 2) + 7, .Rows.Count - 1).Value = "" 'dr("mod_icn")
                        .Item((xnivel * 2) + 8, .Rows.Count - 1).Value = "" 'dr("mod_ini")
                        .Item((xnivel * 2) + 9, .Rows.Count - 1).Value = obj.Codigo 'dr("mod_ord")
                        .Item((xnivel * 2) + 10, .Rows.Count - 1).Value = "" 'dr("mod_vis")
                        .Item((xnivel * 2) + 11, .Rows.Count - 1).Value = obj.ModuloNivel 'dr("mod_roo_id")
                        .Item((xnivel * 2) + 12, .Rows.Count - 1).Value = obj.ModuloCodigo 'dr("mod_id")
                        .Item((xnivel * 2) + 13, .Rows.Count - 1).Value = obj.ModuloCodigoPadre 'dr("mod_prn_id")
                    Else
                        xcolumna = Val(obj.ModuloNivel)
                        .Item(xcolumna * 2, .Rows.Count - 1).Value = ""
                        .Item((xcolumna * 2) + 1, .Rows.Count - 1).Value = obj.ModuloNombre 'dr("mod_nom").ToString().Trim()
                        .Item((xcolumna * 2) + 1, .Rows.Count - 1).Style.ForeColor = Color.Blue
                        .Item((xnivel * 2) + 2, .Rows.Count - 1).Value = obj.Lectura 'IIf(dr("flg_lec") = "0", False, True)
                        .Item((xnivel * 2) + 3, .Rows.Count - 1).Value = obj.Escritura 'IIf(dr("flg_esc") = "0", False, True)
                        .Item((xnivel * 2) + 4, .Rows.Count - 1).Value = obj.Reporte 'IIf(dr("flg_rep") = "0", False, True)
                        .Item((xnivel * 2) + 5, .Rows.Count - 1).Value = obj.Eliminar 'IIf(dr("flg_bor") = "0", False, True)
                        .Item((xnivel * 2) + 6, .Rows.Count - 1).Value = "" 'dr("mod_obj")
                        .Item((xnivel * 2) + 7, .Rows.Count - 1).Value = "" 'dr("mod_icn")
                        .Item((xnivel * 2) + 8, .Rows.Count - 1).Value = "" 'dr("mod_ini")
                        .Item((xnivel * 2) + 9, .Rows.Count - 1).Value = obj.Codigo 'dr("mod_ord")
                        .Item((xnivel * 2) + 10, .Rows.Count - 1).Value = "" 'dr("mod_vis")
                        .Item((xnivel * 2) + 11, .Rows.Count - 1).Value = obj.ModuloNivel 'dr("mod_roo_id")
                        .Item((xnivel * 2) + 12, .Rows.Count - 1).Value = obj.ModuloCodigo 'dr("mod_id")
                        .Item((xnivel * 2) + 13, .Rows.Count - 1).Value = obj.ModuloCodigoPadre 'dr("mod_prn_id")
                        If Val(.Item((xnivel * 2) + (CantRegEst - 2), .Rows.Count - 2).Value) < Val(obj.ModuloNivel) Then
                            .Item((xcolumna * 2) - 2, .Rows.Count - 2).Value = IIf(xAgruparModulos = True, SigPos, SigNeg) 'SigPos
                            .Item((xcolumna * 2) - 2, .Rows.Count - 2).Style.ForeColor = Color.Red
                        End If

                    End If
                End With
                ' Llamada recurrente al mismo m�todo para agregar los Hijos del Nodo reci�n agregado.
                ListarPermiso(Int32.Parse(obj.ModuloCodigo), NuevoNodoDGV)
            Next

        End Sub

        Private Sub ListarPenal()

            If Me.IDUsuario < 1 Then
                Exit Sub
            End If

            objBssAccesoPenal = New Bussines.Seguridad.Penal.Region
            Dim objEntCol As New Entity.Seguridad.Penal.RegionCol

            objEntCol = objBssAccesoPenal.Listar(-1, Me.IDUsuario, "", "", "", "", -1, -1)

            With Me.dgwPenal
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With

        End Sub
#End Region

#Region "Funciones dgwPermisos"
        Private Sub EvaluarNodos(Optional ByVal xColumna As Integer = 0, Optional ByVal xFila As Integer = 0, Optional ByVal xInicio As Integer = 0)
            Dim i As Integer = 0
            With dgwPermisos
                For Each fila As DataGridViewRow In .Rows
                    If .Item(xColumna, xFila).Value = SigNeg Then
                        If fila.Cells.Item(xColumna + 1).Value <> "" And fila.Index > xFila Then Exit Sub
                        If (fila.Cells.Item(xColumna + 2).Value = SigPos Or fila.Cells.Item(xColumna + 3).Value <> "") And fila.Index > xFila Then
                            .Rows(fila.Index).Visible = True
                        End If
                    ElseIf .Item(xColumna, xFila).Value = SigPos Then
                        If fila.Index > xFila And xInicio = 0 Then
                            For i = xColumna To 0 Step -2
                                If .Item(i + 1, fila.Index).Value <> "" Then Exit Sub
                            Next

                            For i = xColumna To .Columns.Count - CantRegEst
                                If .Item(i, fila.Index).Value = SigNeg Then .Item(i, fila.Index).Value = SigPos
                            Next
                            .Rows(fila.Index).Visible = False
                        Else
                            If fila.Cells.Item(xColumna + 1).Value = "" And fila.Index > xFila Then
                                .Rows(fila.Index).Visible = False
                            End If
                        End If
                    End If
                    'If xAgrupar = False Then
                    'If .Item(xColumna, fila.Index).Value = SigPos Then
                    '    .Item(xColumna, fila.Index).Value = SigNeg
                    'End If
                    'End If
                Next
            End With
        End Sub

        Private Sub EvaluarCheckbox(ByVal xIdNodo As String, ByVal xIdPadre As String, ByVal xColumna As Integer, ByVal xfila As Integer,
                                    ByVal xValor As Boolean, Optional ByVal xSegundaVuelta As Boolean = False)

            Try
                Dim NuevaFilaPadre As Integer = -1
                Dim AsignarValor As Boolean = True
                With dgwPermisos
                    For Each fila As DataGridViewRow In .Rows
                        If .Item("mod_id", fila.Index).Value.ToString = xIdPadre Then NuevaFilaPadre = fila.Index : xVerifPadre = True
                        If (.Item("mod_roo_id", xfila).Value.ToString = .Item("mod_roo_id", fila.Index).Value.ToString) And (.Item(xColumna, xfila).Value.ToString <> .Item(xColumna, fila.Index).Value.ToString) Then
                            If xValor = True Then xVerifPadre = True Else xVerifPadre = False
                        End If
                        If fila.Index > xfila Then
                            If fila.Index > xfila And .Item("mod_prn_id", fila.Index).Value = 0 Then GoTo Salida 'Exit Sub
                            If .Item("mod_prn_id", fila.Index).Value.ToString = xIdNodo And xSegundaVuelta = False Then 'evaluando si tiene hijo
                                .Item(xColumna, fila.Index).Value = xValor
                            ElseIf (.Item("mod_roo_id", xfila).Value.ToString = .Item("mod_roo_id", fila.Index).Value.ToString) And (.Item(xColumna, xfila).Value <> .Item(xColumna, fila.Index).Value) Then
                                If xValor = True Then xVerifPadre = True : AsignarValor = False Else xVerifPadre = False : AsignarValor = False
                            ElseIf (.Item("mod_roo_id", xfila).Value.ToString > .Item("mod_roo_id", fila.Index).Value.ToString) Then

                            ElseIf xSegundaVuelta = False And AsignarValor = True And xIdPadre = 0 Then 'agregado 05-08-2016 ( And xIdPadre )
                                .Item(xColumna, fila.Index).Value = xValor
                            End If
                        End If
                    Next
Salida:
                    If NuevaFilaPadre >= 0 Then
                        Call VerificarCheckBoxPadre(.Item("mod_id", xfila).Value, .Item("mod_prn_id", xfila).Value, xColumna, NuevaFilaPadre, IIf(xfila - 1 = NuevaFilaPadre, .Item(xColumna, xfila).Value, IIf((.Item("mod_roo_id", xfila).Value < .Item("mod_roo_id", xfila - 1).Value) Or (.Item("mod_roo_id", xfila).Value = .Item("mod_roo_id", xfila - 1).Value), .Item(xColumna, xfila).Value, .Item(xColumna, NuevaFilaPadre).Value)))
                    End If
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub VerificarCheckBoxPadre(ByVal xIdNodo As String, ByVal xIdPadre As String, ByVal xColumna As Integer, ByVal xfila As Integer, ByVal xValor As Boolean, Optional ByVal xSegundaVuelta As Boolean = False)
            With dgwPermisos
                For Each fila As DataGridViewRow In .Rows
                    If .Item("mod_id", fila.Index).Value = xIdPadre And xVerifPadre = True Then
                        .Item(xColumna, fila.Index).Value = xValor : xVerifPadre = True
                        Call EvaluarCheckbox(.Item("mod_id", fila.Index).Value, .Item("mod_prn_id", fila.Index).Value, xColumna, fila.Index, .Item(xColumna, fila.Index).Value, True)
                    End If
                Next
            End With
        End Sub
#End Region

#Region "Validar"
        Private Function ValidarPC(ByVal PCID As Integer) As Boolean

            Dim blnValue As Boolean = True

            Me.dgwPC.CurrentCell = Nothing
            For Each row As DataGridViewRow In Me.dgwPC.Rows

                Dim intCodigo As Integer = -1

                intCodigo = row.Cells("col_pc_id").Value

                If intCodigo = PCID Then
                    blnValue = False
                End If
            Next
            Return blnValue
        End Function
        Private Function ValidarUsuario() As Boolean

            Dim value As Boolean = False

            If HabilitarLogin = True Then

                If Me.CUE_Usuario < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                   "Ingrese CUE del Usuario", )
                    Me.txtCueUsuario.Focus()
                    Return value
                End If

                If Me.IDTrabajador < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                   "Ingrese el ID del Trabajador", )
                    Me.txtTrabajador.Focus()
                    Return value
                End If
            End If

            If Me.TipoLicencia < 1 Then
                MessageBox.Show("Seleccione nivel del usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbNivelUsuario.Focus()
                Return value
            End If

            If Me.Perfil < 1 Then
                MessageBox.Show("Seleccione el perfil del usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbDependencia.Focus()
                Return value
            End If

            value = True
            Return value
        End Function
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            '/*numero documento*/
            If Me.NumeroDocumento.Length < 1 Or Me.NumeroDocumento = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Ingrese Numero D.N.I.")
                Me.txtNumDoc.Focus()
                Return value
            End If

            If HabilitarLogin = True Then

                'login
                If Me.Login.Length < 4 Or Me.Login.Length < 4 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Ingrese el nombre del login")
                    Me.txtUsuario.Focus()
                    Return value
                End If

                '/*apellido paterno*/
                If Me.ApellidoPaterno.Length < 1 Or Me.ApellidoPaterno = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Ingrese apellido paterno")
                    Me.txtApePaterno.Focus()
                    Return value
                End If
                'End If

                '/*apellido materno*/
                If Me.ApellidoMaterno.Length < 1 Or Me.ApellidoMaterno = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Ingrese apellido materno")
                    Me.txtApeMat.Focus()
                    Return value
                End If

                '/*nombres*/
                If Me.Nombres.Length < 1 Or Me.Nombres = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Ingrese nombres")
                    Me.txtNom.Focus()
                    Return value
                End If

                '/*correo*/
                If Me.Correo.Length < 1 Or Me.Correo = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Ingrese correo institucional")
                    Me.txtCorreo.Focus()
                    Return value
                End If
            End If

            value = True
            Return value
        End Function
#End Region
#Region "Accion"
        Private Sub AEliminarPC()

            Dim blnValue As Boolean = False

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then

                If Me.GrillaUsuarioPCID > 0 Then

                    Dim objBss As New Legolas.LBusiness.Seguridad.UsuarioPC
                    objBss.Eliminar(Me.GrillaUsuarioPCID)

                    ListarPC()
                Else
                    Me.dgwPC.CurrentCell = Nothing
                    For Each row As DataGridViewRow In Me.dgwPC.Rows
                        If row.Cells(0).Value = Me.GrillaPCItem Then
                            Me.dgwPC.Rows.Remove(row)
                            Exit For
                        End If
                    Next
                End If

            End If

        End Sub
        Private Sub AGrabarPC()

            Dim objBss As New Legolas.LBusiness.Seguridad.UsuarioPC

            Dim intPCID As Integer = -1
            Dim strHostName As String = ""
            Dim strMAC As String = ""

            Me.dgwPC.CurrentCell = Nothing
            For Each row As DataGridViewRow In Me.dgwPC.Rows

                intPCID = row.Cells("col_pc_id").Value
                strHostName = row.Cells("col_hos_nam").Value
                strMAC = row.Cells("col_mac").Value

                objBss.Grabar(-1, Me.IDUsuario, intPCID, strHostName, strMAC, False)

            Next

        End Sub
        Private Sub AGrabarUsuarioSedeCentral()

            If ValidarUsuario() = False Then
                Exit Sub
            End If

            Dim blnGrabar As Boolean = False

            If Me.IDUsuario < 1 Then
                'usuarios nuevos
                Dim strValores As String() = Nothing

                'se conecta a la web service del sip-ga y crea los usuarios 
                Dim objWs As New APPWebService.ws_sipga_sede_usuario.Usuario
                objWs.Url = APPWebService.PathURL.WSSipgaSedeUsuario

                strValores = objWs.CrearUsuariov2(1, Me.NumeroDocumento, Legolas.Configuration.Usuario.Login, 2)

                If Not strValores Is Nothing Then
                    Me.CUE_Usuario = strValores(0).ToString
                    Me.Login = strValores(1).ToString
                    Me.IDTrabajador = strValores(2).ToString
                    Me.ApellidoPaterno = strValores(3).ToString
                    Me.ApellidoMaterno = strValores(4).ToString
                    Me.Nombres = strValores(5).ToString
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "No se pudo conectar con la Sede Central o puede que el trabajador no exista en la Sede Central. Por favor vuelva ha intentar")
                    Exit Sub
                End If

                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = Windows.Forms.DialogResult.Yes Then
                    blnGrabar = True
                End If

            Else
                blnGrabar = True
            End If

            If blnGrabar = True Then
                'grabar el usuario en la bd de la sede
                objBss = New Bussines.Seguridad.Usuario

                'objEnt = New Legolas.LEntity.Seguridad.Usuario
                Dim objEntTmp As Entity.Sistema.Seguridad.Usuario = New Entity.Sistema.Seguridad.Usuario ' Legolas.LEntity.Seguridad.Usuario

                With objEntTmp
                    .Codigo = Me.IDUsuario
                    .Tipo = Me.TipoLicencia
                    .Login = Me.Login
                    .CueUsuario = Me.CUE_Usuario
                    .TrabajadorID = Me.IDTrabajador
                    .ApellidoPaterno = Me.ApellidoPaterno
                    .ApellidoMaterno = Me.ApellidoMaterno
                    .Nombres = Me.Nombres
                    .NumeroDocumento = Me.NumeroDocumento
                    .Dependencia = Me.Perfil
                    .CargoNombre = Me.Cargo
                    .Correo = Me.Correo
                    .AdminValidarPC = Me.AdminValidarPC
                    .AdminModuloUsuario = Me.AdminModuloUsuario
                    .ValidarPorHUella = chkValidarPorHuella.CheckState
                End With

                Me.IDUsuario = objBss.Grabar_v2(objEntTmp, Me.ClaveEncript)

            End If

        End Sub
        Private Sub AGrabarUsuarioProvincia()

            Dim blnGrabar As Boolean = False

            If Me.IDUsuario < 1 Then
                'usuarios nuevos
                Dim strValores As String() = Nothing

                'se crea el usuario en la bd del sipga, sede central
                Dim objWs As New APPWebService.ws_sipga_sede_usuario.Usuario
                objWs.Url = APPWebService.PathURL.WSSipgaSedeUsuario

                strValores = objWs.CrearUsuariov2(1, Me.NumeroDocumento, Legolas.Configuration.Usuario.Login, 2)

                If Not strValores Is Nothing Then
                    Me.CUE_Usuario = strValores(0).ToString
                    Me.Login = strValores(1).ToString
                    Me.IDTrabajador = strValores(2).ToString
                    Me.ApellidoPaterno = strValores(3).ToString
                    Me.ApellidoMaterno = strValores(4).ToString
                    Me.Nombres = strValores(5).ToString
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "No se pudo conectar con la Sede Central o puede que el trabajador no exista en la Sede Central. Por favor vuelva ha internar")
                    Exit Sub
                End If

                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = Windows.Forms.DialogResult.Yes Then
                    blnGrabar = True
                End If

                'grabar el usuario en la bd del pope de la sede central
                If blnGrabar = True Then

                    Dim objWsPopeSede As New APPWebService.ws_pope_sede_usuario.Usuario
                    objWsPopeSede.Url = APPWebService.PathURL.WSPopeSedeUsuario

                    Me.IDUsuario = objWsPopeSede.CrearUsuario(Me.IDUsuario, Me.CUE_Usuario, Me.IDTrabajador,
                        Me.Login, Me.TipoLicencia, Nothing,
                        Me.ApellidoPaterno, Me.ApellidoMaterno, Me.Nombres, 1, Me.NumeroDocumento,
                        Me.Perfil, Me.Cargo, Me.AdminValidarPC,
                        Legolas.Configuration.Usuario.Login)

                    If ValidarUsuario() = False Then Exit Sub

                    If Me.IDUsuario > 0 Then
                        'grabar el usuario localmente
                        Dim objEntTmp As Entity.Sistema.Seguridad.Usuario = New Entity.Sistema.Seguridad.Usuario ' Legolas.LEntity.Seguridad.Usuario
                        With objEntTmp
                            .Codigo = Me.IDUsuario
                            .Tipo = Me.TipoLicencia
                            .Login = Me.Login
                            .CueUsuario = Me.CUE_Usuario
                            .TrabajadorID = Me.IDTrabajador
                            .ApellidoPaterno = Me.ApellidoPaterno
                            .ApellidoMaterno = Me.ApellidoMaterno
                            .Nombres = Me.Nombres
                            .NumeroDocumento = Me.NumeroDocumento
                            .Dependencia = Me.Perfil
                            .CargoNombre = Me.Cargo
                            .Correo = Me.Correo
                            .AdminValidarPC = Me.AdminValidarPC
                            .AdminModuloUsuario = Me.AdminModuloUsuario
                            .ValidarPorHUella = chkValidarPorHuella.CheckState
                        End With

                        Me.IDUsuario = (New Bussines.Seguridad.Usuario).GrabarLocal_v2(objEntTmp, Me.ClaveEncript)
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo conectar con la Sede Central, por favor vuelva ha internar")
                        Exit Sub
                    End If

                End If

            Else

                'actualizar el usuario localmente
                Dim objEntTmp As Entity.Sistema.Seguridad.Usuario = New Entity.Sistema.Seguridad.Usuario
                With objEntTmp
                    .Codigo = Me.IDUsuario
                    .Tipo = Me.TipoLicencia
                    .Login = Me.Login
                    .CueUsuario = Me.CUE_Usuario
                    .TrabajadorID = Me.IDTrabajador
                    .ApellidoPaterno = Me.ApellidoPaterno
                    .ApellidoMaterno = Me.ApellidoMaterno
                    .Nombres = Me.Nombres
                    .NumeroDocumento = Me.NumeroDocumento
                    .Dependencia = Me.Perfil
                    .CargoNombre = Me.Cargo
                    .Correo = Me.Correo
                    .AdminValidarPC = Me.AdminValidarPC
                    .AdminModuloUsuario = Me.AdminModuloUsuario
                    .ValidarPorHUella = chkValidarPorHuella.CheckState
                End With

                Me.IDUsuario = (New Bussines.Seguridad.Usuario).Grabar_v2(objEntTmp, Me.ClaveEncript)

            End If

        End Sub
        Private Sub AGrabar(blnMostrarMensaje As Boolean)

            If Validar() = False Then Exit Sub

            If Configuracion.Licencia.Codigo = 1 Then
                AGrabarUsuarioSedeCentral()
            Else
                AGrabarUsuarioProvincia()
            End If

            If Me.IDUsuario > 0 And blnMostrarMensaje = True Then Legolas.Configuration.Aplication.MessageBox.InformationGrabar()

        End Sub
        Private Sub AGrabarPermisos()
            objBssPermiso = New Legolas.LBusiness.Seguridad.UsuarioModulo

            For i As Integer = 0 To dgwPermisos.Rows.Count - 1
                Dim ss As String = dgwPermisos.Item(1, i).Value
                If dgwPermisos.Item("mod_ord", i).Value > 0 Then 'col_codigo
                    'actualiar todo
                    Dim obj As New Legolas.LEntity.Seguridad.UsuarioModulo
                    obj.Codigo = dgwPermisos.Item("mod_ord", i).Value 'col_codigo

                    obj.UsuarioCodigo = Me.IDUsuario
                    obj.ModuloCodigo = dgwPermisos.Item("mod_id", i).Value 'col_modulo_codigo
                    obj.Lectura = dgwPermisos.Item("L", i).Value 'col_read
                    obj.Escritura = dgwPermisos.Item("E", i).Value 'col_write
                    obj.Reporte = dgwPermisos.Item("R", i).Value 'col_reporte
                    obj.Impresion = False 'dgwPermisos.Item("col_impresion", i).Value
                    obj.Eliminar = dgwPermisos.Item("B", i).Value 'col_eliminar

                    objBssPermiso.Grabar(obj)
                Else
                    'insertar como nuevo
                    If dgwPermisos.Item("L", i).Value = True Or
                      dgwPermisos.Item("E", i).Value = True Or
                      dgwPermisos.Item("R", i).Value = True Or
                      dgwPermisos.Item("B", i).Value = True Then

                        Dim obj As New Legolas.LEntity.Seguridad.UsuarioModulo
                        obj.Codigo = -1

                        obj.UsuarioCodigo = Me.IDUsuario
                        obj.ModuloCodigo = dgwPermisos.Item("mod_id", i).Value 'col_modulo_codigo
                        obj.Lectura = dgwPermisos.Item("L", i).Value 'col_read
                        obj.Escritura = dgwPermisos.Item("E", i).Value 'col_write
                        obj.Reporte = dgwPermisos.Item("R", i).Value 'col_reporte
                        obj.Impresion = False 'dgwPermisos.Item("col_impresion", i).Value
                        obj.Eliminar = dgwPermisos.Item("B", i).Value 'col_eliminar

                        Dim t As Integer = -1
                        t = objBssPermiso.Grabar(obj)
                        t = t
                    End If
                End If
            Next

            Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
            AGrabar(False)

        End Sub

        Private Sub AEliminarMasivo()

            If Legolas.Configuration.Aplication.MessageBox.Question("Desea eliminar los registros seleccionados",
) = Windows.Forms.DialogResult.Yes Then

                Dim intValue As Integer = -1
                Dim intCodigo As Integer = -1
                objBssAccesoPenal = New Bussines.Seguridad.Penal.Region

                For Each fila As DataGridViewRow In Me.dgwPenal.Rows

                    If fila.Cells("col_chk").Value = True Then
                        intCodigo = fila.Cells("col_id").Value
                        intValue = objBssAccesoPenal.Eliminar(intCodigo)
                    End If
                Next

                If intValue > 0 Then
                    ListarPenal()
                End If

            End If

        End Sub

        Private CodigoUsuarioNotificacion As Integer
        Private Function ValidarHabilitarPermisoAlerta() As Boolean

            Dim value As Boolean = False

            '1.- validar si ya tiene activado la alerta
            Dim blnAlertaActivado As Boolean = False
            For i As Integer = 0 To dgvListarPermisosAlertas.Rows.Count - 1
                If dgvListarPermisosAlertas.Rows(i).Cells("col_acc_id").Value = 1 Then
                    blnAlertaActivado = True
                    Exit For
                End If
            Next

            If blnAlertaActivado = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un permiso activo del usuario")
                Return False
            End If

            Select Case Me.TipoLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia, Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana, Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaProvincia
                    ListarPenal()
                    If dgwPenal.Rows.Count = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Agregar un penal disponible para este usuario")
                        Return False
                    End If

                    If dgwPenal.Rows.Count > 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe 2 penales disponibles para este tipo de usuario." + Chr(13) +
                                                                                "Solo se puede autorizar permiso a un solo penal")
                        Return False
                    End If

                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia, Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana

                    If Me.RegionId < 1 Or Me.RegionId = 11 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Selecione la Oficina regional.")
                        cbbRegion.Focus()
                        Return False
                    End If

                Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Las notificaciones de alertas no estan disponibles para el nivel de usuario [Sede]")
                    Return False
            End Select

            value = True
            Return value
        End Function
        Private Sub HabilitarPermisosAlertas()
            Dim strmensaje As String = "Desea habilitar el [Servicio de alertas para sentencias.]" + Chr(13) +
                                       "al usuario: " & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres


            If ValidarHabilitarPermisoAlerta() = False Then
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strmensaje) = DialogResult.Yes Then
                CodigoUsuarioNotificacion = -1
                GrabarHabilitacionAlertas()
                ListarPermisosAlertas()
            End If
        End Sub

        Private Sub InhabilitarPermisosAlertas()
            Dim strmensaje As String = "Desea Inhabilitar el [Servicio de alertas para sentencias.]" + Chr(13) +
                                       "del usuario: " & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres

            If dgvListarPermisosAlertas.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un registro para inhabilitar")
                Exit Sub
            End If
            If dgvListarPermisosAlertas.SelectedRows(0).Cells("col_acc_id").Value = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Solo se puede inhabilitar un permiso activo")
                Exit Sub
            End If
            Dim frm As New Sistema.Seguridad.Usuario.frmMotivo
            If frm.ShowDialog = DialogResult.OK Then
                CodigoUsuarioNotificacion = dgvListarPermisosAlertas.SelectedRows(0).Cells("col_usu_not_id").Value
                Me.NotificacionMotivo = frm.Motivo
                GrabarHabilitacionAlertas()
                ListarPermisosAlertas()
            End If
        End Sub
        Private Sub GrabarHabilitacionAlertas()
            Dim bssUsuNot As New Bussines.Seguridad.UsuarioNotificacion
            Dim objUsuNot As New Entity.Sistema.Seguridad.UsuarioNotificacion
            objUsuNot.CodUsuario = Me.IDUsuario
            objUsuNot.FechaRegistro = Legolas.Configuration.Aplication.FechayHora.FechaLong
            objUsuNot.MotivoNombre = ""
            objUsuNot.EstadoId = Type.Enumeracion.Interno.EnmEstado.Activo

            If Me.CodigoUsuarioNotificacion < 1 Then
                objBssAccesoPenal = New Bussines.Seguridad.Penal.Region
                Dim objEntCol As New Entity.Seguridad.Penal.RegionCol

                If Me.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia Or
                    Me.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                    objUsuNot.RegionId = Me.RegionId
                    objUsuNot.PenalId = -1
                    bssUsuNot.Grabar(objUsuNot, "")
                Else
                    objEntCol = objBssAccesoPenal.Listar(-1, Me.IDUsuario, "", "", "", "", -1, -1)
                    For Each obj As Entity.Seguridad.Penal.Region In objEntCol
                        objUsuNot.RegionId = obj.RegionID
                        objUsuNot.PenalId = obj.PenalID
                        bssUsuNot.Grabar(objUsuNot, "")
                    Next
                End If
            Else
                objUsuNot.Codigo = CodigoUsuarioNotificacion
                objUsuNot.MotivoNombre = Me.NotificacionMotivo
                bssUsuNot.Grabar(objUsuNot, "")
            End If

        End Sub
        Private Sub ListarPermisosAlertas()

            If Me.IDUsuario < 1 Then
                Exit Sub
            End If

            Dim bssUsuNot As New Bussines.Seguridad.UsuarioNotificacion
            Dim objUsuNot As New Entity.Sistema.Seguridad.UsuarioNotificacion
            Dim objEntCol As New Entity.Sistema.Seguridad.UsuarioNotificacionCol

            Select Case Me.TipoLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana,
                     Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                    lblRegion.Visible = True
                    cbbRegion.Visible = True
                Case Else
            End Select

            objUsuNot.CodUsuario = Me.IDUsuario
            objUsuNot.Codigo = -1
            objEntCol = bssUsuNot.Listar(objUsuNot)

            With Me.dgvListarPermisosAlertas
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With

            Dim blnvalor As Boolean = False
            For i As Integer = 0 To dgvListarPermisosAlertas.Rows.Count - 1
                If dgvListarPermisosAlertas.Rows(i).Cells("col_acc_id").Value = 1 Then
                    blnvalor = True
                    Exit For
                End If
            Next
            If Me.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or
                     Me.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia Then
                If blnvalor = False Then
                    Me.lblRegion.Visible = True
                    Me.cbbRegion.Visible = True
                Else
                    Me.lblRegion.Visible = False
                    Me.cbbRegion.Visible = False
                End If
            End If
        End Sub
        Private Sub Detallepermiso()
            Dim frm As New Sistema.Seguridad.Usuario.frmPermisoDetalle
            frm._Codigo = Me.GrillaCodigoUsuarioNotificacion
            frm._UsuarioDatos = Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres
            frm.ShowDialog()
        End Sub
#End Region
#Region "Form"
        Private Sub FRM_Penal()

            If Me.IDUsuario < 1 Then
                Exit Sub
            End If

            Dim frm As New Sistema.Seguridad.Licencia.frmPenal
            With frm
                .UsuarioID = Me.IDUsuario
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    AGrabar(True)
                    ListarPenal()
                End If
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub Habilitar(ByVal vf As Boolean)

            dgwPenal.CurrentCell = Nothing
            For Each fila As DataGridViewRow In Me.dgwPenal.Rows
                fila.Cells("col_chk").Value = vf
            Next

        End Sub
        Private Sub AGrillaPC(ByVal PCID As Integer, ByVal HostName As String, ByVal MAC As String)

            If ValidarPC(PCID) = True Then
                Dim row As New DataGridViewRow

                row.CreateCells(Me.dgwPC)
                row.Cells(0).Value = Me.dgwPC.RowCount + 1 'col_ite
                row.Cells(1).Value = -1 'col_usu_pc_id
                row.Cells(2).Value = PCID 'col_pc_id
                row.Cells(3).Value = HostName 'col_hos_nam
                row.Cells(4).Value = MAC 'col_mac 
                Me.dgwPC.Rows.Add(row)
            End If
        End Sub
        Private Sub ValoresxDefault()

            ComboTipoLicencia()
            ComboDependencia()
            CrearDataGridviewPermisos()
            ComboRegion()
            If Me._limitarAccesoSoloHuella Then btnOk.Visible = False

        End Sub
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            Select Case Me.TabIndice
                Case 1 'datos del trabajador
                    AGrabar(True)
                Case 2 'permisos
                    AGrabarPermisos()
                Case 5
                    UscHuellaUsuarioVisor1.Grabar()
            End Select

        End Sub

        Private Sub frmUsuarioPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub frmUsuarioPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            ListarData()
        End Sub

        Private Sub btnAddPc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPc.Click

            'Dim frm As New Seguridad.PC.frmPCPopup
            'With frm
            '    If .ShowDialog = Windows.Forms.DialogResult.OK Then
            '        AGrillaPC(.GrillaID, .GrillaHostName, .GrillaMAC)
            '        'ListarPC()
            '    End If
            'End With
        End Sub

        Private Sub dgwPC_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwPC.CellContentClick

        End Sub

        Private Sub dgwPC_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwPC.CellEnter

            With Me.dgwPC
                intGrillaUsuarioPCID = .Item("col_usu_pc_id", .CurrentCell.RowIndex).Value
                intGrillaPCItem = .Item("col_ite", .CurrentCell.RowIndex).Value
            End With

        End Sub

        Private Sub dgwPC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwPC.KeyDown

            If e.KeyCode = Keys.Delete Then
                AEliminarPC()
            End If

        End Sub

        Private Sub chkLogin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLogin.CheckedChanged

            Me.txtUsuario.ReadOnly = Not Me.chkLogin.Checked
            Me.txtCueUsuario.ReadOnly = Not Me.chkLogin.Checked
            Me.txtTrabajador.ReadOnly = Not Me.chkLogin.Checked
            Me.txtApePaterno.ReadOnly = Not Me.chkLogin.Checked
            Me.txtApeMat.ReadOnly = Not Me.chkLogin.Checked
            Me.txtNom.ReadOnly = Not Me.chkLogin.Checked

        End Sub

        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
            Select Case TabControl1.SelectedIndex
                Case 0 'datos del trabajador
                    btnOk.Visible = IIf(Me._limitarAccesoSoloHuella, False, True)
                Case 1 'datos del usuario
                    'ListarPermiso()
                    If Me._limitarAccesoSoloHuella = False Then
                        CrearDataGridviewPermisos()
                        ListarPermiso(0, Nothing)
                        Call EvaluarNodos(0, 0, 1)
                    Else
                        TabPage2.Enabled = False
                        btnOk.Visible = False
                        MessageBox.Show("Acceso no autorizado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Case 2 'acceso a penales
                    If Me._limitarAccesoSoloHuella = False Then
                        ListarPenal()
                    Else
                        TabPage3.Enabled = False
                        btnOk.Visible = False
                        MessageBox.Show("Acceso no autorizado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Case 3 'verificar datos
                    If Me._limitarAccesoSoloHuella = False Then
                        ListarPermisosAlertas()
                    Else
                        TabPage4.Enabled = False
                        btnOk.Visible = False
                        MessageBox.Show("Acceso no autorizado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Case 4
                    LoadOdontograma()
                    btnOk.Visible = True
            End Select
        End Sub

        Private Sub LoadOdontograma()

            If blTabOdontogramaCargado = False Then
                UscHuellaUsuarioVisor1.LoadUsc()
                blTabOdontogramaCargado = True
            End If

        End Sub

        Private Sub btnAddPenal_Click(sender As System.Object, e As System.EventArgs) Handles btnAddPenal.Click

            FRM_Penal()

        End Sub

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click

            If Me.dgwPenal.RowCount > 0 Then AEliminarMasivo()

        End Sub

        Private Sub chkTodos_Click(sender As Object, e As System.EventArgs) Handles chkTodos.Click
            Me.Habilitar(Me.chkTodos.Checked)
        End Sub

        Private Sub dgwPermisos_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwPermisos.CellClick
            Try
                With dgwPermisos
                    If .Item(.CurrentCell.ColumnIndex, .CurrentCell.RowIndex).Value.ToString = "False" Or .Item(.CurrentCell.ColumnIndex, .CurrentCell.RowIndex).Value.ToString = "True" Then
                        If .Item(.CurrentCell.ColumnIndex, .CurrentCell.RowIndex).Value = True Then
                            .Item(.CurrentCell.ColumnIndex, .CurrentCell.RowIndex).Value = False
                            xVerifPadre = True
                            Call EvaluarCheckbox(.Item("mod_id", .CurrentCell.RowIndex).Value, .Item("mod_prn_id", .CurrentCell.RowIndex).Value, .CurrentCell.ColumnIndex, .CurrentCell.RowIndex, .Item(.CurrentCell.ColumnIndex, .CurrentCell.RowIndex).Value)
                        Else
                            .Item(.CurrentCell.ColumnIndex, .CurrentCell.RowIndex).Value = True
                            xVerifPadre = True
                            Call EvaluarCheckbox(.Item("mod_id", .CurrentCell.RowIndex).Value, .Item("mod_prn_id", .CurrentCell.RowIndex).Value, .CurrentCell.ColumnIndex, .CurrentCell.RowIndex, .Item(.CurrentCell.ColumnIndex, .CurrentCell.RowIndex).Value)
                        End If
                    Else
                        If .CurrentCell.Value = SigPos Then
                            .Item(.CurrentCell.ColumnIndex, .CurrentCell.RowIndex).Value = SigNeg
                            Call EvaluarNodos(.CurrentCell.ColumnIndex, .CurrentCell.RowIndex)
                        ElseIf .CurrentCell.Value = SigNeg Then
                            .Item(.CurrentCell.ColumnIndex, .CurrentCell.RowIndex).Value = SigPos
                            Call EvaluarNodos(.CurrentCell.ColumnIndex, .CurrentCell.RowIndex)
                        End If
                    End If
                End With
            Catch ex As Exception

            End Try
        End Sub

        Private Sub dgwPermisos_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwPermisos.CellContentClick

            Dim blnActivar As Boolean = False
            If e.RowIndex = -1 Then Exit Sub

            If dgwPermisos.Columns(e.ColumnIndex).Name = "col_write" Or
              dgwPermisos.Columns(e.ColumnIndex).Name = "col_read" Or
              dgwPermisos.Columns(e.ColumnIndex).Name = "col_reporte" Or
              dgwPermisos.Columns(e.ColumnIndex).Name = "col_impresion" Or
              dgwPermisos.Columns(e.ColumnIndex).Name = "col_eliminar" Then

                If dgwPermisos.Item("col_codigo_padre", e.RowIndex).Value = 0 Then 'si activa check padre

                    If dgwPermisos.Item(dgwPermisos.Columns(e.ColumnIndex).Name, e.RowIndex).Value = False Then
                        blnActivar = True
                    Else
                        blnActivar = False
                    End If

                    For i As Integer = e.RowIndex To dgwPermisos.Rows.Count - 1
                        If i + 1 >= dgwPermisos.Rows.Count Then
                            dgwPermisos.CurrentCell = Nothing
                            Exit Sub
                        End If

                        If dgwPermisos.Item("col_codigo_padre", i + 1).Value <> 0 Then
                            dgwPermisos.Item(dgwPermisos.Columns(e.ColumnIndex).Name, i + 1).Value = blnActivar
                        Else
                            dgwPermisos.CurrentCell = Nothing
                            Exit Sub
                        End If

                    Next
                End If


                'determinar la fila padre
                Dim intIndexFilaPdre As Integer = -1

                If dgwPermisos.Item("col_codigo_padre", e.RowIndex).Value > 0 Then 'si activa check en hijo
                    For i As Integer = e.RowIndex To 0 Step -1
                        If i - 1 <= -1 Then
                            dgwPermisos.CurrentCell = Nothing
                            Exit For
                        End If
                        If dgwPermisos.Item("col_codigo_padre", i - 1).Value = 0 Then
                            intIndexFilaPdre = i - 1
                            Exit For
                        End If
                    Next
                End If

                dgwPermisos.CurrentCell = Nothing
                If dgwPermisos.Item("col_codigo_padre", e.RowIndex).Value > 0 Then 'si activa check hijo

                    For i As Integer = intIndexFilaPdre To dgwPermisos.Rows.Count - 1

                        If i + 1 >= dgwPermisos.Rows.Count Then
                            dgwPermisos.Item(dgwPermisos.Columns(e.ColumnIndex).Name, intIndexFilaPdre).Value = False
                            Exit Sub
                        End If

                        If dgwPermisos.Item("col_codigo_padre", i + 1).Value <> 0 Then
                            If dgwPermisos.Item(dgwPermisos.Columns(e.ColumnIndex).Name, i + 1).Value = True Then
                                dgwPermisos.Item(dgwPermisos.Columns(e.ColumnIndex).Name, intIndexFilaPdre).Value = True
                                Exit Sub
                            End If
                        Else
                            dgwPermisos.CurrentCell = Nothing
                            dgwPermisos.Item(dgwPermisos.Columns(e.ColumnIndex).Name, intIndexFilaPdre).Value = False
                            Exit Sub
                        End If

                    Next
                End If
            End If

        End Sub

        Private Sub dgwPermisos_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwPermisos.CellFormatting

            If dgwPermisos.Rows.Count > 0 Then
                If dgwPermisos.Item("mod_prn_id", e.RowIndex).Value = 0 Then 'si activa check en hijo
                    dgwPermisos.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.DarkBlue
                    dgwPermisos.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightYellow
                End If
            End If

        End Sub

        Private Sub cbbNivelUsuario_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbNivelUsuario.SelectedIndexChanged

            If blnComboNivelUsuario = True Then
                ComboDependencia()
                Me.Perfil = -1
            End If
        End Sub

        Private Sub btnActivarUsuario_Click(sender As System.Object, e As System.EventArgs) Handles btnActivarUsuario.Click

            If Me.IDUsuario < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Question("Antes de realizar esta operacion, grabe los datos del usuario")
                Exit Sub
            End If

            If Me.EstadoEliminado = False Then
                Legolas.Configuration.Aplication.MessageBox.Information("El usuario se encuentra activo")
            Else

                objBss = New Bussines.Seguridad.Usuario
                objBss.ActivarUsuario(Me.IDUsuario)
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Me.EstadoEliminado = False
            End If

        End Sub

        Private Sub btnRestaurar_Click(sender As System.Object, e As System.EventArgs)

            If Me.IDUsuario < 1 Then Exit Sub

            Dim intValue As Integer = -1
            Dim objBss As New Legolas.LBusiness.Seguridad.Usuario

            intValue = objBss.RestaurarClave(Me.IDUsuario, Legolas.Configuration.Usuario.Codigo)

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information(
                "La contrase�a ha sido restaurada satisfactoriamente")

            End If

        End Sub

        Private Sub btnHabilitarAlertas_Click(sender As Object, e As EventArgs) Handles btnHabilitarAlertas.Click
            HabilitarPermisosAlertas()
        End Sub

        Private Sub btnDeshabilitarAlertas_Click(sender As Object, e As EventArgs) Handles btnDeshabilitarAlertas.Click
            InhabilitarPermisosAlertas()
        End Sub

        Private Sub dgvListarPermisosAlertas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListarPermisosAlertas.CellDoubleClick
            Detallepermiso()
        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged
            Me.RegionId = cbbRegion.SelectedValue
        End Sub
    End Class

End Namespace


