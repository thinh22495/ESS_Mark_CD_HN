'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/24/2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class ChuongTrinhDaoTao_BLL
        Private arrChuongTrinhDaoTao As New ArrayList
#Region "Constructor"
        Public Sub New()
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Dim dt As DataTable = obj.Load_ChuongTrinhDaoTao_List(0)
                Dim objsvChuongTrinhDaoTao As ChuongTrinhDaoTao = Nothing
                Dim dr As DataRow = Nothing
                arrChuongTrinhDaoTao = New ArrayList
                For Each dr In dt.Rows
                    objsvChuongTrinhDaoTao = Converting(dr)
                    arrChuongTrinhDaoTao.Add(objsvChuongTrinhDaoTao)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal dsID_dt As String)
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Dim dt As DataTable = obj.Load_ChuongTrinhDaoTao_List(dsID_dt)
                Dim objsvChuongTrinhDaoTao As ChuongTrinhDaoTao = Nothing
                Dim dr As DataRow = Nothing
                arrChuongTrinhDaoTao = New ArrayList
                For Each dr In dt.Rows
                    objsvChuongTrinhDaoTao = Converting(dr)
                    arrChuongTrinhDaoTao.Add(objsvChuongTrinhDaoTao)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Sub New(ByVal dsID_dt As String, ByVal ID_bm As Integer)
            Dim dtMon As DataTable
            Dim clsDAL As New ChuongTrinhDaoTao_DAL
            'Load các học phần thuộc các chương trình đào
            dtMon = clsDAL.Load_MonHocTrongCTDT(dsID_dt, ID_bm)
            For i As Integer = 0 To dtMon.Rows.Count - 1
                Dim objCTDT As New ChuongTrinhDaoTaoChiTiet
                objCTDT.ID_dt = dtMon.Rows(i)("ID_dt")
                objCTDT.ID_bm = dtMon.Rows(i)("ID_bm")
                objCTDT.ID_mon = dtMon.Rows(i)("ID_mon")
                objCTDT.Ky_hieu = dtMon.Rows(i)("Ky_hieu")
                objCTDT.Ten_mon = dtMon.Rows(i)("Ten_mon")
                objCTDT.So_hoc_trinh = dtMon.Rows(i)("So_hoc_trinh")
                objCTDT.Ky_thu = dtMon.Rows(i)("Ky_thu")
                'Load cac rang buoc học phan

                arrChuongTrinhDaoTao.Add(objCTDT)
            Next
        End Sub
#End Region

#Region "Function"
        Public Sub Add(ByVal CTDT As ChuongTrinhDaoTao)
            arrChuongTrinhDaoTao.Add(CTDT)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrChuongTrinhDaoTao.RemoveAt(idx)
        End Sub
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.arrChuongTrinhDaoTao.Count
            End Get
        End Property
        Public Property ChuongTrinhDaoTao(ByVal idx As Integer) As ChuongTrinhDaoTao
            Get
                Return CType(arrChuongTrinhDaoTao(idx), ChuongTrinhDaoTao)
            End Get
            Set(ByVal Value As ChuongTrinhDaoTao)
                arrChuongTrinhDaoTao(idx) = Value
            End Set
        End Property

        Public Function GetChuongTrinhDaoTao(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer) As ChuongTrinhDaoTao
            For i As Integer = 0 To arrChuongTrinhDaoTao.Count - 1
                Dim objctdt As ChuongTrinhDaoTao = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTao)
                If objctdt.ID_he = ID_he And objctdt.ID_khoa = ID_khoa And objctdt.Khoa_hoc = Khoa_hoc And objctdt.ID_chuyen_nganh = ID_chuyen_nganh Then
                    Return objctdt
                End If
            Next
            Return Nothing
        End Function

        Public Sub Load_CTDTChiTiet(ByVal ID_dt As Integer)
            Dim idx As Integer
            idx = Tim_idx(ID_dt)
            If idx >= 0 Then
                Dim objCTDT As New ChuongTrinhDaoTao
                Dim clsDAL As New ChuongTrinhDaoTao_DAL
                objCTDT = CType(arrChuongTrinhDaoTao(idx), ChuongTrinhDaoTao)
                'Nếu chưa load chương trình đào tạo chi tiết thì load từ database vào
                If objCTDT.ChuongTrinhDaoTaoChiTiet.Count = 0 Then
                    'Load các học phần thuộc chương trình đào tạo
                    Dim dtCTDTChiTiet As DataTable
                    '- ------ - ---------------
                    dtCTDTChiTiet = clsDAL.Load_ChuongTrinhDaoTaoChiTiet_List(ID_dt)
                    For i As Integer = 0 To dtCTDTChiTiet.Rows.Count - 1
                        Dim objCTDTChiTiet As New ChuongTrinhDaoTaoChiTiet
                        objCTDTChiTiet.ID_mon_main = dtCTDTChiTiet.Rows(i)("ID_mon_main")
                        objCTDTChiTiet.Ten_mon_main = dtCTDTChiTiet.Rows(i)("Ten_mon_main").ToString
                        objCTDTChiTiet.ID_dt_mon = dtCTDTChiTiet.Rows(i)("ID_dt_mon")
                        objCTDTChiTiet.ID_dt = dtCTDTChiTiet.Rows(i)("ID_dt")
                        objCTDTChiTiet.ID_mon = dtCTDTChiTiet.Rows(i)("ID_mon")
                        objCTDTChiTiet.Ky_hieu = dtCTDTChiTiet.Rows(i)("Ky_hieu")
                        objCTDTChiTiet.Ten_mon = dtCTDTChiTiet.Rows(i)("Ten_mon")
                        objCTDTChiTiet.So_hoc_trinh = dtCTDTChiTiet.Rows(i)("So_hoc_trinh")
                        objCTDTChiTiet.Ky_thu = dtCTDTChiTiet.Rows(i)("Ky_thu")
                        objCTDTChiTiet.Ly_thuyet = dtCTDTChiTiet.Rows(i)("Ly_thuyet")
                        objCTDTChiTiet.Thuc_hanh = dtCTDTChiTiet.Rows(i)("Thuc_hanh")
                        objCTDTChiTiet.Bai_tap = dtCTDTChiTiet.Rows(i)("Bai_tap")
                        objCTDTChiTiet.Bai_tap_lon = dtCTDTChiTiet.Rows(i)("Bai_tap_lon")
                        objCTDTChiTiet.Thuc_tap = dtCTDTChiTiet.Rows(i)("Thuc_tap")
                        objCTDTChiTiet.Tu_hoc = dtCTDTChiTiet.Rows(i)("Tu_hoc")
                        objCTDTChiTiet.Tu_chon = dtCTDTChiTiet.Rows(i)("Tu_chon")
                        objCTDTChiTiet.STT_mon = dtCTDTChiTiet.Rows(i)("STT_mon")
                        objCTDTChiTiet.He_so = dtCTDTChiTiet.Rows(i)("He_so")
                        objCTDTChiTiet.Kien_thuc = dtCTDTChiTiet.Rows(i)("Kien_thuc")
                        objCTDTChiTiet.Ten_kien_thuc = dtCTDTChiTiet.Rows(i)("Ten_kien_thuc").ToString
                        objCTDTChiTiet.Chon = dtCTDTChiTiet.Rows(i)("Chon")
                        objCTDTChiTiet.Khong_tinh_TBCHT = dtCTDTChiTiet.Rows(i)("Khong_tinh_TBCHT")
                        objCTDTChiTiet.Mon_thi_TN = dtCTDTChiTiet.Rows(i)("Mon_tot_nghiep")
                        objCTDTChiTiet.Mon_thi_TN_thuc_hanh = dtCTDTChiTiet.Rows(i)("Mon_tot_nghiep_thuc_hanh")
                        objCTDTChiTiet.So_hoc_trinh_tien_quyet = dtCTDTChiTiet.Rows(i)("So_hoc_trinh_tien_quyet")
                        objCTDTChiTiet.Ma_khoa_phu_trach = dtCTDTChiTiet.Rows(i)("Ma_khoa_phu_trach").ToString
                        objCTDTChiTiet.Nhom_tu_chon = dtCTDTChiTiet.Rows(i)("Nhom_tu_chon")
                        objCTDTChiTiet.Ly_thuyet_nghe = dtCTDTChiTiet.Rows(i)("Ly_thuyet_nghe")
                        objCTDTChiTiet.Thuc_hanh_nghe = dtCTDTChiTiet.Rows(i)("Thuc_hanh_nghe")
                        'Load rang buoc mon hoc
                        objCTDT.ChuongTrinhDaoTaoChiTiet.Add(objCTDTChiTiet)
                    Next
                End If
                'Load lớp thuộc chương trình đào tạo
                If objCTDT.ChuongTrinhDaoTaoLop.Count = 0 Then
                    Dim dtLop As New DataTable
                    dtLop = clsDAL.Load_ChuongTrinhDaoTao_Lop_List(ID_dt)
                    For i As Integer = 0 To dtLop.Rows.Count - 1
                        Dim l As New Lop
                        l.ID_lop = dtLop.Rows(i)("ID_lop")
                        objCTDT.ChuongTrinhDaoTaoLop.Add(l)
                    Next
                End If

                'Load môn ràng buộc
                If objCTDT.ChuongTrinhDaoTaoRangBuoc.Count = 0 Then
                    Dim dtCTDT_MonRangBuoc As DataTable
                    dtCTDT_MonRangBuoc = clsDAL.Load_ChuongTrinhDaoTaoMonRangBuoc_List(ID_dt)
                    For i As Integer = 0 To dtCTDT_MonRangBuoc.Rows.Count - 1
                        Dim objRB As New ChuongTrinhDaoTaoMonHocRangBuoc
                        objRB.ID_rb = dtCTDT_MonRangBuoc.Rows(i)("ID_rb")
                        objRB.ID_mon = dtCTDT_MonRangBuoc.Rows(i)("ID_mon")
                        objRB.Ky_hieu = dtCTDT_MonRangBuoc.Rows(i)("Ky_hieu1")
                        objRB.Ten_mon = dtCTDT_MonRangBuoc.Rows(i)("Ten_mon1")
                        objRB.ID_mon_rb = dtCTDT_MonRangBuoc.Rows(i)("ID_mon_rb")
                        objRB.ID_dt = dtCTDT_MonRangBuoc.Rows(i)("id_dt")
                        objRB.Ten_mon1 = dtCTDT_MonRangBuoc.Rows(i)("Ten_mon2")
                        objRB.Loai_rang_buoc = dtCTDT_MonRangBuoc.Rows(i)("Loai_rang_buoc")
                        objRB.Ten_rang_buoc = dtCTDT_MonRangBuoc.Rows(i)("Ten_rang_buoc")
                        objRB.Ten_mon_rb = dtCTDT_MonRangBuoc.Rows(i)("Ten_mon_rb")

                        'Load rang buoc mon hoc
                        objCTDT.ChuongTrinhDaoTaoRangBuoc.Add(objRB)
                    Next
                End If

                ' Load nhóm tự chọn
                If objCTDT.ChuongTrinhDaoTaoNhomTuChon.Count = 0 Then
                    Dim clsNhomTuChon_DAL As New ChuongTrinhDaoTaoNhomTuChon_DAL
                    Dim dtCTDTNhomChon As DataTable
                    dtCTDTNhomChon = clsNhomTuChon_DAL.Load_ChuongTrinhDaoTaoNhomTuChon(ID_dt)
                    For j As Integer = 0 To dtCTDTNhomChon.Rows.Count - 1
                        Dim objNTC As New ChuongTrinhDaoTaoNhomTuChon
                        If dtCTDTNhomChon.Rows(j)("ID_dt").ToString() <> "" Then objNTC.ID_dt = CType(dtCTDTNhomChon.Rows(j)("ID_dt").ToString(), Integer)
                        If dtCTDTNhomChon.Rows(j)("Nhom_tu_chon").ToString() <> "" Then objNTC.Nhom_tu_chon = CType(dtCTDTNhomChon.Rows(j)("Nhom_tu_chon").ToString(), Integer)
                        If dtCTDTNhomChon.Rows(j)("So_mon_dang_ky").ToString() <> "" Then objNTC.So_mon_dang_ky = CType(dtCTDTNhomChon.Rows(j)("So_mon_dang_ky").ToString(), Integer)
                        If dtCTDTNhomChon.Rows(j)("So_mon_tu_chon").ToString() <> "" Then objNTC.So_mon_tu_chon = CType(dtCTDTNhomChon.Rows(j)("So_mon_tu_chon").ToString(), Integer)
                        objCTDT.ChuongTrinhDaoTaoNhomTuChon.Add(objNTC)
                    Next
                End If

            End If
        End Sub

        Public Function DanhSachMonHoc() As DataTable
            Dim dtMon As New DataTable
            dtMon.Columns.Add("ID_mon")
            dtMon.Columns.Add("Ten_mon")
            For i As Integer = 0 To arrChuongTrinhDaoTao.Count - 1
                Dim row As DataRow = dtMon.NewRow()
                row("ID_mon") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTaoChiTiet).ID_mon
                row("Ten_mon") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTaoChiTiet).Ten_mon
                dtMon.Rows.Add(row)
            Next
            dtMon.DefaultView.Sort = "Ten_mon"
            Return dtMon
        End Function
        Public Function DanhSachMonHoc(ByVal Ky_thu As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal UserName As String = "", Optional ByVal dsID_lops As String = "") As DataTable
            Dim dtMon As New DataTable
            dtMon.Columns.Add("ID_mon")
            dtMon.Columns.Add("Ten_mon")
            dtMon.Columns.Add("So_hoc_trinh")
            If UserName.Trim = "" Then
                For i As Integer = 0 To arrChuongTrinhDaoTao.Count - 1
                    If CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTaoChiTiet).Ky_thu = Ky_thu Then
                        Dim row As DataRow = dtMon.NewRow()
                        row("ID_mon") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTaoChiTiet).ID_mon
                        row("Ten_mon") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTaoChiTiet).Ten_mon _
                        + " ( " & CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTaoChiTiet).So_hoc_trinh & " hệ số )"
                        row("So_hoc_trinh") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTaoChiTiet).So_hoc_trinh
                        dtMon.Rows.Add(row)
                    End If
                Next
            Else
                Dim clsDM As New DanhMuc_BLL
                Dim SQL As String = "SELECT DISTINCT a.ID_mon FROM PLAN_KeHoachMon a " & _
                                    "INNER JOIN PLAN_GiaoVien b ON (a.ID_cb_1=b.ID_cb OR a.ID_cb_2= b.ID_cb OR a.ID_cb_3= b.ID_cb OR a.ID_cb_4= b.ID_cb)" & _
                                    "INNER JOIN SYS_NguoiDung c ON b.Ma_CB=c.UserName " & _
                                    "WHERE Hoc_ky=" & Hoc_ky & " AND Nam_hoc='" & Nam_hoc & "' AND b.Ma_CB=N'" & UserName & "'"
                If dsID_lops <> "" Then SQL += " AND a.ID_lop IN(" & dsID_lops & ")"
                Dim dt As DataTable = clsDM.LoadDanhMuc(SQL)
                For i As Integer = 0 To arrChuongTrinhDaoTao.Count - 1
                    If CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTaoChiTiet).Ky_thu = Ky_thu Then
                        dt.DefaultView.RowFilter = "ID_mon=" & CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTaoChiTiet).ID_mon
                        If dt.DefaultView.Count > 0 Then
                            Dim row As DataRow = dtMon.NewRow()
                            row("ID_mon") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTaoChiTiet).ID_mon
                            row("Ten_mon") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTaoChiTiet).Ten_mon _
                            + " ( " & CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTaoChiTiet).So_hoc_trinh & " hệ số )"
                            row("So_hoc_trinh") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTaoChiTiet).So_hoc_trinh
                            dtMon.Rows.Add(row)
                        End If
                    End If
                Next
            End If

            dtMon.DefaultView.Sort = "Ten_mon"
            Return dtMon
        End Function
        Public Function DanhSachChuongTrinhDaoTao() As DataTable
            Dim dtCTDT As New DataTable
            dtCTDT.Columns.Add("ID_dt", GetType(Integer))
            dtCTDT.Columns.Add("ID_he", GetType(Integer))
            dtCTDT.Columns.Add("ID_khoa", GetType(Integer))
            dtCTDT.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dtCTDT.Columns.Add("Ten_he", GetType(String))
            dtCTDT.Columns.Add("Ten_khoa", GetType(String))
            dtCTDT.Columns.Add("Khoa_hoc", GetType(Integer))
            dtCTDT.Columns.Add("Ten_chuyen_nganh", GetType(String))
            dtCTDT.Columns.Add("So_hoc_trinh", GetType(Double))
            dtCTDT.Columns.Add("So_ky_hoc", GetType(Integer))
            dtCTDT.Columns.Add("So", GetType(Integer))
            For i As Integer = 0 To arrChuongTrinhDaoTao.Count - 1
                Dim row As DataRow = dtCTDT.NewRow()
                row("ID_dt") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTao).ID_dt
                row("ID_he") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTao).ID_he
                row("ID_khoa") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTao).ID_khoa
                row("ID_chuyen_nganh") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTao).ID_chuyen_nganh
                row("Khoa_hoc") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTao).Khoa_hoc
                row("Ten_he") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTao).Ten_he
                row("Ten_khoa") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTao).Ten_khoa
                row("Khoa_hoc") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTao).Khoa_hoc
                row("Ten_chuyen_nganh") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTao).Chuyen_nganh
                row("So_hoc_trinh") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTao).So_hoc_trinh
                row("So_ky_hoc") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTao).So_ky_hoc
                row("So") = CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTao).So
                dtCTDT.Rows.Add(row)
            Next
            dtCTDT.AcceptChanges()
            Return dtCTDT
        End Function

        Function Get_SoKyToiDa(ByVal ID_dt As Integer) As Integer
            For i As Integer = 0 To arrChuongTrinhDaoTao.Count - 1
                If CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTao).ID_dt = ID_dt Then
                    Return CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTao).So_ky_hoc
                End If
            Next
            Return 0
        End Function

        Public Function ChuongTrinhDaoTaoChiTietDangKy(ByVal ID_dt As Integer) As DataTable
            Dim idx As Integer = Tim_idx(ID_dt)
            Dim dtCTDTChiTiet As New DataTable
            dtCTDTChiTiet.Columns.Add("ID_mon_tc", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("ID_mon_rb", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Loai_rang_buoc", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ten_mon_rb", GetType(String))
            dtCTDTChiTiet.Columns.Add("ID_mon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("STT_mon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ky_hieu", GetType(String))
            dtCTDTChiTiet.Columns.Add("Ten_mon", GetType(String))
            dtCTDTChiTiet.Columns.Add("Ky_thu", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("So_hoc_trinh", GetType(Double))
            dtCTDTChiTiet.Columns.Add("He_so", GetType(Double))
            dtCTDTChiTiet.Columns.Add("Bat_buoc", GetType(String))
            dtCTDTChiTiet.Columns.Add("Nhom_tu_chon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ten_kien_thuc", GetType(String))
            dtCTDTChiTiet.Columns.Add("Rang_buoc", GetType(String))
            dtCTDTChiTiet.Columns.Add("So_tien_nop", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Con_trong", GetType(Integer))
            If idx >= 0 Then
                Dim objTCDT As New ChuongTrinhDaoTao
                objTCDT = CType(arrChuongTrinhDaoTao(idx), ChuongTrinhDaoTao)

                For i As Integer = 0 To objTCDT.ChuongTrinhDaoTaoChiTiet.Count - 1
                    Dim row As DataRow = dtCTDTChiTiet.NewRow()
                    With objTCDT.ChuongTrinhDaoTaoChiTiet.ChuongTrinhDaoTaoChiTiet(i)
                        row("ID_mon") = 0
                        row("ID_mon") = .ID_mon
                        row("STT_mon") = .STT_mon
                        row("Ky_hieu") = .Ky_hieu
                        row("Ten_mon") = .Ten_mon
                        row("Ky_thu") = .Ky_thu
                        row("Nhom_tu_chon") = .Nhom_tu_chon
                        row("So_hoc_trinh") = .So_hoc_trinh
                        If .Tu_chon = False Then
                            row("Bat_buoc") = "X"
                        End If
                        row("He_so") = .He_so
                        row("Ten_kien_thuc") = .Ten_kien_thuc
                        For j As Integer = 0 To objTCDT.ChuongTrinhDaoTaoRangBuoc.Count - 1
                            With objTCDT.ChuongTrinhDaoTaoRangBuoc.ChuongTrinhDaoTaoRangBuoc(j)
                                If row("ID_mon") = .ID_mon Then
                                    row("ID_mon_rb") = .ID_mon_rb
                                    row("Loai_rang_buoc") = .Loai_rang_buoc
                                    row("Ten_mon_rb") = .Ten_mon_rb
                                    row("Rang_buoc") += .Ten_mon_rb + vbCrLf
                                End If
                            End With
                        Next
                    End With
                    dtCTDTChiTiet.Rows.Add(row)
                Next
            End If
            dtCTDTChiTiet.AcceptChanges()
            Return dtCTDTChiTiet
        End Function

        Public Function DanhSachChuongTrinhDaoTaoChiTiet(ByVal ID_dt As Integer) As DataTable
            Dim idx As Integer = Tim_idx(ID_dt)
            Dim dtCTDTChiTiet As New DataTable
            dtCTDTChiTiet.Columns.Add("ID_mon_main", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ten_mon_main", GetType(String))
            dtCTDTChiTiet.Columns.Add("ID_dt_mon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("ID_dt", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("ID_mon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("STT_mon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ky_hieu", GetType(String))
            dtCTDTChiTiet.Columns.Add("Ten_mon", GetType(String))
            dtCTDTChiTiet.Columns.Add("Ky_thu", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("So_hoc_trinh", GetType(Double))
            dtCTDTChiTiet.Columns.Add("Ly_thuyet", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Thuc_hanh", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Bai_tap", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Bai_tap_lon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Thuc_tap", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Tong_so_tiet", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Tu_hoc", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Tu_chon", GetType(Boolean))
            dtCTDTChiTiet.Columns.Add("He_so", GetType(Double))
            dtCTDTChiTiet.Columns.Add("Kien_thuc", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Nhom_tu_chon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ten_kien_thuc", GetType(String))
            dtCTDTChiTiet.Columns.Add("Chon", GetType(Boolean))
            dtCTDTChiTiet.Columns.Add("Khong_tinh_TBCHT", GetType(Boolean))
            dtCTDTChiTiet.Columns.Add("So_hoc_trinh_tien_quyet", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ma_khoa_phu_trach", GetType(String))
            dtCTDTChiTiet.Columns.Add("Mon_tot_nghiep", GetType(Boolean))
            dtCTDTChiTiet.Columns.Add("Mon_tot_nghiep_thuc_hanh", GetType(Boolean))
            dtCTDTChiTiet.Columns.Add("Ly_thuyet_nghe", GetType(Boolean))
            dtCTDTChiTiet.Columns.Add("Thuc_hanh_nghe", GetType(Boolean))
            If idx >= 0 Then
                Dim objTCDT As New ChuongTrinhDaoTao
                objTCDT = CType(arrChuongTrinhDaoTao(idx), ChuongTrinhDaoTao)

                For i As Integer = 0 To objTCDT.ChuongTrinhDaoTaoChiTiet.Count - 1
                    Dim row As DataRow = dtCTDTChiTiet.NewRow()
                    With objTCDT.ChuongTrinhDaoTaoChiTiet.ChuongTrinhDaoTaoChiTiet(i)
                        row("ID_dt_mon") = .ID_dt_mon
                        row("ID_dt") = .ID_dt
                        row("ID_mon") = .ID_mon
                        row("STT_mon") = .STT_mon
                        row("Ky_hieu") = .Ky_hieu
                        row("Ten_mon") = .Ten_mon
                        row("Ky_thu") = .Ky_thu
                        row("So_hoc_trinh") = .So_hoc_trinh
                        row("Ly_thuyet") = .Ly_thuyet
                        row("Thuc_hanh") = .Thuc_hanh
                        row("Bai_tap") = .Bai_tap
                        row("Bai_tap_lon") = .Bai_tap_lon
                        row("Thuc_tap") = .Thuc_tap
                        row("Tong_so_tiet") = .Ly_thuyet + .Thuc_hanh + .Bai_tap + .Bai_tap_lon + .Tu_hoc
                        row("Tu_hoc") = .Tu_hoc
                        row("Tu_chon") = .Tu_chon
                        row("He_so") = .He_so
                        row("Kien_thuc") = .Kien_thuc
                        row("Nhom_tu_chon") = .Nhom_tu_chon
                        row("Ten_kien_thuc") = .Ten_kien_thuc
                        row("Chon") = False
                        row("Khong_tinh_TBCHT") = .Khong_tinh_TBCHT
                        row("Ma_khoa_phu_trach") = .Ma_khoa_phu_trach
                        row("So_hoc_trinh_tien_quyet") = .So_hoc_trinh_tien_quyet
                        row("Mon_tot_nghiep") = .Mon_thi_TN
                        row("Mon_tot_nghiep_thuc_hanh") = .Mon_thi_TN_thuc_hanh
                        row("ID_mon_main") = .ID_mon_main
                        row("Thuc_hanh_nghe") = .Thuc_hanh_nghe
                        row("Ly_thuyet_nghe") = .Ly_thuyet_nghe
                    End With
                    dtCTDTChiTiet.Rows.Add(row)
                Next
            End If
            dtCTDTChiTiet.AcceptChanges()
            dtCTDTChiTiet.DefaultView.Sort = "STT_mon, Ky_thu"
            Return dtCTDTChiTiet
        End Function
        Public Function CheckExist_ChuongTrinhDaoTao_SaoChep(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal So As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Return obj.CheckExist_ChuongTrinhDaoTao_SaoChep(ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh, So)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachMonTuChonChuongTrinhDaoTaoChiTiet(ByVal ID_dt As Integer) As DataTable
            Dim idx As Integer = Tim_idx(ID_dt)
            Dim dtCTDTChiTiet As New DataTable
            dtCTDTChiTiet.Columns.Add("Chon", GetType(Boolean))
            dtCTDTChiTiet.Columns.Add("ID_dt", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Nhom_tu_chon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ky_hieu", GetType(String))
            dtCTDTChiTiet.Columns.Add("Ten_mon", GetType(String))
            dtCTDTChiTiet.Columns.Add("So_hoc_trinh", GetType(Double))
            dtCTDTChiTiet.Columns.Add("Ten_kien_thuc", GetType(String))

            If idx >= 0 Then
                Dim objTCDT As New ChuongTrinhDaoTao
                objTCDT = CType(arrChuongTrinhDaoTao(idx), ChuongTrinhDaoTao)

                For i As Integer = 0 To objTCDT.ChuongTrinhDaoTaoChiTiet.Count - 1
                    Dim row As DataRow = dtCTDTChiTiet.NewRow()
                    With objTCDT.ChuongTrinhDaoTaoChiTiet.ChuongTrinhDaoTaoChiTiet(i)
                        If .Tu_chon Then
                            row("Chon") = False
                            row("ID_dt") = .ID_dt
                            row("Nhom_tu_chon") = .Nhom_tu_chon
                            row("Ky_hieu") = .Ky_hieu
                            row("Ten_mon") = .Ten_mon
                            row("So_hoc_trinh") = .So_hoc_trinh
                            row("Ten_kien_thuc") = .Ten_kien_thuc
                        End If
                    End With
                    dtCTDTChiTiet.Rows.Add(row)
                Next
            End If
            dtCTDTChiTiet.AcceptChanges()
            Return dtCTDTChiTiet
        End Function

        Public Function DanhSach_MonRangBuoc(ByVal ID_dt As Integer) As DataTable
            Dim idx As Integer = Tim_idx(ID_dt)
            Dim dtCTDT_MonRangBuoc As New DataTable
            dtCTDT_MonRangBuoc.Columns.Add("idx_rb", GetType(Integer))
            dtCTDT_MonRangBuoc.Columns.Add("ID_dt", GetType(Integer))
            dtCTDT_MonRangBuoc.Columns.Add("ID_mon", GetType(Integer))
            dtCTDT_MonRangBuoc.Columns.Add("ID_mon_rb", GetType(Integer))
            dtCTDT_MonRangBuoc.Columns.Add("Loai_rang_buoc", GetType(Integer))
            dtCTDT_MonRangBuoc.Columns.Add("Ky_hieu1", GetType(String))
            dtCTDT_MonRangBuoc.Columns.Add("Ten_mon1", GetType(String))
            dtCTDT_MonRangBuoc.Columns.Add("Ten_mon2", GetType(String))
            dtCTDT_MonRangBuoc.Columns.Add("Ten_rang_buoc", GetType(String))
            dtCTDT_MonRangBuoc.Columns.Add("Ten_mon_RB", GetType(String))
            If idx >= 0 Then
                Dim objTCDT As New ChuongTrinhDaoTao
                objTCDT = CType(arrChuongTrinhDaoTao(idx), ChuongTrinhDaoTao)

                For i As Integer = 0 To objTCDT.ChuongTrinhDaoTaoRangBuoc.Count - 1
                    Dim row As DataRow = dtCTDT_MonRangBuoc.NewRow()
                    With objTCDT.ChuongTrinhDaoTaoRangBuoc.ChuongTrinhDaoTaoRangBuoc(i)
                        row("idx_rb") = i
                        row("ID_mon_rb") = .ID_mon_rb
                        row("ID_dt") = .ID_dt
                        row("ID_mon") = .ID_mon
                        row("Loai_rang_buoc") = .Loai_rang_buoc
                        row("Ten_rang_buoc") = .Ten_rang_buoc
                        row("Ky_hieu1") = .Ky_hieu
                        row("Ten_mon1") = .Ten_mon
                        row("Ten_mon2") = .Ten_mon1
                        row("Ten_mon_rb") = .Ten_mon_rb
                    End With
                    dtCTDT_MonRangBuoc.Rows.Add(row)
                Next
            End If
            dtCTDT_MonRangBuoc.AcceptChanges()
            Return dtCTDT_MonRangBuoc
        End Function
        Public Sub GanMonRangBuoc(ByVal ID_dt As Integer, ByVal ID_mon As Integer, ByVal ID_mon_rb As Integer, ByVal Loai_rang_buoc As Integer, ByVal Ky_hieu1 As String, ByVal Ten_mon1 As String, ByVal Ten_mon2 As String, ByVal Ten_rang_buoc As String)
            If Not Check_idx_RangBuoc(ID_dt, ID_mon, ID_mon_rb) Then
                Dim idx As Integer = Tim_idx(ID_dt)
                If idx >= 0 Then
                    Dim objTCDT As New ChuongTrinhDaoTao
                    Dim objMonRB As New ChuongTrinhDaoTaoMonHocRangBuoc
                    objTCDT = CType(arrChuongTrinhDaoTao(idx), ChuongTrinhDaoTao)
                    With objMonRB
                        .ID_dt = ID_dt
                        .ID_mon = ID_mon
                        .ID_mon_rb = ID_mon_rb
                        .Ky_hieu = Ky_hieu1
                        .Loai_rang_buoc = Loai_rang_buoc
                        .Ten_mon1 = Ten_mon2
                        .Ten_mon = Ten_mon1
                        .Ten_rang_buoc = Ten_rang_buoc
                    End With
                    objTCDT.ChuongTrinhDaoTaoRangBuoc.Add(objMonRB)
                    'Update vào CSDL
                    Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                    obj.Insert_PLAN_ChuongTrinhDaoTaoRangBuoc(objMonRB)
                End If
            End If
        End Sub
        Public Sub XoaMonRangBuoc(ByVal ID_dt As Integer, ByVal ID_mon As Integer, ByVal ID_mon_rb As Integer)
            Dim idx As Integer = Tim_idx(ID_dt)
            Dim idx_rb As Integer = Tim_idx_RangBuoc(ID_dt, ID_mon, ID_mon_rb)
            If idx_rb >= 0 Then
                Dim objTCDT As New ChuongTrinhDaoTao
                Dim objMonRB As New ChuongTrinhDaoTaoMonHocRangBuoc
                objTCDT = CType(arrChuongTrinhDaoTao(idx), ChuongTrinhDaoTao)
                objTCDT.ChuongTrinhDaoTaoRangBuoc.Remove(idx_rb)
                'Xoá khỏi CSDL
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                obj.Delete_PLAN_ChuongTrinhDaoTaoRangBuoc(ID_mon, ID_mon_rb)
            End If
        End Sub

        Public Sub XoaNhomTuChon(ByVal ID_dt As Integer, ByVal Nhom_tu_chon As Integer)
            'Xoá khỏi CSDL
            Dim obj As ChuongTrinhDaoTaoNhomTuChon_DAL = New ChuongTrinhDaoTaoNhomTuChon_DAL
            obj.Delete_ChuongTrinhDaoTaoNhomTuChon(ID_dt, Nhom_tu_chon)
        End Sub


        Public Function Update_ChuongTrinhDaoTaoRangBuoc(ByVal objChuongTrinhDaoTao As ChuongTrinhDaoTao, ByVal ID_dt As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Return obj.Update_ChuongTrinhDaoTao(objChuongTrinhDaoTao, ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_ChuongTrinhDaoTaoRangBuoc(ByVal objChuongTrinhDaoTaoRangBuoc As ChuongTrinhDaoTaoMonHocRangBuoc) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Return obj.Insert_ChuongTrinhDaoTaoRangBuoc(objChuongTrinhDaoTaoRangBuoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_ChuongTrinhDaoTaoNhomTuChon(ByVal objChuongTrinhDaoNhomTuChon As ChuongTrinhDaoTaoNhomTuChon) As Integer
            Try
                Dim obj As ChuongTrinhDaoTaoNhomTuChon_DAL = New ChuongTrinhDaoTaoNhomTuChon_DAL
                Return obj.Insert_ChuongTrinhDaoTaoNhomTuChon(objChuongTrinhDaoNhomTuChon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Private Function Check_idx_RangBuoc(ByVal ID_dt As Integer, ByVal ID_mon As Integer, ByVal ID_mon_rb As Integer) As Boolean
            Dim idx As Integer = Tim_idx(ID_dt)
            If idx >= 0 Then
                Dim objTCDT As New ChuongTrinhDaoTao
                objTCDT = CType(arrChuongTrinhDaoTao(idx), ChuongTrinhDaoTao)

                For i As Integer = 0 To objTCDT.ChuongTrinhDaoTaoRangBuoc.Count - 1
                    If objTCDT.ChuongTrinhDaoTaoRangBuoc.ChuongTrinhDaoTaoRangBuoc(i).ID_mon = ID_mon _
                    And objTCDT.ChuongTrinhDaoTaoRangBuoc.ChuongTrinhDaoTaoRangBuoc(i).ID_mon_rb = ID_mon_rb Then
                        Return True
                    End If
                Next
                Return False
            End If
            Return False
        End Function

        Private Function Tim_idx_RangBuoc(ByVal ID_dt As Integer, ByVal ID_mon As Integer, ByVal ID_mon_rb As Integer) As Integer
            Dim idx As Integer = Tim_idx(ID_dt)
            If idx >= 0 Then
                Dim objTCDT As New ChuongTrinhDaoTao
                objTCDT = CType(arrChuongTrinhDaoTao(idx), ChuongTrinhDaoTao)

                For i As Integer = 0 To objTCDT.ChuongTrinhDaoTaoRangBuoc.Count - 1
                    If objTCDT.ChuongTrinhDaoTaoRangBuoc.ChuongTrinhDaoTaoRangBuoc(i).ID_mon = ID_mon _
                    And objTCDT.ChuongTrinhDaoTaoRangBuoc.ChuongTrinhDaoTaoRangBuoc(i).ID_mon_rb = ID_mon_rb Then
                        Return i
                    End If
                Next
                Return -1
            End If
            Return -1
        End Function

        Public Function Tim_idx(ByVal ID_dt As Integer) As Integer
            For i As Integer = 0 To arrChuongTrinhDaoTao.Count - 1
                If CType(arrChuongTrinhDaoTao(i), ChuongTrinhDaoTao).ID_dt = ID_dt Then
                    Return i
                End If
            Next
            Return -1
        End Function

        Public Function Insert_ChuongTrinhDaoTao(ByVal objChuongTrinhDaoTao As ChuongTrinhDaoTao) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Return obj.Insert_ChuongTrinhDaoTao(objChuongTrinhDaoTao)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_ChuongTrinhDaoTao(ByVal objChuongTrinhDaoTao As ChuongTrinhDaoTao, ByVal ID_dt As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Return obj.Update_ChuongTrinhDaoTao(objChuongTrinhDaoTao, ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_ChuongTrinhDaoTao_Lop(ByVal ID_lop As Integer, ByVal ID_dt As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Return obj.Update_ChuongTrinhDaoTao_Lop(ID_lop, ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_ChuongTrinhDaoTao(ByVal ID_dt As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Return obj.Delete_ChuongTrinhDaoTao(ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_ChuongTrinhDaoTao(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal So As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Return obj.CheckExist_ChuongTrinhDaoTao(ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh, So)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_ChuongTrinhDaoTao_Diem(ByVal ID_dt As Integer, Optional ByVal ID_mon As Integer = 0) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Return obj.CheckExist_ChuongTrinhDaoTao_Diem(ID_dt, ID_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_ChuongTrinhDaoTaoChiTiet(ByVal objsvChuongTrinhDaoTaoChiTiet As ChuongTrinhDaoTaoChiTiet) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Return obj.Insert_ChuongTrinhDaoTaoChiTiet(objsvChuongTrinhDaoTaoChiTiet)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_ChuongTrinhDaoTaoChiTiet_Import(ByVal objsvChuongTrinhDaoTaoChiTiet As ChuongTrinhDaoTaoChiTiet) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Return obj.Insert_ChuongTrinhDaoTaoChiTiet_Import(objsvChuongTrinhDaoTaoChiTiet)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_ChuongTrinhDaoTaoChiTiet(ByVal objsvChuongTrinhDaoTaoChiTiet As ChuongTrinhDaoTaoChiTiet, ByVal ID_dt_mon As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Return obj.Update_PLAN_ChuongTrinhDaoTaoChiTiet(objsvChuongTrinhDaoTaoChiTiet, ID_dt_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_ChuongTrinhDaoTaoChiTiet(ByVal ID_dt_mon As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Return obj.Delete_PLAN_ChuongTrinhDaoTaoChiTiet(ID_dt_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Private Function Converting(ByVal drChuongTrinhDaoTao As DataRow) As ChuongTrinhDaoTao
            Dim result As ChuongTrinhDaoTao
            Try
                result = New ChuongTrinhDaoTao
                If drChuongTrinhDaoTao("ID_dt").ToString() <> "" Then result.ID_dt = CType(drChuongTrinhDaoTao("ID_dt").ToString(), Integer)
                If drChuongTrinhDaoTao("ID_he").ToString() <> "" Then result.ID_he = CType(drChuongTrinhDaoTao("ID_he").ToString(), Integer)
                If drChuongTrinhDaoTao("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drChuongTrinhDaoTao("ID_khoa").ToString(), Integer)
                If drChuongTrinhDaoTao("Khoa_hoc").ToString() <> "" Then result.Khoa_hoc = CType(drChuongTrinhDaoTao("Khoa_hoc").ToString(), Integer)
                If drChuongTrinhDaoTao("ID_chuyen_nganh").ToString() <> "" Then result.ID_chuyen_nganh = CType(drChuongTrinhDaoTao("ID_chuyen_nganh").ToString(), Integer)
                If drChuongTrinhDaoTao("So_hoc_trinh").ToString() <> "" Then result.So_hoc_trinh = CType(drChuongTrinhDaoTao("So_hoc_trinh").ToString(), Double)
                If drChuongTrinhDaoTao("So_ky_hoc").ToString() <> "" Then result.So_ky_hoc = CType(drChuongTrinhDaoTao("So_ky_hoc").ToString(), Integer)

                result.Ten_he = drChuongTrinhDaoTao("Ten_he").ToString()
                result.Ten_khoa = drChuongTrinhDaoTao("Ten_khoa").ToString()
                result.Ten_nganh = drChuongTrinhDaoTao("Ten_nganh").ToString()
                result.Chuyen_nganh = drChuongTrinhDaoTao("Chuyen_nganh").ToString()
                result.So = drChuongTrinhDaoTao("So")
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Public Function DanhSachMonHoc_NhomHocPhan(ByVal Ky_thu As Integer, ByVal ID_dt As Integer) As DataTable
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Return obj.DanhSachMonHoc_NhomHocPhan(Ky_thu, ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachMonHoc_NhomHocPhaSub(ByVal Ky_thu As Integer, ByVal ID_dt As Integer, ByVal ID_mon_main As Integer, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer, ByVal ID_lops As String, ByVal dt_danhsachsinhvien As DataTable, ByRef mdt_hp As DataTable) As DataTable
            Try
                Dim obj As ChuongTrinhDaoTao_DAL = New ChuongTrinhDaoTao_DAL
                Dim dt_HP, dt_main, dt_TBCHP As DataTable
                dt_main = dt_danhsachsinhvien.Copy

                dt_TBCHP = obj.DanhSachMonHoc_NhomHocPhan_TinhDiemTBCHP(Ky_thu, ID_dt, ID_mon_main, ID_lops, Lan_hoc, Lan_thi)
                'dt_TBCHP_tmp = obj.DanhSachMonHoc_NhomHocPhan_TinhDiemTBCHP(Ky_thu, ID_dt, ID_mon_main, ID_lops, Lan_hoc, 1)
                dt_HP = obj.DanhSachMonHoc_NhomHocPhanSub(Ky_thu, ID_dt, ID_mon_main)
                mdt_hp = dt_HP.Copy
                For j As Integer = 0 To dt_HP.Rows.Count - 1
                    dt_main.Columns.Add("ID_mon_sub" & dt_HP.Rows(j)("ID_mon"))
                Next
                dt_main.Columns.Add("TBCHP_Main", GetType(Double))
                'For i As Integer = dt_main.Rows.Count - 1 To 0 Step -1

                'Next
                'Dim f As Boolean = False
                For i As Integer = 0 To dt_main.Rows.Count - 1
                    Dim TBCHP As Double = 0
                    Dim So_hoc_trinh As Double = 0
                    dt_TBCHP.DefaultView.RowFilter = "ID_sv=" & dt_main.Rows(i)("ID_SV")
                    For j As Integer = 0 To dt_TBCHP.DefaultView.Count - 1
                        If dt_TBCHP.DefaultView.Item(j)("TBCHP").ToString <> "" AndAlso dt_TBCHP.DefaultView.Item(j)("So_hoc_trinh").ToString <> "" Then
                            TBCHP = TBCHP + dt_TBCHP.DefaultView.Item(j)("TBCHP") * dt_TBCHP.DefaultView.Item(j)("So_hoc_trinh")
                            So_hoc_trinh = So_hoc_trinh + dt_TBCHP.DefaultView.Item(j)("So_hoc_trinh")
                            dt_main.Rows(i)("ID_mon_sub" & dt_TBCHP.DefaultView.Item(j)("ID_mon")) = dt_TBCHP.DefaultView.Item(j)("TBCHP")
                        End If
                    Next
                    If So_hoc_trinh > 0 Then
                        If So_hoc_trinh <> 0 Then dt_main.Rows(i)("TBCHP_Main") = Math.Round(TBCHP / So_hoc_trinh + 0.0000001, 2)
                    End If
                Next
                'dt_main.AcceptChanges()
                Return dt_main
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace