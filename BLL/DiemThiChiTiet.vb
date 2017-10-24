Public Class DiemThiChiTiet_BLL
    Private mDsThanhPhanThi As Generic.List(Of Entity.ThanhPhanThi)
    Private mDsDiemThiChiTiet As Generic.List(Of Entity.DiemThiChiTiet)
    Private DAL As New DAL.DiemThiChiTiet_DAL()
    Public Property dsThanhPhanThi() As Generic.List(Of Entity.ThanhPhanThi)
        Get
            Return mDsThanhPhanThi
        End Get
        Set(ByVal value As Generic.List(Of Entity.ThanhPhanThi))
            mDsThanhPhanThi = value
        End Set
    End Property
    Public Property dsDiemThiChiTiet() As Generic.List(Of Entity.DiemThiChiTiet)
        Get
            Return mDsDiemThiChiTiet
        End Get
        Set(ByVal value As Generic.List(Of Entity.DiemThiChiTiet))
            mDsDiemThiChiTiet = value
        End Set
    End Property

    ''' <summary>
    ''' Load thành phần thi chi tiết của 1 môn trong lớp , vd: Viết, vấn đáp,...
    ''' </summary>
    ''' <param name="dsID_lop"></param>
    ''' <param name="ID_mon"></param>
    ''' <remarks></remarks>
    Sub LoadThanhPhanThi(ByVal dsID_lop As String, ByVal ID_mon As Integer)
        Dim dtThanhPhan As DataTable = DAL.LoadThanhPhanThi(dsID_lop, ID_mon)
        If IsNothing(mDsThanhPhanThi) Then mDsThanhPhanThi = New Generic.List(Of Entity.ThanhPhanThi)
        For index As Integer = 0 To dtThanhPhan.Rows.Count - 1
            Dim obj As New Entity.ThanhPhanThi()
            obj.ConvertFrom(dtThanhPhan.Rows(index))
            mDsThanhPhanThi.Add(obj)
        Next

    End Sub

    Public Sub New(ByVal dsID_lop As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_sv As String, ByVal ID_mon As Integer)
        Me.LoadThanhPhanThi(dsID_lop, ID_mon)
        Dim dtDiemThiChiTiet As DataTable = DAL.LoadDiemThiChiTiet(dsID_lop, Hoc_ky, Nam_hoc, dsID_sv, ID_mon)
        If IsNothing(mDsDiemThiChiTiet) Then mDsDiemThiChiTiet = New Generic.List(Of Entity.DiemThiChiTiet)
        For index As Integer = 0 To dtDiemThiChiTiet.Rows.Count - 1
            Dim obj As New Entity.DiemThiChiTiet()
            obj.ConvertFrom(dtDiemThiChiTiet.Rows(index))
            mDsDiemThiChiTiet.Add(obj)
        Next
    End Sub
    Public Function UpdateDiemThi(ByVal obj As Entity.DiemThiChiTiet) As Integer
        Return New DAL.DiemThiChiTiet_DAL().UpdateDiemThi(obj)
    End Function
End Class
