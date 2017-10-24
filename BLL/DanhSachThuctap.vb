Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class DanhSachThuctap_BLL
        Private arrDanhSachThuctap As ArrayList
        'Private arrDanhSachSinhVien As ArrayList

#Region "Constructor"
        Sub New(ByVal ID_lops As String)
            Try
                arrDanhSachThuctap = New ArrayList
                Dim obj As New DanhSachThuctap_DAL
                Dim dtThucTap As DataTable = obj.DanhSachThuctap_Load_List(ID_lops)
                Dim objThucTap As New DanhSachThuctap
                Dim dr As DataRow = Nothing
                For Each dr In dtThucTap.Rows
                    objThucTap = Converting(dr)
                    arrDanhSachThuctap.Add(objThucTap)
                Next
            Catch ex As Exception
                Throw (ex)
            End Try
        End Sub
#End Region

#Region "Function"
        Public Sub Add(ByVal DSN As DanhSachThuctap)
            arrDanhSachThuctap.Add(DSN)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrDanhSachThuctap.RemoveAt(idx)
        End Sub

        Public Function DanhSachThucTap() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon1", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv2", GetType(String))
            dt.Columns.Add("Ho_ten2", GetType(String))
            dt.Columns.Add("Ten_lop2", GetType(String))
            dt.Columns.Add("Noi_thuc_tap", GetType(String))
            dt.Columns.Add("Ngay_sinh2", GetType(String))
            dt.Columns.Add("ID_SVs", GetType(String))
            Dim ID_svs As String = "-1"
            For i As Integer = 0 To arrDanhSachThuctap.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("ID_sv") = CType(arrDanhSachThuctap(i), DanhSachThuctap).ID_sv
                row("Ma_sv2") = CType(arrDanhSachThuctap(i), DanhSachThuctap).Ma_sv
                row("Ho_ten2") = CType(arrDanhSachThuctap(i), DanhSachThuctap).Ho_ten
                row("Ten_lop2") = CType(arrDanhSachThuctap(i), DanhSachThuctap).Ten_lop
                row("Noi_thuc_tap") = CType(arrDanhSachThuctap(i), DanhSachThuctap).Noi_thuc_tap
                row("Ngay_sinh2") = CType(arrDanhSachThuctap(i), DanhSachThuctap).Ngay_sinh
                row("Chon1") = False
                ID_svs += "," & CType(arrDanhSachThuctap(i), DanhSachThuctap).ID_sv
                dt.Rows.Add(row)
            Next
            If dt.Rows.Count > 0 Then
                dt.Rows(0).Item("ID_svs") = ID_svs
            End If
            dt.AcceptChanges()
            Return dt
        End Function

        Public Function Insert_DanhSachThuctap(ByVal objDanhSachThuctap As DanhSachThuctap) As Integer
            Try
                Dim obj As DanhSachThuctap_DAL = New DanhSachThuctap_DAL
                Return obj.Insert_DanhSachThuctap(objDanhSachThuctap)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSachThuctap(ByVal objDanhSachThuctap As DanhSachThuctap, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachThuctap_DAL = New DanhSachThuctap_DAL
                Return obj.Update_DanhSachThuctap(objDanhSachThuctap, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSachThuctap(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachThuctap_DAL = New DanhSachThuctap_DAL
                Tim_idx(ID_sv)
                Return obj.Delete_DanhSachThuctap(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Converting(ByVal drThucTap As DataRow) As DanhSachThuctap
            Dim result As DanhSachThuctap
            Try
                result = New DanhSachThuctap
                If drThucTap("ID_SV").ToString() <> "" Then result.ID_sv = CType(drThucTap("ID_SV").ToString(), Integer)
                result.Noi_thuc_tap = drThucTap("Noi_thuc_tap").ToString()
                result.Ma_sv = drThucTap("Ma_sv").ToString()
                result.Ho_ten = drThucTap("Ho_ten").ToString()
                result.Ngay_sinh = drThucTap("Ngay_sinh").ToString()
                result.Ten_lop = drThucTap("Ten_lop").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Function Tim_idx(ByVal ID_sv As Integer) As Integer
            For i As Integer = 0 To arrDanhSachThuctap.Count - 1
                If CType(arrDanhSachThuctap(i), DanhSachThuctap).ID_sv = ID_sv Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
    End Class
End Namespace
