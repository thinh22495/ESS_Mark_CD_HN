'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/02/2008
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class Quyen_BLL
#Region "Variable"
        Private aVaiTroQuyen As ArrayList
        Private aPhanHe As ArrayList
        Private aUsersQuyen As ArrayList
        Private aID_Quyen As ArrayList

#End Region

        Public Sub New(ByVal UserID As Integer, ByVal ID_Vai_Tro As Integer)
            Try
                Dim obj As Quyen_DAL = New Quyen_DAL
                Dim objVaiTro As VaiTro_DAL = New VaiTro_DAL
                Dim dtUsersQuyen As DataTable = obj.Load_UsersQuyen_List(UserID, ID_Vai_Tro)
                Dim objUsersQuyen As UsersQuyen = Nothing
                Dim drUsersQuyen As DataRow = Nothing
                aUsersQuyen = New ArrayList
                For Each drUsersQuyen In dtUsersQuyen.Rows
                    objUsersQuyen = Converting(drUsersQuyen)
                    aUsersQuyen.Add(objUsersQuyen)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
      
#Region " Function"
        Private Function Converting(ByVal drQuyen As DataRow) As UsersQuyen
            Dim result As UsersQuyen
            Try
                result = New UsersQuyen
                If drQuyen("ID_quyen").ToString() <> "" Then result.ID_quyen = CType(drQuyen("ID_quyen").ToString(), Integer)
                result.Ten_quyen = drQuyen("Ten_quyen").ToString()
                'If drQuyen("ID_ph").ToString() <> "" Then result.ID_ph = CType(drQuyen("ID_ph").ToString(), Integer)
                If drQuyen("ID_nhom_quyen").ToString() <> "" Then result.ID_nhom_quyen = CType(drQuyen("ID_nhom_quyen").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function ConvertingVaiTroQuyen(ByVal drVaiTroQuyen As DataRow) As VaiTroQuyen
            Dim result As VaiTroQuyen
            Try
                result = New VaiTroQuyen
                If drVaiTroQuyen("ID_quyen").ToString() <> "" Then result.ID_quyen = CType(drVaiTroQuyen("ID_quyen").ToString(), Integer)
                result.Ten_quyen = drVaiTroQuyen("Ten_quyen").ToString()
                If drVaiTroQuyen("ID_ph").ToString() <> "" Then result.ID_ph = CType(drVaiTroQuyen("ID_ph").ToString(), Integer)
                If drVaiTroQuyen("ID_nhom_quyen").ToString() <> "" Then result.ID_nhom_quyen = CType(drVaiTroQuyen("ID_nhom_quyen").ToString(), Integer)
                If drVaiTroQuyen("Them").ToString() <> "" Then result.Them = CType(drVaiTroQuyen("Them").ToString(), Integer)
                If drVaiTroQuyen("Sua").ToString() <> "" Then result.Sua = CType(drVaiTroQuyen("Sua").ToString(), Integer)
                If drVaiTroQuyen("Xoa").ToString() <> "" Then result.Xoa = CType(drVaiTroQuyen("Xoa").ToString(), Integer)

            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
   
        Private Function CovertingIntToBool(ByVal Int As Integer) As Boolean
            If Int = 1 Then
                Return True
            ElseIf Int = 0 Then
                Return False
            End If
        End Function
#End Region

    End Class
End Namespace
