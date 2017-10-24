Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ThienAn.Machine
Imports ThienAn.Entity.Entity
Namespace DBManager
    Public Class PortalLogin_DAL
#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

        Public Function Login(ByVal UserName As String, ByVal Password As String) As Integer
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_sv", UserName)
                    para(1) = New SqlParameter("@Mat_khau", Password)
                    dt = UDB.SelectTableSP("sp_ptLogin", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_sv", UserName)
                    para(1) = New OracleParameter(":Mat_khau", Password)
                    dt = UDB.SelectTableSP("sp_ptLogin", para)
                End If
                If dt.Rows.Count = 0 Then
                    Return 0
                Else
                    Return CInt(dt.Rows(0)(0))
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Change_Password(ByVal ID_sv As Integer, ByVal Mat_khau As String) As Integer
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Mat_khau", Mat_khau)
                    dt = UDB.SelectTableSP("sp_ptChange_Password", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Mat_khau", Mat_khau)
                    dt = UDB.SelectTableSP("sp_ptChange_Password", para)
                End If
            Catch ex As Exception
            End Try
        End Function
        Public Function Change_Password_Canbo(ByVal UserName As String, ByVal Password As String) As Integer
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@UserName", UserName)
                    para(1) = New SqlParameter("@Password", Password)
                    dt = UDB.SelectTableSP("sp_ptChange_Password_Canbo", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":UserName", UserName)
                    para(1) = New OracleParameter(":Password", Password)
                    dt = UDB.SelectTableSP("sp_ptChange_Password_Canbo", para)
                End If
            Catch ex As Exception
            End Try
        End Function
        Public Function Load_ChuongTrinhDaoTao_List() As DataTable
            Try
                Dim dt As New DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("sp_ptChuongTrinhDaoTao_Load_List")
                Else
                    Return UDB.SelectTableSP("sp_ptChuongTrinhDaoTao_Load_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class

End Namespace


