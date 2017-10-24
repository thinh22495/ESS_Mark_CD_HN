Namespace Entity
    Public Class DanhSachThuctap
        Inherits DanhSachSinhVien
#Region "Constructor"
#End Region

#Region "Var"
        Private mNoi_thuc_tap As String = ""
#End Region

#Region "Property"
        Public Property Noi_thuc_tap() As String
            Get
                Return mNoi_thuc_tap
            End Get
            Set(ByVal Value As String)
                mNoi_thuc_tap = Value
            End Set
        End Property
#End Region
    End Class
End Namespace