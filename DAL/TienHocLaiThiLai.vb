'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Thursday, April 17, 2008 
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports System.IO
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class TienHocLaiThiLai_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region
#Region "FunctionSub"
        Public Function Insert_TienHocLaiThiLai(ByVal obj As TienHocLaiThiLai) As Integer
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(2) = New SqlParameter("@Lan_hoc", obj.Lan_hoc)
                para(3) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(4) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(5) = New SqlParameter("@Trang_thai", obj.Trang_thai)
                para(6) = New SqlParameter("@Da_nop_tien", obj.Da_nop_tien)
                para(7) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return UDB.ExecuteSP("STU_TienHocLaiThiLai_Insert", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_TienHocLaiThiLai(ByVal obj As TienHocLaiThiLai) As Integer
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(2) = New SqlParameter("@Lan_hoc", obj.Lan_hoc)
                para(3) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(4) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(5) = New SqlParameter("@Trang_thai", obj.Trang_thai)
                para(6) = New SqlParameter("@Da_nop_tien", obj.Da_nop_tien)
                para(7) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return UDB.ExecuteSP("STU_TienHocLaiThiLai_Update", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_HocLaiThiLai(ByVal ID_mon As Integer, ByVal ID_sv As Integer, ByVal Lan_hoc As Integer) As Boolean
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_mon", ID_mon)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                para(2) = New SqlParameter("@Lan_hoc", Lan_hoc)
                If UDB.SelectTableSP("CheckExist_HocLaiThiLai", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function DanhSachSinhVien_DaNop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lop As String) As DataTable
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(4) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(5) = New SqlParameter("@ID_lop", ID_lop)
                Return UDB.SelectTableSP("MARK_DS_DongTienHocLai", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


