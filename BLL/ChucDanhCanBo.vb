'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, June 17, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class ChucDanhCanBo_BLL
        Private arrChucDanhCanBo As ArrayList

#Region "Constructor"
        Public Sub New()
            'Add tat ca Chuc danh can bo
            Try
                arrChucDanhCanBo = New ArrayList
                Dim objChucDanhCanBo_dal As New ChucDanhCanBo_DAL
                Dim dt As DataTable = objChucDanhCanBo_dal.Load_ChucDanhCanBo_List()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objChucDanhCanBo As New ChucDanhCanBo
                        objChucDanhCanBo = Converting(dt.Rows(i))
                        arrChucDanhCanBo.Add(objChucDanhCanBo)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function ChucDanhCanBo() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_chuc_vu", GetType(Integer))
            dt.Columns.Add("Chuc_vu", GetType(String))
            For i As Integer = 0 To arrChucDanhCanBo.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objChucDanhCanBo As ChucDanhCanBo = CType(arrChucDanhCanBo(i), ChucDanhCanBo)
                row("ID_chuc_vu") = objChucDanhCanBo.ID_chuc_danh
                row("Chuc_vu") = objChucDanhCanBo.Chuc_danh
                dt.Rows.Add(row)
            Next
            Return dt
        End Function

        Public Function Insert_ChucDanhCanBo(ByVal objChucDanhCanBo As ChucDanhCanBo) As Integer
            Try
                Dim obj As ChucDanhCanBo_DAL = New ChucDanhCanBo_DAL
                Return obj.Insert_ChucDanhCanBo(objChucDanhCanBo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_ChucDanhCanBo(ByVal objChucDanhCanBo As ChucDanhCanBo, ByVal ID_chuc_danh As Integer) As Integer
            Try
                Dim obj As ChucDanhCanBo_DAL = New ChucDanhCanBo_DAL
                Return obj.Update_ChucDanhCanBo(objChucDanhCanBo, ID_chuc_danh)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_ChucDanhCanBo(ByVal ID_chuc_danh As Integer) As Integer
            Try
                Dim obj As ChucDanhCanBo_DAL = New ChucDanhCanBo_DAL
                Return obj.Delete_ChucDanhCanBo(ID_chuc_danh)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drChucDanhCanBo As DataRow) As ChucDanhCanBo
            Dim result As ChucDanhCanBo
            Try
                result = New ChucDanhCanBo
                If drChucDanhCanBo("ID_chuc_danh").ToString() <> "" Then result.ID_chuc_danh = CType(drChucDanhCanBo("ID_chuc_danh").ToString(), Integer)
                result.Ma_chuc_danh = drChucDanhCanBo("Ma_chuc_danh").ToString()
                result.Chuc_danh = drChucDanhCanBo("Chuc_danh").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
