'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Wednesday, April 08, 2009
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class KeHoachLop_DAL
#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_KeHoachLop_List(ByVal ID_kh As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh", ID_kh)
                    Return UDB.SelectTableSP("PLAN_KeHoachLop_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh", ID_kh)
                    Return UDB.SelectTableSP("PLAN_KeHoachLop_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KeHoachLop(ByVal obj As KeHoachLop) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New SqlParameter("@ID_lop", obj.ID_lop)
                    para(2) = New SqlParameter("@ID_ky_hieu", obj.ID_ky_hieu)
                    Return UDB.ExecuteSP("PLAN_KeHoachLop_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New OracleParameter(":ID_lop", obj.ID_lop)
                    para(2) = New OracleParameter(":ID_ky_hieu", obj.ID_ky_hieu)
                    Return UDB.ExecuteSP("PLAN_KeHoachLop_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachLop(ByVal obj As KeHoachLop, ByVal ID_kh_lop As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_lop", ID_kh_lop)
                    para(1) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(2) = New SqlParameter("@ID_lop", obj.ID_lop)
                    para(3) = New SqlParameter("@ID_ky_hieu", obj.ID_ky_hieu)
                    Return UDB.ExecuteSP("PLAN_KeHoachLop_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_lop", ID_kh_lop)
                    para(1) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(2) = New OracleParameter(":ID_lop", obj.ID_lop)
                    para(3) = New OracleParameter(":ID_ky_hieu", obj.ID_ky_hieu)
                    Return UDB.ExecuteSP("PLAN_KeHoachLop_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KeHoachLop(ByVal ID_kh_tuan As Integer, ByVal ID_lop As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    para(1) = New SqlParameter("@ID_lop", ID_lop)
                    Return UDB.ExecuteSP("PLAN_KeHoachLop_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", ID_kh_tuan)
                    para(1) = New OracleParameter(":ID_lop", ID_lop)
                    Return UDB.ExecuteSP("PLAN_KeHoachLop_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KeHoachNam_KeHoachTotNghiep() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_KeHoachNam_KeHoachTotNghiep")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KeHoachNam_SoLopHoc() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_KeHoachNam_SoLopHoc")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KeHoachNam_ChiTieuTuyenSinh() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_KeHoachNam_ChiTieuTuyenSinh")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KeHoachNam_List() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_KeHoachNam_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KeHoachNam(ByVal Nam_hoc As String, ByVal Tu_ngay As Date, ByVal Den_ngay As Date) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(1) = New SqlParameter("@Tu_ngay", Tu_ngay)
                    para(2) = New SqlParameter("@Den_ngay", Den_ngay)
                    Return UDB.ExecuteSP("PLAN_KeHoachNam_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(1) = New OracleParameter(":Tu_ngay", Tu_ngay)
                    para(2) = New OracleParameter(":Den_ngay", Den_ngay)
                    Return UDB.ExecuteSP("PLAN_KeHoachNam_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachNam(ByVal ID_kh As Integer, ByVal Nam_hoc As String, ByVal Tu_ngay As Date, ByVal Den_ngay As Date) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh", ID_kh)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@Tu_ngay", Tu_ngay)
                    para(3) = New SqlParameter("@Den_ngay", Den_ngay)
                    Return UDB.ExecuteSP("PLAN_KeHoachNam_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh", ID_kh)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":Tu_ngay", Tu_ngay)
                    para(3) = New OracleParameter(":Den_ngay", Den_ngay)
                    Return UDB.ExecuteSP("PLAN_KeHoachNam_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KeHoachNam(ByVal ID_kh As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh", ID_kh)
                    Return UDB.ExecuteSP("PLAN_KeHoachNam_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh", ID_kh)
                    Return UDB.ExecuteSP("PLAN_KeHoachNam_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_KeHoachNam(ByVal Nam_hoc As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    Dim dt As DataTable
                    para(0) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    dt = UDB.SelectTableSP("PLAN_KeHoachNam_CheckExist", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)("ID_kh")
                    Else
                        Return 0
                    End If
                Else
                    Dim para(0) As OracleParameter
                    Dim dt As DataTable
                    para(0) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    dt = UDB.SelectTableSP("PLAN_KeHoachNam_CheckExist", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)("ID_kh")
                    Else
                        Return 0
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KeHoachTuan_List(ByVal ID_kh As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh", ID_kh)
                    Return UDB.SelectTableSP("PLAN_KeHoachTuan_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh", ID_kh)
                    Return UDB.SelectTableSP("PLAN_KeHoachTuan_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KeHoachTuan(ByVal ID_kh As Integer, ByVal Tuan_thu As Integer, ByVal Tu_ngay As Date, ByVal Den_ngay As Date) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh", ID_kh)
                    para(1) = New SqlParameter("@Tuan_thu", Tuan_thu)
                    para(2) = New SqlParameter("@Tu_ngay", Tu_ngay)
                    para(3) = New SqlParameter("@Den_ngay", Den_ngay)
                    Return UDB.ExecuteSP("PLAN_KeHoachTuan_Insert", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh", ID_kh)
                    para(1) = New OracleParameter(":Tuan_thu", Tuan_thu)
                    para(2) = New OracleParameter(":Tu_ngay", Tu_ngay)
                    para(3) = New OracleParameter(":Den_ngay", Den_ngay)
                    Return UDB.ExecuteSP("PLAN_KeHoachTuan_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachTuan(ByVal ID_kh_tuan As Integer, ByVal ID_kh As Integer, ByVal Tuan_thu As Integer, ByVal Tu_ngay As Date, ByVal Den_ngay As Date) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    para(1) = New SqlParameter("@ID_kh", ID_kh)
                    para(2) = New SqlParameter("@Tuan_thu", Tuan_thu)
                    para(3) = New SqlParameter("@Tu_ngay", Tu_ngay)
                    para(4) = New SqlParameter("@Den_ngay", Den_ngay)
                    Return UDB.ExecuteSP("PLAN_KeHoachTuan_Update", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", ID_kh_tuan)
                    para(1) = New OracleParameter(":ID_kh", ID_kh)
                    para(2) = New OracleParameter(":Tuan_thu", Tuan_thu)
                    para(3) = New OracleParameter(":Tu_ngay", Tu_ngay)
                    para(4) = New OracleParameter(":Den_ngay", Den_ngay)
                    Return UDB.ExecuteSP("PLAN_KeHoachTuan_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace


