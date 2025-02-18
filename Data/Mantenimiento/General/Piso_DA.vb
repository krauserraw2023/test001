﻿Imports Entity.Mantenimiento.General
Imports System.Data.SqlClient

Namespace Mantenimiento.General
    Public Class Piso_DA
        Private Shared strNameProcedure As String = "usp_int_mov_piso"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                              objEnt As Piso_BE) As SqlDataReader

            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_piso_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_pab_id", SqlDbType.Int)).Value = objEnt.PabellonId
                    .Parameters.Add(New SqlParameter("@piso_habilitado", SqlDbType.Bit)).Value = objEnt.PisoHabilitado

                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEnt.IDPenal

                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String,
                              ByVal objEnt As Piso_BE) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_piso_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_pab_id", SqlDbType.Int)).Value = objEnt.PabellonId
                            .Parameters.Add(New SqlParameter("@c_nombre", SqlDbType.VarChar, 100)).Value = objEnt.Nombre
                            .Parameters.Add(New SqlParameter("@piso_habilitado", SqlDbType.Bit)).Value = objEnt.PisoHabilitado

                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEnt.IDPenal

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            value = .Parameters("@variable_out").Value
                            Return value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, intCodigo As Integer) As Integer

            Dim value As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_piso_id", SqlDbType.Int)).Value = intCodigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            value = .Parameters("@variable_out").Value
                            Return value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
    End Class
End Namespace