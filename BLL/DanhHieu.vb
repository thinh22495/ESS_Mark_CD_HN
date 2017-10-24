'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Thursday, July 10, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class DanhHieu_BLL
        Private arrDanhHieu As New ArrayList

#Region "Constructor"
        Public Sub New()
            Try
                Dim obj As DanhHieu_DAL = New DanhHieu_DAL
                Dim dt As DataTable = obj.Load_DanhHieu_List()
                Dim objDH As DanhHieu
                Dim dr As DataRow
                For Each dr In dt.Rows
                    objDH = New DanhHieu
                    objDH = Converting(dr)
                    arrDanhHieu.Add(objDH)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function Danh_hieu(ByVal TBCMR As Double) As String
            For i As Integer = 0 To arrDanhHieu.Count - 1
                If CType(arrDanhHieu(i), DanhHieu).Tu_diem <= TBCMR And _
                    CType(arrDanhHieu(i), DanhHieu).Den_diem >= TBCMR Then
                    Return CType(arrDanhHieu(i), DanhHieu).Danh_hieu
                End If
            Next
            Return ""
        End Function
        Public Function Danh_hieu(ByVal ID_danh_hieu As Integer) As String
            For i As Integer = 0 To arrDanhHieu.Count - 1
                If CType(arrDanhHieu(i), DanhHieu).ID_danh_hieu = ID_danh_hieu Then
                    Return CType(arrDanhHieu(i), DanhHieu).Danh_hieu
                End If
            Next
            Return ""
        End Function
        Public Function ID_danh_hieu(ByVal TBCMR As Double) As Integer
            For i As Integer = 0 To arrDanhHieu.Count - 1
                If CType(arrDanhHieu(i), DanhHieu).Tu_diem <= TBCMR And _
                    CType(arrDanhHieu(i), DanhHieu).Den_diem >= TBCMR Then
                    Return CType(arrDanhHieu(i), DanhHieu).ID_danh_hieu
                End If
            Next
            Return -1
        End Function

        Public Function Insert_DanhHieu(ByVal objDanhHieu As DanhHieu) As Integer
            Try
                Dim obj As DanhHieu_DAL = New DanhHieu_DAL
                Return obj.Insert_DanhHieu(objDanhHieu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhHieu(ByVal objDanhHieu As DanhHieu, ByVal ID_danh_hieu As Integer) As Integer
            Try
                Dim obj As DanhHieu_DAL = New DanhHieu_DAL
                Return obj.Update_DanhHieu(objDanhHieu, ID_danh_hieu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhHieu(ByVal ID_danh_hieu As Integer) As Integer
            Try
                Dim obj As DanhHieu_DAL = New DanhHieu_DAL
                Return obj.Delete_DanhHieu(ID_danh_hieu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drDanhHieu As DataRow) As DanhHieu
            Dim result As DanhHieu
            Try
                result = New DanhHieu
                If drDanhHieu("ID_danh_hieu").ToString() <> "" Then result.ID_danh_hieu = CType(drDanhHieu("ID_danh_hieu").ToString(), Integer)
                result.Danh_hieu = drDanhHieu("Danh_hieu").ToString()
                If drDanhHieu("Tu_diem").ToString() <> "" Then result.Tu_diem = CType(drDanhHieu("Tu_diem").ToString(), Integer)
                If drDanhHieu("Den_diem").ToString() <> "" Then result.Den_diem = CType(drDanhHieu("Den_diem").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
