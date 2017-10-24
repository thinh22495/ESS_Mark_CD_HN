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
    Public Class DanhHieuThiDuaCaNhan_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_XepLoaiHocTap() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("MARK_XepLoaiHocTap_Load_List")
                Else
                    Return UDB.SelectTableSP("MARK_XepLoaiHocTap_Load_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_XepLoaiHocTapThangDiem10() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("MARK_XepLoaiHocTapThangDiem10_Load_List")
                Else
                    Return UDB.SelectTableSP("MARK_XepLoaiHocTapThangDiem10_Load_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_XLRenLuyen() As DataTable
            Try
                Return UDB.SelectTableSP("STU_XLRenLuyen_Load")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhHieuThiDuaCaNhan_List(ByVal dsID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                Return UDB.SelectTableSP("STU_DanhHieuThiDuaCaNhan_Load_List", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DanhHieuThiDuaCaNhan(ByVal obj As DanhHieuThiDuaCaNhan) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@TBCHT", obj.TBCHT)
                    para(4) = New SqlParameter("@DRL", obj.DRL)
                    para(5) = New SqlParameter("@TBCMR", obj.TBCMR)
                    para(6) = New SqlParameter("@ID_danh_hieu", obj.ID_danh_hieu)
                    Return UDB.ExecuteSP("STU_DanhHieuThiDuaCaNhan_Insert", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":TBCHT", obj.TBCHT)
                    para(4) = New OracleParameter(":DRL", obj.DRL)
                    para(5) = New OracleParameter(":TBCMR", obj.TBCMR)
                    para(6) = New OracleParameter(":ID_danh_hieu", obj.ID_danh_hieu)
                    Return UDB.ExecuteSP("STU_DanhHieuThiDuaCaNhan_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhHieuThiDuaCaNhan(ByVal obj As DanhHieuThiDuaCaNhan) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@TBCHT", obj.TBCHT)
                    para(4) = New SqlParameter("@DRL", obj.DRL)
                    para(5) = New SqlParameter("@TBCMR", obj.TBCMR)
                    para(6) = New SqlParameter("@ID_danh_hieu", obj.ID_danh_hieu)
                    Return UDB.ExecuteSP("STU_DanhHieuThiDuaCaNhan_Update", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":TBCHT", obj.TBCHT)
                    para(4) = New OracleParameter(":DRL", obj.DRL)
                    para(5) = New OracleParameter(":TBCMR", obj.TBCMR)
                    para(6) = New OracleParameter(":ID_danh_hieu", obj.ID_danh_hieu)
                    Return UDB.ExecuteSP("STU_DanhHieuThiDuaCaNhan_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhHieuThiDuaCaNhan(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.ExecuteSP("STU_DanhHieuThiDuaCaNhan_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.ExecuteSP("STU_DanhHieuThiDuaCaNhan_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DanhHieuThiDuaCaNhan(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    If UDB.SelectTableSP("STU_DanhHieuThiDuaCaNhan_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    If UDB.SelectTableSP("STU_DanhHieuThiDuaCaNhan_CheckExist", para).Rows.Count > 0 Then
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


