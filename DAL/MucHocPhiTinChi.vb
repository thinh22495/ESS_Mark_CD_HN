'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Thursday, July 31, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class MucHocPhiTinChi_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_MucHocPhiTinChi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    Return UDB.SelectTableSP("ACC_MucHocPhiTinChi_Load", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    Return UDB.SelectTableSP("ACC_MucHocPhiTinChi_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_MucHocPhiTinChi(ByVal obj As MucHocPhiTinChi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(1) = New SqlParameter("@ID_he", obj.ID_he)
                    para(2) = New SqlParameter("@So_tien", obj.So_tien)
                    Return UDB.ExecuteSP("ACC_MucHocPhiTinChi_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(1) = New OracleParameter(":ID_he", obj.ID_he)
                    para(2) = New OracleParameter(":So_tien", obj.So_tien)
                    Return UDB.ExecuteSP("ACC_MucHocPhiTinChi_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_MucHocPhiTinChi(ByVal obj As MucHocPhiTinChi, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    para(3) = New SqlParameter("@So_tien", obj.So_tien)
                    Return UDB.ExecuteSP("ACC_MucHocPhiTinChi_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    para(3) = New OracleParameter(":So_tien", obj.So_tien)
                    Return UDB.ExecuteSP("ACC_MucHocPhiTinChi_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_MucHocPhiTinChi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    Return UDB.ExecuteSP("ACC_MucHocPhiTinChi_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    Return UDB.ExecuteSP("ACC_MucHocPhiTinChi_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


