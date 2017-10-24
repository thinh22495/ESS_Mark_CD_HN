'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Monday, June 30, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class Tang_BLL
        Private arrTang As ArrayList

#Region "Constructor"
        Public Sub New()
            'Add tat ca Chuc vu
            Try
                arrTang = New ArrayList
                Dim objTang_dal As New Tang_DAL
                Dim dt As DataTable = objTang_dal.Load_Tang_List()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objTang As New Tang
                        objTang = Converting(dt.Rows(i))
                        arrTang.Add(objTang)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function DanhMucTang() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_TANG", GetType(Integer))
                dt.Columns.Add("Ten_tang", GetType(String))
                For i As Integer = 0 To arrTang.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objTang As Tang = CType(arrTang(i), Tang)
                    row("ID_TANG") = objTang.ID_TANG
                    row("Ten_tang") = objTang.Ten_tang
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_Tang(ByVal objTang As Tang) As Integer
            Try
                Dim obj As Tang_DAL = New Tang_DAL
                Return obj.Insert_Tang(objTang)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Tang(ByVal objTang As Tang, ByVal ID_TANG As Integer) As Integer
            Try
                Dim obj As Tang_DAL = New Tang_DAL
                Return obj.Update_Tang(objTang, ID_TANG)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_Tang(ByVal ID_TANG As Integer) As Integer
            Try
                Dim obj As Tang_DAL = New Tang_DAL
                Return obj.Delete_Tang(ID_TANG)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_Tang(ByVal ID_TANG As Integer) As Boolean
            Try
                Dim obj As Tang_DAL = New Tang_DAL
                obj.CheckExist_Tang(ID_TANG)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drTang As DataRow) As Tang
            Dim result As Tang
            Try
                result = New Tang
                If drTang("ID_TANG").ToString() <> "" Then result.ID_TANG = CType(drTang("ID_TANG").ToString(), Integer)
                result.Ma_tang = drTang("Ma_tang").ToString()
                result.Ten_tang = drTang("Ten_tang").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
