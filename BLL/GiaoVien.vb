'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/24/2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class GiaoVien_BLL
        Private aGiaoViens As ArrayList
#Region "Constructor"
        Public Sub New(ByVal Hoc_ky As Byte, ByVal Nam_hoc As String)
            Dim cls As New GiaoVien_DAL
            Dim dt As DataTable = cls.Load_GiaoVien_List()
            Dim dtMon As DataTable
            aGiaoViens = New ArrayList
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim gv As New GiaoVien(Ngay_tuan, So_tiet_ngay)
                gv.ID_cb = CType(dt.Rows(i)("ID_cb").ToString(), Integer)
                gv.Ma_cb = dt.Rows(i)("Ma_cb").ToString()
                gv.Ten = dt.Rows(i)("Ten").ToString()
                gv.Ho_ten = dt.Rows(i)("Ho_ten").ToString()

                'Add các môn mà giáo viên này giảng dạy
                dtMon = cls.Load_GiaoVienMonDay_List(gv.ID_cb)
                For m As Integer = 0 To dtMon.Rows.Count - 1
                    Dim mh As New MonHoc
                    mh.ID_mon = dtMon.Rows(m)("ID_mon")
                    mh.Ky_hieu = dtMon.Rows(m)("Ky_hieu")
                    mh.Ten_mon = dtMon.Rows(m)("Ten_mon")
                    gv.MonDay.Add(mh)
                Next
                aGiaoViens.Add(gv)
            Next
        End Sub
        Public Sub New()
            Dim cls As New GiaoVien_DAL
            Dim dt As DataTable = cls.Load_GiaoVien_List()
            Dim dtMon As DataTable
            aGiaoViens = New ArrayList
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim gv As New GiaoVien(Ngay_tuan, So_tiet_ngay)
                gv.ID_cb = CType(dt.Rows(i)("ID_cb").ToString(), Integer)
                gv.Ma_cb = dt.Rows(i)("Ma_cb").ToString()
                gv.Ten = dt.Rows(i)("Ten").ToString()
                gv.Ho_ten = dt.Rows(i)("Ho_ten").ToString()

                'Add các môn mà giáo viên này giảng dạy
                dtMon = cls.Load_GiaoVienMonDay_List(gv.ID_cb)
                For m As Integer = 0 To dtMon.Rows.Count - 1
                    Dim mh As New MonHoc
                    mh.ID_mon = dtMon.Rows(m)("ID_mon")
                    mh.Ky_hieu = dtMon.Rows(m)("Ky_hieu")
                    mh.Ten_mon = dtMon.Rows(m)("Ten_mon")
                    gv.MonDay.Add(mh)
                Next
                aGiaoViens.Add(gv)
            Next
        End Sub
#End Region

#Region "Function"
        Public Function Insert_GiaoVien(ByVal objGiaoVien As GiaoVien) As Integer
            Try
                Dim obj As GiaoVien_DAL = New GiaoVien_DAL
                Return obj.Insert_GiaoVien(objGiaoVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_GiaoVien(ByVal objGiaoVien As GiaoVien, ByVal ID_cb As Integer) As Integer
            Try
                Dim obj As GiaoVien_DAL = New GiaoVien_DAL
                Return obj.Update_GiaoVien(objGiaoVien, ID_cb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_GiaoVien(ByVal ID_cb As Integer) As Integer
            Try
                Dim obj As GiaoVien_DAL = New GiaoVien_DAL
                Return obj.Delete_GiaoVien(ID_cb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drHoSoSinhVien As DataRow) As GiaoVien
            Dim result As GiaoVien
            Try
                result = New GiaoVien
                If drHoSoSinhVien("ID_cb").ToString() <> "" Then result.ID_cb = CType(drHoSoSinhVien("ID_cb").ToString(), Integer)
                result.Ma_cb = drHoSoSinhVien("Ma_cb").ToString()
                result.Ten = drHoSoSinhVien("Ten").ToString()
                result.Ho_ten = drHoSoSinhVien("Ho_ten").ToString()
                If drHoSoSinhVien("ID_gioi_tinh").ToString() <> "" Then result.ID_gioi_tinh = CType(drHoSoSinhVien("ID_gioi_tinh").ToString(), Integer)
                If drHoSoSinhVien("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drHoSoSinhVien("Ngay_sinh").ToString(), Date)
                If drHoSoSinhVien("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drHoSoSinhVien("ID_khoa").ToString(), Integer)
                If drHoSoSinhVien("ID_hoc_ham").ToString() <> "" Then result.ID_hoc_ham = CType(drHoSoSinhVien("ID_hoc_ham").ToString(), Integer)
                If drHoSoSinhVien("ID_hoc_vi").ToString() <> "" Then result.ID_hoc_vi = CType(drHoSoSinhVien("ID_hoc_vi").ToString(), Integer)
                If drHoSoSinhVien("ID_chuc_danh").ToString() <> "" Then result.ID_chuc_danh = CType(drHoSoSinhVien("ID_chuc_danh").ToString(), Integer)
                If drHoSoSinhVien("ID_chuc_vu").ToString() <> "" Then result.ID_chuc_vu = CType(drHoSoSinhVien("ID_chuc_vu").ToString(), Integer)
                result.Bo_mon = drHoSoSinhVien("Bo_mon").ToString()
                result.Chuc_danh = drHoSoSinhVien("Chuc_danh").ToString()
                result.Chuc_vu = drHoSoSinhVien("Chuc_vu").ToString()
                result.Hoc_ham = drHoSoSinhVien("Hoc_ham").ToString()
                result.Hoc_vi = drHoSoSinhVien("Hoc_vi").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Public Function Tim_Ten(ByVal ID_cb As Integer) As String
            For i As Integer = 0 To aGiaoviens.Count - 1
                Dim gv As Giaovien = CType(aGiaoviens(i), Giaovien)
                If gv.ID_cb = ID_cb Then
                    Return gv.Ten
                End If
            Next
            Return ""
        End Function
        Public Function Tim_ID_giaovien(ByVal Ten As String) As Integer
            For i As Integer = 0 To aGiaoViens.Count - 1
                Dim gv As GiaoVien = CType(aGiaoViens(i), GiaoVien)
                If gv.Ten = Ten Then
                    Return gv.ID_cb
                End If
            Next
            Return -1
        End Function
        Public Function Tim_chi_so_theo_Ten_GV(ByVal Ten As String) As Integer
            For i As Integer = 0 To aGiaoViens.Count - 1
                Dim gv As GiaoVien = CType(aGiaoViens(i), GiaoVien)
                If gv.Ten = Ten Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Tim_chi_so_theo_ID_cb(ByVal ID_cb As Integer) As Integer
            For i As Integer = 0 To aGiaoviens.Count - 1
                Dim gv As Giaovien = CType(aGiaoviens(i), Giaovien)
                If gv.ID_cb = ID_cb Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.aGiaoviens.Count
            End Get
        End Property
        Public Property Giaovien(ByVal idx As Integer) As GiaoVien
            Get
                Return CType(Me.aGiaoviens(idx), Giaovien)
            End Get
            Set(ByVal Value As GiaoVien)
                Me.aGiaoviens(idx) = Value
            End Set
        End Property
        Public Function Muc_do_cang() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("STT", GetType(String))
            dt.Columns.Add("Ten_giaovien", GetType(String))
            dt.Columns.Add("Sang", GetType(String))
            dt.Columns.Add("Chieu", GetType(String))
            dt.Columns.Add("Toi", GetType(String))
            dt.Columns.Add("Tong", GetType(String))
            For i As Integer = 0 To aGiaoViens.Count - 1
                Dim gv As GiaoVien = CType(aGiaoViens(i), GiaoVien)
                Dim row As DataRow = dt.NewRow()
                row("STT") = i + 1
                row("Ten_giaovien") = gv.Ho_ten
                If gv.Tiet_Sang > 0 Then row("Sang") = gv.Tiet_Sang
                If gv.Tiet_Chieu > 0 Then row("Chieu") = gv.Tiet_Chieu
                If gv.Tiet_Toi > 0 Then row("Toi") = gv.Tiet_Toi
                row("Tong") = gv.Tiet_Sang + gv.Tiet_Chieu + gv.Tiet_Toi
                dt.Rows.Add(row)
            Next
            Return dt
        End Function

        
#End Region

#Region "BoMonGiangVien"
        Public Function DanhSachGiaoVien() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_cb", GetType(Integer))
            dt.Columns.Add("Ma_cb", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Chuc_danh", GetType(String))
            dt.Columns.Add("Chuc_vu", GetType(String))
            For i As Integer = 0 To aGiaoViens.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objGiaoVien As GiaoVien = CType(aGiaoViens(i), GiaoVien)
                row("ID_cb") = objGiaoVien.ID_cb
                row("Ma_cb") = objGiaoVien.Ma_cb
                row("Ho_ten") = objGiaoVien.Ho_ten
                row("Chuc_danh") = objGiaoVien.Chuc_danh
                row("Chuc_vu") = objGiaoVien.Chuc_vu
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
#End Region
    End Class
End Namespace
