Imports ESS.BLL.Business
Imports ESS.Machine
Public Class frmESS_TongHopChung

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim dsIDLop As String = TreeViewLop1.ID_lop_list
        Dim Hoc_ky As Integer = Convert.ToInt32(cmbHoc_ky.Text)
        Dim Nam_hoc As String = cmbNam_hoc.Text
        Dim tieu_de As String = ""
        If TreeViewLop1.ID_lop_list > 0 Then
            'tieu_de = "Khoa " + UDB.ExecuteScalar("select Ten_khoa from stu_khoa where id_khoa=" + TreeViewLop1.ID_khoa.ToString).ToString + "; Học kỳ " + Hoc_ky.ToString + "; Năm học: " + Nam_hoc + "; Lần học: " + cmbLan_hoc.Text + "; Lần thi " + cmbLan_thi.Text
        Else
            tieu_de = TreeViewLop1.Tieu_de_Lop + "Học kỳ " + Hoc_ky.ToString + "; Năm học: " + Nam_hoc + "; Lần học: " = cmbLan_hoc.Text + "; Lần thi " = cmbLan_thi.Text
        End If
        Dim cls As New TongHopChung_HHT_BLL
        Dim dt As DataTable = cls.GetTienDoNhapDiem(Hoc_ky, Nam_hoc, dsIDLop, cmbLan_hoc.Text, cmbLan_thi.Text)
        Dim rpt As New rptTongHopNhapDiem(dt, tieu_de)
        PrintXtraReport(rpt)
    End Sub
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
            cmbLan_thi.SelectedIndex = 0
            cmbLan_hoc.SelectedIndex = 0
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_TongHopChung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadComboBox()
        TreeViewLop1.Load_TreeView()
    End Sub
End Class