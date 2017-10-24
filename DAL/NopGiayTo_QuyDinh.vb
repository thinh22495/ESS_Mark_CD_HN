Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class NopGiayTo_QuyDinh_DAL
        Public Function getLop_TheoDK(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.ExecuteScalar("STU_Lop_Load_TheoDK", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.ExecuteScalar("STU_Lop_Load_TheoDK", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getLoai_GiayTo_TheoHe(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_LoaiGiayTo_Load_QuyDinhGiayToNop", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_LoaiGiayTo_Load_QuyDinhGiayToNop", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_Loai_GiayTo_TheoHe(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_giay_to As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(2) = New SqlParameter("@ID_giay_to", ID_giay_to)
                    Return UDB.ExecuteSP("STU_LoaiGiayTo_Load_QuyDinhGiayToNop_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(2) = New OracleParameter(":ID_giay_to", ID_giay_to)
                    Return UDB.ExecuteSP("STU_LoaiGiayTo_Load_QuyDinhGiayToNop_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_GiayTo_TheoHe(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_giay_to As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(2) = New SqlParameter("@ID_giay_to", ID_giay_to)
                    Return UDB.ExecuteSP("STU_LoaiGiayTo_Load_QuyDinhGiayToNop_delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(2) = New OracleParameter(":ID_giay_to", ID_giay_to)
                    Return UDB.ExecuteSP("STU_LoaiGiayTo_Load_QuyDinhGiayToNop_delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_GiayTo_TheoHe(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_giay_to As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(2) = New SqlParameter("@ID_giay_to", ID_giay_to)
                    If UDB.SelectTableSP("STU_LoaiGiayTo_Load_QuyDinhGiayToNop_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(2) = New OracleParameter(":ID_giay_to", ID_giay_to)
                    If UDB.SelectTableSP("STU_LoaiGiayTo_Load_QuyDinhGiayToNop_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace


