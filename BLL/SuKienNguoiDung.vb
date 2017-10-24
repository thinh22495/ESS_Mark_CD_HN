'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, 03 June, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class SuKienNguoiDung_BLL
        Inherits SuKienNguoiDung
#Region "Var"
        ' Private aSuKienNguoiDungs As ArrayList
#End Region
#Region "Constructor"
        Public Sub New()
            'aSuKienNguoiDungs = New ArrayList
            'Dim obj As SuKienNguoiDung_DAL = New SuKienNguoiDung_DAL
            'Dim dt As DataTable = obj.Load_SuKienNguoiDung()
            'Dim objSuKienNguoiDung As SuKienNguoiDung = Nothing
            'If dt.Rows.Count > 0 Then
            '    For i As Integer = 0 To dt.Rows.Count - 1
            '        Dim row As DataRow = dt.Rows(i)
            '        objSuKienNguoiDung = Converting(row)
            '        aSuKienNguoiDungs.Add(objSuKienNguoiDung)
            '    Next
            'End If
        End Sub
#End Region

#Region "Function"
        Public Function Load_SuKienNguoiDung_List(ByVal SuKien_NguoiDung As SuKienNguoiDung, Optional ByVal Tu_ngay As String = "", Optional ByVal Den_ngay As String = "") As DataTable
            Try
                Dim obj As SuKienNguoiDung_DAL = New SuKienNguoiDung_DAL
                Dim dtSu_kien_nguoi_dung As DataTable = obj.Load_SuKienNguoiDung(SuKien_NguoiDung, Tu_ngay, Den_ngay)
                Dim dt As New DataTable
                dt.Columns.Add("ID_su_kien", GetType(Integer))
                dt.Columns.Add("Su_kien", GetType(Integer))
                dt.Columns.Add("Ten_su_kien", GetType(String))
                dt.Columns.Add("ID_phan_he", GetType(Integer))
                dt.Columns.Add("Phan_he", GetType(String))
                dt.Columns.Add("Noi_dung", GetType(String))
                dt.Columns.Add("Chuc_nang", GetType(String))
                dt.Columns.Add("Thoi_diem", GetType(Date))
                dt.Columns.Add("May_tram", GetType(String))
                dt.Columns.Add("UserName", GetType(String))
                For i As Integer = 0 To dtSu_kien_nguoi_dung.Rows.Count - 1
                    Dim row As DataRow = dt.NewRow
                    row("ID_su_kien") = dtSu_kien_nguoi_dung.Rows(i)("ID_su_kien")
                    row("Su_kien") = dtSu_kien_nguoi_dung.Rows(i)("Su_kien")
                    row("Ten_Su_kien") = Converting_Su_kien(dtSu_kien_nguoi_dung.Rows(i)("Su_kien"))
                    row("ID_phan_he") = dtSu_kien_nguoi_dung.Rows(i)("ID_phan_he")
                    row("Phan_he") = dtSu_kien_nguoi_dung.Rows(i)("Phan_he")
                    row("Noi_dung") = dtSu_kien_nguoi_dung.Rows(i)("Noi_dung")
                    row("Chuc_nang") = dtSu_kien_nguoi_dung.Rows(i)("Chuc_nang")
                    row("Thoi_diem") = dtSu_kien_nguoi_dung.Rows(i)("Thoi_diem")
                    row("May_tram") = dtSu_kien_nguoi_dung.Rows(i)("May_tram")
                    row("UserName") = dtSu_kien_nguoi_dung.Rows(i)("UserName")
                    dt.Rows.Add(row)
                Next
                dt.AcceptChanges()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách Phân Hê
        Public Function Danh_sach_phan_he() As DataTable
            Try
                Dim dt As New DataTable
                Dim obj As New VaiTro_DAL
                Dim dtPhan_he As DataTable = obj.Load_PhanHe
                Dim flag As Boolean = False
                dt.Columns.Add("ID_ph", GetType(Integer))
                dt.Columns.Add("Phan_he", GetType(String))
                For i As Integer = 0 To dtPhan_he.Rows.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    row("ID_ph") = dtPhan_he.Rows(i)("ID_ph")
                    row("Phan_he") = dtPhan_he.Rows(i)("Phan_he")
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw (ex)
            End Try
        End Function
        Private Function Converting(ByVal drSuKienNguoiDung As DataRow) As SuKienNguoiDung
            Dim result As SuKienNguoiDung
            Try
                result = New SuKienNguoiDung
                If drSuKienNguoiDung("ID_su_kien").ToString() <> "" Then result.ID_su_kien = CType(drSuKienNguoiDung("ID_su_kien").ToString(), Integer)
                If drSuKienNguoiDung("ID_phan_he").ToString() <> "" Then result.ID_phan_he = CType(drSuKienNguoiDung("ID_phan_he").ToString(), Integer)
                If drSuKienNguoiDung("Su_kien").ToString() <> "" Then result.Su_kien = CType(drSuKienNguoiDung("Su_kien").ToString(), Integer)
                result.Chuc_nang = drSuKienNguoiDung("Chuc_nang").ToString()
                result.Noi_dung = drSuKienNguoiDung("Noi_dung").ToString()
                result.Noi_dung = drSuKienNguoiDung("Phan_he").ToString()
                If drSuKienNguoiDung("Thoi_diem").ToString() <> "" Then result.Thoi_diem = CType(drSuKienNguoiDung("Thoi_diem").ToString(), Date)
                result.May_tram = drSuKienNguoiDung("May_tram").ToString()
                result.UserName = drSuKienNguoiDung("UserName").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Public Function Insert_SuKienNguoiDung(ByVal objSuKienNguoiDung As SuKienNguoiDung) As Integer
            Try
                Dim obj As SuKienNguoiDung_DAL = New SuKienNguoiDung_DAL
                Return obj.Insert_SuKienNguoiDung(objSuKienNguoiDung)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting_Su_kien(ByVal Su_kien As Integer) As String
            Try
                Dim str As String = ""
                Select Case Su_kien
                    Case 0
                        str = "Xem"
                    Case 1
                        str = "Thêm"
                    Case 2
                        str = "Sửa"
                    Case 3
                        str = "Xóa"
                End Select
                Return str
            Catch ex As Exception
                Throw (ex)
            End Try
        End Function
#End Region
    End Class
End Namespace
