Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ThienAn.Entity.Entity
Imports ThienAn.DAL.DBManager
Namespace Business
    Public Class Portal_BLL
        Private objDAL As New Portal_DAL
#Region "Constructor"
        Sub New()
        End Sub
#End Region

#Region "Functions"
        Public Function LoadDiemRenLuyen(ByVal ID_sv As Integer) As DataTable
            Try
                Dim dt As DataTable = objDAL.Load_DiemRenLuyenSinhVien(ID_sv)
                Dim obj As New DiemRenLuyen_DAL
                Dim dtXepLoai As DataTable = obj.Load_XLRenLuyen()
                Dim TongDiem As Integer = 0
                dt.Columns.Add("Xep_loai", GetType(String))
                For i As Integer = 0 To dt.Rows.Count - 1
                    TongDiem = dt.Rows(i)("Tong_diem")
                    For j As Integer = 0 To dtXepLoai.Rows.Count - 1
                        If TongDiem >= dtXepLoai.Rows(j).Item("Tu_diem") And TongDiem <= dtXepLoai.Rows(j).Item("Den_diem") Then
                            dt.Rows(i)("Xep_loai") = dtXepLoai.Rows(j).Item("Xep_loai")
                            Exit For
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function LoaLichThi(ByVal ID_sv As Integer) As DataTable
            Try
                Dim dt As DataTable = objDAL.Load_LichThiSinhVien(ID_sv)
                Return dt
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
#End Region
    End Class
End Namespace
