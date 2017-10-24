Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class DanhMucPhong_BLL
        Public Function PhongHoc_Load_List() As DataTable
            Try
                Dim obj As New DanhMucPhong_DAL
                Return obj.PhongHoc_Load_List()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DMPhong(ByVal objPhong As DanhMucPhong, ByVal mID_phong As Integer) As Integer
            Try
                Dim obj As DanhMucPhong_DAL = New DanhMucPhong_DAL
                Return obj.Update_DMPhong(objPhong, mID_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DMPhong(ByVal objPhong As DanhMucPhong) As Integer
            Try
                Dim obj As DanhMucPhong_DAL = New DanhMucPhong_DAL
                Return obj.Insert_DMPhong(objPhong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DMPhong_DEL(ByVal mID_phong As Integer) As DataTable
            Try
                Dim obj As DanhMucPhong_DAL = New DanhMucPhong_DAL
                Return obj.DMPhong_DEL(mID_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
