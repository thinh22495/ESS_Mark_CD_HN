<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThanhPhanThi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.grcDanhSach = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_thanh_phan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKy_hieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_thanh_phan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPhan_tram = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(445, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.ESS_Mark.My.Resources.Resources.Save
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripButton1.Text = "Lưu"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.ESS_Mark.My.Resources.Resources.Close
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripButton2.Text = "Thoát"
        '
        'grcDanhSach
        '
        Me.grcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcDanhSach.Location = New System.Drawing.Point(0, 25)
        Me.grcDanhSach.MainView = Me.grvDanhSach
        Me.grcDanhSach.Name = "grcDanhSach"
        Me.grcDanhSach.Size = New System.Drawing.Size(445, 265)
        Me.grcDanhSach.TabIndex = 1
        Me.grcDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach})
        '
        'grvDanhSach
        '
        Me.grvDanhSach.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_thanh_phan, Me.colKy_hieu, Me.colTen_thanh_phan, Me.colPhan_tram, Me.colChon})
        Me.grvDanhSach.GridControl = Me.grcDanhSach
        Me.grvDanhSach.Name = "grvDanhSach"
        Me.grvDanhSach.OptionsView.ShowGroupPanel = False
        '
        'colID_thanh_phan
        '
        Me.colID_thanh_phan.Caption = "GridColumn1"
        Me.colID_thanh_phan.FieldName = "ID_thanh_phan"
        Me.colID_thanh_phan.Name = "colID_thanh_phan"
        '
        'colKy_hieu
        '
        Me.colKy_hieu.Caption = "Ký hiệu"
        Me.colKy_hieu.FieldName = "Ky_hieu"
        Me.colKy_hieu.Name = "colKy_hieu"
        Me.colKy_hieu.Visible = True
        Me.colKy_hieu.VisibleIndex = 1
        '
        'colTen_thanh_phan
        '
        Me.colTen_thanh_phan.Caption = "Tên thành phần"
        Me.colTen_thanh_phan.FieldName = "Ten_thanh_phan"
        Me.colTen_thanh_phan.Name = "colTen_thanh_phan"
        Me.colTen_thanh_phan.Visible = True
        Me.colTen_thanh_phan.VisibleIndex = 2
        '
        'colPhan_tram
        '
        Me.colPhan_tram.Caption = "Phần trăm"
        Me.colPhan_tram.FieldName = "Phan_tram"
        Me.colPhan_tram.Name = "colPhan_tram"
        Me.colPhan_tram.Visible = True
        Me.colPhan_tram.VisibleIndex = 3
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        '
        'frmThanhPhanThi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 290)
        Me.Controls.Add(Me.grcDanhSach)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmThanhPhanThi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thành phần điểm thi"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents grcDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_thanh_phan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKy_hieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_thanh_phan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhan_tram As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
End Class
