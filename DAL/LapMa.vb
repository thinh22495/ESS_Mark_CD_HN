Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class LapMa_DAL

#Region "Constructor"
        Public Sub New()

        End Sub
#End Region
        'wefwe
#Region "Function"
        Public Function Check_Ma_sv(ByVal Ma_sv As String) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ma_sv", Ma_sv)
                    If UDB.SelectTableSP("STU_HoSoSinhVien_Check_MaSV", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ma_sv", Ma_sv)
                    If UDB.SelectTableSP("STU_HoSoSinhVien_Check_MaSV", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub UpdateMa_sv(ByVal ID_sv As Integer, ByVal Ma_sv As String)
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Ma_sv", Ma_sv)
                    UDB.ExecuteSP("STU_UpdateMa_sv", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Ma_sv", Ma_sv)
                    UDB.ExecuteSP("STU_UpdateMa_sv", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

    End Class
End Namespace


