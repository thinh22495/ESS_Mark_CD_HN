'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Friday, July 24, 2009
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class PhanPhongThucHanh_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_PhanPhongThucHanh(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("PLAN_PhanPhongThucHanh_Load", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.SelectTableSP("PLAN_PhanPhongThucHanh_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_PhanPhongThucHanh(ByVal ID_kh_mon As Integer, ByVal Top_thu As Integer, ByVal ID_phong As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_mon", ID_kh_mon)
                    para(1) = New SqlParameter("@Top_thu", Top_thu)
                    para(2) = New SqlParameter("@ID_phong", ID_phong)
                    Return UDB.ExecuteSP("PLAN_PhanPhongThucHanh_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_mon", ID_kh_mon)
                    para(1) = New OracleParameter(":Top_thu", Top_thu)
                    para(2) = New OracleParameter(":ID_phong", ID_phong)
                    Return UDB.ExecuteSP("PLAN_PhanPhongThucHanh_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_PhanPhongThucHanh(ByVal ID_kh_mon As Integer, ByVal Top_thu As Integer, ByVal ID_phong As Integer, ByVal ID_phan_bo As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                    para(1) = New SqlParameter("@ID_kh_mon", ID_kh_mon)
                    para(2) = New SqlParameter("@Top_thu", Top_thu)
                    para(3) = New SqlParameter("@ID_phong", ID_phong)
                    Return UDB.ExecuteSP("PLAN_PhanPhongThucHanh_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_phan_bo", ID_phan_bo)
                    para(1) = New OracleParameter(":ID_kh_mon", ID_kh_mon)
                    para(2) = New OracleParameter(":Top_thu", Top_thu)
                    para(3) = New OracleParameter(":ID_phong", ID_phong)
                    Return UDB.ExecuteSP("PLAN_PhanPhongThucHanh_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_PhanPhongThucHanh(ByVal ID_phan_bo As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                    Return UDB.ExecuteSP("PLAN_PhanPhongThucHanh_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_phan_bo", ID_phan_bo)
                    Return UDB.ExecuteSP("PLAN_PhanPhongThucHanh_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_PhanPhongThucHanh(ByVal ID_kh_mon As Integer, ByVal Top_thu As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim dt As DataTable
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_kh_mon", ID_kh_mon)
                    para(1) = New SqlParameter("@Top_thu", Top_thu)
                    dt = UDB.SelectTableSP("PLAN_PhanPhongThucHanh_CheckExist", para)
                    If dt.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim dt As DataTable
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_kh_mon", ID_kh_mon)
                    para(1) = New OracleParameter(":Top_thu", Top_thu)
                    dt = UDB.SelectTableSP("PLAN_PhanPhongThucHanh_CheckExist", para)
                    If dt.Rows.Count > 0 Then
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


