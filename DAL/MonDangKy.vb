'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, August 12, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class MonDangKy_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Insert_MonDangKy(ByVal obj As MonDangKy) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(2) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(3) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(4) = New SqlParameter("@So_hoc_trinh", obj.So_hoc_trinh)
                    para(5) = New SqlParameter("@ID_dt", obj.ID_dt)
                    Return UDB.ExecuteSP("PLAN_MonDangKy_Insert", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(2) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(3) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(4) = New OracleParameter(":So_hoc_trinh", obj.So_hoc_trinh)
                    para(5) = New OracleParameter(":ID_dt", obj.ID_dt)
                    Return UDB.ExecuteSP("PLAN_MonDangKy_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_MonDangKy(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.ExecuteSP("PLAN_MonDangKy_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.ExecuteSP("PLAN_MonDangKy_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


