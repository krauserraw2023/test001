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
Namespace ws_migraciones_consulta
    
    'CODEGEN: No se controló el elemento de extensión WSDL opcional 'PolicyReference' del espacio de nombres 'http://schemas.xmlsoap.org/ws/2004/09/policy'.
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="BasicHttpsBinding_IMigraciones", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class Service1
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private Consultar_extranjeroOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.APPWebService.My.MySettings.Default.APPWebService_ws_migraciones_consulta_Service1
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
        Public Event Consultar_extranjeroCompleted As Consultar_extranjeroCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IMigraciones/Consultar_extranjero", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Consultar_extranjero(ByVal tipo_doc As Integer, <System.Xml.Serialization.XmlIgnoreAttribute()> ByVal tipo_docSpecified As Boolean, <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ByVal NumDoc As String) As <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ResultEOfMigracionesE44rCQrf7
            Dim results() As Object = Me.Invoke("Consultar_extranjero", New Object() {tipo_doc, tipo_docSpecified, NumDoc})
            Return CType(results(0),ResultEOfMigracionesE44rCQrf7)
        End Function
        
        '''<remarks/>
        Public Overloads Sub Consultar_extranjeroAsync(ByVal tipo_doc As Integer, ByVal tipo_docSpecified As Boolean, ByVal NumDoc As String)
            Me.Consultar_extranjeroAsync(tipo_doc, tipo_docSpecified, NumDoc, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub Consultar_extranjeroAsync(ByVal tipo_doc As Integer, ByVal tipo_docSpecified As Boolean, ByVal NumDoc As String, ByVal userState As Object)
            If (Me.Consultar_extranjeroOperationCompleted Is Nothing) Then
                Me.Consultar_extranjeroOperationCompleted = AddressOf Me.OnConsultar_extranjeroOperationCompleted
            End If
            Me.InvokeAsync("Consultar_extranjero", New Object() {tipo_doc, tipo_docSpecified, NumDoc}, Me.Consultar_extranjeroOperationCompleted, userState)
        End Sub
        
        Private Sub OnConsultar_extranjeroOperationCompleted(ByVal arg As Object)
            If (Not (Me.Consultar_extranjeroCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent Consultar_extranjeroCompleted(Me, New Consultar_extranjeroCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/WSMigraciones.Entity")>  _
    Partial Public Class ResultEOfMigracionesE44rCQrf7
        
        Private error_MensajeField As String
        
        Private error_codField As Integer
        
        Private error_codFieldSpecified As Boolean
        
        Private resultadoField As MigracionesE
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property Error_Mensaje() As String
            Get
                Return Me.error_MensajeField
            End Get
            Set
                Me.error_MensajeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Error_cod() As Integer
            Get
                Return Me.error_codField
            End Get
            Set
                Me.error_codField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property Error_codSpecified() As Boolean
            Get
                Return Me.error_codFieldSpecified
            End Get
            Set
                Me.error_codFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property Resultado() As MigracionesE
            Get
                Return Me.resultadoField
            End Get
            Set
                Me.resultadoField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/WSMigraciones.Entity")>  _
    Partial Public Class MigracionesE
        
        Private apeMaternoField As String
        
        Private apePaternoField As String
        
        Private calidadMigratoriasField As String
        
        Private domicilioActualField As String
        
        Private fecha_NacimientoField As String
        
        Private generoField As String
        
        Private nombresField As String
        
        Private numeroCEField As String
        
        Private numero_CPPField As String
        
        Private numero_PTPField As String
        
        Private paisNacionalidadField As String
        
        Private ubicacionActualField As String
        
        Private fotoField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property ApeMaterno() As String
            Get
                Return Me.apeMaternoField
            End Get
            Set
                Me.apeMaternoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property ApePaterno() As String
            Get
                Return Me.apePaternoField
            End Get
            Set
                Me.apePaternoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property CalidadMigratorias() As String
            Get
                Return Me.calidadMigratoriasField
            End Get
            Set
                Me.calidadMigratoriasField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property DomicilioActual() As String
            Get
                Return Me.domicilioActualField
            End Get
            Set
                Me.domicilioActualField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property Fecha_Nacimiento() As String
            Get
                Return Me.fecha_NacimientoField
            End Get
            Set
                Me.fecha_NacimientoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property Genero() As String
            Get
                Return Me.generoField
            End Get
            Set
                Me.generoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property Nombres() As String
            Get
                Return Me.nombresField
            End Get
            Set
                Me.nombresField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property NumeroCE() As String
            Get
                Return Me.numeroCEField
            End Get
            Set
                Me.numeroCEField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property Numero_CPP() As String
            Get
                Return Me.numero_CPPField
            End Get
            Set
                Me.numero_CPPField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property Numero_PTP() As String
            Get
                Return Me.numero_PTPField
            End Get
            Set
                Me.numero_PTPField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property PaisNacionalidad() As String
            Get
                Return Me.paisNacionalidadField
            End Get
            Set
                Me.paisNacionalidadField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property UbicacionActual() As String
            Get
                Return Me.ubicacionActualField
            End Get
            Set
                Me.ubicacionActualField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property foto() As String
            Get
                Return Me.fotoField
            End Get
            Set
                Me.fotoField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")>  _
    Public Delegate Sub Consultar_extranjeroCompletedEventHandler(ByVal sender As Object, ByVal e As Consultar_extranjeroCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class Consultar_extranjeroCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As ResultEOfMigracionesE44rCQrf7
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),ResultEOfMigracionesE44rCQrf7)
            End Get
        End Property
    End Class
End Namespace
