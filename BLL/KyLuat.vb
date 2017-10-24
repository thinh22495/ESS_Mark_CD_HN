'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Wednesday, 04 June, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class KyLuat_BLL
        Inherits KyLuat
#Region "Var"
        Private arrKyLuat As ArrayList
        Private dtSinhVienKL As DataTable
#End Region
#Region "Constructor"
        Public Sub New()
        End Sub
        Public Sub New(ByVal ID_lops As String)
            Try
                arrKyLuat = New ArrayList
                Dim obj As KyLuat_DAL = New KyLuat_DAL
                Dim dt As DataTable = obj.Load_KyLuatLop(ID_lops)
                Dim objKyLuat As New KyLuat
                Dim dr As DataRow = Nothing
                For Each dr In dt.Rows
                    objKyLuat = Converting(dr)
                    arrKyLuat.Add(objKyLuat)
                Next
                dtSinhVienKL = obj.Load_SinhVienKyLuat(ID_lops)
            Catch ex As Exception
                Throw ex
            End Try        
        End Sub
        ' Danh sach ky luat của một sinh viên f
        Public Sub New(ByVal ID_sv As Integer)
            Try
                arrKyLuat = New ArrayList
                Dim obj As KyLuat_DAL = New KyLuat_DAL
                Dim dt As DataTable = obj.Load_KyLuatSV(ID_sv)
                Dim objKyLuat As New KyLuat
                Dim dr As DataRow = Nothing
                For Each dr In dt.Rows
                    objKyLuat = Converting(dr)
                    arrKyLuat.Add(objKyLuat)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        ' Danh sach ky luat cua một sinh viên
        Public Function LoadKyLuatSinhVien() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("So_QD", GetType(String))
                dt.Columns.Add("Ngay_QD", GetType(DateTime))
                dt.Columns.Add("Hanh_vi", GetType(String))
                dt.Columns.Add("Xu_ly", GetType(String))
                For i As Integer = 0 To arrKyLuat.Count - 1
                    Dim kl As KyLuat = CType(arrKyLuat(i), KyLuat)
                    Dim row As DataRow = dt.NewRow()
                    row("So_QD") = kl.So_qd
                    row("Ngay_QD") = Format(kl.Ngay_qd, "dd/MM/yyyy")
                    row("Hanh_vi") = kl.Hanh_vi
                    row("Xu_ly") = kl.Xu_ly
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load danh sách sinh vien theo ID_ky_luat ffff
        Public Function Load_SinhVienKyLuat(ByVal ID_ky_luat As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon")
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop")
                dt.Columns.Add("ID_lop")
                dt.Columns.Add("Xoa_ky_luat", GetType(Boolean))
                Dim row As DataRow
                For i As Integer = 0 To dtSinhVienKL.Rows.Count - 1
                    If dtSinhVienKL.Rows(i).Item("ID_ky_luat") = ID_ky_luat Then
                        row = dt.NewRow
                        row("Chon") = False
                        row("ID_sv") = dtSinhVienKL.Rows(i)("ID_sv")
                        row("Ma_sv") = dtSinhVienKL.Rows(i)("Ma_sv")
                        row("Ho_ten") = dtSinhVienKL.Rows(i)("Ho_ten")
                        row("Ngay_sinh") = dtSinhVienKL.Rows(i)("Ngay_sinh")
                        row("Ten_lop") = dtSinhVienKL.Rows(i)("Ten_lop")
                        row("Xoa_ky_luat") = dtSinhVienKL.Rows(i)("Xoa_ky_luat")
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load danh sách kỷ luật theo học kỳ năm học
        Public Function Load_KyLuat(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_ky_luat", GetType(Integer))
                dt.Columns.Add("So_QD", GetType(String))
                dt.Columns.Add("Ngay_QD", GetType(DateTime))
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("ID_hanh_vi", GetType(Integer))
                dt.Columns.Add("Hanh_vi", GetType(String))
                dt.Columns.Add("Noi_dung", GetType(String))
                dt.Columns.Add("ID_xu_ly", GetType(Integer))
                dt.Columns.Add("Muc_xu_ly", GetType(Integer))
                dt.Columns.Add("Xu_ly", GetType(String))
                dt.Columns.Add("ID_cap", GetType(Integer))
                dt.Columns.Add("Ten_cap", GetType(String))
                dt.Columns.Add("Xoa_ky_luat", GetType(Boolean))
                dt.Columns.Add("Ngay_xoa", GetType(String))
                dt.Columns.Add("Lydo_xoa", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                For i As Integer = 0 To arrKyLuat.Count - 1
                    Dim kl As KyLuat = CType(arrKyLuat(i), KyLuat)
                    If kl.Hoc_ky = Hoc_ky And kl.Nam_hoc = Nam_hoc Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_sv") = kl.ID_sv
                        row("ID_ky_luat") = kl.ID_ky_luat
                        row("So_QD") = kl.So_qd
                        row("Ngay_QD") = Format(kl.Ngay_qd, "dd/MM/yyyy")
                        row("Hoc_ky") = kl.Hoc_ky
                        row("Nam_hoc") = kl.Nam_hoc
                        row("ID_hanh_vi") = kl.ID_hanh_vi
                        row("Hanh_vi") = kl.Hanh_vi
                        row("ID_xu_ly") = kl.ID_xu_ly
                        row("Muc_xu_ly") = kl.Muc_xu_ly
                        row("Xu_ly") = kl.Xu_ly
                        row("Xoa_ky_luat") = kl.Xoa_ky_luat
                        row("ID_cap") = kl.ID_cap
                        row("Ten_cap") = kl.Ten_cap
                        row("Noi_dung") = kl.Noi_dung
                        row("Ngay_xoa") = kl.Ngay_xoa
                        row("Lydo_xoa") = kl.Lydo_xoa
                        row("ID_lop") = kl.ID_lop
                        dt.Rows.Add(row)
                    End If
                Next
                dt.AcceptChanges()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load danh sách kỷ luật
        Public Function Load_KyLuat() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_ky_luat", GetType(Integer))
                dt.Columns.Add("So_QD", GetType(String))
                dt.Columns.Add("Ngay_QD", GetType(DateTime))
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("ID_hanh_vi", GetType(Integer))
                dt.Columns.Add("Hanh_vi", GetType(String))
                dt.Columns.Add("Noi_dung", GetType(String))
                dt.Columns.Add("ID_xu_ly", GetType(Integer))
                dt.Columns.Add("Muc_xu_ly", GetType(Integer))
                dt.Columns.Add("Xu_ly", GetType(String))
                dt.Columns.Add("ID_cap", GetType(Integer))
                dt.Columns.Add("Ten_cap", GetType(String))
                dt.Columns.Add("Xoa_ky_luat", GetType(Boolean))
                dt.Columns.Add("Ngay_xoa", GetType(String))
                dt.Columns.Add("Lydo_xoa", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                For i As Integer = 0 To arrKyLuat.Count - 1
                    Dim kl As KyLuat = CType(arrKyLuat(i), KyLuat)
                    Dim row As DataRow = dt.NewRow()
                    row("ID_sv") = kl.ID_sv
                    row("ID_ky_luat") = kl.ID_ky_luat
                    row("So_QD") = kl.So_qd
                    row("Ngay_QD") = Format(kl.Ngay_qd, "dd/MM/yyyy")
                    row("Hoc_ky") = kl.Hoc_ky
                    row("Nam_hoc") = kl.Nam_hoc
                    row("ID_hanh_vi") = kl.ID_hanh_vi
                    row("Hanh_vi") = kl.Hanh_vi
                    row("ID_xu_ly") = kl.ID_xu_ly
                    row("Muc_xu_ly") = kl.Muc_xu_ly
                    row("Xu_ly") = kl.Xu_ly
                    row("Xoa_ky_luat") = kl.Xoa_ky_luat
                    row("ID_cap") = kl.ID_cap
                    row("Ten_cap") = kl.Ten_cap
                    row("Noi_dung") = kl.Noi_dung
                    row("Ngay_xoa") = kl.Ngay_xoa
                    row("Lydo_xoa") = kl.Lydo_xoa
                    row("ID_lop") = kl.ID_lop
                    dt.Rows.Add(row)                    
                Next
                dt.AcceptChanges()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KyLuat_SQD(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_ky_luat", GetType(Integer))
                dt.Columns.Add("So_QD", GetType(String))
                dt.Columns.Add("Ngay_QD", GetType(DateTime))
                dt.Columns.Add("ID_hanh_vi", GetType(Integer))
                dt.Columns.Add("Hanh_vi", GetType(String))
                dt.Columns.Add("ID_xu_ly", GetType(Integer))
                dt.Columns.Add("Xu_ly", GetType(String))
                dt.Columns.Add("Xoa_ky_luat", GetType(Boolean))
                dt.Columns.Add("Ngay_xoa")
                dt.Columns.Add("Lydo_xoa")
                dt.Columns.Add("Noi_dung")
                For i As Integer = 0 To arrKyLuat.Count - 1
                    Dim kl As KyLuat = CType(arrKyLuat(i), KyLuat)
                    If kl.Hoc_ky = Hoc_ky And kl.Nam_hoc = Nam_hoc Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_ky_luat") = kl.ID_ky_luat
                        row("So_QD") = kl.So_qd
                        row("Ngay_QD") = Format(kl.Ngay_qd, "dd/MM/yyyy")
                        row("Ngay_xoa") = kl.Ngay_xoa
                        row("ID_hanh_vi") = kl.ID_hanh_vi
                        row("Hanh_vi") = kl.Hanh_vi
                        row("ID_xu_ly") = kl.ID_xu_ly
                        row("Xu_ly") = kl.Xu_ly
                        row("Xoa_ky_luat") = kl.Xoa_ky_luat
                        row("Lydo_xoa") = kl.Lydo_xoa
                        row("Noi_dung") = kl.Noi_dung
                        dt.Rows.Add(row)
                    End If
                Next
                dt.AcceptChanges()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KyLuat(ByVal ID_ky_luat As Integer) As KyLuat
            Try
                Dim obj As KyLuat_DAL = New KyLuat_DAL
                Dim dt As DataTable = obj.Load_KyLuat(ID_ky_luat)
                Dim objKyLuat As New KyLuat
                If dt.Rows.Count > 0 Then
                    objKyLuat = Converting(dt.Rows(0))
                End If
                Return objKyLuat
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_KyLuat_Sinhvien(ByVal ID_ky_luat As Integer) As KyLuat
            Try
                Dim obj As KyLuat_DAL = New KyLuat_DAL
                Dim dt As DataTable = obj.Load_KyLuat(ID_ky_luat)
                Dim objKyLuat As New KyLuat
                If dt.Rows.Count > 0 Then
                    objKyLuat = Converting(dt.Rows(0))
                End If
                Return objKyLuat
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KyLuat(ByVal objKyLuat As KyLuat) As Integer
            Try
                Dim obj As KyLuat_DAL = New KyLuat_DAL
                Return obj.Insert_KyLuat(objKyLuat)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KyLuatSinhvien(ByVal ID_sv As Integer, ByVal ID_ky_luat As Integer, ByVal Xoa_ky_luat As Integer, ByVal Ngay_xoa As Date, ByVal Ly_do As String) As Integer
            Try
                Dim obj As KyLuat_DAL = New KyLuat_DAL
                Return obj.Insert_KyLuatSinhvien(ID_sv, ID_ky_luat, Xoa_ky_luat, Ngay_xoa, Ly_do)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_KyLuat(ByVal objKyLuat As KyLuat, ByVal ID_ky_luat As Integer) As Integer
            Try
                Dim obj As KyLuat_DAL = New KyLuat_DAL
                Return obj.Update_KyLuat(objKyLuat, ID_ky_luat)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KyLuatSinhvien(ByVal ID_sv As Integer, ByVal ID_ky_luat As Integer, ByVal Xoa_ky_luat As Integer, ByVal Ngay_xoa As Date, ByVal Ly_do As String) As Integer
            Try
                Dim obj As KyLuat_DAL = New KyLuat_DAL
                Return obj.Update_KyLuatSinhVien(ID_sv, ID_ky_luat, Xoa_ky_luat, Ngay_xoa, Ly_do)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_KyLuat(ByVal ID_ky_luat As Integer) As Integer
            Try
                Dim obj As KyLuat_DAL = New KyLuat_DAL
                Return obj.Delete_KyLuat(ID_ky_luat)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KyLuatSinhvien(ByVal ID_ky_luat As Integer) As Integer
            Try
                Dim obj As KyLuat_DAL = New KyLuat_DAL
                Return obj.Delete_KyLuatSinhVien(ID_ky_luat)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svKyLuat(ByVal ID_ky_luat As Integer) As Boolean
            Try
                Dim obj As KyLuat_DAL = New KyLuat_DAL
                obj.CheckExist_STU_KyLuat(ID_ky_luat)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svKyLuatSinhVien(ByVal ID_sv As Integer, ByVal ID_ky_luat As Integer) As Boolean
            Try
                Dim obj As KyLuat_DAL = New KyLuat_DAL
                Return obj.CheckExist_STU_KyLuatSinhVien(ID_sv, ID_ky_luat)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_svKyLuat() As Integer
            Try
                Dim obj As KyLuat_DAL = New KyLuat_DAL
                Return obj.GetMaxID_STU_KyLuat()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drKyLuat As DataRow) As KyLuat
            Dim result As KyLuat
            Try
                result = New KyLuat
                result.ID_sv = drKyLuat("ID_sv")
                If drKyLuat("ID_ky_luat").ToString() <> "" Then result.ID_ky_luat = CType(drKyLuat("ID_ky_luat").ToString(), Integer)
                result.So_qd = drKyLuat("So_qd").ToString()
                If drKyLuat("Ngay_qd").ToString() <> "" Then result.Ngay_qd = CType(drKyLuat("Ngay_qd").ToString(), Date)
                If drKyLuat("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drKyLuat("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drKyLuat("Nam_hoc").ToString()
                If drKyLuat("ID_hanh_vi").ToString() <> "" Then result.ID_hanh_vi = CType(drKyLuat("ID_hanh_vi").ToString(), Integer)
                result.Hanh_vi = drKyLuat("Hanh_vi").ToString()
                If drKyLuat("ID_xu_ly").ToString() <> "" Then result.ID_xu_ly = CType(drKyLuat("ID_xu_ly").ToString(), Integer)
                result.Xu_ly = drKyLuat("Xu_ly").ToString()
                If drKyLuat("ID_cap").ToString() <> "" Then result.ID_cap = CType(drKyLuat("ID_cap").ToString(), Integer)
                result.Ten_cap = drKyLuat("Ten_cap").ToString()
                result.Noi_dung = drKyLuat("Noi_dung").ToString()
                result.Xoa_ky_luat = drKyLuat("Xoa_ky_luat").ToString()
                result.Ngay_xoa = drKyLuat("Ngay_xoa").ToString()
                result.Lydo_xoa = drKyLuat("Lydo_xoa").ToString()
                result.ID_lop = drKyLuat("ID_lop").ToString()
                If drKyLuat("Muc_xu_ly").ToString() <> "" Then result.Muc_xu_ly = drKyLuat("Muc_xu_ly")
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Public Sub AddKyLuat(ByRef dtDSSV As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Try
                dtDSSV.Columns.Add("Ky_luat", GetType(String))
                For i As Integer = 0 To dtDSSV.Rows.Count - 1
                    dtDSSV.Rows(i)("Ky_luat") = KyLuat_ky(dtDSSV.Rows(i)("ID_sv"), Hoc_ky, Nam_hoc)
                Next
            Catch ex As Exception
            End Try
        End Sub

        Public Function KyLuat_ky(ByVal id_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As String
            For i As Integer = 0 To arrKyLuat.Count - 1
                Dim obj As KyLuat = CType(arrKyLuat(i), KyLuat)
                If obj.ID_sv = id_sv And obj.Hoc_ky = Hoc_ky And obj.Nam_hoc = Nam_hoc Then
                    Return obj.Hanh_vi
                End If
            Next
            Return ""
        End Function

#End Region
    End Class
End Namespace
