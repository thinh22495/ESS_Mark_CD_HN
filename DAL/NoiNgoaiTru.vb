'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Sunday, 25 May, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class NoiNgoaiTru_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_NoiNgoaiTru(ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Tu_ngay", Tu_ngay)
                    Return UDB.SelectTableSP("STU_NoiNgoaiTru_Load", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Tu_ngay", Tu_ngay)
                    Return UDB.SelectTableSP("STU_NoiNgoaiTru_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_PhongKyTucXa() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("STU_PhongKyTucXa_Load")
                Else
                    Return UDB.SelectTableSP("STU_PhongKyTucXa_Load")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_NoiNgoaiTru(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_NoiNgoaiTru_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_NoiNgoaiTru_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_NoiNgoaiTru(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_NoiNgoaiTruSV_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_NoiNgoaiTruSV_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_NoiNgoaiTru_List() As DataTable
            Try
                Return UDB.SelectTableSP("NoiNgoaiTru_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_NgoaiTru(ByVal obj As NoiNgoaiTru) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                    para(1) = New SqlParameter("@Dia_chi", obj.Dia_chi)
                    para(2) = New SqlParameter("@Dien_thoai", obj.Dien_thoai)
                    para(3) = New SqlParameter("@Ten_chu_ho", obj.Ten_chu_ho)
                    para(4) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    para(5) = New SqlParameter("@ID_sv", obj.ID_sv)
                    Return UDB.ExecuteSP("STU_NgoaiTru_Insert", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":Tu_ngay", obj.Tu_ngay)
                    para(1) = New OracleParameter(":Dia_chi", obj.Dia_chi)
                    para(2) = New OracleParameter(":Dien_thoai", obj.Dien_thoai)
                    para(3) = New OracleParameter(":Ten_chu_ho", obj.Ten_chu_ho)
                    para(4) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    para(5) = New OracleParameter(":ID_sv", obj.ID_sv)
                    Return UDB.ExecuteSP("STU_NgoaiTru_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_NoiTru(ByVal obj As NoiNgoaiTru) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                    para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(2) = New SqlParameter("@ID_phong_ktx", obj.ID_phong_ktx)
                    para(3) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    para(4) = New SqlParameter("@Dien_thoai", obj.Dien_thoai)
                    Return UDB.ExecuteSP("STU_NoiTru_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":Tu_ngay", obj.Tu_ngay)
                    para(1) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(2) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    para(3) = New OracleParameter(":ID_phong_ktx", obj.ID_phong_ktx)
                    para(4) = New OracleParameter(":Dien_thoai", obj.Dien_thoai)
                    Return UDB.ExecuteSP("STU_NoiTru_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_NoiNgoaiTru(ByVal obj As NoiNgoaiTru, ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(8) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Tu_ngay", Tu_ngay)
                    para(2) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                    para(3) = New SqlParameter("@ID_phong_ktx", obj.ID_phong_ktx)
                    para(4) = New SqlParameter("@Dia_chi", obj.Dia_chi)
                    para(5) = New SqlParameter("@Dien_thoai", obj.Dien_thoai)
                    para(6) = New SqlParameter("@Ten_chu_ho", obj.Ten_chu_ho)
                    para(7) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    para(8) = New SqlParameter("@Trang_thai", obj.Trang_thai)
                    Return UDB.ExecuteSP("STU_NoiNgoaiTru_Update", para)
                Else
                    Dim para(8) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Tu_ngay", Tu_ngay)
                    para(2) = New OracleParameter(":Den_ngay", obj.Den_ngay)
                    para(3) = New OracleParameter(":ID_phong_ktx", obj.ID_phong_ktx)
                    para(4) = New OracleParameter(":Dia_chi", obj.Dia_chi)
                    para(5) = New OracleParameter(":Dien_thoai", obj.Dien_thoai)
                    para(6) = New OracleParameter(":Ten_chu_ho", obj.Ten_chu_ho)
                    para(7) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    para(8) = New OracleParameter(":Trang_thai", obj.Trang_thai)
                    Return UDB.ExecuteSP("STU_NoiNgoaiTru_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_NoiNgoaiTru_TrangThai(ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Trang_thai", 0)
                    Return UDB.ExecuteSP("STU_NoiNgoaiTru_TrangThai_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Trang_thai", 0)
                    Return UDB.ExecuteSP("STU_NoiNgoaiTru_TrangThai_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_NoiNgoaiTru_DenNgay(ByVal ID_sv As Integer, ByVal Den_ngay As Date) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Den_ngay", Den_ngay)
                    Return UDB.ExecuteSP("STU_NoiNgoaiTru_DenNgay_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter("@Den_ngay", Den_ngay)
                    Return UDB.ExecuteSP("STU_NoiNgoaiTru_DenNgay_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_NoiNgoaiTru(ByVal ID_sv As Integer, ByVal Tu_ngay As Date, ByVal ID_phong_ktx As Integer, ByVal Trang_thai As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Tu_ngay", Tu_ngay)
                    para(2) = New SqlParameter("@ID_phong_ktx", ID_phong_ktx)
                    para(3) = New SqlParameter("@Trang_thai", Trang_thai)
                    Return UDB.ExecuteSP("STU_NoiNgoaiTru_Delete", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Tu_ngay", Tu_ngay)
                    para(2) = New OracleParameter(":ID_phong_ktx", ID_phong_ktx)
                    para(3) = New OracleParameter(":Trang_thai", Trang_thai)
                    Return UDB.ExecuteSP("STU_NoiNgoaiTru_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Kiểm tra xem từ ngày này đã hớn hơn chưa
        Public Function CheckExist_NoiNgoaiTru(ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Tu_ngay", Tu_ngay)
                    Dim dt As DataTable = UDB.SelectTableSP("STU_NoiNgoaiTru_CheckExist", para)
                    If dt.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Tu_ngay", Tu_ngay)
                    Dim dt As DataTable = UDB.SelectTableSP("STU_NoiNgoaiTru_CheckExist", para)
                    If dt.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''Kiểm tra xem sinh viên này đã đăng ký nội trú hay ngoại trú chưa?
        Public Function CheckExist_NoiNgoaiTru(ByVal ID_sv As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Dim dt As DataTable = UDB.SelectTableSP("STU_NoiNgoaiTru_CheckExist1", para)
                    If dt.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Dim dt As DataTable = UDB.SelectTableSP("STU_NoiNgoaiTru_CheckExist1", para)
                    If dt.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_NoiNgoaiTru(ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Tu_ngay", Tu_ngay)
                    Return UDB.ExecuteScalar("STU_NoiNgoaiTru_GetMaxID", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Tu_ngay", Tu_ngay)
                    Return UDB.ExecuteScalar("STU_NoiNgoaiTru_GetMaxID", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


