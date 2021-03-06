'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/02/2008
'---------------------------------------------------------------------------


Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class Lop_BLL
        Private arrLop As ArrayList
#Region "Constructor"
        Public Sub New()
            Try
                Dim obj As Lop_DAL = New Lop_DAL
                Dim dt As DataTable = obj.Load_Lop_List_ChiTiet()
                Dim objsvLop As Lop = Nothing
                Dim dr As DataRow = Nothing
                arrLop = New ArrayList
                For Each dr In dt.Rows
                    objsvLop = ConvertingChiTiet(dr)
                    arrLop.Add(objsvLop)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal dsID_lop As String, ByVal Tinh_chat As Integer, ByVal Lop_chuyen_nganh As Integer, ByVal Lop_hanh_chinh As Integer)
            Try
                Dim obj As Lop_DAL = New Lop_DAL
                Dim dt As DataTable = obj.Load_Lop_List(dsID_lop, Tinh_chat, Lop_chuyen_nganh, Lop_hanh_chinh)
                Dim objsvLop As Lop = Nothing
                Dim dr As DataRow = Nothing
                arrLop = New ArrayList
                For Each dr In dt.Rows
                    objsvLop = Converting(dr)
                    arrLop.Add(objsvLop)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.arrLop.Count
            End Get
        End Property
        Public Property Lop(ByVal idx As Integer) As Lop
            Get
                Return CType(Me.arrLop(idx), Lop)
            End Get
            Set(ByVal Value As Lop)
                Me.arrLop(idx) = Value
            End Set
        End Property
        ' Lấy một vài thông tin về sinh viên
        Public Function GetInFoSv(ByVal ID_sv As Integer) As DataTable
            Try
                Dim obj As Lop_DAL = New Lop_DAL
                Return obj.GetInFoSv(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ChuyenNhanh(ByVal Id_he As Integer, ByVal Id_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim cls As Lop_DAL = New Lop_DAL
                Return cls.Load_ChuyenNhanh(Id_he, Id_khoa, Khoa_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách lớp theo chuyên nganh
        Public Function Danh_sach_lop(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_lop", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            For i As Integer = 0 To arrLop.Count - 1
                Dim l As Lop = CType(arrLop(i), Lop)
                If l.ID_he = ID_he And _
                    l.ID_khoa = ID_khoa And _
                    l.Khoa_hoc = Khoa_hoc And _
                    l.ID_chuyen_nganh = ID_chuyen_nganh Then
                    Dim row As DataRow = dt.NewRow()
                    row("ID_lop") = l.ID_lop
                    row("Ten_lop") = l.Ten_lop
                    row("Chon") = False
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function

        Public Function Danh_sach_lop_khoa_hoc(ByVal Khoa_hoc As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_lop", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            For i As Integer = 0 To arrLop.Count - 1
                Dim l As Lop = CType(arrLop(i), Lop)
                If l.Khoa_hoc = Khoa_hoc Then
                    Dim row As DataRow = dt.NewRow()
                    row("ID_lop") = l.ID_lop
                    row("Ten_lop") = l.Ten_lop
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function

        Public Function Danh_sach_lop_dang_hoc() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_lop", GetType(Integer))
            dt.Columns.Add("ID_dt", GetType(Integer))
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("ID_nganh", GetType(Integer))
            dt.Columns.Add("Ten_nganh", GetType(String))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            dt.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dt.Columns.Add("Ten_he", GetType(String))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("Chuyen_nganh", GetType(String))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Nien_khoa", GetType(String))
            dt.Columns.Add("So_sv", GetType(String))
            For i As Integer = 0 To arrLop.Count - 1
                Dim l As Lop = CType(arrLop(i), Lop)
                If l.Ra_truong = False Then
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("ID_lop") = l.ID_lop
                    row("ID_dt") = l.ID_dt
                    row("ID_he") = l.ID_he
                    row("ID_khoa") = l.ID_khoa
                    row("ID_nganh") = l.ID_nganh
                    row("Ten_nganh") = l.Ten_nganh
                    row("Khoa_hoc") = l.Khoa_hoc
                    row("ID_chuyen_nganh") = l.ID_chuyen_nganh
                    row("Ten_he") = l.Ten_he
                    row("Ten_khoa") = l.Ten_khoa
                    row("Chuyen_nganh") = l.Chuyen_nganh
                    row("Ten_lop") = l.Ten_lop
                    row("Nien_khoa") = l.Nien_khoa
                    row("So_sv") = l.So_sv
                    dt.Rows.Add(row)
                End If
            Next
            dt.DefaultView.Sort = "Khoa_hoc"
            Return dt
        End Function
        ' Danh sách lớp đã ra trường và đang học
        Public Function Danh_sach_lop() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_lop", GetType(Integer))
            dt.Columns.Add("ID_dt", GetType(Integer))
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("ID_nganh", GetType(Integer))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            dt.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dt.Columns.Add("Ten_he", GetType(String))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("Chuyen_nganh", GetType(String))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Nien_khoa", GetType(String))
            dt.Columns.Add("So_sv", GetType(String))
            dt.Columns.Add("Ra_truong", GetType(Boolean))
            dt.Columns.Add("Ho_ten_gv", GetType(String))
            dt.Columns.Add("Dien_thoai", GetType(String))
            dt.Columns.Add("Email", GetType(String))
            For i As Integer = 0 To arrLop.Count - 1
                Dim l As Lop = CType(arrLop(i), Lop)
                Dim row As DataRow = dt.NewRow()
                row("Chon") = False
                row("ID_lop") = l.ID_lop
                row("ID_dt") = l.ID_dt
                row("ID_he") = l.ID_he
                row("ID_khoa") = l.ID_khoa
                row("ID_nganh") = l.ID_nganh
                row("Khoa_hoc") = l.Khoa_hoc
                row("ID_chuyen_nganh") = l.ID_chuyen_nganh
                row("Ten_he") = l.Ten_he
                row("Ten_khoa") = l.Ten_khoa
                row("Chuyen_nganh") = l.Chuyen_nganh
                row("Ten_lop") = l.Ten_lop
                row("Nien_khoa") = l.Nien_khoa
                row("So_sv") = l.So_sv
                row("Ho_ten_gv") = l.Ho_ten_gv
                row("Dien_thoai") = l.Dien_thoai
                row("Email") = l.Email
                row("Ra_truong") = l.Ra_truong
                dt.Rows.Add(row)
            Next
            Return dt
        End Function

        Public Function DanhSachLop() As DataTable
            Dim dt As New DataTable
            Dim flag As Boolean = False
            dt.Columns.Add("ID_lop", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            dt.Columns.Add("ID_nganh", GetType(Integer))
            dt.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            For i As Integer = 0 To arrLop.Count - 1
                Dim l As Lop = CType(arrLop(i), Lop)
                dt.DefaultView.RowFilter = "ID_lop=" + l.ID_lop.ToString
                If dt.DefaultView.Count <= 0 Then
                    Dim row As DataRow = dt.NewRow()
                    row("ID_lop") = l.ID_lop
                    row("Ten_lop") = l.Ten_lop
                    row("ID_he") = l.ID_he
                    row("ID_khoa") = l.ID_khoa
                    row("Khoa_hoc") = l.Khoa_hoc
                    row("ID_nganh") = l.ID_nganh
                    row("ID_chuyen_nganh") = l.ID_chuyen_nganh
                    dt.Rows.Add(row)
                End If
            Next
            dt.DefaultView.RowFilter = ""
            Return dt
        End Function

        Public Function Lop_List() As DataTable
            Dim dt As New DataTable
            Dim flag As Boolean = False
            dt.Columns.Add("ID_lop", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("Ten_he", GetType(String))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            dt.Columns.Add("ID_nganh", GetType(Integer))
            dt.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dt.Columns.Add("ID_dt", GetType(Integer))
            dt.Columns.Add("Nien_khoa", GetType(String))
            dt.Columns.Add("Tinh_chat", GetType(Integer))
            For i As Integer = 0 To arrLop.Count - 1
                Dim l As Lop = CType(arrLop(i), Lop)
                dt.DefaultView.RowFilter = "ID_lop=" + l.ID_lop.ToString
                If dt.DefaultView.Count <= 0 Then
                    Dim row As DataRow = dt.NewRow()
                    row("ID_lop") = l.ID_lop
                    row("Ten_lop") = l.Ten_lop
                    row("ID_he") = l.ID_he
                    row("Ten_he") = l.Ten_he
                    row("ID_khoa") = l.ID_khoa
                    row("Ten_khoa") = l.Ten_khoa
                    row("Khoa_hoc") = l.Khoa_hoc
                    row("ID_nganh") = l.ID_nganh
                    row("ID_chuyen_nganh") = l.ID_chuyen_nganh
                    row("ID_dt") = l.ID_dt
                    row("Nien_khoa") = l.Nien_khoa
                    row("Tinh_chat") = l.Tinh_chat
                    dt.Rows.Add(row)
                End If
            Next
            dt.DefaultView.RowFilter = ""
            Return dt
        End Function

        Public Function DanhSachLopCaHoc(ByVal Ca_hoc As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_lop", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Ten_nganh", GetType(String))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            dt.Columns.Add("Ten_he", GetType(String))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("Chuyen_nganh", GetType(String))
            dt.Columns.Add("Nien_khoa", GetType(String))
            dt.Columns.Add("So_sv", GetType(String))
            dt.Columns.Add("Ca_hoc", GetType(String))
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            For i As Integer = 0 To arrLop.Count - 1
                Dim l As Lop = CType(arrLop(i), Lop)
                If l.Ra_truong = False And l.Ca_hoc = Ca_hoc Then
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("ID_lop") = l.ID_lop
                    row("Ten_nganh") = l.Ten_nganh
                    row("Khoa_hoc") = l.Khoa_hoc
                    row("Ten_he") = l.Ten_he
                    row("Ten_khoa") = l.Ten_khoa
                    row("Chuyen_nganh") = l.Chuyen_nganh
                    row("Ten_lop") = l.Ten_lop
                    row("Nien_khoa") = l.Nien_khoa
                    row("So_sv") = l.So_sv
                    row("Ca_hoc") = CType(l.Ca_hoc, eCA_HOC)
                    row("ID_he") = l.ID_he
                    row("ID_khoa") = l.ID_khoa
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function DanhSachLopPhongHoc() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_lop", GetType(Integer))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("ID_phong", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("So_sv", GetType(String))
            dt.Columns.Add("Ca_hoc", GetType(String))
            dt.Columns.Add("Ten_phong", GetType(String))
            For i As Integer = 0 To arrLop.Count - 1
                Dim l As Lop = CType(arrLop(i), Lop)
                If l.Ra_truong = False Then
                    Dim row As DataRow = dt.NewRow()
                    row("ID_lop") = l.ID_lop
                    row("Khoa_hoc") = l.Khoa_hoc
                    row("ID_he") = l.ID_he
                    row("ID_khoa") = l.ID_khoa
                    row("Ten_lop") = l.Ten_lop
                    row("So_sv") = l.So_sv
                    row("Ca_hoc") = CType(l.Ca_hoc, eCA_HOC)
                    row("ID_phong") = l.ID_phong
                    row("Ten_phong") = l.Ten_phong
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function He_dao_tao() As DataTable
            Dim dt As New DataTable
            Dim flag As Boolean = False
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("Ten_he", GetType(String))
            For i As Integer = 0 To arrLop.Count - 1
                Dim l As Lop = CType(arrLop(i), Lop)
                dt.DefaultView.RowFilter = "ID_he=" + l.ID_he.ToString
                If dt.DefaultView.Count <= 0 Then
                    Dim row As DataRow = dt.NewRow()
                    row("ID_he") = l.ID_he
                    row("Ten_he") = l.Ten_he
                    dt.Rows.Add(row)
                End If
            Next
            dt.DefaultView.RowFilter = ""
            Return dt
        End Function
        Public Function Khoa() As DataTable
            Dim dt As New DataTable
            Dim flag As Boolean = False
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("ID_he", GetType(Integer))
            For i As Integer = 0 To arrLop.Count - 1
                Dim l As New Lop
                l = CType(arrLop(i), Lop)
                dt.DefaultView.RowFilter = "ID_khoa=" & l.ID_khoa.ToString & " AND ID_he=" & l.ID_he
                If dt.DefaultView.Count <= 0 Then
                    Dim row As DataRow = dt.NewRow()
                    row("ID_khoa") = l.ID_khoa
                    row("Ten_khoa") = l.Ten_khoa
                    row("ID_he") = l.ID_he
                    dt.Rows.Add(row)
                End If
            Next
            dt.DefaultView.RowFilter = ""
            Return dt
        End Function
        Public Function Khoa_hoc() As DataTable
            Dim dt As New DataTable
            Dim flag As Boolean = False
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            dt.Columns.Add("Khoa_hoc1", GetType(String))
            dt.Columns.Add("ID_he", GetType(Integer))
            For i As Integer = 0 To arrLop.Count - 1
                Dim l As Lop = CType(arrLop(i), Lop)
                dt.DefaultView.RowFilter = "Khoa_hoc=" & l.Khoa_hoc.ToString
                If dt.DefaultView.Count <= 0 Then
                    Dim row As DataRow = dt.NewRow()
                    row("Khoa_hoc") = l.Khoa_hoc
                    row("Khoa_hoc1") = l.Khoa_hoc
                    row("ID_he") = l.ID_he
                    dt.Rows.Add(row)
                End If
            Next
            dt.DefaultView.RowFilter = ""
            Return dt
        End Function

        Public Function Khoa_hoc_By_He() As DataTable
            Dim dt As New DataTable
            Dim flag As Boolean = False
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            dt.Columns.Add("Khoa_hoc1", GetType(String))
            dt.Columns.Add("ID_he", GetType(Integer))
            For i As Integer = 0 To arrLop.Count - 1
                Dim l As New Lop
                l = CType(arrLop(i), Lop)
                dt.DefaultView.RowFilter = "Khoa_hoc=" & l.Khoa_hoc.ToString & " AND ID_he=" & l.ID_he
                If dt.DefaultView.Count <= 0 Then
                    Dim row As DataRow = dt.NewRow()
                    row("Khoa_hoc") = l.Khoa_hoc
                    row("Khoa_hoc1") = l.Khoa_hoc
                    row("ID_he") = l.ID_he
                    dt.Rows.Add(row)
                End If
            Next
            dt.DefaultView.RowFilter = ""
            Return dt
        End Function


        Public Function Nganh_dao_tao() As DataTable
            Dim dt As New DataTable
            Dim flag As Boolean = False
            dt.Columns.Add("ID_nganh", GetType(Integer))
            dt.Columns.Add("Ten_nganh", GetType(String))
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            For i As Integer = 0 To arrLop.Count - 1
                Dim l As Lop = CType(arrLop(i), Lop)
                dt.DefaultView.RowFilter = "ID_nganh=" + l.ID_nganh.ToString & " AND ID_he=" & l.ID_he
                If dt.DefaultView.Count <= 0 Then
                    Dim row As DataRow = dt.NewRow()
                    row("ID_nganh") = l.ID_nganh
                    row("Ten_nganh") = l.Ten_nganh
                    row("ID_he") = l.ID_he
                    row("ID_khoa") = l.ID_khoa
                    row("Khoa_hoc") = l.Khoa_hoc
                    dt.Rows.Add(row)
                End If
            Next
            dt.DefaultView.RowFilter = ""
            Return dt
        End Function
        Public Function Chuyen_nganh_dao_tao() As DataTable
            Dim dt As New DataTable
            Dim flag As Boolean = False
            dt.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dt.Columns.Add("Ten_chuyen_nganh", GetType(String))
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            dt.Columns.Add("ID_nganh", GetType(Integer))
            For i As Integer = 0 To arrLop.Count - 1
                Dim l As Lop = CType(arrLop(i), Lop)
                dt.DefaultView.RowFilter = "ID_chuyen_nganh=" + l.ID_chuyen_nganh.ToString & " AND ID_he=" & l.ID_he
                If dt.DefaultView.Count <= 0 Then
                    Dim row As DataRow = dt.NewRow()
                    row("ID_chuyen_nganh") = l.ID_chuyen_nganh
                    row("Ten_chuyen_nganh") = l.Chuyen_nganh
                    row("ID_he") = l.ID_he
                    row("ID_khoa") = l.ID_khoa
                    row("Khoa_hoc") = l.Khoa_hoc
                    row("ID_nganh") = l.ID_nganh
                    dt.Rows.Add(row)
                End If
            Next
            dt.DefaultView.RowFilter = ""
            Return dt
        End Function
        Public Function Chuyen_nganh_dao_tao(ByVal ID_nganh As Integer) As DataTable
            Dim dt As New DataTable
            Dim flag As Boolean = False
            dt.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dt.Columns.Add("Ten_chuyen_nganh", GetType(String))
            For i As Integer = 0 To arrLop.Count - 1
                Dim l As Lop = CType(arrLop(i), Lop)
                If l.ID_nganh = ID_nganh Then
                    dt.DefaultView.RowFilter = "ID_chuyen_nganh=" + l.ID_chuyen_nganh.ToString
                    If dt.DefaultView.Count <= 0 Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_chuyen_nganh") = l.ID_chuyen_nganh
                        row("Ten_chuyen_nganh") = l.Chuyen_nganh
                        dt.Rows.Add(row)
                    End If
                End If
            Next
            dt.DefaultView.RowFilter = ""
            Return dt
        End Function
        Public Function Insert_Lop(ByVal objLop As Lop) As Integer
            Try
                Dim obj As Lop_DAL = New Lop_DAL
                Return obj.Insert_Lop(objLop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_Lop(ByVal objLop As Lop, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As Lop_DAL = New Lop_DAL
                Return obj.Update_Lop(objLop, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Lop_RaTruong(ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As Lop_DAL = New Lop_DAL
                Return obj.Update_Lop_RaTruong(ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Lop_VaoTruong(ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As Lop_DAL = New Lop_DAL
                Return obj.Update_Lop_VaoTruong(ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Lop_CaHoc(ByVal ID_lop As Integer, ByVal Ca_hoc As Integer) As Integer
            Try
                Dim obj As Lop_DAL = New Lop_DAL
                Return obj.Update_Lop_CaHoc(ID_lop, Ca_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Lop_PhongHoc(ByVal ID_lop As Integer, ByVal ID_phong As Integer) As Integer
            Try
                Dim obj As Lop_DAL = New Lop_DAL
                Return obj.Update_Lop_PhongHoc(ID_lop, ID_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_svLop(ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As Lop_DAL = New Lop_DAL
                Return obj.Delete_Lop(ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Converting(ByVal drLop As DataRow) As Lop
            Dim result As Lop
            Try
                result = New Lop
                If drLop("ID_lop").ToString() <> "" Then result.ID_lop = CType(drLop("ID_lop").ToString(), Integer)
                result.Ten_lop = drLop("Ten_lop").ToString()
                If drLop("ID_he").ToString() <> "" Then result.ID_he = CType(drLop("ID_he").ToString(), Integer)
                If drLop("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drLop("ID_khoa").ToString(), Integer)
                If drLop("ID_chuyen_nganh").ToString() <> "" Then result.ID_chuyen_nganh = CType(drLop("ID_chuyen_nganh").ToString(), Integer)
                If drLop("Khoa_hoc").ToString() <> "" Then result.Khoa_hoc = CType(drLop("Khoa_hoc").ToString(), Integer)
                result.Ten_he = drLop("Ten_he").ToString()
                result.Ten_khoa = drLop("Ten_khoa").ToString()
                result.Chuyen_nganh = drLop("Chuyen_nganh").ToString()
                result.Ten_nganh = drLop("Ten_nganh").ToString()
                result.Nien_khoa = drLop("Nien_khoa").ToString()
                If drLop("ID_dt").ToString() <> "" Then result.ID_dt = CType(drLop("ID_dt").ToString(), Integer)
                If drLop("So_sv").ToString() <> "" Then result.So_sv = CType(drLop("So_sv").ToString(), Integer)
                result.Ra_truong = IIf(IsDBNull(drLop("Ra_truong")), 0, drLop("Ra_truong").ToString)
                If drLop("ID_nganh").ToString() <> "" Then result.ID_nganh = CType(drLop("ID_nganh").ToString(), Integer)
                result.Ho_ten_gv = drLop("Ho_ten_gv").ToString()
                result.Dien_thoai = drLop("Dien_thoai").ToString()
                result.Email = drLop("Email").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function ConvertingChiTiet(ByVal drLop As DataRow) As Lop
            Dim result As Lop
            Try
                result = New Lop
                If drLop("ID_lop").ToString() <> "" Then result.ID_lop = CType(drLop("ID_lop").ToString(), Integer)
                result.Ten_lop = drLop("Ten_lop").ToString()
                If drLop("ID_he").ToString() <> "" Then result.ID_he = CType(drLop("ID_he").ToString(), Integer)
                If drLop("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drLop("ID_khoa").ToString(), Integer)
                If drLop("ID_chuyen_nganh").ToString() <> "" Then result.ID_chuyen_nganh = CType(drLop("ID_chuyen_nganh").ToString(), Integer)
                If drLop("Khoa_hoc").ToString() <> "" Then result.Khoa_hoc = CType(drLop("Khoa_hoc").ToString(), Integer)
                result.Ten_he = drLop("Ten_he").ToString()
                result.Ten_khoa = drLop("Ten_khoa").ToString()
                result.Chuyen_nganh = drLop("Chuyen_nganh").ToString()
                result.Ten_nganh = drLop("Ten_nganh").ToString()
                result.Nien_khoa = drLop("Nien_khoa").ToString()
                If drLop("ID_dt").ToString() <> "" Then result.ID_dt = CType(drLop("ID_dt").ToString(), Integer)
                If drLop("So_sv").ToString() <> "" Then result.So_sv = CType(drLop("So_sv").ToString(), Integer)
                result.Ra_truong = IIf(IsDBNull(drLop("Ra_truong")), 0, drLop("Ra_truong").ToString)
                If drLop("ID_nganh").ToString() <> "" Then result.ID_nganh = CType(drLop("ID_nganh").ToString(), Integer)
                result.Ca_hoc = CType(drLop("Ca_hoc").ToString(), Integer)
                result.ID_phong = drLop("ID_phong").ToString()
                result.Ten_phong = drLop("Ten_phong").ToString()

                result.Ho_ten_gv = drLop("Ho_ten_gv").ToString()
                result.Dien_thoai = drLop("Dien_thoai").ToString()
                result.Email = drLop("Email").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Public Function Check_Exits(ByVal Ten_lop As String) As Boolean
            Try
                Dim obj As Lop_DAL = New Lop_DAL
                Return obj.Check_Exits(Ten_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Tim_Ten_lop(ByVal ID_lop As Integer) As String
            For i As Integer = 0 To arrLop.Count - 1
                Dim lp As Lop = CType(arrLop(i), Lop)
                If lp.ID_lop = ID_lop Then
                    Return lp.Ten_lop
                End If
            Next
            Return ""
        End Function
        Public Function Tim_ID_lop(ByVal Ten_lop As String) As Integer
            For i As Integer = 0 To arrLop.Count - 1
                Dim lp As Lop = CType(arrLop(i), Lop)
                If lp.Ten_lop = Ten_lop Then
                    Return lp.ID_lop
                End If
            Next
            Return -1
        End Function
        Public Function Tim_chi_so(ByVal Ten_lop As String) As Integer
            For i As Integer = 0 To arrLop.Count - 1
                Dim lp As Lop = CType(arrLop(i), Lop)
                If lp.Ten_lop = Ten_lop Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Tim_chi_so(ByVal ID_lop As Integer) As Integer
            For i As Integer = 0 To arrLop.Count - 1
                Dim lp As Lop = CType(arrLop(i), Lop)
                If lp.ID_lop = ID_lop Then
                    Return i
                End If
            Next
            Return -1
        End Function

#End Region

#Region "Danh mục liên quan"
        Public Function DanhMucKhoaHoc() As DataTable
            Try
                Dim obj As Lop_DAL = New Lop_DAL
                Return obj.DanhMucKhoaHoc
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
        
    End Class
End Namespace
