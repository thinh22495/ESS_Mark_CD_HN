'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Monday, June 09, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class GiangVien_BLL
        Inherits GiangVien
        Private arrGiangVien As ArrayList
#Region "Constructor"
        Public Sub New()
            Try
                arrGiangVien = New ArrayList
                Dim objGiangVien_dal As New GiangVien_DAL
                Dim objBoMonGiangVien_dal As New BoMonGiangVien_DAL
                Dim objGiangVienMonDay_dal As New GiangVienMonDay_DAL
                Dim dt As DataTable = objGiangVien_dal.Load_GiangVien_List()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objGiangVien As New GiangVien
                        objGiangVien = ConvertingGiangVien(dt.Rows(i))
                        'Add danh sach bo mon
                        Dim dt1 As DataTable = objBoMonGiangVien_dal.Load_BoMon(objGiangVien.ID_cb)
                        For j As Integer = 0 To dt1.Rows.Count - 1
                            Dim objBoMon As New BoMon
                            objBoMon = ConvertingBoMon(dt1.Rows(j))
                            'Add danh sach mon day
                            Dim  dt3 As DataTable = objGiangVienMonDay_dal.Load_GiangVienMonDay(objGiangVien.ID_cb, objBoMon.ID_bm)
                            For k As Integer = 0 To dt3.Rows.Count - 1
                                Dim objGiangVienMonDay As New GiangVienMonDay
                                objGiangVienMonDay = ConvertingMonHoc(dt3.Rows(k))
                                objGiangVien.dsMonDay.Add(objGiangVienMonDay)
                            Next
                            objGiangVien.dsBoMon.Add(objBoMon)
                        Next
                        arrGiangVien.Add(objGiangVien)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Function"

        Public Function DanhSachGiangVien(Optional ByVal ID_khoa As Integer = 0, Optional ByVal ID_bm As Integer = 0) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chuc_danh", GetType(String))
            dt.Columns.Add("Chuc_vu", GetType(String))
            dt.Columns.Add("Gioi_tinh", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Hoc_ham", GetType(String))
            dt.Columns.Add("Hoc_vi", GetType(String))
            dt.Columns.Add("ID_cb", GetType(Integer))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("Ma_cb", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            If ID_bm = 0 And ID_khoa > 0 Then
                For i As Integer = 0 To arrGiangVien.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objGiangVien As GiangVien = CType(arrGiangVien(i), GiangVien)
                    If objGiangVien.ID_khoa = ID_khoa Then
                        row("Chuc_danh") = objGiangVien.chuc_danh
                        row("Chuc_vu") = objGiangVien.Chuc_vu
                        row("Gioi_tinh") = objGiangVien.gioi_tinh
                        row("Ho_ten") = objGiangVien.Ho_ten
                        row("Hoc_ham") = objGiangVien.hoc_ham
                        row("Hoc_vi") = objGiangVien.hoc_vi
                        row("ID_cb") = objGiangVien.ID_cb
                        row("Ma_cb") = objGiangVien.Ma_cb
                        If objGiangVien.Ngay_sinh.ToString <> "" Then row("Ngay_sinh") = objGiangVien.Ngay_sinh
                        row("ID_khoa") = objGiangVien.ID_khoa
                        dt.Rows.Add(row)
                    End If
                Next
            ElseIf ID_bm > 0 And ID_khoa > 0 Then
                For i As Integer = 0 To arrGiangVien.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objGiangVien As GiangVien = CType(arrGiangVien(i), GiangVien)
                    If objGiangVien.ID_khoa = ID_khoa And CheckExistBoMon(objGiangVien, ID_bm) Then
                        row("Chuc_danh") = objGiangVien.chuc_danh
                        row("Chuc_vu") = objGiangVien.Chuc_vu
                        row("Gioi_tinh") = objGiangVien.gioi_tinh
                        row("Ho_ten") = objGiangVien.Ho_ten
                        row("Hoc_ham") = objGiangVien.hoc_ham
                        row("Hoc_vi") = objGiangVien.hoc_vi
                        row("ID_cb") = objGiangVien.ID_cb
                        row("Ma_cb") = objGiangVien.Ma_cb
                        If objGiangVien.Ngay_sinh.ToString <> "" Then row("Ngay_sinh") = objGiangVien.Ngay_sinh
                        row("ID_khoa") = objGiangVien.ID_khoa
                        dt.Rows.Add(row)
                    End If
                Next
            ElseIf ID_bm = 0 And ID_khoa = 0 Then
                For i As Integer = 0 To arrGiangVien.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objGiangVien As GiangVien = CType(arrGiangVien(i), GiangVien)
                    row("Chuc_danh") = objGiangVien.chuc_danh
                    row("Chuc_vu") = objGiangVien.Chuc_vu
                    row("Gioi_tinh") = objGiangVien.gioi_tinh
                    row("Ho_ten") = objGiangVien.Ho_ten
                    row("Hoc_ham") = objGiangVien.hoc_ham
                    row("Hoc_vi") = objGiangVien.hoc_vi
                    row("ID_cb") = objGiangVien.ID_cb
                    row("Ten_khoa") = objGiangVien.ten_khoa
                    row("Ma_cb") = objGiangVien.Ma_cb
                    If objGiangVien.Ngay_sinh.ToString <> "" Then row("Ngay_sinh") = objGiangVien.Ngay_sinh
                    row("ID_khoa") = objGiangVien.ID_khoa
                    dt.Rows.Add(row)
                Next
            ElseIf ID_bm > 0 And ID_khoa = 0 Then
                For i As Integer = 0 To arrGiangVien.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objGiangVien As GiangVien = CType(arrGiangVien(i), GiangVien)
                    If CheckExistBoMon(objGiangVien, ID_bm) Then
                        row("Chuc_danh") = objGiangVien.chuc_danh
                        row("Chuc_vu") = objGiangVien.Chuc_vu
                        row("Gioi_tinh") = objGiangVien.gioi_tinh
                        row("Ho_ten") = objGiangVien.Ho_ten
                        row("Hoc_ham") = objGiangVien.hoc_ham
                        row("Hoc_vi") = objGiangVien.hoc_vi
                        row("ID_cb") = objGiangVien.ID_cb
                        row("Ma_cb") = objGiangVien.Ma_cb
                        If objGiangVien.Ngay_sinh.ToString <> "" Then row("Ngay_sinh") = objGiangVien.Ngay_sinh
                        row("ID_khoa") = objGiangVien.ID_khoa
                        dt.Rows.Add(row)
                    End If
                Next
            End If
            Return dt
        End Function
        Public Function DanhSachGiangVienTrongBoMon(ByVal ID_bm As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chuc_danh", GetType(String))
            dt.Columns.Add("Chuc_vu", GetType(String))
            dt.Columns.Add("Gioi_tinh", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Hoc_ham", GetType(String))
            dt.Columns.Add("Hoc_vi", GetType(String))
            dt.Columns.Add("ID_cb", GetType(Integer))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("Ma_cb", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("ID_bm", GetType(Integer))
            For i As Integer = 0 To arrGiangVien.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objGiangVien As GiangVien = CType(arrGiangVien(i), GiangVien)
                If CheckExistBoMon(objGiangVien, ID_bm) = True Then
                    row("Chuc_danh") = objGiangVien.chuc_danh
                    row("Chuc_vu") = objGiangVien.Chuc_vu
                    row("Gioi_tinh") = objGiangVien.gioi_tinh
                    row("Ho_ten") = objGiangVien.Ho_ten
                    row("Hoc_ham") = objGiangVien.hoc_ham
                    row("Hoc_vi") = objGiangVien.hoc_vi
                    row("ID_cb") = objGiangVien.ID_cb
                    row("Ma_cb") = objGiangVien.Ma_cb
                    If objGiangVien.Ngay_sinh.ToString <> "" Then row("Ngay_sinh") = objGiangVien.Ngay_sinh
                    row("ID_khoa") = objGiangVien.ID_khoa
                    row("ID_bm") = ID_bm
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function DanhSachPhanGiaoVien() As DataTable
            Dim dtGV As New DataTable
            dtGV.Columns.Add("ID_cb", GetType(Integer))
            dtGV.Columns.Add("ID_bm", GetType(Integer))
            dtGV.Columns.Add("Ma_cb", GetType(String))
            dtGV.Columns.Add("Ho_ten", GetType(String))
            Dim objBm_bll As New BoMon_BLL
            Dim dt As DataTable
            dt = objBm_bll.DanhSachGiangVien(-1)
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim r As DataRow
                r = dtGV.NewRow
                r("ID_cb") = dt.Rows(i)("ID_cb")
                r("Ma_cb") = dt.Rows(i)("Ma_cb")
                r("Ho_ten") = dt.Rows(i)("Ho_ten")
                r("ID_bm") = dt.Rows(i)("ID_bm")
                dtGV.Rows.Add(r)
            Next
            Return dtGV
        End Function
        Public Function DanhSachGiangVienNgoaiBoMon(ByVal ID_bm As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chuc_danh", GetType(String))
            dt.Columns.Add("Chuc_vu", GetType(String))
            dt.Columns.Add("Gioi_tinh", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Hoc_ham", GetType(String))
            dt.Columns.Add("Hoc_vi", GetType(String))
            dt.Columns.Add("ID_cb", GetType(Integer))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("Ma_cb", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("ID_bm", GetType(Integer))
            For i As Integer = 0 To arrGiangVien.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objGiangVien As GiangVien = CType(arrGiangVien(i), GiangVien)
                If CheckExistBoMon(objGiangVien, ID_bm) = False Then
                    row("Chuc_danh") = objGiangVien.chuc_danh
                    row("Chuc_vu") = objGiangVien.Chuc_vu
                    row("Gioi_tinh") = objGiangVien.gioi_tinh
                    row("Ho_ten") = objGiangVien.Ho_ten
                    row("Hoc_ham") = objGiangVien.hoc_ham
                    row("Hoc_vi") = objGiangVien.hoc_vi
                    row("ID_cb") = objGiangVien.ID_cb
                    row("Ma_cb") = objGiangVien.Ma_cb
                    If objGiangVien.Ngay_sinh.ToString <> "" Then row("Ngay_sinh") = objGiangVien.Ngay_sinh
                    row("ID_khoa") = objGiangVien.ID_khoa
                    row("ID_bm") = ID_bm
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function GetGiangVien(ByVal ID_cb As Integer) As GiangVien
            Dim objGiangVien As New GiangVien
            Dim idx As Integer = TimIdx(ID_cb)
            Return arrGiangVien(idx)
        End Function
        Public Function LoadMonDay(ByVal ID_cb As Integer, Optional ByVal ID_bm As Integer = 0) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_mon", GetType(Integer))
            dt.Columns.Add("Ky_hieu", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            Dim idx As Integer = TimIdx(ID_cb)
            If idx >= 0 Then
                Dim objGiangVien As New GiangVien
                objGiangVien = CType(arrGiangVien(idx), GiangVien)
                If ID_bm > 0 Then
                    For i As Integer = 0 To objGiangVien.dsMonDay.Count - 1
                        Dim objGiangvienMonDay As GiangVienMonDay = CType(objGiangVien.dsMonDay(i), GiangVienMonDay)
                        If objGiangvienMonDay.ID_bm = ID_bm Then
                            Dim row As DataRow = dt.NewRow()
                            row("ID_mon") = objGiangvienMonDay.ID_mon
                            row("Ky_hieu") = objGiangvienMonDay.Ky_hieu
                            row("Ten_mon") = objGiangvienMonDay.Ten_mon
                            dt.Rows.Add(row)
                        End If
                    Next
                Else
                    For i As Integer = 0 To objGiangVien.dsMonDay.Count - 1
                        Dim objGiangvienMonDay As GiangVienMonDay = CType(objGiangVien.dsMonDay(i), GiangVienMonDay)
                        Dim row As DataRow = dt.NewRow()
                        row("ID_mon") = objGiangvienMonDay.ID_mon
                        row("Ky_hieu") = objGiangvienMonDay.Ky_hieu
                        row("Ten_mon") = objGiangvienMonDay.Ten_mon
                        dt.Rows.Add(row)
                    Next
                End If
            End If
            Return dt
        End Function
        Public Function Insert_GiangVien(ByVal objGiangVien As GiangVien) As Integer
            Try
                Dim obj As GiangVien_DAL = New GiangVien_DAL
                Return obj.Insert_GiangVien(objGiangVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_GiangVien(ByVal objGiangVien As GiangVien) As Integer
            Try
                Dim obj As GiangVien_DAL = New GiangVien_DAL
                Return obj.Update_GiangVien(objGiangVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_GiangVien(ByVal ID_cb As Integer) As Integer
            Try
                Dim obj As GiangVien_DAL = New GiangVien_DAL
                Return obj.Delete_GiangVien(ID_cb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_IDGiangVien(ByVal ID_cb As Integer) As Boolean
            Try
                Dim obj As GiangVien_DAL = New GiangVien_DAL
                obj.CheckExist_IDGiangVien(ID_cb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_MaGiangVien(ByVal Ma_cb As String) As Boolean
            Try
                Dim obj As GiangVien_DAL = New GiangVien_DAL
                Return obj.CheckExist_MaGiangVien(Ma_cb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function CheckExistBoMon(ByVal objGiangVien As GiangVien, ByVal ID_bm As Integer) As Boolean
            For i As Integer = 0 To objGiangVien.dsBoMon.Count - 1
                If ID_bm = CType(objGiangVien.dsBoMon(i), BoMon).ID_bm Then
                    Return True
                End If
            Next
            Return False
        End Function
        Public Function GetMaxID_GiangVien() As Integer
            Try
                Dim obj As GiangVien_DAL = New GiangVien_DAL
                Return obj.GetMaxID_GiangVien()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function ConvertingGiangVien(ByVal drGiangVien As DataRow) As GiangVien
            Dim result As GiangVien
            Try
                result = New GiangVien
                If drGiangVien("ID_cb").ToString() <> "" Then result.ID_cb = CType(drGiangVien("ID_cb").ToString(), Integer)
                result.Ma_cb = drGiangVien("Ma_cb").ToString()
                result.Ten = drGiangVien("Ten").ToString()
                result.Ho_ten = drGiangVien("Ho_ten").ToString()
                If drGiangVien("ID_gioi_tinh").ToString() <> "" Then result.ID_gioi_tinh = CType(drGiangVien("ID_gioi_tinh").ToString(), Integer)
                If drGiangVien("Gioi_tinh").ToString() <> "" Then result.gioi_tinh = CType(drGiangVien("Gioi_tinh").ToString(), String)
                If drGiangVien("Ngay_sinh").ToString() <> "" Then
                    result.Ngay_sinh = CType(drGiangVien("Ngay_sinh").ToString(), Date)
                Else
                    result.Ngay_sinh = ""
                End If
                If drGiangVien("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drGiangVien("ID_khoa").ToString(), Integer)
                If drGiangVien("Ten_khoa").ToString() <> "" Then result.ten_khoa = CType(drGiangVien("Ten_khoa").ToString(), String)
                If drGiangVien("ID_hoc_ham").ToString() <> "" Then result.ID_hoc_ham = CType(drGiangVien("ID_hoc_ham").ToString(), Integer)
                If drGiangVien("Hoc_ham").ToString() <> "" Then result.hoc_ham = CType(drGiangVien("Hoc_ham").ToString(), String)
                If drGiangVien("ID_hoc_vi").ToString() <> "" Then result.ID_hoc_vi = CType(drGiangVien("ID_hoc_vi").ToString(), Integer)
                If drGiangVien("Hoc_vi").ToString() <> "" Then result.hoc_vi = CType(drGiangVien("Hoc_vi").ToString(), String)
                If drGiangVien("ID_chuc_danh").ToString() <> "" Then result.ID_chuc_danh = CType(drGiangVien("ID_chuc_danh").ToString(), Integer)
                If drGiangVien("Chuc_danh").ToString() <> "" Then result.chuc_danh = CType(drGiangVien("Chuc_danh").ToString(), String)
                If drGiangVien("ID_chuc_vu").ToString() <> "" Then result.ID_chuc_vu = CType(drGiangVien("ID_chuc_vu").ToString(), Integer)
                If drGiangVien("Chuc_vu").ToString() <> "" Then result.Chuc_vu = CType(drGiangVien("Chuc_vu").ToString(), String)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function ConvertingBoMon(ByVal drBomon As DataRow) As BoMon
            Dim result As BoMon
            Try
                result = New BoMon
                If drBomon("ID_bm").ToString() <> "" Then result.ID_bm = CType(drBomon("ID_bm").ToString(), Integer)
                result.Ma_bo_mon = drBomon("Ma_bo_mon").ToString()
                result.Bo_mon = drBomon("Bo_mon").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function ConvertingMonHoc(ByVal drGiangVienMonDay As DataRow) As GiangVienMonDay
            Dim result As GiangVienMonDay
            Try
                result = New GiangVienMonDay
                If drGiangVienMonDay("ID_mon").ToString() <> "" Then result.ID_mon = CType(drGiangVienMonDay("ID_mon").ToString(), Integer)
                If drGiangVienMonDay("ID_bm").ToString() <> "" Then result.ID_bm = CType(drGiangVienMonDay("ID_bm").ToString(), Integer)
                result.Ky_hieu = drGiangVienMonDay("Ky_hieu").ToString()
                result.Ten_mon = drGiangVienMonDay("Ten_mon").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function TimIdx(ByVal ID_cb As Integer) As Integer
            For i As Integer = 0 To arrGiangVien.Count - 1
                If CType(arrGiangVien(i), GiangVien).ID_cb = ID_cb Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
    End Class
End Namespace
