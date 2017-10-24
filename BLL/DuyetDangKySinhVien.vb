'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Thursday, August 21, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ThienAn.Entity.Entity
Imports ThienAn.DAL.DBManager
Namespace Business
    Public Class DuyetDangKySinhVien_BLL
        Private arrDSDuyet As ArrayList
        Private dtSinhVien As DataTable
#Region "Constructor"
        Public Sub New()

        End Sub

        Public Sub New(ByVal UserName As String, ByVal Ky_dang_ky As Integer)
            Try
                Dim obj As DuyetDangKySinhVien_DAL = New DuyetDangKySinhVien_DAL
                Dim dt As DataTable = obj.Load_DuyetDangKySinhVien_List(UserName, Ky_dang_ky)
                Dim objsvDuyetDangKySinhVien As DuyetDangKySinhVien = Nothing
                Dim dr As DataRow = Nothing
                arrDSDuyet = New ArrayList
                For Each dr In dt.Rows
                    objsvDuyetDangKySinhVien = Converting(dr)
                    arrDSDuyet.Add(objsvDuyetDangKySinhVien)
                Next
                'Load danh sách sinh viên mà User này cố vấn
                Dim clsCoVanHT As New CoVanHocTap_BLL(UserName)
                dtSinhVien = clsCoVanHT.DanhSachSVCoVanHocTap()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function ThongKe_DuyetDangKySinhVien(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_khoa As Integer) As DataTable
            Try
                Dim obj As DuyetDangKySinhVien_DAL = New DuyetDangKySinhVien_DAL
                Return obj.ThongKe_DuyetDangKySinhVien(Hoc_ky, Nam_hoc, ID_khoa)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKe_SinhVienDaDuocPheDuyet(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                Dim obj As DuyetDangKySinhVien_DAL = New DuyetDangKySinhVien_DAL
                Return obj.ThongKe_SinhVienDaDuocPheDuyet(Hoc_ky, Nam_hoc, dsID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKe_SinhVienKhongDuocPheDuyet(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                Dim obj As DuyetDangKySinhVien_DAL = New DuyetDangKySinhVien_DAL
                Return obj.ThongKe_SinhVienKhongDuocPheDuyet(Hoc_ky, Nam_hoc, dsID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKe_SinhVienChuaDuocPheDuyet(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                Dim obj As DuyetDangKySinhVien_DAL = New DuyetDangKySinhVien_DAL
                Return obj.ThongKe_SinhVienChuaDuocPheDuyet(Hoc_ky, Nam_hoc, dsID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSachChuaDuyet() As DataTable
            Dim dt As DataTable = dtSinhVien.Copy
            Dim flag As Boolean = False
            dt.Columns.Add("Duyet", GetType(Boolean))
            dt.Columns.Add("Ly_do", GetType(String))
            For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                dt.Rows(i)("Duyet") = False
                dt.Rows(i)("Ly_do") = ""
                flag = False
                'Tìm sinh viên đã được duyệt chưa
                For j As Integer = 0 To arrDSDuyet.Count - 1
                    If dt.Rows(i)("ID_sv") = CType(arrDSDuyet(j), DuyetDangKySinhVien).ID_sv Then
                        flag = True
                        Exit For
                    End If
                Next
                'Nếu đã được duyệt rồi thì xoá khỏi danh sách
                If flag Then
                    dt.Rows.RemoveAt(i)
                End If
            Next
            dt.AcceptChanges()
            Return dt
        End Function
        Public Function Load_DanhSachDaDuyet() As DataTable
            Dim dt As DataTable = dtSinhVien.Copy
            Dim flag As Boolean = False
            Dim Ly_do As String = ""
            dt.Columns.Add("Duyet", GetType(Boolean))
            dt.Columns.Add("Ly_do", GetType(String))
            For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                flag = False
                'Tìm sinh viên đã được duyệt chưa
                For j As Integer = 0 To arrDSDuyet.Count - 1
                    If dt.Rows(i)("ID_sv") = CType(arrDSDuyet(j), DuyetDangKySinhVien).ID_sv And _
                    CType(arrDSDuyet(j), DuyetDangKySinhVien).Duyet = True Then
                        flag = True
                        Ly_do = CType(arrDSDuyet(j), DuyetDangKySinhVien).Ly_do
                        Exit For
                    End If
                Next
                'Nếu chưa được duyệt thì xoá khỏi danh sách
                If Not flag Then
                    dt.Rows.RemoveAt(i)
                Else
                    dt.Rows(i)("Duyet") = True
                    dt.Rows(i)("Ly_do") = Ly_do
                End If
            Next
            dt.AcceptChanges()
            Return dt
        End Function
        Public Function Load_DanhSachKhongDuocDuyet() As DataTable
            Dim dt As DataTable = dtSinhVien.Copy
            Dim flag As Boolean = False
            Dim Ly_do As String = ""
            dt.Columns.Add("Duyet", GetType(Boolean))
            dt.Columns.Add("Ly_do", GetType(String))
            For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                flag = False
                'Tìm sinh viên đã được duyệt chưa
                For j As Integer = 0 To arrDSDuyet.Count - 1
                    If dt.Rows(i)("ID_sv") = CType(arrDSDuyet(j), DuyetDangKySinhVien).ID_sv And _
                    CType(arrDSDuyet(j), DuyetDangKySinhVien).Duyet = False Then
                        flag = True
                        Ly_do = CType(arrDSDuyet(j), DuyetDangKySinhVien).Ly_do
                        Exit For
                    End If
                Next
                'Nếu chưa được duyệt thì xoá khỏi danh sách
                If Not flag Then
                    dt.Rows.RemoveAt(i)
                Else
                    dt.Rows(i)("Duyet") = False
                    dt.Rows(i)("Ly_do") = Ly_do
                End If
            Next
            dt.AcceptChanges()
            Return dt
        End Function
        Public Function Insert_DuyetDangKySinhVien(ByVal objDuyetDangKySinhVien As DuyetDangKySinhVien) As Integer
            Try
                Dim obj As DuyetDangKySinhVien_DAL = New DuyetDangKySinhVien_DAL
                Return obj.Insert_DuyetDangKySinhVien(objDuyetDangKySinhVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DuyetDangKySinhVien(ByVal objDuyetDangKySinhVien As DuyetDangKySinhVien, ByVal Ky_dang_ky As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DuyetDangKySinhVien_DAL = New DuyetDangKySinhVien_DAL
                Return obj.Update_DuyetDangKySinhVien(objDuyetDangKySinhVien, Ky_dang_ky, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svDuyetDangKySinhVien(ByVal Ky_dang_ky As Integer, ByVal ID_sv As Integer) As Boolean
            Try
                Dim obj As DuyetDangKySinhVien_DAL = New DuyetDangKySinhVien_DAL
                Return obj.CheckExist_DuyetDangKySinhVien(Ky_dang_ky, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drDuyetDangKySinhVien As DataRow) As DuyetDangKySinhVien
            Dim result As DuyetDangKySinhVien
            Try
                result = New DuyetDangKySinhVien
                If drDuyetDangKySinhVien("Ky_dang_ky").ToString() <> "" Then result.Ky_dang_ky = CType(drDuyetDangKySinhVien("Ky_dang_ky").ToString(), Integer)
                If drDuyetDangKySinhVien("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDuyetDangKySinhVien("ID_sv").ToString(), Integer)
                result.Duyet = drDuyetDangKySinhVien("Duyet")
                result.Ly_do = drDuyetDangKySinhVien("Ly_do").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
