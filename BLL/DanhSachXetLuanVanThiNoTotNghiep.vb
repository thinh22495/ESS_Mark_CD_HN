'Tungk
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class DanhSachLuanVanThiNoTotNghiep_BLL
        Private arrDanhSachLuanVanThiNoTotNghiep As ArrayList
        Private mID_dv As String = ""
        Private mID_bomon As Integer = 0
        Private mdsID_lop As String = ""
        Private mdtDanhSachSinhVien As DataTable
        Private arrDanhSachLuanVan As New ArrayList
        Private arrDanhSachThiTotNghiep As New ArrayList
        Private arrDanhSachNoTotNghiep As New ArrayList
        Private mID_dt As Integer = 0
        Private QC As QuyCheDaoTao

#Region "Constructor"
        Sub New(ByVal ID_he As Integer, ByVal ID_dv As String, ByVal ID_bomon As Integer, ByVal dsID_lop As String, ByVal ID_dt As Integer, ByVal DanhSachSinhVien As DataTable)
            Try
                QC = New QuyCheDaoTao(ID_he, ID_dt)
                mdtDanhSachSinhVien = DanhSachSinhVien
                mID_dv = ID_dv
                mdsID_lop = dsID_lop
                mID_bomon = ID_bomon
                mID_dt = ID_dt

                Dim obj As DanhSachLuanVanThiNoTotNghiep_DAL = New DanhSachLuanVanThiNoTotNghiep_DAL

                Dim dt As DataTable = obj.Load_DanhSachLuanVan_List(mdsID_lop)
                Dim objsvDanhSachLuanVan As DanhSachLuanVanThiNoTotNghiep = Nothing
                Dim dr As DataRow = Nothing
                arrDanhSachLuanVan = New ArrayList
                For Each dr In dt.Rows
                    objsvDanhSachLuanVan = Converting(dr)
                    arrDanhSachLuanVan.Add(objsvDanhSachLuanVan)
                Next

                dt = obj.Load_DanhSachThiTotNghiep_List(mdsID_lop)
                objsvDanhSachLuanVan = Nothing
                dr = Nothing
                arrDanhSachThiTotNghiep = New ArrayList
                For Each dr In dt.Rows
                    objsvDanhSachLuanVan = Converting(dr)
                    arrDanhSachThiTotNghiep.Add(objsvDanhSachLuanVan)
                Next

                dt = obj.Load_DanhSachNoTotNghiep_List(mdsID_lop)
                objsvDanhSachLuanVan = Nothing
                dr = Nothing
                arrDanhSachNoTotNghiep = New ArrayList
                For Each dr In dt.Rows
                    objsvDanhSachLuanVan = ConvertingNoTotNghiep(dr)
                    arrDanhSachNoTotNghiep.Add(objsvDanhSachLuanVan)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        Function Load_DanhSach_LuanVan(ByVal Lan_xet As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon1", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Noi_sinh", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("TBCHT", GetType(Double))
            dt.Columns.Add("ID_xep_loai", GetType(Integer))
            dt.Columns.Add("Xep_hang", GetType(String))
            dt.Columns.Add("Khoa_hoc", GetType(String))
            dt.Columns.Add("Chuyen_nganh", GetType(String))
            dt.Columns.Add("Ten_he", GetType(String))

            For i As Integer = 0 To arrDanhSachLuanVan.Count - 1
                If CType(arrDanhSachLuanVan(i), DanhSachLuanVanThiNoTotNghiep).Lan_xet = Lan_xet Then
                    Dim row As DataRow = dt.NewRow()
                    row("Chon1") = False
                    row("ID_sv") = CType(arrDanhSachLuanVan(i), DanhSachLuanVanThiNoTotNghiep).ID_sv
                    row("Ma_sv") = CType(arrDanhSachLuanVan(i), DanhSachLuanVanThiNoTotNghiep).Ma_sv
                    row("Noi_sinh") = CType(arrDanhSachLuanVan(i), DanhSachLuanVanThiNoTotNghiep).Noi_sinh
                    row("Ho_ten") = CType(arrDanhSachLuanVan(i), DanhSachLuanVanThiNoTotNghiep).Ho_ten
                    row("Ngay_sinh") = CType(arrDanhSachLuanVan(i), DanhSachLuanVanThiNoTotNghiep).Ngay_sinh
                    row("Ten_lop") = CType(arrDanhSachLuanVan(i), DanhSachLuanVanThiNoTotNghiep).Ten_lop
                    row("TBCHT") = CType(arrDanhSachLuanVan(i), DanhSachLuanVanThiNoTotNghiep).TBCHT
                    row("ID_xep_loai") = CType(arrDanhSachLuanVan(i), DanhSachLuanVanThiNoTotNghiep).ID_xep_loai
                    row("Xep_hang") = CType(arrDanhSachLuanVan(i), DanhSachLuanVanThiNoTotNghiep).Xep_hang
                    row("Khoa_hoc") = CType(arrDanhSachLuanVan(i), DanhSachLuanVanThiNoTotNghiep).Khoa_hoc
                    row("Ten_he") = CType(arrDanhSachLuanVan(i), DanhSachLuanVanThiNoTotNghiep).Ten_he
                    row("Chuyen_nganh") = CType(arrDanhSachLuanVan(i), DanhSachLuanVanThiNoTotNghiep).Chuyen_nganh
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function

        Function Load_DanhSach_ThiTotNghiep(ByVal Lan_xet As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon2", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv2", GetType(String))
            dt.Columns.Add("Noi_sinh2", GetType(String))
            dt.Columns.Add("Ho_ten2", GetType(String))
            dt.Columns.Add("Ngay_sinh2", GetType(Date))
            dt.Columns.Add("Ten_lop2", GetType(String))
            dt.Columns.Add("TBCHT2", GetType(Double))
            dt.Columns.Add("ID_xep_loai", GetType(Integer))
            dt.Columns.Add("Xep_hang2", GetType(String))
            dt.Columns.Add("Khoa_hoc2", GetType(String))
            dt.Columns.Add("Chuyen_nganh2", GetType(String))
            dt.Columns.Add("Ten_he2", GetType(String))

            For i As Integer = 0 To arrDanhSachThiTotNghiep.Count - 1
                If CType(arrDanhSachThiTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Lan_xet = Lan_xet Then
                    Dim row As DataRow = dt.NewRow()
                    row("Chon2") = False
                    row("ID_sv") = CType(arrDanhSachThiTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).ID_sv
                    row("Ma_sv2") = CType(arrDanhSachThiTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Ma_sv
                    row("Ho_ten2") = CType(arrDanhSachThiTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Ho_ten
                    row("Ngay_sinh2") = CType(arrDanhSachThiTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Ngay_sinh
                    row("Ten_lop2") = CType(arrDanhSachThiTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Ten_lop
                    row("TBCHT2") = CType(arrDanhSachThiTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).TBCHT
                    row("ID_xep_loai") = CType(arrDanhSachThiTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).ID_xep_loai
                    row("Xep_hang2") = CType(arrDanhSachThiTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Xep_hang
                    row("Noi_sinh2") = CType(arrDanhSachThiTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Noi_sinh
                    row("Khoa_hoc2") = CType(arrDanhSachThiTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Khoa_hoc
                    row("Ten_he2") = CType(arrDanhSachThiTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Ten_he
                    row("Chuyen_nganh2") = CType(arrDanhSachThiTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Chuyen_nganh
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function

        Function Load_DanhSach_NoTotNghiep() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv3", GetType(String))
            dt.Columns.Add("Ho_ten3", GetType(String))
            dt.Columns.Add("Ngay_sinh3", GetType(Date))
            dt.Columns.Add("Ten_lop3", GetType(String))
            dt.Columns.Add("TBCHT3", GetType(Double))
            dt.Columns.Add("ID_xep_loai", GetType(Integer))
            dt.Columns.Add("Xep_hang3", GetType(String))
            dt.Columns.Add("Ly_do", GetType(String))
            dt.Columns.Add("So_mon_no", GetType(String))
            dt.Columns.Add("Noi_sinh3", GetType(String))
            dt.Columns.Add("Khoa_hoc3", GetType(String))
            dt.Columns.Add("Chuyen_nganh3", GetType(String))
            dt.Columns.Add("Ten_he3", GetType(String))
            Dim SQL As String
            Dim clsDM As New DanhMuc_BLL

            For i As Integer = 0 To arrDanhSachNoTotNghiep.Count - 1
                If CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Trang_thai_hoc = 1 Then
                    If CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Ma_sv = "T13OTO009" Then
                        CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Ma_sv = ""
                    End If
                    SQL = "SELECT Count(*) AS So_BGhi FROM STU_DANHSACH WHERE Trang_thai=0 AND ID_SV=" & CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).ID_sv
                    Dim dt_check As DataTable = clsDM.LoadDanhMuc(SQL)
                    If dt_check.Rows(0)("So_BGhi") > 0 Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_sv") = CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).ID_sv
                        row("Ma_sv3") = CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Ma_sv
                        row("Ho_ten3") = CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Ho_ten
                        row("Ngay_sinh3") = CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Ngay_sinh
                        row("Ten_lop3") = CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Ten_lop
                        row("TBCHT3") = CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).TBCHT
                        row("ID_xep_loai") = CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).ID_xep_loai
                        row("Xep_hang3") = CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Xep_hang
                        row("Ly_do") = CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Ly_do
                        row("So_mon_no") = CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).So_mon_no
                        row("Chuyen_nganh3") = CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Chuyen_nganh
                        row("Noi_sinh3") = CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Noi_sinh
                        If CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Khoa_hoc.ToString <> "" Then
                            row("Khoa_hoc3") = CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Khoa_hoc
                        End If
                        If CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Ten_he.ToString <> "" Then
                            row("Ten_he3") = CType(arrDanhSachNoTotNghiep(i), DanhSachLuanVanThiNoTotNghiep).Ten_he
                        End If


                        dt.Rows.Add(row)
                    End If
                End If
            Next
            Return dt
        End Function

        Public Sub XetLuanVan(ByVal ID_he As Integer, ByVal TBCHT As Double, ByVal Lan_xet As Integer, ByRef dt_LuanVan As DataTable, ByRef dt_thiTN As DataTable, ByRef dt_NoThiTN As DataTable)
            Dim clsDiem As Diem_BLL
            clsDiem = New Diem_BLL(ID_he, mID_dv, mID_bomon, 0, "", mdsID_lop, mID_dt, mdtDanhSachSinhVien)
            'Chi co quy che 25 moi co xet lam luan van, cac qu yche khac chi xet duoc thi tot nghiep nen de gia tri diem >10 de ko co sv lam TV
            dt_LuanVan = clsDiem.XetLuanVan(TBCHT)
            Dim dt_tonghop As DataTable = clsDiem.TongHop_XetThiNoThiTotNghiep()
            XetThi_NoThiTotNghiep(dt_LuanVan, dt_tonghop, dt_thiTN, dt_NoThiTN)
            InsertLuanVan(dt_LuanVan, Lan_xet)
            InsertThiTotNghiep(dt_thiTN, Lan_xet)
            InsertNoThiTotNghiep(dt_NoThiTN)
        End Sub
        Private Sub XetThi_NoThiTotNghiep(ByVal dt_LuanVan As DataTable, ByVal dt_tonghop As DataTable, ByRef dt_thiTN As DataTable, ByRef dt_NoThiTN As DataTable)
            Dim dt_Thi, dt_NoThi As New DataTable
            Dim dt As DataTable = dt_tonghop
            'dt_LuuDiemKy.DefaultView.Count - 1
            'Khoi tao danh sach sinh vien phai Thi tot nghiep
            dt_Thi.Columns.Add("Chon2", GetType(Boolean))
            dt_Thi.Columns.Add("ID_SV", GetType(Integer))
            dt_Thi.Columns.Add("Ho_ten2", GetType(String))
            dt_Thi.Columns.Add("Ngay_sinh2", GetType(Date))
            dt_Thi.Columns.Add("Ten_lop2", GetType(String))
            dt_Thi.Columns.Add("TBCHT2", GetType(Double))
            dt_Thi.Columns.Add("ID_xep_loai2", GetType(Integer))
            dt_Thi.Columns.Add("Xep_hang2", GetType(String))
            dt_Thi.Columns.Add("So_hoc_trinh2", GetType(Integer))


            'Khoi tao danh sach sinh vien phai No thi tot nghiep
            dt_NoThi.Columns.Add("Chon3", GetType(Boolean))
            dt_NoThi.Columns.Add("ID_SV", GetType(Integer))
            dt_NoThi.Columns.Add("Ho_ten3", GetType(String))
            dt_NoThi.Columns.Add("Ngay_sinh3", GetType(Date))
            dt_NoThi.Columns.Add("Ten_lop3", GetType(String))
            dt_NoThi.Columns.Add("TBCHT3", GetType(Double))
            dt_NoThi.Columns.Add("Ly_do", GetType(String))
            dt_NoThi.Columns.Add("So_mon_no", GetType(Integer))
            dt_NoThi.Columns.Add("So_hoc_trinh3", GetType(Integer))
            dt_NoThi.Columns.Add("ID_xep_loai3", GetType(Integer))
            dt_NoThi.Columns.Add("Xep_hang3", GetType(String))



            Dim dr As DataRow

            For i As Integer = 0 To dt.Rows.Count - 1
                dt_LuanVan.DefaultView.Sort = "ID_SV"
                If dt_LuanVan.DefaultView.Find(dt.Rows(i).Item("ID_SV")) < 0 Then
                    If dt.Rows(i).Item("Ly_do").ToString.Trim = "" Then 'Thi tot nghiep
                        'Tao dt danh sach sinh vien phai thi tot nghiep
                        dr = dt_Thi.NewRow
                        dr("Chon2") = False
                        dr("ID_SV") = dt.Rows(i).Item("ID_SV")
                        dr("Ho_ten2") = dt.Rows(i).Item("Ho_ten")
                        dr("Ngay_sinh2") = dt.Rows(i).Item("Ngay_sinh")
                        dr("Ten_lop2") = dt.Rows(i).Item("Ten_lop")
                        dr("TBCHT2") = dt.Rows(i).Item("TBCHT")
                        dr("ID_xep_loai2") = dt.Rows(i).Item("ID_xep_loai")
                        dr("Xep_hang2") = dt.Rows(i).Item("Xep_hang")
                        dr("So_hoc_trinh2") = dt.Rows(i).Item("So_hoc_trinh")
                        dt_Thi.Rows.Add(dr)

                        'Insert vao bang Thi tot nghiep; xoa sv nay ben No thi TN

                    Else 'No thi tot nghiep
                        'Tao dt danh sach sinh vien No thi tot nghiep kem Ly do
                        dr = dt_NoThi.NewRow
                        dr("Chon3") = False
                        dr("ID_SV") = dt.Rows(i).Item("ID_SV")
                        dr("Ho_ten3") = dt.Rows(i).Item("Ho_ten")
                        dr("Ngay_sinh3") = dt.Rows(i).Item("Ngay_sinh")
                        dr("Ten_lop3") = dt.Rows(i).Item("Ten_lop")
                        dr("TBCHT3") = dt.Rows(i).Item("TBCHT")
                        dr("ID_xep_loai3") = dt.Rows(i).Item("ID_xep_loai")
                        dr("Xep_hang3") = dt.Rows(i).Item("Xep_hang")
                        dr("Ly_do") = dt.Rows(i).Item("Ly_do")
                        dr("So_mon_no") = dt.Rows(i).Item("So_mon_no")
                        dr("So_hoc_trinh3") = dt.Rows(i).Item("So_hoc_trinh")
                        dt_NoThi.Rows.Add(dr)

                        'Insert vao bang No thi tot nghiep; xoa sv nay ben Thi TN
                    End If
                End If
            Next
            dt_thiTN = dt_Thi
            dt_NoThiTN = dt_NoThi
        End Sub

        Private Sub InsertLuanVan(ByVal dt As DataTable, ByVal Lan_xet As Integer)
            For i As Integer = 0 To dt.DefaultView.Count - 1
                Delete_DanhSachLuanVan(dt.DefaultView.Item(i)("ID_SV"), Lan_xet)

                Dim obj As New DanhSachLuanVanThiNoTotNghiep
                obj.ID_sv = dt.DefaultView.Item(i)("ID_SV")
                obj.Lan_xet = Lan_xet
                obj.TBCHT = IIf(IsDBNull(dt.DefaultView.Item(i)("TBCHT")), 0, dt.DefaultView.Item(i)("TBCHT"))
                obj.ID_xep_loai = IIf(IsDBNull(dt.DefaultView.Item(i)("ID_xep_loai")), 0, dt.DefaultView.Item(i)("ID_xep_loai"))
                Insert_DanhSachLuanVan(obj)
            Next
        End Sub
        Private Sub InsertThiTotNghiep(ByVal dt As DataTable, ByVal Lan_xet As Integer)
            For i As Integer = 0 To dt.DefaultView.Count - 1
                Delete_DanhSachThiTotNghiep(dt.DefaultView.Item(i)("ID_SV"), Lan_xet)

                Dim obj As New DanhSachLuanVanThiNoTotNghiep
                obj.ID_sv = dt.DefaultView.Item(i)("ID_SV")
                obj.Lan_xet = Lan_xet
                obj.TBCHT = IIf(IsDBNull(dt.DefaultView.Item(i)("TBCHT2")), 0, dt.DefaultView.Item(i)("TBCHT2"))
                obj.ID_xep_loai = IIf(IsDBNull(dt.DefaultView.Item(i)("ID_xep_loai2")), 0, dt.DefaultView.Item(i)("ID_xep_loai2"))
                Insert_DanhSachThiTotNghiep(obj)
            Next
        End Sub
        Private Sub InsertNoThiTotNghiep(ByVal dt As DataTable)
            For i As Integer = 0 To dt.DefaultView.Count - 1
                Delete_DanhSachNoTotNghiep(dt.DefaultView.Item(i)("ID_SV"))

                Dim obj As New DanhSachLuanVanThiNoTotNghiep
                obj.ID_sv = dt.DefaultView.Item(i)("ID_SV")
                obj.TBCHT = IIf(IsDBNull(dt.DefaultView.Item(i)("TBCHT3")), 0, dt.DefaultView.Item(i)("TBCHT3"))
                obj.ID_xep_loai = IIf(IsDBNull(dt.DefaultView.Item(i)("ID_xep_loai3")), 0, dt.DefaultView.Item(i)("ID_xep_loai3"))
                obj.Ly_do = dt.DefaultView.Item(i)("Ly_do")
                obj.So_mon_no = dt.DefaultView.Item(i)("So_mon_no")
                Insert_DanhSachNoTotNghiep(obj)
            Next
        End Sub

        Public Sub ChuyenThiTotNghiep(ByVal dv As DataView, ByVal Lan_xet As Integer)
            For i As Integer = 0 To dv.Count - 1
                If dv.Item(i)("Chon1") = True Then
                    Delete_DanhSachLuanVan(dv.Item(i)("ID_SV"), Lan_xet)
                    Dim obj As New DanhSachLuanVanThiNoTotNghiep
                    obj.ID_sv = dv.Item(i)("ID_SV")
                    obj.Lan_xet = Lan_xet
                    obj.TBCHT = IIf(IsDBNull(dv.Item(i)("TBCHT")), 0, dv.Item(i)("TBCHT"))
                    obj.ID_xep_loai = IIf(IsDBNull(dv.Item(i)("ID_xep_loai")), 0, dv.Item(i)("ID_xep_loai"))
                    Insert_DanhSachThiTotNghiep(obj)
                End If
            Next
        End Sub
        Public Sub ChuyenLamLuanVan(ByVal dv As DataView, ByVal Lan_xet As Integer)
            For i As Integer = 0 To dv.Count - 1
                If dv.Item(i)("Chon2") = True Then
                    Delete_DanhSachThiTotNghiep(dv.Item(i)("ID_SV"), Lan_xet)
                    Dim obj As New DanhSachLuanVanThiNoTotNghiep
                    obj.ID_sv = dv.Item(i)("ID_SV")
                    obj.Lan_xet = Lan_xet
                    obj.TBCHT = IIf(IsDBNull(dv.Item(i)("TBCHT2")), 0, dv.Item(i)("TBCHT2"))
                    obj.ID_xep_loai = IIf(IsDBNull(dv.Item(i)("ID_xep_loai")), 0, dv.Item(i)("ID_xep_loai"))
                    Insert_DanhSachLuanVan(obj)
                End If
            Next
        End Sub

        Private Function Insert_DanhSachLuanVan(ByVal objDanhSachLuanVanThiNoTotNghiep As DanhSachLuanVanThiNoTotNghiep) As Integer
            Try
                Dim obj As DanhSachLuanVanThiNoTotNghiep_DAL = New DanhSachLuanVanThiNoTotNghiep_DAL
                Return obj.Insert_DanhSachLuanVan(objDanhSachLuanVanThiNoTotNghiep)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Delete_DanhSachLuanVan(ByVal ID_sv As Integer, ByVal Lan_xet As Integer) As Integer
            Try
                Dim obj As DanhSachLuanVanThiNoTotNghiep_DAL = New DanhSachLuanVanThiNoTotNghiep_DAL
                Return obj.Delete_DanhSachLuanVan(ID_sv, Lan_xet)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Insert_DanhSachThiTotNghiep(ByVal objDanhSachLuanVanThiNoTotNghiep As DanhSachLuanVanThiNoTotNghiep) As Integer
            Try
                Dim obj As DanhSachLuanVanThiNoTotNghiep_DAL = New DanhSachLuanVanThiNoTotNghiep_DAL
                Return obj.Insert_DanhSachThiTotNghiep(objDanhSachLuanVanThiNoTotNghiep)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Delete_DanhSachThiTotNghiep(ByVal ID_sv As Integer, ByVal Lan_xet As Integer) As Integer
            Try
                Dim obj As DanhSachLuanVanThiNoTotNghiep_DAL = New DanhSachLuanVanThiNoTotNghiep_DAL
                Return obj.Delete_DanhSachThiTotNghiep(ID_sv, Lan_xet)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Insert_DanhSachNoTotNghiep(ByVal objDanhSachLuanVanThiNoTotNghiep As DanhSachLuanVanThiNoTotNghiep) As Integer
            Try
                Dim obj As DanhSachLuanVanThiNoTotNghiep_DAL = New DanhSachLuanVanThiNoTotNghiep_DAL
                Return obj.Insert_DanhSachNoTotNghiep(objDanhSachLuanVanThiNoTotNghiep)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Delete_DanhSachNoTotNghiep(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachLuanVanThiNoTotNghiep_DAL = New DanhSachLuanVanThiNoTotNghiep_DAL
                Return obj.Delete_DanhSachNoTotNghiep(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Converting(ByVal drDanhSachLuanVan As DataRow) As DanhSachLuanVanThiNoTotNghiep
            Dim result As DanhSachLuanVanThiNoTotNghiep
            Try
                result = New DanhSachLuanVanThiNoTotNghiep
                result.Lan_xet = CType(drDanhSachLuanVan("Lan_xet").ToString(), Integer)
                If drDanhSachLuanVan("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachLuanVan("ID_sv").ToString(), Integer)
                If drDanhSachLuanVan("TBCHT").ToString() <> "" Then result.TBCHT = CType(drDanhSachLuanVan("TBCHT").ToString(), Double)
                If drDanhSachLuanVan("ID_xep_loai").ToString() <> "" Then result.ID_xep_loai = CType(drDanhSachLuanVan("ID_xep_loai").ToString(), Integer)
                result.Ma_sv = drDanhSachLuanVan("Ma_sv").ToString()
                result.Ho_ten = drDanhSachLuanVan("Ho_ten").ToString()
                result.Noi_sinh = drDanhSachLuanVan("Noi_sinh").ToString()
                result.Ten_lop = drDanhSachLuanVan("Ten_lop").ToString()
                If drDanhSachLuanVan("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSachLuanVan("Ngay_sinh").ToString(), Date)
                result.Xep_hang = drDanhSachLuanVan("Xep_hang").ToString()
                result.Chuyen_nganh = drDanhSachLuanVan("Chuyen_nganh").ToString()
                result.Khoa_hoc = drDanhSachLuanVan("Khoa_hoc").ToString()
                result.Ten_he = drDanhSachLuanVan("Ten_he").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Private Function ConvertingNoTotNghiep(ByVal drDanhSachLuanVan As DataRow) As DanhSachLuanVanThiNoTotNghiep
            Dim result As DanhSachLuanVanThiNoTotNghiep
            Try
                result = New DanhSachLuanVanThiNoTotNghiep
                If drDanhSachLuanVan("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachLuanVan("ID_sv").ToString(), Integer)
                If drDanhSachLuanVan("TBCHT").ToString() <> "" Then result.TBCHT = CType(drDanhSachLuanVan("TBCHT").ToString(), Double)
                If drDanhSachLuanVan("ID_xep_loai").ToString() <> "" Then result.ID_xep_loai = CType(drDanhSachLuanVan("ID_xep_loai").ToString(), Integer)
                result.Ma_sv = drDanhSachLuanVan("Ma_sv").ToString()
                result.Ho_ten = drDanhSachLuanVan("Ho_ten").ToString()
                result.Ten_lop = drDanhSachLuanVan("Ten_lop").ToString()
                If drDanhSachLuanVan("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSachLuanVan("Ngay_sinh").ToString(), Date)
                result.Ly_do = drDanhSachLuanVan("Ly_do").ToString()
                result.So_mon_no = drDanhSachLuanVan("So_mon_no").ToString()
                result.Xep_hang = drDanhSachLuanVan("Xep_hang").ToString()
                result.Noi_sinh = drDanhSachLuanVan("Noi_sinh").ToString()
                result.Chuyen_nganh = drDanhSachLuanVan("Chuyen_nganh").ToString()
                result.Khoa_hoc = drDanhSachLuanVan("Khoa_hoc").ToString()
                result.Ten_he = drDanhSachLuanVan("Ten_he").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
