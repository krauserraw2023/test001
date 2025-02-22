﻿Namespace Reporte
    Public Class ReporteContenido
        Public Property Codigo As Integer = -1
        Public Property RptCabeceraId As Integer = -1
        Public Property ClaveStr As String = ""
        Public Property ValorStr As String = ""
        Public Property ValorInt As Integer = 0
        Public Property RegionId As Integer = -1
        Public Property PenalId As Integer = -1
    End Class

    Public Class ReporteContenidoCol
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
        Public Function Add(ByVal obj As ReporteContenido) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property ReporteContenido(ByVal Index As Integer) As ReporteContenido
            Get
                Return CType(MyBase.List(Index), ReporteContenido)
            End Get
        End Property
    End Class
End Namespace