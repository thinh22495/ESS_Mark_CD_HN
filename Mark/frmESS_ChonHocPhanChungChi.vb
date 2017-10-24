Imports System.Drawing.Drawing2D
Imports ESS.Entity.Entity
Imports ESS.BLL.Business
Public Class frmESS_ChonHocPhanChungChi
    Dim objMonHoc_bll As MonHoc_BLL
#Region "Var"
    Private mMonHoc As New ArrayList
    Private mID_dt As Integer
    Private mID_chung_chi As Integer
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
    Property ID_dt() As Integer
        Get
            Return mID_dt
        End Get
        Set(ByVal value As Integer)
            mID_dt = value
        End Set
    End Property
    Property ID_chung_chi() As Integer
        Get
            Return mID_chung_chi
        End Get
        Set(ByVal value As Integer)
            mID_chung_chi = value
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
    Private Sub frmESS__Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            objMonHoc_bll = New MonHoc_BLL(0, 0, ID_dt)
            grcDanhSachHP.DataSource = objMonHoc_bll.DanhSachMonHoc().DefaultView
            FillComboBox()
            loader = True
        Catch ex As Exception
        End Try
    End Sub


    Private Sub FillComboBox()
        Dim clsDM As New DanhMuc_BLL
        Dim dtLoaiChungChi As DataTable = clsDM.DanhMuc_Load("MARK_LoaiChungchi", "ID_chung_chi", "Loai_chung_chi")
        FillCombo(cmbLoaiChungChi, dtLoaiChungChi)
        cmbLoaiChungChi.SelectedValue = ID_chung_chi
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If cmbLoaiChungChi.SelectedIndex < 0 Then
            Thongbao("Bạn phải chọn loai chứng chỉ!", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Thoat = False
        Dim dv As DataView = grvDanhSachHP.DataSource
        For i As Integer = 0 To dv.Count - 1
            If dv.Item(i)("Chon") Then
                Dim objMh As New MonHoc
                ' Lay Học phần
                objMh = objMonHoc_bll.GetMonHoc(dv(i)("ID_mon"))
                MonHoc.Add(objMh)
            End If
        Next
        ' Gán lại chứng chỉ
        ID_chung_chi = cmbLoaiChungChi.SelectedValue
        Me.Close()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Thoat = True
        Me.Close()
    End Sub
#End Region
End Class