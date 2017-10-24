Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class LoaiChungChiDanhSachMon_BLL
        Private arrLoaiChungChiDanhSachSinhVien As ArrayList

#Region "Constructor"
        Public Sub New()
        End Sub
        Public Sub New(ByVal ID_lops As String)
            Try
                Dim obj As LoaiChungChiDanhSachMon_DAL = New LoaiChungChiDanhSachMon_DAL
                Dim dt As DataTable = obj.Load_DSSinhVienChungChi(ID_lops)
                Dim objLoaiChungChiDanhSachMon As LoaiChungChiDanhSachMon = Nothing
                Dim dr As DataRow = Nothing
                arrLoaiChungChiDanhSachSinhVien = New ArrayList
                For Each dr In dt.Rows
                    objLoaiChungChiDanhSachMon = Converting_ChungChi(dr)
                    arrLoaiChungChiDanhSachSinhVien.Add(objLoaiChungChiDanhSachMon)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
         
        Public Function Load_LoaiChungChiDanhSachMon(ByVal ID_dt As Integer) As DataTable
            Try
                Dim obj As LoaiChungChiDanhSachMon_DAL = New LoaiChungChiDanhSachMon_DAL
                Dim dt As DataTable = obj.Load_LoaiChungChiDanhSachMon(ID_dt)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_LoaiChungChiDanhSachMon(ByVal ID_chung_chi As Integer, ByVal ID_mon As Integer, ByVal id_dt As Integer) As Integer
            Try
                Dim obj As LoaiChungChiDanhSachMon_DAL = New LoaiChungChiDanhSachMon_DAL
                Return obj.Insert_LoaiChungChiDanhSachMon(ID_chung_chi, ID_mon, id_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_LoaiChungChiDanhSachMon(ByVal ID_chung_chi As Integer, ByVal ID_mon As Integer, ByVal ID_dt As Integer) As Integer
            Try
                Dim obj As LoaiChungChiDanhSachMon_DAL = New LoaiChungChiDanhSachMon_DAL
                Return obj.Delete_LoaiChungChiDanhSachMon(ID_chung_chi, ID_mon, ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_ChungChiTheoSinhVien(ByVal obj As LoaiChungChiDanhSachMon) As Integer
            Try
                Dim objDal As LoaiChungChiDanhSachMon_DAL = New LoaiChungChiDanhSachMon_DAL
                Return objDal.Insert_ChungChiTheoSinhVien(obj)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_ChungChiTheoSinhVien(ByVal obj As LoaiChungChiDanhSachMon) As Integer
            Try
                Dim objDal As LoaiChungChiDanhSachMon_DAL = New LoaiChungChiDanhSachMon_DAL
                Return objDal.Delete_ChungChiTheoSinhVien(obj)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Tim_idx(ByVal ID_sv As Integer, ByVal ID_chung_chi As Integer) As Integer
            For i As Integer = 0 To arrLoaiChungChiDanhSachSinhVien.Count - 1
                If CType(arrLoaiChungChiDanhSachSinhVien(i), LoaiChungChiDanhSachMon).ID_sv = ID_sv And CType(arrLoaiChungChiDanhSachSinhVien(i), LoaiChungChiDanhSachMon).ID_chung_chi = ID_chung_chi Then
                    Return i
                End If
            Next
            Return -1
        End Function

        Public Function DSSV_ChuaXetTheoLanXet(ByVal ID_chung_chi As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("TBCHT", GetType(Double))
                dt.Columns.Add("Xep_hang", GetType(String))
                dt.Columns.Add("ID_xep_loai", GetType(Integer))
                dt.Columns.Add("ID_chung_chi", GetType(Integer))
                dt.Columns.Add("Lan_xet", GetType(Integer))
                For i As Integer = 0 To arrLoaiChungChiDanhSachSinhVien.Count - 1
                    Dim ds As LoaiChungChiDanhSachMon = CType(arrLoaiChungChiDanhSachSinhVien(i), LoaiChungChiDanhSachMon)
                    If Tim_idx(ds.ID_sv, ID_chung_chi) = -1 Then
                        Dim row As DataRow = dt.NewRow()
                        row("Chon") = False
                        row("ID_sv") = ds.ID_sv
                        row("ID_dt") = ds.ID_dt
                        row("Ma_sv") = ds.Ma_sv
                        row("Ho_ten") = ds.Ho_ten
                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                        row("Ten_lop") = ds.Ten_lop
                        row("TBCHT") = ds.TBCHT
                        row("Xep_hang") = ds.Xep_hang
                        row("ID_xep_loai") = ds.ID_xep_loai
                        row("ID_chung_chi") = ds.ID_chung_chi
                        row("Lan_xet") = ds.Lan_xet
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DSSV_DaXetTheoLanXet(ByVal ID_chung_chi As Integer, ByVal Lan_xet As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("TBCHT", GetType(Double))
                dt.Columns.Add("Xep_hang", GetType(String))
                dt.Columns.Add("ID_xep_loai", GetType(Integer))
                dt.Columns.Add("ID_chung_chi", GetType(Integer))
                dt.Columns.Add("Lan_xet", GetType(Integer))
                dt.Columns.Add("Ly_do", GetType(String))
                For i As Integer = 0 To arrLoaiChungChiDanhSachSinhVien.Count - 1
                    Dim ds As LoaiChungChiDanhSachMon = CType(arrLoaiChungChiDanhSachSinhVien(i), LoaiChungChiDanhSachMon)
                    If ds.ID_chung_chi = ID_chung_chi And ds.Lan_xet = Lan_xet Then
                        Dim row As DataRow = dt.NewRow()
                        row("Chon") = False
                        row("ID_sv") = ds.ID_sv
                        row("ID_dt") = ds.ID_dt
                        row("Ma_sv") = ds.Ma_sv
                        row("Ho_ten") = ds.Ho_ten
                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                        row("Ten_lop") = ds.Ten_lop
                        row("TBCHT") = ds.TBCHT
                        row("Xep_hang") = ds.Xep_hang
                        row("ID_xep_loai") = ds.ID_xep_loai
                        row("ID_chung_chi") = ds.ID_chung_chi
                        row("Lan_xet") = ds.Lan_xet
                        row("Ly_do") = ""
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Converting_ChungChi(ByVal drLoaiChungChiDanhSachMon As DataRow) As LoaiChungChiDanhSachMon
            Dim result As LoaiChungChiDanhSachMon
            Try
                result = New LoaiChungChiDanhSachMon
                If drLoaiChungChiDanhSachMon("ID_chung_chi").ToString() <> "" Then result.ID_chung_chi = CType(drLoaiChungChiDanhSachMon("ID_chung_chi").ToString(), Integer)
                If drLoaiChungChiDanhSachMon("ID_sv").ToString() <> "" Then result.ID_sv = CType(drLoaiChungChiDanhSachMon("ID_sv").ToString(), Integer)
                If drLoaiChungChiDanhSachMon("ID_dt").ToString() <> "" Then result.ID_dt = CType(drLoaiChungChiDanhSachMon("ID_dt").ToString(), Integer)
                If drLoaiChungChiDanhSachMon("Lan_xet").ToString() <> "" Then result.Lan_xet = CType(drLoaiChungChiDanhSachMon("Lan_xet").ToString(), Integer)
                If drLoaiChungChiDanhSachMon("ID_xep_loai").ToString() <> "" Then result.ID_xep_loai = CType(drLoaiChungChiDanhSachMon("ID_xep_loai").ToString(), Integer)
                If drLoaiChungChiDanhSachMon("TBCHT").ToString() <> "" Then result.TBCHT = CType(drLoaiChungChiDanhSachMon("TBCHT").ToString(), Double)
                If drLoaiChungChiDanhSachMon("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drLoaiChungChiDanhSachMon("Ngay_sinh").ToString(), Date)
                result.Xep_hang = drLoaiChungChiDanhSachMon("Xep_hang").ToString()
                result.Ma_sv = drLoaiChungChiDanhSachMon("Ma_sv").ToString()
                result.Ho_ten = drLoaiChungChiDanhSachMon("Ho_ten").ToString()
                result.Ten_lop = drLoaiChungChiDanhSachMon("Ten_lop").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
