'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Thursday, August 28, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ThienAn.Machine
Imports ThienAn.Entity.Entity
Namespace DBManager
    Public Class ChuyenNganh_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_ChuyenNganh_List() As DataTable
            Try
                Return UDB.SelectTableSP("sp_STU_ChuyenNganh_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_ChuyenNganh(ByVal obj As ChuyenNganh) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_nganh", obj.ID_nganh)
                    para(1) = New SqlParameter("@Ma_chuyen_nganh", obj.Ma_chuyen_nganh)
                    para(2) = New SqlParameter("@Chuyen_nganh", obj.Chuyen_nganh)
                    Return UDB.ExecuteSP("sp_STU_ChuyenNganh_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_nganh", obj.ID_nganh)
                    para(1) = New OracleParameter(":Ma_chuyen_nganh", obj.Ma_chuyen_nganh)
                    para(2) = New OracleParameter(":Chuyen_nganh", obj.Chuyen_nganh)
                    Return UDB.ExecuteSP("sp_STU_ChuyenNganh_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_ChuyenNganh(ByVal obj As ChuyenNganh, ByVal ID_chuyen_nganh As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    para(1) = New SqlParameter("@ID_nganh", obj.ID_nganh)
                    para(2) = New SqlParameter("@Ma_chuyen_nganh", obj.Ma_chuyen_nganh)
                    para(3) = New SqlParameter("@Chuyen_nganh", obj.Chuyen_nganh)
                    Return UDB.ExecuteSP("sp_STU_ChuyenNganh_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    para(1) = New OracleParameter(":ID_nganh", obj.ID_nganh)
                    para(2) = New OracleParameter(":Ma_chuyen_nganh", obj.Ma_chuyen_nganh)
                    para(3) = New OracleParameter(":Chuyen_nganh", obj.Chuyen_nganh)
                    Return UDB.ExecuteSP("sp_STU_ChuyenNganh_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_ChuyenNganh(ByVal ID_chuyen_nganh As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.ExecuteSP("sp_STU_ChuyenNganh_Delete", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_chuyen_nganh", ID_chuyen_nganh)
                    Return UDB.ExecuteSP("sp_STU_ChuyenNganh_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_ChuyenNganh(ByVal Ma_chuyen_nganh As String) As Boolean
            Try
                Dim dt As New DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@Ma_chuyen_nganh", Ma_chuyen_nganh)
                    dt = UDB.SelectTableSP("sp_STU_ChuyenNganh_CheckExist", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":Ma_chuyen_nganh", Ma_chuyen_nganh)
                    dt = UDB.SelectTableSP("sp_STU_ChuyenNganh_CheckExist", para)
                End If
                If dt.Rows.Count = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


