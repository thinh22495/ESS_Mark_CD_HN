'---------------------------------------------------------------------------
' Author : Nguyễn Xuân Vinh
' Company : NamVietJSC
' Created Date : 27/07/2013
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class InChungChi_DAL
        Public Function InChungChi_Load_List() As DataTable
            Try
                Return UDB.SelectTableSP("Mark_InChungChi_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_SoHieu(ByVal So_hieu As String, ByVal ID_sv As Integer, ByVal Ten_cc As String) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@So_hieu", So_hieu)
                para(2) = New SqlParameter("@Ten_cc", Ten_cc)
                Return UDB.ExecuteSP("SoHieu_InChungChi_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_SoVaoSo(ByVal So_vao_so As String, ByVal ID_sv As Integer, ByVal Ten_cc As String) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@So_vao_so", So_vao_so)
                para(2) = New SqlParameter("@Ten_cc", Ten_cc)
                Return UDB.ExecuteSP("SoVaoSo_InChungChi_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_ChungChi(ByVal ID_sv As Integer, ByVal Ten_cc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Ten_cc", Ten_cc)
                Return UDB.SelectTableSP("Mark_Load_ChungChi ", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_InChungChi(ByVal objChungChi As InChungChi, ByVal ID_sv As Integer, ByVal Ten_cc As String) As Integer
            Try
                Dim para(16) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Ma_sv", objChungChi.Ma_sv)
                para(2) = New SqlParameter("@Ho_ten", objChungChi.Ho_ten)
                If objChungChi.Ngay_sinh = Nothing Then
                    para(3) = New SqlParameter("@Ngay_sinh", objChungChi.Ngay_sinh)
                Else
                    para(3) = New SqlParameter("@Ngay_sinh", objChungChi.Ngay_sinh)
                End If
                para(4) = New SqlParameter("@Gioi_tinh", objChungChi.Gioi_tinh)
                para(5) = New SqlParameter("@Chuyen_nganh", objChungChi.Chuyen_nganh)
                para(6) = New SqlParameter("@Ten_lop", objChungChi.Ten_lop)
                para(7) = New SqlParameter("@Ten_tinh", objChungChi.Ten_tinh)
                para(8) = New SqlParameter("@Diem", objChungChi.Diem)
                para(9) = New SqlParameter("@Xep_loai", objChungChi.Xep_loai)
                para(10) = New SqlParameter("@So_hieu", objChungChi.So_hieu)
                para(11) = New SqlParameter("@So_vao_so", objChungChi.So_vao_so)
                para(12) = New SqlParameter("@Tu_ngay", objChungChi.Tu_ngay)
                para(13) = New SqlParameter("@Den_ngay", objChungChi.Den_ngay)
                para(14) = New SqlParameter("@Tu_thang", objChungChi.Tu_thang)
                para(15) = New SqlParameter("@Den_thang", objChungChi.Den_thang)
                para(16) = New SqlParameter("@Ten_cc", Ten_cc)
                Return UDB.ExecuteSP("MARK_Update_ChungChi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_InChungChi(ByVal objChungChi As InChungChi) As Integer
            Try
                Dim para(16) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", objChungChi.ID_sv)
                para(1) = New SqlParameter("@Ma_sv", objChungChi.Ma_sv)
                para(2) = New SqlParameter("@Ho_ten", objChungChi.Ho_ten)
                If objChungChi.Ngay_sinh = Nothing Then
                    para(3) = New SqlParameter("@Ngay_sinh", objChungChi.Ngay_sinh)
                Else
                    para(3) = New SqlParameter("@Ngay_sinh", objChungChi.Ngay_sinh)
                End If
                para(4) = New SqlParameter("@Gioi_tinh", objChungChi.Gioi_tinh)
                para(5) = New SqlParameter("@Chuyen_nganh", objChungChi.Chuyen_nganh)
                para(6) = New SqlParameter("@Ten_lop", objChungChi.Ten_lop)
                para(7) = New SqlParameter("@Ten_tinh", objChungChi.Ten_tinh)
                para(8) = New SqlParameter("@Diem", objChungChi.Diem)
                para(9) = New SqlParameter("@Xep_loai", objChungChi.Xep_loai)
                para(10) = New SqlParameter("@So_hieu", objChungChi.So_hieu)
                para(11) = New SqlParameter("@So_vao_so", objChungChi.So_vao_so)
                para(12) = New SqlParameter("@Tu_ngay", objChungChi.Tu_ngay)
                para(13) = New SqlParameter("@Den_ngay", objChungChi.Den_ngay)
                para(14) = New SqlParameter("@Tu_thang", objChungChi.Tu_thang)
                para(15) = New SqlParameter("@Den_thang", objChungChi.Den_thang)
                para(16) = New SqlParameter("@Ten_cc", objChungChi.Ten_cc)
                Return UDB.ExecuteSP("MARK_INSERT_ChungChi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_InChungChi(ByVal ID_sv As Integer, ByVal Ten_cc As String) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Ten_cc", Ten_cc)
                Return UDB.ExecuteSP("Mark_Delete_InChungChi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

