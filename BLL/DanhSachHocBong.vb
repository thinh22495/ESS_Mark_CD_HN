'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Saturday, August 09, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class DanhSachHocBong_BLL

        Private arrDanhSachHB As New ArrayList
        Private mdtDoiTuongHB As DataTable
        Private mdtDsTroCap As DataTable ' Danh sách sinh viên xác định tiền trợ cấp
        Private arrHBSinhVien As New ArrayList ' Thông tin học bổng của một sinh viên
#Region "Constructor"
        Public Sub New()
        End Sub
        Public Sub New(ByVal dsID_lop As String)
            Try
                Dim obj As DanhSachHocBong_DAL = New DanhSachHocBong_DAL
                Dim dt As DataTable = obj.Load_DanhSachHocBong_List(dsID_lop)                
                Dim objDanhSachHocBong As DanhSachHocBong = Nothing
                For Each dr As DataRow In dt.Rows
                    objDanhSachHocBong = New DanhSachHocBong
                    objDanhSachHocBong = Converting(dr)
                    arrDanhSachHB.Add(objDanhSachHocBong)
                Next                
                mdtDoiTuongHB = obj.Load_DoiTuongHocBong()
                mdtDsTroCap = obj.Load_DanhSachTroCap(0, "", dsID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal ID_sv As Integer) ' Load học bổng của một sinh viên (dùng load hồ sơ sinh viên)
            Try
                Dim obj As DanhSachHocBong_DAL = New DanhSachHocBong_DAL
                Dim dt As DataTable = obj.Load_HocBongSinhVien(ID_sv)                
                Dim objDanhSachHocBong As DanhSachHocBong = Nothing
                For Each dr As DataRow In dt.Rows
                    objDanhSachHocBong = New DanhSachHocBong
                    objDanhSachHocBong = ConvertingQHBSinhVien(dr)
                    arrHBSinhVien.Add(objDanhSachHocBong)
                Next                
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        ' Học bổng của một sinh viên (dùng load trong hồ sơ sinh viên)
        Public Function HocBongSinhVien() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Hoc_ky1")
                dt.Columns.Add("Hoc_ky2")
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("HBHT1", GetType(Integer))
                dt.Columns.Add("HBHT2", GetType(Integer))
                dt.Columns.Add("HBCS1", GetType(Integer))
                dt.Columns.Add("HBCS2", GetType(Integer))
                dt.Columns.Add("Tong_cong", GetType(Integer))
                Dim r As DataRow
                Dim Hoc_ky As Integer = 0
                Dim Nam_hoc As String = ""
                Dim obj As New DanhSachHocBong
                For i As Integer = 0 To arrHBSinhVien.Count - 1
                    obj = arrHBSinhVien(i)
                    If obj.Nam_hoc <> Nam_hoc Or obj.Hoc_ky <> Hoc_ky Then
                        Dim HBHT1, HBHT2 As Integer
                        Dim HBCS1, HBCS2 As Integer
                        Dim obj1 As DanhSachHocBong
                        For j As Integer = 0 To arrHBSinhVien.Count - 1
                            obj1 = arrHBSinhVien(j)
                            If obj.Hoc_ky = obj1.Hoc_ky And obj.Nam_hoc = obj1.Nam_hoc Then
                                If obj1.Hoc_ky = 1 Then
                                    HBHT1 += obj1.HB_HT
                                    HBCS1 += obj1.HB_CS
                                ElseIf obj1.Hoc_ky = 2 Then
                                    HBHT2 += obj1.HB_HT
                                    HBCS2 += obj1.HB_CS
                                End If
                            End If
                        Next
                        r = dt.NewRow
                        If obj.Hoc_ky = 1 Then
                            r("Hoc_ky1") = obj.Hoc_ky
                        Else
                            r("Hoc_ky2") = obj.Hoc_ky
                        End If
                        r("Nam_hoc") = obj.Nam_hoc
                        If HBHT1 > 0 Then r("HBHT1") = HBHT1
                        If HBHT2 > 0 Then r("HBHT2") = HBHT2
                        If HBCS1 > 0 Then r("HBCS1") = HBCS1
                        If HBCS2 > 0 Then r("HBCS2") = HBCS2
                        Dim Tong_cong As Integer = HBHT1 + HBHT2 + HBCS1 + HBCS2
                        If Tong_cong > 0 Then r("Tong_cong") = Tong_cong
                        dt.Rows.Add(r)
                        Hoc_ky = obj.Hoc_ky
                        Nam_hoc = obj.Nam_hoc
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên đủ điều kiện xét học bổng
        Public Function DanhSachSV_XetHocBong(ByVal dtDiem As DataTable, ByVal dtKl As DataTable, ByVal dtRLSinhVien As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByRef TongTien_HB_CS As Integer, ByRef ProgressBar As System.Windows.Forms.ProgressBar) As DataTable
            Try
                Dim objDM As New DanhMuc_BLL
                Dim XepLoaiXS As String = objDM.LoadXepLoai_HocBong(1)
                Dim XepLoaiGioi As String = objDM.LoadXepLoai_HocBong(2)
                Dim XepLoaiKha As String = objDM.LoadXepLoai_HocBong(3)
                Dim dt As DataTable
                dt = dtDiem.Copy
                dt.Columns.Add("Ma_dt", GetType(String))
                dt.Columns.Add("Ten_dt", GetType(String))
                dt.Columns.Add("Tong_diem_rl", GetType(Integer))
                dt.Columns.Add("ID_xep_loai_RL", GetType(Integer))
                dt.Columns.Add("Xep_loai_RL", GetType(String))
                dt.Columns.Add("ID_xep_loai_HB", GetType(Integer))
                dt.Columns.Add("Xep_loai_HB", GetType(String))
                dt.Columns.Add("HB_HT", GetType(Integer))
                dt.Columns.Add("HB_CS", GetType(Integer))
                dt.Columns.Add("Xu_ly_ky_luat", GetType(String))
                ProgressBar.Minimum = 0
                ProgressBar.Maximum = dt.Rows.Count - 1
                ProgressBar.Step = 1
                ProgressBar.Value = 0
                For i As Integer = 0 To dt.Rows.Count - 1
                    ProgressBar.Value = i
                    ' Lọc sinh viên kỷ luật
                    dtKl.DefaultView.RowFilter = "ID_sv=" & dt.Rows(i)("ID_sv")
                    ' Lọc điểm rèn luyện của sinh viên
                    dtRLSinhVien.DefaultView.RowFilter = "ID_sv=" & dt.Rows(i)("ID_sv")
                    If dtRLSinhVien.DefaultView.Count > 0 Then dt.Rows(i)("Tong_diem_rl") = IIf(IsDBNull(dtRLSinhVien.DefaultView.Item(0)("Tong_diem_rl")), 0, dtRLSinhVien.DefaultView.Item(0)("Tong_diem_rl"))
                    If dtRLSinhVien.DefaultView.Count > 0 Then dt.Rows(i)("ID_xep_loai_RL") = dtRLSinhVien.DefaultView.Item(0)("ID_xep_loai")
                    If dtRLSinhVien.DefaultView.Count > 0 Then dt.Rows(i)("Xep_loai_RL") = dtRLSinhVien.DefaultView.Item(0)("Xep_loai")
                    dt.Rows(i)("chon") = False
                    mdtDoiTuongHB.DefaultView.RowFilter = "ID_dt_hb=" & dt.Rows(i)("ID_doi_tuong_TC")
                    If mdtDoiTuongHB.DefaultView.Count > 0 Then ' Nếu sinh viên đã xác định đối tượng học bổng
                        dt.Rows(i)("Ma_dt") = mdtDoiTuongHB.DefaultView.Item(0)("Ma_dt_hb")
                        dt.Rows(i)("Ten_dt") = mdtDoiTuongHB.DefaultView.Item(0)("Ten_dt_hb")
                        dt.Rows(i)("HB_CS") = 0
                    End If
                    ' Không nợ môn và phải không bị kỷ luật và ID_xep_loai >=1 and ID_xep_loai <= 3(từ khá trở lên) và xếp loại rèn luyện từ khá trở lên ID_xep_loai >=1 ID_xep_loai <=3 từ khá trở lên
                    If IIf(IsDBNull(dt.Rows(i)("So_mon_no")), 0, dt.Rows(i)("So_mon_no")) = 0 And _
                    IIf(IsDBNull(dt.Rows(i)("Diem_thi_nho_hon5")), 0, dt.Rows(i)("Diem_thi_nho_hon5")) = 0 And _
                    dtKl.DefaultView.Count <= 0 And dtRLSinhVien.DefaultView.Count > 0 Then
                        Try
                            ' Xếp loại hb xuất sắc
                            If IIf(IsDBNull(dt.Rows(i)("ID_xep_loai")), 0, dt.Rows(i)("ID_xep_loai")) = 1 And _
                            IIf(IsDBNull(dtRLSinhVien.DefaultView.Item(0).Item("ID_xep_loai")), 0, dtRLSinhVien.DefaultView.Item(0).Item("ID_xep_loai")) = 1 Then
                                dt.Rows(i)("ID_xep_loai_HB") = 1
                                dt.Rows(i)("Xep_loai_HB") = XepLoaiXS
                            ElseIf IIf(IsDBNull(dt.Rows(i)("ID_xep_loai")), 0, dt.Rows(i)("ID_xep_loai")) <= 2 And _
                            IIf(IsDBNull(dt.Rows(i)("ID_xep_loai")), 0, dt.Rows(i)("ID_xep_loai")) > 0 And _
                            IIf(IsDBNull(dtRLSinhVien.DefaultView.Item(0).Item("ID_xep_loai")), 0, dtRLSinhVien.DefaultView.Item(0).Item("ID_xep_loai")) <= 2 Then ' Xếp loại hb giỏi
                                dt.Rows(i)("ID_xep_loai_HB") = 2
                                dt.Rows(i)("Xep_loai_HB") = XepLoaiGioi
                            ElseIf IIf(IsDBNull(dt.Rows(i)("ID_xep_loai")), 0, dt.Rows(i)("ID_xep_loai")) <= 3 And _
                            IIf(IsDBNull(dt.Rows(i)("ID_xep_loai")), 0, dt.Rows(i)("ID_xep_loai")) > 0 And _
                            IIf(IsDBNull(dtRLSinhVien.DefaultView.Item(0).Item("ID_xep_loai")), 0, dtRLSinhVien.DefaultView.Item(0).Item("ID_xep_loai")) <= 3 Then ' Xếp loại hb khá
                                dt.Rows(i)("ID_xep_loai_HB") = 3
                                dt.Rows(i)("Xep_loai_HB") = XepLoaiKha
                            Else ' Khong duoc xep loai hoc bong
                                dt.Rows(i)("ID_xep_loai_HB") = 4
                                dt.Rows(i)("Xep_loai_HB") = "Không xếp loại"
                            End If
                        Catch ex As Exception
                            Throw ex
                        End Try
                    Else ' Neu vi pham no mon, ky luat
                        If dtKl.DefaultView.Count > 0 Then dt.Rows(i)("Xu_ly_ky_luat") = dtKl.DefaultView.Item(0)("Xu_ly").ToString
                        ' Khong duoc xep loai hoc bong
                        dt.Rows(i)("ID_xep_loai_HB") = 4
                        dt.Rows(i)("Xep_loai_HB") = "Không xếp loại"
                    End If
                Next
                dt.AcceptChanges()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên đã xết học bổng
        Public Function DanhSachSV_DaXet(ByVal dtDanhSachSV As DataTable, ByVal ID_phan_bo As Integer, ByRef So_tien_da_xet As Integer, ByRef So_tien_tro_cap As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("ID_xep_loai", GetType(Integer))
                dt.Columns.Add("Xep_loai", GetType(String))
                dt.Columns.Add("ID_xep_loai_RL", GetType(Integer))
                dt.Columns.Add("Xep_loai_RL", GetType(String))
                dt.Columns.Add("ID_doi_tuong_TC", GetType(Integer))
                dt.Columns.Add("Ma_dt", GetType(String))
                dt.Columns.Add("Ten_dt", GetType(String))
                dt.Columns.Add("ID_xep_loai_HB", GetType(Integer))
                dt.Columns.Add("TBCHT1", GetType(Double))
                dt.Columns.Add("Tong_diem_rl", GetType(Integer))
                dt.Columns.Add("Xep_loai_HB", GetType(String))
                dt.Columns.Add("HB_HT", GetType(Integer))
                dt.Columns.Add("HB_CS", GetType(Integer))
                Dim dr As DataRow
                Dim obj As DanhSachHocBong
                For Each r As DataRow In dtDanhSachSV.Rows
                    For i As Integer = 0 To arrDanhSachHB.Count - 1
                        obj = arrDanhSachHB(i)
                        If obj.ID_phan_bo = ID_phan_bo And obj.ID_sv = r("ID_sv") Then
                            dr = dt.NewRow
                            dr("Chon") = False
                            dr("ID_sv") = obj.ID_sv
                            dr("Ma_sv") = r("Ma_sv")
                            dr("Ho_ten") = r("Ho_ten")
                            dr("Ngay_sinh") = r("Ngay_sinh")
                            dr("Ten_lop") = r("Ten_lop")
                            dr("ID_xep_loai") = r("ID_xep_loai")
                            dr("Xep_loai") = r("Xep_loai")
                            dr("ID_xep_loai_RL") = r("ID_xep_loai_RL")
                            dr("Xep_loai_RL") = r("Xep_loai_RL")
                            dr("ID_doi_tuong_TC") = r("ID_doi_tuong_TC")
                            dr("Ma_dt") = r("Ma_dt")
                            dr("Ten_dt") = r("Ten_dt")
                            dr("ID_xep_loai_HB") = r("ID_xep_loai_HB")
                            dr("TBCHT1") = r("TBCHT1")
                            dr("Tong_diem_rl") = r("Tong_diem_rl")
                            dr("Xep_loai_HB") = r("Xep_loai_HB")
                            dr("HB_HT") = obj.HB_HT
                            dr("HB_CS") = obj.HB_CS
                            dt.Rows.Add(dr)
                            So_tien_da_xet += obj.HB_HT
                            So_tien_tro_cap += obj.HB_CS
                        End If
                    Next
                Next
                dt.AcceptChanges()
                dt.DefaultView.AllowNew = False
                dt.DefaultView.AllowEdit = False
                dt.DefaultView.AllowDelete = False
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Xét học bổng
        Public Function XetHocBong(ByVal ID_he As Integer, ByVal dtDanhSach As DataTable, ByVal dtLoaiHB As DataTable, ByRef So_tien_da_xet As Integer, ByVal So_tien_xet As Integer) As DataTable
            Try
                Dim dv As DataView
                dv = dtDanhSach.DefaultView
                ' Xet sinh vien xuat sac truoc
                dv.RowFilter = "ID_xep_loai_hb=1 And ID_xep_loai_hb<>4 "
                dv.Sort = "TBCHT1,Tong_diem_rl" ' Sap xep loc uu tien Diem TBCHT, sau do diem ren luyen
                For i As Integer = dv.Count - 1 To 0 Step -1
                    With dtLoaiHB.DefaultView
                        .RowFilter = "Ma_dt='" & dv.Item(i)("Ma_dt") & "' And ID_xep_loai_hb=" & dv.Item(i)("ID_xep_loai_hb") & " And ID_he=" & ID_he
                        If .Count > 0 Then
                            If CInt("0" + .Item(0).Item("HB_HT")) > So_tien_xet Then
                                ' Số tiền còn lại gán nốt cho sinh viên cuối cùng được hưởng
                                dv.Item(i)("HB_HT") = So_tien_xet
                                So_tien_da_xet += dv.Item(i)("HB_HT")
                                So_tien_xet -= So_tien_xet
                                Exit For
                            End If
                            dv.Item(i)("HB_HT") = CInt("0" + .Item(0).Item("HB_HT")) ' Nhân với 6 thang trong 1 học kỳ
                            So_tien_da_xet += dv.Item(i)("HB_HT")
                            So_tien_xet -= dv.Item(i)("HB_HT")
                        Else  'Chưa có phân loại học bổng theo đối tượng
                            dv.Item(i)("HB_HT") = 0
                        End If
                    End With
                Next
                ' Xet sinh vien giỏi truoc
                dv.RowFilter = "ID_xep_loai_hb=2 And ID_xep_loai_hb<>4 "
                dv.Sort = "TBCHT1,Tong_diem_rl" ' Sap xep loc uu tien Diem TBCHT, sau do diem ren luyen
                For i As Integer = dv.Count - 1 To 0 Step -1
                    With dtLoaiHB.DefaultView
                        .RowFilter = "Ma_dt='" & dv.Item(i)("Ma_dt") & "' And ID_xep_loai_hb=" & dv.Item(i)("ID_xep_loai_hb") & " And ID_he=" & ID_he
                        If .Count > 0 Then
                            If CInt("0" + .Item(0).Item("HB_HT")) > So_tien_xet Then
                                ' Số tiền còn lại gán nốt cho sinh viên cuối cùng được hưởng
                                dv.Item(i)("HB_HT") = So_tien_xet
                                So_tien_da_xet += dv.Item(i)("HB_HT")
                                So_tien_xet -= So_tien_xet
                                Exit For
                            End If
                            dv.Item(i)("HB_HT") = CInt("0" + .Item(0).Item("HB_HT")) ' Nhân với 6 thang trong 1 học kỳ
                            So_tien_da_xet += dv.Item(i)("HB_HT")
                            So_tien_xet -= dv.Item(i)("HB_HT")
                        Else  'Chưa có phân loại học bổng theo đối tượng
                            dv.Item(i)("HB_HT") = 0
                        End If
                    End With
                Next
                ' Xet sinh vien giỏi truoc
                dv.RowFilter = "ID_xep_loai_hb=3 And ID_xep_loai_hb<>4 "
                dv.Sort = "TBCHT1,Tong_diem_rl" ' Sap xep loc uu tien Diem TBCHT, sau do diem ren luyen
                For i As Integer = dv.Count - 1 To 0 Step -1
                    With dtLoaiHB.DefaultView
                        .RowFilter = "Ma_dt='" & dv.Item(i)("Ma_dt") & "' And ID_xep_loai_hb=" & dv.Item(i)("ID_xep_loai_hb") & " And ID_he=" & ID_he
                        If .Count > 0 Then
                            If CInt("0" + .Item(0).Item("HB_HT")) > So_tien_xet Then
                                ' Số tiền còn lại gán nốt cho sinh viên cuối cùng được hưởng
                                dv.Item(i)("HB_HT") = So_tien_xet
                                So_tien_da_xet += dv.Item(i)("HB_HT")
                                So_tien_xet -= So_tien_xet
                                Exit For
                            End If
                            dv.Item(i)("HB_HT") = CInt("0" + .Item(0).Item("HB_HT")) ' Nhân với 6 thang trong 1 học kỳ
                            So_tien_da_xet += dv.Item(i)("HB_HT")
                            So_tien_xet -= dv.Item(i)("HB_HT")
                        Else  'Chưa có phân loại học bổng theo đối tượng
                            dv.Item(i)("HB_HT") = 0
                        End If
                    End With
                Next

                ' Xóa những sinh viên không có học bổng học tập, học bổng chính sách    
                For i As Integer = dv.Table.Rows.Count - 1 To 0 Step -1
                    If IIf(IsDBNull(dv.Table.Rows(i)("HB_HT")), 0, dv.Table.Rows(i)("HB_HT")) = 0 And IIf(IsDBNull(dv.Table.Rows(i)("HB_CS")), 0, dv.Table.Rows(i)("HB_CS")) = 0 Then dv.Table.Rows(i).Delete()
                Next
                dv.Table.AcceptChanges()
                Return dv.Table
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên chưa xét học bổng ( Lọc từ danh sách sinh viên đủ điều kiên xét học bổng)
        Public Function DanhSachSV_Chua_XetHocBong(ByVal dtDanhSachSv As DataTable, ByVal dtDaXet As DataTable) As DataTable
            Try
                For i As Integer = dtDanhSachSv.Rows.Count - 1 To 0 Step -1
                    For j As Integer = 0 To dtDaXet.Rows.Count - 1
                        If dtDanhSachSv.Rows(i)("ID_sv") = dtDaXet.Rows(j)("ID_sv") Then ' Loại những sinh viên đã xét học bổng
                            dtDanhSachSv.Rows(i).Delete()
                            Exit For
                        End If
                    Next
                Next
                dtDanhSachSv.AcceptChanges()
                dtDanhSachSv.DefaultView.AllowNew = False
                dtDanhSachSv.DefaultView.AllowEdit = False
                dtDanhSachSv.DefaultView.AllowDelete = False
                Return dtDanhSachSv
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Bảng tổng hợp xét học bổng (in bc tổng hợp)
        Public Function BaoCao_TongHop(ByVal dtDaXet As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim dtDT As New DataTable
                dtDT.Columns.Add("Hoc_ky", GetType(Integer))
                dtDT.Columns.Add("Nam_hoc", GetType(String))
                dtDT.Columns.Add("Ma_dt", GetType(String))
                dtDT.Columns.Add("Ten_dt", GetType(String))
                dtDT.Columns.Add("Tong_sv", GetType(Integer))
                dtDT.Columns.Add("Tong_sv_xs", GetType(Integer))
                dtDT.Columns.Add("Tong_Tien_xs", GetType(Integer))
                dtDT.Columns.Add("Tong_sv_gioi", GetType(Integer))
                dtDT.Columns.Add("Tong_Tien_gioi", GetType(Integer))
                dtDT.Columns.Add("Tong_sv_kha", GetType(Integer))
                dtDT.Columns.Add("Tong_Tien_kha", GetType(Integer))
                dtDT.Columns.Add("Tong_Tien_Doi_Tuong", GetType(Integer)) ' Tổng số tiền HB theo đối tượng
                Dim Ma_dt As String = ""
                Dim r1 As DataRow
                Dim dv As DataView = dtDaXet.DefaultView
                dv.Sort = "Ma_dt"
                For i As Integer = 0 To dv.Count - 1 ' Lấy ra các đối tượng được học bổng
                    If Ma_dt <> dv.Item(i)("Ma_dt") Then
                        r1 = dtDT.NewRow
                        r1("Ma_dt") = dv.Item(i)("Ma_dt")
                        r1("Ten_dt") = dv.Item(i)("Ten_dt")
                        r1("Hoc_ky") = Hoc_ky
                        r1("Nam_hoc") = Nam_hoc
                        r1("Ma_dt") = dv.Item(i)("Ma_dt")
                        r1("Ten_dt") = dv.Item(i)("Ten_dt")
                        dtDT.Rows.Add(r1)
                        Ma_dt = dv.Item(i)("Ma_dt")
                    End If
                Next
                For Each dr As DataRow In dtDT.Rows ' Tính tổng sinh viên và tổng tiền của từng loại đối tượng
                    Dim Tong_sv As Integer = 0
                    Dim Tong_sv_xs As Integer = 0
                    Dim Tong_Tien_xs As Integer = 0
                    Dim Tong_sv_gioi As Integer = 0
                    Dim Tong_Tien_gioi As Integer = 0
                    Dim Tong_sv_kha As Integer = 0
                    Dim Tong_Tien_kha As Integer = 0
                    Dim Tong_Tien_Doi_Tuong As Integer = 0
                    For Each dr1 As DataRow In dtDaXet.Rows
                        If dr("Ma_dt") = dr1("Ma_dt") Then Tong_sv += 1
                        If dr("Ma_dt") = dr1("Ma_dt") And dr1("ID_xep_loai_HB") = 1 Then ' Tính tổng sv Xuất sắc và tổng tiền Xuất sắc
                            Tong_sv_xs += 1
                            If dr1("HB_HT") = 0 Then ' Nếu HBHT = 0 thì điền HBCS
                                Tong_Tien_xs += dr1("HB_CS")
                            Else
                                Tong_Tien_xs += dr1("HB_HT")
                            End If
                        End If
                        If dr("Ma_dt") = dr1("Ma_dt") And dr1("ID_xep_loai_HB") = 2 Then ' Tính tổng sv Giỏi và tổng tiền Giỏi                            
                            Tong_sv_gioi += 1
                            If dr1("HB_HT") = 0 Then ' Nếu HBHT = 0 thì điền HBCS
                                Tong_Tien_gioi += dr1("HB_CS")
                            Else
                                Tong_Tien_gioi += dr1("HB_HT")
                            End If
                        End If
                        If dr("Ma_dt") = dr1("Ma_dt") And dr1("ID_xep_loai_HB") = 3 Then ' Tính tổng sv Khá và tổng tiền Khá
                            Tong_sv_kha += 1
                            If dr1("HB_HT") = 0 Then ' Nếu HBHT = 0 thì điền HBCS
                                Tong_Tien_kha += dr1("HB_CS")
                            Else
                                Tong_Tien_kha += dr1("HB_HT")
                            End If
                        End If
                    Next
                    Tong_Tien_Doi_Tuong = Tong_Tien_xs + Tong_Tien_gioi + Tong_Tien_kha
                    If Tong_sv <> 0 Then dr("Tong_sv") = Tong_sv
                    If Tong_sv_xs <> 0 Then dr("Tong_sv_xs") = Tong_sv_xs
                    If Tong_Tien_xs <> 0 Then dr("Tong_Tien_xs") = Tong_Tien_xs
                    If Tong_sv_gioi <> 0 Then dr("Tong_sv_gioi") = Tong_sv_gioi
                    If Tong_Tien_gioi <> 0 Then dr("Tong_Tien_gioi") = Tong_Tien_gioi
                    If Tong_sv_kha <> 0 Then dr("Tong_sv_kha") = Tong_sv_kha
                    If Tong_Tien_kha <> 0 Then dr("Tong_Tien_kha") = Tong_Tien_kha
                    If Tong_Tien_Doi_Tuong <> 0 Then dr("Tong_Tien_Doi_Tuong") = Tong_Tien_Doi_Tuong
                Next
                dtDT.AcceptChanges()
                dtDT.DefaultView.AllowNew = False
                dtDT.DefaultView.AllowEdit = False
                dtDT.DefaultView.AllowDelete = False
                Return dtDT
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DanhSachHocBong(ByVal objDanhSachHocBong As DanhSachHocBong) As Integer
            Try
                Dim obj As DanhSachHocBong_DAL = New DanhSachHocBong_DAL
                Return obj.Insert_DanhSachHocBong(objDanhSachHocBong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSachHocBong(ByVal objDanhSachHocBong As DanhSachHocBong, ByVal ID_phan_bo As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachHocBong_DAL = New DanhSachHocBong_DAL
                Return obj.Update_DanhSachHocBong(objDanhSachHocBong, ID_phan_bo, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSachHocBong(ByVal ID_phan_bo As Integer) As Integer
            Try
                Dim obj As DanhSachHocBong_DAL = New DanhSachHocBong_DAL
                Return obj.Delete_DanhSachHocBong(ID_phan_bo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSachHocBong_SinhVien(ByVal ID_phan_bo As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachHocBong_DAL = New DanhSachHocBong_DAL
                Return obj.Delete_DanhSachHocBong_SinhVien(ID_phan_bo, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drDanhSachHocBong As DataRow) As DanhSachHocBong
            Dim result As DanhSachHocBong
            Try
                result = New DanhSachHocBong
                If drDanhSachHocBong("ID_phan_bo").ToString() <> "" Then result.ID_phan_bo = CType(drDanhSachHocBong("ID_phan_bo").ToString(), Integer)
                If drDanhSachHocBong("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachHocBong("ID_sv").ToString(), Integer)
                If drDanhSachHocBong("ID_xep_loai_hb").ToString() <> "" Then result.ID_xep_loai_hb = CType(drDanhSachHocBong("ID_xep_loai_hb").ToString(), Integer)
                If drDanhSachHocBong("HB_HT").ToString() <> "" Then result.HB_HT = CType(drDanhSachHocBong("HB_HT").ToString(), Integer)
                If drDanhSachHocBong("HB_CS").ToString() <> "" Then result.HB_CS = CType(drDanhSachHocBong("HB_CS").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        ' Conver ra object quỹ học bỏng của một sinh viên
        Private Function ConvertingQHBSinhVien(ByVal drDanhSachHocBong As DataRow) As DanhSachHocBong
            Dim result As DanhSachHocBong
            Try
                result = New DanhSachHocBong
                If drDanhSachHocBong("Nam_hoc").ToString() <> "" Then result.Nam_hoc = drDanhSachHocBong("Nam_hoc").ToString()
                If drDanhSachHocBong("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drDanhSachHocBong("Hoc_ky").ToString(), Integer)
                If drDanhSachHocBong("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachHocBong("ID_sv").ToString(), Integer)
                If drDanhSachHocBong("HB_HT").ToString() <> "" Then result.HB_HT = CType(drDanhSachHocBong("HB_HT").ToString(), Integer)
                If drDanhSachHocBong("HB_CS").ToString() <> "" Then result.HB_CS = CType(drDanhSachHocBong("HB_CS").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        '
        Public Sub AddHocBong(ByRef dtDSSV As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Try
                dtDSSV.Columns.Add("Hoc_bong", GetType(String))
                For i As Integer = 0 To dtDSSV.Rows.Count - 1
                    dtDSSV.Rows(i)("Hoc_bong") = HocBong_Ky(dtDSSV.Rows(i)("ID_sv"), Hoc_ky, Nam_hoc)
                Next
            Catch ex As Exception
            End Try
        End Sub

        Public Function HocBong_Ky(ByVal id_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As String
            For i As Integer = 0 To arrDanhSachHB.Count - 1
                Dim obj As DanhSachHocBong = CType(arrDanhSachHB(i), DanhSachHocBong)
                If obj.ID_sv = id_sv And obj.Hoc_ky = Hoc_ky And obj.Nam_hoc = Nam_hoc Then
                    Return obj.HB_HT.ToString
                End If
            Next
            Return ""
        End Function

#End Region
    End Class
End Namespace
