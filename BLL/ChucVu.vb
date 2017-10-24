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
    Public Class ChucVu_BLL
        Private arrChucVu As ArrayList

#Region "Constructor"
        Public Sub New()
            'Add tat ca Chuc vu
            Try
                arrChucVu = New ArrayList
                Dim objChucVu_dal As New ChucVu_DAL
                Dim dt As DataTable = objChucVu_dal.Load_ChucVu_List()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objChucVu As New ChucVu
                        objChucVu = Converting(dt.Rows(i))
                        arrChucVu.Add(objChucVu)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function DanhMucChucVu() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_chuc_vu", GetType(Integer))
            dt.Columns.Add("Chuc_vu", GetType(String))
            For i As Integer = 0 To arrChucVu.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objChucVu As ChucVu = CType(arrChucVu(i), ChucVu)
                row("ID_chuc_vu") = objChucVu.ID_chuc_vu
                row("Chuc_vu") = objChucVu.Chuc_vu
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Public Function Insert_ChucVu(ByVal objChucVu As ChucVu) As Integer
            Try
                Dim obj As ChucVu_DAL = New ChucVu_DAL
                Return obj.Insert_ChucVu(objChucVu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_ChucVu(ByVal objChucVu As ChucVu, ByVal ID_chuc_vu As Integer) As Integer
            Try
                Dim obj As ChucVu_DAL = New ChucVu_DAL
                Return obj.Update_ChucVu(objChucVu, ID_chuc_vu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_ChucVu(ByVal ID_chuc_vu As Integer) As Integer
            Try
                Dim obj As ChucVu_DAL = New ChucVu_DAL
                Return obj.Delete_ChucVu(ID_chuc_vu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drChucVu As DataRow) As ChucVu
            Dim result As ChucVu
            Try
                result = New ChucVu
                If drChucVu("ID_chuc_vu").ToString() <> "" Then result.ID_chuc_vu = CType(drChucVu("ID_chuc_vu").ToString(), Integer)
                result.Ma_chuc_vu = drChucVu("Ma_chuc_vu").ToString()
                result.Chuc_vu = drChucVu("Chuc_vu").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
