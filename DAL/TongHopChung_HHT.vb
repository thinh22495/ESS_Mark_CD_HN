Imports ESS.Entity
Imports ESS.Machine
Imports System.Data.SqlClient
Namespace DBManager
    Public Class TongHopChung_HHT_DAL
        Public Function GetTienDoNhapDiem(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsIDLop As String, Optional ByVal Lan_hoc As Integer = 0, Optional ByVal Lan_thi As Integer = 0) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@dsIDLop", dsIDLop)
                para(3) = New SqlParameter("@Lan_hoc", Lan_hoc)
                para(4) = New SqlParameter("@Lan_thi", Lan_thi)
                Return UDB.SelectTableSP("[MARK_TongHopNhapDiem]", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetTienDoNhapDiem_DiemThi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsIDLop As String, Optional ByVal Lan_hoc As Integer = 0, Optional ByVal Lan_thi As Integer = 0) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@dsIDLop", dsIDLop)
                para(3) = New SqlParameter("@Lan_hoc", Lan_hoc)
                para(4) = New SqlParameter("@Lan_thi", Lan_thi)
                Return UDB.SelectTableSP("[MARK_TongHopNhapDiem_DiemThi]", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace