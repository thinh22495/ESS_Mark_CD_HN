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
    Public Class KeHoachMon_BLL
        Private arrKeHoachMon As ArrayList
#Region "Constructor"
        Public Sub New()

        End Sub
        Public Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Try
                Dim obj As KeHoachMon_DAL = New KeHoachMon_DAL
                Dim dt As DataTable = obj.Load_KeHoachMon_List(Hoc_ky, Nam_hoc)
                Dim objsvKeHoachMon As KeHoachMon = Nothing
                Dim dr As DataRow = Nothing
                arrKeHoachMon = New ArrayList
                For Each dr In dt.Rows
                    objsvKeHoachMon = Converting(dr)
                    arrKeHoachMon.Add(objsvKeHoachMon)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.arrKeHoachMon.Count
            End Get
        End Property
        Public Property KeHoachMon(ByVal idx As Integer) As KeHoachMon
            Get
                Return CType(Me.arrKeHoachMon(idx), KeHoachMon)
            End Get
            Set(ByVal Value As KeHoachMon)
                Me.arrKeHoachMon(idx) = Value
            End Set
        End Property
        Public Sub TaoKehoachChiTietMon(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lops As String)
            Dim lps As New Lop_BLL(dsID_lops, 1, -1, 1)
            Dim clsCTDT As ChuongTrinhDaoTao_BLL
            Dim objCTDT As New ChuongTrinhDaoTaoChiTiet
            Dim objMon As New KeHoachMon
            Dim Ky_thu, Nam_dau, idx As Integer
            'Duyệt danh sách lớp
            For l As Integer = 0 To lps.Count - 1
                'Xác định kỳ thứ của lớp
                If lps.Lop(l).Nien_khoa.ToString <> "" Then
                    Nam_dau = Left(lps.Lop(l).Nien_khoa, 4)
                    Ky_thu = (Left(Nam_hoc, 4) - Nam_dau) * 2 + Hoc_ky
                    'Load chương trình đào tạo khung
                    clsCTDT = New ChuongTrinhDaoTao_BLL(lps.Lop(l).ID_dt)
                    clsCTDT.Load_CTDTChiTiet(lps.Lop(l).ID_dt)
                    If clsCTDT.Count Then
                        objCTDT = clsCTDT.ChuongTrinhDaoTao(0).ChuongTrinhDaoTaoChiTiet
                    End If
                    For i As Integer = 0 To objCTDT.Count - 1
                        If objCTDT.ChuongTrinhDaoTaoChiTiet(i).Ky_thu = Ky_thu Then
                            'Kiểm tra xem trong kế hoạch chi tiết đã có môn này chưa?
                            idx = Tim_mon_hoc(objCTDT.ChuongTrinhDaoTaoChiTiet(i).ID_mon, lps.Lop(l).ID_lop)
                            If idx >= 0 Then
                                'Update lại thông tin môn trong kế hoạch học kỳ
                                objMon = KeHoachMon(idx)
                                objMon.Ly_thuyet = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Ly_thuyet
                                objMon.Thuc_hanh = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Thuc_hanh
                                objMon.Bai_tap = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Bai_tap
                                objMon.Bai_tap_lon = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Bai_tap_lon
                                objMon.Thuc_tap = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Thuc_tap
                                objMon.So_hoc_trinh = objCTDT.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                Update_KeHoachMon(objMon, objMon.ID_kh_mon)
                            Else
                                'Insert môn vào kế hoạch học kỳ
                                objMon.Hoc_ky = Hoc_ky
                                objMon.Nam_hoc = Nam_hoc
                                objMon.ID_lop = lps.Lop(l).ID_lop
                                objMon.ID_mon = objCTDT.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                                objMon.Ly_thuyet = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Ly_thuyet
                                objMon.Thuc_hanh = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Thuc_hanh
                                objMon.Bai_tap = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Bai_tap
                                objMon.Bai_tap_lon = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Bai_tap_lon
                                objMon.Thuc_tap = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Thuc_tap
                                objMon.So_hoc_trinh = objCTDT.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                objMon.STT_mon = objCTDT.ChuongTrinhDaoTaoChiTiet(i).STT_mon
                                Insert_KeHoachMon(objMon)
                            End If
                        End If
                    Next
                End If
            Next
        End Sub
        Public Function ChuongtrinhDaotaoLop(ByVal ID_lop As Integer) As DataTable
            Dim lps As New Lop_BLL(ID_lop, 1, -1, 1)
            Dim clsCTDT As ChuongTrinhDaoTao_BLL
            Dim objCTDT As New ChuongTrinhDaoTaoChiTiet
            'Load chương trình đào tạo khung
            If lps.Count > 0 Then
                clsCTDT = New ChuongTrinhDaoTao_BLL(lps.Lop(0).ID_dt)
                clsCTDT.Load_CTDTChiTiet(lps.Lop(0).ID_dt)
                If clsCTDT.Count Then
                    Dim idx As Integer
                    idx = clsCTDT.Tim_idx(lps.Lop(0).ID_dt)
                    If idx <= 0 Then idx = 0
                    objCTDT = clsCTDT.ChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoChiTiet
                End If
            End If
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_mon", GetType(Integer))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Ly_thuyet", GetType(Integer))
            dt.Columns.Add("Thuc_hanh", GetType(Integer))
            dt.Columns.Add("Bai_tap", GetType(Integer))
            dt.Columns.Add("Bai_tap_lon", GetType(Integer))
            dt.Columns.Add("Thuc_tap", GetType(Integer))
            dt.Columns.Add("So_hoc_trinh", GetType(Integer))
            dt.Columns.Add("So_top", GetType(Integer))
            dt.Columns.Add("STT_mon", GetType(Integer))
            dt.Columns.Add("Kien_thuc", GetType(Integer))
            dt.Columns.Add("Ky_thu", GetType(Integer))
            For i As Integer = 0 To objCTDT.Count - 1
                Dim dr As DataRow
                dr = dt.NewRow
                dr("Chon") = False
                dr("ID_mon") = objCTDT.ChuongTrinhDaoTaoChiTiet(i).ID_mon
                dr("Ten_mon") = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Ten_mon
                If objCTDT.ChuongTrinhDaoTaoChiTiet(i).Ly_thuyet > 0 Then dr("Ly_thuyet") = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Ly_thuyet
                If objCTDT.ChuongTrinhDaoTaoChiTiet(i).Thuc_hanh > 0 Then dr("Thuc_hanh") = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Thuc_hanh
                If objCTDT.ChuongTrinhDaoTaoChiTiet(i).Bai_tap > 0 Then dr("Bai_tap") = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Bai_tap
                If objCTDT.ChuongTrinhDaoTaoChiTiet(i).Bai_tap_lon > 0 Then dr("Bai_tap_lon") = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Bai_tap_lon
                If objCTDT.ChuongTrinhDaoTaoChiTiet(i).Thuc_tap > 0 Then dr("Thuc_tap") = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Thuc_tap
                dr("So_hoc_trinh") = objCTDT.ChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                dr("So_top") = 0
                dr("STT_mon") = objCTDT.ChuongTrinhDaoTaoChiTiet(i).STT_mon
                dr("Kien_thuc") = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Kien_thuc
                dr("Ky_thu") = objCTDT.ChuongTrinhDaoTaoChiTiet(i).Ky_thu
                dt.Rows.Add(dr)
            Next
            'Duyệt xóa những môn đã chọn trong học kỳ
            For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                For j As Integer = 0 To Count - 1
                    If KeHoachMon(j).ID_mon = dt.Rows(i)("ID_mon") And KeHoachMon(j).ID_lop = ID_lop Then
                        dt.Rows.RemoveAt(i)
                    End If
                Next
            Next
            dt.DefaultView.Sort = "Ky_thu, STT_mon"
            Return dt
        End Function
        Public Function KeHoachMonTrongKyDaChon(ByVal ID_lop As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_mon", GetType(Integer))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Ly_thuyet", GetType(Integer))
            dt.Columns.Add("Thuc_hanh", GetType(Integer))
            dt.Columns.Add("Bai_tap", GetType(Integer))
            dt.Columns.Add("Bai_tap_lon", GetType(Integer))
            dt.Columns.Add("Thuc_tap", GetType(Integer))
            dt.Columns.Add("So_hoc_trinh", GetType(Integer))
            dt.Columns.Add("So_top", GetType(Integer))
            dt.Columns.Add("STT_mon", GetType(Integer))
            dt.Columns.Add("Kien_thuc", GetType(Integer))
            dt.Columns.Add("Ky_thu", GetType(Integer))
            For i As Integer = 0 To Count - 1
                If KeHoachMon(i).ID_lop = ID_lop Then
                    Dim dr As DataRow
                    dr = dt.NewRow
                    dr("Chon") = False
                    dr("ID_mon") = KeHoachMon(i).ID_mon
                    dr("Ten_mon") = KeHoachMon(i).Ten_mon
                    If KeHoachMon(i).Ly_thuyet > 0 Then dr("Ly_thuyet") = KeHoachMon(i).Ly_thuyet
                    If KeHoachMon(i).Thuc_hanh > 0 Then dr("Thuc_hanh") = KeHoachMon(i).Thuc_hanh
                    If KeHoachMon(i).Bai_tap > 0 Then dr("Bai_tap") = KeHoachMon(i).Bai_tap
                    If KeHoachMon(i).Bai_tap_lon > 0 Then dr("Bai_tap_lon") = KeHoachMon(i).Bai_tap_lon
                    If KeHoachMon(i).Thuc_tap > 0 Then dr("Thuc_tap") = KeHoachMon(i).Thuc_tap
                    dr("So_hoc_trinh") = KeHoachMon(i).So_hoc_trinh
                    dr("So_top") = KeHoachMon(i).So_top
                    dr("STT_mon") = KeHoachMon(i).STT_mon
                    dr("Kien_thuc") = 0
                    dr("Ky_thu") = 0
                    dt.Rows.Add(dr)
                End If
            Next
            dt.DefaultView.Sort = "STT_mon"
            Return dt
        End Function
        Public Function PhanBoGiaoVien() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_kh_mon", GetType(Integer))
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            dt.Columns.Add("ID_cb", GetType(Integer))
            dt.Columns.Add("ID_bm", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Ca_hoc", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("So_tiet", GetType(Integer))
            dt.Columns.Add("Ho_ten", GetType(String))
            For i As Integer = 0 To Count - 1
                Dim dr As DataRow
                dr = dt.NewRow
                dr("ID_kh_mon") = KeHoachMon(i).ID_kh_mon
                dr("ID_he") = KeHoachMon(i).ID_he
                dr("ID_khoa") = KeHoachMon(i).ID_khoa
                dr("Khoa_hoc") = KeHoachMon(i).Khoa_hoc
                dr("ID_cb") = KeHoachMon(i).ID_cb
                dr("ID_bm") = KeHoachMon(i).ID_bm
                dr("Ten_mon") = KeHoachMon(i).Ten_mon
                dr("So_tiet") = KeHoachMon(i).Ly_thuyet
                dr("Ten_lop") = KeHoachMon(i).Ten_lop
                dr("Ca_hoc") = CType(KeHoachMon(i).Ca_hoc, eCA_HOC).ToString
                dr("Ho_ten") = KeHoachMon(i).Ho_ten
                dt.Rows.Add(dr)
            Next
            Return dt
        End Function
        Public Function PhanBoPhongThucHanh() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_phan_bo", GetType(Integer))
            dt.Columns.Add("ID_kh_mon", GetType(Integer))
            dt.Columns.Add("ID_phong", GetType(Integer))
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Ca_hoc", GetType(String))
            dt.Columns.Add("So_sv", GetType(Integer))
            dt.Columns.Add("Top_thu", GetType(Integer))
            dt.Columns.Add("Ten_phong", GetType(String))
            For i As Integer = 0 To Count - 1
                If KeHoachMon(i).So_top > 0 Then
                    For t As Integer = 1 To KeHoachMon(i).So_top
                        Dim dr As DataRow
                        dr = dt.NewRow
                        dr("ID_kh_mon") = KeHoachMon(i).ID_kh_mon
                        dr("ID_he") = KeHoachMon(i).ID_he
                        dr("ID_khoa") = KeHoachMon(i).ID_khoa
                        dr("Khoa_hoc") = KeHoachMon(i).Khoa_hoc
                        dr("Ten_mon") = KeHoachMon(i).Ten_mon
                        dr("Ten_lop") = KeHoachMon(i).Ten_lop
                        dr("Ca_hoc") = CType(KeHoachMon(i).Ca_hoc, eCA_HOC).ToString
                        dr("So_sv") = KeHoachMon(i).So_sv / KeHoachMon(i).So_top
                        dr("Top_thu") = t
                        dr("ID_phong") = 0
                        dr("Ten_phong") = ""
                        dt.Rows.Add(dr)
                    Next
                End If
            Next
            dt.AcceptChanges()
            dt.DefaultView.Sort = "Ten_mon, Ten_lop"
            Return dt
        End Function
        Public Function GiayBaoKeHoachGiangDayBoMon() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            dt.Columns.Add("ID_bm", GetType(Integer))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("So_sv", GetType(Integer))
            dt.Columns.Add("So_tiet", GetType(Integer))
            dt.Columns.Add("LT", GetType(Integer))
            dt.Columns.Add("LT_quy_doi", GetType(Integer))
            dt.Columns.Add("TH", GetType(Integer))
            dt.Columns.Add("So_top", GetType(Integer))
            dt.Columns.Add("TH_quy_doi", GetType(Integer))
            dt.Columns.Add("BT", GetType(Integer))
            dt.Columns.Add("BT_quy_doi", GetType(Integer))
            dt.Columns.Add("BTL", GetType(Integer))
            dt.Columns.Add("BTL_quy_doi", GetType(Integer))
            dt.Columns.Add("Phu_dao", GetType(Integer))
            dt.Columns.Add("Thi_quy_doi", GetType(Integer))
            dt.Columns.Add("Tong_so_tiet_quy_doi", GetType(Integer))
            dt.Columns.Add("Thoi_gian", GetType(String))
            dt.Columns.Add("Thuc_tap", GetType(Integer))
            dt.Columns.Add("Ca_hoc", GetType(Integer))
            For i As Integer = 0 To Count - 1
                Dim dr As DataRow
                dr = dt.NewRow
                dr("ID_he") = KeHoachMon(i).ID_he
                dr("ID_khoa") = KeHoachMon(i).ID_khoa
                dr("Khoa_hoc") = KeHoachMon(i).Khoa_hoc
                dr("ID_bm") = KeHoachMon(i).ID_bm
                dr("Ten_mon") = KeHoachMon(i).Ten_mon
                dr("Ten_lop") = KeHoachMon(i).Ten_lop
                dr("So_tiet") = KeHoachMon(i).Ly_thuyet + KeHoachMon(i).Thuc_hanh + KeHoachMon(i).Bai_tap + KeHoachMon(i).Bai_tap_lon
                dr("So_sv") = KeHoachMon(i).So_sv
                dr("LT") = KeHoachMon(i).Ly_thuyet
                dr("LT_quy_doi") = LT_Quy_doi(KeHoachMon(i).ID_he, KeHoachMon(i).So_sv, KeHoachMon(i).Ly_thuyet)
                dr("TH") = KeHoachMon(i).Thuc_hanh
                dr("So_top") = KeHoachMon(i).So_top
                dr("TH_quy_doi") = TH_Quy_doi(KeHoachMon(i).ID_he, KeHoachMon(i).Thuc_hanh, KeHoachMon(i).So_top)
                dr("BT") = KeHoachMon(i).Bai_tap
                dr("BT_quy_doi") = BT_Quy_doi(KeHoachMon(i).ID_he, KeHoachMon(i).Bai_tap, KeHoachMon(i).So_sv)
                dr("BTL") = KeHoachMon(i).Bai_tap_lon
                dr("BTL_quy_doi") = BTL_Quy_doi(KeHoachMon(i).ID_he, KeHoachMon(i).Bai_tap_lon, KeHoachMon(i).So_sv)
                dr("Phu_dao") = 0
                dr("Tong_so_tiet_quy_doi") = dr("LT_quy_doi") + dr("TH_quy_doi") + dr("BT_quy_doi") + dr("BTL_quy_doi") + Thuc_Tap_Quy_doi(KeHoachMon(i).ID_he, KeHoachMon(i).So_sv, KeHoachMon(i).Thuc_tap)
                dr("Thoi_gian") = KeHoachMon(i).Thoi_gian
                If KeHoachMon(i).Thuc_tap > 0 Then dr("Thuc_tap") = KeHoachMon(i).Thuc_tap
                dr("Ca_hoc") = KeHoachMon(i).Ca_hoc
                dt.Rows.Add(dr)
            Next
            Return dt
        End Function
        Public Function Tim_mon_hoc(ByVal ID_mon As Integer, ByVal ID_lop As Integer) As Integer
            For i As Integer = 0 To Count - 1
                If KeHoachMon(i).ID_mon = ID_mon And KeHoachMon(i).ID_lop = ID_lop Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Tim_mon_hoc(ByVal ID_kh_mon As Integer) As Integer
            For i As Integer = 0 To Count - 1
                If KeHoachMon(i).ID_kh_mon = ID_kh_mon Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Insert_KeHoachMon(ByVal objKeHoachMon As KeHoachMon) As Integer
            Try
                Dim obj As KeHoachMon_DAL = New KeHoachMon_DAL
                Return obj.Insert_KeHoachMon(objKeHoachMon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachMon(ByVal objKeHoachMon As KeHoachMon, ByVal ID_kh_mon As Integer) As Integer
            Try
                Dim obj As KeHoachMon_DAL = New KeHoachMon_DAL
                Return obj.Update_KeHoachMon(objKeHoachMon, ID_kh_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachMon_GiaoVien(ByVal ID_kh_mon As Integer, ByVal ID_cb As Integer) As Integer
            Try
                Dim obj As KeHoachMon_DAL = New KeHoachMon_DAL
                Return obj.Update_KeHoachMon_GiaoVien(ID_kh_mon, ID_cb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KeHoachMon(ByVal ID_kh_mon As Integer) As Integer
            Try
                Dim obj As KeHoachMon_DAL = New KeHoachMon_DAL
                Return obj.Delete_KeHoachMon(ID_kh_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drKeHoachMon As DataRow) As KeHoachMon
            Dim result As KeHoachMon
            Try
                result = New KeHoachMon
                If drKeHoachMon("ID_kh_mon").ToString() <> "" Then result.ID_kh_mon = CType(drKeHoachMon("ID_kh_mon").ToString(), Integer)
                If drKeHoachMon("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drKeHoachMon("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drKeHoachMon("Nam_hoc").ToString()
                If drKeHoachMon("ID_lop").ToString() <> "" Then result.ID_lop = CType(drKeHoachMon("ID_lop").ToString(), Integer)
                If drKeHoachMon("ID_he").ToString() <> "" Then result.ID_he = CType(drKeHoachMon("ID_he").ToString(), Integer)
                If drKeHoachMon("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drKeHoachMon("ID_khoa").ToString(), Integer)
                If drKeHoachMon("Khoa_hoc").ToString() <> "" Then result.Khoa_hoc = CType(drKeHoachMon("Khoa_hoc").ToString(), Integer)
                If drKeHoachMon("ID_mon").ToString() <> "" Then result.ID_mon = CType(drKeHoachMon("ID_mon").ToString(), Integer)
                If drKeHoachMon("Ten_mon").ToString() <> "" Then result.Ten_mon = CType(drKeHoachMon("Ten_mon").ToString(), String)
                If drKeHoachMon("Ly_thuyet").ToString() <> "" Then result.Ly_thuyet = CType(drKeHoachMon("Ly_thuyet").ToString(), Integer)
                If drKeHoachMon("Thuc_hanh").ToString() <> "" Then result.Thuc_hanh = CType(drKeHoachMon("Thuc_hanh").ToString(), Integer)
                If drKeHoachMon("Bai_tap").ToString() <> "" Then result.Bai_tap = CType(drKeHoachMon("Bai_tap").ToString(), Integer)
                If drKeHoachMon("Bai_tap_lon").ToString() <> "" Then result.Bai_tap_lon = CType(drKeHoachMon("Bai_tap_lon").ToString(), Integer)
                If drKeHoachMon("Thuc_tap").ToString() <> "" Then result.Thuc_tap = CType(drKeHoachMon("Thuc_tap").ToString(), Integer)
                If drKeHoachMon("So_hoc_trinh").ToString() <> "" Then result.So_hoc_trinh = CType(drKeHoachMon("So_hoc_trinh").ToString(), Integer)
                If drKeHoachMon("So_top").ToString() <> "" Then result.So_top = CType(drKeHoachMon("So_top").ToString(), Integer)
                If drKeHoachMon("STT_mon").ToString() <> "" Then result.STT_mon = CType(drKeHoachMon("STT_mon").ToString(), Integer)
                If drKeHoachMon("Ca_hoc").ToString() <> "" Then result.Ca_hoc = CType(drKeHoachMon("Ca_hoc").ToString(), Integer)
                If drKeHoachMon("ID_cb").ToString() <> "" Then result.STT_mon = CType(drKeHoachMon("ID_cb").ToString(), Integer)
                If drKeHoachMon("ID_bm").ToString() <> "" Then result.ID_bm = CType(drKeHoachMon("ID_bm").ToString(), Integer)
                If drKeHoachMon("So_sv").ToString() <> "" Then result.So_sv = CType(drKeHoachMon("So_sv").ToString(), Integer)
                result.Ho_ten = drKeHoachMon("Ho_ten").ToString()
                result.Ten_lop = drKeHoachMon("Ten_lop").ToString()
                result.Thoi_gian = drKeHoachMon("Thoi_gian").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function LT_Quy_doi(ByVal ID_he As Integer, ByVal So_tiet As Integer, ByVal So_sv As Integer) As Integer
            Select Case ID_he
                Case Is <> 3
                    Select Case So_sv
                        Case Is < 80
                            Return So_tiet
                        Case So_sv >= 80 And So_sv < 150
                            Return So_tiet * 1.2
                        Case So_sv >= 150 And So_sv < 200
                            Return So_tiet * 1.3
                        Case So_sv >= 200 And So_sv < 250
                            Return So_tiet * 1.4
                        Case Else
                            Return So_tiet * 1.5
                    End Select
                Case Else   'Tại chức
                    Select Case So_sv
                        Case Is < 80
                            Return So_tiet * 1.3
                        Case So_sv >= 80 And So_sv < 150
                            Return So_tiet * 1.2 * 1.3
                        Case So_sv >= 150 And So_sv < 200
                            Return So_tiet * 1.3 * 1.3
                        Case So_sv >= 200 And So_sv < 250
                            Return So_tiet * 1.4 * 1.3
                        Case Else
                            Return So_tiet * 1.5 * 1.3
                    End Select
            End Select
        End Function
        Private Function TH_Quy_doi(ByVal ID_he As Integer, ByVal So_tiet As Integer, ByVal So_nhom As Integer) As Integer
            Return Math.Round(So_tiet * So_nhom * 0.5, 0)
        End Function
        Private Function BT_Quy_doi(ByVal ID_he As Integer, ByVal So_tiet As Integer, ByVal So_sv As Integer) As Integer
            Select Case So_sv
                Case Is < 80
                    Return So_tiet
                Case Else
                    Return Math.Round(So_tiet * 1.2, 0)
            End Select
        End Function
        Private Function BTL_Quy_doi(ByVal ID_he As Integer, ByVal So_tiet As Integer, ByVal So_sv As Integer) As Integer
            Select Case So_tiet
                Case Is < 11
                    Return Math.Round(So_sv * 0.3, 0)
                Case So_tiet >= 11 And So_tiet <= 15
                    Return Math.Round(So_sv * 0.5, 0)
                Case Else
                    Return So_sv
            End Select
        End Function
        Private Function Thi_Quy_doi(ByVal ID_he As Integer, ByVal So_sv As Integer) As Integer
            Return Math.Round(So_sv / 10, 0)
        End Function
        Private Function Thuc_Tap_Quy_doi(ByVal ID_he As Integer, ByVal So_sv As Integer, ByVal So_tuan As Integer) As Integer
            Select Case So_sv
                Case Is < 30
                    Return Math.Round(1 * 12 * So_tuan, 0)
                Case So_sv >= 30 And So_sv < 60
                    Return Math.Round(2 * 12 * So_tuan, 0)
                Case Else
                    Return Math.Round(3 * 12 * So_tuan, 0)
            End Select
        End Function
#End Region
    End Class
End Namespace
