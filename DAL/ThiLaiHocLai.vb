'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Friday, July 11, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class ThiLaiHocLai_DAL
#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function ThiLaiHocLai_TheoMon_Load_List(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lop As Integer, ByVal ID_mon As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(4) = New SqlParameter("@ID_lop", ID_lop)
                para(5) = New SqlParameter("@ID_mon", ID_mon)
                para(6) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(7) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return UDB.SelectTableSP("MARK_ThiLaiHocLai_TheoMon_Load_List", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


#End Region

    End Class
End Namespace

