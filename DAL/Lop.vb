'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/02/2008
'---------------------------------------------------------------------------


Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class Lop_DAL

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
                Return UDB.SelectTableSP("STU_ThongTinSv", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Lop_List_KhoaHoc(ByVal Khoa_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_Lop_Load_Khoa_hoc", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_Lop_Load_Khoa_hoc", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ChuyenNhanh(ByVal Id_he As Integer, ByVal Id_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Dim para(2) As SqlParameter
            para(0) = New SqlParameter("@Id_he", Id_he)
            para(1) = New SqlParameter("@Id_khoa", Id_khoa)
            para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
            Return UDB.SelectTableSP("MARK_LoadChuyenNganh_SaoChep", para)
        End Function
        Public Function Load_Lop_List_He(ByVal ID_he As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    Return UDB.SelectTableSP("STU_Lop_Load_He", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    Return UDB.SelectTableSP("STU_Lop_Load_He", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Lop_List(ByVal dsID_lop As String, ByVal Tinh_chat As Integer, ByVal Lop_chuyen_nganh As Integer, ByVal Lop_hanh_chinh As Integer) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@dsID_lop", dsID_lop)
                para(1) = New SqlParameter("@Tinh_chat", Tinh_chat)
                para(2) = New SqlParameter("@Lop_chuyen_nganh", Lop_chuyen_nganh)
                para(3) = New SqlParameter("@Lop_hanh_chinh", Lop_hanh_chinh)
                Return UDB.SelectTableSP("STU_Lop_Load_List", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Lop_List_ChiTiet() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("STU_Lop_Load_List_ChiTiet")
                Else
                    Return UDB.SelectTableSP("STU_Lop_Load_List_ChiTiet")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhMucKhoaHoc() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim strSQL As String = "SELECT DISTINCT Khoa_hoc,Khoa_hoc FROM STU_Lop"
                    Return UDB.SelectTable(strSQL)
                Else
                    Dim strORC As String = "SELECT DISTINCT Khoa_hoc,Khoa_hoc FROM STU_Lop"
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
                    If UDB.SelectTableSP("STU_Lop_Check_Exits", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ten_lop", Ten_lop)
                    If UDB.SelectTableSP("STU_Lop_Check_Exits", para).Rows.Count > 0 Then
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
                    Return UDB.ExecuteSP("STU_Lop_Insert", para)
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
                    Return UDB.ExecuteSP("STU_Lop_Insert", para)
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
                    Return UDB.ExecuteSP("STU_Lop_Update", para)
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
                    Return UDB.ExecuteSP("STU_Lop_Update", para)
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
                    Return UDB.ExecuteSP("STU_LopRaVaoTruong_Update", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop", ID_lop)
                    para(1) = New OracleParameter(":Ra_truong", 1)
                    Return UDB.ExecuteSP("STU_LopRaVaoTruong_Update", para)
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
                    Return UDB.ExecuteSP("STU_LopRaVaoTruong_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop", ID_lop)
                    para(1) = New OracleParameter(":Ra_truong", 0)
                    Return UDB.ExecuteSP("STU_LopRaVaoTruong_Update", para)
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
                    Return UDB.ExecuteSP("STU_LopCaHoc_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop", ID_lop)
                    para(1) = New OracleParameter(":Ca_hoc", Ca_hoc)
                    Return UDB.ExecuteSP("STU_LopCaHoc_Update", para)
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
                    Return UDB.ExecuteSP("STU_LopPhongHoc_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop", ID_lop)
                    para(1) = New OracleParameter(":ID_phong", ID_phong)
                    Return UDB.ExecuteSP("STU_LopPhongHoc_Update", para)
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
                    Return UDB.ExecuteSP("STU_Lop_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop", ID_lop)
                    Return UDB.ExecuteSP("STU_Lop_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

    End Class
End Namespace


