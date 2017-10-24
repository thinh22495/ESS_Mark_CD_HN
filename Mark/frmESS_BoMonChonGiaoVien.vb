Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.BLL.Business
Public Class frmESS_BoMonChonGiaoVien

#Region "Var"
    Private mID_cb As New ArrayList
    Private mID_bm As Integer
    Private mThoat As Boolean
    Dim loader As Boolean = False
#End Region

#Region "Property"
    Property arrID_cb() As ArrayList
        Get
            Return mID_cb
        End Get
        Set(ByVal value As ArrayList)
            mID_cb = value
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
            Dim objGiangVien_Bussines As New GiangVien_BLL
            DataGridView1.DataSource = objGiangVien_Bussines.DanhSachGiangVienNgoaiBoMon(ID_bm).DefaultView
            loader = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmESS_BoMonChonGiaoVien_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

    End Sub
    Private Sub txtTen_gv_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTen_gv.TextChanged
        If loader Then
            Dim DieuKien As String = " 1=1"
            If txtTen_gv.Text.Trim <> "" Then DieuKien += " AND Ho_ten LIKE '" + txtTen_gv.Text.Trim + "%'"
            'Lọc theo các điều kiện w
            CType(DataGridView1.DataSource, DataView).RowFilter = DieuKien
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
                arrID_cb.Add(dv(i)("ID_cb"))
            End If
        Next
        Me.Close()
    End Sub
#End Region


End Class