'---------------------------------------------------------------------------
' Author : Thiên An ESS
' Company : Thien An ESS
' Created Date : 04/02/2011
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity

Namespace DBManager
    Public Class DiemRenLuyen_New_DAL
#Region "Constructor"
        Public Sub New()

        End Sub
#End Region
#Region "Function"
        Public Function Load_XLRenLuyen() As DataTable
            Try
                Return UDB.SelectTableSP("STU_XLRenLuyen_Load")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DiemRenLuyen_New_List() As DataTable
            Try
                Return UDB.SelectTableSP("MARK_DiemRenLuyen_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DiemRenLuyen_NewLop(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("MARK_DiemRenLuyen_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("MARK_DiemRenLuyen_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_SVRenLuyenLop(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_SinhVienRenLuyen_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_SinhVienRenLuyen_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DiemLoaiRenLuyen(ByVal ID_Loai_rl As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_Loai_rl", ID_Loai_rl)
                    Return UDB.SelectTableSP("STU_LoaiRenLuyen_Load", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_Loai_rl", ID_Loai_rl)
                    Return UDB.SelectTableSP("STU_LoaiRenLuyen_Load", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DiemRenLuyen_New(ByVal obj As DiemRenLuyen_New) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@Diem", obj.Diem)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(4) = New SqlParameter("@ID_loai_rl", obj.ID_loai_rl)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyen_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":Diem", obj.Diem)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(4) = New OracleParameter(":ID_loai_rl", obj.ID_loai_rl)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyen_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Public Function Insert_DiemRenLuyen_NewExcel(ByVal obj As DiemRenLuyen_New) As Integer
        '    Try
        '        If gDBType = DatabaseType.SQLServer Then
        '            Dim para(4) As SqlParameter
        '            para(0) = New SqlParameter("@Diem", obj.Diem)
        '            para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
        '            para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
        '            para(3) = New SqlParameter("@ID_sv", obj.ID_sv)
        '            para(4) = New SqlParameter("@ID_loai_rl", obj.ID_loai_rl)
        '            Return UDB.ExecuteSP("MARK_DiemRenLuyen_NewExcel_Insert", para)
        '        Else
        '            Dim para(4) As OracleParameter
        '            para(0) = New OracleParameter(":Diem", obj.Diem)
        '            para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
        '            para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
        '            para(3) = New OracleParameter(":ID_sv", obj.ID_sv)
        '            para(4) = New OracleParameter(":ID_loai_rl", obj.ID_loai_rl)
        '            Return UDB.ExecuteSP("MARK_DiemRenLuyen_NewExcel_Insert", para)
        '        End If
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        Public Function Update_DiemRenLuyen_New(ByVal obj As DiemRenLuyen_New) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem_rl", obj.ID_diem_rl)
                    para(1) = New SqlParameter("@Diem", obj.Diem)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyen_Update", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem_rl", obj.ID_diem_rl)
                    para(1) = New OracleParameter(":Diem", obj.Diem)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyen_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function KhoaMo_DiemRenLuyen_New(ByVal Lock As Boolean, ByVal ID_diem_rl As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem_rl", ID_diem_rl)
                    para(1) = New SqlParameter("@Locked", Lock)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyen_KhoaMo", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem_rl", ID_diem_rl)
                    para(1) = New OracleParameter(":Locked", Lock)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyen_KhoaMo", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function



        Public Function Update_DiemRenLuyen_NewExcel(ByVal obj As DiemRenLuyen_New) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@Diem", obj.Diem)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(4) = New SqlParameter("@ID_loai_rl", obj.ID_loai_rl)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyenExcel_Update", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":Diem", obj.Diem)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(4) = New OracleParameter(":ID_loai_rl", obj.ID_loai_rl)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyenExcel_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DiemRenLuyen_NewExcel(ByVal obj As DiemRenLuyen_New) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(2) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(3) = New SqlParameter("@ID_loai_rl", obj.ID_loai_rl)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyenExcel_Delete", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(2) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(3) = New OracleParameter(":ID_loai_rl", obj.ID_loai_rl)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyenExcel_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DiemRenLuyen_New(ByVal ID_diem_rl As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem_rl", ID_diem_rl)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyen_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem_rl", ID_diem_rl)
                    Return UDB.ExecuteSP("MARK_DiemRenLuyen_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DiemRenLuyen_New(ByVal obj As DiemRenLuyen_New) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_diem_rl", obj.ID_diem_rl)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(4) = New SqlParameter("@ID_loai_rl", obj.ID_loai_rl)
                    If UDB.SelectTableSP("MARK_DiemRenLuyen_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_diem_rl", obj.ID_diem_rl)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(4) = New OracleParameter(":ID_loai_rl", obj.ID_loai_rl)
                    If UDB.SelectTableSP("MARK_DiemRenLuyen_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CheckExist_DiemRenLuyen_NewExcel(ByVal obj As DiemRenLuyen_New) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(2) = New SqlParameter("@Ma_sv", obj.Ma_sv)
                    para(3) = New SqlParameter("@ID_loai_rl", obj.ID_loai_rl)
                    If UDB.SelectTableSP("MARK_DiemRenLuyenExcel_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(2) = New OracleParameter(":Ma_sv", obj.Ma_sv)
                    para(3) = New OracleParameter(":ID_loai_rl", obj.ID_loai_rl)
                    If UDB.SelectTableSP("MARK_DiemRenLuyenExcel_CheckExist", para).Rows.Count > 0 Then
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


