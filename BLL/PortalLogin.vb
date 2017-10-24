Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ThienAn.Entity.Entity
Imports ThienAn.DAL.DBManager
Namespace Business
    Public Class PortalLogin_BLL
        Dim obj As New PortalLogin_DAL
#Region "Constructor"
        Sub New()
        End Sub
#End Region

#Region "Functions"
        Public Function Login(ByVal UserName As String, ByVal Password As String) As Integer
            Return obj.Login(UserName, Password)
        End Function
        Public Function ChangePassword(ByVal ID_sv As Integer, ByVal Password As String) As Integer
            Return obj.Change_Password(ID_sv, Password)
        End Function
        Public Function ChangePasswordCanbo(ByVal UserName As String, ByVal Password As String) As Integer
            Password = ThienAn.UniLibrary.XCrypto.MD5(Password)
            Return obj.Change_Password_Canbo(UserName, Password)
        End Function
        Public Function sID_dt() As String
            Dim dt As DataTable = obj.Load_ChuongTrinhDaoTao_List()
            Dim str As String = "0"
            For i As Integer = 0 To dt.Rows.Count - 1
                str &= "," & dt.Rows(i)("ID_dt")
            Next
            Return str
        End Function
#End Region

    End Class
End Namespace
