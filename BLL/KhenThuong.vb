'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Sunday, June 01, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class KhenThuong_BLL        
        Private arrKhenThuong As New ArrayList
        Private dtSinhVienKT As DataTable  ' Danh sách sinh viên khen thưởng

#Region "Constructor"
        Public Sub New()
        End Sub
        Public Sub New(ByVal ID_lops As String)
            Try
                Dim obj As KhenThuong_DAL = New KhenThuong_DAL
                Dim dt As DataTable = obj.Load_KhenThuong(ID_lops)
                Dim objKhenThuong As New KhenThuong
                Dim dr As DataRow = Nothing
                For Each dr In dt.Rows
                    objKhenThuong = Converting(dr)
                    arrKhenThuong.Add(objKhenThuong)
                Next
                dtSinhVienKT = obj.Load_SinhVienKhenThuong(ID_lops)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        ' Load Khen thuong sinh vien
        Public Function Load_QDKhenThuong() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("So_QD", GetType(String))
                dt.Columns.Add("Ngay_QD", GetType(DateTime))
                dt.Columns.Add("Hinh_thuc", GetType(String))
                For i As Integer = 0 To arrKhenThuong.Count - 1
                    Dim kt As KhenThuong = CType(arrKhenThuong(i), KhenThuong)
                    Dim row As DataRow = dt.NewRow()
                    row("So_QD") = kt.So_QD
                    row("Ngay_QD") = Format(kt.Ngay_QD, "dd/MM/yyyy")
                    row("Hinh_thuc") = kt.Hinh_thuc
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load danh sách sinh vien theo ID_khen_thuong
        Public Function Load_SinhVienKhenThuong(ByVal ID_khen_thuong As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon")
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh")
                dt.Columns.Add("Ten_lop")
                dt.Columns.Add("ID_lop")
                Dim row As DataRow
                For i As Integer = 0 To dtSinhVienKT.Rows.Count - 1
                    If dtSinhVienKT.Rows(i).Item("ID_khen_thuong") = ID_khen_thuong Then
                        row = dt.NewRow
                        row("Chon") = False
                        row("ID_sv") = dtSinhVienKT.Rows(i)("ID_sv")
                        row("Ma_sv") = dtSinhVienKT.Rows(i)("Ma_sv")
                        row("Ho_ten") = dtSinhVienKT.Rows(i)("Ho_ten")
                        If dtSinhVienKT.Rows(i)("Ngay_sinh").ToString <> "" Then row("Ngay_sinh") = Format(dtSinhVienKT.Rows(i)("Ngay_sinh"), "dd/MM/yyyy")
                        row("Ten_lop") = dtSinhVienKT.Rows(i)("Ten_lop")                        
                        dt.Rows.Add(row)
                    End If
                Next               
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KhenThuong(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_khen_thuong", GetType(Integer))
                dt.Columns.Add("So_QD", GetType(String))
                dt.Columns.Add("Ngay_QD", GetType(Date))
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("ID_loai_kt", GetType(Integer))
                dt.Columns.Add("Hinh_thuc", GetType(String))
                dt.Columns.Add("Ten_cap", GetType(String))
                For i As Integer = 0 To arrKhenThuong.Count - 1
                    Dim kt As KhenThuong = CType(arrKhenThuong(i), KhenThuong)
                    If kt.Hoc_ky = Hoc_ky And kt.Nam_hoc = Nam_hoc Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_khen_thuong") = kt.ID_khen_thuong
                        row("So_QD") = kt.So_QD
                        row("Ngay_QD") = Format(kt.Ngay_QD, "dd/MM/yyyy")
                        row("Hoc_ky") = kt.Hoc_ky
                        row("Nam_hoc") = kt.Nam_hoc
                        row("ID_loai_kt") = kt.ID_loai_kt
                        row("Hinh_thuc") = kt.Hinh_thuc
                        row("Ten_cap") = kt.Ten_cap
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KhenThuong(ByVal ID_khen_thuong As Integer) As KhenThuong
            Try
                Dim obj As KhenThuong_DAL = New KhenThuong_DAL
                Dim dt As DataTable = obj.Load_KhenThuong(ID_khen_thuong)
                Dim objKhenThuong As KhenThuong = Nothing
                If dt.Rows.Count > 0 Then
                    objKhenThuong = Converting(dt.Rows(0))
                End If
                Return objKhenThuong
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        
        Public Function Insert_KhenThuong(ByVal objKhenThuong As KhenThuong) As Integer
            Try
                Dim obj As KhenThuong_DAL = New KhenThuong_DAL
                Return obj.Insert_KhenThuong(objKhenThuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KhenThuongSinhVien(ByVal ID_sv As Integer, ByVal ID_khen_thuong As Integer) As Integer
            Try
                Dim obj As KhenThuong_DAL = New KhenThuong_DAL
                Return obj.Insert_KhenThuongSinhVien(ID_sv, ID_khen_thuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KhenThuong(ByVal objKhenThuong As KhenThuong, ByVal ID_khen_thuong As Integer) As Integer
            Try
                Dim obj As KhenThuong_DAL = New KhenThuong_DAL
                Return obj.Update_KhenThuong(objKhenThuong, ID_khen_thuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KhenThuongSinhVien(ByVal ID_sv As Integer, ByVal ID_khen_thuong As Integer) As Integer
            Try
                Dim obj As KhenThuong_DAL = New KhenThuong_DAL
                Return obj.Update_KhenThuongSinhVien(ID_sv, ID_khen_thuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KhenThuong(ByVal ID_khen_thuong As Integer) As Integer
            Try
                Dim obj As KhenThuong_DAL = New KhenThuong_DAL
                Return obj.Delete_KhenThuong(ID_khen_thuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KhenThuongSinhVien(ByVal ID_khen_thuong As Integer) As Integer
            Try
                Dim obj As KhenThuong_DAL = New KhenThuong_DAL
                Return obj.Delete_KhenThuongSinhVien(ID_khen_thuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svKhenThuong(ByVal ID_khen_thuong As Integer) As Boolean
            Try
                Dim obj As KhenThuong_DAL = New KhenThuong_DAL
                obj.CheckExist_KhenThuong(ID_khen_thuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svKhenThuongSinhVien(ByVal ID_sv As Integer, ByVal ID_khen_thuong As Integer) As Boolean
            Try
                Dim obj As KhenThuong_DAL = New KhenThuong_DAL
                Return obj.CheckExist_KhenThuongSinhVien(ID_sv, ID_khen_thuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_svKhenThuong() As Integer
            Try
                Dim obj As KhenThuong_DAL = New KhenThuong_DAL
                Return obj.GetMaxID_KhenThuong()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drKhenThuong As DataRow) As KhenThuong
            Dim result As KhenThuong
            Try
                result = New KhenThuong
                If drKhenThuong("ID_khen_thuong").ToString() <> "" Then result.ID_khen_thuong = CType(drKhenThuong("ID_khen_thuong").ToString(), Integer)
                result.So_QD = drKhenThuong("So_QD").ToString()
                If drKhenThuong("Ngay_QD").ToString() <> "" Then result.Ngay_QD = CType(drKhenThuong("Ngay_QD").ToString(), Date)
                If drKhenThuong("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drKhenThuong("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drKhenThuong("Nam_hoc").ToString()
                If drKhenThuong("ID_loai_kt").ToString() <> "" Then result.ID_loai_kt = CType(drKhenThuong("ID_loai_kt").ToString(), Integer)
                If drKhenThuong("ID_cap").ToString() <> "" Then result.ID_cap = CType(drKhenThuong("ID_cap").ToString(), Integer)
                result.Hinh_thuc = drKhenThuong("Hinh_thuc").ToString()
                If drKhenThuong("Ten_cap").ToString() <> "" Then result.Ten_cap = CType(drKhenThuong("Ten_cap").ToString(), String)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Public Sub AddKhenThuong(ByRef dtDSSV As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Try
                dtDSSV.Columns.Add("Khen_thuong", GetType(String))
                For i As Integer = 0 To dtDSSV.Rows.Count - 1
                    If CInt(dtDSSV.Rows(i)("ID_xep_loai")) > 0 And CInt(dtDSSV.Rows(i)("ID_xep_loai")) <= 3 Then
                        dtDSSV.Rows(i)("Khen_thuong") = "SV " & dtDSSV.Rows(i)("Xep_loai")
                    End If
                Next
            Catch ex As Exception
            End Try
        End Sub

#End Region
    End Class
End Namespace
