Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class DanhMucMon_BLL
        Public Function MonHoc_Load_List() As DataTable
            Try
                Dim obj As New DanhMucMon_DAL
                Return obj.MonHoc_Load_List()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DMMon(ByVal objMonHoc As DanhMucMon, ByVal mID_mon As Integer) As Integer
            Try
                Dim obj As DanhMucMon_DAL = New DanhMucMon_DAL
                Return obj.Update_DMMon(objMonHoc, mID_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DMMon(ByVal objMonHoc As DanhMucMon) As Integer
            Try
                Dim obj As DanhMucMon_DAL = New DanhMucMon_DAL
                Return obj.Insert_DMMon(objMonHoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DMMon_DEL(ByVal mID_phong As Integer) As DataTable
            Try
                Dim obj As DanhMucMon_DAL = New DanhMucMon_DAL
                Return obj.DMMon_DEL(mID_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_Exist_MonHoc(ByVal Ky_hieu As String, ByVal Ten_mon As String) As Boolean
            Try
                Dim obj As New DanhMucMon_DAL
                Return obj.Check_Exist_MonHoc(Ky_hieu, Ten_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
