Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Public Class frmESS_NoiDungQDTotNghiep
    Private mdt_sv As DataTable
    Private mdv_sv As DataView
    Private QD_ThoiHoc As Boolean = True

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Public Overloads Sub ShowDialog(ByVal dt_danhsach As DataTable)
        Try
            mdv_sv = dt_danhsach.DefaultView
            Me.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            If txtSo_QD.Text = "" Or dtmNgay_hop.Checked = False Then
                Thongbao("Bạn phải nhập Số quyết định và Ngày quyết định !")
            Else
                Dim So_QD1 As String = ""
                Dim So_QD2 As String = ""
                Dim Ngay_quyet_dinh As Date = Format(dtmNgay_hop.Value, "dd/MM/yyyy")
                Dim Ngay As Integer = Ngay_quyet_dinh.Day
                Dim Ngay_HT As String = ""
                If Ngay < 10 Then
                    Ngay_HT = "0" & Ngay.ToString
                Else
                    Ngay_HT = Ngay.ToString
                End If
                So_QD1 = "Số:     /GCN - CĐN CNC"
                So_QD2 = "        Đã tốt nghiệp Cao đẳng nghề theo Quyết định số " & txtSo_QD.Text & "/QĐ – CĐN CNC ngày " & Ngay_HT.ToString
                Dim So_QD3 As String = "tháng " & Ngay_quyet_dinh.Month & " năm " & Ngay_quyet_dinh.Year & " của Hiệu trưởng Trường cao đẳng nghề Công nghệ cao Hà Nội."
                Dim rpt As New rptGiayChungNhanTotNghiepTamThoi(mdv_sv, So_QD1, So_QD2, So_QD3)
                rpt.Binding()
                rpt.DataSource = mdv_sv
                PrintXtraReport(rpt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnChung_nhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChung_nhan.Click
        Try
            If txtSo_QD.Text = "" Or dtmNgay_hop.Checked = False Then
                Thongbao("Bạn phải nhập Số quyết định và Ngày quyết định !")
            Else
                Dim So_QD1 As String = ""
                Dim So_QD2 As String = ""
                Dim Ngay_quyet_dinh As Date = Format(dtmNgay_hop.Value, "dd/MM/yyyy")
                So_QD1 = "Số:   /GCN - CĐN CNC"
                So_QD2 = "      Đã tốt nghiệp theo Quyết định số " & txtSo_QD.Text & "/QĐ – CĐNCNC ngày " & Ngay_quyet_dinh.Day & " tháng " & Ngay_quyet_dinh.Month & " năm " & Ngay_quyet_dinh.Year
                Dim rpt As New rptGiayChungNhanHoanThanhKhoaHoc(mdv_sv, So_QD1, So_QD2)
                rpt.Binding()
                rpt.DataSource = mdv_sv
                PrintXtraReport(rpt)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class