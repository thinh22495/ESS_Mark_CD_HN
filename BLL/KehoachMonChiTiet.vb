'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Wednesday, April 08, 2009
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class KehoachMonChiTiet_BLL
        Private arrKehoachMonChiTiet As ArrayList
        Private khMon As New KeHoachMon_BLL()
#Region "Constructor"
        Public Sub New()

        End Sub
        Public Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Try
                Dim obj As KehoachMonChiTiet_DAL = New KehoachMonChiTiet_DAL
                Dim dt As DataTable = obj.Load_KehoachMonChiTiet_List(Hoc_ky, Nam_hoc)
                Dim objsvKehoachMonChiTiet As KehoachMonChiTiet = Nothing
                Dim dr As DataRow = Nothing
                arrKehoachMonChiTiet = New ArrayList
                For Each dr In dt.Rows
                    objsvKehoachMonChiTiet = Converting(dr)
                    arrKehoachMonChiTiet.Add(objsvKehoachMonChiTiet)
                Next
                khMon = New KeHoachMon_BLL(Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region
#Region "Function"
        Private ReadOnly Property Count() As Integer
            Get
                Return Me.arrKehoachMonChiTiet.Count
            End Get
        End Property
        Private Property KehoachMonChiTiet(ByVal idx As Integer) As KehoachMonChiTiet
            Get
                Return CType(Me.arrKehoachMonChiTiet(idx), KehoachMonChiTiet)
            End Get
            Set(ByVal Value As KehoachMonChiTiet)
                Me.arrKehoachMonChiTiet(idx) = Value
            End Set
        End Property
        Private Function TimKehoach(ByVal ID_kh_mon As Integer, ByVal ID_kh_tuan As Integer) As Integer
            For i As Integer = 0 To arrKehoachMonChiTiet.Count - 1
                Dim obj As KehoachMonChiTiet = CType(arrKehoachMonChiTiet(i), KehoachMonChiTiet)
                If obj.ID_kh_tuan = ID_kh_tuan And obj.ID_kh_mon = ID_kh_mon Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Baocao_KehoachMon_Chitiet(ByVal ID_kh As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lops As String) As DataTable
            Dim dt As New DataTable
            Dim khTuan As New KeHoachTuan_BLL(ID_kh)
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            dt.Columns.Add("ID_nganh", GetType(Integer))
            dt.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dt.Columns.Add("Nien_khoa", GetType(String))
            dt.Columns.Add("ID_lop", GetType(Integer))
            dt.Columns.Add("ID_kh_mon", GetType(Integer))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("So_top", GetType(Integer))
            dt.Columns.Add("Ly_thuyet", GetType(Integer))
            dt.Columns.Add("Thuc_hanh", GetType(Integer))
            dt.Columns.Add("Ly_thuyet_con_lai", GetType(Integer))
            dt.Columns.Add("Thuc_hanh_con_lai", GetType(Integer))
            'Add các tuần trong 1 học kỳ của năm
            For i As Integer = 0 To khTuan.Count - 1
                If Hoc_ky = 1 Then
                    If khTuan.KeHoachTuan(i).Tuan_thu <= 26 Then
                        dt.Columns.Add("T." + khTuan.KeHoachTuan(i).ID_kh_tuan.ToString, GetType(String))
                    End If
                ElseIf Hoc_ky = 2 Then
                    If khTuan.KeHoachTuan(i).Tuan_thu > 26 Then
                        dt.Columns.Add("T." + khTuan.KeHoachTuan(i).ID_kh_tuan.ToString, GetType(String))
                    End If
                End If
            Next
            Dim lps As New Lop_BLL(dsID_lops, 1, -1, 1)
            Dim khLop As New KeHoachLop_BLL(ID_kh)
            Dim So_tiet_ly_thuyet, So_tiet_thuc_hanh As Integer
            'Duyệt danh sách lớp
            For i As Integer = 0 To lps.Count - 1
                Dim dr As DataRow
                dr = dt.NewRow
                dr("ID_he") = lps.Lop(i).ID_he
                dr("Khoa_hoc") = lps.Lop(i).Khoa_hoc
                dr("ID_nganh") = lps.Lop(i).ID_nganh
                dr("ID_chuyen_nganh") = lps.Lop(i).ID_chuyen_nganh
                dr("Nien_khoa") = lps.Lop(i).Nien_khoa
                dr("ID_lop") = lps.Lop(i).ID_lop
                dr("Ten_mon") = "Lớp: " + lps.Lop(i).Ten_lop.ToString
                'Add thông tin về kế hoạch lớp
                For j As Integer = 0 To khLop.Count - 1
                    Dim objKehoachLop As KeHoachLop = CType(khLop.KeHoachLop(j), KeHoachLop)
                    If objKehoachLop.ID_lop = lps.Lop(i).ID_lop Then
                        If Hoc_ky = 1 Then
                            If objKehoachLop.Tuan_thu <= 26 Then
                                dr("T." + objKehoachLop.ID_kh_tuan.ToString) = objKehoachLop.Ky_hieu
                            End If
                        ElseIf Hoc_ky = 2 Then
                            If objKehoachLop.Tuan_thu > 26 Then
                                dr("T." + objKehoachLop.ID_kh_tuan.ToString) = objKehoachLop.Ky_hieu
                            End If
                        End If
                    End If
                Next
                dt.Rows.Add(dr)
                'Add thông tin về kế hoạch môn
                For j As Integer = 0 To khMon.Count - 1
                    If lps.Lop(i).ID_lop = khMon.KeHoachMon(j).ID_lop Then
                        dr = dt.NewRow
                        dr("ID_he") = lps.Lop(i).ID_he
                        dr("Khoa_hoc") = lps.Lop(i).Khoa_hoc
                        dr("ID_nganh") = lps.Lop(i).ID_nganh
                        dr("ID_chuyen_nganh") = lps.Lop(i).ID_chuyen_nganh
                        dr("Nien_khoa") = lps.Lop(i).Nien_khoa
                        dr("ID_lop") = lps.Lop(i).ID_lop
                        dr("ID_kh_mon") = khMon.KeHoachMon(j).ID_kh_mon
                        dr("Ten_mon") = khMon.KeHoachMon(j).Ten_mon
                        dr("Ly_thuyet") = khMon.KeHoachMon(j).Ly_thuyet
                        dr("Thuc_hanh") = khMon.KeHoachMon(j).Thuc_hanh
                        dr("So_top") = khMon.KeHoachMon(j).So_top
                        So_tiet_ly_thuyet = 0
                        So_tiet_thuc_hanh = 0
                        For t As Integer = 0 To arrKehoachMonChiTiet.Count - 1
                            Dim objMonCT As KehoachMonChiTiet = CType(arrKehoachMonChiTiet(t), KehoachMonChiTiet)
                            If khMon.KeHoachMon(j).ID_kh_mon = objMonCT.ID_kh_mon Then
                                dr("T." + objMonCT.ID_kh_tuan.ToString) = objMonCT.So_tiet_ly_thuyet.ToString
                                If objMonCT.So_tiet_thuc_hanh > 0 Then
                                    dr("T." + objMonCT.ID_kh_tuan.ToString) += "/" + objMonCT.So_tiet_thuc_hanh.ToString
                                End If
                                So_tiet_ly_thuyet += objMonCT.So_tiet_ly_thuyet
                                So_tiet_thuc_hanh += objMonCT.So_tiet_thuc_hanh
                            End If
                        Next
                        dr("Ly_thuyet_con_lai") = khMon.KeHoachMon(j).Ly_thuyet - So_tiet_ly_thuyet
                        dr("Thuc_hanh_con_lai") = khMon.KeHoachMon(j).Thuc_hanh - So_tiet_thuc_hanh
                        dt.Rows.Add(dr)
                    End If
                Next
                'Add thông tin tổng số tiết trong tuần
                dr = dt.NewRow
                dr("ID_he") = lps.Lop(i).ID_he
                dr("Khoa_hoc") = lps.Lop(i).Khoa_hoc
                dr("ID_nganh") = lps.Lop(i).ID_nganh
                dr("ID_chuyen_nganh") = lps.Lop(i).ID_chuyen_nganh
                dr("Nien_khoa") = lps.Lop(i).Nien_khoa
                dr("Ten_mon") = "Tổng số tiết trong tuần"
                For t As Integer = 0 To khTuan.Count - 1
                    So_tiet_ly_thuyet = 0
                    So_tiet_thuc_hanh = 0
                    For m As Integer = 0 To khMon.Count - 1
                        If lps.Lop(i).ID_lop = khMon.KeHoachMon(m).ID_lop Then
                            For j As Integer = 0 To arrKehoachMonChiTiet.Count - 1
                                Dim objMonCT As KehoachMonChiTiet = CType(arrKehoachMonChiTiet(j), KehoachMonChiTiet)
                                If objMonCT.ID_kh_tuan = khTuan.KeHoachTuan(t).ID_kh_tuan _
                                And objMonCT.ID_kh_mon = khMon.KeHoachMon(m).ID_kh_mon Then
                                    So_tiet_ly_thuyet += objMonCT.So_tiet_ly_thuyet
                                    So_tiet_thuc_hanh += objMonCT.So_tiet_thuc_hanh
                                End If
                            Next
                        End If
                    Next
                    If So_tiet_ly_thuyet > 0 Or So_tiet_thuc_hanh > 0 Then
                        If Hoc_ky = 1 Then
                            If khTuan.KeHoachTuan(t).Tuan_thu <= 26 Then
                                dr("T." + khTuan.KeHoachTuan(t).ID_kh_tuan.ToString) = So_tiet_ly_thuyet.ToString
                                If So_tiet_thuc_hanh > 0 Then
                                    dr("T." + khTuan.KeHoachTuan(t).ID_kh_tuan.ToString) += "/" + So_tiet_thuc_hanh.ToString
                                End If
                            End If
                        ElseIf Hoc_ky = 2 Then
                            If khTuan.KeHoachTuan(t).Tuan_thu > 26 Then
                                dr("T." + khTuan.KeHoachTuan(t).ID_kh_tuan.ToString) = So_tiet_ly_thuyet.ToString
                                If So_tiet_thuc_hanh > 0 Then
                                    dr("T." + khTuan.KeHoachTuan(t).ID_kh_tuan.ToString) += "/" + So_tiet_thuc_hanh.ToString
                                End If
                            End If
                        End If
                    End If
                Next
                dt.Rows.Add(dr)
            Next           
            Return dt
        End Function
        Public Function Baocao_KehoachMon_Chitiet_Report(ByVal ID_kh As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lops As String) As DataTable
            Dim dt As New DataTable
            Dim khTuan As New KeHoachTuan_BLL(ID_kh)
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            dt.Columns.Add("ID_nganh", GetType(Integer))
            dt.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("So_top", GetType(Integer))
            dt.Columns.Add("Ly_thuyet", GetType(Integer))
            dt.Columns.Add("Thuc_hanh", GetType(Integer))
            dt.Columns.Add("Ly_thuyet_con_lai", GetType(Integer))
            dt.Columns.Add("Thuc_hanh_con_lai", GetType(Integer))
            'Add các tuần trong 1 học kỳ của năm
            For i As Integer = 1 To 26
                dt.Columns.Add("T" + i.ToString)
            Next
            Dim lps As New Lop_BLL(dsID_lops, 1, -1, 1)
            Dim khLop As New KeHoachLop_BLL(ID_kh)
            Dim So_tiet_ly_thuyet, So_tiet_thuc_hanh As Integer
            Dim Tuan_thu As Integer = 0
            Dim dr As DataRow
            'Duyệt danh sách lớp
            For i As Integer = 0 To lps.Count - 1
                'Add thông tin về kế hoạch môn
                For j As Integer = 0 To khMon.Count - 1
                    If lps.Lop(i).ID_lop = khMon.KeHoachMon(j).ID_lop Then
                        dr = dt.NewRow
                        dr("ID_he") = lps.Lop(i).ID_he
                        dr("Khoa_hoc") = lps.Lop(i).Khoa_hoc
                        dr("ID_nganh") = lps.Lop(i).ID_nganh
                        dr("ID_chuyen_nganh") = lps.Lop(i).ID_chuyen_nganh
                        dr("Ten_lop") = "Lớp: " + lps.Lop(i).Ten_lop
                        dr("Ten_mon") = khMon.KeHoachMon(j).Ten_mon
                        dr("Ly_thuyet") = khMon.KeHoachMon(j).Ly_thuyet
                        dr("Thuc_hanh") = khMon.KeHoachMon(j).Thuc_hanh
                        dr("So_top") = khMon.KeHoachMon(j).So_top
                        So_tiet_ly_thuyet = 0
                        So_tiet_thuc_hanh = 0
                        For t As Integer = 0 To arrKehoachMonChiTiet.Count - 1
                            Dim objMonCT As KehoachMonChiTiet = CType(arrKehoachMonChiTiet(t), KehoachMonChiTiet)
                            'Xác định Tuần thứ
                            If objMonCT.Tuan_thu <= 26 Then
                                Tuan_thu = objMonCT.Tuan_thu
                            Else
                                Tuan_thu = objMonCT.Tuan_thu - 26
                            End If
                            If khMon.KeHoachMon(j).ID_kh_mon = objMonCT.ID_kh_mon Then
                                dr("T" + Tuan_thu.ToString) = objMonCT.So_tiet_ly_thuyet.ToString
                                If objMonCT.So_tiet_thuc_hanh > 0 Then
                                    dr("T" + Tuan_thu.ToString) += "/" + objMonCT.So_tiet_thuc_hanh.ToString
                                End If
                                So_tiet_ly_thuyet += objMonCT.So_tiet_ly_thuyet
                                So_tiet_thuc_hanh += objMonCT.So_tiet_thuc_hanh
                            End If
                        Next
                        dr("Ly_thuyet_con_lai") = khMon.KeHoachMon(j).Ly_thuyet - So_tiet_ly_thuyet
                        dr("Thuc_hanh_con_lai") = khMon.KeHoachMon(j).Thuc_hanh - So_tiet_thuc_hanh
                        dt.Rows.Add(dr)
                    End If
                Next
            Next
            Return dt
        End Function
        Public Function ThongTinKeHoachMon(ByVal ID_lop As Integer, ByVal arrMon As ArrayList) As DataTable
            Dim dtkhMon As New DataTable
            Dim idx As Integer
            dtkhMon.Columns.Add("ID_kh_mon", GetType(Integer))
            dtkhMon.Columns.Add("STT_mon", GetType(Integer))
            dtkhMon.Columns.Add("Ten_mon", GetType(String))
            dtkhMon.Columns.Add("Tong_so_ly_thuyet", GetType(Integer))
            dtkhMon.Columns.Add("Tong_so_thuc_hanh", GetType(Integer))
            dtkhMon.Columns.Add("So_tiet_ly_thuyet", GetType(Integer))
            dtkhMon.Columns.Add("So_tiet_thuc_hanh", GetType(Integer))
            dtkhMon.Columns.Add("So_hoc_trinh", GetType(Integer))
            For i As Integer = 0 To arrMon.Count - 1
                idx = khMon.Tim_mon_hoc(arrMon(i))
                If idx >= 0 Then
                    Dim dr As DataRow
                    dr = dtkhMon.NewRow
                    dr("ID_kh_mon") = khMon.KeHoachMon(idx).ID_kh_mon
                    dr("STT_mon") = khMon.KeHoachMon(idx).STT_mon
                    dr("Ten_mon") = khMon.KeHoachMon(idx).Ten_mon
                    dr("Tong_so_ly_thuyet") = khMon.KeHoachMon(idx).Ly_thuyet
                    dr("Tong_so_thuc_hanh") = khMon.KeHoachMon(idx).Thuc_hanh
                    dr("So_hoc_trinh") = khMon.KeHoachMon(idx).So_hoc_trinh
                    dtkhMon.Rows.Add(dr)
                End If
            Next
            dtkhMon.AcceptChanges()
            Return dtkhMon
        End Function
        Public Sub XepKeHoachThuCong(ByVal dtKH As DataTable, ByVal ID_kh_tuan_tu As Integer, ByVal ID_kh_tuan_den As Integer)
            Dim idx, So_tiet_ly_thuyet_da_xep, So_tiet_thuc_hanh_da_xep, ID_kh_mon As Integer
            Dim So_tiet_ly_thuyet, So_tiet_thuc_hanh As Integer
            For i As Integer = 0 To dtKH.Rows.Count - 1
                'Xóa kế hoạch đã xếp trước đó
                ID_kh_mon = dtKH.Rows(i)("ID_kh_mon")
                For t As Integer = ID_kh_tuan_tu To ID_kh_tuan_den
                    idx = TimKehoach(ID_kh_mon, t)
                    If idx >= 0 Then
                        Delete_KehoachMonChiTiet(KehoachMonChiTiet(idx).ID_kh_mon_ct)
                        arrKehoachMonChiTiet.RemoveAt(idx)
                    End If
                Next
                'Lập kế hoạch mới
                ' - Tính tổng số tiết đã xếp
                So_tiet_ly_thuyet_da_xep = 0
                So_tiet_thuc_hanh_da_xep = 0
                For t As Integer = 0 To arrKehoachMonChiTiet.Count - 1
                    Dim objMonCT As KehoachMonChiTiet = CType(arrKehoachMonChiTiet(t), KehoachMonChiTiet)
                    If ID_kh_mon = objMonCT.ID_kh_mon Then
                        So_tiet_ly_thuyet_da_xep += objMonCT.So_tiet_ly_thuyet
                        So_tiet_thuc_hanh_da_xep += objMonCT.So_tiet_thuc_hanh
                    End If
                Next
                ' - Xếp kế hoạch mới
                For t As Integer = ID_kh_tuan_tu To ID_kh_tuan_den
                    So_tiet_ly_thuyet = 0
                    So_tiet_thuc_hanh = 0
                    If dtKH.Rows(i)("Tong_so_ly_thuyet") > So_tiet_ly_thuyet_da_xep Or dtKH.Rows(i)("Tong_so_thuc_hanh") > So_tiet_thuc_hanh_da_xep Then
                        'Xác định số tiết lý thuyết, thực hành trong 1 tuần
                        If dtKH.Rows(i)("Tong_so_ly_thuyet") > CInt("0" + dtKH.Rows(i)("So_tiet_ly_thuyet").ToString) + So_tiet_ly_thuyet_da_xep Then
                            So_tiet_ly_thuyet = CInt("0" + dtKH.Rows(i)("So_tiet_ly_thuyet").ToString)
                        ElseIf dtKH.Rows(i)("Tong_so_ly_thuyet") - So_tiet_ly_thuyet_da_xep > 0 Then
                            So_tiet_ly_thuyet = dtKH.Rows(i)("Tong_so_ly_thuyet") - So_tiet_ly_thuyet_da_xep
                        End If
                        If dtKH.Rows(i)("Tong_so_thuc_hanh") > CInt("0" + dtKH.Rows(i)("So_tiet_thuc_hanh").ToString) + So_tiet_thuc_hanh_da_xep Then
                            So_tiet_thuc_hanh = CInt("0" + dtKH.Rows(i)("So_tiet_thuc_hanh").ToString)
                        ElseIf dtKH.Rows(i)("Tong_so_thuc_hanh") - So_tiet_thuc_hanh_da_xep > 0 Then
                            So_tiet_thuc_hanh = dtKH.Rows(i)("Tong_so_thuc_hanh") - So_tiet_thuc_hanh_da_xep
                        End If
                        If So_tiet_ly_thuyet > 0 Or So_tiet_thuc_hanh > 0 Then
                            Dim objMonCT As New KehoachMonChiTiet
                            objMonCT.ID_kh_mon = ID_kh_mon
                            objMonCT.ID_kh_tuan = t
                            'Gán dữ liệu vào obj Môn chi tiết
                            objMonCT.So_tiet_ly_thuyet = So_tiet_ly_thuyet
                            objMonCT.So_tiet_thuc_hanh = So_tiet_thuc_hanh
                            'Add vào kế hoạch môn chi tiết
                            arrKehoachMonChiTiet.Add(objMonCT)
                            So_tiet_ly_thuyet_da_xep += So_tiet_ly_thuyet
                            So_tiet_thuc_hanh_da_xep += So_tiet_thuc_hanh
                        End If
                    End If
                Next
            Next
        End Sub
        Public Sub XepKeHoachTuDong(ByVal dtKH As DataTable, ByVal Nhom_tiet As String, ByVal So_tiet_tuan As Integer, ByVal ID_kh_tuan_tu As Integer, ByVal ID_kh_tuan_den As Integer)
            Dim idx, t, ID_kh_mon As Integer
            Select Case Nhom_tiet
                Case "2-3"
                    dtKH = Chia_tiet2_3(dtKH, So_tiet_tuan)
                Case "3"
                    dtKH = Chia_tiet3_3(dtKH, So_tiet_tuan)
                Case "2"
                    dtKH = Chia_tiet2_2(dtKH, So_tiet_tuan)
            End Select
            For i As Integer = 0 To dtKH.Rows.Count - 1
                'Xóa kế hoạch đã xếp trước đó
                ID_kh_mon = dtKH.Rows(i)("ID_kh_mon")
                For t = ID_kh_tuan_tu To ID_kh_tuan_den
                    idx = TimKehoach(ID_kh_mon, t)
                    If idx >= 0 Then
                        arrKehoachMonChiTiet.RemoveAt(idx)
                        Delete_KehoachMonChiTiet(KehoachMonChiTiet(idx).ID_kh_mon_ct)
                    End If
                Next
                'Lập kế hoạch mới
                t = ID_kh_tuan_tu
                For j As Integer = 1 To 10    'Duyet cac tuan co Ke hoach  thay doi
                    For k As Integer = 0 To dtKH.DefaultView.Item(i)("So_tuan" & j) - 1    'Duyet so tuan on dinh
                        If dtKH.DefaultView.Item(i)("N2" & j) * 2 + dtKH.DefaultView.Item(i)("N3" & j) * 3 > 0 Then
                            Dim objMonCT As New KehoachMonChiTiet
                            objMonCT.ID_kh_mon = ID_kh_mon
                            objMonCT.ID_kh_tuan = t
                            'Gán dữ liệu vào obj Môn chi tiết
                            objMonCT.So_tiet_ly_thuyet = dtKH.DefaultView.Item(i)("N2" & j) * 2 + dtKH.DefaultView.Item(i)("N3" & j) * 3
                            objMonCT.So_tiet_thuc_hanh = 0
                            'Add vào kế hoạch môn chi tiết
                            arrKehoachMonChiTiet.Add(objMonCT)
                            t += 1
                        End If
                    Next
                Next
            Next
        End Sub
        Public Sub LuuKeHoach()
            For i As Integer = 0 To arrKehoachMonChiTiet.Count - 1
                Dim objKH As KehoachMonChiTiet = CType(arrKehoachMonChiTiet(i), KehoachMonChiTiet)
                If objKH.ID_kh_mon_ct > 0 Then
                    'Update database
                    Update_KehoachMonChiTiet(objKH, objKH.ID_kh_mon_ct)
                Else
                    'Insert database
                    Insert_KehoachMonChiTiet(objKH)
                End If
            Next
        End Sub
        Public Sub XoaKeHoach(ByVal ID_kh_mon As Integer, ByVal ID_kh_tuan As Integer)
            For i As Integer = arrKehoachMonChiTiet.Count - 1 To 0 Step -1
                Dim obj As KehoachMonChiTiet = CType(arrKehoachMonChiTiet(i), KehoachMonChiTiet)
                If obj.ID_kh_mon = ID_kh_mon And obj.ID_kh_tuan = ID_kh_tuan Then
                    'Xóa trong Database 
                    Delete_KehoachMonChiTiet(obj.ID_kh_mon_ct)
                    'Xóa trên bộ nhớ
                    arrKehoachMonChiTiet.RemoveAt(i)
                End If
            Next
        End Sub
        Private Function Insert_KehoachMonChiTiet(ByVal objKehoachMonChiTiet As KehoachMonChiTiet) As Integer
            Try
                Dim obj As KehoachMonChiTiet_DAL = New KehoachMonChiTiet_DAL
                Return obj.Insert_KehoachMonChiTiet(objKehoachMonChiTiet)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Update_KehoachMonChiTiet(ByVal objKehoachMonChiTiet As KehoachMonChiTiet, ByVal ID_kh_mon_ct As Integer) As Integer
            Try
                Dim obj As KehoachMonChiTiet_DAL = New KehoachMonChiTiet_DAL
                Return obj.Update_KehoachMonChiTiet(objKehoachMonChiTiet, ID_kh_mon_ct)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Delete_KehoachMonChiTiet(ByVal ID_kh_mon_ct As Integer) As Integer
            Try
                Dim obj As KehoachMonChiTiet_DAL = New KehoachMonChiTiet_DAL
                Return obj.Delete_KehoachMonChiTiet(ID_kh_mon_ct)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drKehoachMonChiTiet As DataRow) As KehoachMonChiTiet
            Dim result As KehoachMonChiTiet
            Try
                result = New KehoachMonChiTiet
                If drKehoachMonChiTiet("ID_kh_mon_ct").ToString() <> "" Then result.ID_kh_mon_ct = CType(drKehoachMonChiTiet("ID_kh_mon_ct").ToString(), Integer)
                If drKehoachMonChiTiet("ID_kh_tuan").ToString() <> "" Then result.ID_kh_tuan = CType(drKehoachMonChiTiet("ID_kh_tuan").ToString(), Integer)
                If drKehoachMonChiTiet("Tuan_thu").ToString() <> "" Then result.Tuan_thu = CType(drKehoachMonChiTiet("Tuan_thu").ToString(), Integer)
                If drKehoachMonChiTiet("ID_kh_mon").ToString() <> "" Then result.ID_kh_mon = CType(drKehoachMonChiTiet("ID_kh_mon").ToString(), Integer)
                If drKehoachMonChiTiet("So_tiet_ly_thuyet").ToString() <> "" Then result.So_tiet_ly_thuyet = CType(drKehoachMonChiTiet("So_tiet_ly_thuyet").ToString(), Integer)
                If drKehoachMonChiTiet("So_tiet_thuc_hanh").ToString() <> "" Then result.So_tiet_thuc_hanh = CType(drKehoachMonChiTiet("So_tiet_thuc_hanh").ToString(), Integer)
                If drKehoachMonChiTiet("Phan_doan").ToString() <> "" Then result.Phan_doan = CType(drKehoachMonChiTiet("Phan_doan").ToString(), Integer)
                result.Ghi_chu = drKehoachMonChiTiet("Ghi_chu").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
#Region "Chia tiet tu dong"
        Private Function Tao_bang(ByVal dtKH As DataTable) As DataTable
            dtKH.Columns.Add("Sotiet_chia", GetType(Integer))
            dtKH.Columns.Add("Sotiet_tuan", GetType(Integer))
            For i As Byte = 1 To 10
                dtKH.Columns.Add("So_tuan" & i, GetType(Integer))
                dtKH.Columns.Add("N2" & i, GetType(Integer))
                dtKH.Columns.Add("N3" & i, GetType(Integer))
            Next
            For i As Integer = 0 To dtKH.Rows.Count - 1
                For j As Byte = 1 To 10
                    dtKH.Rows(i)("N2" & j) = 0
                    dtKH.Rows(i)("N3" & j) = 0
                    dtKH.Rows(i)("So_tuan" & j) = 0
                Next
                dtKH.Rows(i)("Sotiet_chia") = 0
                dtKH.Rows(i)("Sotiet_tuan") = 0
            Next
            Return dtKH
        End Function
        Private Function Chia_tiet2_3(ByVal dtKH As DataTable, ByVal Sotiet_tuan As Byte) As DataTable
            'Tao cau truc bang
            Dim dt As DataTable = Tao_bang(dtKH)
            Dim Tongso_tiet, So_tuan, Tuan As Integer
            Dim Flag As Boolean
            Tongso_tiet = 0
            Tuan = 1
            'Lap de chia cho cac tuan
            Do While Tuan < 10
                If Chia_tuan2_3(dt, So_tuan, Sotiet_tuan, Tuan) Then
                    'Kiem tra xem so tuan do co hop ly khong
                    Do While So_tuan > 0
                        Flag = False
                        For i As Integer = 0 To dt.Rows.Count - 1
                            With dt.Rows(i)
                                If (.Item("Tong_so_ly_thuyet") < (.Item("N2" & Tuan) * 2 * So_tuan + .Item("N3" & Tuan) * 3 * So_tuan)) Or (.Item("Tong_so_ly_thuyet") - (.Item("N2" & Tuan) * 2 * So_tuan + .Item("N3" & Tuan) * 3 * So_tuan) = 1) Then
                                    So_tuan -= 1
                                    Flag = True
                                    Exit For
                                End If
                            End With
                        Next
                        If Not Flag Then Exit Do
                    Loop
                    'Tru so tiet da bo tri
                    If So_tuan = 0 Then So_tuan = 1
                    For i As Integer = 0 To dt.Rows.Count - 1
                        With dt.Rows(i)
                            .Item("So_tuan" & Tuan) = So_tuan
                            .Item("Tong_so_ly_thuyet") -= .Item("N2" & Tuan) * 2 * So_tuan + .Item("N3" & Tuan) * 3 * So_tuan
                        End With
                    Next
                    Tuan += 1
                Else
                    Exit Do
                End If
            Loop
            Return dt
        End Function
        Private Function Chia_tuan2_3(ByRef dt As DataTable, ByRef So_tuan As Integer, ByVal Sotiet_tuan As Byte, ByVal Tuan As Byte) As Boolean
            Dim Tongso_tiet As Integer
            Dim i, N2, N3, Tong, So_nhom As Integer
            Dim Chia As Boolean = True
            dt.DefaultView.Sort = "Tong_so_ly_thuyet"
            'Tinh tong so tiet con lai
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i)("Tong_so_ly_thuyet").ToString <> "" Then Tongso_tiet += dt.Rows(i)("Tong_so_ly_thuyet")
            Next
            If Tongso_tiet <= 0 Then
                Return False
            End If
            So_tuan = Tongso_tiet / Sotiet_tuan
            So_nhom = Sotiet_tuan / 5
            'Chia so tiet/tuan
            If So_tuan = 0 Then So_tuan = 1
            For i = 0 To dt.Rows.Count - 1
                dt.Rows(i).Item("Sotiet_chia") = dt.Rows(i).Item("Tong_so_ly_thuyet") / So_tuan
            Next
            'Xac dinh so tiet/tuan
            N2 = 0 : N3 = 0 : Tong = 0
            i = 0
            Do While True
                Chia = False
                For i = 0 To dt.Rows.Count - 1
                    With dt.DefaultView.Item(i)
                        If .Item("Sotiet_chia") > 0 And .Item("Tong_so_ly_thuyet") > 0 Then
                            If (Int(.Item("Sotiet_chia")) = 2 Or .Item("Tong_so_ly_thuyet") = 2) And N2 < So_nhom Then
                                N2 += 1
                                .Item("Sotiet_chia") = .Item("Sotiet_chia") - 2
                                .Item("N2" & Tuan) += 1
                                Tong += 2
                                Chia = True
                            End If
                            If (Int(.Item("Sotiet_chia")) = 3 Or .Item("Tong_so_ly_thuyet") = 3) And N3 < So_nhom Then
                                N3 += 1
                                .Item("Sotiet_chia") = .Item("Sotiet_chia") - 3
                                .Item("N3" & Tuan) += 1
                                Tong += 3
                                Chia = True
                            End If
                            If (Int(.Item("Sotiet_chia")) = 4 Or .Item("Tong_so_ly_thuyet") = 4) And N2 < So_nhom Then
                                If N2 < So_nhom - 1 Then
                                    N2 += 2
                                    .Item("Sotiet_chia") = .Item("Sotiet_chia") - 4
                                    .Item("N2" & Tuan) += 2
                                    Tong += 4
                                    Chia = True
                                Else
                                    N2 += 1
                                    .Item("Sotiet_chia") = .Item("Sotiet_chia") - 2
                                    .Item("N2" & Tuan) += 1
                                    Tong += 2
                                    Chia = True
                                End If
                            End If
                            If Int(.Item("Sotiet_chia")) >= 5 Then
                                If N3 <= N2 And N3 < So_nhom Then
                                    N3 += 1
                                    .Item("Sotiet_chia") = .Item("Sotiet_chia") - 3
                                    .Item("N3" & Tuan) += 1
                                    Tong += 3
                                    Chia = True
                                ElseIf N2 < So_nhom And N2 < So_nhom Then
                                    N2 += 1
                                    .Item("Sotiet_chia") = .Item("Sotiet_chia") - 2
                                    .Item("N2" & Tuan) += 1
                                    Tong += 2
                                    Chia = True
                                End If
                            End If
                        End If
                    End With
                Next
                If (Not Chia) Or (N2 = N3 And N2 = So_nhom) Then Exit Do
            Loop
            'Xu ly cap tiet 2-3 con thieu
            If N2 < So_nhom Or N3 < So_nhom Then
                Dim So_du As Double, k As Integer
                Do While N2 < So_nhom Or N3 < So_nhom
                    So_du = 0
                    k = 0
                    For i = 0 To dt.Rows.Count - 1
                        If dt.Rows(i)("Sotiet_chia") > So_du Then
                            So_du = dt.Rows(i)("Sotiet_chia")
                            k = i
                        End If
                    Next
                    With dt.Rows(k)
                        If .Item("Sotiet_chia") > 0 Then
                            If N3 < So_nhom Then
                                N3 += 1
                                .Item("N3" & Tuan) += 1
                                .Item("Sotiet_chia") /= 3
                            ElseIf N2 < So_nhom Then
                                N2 += 1
                                .Item("N2" & Tuan) += 1
                                .Item("Sotiet_chia") /= 2
                            End If
                        Else
                            Exit Do
                        End If
                    End With
                Loop
            End If
            Return True
        End Function
        Private Function Chia_tiet2_2(ByVal dtKH As DataTable, ByVal Sotiet_tuan As Byte) As DataTable
            Dim dt As DataTable = Tao_bang(dtKH)
            Dim Tongso_tiet, So_tuan, Tuan As Integer
            Dim Flag As Boolean
            Tongso_tiet = 0
            Tuan = 1
            'Lap de chia cho cac tuan
            Do While Tuan < 10
                If Chia_tuan2_2(dt, So_tuan, Sotiet_tuan, Tuan) Then
                    'Kiem tra xem so tuan do co hop ly khong
                    Do While So_tuan > 0
                        Flag = False
                        For i As Integer = 0 To dt.Rows.Count - 1
                            With dt.Rows(i)
                                If (.Item("So_tiet_ly_thuyet") <= (.Item("N2" & Tuan) * 2 * So_tuan + .Item("N3" & Tuan) * 3 * So_tuan)) _
                                Or (.Item("So_tiet_ly_thuyet") - (.Item("N2" & Tuan) * 2 * So_tuan + .Item("N3" & Tuan) * 3 * So_tuan) = 1) Then
                                    So_tuan -= 1
                                    Flag = True
                                    Exit For
                                End If
                            End With
                        Next
                        If Not Flag Then Exit Do
                    Loop
                    'Tru so tiet da bo tri
                    If So_tuan = 0 Then So_tuan = 1
                    For i As Integer = 0 To dt.Rows.Count - 1
                        With dt.Rows(i)
                            .Item("So_tuan" & Tuan) = So_tuan
                            .Item("So_tiet_ly_thuyet") -= .Item("N2" & Tuan) * 2 * So_tuan
                        End With
                    Next
                    Tuan += 1
                Else
                    Exit Do
                End If
            Loop
            Return dt
        End Function
        Private Function Chia_tuan2_2(ByRef dt As DataTable, ByRef So_tuan As Integer, ByVal Sotiet_tuan As Byte, ByVal Tuan As Byte) As Boolean
            Dim Tongso_tiet As Integer
            Dim i, N2 As Integer
            Dim Chia As Boolean = True
            'Tinh tong so tiet con lai
            For i = 0 To dt.Rows.Count - 1
                Tongso_tiet += dt.Rows(i)("So_tiet_ly_thuyet")
            Next
            If Tongso_tiet <= 0 Then
                Return False
            End If
            So_tuan = Tongso_tiet / Sotiet_tuan
            'Chia so tiet/tuan
            If So_tuan = 0 Then So_tuan = 1
            For i = 0 To dt.Rows.Count - 1
                dt.Rows(i).Item("Sotiet_chia") = dt.Rows(i).Item("So_tiet_ly_thuyet") / So_tuan
            Next
            'Xac dinh so tiet/tuan
            N2 = 0
            i = 0
            Do While True
                Chia = False
                dt.DefaultView.Sort = "So_tiet_ly_thuyet DESC"
                For i = 0 To dt.Rows.Count - 1
                    With dt.DefaultView.Item(i)
                        If .Item("Sotiet_chia") > 0 And .Item("So_tiet_ly_thuyet") > 0 Then
                            If (Int(.Item("Sotiet_chia")) > 0) And N2 * 2 < Sotiet_tuan Then
                                N2 += 1
                                .Item("Sotiet_chia") = .Item("Sotiet_chia") - 2
                                .Item("N2" & Tuan) += 1
                                Chia = True
                            End If
                        End If
                    End With
                Next
                If (Not Chia) Then Exit Do
            Loop
            Return True
        End Function
        Private Function Chia_tiet3_3(ByVal dtKH As DataTable, ByVal Sotiet_tuan As Byte) As DataTable
            Dim dt As DataTable = Tao_bang(dtKH)
            Dim Tongso_tiet, So_tuan, Tuan As Integer
            Dim Flag As Boolean
            Tongso_tiet = 0
            Tuan = 1
            'Lap de chia cho cac tuan
            Do While Tuan < 10
                If Chia_tuan3_3(dt, So_tuan, Sotiet_tuan, Tuan) Then
                    'Kiem tra xem so tuan do co hop ly khong
                    Do While So_tuan > 0
                        Flag = False
                        For i As Integer = 0 To dt.Rows.Count - 1
                            With dt.Rows(i)
                                If (.Item("Tong_so_ly_thuyet") < (.Item("N2" & Tuan) * 2 * So_tuan + .Item("N3" & Tuan) * 3 * So_tuan)) Or (.Item("Tong_so_ly_thuyet") - (.Item("N2" & Tuan) * 2 * So_tuan + .Item("N3" & Tuan) * 3 * So_tuan) = 1) Then
                                    So_tuan -= 1
                                    Flag = True
                                    Exit For
                                End If
                            End With
                        Next
                        If Not Flag Then Exit Do
                    Loop
                    'Tru so tiet da bo tri
                    If So_tuan = 0 Then So_tuan = 1
                    For i As Integer = 0 To dt.Rows.Count - 1
                        With dt.Rows(i)
                            .Item("So_tuan" & Tuan) = So_tuan
                            .Item("Tong_so_ly_thuyet") -= .Item("N2" & Tuan) * 2 * So_tuan + .Item("N3" & Tuan) * 3 * So_tuan
                        End With
                    Next
                    Tuan += 1
                Else
                    Exit Do
                End If
            Loop
            Return dt
        End Function
        Private Function Chia_tuan3_3(ByRef dt As DataTable, ByRef So_tuan As Integer, ByVal Sotiet_tuan As Byte, ByVal Tuan As Byte) As Boolean
            Dim Tongso_tiet As Integer
            Dim i, N3 As Integer
            Dim Chia As Boolean = True
            'Tinh tong so tiet con lai
            For i = 0 To dt.Rows.Count - 1
                Tongso_tiet += dt.Rows(i)("Tong_so_ly_thuyet")
            Next
            If Tongso_tiet <= 0 Then
                Return False
            End If
            So_tuan = Tongso_tiet / Sotiet_tuan
            'Chia so tiet/tuan
            If So_tuan = 0 Then So_tuan = 1
            For i = 0 To dt.Rows.Count - 1
                dt.Rows(i).Item("Sotiet_chia") = dt.Rows(i).Item("Tong_so_ly_thuyet") / So_tuan
            Next
            'Xac dinh so tiet/tuan
            N3 = 0
            i = 0
            Do While True
                Chia = False
                dt.DefaultView.Sort = "Tong_so_ly_thuyet DESC"
                For i = 0 To dt.Rows.Count - 1
                    With dt.DefaultView.Item(i)
                        If (Int(.Item("Sotiet_chia")) > 0) And N3 * 3 < Sotiet_tuan Then
                            N3 += 1
                            .Item("Sotiet_chia") = .Item("Sotiet_chia") - 3
                            .Item("N3" & Tuan) += 1
                            Chia = True
                        End If
                    End With
                Next
                If (Not Chia) Then Exit Do
            Loop
            Return True
        End Function
#End Region
    End Class
End Namespace
