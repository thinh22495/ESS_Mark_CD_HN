'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Thursday, August 21, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DuyetDangKySinhVien_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_DuyetDangKySinhVien_List(ByVal UserName As String, ByVal Ky_dang_ky As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    para(1) = New SqlParameter("@UserName", UserName)
                    Return UDB.SelectTableSP("PLAN_DuyetDangKySinhVien_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    para(1) = New OracleParameter(":ID_sv", UserName)
                    Return UDB.SelectTableSP("PLAN_DuyetDangKySinhVien_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DuyetDangKySinhVien(ByVal obj As DuyetDangKySinhVien) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", obj.Ky_dang_ky)
                    para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(2) = New SqlParameter("@Duyet", obj.Duyet)
                    para(3) = New SqlParameter("@Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("PLAN_DuyetDangKySinhVien_Insert", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", obj.Ky_dang_ky)
                    para(1) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(2) = New OracleParameter(":Duyet", obj.Duyet)
                    para(3) = New OracleParameter(":Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("PLAN_DuyetDangKySinhVien_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DuyetDangKySinhVien(ByVal obj As DuyetDangKySinhVien, ByVal Ky_dang_ky As Integer, ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    para(2) = New SqlParameter("@Duyet", obj.Duyet)
                    para(3) = New SqlParameter("@Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("PLAN_DuyetDangKySinhVien_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    para(2) = New OracleParameter(":Duyet", obj.Duyet)
                    para(3) = New OracleParameter(":Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("PLAN_DuyetDangKySinhVien_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DuyetDangKySinhVien(ByVal Ky_dang_ky As Integer, ByVal ID_sv As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    Dim dt As DataTable
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    dt = UDB.SelectTableSP("PLAN_DuyetDangKySinhVien_CheckExist", para)
                    If dt.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(1) As OracleParameter
                    Dim dt As DataTable
                    para(0) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    dt = UDB.SelectTableSP("PLAN_DuyetDangKySinhVien_CheckExist", para)
                    If dt.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKe_DuyetDangKySinhVien(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_khoa As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                    Return UDB.SelectTableSP("PLAN_DuyetDangKySinhVienThongKe_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_khoa", ID_khoa)
                    Return UDB.SelectTableSP("PLAN_DuyetDangKySinhVienThongKe_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKe_SinhVienDaDuocPheDuyet(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("PLAN_ThongKeSinhVienDaDuocPheDuyet", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("PLAN_ThongKeSinhVienDaDuocPheDuyet", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKe_SinhVienKhongDuocPheDuyet(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("PLAN_ThongKeSinhVienKhongDuocPheDuyet", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("PLAN_ThongKeSinhVienKhongDuocPheDuyet", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKe_SinhVienChuaDuocPheDuyet(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("PLAN_ThongKeSinhVienChuaPheDuyet", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("PLAN_ThongKeSinhVienChuaPheDuyet", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace


