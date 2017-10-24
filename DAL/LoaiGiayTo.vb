'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Sunday, May 04, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class LoaiGiayTo_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_LoaiGiayTo_DaNop(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_LoaiGiayTo_DaNop", para)
                Else
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter(":ID_sv", ID_sv)
                    Return UDB.SelectTableSP("STU_LoaiGiayTo_DaNop", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_LoaiGiayTo_List(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_LoaiGiayTo_Load_List", para)
                Else
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter(":ID_he", ID_he)
                    para(1) = New SqlParameter(":Khoa_hoc", Khoa_hoc)
                    Return UDB.SelectTableSP("STU_LoaiGiayTo_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Public Function Load_LoaiGiayTo_List() As DataTable
        '    Try
        '        Return UDB.SelectTableSP("STU_LoaiGiayTo_Load_List")
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function

        Public Function Load_LoaiGiayTo(ByVal ID_giay_to As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_giay_to", ID_giay_to)
                    Return UDB.SelectTableSP("STU_LoaiGiayTo_Load", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_giay_to", ID_giay_to)
                    Return UDB.SelectTableSP("STU_LoaiGiayTo_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_LoaiGiayTo(ByVal obj As LoaiGiayTo) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_giay_to", obj.Ma_giay_to)
                    para(1) = New SqlParameter("@Ten_giay_to", obj.Ten_giay_to)
                    Return UDB.ExecuteSP("STU_LoaiGiayTo_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_giay_to", obj.Ma_giay_to)
                    para(1) = New OracleParameter(":Ten_giay_to", obj.Ten_giay_to)
                    Return UDB.ExecuteSP("STU_LoaiGiayTo_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_LoaiGiayTo(ByVal obj As LoaiGiayTo, ByVal ID_giay_to As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_giay_to", ID_giay_to)
                    para(1) = New SqlParameter("@Ma_giay_to", obj.Ma_giay_to)
                    para(2) = New SqlParameter("@Ten_giay_to", obj.Ten_giay_to)
                    Return UDB.ExecuteSP("STU_LoaiGiayTo_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_giay_to", ID_giay_to)
                    para(1) = New OracleParameter(":Ma_giay_to", obj.Ma_giay_to)
                    para(2) = New OracleParameter(":Ten_giay_to", obj.Ten_giay_to)
                    Return UDB.ExecuteSP("STU_LoaiGiayTo_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_LoaiGiayTo(ByVal ID_giay_to As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_giay_to", ID_giay_to)
                    Return UDB.ExecuteSP("STU_LoaiGiayTo_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_giay_to", ID_giay_to)
                    Return UDB.ExecuteSP("STU_LoaiGiayTo_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#Region "Giấy tờ cần nộp theo đối tượng học bổng"
        Public Function Load_DoiTuongGiayTo_List() As DataTable
            Try
                Return UDB.SelectTableSP("STU_DoiTuongGiayTo_load")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DoiTuongGiayTo(ByVal Ma_dt As String, ByVal ID_giay_to As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_dt", Ma_dt)
                    para(1) = New SqlParameter("@ID_giay_to", ID_giay_to)
                    Return UDB.ExecuteSP("STU_DoiTuongGiayTo_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_dt", Ma_dt)
                    para(1) = New OracleParameter(":ID_giay_to", ID_giay_to)
                    Return UDB.ExecuteSP("STU_DoiTuongGiayTo_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DoiTuongGiayTo(ByVal Ma_dt As String, ByVal ID_giay_to As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_dt", Ma_dt)
                    para(1) = New SqlParameter("@ID_giay_to", ID_giay_to)
                    Return UDB.ExecuteSP("STU_DoiTuongGiayTo_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_dt", Ma_dt)
                    para(1) = New OracleParameter(":ID_giay_to", ID_giay_to)
                    Return UDB.ExecuteSP("STU_DoiTuongGiayTo_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DoiTuongGiayTo(ByVal Ma_dt As String, ByVal ID_giay_to As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_dt", Ma_dt)
                    para(1) = New SqlParameter("@ID_giay_to", ID_giay_to)
                    Return UDB.ExecuteSP("STU_DoiTuongGiayTo_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_dt", Ma_dt)
                    para(1) = New OracleParameter(":ID_giay_to", ID_giay_to)
                    Return UDB.ExecuteSP("STU_DoiTuongGiayTo_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_DoiTuongGiayTo(ByVal Ma_dt As String, ByVal ID_giay_to As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_dt", Ma_dt)
                    para(1) = New SqlParameter("@ID_giay_to", ID_giay_to)
                    If UDB.SelectTableSP("STU_DoiTuongGiayTo_CheckExits", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_dt", Ma_dt)
                    para(1) = New OracleParameter(":ID_giay_to", ID_giay_to)
                    If UDB.SelectTableSP("STU_DoiTuongGiayTo_CheckExits", para).Rows.Count > 0 Then
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
#End Region

    End Class
End Namespace


