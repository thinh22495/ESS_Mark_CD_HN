'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, April 22, 2008
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class TimKiemThongKeTKB_DAL
        Public Function TimKiemLopDangHoc(ByVal strSQL_Where As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@strSQL_Where", strSQL_Where)
                    Return UDB.SelectTableSP("PLAN_TimKiemLopDangHoc", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":strSQL_Where", strSQL_Where)
                    Return UDB.SelectTableSP("PLAN_TimKiemLopDangHoc", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TimKiemLopRoi(ByVal strSQL_Where_thoi_gian As String, ByVal strSQL_Where_lop As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@strSQL_Where_thoi_gian", strSQL_Where_thoi_gian)
                    para(1) = New SqlParameter("@strSQL_Where_lop", strSQL_Where_lop)
                    Return UDB.SelectTableSP("PLAN_TimKiemLopRoi", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":strSQL_Where_thoi_gian", strSQL_Where_thoi_gian)
                    para(1) = New OracleParameter(":strSQL_Where_lop", strSQL_Where_lop)
                    Return UDB.SelectTableSP("PLAN_TimKiemLopRoi", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TimKiemGiaoVienDangDay(ByVal strSQL_Where As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@strSQL_Where", strSQL_Where)
                    Return UDB.SelectTableSP("PLAN_TimKiemGiaoVienDangDay", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":strSQL_Where", strSQL_Where)
                    Return UDB.SelectTableSP("PLAN_TimKiemGiaoVienDangDay", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TimKiemGiaoVienRoi(ByVal strSQL_Where_thoi_gian As String, ByVal strSQL_Where_giao_vien As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@strSQL_Where_thoi_gian", strSQL_Where_thoi_gian)
                    para(1) = New SqlParameter("@strSQL_Where_giao_vien", strSQL_Where_giao_vien)
                    Return UDB.SelectTableSP("PLAN_TimKiemGiaoVienRoi", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":strSQL_Where_thoi_gian", strSQL_Where_thoi_gian)
                    para(1) = New OracleParameter(":strSQL_Where_giao_vien", strSQL_Where_giao_vien)
                    Return UDB.SelectTableSP("PLAN_TimKiemGiaoVienRoi", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TimKiemPhongDangHoc(ByVal strSQL_Where As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@strSQL_Where", strSQL_Where)
                    Return UDB.SelectTableSP("PLAN_TimKiemPhongDangHoc", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":strSQL_Where", strSQL_Where)
                    Return UDB.SelectTableSP("PLAN_TimKiemPhongDangHoc", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TimKiemPhongRoi(ByVal strSQL_Where_thoi_gian As String, ByVal strSQL_Where_phong As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@strSQL_Where_thoi_gian", strSQL_Where_thoi_gian)
                    para(1) = New SqlParameter("@strSQL_Where_phong", strSQL_Where_phong)
                    Return UDB.SelectTableSP("PLAN_TimKiemPhongRoi", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":strSQL_Where_thoi_gian", strSQL_Where_thoi_gian)
                    para(1) = New OracleParameter(":strSQL_Where_phong", strSQL_Where_phong)
                    Return UDB.SelectTableSP("PLAN_TimKiemPhongRoi", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKeGioGiangTKB(ByVal strSQL_Where As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@strSQL_Where", strSQL_Where)
                    Return UDB.SelectTableSP("PLAN_ThongKeGioGiangTKB", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":strSQL_Where", strSQL_Where)
                    Return UDB.SelectTableSP("PLAN_ThongKeGioGiangTKB", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKeGioGiangKeHoach(ByVal strSQL_Where As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@strSQL_Where", strSQL_Where)
                    Return UDB.SelectTableSP("PLAN_ThongKeGioGiangKeHoach", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":strSQL_Where", strSQL_Where)
                    Return UDB.SelectTableSP("PLAN_ThongKeGioGiangKeHoach", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace



