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
    Public Class HocVi_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_HocVi(ByVal ID_hoc_vi As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_hoc_vi", ID_hoc_vi)
                    Return UDB.SelectTableSP("PLAN_HocVi_Load", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_hoc_vi", ID_hoc_vi)
                    Return UDB.SelectTableSP("PLAN_HocVi_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_HocVi_List() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_HocVi_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_HocVi(ByVal obj As HocVi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_hoc_vi", obj.Ma_hoc_vi)
                    para(1) = New SqlParameter("@Hoc_vi", obj.Hoc_vi)
                    Return UDB.ExecuteSP("PLAN_HocVi_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_hoc_vi", obj.Ma_hoc_vi)
                    para(1) = New OracleParameter(":Hoc_vi", obj.Hoc_vi)
                    Return UDB.ExecuteSP("PLAN_HocVi_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_HocVi(ByVal obj As HocVi, ByVal ID_hoc_vi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_hoc_vi", ID_hoc_vi)
                    para(1) = New SqlParameter("@Ma_hoc_vi", obj.Ma_hoc_vi)
                    para(2) = New SqlParameter("@Hoc_vi", obj.Hoc_vi)
                    Return UDB.ExecuteSP("PLAN_HocVi_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_hoc_vi", ID_hoc_vi)
                    para(1) = New OracleParameter(":Ma_hoc_vi", obj.Ma_hoc_vi)
                    para(2) = New OracleParameter(":Hoc_vi", obj.Hoc_vi)
                    Return UDB.ExecuteSP("PLAN_HocVi_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_HocVi(ByVal ID_hoc_vi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_hoc_vi", ID_hoc_vi)
                    Return UDB.ExecuteSP("PLAN_HocVi_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_hoc_vi", ID_hoc_vi)
                    Return UDB.ExecuteSP("PLAN_HocVi_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


