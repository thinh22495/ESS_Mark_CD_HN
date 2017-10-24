Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ThienAn.Entity.Entity
Imports ThienAn.DAL.DBManager
Imports ThienAn.Machine
Namespace Business
    Public Class GiayToNhapHoc_DN_BLL
        Public Sub New()
        End Sub

        Public Function Sinhvien_list(ByVal ID_lops As String) As DataTable
            Dim StrSql As String
            Dim dt As DataTable
            StrSql = "SELECT a.ID_sv, a.Ma_sv, a.Ho_ten,Hoten_order, a.Ngay_sinh,a.ID_gioi_tinh, d.Gioi_tinh, c.Ten_tinh, a.Ma_dt " & _
                         "FROM svHoSo a " & _
                         "INNER JOIN svDanhSach b ON a.ID_sv = b.ID_sv " & _
                         "LEFT JOIN svTinh c on c.ID_tinh= a.ID_tinh_ns " & _
                         "LEFT JOIN svGioiTinh  d ON a.ID_gioi_tinh = d.ID_gioi_tinh " & _
                         "WHERE b.ID_lop IN(" & ID_lops & ") AND " & sec.ID_lopAccess("b.ID_lop") & _
                         " ORDER BY Ma_sv"
            '-------------------------------------------
            dt = UDB.SelectTable(StrSql)
            '-------------------------------------------
            'Them cot Kiem tra
            Dim ColType As Boolean
            Dim Col As New DataColumn("Chon", ColType.GetType)
            Col.DefaultValue = False
            dt.Columns.Add(Col)
            '-------------------------------------------
            If Not dt Is Nothing Then
                dt.DefaultView.AllowDelete = False
                dt.DefaultView.AllowEdit = True
                dt.DefaultView.AllowNew = False
            End If
            Return dt
        End Function

        Public Function Giayto_nop_list(ByVal ID_sv As Long) As DataTable
            Dim StrSQL As String
            Dim dt As DataTable
            '-----------------------------------------------------------------------------------
            StrSQL = "SELECT a.*,b.Ten_Giay_to FROM svHoSoNop a INNER JOIN svLoaiGiayTo b ON a.ID_giay_to=b.ID_giay_to " & _
                            "WHERE a.ID_sv=" & ID_sv
            dt = UDB.SelectTable(StrSQL)
            If Not dt Is Nothing Then
                dt.DefaultView.AllowDelete = False
                dt.DefaultView.AllowEdit = True
                dt.DefaultView.AllowNew = False
            End If
            Return dt
        End Function

        Public Function Giayto_chuanop_list(ByVal ID_sv As Long) As DataTable
            Dim StrSQL, StrQuery As String
            Dim dt As DataTable
            '-----------------------------------------------------------------------------------
            StrQuery = "SELECT ID_giay_to FROM svHoSoNop " & _
                            "WHERE ID_sv=" & ID_sv
            '-----------------------------------------------------------------------------------
            StrSQL = "SELECT b.* FROM svHoSoYeucau a INNER JOIN svLoaiGiayTo b ON a.ID_giay_to=b.ID_giay_to " & _
                            "WHERE a.ID_giay_to NOT IN(" & StrQuery & ") "
            '-----------------------------------------------------------------------------------
            dt = UDB.SelectTable(StrSQL)
            If Not dt Is Nothing Then
                dt.DefaultView.AllowDelete = False
                dt.DefaultView.AllowEdit = False
                dt.DefaultView.AllowNew = False
            End If
            Return dt
        End Function

        Public Sub Delete(ByVal ID_sv As Long, ByVal ID_giay_to As Long)
            Dim StrSQL As String
            StrSQL = "DELETE FROM svHoSoNop " & _
                            "WHERE ID_sv=" & ID_sv & " AND ID_giay_to=" & ID_giay_to
            UDB.Execute(StrSQL)
        End Sub

        Public Sub Update(ByVal ID_sv As Long, ByVal ID_giay_to As Long, ByVal Ghi_chu_nop As String)
            Ghi_chu_nop = Left(Ghi_chu_nop, 200)
            Dim StrSQL As String
            StrSQL = "UPDATE svHoSoNop SET Ghi_chu_nop=N'" & Replace(Ghi_chu_nop, "'", "''") & "' " & _
                            "WHERE ID_sv=" & ID_sv & " AND ID_giay_to=" & ID_giay_to
            UDB.Execute(StrSQL)
        End Sub

        Public Sub Insert(ByVal ID_sv As Long, ByVal ID_giay_to As Long, Optional ByVal Ghi_chu_nop As String = "")
            Dim StrSQL As String
            StrSQL = "INSERT INTO svHoSoNop(ID_sv,ID_giay_to,Ghi_chu_nop) " & _
                            "VALUES(" & ID_sv & "," & ID_giay_to & ",N'" & Ghi_chu_nop & "')"
            UDB.Execute(StrSQL)
        End Sub

        Public Function CheckExist_giayto_nop(ByVal ID_sv As Long, ByVal ID_giay_to As Long) As Boolean
            Dim StrSQL As String
            Dim dt As DataTable
            StrSQL = "SELECT COUNT(ID_sv) FROM svHoSoNop " & _
                            "WHERE ID_sv=" & ID_sv & " AND ID_giay_to=" & ID_giay_to
            dt = UDB.SelectTable(StrSQL)
            If dt Is Nothing Then Return False
            If dt.Rows(0).Item(0) > 0 Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class

End Namespace