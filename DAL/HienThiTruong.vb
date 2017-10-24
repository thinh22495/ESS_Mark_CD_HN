Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class HienThiTruong_DAL
        Public Function Load_NhomTruongHienThi_List(ByVal ID_phan_he As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_phan_he", ID_phan_he)
                    Return UDB.SelectTableSP("SYS_NhomTruongHienThi_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_phan_he", ID_phan_he)
                    Return UDB.SelectTableSP("SYS_NhomTruongHienThi_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_TruongHienThiNguoiDung(ByVal ID_phan_he As Integer, ByVal ID_user As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_phan_he", ID_phan_he)
                    para(1) = New SqlParameter("@ID_user", ID_user)
                    Return UDB.SelectTableSP("SYS_HienThiTruongNguoiDung_Load", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_phan_he", ID_phan_he)
                    para(1) = New OracleParameter(":ID_user", ID_user)
                    Return UDB.SelectTableSP("SYS_HienThiTruongNguoiDung_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_TruongHienThiMacDinh(ByVal FieldGroup As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@FieldGroup", FieldGroup)
                    Return UDB.SelectTableSP("SYS_HienThiTruongMacDinh_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":FieldGroup", FieldGroup)
                    Return UDB.SelectTableSP("SYS_HienThiTruongMacDinh_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ' Delete Trường hiển thị người dùng
        Public Function Delete_FielUser(ByVal ID_user As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_user", ID_user)
                    Return UDB.ExecuteSP("SYS_HienThiTruongNguoiDung_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_user", ID_user)
                    Return UDB.ExecuteSP("SYS_HienThiTruongNguoiDung_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Delete Trường hiển thị mặc định
        Public Function Delete_FielDefaul(ByVal FieldGroup As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@FieldGroup", FieldGroup)
                    Return UDB.ExecuteSP("SYS_HienThiTruongMacDinh_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":FieldGroup", FieldGroup)
                    Return UDB.ExecuteSP("SYS_HienThiTruongMacDinh_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_FieldUser(ByVal ID_user As Integer, ByVal FieldID As String, ByVal FieldSize As Double, ByVal STT As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_user", SqlDbType.Int)
                    para(0).Value = ID_user
                    para(1) = New SqlParameter("@FieldID", SqlDbType.NVarChar)
                    para(1).Value = FieldID
                    para(2) = New SqlParameter("@FieldSize", SqlDbType.Float)
                    para(2).Value = FieldSize
                    para(3) = New SqlParameter("@STT", SqlDbType.Int)
                    para(3).Value = STT
                    Return UDB.ExecuteSP("SYS_HienThiTruongNguoiDung_Insert", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_user", ID_user)
                    para(1) = New OracleParameter(":FieldID", FieldID)
                    para(2) = New OracleParameter(":FieldSize", FieldSize)
                    para(3) = New OracleParameter(":STT", STT)
                    Return UDB.ExecuteSP("SYS_HienThiTruongNguoiDung_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_FieldDefault(ByVal FieldGroup As Integer, ByVal FieldID As String, ByVal STT As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@FieldGroup", FieldGroup)
                    para(1) = New SqlParameter("@FieldID", FieldID)
                    para(2) = New SqlParameter("@STT", STT)
                    Return UDB.ExecuteSP("SYS_HienThiTruongMacDinh_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":FieldGroup", FieldGroup)
                    para(1) = New OracleParameter(":FieldID", FieldID)
                    para(2) = New OracleParameter(":STT", STT)
                    Return UDB.ExecuteSP("SYS_HienThiTruongMacDinh_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace



