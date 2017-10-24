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
    Public Class KeHoachTuan_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_KeHoachTuan_List(ByVal ID_kh As Integer) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_kh", ID_kh)
                Return UDB.SelectTableSP("PLAN_KeHoachTuan_Load_List", para)
            Else
                Dim para(0) As OracleParameter
                para(0) = New OracleParameter(":ID_kh", ID_kh)
                Return UDB.SelectTableSP("PLAN_KeHoachTuan_Load_List", para)
            End If
        End Function
        Public Function Load_KeHoachTuanChiTiet_List(ByVal ID_kh As Integer) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_kh", ID_kh)
                Return UDB.SelectTableSP("PLAN_KeHoachTuanChiTiet_Load_List", para)
            Else
                Dim para(0) As OracleParameter
                para(0) = New OracleParameter(":ID_kh", ID_kh)
                Return UDB.SelectTableSP("PLAN_KeHoachTuanChiTiet_Load_List", para)
            End If
        End Function
        Public Function Insert_KeHoachTuan(ByVal obj As KeHoachTuan) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh", obj.ID_kh)
                    para(1) = New SqlParameter("@Tuan_thu", obj.Tuan_thu)
                    para(2) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                    para(3) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                    Return UDB.ExecuteSP("PLAN_KeHoachTuan_Insert", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh", obj.ID_kh)
                    para(1) = New OracleParameter(":Tuan_thu", obj.Tuan_thu)
                    para(2) = New OracleParameter(":Tu_ngay", obj.Tu_ngay)
                    para(3) = New OracleParameter(":Den_ngay", obj.Den_ngay)
                    Return UDB.ExecuteSP("PLAN_KeHoachTuan_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachTuan(ByVal obj As KeHoachTuan, ByVal ID_kh_tuan As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    para(1) = New SqlParameter("@ID_kh", obj.ID_kh)
                    para(2) = New SqlParameter("@Tuan_thu", obj.Tuan_thu)
                    para(3) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                    para(4) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                    Return UDB.ExecuteSP("PLAN_KeHoachTuan_Update", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", ID_kh_tuan)
                    para(1) = New OracleParameter(":ID_kh", obj.ID_kh)
                    para(2) = New OracleParameter(":Tuan_thu", obj.Tuan_thu)
                    para(3) = New OracleParameter(":Tu_ngay", obj.Tu_ngay)
                    para(4) = New OracleParameter(":Den_ngay", obj.Den_ngay)
                    Return UDB.ExecuteSP("PLAN_KeHoachTuan_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KeHoachTuan(ByVal ID_kh_tuan As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    Return UDB.ExecuteSP("PLAN_KeHoachTuan_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", ID_kh_tuan)
                    Return UDB.ExecuteSP("PLAN_KeHoachTuan_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


