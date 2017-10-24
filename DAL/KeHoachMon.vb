'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Wednesday, April 08, 2009
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class KeHoachMon_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_KeHoachMon_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("PLAN_KeHoachMon_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("PLAN_KeHoachMon_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KeHoachMon(ByVal obj As KeHoachMon) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(11) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(2) = New SqlParameter("@ID_lop", obj.ID_lop)
                    para(3) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(4) = New SqlParameter("@Ly_thuyet", obj.Ly_thuyet)
                    para(5) = New SqlParameter("@Thuc_hanh", obj.Thuc_hanh)
                    para(6) = New SqlParameter("@Bai_tap", obj.Bai_tap)
                    para(7) = New SqlParameter("@Bai_tap_lon", obj.Bai_tap_lon)
                    para(8) = New SqlParameter("@Thuc_tap", obj.Thuc_tap)
                    para(9) = New SqlParameter("@So_hoc_trinh", obj.So_hoc_trinh)
                    para(10) = New SqlParameter("@So_top", obj.So_top)
                    para(11) = New SqlParameter("@STT_mon", obj.STT_mon)
                    Return UDB.ExecuteSP("PLAN_KeHoachMon_Insert", para)
                Else
                    Dim para(11) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(2) = New OracleParameter(":ID_lop", obj.ID_lop)
                    para(3) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(4) = New OracleParameter(":Ly_thuyet", obj.Ly_thuyet)
                    para(5) = New OracleParameter(":Thuc_hanh", obj.Thuc_hanh)
                    para(6) = New OracleParameter(":Bai_tap", obj.Bai_tap)
                    para(7) = New OracleParameter(":Bai_tap_lon", obj.Bai_tap_lon)
                    para(8) = New OracleParameter(":Thuc_tap", obj.Thuc_tap)
                    para(9) = New OracleParameter(":So_hoc_trinh", obj.So_hoc_trinh)
                    para(10) = New OracleParameter(":So_top", obj.So_top)
                    para(11) = New OracleParameter(":STT_mon", obj.STT_mon)
                    Return UDB.ExecuteSP("PLAN_KeHoachMon_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachMon(ByVal obj As KeHoachMon, ByVal ID_kh_mon As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(12) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_mon", ID_kh_mon)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@ID_lop", obj.ID_lop)
                    para(4) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(5) = New SqlParameter("@Ly_thuyet", obj.Ly_thuyet)
                    para(6) = New SqlParameter("@Thuc_hanh", obj.Thuc_hanh)
                    para(7) = New SqlParameter("@Bai_tap", obj.Bai_tap)
                    para(8) = New SqlParameter("@Bai_tap_lon", obj.Bai_tap_lon)
                    para(9) = New SqlParameter("@Thuc_tap", obj.Thuc_tap)
                    para(10) = New SqlParameter("@So_hoc_trinh", obj.So_hoc_trinh)
                    para(11) = New SqlParameter("@So_top", obj.So_top)
                    para(12) = New SqlParameter("@STT_mon", obj.STT_mon)
                    Return UDB.ExecuteSP("PLAN_KeHoachMon_Update", para)
                Else
                    Dim para(12) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_mon", ID_kh_mon)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":ID_lop", obj.ID_lop)
                    para(4) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(5) = New OracleParameter(":Ly_thuyet", obj.Ly_thuyet)
                    para(6) = New OracleParameter(":Thuc_hanh", obj.Thuc_hanh)
                    para(7) = New OracleParameter(":Bai_tap", obj.Bai_tap)
                    para(8) = New OracleParameter(":Bai_tap_lon", obj.Bai_tap_lon)
                    para(9) = New OracleParameter(":Thuc_tap", obj.Thuc_tap)
                    para(10) = New OracleParameter(":So_hoc_trinh", obj.So_hoc_trinh)
                    para(11) = New OracleParameter(":So_top", obj.So_top)
                    para(12) = New OracleParameter(":STT_mon", obj.STT_mon)
                    Return UDB.ExecuteSP("PLAN_KeHoachMon_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachMon_GiaoVien(ByVal ID_kh_mon As Integer, ByVal ID_cb As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_mon", ID_kh_mon)
                    para(1) = New SqlParameter("@ID_cb", ID_cb)
                    Return UDB.ExecuteSP("PLAN_KeHoachMon_GiaoVien_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_mon", ID_kh_mon)
                    para(1) = New OracleParameter(":ID_cb", ID_cb)
                    Return UDB.ExecuteSP("PLAN_KeHoachMon_GiaoVien_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KeHoachMon(ByVal ID_kh_mon As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_mon", ID_kh_mon)
                    Return UDB.ExecuteSP("PLAN_KeHoachMon_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_mon", ID_kh_mon)
                    Return UDB.ExecuteSP("PLAN_KeHoachMon_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


