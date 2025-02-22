﻿Namespace Registro.Reporte
    Public Class frmReporteDocPopup
        Public objEntCol As Entity.Reporte.CertificadoLibertad.RestriccionCol
#Region "Propiedades"
        Private intTipoDocumentoID As Integer = -1
        Private lngpInternoID As Long = 0
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
        Public Property _pReporteTipo() As Integer
            Get
                Return intTipoDocumentoID
            End Get
            Set(ByVal value As Integer)
                intTipoDocumentoID = value
            End Set
        End Property
        Public Property _pInternoID() As Long
            Get
                Return lngpInternoID
            End Get
            Set(ByVal value As Long)
                lngpInternoID = value
            End Set
        End Property
        Private ReadOnly Property TipoDocumentoID() As Integer
            Get
                Return Me._pReporteTipo
            End Get
        End Property
        Private ReadOnly Property TipoDocumentoNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.TipoDocumentoID
                    Case 6, 25, 42, 63
                        value = "Constancia de Reclusion"
                    Case 7
                        value = "Papeleta de Excarcelacion"
                    Case 8, 36, 44, 64
                        value = "Certificado de Libertad"
                End Select
                Return value
            End Get

        End Property
        Private Property TipoDocumento() As String
            Get
                Return Me.txtTipoDoc.Text
            End Get
            Set(ByVal value As String)
                Me.txtTipoDoc.Text = value
            End Set
        End Property
        Private Property Anio() As Integer
            Get
                Return Me.cbbAnio.Value
            End Get
            Set(ByVal value As Integer)
                Me.cbbAnio.Value = value
            End Set
        End Property
        Private Property Numero() As String
            Get
                Return Me.txtNumero.Text
            End Get
            Set(ByVal value As String)
                Me.txtNumero.Text = value
            End Set
        End Property
        Private ReadOnly Property AnioNumero() As String
            Get
                Dim value As String = ""
                value = Me.Anio.ToString & "-" & Me.Numero
                Return value
            End Get
        End Property
        'Private Property Correlativo() As String
        '    Get
        '        Return Me.txtCorrelativo.Text
        '    End Get
        '    Set(ByVal value As String)
        '        Me.txtCorrelativo.Text = value
        '    End Set
        'End Property
        Private Property FechaEmision() As Long
            Get
                Return Me.dtpFechaEmision.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaEmision.ValueLong = value
            End Set
        End Property
        Private ReadOnly Property FechaEmisionString() As String
            Get
                Dim value As String = ""

                If Me.FechaEmision > 0 Then
                    value = Legolas.Components.FechaHora.FechaString(Me.FechaEmision)
                Else
                    value = Legolas.Configuration.Aplication.FechayHora.FechaString
                End If

                Return value

            End Get
        End Property
     
        Private Property Nota() As String
            Get
                Return Me.txtNota.Text
            End Get
            Set(ByVal value As String)
                Me.txtNota.Text = value
            End Set
        End Property
        Private Property Direccion() As String
            Get
                Return Me.txtDireccion.Text
            End Get
            Set(ByVal value As String)
                Me.txtDireccion.Text = value
            End Set
        End Property
        Private Property Procedencia() As String
            Get
                Return Me.txtProcedencia.Text
            End Get
            Set(ByVal value As String)
                Me.txtProcedencia.Text = value
            End Set
        End Property
        Private Property Procedencia2() As String
            Get
                Return Me.txtProcedencia2.Text
            End Get
            Set(ByVal value As String)
                Me.txtProcedencia2.Text = value
            End Set
        End Property
        Private Property Observaciones() As String
            Get
                Return Me.txtObs.Text
            End Get
            Set(ByVal value As String)
                Me.txtObs.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Otros"
        Private ReadOnly Property Observacion1() As String
            Get
                Dim value As String = ""

                Select Case Me.TipoDocumentoID
                    Case 6, 25, 63, 42 'certificado de reclusion
                        value = Me.Observaciones
                    Case 7 'papeleta de excarcelacion
                        value = Me.Procedencia
                    Case 8, 36, 44, 64 'certificado de libertad
                        value = Me.Procedencia2
                End Select

                Return value
            End Get
        End Property
        Private ReadOnly Property Observacion2() As String
            Get
                Dim value As String = ""

                Select Case Me.TipoDocumentoID
                    Case 7 'papeleta de excarcelacion
                        value = Me.Direccion
                    Case 8, 36, 44, 64 'certificado de libertad
                        value = Me.Nota
                End Select

                Return value
            End Get
        End Property
        Public ReadOnly Property RestriccionCol() As Entity.Reporte.CertificadoLibertad.RestriccionCol
            Get
                Dim value As Entity.Reporte.CertificadoLibertad.RestriccionCol = Nothing

                Select Case Me.TipoDocumentoID
                    Case 8, 36, 44, 64 'libertad
                        value = objEntCol
                    Case Else
                        value = Nothing
                End Select

                Return value

            End Get
        End Property
#End Region
#Region "Propiedades_Return"
        Public ReadOnly Property _DocumentoNumero() As String
            Get
                Return Me.AnioNumero
            End Get
        End Property
        Public ReadOnly Property _FechaEmision() As String
            Get
                Return Me.FechaEmisionString
            End Get
        End Property
        Public ReadOnly Property _Observacion As String
            Get
                Return Me.Observacion1
            End Get
        End Property
        Public ReadOnly Property _Nota As String
            Get
                Return txtNota.Text
            End Get
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private intGrillaItem As Integer = 0
        Private ReadOnly Property GrillaItem() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.dgwRestriccion.RowCount > 0 Then
                    intValue = intGrillaItem
                End If
                Return intValue
            End Get

        End Property
#End Region
#Region "Combo"
        Private Sub ComboEstado()

            'With Me.cbbEstado
            '    .Items.Add("")
            '    .Items.Add("Pendiente")
            '    .Items.Add("Terminado")
            'End With

        End Sub
        Private Sub ComboAnio()

            With Me.cbbAnio
                .AnioInicio = 2000
                .AnioFin = Legolas.Configuration.Aplication.FechayHora.FechaAnio
                .LoadUsc()
            End With

            Me.Anio = Legolas.Configuration.Aplication.FechayHora.FechaAnio

        End Sub
#End Region
#Region "Grilla"
        Private Sub GrillaEliminar()

            If Me.GrillaItem > 0 Then
                objEntCol.RemoveID(Me.GrillaItem)
                GrillaListar()
            End If

        End Sub
        Private Sub GrillaListar()

            With Me.dgwRestriccion
                .AutoGenerateColumns = False
                .DataSource = Nothing

                If objEntCol Is Nothing = False Then
                    .DataSource = objEntCol
                Else
                    Legolas.Configuration.Aplication.MessageBox.MensajeError( _
                   "El objeto objEntCol, tiene problemas")
                End If

            End With

        End Sub
        Private Sub GrillaRegistrar(ByVal Nombre As String)

            Dim objEnt As New Entity.Reporte.CertificadoLibertad.Restriccion

            objEnt.Item = Me.dgwRestriccion.RowCount + 1
            objEnt.Descripcion = Nombre
            objEntCol.Add(objEnt)

            GrillaListar()

        End Sub
#End Region
#Region "Reporte"
        Private Sub AReporte()

            Dim strMensaje As String = "Esta seguro de generar el reporte"

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) <> Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If

            Select Case Me._pReporteTipo
                Case 25, 36, 42, 44, 63, 64 'CERTIFICADO DE LIBERTAD
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Case Else
                    'Dim frm As New APPReporte.Registro.frmReporte
                    'With frm
                    '    ._pReporteTipo = Me._pReporteTipo
                    '    ._pInternoID = Me._pInternoID
                    '    ._pNumeroDoc = Me.AnioNumero
                    '    ._pFechaEmision = Me.FechaEmisionString
                    '    ._pObservacion1 = Me.Observacion1
                    '    ._pObservacion2 = Me.Observacion2
                    '    ._pRestriccionCol = Me.RestriccionCol
                    '    .ShowDialog()
                    'End With
            End Select

        End Sub
#End Region
#Region "Otros"
        Private Sub Habilitar()

            Me.TipoDocumento = Me.TipoDocumentoNombre.ToUpper

            Me.pnlObs.Visible = False
            Me.pnlPapeletaExcarcelacion.Visible = False
            Me.pnlLibertad.Visible = False

            Select Case Me.TipoDocumentoID
                Case 6, 25, 42, 63 'certificado de reclusion
                    Me.pnlObs.Visible = True
                Case 7 'papeleta de excarcelacion
                    Me.pnlPapeletaExcarcelacion.Visible = True
                Case 8, 36, 64, 44 'certificado de libertad
                    Me.pnlLibertad.Visible = True
            End Select

            'Select Case Me._TipoLicencia
            '    Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
            '        Me.pnlProcedencia2.Visible = False
            '    Case Else
            '        Me.pnlProcedencia2.Visible = True
            'End Select

        End Sub
        Private Sub ValoresxDefault()
            If objEntCol Is Nothing Then
                objEntCol = New Entity.Reporte.CertificadoLibertad.RestriccionCol
            End If
            ComboEstado()
            ComboAnio()

            Me.FechaEmision = Legolas.Configuration.Aplication.FechayHora.FechaLong
        End Sub
#End Region

        Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

            Dim frm As New Registro.Reporte.frmReporteRestriccionPopup
            With frm
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    GrillaRegistrar(._Nombre)
                End If
            End With

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AReporte()

        End Sub

        Private Sub frmReporteDocPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmReporteDocPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Habilitar()

        End Sub

        Private Sub dgwRestriccion_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwRestriccion.CellEnter

            Try

                With Me.dgwRestriccion
                    intGrillaItem = .Item("col_ite", .CurrentCell.RowIndex).Value
                End With

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub

        Private Sub dgwRestriccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwRestriccion.KeyDown

            If e.KeyCode = Keys.Delete Then
                GrillaEliminar()
            End If

        End Sub

        Private Sub dgwRestriccion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwRestriccion.CellContentClick

        End Sub
    End Class

End Namespace