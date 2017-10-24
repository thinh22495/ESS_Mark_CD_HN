Public Class ThanhPhanThi
#Region "Properties"


    Private mID_thanh_phan As Integer
    Public Property ID_thanh_phan() As Integer
        Get
            Return mID_thanh_phan
        End Get
        Set(ByVal value As Integer)
            mID_thanh_phan = value
        End Set
    End Property

    Private mKy_hieu As String
    Public Property Ky_hieu() As String
        Get
            Return mKy_hieu
        End Get
        Set(ByVal value As String)
            mKy_hieu = value
        End Set
    End Property

    Private mTen_thanh_phan As String
    Public Property Ten_thanh_phan() As String
        Get
            Return mTen_thanh_phan
        End Get
        Set(ByVal value As String)
            mTen_thanh_phan = value
        End Set
    End Property

    Private mPhan_pham As Double
    Public Property Phan_tram() As Double
        Get
            Return mPhan_pham
        End Get
        Set(ByVal value As Double)
            mPhan_pham = value
        End Set
    End Property
#End Region
#Region "Converting"
    ''' <summary>
    ''' Convert từ datarow thành object thành phần thi
    ''' </summary>
    ''' <param name="dr">Datarow</param>
    ''' <remarks></remarks>
    Public Sub ConvertFrom(ByVal dr As DataRow)
        If dr.Table.Columns.Contains("ID_thanh_phan_thi") Then Me.ID_thanh_phan = IIf(IsNumeric(dr("ID_thanh_phan_thi")), dr("ID_thanh_phan_thi"), 0)
        If dr.Table.Columns.Contains("Ky_hieu") Then Me.Ky_hieu = IIf(Not IsNothing(dr("Ky_hieu")), dr("Ky_hieu"), "")
        If dr.Table.Columns.Contains("Ten_thanh_phan") Then Me.Ten_thanh_phan = IIf(Not IsNothing(dr("Ten_thanh_phan")), dr("Ten_thanh_phan"), "")
        If dr.Table.Columns.Contains("Phan_tram") Then Me.Phan_tram = IIf(IsNumeric(dr("Phan_tram")), dr("Phan_tram"), 0)
    End Sub
#End Region
End Class
