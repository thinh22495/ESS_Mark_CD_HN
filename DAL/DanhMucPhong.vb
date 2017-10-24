Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DanhMucPhong_DAL
#Region "Constructor"
        Public Sub New()
        End Sub
#End Region
#Region "Function"
        Public Function PhongHoc_Load_List() As DataTable
            Try
                Return UDB.SelectTableSP("[PLAN_PhongHoc_Load]")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DMPhong(ByVal phong As DanhMucPhong) As Integer
            Try
                Dim obj As DanhMucPhong_DAL = New DanhMucPhong_DAL
                Return obj.Update_DMPhong(phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DMPhong(ByVal obj As DanhMucPhong, ByVal mID_phong As Integer) As Integer
            Try
                Dim para(10) As SqlParameter
                para(0) = New SqlParameter("@ID_phong", obj.ID_phong)
                para(1) = New SqlParameter("@ID_co_so", obj.ID_co_so)
                para(2) = New SqlParameter("@ID_nha", obj.ID_nha)
                para(3) = New SqlParameter("@ID_tang", obj.ID_tang)
                para(4) = New SqlParameter("@So_phong", obj.So_phong)
                para(5) = New SqlParameter("@Suc_chua", obj.Suc_chua)
                para(6) = New SqlParameter("@Tivi", obj.Tivi)
                para(7) = New SqlParameter("@Am_thanh", obj.Am_thanh)
                para(8) = New SqlParameter("@May_chieu", obj.May_chieu)
                para(9) = New SqlParameter("@May_tinh", obj.May_tinh)
                para(10) = New SqlParameter("@ID_Loai_phong", obj.ID_loai_phong)
                Return UDB.ExecuteSP("PLAN_DMPhong_Update", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DMPhong(ByVal obj As DanhMucPhong) As Integer
            Try
                Dim para(9) As SqlParameter
                para(0) = New SqlParameter("@ID_co_so", obj.ID_co_so)
                para(1) = New SqlParameter("@ID_nha", obj.ID_nha)
                para(2) = New SqlParameter("@ID_tang", obj.ID_tang)
                para(3) = New SqlParameter("@So_phong", obj.So_phong)
                para(4) = New SqlParameter("@Suc_chua", obj.Suc_chua)
                para(5) = New SqlParameter("@Tivi", obj.Tivi)
                para(6) = New SqlParameter("@Am_thanh", obj.Am_thanh)
                para(7) = New SqlParameter("@May_chieu", obj.May_chieu)
                para(8) = New SqlParameter("@May_tinh", obj.May_tinh)
                para(9) = New SqlParameter("@ID_Loai_phong", obj.ID_loai_phong)
                Return UDB.ExecuteSP("PLAN_DMPhong_Insert", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DMPhong_DEL(ByVal mID_phong As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_phong", mID_phong)
                Return UDB.SelectTableSP("PLAN_DMPhong_Del", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
