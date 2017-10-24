'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Wednesday, April 08, 2009
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class KeHoachLop_BLL
        Private arrKeHoachLop As ArrayList
        Private clsKeHoachKyHieu As New KeHoachKyHieu_BLL()
#Region "Constructor"
        Public Sub New()

        End Sub
        Public Sub New(ByVal ID_kh As Integer)
            Try
                Dim obj As KeHoachLop_DAL = New KeHoachLop_DAL
                Dim dt As DataTable = obj.Load_KeHoachLop_List(ID_kh)
                Dim objsvKeHoachLop As KeHoachLop = Nothing
                Dim dr As DataRow = Nothing
                arrKeHoachLop = New ArrayList
                For Each dr In dt.Rows
                    objsvKeHoachLop = Converting(dr)
                    arrKeHoachLop.Add(objsvKeHoachLop)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region
#Region "Function"
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.arrKeHoachLop.Count
            End Get
        End Property
        Public Property KeHoachLop(ByVal idx As Integer) As KeHoachLop
            Get
                Return CType(Me.arrKeHoachLop(idx), KeHoachLop)
            End Get
            Set(ByVal Value As KeHoachLop)
                Me.arrKeHoachLop(idx) = Value
            End Set
        End Property
        Public ReadOnly Property KeHoachKyHieu() As KeHoachKyHieu_BLL
            Get
                Return clsKeHoachKyHieu
            End Get
        End Property
        Public Function TimKeHoach(ByVal ID_kh_tuan As Integer, ByVal ID_lop As Integer) As Integer
            For i As Integer = 0 To arrKeHoachLop.Count - 1
                Dim obj As KeHoachLop = CType(arrKeHoachLop(i), KeHoachLop)
                If obj.ID_kh_tuan = ID_kh_tuan And obj.ID_lop = ID_lop Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Sub XepKeHoach(ByVal ID_kh_tuan As Integer, ByVal ID_lop As Integer, ByVal ID_ky_hieu As Integer)
            Dim idx As Integer = TimKeHoach(ID_kh_tuan, ID_lop)
            Dim objKH As New KeHoachLop
            If idx >= 0 Then
                objKH = arrKeHoachLop(idx)
                objKH.ID_ky_hieu = ID_ky_hieu
                For i As Integer = 0 To KeHoachKyHieu.Count - 1
                    Dim obj As KeHoachKyHieu = KeHoachKyHieu.KeHoachKyHieu(i)
                    If obj.ID_ky_hieu = ID_ky_hieu Then
                        objKH.Ky_hieu = obj.Ky_hieu
                        Exit For
                    End If
                Next
                arrKeHoachLop(idx) = objKH
            Else
                objKH.ID_kh_tuan = ID_kh_tuan
                objKH.ID_lop = ID_lop
                objKH.ID_ky_hieu = ID_ky_hieu
                For i As Integer = 0 To KeHoachKyHieu.Count - 1
                    Dim obj As KeHoachKyHieu = KeHoachKyHieu.KeHoachKyHieu(i)
                    If obj.ID_ky_hieu = ID_ky_hieu Then
                        objKH.Ky_hieu = obj.Ky_hieu
                        Exit For
                    End If
                Next
                arrKeHoachLop.Add(objKH)
            End If
        End Sub
        Public Sub LuuKeHoach()
            For i As Integer = 0 To arrKeHoachLop.Count - 1
                Dim objKH As KeHoachLop = CType(arrKeHoachLop(i), KeHoachLop)
                If objKH.ID_kh_lop > 0 Then
                    'Update database
                    Update_KeHoachLop(objKH, objKH.ID_kh_lop)
                Else
                    'Insert database
                    Insert_KeHoachLop(objKH)
                End If
            Next
        End Sub
        Public Sub XoaKeHoach(ByVal ID_lop As Integer, ByVal ID_kh_tuan As Integer)
            For i As Integer = arrKeHoachLop.Count - 1 To 0 Step -1
                Dim obj As KeHoachLop = CType(arrKeHoachLop(i), KeHoachLop)
                If obj.ID_lop = ID_lop And obj.ID_kh_tuan = ID_kh_tuan Then
                    'Xóa trong Database 
                    Delete_KeHoachLop(ID_kh_tuan, ID_lop)
                    'Xóa trên bộ nhớ
                    arrKeHoachLop.RemoveAt(i)
                End If
            Next
        End Sub
        Public Function Baocao_KeHoachLop(ByVal ID_kh As Integer, ByVal dsID_lops As String) As DataTable
            Dim dt As New DataTable
            Dim khTuan As New KeHoachTuan_BLL(ID_kh)
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("ID_lop", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("So_sv", GetType(String))
            dt.Columns.Add("Ten_he", GetType(String))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            dt.Columns.Add("Nien_khoa", GetType(String))
            dt.Columns.Add("ID_nganh", GetType(Integer))
            dt.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            'Add các tuần trong kế hoạch năm
            For i As Integer = 0 To khTuan.Count - 1
                dt.Columns.Add("T." + khTuan.KeHoachTuan(i).ID_kh_tuan.ToString, GetType(String))
            Next

            Dim lps As New Lop_BLL(dsID_lops, 1, -1, 1)
            For i As Integer = 0 To lps.Count - 1
                Dim dr As DataRow
                dr = dt.NewRow                
                dr("ID_he") = lps.Lop(i).ID_he
                dr("ID_nganh") = lps.Lop(i).ID_nganh
                dr("ID_chuyen_nganh") = lps.Lop(i).ID_chuyen_nganh
                dr("ID_lop") = lps.Lop(i).ID_lop
                dr("Ten_lop") = lps.Lop(i).Ten_lop
                dr("So_sv") = lps.Lop(i).So_sv
                dr("Ten_he") = lps.Lop(i).Ten_he
                dr("Khoa_hoc") = lps.Lop(i).Khoa_hoc
                dr("Nien_khoa") = lps.Lop(i).Nien_khoa
                'Add thông tin về kế hoạch lớpLop
                For j As Integer = 0 To arrKeHoachLop.Count - 1
                    Dim objKehoachLop As KeHoachLop = CType(arrKeHoachLop(j), KeHoachLop)
                    If objKehoachLop.ID_lop = lps.Lop(i).ID_lop Then
                        dr("T." + objKehoachLop.ID_kh_tuan.ToString) = objKehoachLop.Ky_hieu
                    End If
                Next
                dt.Rows.Add(dr)
            Next
            Return dt
        End Function
        Public Function Baocao_KeHoachLop_Report(ByVal ID_kh As Integer, ByVal dsID_lops As String) As DataTable
            Dim dt As New DataTable
            Dim khTuan As New KeHoachTuan_BLL(ID_kh)
            dt.Columns.Add("ID_he", GetType(Integer))            
            dt.Columns.Add("ID_nganh", GetType(Integer))
            dt.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dt.Columns.Add("ID_lop", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("So_sv", GetType(String))
            dt.Columns.Add("Ten_he", GetType(String))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))
            'Add các tuần trong kế hoạch năm
            For i As Integer = 0 To khTuan.Count - 1
                dt.Columns.Add("T" + khTuan.KeHoachTuan(i).Tuan_thu.ToString, GetType(String))
            Next

            Dim lps As New Lop_BLL(dsID_lops, 1, 1, -1)
            For i As Integer = 0 To lps.Count - 1
                Dim dr As DataRow
                dr = dt.NewRow
                dr("ID_he") = lps.Lop(i).ID_he                
                dr("ID_nganh") = lps.Lop(i).ID_nganh
                dr("ID_chuyen_nganh") = lps.Lop(i).ID_chuyen_nganh
                dr("ID_lop") = lps.Lop(i).ID_lop
                dr("Ten_lop") = lps.Lop(i).Ten_lop
                dr("So_sv") = lps.Lop(i).So_sv
                dr("Ten_he") = lps.Lop(i).Ten_he
                dr("Khoa_hoc") = lps.Lop(i).Khoa_hoc
                'Add thông tin về kế hoạch lớpLop
                For j As Integer = 0 To arrKeHoachLop.Count - 1
                    Dim objKehoachLop As KeHoachLop = CType(arrKeHoachLop(j), KeHoachLop)
                    If objKehoachLop.ID_lop = lps.Lop(i).ID_lop Then
                        dr("T" + objKehoachLop.Tuan_thu.ToString) = objKehoachLop.Ky_hieu
                    End If
                Next
                dt.Rows.Add(dr)
            Next
            Return dt
        End Function
        Public Function DanhmucKyHieu() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_ky_hieu", GetType(Integer))
            dt.Columns.Add("Ky_hieu", GetType(String))
            dt.Columns.Add("Ten_ky_hieu", GetType(String))
            dt.Columns.Add("txtColor", GetType(String))
            dt.Columns.Add("bgColor", GetType(String))
            For i As Integer = 0 To KeHoachKyHieu.Count - 1
                Dim objKyHieu As KeHoachKyHieu = KeHoachKyHieu.KeHoachKyHieu(i)
                Dim dr As DataRow
                dr = dt.NewRow
                dr("ID_ky_hieu") = objKyHieu.ID_ky_hieu
                dr("Ky_hieu") = objKyHieu.Ky_hieu
                dr("Ten_ky_hieu") = objKyHieu.Ten_ky_hieu
                dr("txtColor") = objKyHieu.txtColor
                dr("bgColor") = objKyHieu.bgColor
                dt.Rows.Add(dr)
            Next
            Return dt
        End Function
        Public Function Insert_KeHoachLop(ByVal objKeHoachLop As KeHoachLop) As Integer
            Try
                Dim obj As KeHoachLop_DAL = New KeHoachLop_DAL
                Return obj.Insert_KeHoachLop(objKeHoachLop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachLop(ByVal objKeHoachLop As KeHoachLop, ByVal ID_kh_lop As Integer) As Integer
            Try
                Dim obj As KeHoachLop_DAL = New KeHoachLop_DAL
                Return obj.Update_KeHoachLop(objKeHoachLop, ID_kh_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KeHoachLop(ByVal ID_kh_tuan As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As KeHoachLop_DAL = New KeHoachLop_DAL
                Return obj.Delete_KeHoachLop(ID_kh_tuan, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drKeHoachLop As DataRow) As KeHoachLop
            Dim result As KeHoachLop
            Try
                result = New KeHoachLop
                If drKeHoachLop("ID_kh_lop").ToString() <> "" Then result.ID_kh_lop = CType(drKeHoachLop("ID_kh_lop").ToString(), Integer)
                If drKeHoachLop("ID_kh_tuan").ToString() <> "" Then result.ID_kh_tuan = CType(drKeHoachLop("ID_kh_tuan").ToString(), Integer)
                If drKeHoachLop("Tuan_thu").ToString() <> "" Then result.Tuan_thu = CType(drKeHoachLop("Tuan_thu").ToString(), Integer)
                If drKeHoachLop("ID_lop").ToString() <> "" Then result.ID_lop = CType(drKeHoachLop("ID_lop").ToString(), Integer)
                If drKeHoachLop("ID_ky_hieu").ToString() <> "" Then result.ID_ky_hieu = CType(drKeHoachLop("ID_ky_hieu").ToString(), Integer)
                If drKeHoachLop("Ky_hieu").ToString() <> "" Then result.Ky_hieu = CType(drKeHoachLop("Ky_hieu").ToString(), String)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Public Function Load_KeHoachNam_List() As DataTable
            Try
                Dim obj As KeHoachLop_DAL = New KeHoachLop_DAL
                Return obj.Load_KeHoachNam_List()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KeHoachNam_ChiTieuTuyenSinh() As DataTable
            Try
                Dim obj As KeHoachLop_DAL = New KeHoachLop_DAL
                Return obj.Load_KeHoachNam_ChiTieuTuyenSinh()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KeHoachNam_KeHoachTotNghiep() As DataTable
            Try
                Dim obj As KeHoachLop_DAL = New KeHoachLop_DAL
                Return obj.Load_KeHoachNam_KeHoachTotNghiep
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KeHoachNam_SoLopHoc() As DataTable
            Try
                Dim obj As KeHoachLop_DAL = New KeHoachLop_DAL
                Return obj.Load_KeHoachNam_SoLopHoc
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KeHoachNam(ByVal Nam_hoc As String, ByVal Tu_ngay As Date, ByVal Den_ngay As Date) As Integer
            Try
                Dim obj As KeHoachLop_DAL = New KeHoachLop_DAL
                Return obj.Insert_KeHoachNam(Nam_hoc, Tu_ngay, Den_ngay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachNam(ByVal ID_kh As Integer, ByVal Nam_hoc As String, ByVal Tu_ngay As Date, ByVal Den_ngay As Date) As Integer
            Try
                Dim obj As KeHoachLop_DAL = New KeHoachLop_DAL
                Return obj.Update_KeHoachNam(ID_kh, Nam_hoc, Tu_ngay, Den_ngay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KeHoachNam(ByVal ID_kh As Integer) As Integer
            Try
                Dim obj As KeHoachLop_DAL = New KeHoachLop_DAL
                Return obj.Delete_KeHoachNam(ID_kh)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_tkbKeHoachNam(ByVal Nam_hoc As String) As Integer
            Try
                Dim obj As KeHoachLop_DAL = New KeHoachLop_DAL
                Return obj.CheckExist_KeHoachNam(Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KeHoachTuan_List(ByVal ID_kh As Integer) As DataTable
            Try
                Dim obj As KeHoachLop_DAL = New KeHoachLop_DAL
                Return obj.Load_KeHoachTuan_List(ID_kh)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KeHoachTuan(ByVal ID_kh As Integer, ByVal Tuan_thu As Integer, ByVal Tu_ngay As Date, ByVal Den_ngay As Date) As Integer
            Try
                Dim obj As KeHoachLop_DAL = New KeHoachLop_DAL
                Return obj.Insert_KeHoachTuan(ID_kh, Tuan_thu, Tu_ngay, Den_ngay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachTuan(ByVal ID_kh_tuan As Integer, ByVal ID_kh As Integer, ByVal Tuan_thu As Integer, ByVal Tu_ngay As Date, ByVal Den_ngay As Date) As Integer
            Try
                Dim obj As KeHoachLop_DAL = New KeHoachLop_DAL
                Return obj.Update_KeHoachTuan(ID_kh_tuan, ID_kh, Tuan_thu, Tu_ngay, Den_ngay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region
    End Class
End Namespace
