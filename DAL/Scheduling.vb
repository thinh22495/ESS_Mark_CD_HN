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
    Public Class Scheduling_DLL
        Public Sub New()
        
        End Sub
        Public Function SuKiens_Count(ByVal ID_kh_tuan As Integer) As Integer
            ' Đếm số sự kiện của tuần trong bảng Sự kiện
            ' nếu chưa có thì chúng ta phải đọc dữ liệu từ bảng Kế hoạch môn
            ' còn không chúng ta sẽ đọc trong bảng sự kiện
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    Return UDB.SelectTableSP("PLAN_Sukiens_CheckExist", para).Rows.Count
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", ID_kh_tuan)
                    Return UDB.SelectTableSP("PLAN_Sukiens_CheckExist", para).Rows.Count
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_Sukiens(ByVal obj As Su_kien) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(12) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New SqlParameter("@ID_lop", obj.ID_lop)
                    para(2) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(3) = New SqlParameter("@ID_phong", obj.ID_phong)
                    para(4) = New SqlParameter("@ID_cb", obj.ID_cb)
                    para(5) = New SqlParameter("@Ca_hoc", obj.Ca_hoc)
                    para(6) = New SqlParameter("@Thu", obj.Thu)
                    para(7) = New SqlParameter("@Tiet", obj.Tiet)
                    para(8) = New SqlParameter("@So_tiet", obj.So_tiet)
                    para(9) = New SqlParameter("@Loai_tiet", obj.Loai_tiet)
                    para(10) = New SqlParameter("@Da_xep_lich", obj.Da_xep_lich)
                    para(11) = New SqlParameter("@Locked", obj.Locked)
                    para(12) = New SqlParameter("@Top_thu", obj.Top_thu)
                    Return UDB.ExecuteSP("PLAN_Sukiens_Insert", para)
                Else
                    Dim para(12) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New OracleParameter(":ID_lop", obj.ID_lop)
                    para(2) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(3) = New OracleParameter(":ID_phong", obj.ID_phong)
                    para(4) = New OracleParameter(":ID_cb", obj.ID_cb)
                    para(5) = New OracleParameter(":Ca_hoc", obj.Ca_hoc)
                    para(6) = New OracleParameter(":Thu", obj.Thu)
                    para(7) = New OracleParameter(":Tiet", obj.Tiet)
                    para(8) = New OracleParameter(":So_tiet", obj.So_tiet)
                    para(9) = New OracleParameter(":Loai_tiet", obj.Loai_tiet)
                    para(10) = New OracleParameter(":Da_xep_lich", obj.Da_xep_lich)
                    para(11) = New OracleParameter(":Locked", obj.Locked)
                    para(12) = New OracleParameter(":Top_thu", obj.Top_thu)
                    Return UDB.ExecuteSP("PLAN_Sukiens_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Sukiens(ByVal obj As Su_kien, ByVal ID As Long) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(13) As SqlParameter
                    para(0) = New SqlParameter("@ID", ID)
                    para(1) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(2) = New SqlParameter("@ID_lop", obj.ID_lop)
                    para(3) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(4) = New SqlParameter("@ID_phong", obj.ID_phong)
                    para(5) = New SqlParameter("@ID_cb", obj.ID_cb)
                    para(6) = New SqlParameter("@Ca_hoc", obj.Ca_hoc)
                    para(7) = New SqlParameter("@Thu", obj.Thu)
                    para(8) = New SqlParameter("@Tiet", obj.Tiet)
                    para(9) = New SqlParameter("@So_tiet", obj.So_tiet)
                    para(10) = New SqlParameter("@Loai_tiet", obj.Loai_tiet)
                    para(11) = New SqlParameter("@Da_xep_lich", obj.Da_xep_lich)
                    para(12) = New SqlParameter("@Locked", obj.Locked)
                    para(13) = New SqlParameter("@Top_thu", obj.Top_thu)
                    Return UDB.ExecuteSP("PLAN_Sukiens_Update", para)
                Else
                    Dim para(13) As OracleParameter
                    para(0) = New OracleParameter(":ID", ID)
                    para(1) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(2) = New OracleParameter(":ID_lop", obj.ID_lop)
                    para(3) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(4) = New OracleParameter(":ID_phong", obj.ID_phong)
                    para(5) = New OracleParameter(":ID_cb", obj.ID_cb)
                    para(6) = New OracleParameter(":Ca_hoc", obj.Ca_hoc)
                    para(7) = New OracleParameter(":Thu", obj.Thu)
                    para(8) = New OracleParameter(":Tiet", obj.Tiet)
                    para(9) = New OracleParameter(":So_tiet", obj.So_tiet)
                    para(10) = New OracleParameter(":Loai_tiet", obj.Loai_tiet)
                    para(11) = New OracleParameter(":Da_xep_lich", obj.Da_xep_lich)
                    para(12) = New OracleParameter(":Locked", obj.Locked)
                    para(13) = New OracleParameter(":Top_thu", obj.Top_thu)
                    Return UDB.ExecuteSP("PLAN_Sukiens_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_Sukiens(ByVal ID_kh_tuan As Long) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    Return UDB.ExecuteSP("PLAN_Sukiens_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", ID_kh_tuan)
                    Return UDB.ExecuteSP("PLAN_Sukiens_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SuKiensTinChi_Read_from_KHM(ByVal ID_kh_tuan As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    Return UDB.SelectTableSP("PLAN_Sukiens_Select_Kehoach", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", ID_kh_tuan)
                    Return UDB.SelectTableSP("PLAN_Sukiens_Select_Kehoach", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SuKiensTinChi_Read_from_sukien(ByVal ID_kh_tuan As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    Return UDB.SelectTableSP("PLAN_Sukiens_Select_SuKien", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", ID_kh_tuan)
                    Return UDB.SelectTableSP("PLAN_Sukiens_Select_SuKien", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SuKienKhacLop(ByVal ID_kh_tuan As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    Return UDB.SelectTableSP("PLAN_SkKhacLop_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", ID_kh_tuan)
                    Return UDB.SelectTableSP("PLAN_SkKhacLop_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SuKienKhacLopHocKy(ByVal ID_kh As Integer, ByVal ID_lop As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh", ID_kh)
                    para(1) = New SqlParameter("@ID_lop", ID_lop)
                    Return UDB.SelectTableSP("PLAN_SkKhacLopHocKy_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh", ID_kh)
                    para(1) = New OracleParameter(":ID_lop", ID_lop)
                    Return UDB.SelectTableSP("PLAN_SkKhacLopHocKy_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SuKienKhacTruong(ByVal ID_kh_tuan As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    Return UDB.SelectTableSP("PLAN_SkKhacTruong_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", ID_kh_tuan)
                    Return UDB.SelectTableSP("PLAN_SkKhacTruong_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SuKienKhacTruongHocKy(ByVal ID_kh As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh", ID_kh)
                    Return UDB.SelectTableSP("PLAN_SkKhacTruongHocKy_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh", ID_kh)
                    Return UDB.SelectTableSP("PLAN_SkKhacTruongHocKy_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SuKienKhacPhong(ByVal ID_kh_tuan As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    Return UDB.SelectTableSP("PLAN_SkKhacPhong_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", ID_kh_tuan)
                    Return UDB.SelectTableSP("PLAN_SkKhacPhong_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SuKienKhacPhongHocKy(ByVal ID_kh As Integer, ByVal ID_phong As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh", ID_kh)
                    para(1) = New SqlParameter("@ID_phong", ID_phong)
                    Return UDB.SelectTableSP("PLAN_SkKhacPhongHocKy_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh", ID_kh)
                    para(1) = New OracleParameter(":ID_phong", ID_phong)
                    Return UDB.SelectTableSP("PLAN_SkKhacPhongHocKy_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SuKienKhacGiaoVien(ByVal ID_kh_tuan As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    Return UDB.SelectTableSP("PLAN_SkKhacGiaoVien_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ky_dang_ky", ID_kh_tuan)
                    Return UDB.SelectTableSP("PLAN_SkKhacGiaoVien_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SuKienKhacGiaoVienHocKy(ByVal ID_kh As Integer, ByVal ID_cb As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh", ID_kh)
                    para(1) = New SqlParameter("@ID_cb", ID_cb)
                    Return UDB.SelectTableSP("PLAN_SkKhacGiaoVienHocKy_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh", ID_kh)
                    para(1) = New OracleParameter(":ID_cb", ID_cb)
                    Return UDB.SelectTableSP("PLAN_SkKhacGiaoVienHocKy_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub SuKiensKhacGiaoVien_Save(ByVal obj As Sukien_gv)
            If obj.ID = -1 Then
                If obj.Mo_ta.Trim() <> "" Then
                    If gDBType = DatabaseType.SQLServer Then
                        Dim para(5) As SqlParameter
                        para(0) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                        para(1) = New SqlParameter("@ID_cb", obj.ID_cb)
                        para(2) = New SqlParameter("@Thu", obj.Thu)
                        para(3) = New SqlParameter("@Tiet", obj.Tiet)
                        para(4) = New SqlParameter("@So_tiet", obj.So_tiet)
                        para(5) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                        UDB.ExecuteSP("PLAN_SkKhacGiaoVien_Insert", para)
                    Else
                        Dim para(5) As OracleParameter
                        para(0) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                        para(1) = New OracleParameter(":ID_cb", obj.ID_cb)
                        para(2) = New OracleParameter(":Thu", obj.Thu)
                        para(3) = New OracleParameter(":Tiet", obj.Tiet)
                        para(4) = New OracleParameter(":So_tiet", obj.So_tiet)
                        para(5) = New OracleParameter(":Mo_ta", obj.Mo_ta)
                        UDB.ExecuteSP("PLAN_SkKhacGiaoVien_Insert", para)
                    End If
                End If
            Else ' delete or update
                If obj.Mo_ta.Trim() = "" Then
                    ' del
                    If gDBType = DatabaseType.SQLServer Then
                        Dim para(0) As SqlParameter
                        para(0) = New SqlParameter("@ID", obj.ID)
                        UDB.ExecuteSP("PLAN_SkKhacGiaoVien_Delete", para)
                    Else
                        Dim para(0) As OracleParameter
                        para(0) = New OracleParameter(":ID", obj.ID)
                        UDB.ExecuteSP("PLAN_SkKhacGiaoVien_Delete", para)
                    End If
                Else
                    ' update
                    If gDBType = DatabaseType.SQLServer Then
                        Dim para(6) As SqlParameter
                        para(0) = New SqlParameter("@ID", obj.ID)
                        para(1) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                        para(2) = New SqlParameter("@ID_cb", obj.ID_cb)
                        para(3) = New SqlParameter("@Thu", obj.Thu)
                        para(4) = New SqlParameter("@Tiet", obj.Tiet)
                        para(5) = New SqlParameter("@So_tiet", obj.So_tiet)
                        para(6) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                        UDB.ExecuteSP("PLAN_SkKhacGiaoVien_Update", para)
                    Else
                        Dim para(6) As OracleParameter
                        para(0) = New OracleParameter(":ID", obj.ID)
                        para(1) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                        para(2) = New OracleParameter(":ID_cb", obj.ID_cb)
                        para(3) = New OracleParameter(":Thu", obj.Thu)
                        para(4) = New OracleParameter(":Tiet", obj.Tiet)
                        para(5) = New OracleParameter(":So_tiet", obj.So_tiet)
                        para(6) = New OracleParameter(":Mo_ta", obj.Mo_ta)
                        UDB.ExecuteSP("PLAN_SkKhacGiaoVien_Update", para)
                    End If

                End If
            End If
        End Sub
        Public Sub SuKiensKhacPhong_Save(ByVal obj As Sukien_phong)
            If obj.ID = -1 Then
                If obj.Mo_ta.Trim() <> "" Then
                    If gDBType = DatabaseType.SQLServer Then
                        Dim para(5) As SqlParameter
                        para(0) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                        para(1) = New SqlParameter("@ID_phong", obj.ID_phong)
                        para(2) = New SqlParameter("@Thu", obj.Thu)
                        para(3) = New SqlParameter("@Tiet", obj.Tiet)
                        para(4) = New SqlParameter("@So_tiet", obj.So_tiet)
                        para(5) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                        UDB.ExecuteSP("PLAN_SkKhacPhong_Insert", para)
                    Else
                        Dim para(5) As OracleParameter
                        para(0) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                        para(1) = New OracleParameter(":ID_phong", obj.ID_phong)
                        para(2) = New OracleParameter(":Thu", obj.Thu)
                        para(3) = New OracleParameter(":Tiet", obj.Tiet)
                        para(4) = New OracleParameter(":So_tiet", obj.So_tiet)
                        para(5) = New OracleParameter(":Mo_ta", obj.Mo_ta)
                        UDB.ExecuteSP("PLAN_SkKhacPhong_Insert", para)
                    End If

                End If
            Else ' delete or update
                If obj.Mo_ta.Trim() = "" Then
                    ' del
                    If gDBType = DatabaseType.SQLServer Then
                        Dim para(0) As SqlParameter
                        para(0) = New SqlParameter("@ID", obj.ID)
                        UDB.ExecuteSP("PLAN_SkKhacPhong_Delete", para)
                    Else
                        Dim para(0) As OracleParameter
                        para(0) = New OracleParameter(":ID", obj.ID)
                        UDB.ExecuteSP("PLAN_SkKhacPhong_Delete", para)
                    End If
                Else
                    ' update
                    If gDBType = DatabaseType.SQLServer Then
                        Dim para(6) As SqlParameter
                        para(0) = New SqlParameter("@ID", obj.ID)
                        para(1) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                        para(2) = New SqlParameter("@ID_phong", obj.ID_phong)
                        para(3) = New SqlParameter("@Thu", obj.Thu)
                        para(4) = New SqlParameter("@Tiet", obj.Tiet)
                        para(5) = New SqlParameter("@So_tiet", obj.So_tiet)
                        para(6) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                        UDB.ExecuteSP("PLAN_SkKhacPhong_Update", para)
                    Else
                        Dim para(6) As OracleParameter
                        para(0) = New OracleParameter(":ID", obj.ID)
                        para(1) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                        para(2) = New OracleParameter(":ID_phong", obj.ID_phong)
                        para(3) = New OracleParameter(":Thu", obj.Thu)
                        para(4) = New OracleParameter(":Tiet", obj.Tiet)
                        para(5) = New OracleParameter(":So_tiet", obj.So_tiet)
                        para(6) = New OracleParameter(":Mo_ta", obj.Mo_ta)
                        UDB.ExecuteSP("PLAN_SkKhacPhong_Update", para)
                    End If

                End If
            End If
        End Sub
        Public Sub SuKiensKhacLop_Save(ByVal obj As Sukien_lop)
            If obj.ID = -1 Then
                If obj.Mo_ta.Trim() <> "" Then
                    If gDBType = DatabaseType.SQLServer Then
                        Dim para(5) As SqlParameter
                        para(0) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                        para(1) = New SqlParameter("@ID_lop", obj.ID_lop)
                        para(2) = New SqlParameter("@Thu", obj.Thu)
                        para(3) = New SqlParameter("@Tiet", obj.Tiet)
                        para(4) = New SqlParameter("@So_tiet", obj.So_tiet)
                        para(5) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                        UDB.ExecuteSP("PLAN_SkKhacLop_Insert", para)
                    Else
                        Dim para(5) As OracleParameter
                        para(0) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                        para(1) = New OracleParameter(":ID_lop", obj.ID_lop)
                        para(2) = New OracleParameter(":Thu", obj.Thu)
                        para(3) = New OracleParameter(":Tiet", obj.Tiet)
                        para(4) = New OracleParameter(":So_tiet", obj.So_tiet)
                        para(5) = New OracleParameter(":Mo_ta", obj.Mo_ta)
                        UDB.ExecuteSP("PLAN_SkKhacLop_Insert", para)
                    End If

                End If
            Else ' delete or update
                If obj.Mo_ta.Trim() = "" Then
                    ' del
                    If gDBType = DatabaseType.SQLServer Then
                        Dim para(0) As SqlParameter
                        para(0) = New SqlParameter("@ID", obj.ID)
                        UDB.ExecuteSP("PLAN_SkKhacLop_Delete", para)
                    Else
                        Dim para(0) As OracleParameter
                        para(0) = New OracleParameter(":ID", obj.ID)
                        UDB.ExecuteSP("PLAN_SkKhacLop_Delete", para)
                    End If

                Else
                    ' update
                    If gDBType = DatabaseType.SQLServer Then
                        Dim para(6) As SqlParameter
                        para(0) = New SqlParameter("@ID", obj.ID)
                        para(1) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                        para(2) = New SqlParameter("@ID_lop", obj.ID_lop)
                        para(3) = New SqlParameter("@Thu", obj.Thu)
                        para(4) = New SqlParameter("@Tiet", obj.Tiet)
                        para(5) = New SqlParameter("@So_tiet", obj.So_tiet)
                        para(6) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                        UDB.ExecuteSP("PLAN_SkKhacLop_Update", para)
                    Else
                        Dim para(6) As OracleParameter
                        para(0) = New OracleParameter(":ID", obj.ID)
                        para(1) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                        para(2) = New OracleParameter(":ID_lop", obj.ID_lop)
                        para(3) = New OracleParameter(":Thu", obj.Thu)
                        para(4) = New OracleParameter(":Tiet", obj.Tiet)
                        para(5) = New OracleParameter(":So_tiet", obj.So_tiet)
                        para(6) = New OracleParameter(":Mo_ta", obj.Mo_ta)
                        UDB.ExecuteSP("PLAN_SkKhacLop_Update", para)
                    End If

                End If
            End If
        End Sub
        Public Function Insert_SkClassSign(ByVal ID_kh_tuan As Integer, ByVal ID_lop As Integer, ByVal Hashcode As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    para(1) = New SqlParameter("@ID_lop", ID_lop)
                    para(2) = New SqlParameter("@Hashcode", Hashcode)
                    Return UDB.ExecuteSP("PLAN_SkClassSign_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", ID_kh_tuan)
                    para(1) = New OracleParameter(":ID_lop", ID_lop)
                    para(2) = New OracleParameter(":Hashcode", Hashcode)
                    Return UDB.ExecuteSP("PLAN_SkClassSign_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_SkClassSign(ByVal ID_kh_tuan As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    Return UDB.ExecuteSP("PLAN_SkClassSign_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", ID_kh_tuan)
                    Return UDB.ExecuteSP("PLAN_SkClassSign_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_SkTeacherSign(ByVal ID_kh_tuan As Integer, ByVal ID_canbo As Integer, ByVal Hashcode As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    para(1) = New SqlParameter("@ID_canbo", ID_canbo)
                    para(2) = New SqlParameter("@Hashcode", Hashcode)
                    Return UDB.ExecuteSP("PLAN_SkTeacherSign_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", ID_kh_tuan)
                    para(1) = New OracleParameter(":ID_canbo", ID_canbo)
                    para(2) = New OracleParameter(":Hashcode", Hashcode)
                    Return UDB.ExecuteSP("PLAN_SkTeacherSign_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_SkTeacherSign(ByVal ID_kh_tuan As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    Return UDB.ExecuteSP("PLAN_SkTeacherSign_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", ID_kh_tuan)
                    Return UDB.ExecuteSP("PLAN_SkTeacherSign_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_SkRoomSign(ByVal ID_kh_tuan As Integer, ByVal ID_phong As Integer, ByVal Hashcode As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    para(1) = New SqlParameter("@ID_phong", ID_phong)
                    para(2) = New SqlParameter("@Hashcode", Hashcode)
                    Return UDB.ExecuteSP("PLAN_SkRoomSign_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", ID_kh_tuan)
                    para(1) = New OracleParameter(":ID_phong", ID_phong)
                    para(2) = New OracleParameter(":Hashcode", Hashcode)
                    Return UDB.ExecuteSP("PLAN_SkRoomSign_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_SkRoomSign(ByVal ID_kh_tuan As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", ID_kh_tuan)
                    Return UDB.ExecuteSP("PLAN_SkRoomSign_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", ID_kh_tuan)
                    Return UDB.ExecuteSP("PLAN_SkRoomSign_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_SkKhacGiaoVien(ByVal obj As Sukien_gv) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New SqlParameter("@ID_cb", obj.ID_cb)
                    para(2) = New SqlParameter("@Thu", obj.Thu)
                    para(3) = New SqlParameter("@Tiet", obj.Tiet)
                    para(4) = New SqlParameter("@So_tiet", obj.So_tiet)
                    para(5) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("PLAN_SkKhacGiaoVien_Insert", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New OracleParameter(":ID_cb", obj.ID_cb)
                    para(2) = New OracleParameter(":Thu", obj.Thu)
                    para(3) = New OracleParameter(":Tiet", obj.Tiet)
                    para(4) = New OracleParameter(":So_tiet", obj.So_tiet)
                    para(5) = New OracleParameter(":Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("PLAN_SkKhacGiaoVien_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_SkKhacGiaoVien(ByVal obj As Sukien_gv) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@ID", obj.ID)
                    para(1) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(2) = New SqlParameter("@ID_cb", obj.ID_cb)
                    para(3) = New SqlParameter("@Thu", obj.Thu)
                    para(4) = New SqlParameter("@Tiet", obj.Tiet)
                    para(5) = New SqlParameter("@So_tiet", obj.So_tiet)
                    para(6) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("PLAN_SkKhacGiaoVien_Update", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID", obj.ID)
                    para(1) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(2) = New OracleParameter(":ID_cb", obj.ID_cb)
                    para(3) = New OracleParameter(":Thu", obj.Thu)
                    para(4) = New OracleParameter(":Tiet", obj.Tiet)
                    para(5) = New OracleParameter(":So_tiet", obj.So_tiet)
                    para(6) = New OracleParameter(":Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("PLAN_SkKhacGiaoVien_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_SkKhacGiaoVien(ByVal ID As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID", ID)
                    Return UDB.ExecuteSP("PLAN_SkKhacGiaoVien_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID", ID)
                    Return UDB.ExecuteSP("PLAN_SkKhacGiaoVien_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_SkKhacGiaoVien(ByVal obj As Sukien_gv) As Integer
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New SqlParameter("@ID_cb", obj.ID_cb)
                    para(2) = New SqlParameter("@Thu", obj.Thu)
                    para(3) = New SqlParameter("@Tiet", obj.Tiet)
                    dt = UDB.SelectTableSP("PLAN_SkKhacGiaoVien_Check", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return 0
                    End If
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New OracleParameter(":ID_cb", obj.ID_cb)
                    para(2) = New OracleParameter(":Thu", obj.Thu)
                    para(3) = New OracleParameter(":Tiet", obj.Tiet)
                    dt = UDB.SelectTableSP("PLAN_SkKhacGiaoVien_Check", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return 0
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_SkKhacPhong(ByVal obj As Sukien_phong) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New SqlParameter("@ID_phong", obj.ID_phong)
                    para(2) = New SqlParameter("@Thu", obj.Thu)
                    para(3) = New SqlParameter("@Tiet", obj.Tiet)
                    para(4) = New SqlParameter("@So_tiet", obj.So_tiet)
                    para(5) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("PLAN_SkKhacPhong_Insert", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New OracleParameter(":ID_phong", obj.ID_phong)
                    para(2) = New OracleParameter(":Thu", obj.Thu)
                    para(3) = New OracleParameter(":Tiet", obj.Tiet)
                    para(4) = New OracleParameter(":So_tiet", obj.So_tiet)
                    para(5) = New OracleParameter(":Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("PLAN_SkKhacPhong_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_SkKhacPhong(ByVal obj As Sukien_phong) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@ID", obj.ID)
                    para(1) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(2) = New SqlParameter("@ID_phong", obj.ID_phong)
                    para(3) = New SqlParameter("@Thu", obj.Thu)
                    para(4) = New SqlParameter("@Tiet", obj.Tiet)
                    para(5) = New SqlParameter("@So_tiet", obj.So_tiet)
                    para(6) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("PLAN_SkKhacPhong_Update", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID", obj.ID)
                    para(1) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(2) = New OracleParameter(":ID_phong", obj.ID_phong)
                    para(3) = New OracleParameter(":Thu", obj.Thu)
                    para(4) = New OracleParameter(":Tiet", obj.Tiet)
                    para(5) = New OracleParameter(":So_tiet", obj.So_tiet)
                    para(6) = New OracleParameter(":Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("PLAN_SkKhacPhong_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_SkKhacPhong(ByVal ID As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID", ID)
                    Return UDB.ExecuteSP("PLAN_SkKhacPhong_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID", ID)
                    Return UDB.ExecuteSP("PLAN_SkKhacPhong_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_SkKhacPhong(ByVal obj As Sukien_phong) As Integer
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New SqlParameter("@ID_phong", obj.ID_phong)
                    para(2) = New SqlParameter("@Thu", obj.Thu)
                    para(3) = New SqlParameter("@Tiet", obj.Tiet)
                    dt = UDB.SelectTableSP("PLAN_SkKhacPhong_Check", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return 0
                    End If
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New OracleParameter(":ID_phong", obj.ID_phong)
                    para(2) = New OracleParameter(":Thu", obj.Thu)
                    para(3) = New OracleParameter(":Tiet", obj.Tiet)
                    dt = UDB.SelectTableSP("PLAN_SkKhacPhong_Check", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return 0
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_SkKhacLop(ByVal obj As Sukien_lop) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New SqlParameter("@ID_lop", obj.ID_lop)
                    para(2) = New SqlParameter("@Thu", obj.Thu)
                    para(3) = New SqlParameter("@Tiet", obj.Tiet)
                    para(4) = New SqlParameter("@So_tiet", obj.So_tiet)
                    para(5) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("PLAN_SkKhacLop_Insert", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New OracleParameter(":ID_lop", obj.ID_lop)
                    para(2) = New OracleParameter(":Thu", obj.Thu)
                    para(3) = New OracleParameter(":Tiet", obj.Tiet)
                    para(4) = New OracleParameter(":So_tiet", obj.So_tiet)
                    para(5) = New OracleParameter(":Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("PLAN_SkKhacLop_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_SkKhacLop(ByVal obj As Sukien_lop) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@ID", obj.ID)
                    para(1) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(2) = New SqlParameter("@ID_lop", obj.ID_lop)
                    para(3) = New SqlParameter("@Thu", obj.Thu)
                    para(4) = New SqlParameter("@Tiet", obj.Tiet)
                    para(5) = New SqlParameter("@So_tiet", obj.So_tiet)
                    para(6) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("PLAN_SkKhacLop_Update", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID", obj.ID)
                    para(1) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(2) = New OracleParameter(":ID_lop", obj.ID_lop)
                    para(3) = New OracleParameter(":Thu", obj.Thu)
                    para(4) = New OracleParameter(":Tiet", obj.Tiet)
                    para(5) = New OracleParameter(":So_tiet", obj.So_tiet)
                    para(6) = New OracleParameter(":Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("PLAN_SkKhacLop_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_SkKhacLop(ByVal ID As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID", ID)
                    Return UDB.ExecuteSP("PLAN_SkKhacLop_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID", ID)
                    Return UDB.ExecuteSP("PLAN_SkKhacLop_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_SkKhacLop(ByVal obj As Sukien_lop) As Integer
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New SqlParameter("@ID_lop", obj.ID_lop)
                    para(2) = New SqlParameter("@Thu", obj.Thu)
                    para(3) = New SqlParameter("@Tiet", obj.Tiet)
                    dt = UDB.SelectTableSP("PLAN_SkKhacLop_Check", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return 0
                    End If
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New OracleParameter(":ID_lop", obj.ID_lop)
                    para(2) = New OracleParameter(":Thu", obj.Thu)
                    para(3) = New OracleParameter(":Tiet", obj.Tiet)
                    dt = UDB.SelectTableSP("PLAN_SkKhacLop_Check", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return 0
                    End If

                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_SkKhacTruong(ByVal obj As Sukien_lop) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New SqlParameter("@Thu", obj.Thu)
                    para(2) = New SqlParameter("@Tiet", obj.Tiet)
                    para(3) = New SqlParameter("@So_tiet", obj.So_tiet)
                    para(4) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("PLAN_SkKhacTruong_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New OracleParameter(":Thu", obj.Thu)
                    para(2) = New OracleParameter(":Tiet", obj.Tiet)
                    para(3) = New OracleParameter(":So_tiet", obj.So_tiet)
                    para(4) = New OracleParameter(":Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("PLAN_SkKhacTruong_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_SkKhacTruong(ByVal obj As Sukien_lop) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID", obj.ID)
                    para(1) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(2) = New SqlParameter("@Thu", obj.Thu)
                    para(3) = New SqlParameter("@Tiet", obj.Tiet)
                    para(4) = New SqlParameter("@So_tiet", obj.So_tiet)
                    para(5) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("PLAN_SkKhacTruong_Update", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID", obj.ID)
                    para(1) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(2) = New OracleParameter(":Thu", obj.Thu)
                    para(3) = New OracleParameter(":Tiet", obj.Tiet)
                    para(4) = New OracleParameter(":So_tiet", obj.So_tiet)
                    para(5) = New OracleParameter(":Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("PLAN_SkKhacTruong_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_SkKhacTruong(ByVal ID As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID", ID)
                    Return UDB.ExecuteSP("PLAN_SkKhacTruong_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID", ID)
                    Return UDB.ExecuteSP("PLAN_SkKhacTruong_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_SkKhacTruong(ByVal obj As Sukien_lop) As Integer
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New SqlParameter("@Thu", obj.Thu)
                    para(2) = New SqlParameter("@Tiet", obj.Tiet)
                    dt = UDB.SelectTableSP("PLAN_SkKhacTruong_Check", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return 0
                    End If
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_tuan", obj.ID_kh_tuan)
                    para(1) = New OracleParameter(":Thu", obj.Thu)
                    para(2) = New OracleParameter(":Tiet", obj.Tiet)
                    dt = UDB.SelectTableSP("PLAN_SkKhacTruong_Check", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return 0
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

