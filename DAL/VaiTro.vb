'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/21/2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class VaiTro_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
#Region " VaiTro Functions" ' Các hàm liên quan đến object VaiTro

        '' Load các vai trò theo UserID
        Public Function Load_VaiTro_List(ByVal UserID As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@UserID", UserID)
                    Return UDB.SelectTableSP("SYS_VaiTro_Load", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":UserID", UserID)
                    Return UDB.SelectTableSP("SYS_VaiTro_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ' Thêm mới vai trò
        Public Function Insert_VaiTro(ByVal obj As VaiTro) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ten_vai_tro", obj.Ten_vai_tro)
                    para(1) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                    UDB.ExecuteSP("SYS_VaiTro_Insert", para)
                    Return GetMaxID_VaiTro()
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ten_vai_tro", obj.Ten_vai_tro)
                    para(1) = New OracleParameter(":Mo_ta", obj.Mo_ta)
                    UDB.ExecuteSP("SYS_VaiTro_Insert", para)
                    Return GetMaxID_VaiTro()
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_VaiTro(ByVal obj As VaiTro, ByVal ID_vai_tro As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_vai_tro", ID_vai_tro)
                    para(1) = New SqlParameter("@Ten_vai_tro", obj.Ten_vai_tro)
                    para(2) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("SYS_VaiTro_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_vai_tro", ID_vai_tro)
                    para(1) = New OracleParameter(":Ten_vai_tro", obj.Ten_vai_tro)
                    para(2) = New OracleParameter(":Mo_ta", obj.Mo_ta)
                    Return UDB.ExecuteSP("SYS_VaiTro_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_VaiTro(ByVal ID_vai_tro As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_vai_tro", ID_vai_tro)
                    Return UDB.ExecuteSP("SYS_VaiTro_Delete", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_vai_tro", ID_vai_tro)
                    Return UDB.ExecuteSP("SYS_VaiTro_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        '' Trả lại giá trị mã của ID_vai_tro
        Public Function GetMaxID_VaiTro() As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim dt As DataTable = UDB.SelectTable("SYS_VaiTro_GetMaxID")
                    Return dt.Rows(0)(0)
                Else
                    Dim dt As DataTable = UDB.SelectTable("SYS_VaiTro_GetMaxID")
                    Return dt.Rows(0)(0)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        '' Hàm kiểm tra xem vai trò đã được gán các quyền chưa?
        Public Function CheckExist_VaiTroQuyen(ByVal ID_vai_tro As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_vai_tro", ID_vai_tro)
                    Dim dt As DataTable = UDB.SelectTableSP("SYS_VaiTroQuyen_CheckExist", para)
                    If dt.Rows(0)(0) > 0 Then
                        Return True
                    End If
                    Return False 'UDB.ExecuteScalar("SYS_VaiTroQuyen_CheckExist", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_vai_tro", ID_vai_tro)
                    Dim dt As DataTable = UDB.SelectTableSP("SYS_VaiTroQuyen_CheckExist", para)
                    If dt.Rows(0)(0) > 0 Then
                        Return True
                    End If
                    Return False 'Return UDB.ExecuteScalar("SYS_VaiTroQuyen_CheckExist", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

#Region " VaiTroQuyen Function" ' Các hàm liên quan đến Object VaiTroQuyen

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

        '' Thêm mới các quyền cho VaiTro
        Public Function Insert_VaiTroQuyen(ByVal obj As VaiTroQuyen, ByVal ID_vai_tro As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_vai_tro", ID_vai_tro)
                    para(1) = New SqlParameter("@ID_quyen", obj.ID_quyen)
                    para(2) = New SqlParameter("@Them", obj.Them)
                    para(3) = New SqlParameter("@Sua", obj.Sua)
                    para(4) = New SqlParameter("@Xoa", obj.Xoa)
                    Return UDB.ExecuteSP("SYS_VaiTroquyen_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_vai_tro", ID_vai_tro)
                    para(1) = New OracleParameter(":ID_quyen", obj.ID_quyen)
                    para(2) = New OracleParameter(":Them", obj.Them)
                    para(3) = New OracleParameter(":Sua", obj.Sua)
                    para(4) = New OracleParameter(":Xoa", obj.Xoa)
                    Return UDB.ExecuteSP("SYS_VaiTroquyen_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'Public Function Update_VaiTroQuyen(ByVal obj As VaiTroQuyen, ByVal ID_vai_tro As Integer, ByVal ID_quyen As Integer) As Integer
        '    Try
        '        If gDBType = DatabaseType.SQLServer Then
        '            Dim para(4) As SqlParameter
        '            para(0) = New SqlParameter("@ID_vai_tro", ID_vai_tro)
        '            para(1) = New SqlParameter("@ID_quyen", ID_quyen)
        '            para(2) = New SqlParameter("@Them", obj.Them)
        '            para(3) = New SqlParameter("@Sua", obj.Sua)
        '            para(4) = New SqlParameter("@Xoa", obj.Xoa)
        '            Return UDB.ExecuteSP("SYS_VaiTroquyen_Update", para)
        '        Else
        '            Dim para(4) As OracleParameter
        '            para(0) = New OracleParameter(":ID_vai_tro", ID_vai_tro)
        '            para(1) = New OracleParameter(":ID_quyen", ID_quyen)
        '            para(2) = New OracleParameter(":Them", obj.Them)
        '            para(3) = New OracleParameter(":Sua", obj.Sua)
        '            para(4) = New OracleParameter(":Xoa", obj.Xoa)
        '            Return UDB.ExecuteSP("SYS_VaiTroquyen_Update", para)
        '        End If
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function

        '' Xóa hết các quyền của VaiTro
        Public Function Delete_VaiTroQuyen(ByVal ID_vai_tro As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_vai_tro", ID_vai_tro)
                    Return UDB.ExecuteSP("SYS_VaiTroquyen_Delete", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_vai_tro", ID_vai_tro)
                    Return UDB.ExecuteSP("SYS_VaiTroquyen_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

#Region " UserVaiTro Functions" ' Các hàm liên quan đến UserVaiTro
        '' Thêm mới VaiTro cho User
        Public Function Insert_UsersVaiTro(ByVal UserID As Integer, ByVal ID_vai_tro As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@UserID", UserID)
                    para(1) = New SqlParameter("@ID_vai_tro", ID_vai_tro)
                    Return UDB.ExecuteSP("SYS_NguoiDungVaiTro_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":UserID", UserID)
                    para(1) = New OracleParameter(":ID_vai_tro", ID_vai_tro)
                    Return UDB.ExecuteSP("SYS_NguoiDungVaiTro_Insert", para)
                End If

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        '' Xóa các vai trò của User
        Public Function Delete_UsersVaitro(ByVal UserID As Integer, ByVal ID_vai_tro As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@UserID", UserID)
                    para(1) = New SqlParameter("@ID_vai_tro", ID_vai_tro)
                    Return UDB.ExecuteSP("SYS_NguoiDungVaiTro_Delete_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":UserID", UserID)
                    para(1) = New OracleParameter(":ID_vai_tro", ID_vai_tro)
                    Return UDB.ExecuteSP("SYS_NguoiDungVaiTro_Delete_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

        '' Load các quyền của User theo VaiTro
        Public Function Load_UserQuyen(ByVal UserID As Integer, ByVal ID_vai_tro As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@UserID", UserID)
                    para(1) = New SqlParameter("@ID_vai_tro", ID_vai_tro)
                    Return UDB.SelectTableSP("SYS_NguoiDungVaiTro_Load", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":UserID", UserID)
                    para(1) = New OracleParameter(":ID_vai_tro", ID_vai_tro)
                    Return UDB.SelectTableSP("SYS_NguoiDungVaiTro_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        '' Load các phân hệ theo UserID
        Public Function Load_PhanHe() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then

                    Return UDB.SelectTableSP("SYS_PhanHe_Load")
                Else

                    Return UDB.SelectTableSP("SYS_PhanHe_Load")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_PhanHe_List(ByVal User As Users) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@UserID", User.UserID)
                    Return UDB.SelectTableSP("SYS_PhanHe_Load_List", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":UserID", User.UserID)
                    Return UDB.SelectTableSP("SYS_PhanHe_Load_list", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

    End Class
End Namespace


