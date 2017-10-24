'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/24/2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class MonHoc_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_MonHoc_He_List(ByVal ID_he As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    Return UDB.SelectTableSP("MARK_MonHoc_Load_He_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    Return UDB.SelectTableSP("MARK_MonHoc_Load_He_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_MonHoc_List() As DataTable
            Try
                Return UDB.SelectTableSP("MARK_MonHoc_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_MonHoc_ChungChi_List(ByVal ID_dt As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.SelectTableSP("MARK_MonHoc_ChungChi_Load_List", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.SelectTableSP("MARK_MonHoc_ChungChi_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_MonHoc_BoMon_List(ByVal ID_bm As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_bm", ID_bm)
                    Return UDB.SelectTableSP("MARK_MonHoc_Load_BoMon_List", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_bm", ID_bm)
                    Return UDB.SelectTableSP("MARK_MonHoc_Load_BoMon_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_MonHoc(ByVal obj As MonHoc) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@Ky_hieu", obj.Ky_hieu)
                    para(1) = New SqlParameter("@Ten_mon", obj.Ten_mon)
                    para(2) = New SqlParameter("@Ten_tieng_anh", obj.Ten_tieng_anh)
                    para(3) = New SqlParameter("@ID_bm", obj.ID_bm)
                    para(4) = New SqlParameter("@ID_he", obj.ID_he)
                    para(5) = New SqlParameter("@ID_nhom_hp", obj.ID_nhom)
                    Return UDB.ExecuteSP("MARK_MonHoc_DT_Insert", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":Ky_hieu", obj.Ky_hieu)
                    para(1) = New OracleParameter(":Ten_mon", obj.Ten_mon)
                    para(2) = New OracleParameter(":Ten_tieng_anh", obj.Ten_tieng_anh)
                    para(3) = New OracleParameter(":ID_bm", obj.ID_bm)
                    para(4) = New OracleParameter(":ID_he", obj.ID_he)
                    para(5) = New OracleParameter(":ID_nhom_hp", obj.ID_nhom)
                    Return UDB.ExecuteSP("MARK_MonHoc_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_MonHoc(ByVal obj As MonHoc, ByVal ID_mon As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@ID_mon", ID_mon)
                    para(1) = New SqlParameter("@Ky_hieu", obj.Ky_hieu)
                    para(2) = New SqlParameter("@Ten_mon", obj.Ten_mon)
                    para(3) = New SqlParameter("@Ten_tieng_anh", obj.Ten_tieng_anh)
                    para(4) = New SqlParameter("@ID_bm", obj.ID_bm)
                    para(5) = New SqlParameter("@ID_he", obj.ID_he)
                    para(6) = New SqlParameter("@ID_nhom_hp", obj.ID_nhom)
                    Return UDB.ExecuteSP("MARK_MonHoc_Update", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":ID_mon", ID_mon)
                    para(1) = New OracleParameter(":Ky_hieu", obj.Ky_hieu)
                    para(2) = New OracleParameter(":Ten_mon", obj.Ten_mon)
                    para(3) = New OracleParameter(":Ten_tieng_anh", obj.Ten_tieng_anh)
                    para(4) = New OracleParameter(":ID_bm", obj.ID_bm)
                    para(5) = New OracleParameter(":ID_he", obj.ID_he)
                    para(6) = New OracleParameter(":ID_nhom_hp", obj.ID_nhom)
                    Return UDB.ExecuteSP("MARK_MonHoc_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_MonHoc(ByVal ID_mon As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_mon", ID_mon)
                    Return UDB.ExecuteSP("MARK_MonHoc_Delete", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_mon", ID_mon)
                    Return UDB.ExecuteSP("MARK_MonHoc_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function sp_MARK_MonHoc_CheckExist_ky_hieu(ByVal Ky_hieu As String) As Boolean
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@Ky_hieu", Ky_hieu)
                    dt = UDB.SelectTableSP("MARK_MonHoc_CheckExist_ky_hieu", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":Ky_hieu", Ky_hieu)
                    dt = UDB.SelectTableSP("MARK_MonHoc_CheckExist_ky_hieu", para)
                End If
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#Region "Chương trình đào tạo"
        Public Function Load_MonHoc(ByVal ID_mon As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_mon", ID_mon)
                    Return UDB.SelectTableSP("MARK_MonHoc_Load", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_mon", ID_mon)
                    Return UDB.SelectTableSP("MARK_MonHoc_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ChuongTrinhDaoTaoRangBuoc(ByVal ID_mon As Integer, ByVal ID_dt As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_mon", ID_mon)
                    para(1) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoRangBuoc_Load", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_mon", ID_mon)
                    para(1) = New OracleParameter(":ID_dt", ID_dt)

                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoRangBuoc_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ChuongTrinhDaoTaoNhomTuChon(ByVal ID_mon As Integer, ByVal ID_dt As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_mon", ID_mon)
                    para(1) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoNhomTuChon_Load_Nhom", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_mon", ID_mon)
                    para(1) = New OracleParameter(":ID_dt", ID_dt)

                    Return UDB.SelectTableSP("PLAN_ChuongTrinhDaoTaoNhomTuChon_Load_Nhom", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace
'Public Function Load_MonHoc_CTDT(ByVal ID_mon As Integer, ByVal id_dt As Integer) As DataTable
'    Try
'        If gDBType = DatabaseType.SQLServer Then
'            Dim para(1) As SqlParameter
'            para(0) = New SqlParameter("@ID_mon", ID_mon)
'            para(1) = New SqlParameter("@id_dt", id_dt)
'            Return UDB.SelectTableSP("MARK_MonHoc_CTDT_Load", para)
'        Else
'            Dim para(1) As OracleParameter
'            para(0) = New OracleParameter(":ID_mon", ID_mon)
'            para(1) = New OracleParameter(":id_dt", id_dt)
'            Return UDB.SelectTableSP("MARK_MonHoc_CTDT_Load", para)
'        End If
'    Catch ex As Exception
'        Throw ex
'    End Try
'End Function

