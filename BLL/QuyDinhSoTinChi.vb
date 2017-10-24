'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Monday, July 07, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ThienAn.Entity.Entity
Imports ThienAn.DAL.DBManager
Namespace Business
    Public Class QuyDinhSoTinChi_BLL
        Private arrQuyDinhSoTinChi As ArrayList

#Region "Constructor"
        Public Sub New()
            Dim obj As QuyDinhSoTinChi_DAL = New QuyDinhSoTinChi_DAL
            Dim dt As DataTable = obj.Load_QuyDinhSoTinChi_List()
            arrQuyDinhSoTinChi = New ArrayList
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim ph As New QuyDinhSoTinChi
                ph = Converting(dt.Rows(i))
                arrQuyDinhSoTinChi.Add(ph)
            Next
        End Sub
#End Region

#Region "Function"
        Public Function DanhSachQuyDinhSoTinChi() As DataTable
            Dim dt As New DataTable
            Try
                dt.Columns.Add("Check_so_tin_chi_max", GetType(Boolean))
                dt.Columns.Add("Check_so_tin_chi_min", GetType(Boolean))
                dt.Columns.Add("Den_ngay1", GetType(Date))
                dt.Columns.Add("Den_ngay2", GetType(Date))
                dt.Columns.Add("Ky_dang_ky", GetType(Integer))
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("ID_khoa", GetType(Integer))
                dt.Columns.Add("Khoa_hoc", GetType(Integer))
                dt.Columns.Add("So_tin_chi_max", GetType(Integer))
                dt.Columns.Add("So_tin_chi_min", GetType(Integer))
                dt.Columns.Add("So_tin_chi_option", GetType(Integer))
                dt.Columns.Add("Tu_ngay1", GetType(Date))
                dt.Columns.Add("Tu_ngay2", GetType(Date))
                dt.Columns.Add("Ten_he", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Ten", GetType(String))
                For i As Integer = 0 To arrQuyDinhSoTinChi.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objQuyDinhSoTinChi As QuyDinhSoTinChi = CType(arrQuyDinhSoTinChi(i), QuyDinhSoTinChi)
                    row("Check_so_tin_chi_max") = objQuyDinhSoTinChi.Check_so_tin_chi_max_bt
                    row("Check_so_tin_chi_max") = objQuyDinhSoTinChi.Check_so_tin_chi_max_yeu
                    row("Check_so_tin_chi_min") = objQuyDinhSoTinChi.Check_so_tin_chi_min_bt
                    row("Check_so_tin_chi_min") = objQuyDinhSoTinChi.Check_so_tin_chi_min_yeu
                    row("Den_ngay1") = objQuyDinhSoTinChi.Den_ngay1.ToString
                    If Not IsNothing(objQuyDinhSoTinChi.Den_ngay2) Then
                        row("Den_ngay2") = objQuyDinhSoTinChi.Den_ngay2.ToString
                    End If
                    row("Ky_dang_ky") = objQuyDinhSoTinChi.Ky_dang_ky
                    row("ID_he") = objQuyDinhSoTinChi.ID_he
                    row("ID_khoa") = objQuyDinhSoTinChi.ID_khoa
                    row("Khoa_hoc") = objQuyDinhSoTinChi.Khoa_hoc
                    row("So_tin_chi_max") = objQuyDinhSoTinChi.So_tin_chi_max_bt
                    row("So_tin_chi_max") = objQuyDinhSoTinChi.So_tin_chi_max_yeu
                    row("So_tin_chi_min") = objQuyDinhSoTinChi.So_tin_chi_min_bt
                    row("So_tin_chi_min") = objQuyDinhSoTinChi.So_tin_chi_min_yeu
                    row("So_tin_chi_option") = objQuyDinhSoTinChi.So_tin_chi_option_bt
                    row("So_tin_chi_option") = objQuyDinhSoTinChi.So_tin_chi_option_yeu
                    row("Tu_ngay1") = objQuyDinhSoTinChi.Tu_ngay1.ToString
                    If Not IsNothing(objQuyDinhSoTinChi.Tu_ngay2) Then
                        row("Tu_ngay2") = objQuyDinhSoTinChi.Tu_ngay2.ToString
                    End If
                    row("Ten_he") = objQuyDinhSoTinChi.Ten_he
                    row("Ten_khoa") = objQuyDinhSoTinChi.Ten_khoa
                    row("Ten") = objQuyDinhSoTinChi.Ten_he & "," & objQuyDinhSoTinChi.Ten_khoa & "," & objQuyDinhSoTinChi.Khoa_hoc
                    dt.Rows.Add(row)
                Next
            Catch ex As Exception
            End Try
            Return dt
        End Function
        Public Function GetQuyDinhSoTinChi(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Ky_dang_ky As Integer) As QuyDinhSoTinChi
            Dim objQuyDinhSoTinChi As New QuyDinhSoTinChi
            Dim idx As Integer = TimIdx(ID_he, ID_khoa, Khoa_hoc, Ky_dang_ky)
            Return arrQuyDinhSoTinChi(idx)
        End Function
        Public Function Insert_QuyDinhSoTinChi(ByVal objQuyDinhSoTinChi As QuyDinhSoTinChi) As Integer
            Try
                Dim obj As QuyDinhSoTinChi_DAL = New QuyDinhSoTinChi_DAL
                Return obj.Insert_QuyDinhSoTinChi(objQuyDinhSoTinChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_QuyDinhSoTinChi(ByVal objQuyDinhSoTinChi As QuyDinhSoTinChi) As Integer
            Try
                Dim obj As QuyDinhSoTinChi_DAL = New QuyDinhSoTinChi_DAL
                Return obj.Update_QuyDinhSoTinChi(objQuyDinhSoTinChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_ChonDotDangKy(ByVal Ky_dang_ky As Integer) As Integer
            Try
                Dim obj As QuyDinhSoTinChi_DAL = New QuyDinhSoTinChi_DAL
                Return obj.Update_ChonDotDangKy(Ky_dang_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_QuyDinhSoTinChi(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Ky_dang_ky As Integer) As Integer
            Try
                Dim obj As QuyDinhSoTinChi_DAL = New QuyDinhSoTinChi_DAL
                Return obj.Delete_QuyDinhSoTinChi(ID_he, ID_khoa, Khoa_hoc, Ky_dang_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_QuyDinhSoTinChi(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Ky_dang_ky As Integer) As Boolean
            Try
                Dim obj As QuyDinhSoTinChi_DAL = New QuyDinhSoTinChi_DAL
                Return obj.CheckExist_QuyDinhSoTinChi(ID_he, ID_khoa, Khoa_hoc, Ky_dang_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drQuyDinhSoTinChi As DataRow) As QuyDinhSoTinChi
            Dim result As QuyDinhSoTinChi
            Try
                result = New QuyDinhSoTinChi
                If drQuyDinhSoTinChi("ID_he").ToString() <> "" Then result.ID_he = CType(drQuyDinhSoTinChi("ID_he").ToString(), Integer)
                If drQuyDinhSoTinChi("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drQuyDinhSoTinChi("ID_khoa").ToString(), Integer)
                If drQuyDinhSoTinChi("Khoa_hoc").ToString() <> "" Then result.Khoa_hoc = CType(drQuyDinhSoTinChi("Khoa_hoc").ToString(), Integer)
                If drQuyDinhSoTinChi("Ky_dang_ky").ToString() <> "" Then result.Ky_dang_ky = CType(drQuyDinhSoTinChi("Ky_dang_ky").ToString(), Integer)
                If drQuyDinhSoTinChi("So_tin_chi_min_bt").ToString() <> "" Then result.So_tin_chi_min_bt = CType(drQuyDinhSoTinChi("So_tin_chi_min_bt").ToString(), Integer)
                If drQuyDinhSoTinChi("So_tin_chi_min_yeu").ToString() <> "" Then result.So_tin_chi_min_yeu = CType(drQuyDinhSoTinChi("So_tin_chi_min_yeu").ToString(), Integer)
                If drQuyDinhSoTinChi("So_tin_chi_max_bt").ToString() <> "" Then result.So_tin_chi_max_bt = CType(drQuyDinhSoTinChi("So_tin_chi_max_bt").ToString(), Integer)
                If drQuyDinhSoTinChi("So_tin_chi_max_yeu").ToString() <> "" Then result.So_tin_chi_max_yeu = CType(drQuyDinhSoTinChi("So_tin_chi_max_yeu").ToString(), Integer)
                If drQuyDinhSoTinChi("So_tin_chi_option_bt").ToString() <> "" Then result.So_tin_chi_option_bt = CType(drQuyDinhSoTinChi("So_tin_chi_option_bt").ToString(), Integer)
                If drQuyDinhSoTinChi("So_tin_chi_option_yeu").ToString() <> "" Then result.So_tin_chi_option_yeu = CType(drQuyDinhSoTinChi("So_tin_chi_option_yeu").ToString(), Integer)
                result.Check_so_tin_chi_min_bt = drQuyDinhSoTinChi("Check_so_tin_chi_min_bt").ToString()
                result.Check_so_tin_chi_min_yeu = drQuyDinhSoTinChi("Check_so_tin_chi_min_yeu").ToString()
                result.Check_so_tin_chi_max_bt = drQuyDinhSoTinChi("Check_so_tin_chi_max_bt").ToString()
                result.Check_so_tin_chi_max_yeu = drQuyDinhSoTinChi("Check_so_tin_chi_max_yeu").ToString()
                If drQuyDinhSoTinChi("Tu_ngay1").ToString() <> "" Then result.Tu_ngay1 = CType(drQuyDinhSoTinChi("Tu_ngay1").ToString(), Date)
                If drQuyDinhSoTinChi("Den_ngay1").ToString() <> "" Then result.Den_ngay1 = CType(drQuyDinhSoTinChi("Den_ngay1").ToString(), Date)
                If drQuyDinhSoTinChi("Tu_ngay2").ToString() <> "" Then result.Tu_ngay2 = CType(drQuyDinhSoTinChi("Tu_ngay2").ToString(), Date)
                If drQuyDinhSoTinChi("Den_ngay2").ToString() <> "" Then result.Den_ngay2 = CType(drQuyDinhSoTinChi("Den_ngay2").ToString(), Date)
                If drQuyDinhSoTinChi("Ten_he").ToString() <> "" Then result.Ten_he = CType(drQuyDinhSoTinChi("Ten_he").ToString(), String)
                If drQuyDinhSoTinChi("Ten_khoa").ToString() <> "" Then result.Ten_khoa = CType(drQuyDinhSoTinChi("Ten_khoa").ToString(), String)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function TimIdx(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Ky_dang_ky As Integer) As Integer
            For i As Integer = 0 To arrQuyDinhSoTinChi.Count - 1
                If CType(arrQuyDinhSoTinChi(i), QuyDinhSoTinChi).ID_he = ID_he _
                And CType(arrQuyDinhSoTinChi(i), QuyDinhSoTinChi).ID_khoa = ID_khoa _
                And CType(arrQuyDinhSoTinChi(i), QuyDinhSoTinChi).Khoa_hoc = Khoa_hoc _
                And CType(arrQuyDinhSoTinChi(i), QuyDinhSoTinChi).Ky_dang_ky = Ky_dang_ky Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
    End Class
End Namespace
