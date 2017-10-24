'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Thursday, July 31, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class MucThuKhacSinhVien_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_MucThuKhacSinhVien_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("ACC_MucThuKhacSinhVien_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("ACC_MucThuKhacSinhVien_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_MucThuKhacSinhVien(ByVal obj As MucThuKhacSinhVien) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(2) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(3) = New SqlParameter("@ID_thu_chi", obj.ID_thu_chi)
                    para(4) = New SqlParameter("@So_tien", obj.So_tien)
                    para(5) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("ACC_MucThuKhacSinhVien_Insert", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(2) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(3) = New OracleParameter(":ID_thu_chi", obj.ID_thu_chi)
                    para(4) = New OracleParameter(":So_tien", obj.So_tien)
                    para(5) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("ACC_MucThuKhacSinhVien_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_MucThuKhacSinhVien(ByVal obj As MucThuKhacSinhVien) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(2) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(3) = New SqlParameter("@ID_thu_chi", obj.ID_thu_chi)
                    para(4) = New SqlParameter("@So_tien", obj.So_tien)
                    para(5) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("ACC_MucThuKhacSinhVien_Update", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(2) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(3) = New OracleParameter(":ID_thu_chi", obj.ID_thu_chi)
                    para(4) = New OracleParameter(":So_tien", obj.So_tien)
                    para(5) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("ACC_MucThuKhacSinhVien_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_MucThuKhacSinhVien(ByVal objMucThuKhacSinhVien As MucThuKhacSinhVien) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", objMucThuKhacSinhVien.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", objMucThuKhacSinhVien.Nam_hoc)
                    para(2) = New SqlParameter("@ID_sv", objMucThuKhacSinhVien.ID_sv)
                    para(3) = New SqlParameter("@ID_thu_chi", objMucThuKhacSinhVien.ID_thu_chi)
                    Return UDB.ExecuteSP("ACC_MucThuKhacSinhVien_Delete", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", objMucThuKhacSinhVien.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", objMucThuKhacSinhVien.Nam_hoc)
                    para(2) = New OracleParameter(":ID_sv", objMucThuKhacSinhVien.ID_sv)
                    para(3) = New OracleParameter(":ID_thu_chi", objMucThuKhacSinhVien.ID_thu_chi)
                    Return UDB.ExecuteSP("ACC_MucThuKhacSinhVien_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_MucThuKhacSinhVien(ByVal objMucThuKhacSinhVien As MucThuKhacSinhVien) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", objMucThuKhacSinhVien.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", objMucThuKhacSinhVien.Nam_hoc)
                    para(2) = New SqlParameter("@ID_sv", objMucThuKhacSinhVien.ID_sv)
                    para(3) = New SqlParameter("@ID_thu_chi", objMucThuKhacSinhVien.ID_thu_chi)
                    If UDB.SelectTableSP("ACC_MucThuKhacSinhVien_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", objMucThuKhacSinhVien.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", objMucThuKhacSinhVien.Nam_hoc)
                    para(2) = New OracleParameter(":ID_sv", objMucThuKhacSinhVien.ID_sv)
                    para(3) = New OracleParameter(":ID_thu_chi", objMucThuKhacSinhVien.ID_thu_chi)
                    If UDB.SelectTableSP("ACC_MucThuKhacSinhVien_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


