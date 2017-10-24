Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ThienAn.Entity.Entity
Imports ThienAn.DAL.DBManager
Namespace Business
    Public Class He_Khoa_Khoa_Lop_BLL
        Private arrHe As ArrayList
        Private arrChuyenNganh As ArrayList
        Private arrChuyenNganh_Nganh As ArrayList
        Private arrNganh As ArrayList
        Private arrCoSo As ArrayList
        Private arrKhoa As ArrayList
        Private arrKhoaHoc As ArrayList

#Region "Constructor"
        Public Sub New()
            Try
                Dim obj As New He_Khoa_Khoa_Lop_DAL
                Dim dt As DataTable
                Dim dr As DataRow = Nothing

                Dim objsvHe As He_Khoa_Khoa_Lop = Nothing
                arrHe = New ArrayList
                dt = obj.Load_He_List
                For Each dr In dt.Rows
                    objsvHe = Converting_He(dr)
                    arrHe.Add(objsvHe)
                Next

                Dim objsvNganh As He_Khoa_Khoa_Lop = Nothing
                arrNganh = New ArrayList
                dt = obj.Load_Nganh_List
                For Each dr In dt.Rows
                    objsvNganh = Converting_Nganh(dr)
                    arrNganh.Add(objsvNganh)
                Next

                Dim objsvChuyenNganh As He_Khoa_Khoa_Lop = Nothing
                arrChuyenNganh = New ArrayList
                dt = obj.Load_ChuyenNganh_List
                For Each dr In dt.Rows
                    objsvChuyenNganh = Converting_ChuyenNganh(dr)
                    arrChuyenNganh.Add(objsvChuyenNganh)
                Next

                'Dim objsvChuyenNganh_Nganh As He_Khoa_Khoa_Lop = Nothing
                'arrChuyenNganh_Nganh = New ArrayList
                'dt = obj.Load_ChuyenNganh_Nganh_List
                'For Each dr In dt.Rows
                '    objsvChuyenNganh_Nganh = Converting_ChuyenNganh(dr)
                '    arrChuyenNganh_Nganh.Add(objsvChuyenNganh_Nganh)
                'Next

                Dim objsvCoSo As He_Khoa_Khoa_Lop = Nothing
                arrCoSo = New ArrayList
                dt = obj.Load_CoSo_List
                For Each dr In dt.Rows
                    objsvCoSo = Converting_CoSoDaoTao(dr)
                    arrCoSo.Add(objsvCoSo)
                Next

                Dim objsvKhoa As He_Khoa_Khoa_Lop = Nothing
                arrKhoa = New ArrayList
                dt = obj.Load_Khoa_List
                For Each dr In dt.Rows
                    objsvKhoa = Converting_Khoa(dr)
                    arrKhoa.Add(objsvKhoa)
                Next

                Dim objsvKhoaHoc As He_Khoa_Khoa_Lop = Nothing
                arrKhoaHoc = New ArrayList
                dt = obj.Load_KhoaHoc_List
                For Each dr In dt.Rows
                    objsvKhoaHoc = Converting_KhoaHoc(dr)
                    arrKhoaHoc.Add(objsvKhoaHoc)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


#End Region

#Region "Function"
        Public Function Fill_He() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("Ten_he", GetType(String))
            For i As Integer = 0 To arrHe.Count - 1
                Dim l As He_Khoa_Khoa_Lop = CType(arrHe(i), He_Khoa_Khoa_Lop)
                Dim row As DataRow = dt.NewRow()
                row("ID_he") = l.ID_he
                row("Ten_he") = l.Ten_he
                dt.Rows.Add(row)
            Next
            Return dt
        End Function

        Public Function Fill_Nganh() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_nganh", GetType(Integer))
            dt.Columns.Add("Ten_nganh", GetType(String))
            For i As Integer = 0 To arrNganh.Count - 1
                Dim l As He_Khoa_Khoa_Lop = CType(arrNganh(i), He_Khoa_Khoa_Lop)
                Dim row As DataRow = dt.NewRow()
                row("ID_nganh") = l.ID_nganh
                row("Ten_nganh") = l.Ten_nganh
                dt.Rows.Add(row)
            Next
            Return dt
        End Function

        Public Function get_ID_Nganh(ByVal ID_chuyen_nganh As Integer) As Integer
            Dim dt As New DataTable
            For i As Integer = 0 To arrChuyenNganh.Count - 1
                Dim l As He_Khoa_Khoa_Lop = CType(arrChuyenNganh(i), He_Khoa_Khoa_Lop)
                If l.ID_chuyen_nganh = ID_chuyen_nganh Then
                    Return l.ID_nganh
                End If
            Next
            Return 0
        End Function

        Public Function Fill_CoSoDaoTao() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_co_so", GetType(Integer))
            dt.Columns.Add("Ten_co_so", GetType(String))
            For i As Integer = 0 To arrCoSo.Count - 1
                Dim l As He_Khoa_Khoa_Lop = CType(arrCoSo(i), He_Khoa_Khoa_Lop)
                Dim row As DataRow = dt.NewRow()
                row("ID_co_so") = l.ID_co_so
                row("Ten_co_so") = l.Ten_co_so
                dt.Rows.Add(row)
            Next
            Return dt
        End Function

        Public Function Fill_Khoa() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("Ten_khoa", GetType(String))
            For i As Integer = 0 To arrKhoa.Count - 1
                Dim l As He_Khoa_Khoa_Lop = CType(arrKhoa(i), He_Khoa_Khoa_Lop)
                Dim row As DataRow = dt.NewRow()
                row("ID_khoa") = l.ID_khoa
                row("Ten_khoa") = l.Ten_khoa
                dt.Rows.Add(row)
            Next
            Return dt
        End Function

        Public Function Fill_ChuyenNganh() As DataTable
            Dim dt As New DataTable
            'dt.Columns.Add("ID_nganh", GetType(Integer))
            dt.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dt.Columns.Add("Chuyen_nganh", GetType(String))
            For i As Integer = 0 To arrChuyenNganh.Count - 1
                Dim l As He_Khoa_Khoa_Lop = CType(arrChuyenNganh(i), He_Khoa_Khoa_Lop)
                'dt.DefaultView.RowFilter = "ID_nganh=" + l.ID_nganh
                Dim row As DataRow = dt.NewRow()
                'row("ID_nganh") = l.ID_nganh
                row("ID_chuyen_nganh") = l.ID_chuyen_nganh
                row("Chuyen_nganh") = l.Chuyen_nganh
                dt.Rows.Add(row)
            Next
            Return dt
        End Function

        Public Function Fill_ChuyenNganh_Nganh(ByVal ID_nganh As String) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dt.Columns.Add("Chuyen_nganh", GetType(String))
            For i As Integer = 0 To arrChuyenNganh.Count - 1
                Dim l As He_Khoa_Khoa_Lop = CType(arrChuyenNganh(i), He_Khoa_Khoa_Lop)
                If l.ID_nganh = ID_nganh Then
                    Dim row As DataRow = dt.NewRow()
                    row("ID_chuyen_nganh") = l.ID_chuyen_nganh
                    row("Chuyen_nganh") = l.Chuyen_nganh
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function

        Private Function Converting_He(ByVal drHe As DataRow) As He_Khoa_Khoa_Lop
            Dim result As He_Khoa_Khoa_Lop
            Try
                result = New He_Khoa_Khoa_Lop
                If drHe("ID_he").ToString() <> "" Then result.ID_he = CType(drHe("ID_he").ToString(), Integer)
                result.Ten_he = drHe("Ten_he").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function Converting_ChuyenNganh(ByVal drChuyenNganh As DataRow) As He_Khoa_Khoa_Lop
            Dim result As He_Khoa_Khoa_Lop
            Try
                result = New He_Khoa_Khoa_Lop
                If drChuyenNganh("ID_chuyen_nganh").ToString() <> "" Then result.ID_chuyen_nganh = CType(drChuyenNganh("ID_chuyen_nganh").ToString(), Integer)
                result.Chuyen_nganh = drChuyenNganh("Chuyen_nganh").ToString()
                If drChuyenNganh("ID_nganh").ToString() <> "" Then result.ID_nganh = CType(drChuyenNganh("ID_nganh").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function Converting_Nganh(ByVal drNganh As DataRow) As He_Khoa_Khoa_Lop
            Dim result As He_Khoa_Khoa_Lop
            Try
                result = New He_Khoa_Khoa_Lop
                If drNganh("ID_nganh").ToString() <> "" Then result.ID_nganh = CType(drNganh("ID_nganh").ToString(), Integer)
                result.Ten_nganh = drNganh("Ten_nganh").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Private Function Converting_CoSoDaoTao(ByVal drCoSoDaoTao As DataRow) As He_Khoa_Khoa_Lop
            Dim result As He_Khoa_Khoa_Lop
            Try
                result = New He_Khoa_Khoa_Lop
                If drCoSoDaoTao("ID_co_so").ToString() <> "" Then result.ID_co_so = CType(drCoSoDaoTao("ID_co_so").ToString(), Integer)
                result.Ten_co_so = drCoSoDaoTao("Ten_co_so").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function Converting_Khoa(ByVal drKhoa As DataRow) As He_Khoa_Khoa_Lop
            Dim result As He_Khoa_Khoa_Lop
            Try
                result = New He_Khoa_Khoa_Lop
                If drKhoa("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drKhoa("ID_khoa").ToString(), Integer)
                result.Ten_khoa = drKhoa("Ten_khoa").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Private Function Converting_KhoaHoc(ByVal drKhoa_hoc As DataRow) As He_Khoa_Khoa_Lop
            Dim result As He_Khoa_Khoa_Lop
            Try
                result = New He_Khoa_Khoa_Lop
                If drKhoa_hoc("Khoa_hoc").ToString() <> "" Then result.khoa_hoc = CType(drKhoa_hoc("Khoa_hoc").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Public Function Fill_KhoaHoc() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            For i As Integer = 0 To arrKhoaHoc.Count - 1
                Dim l As He_Khoa_Khoa_Lop = CType(arrKhoaHoc(i), He_Khoa_Khoa_Lop)
                Dim row As DataRow = dt.NewRow()
                row("Khoa_hoc") = l.Khoa_Hoc
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
#End Region
    End Class
End Namespace