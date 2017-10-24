Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class ToChucThiPhong_BLL
        Public Function Update_ToChucThi_ChiTiet_Phong(ByVal obj As ToChucThiPhong, ByVal ID_phong_thi As Integer) As Integer
            Try
                Dim objTCT As ToChucThiPhong_DAL = New ToChucThiPhong_DAL
                Return objTCT.Update_ToChucThi_ChiTiet_Phong(obj, ID_phong_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
