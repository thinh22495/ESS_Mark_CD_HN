﻿Imports System
Imports System.Drawing
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class DiemRenLuyen_New_BLL
#Region "Var"
        Private aDiemRenLuyen_News As ArrayList
        Private aSVRenLuyens As ArrayList
        Private dtXepLoai As DataTable
#End Region
#Region "Constructor"
        Public Sub New()

        End Sub
        Public Sub New(ByVal ID_lops As String)
            Try
                aDiemRenLuyen_News = New ArrayList
                aSVRenLuyens = New ArrayList
                Dim obj As New DiemRenLuyen_New_DAL
                Dim dtDiemRL As DataTable = obj.Load_DiemRenLuyen_NewLop(ID_lops)
                Dim dtSVRL As DataTable = obj.Load_SVRenLuyenLop(ID_lops)
                dtXepLoai = obj.Load_XLRenLuyen()
                Dim objDiemRL As New DiemRenLuyen_New
                Dim dr As DataRow = Nothing
                For Each dr In dtDiemRL.Rows
                    objDiemRL = ConvertingDiem(dr)
                    aDiemRenLuyen_News.Add(objDiemRL)
                Next
                For Each dr In dtSVRL.Rows
                    objDiemRL = Converting(dr)
                    aSVRenLuyens.Add(objDiemRL)
                Next
            Catch ex As Exception
                Throw (ex)
            End Try
        End Sub
#End Region
#Region "Function"
        ' Tính tổng điểm rèn luyện của sinh viên 
        Private Function SumPointKy(ByVal ID_sv As Integer, ByRef TongDiem As Integer, ByRef DRLQD As Double, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByRef Xep_loai As String, ByRef ID_xep_loai As Integer) As Integer
            Try
                TongDiem = 0
                DRLQD = 0
                Xep_loai = ""
                For i As Integer = 0 To aDiemRenLuyen_News.Count - 1
                    Dim DiemRl As DiemRenLuyen_New = CType(aDiemRenLuyen_News(i), DiemRenLuyen_New)
                    If DiemRl.ID_sv = ID_sv And DiemRl.Hoc_ky = Hoc_ky And DiemRl.Nam_hoc = Nam_hoc Then
                        TongDiem += DiemRl.Diem
                    End If
                Next
                If TongDiem > 100 Then TongDiem = 100
                DRLQD = CDbl(TongDiem / 100)
                For j As Integer = 0 To dtXepLoai.Rows.Count - 1
                    If TongDiem >= dtXepLoai.Rows(j).Item("Tu_diem") And TongDiem <= dtXepLoai.Rows(j).Item("Den_diem") Then
                        Xep_loai = dtXepLoai.Rows(j).Item("Xep_loai")
                        ID_xep_loai = dtXepLoai.Rows(j).Item("ID_xep_loai")
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Tính tổng điểm rèn luyện của sinh viên 
        Private Function SumPointNam(ByVal ID_sv As Integer, ByRef TongDiem As Integer, ByRef TongDiemKy1 As Integer, ByRef TongDiemKy2 As Integer, ByRef DRLQD As Double, ByVal Nam_hoc As String, ByRef Xep_loai As String, ByRef ID_xep_loai As Integer) As Integer
            Try
                TongDiem = 0
                TongDiemKy1 = 0
                TongDiemKy2 = 0
                DRLQD = 0
                Xep_loai = ""
                For i As Integer = 0 To aDiemRenLuyen_News.Count - 1
                    Dim DiemRl As DiemRenLuyen_New = CType(aDiemRenLuyen_News(i), DiemRenLuyen_New)
                    'If DiemRl.ID_sv = ID_sv And DiemRl.Nam_hoc = Nam_hoc Then TongDiem += DiemRl.Diem
                    If DiemRl.ID_sv = ID_sv And DiemRl.Hoc_ky = 1 And DiemRl.Nam_hoc = Nam_hoc Then
                        TongDiemKy1 += DiemRl.Diem
                    End If
                    If DiemRl.ID_sv = ID_sv And DiemRl.Hoc_ky = 2 And DiemRl.Nam_hoc = Nam_hoc Then
                        TongDiemKy2 += DiemRl.Diem
                    End If
                Next
                If TongDiemKy1 > 100 Then TongDiemKy1 = 100
                If TongDiemKy2 > 100 Then TongDiemKy2 = 100
                TongDiem = (TongDiemKy1 + TongDiemKy2) / 2
                DRLQD = CDbl(TongDiem / 100)
                For j As Integer = 0 To dtXepLoai.Rows.Count - 1
                    If TongDiem >= dtXepLoai.Rows(j).Item("Tu_diem") And TongDiem <= dtXepLoai.Rows(j).Item("Den_diem") Then
                        Xep_loai = dtXepLoai.Rows(j).Item("Xep_loai")
                        ID_xep_loai = dtXepLoai.Rows(j).Item("ID_xep_loai")
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Tính tổng điểm rèn luyện của sinh viên         
        Private Function SumPointKhoa(ByVal ID_sv As Integer, ByRef TongDiem As Integer, ByRef TongDiemNam1 As Integer, ByRef TongDiemNam2 As Integer, ByRef TongDiemNam3 As Integer, ByRef TongDiemNam4 As Integer, ByRef TongDiemNam5 As Integer, ByRef DRLQD As Double, ByRef Xep_loai As String, ByRef ID_xep_loai As Integer) As Integer
            Try
                TongDiem = 0
                TongDiemNam1 = 0
                TongDiemNam2 = 0
                TongDiemNam3 = 0
                TongDiemNam4 = 0
                TongDiemNam5 = 0
                DRLQD = 0
                Xep_loai = ""
                Dim Nam1_ky1 As Integer, Nam1_Ky2 As Integer
                Dim Nam2_ky1 As Integer, Nam2_Ky2 As Integer
                Dim Nam3_ky1 As Integer, Nam3_Ky2 As Integer
                Dim Nam4_ky1 As Integer, Nam4_Ky2 As Integer
                Dim Nam5_ky1 As Integer, Nam5_Ky2 As Integer
                Dim obj As New DanhMuc_BLL
                Dim Nien_khoa As String = obj.LoadNienKhoa(ID_sv)
                If Nien_khoa = "" Then Exit Function
                Dim arrNam(1) As String
                arrNam = Nien_khoa.Split("-")
                Dim SoNam As Integer = arrNam(1) - arrNam(0)
                Dim Nam1, Nam2, Nam3, Nam4 As String
                Dim Nam5 As String = ""
                Nam1 = arrNam(0) & "-" & arrNam(0) + 1
                Nam2 = arrNam(0) + 1 & "-" & arrNam(0) + 2
                Nam3 = arrNam(0) + 2 & "-" & arrNam(0) + 3
                Nam4 = arrNam(0) + 3 & "-" & arrNam(0) + 4
                If SoNam = 5 Then Nam5 = arrNam(0) + 4 & "-" & arrNam(0) + 5
                For i As Integer = 0 To aDiemRenLuyen_News.Count - 1
                    Dim DiemRl As DiemRenLuyen_New = CType(aDiemRenLuyen_News(i), DiemRenLuyen_New)
                    ' Năm thứ nhất
                    If DiemRl.ID_sv = ID_sv And DiemRl.Nam_hoc = Nam1 And DiemRl.Hoc_ky = 1 Then
                        Nam1_ky1 += DiemRl.Diem
                    ElseIf DiemRl.ID_sv = ID_sv And DiemRl.Nam_hoc = Nam1 And DiemRl.Hoc_ky = 2 Then
                        Nam1_Ky2 += DiemRl.Diem
                    End If
                    ' Năm thứ hai
                    If DiemRl.ID_sv = ID_sv And DiemRl.Nam_hoc = Nam2 And DiemRl.Hoc_ky = 1 Then
                        Nam2_ky1 += DiemRl.Diem
                    ElseIf DiemRl.ID_sv = ID_sv And DiemRl.Nam_hoc = Nam2 And DiemRl.Hoc_ky = 2 Then
                        Nam2_Ky2 += DiemRl.Diem
                    End If
                    ' Năm thứ ba
                    If DiemRl.ID_sv = ID_sv And DiemRl.Nam_hoc = Nam3 And DiemRl.Hoc_ky = 1 Then
                        Nam3_ky1 += DiemRl.Diem
                    ElseIf DiemRl.ID_sv = ID_sv And DiemRl.Nam_hoc = Nam3 And DiemRl.Hoc_ky = 2 Then
                        Nam3_Ky2 += DiemRl.Diem
                    End If
                    ' Năm thứ bốn
                    If DiemRl.ID_sv = ID_sv And DiemRl.Nam_hoc = Nam4 And DiemRl.Hoc_ky = 1 Then
                        Nam4_ky1 += DiemRl.Diem
                    ElseIf DiemRl.ID_sv = ID_sv And DiemRl.Nam_hoc = Nam4 And DiemRl.Hoc_ky = 2 Then
                        Nam4_Ky2 += DiemRl.Diem
                    End If
                    ' Năm thứ năm
                    If DiemRl.ID_sv = ID_sv And DiemRl.Nam_hoc = Nam5 And DiemRl.Hoc_ky = 1 Then
                        Nam5_ky1 += DiemRl.Diem
                    ElseIf DiemRl.ID_sv = ID_sv And DiemRl.Nam_hoc = Nam5 And DiemRl.Hoc_ky = 2 Then
                        Nam5_Ky2 += DiemRl.Diem
                    End If
                Next
                TongDiemNam1 = (Nam1_ky1 + Nam1_Ky2) / 2 ' Tổng điểm năm thứ nhất                
                TongDiemNam2 = (Nam2_ky1 + Nam2_Ky2) / 2 ' Tổng điểm năm thứ hai                
                TongDiemNam3 = (Nam3_ky1 + Nam3_Ky2) / 2 ' Tổng điểm năm thứ ba                
                TongDiemNam4 = (Nam4_ky1 + Nam4_Ky2) / 2 ' Tổng điểm năm thứ bốn                
                TongDiemNam5 = (Nam5_ky1 + Nam5_Ky2) / 2 ' Tổng điểm năm thứ năm
                Dim DiemTong As Double
                Dim TongHeSo As Double
                Dim R As Integer ' Điểm rèn luyện toàn khóa                     
                Dim cls As New ThamSoHeThong_BLL(2) ' Lóp tham số hệ thống phân hệ Unistudent
                Dim n1 As Double = CDbl(IIf(cls.Doc_tham_so("HeSo_Nam1").ToString = "", 1, cls.Doc_tham_so("HeSo_Nam1")))
                Dim n2 As Double = CDbl(IIf(cls.Doc_tham_so("HeSo_Nam2").ToString = "", 1, cls.Doc_tham_so("HeSo_Nam2")))
                Dim n3 As Double = CDbl(IIf(cls.Doc_tham_so("HeSo_Nam3").ToString = "", 1, cls.Doc_tham_so("HeSo_Nam3")))
                Dim n4 As Double = CDbl(IIf(cls.Doc_tham_so("HeSo_Nam4").ToString = "", 1, cls.Doc_tham_so("HeSo_Nam4")))
                Dim n5 As Double = CDbl(IIf(cls.Doc_tham_so("HeSo_Nam5").ToString = "", 1, cls.Doc_tham_so("HeSo_Nam5")))
                For i As Integer = 1 To SoNam
                    If i = 1 Then
                        If TongDiemNam1 > 0 Then
                            DiemTong += TongDiemNam1 * n1
                            TongHeSo += n1
                        End If
                    End If
                    If i = 2 Then
                        If TongDiemNam2 > 0 Then
                            DiemTong += TongDiemNam2 * n2
                            TongHeSo += n2
                        End If
                    End If
                    If i = 3 Then
                        If TongDiemNam3 > 0 Then
                            DiemTong += TongDiemNam3 * n3
                            TongHeSo += n3
                        End If
                    End If
                    If i = 4 Then
                        If TongDiemNam4 > 0 Then
                            DiemTong += TongDiemNam4 * n4
                            TongHeSo += n4
                        End If
                    End If
                    If i = 5 Then
                        If TongDiemNam5 > 0 Then
                            DiemTong += TongDiemNam5 * n5
                            TongHeSo += n5
                        End If
                    End If
                Next
                R = DiemTong / TongHeSo
                If R > 100 Then R = 100
                TongDiem = R
                For j As Integer = 0 To dtXepLoai.Rows.Count - 1
                    If TongDiem >= dtXepLoai.Rows(j).Item("Tu_diem") And TongDiem <= dtXepLoai.Rows(j).Item("Den_diem") Then
                        Xep_loai = dtXepLoai.Rows(j).Item("Xep_loai")
                        ID_xep_loai = dtXepLoai.Rows(j).Item("ID_xep_loai")
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ' Tổng hợp điểm rèn luyện theo học kỳ 
        Public Function TongHop_DiemRenLuyen_NewKy(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim dt As New DataTable
                Dim tempID_sv As Integer
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(DateTime))
                dt.Columns.Add("Tong_diem", GetType(Integer))
                dt.Columns.Add("Diem_quy_doi", GetType(Double))
                dt.Columns.Add("Xep_loai", GetType(String))
                dt.Columns.Add("ID_xep_loai", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("ID_lop", GetType(String))
                For i As Integer = 0 To aDiemRenLuyen_News.Count - 1
                    Dim DiemRl As DiemRenLuyen_New = CType(aDiemRenLuyen_News(i), DiemRenLuyen_New)
                    Dim row As DataRow = dt.NewRow()
                    Dim TongDiem As Integer
                    Dim DiemQD As Double
                    Dim Xep_loai As String = ""
                    Dim ID_xep_loai As Integer
                    If DiemRl.Hoc_ky = Hoc_ky And DiemRl.Nam_hoc = Nam_hoc And tempID_sv <> DiemRl.ID_sv Then
                        SumPointKy(DiemRl.ID_sv, TongDiem, DiemQD, Hoc_ky, Nam_hoc, Xep_loai, ID_xep_loai)
                        row("ID_sv") = DiemRl.ID_sv
                        row("Hoc_ky") = DiemRl.Hoc_ky
                        row("Nam_hoc") = DiemRl.Nam_hoc
                        row("Ma_sv") = DiemRl.Ma_sv
                        row("Ho_ten") = DiemRl.Ho_ten
                        row("Ngay_sinh") = Format(DiemRl.Ngay_sinh.Date.ToString)
                        row("Tong_diem") = TongDiem
                        row("Diem_quy_doi") = DiemQD
                        row("Xep_loai") = Xep_loai
                        row("ID_xep_loai") = ID_xep_loai
                        row("Ten_lop") = DiemRl.Ten_lop
                        row("ID_lop") = DiemRl.ID_lop
                        dt.Rows.Add(row)
                        tempID_sv = DiemRl.ID_sv
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Tổng hợp điểm rèn luyện theo nam hoc
        Public Function TongHop_DiemRenLuyen_NewNam(ByVal Nam_hoc As String) As DataTable
            Try
                Dim dt As New DataTable
                Dim tempID_sv As Integer
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(DateTime))
                dt.Columns.Add("Tong_diem", GetType(Integer))
                dt.Columns.Add("Tong_diem_ky1", GetType(Integer))
                dt.Columns.Add("Tong_diem_ky2", GetType(Integer))
                dt.Columns.Add("Diem_quy_doi", GetType(Double))
                dt.Columns.Add("Xep_loai", GetType(String))
                dt.Columns.Add("ID_xep_loai", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                For i As Integer = 0 To aDiemRenLuyen_News.Count - 1
                    Dim DiemRl As DiemRenLuyen_New = CType(aDiemRenLuyen_News(i), DiemRenLuyen_New)
                    Dim row As DataRow = dt.NewRow()
                    Dim TongDiem As Integer
                    Dim TongDiemKy1 As Integer
                    Dim TongDiemKy2 As Integer
                    Dim DiemQD As Double
                    Dim Xep_loai As String = ""
                    Dim ID_xep_loai As Integer
                    If DiemRl.Nam_hoc = Nam_hoc And tempID_sv <> DiemRl.ID_sv Then
                        SumPointNam(DiemRl.ID_sv, TongDiem, TongDiemKy1, TongDiemKy2, DiemQD, Nam_hoc, Xep_loai, ID_xep_loai)
                        row("ID_sv") = DiemRl.ID_sv
                        row("Nam_hoc") = DiemRl.Nam_hoc
                        row("Ma_sv") = DiemRl.Ma_sv
                        row("Ho_ten") = DiemRl.Ho_ten
                        row("Ngay_sinh") = Format(DiemRl.Ngay_sinh.Date.ToString)
                        row("Tong_diem") = TongDiem
                        row("Tong_diem_ky1") = TongDiemKy1
                        row("Tong_diem_ky2") = TongDiemKy2
                        row("Diem_quy_doi") = DiemQD
                        row("Xep_loai") = Xep_loai
                        row("ID_xep_loai") = ID_xep_loai
                        row("Ten_lop") = DiemRl.Ten_lop
                        dt.Rows.Add(row)
                        tempID_sv = DiemRl.ID_sv
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Điểm rèn luyện năm học của một sinh viên ( dùng trong load frmHoSoSinhVien )
        Public Function DiemRenLuyen_NewSinhVien(ByVal Nam_hoc As String, ByVal ID_sv As Integer) As DataTable
            Try
                Dim dt As New DataTable
                Dim tempID_sv As Integer = 0
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(DateTime))
                dt.Columns.Add("Tong_diem", GetType(Integer))
                dt.Columns.Add("Tong_diem_ky1", GetType(Integer))
                dt.Columns.Add("Tong_diem_ky2", GetType(Integer))
                dt.Columns.Add("Diem_quy_doi", GetType(Double))
                dt.Columns.Add("Xep_loai", GetType(String))
                dt.Columns.Add("ID_xep_loai", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                For i As Integer = 0 To aDiemRenLuyen_News.Count - 1
                    Dim DiemRl As DiemRenLuyen_New = CType(aDiemRenLuyen_News(i), DiemRenLuyen_New)
                    Dim row As DataRow = dt.NewRow()
                    Dim TongDiem As Integer
                    Dim TongDiemKy1 As Integer
                    Dim TongDiemKy2 As Integer
                    Dim DiemQD As Double
                    Dim Xep_loai As String = ""
                    Dim ID_xep_loai As Integer
                    If tempID_sv <> DiemRl.ID_sv And DiemRl.Nam_hoc = Nam_hoc And DiemRl.ID_sv = ID_sv Then
                        SumPointNam(DiemRl.ID_sv, TongDiem, TongDiemKy1, TongDiemKy2, DiemQD, Nam_hoc, Xep_loai, ID_xep_loai)
                        row("ID_sv") = DiemRl.ID_sv
                        row("Nam_hoc") = DiemRl.Nam_hoc
                        row("Ma_sv") = DiemRl.Ma_sv
                        row("Ho_ten") = DiemRl.Ho_ten
                        row("Ngay_sinh") = Format(DiemRl.Ngay_sinh.Date.ToString)
                        row("Tong_diem") = TongDiem
                        row("Tong_diem_ky1") = TongDiemKy1
                        row("Tong_diem_ky2") = TongDiemKy2
                        row("Diem_quy_doi") = DiemQD
                        row("Xep_loai") = Xep_loai
                        row("ID_xep_loai") = ID_xep_loai
                        row("Ten_lop") = DiemRl.Ten_lop
                        dt.Rows.Add(row)
                        tempID_sv = DiemRl.ID_sv
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ' Tổng hợp điểm rèn luyện theo khóa học
        Public Function TongHop_DiemRenLuyen_NewKhoa() As DataTable
            Try
                Dim dt As New DataTable
                Dim tempID_sv As Integer
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(DateTime))
                dt.Columns.Add("Tong_diem", GetType(Integer))
                dt.Columns.Add("Tong_diem_nam1", GetType(Integer))
                dt.Columns.Add("Tong_diem_nam2", GetType(Integer))
                dt.Columns.Add("Tong_diem_nam3", GetType(Integer))
                dt.Columns.Add("Tong_diem_nam4", GetType(Integer))
                dt.Columns.Add("Tong_diem_nam5", GetType(Integer))
                dt.Columns.Add("Diem_quy_doi", GetType(Double))
                dt.Columns.Add("Xep_loai", GetType(String))
                dt.Columns.Add("ID_xep_loai", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                For i As Integer = 0 To aDiemRenLuyen_News.Count - 1
                    Dim DiemRl As DiemRenLuyen_New = CType(aDiemRenLuyen_News(i), DiemRenLuyen_New)
                    Dim row As DataRow = dt.NewRow()
                    Dim TongDiem As Integer
                    Dim TongDiemNam1, TongDiemNam2, TongDiemNam3, TongDiemNam4, TongDiemNam5 As Integer
                    Dim DiemQD As Double
                    Dim Xep_loai As String = ""
                    Dim ID_xep_loai As Integer
                    If tempID_sv <> DiemRl.ID_sv Then
                        SumPointKhoa(DiemRl.ID_sv, TongDiem, TongDiemNam1, TongDiemNam2, TongDiemNam3, TongDiemNam4, TongDiemNam5, DiemQD, Xep_loai, ID_xep_loai)
                        row("ID_sv") = DiemRl.ID_sv
                        row("Ma_sv") = DiemRl.Ma_sv
                        row("Ho_ten") = DiemRl.Ho_ten
                        row("Ngay_sinh") = Format(DiemRl.Ngay_sinh.Date.ToString)
                        row("Tong_diem") = TongDiem
                        row("Tong_diem_nam1") = TongDiemNam1
                        row("Tong_diem_nam2") = TongDiemNam2
                        row("Tong_diem_nam3") = TongDiemNam3
                        row("Tong_diem_nam4") = TongDiemNam4
                        row("Tong_diem_nam5") = TongDiemNam5
                        row("Diem_quy_doi") = DiemQD
                        row("Xep_loai") = Xep_loai
                        row("ID_xep_loai") = ID_xep_loai
                        row("Ten_lop") = DiemRl.Ten_lop
                        row("ID_lop") = DiemRl.ID_lop
                        dt.Rows.Add(row)
                        tempID_sv = DiemRl.ID_sv
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên điểm rèn luyện theo khóa học của một sinh viên ( dùng trong load frmHoSoSinhVien )
        Public Function DiemRenLuyen_NewKhoaSinhVien(ByVal ID_sv As Integer) As DataTable
            Try
                Dim dt As New DataTable
                Dim tempID_sv As Integer = 0
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(DateTime))
                dt.Columns.Add("Tong_diem", GetType(Integer))
                dt.Columns.Add("Tong_diem_nam1", GetType(Integer))
                dt.Columns.Add("Tong_diem_nam2", GetType(Integer))
                dt.Columns.Add("Tong_diem_nam3", GetType(Integer))
                dt.Columns.Add("Tong_diem_nam4", GetType(Integer))
                dt.Columns.Add("Tong_diem_nam5", GetType(Integer))
                dt.Columns.Add("Diem_quy_doi", GetType(Double))
                dt.Columns.Add("Xep_loai", GetType(String))
                dt.Columns.Add("ID_xep_loai", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                For i As Integer = 0 To aDiemRenLuyen_News.Count - 1
                    Dim DiemRl As DiemRenLuyen_New = CType(aDiemRenLuyen_News(i), DiemRenLuyen_New)
                    Dim row As DataRow = dt.NewRow()
                    Dim TongDiem As Integer
                    Dim TongDiemNam1, TongDiemNam2, TongDiemNam3, TongDiemNam4, TongDiemNam5 As Integer
                    Dim DiemQD As Double
                    Dim Xep_loai As String = ""
                    Dim ID_xep_loai As Integer
                    If tempID_sv <> DiemRl.ID_sv And DiemRl.ID_sv = ID_sv Then
                        SumPointKhoa(DiemRl.ID_sv, TongDiem, TongDiemNam1, TongDiemNam2, TongDiemNam3, TongDiemNam4, TongDiemNam5, DiemQD, Xep_loai, ID_xep_loai)
                        row("ID_sv") = DiemRl.ID_sv
                        row("Ma_sv") = DiemRl.Ma_sv
                        row("Ho_ten") = DiemRl.Ho_ten
                        row("Ngay_sinh") = Format(DiemRl.Ngay_sinh.Date.ToString)
                        row("Tong_diem") = TongDiem
                        row("Tong_diem_nam1") = TongDiemNam1
                        row("Tong_diem_nam2") = TongDiemNam2
                        row("Tong_diem_nam3") = TongDiemNam3
                        row("Tong_diem_nam4") = TongDiemNam4
                        row("Tong_diem_nam5") = TongDiemNam5
                        row("Diem_quy_doi") = DiemQD
                        row("Xep_loai") = Xep_loai
                        row("ID_xep_loai") = ID_xep_loai
                        row("Ten_lop") = DiemRl.Ten_lop
                        dt.Rows.Add(row)
                        tempID_sv = DiemRl.ID_sv
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Load danh sach tất cả các sinh viên theo ID_Lops
        Public Function Load_DiemRenLuyen_New() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_diem_rl", GetType(Integer))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("ID_lop", GetType(String))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(DateTime))
                dt.Columns.Add("Diem", GetType(Integer))
                dt.Columns.Add("ID_Loai_rl", GetType(Integer))
                dt.Columns.Add("Ten_loai", GetType(String))
                dt.Columns.Add("Diemloairl", GetType(Integer))
                dt.Columns.Add("ID_Cap_rl", GetType(Integer))
                dt.Columns.Add("Ten_cap", GetType(String))
                dt.Columns.Add("DiemCaprl", GetType(Integer))
                dt.Columns.Add("Locked", GetType(Boolean))
                For i As Integer = 0 To aSVRenLuyens.Count - 1
                    Dim DiemRl As DiemRenLuyen_New = CType(aSVRenLuyens(i), DiemRenLuyen_New)
                    Dim row As DataRow = dt.NewRow()
                    row("ID_diem_rl") = DiemRl.ID_diem_rl
                    row("ID_sv") = DiemRl.ID_sv
                    row("Hoc_ky") = DiemRl.Hoc_ky
                    row("Nam_hoc") = DiemRl.Nam_hoc
                    row("ID_lop") = DiemRl.ID_lop
                    row("Ten_lop") = DiemRl.Ten_lop
                    row("Ma_sv") = DiemRl.Ma_sv
                    row("Ho_ten") = DiemRl.Ho_ten
                    row("Ngay_sinh") = Format(DiemRl.Ngay_sinh.Date.ToString)
                    row("ID_Loai_rl") = DiemRl.ID_loai_rl
                    row("Ten_loai") = DiemRl.Ten_loai
                    row("Diemloairl") = DiemRl.DiemLoairl
                    row("ID_Cap_rl") = DiemRl.ID_cap_rl
                    row("Ten_cap") = DiemRl.Ten_cap
                    row("DiemCaprl") = DiemRl.DiemCaprl
                    row("Locked") = DiemRl.Locked
                    dt.Rows.Add(row)
                Next
                dt.AcceptChanges()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Load danh sach tất cả các sinh viên theo ID_Lops, theo học kỳ và theo năm học
        Public Function Load_DiemRenLuyen_New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_diem_rl", GetType(Integer))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("ID_lop", GetType(String))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(DateTime))
                dt.Columns.Add("Diem", GetType(Integer))
                dt.Columns.Add("ID_Loai_rl", GetType(Integer))
                dt.Columns.Add("Ten_loai", GetType(String))
                dt.Columns.Add("Diemloairl", GetType(Integer))
                dt.Columns.Add("ID_Cap_rl", GetType(Integer))
                dt.Columns.Add("Ten_cap", GetType(String))
                dt.Columns.Add("DiemCaprl", GetType(Integer))
                For i As Integer = 0 To aDiemRenLuyen_News.Count - 1
                    Dim DiemRl As DiemRenLuyen_New = CType(aDiemRenLuyen_News(i), DiemRenLuyen_New)
                    Dim row As DataRow = dt.NewRow()
                    row("ID_diem_rl") = DiemRl.ID_diem_rl
                    row("ID_sv") = DiemRl.ID_sv
                    row("Hoc_ky") = DiemRl.Hoc_ky
                    row("Nam_hoc") = DiemRl.Nam_hoc
                    row("ID_lop") = DiemRl.ID_lop
                    row("Ten_lop") = DiemRl.Ten_lop
                    row("Ma_sv") = DiemRl.Ma_sv
                    row("Ho_ten") = DiemRl.Ho_ten
                    row("Ngay_sinh") = Format(DiemRl.Ngay_sinh.Date.ToString)
                    row("ID_Loai_rl") = DiemRl.ID_loai_rl
                    row("Ten_loai") = DiemRl.Ten_loai
                    row("Diemloairl") = DiemRl.DiemLoairl
                    row("ID_Cap_rl") = DiemRl.ID_cap_rl
                    row("Ten_cap") = DiemRl.Ten_cap
                    row("DiemCaprl") = DiemRl.DiemCaprl
                    dt.Rows.Add(row)
                Next
                dt.AcceptChanges()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Load danh sach tất cả các sinh viên theo ID_Lops, theo học kỳ năm học,theo các cấp rèn luyện và tiêu chuân rèn luyện
        Public Function Load_DiemRenLuyen_New(ByVal dvSVRenLuyen As DataView, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, Optional ByVal ID_loai_rl As Integer = -1, Optional ByVal ID_cap_rl As Integer = -1) As DataView
            Try
                dvSVRenLuyen = Me.Load_DiemRenLuyen_New().DefaultView
                For i As Integer = 0 To aDiemRenLuyen_News.Count - 1
                    Dim DiemRl As DiemRenLuyen_New = CType(aDiemRenLuyen_News(i), DiemRenLuyen_New)
                    For j As Integer = 0 To dvSVRenLuyen.Count - 1
                        If dvSVRenLuyen.Table.Rows(j)("ID_sv") = DiemRl.ID_sv Then
                            If ID_loai_rl > 0 And ID_cap_rl > 0 Then
                                If DiemRl.Hoc_ky = Hoc_ky And DiemRl.Nam_hoc = Nam_hoc And DiemRl.ID_cap_rl = ID_cap_rl And DiemRl.ID_loai_rl = ID_loai_rl Then
                                    dvSVRenLuyen.Table.Rows(j)("ID_diem_rl") = DiemRl.ID_diem_rl
                                    dvSVRenLuyen.Table.Rows(j)("ID_Loai_rl") = DiemRl.ID_loai_rl
                                    dvSVRenLuyen.Table.Rows(j)("Ten_loai") = DiemRl.Ten_loai
                                    dvSVRenLuyen.Table.Rows(j)("Diemloairl") = DiemRl.DiemLoairl
                                    dvSVRenLuyen.Table.Rows(j)("ID_Cap_rl") = DiemRl.ID_cap_rl
                                    dvSVRenLuyen.Table.Rows(j)("Ten_cap") = DiemRl.Ten_cap
                                    dvSVRenLuyen.Table.Rows(j)("DiemCaprl") = DiemRl.DiemCaprl
                                    dvSVRenLuyen.Table.Rows(j)("Diem") = DiemRl.Diem
                                    dvSVRenLuyen.Table.Rows(j)("Locked") = DiemRl.Locked
                                    GoTo quit
                                End If
                            End If
                        End If
                    Next
Quit:           Next
                Return dvSVRenLuyen
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''Load điểm rèn luyện theo ID_loai_rl
        Public Function Load_DiemLoaiRenLuyen(ByVal ID_Loai_rl As Integer) As Integer
            Try
                Dim diem As Integer = 0
                For i As Integer = 0 To aDiemRenLuyen_News.Count - 1
                    Dim DiemRl As DiemRenLuyen_New = CType(aDiemRenLuyen_News(i), DiemRenLuyen_New)
                    If DiemRl.ID_loai_rl = ID_Loai_rl Then
                        diem = DiemRl.DiemLoairl
                        Return diem
                    End If
                Next
                Dim obj As New DiemRenLuyen_New_DAL
                Dim dt As DataTable = obj.Load_DiemLoaiRenLuyen(ID_Loai_rl)
                If dt.Rows.Count > 0 Then
                    diem = dt.Rows(0)("Diem")
                End If
                Return diem
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''Insert Điểm rèn luyện
        Public Function Insert_DiemRenLuyen(ByVal objDiemRenLuyen_New As DiemRenLuyen_New) As Integer
            Try
                Dim obj As DiemRenLuyen_New_DAL = New DiemRenLuyen_New_DAL
                Return obj.Insert_DiemRenLuyen_New(objDiemRenLuyen_New)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Public Function Insert_DiemRenLuyen_NewExcel(ByVal objDiemRenLuyen_New As DiemRenLuyen_New) As Integer
        '    Try
        '        Dim obj As DiemRenLuyen_New_DAL = New DiemRenLuyen_New_DAL
        '        Return obj.Insert_DiemRenLuyen_NewExcel(objDiemRenLuyen_New)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        ''Update Điểm rèn luyện
        Public Function Update_DiemRenLuyen_New(ByVal objDiemRenLuyen_New As DiemRenLuyen_New) As Integer
            Try
                Dim obj As DiemRenLuyen_New_DAL = New DiemRenLuyen_New_DAL
                Return obj.Update_DiemRenLuyen_New(objDiemRenLuyen_New)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function KhoaMo_DiemRenLuyen_New(ByVal Lock As Boolean, ByVal ID_diem_rl As Integer) As Integer
            Try
                Dim obj As DiemRenLuyen_New_DAL = New DiemRenLuyen_New_DAL
                Return obj.KhoaMo_DiemRenLuyen_New(Lock, ID_diem_rl)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_DiemRenLuyen_NewExcel(ByVal objDiemRenLuyen_New As DiemRenLuyen_New) As Integer
            Try
                Dim obj As DiemRenLuyen_New_DAL = New DiemRenLuyen_New_DAL
                Return obj.Update_DiemRenLuyen_NewExcel(objDiemRenLuyen_New)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''Xóa điểm rèn luyện
        Public Function Delete_DiemRenLuyen_New(ByVal ID_diem_rl As Integer) As Integer
            Try
                Dim obj As DiemRenLuyen_New_DAL = New DiemRenLuyen_New_DAL
                Return obj.Delete_DiemRenLuyen_New(ID_diem_rl)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DiemRenLuyen_NewExcel(ByVal objDiemRenLuyen_New As DiemRenLuyen_New) As Integer
            Try
                Dim obj As DiemRenLuyen_New_DAL = New DiemRenLuyen_New_DAL
                Return obj.Delete_DiemRenLuyen_NewExcel(objDiemRenLuyen_New)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svDiemRenLuyen_New(ByVal objDiemRenLuyen_New As DiemRenLuyen_New) As Boolean
            Try
                Dim obj As DiemRenLuyen_New_DAL = New DiemRenLuyen_New_DAL
                Return obj.CheckExist_DiemRenLuyen_New(objDiemRenLuyen_New)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DiemRenLuyen_NewExcel(ByVal objDiemRenLuyen_New As DiemRenLuyen_New) As Boolean
            Try
                Dim obj As DiemRenLuyen_New_DAL = New DiemRenLuyen_New_DAL
                Return obj.CheckExist_DiemRenLuyen_NewExcel(objDiemRenLuyen_New)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Converting(ByVal drDiemRenLuyen_New As DataRow) As DiemRenLuyen_New
            Dim result As DiemRenLuyen_New
            Try
                result = New DiemRenLuyen_New
                If drDiemRenLuyen_New("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drDiemRenLuyen_New("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drDiemRenLuyen_New("Nam_hoc").ToString()
                If drDiemRenLuyen_New("ID_diem_rl").ToString() <> "" Then result.ID_diem_rl = CType(drDiemRenLuyen_New("ID_diem_rl").ToString(), Integer)
                If drDiemRenLuyen_New("ID_lop").ToString() <> "" Then result.ID_lop = CType(drDiemRenLuyen_New("ID_lop").ToString(), Integer)
                result.Ten_lop = drDiemRenLuyen_New("Ten_lop").ToString()
                If drDiemRenLuyen_New("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDiemRenLuyen_New("ID_sv").ToString(), Integer)
                result.Ma_sv = drDiemRenLuyen_New("Ma_sv").ToString()
                result.Ho_ten = drDiemRenLuyen_New("Ho_ten").ToString()
                If drDiemRenLuyen_New("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDiemRenLuyen_New("Ngay_sinh").ToString(), Date)
                If drDiemRenLuyen_New("Diem").ToString() <> "" Then result.Diem = CType(drDiemRenLuyen_New("Diem").ToString(), Integer)
                If drDiemRenLuyen_New("ID_loai_rl").ToString() <> "" Then result.ID_loai_rl = CType(drDiemRenLuyen_New("ID_loai_rl").ToString(), Integer)
                result.Ten_loai = drDiemRenLuyen_New("Ten_loai").ToString()
                If drDiemRenLuyen_New("DiemLoairl").ToString() <> "" Then result.DiemLoairl = CType(drDiemRenLuyen_New("DiemLoairl").ToString(), Integer)
                If drDiemRenLuyen_New("ID_cap_rl").ToString() <> "" Then result.ID_cap_rl = CType(drDiemRenLuyen_New("ID_cap_rl").ToString(), Integer)
                result.Ten_cap = drDiemRenLuyen_New("Ten_cap").ToString()
                If drDiemRenLuyen_New("DiemCaprl").ToString() <> "" Then result.DiemCaprl = CType(drDiemRenLuyen_New("DiemCaprl").ToString(), Integer)
                If drDiemRenLuyen_New("Locked").ToString() <> "" Then result.Locked = CType(drDiemRenLuyen_New("Locked").ToString(), Boolean)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function ConvertingDiem(ByVal drDiemRenLuyen_New As DataRow) As DiemRenLuyen_New
            Dim result As DiemRenLuyen_New
            Try
                result = New DiemRenLuyen_New
                If drDiemRenLuyen_New("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drDiemRenLuyen_New("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drDiemRenLuyen_New("Nam_hoc").ToString()
                If drDiemRenLuyen_New("ID_diem_rl").ToString() <> "" Then result.ID_diem_rl = CType(drDiemRenLuyen_New("ID_diem_rl").ToString(), Integer)
                If drDiemRenLuyen_New("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDiemRenLuyen_New("ID_sv").ToString(), Integer)
                If drDiemRenLuyen_New("Diem").ToString() <> "" Then result.Diem = CType(drDiemRenLuyen_New("Diem").ToString(), Integer)
                If drDiemRenLuyen_New("ID_loai_rl").ToString() <> "" Then result.ID_loai_rl = CType(drDiemRenLuyen_New("ID_loai_rl").ToString(), Integer)
                result.Ten_loai = drDiemRenLuyen_New("Ten_loai").ToString()
                If drDiemRenLuyen_New("DiemLoairl").ToString() <> "" Then result.DiemLoairl = CType(drDiemRenLuyen_New("DiemLoairl").ToString(), Integer)
                If drDiemRenLuyen_New("ID_cap_rl").ToString() <> "" Then result.ID_cap_rl = CType(drDiemRenLuyen_New("ID_cap_rl").ToString(), Integer)
                result.Ten_cap = drDiemRenLuyen_New("Ten_cap").ToString()
                If drDiemRenLuyen_New("DiemCaprl").ToString() <> "" Then result.DiemCaprl = CType(drDiemRenLuyen_New("DiemCaprl").ToString(), Integer)
                If drDiemRenLuyen_New("Ma_sv").ToString() <> "" Then result.Ma_sv = CType(drDiemRenLuyen_New("Ma_sv").ToString(), String)
                If drDiemRenLuyen_New("Ho_ten").ToString() <> "" Then result.Ho_ten = CType(drDiemRenLuyen_New("Ho_ten").ToString(), String)
                If drDiemRenLuyen_New("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDiemRenLuyen_New("Ngay_sinh").ToString(), Date)
                If drDiemRenLuyen_New("Ten_lop").ToString() <> "" Then result.Ten_lop = CType(drDiemRenLuyen_New("Ten_lop").ToString(), String)
                If drDiemRenLuyen_New("ID_lop").ToString() <> "" Then result.ID_lop = CType(drDiemRenLuyen_New("ID_lop").ToString(), String)
                If drDiemRenLuyen_New("Locked").ToString() <> "" Then result.Locked = CType(drDiemRenLuyen_New("Locked").ToString(), Boolean)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Public Sub AddDiemRenLuyen_New(ByRef dtDSSV As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Try
                dtDSSV.Columns.Add("TBCRL", GetType(String))
                For i As Integer = 0 To dtDSSV.Rows.Count - 1
                    dtDSSV.Rows(i)("TBCRL") = TBCRL_Ky(dtDSSV.Rows(i)("ID_sv"), Hoc_ky, Nam_hoc)
                Next
            Catch ex As Exception
            End Try
        End Sub

        Public Function TBCRL_Ky(ByVal id_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As String
            Dim TongDiem As Integer = 0
            Dim DRLQD As Double = 0
            For i As Integer = 0 To aDiemRenLuyen_News.Count - 1
                Dim DiemRl As DiemRenLuyen_New = CType(aDiemRenLuyen_News(i), DiemRenLuyen_New)
                If DiemRl.ID_sv = id_sv And DiemRl.Hoc_ky = Hoc_ky And DiemRl.Nam_hoc = Nam_hoc Then
                    TongDiem += DiemRl.Diem
                End If
            Next
            If TongDiem > 100 Then TongDiem = 100
            DRLQD = CDbl(TongDiem / 100)
            Return DRLQD.ToString
        End Function
#End Region

    End Class

End Namespace
