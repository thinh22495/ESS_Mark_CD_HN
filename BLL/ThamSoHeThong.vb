'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/05/2008
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.DirectoryServices
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Imports ESS.Library
Namespace Business
    Public Class ThamSoHeThong_BLL
#Region "Variable"
        Public aThamSoHeThongs As ArrayList
#End Region

#Region "Constructor"
        Public Sub New()

        End Sub
        Public Sub New(ByVal ID_ph As Integer)
            Try
                aThamSoHeThongs = New ArrayList
                Dim obj As ThamSoHeThong_DAL = New ThamSoHeThong_DAL
                Dim dtThamSoHeThong As DataTable
                dtThamSoHeThong = obj.Load_ThamSoHeThong_List(ID_ph)
                If dtThamSoHeThong.Rows.Count > 0 Then
                    For i As Integer = 0 To dtThamSoHeThong.Rows.Count - 1
                        Dim objThamSoHeThong As New ThamSoHeThong
                        objThamSoHeThong = Converting(dtThamSoHeThong.Rows(i))
                        aThamSoHeThongs.Add(objThamSoHeThong)
                    Next
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Add(ByVal thamsohethong As ThamSoHeThong)
            aThamSoHeThongs.Add(thamsohethong)
        End Sub
        Public Sub Remove(ByVal idx_Thamsohethong As Integer)
            aThamSoHeThongs.RemoveAt(idx_Thamsohethong)
        End Sub
#End Region

#Region "Function"
        Public Function Doc_tham_so(ByVal key As String) As String
            Try
                Dim cls As New ThamSoHeThong_DAL
                Return cls.Doc_tham_so(key)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Doc_tham_so_Active(ByVal key As String) As Boolean
            Try
                Dim cls As New ThamSoHeThong_DAL
                Return cls.Doc_tham_so_Active(key)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

      
        Public Function Load_ThamSoHeThong() As DataTable
            Try
                Dim dt As New DataTable, i As Integer '= obj.Load_ThamSoHeThong_List()
                dt.Columns.Add("ID_tham_so", GetType(String))
                dt.Columns.Add("Ten_tham_so", GetType(String))
                dt.Columns.Add("Gia_tri", GetType(String))
                dt.Columns.Add("Ghi_chu", GetType(String))
                dt.Columns.Add("ID_ph", GetType(Integer))
                dt.Columns.Add("Active", GetType(Integer))
                For i = 0 To aThamSoHeThongs.Count - 1
                    Dim objThamSoHeThong As ThamSoHeThong = CType(aThamSoHeThongs(i), ThamSoHeThong)
                    Dim row As DataRow = dt.NewRow()
                    row("ID_tham_so") = objThamSoHeThong.ID_tham_so
                    row("Ten_tham_so") = objThamSoHeThong.Ten_tham_so
                    row("Gia_tri") = objThamSoHeThong.Gia_tri
                    row("Ghi_chu") = objThamSoHeThong.Ghi_chu
                    row("ID_ph") = objThamSoHeThong.ID_ph
                    row("Active") = objThamSoHeThong.Active
                    dt.Rows.Add(row)
                Next
                dt.AcceptChanges()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
       
        Public Function Update_ThamSoHeThong(ByVal objThamSoHeThong As ThamSoHeThong, ByVal ID_tham_so As String) As Integer
            Try
                Dim obj As ThamSoHeThong_DAL = New ThamSoHeThong_DAL
                Return obj.Update_ThamSoHeThong(objThamSoHeThong, ID_tham_so)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_ThamSoHeThong(ByVal objThamSoHeThong As ThamSoHeThong) As Integer
            Try
                Dim obj As ThamSoHeThong_DAL = New ThamSoHeThong_DAL
                Return obj.Update_ThamSoHeThong(objThamSoHeThong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Converting(ByVal drThamSoHeThong As DataRow) As ThamSoHeThong
            Dim result As ThamSoHeThong
            Try
                result = New ThamSoHeThong
                result.ID_tham_so = drThamSoHeThong("ID_tham_so").ToString()
                result.Ten_tham_so = drThamSoHeThong("Ten_tham_so").ToString()
                If drThamSoHeThong("ID_ph").ToString() <> "" Then result.ID_ph = CType(drThamSoHeThong("ID_ph").ToString(), Integer)
                result.Gia_tri = drThamSoHeThong("Gia_tri").ToString()
                result.Ghi_chu = drThamSoHeThong("Ghi_chu").ToString()
                result.Active = drThamSoHeThong("Active").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region

    End Class
End Namespace
