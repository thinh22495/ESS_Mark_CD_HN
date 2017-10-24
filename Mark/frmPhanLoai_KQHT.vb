Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Imports C1.Win.C1Report
Imports C1.Win.C1FlexGrid
Imports ESS_Reports
Public Class frmPhanLoai_KQHT
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private mdtDanhSachSinhVien As New DataTable
    Private clsDiem As New Diem_BLL

    Private Sub frmPhanLoai_KQHT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadComboBox()
    End Sub

    Private Sub frmPhanLoai_KQHT_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
            Dim clsDM As New DanhMuc_BLL
            Dim SQL As String = ""
            SQL = "SELECT DISTINCT Khoa_hoc,Khoa_hoc FROM STU_LOP ORDER BY Khoa_hoc"
            Dim dt As DataTable = clsDM.LoadDanhMuc(SQL)
            FillCombo(cmbKhoa_hoc, dt)
            SQL = "SELECT ID_khoa,Ten_khoa FROM STU_KHOA order by Ten_khoa"
            Dim dt_khoa As DataTable = clsDM.LoadDanhMuc(SQL)
            FillCombo(cmbID_khoa, dt_khoa)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnPrint1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint_KQHT_Khoa.Click

    End Sub

    Private Sub btnPrint__Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint_KQHT_Lop.Click
        Try
            Dim cls As New Diem_BLL
            Dim dt_SinhVien As DataTable
            Dim dt_diem As DataTable
            Dim dv_HocLai, dv_ThiLai As DataView
            ' Dim dt_xeploai As DataTable = cls.Load_XepLoaiHocTap
            Dim dt_lop As DataTable = cls.dt_DanhSachLop(cmbID_khoa.SelectedValue, cmbKhoa_hoc.SelectedValue)
            dt_lop.Columns.Add("So_sv_XS", GetType(Integer))
            dt_lop.Columns.Add("TyLe_XS", GetType(Double))
            dt_lop.Columns.Add("So_sv_Gioi", GetType(Integer))
            dt_lop.Columns.Add("TyLe_Gioi", GetType(Double))
            dt_lop.Columns.Add("So_sv_Kha", GetType(Integer))
            dt_lop.Columns.Add("TyLe_Kha", GetType(Double))
            dt_lop.Columns.Add("So_sv_TBKha", GetType(Integer))
            dt_lop.Columns.Add("TyLe_TBKha", GetType(Double))
            dt_lop.Columns.Add("So_sv_TB", GetType(Integer))
            dt_lop.Columns.Add("TyLe_TB", GetType(Double))
            dt_lop.Columns.Add("So_sv_Yeu", GetType(Integer))
            dt_lop.Columns.Add("TyLe_Yeu", GetType(Double))
            dt_lop.Columns.Add("So_sv_Kem", GetType(Integer))
            dt_lop.Columns.Add("TyLe_Kem", GetType(Double))
            dt_lop.Columns.Add("So_sv_KXL", GetType(Integer))
            dt_lop.Columns.Add("TyLe_KXL", GetType(Double))
            dt_lop.Columns.Add("So_sv_ThiLai", GetType(Integer))
            dt_lop.Columns.Add("TyLe_ThiLai", GetType(Double))
            dt_lop.Columns.Add("So_sv_HocBu", GetType(Integer))
            dt_lop.Columns.Add("TyLe_HocBu", GetType(Double))
            dt_lop.Columns.Add("So_sv_HocLai", GetType(Integer))
            dt_lop.Columns.Add("TyLe_HocLai", GetType(Double))
            For i As Integer = 0 To dt_lop.Rows.Count - 1
                Dim So_sv_XS As Integer = 0
                Dim So_sv_Gioi As Integer = 0
                Dim So_sv_Kha As Integer = 0
                Dim So_sv_TBKha As Integer = 0
                Dim So_sv_TB As Integer = 0
                Dim So_sv_Yeu As Integer = 0
                Dim So_sv_Kem As Integer = 0
                Dim So_sv_KXL As Integer = 0
                Dim So_sv_ThiLai As Integer = 0
                Dim So_sv_HocBu As Integer = 0
                Dim So_sv_HocLai As Integer = 0
                Dim TBCHP As Double = 0

                dt_SinhVien = cls.dt_DanhSachSinhVienLop(dt_lop.Rows(i)("ID_lop"))
                For j As Integer = 0 To dt_SinhVien.Rows.Count - 1 ' Duyet tung sinh vien
                    dt_diem = cls.dt_DanhSachDiemTheoSinhVien(dt_SinhVien.Rows(j)("ID_sv"), cmbHoc_ky.Text, cmbNam_hoc.Text)
                    If dt_diem.Rows.Count > 0 Then 'Kiem tra co diem va So hoc trinh <>0
                        If dt_diem.Rows(0)("So_hoc_trinh").ToString <> "" AndAlso dt_diem.Rows(0)("So_hoc_trinh") > 0 Then
                            TBCHP = dt_diem.Rows(0)("Tong_Diem") / dt_diem.Rows(0)("So_hoc_trinh")
                            If TBCHP >= 9 Then 'XS
                                So_sv_XS = So_sv_XS + 1
                            ElseIf TBCHP < 9 And TBCHP >= 8 Then 'Gioi
                                So_sv_Gioi = So_sv_Gioi + 1
                            ElseIf TBCHP < 8 And TBCHP >= 7 Then 'Kha
                                So_sv_Kha = So_sv_Kha + 1
                            ElseIf TBCHP < 7 And TBCHP >= 6 Then 'TB kha
                                So_sv_TBKha = So_sv_TBKha + 1
                            ElseIf TBCHP < 6 And TBCHP >= 5 Then 'TB 
                                So_sv_TB = So_sv_TB + 1
                            ElseIf TBCHP < 5 And TBCHP >= 4 Then 'Yeu
                                So_sv_Yeu = So_sv_Yeu + 1
                            Else 'Kem
                                So_sv_Kem = So_sv_Kem + 1
                            End If
                            'Else
                            '    So_sv_KXL = So_sv_KXL + 1
                        End If
                        'Else
                        '    So_sv_KXL = So_sv_KXL + 1
                    End If
                    dv_HocLai = cls.dt_DSHocLai(dt_SinhVien.Rows(j)("ID_sv"), cmbHoc_ky.Text, cmbNam_hoc.Text).DefaultView
                    If dv_HocLai.Count > 0 Then
                        So_sv_HocLai = So_sv_HocLai + 1
                    End If
                    dv_ThiLai = cls.dt_DSThiLai(dt_SinhVien.Rows(j)("ID_sv"), cmbHoc_ky.Text, cmbNam_hoc.Text).DefaultView
                    If dv_ThiLai.Count > 0 Then
                        So_sv_ThiLai = So_sv_ThiLai + 1
                    End If
                Next
                If dt_SinhVien.Rows.Count > 0 Then
                    'dt_lop.Rows(i)("Tong_so_sv") = dt_SinhVien.Rows.Count
                    dt_lop.Rows(i)("So_sv_XS") = So_sv_XS
                    dt_lop.Rows(i)("So_sv_Gioi") = So_sv_Gioi
                    dt_lop.Rows(i)("So_sv_Kha") = So_sv_Kha
                    dt_lop.Rows(i)("So_sv_TBKha") = So_sv_TBKha
                    dt_lop.Rows(i)("So_sv_TB") = So_sv_TB
                    dt_lop.Rows(i)("So_sv_Yeu") = So_sv_Yeu
                    dt_lop.Rows(i)("So_sv_Kem") = So_sv_Kem
                    dt_lop.Rows(i)("So_sv_KXL") = So_sv_KXL
                    dt_lop.Rows(i)("So_sv_HocLai") = So_sv_HocLai
                    dt_lop.Rows(i)("So_sv_ThiLai") = So_sv_ThiLai

                    dt_lop.Rows(i)("TyLe_XS") = Math.Round(So_sv_XS * 100 / dt_SinhVien.Rows.Count, 2)
                    dt_lop.Rows(i)("TyLe_Gioi") = Math.Round(So_sv_Gioi * 100 / dt_SinhVien.Rows.Count, 2)
                    dt_lop.Rows(i)("TyLe_Kha") = Math.Round(So_sv_Kha * 100 / dt_SinhVien.Rows.Count, 2)
                    dt_lop.Rows(i)("TyLe_TBKha") = Math.Round(So_sv_TBKha * 100 / dt_SinhVien.Rows.Count, 2)
                    dt_lop.Rows(i)("TyLe_TB") = Math.Round(So_sv_TB * 100 / dt_SinhVien.Rows.Count, 2)
                    dt_lop.Rows(i)("TyLe_Yeu") = Math.Round(So_sv_Yeu * 100 / dt_SinhVien.Rows.Count, 2)
                    dt_lop.Rows(i)("TyLe_Kem") = Math.Round(So_sv_Kem * 100 / dt_SinhVien.Rows.Count, 2)
                    dt_lop.Rows(i)("TyLe_KXL") = Math.Round(So_sv_KXL * 100 / dt_SinhVien.Rows.Count, 2)
                    dt_lop.Rows(i)("TyLe_ThiLai") = Math.Round(So_sv_ThiLai * 100 / dt_SinhVien.Rows.Count, 2)
                    dt_lop.Rows(i)("TyLe_HocLai") = Math.Round(So_sv_HocLai * 100 / dt_SinhVien.Rows.Count, 2)
                End If
            Next
            Dim tieu_de As String = ""
            Dim rpt As New rptTongHopToanTruong(dt_lop.DefaultView, tieu_de)
            PrintXtraReport(rpt)
        Catch ex As Exception
        End Try
    End Sub
End Class