﻿Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class internoFoto
        Private Shared strNameProcedure As String = "UP_VIS_InternoFoto"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal InternoID As Integer, _
        ByVal FotoDescargada As Integer) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_fot_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@fot_dwn", SqlDbType.Int)).Value = FotoDescargada
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal InternoID As Integer) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_fot_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intValue = .Parameters("@variable_out").Value
                            Return intValue
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal InternoID As Integer, _
        ByVal InternoCodigoRP As String, _
        ByVal PrimerApellido As String, _
        ByVal SegundoApellido As String, _
        ByVal PreNombres As String, _
        ByVal PathFoto As String, ByVal FotoPerfil As Integer, _
        ByVal FotoDescargada As Integer, _
        ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_fot_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 50)).Value = InternoCodigoRP
                            .Parameters.Add(New SqlParameter("@int_pri_ape", SqlDbType.VarChar, 50)).Value = PrimerApellido
                            .Parameters.Add(New SqlParameter("@int_seg_ape", SqlDbType.VarChar, 50)).Value = SegundoApellido
                            .Parameters.Add(New SqlParameter("@int_pre_nom", SqlDbType.VarChar, 50)).Value = PreNombres
                            .Parameters.Add(New SqlParameter("@int_pth_fot", SqlDbType.VarChar, 500)).Value = PathFoto
                            .Parameters.Add(New SqlParameter("@int_fot_per", SqlDbType.Int)).Value = FotoPerfil
                            .Parameters.Add(New SqlParameter("@fot_dwn", SqlDbType.Int)).Value = FotoDescargada

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_fot_id", SqlDbType.Int)).Value = Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
    End Class
End Namespace