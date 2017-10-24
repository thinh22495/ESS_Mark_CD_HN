Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class NoKhacKhiXetTotNghiep_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"

        Public Function DanhSachNoKhacKhiXetTotNghiep_Load_List(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("MARK_NoKhacKhiXetTotNghiep_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("MARK_NoKhacKhiXetTotNghiep_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_NoKhacKhiXetTotNghiep(ByVal obj As NoKhacKhiXetTotNghiep) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("MARK_NoKhacKhiXetTotNghiep_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("MARK_NoKhacKhiXetTotNghiep_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_NoKhacKhiXetTotNghiep(ByVal obj As NoKhacKhiXetTotNghiep, ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("MARK_NoKhacKhiXetTotNghiep_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("MARK_NoKhacKhiXetTotNghiep_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_NoKhacKhiXetTotNghiep(ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.ExecuteSP("MARK_NoKhacKhiXetTotNghiep_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.ExecuteSP("MARK_NoKhacKhiXetTotNghiep_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

