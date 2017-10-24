'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Wednesday, 11 June, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class HoatDongXaHoi_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        'Public Function Load_HoatDongXaHoi(ByVal ID_hd_xh As Integer) As DataTable
        '    Try
        '        If gDBType = DatabaseType.SQLServer Then
        '            Dim para(1) As SqlParameter
        '            para(0) = New SqlParameter("@ID_hd_xh", ID_hd_xh)
        '            Return UDB.SelectTableSP("STU_HoatDongXaHoi_Load", para)
        '        Else
        '            Dim para(1) As OracleParameter
        '            para(0) = New OracleParameter(":ID_hd_xh", ID_hd_xh)
        '            Return UDB.SelectTableSP("STU_HoatDongXaHoi_Load", para)
        '        End If
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        Public Function Load_HoatDongXaHoi(Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0, Optional ByVal ID_lop As Integer = 0) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(3) = New SqlParameter("@ID_lop", ID_lop)
                    para(4) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(5) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("STU_HoatDongXaHoi_Load", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(3) = New OracleParameter(":ID_lop", ID_lop)
                    para(4) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(5) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("STU_HoatDongXaHoi_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_HoatDongXaHoiSv(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_HoatDongXaHoi_LoadSV", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_HoatDongXaHoi_LoadSV", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_HoatDongXaHoi_List() As DataTable
            Try
                Return UDB.SelectTableSP("HoatDongXaHoi_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_HoatDongXaHoi(ByVal obj As HoatDongXaHoi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@Ngay_thang", obj.Ngay_thang)
                    para(4) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                    para(5) = New SqlParameter("@Ket_qua", obj.Ket_qua)
                    para(6) = New SqlParameter("@Diem_thuong", obj.Diem_thuong)
                    Return UDB.ExecuteSP("STU_HoatDongXaHoi_Insert", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":Ngay_thang", obj.Ngay_thang)
                    para(4) = New OracleParameter(":Noi_dung", obj.Noi_dung)
                    para(5) = New OracleParameter(":Ket_qua", obj.Ket_qua)
                    para(6) = New OracleParameter(":Diem_thuong", obj.Diem_thuong)
                    Return UDB.ExecuteSP("STU_HoatDongXaHoi_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_HoatDongXaHoi(ByVal obj As HoatDongXaHoi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_hd_xh", obj.ID_hd_xh)
                    para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(2) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(3) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(4) = New SqlParameter("@Ngay_thang", obj.Ngay_thang)
                    para(5) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                    para(6) = New SqlParameter("@Ket_qua", obj.Ket_qua)
                    para(7) = New SqlParameter("@Diem_thuong", obj.Diem_thuong)
                    Return UDB.ExecuteSP("STU_HoatDongXaHoi_Update", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":ID_hd_xh", obj.ID_hd_xh)
                    para(1) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(2) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(3) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(4) = New OracleParameter(":Ngay_thang", obj.Ngay_thang)
                    para(5) = New OracleParameter(":Noi_dung", obj.Noi_dung)
                    para(6) = New OracleParameter(":Ket_qua", obj.Ket_qua)
                    para(7) = New OracleParameter(":Diem_thuong", obj.Diem_thuong)
                    Return UDB.ExecuteSP("STU_HoatDongXaHoi_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_HoatDongXaHoi(ByVal ID_hd_xh As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_hd_xh", ID_hd_xh)
                    Return UDB.ExecuteSP("STU_HoatDongXaHoi_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_hd_xh", ID_hd_xh)
                    Return UDB.ExecuteSP("STU_HoatDongXaHoi_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_HoatDongXaHoi(ByVal obj As HoatDongXaHoi) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    If UDB.SelectTableSP("STU_HoatDongXaHoi_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    End If
                    Return False
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    If UDB.SelectTableSP("STU_HoatDongXaHoi_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    End If
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


