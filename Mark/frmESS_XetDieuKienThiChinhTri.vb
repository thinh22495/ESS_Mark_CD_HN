Imports System.Drawing.Drawing2D
Imports ESS.BLL.Business
Imports ESS.Entity.Entity
Public Class frmESS_XetDieuKienThiChinhTri
    Dim dt_ds_lv, dt_ds_thi As DataTable
    Dim clsXet As DanhSachLuanVanThiNoTotNghiep_BLL
    Private mID_dt As Integer = 0
    Private mID_he As Integer = 0
    Private Sub frmESS_XetDieuKienThiChinhTri_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TrvLop_ChuanHoa_ThiTN.Load_TreeView()
        Me.TrvLop_ChuanHoa_NoThi.Load_TreeView()
        cmbLan_thu.SelectedIndex = 0
        SetQuyenTruyCap(, btnxet, btnLV, btnThiTN)
    End Sub
End Class