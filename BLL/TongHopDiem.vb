''---------------------------------------------------------------------------
'' Author : Nguyễn Khánh Tùng
'' Company : Thiên An ESS
'' Created Date : Sunday, May 04, 2008
''---------------------------------------------------------------------------
'Imports System
'Imports System.Data
'Imports System.Data.SqlClient
'Imports ESS.Entity.Entity
'Imports ESS.DAL.DBManager
'Namespace Business
'    Public Class TongHopDiem_BLL
'        Private mDiem As Diem_BLL
'        Private mdtDanhSachSinhVien As DataTable
'        Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lops As String, ByVal dtDanhSachSinhVien As DataTable)
'            mdtDanhSachSinhVien = dtDanhSachSinhVien
'            Dim dtMonHoc As New DataTable
'            'Load diem sinh vien
'            mDiem = New Diem_BLL(mdtDanhSachSinhVien)
'            'Load cac mon hoc
'        End Sub
'        Function TongHopHocKy(ByVal Lan_thi As Byte) As DataTable
'            Dim dtTongHop As New DataTable
'            Dim idx_diem As Integer = -1, ID_mon As Integer
'            Dim DiemShow As String = "", DiemTBMH As Double
'            Dim dr As DataRow
'            Dim Tong_diem As Double = 0, Tong_so_hoc_trinh As Integer = 0
'            dtTongHop = mdtDanhSachSinhVien.Copy
'            'Add cac cot diem cua cac mon hoc
'            For i As Integer = 0 To mCTDT.Count - 1
'                dtTongHop.Columns.Add(mCTDT.ChuongTrinhDaoTaoChiTiet(i).ID_mon)
'            Next
'            'Gan cac diem chi tiet tung mon hoc cua sinh vien va tinh diem TBCHT, Xep Loai
'            For Each dr In dtTongHop.Rows
'                'Duyet cac mon hoc
'                For i As Integer = 0 To mCTDT.Count - 1
'                    ID_mon = mCTDT.ChuongTrinhDaoTaoChiTiet(i).ID_mon
'                    'Tim diem cua sinh vien nay
'                    idx_diem = mDiem.Tim_idx(dr("ID_sv"), ID_mon)
'                    If idx_diem >= 0 Then
'                        Dim diem As Diem = mDiem.Diem(idx_diem)
'                        'Tính điểm TBCMH
'                        If Lan_thi = 1 Then
'                            DiemTBMH = TinhDiemTBMH(diem.dsDiemThi.Diem_thi_lan(1), diem.dsDiemThanhPhan)
'                        Else
'                            DiemTBMH = TinhDiemTBMH(diem.dsDiemThi.Diem_thi_max, diem.dsDiemThanhPhan)
'                        End If
'                        'Điểm hiển thị
'                        DiemShow = DiemHienThi(mDiem.Diem(idx_diem))

'                        dr(mCTDT.ChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString) = DiemShow
'                    End If
'                Next
'            Next
'            Return dtTongHop
'        End Function

'        'Hàm này để tính điểm TBCMH
'        Private Function TinhDiemTBMH(ByVal Diem_thi As Double, ByVal diemTP As DiemThanhPhan) As Double
'            Dim DiemTBMH As Double = 0, Tong_ty_le As Byte = 0, Tong_diemTP As Byte = 0
'            For i As Byte = 0 To diemTP.Count - 1
'                Tong_ty_le += diemTP.DiemThanhPhan(i).Ty_le
'                Tong_diemTP += diemTP.DiemThanhPhan(i).Diem * diemTP.DiemThanhPhan(i).Ty_le
'            Next
'            DiemTBMH = (Tong_diemTP + (100 - Tong_ty_le) * Diem_thi) / 100

'            'Lam tron diem TBCMH
'            DiemTBMH = Math.Round(DiemTBMH, gLam_tron_TBCMH)

'            Return DiemTBMH
'        End Function

'        Private Function DiemHienThi(ByVal diem As Diem) As String
'            Dim Diem_hien_thi As String = ""
'            For Lan_thi As Integer = 0 To diem.dsDiemThi.Count - 1
'                Diem_hien_thi += TinhDiemTBMH(diem.dsDiemThi.Diem_thi_lan(Lan_thi), diem.dsDiemThanhPhan) + "-"
'            Next
'            If Diem_hien_thi <> "" Then Diem_hien_thi = Left(Diem_hien_thi, Len(Diem_hien_thi) - 1)
'            Return Diem_hien_thi
'        End Function
'    End Class
'End Namespace