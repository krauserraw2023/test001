﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace ws_pope_ep_trat_asist_tall
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="ListaGrupoAcceso", [Namespace]:="http://schemas.datacontract.org/2004/07/ws_biostar_2.Entity"),  _
     System.SerializableAttribute()>  _
    Partial Public Class ListaGrupoAcceso
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private recordsField() As ws_pope_ep_trat_asist_tall.GrupoAcceso
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property records() As ws_pope_ep_trat_asist_tall.GrupoAcceso()
            Get
                Return Me.recordsField
            End Get
            Set
                If (Object.ReferenceEquals(Me.recordsField, value) <> true) Then
                    Me.recordsField = value
                    Me.RaisePropertyChanged("records")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="GrupoAcceso", [Namespace]:="http://schemas.datacontract.org/2004/07/ws_biostar_2.Entity"),  _
     System.SerializableAttribute()>  _
    Partial Public Class GrupoAcceso
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private idField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private included_by_user_groupField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private nameField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property id() As Integer
            Get
                Return Me.idField
            End Get
            Set
                If (Me.idField.Equals(value) <> true) Then
                    Me.idField = value
                    Me.RaisePropertyChanged("id")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property included_by_user_group() As String
            Get
                Return Me.included_by_user_groupField
            End Get
            Set
                If (Object.ReferenceEquals(Me.included_by_user_groupField, value) <> true) Then
                    Me.included_by_user_groupField = value
                    Me.RaisePropertyChanged("included_by_user_group")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property name() As String
            Get
                Return Me.nameField
            End Get
            Set
                If (Object.ReferenceEquals(Me.nameField, value) <> true) Then
                    Me.nameField = value
                    Me.RaisePropertyChanged("name")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="ListaUsuarioGrupo", [Namespace]:="http://schemas.datacontract.org/2004/07/ws_biostar_2.Entity"),  _
     System.SerializableAttribute()>  _
    Partial Public Class ListaUsuarioGrupo
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private recordsField() As ws_pope_ep_trat_asist_tall.UsuarioGrupo
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property records() As ws_pope_ep_trat_asist_tall.UsuarioGrupo()
            Get
                Return Me.recordsField
            End Get
            Set
                If (Object.ReferenceEquals(Me.recordsField, value) <> true) Then
                    Me.recordsField = value
                    Me.RaisePropertyChanged("records")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="UsuarioGrupo", [Namespace]:="http://schemas.datacontract.org/2004/07/ws_biostar_2.Entity"),  _
     System.SerializableAttribute()>  _
    Partial Public Class UsuarioGrupo
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private idField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private nameField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private user_totalField As Integer
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property id() As Integer
            Get
                Return Me.idField
            End Get
            Set
                If (Me.idField.Equals(value) <> true) Then
                    Me.idField = value
                    Me.RaisePropertyChanged("id")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property name() As String
            Get
                Return Me.nameField
            End Get
            Set
                If (Object.ReferenceEquals(Me.nameField, value) <> true) Then
                    Me.nameField = value
                    Me.RaisePropertyChanged("name")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property user_total() As Integer
            Get
                Return Me.user_totalField
            End Get
            Set
                If (Me.user_totalField.Equals(value) <> true) Then
                    Me.user_totalField = value
                    Me.RaisePropertyChanged("user_total")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="ListaUsuarioAPI", [Namespace]:="http://schemas.datacontract.org/2004/07/ws_biostar_2.Entity"),  _
     System.SerializableAttribute()>  _
    Partial Public Class ListaUsuarioAPI
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private recordsField() As ws_pope_ep_trat_asist_tall.UsuarioAPI
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property records() As ws_pope_ep_trat_asist_tall.UsuarioAPI()
            Get
                Return Me.recordsField
            End Get
            Set
                If (Object.ReferenceEquals(Me.recordsField, value) <> true) Then
                    Me.recordsField = value
                    Me.RaisePropertyChanged("records")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="UsuarioAPI", [Namespace]:="http://schemas.datacontract.org/2004/07/ws_biostar_2.Entity"),  _
     System.SerializableAttribute()>  _
    Partial Public Class UsuarioAPI
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private access_groupsField() As ws_pope_ep_trat_asist_tall.GrupoAcceso
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private emailField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private expiry_datetimeField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private nameField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private security_levelField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private start_datetimeField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private statusField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private user_groupField As ws_pope_ep_trat_asist_tall.UsuarioGrupo
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private user_idField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property access_groups() As ws_pope_ep_trat_asist_tall.GrupoAcceso()
            Get
                Return Me.access_groupsField
            End Get
            Set
                If (Object.ReferenceEquals(Me.access_groupsField, value) <> true) Then
                    Me.access_groupsField = value
                    Me.RaisePropertyChanged("access_groups")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property email() As String
            Get
                Return Me.emailField
            End Get
            Set
                If (Object.ReferenceEquals(Me.emailField, value) <> true) Then
                    Me.emailField = value
                    Me.RaisePropertyChanged("email")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property expiry_datetime() As String
            Get
                Return Me.expiry_datetimeField
            End Get
            Set
                If (Object.ReferenceEquals(Me.expiry_datetimeField, value) <> true) Then
                    Me.expiry_datetimeField = value
                    Me.RaisePropertyChanged("expiry_datetime")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property name() As String
            Get
                Return Me.nameField
            End Get
            Set
                If (Object.ReferenceEquals(Me.nameField, value) <> true) Then
                    Me.nameField = value
                    Me.RaisePropertyChanged("name")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property security_level() As String
            Get
                Return Me.security_levelField
            End Get
            Set
                If (Object.ReferenceEquals(Me.security_levelField, value) <> true) Then
                    Me.security_levelField = value
                    Me.RaisePropertyChanged("security_level")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property start_datetime() As String
            Get
                Return Me.start_datetimeField
            End Get
            Set
                If (Object.ReferenceEquals(Me.start_datetimeField, value) <> true) Then
                    Me.start_datetimeField = value
                    Me.RaisePropertyChanged("start_datetime")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property status() As String
            Get
                Return Me.statusField
            End Get
            Set
                If (Object.ReferenceEquals(Me.statusField, value) <> true) Then
                    Me.statusField = value
                    Me.RaisePropertyChanged("status")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property user_group() As ws_pope_ep_trat_asist_tall.UsuarioGrupo
            Get
                Return Me.user_groupField
            End Get
            Set
                If (Object.ReferenceEquals(Me.user_groupField, value) <> true) Then
                    Me.user_groupField = value
                    Me.RaisePropertyChanged("user_group")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property user_id() As String
            Get
                Return Me.user_idField
            End Get
            Set
                If (Object.ReferenceEquals(Me.user_idField, value) <> true) Then
                    Me.user_idField = value
                    Me.RaisePropertyChanged("user_id")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ws_pope_ep_trat_asist_tall.IApiBiostar")>  _
    Public Interface IApiBiostar
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IApiBiostar/GetData", ReplyAction:="http://tempuri.org/IApiBiostar/GetDataResponse")>  _
        Function GetData(ByVal value As Integer) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IApiBiostar/Login_API", ReplyAction:="http://tempuri.org/IApiBiostar/Login_APIResponse")>  _
        Function Login_API(<System.Runtime.InteropServices.OutAttribute()> ByRef [error] As String, ByVal conexion As String, ByVal _ApiIp As String, ByVal _subdominio As String, ByVal _password As String, ByVal _userid As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IApiBiostar/CargaUsuarioSupremaV2", ReplyAction:="http://tempuri.org/IApiBiostar/CargaUsuarioSupremaV2Response")>  _
        Function CargaUsuarioSupremaV2(<System.Runtime.InteropServices.OutAttribute()> ByRef [error] As String, ByVal IDUsuario As String, ByVal Nombre As String, ByVal GrupoAcceso As String, ByVal GrupoUsuario As String, ByVal Email As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IApiBiostar/EliminarUsuario", ReplyAction:="http://tempuri.org/IApiBiostar/EliminarUsuarioResponse")>  _
        Function EliminarUsuario(<System.Runtime.InteropServices.OutAttribute()> ByRef [error] As String, ByVal Usuario As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IApiBiostar/DesHabUsuarioSupremaV2", ReplyAction:="http://tempuri.org/IApiBiostar/DesHabUsuarioSupremaV2Response")>  _
        Function DesHabUsuarioSupremaV2(<System.Runtime.InteropServices.OutAttribute()> ByRef [error] As String, ByVal pUsuario As String, ByVal pTipo As Integer) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IApiBiostar/CambiarCodigo", ReplyAction:="http://tempuri.org/IApiBiostar/CambiarCodigoResponse")>  _
        Function CambiarCodigo(<System.Runtime.InteropServices.OutAttribute()> ByRef [error] As String, ByVal IDUsuarioNue As String, ByVal IDUsuarioAnt As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IApiBiostar/ListarGrupoAcceso", ReplyAction:="http://tempuri.org/IApiBiostar/ListarGrupoAccesoResponse")>  _
        Function ListarGrupoAcceso(<System.Runtime.InteropServices.OutAttribute()> ByRef [error] As String) As ws_pope_ep_trat_asist_tall.ListaGrupoAcceso
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IApiBiostar/ListarGrupoUsuario", ReplyAction:="http://tempuri.org/IApiBiostar/ListarGrupoUsuarioResponse")>  _
        Function ListarGrupoUsuario(<System.Runtime.InteropServices.OutAttribute()> ByRef [error] As String) As ws_pope_ep_trat_asist_tall.ListaUsuarioGrupo
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IApiBiostar/test", ReplyAction:="http://tempuri.org/IApiBiostar/testResponse")>  _
        Function test() As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IApiBiostar/ListarUsuarioAPI", ReplyAction:="http://tempuri.org/IApiBiostar/ListarUsuarioAPIResponse")>  _
        Function ListarUsuarioAPI(<System.Runtime.InteropServices.OutAttribute()> ByRef [error] As String) As ws_pope_ep_trat_asist_tall.ListaUsuarioAPI
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IApiBiostarChannel
        Inherits ws_pope_ep_trat_asist_tall.IApiBiostar, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ApiBiostarClient
        Inherits System.ServiceModel.ClientBase(Of ws_pope_ep_trat_asist_tall.IApiBiostar)
        Implements ws_pope_ep_trat_asist_tall.IApiBiostar
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function GetData(ByVal value As Integer) As String Implements ws_pope_ep_trat_asist_tall.IApiBiostar.GetData
            Return MyBase.Channel.GetData(value)
        End Function
        
        Public Function Login_API(<System.Runtime.InteropServices.OutAttribute()> ByRef [error] As String, ByVal conexion As String, ByVal _ApiIp As String, ByVal _subdominio As String, ByVal _password As String, ByVal _userid As String) As Boolean Implements ws_pope_ep_trat_asist_tall.IApiBiostar.Login_API
            Return MyBase.Channel.Login_API([error], conexion, _ApiIp, _subdominio, _password, _userid)
        End Function
        
        Public Function CargaUsuarioSupremaV2(<System.Runtime.InteropServices.OutAttribute()> ByRef [error] As String, ByVal IDUsuario As String, ByVal Nombre As String, ByVal GrupoAcceso As String, ByVal GrupoUsuario As String, ByVal Email As String) As Boolean Implements ws_pope_ep_trat_asist_tall.IApiBiostar.CargaUsuarioSupremaV2
            Return MyBase.Channel.CargaUsuarioSupremaV2([error], IDUsuario, Nombre, GrupoAcceso, GrupoUsuario, Email)
        End Function
        
        Public Function EliminarUsuario(<System.Runtime.InteropServices.OutAttribute()> ByRef [error] As String, ByVal Usuario As String) As Boolean Implements ws_pope_ep_trat_asist_tall.IApiBiostar.EliminarUsuario
            Return MyBase.Channel.EliminarUsuario([error], Usuario)
        End Function
        
        Public Function DesHabUsuarioSupremaV2(<System.Runtime.InteropServices.OutAttribute()> ByRef [error] As String, ByVal pUsuario As String, ByVal pTipo As Integer) As Boolean Implements ws_pope_ep_trat_asist_tall.IApiBiostar.DesHabUsuarioSupremaV2
            Return MyBase.Channel.DesHabUsuarioSupremaV2([error], pUsuario, pTipo)
        End Function
        
        Public Function CambiarCodigo(<System.Runtime.InteropServices.OutAttribute()> ByRef [error] As String, ByVal IDUsuarioNue As String, ByVal IDUsuarioAnt As String) As Boolean Implements ws_pope_ep_trat_asist_tall.IApiBiostar.CambiarCodigo
            Return MyBase.Channel.CambiarCodigo([error], IDUsuarioNue, IDUsuarioAnt)
        End Function
        
        Public Function ListarGrupoAcceso(<System.Runtime.InteropServices.OutAttribute()> ByRef [error] As String) As ws_pope_ep_trat_asist_tall.ListaGrupoAcceso Implements ws_pope_ep_trat_asist_tall.IApiBiostar.ListarGrupoAcceso
            Return MyBase.Channel.ListarGrupoAcceso([error])
        End Function
        
        Public Function ListarGrupoUsuario(<System.Runtime.InteropServices.OutAttribute()> ByRef [error] As String) As ws_pope_ep_trat_asist_tall.ListaUsuarioGrupo Implements ws_pope_ep_trat_asist_tall.IApiBiostar.ListarGrupoUsuario
            Return MyBase.Channel.ListarGrupoUsuario([error])
        End Function
        
        Public Function test() As String Implements ws_pope_ep_trat_asist_tall.IApiBiostar.test
            Return MyBase.Channel.test
        End Function
        
        Public Function ListarUsuarioAPI(<System.Runtime.InteropServices.OutAttribute()> ByRef [error] As String) As ws_pope_ep_trat_asist_tall.ListaUsuarioAPI Implements ws_pope_ep_trat_asist_tall.IApiBiostar.ListarUsuarioAPI
            Return MyBase.Channel.ListarUsuarioAPI([error])
        End Function
    End Class
End Namespace
