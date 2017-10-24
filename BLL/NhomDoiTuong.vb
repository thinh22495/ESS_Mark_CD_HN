'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, April 22, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class NhomDoiTuong_BLL
        Inherits NhomDoiTuong

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        ' Load Danh mục nhom Doi tuong 
        Public Function Load_NhomDoiTuong() As DataTable
            Try
                Dim obj As NhomDoiTuong_DAL = New NhomDoiTuong_DAL
                Dim dt As DataTable = obj.Load_NhomDoiTuong()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_NhomDoiTuong(ByVal ID_nhom_dt As Integer) As NhomDoiTuong
            Try
                Dim obj As NhomDoiTuong_DAL = New NhomDoiTuong_DAL
                Dim dt As DataTable = obj.Load_NhomDoiTuong(ID_nhom_dt)
                Dim objNhomDoiTuong As NhomDoiTuong = Nothing
                If dt.Rows.Count > 0 Then
                    objNhomDoiTuong = Converting(dt.Rows(0))
                End If
                Return objNhomDoiTuong
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_NhomDoiTuong(ByVal objNhomDoiTuong As NhomDoiTuong) As Integer
            Try
                Dim obj As NhomDoiTuong_DAL = New NhomDoiTuong_DAL
                Return obj.Insert_NhomDoiTuong(objNhomDoiTuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_NhomDoiTuong(ByVal objNhomDoiTuong As NhomDoiTuong, ByVal ID_nhom_dt As Integer) As Integer
            Try
                Dim obj As NhomDoiTuong_DAL = New NhomDoiTuong_DAL
                Return obj.Update_NhomDoiTuong(objNhomDoiTuong, ID_nhom_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_NhomDoiTuong(ByVal ID_nhom_dt As Integer) As Integer
            Try
                Dim obj As NhomDoiTuong_DAL = New NhomDoiTuong_DAL
                Return obj.Delete_NhomDoiTuong(ID_nhom_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drNhomDoiTuong As DataRow) As NhomDoiTuong
            Dim result As NhomDoiTuong
            Try
                result = New NhomDoiTuong
                If drNhomDoiTuong("ID_nhom_dt").ToString() <> "" Then result.ID_nhom_dt = CType(drNhomDoiTuong("ID_nhom_dt").ToString(), Integer)
                result.Ma_nhom = drNhomDoiTuong("Ma_nhom").ToString()
                result.Ten_nhom = drNhomDoiTuong("Ten_nhom").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
