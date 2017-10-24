'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, May 27, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class HoSoNop_DAL
#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_LoaiGiayTo_List(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_LoaiGiayTo_Load_List", para)
                Else
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter(":ID_he", ID_he)
                    para(1) = New SqlParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_LoaiGiayTo_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_TableHoSoNop(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_TableHoSoNop_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_TableHoSoNop_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_HoSoNop(ByVal ID_sv As Integer, ByVal ID_giay_to As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_giay_to", ID_giay_to)
                    Return UDB.SelectTableSP("STU_HoSoNop_Load", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_giay_to", ID_giay_to)
                    Return UDB.SelectTableSP("STU_HoSoNop_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_HoSoNop_List(ByVal dsID_lop As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@dsID_lop", dsID_lop)
                Return UDB.SelectTableSP("STU_HoSoNop_Load_List", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_HoSoNop(ByVal obj As HoSoNop) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_giay_to", obj.ID_giay_to)
                    para(1) = New SqlParameter("@Ghi_chu_nop", obj.Ghi_chu_nop)
                    para(2) = New SqlParameter("@Ghi_chu_tra", obj.Ghi_chu_tra)
                    para(3) = New SqlParameter("@Da_tra", obj.Da_tra)
                    If obj.Ngay_tra = Nothing Then
                        para(4) = New SqlParameter("@Ngay_tra", DBNull.Value)
                    Else
                        para(4) = New SqlParameter("@Ngay_tra", obj.Ngay_tra)
                    End If
                    para(5) = New SqlParameter("@ID_sv", obj.ID_sv)
                    Return UDB.ExecuteSP("STU_HoSoNop_Insert", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_giay_to", obj.ID_giay_to)
                    para(1) = New OracleParameter(":Ghi_chu_nop", obj.Ghi_chu_nop)
                    para(2) = New OracleParameter(":Ghi_chu_tra", obj.Ghi_chu_tra)
                    para(3) = New OracleParameter(":Da_tra", obj.Da_tra)
                    If obj.Ngay_tra = Nothing Then
                        para(4) = New OracleParameter(":Ngay_tra", DBNull.Value)
                    Else
                        para(4) = New OracleParameter(":Ngay_tra", obj.Ngay_tra)
                    End If
                    para(5) = New OracleParameter(":ID_sv", obj.ID_sv)
                    Return UDB.ExecuteSP("STU_HoSoNop_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_HoSoNop(ByVal obj As HoSoNop) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@ID_giay_to", obj.ID_giay_to)
                    para(2) = New SqlParameter("@Ghi_chu_nop", obj.Ghi_chu_nop)
                    para(3) = New SqlParameter("@Ghi_chu_tra", obj.Ghi_chu_tra)
                    para(4) = New SqlParameter("@Da_tra", obj.Da_tra)
                    If obj.Ngay_tra = Nothing Then
                        para(5) = New SqlParameter("@Ngay_tra", DBNull.Value)
                    Else
                        para(5) = New SqlParameter("@Ngay_tra", obj.Ngay_tra)
                    End If
                    Return UDB.ExecuteSP("STU_HoSoNop_Update", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":ID_giay_to", obj.ID_giay_to)
                    para(2) = New OracleParameter(":Ghi_chu_nop", obj.Ghi_chu_nop)
                    para(3) = New OracleParameter(":Ghi_chu_tra", obj.Ghi_chu_tra)
                    para(4) = New OracleParameter(":Da_tra", obj.Da_tra)
                    If obj.Ngay_tra = Nothing Then
                        para(5) = New OracleParameter(":Ngay_tra", DBNull.Value)
                    Else
                        para(5) = New OracleParameter(":Ngay_tra", obj.Ngay_tra)
                    End If
                    Return UDB.ExecuteSP("STU_HoSoNop_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_HoSoNop(ByVal ID_sv As Integer, ByVal ID_giay_to As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_giay_to", ID_giay_to)
                    Return UDB.ExecuteSP("STU_HoSoNop_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_giay_to", ID_giay_to)
                    Return UDB.ExecuteSP("STU_HoSoNop_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_HoSoNop(ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_HoSoNopSV_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_HoSoNopSV_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_HoSoNop(ByVal ID_sv As Integer, ByVal ID_giay_to As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_giay_to", ID_giay_to)
                    If UDB.SelectTableSP("STU_HoSoNop_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_giay_to", ID_giay_to)
                    If UDB.SelectTableSP("STU_HoSoNop_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_HoSoNop(ByVal ID_sv As Integer, ByVal ID_giay_to As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_giay_to", ID_giay_to)
                    Return UDB.ExecuteScalar("STU_HoSoNop_GetMaxID", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_giay_to", ID_giay_to)
                    Return UDB.ExecuteScalar("STU_HoSoNop_GetMaxID", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_GiayTo_ThayThe() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("STU_GiayToSinhVien_Load")
                Else
                    Return UDB.SelectTableSP("STU_GiayToSinhVien_Load")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


