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
    Public Class KehoachMonChiTiet_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_KehoachMonChiTiet_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("PLAN_KeHoachMonChiTiet_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("PLAN_KeHoachMonChiTiet_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KehoachMonChiTiet(ByVal obj As KehoachMonChiTiet) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New SqlParameter("@ID_kh_mon", obj.ID_kh_mon)
                    para(2) = New SqlParameter("@So_tiet_ly_thuyet", obj.So_tiet_ly_thuyet)
                    para(3) = New SqlParameter("@So_tiet_thuc_hanh", obj.So_tiet_thuc_hanh)
                    para(4) = New SqlParameter("@Phan_doan", obj.Phan_doan)
                    para(5) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("PLAN_KeHoachMonChiTiet_Insert", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New OracleParameter(":ID_kh_mon", obj.ID_kh_mon)
                    para(2) = New OracleParameter(":So_tiet_ly_thuyet", obj.So_tiet_ly_thuyet)
                    para(3) = New OracleParameter(":So_tiet_thuc_hanh", obj.So_tiet_thuc_hanh)
                    para(4) = New OracleParameter(":Phan_doan", obj.Phan_doan)
                    para(5) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("PLAN_KeHoachMonChiTiet_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KehoachMonChiTiet(ByVal obj As KehoachMonChiTiet, ByVal ID_kh_mon_ct As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_mon_ct", ID_kh_mon_ct)
                    para(1) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(2) = New SqlParameter("@ID_kh_mon", obj.ID_kh_mon)
                    para(3) = New SqlParameter("@So_tiet_ly_thuyet", obj.So_tiet_ly_thuyet)
                    para(4) = New SqlParameter("@So_tiet_thuc_hanh", obj.So_tiet_thuc_hanh)
                    para(5) = New SqlParameter("@Phan_doan", obj.Phan_doan)
                    para(6) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("PLAN_KeHoachMonChiTiet_Update", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_mon_ct", ID_kh_mon_ct)
                    para(1) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(2) = New OracleParameter(":ID_kh_mon", obj.ID_kh_mon)
                    para(3) = New OracleParameter(":So_tiet_ly_thuyet", obj.So_tiet_ly_thuyet)
                    para(4) = New OracleParameter(":So_tiet_thuc_hanh", obj.So_tiet_thuc_hanh)
                    para(5) = New OracleParameter(":Phan_doan", obj.Phan_doan)
                    para(6) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("PLAN_KeHoachMonChiTiet_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KehoachMonChiTiet(ByVal ID_kh_mon_ct As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_mon_ct", ID_kh_mon_ct)
                    Return UDB.ExecuteSP("PLAN_KeHoachMonChiTiet_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_mon_ct", ID_kh_mon_ct)
                    Return UDB.ExecuteSP("PLAN_KeHoachMonChiTiet_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace


