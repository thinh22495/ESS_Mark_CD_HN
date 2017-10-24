Public Class DiemThiChiTiet
#Region "Properties"
    Private mID_diem_thi As Integer
    Public Property ID_diem_thi() As Integer
        Get
            Return mID_diem_thi
        End Get
        Set(ByVal value As Integer)
            mID_diem_thi = value
        End Set
    End Property
    Private mThanhPhanThi As ThanhPhanThi
    Public Property ThanhPhanThi() As ThanhPhanThi
        Get
            Return mThanhPhanThi
        End Get
        Set(ByVal value As ThanhPhanThi)
            mThanhPhanThi = value
        End Set
    End Property

    Private mDiem As Double
    Public Property Diem() As Double
        Get
            Return mDiem
        End Get
        Set(ByVal value As Double)
            mDiem = value
        End Set
    End Property
#End Region

#Region "Converting"
    ''' <summary>
    ''' Convert từ datarow sang object
    ''' </summary>
    ''' <param name="dr"></param>
    ''' <remarks></remarks>
    Public Sub ConvertFrom(ByVal dr As DataRow)
        Me.ThanhPhanThi.ConvertFrom(dr)
        If dr.Table.Columns.Contains("ID_diem_thi") Then Me.ID_diem_thi = IIf(IsNumeric(dr("ID_diem_thi")), dr("ID_diem_thi"), 0)
        If dr.Table.Columns.Contains("Diem") Then Me.Diem = IIf(Not IsNothing(dr("Diem")), dr("Diem"), 0)
    End Sub
#End Region

    Public Sub New()
        Me.ThanhPhanThi = New ESS.Entity.ThanhPhanThi()
    End Sub
End Class
