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
Imports System.Data
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
'
Namespace ws_pope_sede_tp_config
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="TablaMaestras_ConfigSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class TablaMaestras_Config
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private Cantidad_TestOperationCompleted As System.Threading.SendOrPostCallback
        
        Private Listar_TestOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListarxLicencia_TestOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CantidadOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListarOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ListarxLicenciaOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.APPWebService.My.MySettings.Default.APPWebService_ws_pope_sede_tp_config_TablaMaestras_Config
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
        Public Event Cantidad_TestCompleted As Cantidad_TestCompletedEventHandler
        
        '''<remarks/>
        Public Event Listar_TestCompleted As Listar_TestCompletedEventHandler
        
        '''<remarks/>
        Public Event ListarxLicencia_TestCompleted As ListarxLicencia_TestCompletedEventHandler
        
        '''<remarks/>
        Public Event CantidadCompleted As CantidadCompletedEventHandler
        
        '''<remarks/>
        Public Event ListarCompleted As ListarCompletedEventHandler
        
        '''<remarks/>
        Public Event ListarxLicenciaCompleted As ListarxLicenciaCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Cantidad_Test", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Cantidad_Test(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config) As Integer
            Dim results() As Object = Me.Invoke("Cantidad_Test", New Object() {IDLicencia, TipoTabla})
            Return CType(results(0),Integer)
        End Function
        
        '''<remarks/>
        Public Overloads Sub Cantidad_TestAsync(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config)
            Me.Cantidad_TestAsync(IDLicencia, TipoTabla, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub Cantidad_TestAsync(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config, ByVal userState As Object)
            If (Me.Cantidad_TestOperationCompleted Is Nothing) Then
                Me.Cantidad_TestOperationCompleted = AddressOf Me.OnCantidad_TestOperationCompleted
            End If
            Me.InvokeAsync("Cantidad_Test", New Object() {IDLicencia, TipoTabla}, Me.Cantidad_TestOperationCompleted, userState)
        End Sub
        
        Private Sub OnCantidad_TestOperationCompleted(ByVal arg As Object)
            If (Not (Me.Cantidad_TestCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent Cantidad_TestCompleted(Me, New Cantidad_TestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Listar_Test", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Listar_Test(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("Listar_Test", New Object() {IDLicencia, TipoTabla})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Overloads Sub Listar_TestAsync(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config)
            Me.Listar_TestAsync(IDLicencia, TipoTabla, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub Listar_TestAsync(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config, ByVal userState As Object)
            If (Me.Listar_TestOperationCompleted Is Nothing) Then
                Me.Listar_TestOperationCompleted = AddressOf Me.OnListar_TestOperationCompleted
            End If
            Me.InvokeAsync("Listar_Test", New Object() {IDLicencia, TipoTabla}, Me.Listar_TestOperationCompleted, userState)
        End Sub
        
        Private Sub OnListar_TestOperationCompleted(ByVal arg As Object)
            If (Not (Me.Listar_TestCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent Listar_TestCompleted(Me, New Listar_TestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListarxLicencia_Test", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ListarxLicencia_Test(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("ListarxLicencia_Test", New Object() {IDLicencia, TipoTabla})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListarxLicencia_TestAsync(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config)
            Me.ListarxLicencia_TestAsync(IDLicencia, TipoTabla, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListarxLicencia_TestAsync(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config, ByVal userState As Object)
            If (Me.ListarxLicencia_TestOperationCompleted Is Nothing) Then
                Me.ListarxLicencia_TestOperationCompleted = AddressOf Me.OnListarxLicencia_TestOperationCompleted
            End If
            Me.InvokeAsync("ListarxLicencia_Test", New Object() {IDLicencia, TipoTabla}, Me.ListarxLicencia_TestOperationCompleted, userState)
        End Sub
        
        Private Sub OnListarxLicencia_TestOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListarxLicencia_TestCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListarxLicencia_TestCompleted(Me, New ListarxLicencia_TestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Cantidad", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Cantidad(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config, ByRef MensajeError As String) As Integer
            Dim results() As Object = Me.Invoke("Cantidad", New Object() {IDLicencia, TipoTabla, MensajeError})
            MensajeError = CType(results(1),String)
            Return CType(results(0),Integer)
        End Function
        
        '''<remarks/>
        Public Overloads Sub CantidadAsync(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config, ByVal MensajeError As String)
            Me.CantidadAsync(IDLicencia, TipoTabla, MensajeError, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CantidadAsync(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config, ByVal MensajeError As String, ByVal userState As Object)
            If (Me.CantidadOperationCompleted Is Nothing) Then
                Me.CantidadOperationCompleted = AddressOf Me.OnCantidadOperationCompleted
            End If
            Me.InvokeAsync("Cantidad", New Object() {IDLicencia, TipoTabla, MensajeError}, Me.CantidadOperationCompleted, userState)
        End Sub
        
        Private Sub OnCantidadOperationCompleted(ByVal arg As Object)
            If (Not (Me.CantidadCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CantidadCompleted(Me, New CantidadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Listar", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Listar(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config, ByRef MensajeError As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("Listar", New Object() {IDLicencia, TipoTabla, MensajeError})
            MensajeError = CType(results(1),String)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListarAsync(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config, ByVal MensajeError As String)
            Me.ListarAsync(IDLicencia, TipoTabla, MensajeError, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListarAsync(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config, ByVal MensajeError As String, ByVal userState As Object)
            If (Me.ListarOperationCompleted Is Nothing) Then
                Me.ListarOperationCompleted = AddressOf Me.OnListarOperationCompleted
            End If
            Me.InvokeAsync("Listar", New Object() {IDLicencia, TipoTabla, MensajeError}, Me.ListarOperationCompleted, userState)
        End Sub
        
        Private Sub OnListarOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListarCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListarCompleted(Me, New ListarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListarxLicencia", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ListarxLicencia(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config, ByRef MensajeError As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("ListarxLicencia", New Object() {IDLicencia, TipoTabla, MensajeError})
            MensajeError = CType(results(1),String)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Overloads Sub ListarxLicenciaAsync(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config, ByVal MensajeError As String)
            Me.ListarxLicenciaAsync(IDLicencia, TipoTabla, MensajeError, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ListarxLicenciaAsync(ByVal IDLicencia As Integer, ByVal TipoTabla As TipoTabla_Config, ByVal MensajeError As String, ByVal userState As Object)
            If (Me.ListarxLicenciaOperationCompleted Is Nothing) Then
                Me.ListarxLicenciaOperationCompleted = AddressOf Me.OnListarxLicenciaOperationCompleted
            End If
            Me.InvokeAsync("ListarxLicencia", New Object() {IDLicencia, TipoTabla, MensajeError}, Me.ListarxLicenciaOperationCompleted, userState)
        End Sub
        
        Private Sub OnListarxLicenciaOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListarxLicenciaCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListarxLicenciaCompleted(Me, New ListarxLicenciaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Public Enum TipoTabla_Config
        
        '''<remarks/>
        Ninguno
        
        '''<remarks/>
        Licencia
        
        '''<remarks/>
        LicenciaDetalle
        
        '''<remarks/>
        Modulo
        
        '''<remarks/>
        Usuario
        
        '''<remarks/>
        UsuarioModulo
        
        '''<remarks/>
        UsuarioRegion
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")>  _
    Public Delegate Sub Cantidad_TestCompletedEventHandler(ByVal sender As Object, ByVal e As Cantidad_TestCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class Cantidad_TestCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Integer
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Integer)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")>  _
    Public Delegate Sub Listar_TestCompletedEventHandler(ByVal sender As Object, ByVal e As Listar_TestCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class Listar_TestCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As System.Data.DataSet
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),System.Data.DataSet)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")>  _
    Public Delegate Sub ListarxLicencia_TestCompletedEventHandler(ByVal sender As Object, ByVal e As ListarxLicencia_TestCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class ListarxLicencia_TestCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As System.Data.DataSet
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),System.Data.DataSet)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")>  _
    Public Delegate Sub CantidadCompletedEventHandler(ByVal sender As Object, ByVal e As CantidadCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class CantidadCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Integer
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Integer)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property MensajeError() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),String)
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
        Public ReadOnly Property Result() As System.Data.DataSet
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),System.Data.DataSet)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property MensajeError() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")>  _
    Public Delegate Sub ListarxLicenciaCompletedEventHandler(ByVal sender As Object, ByVal e As ListarxLicenciaCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class ListarxLicenciaCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As System.Data.DataSet
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),System.Data.DataSet)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property MensajeError() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),String)
            End Get
        End Property
    End Class
End Namespace
