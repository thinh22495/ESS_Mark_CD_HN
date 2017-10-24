'---------------------------------------------------------------------------
' Author : Thien An ESS
' Company : Thien An ESS
' Created Date : Tuesday, November 03, 2011
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DiemRenLuyenTinChi_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_DiemRenLuyenTinChi(ByVal ID_diem_rl As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem_rl", ID_diem_rl)
                    Return UDB.SelectTableSP("MARK_DiemRenLuyenTinChi_TC_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem_rl", ID_diem_rl)
                    Return UDB.SelectTableSP("MARK_DiemRenLuyenTinChi_TC_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DiemRenLuyenTinChi_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon_tc As Integer) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                Return UDB.SelectTableSP("MARK_DiemRenLuyenTinChi_TC_Load_List", para)
            Else
                Dim para(2) As OracleParameter
                para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                para(2) = New OracleParameter(":ID_mon_tc", ID_mon_tc)
                Return UDB.SelectTableSP("MARK_DiemRenLuyenTinChi_TC_Load_List", para)
            End If
        End Function
        Public Function Insert_DiemRenLuyenTinChi(ByVal obj As DiemRenLuyenTinChi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(2) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(3) = New SqlParameter("@ID_mon_tc", obj.ID_mon_tc)
                    para(4) = New SqlParameter("@Diem", obj.Diem)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyenTinChi_TC_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(2) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(3) = New OracleParameter(":ID_mon_tc", obj.ID_mon_tc)
                    para(4) = New OracleParameter(":Diem", obj.Diem)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyenTinChi_TC_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemRenLuyenTinChi(ByVal obj As DiemRenLuyenTinChi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(2) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(3) = New SqlParameter("@ID_mon_tc", obj.ID_mon_tc)
                    para(4) = New SqlParameter("@Diem", obj.Diem)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyenTinChi_TC_Update", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(2) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(3) = New OracleParameter(":ID_mon_tc", obj.ID_mon_tc)
                    para(4) = New OracleParameter(":Diem", obj.Diem)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyenTinChi_TC_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DiemRenLuyenTinChi(ByVal ID_diem_rl As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem_rl", ID_diem_rl)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyenTinChi_TC_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem_rl", ID_diem_rl)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyenTinChi_TC_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DiemRenLuyenTinChi(ByVal obj As DiemRenLuyenTinChi) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem_rl", obj.ID_diem_rl)
                    If UDB.SelectTableSP("MARK_DiemRenLuyenTinChi_TC_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem_rl", obj.ID_diem_rl)
                    If UDB.SelectTableSP("MARK_DiemRenLuyenTinChi_TC_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

