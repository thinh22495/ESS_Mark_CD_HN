Imports System.Drawing.Drawing2D
Imports ESS.Entity.Entity
Imports ESS.BLL.Business
Public Class frmESS_BoMonChonHocPhan
    Dim objMonHoc_bll As New MonHoc_BLL

#Region "Var"
    Private mMonHoc As New ArrayList
    Private mID_bm As Integer
    Private mThoat As Boolean
    Dim loader As Boolean = False
#End Region

#Region "Property"
    Property MonHoc() As ArrayList
        Get
            Return mMonHoc
        End Get
        Set(ByVal value As ArrayList)
            mMonHoc = value
        End Set
    End Property
    Property ID_bm() As Integer
        Get
            Return mID_bm
        End Get
        Set(ByVal value As Integer)
            mID_bm = value
        End Set
    End Property
    Property Thoat() As Boolean
        Get
            Return mThoat
        End Get
        Set(ByVal value As Boolean)
            mThoat = value
        End Set
    End Property
#End Region

#Region "Functions And Subs"
    Private Sub frmESS_BoMonChonGiaoVien_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            SetUpDataGridView(DataGridView1)
            DataGridView1.DataSource = objMonHoc_bll.DanhSachMonHoc().DefaultView
            DataGridView1.DataSource.RowFilter = " ID_bm <> " & ID_bm
            loader = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmESS_BoMonChonMonHoc_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub txtTen_gv_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTen_mh.TextChanged
        If loader Then
            Dim DieuKien As String = " ID_bm <> " & ID_bm
            If txtTen_mh.Text.Trim <> "" Then DieuKien += " AND Ten_mon LIKE '" + txtTen_mh.Text.Trim + "%'"
            'Lọc theo các điều kiện eeeee
            DataGridView1.DataSource.RowFilter = DieuKien
        End If
    End Sub

    Private Sub txtMa_Mon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMa_Mon.TextChanged
        If loader Then
            Dim dk As String = ""
            dk = " ID_bm <> " & ID_bm

            If txtMa_Mon.Text.Trim <> "" Then dk += " AND Ky_hieu LIKE '" + txtMa_Mon.Text.Trim + "%'"
            DataGridView1.DataSource.RowFilter = dk
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Thoat = True
        Me.Close()
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Thoat = False
        Dim dv As DataView = DataGridView1.DataSource
        For i As Integer = 0 To dv.Count - 1
            If DataGridView1.Item(0, i).Value Then
                Dim objMh As New MonHoc
                ' Lay mon hoc
                objMh = objMonHoc_bll.GetMonHoc(dv(i)("ID_mon"))
                ' Gan lai bo mon
                objMh.ID_bm = ID_bm
                MonHoc.Add(objMh)
            End If
        Next
        Me.Close()
    End Sub


    Private Sub optAll1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll1.CheckedChanged
        Try
            Dim dv As New DataView
            dv = DataGridView1.DataSource
            If dv.Count < 0 Then Exit Sub
            For i As Integer = 0 To dv.Count - 1
                dv.Item(i).Item("Chon") = optAll1.Checked
            Next
            DataGridView1.DataSource = dv
        Catch ex As Exception

        End Try
    End Sub
#End Region


End Class
