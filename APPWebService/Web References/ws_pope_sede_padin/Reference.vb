﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
'
Namespace ws_pope_sede_padin
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="PadinSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class Padin
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private HelloWorldOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GrabarAnulacionOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GrabarRecepcionOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GrabarRespuestaOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListarOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.APPWebService.My.MySettings.Default.APPWebService_ws_pope_sede_padin_Padin
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event HelloWorldCompleted As HelloWorldCompletedEventHandler
        
        '''<remarks/>
        Public Event GrabarAnulacionCompleted As GrabarAnulacionCompletedEventHandler
        
        '''<remarks/>
        Public Event GrabarRecepcionCompleted As GrabarRecepcionCompletedEventHandler
        
        '''<remarks/>
        Public Event GrabarRespuestaCompleted As GrabarRespuestaCompletedEventHandler
        
        '''<remarks/>
        Public Event ListarCompleted As ListarCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function HelloWorld() As String
            Dim results() As Object = Me.Invoke("HelloWorld", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub HelloWorldAsync()
            Me.HelloWorldAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub HelloWorldAsync(ByVal userState As Object)
            If (Me.HelloWorldOperationCompleted Is Nothing) Then
                Me.HelloWorldOperationCompleted = AddressOf Me.OnHelloWorldOperationCompleted
            End If
            Me.InvokeAsync("HelloWorld", New Object(-1) {}, Me.HelloWorldOperationCompleted, userState)
        End Sub
        
        Private Sub OnHelloWorldOperationCompleted(ByVal arg As Object)
            If (Not (Me.HelloWorldCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent HelloWorldCompleted(Me, New HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GrabarAnulacion", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GrabarAnulacion(ByVal objDto As DTO_PadinAnulacion_Sol) As Long
            Dim results() As Object = Me.Invoke("GrabarAnulacion", New Object() {objDto})
            Return CType(results(0),Long)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GrabarAnulacionAsync(ByVal objDto As DTO_PadinAnulacion_Sol)
            Me.GrabarAnulacionAsync(objDto, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GrabarAnulacionAsync(ByVal objDto As DTO_PadinAnulacion_Sol, ByVal userState As Object)
            If (Me.GrabarAnulacionOperationCompleted Is Nothing) Then
                Me.GrabarAnulacionOperationCompleted = AddressOf Me.OnGrabarAnulacionOperationCompleted
            End If
            Me.InvokeAsync("GrabarAnulacion", New Object() {objDto}, Me.GrabarAnulacionOperationCompleted, userState)
        End Sub
        
        Private Sub OnGrabarAnulacionOperationCompleted(ByVal arg As Object)
            If (Not (Me.GrabarAnulacionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GrabarAnulacionCompleted(Me, New GrabarAnulacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GrabarRecepcion", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GrabarRecepcion(ByVal objDto As DTO_PadinRecepcion_Sol) As Long
            Dim results() As Object = Me.Invoke("GrabarRecepcion", New Object() {objDto})
            Return CType(results(0),Long)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GrabarRecepcionAsync(ByVal objDto As DTO_PadinRecepcion_Sol)
            Me.GrabarRecepcionAsync(objDto, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GrabarRecepcionAsync(ByVal objDto As DTO_PadinRecepcion_Sol, ByVal userState As Object)
            If (Me.GrabarRecepcionOperationCompleted Is Nothing) Then
                Me.GrabarRecepcionOperationCompleted = AddressOf Me.OnGrabarRecepcionOperationCompleted
            End If
            Me.InvokeAsync("GrabarRecepcion", New Object() {objDto}, Me.GrabarRecepcionOperationCompleted, userState)
        End Sub
        
        Private Sub OnGrabarRecepcionOperationCompleted(ByVal arg As Object)
            If (Not (Me.GrabarRecepcionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GrabarRecepcionCompleted(Me, New GrabarRecepcionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GrabarRespuesta", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GrabarRespuesta(ByVal objDto As DTO_PadinRespuesta_Sol) As Long
            Dim results() As Object = Me.Invoke("GrabarRespuesta", New Object() {objDto})
            Return CType(results(0),Long)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GrabarRespuestaAsync(ByVal objDto As DTO_PadinRespuesta_Sol)
            Me.GrabarRespuestaAsync(objDto, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GrabarRespuestaAsync(ByVal objDto As DTO_PadinRespuesta_Sol, ByVal userState As Object)
            If (Me.GrabarRespuestaOperationCompleted Is Nothing) Then
                Me.GrabarRespuestaOperationCompleted = AddressOf Me.OnGrabarRespuestaOperationCompleted
            End If
            Me.InvokeAsync("GrabarRespuesta", New Object() {objDto}, Me.GrabarRespuestaOperationCompleted, userState)
        End Sub
        
        Private Sub OnGrabarRespuestaOperationCompleted(ByVal arg As Object)
            If (Not (Me.GrabarRespuestaCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GrabarRespuestaCompleted(Me, New GrabarRespuestaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Listar", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Listar(ByVal objDtoCol() As DTO_Padin_ListarSol) As DTO_Padin_ListarRpta()
            Dim results() As Object = Me.Invoke("Listar", New Object() {objDtoCol})
            Return CType(results(0),DTO_Padin_ListarRpta())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListarAsync(ByVal objDtoCol() As DTO_Padin_ListarSol)
            Me.ListarAsync(objDtoCol, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListarAsync(ByVal objDtoCol() As DTO_Padin_ListarSol, ByVal userState As Object)
            If (Me.ListarOperationCompleted Is Nothing) Then
                Me.ListarOperationCompleted = AddressOf Me.OnListarOperationCompleted
            End If
            Me.InvokeAsync("Listar", New Object() {objDtoCol}, Me.ListarOperationCompleted, userState)
        End Sub
        
        Private Sub OnListarOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListarCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListarCompleted(Me, New ListarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class DTO_PadinAnulacion_Sol
        Inherits DTO_PadinRespuesta_Sol
    End Class
    
    '''<remarks/>
    <System.Xml.Serialization.XmlIncludeAttribute(GetType(DTO_PadinAnulacion_Sol)),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class DTO_PadinRespuesta_Sol
        
        Private iDRowPadinField As Long
        
        Private iDRegionField As Integer
        
        Private iDPenalField As Integer
        
        Private fechaRespuestaField As Long
        
        Private iDEstadoField As Integer
        
        Private iDUsuarioField As Integer
        
        Private usuarioApeNomField As String
        
        Private obsAnulacionField As String
        
        '''<remarks/>
        Public Property IDRowPadin() As Long
            Get
                Return Me.iDRowPadinField
            End Get
            Set
                Me.iDRowPadinField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IDRegion() As Integer
            Get
                Return Me.iDRegionField
            End Get
            Set
                Me.iDRegionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IDPenal() As Integer
            Get
                Return Me.iDPenalField
            End Get
            Set
                Me.iDPenalField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property FechaRespuesta() As Long
            Get
                Return Me.fechaRespuestaField
            End Get
            Set
                Me.fechaRespuestaField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IDEstado() As Integer
            Get
                Return Me.iDEstadoField
            End Get
            Set
                Me.iDEstadoField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IDUsuario() As Integer
            Get
                Return Me.iDUsuarioField
            End Get
            Set
                Me.iDUsuarioField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property UsuarioApeNom() As String
            Get
                Return Me.usuarioApeNomField
            End Get
            Set
                Me.usuarioApeNomField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ObsAnulacion() As String
            Get
                Return Me.obsAnulacionField
            End Get
            Set
                Me.obsAnulacionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class DTO_Padin_ListarRpta
        
        Private iDPadinField As Integer
        
        Private iDEstadoField As Integer
        
        Private iDEstadoSolField As Integer
        
        Private fechaRecepcionField As Long
        
        Private fechaRespuestaField As Long
        
        Private iDUsuarioField As Integer
        
        Private usuarioApeNomField As String
        
        Private obsAnulacionField As String
        
        '''<remarks/>
        Public Property IDPadin() As Integer
            Get
                Return Me.iDPadinField
            End Get
            Set
                Me.iDPadinField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IDEstado() As Integer
            Get
                Return Me.iDEstadoField
            End Get
            Set
                Me.iDEstadoField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IDEstadoSol() As Integer
            Get
                Return Me.iDEstadoSolField
            End Get
            Set
                Me.iDEstadoSolField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property FechaRecepcion() As Long
            Get
                Return Me.fechaRecepcionField
            End Get
            Set
                Me.fechaRecepcionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property FechaRespuesta() As Long
            Get
                Return Me.fechaRespuestaField
            End Get
            Set
                Me.fechaRespuestaField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IDUsuario() As Integer
            Get
                Return Me.iDUsuarioField
            End Get
            Set
                Me.iDUsuarioField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property UsuarioApeNom() As String
            Get
                Return Me.usuarioApeNomField
            End Get
            Set
                Me.usuarioApeNomField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ObsAnulacion() As String
            Get
                Return Me.obsAnulacionField
            End Get
            Set
                Me.obsAnulacionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class DTO_Padin_ListarSol
        
        Private iDPadinField As Long
        
        Private iDRowPadinField As Long
        
        Private iDRegionField As Integer
        
        Private iDPenalField As Integer
        
        Private iDEstadoField As Integer
        
        '''<remarks/>
        Public Property IDPadin() As Long
            Get
                Return Me.iDPadinField
            End Get
            Set
                Me.iDPadinField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IDRowPadin() As Long
            Get
                Return Me.iDRowPadinField
            End Get
            Set
                Me.iDRowPadinField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IDRegion() As Integer
            Get
                Return Me.iDRegionField
            End Get
            Set
                Me.iDRegionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IDPenal() As Integer
            Get
                Return Me.iDPenalField
            End Get
            Set
                Me.iDPenalField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IDEstado() As Integer
            Get
                Return Me.iDEstadoField
            End Get
            Set
                Me.iDEstadoField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class DTO_PadinRecepcion_Sol
        
        Private iDRowPadinField As Long
        
        Private iDRegionField As Integer
        
        Private iDPenalField As Integer
        
        Private fechaRecepcionField As Long
        
        Private iDEstadoField As Integer
        
        '''<remarks/>
        Public Property IDRowPadin() As Long
            Get
                Return Me.iDRowPadinField
            End Get
            Set
                Me.iDRowPadinField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IDRegion() As Integer
            Get
                Return Me.iDRegionField
            End Get
            Set
                Me.iDRegionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IDPenal() As Integer
            Get
                Return Me.iDPenalField
            End Get
            Set
                Me.iDPenalField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property FechaRecepcion() As Long
            Get
                Return Me.fechaRecepcionField
            End Get
            Set
                Me.fechaRecepcionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property IDEstado() As Integer
            Get
                Return Me.iDEstadoField
            End Get
            Set
                Me.iDEstadoField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")>  _
    Public Delegate Sub HelloWorldCompletedEventHandler(ByVal sender As Object, ByVal e As HelloWorldCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class HelloWorldCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")>  _
    Public Delegate Sub GrabarAnulacionCompletedEventHandler(ByVal sender As Object, ByVal e As GrabarAnulacionCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GrabarAnulacionCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Long
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Long)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")>  _
    Public Delegate Sub GrabarRecepcionCompletedEventHandler(ByVal sender As Object, ByVal e As GrabarRecepcionCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GrabarRecepcionCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Long
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Long)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")>  _
    Public Delegate Sub GrabarRespuestaCompletedEventHandler(ByVal sender As Object, ByVal e As GrabarRespuestaCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GrabarRespuestaCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Long
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Long)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")>  _
    Public Delegate Sub ListarCompletedEventHandler(ByVal sender As Object, ByVal e As ListarCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class ListarCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As DTO_Padin_ListarRpta()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),DTO_Padin_ListarRpta())
            End Get
        End Property
    End Class
End Namespace
