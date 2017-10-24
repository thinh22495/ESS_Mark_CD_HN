'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Wednesday, April 08, 2009
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class KeHoachKyHieu_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_KeHoachKyHieu_List() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_KeHoachKyHieu_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KeHoachKyHieu(ByVal obj As KeHoachKyHieu) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@Ky_hieu", obj.Ky_hieu)
                    para(1) = New SqlParameter("@Ten_ky_hieu", obj.Ten_ky_hieu)
                    para(2) = New SqlParameter("@bgColor", obj.bgColor)
                    para(3) = New SqlParameter("@txtColor", obj.txtColor)
                    Return UDB.ExecuteSP("PLAN_KeHoachKyHieu_Insert", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":Ky_hieu", obj.Ky_hieu)
                    para(1) = New OracleParameter(":Ten_ky_hieu", obj.Ten_ky_hieu)
                    para(2) = New OracleParameter(":bgColor", obj.bgColor)
                    para(3) = New OracleParameter(":txtColor", obj.txtColor)
                    Return UDB.ExecuteSP("PLAN_KeHoachKyHieu_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachKyHieu(ByVal obj As KeHoachKyHieu, ByVal ID_ky_hieu As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_ky_hieu", ID_ky_hieu)
                    para(1) = New SqlParameter("@Ky_hieu", obj.Ky_hieu)
                    para(2) = New SqlParameter("@Ten_ky_hieu", obj.Ten_ky_hieu)
                    para(3) = New SqlParameter("@bgColor", obj.bgColor)
                    para(4) = New SqlParameter("@txtColor", obj.txtColor)
                    Return UDB.ExecuteSP("PLAN_KeHoachKyHieu_Update", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_ky_hieu", ID_ky_hieu)
                    para(1) = New OracleParameter(":Ky_hieu", obj.Ky_hieu)
                    para(2) = New OracleParameter(":Ten_ky_hieu", obj.Ten_ky_hieu)
                    para(3) = New OracleParameter(":bgColor", obj.bgColor)
                    para(4) = New OracleParameter(":txtColor", obj.txtColor)
                    Return UDB.ExecuteSP("PLAN_KeHoachKyHieu_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KeHoachKyHieu(ByVal ID_ky_hieu As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_ky_hieu", ID_ky_hieu)
                    Return UDB.ExecuteSP("PLAN_KeHoachKyHieu_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_ky_hieu", ID_ky_hieu)
                    Return UDB.ExecuteSP("PLAN_KeHoachKyHieu_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


