'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/05/2008
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class ThamSoHeThong_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Doc_tham_so(ByVal key As String) As String
            Try
                Dim strSQL As String = "SELECT Gia_tri FROM SYS_ThamSoHeThong WHERE ID_tham_so ='" + key + "'"
                Dim dt As DataTable = UDB.SelectTable(strSQL)
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0).Item(0).ToString
                End If
                Return ""
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Doc_tham_so_Active(ByVal key As String) As Boolean
            Try
                Dim strSQL As String = "SELECT Active FROM SYS_ThamSoHeThong WHERE ID_tham_so ='" + key + "'"
                Dim dt As DataTable = UDB.SelectTable(strSQL)
                If dt.Rows.Count > 0 Then
                    Return CType(dt.Rows(0).Item(0), Boolean)
                End If
                Return True
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Load_ThamSoHeThong() As DataTable
            Try
                Return UDB.SelectTableSP("ThamSoHeThong_Load")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_ThamSoHeThong_List(ByVal ID_ph As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_ph", ID_ph)
                    Return UDB.SelectTableSP("SYS_ThamSoHeThong_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_ph", ID_ph)
                    Return UDB.SelectTableSP("SYS_ThamSoHeThong_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_ThamSoHeThong(ByVal obj As ThamSoHeThong, ByVal ID_tham_so As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_tham_so", ID_tham_so)
                    para(1) = New SqlParameter("@Ten_tham_so", obj.Ten_tham_so)
                    para(2) = New SqlParameter("@ID_ph", obj.ID_ph)
                    para(3) = New SqlParameter("@Gia_tri", obj.Gia_tri)
                    para(4) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    para(5) = New SqlParameter("@Active", obj.Active)
                    Return UDB.ExecuteSP("SYS_ThamSoHeThong_Update", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_tham_so", ID_tham_so)
                    para(1) = New OracleParameter(":Ten_tham_so", obj.Ten_tham_so)
                    para(2) = New OracleParameter(":ID_ph", obj.ID_ph)
                    para(3) = New OracleParameter(":Gia_tri", obj.Gia_tri)
                    para(4) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    para(5) = New OracleParameter(":Active", obj.Active)
                    Return UDB.ExecuteSP("SYS_ThamSoHeThong_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        
        Public Function Update_ThamSoHeThong(ByVal obj As ThamSoHeThong) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_tham_so", obj.ID_tham_so)
                    para(1) = New SqlParameter("@Gia_tri", obj.Gia_tri)
                    para(2) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                    para(3) = New SqlParameter("@Active", obj.Active)
                    Return UDB.ExecuteSP("SYS_ThamSoHeThong_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_tham_so", obj.ID_tham_so)
                    para(1) = New OracleParameter(":Gia_tri", obj.Gia_tri)
                    para(2) = New OracleParameter(":Ghi_chu", obj.Ghi_chu)
                    para(3) = New OracleParameter(":Active", obj.Active)
                    Return UDB.ExecuteSP("SYS_ThamSoHeThong_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

      
#End Region

    End Class
End Namespace

