Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class CoVanHocTap_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"

        Public Function DanhSachSVCoVanHocTap_Load_List(ByVal UserName As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@UserName", UserName)
                    Return UDB.SelectTableSP("STU_DanhSachCoVanSV_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":UserName", UserName)
                    Return UDB.SelectTableSP("STU_DanhSachCoVanSV_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DanhSachSVCoVanHocTap(ByVal obj As CoVanHocTap) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_sv", obj.Ma_sv)
                    para(1) = New SqlParameter("@UserName", obj.UserName)
                    Return UDB.ExecuteSP("SYS_NguoiDungCoVanHocTap_Insert", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ma_sv", obj.Ma_sv)
                    para(1) = New OracleParameter(":UserName", obj.UserName)
                    Return UDB.ExecuteSP("SYS_NguoiDungCoVanHocTap_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSachSVCoVanHocTap(ByVal obj As CoVanHocTap) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@UserName", obj.UserName)
                    para(1) = New SqlParameter("@Ma_sv", obj.Ma_sv)
                    Return UDB.ExecuteSP("SYS_NguoiDungCoVanHocTap_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":UserName", obj.UserName)
                    para(1) = New OracleParameter(":Ma_sv", obj.Ma_sv)
                    Return UDB.ExecuteSP("SYS_NguoiDungCoVanHocTap_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSachSVCoVanHocTap(ByVal Ma_sv As String, ByVal UserName As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@UserName", UserName)
                    para(1) = New SqlParameter("@Ma_sv", Ma_sv)
                    Return UDB.ExecuteSP("SYS_NguoiDungCoVanHocTap_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":UserName", UserName)
                    para(1) = New OracleParameter(":Ma_sv", Ma_sv)
                    Return UDB.ExecuteSP("SYS_NguoiDungCoVanHocTap_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

