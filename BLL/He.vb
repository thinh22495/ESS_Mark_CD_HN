'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, July 08, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class He_BLL
        Private arrHe As ArrayList

#Region "Constructor"
        Public Sub New()
            'Add tat ca He
            Try
                arrHe = New ArrayList
                Dim objHe_dal As New He_DAL
                Dim dt As DataTable = objHe_dal.Load_He_List()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objHe As New He
                        objHe = Converting(dt.Rows(i))
                        arrHe.Add(objHe)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function DanhMucHe() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_He", GetType(Integer))
            dt.Columns.Add("Ten_He", GetType(String))
            For i As Integer = 0 To arrHe.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objHe As He = CType(arrHe(i), He)
                row("ID_He") = objHe.ID_he
                row("Ten_He") = objHe.Ten_he
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Public Function Insert_He(ByVal objHe As He) As Integer
            Try
                Dim obj As He_DAL = New He_DAL
                Return obj.Insert_He(objHe)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_He(ByVal objHe As He, ByVal ID_he As Integer) As Integer
            Try
                Dim obj As He_DAL = New He_DAL
                Return obj.Update_He(objHe, ID_he)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_He(ByVal ID_he As Integer) As Integer
            Try
                Dim obj As He_DAL = New He_DAL
                Return obj.Delete_He(ID_he)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_He(ByVal ID_he As Integer) As Boolean
            Try
                Dim obj As He_DAL = New He_DAL
                obj.CheckExist_He(ID_he)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drHe As DataRow) As He
            Dim result As He
            Try
                result = New He
                If drHe("ID_he").ToString() <> "" Then result.ID_he = CType(drHe("ID_he").ToString(), Integer)
                result.Ma_he = drHe("Ma_he").ToString()
                result.Ten_he = drHe("Ten_he").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
