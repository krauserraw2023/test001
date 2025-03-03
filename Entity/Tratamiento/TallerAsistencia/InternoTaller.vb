
Namespace Tratamiento.TallerAsistencia
    Public Class InternoTaller
        Inherits Legolas.LEntity.Globall.Persona

#Region "Propiedades"

        Public Property Codigo As Integer = -1
        '------------------------------
        Public Property InternoID As Integer = -1
        Private strDomicilio As String = ""
        Private strEstado As String = ""
        Private strOcupacionNombre As String = ""
        Private strNivelAcademicoNombre As String = ""
        Private strProfesionNombre As String = ""
        Private strComunidadAndinaNombre As String = ""
        Private strObs As String = ""
        Public Property SedeRowId As Integer = -1
        '-----------------------------
        Public Property FlagTransferenciaSede As Integer = 0
        Public Property Contador() As Integer = -1
        Public Property CodigoTaller() As Integer = -1
        Public Property CodigoActividad As Integer = -1
        Public Property CodigoTipoActividad As Integer = -1
        Public Property NombreTaller As String = ""
        Public Property NombreActividad As String = ""
        Public Property NombreTipoActividad() As String = ""
        Public Property CodigoPadre() As Integer = -1

        Public Property CodigoRP As String = ""
        Public Property CodigoMarcacionID As Integer = 0
        Public Property ApellidosNombres() As String = ""
        Public Property NombrePadre() As String = ""
        Public Property NombreMadre() As String = ""
        Public Property Tipo As Boolean = False
        Public Property EstadoLaboralID() As Integer = -1
        Public Property EstadoID() As Integer = -1
        Public Property InternoHuellaID() As Integer = -1
        Public Property TipoCapturaDerID() As Integer = -1
        Public Property TipoCapturaIzqID() As Integer = -1
        Public Property BioRegistroVinculado As Boolean = False 'indica si el registro ya fue vinculado al biometrico o se encuentra pendiente
        Public ReadOnly Property EstadoLaboralNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoLaboralID
                    Case 0
                        value = "Inactivo"
                    Case 1
                        value = "Activo"
                End Select

                Return value.ToUpper
            End Get
        End Property
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoID
                    Case 0
                        value = "Inactivo"
                    Case 1
                        value = "Activo"
                End Select

                Return value.ToUpper
            End Get
        End Property
        Public ReadOnly Property ActividadLaboral() As String
            Get
                Dim value As String = ""
                Dim strTip As String = ""
                Dim strAct As String = ""
                Select Case Me.NombreTipoActividad
                    Case "ACTIVIDADES PRODUCTIVAS"
                        strTip = "[Act. Productivas]"
                    Case "ACTIVIDADES DE SOPORTE"
                        strTip = "[Act. de Soporte]"
                    Case "SERVICIOS AD-HONOREN"
                        strTip = "[Serv. AD-H]"
                End Select
                Select Case Me.NombreActividad
                    Case "Actividades en Talleres"
                        strAct = "AT"
                    Case "Actividades de Servicio"
                        strAct = "AS"
                    Case "Actividades M�ltiples"
                        strAct = "AM"
                    Case "Otras Actividades"
                        strAct = "OA"
                    Case "AD-HONOREN"
                        strAct = "AH"
                End Select
                value = Me.NombreTaller & " " & strTip
                Return value    '.ToUpper
            End Get
        End Property
        Public ReadOnly Property TipoNumeroDocumento() As String
            Get
                Dim value As String = ""

                If Me.TipoDocumentoID > 0 Then
                    value = Me.TipoDocumentoNombre
                End If
                If Me.NumeroDocumento.Length > 0 Then
                    If value.Length > 0 Then
                        value = value & " - " & Me.NumeroDocumento
                    Else
                        value = Me.NumeroDocumento
                    End If
                End If

                Return value.ToUpper
            End Get
        End Property
        Public ReadOnly Property EstadoSolicitudNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoID
                    Case 1
                        value = "PENDIENTE"
                    Case 2
                        value = "ENVIADO"
                    Case 3
                        value = "ATENDIDO"
                End Select

                Return value
            End Get
        End Property
        Public Property Observacion As String = ""
        Public ReadOnly Property ObservacionRegistro As String
            Get
                Dim Value As String = "NO"
                If Me.ApellidoPaterno.Length > 0 And Me.ApellidoMaterno.Length > 0 And Me.Nombres.Length > 0 And
                   Me.TipoDocumentoID = 10 And NumeroDocumento.Length = 8 And Me.FechaNacimiento > 0 And Me.SexoID > -1 Then
                    Value = ""
                End If
                Return Value
            End Get
        End Property
        Public ReadOnly Property ObservacionRegistroImg() As System.Drawing.Bitmap
            Get
                If ObservacionRegistro.Trim = "" Then
                    Return My.Resources.check_box_black
                Else
                    Return My.Resources.warning_32x32
                End If
            End Get
        End Property
        Public Property Email() As String = ""
        Public Property EstadoRncID As Integer = -1

        Public ReadOnly Property EstadoRnc As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoRncID
                    Case 1
                        value = "VAL" 'validado
                    Case 2
                        value = "OBS" 'observado
                    Case 3
                        value = "NEC" 'no encontrado
                End Select
                Return value
            End Get
        End Property
        Public Property EstadoEspecificoID As Integer = -1
        'Public Property EstadoEspecificoNombre As Integer = -1
        Public ReadOnly Property EstadoEspecificoNombre As String
            Get
                Dim value As String = ""
                'If Me.CodigoRP = "" Then
                '    value = ""
                'Else
                Select Case Me.EstadoEspecificoID
                    Case 1
                        value = "RECLUIDO"
                    Case 2
                        value = "FUGA"
                    Case 3
                        value = "FALLECIDO"
                    Case 4
                        value = "EN CONDUCCION"
                    Case 5
                        value = "CON LIBERTAD"
                    Case 6
                        value = "EN TRASLADO"
                    Case 7
                        value = "Pendiente de Egreso"
                    Case 0, -1
                        value = "NO REGISTRA"
                    Case Else
                        value = ""
                End Select
                'End If
                Return value
            End Get
        End Property

        Public Property PabellonNombre As String = ""

        Public Property GestorProduccion As String = ""

        Public Property ResponsableLaboral As String = ""

        Public Property FechaInicioBusqueda As Long = 0

        Public Property FechaFinBusqueda As Long = 0


#Region "Ubicacion"
        Private strPenalNombre As String = ""
        Public Property RegionID() As Integer = -1
        Public Property RegionNombre() As String = ""
        Public Property RegionCodigo() As String = ""
        Public Property PenalID() As Integer = -1
        Public Property PenalCodigo() As String = ""
        Public Property PenalNombre() As String
            Get
                Return strPenalNombre.ToUpper
            End Get
            Set(ByVal value As String)
                strPenalNombre = value
            End Set
        End Property
        Public Property RegionRegistroID() As Integer = -1
        Public Property PenalRegistroID() As Integer = -1
        Public Property Cantidad() As Integer = 0
        Public Property Ingresos() As Integer = 0
        Public Property Egresos() As Integer = 0
        Public Property Traslados() As Integer = 0
#End Region
#End Region

#Region "Propiedades_Ubigeo"
        Public Property Departamento() As String = ""
        Public Property Provincia() As String = ""
        Public Property Distrito() As String = ""
        Public ReadOnly Property Ubigeo() As String
            Get
                Dim strValue As String = ""

                strValue = Me.Departamento & "/" & Me.Provincia & "/" & Me.Distrito
                Return Legolas.Components.Cadena.ProperCase(strValue)
            End Get
        End Property
        Public Property Nac_Departamento As String = ""
        Public Property Nac_Provincia As String = ""
        Public Property Nac_Distrito As String = ""
#End Region

#Region "Propiedades_Ingreso"
        Private intIngresoNumero As Integer = -1
        Private strTipoIngreso As String = ""
        Public Property IngresoNumero() As Integer
            Get
                Return intIngresoNumero
            End Get
            Set(ByVal value As Integer)
                intIngresoNumero = value
            End Set
        End Property
        Public Property IngresoAux() As Integer = -1
        Public Property SituacionJuridicaId() As Integer = -1
        Public Property SituacionJuridicaNom() As String = ""
        Public ReadOnly Property SituacionJuridicaReadonly() As String
            Get
                Dim value As String = ""

                Select Case Me.SituacionJuridicaId
                    Case 1
                        value = "PROC."
                    Case 2
                        value = "SENT."
                    Case 3
                        value = "SENT./PROC."
                    Case Else
                        value = ""
                End Select

                Return value

            End Get
        End Property

        Public Property MotivoIngresoID() As Integer = -1
        Public Property MotivoIngresoNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strTipoIngreso)
            End Get
            Set(ByVal value As String)
                strTipoIngreso = value
            End Set
        End Property
        Public Property MotivoTrasladoID() As Integer = -1


        Public Property Fecha() As Long = 0

        Public Property HoraEntrada() As String = ""
        Public Property HoraSalida() As String = ""
        Public Property Tiempo() As Integer = 0
        Public Property FechaInscripcion() As Long = 0
        Public ReadOnly Property FechaDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.Fecha)
            End Get
        End Property
        Public ReadOnly Property FechaNacimientoStr() As String
            Get
                Dim value As String = ""
                If Me.FechaNacimiento > 0 Then
                    Dim fecha As Date = Legolas.Components.FechaHora.FechaString(Me.FechaNacimiento)
                    value = fecha.ToString("yyyyMMdd")
                End If
                Return value
            End Get
        End Property
        Public Property NumeroDocumentoIngreso() As String = ""
        Public Property PenalOrigenNombre() As String = ""
        Public ReadOnly Property Permanencia() As String
            Get
                Dim Valor As String = ""
                If Me.HoraSalida = "00:00:00" Then
                    Valor = "No registra salida"
                Else
                    Dim f1 As DateTime = Me.HoraEntrada
                    Dim f2 As DateTime = Me.HoraSalida
                    Valor = DateDiff(DateInterval.Minute, f1, f2) & " min."
                End If
                Return Valor
            End Get
        End Property
        Public Property FechaIngreso() As Long = 0
        Public ReadOnly Property FechaIngresoString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaIngreso)
            End Get
        End Property
        Public ReadOnly Property FechaInscripcionString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaInscripcion)
            End Get
        End Property
#End Region
#Region "Propiedades_Retiro"
        Public Property MotivoRetiroID() As Integer = -1
        Public Property MotivoRetiroNombre() As String = ""
        Public Property FechaRetiro() As Long = 0
        Public Property DocumentoRetiro() As String = ""
        Public Property FechaDocumento() As Long = 0
        Public Property ObservacionRetiro() As String = ""
        Public ReadOnly Property FechaRetiroString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaRetiro)
            End Get
        End Property
#End Region
#Region "Propiedades_Foto"
        Private intFotoPerfilIzquierdo As Integer = 0
        Private intFotoPerfilFrente As Integer = 0
        Private intFotoPerfilDerecho As Integer = 0
        Public Property FotoPerfilIzquierdo() As Integer = -1
        Public ReadOnly Property FotoPI() As Boolean
            Get
                Dim value As Boolean = False

                If Me.FotoPerfilIzquierdo > 0 Then
                    value = True
                End If

                Return value
            End Get
        End Property
        Public ReadOnly Property FotoIconoPI() As System.Drawing.Image
            Get
                Dim value As System.Drawing.Image = My.Resources.check_box_black

                Select Case Me.CodigoPadre
                    Case 0

                        If Me.FotoPerfilIzquierdo > 0 Then
                            value = My.Resources.check_box_green
                        Else
                            value = My.Resources.check_box_green2
                        End If

                    Case 1
                        value = My.Resources.check_box_black
                End Select

                Return value
            End Get
        End Property
        Public Property FotoPerfilFrente() As Integer = -1
        Public ReadOnly Property FotoPF() As Boolean
            Get
                Dim value As Boolean = False

                If Me.FotoPerfilFrente > 0 Then
                    value = True
                End If

                Return value
            End Get
        End Property
        Public ReadOnly Property FotoIconoPF() As System.Drawing.Image
            Get

                Dim value As System.Drawing.Image = My.Resources.check_box_black

                Select Case Me.CodigoPadre
                    Case 0
                        If Me.FotoPerfilFrente > 0 Then
                            value = My.Resources.check_box_green
                        Else
                            value = My.Resources.check_box_green2
                        End If
                    Case 1
                        value = My.Resources.check_box_black
                End Select

                Return value
            End Get
        End Property
        Public Property FotoPerfilDerecho() As Integer = -1
        Public ReadOnly Property FotoPD() As Boolean
            Get
                Dim value As Boolean = False

                If Me.FotoPerfilDerecho > 0 Then
                    value = True
                End If

                Return value
            End Get
        End Property
        Public ReadOnly Property FotoIconoPD() As System.Drawing.Image
            Get
                Dim value As System.Drawing.Image = My.Resources.check_box_black

                Select Case Me.CodigoPadre

                    Case 0
                        If Me.FotoPerfilDerecho > 0 Then
                            value = My.Resources.check_box_green
                        Else
                            value = My.Resources.check_box_green2
                        End If
                    Case 1
                        value = My.Resources.check_box_black
                End Select

                Return value
            End Get
        End Property
#End Region

#Region "Propiedades_Filtro"
        Public Property NacionalidadExtranjero As Integer = -1
        Public Property DelitoGenericoID As Integer = -1
        Public Property DelitoEspecificoID As Integer = -1
        Public Property IngresoFechaDesde As Long = 0
        Public Property IngresoFechaHasta As Long = 0
        Public Property PenalMultiple As String = ""
        Public Property IDInternoString As String = ""
#End Region

        '------------------ campos auxiliares -------------------------------
        Public Property GrupoUsuarioRaiz As String = ""
        Public Property GrupoUsuario As String = ""
        Public Property GrupoAcceso As String = ""
    End Class
#Region "InternoCol"
    Public Class InternoTallerCol
        Inherits System.Collections.CollectionBase
        Private _enmSortDirection As SortDirection
        Public Sub New()
            _enmSortDirection = SortDirection.Asc
        End Sub
        Public Sub Sort(ByVal sortExpression As String, ByVal sortDirection As SortDirection)
            InnerList.Sort(New Comparer(sortExpression, sortDirection))
        End Sub
        Public Sub Sort(ByVal sortExpression As String)
            InnerList.Sort(New Comparer(sortExpression, _enmSortDirection))
            If _enmSortDirection = SortDirection.Asc Then
                _enmSortDirection = SortDirection.Desc
            Else
                _enmSortDirection = SortDirection.Asc
            End If
        End Sub
        Public Function Add(ByVal value As InternoTaller) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As InternoTaller) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As InternoTaller) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As InternoTaller)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As InternoTaller
            Get
                Return DirectCast(List(index), InternoTaller)
            End Get
            Set(ByVal value As InternoTaller)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As InternoAsistencia)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As InternoAsistencia
            Return MyBase.MemberwiseClone
        End Function
        Public Function toList() As List(Of InternoAsistencia)
            Dim a As New List(Of InternoAsistencia)
            For Each i As InternoAsistencia In InnerList
                a.Add(i)
            Next
            Return a
        End Function
    End Class
#End Region
End Namespace
