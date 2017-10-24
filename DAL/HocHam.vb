'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, June 17, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class HocHam_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_HocHam(ByVal ID_hoc_ham As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_hoc_ham", ID_hoc_ham)
                    Return UDB.SelectTableSP("PLAN_HocHam_Load", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_hoc_ham", ID_hoc_ham)
                    Return UDB.SelectTableSP("PLAN_HocHam_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_HocHam_List() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_HocHam_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_HocHam(ByVal obj As HocHam) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_hoc_ham", obj.Ma_hoc_ham)
                    para(1) = New SqlParameter("@Hoc_ham", obj.Hoc_ham)
                    Return UDB.ExecuteSP("PLAN_HocHam_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_hoc_ham", obj.Ma_hoc_ham)
                    para(1) = New OracleParameter(":Hoc_ham", obj.Hoc_ham)
                    Return UDB.ExecuteSP("PLAN_HocHam_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_HocHam(ByVal obj As HocHam, ByVal ID_hoc_ham As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_hoc_ham", ID_hoc_ham)
                    para(1) = New SqlParameter("@Ma_hoc_ham", obj.Ma_hoc_ham)
                    para(2) = New SqlParameter("@Hoc_ham", obj.Hoc_ham)
                    Return UDB.ExecuteSP("PLAN_HocHam_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_hoc_ham", ID_hoc_ham)
                    para(1) = New OracleParameter(":Ma_hoc_ham", obj.Ma_hoc_ham)
                    para(2) = New OracleParameter(":Hoc_ham", obj.Hoc_ham)
                    Return UDB.ExecuteSP("PLAN_HocHam_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_HocHam(ByVal ID_hoc_ham As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_hoc_ham", ID_hoc_ham)
                    Return UDB.ExecuteSP("PLAN_HocHam_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_hoc_ham", ID_hoc_ham)
                    Return UDB.ExecuteSP("PLAN_HocHam_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


