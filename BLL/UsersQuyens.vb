Imports ESS.Entity.Entity
Public Class UsersQuyens
    Private mUsersQuyen As ArrayList
    Public Sub New()
        mUsersQuyen = New ArrayList
    End Sub
    Public Sub Add(ByVal quyen As UsersQuyen)
        mUsersQuyen.Add(quyen)
    End Sub
    Public Sub Remove(ByVal idx_quyen As Integer)
        mUsersQuyen.RemoveAt(idx_quyen)
    End Sub
    Public ReadOnly Property Count() As Integer
        Get
            Return mUsersQuyen.Count
        End Get
    End Property
    Public Property UsersQuyen(ByVal idx As Integer) As UsersQuyen
        Get
            Return CType(mUsersQuyen(idx), UsersQuyen)
        End Get
        Set(ByVal Value As UsersQuyen)
            mUsersQuyen(idx) = Value
        End Set
    End Property
End Class
