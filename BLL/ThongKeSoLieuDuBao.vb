'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Tuesday, April 22, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ThienAn.Entity.Entity
Imports ThienAn.DAL.DBManager
Namespace Business
    Public Class ThongKeSoLieuDuBao_BLL
        Public Function ThongkeTheoCTDT_Nganh1(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim obj As ThongKeSoLieuDuBao_DAL = New ThongKeSoLieuDuBao_DAL
                Dim dt1, dt2 As DataTable
                'Tính số sinh viên học các học phần theo chương trình đào tạo khung
                dt1 = obj.SoSinhVienHoc_TCDT_Nganh1(Hoc_ky, Nam_hoc, ID_he, ID_khoa, Khoa_hoc, ID_nganh, ID_chuyen_nganh)
                'Tính số sinh viên đã tích lũy
                dt2 = obj.SoSinhVien_DaTichLuy_Nganh1(ID_he, ID_khoa, Khoa_hoc, ID_nganh, ID_chuyen_nganh)
                'Duyệt để trừ đi số sinh viên đã tích lũy học phần
                For i As Integer = 0 To dt1.Rows.Count - 1
                    For j As Integer = 0 To dt2.Rows.Count - 1
                        If dt1.Rows(i)("ID_mon") = dt2.Rows(j)("ID_mon") And dt1.Rows(i)("So_hoc_trinh") = dt2.Rows(j)("So_hoc_trinh") Then
                            dt1.Rows(i)("So_sv") = CInt(dt1.Rows(i)("So_sv").ToString) - CInt(dt2.Rows(j)("So_sv").ToString)
                        End If
                    Next
                Next
                'Xóa những môn có số sv bằng 0
                For i As Integer = dt1.Rows.Count - 1 To 0 Step -1
                    If dt1.Rows(i)("So_sv") = 0 Then dt1.Rows(i).Delete()
                Next
                dt1.AcceptChanges()
                Return dt1
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongkeTheoCTDT_Nganh2(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim obj As ThongKeSoLieuDuBao_DAL = New ThongKeSoLieuDuBao_DAL
                Dim dt1, dt2 As DataTable
                'Tính số sinh viên học các học phần theo chương trình đào tạo khung thứ 2
                dt1 = obj.SoSinhVienHoc_TCDT_Nganh2(Hoc_ky, Nam_hoc, ID_he, ID_khoa, Khoa_hoc, ID_nganh, ID_chuyen_nganh)
                'Tính số sinh viên đã tích lũy
                dt2 = obj.SoSinhVien_DaTichLuy_Nganh2(ID_he, ID_khoa, Khoa_hoc, ID_nganh, ID_chuyen_nganh)
                'Duyệt để trừ đi số sinh viên đã tích lũy học phần
                For i As Integer = 0 To dt1.Rows.Count - 1
                    For j As Integer = 0 To dt2.Rows.Count - 1
                        If dt1.Rows(i)("ID_mon") = dt2.Rows(j)("ID_mon") And dt1.Rows(i)("So_hoc_trinh") = dt2.Rows(j)("So_hoc_trinh") Then
                            dt1.Rows(i)("So_sv") = CInt(dt1.Rows(i)("So_sv").ToString) - CInt(dt2.Rows(j)("So_sv").ToString)
                        End If
                    Next
                Next
                'Xóa những môn có số sv bằng 0
                For i As Integer = dt1.Rows.Count - 1 To 0 Step -1
                    If dt1.Rows(i)("So_sv") = 0 Then dt1.Rows(i).Delete()
                Next
                dt1.AcceptChanges()
                Return dt1
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongkeTheoDangKySom_Nganh1(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim obj As ThongKeSoLieuDuBao_DAL = New ThongKeSoLieuDuBao_DAL
                Dim dt1 As DataTable
                'Tính số sinh viên đăng ký học sớm ngành 1
                dt1 = obj.SoSinhVien_DangKySom_Nganh1(Hoc_ky, Nam_hoc, ID_he, ID_khoa, Khoa_hoc, ID_nganh, ID_chuyen_nganh)
                Return dt1
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongkeTheoDangKySom_Nganh2(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim obj As ThongKeSoLieuDuBao_DAL = New ThongKeSoLieuDuBao_DAL
                Dim dt1 As DataTable
                'Tính số sinh viên đăng ký học sớm ngành 2
                dt1 = obj.SoSinhVien_DangKySom_Nganh2(Hoc_ky, Nam_hoc, ID_he, ID_khoa, Khoa_hoc, ID_nganh, ID_chuyen_nganh)
                Return dt1
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace