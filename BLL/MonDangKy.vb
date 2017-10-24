'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, August 12, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class MonDangKy_BLL
        Private arrMonDangKy As ArrayList
#Region "Constructor"
#End Region

#Region "Function"
        Public Function Insert_MonDangKy(ByVal objMonDangKy As MonDangKy) As Integer
            Try
                Dim obj As MonDangKy_DAL = New MonDangKy_DAL
                Return obj.Insert_MonDangKy(objMonDangKy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_MonDangKy(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As MonDangKy_DAL = New MonDangKy_DAL
                Return obj.Delete_MonDangKy(Hoc_ky, Nam_hoc, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
