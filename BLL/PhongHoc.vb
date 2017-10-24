'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/25/2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class PhongHoc_BLL
        Private arrPhongHoc As ArrayList
#Region "Constructor"
        Public Sub New()
            Try
                Dim obj As PhongHoc_DAL = New PhongHoc_DAL
                Dim dt As DataTable = obj.Load_PhongHoc_List()
                arrPhongHoc = New ArrayList
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim objPH As New PhongHoc(Ngay_tuan, So_tiet_ngay)
                    objPH = Converting(dt.Rows(i))
                    arrPhongHoc.Add(objPH)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function DanhSachPhongThi(ByVal mclsTCThi As TochucThi_BLL, ByVal ID_nha As Integer, ByRef So_sv_da_chon As Integer) As DataTable
            Dim obj As PhongHoc_DAL = New PhongHoc_DAL
            Dim dt As DataTable = obj.Load_PhongHoc_List()
            If ID_nha > 0 Then dt.DefaultView.RowFilter = "ID_nha=" & ID_nha
            Dim dt_main As New DataTable
            dt_main.Columns.Add("ID_phong_thi", GetType(Integer))
            dt_main.Columns.Add("ID_phong", GetType(Integer))
            dt_main.Columns.Add("Ten_phong_main", GetType(String))
            dt_main.Columns.Add("Suc_chua", GetType(Integer))
            dt_main.Columns.Add("So_sv", GetType(Integer))
            dt_main.Columns.Add("Chon", GetType(Boolean))
            dt_main.Columns.Add("Khong_thay_doi", GetType(Boolean))
            Dim Ten_phong As String = ""
            So_sv_da_chon = 0
            For i As Integer = 0 To dt.DefaultView.Count - 1
                Dim dr As DataRow = dt_main.NewRow
                dr("Chon") = False
                dr("ID_phong_thi") = 0
                dr("ID_phong") = dt.DefaultView.Item(i)("ID_phong")
                If dt.DefaultView.Item(i)("Suc_chua").ToString <> "" Then
                    dr("Suc_chua") = dt.DefaultView.Item(i)("Suc_chua")
                Else
                    dr("Suc_chua") = 0
                End If
                dr("So_sv") = 0
                dr("Ten_phong_main") = dt.DefaultView.Item(i)("Ten_nha").ToString & "-" & dt.DefaultView.Item(i)("So_phong").ToString
                dr("Khong_thay_doi") = False
                For j As Integer = 0 To mclsTCThi.ToChucThi(0).dsPhongThi.Count - 1
                    If mclsTCThi.ToChucThi(0).dsPhongThi.TochucThiPhong(j).Ten_phong = dr("Ten_phong_main").ToString Then
                        So_sv_da_chon += mclsTCThi.ToChucThi(0).dsPhongThi.TochucThiPhong(j).So_sv
                        dr("So_sv") = mclsTCThi.ToChucThi(0).dsPhongThi.TochucThiPhong(j).So_sv
                        dr("Chon") = True
                        dr("ID_phong_thi") = mclsTCThi.ToChucThi(0).dsPhongThi.TochucThiPhong(j).ID_phong_thi
                        dr("Khong_thay_doi") = True
                    End If
                Next
                dt_main.Rows.Add(dr)
            Next
            Return dt_main
        End Function
        Public Function DanhSachPhongHoc() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_phong", GetType(Integer))
            dt.Columns.Add("ID_co_so", GetType(Integer))
            dt.Columns.Add("ID_nha", GetType(Integer))
            dt.Columns.Add("ID_tang", GetType(Integer))
            dt.Columns.Add("So_phong", GetType(String))
            dt.Columns.Add("Ten_co_so", GetType(String))
            dt.Columns.Add("Suc_chua", GetType(Integer))
            dt.Columns.Add("So_sv", GetType(Integer))
            dt.Columns.Add("Ten_nha", GetType(String))
            dt.Columns.Add("Ten_loai_phong", GetType(String))
            dt.Columns.Add("Ten_tang", GetType(String))
            dt.Columns.Add("ID_loai_phong", GetType(Integer))
            dt.Columns.Add("Thiet_bi", GetType(String))
            For i As Integer = 0 To arrPhongHoc.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objPhongHoc As PhongHoc = CType(arrPhongHoc(i), PhongHoc)
                row("ID_co_so") = objPhongHoc.ID_co_so
                row("Ten_co_so") = objPhongHoc.Ten_co_so
                row("ID_phong") = objPhongHoc.ID_phong
                row("ID_nha") = objPhongHoc.ID_nha
                row("ID_tang") = objPhongHoc.ID_tang
                row("So_phong") = objPhongHoc.So_phong
                row("Suc_chua") = objPhongHoc.Suc_chua
                row("So_sv") = objPhongHoc.So_sv
                row("Ten_nha") = objPhongHoc.Ten_nha
                row("Ten_loai_phong") = objPhongHoc.Ten_loai_phong
                row("Ten_tang") = objPhongHoc.Ten_tang
                row("ID_loai_phong") = objPhongHoc.ID_loai_phong
                row("Thiet_bi") = objPhongHoc.Thiet_bi
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Public Function DanhSachPhanPhongHocLyThuyet() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_phong", GetType(Integer))
            dt.Columns.Add("ID_nha", GetType(Integer))
            dt.Columns.Add("ID_co_so", GetType(Integer))
            dt.Columns.Add("Phan_vao_lop", GetType(String))
            dt.Columns.Add("Ten_phong", GetType(String))
            dt.Columns.Add("Suc_chua", GetType(Integer))
            dt.Columns.Add("Ten_loai_phong", GetType(String))
            For i As Integer = 0 To arrPhongHoc.Count - 1
                Dim objPhongHoc As PhongHoc = CType(arrPhongHoc(i), PhongHoc)
                'Chỉ lấy phòng lý thuyết
                If objPhongHoc.Thuc_hanh = False Then
                    Dim row As DataRow = dt.NewRow()
                    row("ID_phong") = objPhongHoc.ID_phong
                    row("ID_nha") = objPhongHoc.ID_nha
                    row("ID_co_so") = objPhongHoc.ID_co_so
                    row("Ten_phong") = objPhongHoc.So_phong
                    row("Suc_chua") = objPhongHoc.Suc_chua
                    row("Ten_loai_phong") = objPhongHoc.Ten_loai_phong
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function DanhSachPhanPhongHocThucHanh() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_phong", GetType(Integer))
            dt.Columns.Add("ID_nha", GetType(Integer))
            dt.Columns.Add("ID_co_so", GetType(Integer))
            dt.Columns.Add("Phan_vao_lop", GetType(String))
            dt.Columns.Add("Ten_phong", GetType(String))
            dt.Columns.Add("Suc_chua", GetType(Integer))
            dt.Columns.Add("Ten_loai_phong", GetType(String))
            For i As Integer = 0 To arrPhongHoc.Count - 1
                Dim objPhongHoc As PhongHoc = CType(arrPhongHoc(i), PhongHoc)
                'Chỉ lấy phòng thực hành
                If objPhongHoc.Thuc_hanh = True Then
                    Dim row As DataRow = dt.NewRow()
                    row("ID_phong") = objPhongHoc.ID_phong
                    row("ID_nha") = objPhongHoc.ID_nha
                    row("ID_co_so") = objPhongHoc.ID_co_so
                    row("Ten_phong") = objPhongHoc.So_phong
                    row("Suc_chua") = objPhongHoc.Suc_chua
                    row("Ten_loai_phong") = objPhongHoc.Ten_loai_phong
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function DanhSachPhanPhongHoc(ByVal ID_nha As Integer, Optional ByVal ID_co_so As Integer = 0) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_phong", GetType(Integer))
            dt.Columns.Add("Ten_phong", GetType(String))
            dt.Columns.Add("Suc_chua", GetType(Integer))
            dt.Columns.Add("Ten_loai_phong", GetType(String))
            For i As Integer = 0 To arrPhongHoc.Count - 1
                Dim objPhongHoc As PhongHoc = CType(arrPhongHoc(i), PhongHoc)
                If ID_nha > 0 And ID_co_so <= 0 Then
                    If objPhongHoc.ID_nha = ID_nha Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_phong") = objPhongHoc.ID_phong
                        row("Ten_phong") = objPhongHoc.So_phong
                        row("Suc_chua") = objPhongHoc.Suc_chua
                        row("Ten_loai_phong") = objPhongHoc.Ten_loai_phong
                        dt.Rows.Add(row)
                    End If
                ElseIf ID_nha > 0 And ID_co_so > 0 Then
                    If objPhongHoc.ID_nha = ID_nha And objPhongHoc.ID_co_so = ID_co_so Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_phong") = objPhongHoc.ID_phong
                        row("Ten_phong") = objPhongHoc.So_phong
                        row("Suc_chua") = objPhongHoc.Suc_chua
                        row("Ten_loai_phong") = objPhongHoc.Ten_loai_phong
                        dt.Rows.Add(row)
                    End If
                ElseIf ID_nha <= 0 And ID_co_so > 0 Then
                    If objPhongHoc.ID_co_so = ID_co_so Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_phong") = objPhongHoc.ID_phong
                        row("Ten_phong") = objPhongHoc.So_phong
                        row("Suc_chua") = objPhongHoc.Suc_chua
                        row("Ten_loai_phong") = objPhongHoc.Ten_loai_phong
                        dt.Rows.Add(row)
                    End If
                Else
                    Dim row As DataRow = dt.NewRow()
                    row("ID_phong") = objPhongHoc.ID_phong
                    row("Ten_phong") = objPhongHoc.So_phong
                    row("Suc_chua") = objPhongHoc.Suc_chua
                    row("Ten_loai_phong") = objPhongHoc.Ten_loai_phong
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function DanhSachPhongHocList() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_phong", GetType(Integer))
            dt.Columns.Add("Ten_phong", GetType(String))
            For i As Integer = 0 To arrPhongHoc.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objPhongHoc As PhongHoc = CType(arrPhongHoc(i), PhongHoc)
                row("ID_phong") = objPhongHoc.ID_phong
                row("Ten_phong") = objPhongHoc.Ten_phong
                dt.Rows.Add(row)
            Next
            Dim row1 As DataRow = dt.NewRow()
            row1("ID_phong") = 0
            row1("Ten_phong") = ""
            dt.Rows.Add(row1)
            Return dt
        End Function

        Public Function Insert_PhongHoc(ByVal objPhongHoc As PhongHoc) As Integer
            Try
                Dim obj As PhongHoc_DAL = New PhongHoc_DAL
                Return obj.Insert_PhongHoc(objPhongHoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_PhongHoc(ByVal objPhongHoc As PhongHoc, ByVal ID_phong As Integer) As Integer
            Try
                Dim obj As PhongHoc_DAL = New PhongHoc_DAL
                Return obj.Update_PhongHoc(objPhongHoc, ID_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_PhongHoc(ByVal ID_phong As Integer) As Integer
            Try
                Dim obj As PhongHoc_DAL = New PhongHoc_DAL
                Return obj.Delete_PhongHoc(ID_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drPhongHoc As DataRow) As PhongHoc
            Dim result As PhongHoc
            Try
                result = New PhongHoc(Ngay_tuan, So_tiet_ngay)
                If drPhongHoc("ID_phong").ToString() <> "" Then result.ID_phong = CType(drPhongHoc("ID_phong").ToString(), Integer)
                If drPhongHoc("ID_nha").ToString() <> "" Then result.ID_nha = CType(drPhongHoc("ID_nha").ToString(), Integer)
                If drPhongHoc("ID_tang").ToString() <> "" Then result.ID_tang = CType(drPhongHoc("ID_tang").ToString(), Integer)
                If drPhongHoc("ID_co_so").ToString() <> "" Then result.ID_co_so = CType(drPhongHoc("ID_co_so").ToString(), Integer)
                result.So_phong = drPhongHoc("So_phong").ToString()
                If drPhongHoc("Suc_chua").ToString() <> "" Then result.Suc_chua = CType(drPhongHoc("Suc_chua").ToString(), Integer)
                If drPhongHoc("So_sv").ToString() <> "" Then result.So_sv = CType(drPhongHoc("So_sv").ToString(), Integer)
                If drPhongHoc("ID_loai_phong").ToString() <> "" Then result.ID_loai_phong = CType(drPhongHoc("ID_loai_phong").ToString(), Integer)
                result.Thiet_bi = drPhongHoc("Thiet_bi").ToString()
                result.Ten_nha = drPhongHoc("Ten_nha").ToString()
                result.Ten_tang = drPhongHoc("Ten_tang").ToString()
                result.Ten_loai_phong = drPhongHoc("Ten_loai_phong").ToString()
                result.Ten_co_so = drPhongHoc("Ten_co_so").ToString()
                result.Ten_phong = result.So_phong
                If drPhongHoc("ID_loai_phong").ToString = "4" Or drPhongHoc("Thuc_hanh").ToString = "True" Then
                    result.Thuc_hanh = True
                Else
                    result.Thuc_hanh = False
                End If
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Public Function Tim_Ten_phong(ByVal ID_phong As Integer) As String
            For i As Integer = 0 To arrPhongHoc.Count - 1
                Dim ph As PhongHoc = CType(arrPhongHoc(i), PhongHoc)
                If ph.ID_phong = ID_phong Then
                    Return ph.So_phong
                End If
            Next
            Return ""
        End Function
        Public Function Tim_ID_phong(ByVal Ten_phong As String) As Integer
            For i As Integer = 0 To arrPhongHoc.Count - 1
                Dim ph As PhongHoc = CType(arrPhongHoc(i), PhongHoc)
                If ph.So_phong = Ten_phong Then
                    Return ph.ID_phong
                End If
            Next
            Return -1
        End Function
        Public Function Tim_chi_so(ByVal ID_phong As Integer) As Integer
            For i As Integer = 0 To arrPhongHoc.Count - 1
                Dim ph As PhongHoc = CType(arrPhongHoc(i), PhongHoc)
                If ph.ID_phong = ID_phong Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.arrPhongHoc.Count
            End Get
        End Property
        Public Property Phong_hoc(ByVal idx As Integer) As PhongHoc
            Get
                Return CType(Me.arrPhongHoc(idx), PhongHoc)
            End Get
            Set(ByVal Value As PhongHoc)
                Me.arrPhongHoc(idx) = Value
            End Set
        End Property
        Public Function CheckExist_TenPhongHoc(ByVal ID_co_so As Integer, ByVal ID_nha As Integer, ByVal ID_tang As Integer, ByVal So_phong As String) As Boolean
            Try
                Dim obj As PhongHoc_DAL = New PhongHoc_DAL
                Return obj.CheckExist_TenPhongHoc(ID_co_so, ID_nha, ID_tang, So_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetPhongHoc(ByVal ID_phong As Integer) As PhongHoc
            Dim idx As Integer = SearchIndex(ID_phong)
            Return arrPhongHoc(idx)
        End Function
        Private Function SearchIndex(ByVal ID_phong As Integer) As Integer
            For i As Integer = 0 To arrPhongHoc.Count - 1
                If CType(arrPhongHoc(i), PhongHoc).ID_phong = ID_phong Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
    End Class
End Namespace
