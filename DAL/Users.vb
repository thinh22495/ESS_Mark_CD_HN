'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/05/2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class Users_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Sub ChangePassword(ByVal UserID As Integer, ByVal NewPassword As String)
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@UserID", UserID)
                    para(1) = New SqlParameter("@NewPassword", NewPassword)
                    UDB.ExecuteSP("htChangePassword", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":UserID", UserID)
                    para(0) = New OracleParameter(":NewPassword", NewPassword)
                    UDB.ExecuteSP("htChangePassword", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function Load_Users(ByVal UserName As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@UserName", UserName)
                    Return UDB.SelectTableSP("SYS_NguoiDung_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":UserName", UserName)
                    Return UDB.SelectTableSP("SYS_NguoiDung_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Load các quyền của vai tro
        Public Function Load_VaiTroQuyen(ByVal ID_Vai_Tro As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_Vai_Tro", ID_Vai_Tro)
                    Return UDB.SelectTableSP("SYS_VaiTroQuyen_Load", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_Vai_Tro", ID_Vai_Tro)
                    Return UDB.SelectTableSP("SYS_VaiTroQuyen_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Phong(ByVal ID_Phong As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_Phong", ID_Phong)
                    Return UDB.SelectTableSP("SYS_Phong_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_Phong", ID_Phong)
                    Return UDB.SelectTableSP("SYS_NguoiDung_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Phong_List() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("SYS_Phong_Load_List")
                Else
                    Return UDB.SelectTableSP("SYS_Phong_Load_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Public Function Load_Khoa_List() As DataTable
        '    Try
        '        If gDBType = DatabaseType.SQLServer Then
        '            Return UDB.SelectTableSP("STU_Khoa_Load_List")
        '        Else
        '            Return UDB.SelectTableSP("STU_Khoa_Load_List")
        '        End If
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        Public Function Load_Bomon_List() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("PLAN_BoMon_Load_List")
                Else
                    Return UDB.SelectTableSP("PLAN_BoMon_Load_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Users_List(ByVal UserID As Integer, ByVal ID_Khoa As Integer, ByVal ID_Bomon As Integer, ByVal ID_Phong As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@UserID", UserID)
                    para(1) = New SqlParameter("@ID_Khoa", ID_Khoa)
                    para(2) = New SqlParameter("@ID_Bomon", ID_Bomon)
                    para(3) = New SqlParameter("@ID_Phong", ID_Phong)
                    Return UDB.SelectTableSP("SYS_NguoiDung_Load_List1", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":UserID", UserID)
                    para(1) = New OracleParameter(":ID_Khoa", ID_Khoa)
                    para(2) = New OracleParameter(":ID_Bomon", ID_Bomon)
                    para(3) = New OracleParameter(":ID_Phong", ID_Phong)
                    Return UDB.SelectTableSP("SYS_NguoiDung_Load_List1", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Load_UsersQuyen_List(ByVal ID_ph As Integer, ByVal UserID As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_ph", ID_ph)
                    para(1) = New SqlParameter("@UserID", UserID)
                    Return UDB.SelectTableSP("SYS_NguoiDungQuyen_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_ph", ID_ph)
                    para(1) = New OracleParameter(":UserID", UserID)
                    Return UDB.SelectTableSP("SYS_NguoiDungQuyen_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_UsersHeAccess_List(ByVal UserID As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@UserID", UserID)
                    Return UDB.SelectTableSP("SYS_NguoiDungAccessHe_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":UserID", UserID)
                    Return UDB.SelectTableSP("SYS_NguoiDungAccessHe_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_UsersLopAccess_List(ByVal ID_he As Integer, ByVal ID_Khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@ID_khoa", ID_Khoa)
                    para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    para(3) = New SqlParameter("@ID_nganh", ID_nganh)
                    para(4) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("SYS_NguoiDungAccessLop_Load_List", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    para(1) = New OracleParameter(":ID_khoa", ID_Khoa)
                    para(2) = New OracleParameter(":Khoa_hoc", Khoa_hoc)
                    para(3) = New OracleParameter(":ID_nganh", ID_nganh)
                    para(4) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.SelectTableSP("SYS_NguoiDungAccessLop_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_He_List() As DataTable
            Try
                Return UDB.SelectTableSP("STU_He_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Khoa_List() As DataTable
            Try
                Return UDB.SelectTableSP("STU_Khoa_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KhoaHoc_List() As DataTable
            Try
                Return UDB.SelectTableSP("STU_KhoaHoc_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Nganh_List() As DataTable
            Try
                Return UDB.SelectTableSP("STU_Nganh_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ChuyenNganh_List() As DataTable
            Try
                Return UDB.SelectTableSP("STU_ChuyenNganh_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_Users(ByVal obj As Users) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(12) As SqlParameter
                    para(0) = New SqlParameter("@UserName", obj.UserName)
                    para(1) = New SqlParameter("@PassWord", obj.PassWord)
                    para(2) = New SqlParameter("@FullName", obj.FullName)
                    para(3) = New SqlParameter("@UserGroup", obj.UserGroup)
                    para(4) = New SqlParameter("@ID_phong", obj.ID_phong)
                    para(5) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(6) = New SqlParameter("@ID_Bomon", obj.ID_Bomon)
                    para(7) = New SqlParameter("@Active", obj.Active)
                    para(8) = New SqlParameter("@May_tram", obj.May_tram)
                    para(9) = New SqlParameter("@UserNameLDAP", obj.UserNameLDAP)
                    para(10) = New SqlParameter("@adsPathLDAP", obj.adsPathLDAP)
                    para(11) = New SqlParameter("@Dien_thoai", obj.Dien_thoai)
                    para(12) = New SqlParameter("@Email", obj.Email)
                    UDB.ExecuteSP("SYS_NguoiDung_Insert", para)
                    Return GetMaxID_Users()
                Else
                    Dim para(12) As OracleParameter
                    para(0) = New OracleParameter(":UserName", obj.UserName)
                    para(1) = New OracleParameter(":PassWord", obj.PassWord)
                    para(2) = New OracleParameter(":FullName", obj.FullName)
                    para(3) = New OracleParameter(":UserGroup", obj.UserGroup)
                    para(4) = New OracleParameter(":ID_phong", obj.ID_phong)
                    para(5) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(6) = New OracleParameter(":ID_Bomon", obj.ID_Bomon)
                    para(7) = New OracleParameter(":Active", obj.Active)
                    para(8) = New OracleParameter(":May_tram", obj.May_tram)
                    para(9) = New OracleParameter(":UserNameLDAP", obj.UserNameLDAP)
                    para(10) = New OracleParameter(":adsPathLDAP", obj.adsPathLDAP)
                    para(11) = New OracleParameter(":Dien_thoai", obj.Dien_thoai)
                    para(12) = New OracleParameter(":Email", obj.Email)
                    UDB.ExecuteSP("SYS_NguoiDung_Insert", para)
                    Return GetMaxID_Users()
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_UserVaiTro(ByVal obj As VaiTro, ByVal UserID As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_vai_tro", obj.ID_vai_tro)
                    para(1) = New SqlParameter("@UserID", UserID)
                    Return UDB.ExecuteSP("SYS_NguoiDungVaiTro_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_vai_tro", obj.ID_vai_tro)
                    para(1) = New OracleParameter(":UserID", UserID)
                    Return UDB.ExecuteSP("SYS_NguoiDungVaiTro_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_SYS_NguoiDung(ByVal obj As Users, ByVal UserID As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(13) As SqlParameter
                    para(0) = New SqlParameter("@UserID", UserID)
                    para(1) = New SqlParameter("@UserName", obj.UserName)
                    para(2) = New SqlParameter("@PassWord", obj.PassWord)
                    para(3) = New SqlParameter("@FullName", obj.FullName)
                    para(4) = New SqlParameter("@UserGroup", obj.UserGroup)
                    para(5) = New SqlParameter("@Active", obj.Active)
                    para(6) = New SqlParameter("@ID_phong", obj.ID_phong)
                    para(7) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(8) = New SqlParameter("@ID_Bomon", obj.ID_Bomon)
                    para(9) = New SqlParameter("@May_tram", obj.May_tram)
                    para(10) = New SqlParameter("@UserNameLDAP", obj.UserNameLDAP)
                    para(11) = New SqlParameter("@adsPathLDAP", obj.adsPathLDAP)
                    para(12) = New SqlParameter("@Dien_thoai", obj.Dien_thoai)
                    para(13) = New SqlParameter("@Email", obj.Email)
                    Return UDB.ExecuteSP("SYS_NguoiDung_Update", para)
                Else
                    Dim para(13) As OracleParameter
                    para(0) = New OracleParameter(":UserID", UserID)
                    para(1) = New OracleParameter(":UserName", obj.UserName)
                    para(2) = New OracleParameter(":PassWord", obj.PassWord)
                    para(3) = New OracleParameter(":FullName", obj.FullName)
                    para(4) = New OracleParameter(":UserGroup", obj.UserGroup)
                    para(5) = New OracleParameter(":Active", obj.Active)
                    para(6) = New OracleParameter(":ID_phong", obj.ID_phong)
                    para(7) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(8) = New OracleParameter(":ID_Bomon", obj.ID_Bomon)
                    para(9) = New OracleParameter(":May_tram", obj.May_tram)
                    para(10) = New OracleParameter(":UserNameLDAP", obj.UserNameLDAP)
                    para(11) = New OracleParameter(":adsPathLDAP", obj.adsPathLDAP)
                    para(12) = New OracleParameter(":Dien_thoai", obj.Dien_thoai)
                    para(13) = New OracleParameter(":Email", obj.Email)
                    Return UDB.ExecuteSP("SYS_NguoiDung_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_UsersAccessHe(ByVal obj As UsersHeAcess, ByVal UserID As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@UserID", UserID)
                    para(1) = New SqlParameter("@ID_he", obj.ID_he)
                    para(2) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(3) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                    para(4) = New SqlParameter("@ID_nganh", obj.ID_nganh)
                    para(5) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    Return UDB.ExecuteSP("SYS_NguoiDungAccessHe_Insert", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":UserID", UserID)
                    para(1) = New OracleParameter(":ID_he", obj.ID_he)
                    para(2) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(3) = New OracleParameter(":Khoa_hoc", obj.Khoa_hoc)
                    para(4) = New OracleParameter(":ID_nganh", obj.ID_nganh)
                    para(5) = New OracleParameter(":ID_chuyen_nganh", obj.ID_chuyen_nganh)
                    Return UDB.ExecuteSP("SYS_NguoiDungAccessHe_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_UsersAccessHe(ByVal UserID As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@UserID", UserID)
                    Return UDB.ExecuteSP("SYS_NguoiDungAccessHe_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":UserID", UserID)

                    Return UDB.ExecuteSP("SYS_NguoiDungAccessHe_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_Users(ByVal UserID As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@UserID", UserID)
                    Return UDB.ExecuteSP("SYS_NguoiDung_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":UserID", UserID)
                    Return UDB.ExecuteSP("SYS_NguoiDung_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_UserVaiTro(ByVal UserID As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@UserID", UserID)
                    Return UDB.ExecuteSP("SYS_NguoiDungVaiTro_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":UserID", UserID)
                    Return UDB.ExecuteSP("SYS_NguoiDungVaiTro_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CheckExist_Users(ByVal UserName As String) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@UserName", UserName)
                    Dim dt As DataTable = UDB.SelectTableSP("SYS_NguoiDung_CheckExist", para)
                    If dt.Rows(0)(0) > 0 Then
                        Return True
                    End If
                    Return False
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":UserName", UserName)
                    Dim dt As DataTable = UDB.SelectTableSP("SYS_NguoiDung_CheckExist", para)
                    If dt.Rows(0)(0) > 0 Then
                        Return True
                    End If
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CheckExist_Users(ByVal UserName As String, ByVal UserID As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@UserName", UserName)
                    para(1) = New SqlParameter("@UserID", UserID)
                    Dim dt As DataTable = UDB.SelectTableSP("SYS_NguoiDung_CheckExistUp", para)
                    If dt.Rows(0)(0) > 0 Then
                        Return True
                    End If
                    Return False
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":UserName", UserName)
                    para(1) = New OracleParameter(":UserID", UserID)
                    Dim dt As DataTable = UDB.SelectTableSP("SYS_NguoiDung_CheckExistUp", para)
                    If dt.Rows(0)(0) > 0 Then
                        Return True
                    End If
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Check_UsersVaiTro(ByVal UserID As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@UserID", UserID)
                    Dim dt As DataTable = UDB.SelectTableSP("SYS_NguoiDungVaiTro_CheckExist", para)
                    If dt.Rows(0)(0) > 0 Then
                        Return True
                    End If
                    Return False
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":UserID", UserID)
                    Dim dt As DataTable = UDB.SelectTableSP("SYS_NguoiDungVaiTro_CheckExist", para)
                    If dt.Rows(0)(0) > 0 Then
                        Return True
                    End If
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_UsersAccessHe(ByVal UserID As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@UserID", UserID)
                    Dim dt As DataTable = UDB.SelectTableSP("SYS_NguoiDungAccessHe_CheckExist", para)
                    If dt.Rows(0)(0) > 0 Then
                        Return True
                    End If
                    Return False
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":UserID", UserID)
                    Dim dt As DataTable = UDB.SelectTableSP("SYS_NguoiDungAccessHe_CheckExist", para)
                    If dt.Rows(0)(0) > 0 Then
                        Return True
                    End If
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetMaxID_Users() As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim dt As DataTable = UDB.SelectTableSP("SYS_NguoiDung_GetMaxID")
                    Return dt.Rows(0)(0)
                Else
                    Dim dt As DataTable = UDB.SelectTableSP("SYS_NguoiDung_GetMaxID")
                    Return dt.Rows(0)(0)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

    End Class
End Namespace


