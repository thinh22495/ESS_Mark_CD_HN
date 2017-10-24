Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class HienThiTruong_BLL
#Region "Function"
        ' Load nhớm trường hiển thị
        Public Function Load_NhomTruongHienThi(ByVal ID_phan_he As Integer) As DataTable
            Try
                Dim obj As New HienThiTruong_DAL
                Dim dt As DataTable
                dt = obj.Load_NhomTruongHienThi_List(ID_phan_he)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load trường hiển thị người dùng
        Public Function Load_TruongHienThiNguoiDung(ByVal ID_phan_he As Integer, ByVal ID_user As Integer) As DataTable
            Try
                Dim obj As New HienThiTruong_DAL
                Dim dt As DataTable
                dt = obj.Load_TruongHienThiNguoiDung(ID_phan_he, ID_user)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load trường hiển thị người dùng
        Public Function Load_TruongHienThiMacDinh(ByVal FieldGroup As Integer) As DataTable
            Try
                Dim obj As New HienThiTruong_DAL
                Dim dt As DataTable
                dt = obj.Load_TruongHienThiMacDinh(FieldGroup)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Delete Trường hiển thị người dùng
        Public Function Delete_FielUser(ByVal ID_user As Integer) As Integer
            Try
                Dim obj As New HienThiTruong_DAL
                Return obj.Delete_FielUser(ID_user)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Delete Trường hiển thị mặc định
        Public Function Delete_FielDefaul(ByVal FieldGroup As Integer) As Integer
            Try
                Dim obj As New HienThiTruong_DAL
                Return obj.Delete_FielDefaul(FieldGroup)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_FieldUser(ByVal ID_user As Integer, ByVal FieldID As String, ByVal FieldSize As Double, ByVal STT As Integer) As Integer
            Try
                Dim obj As New HienThiTruong_DAL
                Return obj.Insert_FieldUser(ID_user, FieldID, FieldSize, STT)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_FieldDefault(ByVal FieldGroup As Integer, ByVal FieldID As String, ByVal STT As Integer) As Integer
            Try
                Dim obj As New HienThiTruong_DAL
                Return obj.Insert_FieldDefault(FieldGroup, FieldID, STT)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region        
    End Class
End Namespace
