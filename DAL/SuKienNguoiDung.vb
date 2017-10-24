'---------------------------------------------------------------------------
' Author : Ð? Van L?c
' Company : Thiên An ESS
' Created Date : Tuesday, 03 June, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class SuKienNguoiDung_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_SuKienNguoiDung(ByVal obj As SuKienNguoiDung, Optional ByVal Tu_ngay As String = "", Optional ByVal Den_ngay As String = "") As DataTable ', Optional ByVal ID_Phan_he As Integer = 0, Optional ByVal Su_kien As Integer = 0, Optional ByVal UserName As String = "", Optional ByVal Chuc_nang As String = "", Optional ByVal Noi_dung As String = "", Optional ByVal May_tram As String = "") As DataTable
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_Phan_he", obj.ID_phan_he)
                para(1) = New SqlParameter("@Su_kien", obj.Su_kien)
                para(2) = New SqlParameter("@Chuc_nang", obj.Chuc_nang)
                para(3) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                para(4) = New SqlParameter("@May_tram", obj.May_tram)
                para(5) = New SqlParameter("@Tu_ngay", Tu_ngay)
                para(6) = New SqlParameter("@Den_ngay", Den_ngay)
                para(7) = New SqlParameter("@UserName", obj.UserName)
                Return UDB.SelectTableSP("SYS_SuKienNguoiDung_Load", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_SuKienNguoiDung(ByVal obj As SuKienNguoiDung) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@ID_phan_he", obj.ID_phan_he)
                    para(1) = New SqlParameter("@Su_kien", obj.Su_kien)
                    para(2) = New SqlParameter("@Chuc_nang", obj.Chuc_nang)
                    para(3) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                    para(4) = New SqlParameter("@Thoi_diem", obj.Thoi_diem)
                    para(5) = New SqlParameter("@May_tram", obj.May_tram)
                    para(6) = New SqlParameter("@UserName", obj.UserName)
                    Return UDB.ExecuteSP("SYS_SuKienNguoiDung_Insert", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_phan_he", obj.ID_phan_he)
                    para(1) = New OracleParameter(":Su_kien", obj.Su_kien)
                    para(2) = New OracleParameter(":Chuc_nang", obj.Chuc_nang)
                    para(3) = New OracleParameter(":Noi_dung", obj.Noi_dung)
                    para(4) = New OracleParameter(":Thoi_diem", obj.Thoi_diem)
                    para(5) = New OracleParameter(":May_tram", obj.May_tram)
                    para(6) = New OracleParameter(":UserName", obj.UserName)
                    Return UDB.ExecuteSP("SYS_SuKienNguoiDung_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_SuKienNguoiDung(ByVal obj As SuKienNguoiDung, ByVal ID_su_kien As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_su_kien", ID_su_kien)
                    para(1) = New SqlParameter("@ID_phan_he", obj.ID_phan_he)
                    para(2) = New SqlParameter("@Su_kien", obj.Su_kien)
                    para(3) = New SqlParameter("@Chuc_nang", obj.Chuc_nang)
                    para(4) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                    para(5) = New SqlParameter("@Thoi_diem", obj.Thoi_diem)
                    para(6) = New SqlParameter("@May_tram", obj.May_tram)
                    para(7) = New SqlParameter("@UserName", obj.UserName)
                    Return UDB.ExecuteSP("SYS_SuKienNguoiDung_Update", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":ID_su_kien", ID_su_kien)
                    para(1) = New OracleParameter(":ID_phan_he", obj.ID_phan_he)
                    para(2) = New OracleParameter(":Su_kien", obj.Su_kien)
                    para(3) = New OracleParameter(":Chuc_nang", obj.Chuc_nang)
                    para(4) = New OracleParameter(":Noi_dung", obj.Noi_dung)
                    para(5) = New OracleParameter(":Thoi_diem", obj.Thoi_diem)
                    para(6) = New OracleParameter(":May_tram", obj.May_tram)
                    para(7) = New OracleParameter(":UserName", obj.UserName)
                    Return UDB.ExecuteSP("SYS_SuKienNguoiDung_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_SuKienNguoiDung(ByVal ID_su_kien As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_su_kien", ID_su_kien)
                    Return UDB.ExecuteSP("SYS_SuKienNguoiDung_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_su_kien", ID_su_kien)
                    Return UDB.ExecuteSP("SYS_SuKienNguoiDung_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


