'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Saturday, August 09, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DanhSachHocBong_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_HocBongSinhVien(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_HocBongSinhVien_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_HocBongSinhVien_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSachHocBong_List(ByVal dsID_lop As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("STU_DanhSachHocBong_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("STU_DanhSachHocBong_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DoiTuongHocBong() As DataTable
            Try
                Return UDB.SelectTableSP("STU_DoiTuongHocBong_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSachTroCap(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("STU_DanhSachTroCap_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("STU_DanhSachTroCap_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DanhSachHocBong(ByVal obj As DanhSachHocBong) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_phan_bo", obj.ID_phan_bo)
                    para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(2) = New SqlParameter("@ID_xep_loai_hb", obj.ID_xep_loai_hb)
                    para(3) = New SqlParameter("@HB_HT", obj.HB_HT)
                    para(4) = New SqlParameter("@HB_CS", obj.HB_CS)
                    Return UDB.ExecuteSP("STU_DanhSachHocBong_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_phan_bo", obj.ID_phan_bo)
                    para(1) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(2) = New OracleParameter(":ID_xep_loai_hb", obj.ID_xep_loai_hb)
                    para(3) = New OracleParameter(":HB_HT", obj.HB_HT)
                    para(4) = New OracleParameter(":HB_CS", obj.HB_CS)
                    Return UDB.ExecuteSP("STU_DanhSachHocBong_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSachHocBong(ByVal obj As DanhSachHocBong, ByVal ID_phan_bo As Integer, ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    para(2) = New SqlParameter("@ID_xep_loai_hb", obj.ID_xep_loai_hb)
                    para(3) = New SqlParameter("@HB_HT", obj.HB_HT)
                    para(4) = New SqlParameter("@HB_CS", obj.HB_CS)
                    Return UDB.ExecuteSP("STU_DanhSachHocBong_Update", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_phan_bo", ID_phan_bo)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    para(2) = New OracleParameter(":ID_xep_loai_hb", obj.ID_xep_loai_hb)
                    para(3) = New OracleParameter(":HB_HT", obj.HB_HT)
                    para(4) = New OracleParameter(":HB_CS", obj.HB_CS)
                    Return UDB.ExecuteSP("STU_DanhSachHocBong_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSachHocBong(ByVal ID_phan_bo As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                    Return UDB.ExecuteSP("STU_DanhSachHocBong_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_phan_bo", ID_phan_bo)
                    Return UDB.ExecuteSP("STU_DanhSachHocBong_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSachHocBong_SinhVien(ByVal ID_phan_bo As Integer, ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                    para(1) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_DanhSachHocBong_SinhVien_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_phan_bo", ID_phan_bo)
                    para(1) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_DanhSachHocBong_SinhVien_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


