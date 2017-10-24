'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, June 03, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class PortalHosoSinhVien_DAL
        Public Function Load_ThongTinSinhVien_Full(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("ptThongTinSinhVienFull_Load", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("ptThongTinSinhVienFull_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ThongTinSinhVien(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("ptThongTinSinhVien_Load", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("ptThongTinSinhVien_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace


