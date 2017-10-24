Public Class rptBangDiemTotNghiep_NNT_Sub_Left
    Dim stt As Integer
    Public Sub binding(ByVal TB_ChinhTri As Double, ByVal ChinhTri_HocTrinh As Double, ByVal TB_PhapLuat As Double, ByVal PhapLuat_HocTrinh As Double, ByVal TB_GDTC As Double, ByVal GDTC_HocTrinh As Double, ByVal TB_GDQP As Double, ByVal GDQP_HocTrinh As Double)
        So_thu_tu.DataBindings.Add("Text", DataSource, "STT")
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHP", "{0:n1}")
        TBCHT.DataBindings.Add("Text", DataSource, "TBCHT", "{0:n1}")

        Me.lbTB_ChinhTri.Text = FormatNumber(TB_ChinhTri, 1)
        'Me.lbChinhTri_HocTrinh.Text = ChinhTri_HocTrinh
        Me.TB_PhapLuat.Text = FormatNumber(TB_PhapLuat, 1)
        'Me.PhapLuat_HocTrinh.Text = PhapLuat_HocTrinh
        Me.TB_GDTC.Text = FormatNumber(TB_GDTC, 1)
        'Me.GDTC_HocTrinh.Text = GDTC_HocTrinh
        Me.TB_GDQP.Text = FormatNumber(TB_GDQP, 1)
        'Me.GDQP_HocTrinh.Text = GDQP_HocTrinh
    End Sub
End Class