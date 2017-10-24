Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Public Class frmESS_ToChucThiPhong
    Private mSo_sv As Integer
    Private mclsTCThi As TochucThi_BLL

    Private Sub FormatGridviewLopTinChi(ByVal grdView As DataGridView)
        Dim col1 As New DataGridViewCheckBoxColumn
        With col1
            .Name = "Chon"
            .DataPropertyName = "Chon"
            .HeaderText = "Chọn"
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.NullValue = ""
            .ReadOnly = False
        End With
        Dim col2 As New DataGridViewTextBoxColumn
        With col2
            .HeaderText = "Phòng học"
            .DataPropertyName = "Ten_phong_main"
            .Visible = True
            .ReadOnly = True
            .Width = 150
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        'End With
        Dim col3 As New DataGridViewTextBoxColumn
        With col3
            .HeaderText = "Số sv"
            .DataPropertyName = "So_sv"
            .Visible = True
            .ReadOnly = False
            .Width = 80
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col4 As New DataGridViewTextBoxColumn
        With col4
            .HeaderText = "Sức chứa"
            .DataPropertyName = "Suc_chua"
            .Visible = True
            .ReadOnly = True
            .Width = 80
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col5 As New DataGridViewCheckBoxColumn
        With col5
            .Name = "Khong_thay_doi"
            .DataPropertyName = "Khong_thay_doi"
            .HeaderText = "Không thay đổi"
            .Width = 140
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.NullValue = ""
            .ReadOnly = False
        End With
        grdViewPhongThi.Columns.Clear()
        With grdView.Columns
            .Add(col1)
            .Add(col2)
            .Add(col3)
            .Add(col4)
            .Add(col5)
        End With
    End Sub

    Public Overloads Sub ShowDialog(ByVal clsTCThi As TochucThi_BLL, ByVal So_sv As Integer)
        mSo_sv = So_sv
        lblSo_sv.Text = mSo_sv
        mclsTCThi = clsTCThi
        Me.ShowDialog()
    End Sub

    Private Sub frmESS_ToChucThiPhong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim clsDM As New DanhMuc_BLL
        Dim dt As DataTable = clsDM.DanhMuc_Load("PLAN_ToaNha", "ID_nha", "Ten_nha")
        FillCombo(cmbID_nha, dt)

        SetUpDataGridView(grdViewPhongThi)
        FormatGridviewLopTinChi(grdViewPhongThi)

        Dim dtPhongHoc As New DataTable
        Dim clsPhongHoc As New PhongHoc_BLL
        'Load danh sách phòng học
        Dim So_sv_da_chon As Integer = 0
        dtPhongHoc = clsPhongHoc.DanhSachPhongThi(mclsTCThi, cmbID_nha.SelectedValue, So_sv_da_chon)
        lblSuc_chua.Text = So_sv_da_chon
        lblSo_sv.Text = mSo_sv
        grdViewPhongThi.DataSource = dtPhongHoc.DefaultView
    End Sub

    Private Sub cmbID_nha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_nha.SelectedIndexChanged
        Try
            Dim dtPhongHoc As New DataTable
            Dim clsPhongHoc As New PhongHoc_BLL
            Dim So_sv_da_chon As Integer = 0
            dtPhongHoc = clsPhongHoc.DanhSachPhongThi(mclsTCThi, cmbID_nha.SelectedValue, So_sv_da_chon)
            lblSo_sv.Text = So_sv_da_chon
            grdViewPhongThi.DataSource = dtPhongHoc.DefaultView
        Catch ex As Exception
        End Try
    End Sub

    Private Sub grdViewPhongThi_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdViewPhongThi.CellEndEdit
        Try
            Dim Suc_chua As Integer = 0
            Dim dv As DataView = grdViewPhongThi.DataSource
            For i As Integer = 0 To dv.Count - 1
                If Not grdViewPhongThi.CurrentCell.Value Is Nothing AndAlso grdViewPhongThi.CurrentCell.Value.ToString <> "" AndAlso Not IsNumeric(grdViewPhongThi.CurrentCell.Value) Then
                    Thongbao("Bạn phải nhập số sinh viên là số !")
                    grdViewPhongThi.CurrentCell.Value = 0
                End If
                If dv.Item(i)("Chon") = True Then
                    If Suc_chua + dv.Item(i)("So_sv") > mSo_sv Then
                        dv.Item(i)("So_sv") = 0
                    End If
                    If dv.Item(i)("So_sv") > dv.Item(i)("Suc_chua") AndAlso chkCheck.Checked = True Then
                        dv.Item(i)("So_sv") = dv.Item(i)("Suc_chua")
                    End If
                    Suc_chua += dv.Item(i)("So_sv")
                End If
            Next
            lblSuc_chua.Text = Suc_chua

            lblSV_Con.Text = CType(lblSo_sv.Text, Integer) - Suc_chua
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnToTucThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dt As DataTable = grdViewPhongThi.DataSource.Table
        Dim Tong_sv As Integer
        'Tính tổng số sinh viên của các phòng thi
        For i As Integer = 0 To dt.Rows.Count - 1
            Tong_sv += dt.Rows(i)("So_sv")
        Next
        'Kiểm tra tổng số sinh viên của các phòng thi so với số sinh viên tổ chức thi
        If Tong_sv < mSo_sv Then
            Thongbao("Tổng số sinh viên của các phòng thi nhỏ hơn số sinh viên tổ chức thi là" + mSo_sv.ToString + " (sv) .Bạn nhập lại số sinh viên / phòng thi!")
        Else
            Me.Tag = 1
            Me.Close()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = 0
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim dt As DataTable = grdViewPhongThi.DataSource.Table
        Dim Tong_sv As Integer
        'Tính tổng số sinh viên của các phòng thi
        For i As Integer = 0 To dt.Rows.Count - 1
            Tong_sv += dt.Rows(i)("So_sv")
        Next
        'Kiểm tra tổng số sinh viên của các phòng thi so với số sinh viên tổ chức thi
        If Tong_sv < mSo_sv Then
            Thongbao("Tổng số sinh viên của các phòng thi nhỏ hơn số sinh viên tổ chức thi là" + mSo_sv.ToString + " (sv) .Bạn nhập lại số sinh viên / phòng thi!")
        Else
            Me.Tag = 1
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class