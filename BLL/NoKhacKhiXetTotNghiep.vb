Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class NoKhacKhiXetTotNghiep_BLL
        Private arrDanhSachNoKhacXetTotNghiep As ArrayList

#Region "Constructor"
        Sub New(ByVal ID_lops As String)
            Try
                arrDanhSachNoKhacXetTotNghiep = New ArrayList
                Dim obj As New NoKhacKhiXetTotNghiep_DAL
                Dim dt As DataTable = obj.DanhSachNoKhacKhiXetTotNghiep_Load_List(ID_lops)
                Dim objEn As New NoKhacKhiXetTotNghiep
                Dim dr As DataRow = Nothing
                For Each dr In dt.Rows
                    objEn = Converting(dr)
                    arrDanhSachNoKhacXetTotNghiep.Add(objEn)
                Next
            Catch ex As Exception
                Throw (ex)
            End Try
        End Sub
#End Region

#Region "Function"
        Public Sub Add(ByVal DSN As NoKhacKhiXetTotNghiep)
            arrDanhSachNoKhacXetTotNghiep.Add(DSN)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrDanhSachNoKhacXetTotNghiep.RemoveAt(idx)
        End Sub

        Public Function DanhSachNoKhacKhiXetTotNghiep() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Ly_do", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(String))
            dt.Columns.Add("ID_SVs", GetType(String))
            Dim ID_svs As String = "-1"
            For i As Integer = 0 To arrDanhSachNoKhacXetTotNghiep.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("ID_sv") = CType(arrDanhSachNoKhacXetTotNghiep(i), NoKhacKhiXetTotNghiep).ID_sv
                row("Ma_sv") = CType(arrDanhSachNoKhacXetTotNghiep(i), NoKhacKhiXetTotNghiep).Ma_sv
                row("Ho_ten") = CType(arrDanhSachNoKhacXetTotNghiep(i), NoKhacKhiXetTotNghiep).Ho_ten
                row("Ten_lop") = CType(arrDanhSachNoKhacXetTotNghiep(i), NoKhacKhiXetTotNghiep).Ten_lop
                row("Ly_do") = CType(arrDanhSachNoKhacXetTotNghiep(i), NoKhacKhiXetTotNghiep).Ly_do
                row("Ngay_sinh") = CType(arrDanhSachNoKhacXetTotNghiep(i), NoKhacKhiXetTotNghiep).Ngay_sinh
                row("Chon") = False
                ID_svs += "," & CType(arrDanhSachNoKhacXetTotNghiep(i), NoKhacKhiXetTotNghiep).ID_sv
                dt.Rows.Add(row)
            Next
            If dt.Rows.Count > 0 Then
                dt.Rows(0).Item("ID_svs") = ID_svs
            End If
            dt.AcceptChanges()
            Return dt
        End Function

        Public Function Insert_NoKhacKhiXetTotNghiep(ByVal objEn As NoKhacKhiXetTotNghiep) As Integer
            Try
                Dim obj As NoKhacKhiXetTotNghiep_DAL = New NoKhacKhiXetTotNghiep_DAL
                Return obj.Insert_NoKhacKhiXetTotNghiep(objEn)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_NoKhacKhiXetTotNghiep(ByVal objEn As NoKhacKhiXetTotNghiep, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As NoKhacKhiXetTotNghiep_DAL = New NoKhacKhiXetTotNghiep_DAL
                Return obj.Update_NoKhacKhiXetTotNghiep(objEn, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_NoKhacKhiXetTotNghiep(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As NoKhacKhiXetTotNghiep_DAL = New NoKhacKhiXetTotNghiep_DAL
                Tim_idx(ID_sv)
                Return obj.Delete_NoKhacKhiXetTotNghiep(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Converting(ByVal dr As DataRow) As NoKhacKhiXetTotNghiep
            Dim result As NoKhacKhiXetTotNghiep
            Try
                result = New NoKhacKhiXetTotNghiep
                If dr("ID_SV").ToString() <> "" Then result.ID_sv = CType(dr("ID_SV").ToString(), Integer)
                result.Ly_do = dr("Ly_do").ToString()
                result.Ma_sv = dr("Ma_sv").ToString()
                result.Ho_ten = dr("Ho_ten").ToString()
                result.Ngay_sinh = dr("Ngay_sinh").ToString()
                result.Ten_lop = dr("Ten_lop").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Function Tim_idx(ByVal ID_sv As Integer) As Integer
            For i As Integer = 0 To arrDanhSachNoKhacXetTotNghiep.Count - 1
                If CType(arrDanhSachNoKhacXetTotNghiep(i), NoKhacKhiXetTotNghiep).ID_sv = ID_sv Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
    End Class
End Namespace