'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Friday, July 24, 2009
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class PhanPhongThucHanh_BLL
#Region "Constructor"

#End Region

#Region "Function"
        Public Function Load_PhanPhongThucHanh(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As PhanPhongThucHanh_DAL = New PhanPhongThucHanh_DAL
                Return obj.Load_PhanPhongThucHanh(Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_PhanPhongThucHanh(ByVal ID_kh_mon As Integer, ByVal Top_thu As Integer, ByVal ID_phong As Integer) As Integer
            Try
                Dim obj As PhanPhongThucHanh_DAL = New PhanPhongThucHanh_DAL
                Return obj.Insert_PhanPhongThucHanh(ID_kh_mon, Top_thu, ID_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_PhanPhongThucHanh(ByVal ID_kh_mon As Integer, ByVal Top_thu As Integer, ByVal ID_phong As Integer, ByVal ID_phan_bo As Integer) As Integer
            Try
                Dim obj As PhanPhongThucHanh_DAL = New PhanPhongThucHanh_DAL
                Return obj.Update_PhanPhongThucHanh(ID_kh_mon, Top_thu, ID_phong, ID_phan_bo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_PhanPhongThucHanh(ByVal ID_phan_bo As Integer) As Integer
            Try
                Dim obj As PhanPhongThucHanh_DAL = New PhanPhongThucHanh_DAL
                Return obj.Delete_PhanPhongThucHanh(ID_phan_bo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_PhanPhongThucHanh(ByVal ID_kh_mon As Integer, ByVal Top_thu As Integer) As Boolean
            Try
                Dim obj As PhanPhongThucHanh_DAL = New PhanPhongThucHanh_DAL
                Return obj.CheckExist_PhanPhongThucHanh(ID_kh_mon, Top_thu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
