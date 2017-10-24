'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Monday, June 16, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ThienAn.Machine
Imports ThienAn.Entity.Entity
Namespace DBManager
    Public Class XepLoaiHocTap_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_XepLoaiHocTap_List() As DataTable
            Try
                Return UDB.SelectTableSP("sp_svXepLoai_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_XepLoaiHocTap(ByVal obj As XepLoaiHocTap) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Xep_loai", obj.Xep_loai)
                    para(1) = New SqlParameter("@Tu_diem", obj.Tu_diem)
                    para(2) = New SqlParameter("@Den_diem", obj.Den_diem)
                    para(3) = New SqlParameter("@Diem_chu", obj.Diem_chu)
                    para(4) = New SqlParameter("@Diem_so", obj.Diem_so)
                    para(5) = New SqlParameter("@Thuong_diem", obj.Thuong_diem)
                    Return UDB.ExecuteSP("sp_svXepLoai_Insert", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":Xep_loai", obj.Xep_loai)
                    para(1) = New OracleParameter(":Tu_diem", obj.Tu_diem)
                    para(2) = New OracleParameter(":Den_diem", obj.Den_diem)
                    para(3) = New OracleParameter(":Diem_chu", obj.Diem_chu)
                    para(4) = New OracleParameter(":Diem_so", obj.Diem_so)
                    para(5) = New OracleParameter(":Thuong_diem", obj.Thuong_diem)
                    Return UDB.ExecuteSP("sp_svXepLoai_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_XepLoaiHocTap(ByVal obj As XepLoaiHocTap, ByVal ID_xep_loai As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@ID_xep_loai", ID_xep_loai)
                    para(1) = New SqlParameter("@Xep_loai", obj.Xep_loai)
                    para(2) = New SqlParameter("@Tu_diem", obj.Tu_diem)
                    para(3) = New SqlParameter("@Den_diem", obj.Den_diem)
                    para(4) = New SqlParameter("@Diem_chu", obj.Diem_chu)
                    para(5) = New SqlParameter("@Diem_so", obj.Diem_so)
                    para(6) = New SqlParameter("@Thuong_diem", obj.Thuong_diem)
                    Return UDB.ExecuteSP("sp_svXepLoai_Update", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_xep_loai", ID_xep_loai)
                    para(1) = New OracleParameter(":Xep_loai", obj.Xep_loai)
                    para(2) = New OracleParameter(":Tu_diem", obj.Tu_diem)
                    para(3) = New OracleParameter(":Den_diem", obj.Den_diem)
                    para(4) = New OracleParameter(":Diem_chu", obj.Diem_chu)
                    para(5) = New OracleParameter(":Diem_so", obj.Diem_so)
                    para(6) = New OracleParameter(":Thuong_diem", obj.Thuong_diem)
                    Return UDB.ExecuteSP("sp_svXepLoai_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_XepLoaiHocTap(ByVal ID_xep_loai As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_xep_loai", ID_xep_loai)
                    Return UDB.ExecuteSP("sp_svXepLoai_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_xep_loai", ID_xep_loai)
                    Return UDB.ExecuteSP("sp_svXepLoai_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


