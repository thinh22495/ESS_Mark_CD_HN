'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Thursday, July 31, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class MucThuKhacSinhVien_BLL
        Inherits MucThuKhacSinhVien
        Private arrDanhSachSVThuKhac As New ArrayList
#Region "Constructor"
        Sub New()
            
        End Sub
        Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String)
            Dim obj_DAL As MucThuKhacSinhVien_DAL = New MucThuKhacSinhVien_DAL
            Dim dt As DataTable
            dt = obj_DAL.Load_MucThuKhacSinhVien_List(Hoc_ky, Nam_hoc, dsID_lop)
            Dim obj As MucThuKhacSinhVien
            Dim dr As DataRow
            For Each dr In dt.Rows
                obj = New MucThuKhacSinhVien
                obj = Converting(dr)
                arrDanhSachSVThuKhac.Add(obj)
            Next
        End Sub
#End Region

#Region "Function"
        ' Danh sách sinh viên xác đinh khoản thu khác
        Public Function DanhSach_Thu(ByVal dtSinhVien As DataTable, Optional ByVal ID_thu_chi As Integer = 0) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon")
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Hoc_ky")
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("ID_thu_chi")
                dt.Columns.Add("Ten_thu_chi")
                dt.Columns.Add("So_tien")
                dt.Columns.Add("So_mon")
                dt.Columns.Add("Noi_tru")
                dt.Columns.Add("So_tien_mot_nguoi")
                Dim obj As MucThuKhacSinhVien
                Dim row As DataRow
                For Each dr As DataRow In dtSinhVien.Rows
                    For i As Integer = 0 To arrDanhSachSVThuKhac.Count - 1
                        obj = New MucThuKhacSinhVien
                        obj = CType(arrDanhSachSVThuKhac(i), MucThuKhacSinhVien)
                        If dr("ID_sv") = obj.ID_sv And obj.ID_thu_chi = ID_thu_chi Then
                            row = dt.NewRow
                            row("Chon") = False
                            row("ID_sv") = dr("ID_sv")
                            row("Ma_sv") = dr("Ma_sv")
                            row("Ho_ten") = dr("Ho_ten")
                            row("Ngay_sinh") = dr("Ngay_sinh")
                            row("Hoc_ky") = obj.Hoc_ky
                            row("Nam_hoc") = obj.Nam_hoc
                            row("Ten_thu_chi") = obj.Ten_thu_chi
                            row("ID_thu_chi") = obj.ID_thu_chi
                            row("So_tien") = Format(obj.So_tien, "###,##0")
                            row("So_mon") = 0
                            row("Noi_tru") = 0
                            row("So_tien_mot_nguoi") = 0
                            dt.Rows.Add(row)
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên chưa xác định khoản thu khác
        Public Function DanhSach_ChuaXacDinh_Thu(ByVal dtSinhVien As DataTable, ByVal ID_thu_chi As Integer) As DataTable
            Try                
                Dim dt As DataTable
                dt = dtSinhVien.Copy                
                Dim obj As MucThuKhacSinhVien
                For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                    For j As Integer = 0 To arrDanhSachSVThuKhac.Count - 1
                        obj = New MucThuKhacSinhVien
                        obj = CType(arrDanhSachSVThuKhac(j), MucThuKhacSinhVien)
                        If dt.Rows(i)("ID_sv") = obj.ID_sv And obj.ID_thu_chi = ID_thu_chi Then
                            dt.Rows(i).Delete() ' Xóa bỏ những sinh viên đã xác định khoản thu
                            Exit For
                        End If
                    Next
                Next
                ' Chỉ xác định lấy một số trường
                Dim dtDS As New DataTable
                dtDS.Columns.Add("Chon")
                dtDS.Columns.Add("ID_sv")
                dtDS.Columns.Add("Ma_sv")
                dtDS.Columns.Add("Ho_ten")
                dtDS.Columns.Add("Ngay_sinh", GetType(Date))
                dtDS.Columns.Add("Hoc_ky")
                dtDS.Columns.Add("Nam_hoc")
                dtDS.Columns.Add("ID_thu_chi")
                dtDS.Columns.Add("Ten_thu_chi")
                dtDS.Columns.Add("So_tien")
                dtDS.Columns.Add("Ngoai_ngan_sach", GetType(Integer))
                dtDS.Columns.Add("Noi_tru", GetType(Integer)) ' Ỏ nội trú
                dtDS.Columns.Add("So_tien_mot_nguoi") ' Số tiền theo phòng KTX
                Dim row As DataRow
                For Each dr As DataRow In dt.Rows
                    row = dtDS.NewRow
                    row("Chon") = False
                    row("ID_sv") = dr("ID_sv")
                    row("Ma_sv") = dr("Ma_sv")
                    row("Ho_ten") = dr("Ho_ten")
                    row("Ngay_sinh") = dr("Ngay_sinh")
                    row("Hoc_ky") = 1
                    row("Nam_hoc") = ""
                    row("Ten_thu_chi") = ""
                    row("ID_thu_chi") = 0
                    row("So_tien") = 0
                    row("So_tien") = 0
                    row("Ngoai_ngan_sach") = IIf(dr("Ngoai_ngan_sach") = False, 0, 1)
                    Dim objNN_Tru As New NoiNgoaiTru_BLL(CInt(dr("ID_sv")))
                    Dim dtNoiTru As DataTable = objNN_Tru.Load_NoiNgoaiTruSV_DangO()
                    If dtNoiTru.Rows.Count > 0 Then
                        row("Noi_tru") = 1
                        row("So_tien_mot_nguoi") = dtNoiTru.Rows(0)("So_tien_mot_nguoi")
                    Else
                        row("Noi_tru") = 0
                        row("So_tien_mot_nguoi") = 0
                    End If
                    dtDS.Rows.Add(row)
                Next                
                Return dtDS
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_MucThuKhacSinhVien(ByVal objMucThuKhacSinhVien As MucThuKhacSinhVien) As Integer
            Try
                Dim obj As MucThuKhacSinhVien_DAL = New MucThuKhacSinhVien_DAL
                Return obj.Insert_MucThuKhacSinhVien(objMucThuKhacSinhVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_MucThuKhacSinhVien(ByVal objMucThuKhacSinhVien As MucThuKhacSinhVien) As Integer
            Try
                Dim obj As MucThuKhacSinhVien_DAL = New MucThuKhacSinhVien_DAL
                Return obj.Update_MucThuKhacSinhVien(objMucThuKhacSinhVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_MucThuKhacSinhVien(ByVal objMucThuKhacSinhVien As MucThuKhacSinhVien) As Integer
            Try
                Dim obj As MucThuKhacSinhVien_DAL = New MucThuKhacSinhVien_DAL
                Return obj.Delete_MucThuKhacSinhVien(objMucThuKhacSinhVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svMucThuKhacSinhVien(ByVal objMucThuKhacSinhVien As MucThuKhacSinhVien) As Boolean
            Try
                Dim obj As MucThuKhacSinhVien_DAL = New MucThuKhacSinhVien_DAL
                Return obj.CheckExist_MucThuKhacSinhVien(objMucThuKhacSinhVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drMucThuKhacSinhVien As DataRow) As MucThuKhacSinhVien
            Dim result As MucThuKhacSinhVien
            Try
                result = New MucThuKhacSinhVien
                If drMucThuKhacSinhVien("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drMucThuKhacSinhVien("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drMucThuKhacSinhVien("Nam_hoc").ToString()
                If drMucThuKhacSinhVien("ID_sv").ToString() <> "" Then result.ID_sv = CType(drMucThuKhacSinhVien("ID_sv").ToString(), Integer)
                If drMucThuKhacSinhVien("ID_thu_chi").ToString() <> "" Then result.ID_thu_chi = CType(drMucThuKhacSinhVien("ID_thu_chi").ToString(), Integer)
                If drMucThuKhacSinhVien("So_tien").ToString() <> "" Then result.So_tien = CType(drMucThuKhacSinhVien("So_tien").ToString(), Integer)
                result.Ghi_chu = drMucThuKhacSinhVien("Ghi_chu").ToString()
                result.Ten_thu_chi = drMucThuKhacSinhVien("Ten_thu_chi").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
