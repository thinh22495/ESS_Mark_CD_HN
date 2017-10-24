'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Monday, June 09, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class GiangVien_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_GiangVien(ByVal ID_cb As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_cb", ID_cb)
                    Return UDB.SelectTableSP("PLAN_GiaoVien_Load", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_cb", ID_cb)
                    Return UDB.SelectTableSP("PLAN_GiaoVien_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_GiangVien_List() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_GiaoVien_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_GiangVien(ByVal obj As GiangVien) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(9) As SqlParameter
                    para(0) = New SqlParameter("@Ma_cb", obj.Ma_cb)
                    para(1) = New SqlParameter("@Ten", obj.Ten)
                    para(2) = New SqlParameter("@Ho_ten", obj.Ho_ten)
                    para(3) = New SqlParameter("@ID_gioi_tinh", obj.ID_gioi_tinh)
                    para(4) = New SqlParameter("@Ngay_sinh", SqlDbType.DateTime)
                    If obj.Ngay_sinh.ToString = "" Then
                        para(4).Value = DBNull.Value
                    Else
                        para(4).Value = CDate(obj.Ngay_sinh)
                    End If
                    para(5) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(6) = New SqlParameter("@ID_hoc_ham", obj.ID_hoc_ham)
                    para(7) = New SqlParameter("@ID_hoc_vi", obj.ID_hoc_vi)
                    para(8) = New SqlParameter("@ID_chuc_danh", obj.ID_chuc_danh)
                    para(9) = New SqlParameter("@ID_chuc_vu", obj.ID_chuc_vu)
                    Return UDB.ExecuteSP("PLAN_GiaoVien_Insert", para)
                Else
                    Dim para(9) As OracleParameter
                    para(0) = New OracleParameter(":Ma_cb", obj.Ma_cb)
                    para(1) = New OracleParameter(":Ten", obj.Ten)
                    para(2) = New OracleParameter(":Ho_ten", obj.Ho_ten)
                    para(3) = New OracleParameter(":ID_gioi_tinh", obj.ID_gioi_tinh)
                    para(4) = New OracleParameter(":Ngay_sinh", obj.Ngay_sinh)
                    para(5) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(6) = New OracleParameter(":ID_hoc_ham", obj.ID_hoc_ham)
                    para(7) = New OracleParameter(":ID_hoc_vi", obj.ID_hoc_vi)
                    para(8) = New OracleParameter(":ID_chuc_danh", obj.ID_chuc_danh)
                    para(9) = New OracleParameter(":ID_chuc_vu", obj.ID_chuc_vu)
                    Return UDB.ExecuteSP("PLAN_GiaoVien_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_GiangVien(ByVal obj As GiangVien) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(10) As SqlParameter
                    para(0) = New SqlParameter("@Ma_cb", obj.Ma_cb)
                    para(1) = New SqlParameter("@Ten", obj.Ten)
                    para(2) = New SqlParameter("@Ho_ten", obj.Ho_ten)
                    para(3) = New SqlParameter("@ID_gioi_tinh", obj.ID_gioi_tinh)
                    para(4) = New SqlParameter("@Ngay_sinh", SqlDbType.DateTime)
                    If obj.Ngay_sinh.ToString = "" Then
                        para(4).Value = DBNull.Value
                    Else
                        para(4).Value = CDate(obj.Ngay_sinh)
                    End If
                    para(5) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(6) = New SqlParameter("@ID_hoc_ham", obj.ID_hoc_ham)
                    para(7) = New SqlParameter("@ID_hoc_vi", obj.ID_hoc_vi)
                    para(8) = New SqlParameter("@ID_chuc_danh", obj.ID_chuc_danh)
                    para(9) = New SqlParameter("@ID_chuc_vu", obj.ID_chuc_vu)
                    para(10) = New SqlParameter("@ID_cb", obj.ID_cb)
                    Return UDB.ExecuteSP("PLAN_GiaoVien_Update", para)
                Else
                    Dim para(10) As OracleParameter
                    para(0) = New OracleParameter(":Ma_cb", obj.Ma_cb)
                    para(1) = New OracleParameter(":Ten", obj.Ten)
                    para(2) = New OracleParameter(":Ho_ten", obj.Ho_ten)
                    para(3) = New OracleParameter(":ID_gioi_tinh", obj.ID_gioi_tinh)
                    para(4) = New OracleParameter(":Ngay_sinh", SqlDbType.DateTime)
                    If obj.Ngay_sinh.ToString = "" Then
                        para(4).Value = DBNull.Value
                    Else
                        para(4).Value = CDate(obj.Ngay_sinh)
                    End If
                    para(5) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(6) = New OracleParameter(":ID_hoc_ham", obj.ID_hoc_ham)
                    para(7) = New OracleParameter(":ID_hoc_vi", obj.ID_hoc_vi)
                    para(8) = New OracleParameter(":ID_chuc_danh", obj.ID_chuc_danh)
                    para(9) = New OracleParameter(":ID_chuc_vu", obj.ID_chuc_vu)
                    para(10) = New OracleParameter(":ID_cb", obj.ID_cb)
                    Return UDB.ExecuteSP("PLAN_GiaoVien_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_GiangVien(ByVal ID_cb As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_cb", ID_cb)
                    Return UDB.ExecuteSP("PLAN_GiaoVien_Delete", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_cb", ID_cb)
                    Return UDB.ExecuteSP("PLAN_GiaoVien_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_IDGiangVien(ByVal ID_cb As Integer) As Boolean
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_cb", ID_cb)
                    dt = UDB.SelectTableSP("PLAN_GiaoVien_CheckExist_ID", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_cb", ID_cb)
                    dt = UDB.SelectTableSP("PLAN_GiaoVien_CheckExist_ID", para)
                End If
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_MaGiangVien(ByVal Ma_cb As String) As Boolean
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@Ma_cb", Ma_cb)
                    dt = UDB.SelectTableSP("PLAN_GiaoVien_CheckExist_Ma", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":Ma_cb", Ma_cb)
                    dt = UDB.SelectTableSP("PLAN_GiaoVien_CheckExist_Ma", para)
                End If
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_GiangVien() As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.ExecuteScalar("PLAN_GiaoVien_GetMaxID")
                Else
                    Return UDB.ExecuteScalar("PLAN_GiaoVien_GetMaxID")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


