Namespace Entity
    Public Class CoVanHocTap
        Inherits DanhSachSinhVien
#Region "Constructor"
#End Region

#Region "Var"
        Private mUserName As String = ""
#End Region

#Region "Property"
        Public Property UserName() As String
            Get
                Return mUserName
            End Get
            Set(ByVal Value As String)
                mUserName = Value
            End Set
        End Property
#End Region
    End Class
End Namespace