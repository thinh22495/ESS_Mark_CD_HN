'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Wednesday, August 06, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class LoaiHocBong_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_DoiTuongHocBong() As DataTable
            Try
                Return UDB.SelectTableSP("STU_DoiTuongHocBong_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_LoaiHocBong_List() As DataTable
            Try
                Return UDB.SelectTableSP("STU_LoaiHocBong_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_LoaiHocBong(ByVal obj As LoaiHocBong) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@Ma_dt", obj.Ma_dt)
                    para(1) = New SqlParameter("@ID_he", obj.ID_he)
                    para(2) = New SqlParameter("@ID_xep_loai_hb", obj.ID_xep_loai_hb)
                    para(3) = New SqlParameter("@HB_HT", obj.HB_HT)
                    Return UDB.ExecuteSP("STU_LoaiHocBong_Insert", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":Ma_dt", obj.Ma_dt)
                    para(1) = New OracleParameter(":ID_he", obj.ID_he)
                    para(2) = New OracleParameter(":ID_xep_loai_hb", obj.ID_xep_loai_hb)
                    para(3) = New OracleParameter(":HB_HT", obj.HB_HT)
                    Return UDB.ExecuteSP("STU_LoaiHocBong_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_LoaiHocBong(ByVal obj As LoaiHocBong) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@Ma_dt", obj.Ma_dt)
                    para(1) = New SqlParameter("@ID_he", obj.ID_he)
                    para(2) = New SqlParameter("@ID_xep_loai_hb", obj.ID_xep_loai_hb)
                    para(3) = New SqlParameter("@HB_HT", obj.HB_HT)
                    Return UDB.ExecuteSP("STU_LoaiHocBong_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":Ma_dt", obj.Ma_dt)
                    para(1) = New OracleParameter(":ID_he", obj.ID_he)
                    para(2) = New OracleParameter(":ID_xep_loai_hb", obj.ID_xep_loai_hb)
                    para(3) = New OracleParameter(":HB_HT", obj.HB_HT)
                    Return UDB.ExecuteSP("STU_LoaiHocBong_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_LoaiHocBong(ByVal Ma_dt As String, ByVal ID_he As Integer, ByVal ID_xep_loai_hb As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Ma_dt", Ma_dt)
                    para(1) = New SqlParameter("@ID_he", ID_he)
                    para(2) = New SqlParameter("@ID_xep_loai_hb", ID_xep_loai_hb)
                    Return UDB.ExecuteSP("STU_LoaiHocBong_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Ma_dt", Ma_dt)
                    para(1) = New OracleParameter(":ID_he", ID_he)
                    para(2) = New OracleParameter(":ID_xep_loai_hb", ID_xep_loai_hb)
                    Return UDB.ExecuteSP("STU_LoaiHocBong_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_LoaiHocBong(ByVal Ma_dt As String, ByVal ID_he As Integer, ByVal ID_xep_loai_hb As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Ma_dt", Ma_dt)
                    para(1) = New SqlParameter("@ID_he", ID_he)
                    para(2) = New SqlParameter("@ID_xep_loai_hb", ID_xep_loai_hb)
                    If UDB.SelectTableSP("STU_LoaiHocBong_CheckExist", para).Rows.Count Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Ma_dt", Ma_dt)
                    para(1) = New OracleParameter(":ID_he", ID_he)
                    para(2) = New OracleParameter(":ID_xep_loai_hb", ID_xep_loai_hb)
                    If UDB.SelectTableSP("STU_LoaiHocBong_CheckExist", para).Rows.Count Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


