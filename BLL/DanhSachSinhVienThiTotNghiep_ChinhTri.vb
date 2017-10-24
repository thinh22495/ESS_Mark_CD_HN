'---------------------------------------------------------------------------
' Author : Nguyễn Xuân Vinh
' Company : NamVietJSC
' Created Date : 06/01/2014
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business

    Public Class DanhSachSinhVienThiTotNghiep_ChinhTri_BLL

        Public Function DanhSachSinhVienThiTotNghiep_TheoKhoa(ByVal Khoa_hoc As Integer, ByVal ID_he As Integer) As DataTable
            Dim obj As DanhSachSinhVienThiTotNghiep_ChinhTri_DAL = New DanhSachSinhVienThiTotNghiep_ChinhTri_DAL
            Return obj.DanhSachSinhVienThiTotNghiep_TheoKhoa(Khoa_hoc, ID_he)
        End Function

        Public Function DanhSachSinhVienThiTotNghiep_TheoLop(ByVal ID_lop As Integer) As DataTable
            Dim obj As DanhSachSinhVienThiTotNghiep_ChinhTri_DAL = New DanhSachSinhVienThiTotNghiep_ChinhTri_DAL
            Return obj.DanhSachSinhVienThiTotNghiep_TheoLop(ID_lop)
        End Function

    End Class

End Namespace

