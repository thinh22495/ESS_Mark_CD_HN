'Tungnk
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DanhSachKhongThi_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function DanhSachKhongDuDKDuThi_Load_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DanhSachKhongThi_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DanhSachKhongThi_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachNoHocPhiHocKy_Load_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DanhSachKhongThi_NoHocPhiHocKy_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DanhSachKhongThi_NoHocPhiHocKy_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_DanhSachKhongThi(ByVal obj As DanhSachKhongThi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("STU_DanhSachKhongThi_Insert", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("STU_DanhSachKhongThi_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Public Function Update_DanhSachKhongThi(ByVal obj As DanhSachKhongThi, ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
        '    Try
        '        If gDBType = DatabaseType.SQLServer Then
        '            Dim para(4) As SqlParameter
        '            para(0) = New SqlParameter("@ID_sv", ID_sv)
        '            para(1) = New SqlParameter("@ID_mon", ID_mon)
        '            para(2) = New SqlParameter("@Hoc_ky", Hoc_ky)
        '            para(3) = New SqlParameter("@Nam_hoc", Nam_hoc)
        '            para(4) = New SqlParameter("@Ly_do", obj.Ly_do)
        '            Return UDB.ExecuteSP("STU_DanhSachKhongThi_Update", para)
        '        Else
        '            Dim para(4) As OracleParameter
        '            para(0) = New OracleParameter(":ID_sv", ID_sv)
        '            para(1) = New OracleParameter(":ID_mon", ID_mon)
        '            para(2) = New OracleParameter(":Hoc_ky", Hoc_ky)
        '            para(3) = New OracleParameter(":Nam_hoc", Nam_hoc)
        '            para(4) = New OracleParameter(":Ly_do", obj.Ly_do)
        '            Return UDB.ExecuteSP("STU_DanhSachKhongThi_Update", para)
        '        End If
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        Public Function Delete_DanhSachKhongThi(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.ExecuteSP("STU_DanhSachKhongThi_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.ExecuteSP("STU_DanhSachKhongThi_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

