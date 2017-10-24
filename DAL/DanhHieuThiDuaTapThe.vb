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
    Public Class DanhHieuThiDuaTapThe_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_DanhHieuThiDuaTapThe_List(ByVal dsID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                Return UDB.SelectTableSP("STU_DanhHieuThiDuaTapThe_Load_List", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DanhHieuThiDuaTapThe(ByVal obj As DanhHieuThiDuaTapThe) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(2) = New SqlParameter("@ID_lop", obj.ID_lop)
                    para(3) = New SqlParameter("@ID_danh_hieu", obj.ID_danh_hieu)
                    para(4) = New SqlParameter("@Ly_do", obj.Ly_do)
                    para(5) = New SqlParameter("@ID_cap", obj.ID_cap)
                    Return UDB.ExecuteSP("STU_DanhHieuThiDuaTapThe_Insert", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(2) = New OracleParameter(":ID_lop", obj.ID_lop)
                    para(3) = New OracleParameter(":ID_danh_hieu", obj.ID_danh_hieu)
                    para(4) = New OracleParameter(":Ly_do", obj.Ly_do)
                    para(5) = New OracleParameter(":ID_cap", obj.ID_cap)
                    Return UDB.ExecuteSP("STU_DanhHieuThiDuaTapThe_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhHieuThiDuaTapThe(ByVal obj As DanhHieuThiDuaTapThe) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(2) = New SqlParameter("@ID_lop", obj.ID_lop)
                    para(3) = New SqlParameter("@ID_danh_hieu", obj.ID_danh_hieu)
                    para(4) = New SqlParameter("@Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("STU_DanhHieuThiDuaTapThe_Update", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(2) = New OracleParameter(":ID_lop", obj.ID_lop)
                    para(3) = New OracleParameter(":ID_danh_hieu", obj.ID_danh_hieu)
                    para(4) = New OracleParameter(":Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("STU_DanhHieuThiDuaTapThe_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhHieuThiDuaTapThe(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lop As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_lop", ID_lop)
                    Return UDB.ExecuteSP("STU_DanhHieuThiDuaTapThe_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_lop", ID_lop)
                    Return UDB.ExecuteSP("STU_DanhHieuThiDuaTapThe_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DanhHieuThiDuaTapThe(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lop As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_lop", ID_lop)
                    If UDB.SelectTableSP("STU_DanhHieuThiDuaTapThe_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_lop", ID_lop)
                    If UDB.SelectTableSP("STU_DanhHieuThiDuaTapThe_CheckExist", para).Rows.Count > 0 Then
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


