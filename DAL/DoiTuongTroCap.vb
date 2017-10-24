'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, April 22, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DoiTuongTroCap_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_DanhSachTroCap(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("STU_DanhSachTroCap_Load_List", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":dsID_lop", dsID_lop)
                    Return UDB.SelectTableSP("STU_DanhSachTroCap_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DoiTuongTroCap(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DoiTuongHocBong_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DoiTuongHocBong_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load danh mục đối tượng học bổng
        Public Function Load_DoiTuong() As DataTable
            Try
                Return UDB.SelectTableSP("STU_DoiTuongHocBong_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DoiTuongTroCap(ByVal obj As DoiTuongTroCap) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Ma_dt_hb", obj.Ma_dt_hb)
                    para(1) = New SqlParameter("@Ten_dt_hb", obj.Ten_dt_hb)
                    para(2) = New SqlParameter("@Sotien_trocap", obj.Sotien_trocap)
                    Return UDB.ExecuteSP("STU_DoiTuongHocBong_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Ma_dt_hb", obj.Ma_dt_hb)
                    para(1) = New OracleParameter(":Ten_dt_hb", obj.Ten_dt_hb)
                    para(2) = New OracleParameter(":Sotien_trocap", obj.Sotien_trocap)
                    Return UDB.ExecuteSP("STU_DoiTuongHocBong_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DoiTuongTroCap(ByVal obj As DoiTuongTroCap, ByVal ID_dt_hb As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt_hb", ID_dt_hb)
                    para(1) = New SqlParameter("@Ma_dt_hb", obj.Ma_dt_hb)
                    para(2) = New SqlParameter("@Ten_dt_hb", obj.Ten_dt_hb)
                    para(3) = New SqlParameter("@Sotien_trocap", obj.Sotien_trocap)
                    Return UDB.ExecuteSP("STU_DoiTuongHocBong_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt_hb", ID_dt_hb)
                    para(1) = New OracleParameter(":Ma_dt_hb", obj.Ma_dt_hb)
                    para(2) = New OracleParameter(":Ten_dt_hb", obj.Ten_dt_hb)
                    para(3) = New OracleParameter(":Sotien_trocap", obj.Sotien_trocap)
                    Return UDB.ExecuteSP("STU_DoiTuongHocBong_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DoiTuongTroCap(ByVal ID_dt_hb As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt_hb", ID_dt_hb)
                    Return UDB.ExecuteSP("STU_DoiTuongHocBong_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt_hb", ID_dt_hb)
                    Return UDB.ExecuteSP("STU_DoiTuongHocBong_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_DoiTuongTroCap(ByVal Ma_dt_hb As String) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ma_dt_hb", Ma_dt_hb)
                    If UDB.SelectTableSP("STU_DoiTuongHocBong_Check", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ma_dt_hb", Ma_dt_hb)
                    If UDB.SelectTableSP("STU_DoiTuongHocBong_Check", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#Region "Danh sách xác định tiền trợ cập"
        Public Function Check_DanhSachTroCap(ByVal obj As DanhSachTroCap) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    If UDB.SelectTableSP("STU_DanhSachTroCap_Check", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    If UDB.SelectTableSP("STU_DanhSachTroCap_Check", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DanhSachTroCap(ByVal obj As DanhSachTroCap) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(2) = New SqlParameter("@Sotien_trocap", obj.Sotien_trocap)
                    para(3) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(4) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("STU_DanhSachTroCap_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(2) = New OracleParameter(":Sotien_trocap", obj.Sotien_trocap)
                    para(3) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(4) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("STU_DanhSachTroCap_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSachTroCap(ByVal obj As DanhSachTroCap) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@Sotien_trocap", obj.Sotien_trocap)
                    para(4) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("STU_DanhSachTroCap_Update", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":Sotien_trocap", obj.Sotien_trocap)
                    para(4) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    Return UDB.ExecuteSP("STU_DanhSachTroCap_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSachTroCap(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.ExecuteSP("STU_DanhSachTroCap_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.ExecuteSP("STU_DanhSachTroCap_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
#End Region

    End Class
End Namespace


