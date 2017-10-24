'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Sunday, June 01, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class KhenThuong_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_SinhVienKhenThuong(ByVal dsID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                Return UDB.SelectTableSP("STU_SinhVienKhenThuong_Load", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KhenThuong(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_KhenThuongLop_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_KhenThuongLop_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KhenThuongSV(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_KhenThuongSV_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_KhenThuongSV_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KhenThuong(ByVal ID_khen_thuong As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_khen_thuong", ID_khen_thuong)
                    Return UDB.SelectTableSP("STU_KhenThuong_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_khen_thuong", ID_khen_thuong)
                    Return UDB.SelectTableSP("STU_KhenThuong_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KhenThuong_List() As DataTable
            Try
                Return UDB.SelectTableSP("KhenThuong_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KhenThuong(ByVal obj As KhenThuong) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@So_QD", obj.So_QD)
                    para(1) = New SqlParameter("@Ngay_QD", obj.Ngay_QD)
                    para(2) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(3) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(4) = New SqlParameter("@ID_loai_kt", obj.ID_loai_kt)
                    para(5) = New SqlParameter("@Hinh_thuc", obj.Hinh_thuc)
                    para(6) = New SqlParameter("@ID_cap", obj.ID_cap)
                    Return UDB.ExecuteSP("STU_KhenThuong_Insert", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":So_QD", obj.So_QD)
                    para(1) = New OracleParameter(":Ngay_QD", obj.Ngay_QD)
                    para(2) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(3) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(4) = New OracleParameter(":ID_loai_kt", obj.ID_loai_kt)
                    para(5) = New OracleParameter(":Hinh_thuc", obj.Hinh_thuc)
                    para(6) = New OracleParameter(":ID_cap", obj.ID_cap)
                    Return UDB.ExecuteSP("STU_KhenThuong_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KhenThuongSinhVien(ByVal ID_sv As Integer, ByVal ID_khen_thuong As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_khen_thuong", ID_khen_thuong)
                    Return UDB.ExecuteSP("STU_KhenThuongSinhVien_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_khen_thuong", ID_khen_thuong)
                    Return UDB.ExecuteSP("STU_KhenThuongSinhVien_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KhenThuong(ByVal obj As KhenThuong, ByVal ID_khen_thuong As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_khen_thuong", ID_khen_thuong)
                    para(1) = New SqlParameter("@So_QD", obj.So_QD)
                    para(2) = New SqlParameter("@Ngay_QD", obj.Ngay_QD)
                    para(3) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(4) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(5) = New SqlParameter("@ID_loai_kt", obj.ID_loai_kt)
                    para(6) = New SqlParameter("@Hinh_thuc", obj.Hinh_thuc)
                    para(7) = New SqlParameter("@ID_cap", obj.ID_cap)
                    Return UDB.ExecuteSP("STU_KhenThuong_Update", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":ID_khen_thuong", ID_khen_thuong)
                    para(1) = New OracleParameter(":So_QD", obj.So_QD)
                    para(2) = New OracleParameter(":Ngay_QD", obj.Ngay_QD)
                    para(3) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(4) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(5) = New OracleParameter(":ID_loai_kt", obj.ID_loai_kt)
                    para(6) = New OracleParameter(":Hinh_thuc", obj.Hinh_thuc)
                    para(7) = New OracleParameter(":ID_cap", obj.ID_cap)
                    Return UDB.ExecuteSP("STU_KhenThuong_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KhenThuongSinhVien(ByVal ID_sv As Integer, ByVal ID_khen_thuong As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_khen_thuong", ID_khen_thuong)
                    Return UDB.ExecuteSP("STU_KhenThuongSinhVien_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_khen_thuong", ID_khen_thuong)
                    Return UDB.ExecuteSP("STU_KhenThuongSinhVien_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KhenThuong(ByVal ID_khen_thuong As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_khen_thuong", ID_khen_thuong)
                    Return UDB.ExecuteSP("STU_KhenThuong_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_khen_thuong", ID_khen_thuong)
                    Return UDB.ExecuteSP("STU_KhenThuong_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KhenThuongSinhVien(ByVal ID_khen_thuong As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_khen_thuong", ID_khen_thuong)
                    Return UDB.ExecuteSP("STU_KhenThuongSinhVien_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_khen_thuong", ID_khen_thuong)
                    Return UDB.ExecuteSP("STU_KhenThuongSinhVien_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_KhenThuong(ByVal ID_khen_thuong As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_khen_thuong", ID_khen_thuong)
                    Return UDB.ExecuteScalar("STU_KhenThuong_CheckExist", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_khen_thuong", ID_khen_thuong)
                    Return UDB.ExecuteScalar("STU_KhenThuong_CheckExist", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_KhenThuongSinhVien(ByVal ID_sv As Integer, ByVal ID_khen_thuong As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_khen_thuong", ID_khen_thuong)
                    If UDB.SelectTableSP("STU_KhenThuongSinhVien_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_khen_thuong", ID_khen_thuong)
                    If UDB.SelectTableSP("STU_KhenThuongSinhVien_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_KhenThuong() As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.ExecuteScalar("STU_KhenThuong_GetMaxID")
                Else
                    Dim para(0) As OracleParameter
                    Return UDB.ExecuteScalar("STU_KhenThuong_GetMaxID")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


