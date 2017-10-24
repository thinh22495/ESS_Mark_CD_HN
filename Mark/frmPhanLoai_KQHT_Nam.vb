Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Imports ESS.Library
Imports C1.Win.C1Report
Imports C1.Win.C1FlexGrid
Imports ESS_Reports
Imports ESS.Machine
Public Class frmPhanLoai_KQHT_nam
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
            SQL = "SELECT DISTINCT Id_he,Ten_he FROM STU_he ORDER BY Ten_he"
            Dim dt As DataTable = clsDM.LoadDanhMuc(SQL)
            FillCombo(cmbHe, dt)
            'SQL = "SELECT ID_khoa,Ten_khoa FROM STU_KHOA order by Ten_khoa"
            'Dim dt_khoa As DataTable = clsDM.LoadDanhMuc(SQL)
            'FillCombo(cmbID_khoa, dt_khoa)
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
            'Dim dt_lop As DataTable = cls.dt_DanhSachLop_CoDiem(cmbHe.SelectedValue, cmbHoc_ky.Text, cmbNam_hoc.Text)
            Dim dt_khoa As DataTable = UDB.SelectTable("Select * from stu_khoa")
            dt_khoa.Columns.Add("Tong_so_sv", GetType(Integer))
            dt_khoa.Columns.Add("So_sv_XS", GetType(Integer))
            dt_khoa.Columns.Add("TL_sv_XS", GetType(Double))
            dt_khoa.Columns.Add("So_sv_Gioi", GetType(Integer))
            dt_khoa.Columns.Add("TL_sv_Gioi", GetType(Double))
            dt_khoa.Columns.Add("So_sv_Kha", GetType(Integer))
            dt_khoa.Columns.Add("TL_sv_Kha", GetType(Double))
            dt_khoa.Columns.Add("So_sv_TBKha", GetType(Integer))
            dt_khoa.Columns.Add("TL_sv_TBKha", GetType(Double))
            dt_khoa.Columns.Add("So_sv_TB", GetType(Integer))
            dt_khoa.Columns.Add("TL_sv_TB", GetType(Double))
            dt_khoa.Columns.Add("So_sv_Yeu", GetType(Integer))
            dt_khoa.Columns.Add("TL_sv_Yeu", GetType(Double))
            dt_khoa.Columns.Add("So_sv_Kem", GetType(Integer))
            dt_khoa.Columns.Add("TL_sv_Kem", GetType(Double))

            For i As Integer = 0 To dt_khoa.Rows.Count - 1
                Dim So_sv_XS As Integer = 0
                Dim So_sv_Gioi As Integer = 0
                Dim So_sv_Kha As Integer = 0
                Dim So_sv_TBKha As Integer = 0
                Dim So_sv_TB As Integer = 0
                Dim So_sv_Yeu As Integer = 0
                Dim So_sv_Kem As Integer = 0

                Dim TL_sv_XS As Double = 0
                Dim TL_sv_Gioi As Double = 0
                Dim TL_sv_Kha As Double = 0
                Dim TL_sv_TBKha As Double = 0
                Dim TL_sv_TB As Double = 0
                Dim TL_sv_Yeu As Double = 0
                Dim TL_sv_Kem As Double = 0

                Dim TBCHP As Double = 0

                dt_SinhVien = cls.dt_DanhSachSinhVienKhoa(dt_khoa.Rows(i)("ID_Khoa"), cmbNam_hoc.Text)
                Dim TongSV As Integer = dt_SinhVien.Rows.Count
                dt_khoa.Rows(i)("Tong_so_sv") = TongSV

                For j As Integer = 0 To TongSV - 1 ' Duyet tung sinh vien
                    dt_diem = cls.dt_DanhSachDiemTheoSinhVien_TheoNam(dt_SinhVien.Rows(j)("ID_sv"), cmbNam_hoc.Text)
                    If dt_diem.Rows.Count > 0 Then 'Kiem tra co diem va So hoc trinh <>0
                        If dt_diem.Rows(0)("So_hoc_trinh").ToString <> "" AndAlso dt_diem.Rows(0)("So_hoc_trinh") > 0 Then
                            TBCHP = dt_diem.Rows(0)("Tong_Diem") / dt_diem.Rows(0)("So_hoc_trinh")
                            If TBCHP >= 9 Then 'XS;
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
                                So_sv_Kem = So_sv_Kem + 1 'Kém
                            End If
                        End If
                    End If
                    If TongSV > 0 Then
                        dt_khoa.Rows(i)("So_sv_XS") = So_sv_XS
                        dt_khoa.Rows(i)("So_sv_Gioi") = So_sv_Gioi
                        dt_khoa.Rows(i)("So_sv_Kha") = So_sv_Kha
                        dt_khoa.Rows(i)("So_sv_TBKha") = So_sv_TBKha
                        dt_khoa.Rows(i)("So_sv_TB") = So_sv_TB
                        dt_khoa.Rows(i)("So_sv_Yeu") = So_sv_Yeu
                        dt_khoa.Rows(i)("So_sv_Kem") = So_sv_Kem

                        TL_sv_XS = Math.Round((So_sv_XS / TongSV) * 100, 1)
                        TL_sv_Gioi = Math.Round((So_sv_Gioi / TongSV) * 100, 1)
                        TL_sv_Kha = Math.Round((So_sv_Kha / TongSV) * 100, 1)
                        TL_sv_TBKha = Math.Round((So_sv_TBKha / TongSV) * 100, 1)
                        TL_sv_TB = Math.Round((So_sv_TB / TongSV) * 100, 1)
                        TL_sv_Yeu = Math.Round((So_sv_Yeu / TongSV) * 100, 1)
                        TL_sv_Kem = Math.Round((So_sv_Kem / TongSV) * 100, 1)

                        dt_khoa.Rows(i)("TL_sv_XS") = TL_sv_XS
                        dt_khoa.Rows(i)("TL_sv_Gioi") = TL_sv_Gioi
                        dt_khoa.Rows(i)("TL_sv_Kha") = TL_sv_Kha
                        dt_khoa.Rows(i)("TL_sv_TBKha") = TL_sv_TBKha
                        dt_khoa.Rows(i)("TL_sv_TB") = TL_sv_TB
                        dt_khoa.Rows(i)("TL_sv_Yeu") = TL_sv_Yeu
                        dt_khoa.Rows(i)("TL_sv_Kem") = TL_sv_Kem
                    End If
                Next
            Next

            Dim dv As DataView = dt_khoa.DefaultView

            Dim Tong_SV As Integer = 0
            Dim XS As Double = 0
            Dim Gioi As Double = 0
            Dim Kha As Double = 0
            Dim TBKha As Double = 0
            Dim TB As Double = 0
            Dim Yeu As Double = 0
            Dim Kem As Double = 0

            For i As Integer = 0 To dv.Count - 1
                Tong_SV += CType(dv.Item(i)("Tong_so_sv"), Integer)
                XS += CType(dv.Item(i)("So_sv_XS"), Double)
                Gioi += CType(dv.Item(i)("So_sv_Gioi"), Double)
                Kha += CType(dv.Item(i)("So_sv_Kha"), Double) '
                TBKha += CType(dv.Item(i)("So_sv_TBKha"), Double)
                TB += CType(dv.Item(i)("So_sv_TB"), Double)
                Yeu += CType(dv.Item(i)("So_sv_Yeu"), Double)
                Kem += CType(dv.Item(i)("So_sv_Kem"), Double)
            Next
            Dim PT_ALL_XS As Double = Math.Round((XS / Tong_SV) * 100, 1)
            Dim PT_ALL_Gioi As Double = Math.Round((Gioi / Tong_SV) * 100, 1)
            Dim PT_ALL_Kha As Double = Math.Round((Kha / Tong_SV) * 100, 1)
            Dim PT_ALL_TBKha As Double = Math.Round((TBKha / Tong_SV) * 100, 1)
            Dim PT_ALL_TB As Double = Math.Round((TB / Tong_SV) * 100, 1)
            Dim PT_ALL_Yeu As Double = Math.Round((Yeu / Tong_SV) * 100, 1)
            Dim PT_ALL_Kem As Double = Math.Round((Kem / Tong_SV) * 100, 1)


            Dim tieu_de As String = "BẢNG TỔNG HỢP KẾT QUẢ NĂM HỌC " & cmbNam_hoc.Text
            Dim rpt As New rpt_ThongKeXepLoaiHocTap_Nam(dt_khoa.DefaultView, tieu_de, PT_ALL_XS, PT_ALL_Gioi, PT_ALL_Kha, PT_ALL_TBKha, PT_ALL_Yeu, PT_ALL_Kem)
            PrintXtraReport(rpt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class