'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, June 17, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class TienHocLaiThiLai_BLL
        Private arrHocHam As ArrayList

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Insert_TienHocLaiThiLai(ByVal objTienThiLaiHocLai As TienHocLaiThiLai) As Integer
            Try
                Dim obj As TienHocLaiThiLai_DAL = New TienHocLaiThiLai_DAL
                Return obj.Insert_TienHocLaiThiLai(objTienThiLaiHocLai)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_TienHocLaiThiLai(ByVal objTienThiLaiHocLai As TienHocLaiThiLai) As Integer
            Try
                Dim obj As TienHocLaiThiLai_DAL = New TienHocLaiThiLai_DAL
                Return obj.Update_TienHocLaiThiLai(objTienThiLaiHocLai)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_HocLaiThiLai(ByVal ID_mon As Integer, ByVal ID_sv As Integer, ByVal Lan_hoc As Integer) As Boolean
            Try
                Dim obj As TienHocLaiThiLai_DAL = New TienHocLaiThiLai_DAL
                Return obj.CheckExist_HocLaiThiLai(ID_mon, ID_sv, Lan_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Function DanhSachSinhVien_DaNop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lop As String) As DataTable
            Try
                Dim obj As TienHocLaiThiLai_DAL = New TienHocLaiThiLai_DAL
                Return obj.DanhSachSinhVien_DaNop(Hoc_ky, Nam_hoc, ID_he, Khoa_hoc, ID_chuyen_nganh, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
