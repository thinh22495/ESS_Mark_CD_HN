'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Sunday, August 10, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class HocKyDangKy_BLL
        Private arrHocKyDangKy As ArrayList
#Region "Constructor"
        Sub New()
            'Add học kỳ đăng ký
            Try
                arrHocKyDangKy = New ArrayList
                Dim obj_dal As New HocKyDangKy_DAL
                Dim dt As DataTable = obj_dal.Load_HocKyDangKy_List()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim obj As New HocKyDangKy
                        obj = Converting(dt.Rows(i))
                        arrHocKyDangKy.Add(obj)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function DanhMucHocKyDangKy() As DataTable
            Dim dt As New DataTable
            Try
                dt.Columns.Add("ky_dang_ky", GetType(Integer))
                dt.Columns.Add("Ten_ky_dang_ky", GetType(String))
                For i As Integer = 0 To arrHocKyDangKy.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim obj As HocKyDangKy = CType(arrHocKyDangKy(i), HocKyDangKy)
                    row("ky_dang_ky") = obj.Ky_dang_ky
                    row("Ten_ky_dang_ky") = "Đợt " & obj.Dot & " (Học kỳ " & obj.Hoc_ky & " năm học " & obj.Nam_hoc & ")"
                    dt.Rows.Add(row)
                Next
            Catch ex As Exception
            End Try
            Return dt
        End Function
        Public Function Check_HocKyDangKy(ByVal objHocKyDangKy As HocKyDangKy) As Boolean
            Try
                Dim obj As HocKyDangKy_DAL = New HocKyDangKy_DAL
                Return obj.Check_HocKyDangKy(objHocKyDangKy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_HocKyDangKy(ByVal objHocKyDangKy As HocKyDangKy) As Integer
            Try
                Dim obj As HocKyDangKy_DAL = New HocKyDangKy_DAL
                Return obj.Insert_HocKyDangKy(objHocKyDangKy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_HocKyDangKy(ByVal objHocKyDangKy As HocKyDangKy) As Integer
            Try
                Dim obj As HocKyDangKy_DAL = New HocKyDangKy_DAL
                Return obj.Update_HocKyDangKy(objHocKyDangKy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_HocKyDangKy(ByVal Ky_dang_ky As Integer) As Integer
            Try
                Dim obj As HocKyDangKy_DAL = New HocKyDangKy_DAL
                Return obj.Delete_HocKyDangKy(Ky_dang_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drHocKyDangKy As DataRow) As HocKyDangKy
            Dim result As HocKyDangKy
            Try
                result = New HocKyDangKy
                If drHocKyDangKy("Ky_dang_ky").ToString() <> "" Then result.Ky_dang_ky = CType(drHocKyDangKy("Ky_dang_ky").ToString(), Integer)
                If drHocKyDangKy("Dot").ToString() <> "" Then result.Dot = CType(drHocKyDangKy("Dot").ToString(), Integer)
                If drHocKyDangKy("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drHocKyDangKy("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drHocKyDangKy("Nam_hoc").ToString()
                If drHocKyDangKy("Tu_ngay").ToString() <> "" Then result.Tu_ngay = CType(drHocKyDangKy("Tu_ngay").ToString(), Date)
                If drHocKyDangKy("Den_ngay").ToString() <> "" Then result.Den_ngay = CType(drHocKyDangKy("Den_ngay").ToString(), Date)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Public Function Check_HocKyDangKy_TonTai(ByVal obj As HocKyDangKy) As Boolean
            Try
                Dim clsDAL As HocKyDangKy_DAL = New HocKyDangKy_DAL
                Return clsDAL.Check_HocKyDangKy_TonTai(obj)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_HocKyDangKy_DaTonTai(ByVal obj As HocKyDangKy) As Integer
            Try
                Dim clsDAL As HocKyDangKy_DAL = New HocKyDangKy_DAL
                Return clsDAL.Delete_HocKyDangKy_DaTonTai(obj)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace