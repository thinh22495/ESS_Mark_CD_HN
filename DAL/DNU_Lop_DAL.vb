'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An Technology
' Created Date : 04/02/2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DNU_Lop_DAL

#Region "Constructor"
        Public Sub New()
            'UDB.SetConnectionString(".", "UniSoft_new", "UnisoftAdmin", "taUnisoft032003")
        End Sub
#End Region

#Region "Function"
        Public Function GetInFoSv(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return UDB.SelectTableSP("sp_svThongTinSv", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Lop_List_KhoaHoc(ByVal Khoa_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("sp_svLop_Load_Khoa_hoc", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("sp_svLop_Load_Khoa_hoc", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Lop_List_He(ByVal ID_he As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    Return UDB.SelectTableSP("sp_svLop_Load_He", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    Return UDB.SelectTableSP("sp_svLop_Load_He", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Lop_List(ByVal dsID_lop As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("sp_svLop_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("sp_svLop_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Lop_NEW(ByVal dsID_lop As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("sp_svLop_Load_NEW", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("sp_svLop_Load_NEW", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Lop_List_ChiTiet() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("sp_svLop_Load_List_ChiTiet")
                Else
                    Return UDB.SelectTableSP("sp_svLop_Load_List_ChiTiet")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhMucKhoaHoc() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim strSQL As String = "SELECT DISTINCT Khoa_hoc,Khoa_hoc FROM SVLOP"
                    Return UDB.SelectTable(strSQL)
                Else
                    Dim strORC As String = "SELECT DISTINCT Khoa_hoc,Khoa_hoc FROM SVLOP"
                    Return UDB.SelectTable(strORC)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_Exits(ByVal Ten_lop As String) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ten_lop", Ten_lop) ' Tên lớp                    
                    If UDB.SelectTableSP("sp_svLop_Check_Exits", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ten_lop", Ten_lop)                    
                    If UDB.SelectTableSP("sp_svLop_Check_Exits", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_Lop(ByVal obj As Lop) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(10) As SqlParameter
                    para(0) = New SqlParameter("@Ten_lop", obj.Ten_lop) ' Tên lớp
                    para(1) = New SqlParameter("@ID_he", obj.ID_he)
                    para(2) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(3) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    para(4) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                    para(5) = New SqlParameter("@Nien_khoa", obj.Nien_khoa)
                    para(6) = New SqlParameter("@ID_dt", obj.ID_dt)
                    para(7) = New SqlParameter("@So_sv", obj.So_sv)
                    para(8) = New SqlParameter("@Ho_ten_gv", obj.Ho_ten_gv)
                    para(9) = New SqlParameter("@Dien_thoai", obj.Dien_thoai)
                    para(10) = New SqlParameter("@Email", obj.Email)
                    Return UDB.ExecuteSP("sp_svLop_Insert", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":Ten_lop", obj.Ten_lop)
                    para(1) = New OracleParameter(":ID_he", obj.ID_he)
                    para(2) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(3) = New OracleParameter(":ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    para(4) = New OracleParameter(":Khoa_hoc", obj.Khoa_hoc)
                    para(5) = New OracleParameter(":Nien_khoa", obj.Nien_khoa)
                    para(6) = New OracleParameter(":ID_dt", obj.ID_dt)
                    para(7) = New OracleParameter(":So_sv", obj.So_sv)
                    Return UDB.ExecuteSP("sp_svLop_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Lop(ByVal obj As Lop, ByVal ID_lop As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(11) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop", ID_lop)
                    para(1) = New SqlParameter("@Ten_lop", obj.Ten_lop)
                    para(2) = New SqlParameter("@ID_he", obj.ID_he)
                    para(3) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(4) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    para(5) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                    para(6) = New SqlParameter("@Nien_khoa", obj.Nien_khoa)
                    para(7) = New SqlParameter("@ID_dt", obj.ID_dt)
                    para(8) = New SqlParameter("@So_sv", obj.So_sv)
                    para(9) = New SqlParameter("@Ho_ten_gv", obj.Ho_ten_gv)
                    para(10) = New SqlParameter("@Dien_thoai", obj.Dien_thoai)
                    para(11) = New SqlParameter("@Email", obj.Email)
                    Return UDB.ExecuteSP("sp_svLop_Update", para)
                Else
                    Dim para(8) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop", ID_lop)
                    para(1) = New OracleParameter(":Ten_lop", obj.Ten_lop)
                    para(2) = New OracleParameter(":ID_he", obj.ID_he)
                    para(3) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(4) = New OracleParameter(":ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    para(5) = New OracleParameter(":Khoa_hoc", obj.Khoa_hoc)
                    para(6) = New OracleParameter(":Nien_khoa", obj.Nien_khoa)
                    para(7) = New OracleParameter(":ID_dt", obj.ID_dt)
                    para(8) = New OracleParameter(":So_sv", obj.So_sv)
                    Return UDB.ExecuteSP("sp_svLop_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Lop_RaTruong(ByVal ID_lop As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop", ID_lop)
                    para(1) = New SqlParameter("@Ra_truong", 1)
                    Return UDB.ExecuteSP("sp_svLopRaVaoTruong_Update", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop", ID_lop)
                    para(1) = New OracleParameter(":Ra_truong", 1)
                    Return UDB.ExecuteSP("sp_svLopRaVaoTruong_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Lop_VaoTruong(ByVal ID_lop As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop", ID_lop)
                    para(1) = New SqlParameter("@Ra_truong", 0)
                    Return UDB.ExecuteSP("sp_svLopRaVaoTruong_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop", ID_lop)
                    para(1) = New OracleParameter(":Ra_truong", 0)
                    Return UDB.ExecuteSP("sp_svLopRaVaoTruong_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Lop_CaHoc(ByVal ID_lop As Integer, ByVal Ca_hoc As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop", ID_lop)
                    para(1) = New SqlParameter("@Ca_hoc", Ca_hoc)
                    Return UDB.ExecuteSP("sp_svLopCaHoc_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop", ID_lop)
                    para(1) = New OracleParameter(":Ca_hoc", Ca_hoc)
                    Return UDB.ExecuteSP("sp_svLopCaHoc_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Lop_PhongHoc(ByVal ID_lop As Integer, ByVal ID_phong As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop", ID_lop)
                    para(1) = New SqlParameter("@ID_phong", ID_phong)
                    Return UDB.ExecuteSP("sp_svLopPhongHoc_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop", ID_lop)
                    para(1) = New OracleParameter(":ID_phong", ID_phong)
                    Return UDB.ExecuteSP("sp_svLopPhongHoc_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_Lop(ByVal ID_lop As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop", ID_lop)
                    Return UDB.ExecuteSP("sp_svLop_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop", ID_lop)
                    Return UDB.ExecuteSP("sp_svLop_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region
        Public Function Load_LopCoSVHocLai(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.SelectTableSP("sp_svDangKyHocLai_DanhSachLop", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSachSVHocLai(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lop As Integer) As DataTable
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(4) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(5) = New SqlParameter("@ID_lop", ID_lop)
                Return UDB.SelectTableSP("sp_svDangKyHocLai_DanhSachSinhVien_Duyet", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
