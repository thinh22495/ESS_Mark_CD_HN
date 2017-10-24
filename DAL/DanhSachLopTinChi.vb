'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/02/2008
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity

Namespace DBManager
    Public Class DanhSachSinhVienLopTinChi_DAL

#Region "Constructor"
        Public Sub New()

        End Sub
#End Region

#Region "Function"
        Public Function Load_DanhSachSinhVienLopTinChi_List(ByVal ID_mon_tc As Integer, ByVal ID_lop_tc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                    para(1) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                    Return UDB.SelectTableSP("STU_DanhSachSinhVienLopTinChi_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_mon_tc", ID_mon_tc)
                    para(1) = New OracleParameter(":ID_lop_tc", ID_lop_tc)
                    Return UDB.SelectTableSP("STU_DanhSachSinhVienLopTinChi_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DanhSachLopTinChi(ByVal obj As DanhSachLopTinChi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop_tc", obj.ID_lop_tc)
                    para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(2) = New SqlParameter("@Hoc_lai", obj.Hoc_lai)
                    para(3) = New SqlParameter("@Huy_dang_ky", obj.Huy_dang_ky)
                    para(4) = New SqlParameter("@Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("STU_DanhSachLopTinChi_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop_tc", obj.ID_lop_tc)
                    para(1) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(2) = New OracleParameter(":Hoc_lai", obj.Hoc_lai)
                    para(3) = New OracleParameter(":Huy_dang_ky", obj.Huy_dang_ky)
                    para(4) = New OracleParameter(":Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("STU_DanhSachLopTinChi_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSachLopTinChi(ByVal ID_sv As Integer, ByVal Ky_dang_ky As Integer, ByVal Duyet As Boolean) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    para(2) = New SqlParameter("@Duyet", Duyet)
                    Return UDB.ExecuteSP("STU_DanhSachLopTinChi_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Ky_dang_ky", Ky_dang_ky)
                    para(2) = New OracleParameter(":Duyet", Duyet)
                    Return UDB.ExecuteSP("STU_DanhSachLopTinChi_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_LopTinChi(ByVal ID_sv As Integer, ByVal ID_lop_tc As Integer, ByVal Rut_bot_hoc_phan As Boolean) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                    para(2) = New SqlParameter("@Rut_bot_hoc_phan", Rut_bot_hoc_phan)
                    Return UDB.ExecuteSP("STU_LopTinChi_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_lop_tc", ID_lop_tc)
                    para(2) = New OracleParameter(":Rut_bot_hoc_phan", Rut_bot_hoc_phan)
                    Return UDB.ExecuteSP("STU_LopTinChi_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_LopTinChi_Chuyen(ByVal ID_sv As Integer, ByVal ID_lop_tc_tu As Integer, ByVal ID_lop_tc_den As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_lop_tc_tu", ID_lop_tc_tu)
                    para(2) = New SqlParameter("@ID_lop_tc_den", ID_lop_tc_den)
                    Return UDB.ExecuteSP("STU_LopTinChi_Chuyen_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_lop_tc", ID_lop_tc_tu)
                    para(2) = New OracleParameter(":ID_lop_tc_den", ID_lop_tc_den)
                    Return UDB.ExecuteSP("STU_LopTinChi_Chuyen_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSachLopTinChi(ByVal ID_sv As Integer, ByVal dsKy_dang_ky As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@dsKy_dang_ky", dsKy_dang_ky)
                    Return UDB.ExecuteSP("STU_DanhSachLopTinChi_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":dsKy_dang_ky", dsKy_dang_ky)
                    Return UDB.ExecuteSP("STU_DanhSachLopTinChi_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_LopTinChi(ByVal ID_sv As Integer, ByVal ID_lop_tc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                    Return UDB.ExecuteSP("STU_LopTinChi_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_lop_tc", ID_lop_tc)
                    Return UDB.ExecuteSP("STU_LopTinChi_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function ThongTnLopTInChi_Select(ByVal ID_lop_tc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                    Return UDB.SelectTableSP("PLAN_ThongTnLopTInChi_Select", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop_tc", ID_lop_tc)
                    Return UDB.SelectTableSP("PLAN_ThongTnLopTInChi_Select", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace


