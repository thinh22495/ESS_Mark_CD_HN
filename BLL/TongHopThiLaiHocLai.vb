'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Friday, June 06, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class TongHopThiLaiHocLai_BLL
#Region "Constructor"
        Sub New()
        End Sub
#End Region

        Public Function ThiLaiHocLai_TheoMon_Load_List(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lop As Integer, ByVal ID_mon As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Dim cls As New ThiLaiHocLai_DAL
            Dim dt As DataTable = cls.ThiLaiHocLai_TheoMon_Load_List(ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh, ID_lop, ID_mon, Hoc_ky, Nam_hoc)
            dt.Columns.Add("Chon", GetType(Boolean))
            Return dt
        End Function

    End Class
End Namespace