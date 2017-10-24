﻿'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Saturday, December 27, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class KeHoachKhac_BLL
        Private arrKeHoachKhac As New ArrayList

#Region "Constructor"
        Public Sub New()
            Try
                Dim obj_DAL As KeHoachKhac_DAL = New KeHoachKhac_DAL
                Dim dt As DataTable = obj_DAL.Load_KeHoachKhac_List
                Dim obj As KeHoachKhac = Nothing
                Dim dr As DataRow = Nothing
                arrKeHoachKhac = New ArrayList
                For Each dr In dt.Rows
                    obj = Converting(dr)
                    arrKeHoachKhac.Add(obj)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function DanhSachKeHoachKhac() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID", GetType(Integer))
            dt.Columns.Add("Hoc_ky", GetType(Integer))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("Ky_hieu", GetType(String))
            dt.Columns.Add("Pham_vi", GetType(String))
            dt.Columns.Add("Tu_ngay", GetType(String))
            dt.Columns.Add("Den_ngay", GetType(String))
            dt.Columns.Add("Ten_ky_hieu", GetType(String))
            dt.Columns.Add("Hien_thi", GetType(Integer))

            For i As Integer = 0 To arrKeHoachKhac.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim obj As KeHoachKhac = CType(arrKeHoachKhac(i), KeHoachKhac)
                row("ID") = obj.ID
                row("Hoc_ky") = obj.Hoc_ky
                row("Nam_hoc") = obj.Nam_hoc
                row("ID_he") = obj.ID_he
                row("Ky_hieu") = obj.Ky_hieu

                Dim strPham_vi As String = "(HK: " & obj.Hoc_ky & ",NH: " & obj.Nam_hoc & ")-Hệ:" & obj.Ten_he
                If obj.Khoa_hoc <> 0 Then strPham_vi &= "-Khóa:" & obj.Khoa_hoc
                If obj.Ten_nganh <> "" Then strPham_vi &= "-Ngành:" & obj.Ten_nganh
                If obj.Chuyen_nganh <> "" Then strPham_vi &= "-CN:" & obj.Chuyen_nganh

                row("Pham_vi") = strPham_vi
                row("Tu_ngay") = obj.Tu_ngay.Date
                row("Den_ngay") = obj.Den_ngay.Date
                row("Ten_ky_hieu") = obj.Ten_ky_hieu
                row("Hien_thi") = obj.Hien_thi
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Public Function ThongBaoKeHoachKhac(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As String
            Try
                Dim obj_DAL As KeHoachKhac_DAL = New KeHoachKhac_DAL
                Dim dt As DataTable = obj_DAL.Load_KeHoachKhac_ThongBao(Hoc_ky, Nam_hoc, ID_he)
                Dim result As String = ""
                For i As Integer = 0 To dt.Rows.Count - 1
                    result &= dt.Rows(i)(0).ToString & vbCrLf
                Next
                Return result
            Catch ex As Exception
            End Try
        End Function
        Public Function GetKeHoachKhac(ByVal ID As Integer) As KeHoachKhac
            Dim obj As New KeHoachKhac
            For i As Integer = 0 To arrKeHoachKhac.Count - 1
                obj = CType(arrKeHoachKhac(i), KeHoachKhac)
                If obj.ID = ID Then Return obj
            Next
            Return Nothing
        End Function
        Public Function Insert_KeHoachKhac(ByVal objKeHoachKhac As KeHoachKhac) As Integer
            Try
                Dim obj As KeHoachKhac_DAL = New KeHoachKhac_DAL
                Return obj.Insert_KeHoachKhac(objKeHoachKhac)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachKhac(ByVal objKeHoachKhac As KeHoachKhac, ByVal ID As Integer) As Integer
            Try
                Dim obj As KeHoachKhac_DAL = New KeHoachKhac_DAL
                Return obj.Update_KeHoachKhac(objKeHoachKhac, ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KeHoachKhac(ByVal ID As Integer) As Integer
            Try
                Dim obj As KeHoachKhac_DAL = New KeHoachKhac_DAL
                Return obj.Delete_KeHoachKhac(ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExisKeHoachKhac(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal id_he As Integer, ByVal ky_hieu As String, ByVal tu_ngay As Date, ByVal den_ngay As Date) As Boolean
            Try
                Dim obj As KeHoachKhac_DAL = New KeHoachKhac_DAL
                obj.CheckExist_KeHoachKhac(Hoc_ky, Nam_hoc, id_he, ky_hieu, tu_ngay, den_ngay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drKeHoachKyHieu As DataRow) As KeHoachKhac
            Dim result As KeHoachKhac
            Try
                result = New KeHoachKhac
                If drKeHoachKyHieu("ID").ToString() <> "" Then result.ID = CType(drKeHoachKyHieu("ID").ToString(), Integer)
                If drKeHoachKyHieu("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drKeHoachKyHieu("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drKeHoachKyHieu("Nam_hoc").ToString()
                If drKeHoachKyHieu("ID_he").ToString() <> "" Then result.ID_he = CType(drKeHoachKyHieu("ID_he").ToString(), Integer)
                If drKeHoachKyHieu("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drKeHoachKyHieu("ID_khoa").ToString(), Integer)
                If drKeHoachKyHieu("Khoa_hoc").ToString() <> "" Then result.Khoa_hoc = CType(drKeHoachKyHieu("Khoa_hoc").ToString(), Integer)
                If drKeHoachKyHieu("ID_nganh").ToString() <> "" Then result.ID_nganh = CType(drKeHoachKyHieu("ID_nganh").ToString(), Integer)
                If drKeHoachKyHieu("ID_chuyen_nganh").ToString() <> "" Then result.ID_chuyen_nganh = CType(drKeHoachKyHieu("ID_chuyen_nganh").ToString(), Integer)
                If drKeHoachKyHieu("Tu_ngay").ToString() <> "" Then result.Tu_ngay = CType(drKeHoachKyHieu("Tu_ngay").ToString(), Date)
                If drKeHoachKyHieu("Den_ngay").ToString() <> "" Then result.Den_ngay = CType(drKeHoachKyHieu("Den_ngay").ToString(), Date)
                result.Ky_hieu = drKeHoachKyHieu("Ky_hieu").ToString()
                result.Hien_thi = drKeHoachKyHieu("Hien_thi").ToString()
                result.Ky_hieu1 = drKeHoachKyHieu("Ky_hieu1").ToString()
                result.Ten_ky_hieu = drKeHoachKyHieu("Ten_ky_hieu").ToString()
                If drKeHoachKyHieu("bgColor").ToString() <> "" Then result.bgColor = CType(drKeHoachKyHieu("bgColor").ToString(), Integer)
                If drKeHoachKyHieu("txtColor").ToString() <> "" Then result.txtColor = CType(drKeHoachKyHieu("txtColor").ToString(), Integer)
                result.Ma_he = drKeHoachKyHieu("Ma_he").ToString()
                result.Ten_he = drKeHoachKyHieu("Ten_he").ToString()
                result.Ma_khoa = drKeHoachKyHieu("Ma_khoa").ToString()
                result.Ten_khoa = drKeHoachKyHieu("Ten_khoa").ToString()
                result.Ma_nganh = drKeHoachKyHieu("Ma_nganh").ToString()
                result.Ten_nganh = drKeHoachKyHieu("Ten_nganh").ToString()
                result.Ma_chuyen_nganh = drKeHoachKyHieu("Ma_chuyen_nganh").ToString()
                result.Chuyen_nganh = drKeHoachKyHieu("Chuyen_nganh").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
