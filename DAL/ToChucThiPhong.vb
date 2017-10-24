Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class ToChucThiPhong_DAL
        Public Function Update_ToChucThi_ChiTiet_Phong(ByVal obj As ToChucThiPhong, ByVal ID_phong_thi As Integer) As Integer
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_phong_thi", obj.ID_phong_thi)
                para(1) = New SqlParameter("@ID_phong", obj.ID_phong)
                para(2) = New SqlParameter("@Ten_phong", obj.Ten_phong)
                para(3) = New SqlParameter("@Dot_thi", obj.Dot_thi)
                para(4) = New SqlParameter("@Ngay_thi", obj.Ngay_thi)
                para(5) = New SqlParameter("@Ca_thi", obj.Ca_thi)
                para(6) = New SqlParameter("@Nhom_tiet", obj.Nhom_tiet)
                para(7) = New SqlParameter("@Thoi_gian", obj.Thoi_gian)
                Return UDB.ExecuteSP("MARK_TochucThi_ChiTiet_Phong_Update", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
