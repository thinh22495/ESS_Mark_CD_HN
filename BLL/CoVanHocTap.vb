Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ThienAn.Entity.Entity
Imports ThienAn.DAL.DBManager
Namespace Business
    Public Class CoVanHocTap_BLL
        Private arrDanhSachSinhVienCoVanHocTap As ArrayList

#Region "Constructor"
        Sub New(ByVal UserName As String)
            Try
                arrDanhSachSinhVienCoVanHocTap = New ArrayList
                Dim obj As New CoVanHocTap_DAL
                Dim dtSVCoVanHT As DataTable = obj.DanhSachSVCoVanHocTap_Load_List(UserName)
                Dim objSVCoVanHT As New CoVanHocTap
                Dim dr As DataRow = Nothing
                For Each dr In dtSVCoVanHT.Rows
                    objSVCoVanHT = Converting(dr)
                    arrDanhSachSinhVienCoVanHocTap.Add(objSVCoVanHT)
                Next
            Catch ex As Exception
                Throw (ex)
            End Try
        End Sub
#End Region

#Region "Function"
        Public Sub Add(ByVal DSN As CoVanHocTap)
            arrDanhSachSinhVienCoVanHocTap.Add(DSN)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrDanhSachSinhVienCoVanHocTap.RemoveAt(idx)
        End Sub

        Public Function DanhSachSVCoVanHocTap() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            Dim ID_svs As String = "-1"
            For i As Integer = 0 To arrDanhSachSinhVienCoVanHocTap.Count - 1
                Dim obj As CoVanHocTap = CType(arrDanhSachSinhVienCoVanHocTap(i), CoVanHocTap)
                Dim row As DataRow = dt.NewRow()
                row("Chon") = False
                row("ID_sv") = obj.ID_sv
                row("Ma_sv") = obj.Ma_sv
                row("Ho_ten") = obj.Ho_ten
                row("Ten_lop") = obj.Ten_lop
                row("Ngay_sinh") = obj.Ngay_sinh
                dt.Rows.Add(row)
            Next
            Return dt
        End Function

        Public Function Insert_CoVanHocTap(ByVal objCoVanHocTap As CoVanHocTap) As Integer
            Try
                Dim obj As CoVanHocTap_DAL = New CoVanHocTap_DAL
                Return obj.Insert_DanhSachSVCoVanHocTap(objCoVanHocTap)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_CoVanHocTap(ByVal objCoVanHocTap As CoVanHocTap, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As CoVanHocTap_DAL = New CoVanHocTap_DAL
                Return obj.Update_DanhSachSVCoVanHocTap(objCoVanHocTap)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_CoVanHocTap(ByVal Ma_sv As String, ByVal UserName As String) As Integer
            Try
                Dim obj As CoVanHocTap_DAL = New CoVanHocTap_DAL
                Return obj.Delete_DanhSachSVCoVanHocTap(Ma_sv, UserName)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Converting(ByVal drThucTap As DataRow) As CoVanHocTap
            Dim result As CoVanHocTap
            Try
                result = New CoVanHocTap
                If drThucTap("ID_SV").ToString() <> "" Then result.ID_sv = CType(drThucTap("ID_SV").ToString(), Integer)
                result.UserName = drThucTap("UserName").ToString()
                result.Ma_sv = drThucTap("Ma_sv").ToString()
                result.Ho_ten = drThucTap("Ho_ten").ToString()
                If drThucTap("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = drThucTap("Ngay_sinh").ToString()
                result.Ten_lop = drThucTap("Ten_lop").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Function Tim_idx(ByVal ID_sv As Integer) As Integer
            For i As Integer = 0 To arrDanhSachSinhVienCoVanHocTap.Count - 1
                If CType(arrDanhSachSinhVienCoVanHocTap(i), CoVanHocTap).ID_sv = ID_sv Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
    End Class
End Namespace