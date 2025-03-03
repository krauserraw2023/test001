﻿Namespace Visita.Interno
    Public Class frmSancionPopup
        Private objBss As Bussines.Visita.InternoSancion = Nothing
        Private objEnt As Entity.Visita.InternoSancion = Nothing
#Region "Propiedades_Parametricas"
        Private intInternoID As Integer = -1
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Public Property _InternoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
            End Set
        End Property
        Public Property _InternoApellidosyNombres As String = ""
        Public Property _RegionID() As Integer
            Get
                Return intRegionID
            End Get
            Set(ByVal value As Integer)
                intRegionID = value
            End Set
        End Property
        Public Property _PenalID() As Integer
            Get
                Return intPenalID
            End Get
            Set(ByVal value As Integer)
                intPenalID = value
            End Set
        End Property
#End Region
#Region "Propiedades"
        Private intCodigo As Integer = -1        
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Private Property TipoSancion() As Integer
            Get
                Return Me.cbbTipSan.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipSan.SelectedValue = value
            End Set
        End Property
        Private Property FechaSancion() As Long
            Get
                Return Me.dtpFechaSan.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaSan.ValueLong = value
            End Set
        End Property
        Private Property FechaInicio() As Long
            Get
                Return Me.dtpFechaIni.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaIni.ValueLong = value
            End Set
        End Property
        Private Property FechaFin() As Long
            Get
                Return Me.dtpFechaFin.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaFin.ValueLong = value
            End Set
        End Property
        Private Property FechaFinIndeterminado() As Boolean
            Get
                Return Me.chkIndeterminado.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkIndeterminado.Checked = value
            End Set
        End Property
        Private Property Documento() As String
            Get
                Return Me.txtDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDoc.Text = value
            End Set
        End Property
        Private Property Estado() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.chkEstado.Checked = True Then
                    intValue = 1
                Else
                    intValue = 0
                End If
                Return intValue
            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case 0
                        Me.chkEstado.Checked = False
                    Case 1
                        Me.chkEstado.Checked = True
                End Select
            End Set
        End Property
        Private Property Obs() As String
            Get
                Return Me.txtObs.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObs.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Otros"
        Private blnVisibleGrabar As Boolean = False
        Public Property _VisibleGrabar() As Boolean
            Get
                Return blnVisibleGrabar
            End Get
            Set(ByVal value As Boolean)
                blnVisibleGrabar = value
            End Set
        End Property

#End Region
#Region "Combo"
        Private Sub Combo()

            With Me.cbbTipSan
                .LoadUsc()
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub ListarData()

            If Me.Codigo < 1 Then
                Exit Sub
            End If

            objEnt = New Entity.Visita.InternoSancion
            objBss = New Bussines.Visita.InternoSancion

            objEnt = objBss.Listar(Me.Codigo)
            With objEnt
                Me.TipoSancion = .TipoSancion
                Me.FechaSancion = .Fecha
                Me.FechaInicio = .FechaInicio
                Me.FechaFin = .FechaFin
                Me.FechaFinIndeterminado = .FechaFinIndeterminado
                HabilitarIndeterminado()
                Me.Documento = .Documento
                Me.Estado = .EstadoID
                Me.Obs = .Obs
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True

            'visitante 
            If Me._InternoID < 1 Then
                blnValue = False
                Return blnValue
            End If

            'tipo sancion
            If Me.TipoSancion < 1 Then
                MessageBox.Show("Seleccione el tipo de sancion", _
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.cbbTipSan.Focus()
                Return blnValue
            End If

            'fecha de sancion
            If Me.FechaSancion < 1 Then
                MessageBox.Show("Ingrese la fecha de sanccion", _
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.dtpFechaSan.Focus()
                Return blnValue
            End If

            'fecha ini
            If Me.FechaInicio < 1 Then
                MessageBox.Show("Ingrese la fecha de inicio", _
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.dtpFechaIni.Focus()
                Return blnValue
            End If

            'fecha ini
            If Me.FechaFinIndeterminado = False Then
                If Me.FechaFin < 1 Then
                    MessageBox.Show("Ingrese la fecha fin", _
                    Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    blnValue = False
                    Me.dtpFechaFin.Focus()
                    Return blnValue
                End If
            End If
            
            'fecha ini
            If Me.FechaFinIndeterminado = False Then
                If Me.FechaFin < Me.FechaInicio Then
                    MessageBox.Show("La fecha final, no puede ser menor a la fecha de inicio", _
                    Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    blnValue = False
                    Me.dtpFechaFin.Focus()
                    Return blnValue
                End If
            End If
            
            Return blnValue
        End Function
        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            If Me.Codigo > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Los datos ingresados no se pueden modificar")
                Exit Sub
            End If

            objBss = New Bussines.Visita.InternoSancion
            Dim objEnt As New Entity.Visita.InternoSancion

            With objEnt
                .Codigo = Me.Codigo
                .InternoID = Me._InternoID
                .InternoApellidosyNombres = Me._InternoApellidosyNombres
                .TipoSancion = Me.TipoSancion
                .Fecha = Me.FechaSancion
                .FechaInicio = Me.FechaInicio
                .FechaFin = Me.FechaFin
                .FechaFinIndeterminado = Me.FechaFinIndeterminado
                .Documento = Me.Documento
                .EstadoID = Me.Estado
                .Obs = Me.Obs
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With

            Me.Codigo = objBss.Grabar(objEnt)

            If Me.Codigo > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            Me.btnOk.Visible = Me._VisibleGrabar
            Combo()
        End Sub
        Private Sub HabilitarIndeterminado()

            If Me.FechaFinIndeterminado = True Then
                Me.FechaFin = 0
            End If

            Me.dtpFechaFin.Enabled = Not Me.FechaFinIndeterminado

        End Sub
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AGrabar()

        End Sub

        Private Sub frmSancionPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmSancionPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ListarData()

        End Sub

        Private Sub chkIndeterminado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkIndeterminado.Click

            HabilitarIndeterminado()

        End Sub
    End Class
End Namespace

