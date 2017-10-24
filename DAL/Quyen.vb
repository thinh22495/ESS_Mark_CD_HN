'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/05/2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class Quyen_DAL
        Public Function Load_Quyen_List() As DataTable
            Try
                Return UDB.SelectTableSP("SYS_VaiTroQuyen_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_PhanHe_List() As DataTable
            Try
                Return UDB.SelectTableSP("SYS_PhanHe_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_UsersQuyen_List(ByVal UserID As Integer, ByVal ID_Vai_Tro As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@UserID", UserID)
                    para(1) = New SqlParameter("@ID_Vai_Tro", ID_Vai_Tro)
                    Return UDB.SelectTableSP("SYS_NguoiDungQuyen1_Load_List", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":UserID", UserID)
                    para(0) = New OracleParameter(":ID_Vai_Tro", ID_Vai_Tro)
                    Return UDB.SelectTableSP("SYS_NguoiDungQuyen1_Load_List", para)
                End If

            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace


