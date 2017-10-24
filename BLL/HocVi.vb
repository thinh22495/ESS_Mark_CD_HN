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
    Public Class HocVi_BLL
        Private arrHocVi As ArrayList

#Region "Constructor"
        Public Sub New()
            'Add tat ca Hoc vi
            Try
                arrHocVi = New ArrayList
                Dim objHocVi_dal As New HocVi_DAL
                Dim dt As DataTable = objHocVi_dal.Load_HocVi_List()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objHocVi As New HocVi
                        objHocVi = Converting(dt.Rows(i))
                        arrHocVi.Add(objHocVi)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function DanhMucHocVi() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_hoc_vi", GetType(Integer))
            dt.Columns.Add("Hoc_vi", GetType(String))
            For i As Integer = 0 To arrHocVi.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objHocVi As HocVi = CType(arrHocVi(i), HocVi)
                row("ID_hoc_vi") = objHocVi.ID_hoc_vi
                row("Hoc_vi") = objHocVi.Hoc_vi
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Public Function Insert_HocVi(ByVal objHocVi As HocVi) As Integer
            Try
                Dim obj As HocVi_DAL = New HocVi_DAL
                Return obj.Insert_HocVi(objHocVi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_HocVi(ByVal objHocVi As HocVi, ByVal ID_hoc_vi As Integer) As Integer
            Try
                Dim obj As HocVi_DAL = New HocVi_DAL
                Return obj.Update_HocVi(objHocVi, ID_hoc_vi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_HocVi(ByVal ID_hoc_vi As Integer) As Integer
            Try
                Dim obj As HocVi_DAL = New HocVi_DAL
                Return obj.Delete_HocVi(ID_hoc_vi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drHocVi As DataRow) As HocVi
            Dim result As HocVi
            Try
                result = New HocVi
                If drHocVi("ID_hoc_vi").ToString() <> "" Then result.ID_hoc_vi = CType(drHocVi("ID_hoc_vi").ToString(), Integer)
                result.Ma_hoc_vi = drHocVi("Ma_hoc_vi").ToString()
                result.Hoc_vi = drHocVi("Hoc_vi").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
