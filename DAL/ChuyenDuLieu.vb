Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Imports System.IO
Namespace DBManager
    Public Class ChuyenDuLieu_DAL
        Public Sub New()

        End Sub
        Public Function LoadHoSoTemp(ByVal UserID As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@UserID", UserID)
                    Return UDB.SelectTableSP("STU_LoadHoSoSinhVienTemp", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":UserID", UserID)
                    Return UDB.SelectTableSP("STU_LoadHoSoSinhVienTemp", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function LoadCauTrucHoSoSinhVien() As DataTable
            Try
                Return UDB.SelectTableSP("STU_LoadCauTrucHoSoSinhVien")
            Catch ex As Exception
                Throw ex
            End Try
        End Function '
        Public Function getDataSource(ByVal TableName As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@TableName", TableName)
                    Return UDB.SelectTableSP("STU_GetDataSource", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":TableName", TableName)
                    Return UDB.SelectTableSP("STU_GetDataSource", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getDMTables(ByVal strFields As String) As DataTable
            Try                               
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@strFields", strFields)                    
                    Return UDB.SelectTable("STU_getDMTables " & strFields) ', para)                    
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":strFields", strFields)
                    Return UDB.SelectTableSP("STU_getDMTables", para)
                End If                
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Láy giá trị danh mục
        Public Function getDMValueTen(ByVal DTable As String, ByVal DFieldID As String, ByVal DFieldName As String, ByVal strValue As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@DFieldID", DFieldID)
                    para(1) = New SqlParameter("@DFieldName", DFieldName)
                    para(2) = New SqlParameter("@DTable", DTable)
                    para(3) = New SqlParameter("@strValue", strValue)                    
                    Return UDB.SelectTableSP("STU_GetDMValueTen", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":DFieldID", DFieldID)
                    para(1) = New OracleParameter(":DFieldName", DFieldName)
                    para(2) = New OracleParameter(":DTable", DTable)
                    para(3) = New OracleParameter(":strValue", strValue)
                    Return UDB.SelectTableSP("STU_GetDMValueTen", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getDMValueMa(ByVal DTable As String, ByVal DFieldID As String, ByVal DFieldMa As String, ByVal DFieldName As String, ByVal strValue As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@DFieldID", DFieldID)
                    para(1) = New SqlParameter("@DFieldName", DFieldName)
                    para(2) = New SqlParameter("@DTable", DTable)
                    para(3) = New SqlParameter("@strValue", strValue)
                    para(4) = New SqlParameter("@DFieldMa", DFieldMa)
                    Return UDB.SelectTableSP("STU_GetDMValueMa", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":DFieldID", DFieldID)
                    para(1) = New OracleParameter(":DFieldName", DFieldName)
                    para(2) = New OracleParameter(":DTable", DTable)
                    para(3) = New OracleParameter(":strValue", strValue)
                    para(4) = New OracleParameter(":DFieldMa", DFieldMa)
                    Return UDB.SelectTableSP("STU_GetDMValueMa", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getColumName_Ma(ByVal DTable As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@DTable", DTable)
                    Return UDB.SelectTableSP("STU_GetColumName_Ma", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":DTable", DTable)
                    Return UDB.SelectTableSP("STU_GetColumName_Ma", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getColumName_ID(ByVal DTable As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@DTable", DTable)
                    Return UDB.SelectTableSP("STU_GetColumName_ID", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":DTable", DTable)
                    Return UDB.SelectTableSP("STU_GetColumName_ID", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace



