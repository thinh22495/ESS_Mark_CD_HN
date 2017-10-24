Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class rptDiem_ToanKhoa_SV_BLL
        Public Function Load_BangDiemToanKhoa_SV(ByVal ID_SV As Integer) As DataTable
            Try
                Dim obj As rptDiem_ToanKhoa_SV_DAL = New rptDiem_ToanKhoa_SV_DAL
                Return obj.Load_BangDiemToanKhoa_SV(ID_SV)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function Load_XepHangTotNghiep(ByVal TBCHT_TK As Double) As String
            Dim dtXepHangTotNghiep As DataTable
            Dim clsDAL As New Diem_DAL
            'Load các học phần thuộc các chương trình đào tạo
            dtXepHangTotNghiep = clsDAL.Load_XepHangTotNghiep()
            For i As Integer = 0 To dtXepHangTotNghiep.Rows.Count - 1
                If TBCHT_TK >= dtXepHangTotNghiep.Rows(i)("Tu_diem") And TBCHT_TK < dtXepHangTotNghiep.Rows(i)("Den_diem") Then
                    Return dtXepHangTotNghiep.Rows(i)("Xep_hang").ToString
                End If
            Next
            Return ""
        End Function

        Public Function Diem_ChungNhan(ByVal ID_sv As Integer, ByVal ID_mon As Integer) As Double
            Try
                Dim obj As rptDiem_ToanKhoa_SV_DAL = New rptDiem_ToanKhoa_SV_DAL
                Return obj.Diem_ChungNhan(ID_sv, ID_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LoadThanhPhanMon_BySV(ByVal ID_sv As Integer) As DataTable
            Try
                Dim obj As rptDiem_ToanKhoa_SV_DAL = New rptDiem_ToanKhoa_SV_DAL
                Return obj.LoadThanhPhanMon_BySV(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_DiemThanhPhan_BySV_Mon(ByVal ID_sv As Integer, ByVal ID_mon As Integer) As DataTable
            Try
                Dim obj As rptDiem_ToanKhoa_SV_DAL = New rptDiem_ToanKhoa_SV_DAL
                Return obj.Load_DiemThanhPhan_BySV_Mon(ID_sv, ID_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

