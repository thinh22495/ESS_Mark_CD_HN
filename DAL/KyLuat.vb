'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Wednesday, 04 June, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class KyLuat_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_KyLuat(ByVal ID_ky_luat As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_ky_luat", ID_ky_luat)
                    Return UDB.SelectTableSP("STU_KyLuat_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_ky_luat", ID_ky_luat)
                    Return UDB.SelectTableSP("STU_KyLuat_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_SinhVienKyLuat(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_SinhVienKyLuat_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_SinhVienKyLuat_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KyLuatLop(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_KyLuatLop_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_KyLuatLop_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KyLuatSV(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_KyLuatSV_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_KyLuatSV_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KyLuat_List() As DataTable
            Try
                Return UDB.SelectTableSP("KyLuat_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KyLuat(ByVal obj As KyLuat) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@So_qd", obj.So_qd)
                    para(1) = New SqlParameter("@Ngay_qd", obj.Ngay_qd)
                    para(2) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(3) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(4) = New SqlParameter("@ID_hanh_vi", obj.ID_hanh_vi)
                    para(5) = New SqlParameter("@ID_xu_ly", obj.ID_xu_ly)
                    para(6) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                    Return UDB.ExecuteSP("STU_KyLuat_Insert", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":So_qd", obj.So_qd)
                    para(1) = New OracleParameter(":Ngay_qd", obj.Ngay_qd)
                    para(2) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(3) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(4) = New OracleParameter(":ID_hanh_vi", obj.ID_hanh_vi)
                    para(5) = New OracleParameter(":ID_xu_ly", obj.ID_xu_ly)
                    para(6) = New OracleParameter(":Noi_dung", obj.Noi_dung)
                    Return UDB.ExecuteSP("STU_KyLuat_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KyLuatSinhvien(ByVal ID_sv As Integer, ByVal ID_ky_luat As Integer, ByVal Xoa_ky_luat As Integer, ByVal Ngay_xoa As Date, ByVal Ly_do As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_ky_luat", ID_ky_luat)
                    para(2) = New SqlParameter("@Xoa_ky_luat", Xoa_ky_luat)
                    para(3) = New SqlParameter("@Ngay_xoa", Ngay_xoa)
                    para(4) = New SqlParameter("@Lydo_xoa", Ly_do)
                    Return UDB.ExecuteSP("STU_KyLuatSinhvien_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_ky_luat", ID_ky_luat)
                    para(2) = New OracleParameter(":Xoa_ky_luat", Xoa_ky_luat)
                    para(3) = New OracleParameter(":Ngay_xoa", Ngay_xoa)
                    para(4) = New OracleParameter(":Lydo_xoa", Ly_do)
                    Return UDB.ExecuteSP("STU_KyLuatSinhvien_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KyLuat(ByVal obj As KyLuat, ByVal ID_ky_luat As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_ky_luat", ID_ky_luat)
                    para(1) = New SqlParameter("@So_qd", obj.So_qd)
                    para(2) = New SqlParameter("@Ngay_qd", obj.Ngay_qd)
                    para(3) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(4) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(5) = New SqlParameter("@ID_hanh_vi", obj.ID_hanh_vi)
                    para(6) = New SqlParameter("@ID_xu_ly", obj.ID_xu_ly)
                    para(7) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                    Return UDB.ExecuteSP("STU_KyLuat_Update", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":ID_ky_luat", ID_ky_luat)
                    para(1) = New OracleParameter(":So_qd", obj.So_qd)
                    para(2) = New OracleParameter(":Ngay_qd", obj.Ngay_qd)
                    para(3) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(4) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(5) = New OracleParameter(":ID_hanh_vi", obj.ID_hanh_vi)
                    para(6) = New OracleParameter(":ID_xu_ly", obj.ID_xu_ly)
                    para(7) = New OracleParameter(":Noi_dung", obj.Noi_dung)
                    Return UDB.ExecuteSP("STU_KyLuat_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KyLuatSinhVien(ByVal ID_sv As Integer, ByVal ID_ky_luat As Integer, ByVal Xoa_ky_luat As Integer, ByVal Ngay_xoa As Date, ByVal Ly_do As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@Xoa_ky_luat", Xoa_ky_luat)
                    para(1) = New SqlParameter("@ID_ky_luat", ID_ky_luat)
                    para(2) = New SqlParameter("@Ngay_Xoa", Ngay_xoa)
                    para(3) = New SqlParameter("@Lydo_Xoa", Ly_do)
                    para(4) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_KyLuatSinhVien_Update", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":Xoa_ky_luat", Xoa_ky_luat)
                    para(1) = New OracleParameter(":ID_ky_luat", ID_ky_luat)
                    para(2) = New OracleParameter(":Ngay_Xoa", Ngay_xoa)
                    para(3) = New OracleParameter(":Lydo_Xoa", Ly_do)
                    para(4) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_KyLuatSinhVien_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KyLuatSinhVien(ByVal ID_ky_luat As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_ky_luat", ID_ky_luat)
                    Return UDB.ExecuteSP("STU_KyLuatSinhVien_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_ky_luat", ID_ky_luat)
                    Return UDB.ExecuteSP("STU_KyLuatSinhVien_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KyLuat(ByVal ID_ky_luat As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_ky_luat", ID_ky_luat)
                    Return UDB.ExecuteSP("STU_KyLuat_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_ky_luat", ID_ky_luat)
                    Return UDB.ExecuteSP("STU_KyLuat_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_STU_KyLuatSinhVien(ByVal ID_ky_luat As Integer, ByVal ID_sv As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_ky_luat", ID_ky_luat)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    If UDB.SelectTableSP("STU_KyLuatSinhVien_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_ky_luat", ID_ky_luat)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    If UDB.SelectTableSP("STU_KyLuatSinhVien_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_STU_KyLuat(ByVal ID_ky_luat As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_ky_luat", ID_ky_luat)
                    If UDB.SelectTableSP("STU_KyLuat_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_ky_luat", ID_ky_luat)
                    If UDB.SelectTableSP("STU_KyLuat_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_STU_KyLuat() As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.ExecuteScalar("STU_KyLuat_GetMaxID")
                Else
                    Return UDB.ExecuteScalar("STU_KyLuat_GetMaxID")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

    End Class
End Namespace


