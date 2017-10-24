'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Monday, July 13, 2009
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class QuyCheDaoTao_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Function Load_DanhSach_BangQC() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return UDB.SelectTableSP("MARK_ThamSoQuyChe_Load_List")
                Else
                    Return UDB.SelectTableSP("MARK_ThamSoQuyChe_Load_List")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ThamSoQuyChe(ByVal Quy_che As Integer, ByVal Ma_tham_so As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Quy_che", Quy_che)
                    para(1) = New SqlParameter("@Ma_tham_so", Ma_tham_so)
                    Return UDB.SelectTableSP("MARK_ThamSoQuyChe_Load", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Quy_che", Quy_che)
                    para(1) = New OracleParameter(":Ma_tham_so", Ma_tham_so)
                    Return UDB.SelectTableSP("MARK_ThamSoQuyChe_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_QuyChe(ByVal ID_he As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_he", ID_he)
                    Return UDB.SelectTableSP("STU_He_Load_QuyChe", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_he", ID_he)
                    Return UDB.SelectTableSP("STU_He_Load_QuyChe", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_ThamSoQuyChe(ByVal ID_tham_so_qc As Integer, ByVal Gia_tri As Double) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_tham_so_qc", ID_tham_so_qc)
                    para(1) = New SqlParameter("@Gia_tri", Gia_tri)
                    Return UDB.ExecuteSP("MARK_ThamSoQuyChe_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_tham_so_qc", ID_tham_so_qc)
                    para(1) = New OracleParameter(":Gia_tri", Gia_tri)
                    Return UDB.ExecuteSP("MARK_ThamSoQuyChe_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace


