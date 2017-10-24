'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Monday, June 30, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class ToaNha_BLL
        Private arrToaNha As ArrayList

#Region "Constructor"
        Public Sub New()
            'Add tat ca Chuc vu
            Try
                arrToaNha = New ArrayList
                Dim objToaNha_dal As New ToaNha_DAL
                Dim dt As DataTable = objToaNha_dal.Load_ToaNha_List()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objToaNha As New ToaNha
                        objToaNha = Converting(dt.Rows(i))
                        arrToaNha.Add(objToaNha)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function DanhMucToaNha() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_nha", GetType(Integer))
                dt.Columns.Add("Ten_nha", GetType(String))
                For i As Integer = 0 To arrToaNha.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objToaNha As ToaNha = CType(arrToaNha(i), ToaNha)
                    row("ID_nha") = objToaNha.ID_nha
                    row("Ten_nha") = objToaNha.Ten_nha
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_ToaNha(ByVal objToaNha As ToaNha) As Integer
            Try
                Dim obj As ToaNha_DAL = New ToaNha_DAL
                Return obj.Insert_ToaNha(objToaNha)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_ToaNha(ByVal ID_nha As Integer) As Integer
            Try
                Dim obj As ToaNha_DAL = New ToaNha_DAL
                Return obj.Delete_ToaNha(ID_nha)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drToaNha As DataRow) As ToaNha
            Dim result As ToaNha
            Try
                result = New ToaNha
                If drToaNha("ID_nha").ToString() <> "" Then result.ID_nha = CType(drToaNha("ID_nha").ToString(), Integer)
                If drToaNha("ID_co_so").ToString() <> "" Then result.ID_co_so = CType(drToaNha("ID_co_so").ToString(), Integer)
                result.Ma_nha = drToaNha("Ma_nha").ToString()
                result.Ten_nha = drToaNha("Ten_nha").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
