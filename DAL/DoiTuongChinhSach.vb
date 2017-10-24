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
    Public Class DoiTuongChinhSach_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_DoiTuongChinhSach(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DoiTuongChinhSach_Load", para)
                Else
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DoiTuongChinhSach_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DoiTuongChinhSach() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("STU_DoiTuong_Load")
                Else
                    Return UDB.SelectTableSP("STU_DoiTuong_Load")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DoiTuongChinhSach(ByVal ID_dt As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    If UDB.SelectTableSP("STU_DoiTuong_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    If UDB.SelectTableSP("STU_DoiTuong_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'Public Function Insert_DoiTuongChinhSach(ByVal obj As DoiTuongChinhSach) As Integer
        '    Try
        '        If gDBType = DatabaseType.SQLServer Then
        '            Dim para(3) As SqlParameter
        '            para(0) = New SqlParameter("@Ma_dt", obj.Ma_dt)
        '            para(1) = New SqlParameter("@Ten_dt", obj.Ten_dt)
        '            para(2) = New SqlParameter("@Mien_giam", obj.Mien_giam)
        '            para(3) = New SqlParameter("@Sotien_miengiam", obj.Sotien_miengiam)
        '            Return UDB.ExecuteSP("STU_DoiTuong_Insert", para)
        '        Else
        '            Dim para(3) As OracleParameter
        '            para(0) = New OracleParameter(":Ma_dt", obj.Ma_dt)
        '            para(1) = New OracleParameter(":Ten_dt", obj.Ten_dt)
        '            para(2) = New OracleParameter(":Mien_giam", obj.Mien_giam)
        '            para(3) = New OracleParameter(":Sotien_miengiam", obj.Sotien_miengiam)
        '            Return UDB.ExecuteSP("STU_DoiTuong_Insert", para)
        '        End If
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        'Public Function Update_DoiTuongChinhSach(ByVal obj As DoiTuongChinhSach, ByVal ID_dt As Integer) As Integer
        '    Try
        '        If gDBType = DatabaseType.SQLServer Then
        '            Dim para(4) As SqlParameter
        '            para(0) = New SqlParameter("@ID_dt", ID_dt)
        '            para(1) = New SqlParameter("@Ma_dt", obj.Ma_dt)
        '            para(2) = New SqlParameter("@Ten_dt", obj.Ten_dt)
        '            para(3) = New SqlParameter("@Mien_giam", obj.Mien_giam)
        '            para(4) = New SqlParameter("@Sotien_miengiam", obj.Sotien_miengiam)
        '            Return UDB.ExecuteSP("STU_DoiTuong_Update", para)
        '        Else
        '            Dim para(4) As OracleParameter
        '            para(0) = New OracleParameter(":ID_dt", ID_dt)
        '            para(1) = New OracleParameter(":Ma_dt", obj.Ma_dt)
        '            para(2) = New OracleParameter(":Ten_dt", obj.Ten_dt)
        '            para(3) = New OracleParameter(":Mien_giam", obj.Mien_giam)
        '            para(4) = New OracleParameter(":Sotien_miengiam", obj.Sotien_miengiam)
        '            Return UDB.ExecuteSP("STU_DoiTuong_Update", para)
        '        End If
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        Public Function Delete_DoiTuongChinhSach(ByVal ID_dt As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.ExecuteSP("STU_DoiTuong_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.ExecuteSP("STU_DoiTuong_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


