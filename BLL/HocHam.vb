'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, June 17, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class HocHam_BLL
        Private arrHocHam As ArrayList

#Region "Constructor"
        Public Sub New()
            'Add tat ca Hoc ham
            Try
                arrHocHam = New ArrayList
                Dim objHocHam_dal As New HocHam_DAL
                Dim dt As DataTable = objHocHam_dal.Load_HocHam_List()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objHocHam As New HocHam
                        objHocHam = Converting(dt.Rows(i))
                        arrHocHam.Add(objHocHam)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function DanhMucHocHam() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_hoc_ham", GetType(Integer))
            dt.Columns.Add("Hoc_ham", GetType(String))
            For i As Integer = 0 To arrHocHam.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objHocHam As HocHam = CType(arrHocHam(i), HocHam)
                row("ID_hoc_ham") = objHocHam.ID_hoc_ham
                row("Hoc_ham") = objHocHam.Hoc_ham
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Public Function Insert_HocHam(ByVal objHocHam As HocHam) As Integer
            Try
                Dim obj As HocHam_DAL = New HocHam_DAL
                Return obj.Insert_HocHam(objHocHam)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_HocHam(ByVal objHocHam As HocHam, ByVal ID_hoc_ham As Integer) As Integer
            Try
                Dim obj As HocHam_DAL = New HocHam_DAL
                Return obj.Update_HocHam(objHocHam, ID_hoc_ham)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_HocHam(ByVal ID_hoc_ham As Integer) As Integer
            Try
                Dim obj As HocHam_DAL = New HocHam_DAL
                Return obj.Delete_HocHam(ID_hoc_ham)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drHocHam As DataRow) As HocHam
            Dim result As HocHam
            Try
                result = New HocHam
                If drHocHam("ID_hoc_ham").ToString() <> "" Then result.ID_hoc_ham = CType(drHocHam("ID_hoc_ham").ToString(), Integer)
                result.Ma_hoc_ham = drHocHam("Ma_hoc_ham").ToString()
                result.Hoc_ham = drHocHam("Hoc_ham").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
