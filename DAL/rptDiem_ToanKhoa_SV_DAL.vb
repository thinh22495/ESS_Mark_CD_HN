Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class rptDiem_ToanKhoa_SV_DAL
        Public Function Load_DiemToanKhoa_SV(ByVal ID_SV As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_SV)
                Return UDB.SelectTableSP("rpt_Load_DiemToanKhoa_SV", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BangDiemToanKhoa_SV(ByVal ID_SV As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_SV)
                Return UDB.SelectTableSP("sp_svBangDiemSinhVien", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Diem_ChungNhan(ByVal ID_sv As Integer, ByVal ID_mon As Integer) As Double
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                Dim dt As DataTable = UDB.SelectTableSP("Mark_Diem_ChungNhan_Load_List", para)
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)(0)
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function LoadThanhPhanMon_BySV(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return UDB.SelectTableSP("Mark_LoadThanhPhanMon_BySV", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Load_DiemThanhPhan_BySV_Mon(ByVal ID_sv As Integer, ByVal ID_mon As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                Return UDB.SelectTableSP("Mark_Load_DiemThanhPhan_SV_Mon", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace


