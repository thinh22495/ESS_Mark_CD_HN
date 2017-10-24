Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class ChuongTrinhDaoTaoNhomTuChon_DAL
#Region "Constructor"
        Public Sub New()
        End Sub
#End Region
#Region "Function"
        Public Function Load_ChuongTrinhDaoTaoNhomTuChon_List(ByVal ID_dt As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTietNhomMonChon_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTietNhomMonChon_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_ChuongTrinhDaoTaoNhomTuChon(ByVal ID_dt As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_NhomTuChon_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_NhomTuChon_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_ChuongTrinhDaoTaoNotNhomTuChon_List(ByVal ID_dt As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTietNotNhomMonChon_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTietNotNhomMonChon_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Insert_ChuongTrinhDaoTaoNhomTuChon(ByVal obj As ChuongTrinhDaoTaoNhomTuChon) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", obj.ID_dt)
                    para(1) = New SqlParameter("@Nhom_tu_chon", obj.Nhom_tu_chon)
                    para(2) = New SqlParameter("@So_mon_tu_chon", obj.So_mon_tu_chon)
                    para(3) = New SqlParameter("@So_mon_dang_ky", obj.So_mon_dang_ky)
                    Dim dt As DataTable = UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoNhomTuChon_Insert", para)
                    If dt.Rows.Count > 0 Then
                        Return CInt("0" + dt.Rows(0)(0).ToString())
                    Else
                        Return 0
                    End If
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", obj.ID_dt)
                    para(1) = New OracleParameter(":Nhom_tu_chon", obj.Nhom_tu_chon)
                    para(2) = New OracleParameter(":So_mon_tu_chon", obj.So_mon_tu_chon)
                    para(3) = New OracleParameter(":So_mon_dang_ky", obj.So_mon_dang_ky)
                    Dim dt As DataTable = UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoNhomTuChon_Insert", para)
                    If dt.Rows.Count > 0 Then
                        Return CInt("0" + dt.Rows(0)(0).ToString())
                    Else
                        Return 0
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_ChuongTrinhDaoTaoNhomTuChon(ByVal ID_dt As Integer, ByVal Nhom_tu_chon As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    para(1) = New SqlParameter("@Nhom_tu_chon", Nhom_tu_chon)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTaoNhomTuChon_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    para(1) = New OracleParameter(":Nhom_tu_chon", Nhom_tu_chon)
                    Return UDB.ExecuteSP("PLAN_ChuongTrinhDaoTaoNhomTuChon_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace


