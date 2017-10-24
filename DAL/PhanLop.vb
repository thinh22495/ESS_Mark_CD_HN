Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class PhanLop_DAL
#Region "Contructor"
        Public Sub New()

        End Sub
#End Region
#Region "Function"
        ' Load danh sách sinh viên chua phân lớp
        Public Function DanhSachSinhVien(ByVal UserID As Integer, ByVal UserGroup As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                para(1) = New SqlParameter("@UserGroup", UserGroup)
                Return UDB.SelectTableSP("STU_LoadSinhVienChuaPhanLop", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace



