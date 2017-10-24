'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, June 17, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class Khoa_BLL
        Private arrKhoa As ArrayList

#Region "Constructor"
        Public Sub New()
            'Add tat ca Khoa
            Try
                arrKhoa = New ArrayList
                Dim objKhoa_dal As New Khoa_DAL
                Dim dt As DataTable = objKhoa_dal.Load_Khoa_List()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objKhoa As New Khoa
                        objKhoa = Converting(dt.Rows(i))
                        arrKhoa.Add(objKhoa)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function DanhMucKhoa() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("Ten_khoa", GetType(String))
            For i As Integer = 0 To arrKhoa.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objKhoa As Khoa = CType(arrKhoa(i), Khoa)
                row("ID_khoa") = objKhoa.ID_khoa
                row("Ten_khoa") = objKhoa.Ten_khoa
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Public Function Insert_Khoa(ByVal objKhoa As Khoa) As Integer
            Try
                Dim obj As Khoa_DAL = New Khoa_DAL
                Return obj.Insert_Khoa(objKhoa)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Khoa(ByVal objKhoa As Khoa, ByVal ID_khoa As Integer) As Integer
            Try
                Dim obj As Khoa_DAL = New Khoa_DAL
                Return obj.Update_Khoa(objKhoa, ID_khoa)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_Khoa(ByVal ID_khoa As Integer) As Integer
            Try
                Dim obj As Khoa_DAL = New Khoa_DAL
                Return obj.Delete_Khoa(ID_khoa)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drKhoa As DataRow) As Khoa
            Dim result As Khoa
            Try
                result = New Khoa
                If drKhoa("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drKhoa("ID_khoa").ToString(), Integer)
                result.Ma_khoa = drKhoa("Ma_khoa").ToString()
                result.Ten_khoa = drKhoa("Ten_khoa").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
