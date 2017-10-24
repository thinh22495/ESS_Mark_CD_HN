Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ThienAn.Entity.Entity
Imports ThienAn.DAL.DBManager
Imports ThienAn.Machine
Namespace Business
    Public Class GoiNhapHoc_DN_BLL
        Public Sub New()
        End Sub

        Function In_danh_sach_nhap_hoc(ByVal Khoi_thi As String, ByVal Nganh_thi As String, ByVal Dang_ky As Boolean, ByVal Ngay_nhap_hoc As String) As DataTable
            Dim strSQL As String
            Dim dt As DataTable
            strSQL = "SELECT hs.UserID_tiep_nhan,blm.nam_hoc,hs.ID_sv, hs.SBD, hs.Ho_ten, hs.Ngay_sinh, '' AS Giay_to_thieu, SUM(bls.So_tien) AS So_tien_thu, UserName, convert(char(11),Ngay_nhap_hoc) AS Ngay_nhap_hoc " _
                        + "FROM svBienLaiThuMain blm INNER JOIN " _
                                + "svBienLaiThuSub bls ON blm.ID_bien_lai = bls.ID_bien_lai INNER JOIN " _
                                + "svHoSo hs ON blm.ID_sv = hs.ID_sv LEFT OUTER JOIN " _
                                + "htUsers u ON hs.UserID_tiep_nhan=u.UserID " _
                        + "WHERE DANG_KY_HOC=1 "

            'Khong thuoc danh sach sinh vien da phan lop
            strSQL += " AND (hs.ID_sv NOT IN  (SELECT ID_sv FROM svDanhSach))"
            'Khong thuoc danh sach sinh vien da ngung hoc
            strSQL += " AND (hs.ID_sv NOT IN  (SELECT ID_sv FROM svDanhSachNgunghoc))"
            If Khoi_thi <> "" Then strSQL += " AND Khoi_thi=N'" + Khoi_thi + "'"
            If Nganh_thi <> "" Then strSQL += " AND Nganh_thi=N'" + Nganh_thi + "'"

            'Group by
            strSQL += " GROUP BY hs.UserID_tiep_nhan,blm.nam_hoc,hs.ID_sv, hs.SBD, hs.Ho_ten, hs.Ngay_sinh, UserName, Ngay_nhap_hoc "

            dt = UDB.SelectTable(strSQL)
            'Update giay to con thieu
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("Giay_to_thieu") = getGiay_to_thieu(dt.Rows(i)("ID_sv"))
            Next
            Return dt
        End Function

        Private Function getGiay_to_thieu(ByVal ID_sv As Integer) As String
            Dim strSQL As String
            Dim dt As DataTable
            Dim strGiay_to_thieu As String = ""
            strSQL = "SELECT nop.ID_giay_to, loai.Ten_giay_to " _
                        + "FROM svHoSoYeucau yc LEFT OUTER JOIN " _
                                    + "svLoaiGiayTo loai ON yc.ID_giay_to = loai.ID_giay_to LEFT OUTER JOIN " _
                                    + "svHoSoNop nop ON yc.ID_giay_to = nop.ID_giay_to AND nop.ID_sv = " + ID_sv.ToString
            dt = UDB.SelectTable(strSQL)
            For i As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(i)("ID_giay_to").ToString = "" Then
                    strGiay_to_thieu += dt.Rows(i)("Ten_giay_to").ToString + ","
                End If
            Next
            If strGiay_to_thieu <> "" Then strGiay_to_thieu = Left(strGiay_to_thieu, Len(strGiay_to_thieu) - 1)
            Return strGiay_to_thieu
        End Function


        Function Load_danh_sach_nhap_hoc(ByVal SBD As String, ByVal Ho_ten As String, ByVal Khoi_thi As String, ByVal Nganh_thi As String, ByVal Dang_ky As Boolean, ByVal Ngay_nhap_hoc As String, ByVal ID_lop As Integer, ByVal All_SinhVien As Boolean, ByVal Khoa_hoc As Integer) As DataTable
            Dim strSQL As String
            strSQL = "SELECT hs.Dang_ky_hoc,l.Ten_lop, hs.ID_sv, hs.SBD, hs.Ho_ten, hs.Ngay_sinh, gt.Gioi_tinh, hs.Khoi_thi, hs.Chuyen_nganh, hs.Tong_diem, UserName, Ngay_nhap_hoc " _
                + "FROM svHoSo hs LEFT OUTER JOIN " _
                + "svGioiTinh gt ON hs.ID_gioi_tinh = gt.ID_gioi_tinh LEFT OUTER JOIN " _
                + "htUsers u ON hs.UserID_tiep_nhan=u.UserID LEFT JOIN " _
                + "svDanhSach ds ON hs.ID_SV=ds.ID_sv LEFT JOIN " _
                + "svLop l ON ds.ID_lop=l.ID_lop " _
                + "WHERE DANG_KY_HOC=" + IIf(Dang_ky, 1, 0).ToString
            'Khong thuoc danh sach sinh vien da phan lop
            If Dang_ky = False Then strSQL += " AND (hs.ID_sv NOT IN  (SELECT ID_sv FROM svDanhSach))"
            If Dang_ky AndAlso ID_lop > 0 Then strSQL += " AND (hs.ID_sv IN  (SELECT ID_sv FROM svDanhSach WHERE ID_lop=" & ID_lop & "))"
            If Dang_ky AndAlso Khoa_hoc > 0 Then strSQL += " AND (hs.ID_sv IN  (SELECT ID_sv FROM svDanhSach a INNER JOIN svLop b ON a.ID_lop=b.ID_lop WHERE Khoa_hoc=" & Khoa_hoc & "))"
            'Khong thuoc danh sach sinh vien da ngung hoc
            strSQL += " AND (hs.ID_sv NOT IN  (SELECT ID_sv FROM svDanhSachNgunghoc))"
            'Loc theo cac dieu kien nhap vao
            If SBD <> "" Then strSQL += " AND SBD Like N'%" + SBD + "%'"
            If Ho_ten <> "" Then strSQL += " AND Ho_ten Like N'%" + Ho_ten + "%'"
            If Khoi_thi <> "" Then strSQL += " AND Khoi_thi Like N'%" + Khoi_thi + "%'"
            If Nganh_thi <> "" Then strSQL += " AND Chuyen_nganh Like N'%" + Nganh_thi + "%'"
            'If UserID_tiep_nhan > 0 And Dang_ky Then strSQL += " AND UserID_tiep_nhan=" + UserID_tiep_nhan.ToString
            'Order by theo SBD
            strSQL += " ORDER BY SBD"
            Return UDB.SelectTable(strSQL)
        End Function

        Function Load_danh_sach_Da_nhap_hoc(ByVal Khoa_hoc As Integer, ByVal ID_lop As Integer) As DataTable
            Dim strSQL As String
            strSQL = "SELECT hs.Dang_ky_hoc,l.Ten_lop, hs.ID_sv, hs.SBD, hs.Ho_ten, hs.Ngay_sinh, gt.Gioi_tinh, hs.Khoi_thi, hs.Chuyen_nganh, hs.Tong_diem, UserName, Ngay_nhap_hoc " _
                + "FROM svHoSo hs LEFT OUTER JOIN " _
                + "svGioiTinh gt ON hs.ID_gioi_tinh = gt.ID_gioi_tinh LEFT OUTER JOIN " _
                + "htUsers u ON hs.UserID_tiep_nhan=u.UserID LEFT JOIN " _
                + "svDanhSach ds ON hs.ID_SV=ds.ID_sv LEFT JOIN " _
                + "svLop l ON ds.ID_lop=l.ID_lop " _
                + "WHERE DANG_KY_HOC=1 AND Khoa_hoc=" & Khoa_hoc & " AND ds.ID_lop=" & ID_lop
            strSQL += " AND (hs.ID_sv NOT IN  (SELECT ID_sv FROM svDanhSachNgunghoc))"
            strSQL += " ORDER BY SBD"
            Return UDB.SelectTable(strSQL)
        End Function
        Function Giay_to_yeu_cau_nop() As DataTable
            Dim strSQL As String
            Dim dt As DataTable
            strSQL = "SELECT b.ID_giay_to, b.Ma_giay_to, b.Ten_giay_to " _
                        + "FROM svHoSoYeucau a INNER JOIN " _
                        + "svLoaiGiayTo b ON a.ID_giay_to = b.ID_giay_to " _
                        + "ORDER BY b.Ma_giay_to "
            dt = UDB.SelectTable(strSQL)
            Dim dc1 As New DataColumn("Chon", GetType(Boolean))
            dc1.DefaultValue = False
            dt.Columns.Add(dc1)

            Dim dc2 As New DataColumn("Ghi_chu_nop", GetType(String))
            dt.Columns.Add(dc2)
            Return dt
        End Function

        Function Khoan_thu_phai_nop() As DataTable
            Dim strSQL As String
            Dim dt As DataTable
            strSQL = "SELECT ID_thu_chi, Ten_thu_chi, So_tien " _
                        + "FROM svLoaiThuChi " _
                        + "WHERE (Thu_chi = 1) AND (Theo_nien_khoa = 1) AND (Thu_bat_buoc = 1) "

            dt = UDB.SelectTable(strSQL)
            Dim dc1 As New DataColumn("Chon", GetType(Boolean))
            dc1.DefaultValue = False
            dt.Columns.Add(dc1)

            Return dt
        End Function

        Function Giay_to_da_nop(ByVal ID_sv As Integer) As DataTable
            Dim strSQL As String
            strSQL = "SELECT     ID_giay_to, Ghi_chu_nop  " _
                        + "FROM         svHoSoNop " _
                        + "WHERE     (ID_sv = " + ID_sv.ToString + ") "

            Return UDB.SelectTable(strSQL)
        End Function

        Function Khoan_thu_da_nop(ByVal ID_sv As Integer, ByVal Nam_hoc As String) As DataTable
            Dim strSQL As String
            strSQL = "SELECT bls.ID_thu_chi, bls.So_tien,bls.Noi_dung as Ten_thu_chi,blm.Nam_hoc " _
                        + "FROM svBienLaiThuSub bls INNER JOIN " _
                                    + "svBienLaiThuMain blm ON bls.ID_bien_lai = blm.ID_bien_lai " _
                        + "WHERE (blm.Hoc_ky = 1) AND (blm.Nam_hoc = N'" + Nam_hoc + "') AND (blm.ID_sv = " + ID_sv.ToString + ")"

            Return UDB.SelectTable(strSQL)
        End Function

        Sub Update_dang_ky_hoc(ByVal ID_sv As Integer, ByVal Ngay_nhap_hoc As String)
            Dim strSQL As String
            strSQL = "UPDATE svHoSo SET Dang_ky_hoc=1, UserID_tiep_nhan=" + gUserID.ToString + ", Ngay_nhap_hoc=" & SQLDate(Ngay_nhap_hoc) & " " _
                            + "WHERE ID_sv=" + ID_sv.ToString
            UDB.SelectTable(strSQL)
        End Sub

        Function CheckID_SV(ByVal ID_SV As Integer) As Boolean
            CheckID_SV = False
            Dim SQL As String = "SELECT ID_sv FROM svDanhSach WHERE ID_SV=" & ID_SV
            Dim dt As DataTable = UDB.SelectTable(SQL)
            If dt.Rows.Count > 0 Then Return True
        End Function

        Sub Update_Lop_hoc(ByVal ID_sv As Integer, ByVal ID_lop As Integer)
            Dim strSQL As String
            strSQL = "UPDATE svDanhSach SET ID_lop=" & ID_lop & " WHERE ID_sv=" & ID_sv
            UDB.SelectTable(strSQL)
        End Sub

        Sub Insert_Lop_hoc(ByVal ID_sv As Integer, ByVal ID_lop As Integer)
            Dim strSQL As String
            strSQL = "DELETE svDanhSach WHERE ID_sv=" & ID_sv
            UDB.SelectTable(strSQL)

            strSQL = "INSERT INTO svDanhSach (ID_SV,ID_lop) VALUES (" & ID_sv & "," & ID_lop & " )"
            UDB.SelectTable(strSQL)
        End Sub
        Sub Update_giay_to(ByVal ID_sv As Integer, ByVal dtGiay_to As DataView)
            Dim cls As New clsNop_giay_to
            For i As Integer = 0 To dtGiay_to.Count - 1
                With dtGiay_to.Item(i)
                    If .Item("Chon") Then
                        If cls.CheckExist_giayto_nop(ID_sv, .Item("ID_giay_to")) Then
                            cls.Update(ID_sv, .Item("ID_giay_to"), .Item("Ghi_chu_nop").ToString)
                        Else
                            cls.Insert(ID_sv, .Item("ID_giay_to"), .Item("Ghi_chu_nop").ToString)
                        End If
                    Else
                        cls.Delete(ID_sv, .Item("ID_giay_to"))
                    End If
                End With
            Next
        End Sub

        Sub Huy_dang_ky(ByVal ID_sv As Integer, ByVal Nam_hoc As String, ByVal dtGiay_to As DataView)
            Dim strSQL As String
            'Xoa giay to nhap truong
            Dim cls As New clsNop_giay_to
            For i As Integer = 0 To dtGiay_to.Count - 1
                With dtGiay_to.Item(i)
                    If .Item("Chon") Then
                        cls.Delete(ID_sv, .Item("ID_giay_to"))
                    End If
                End With
            Next
            'Xoa svDanhSach
            strSQL = "DELETE svDanhSach WHERE ID_sv=" & ID_sv
            UDB.Execute(strSQL)

            'Xoa khoan nop
            'Xoa svBienLaiThuSub
            strSQL = "DELETE svBienLaiThuSub WHERE ID_bien_lai IN( " _
                                        + "SELECT ID_bien_lai FROM svBienLaiThuMain " _
                                        + "WHERE Hoc_ky=1 AND Nam_hoc='" + Nam_hoc + "' AND ID_sv=" + ID_sv.ToString & ")"
            UDB.Execute(strSQL)
            'Xoa svBienLaiThuMain
            strSQL = "DELETE FROM svBienLaiThuMain " _
                        + "WHERE Hoc_ky=1 AND Nam_hoc='" + Nam_hoc + "' AND ID_sv=" + ID_sv.ToString
            UDB.Execute(strSQL)
            'Update trang thai dang ky nhap hoc la 0
            If DbType = mdlUnisoft.DatabaseType.SQLServer Then
                strSQL = "UPDATE svHoSo SET Dang_ky_hoc=0, UserID_tiep_nhan=0, Ngay_nhap_hoc=Null " _
                            + "WHERE ID_sv=" + ID_sv.ToString
            Else
                strSQL = "UPDATE svHoSo SET Dang_ky_hoc=0, UserID_tiep_nhan=0, Ngay_nhap_hoc=Null " _
                            + "WHERE ID_sv=" + ID_sv.ToString
            End If
            UDB.SelectTable(strSQL)
        End Sub

        Sub Update_cac_khoan_nop(ByVal ID_sv As Integer, ByVal Nam_hoc As String, ByVal dtKhoan_nop As DataView)
            Dim cls As New clsBien_lai_mains
            Dim Tong_tien As Integer
            Dim bl_sub As New ArrayList
            For i As Integer = 0 To dtKhoan_nop.Count - 1
                With dtKhoan_nop.Item(i)
                    If .Item("Chon") Then
                        Dim info_sub As clsBien_lai_sub
                        info_sub = New clsBien_lai_sub
                        info_sub.ID_thu_chi = .Item("ID_thu_chi")
                        info_sub.Dot_thu = 1
                        info_sub.Lan_thu = 1
                        info_sub.Noi_dung = .Item("Ten_thu_chi")
                        info_sub.So_tien = .Item("So_tien")
                        bl_sub.Add(info_sub)
                        Tong_tien += .Item("So_tien")
                    End If
                End With
            Next
            cls.Bien_lai_mains.Bien_lai_subs = bl_sub
            If bl_sub.Count > 0 Then
                With cls.Bien_lai_mains
                    .Hoc_ky = 1
                    .Nam_hoc = Nam_hoc
                    .ID_sv = ID_sv
                    .So_phieu = 0
                    .Ngay_thu = Now()
                    .Noi_dung = "Thu lệ phí nhập học"
                    .Thu_chi = 1
                    .Ngoai_te = "VND"
                    .So_tien = Tong_tien
                    .So_tien_chu = ChuyenChu(Tong_tien)
                    .Nguoi_thu = gUserFullName
                    .Printed = 0
                End With
                Dim ID_bien_lai As Integer = Check_khoan_thu(ID_sv, Nam_hoc)
                If ID_bien_lai > 0 Then
                    cls.Save_bien_lai(ID_bien_lai)
                Else
                    cls.Save_bien_lai(0)
                End If
            End If
        End Sub

        Private Function Check_khoan_thu(ByVal ID_sv As Integer, ByVal Nam_hoc As String) As Integer
            Dim strSQL As String
            Dim dt As DataTable
            strSQL = "SELECT ID_bien_lai " _
                        + "FROM svBienLaiThuMain " _
                        + "WHERE (Hoc_ky = 1) AND (Nam_hoc = N'" + Nam_hoc + "') AND (ID_sv = " + ID_sv.ToString + ")"
            dt = UDB.SelectTable(strSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)("ID_bien_lai")
            Else
                Return 0
            End If
        End Function

        Function dt_GiaoVienInfor(ByVal ID_lop As Integer) As DataTable
            Dim SQL As String = "SELECT Ten_gv,Dien_thoai,Email,isnull(So_sv,0) as So_SV FROM svLop WHERE ID_lop=" & ID_lop
            Return UDB.SelectTable(SQL)
        End Function
    End Class
End Namespace