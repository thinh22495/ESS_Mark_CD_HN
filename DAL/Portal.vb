Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ThienAn.Machine
Namespace DBManager
    Public Class Portal_DAL

        Public Function Load_DiemRenLuyenSinhVien(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_ptDiemRenLuyen_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_ptDiemRenLuyen_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_LichThiSinhVien(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_ptLichThi_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("sp_ptLichThi_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
End Namespace


