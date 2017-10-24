Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DanhSachLuanVanThiNoTotNghiep_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_DanhSachLuanVan_List(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DanhSachLuanVan_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DanhSachLuanVan_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSachThiTotNghiep_List(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DanhSachThiTotNghiep_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DanhSachThiTotNghiep_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSachNoTotNghiep_List(ByVal ID_lops As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DanhSachNoTotNghiep_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lops", ID_lops)
                    Return UDB.SelectTableSP("STU_DanhSachNoTotNghiep_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_DanhSachLuanVan(ByVal obj As DanhSachLuanVanThiNoTotNghiep) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@TBCHT", obj.TBCHT)
                para(2) = New SqlParameter("@Lan_xet", obj.Lan_xet)
                para(3) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                Return UDB.ExecuteSP("STU_DanhSachLuanVan_Insert", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_DanhSachLuanVan(ByVal ID_sv As Integer, ByVal Lan_xet As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Lan_xet", Lan_xet)
                Return UDB.ExecuteSP("STU_DanhSachLuanVan_Delete", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_DanhSachThiTotNghiep(ByVal obj As DanhSachLuanVanThiNoTotNghiep) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@TBCHT", obj.TBCHT)
                para(2) = New SqlParameter("@Lan_xet", obj.Lan_xet)
                para(3) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                Return UDB.ExecuteSP("STU_DanhSachThiTotNghiep_Insert", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSachThiTotNghiep(ByVal ID_sv As Integer, ByVal Lan_xet As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Lan_xet", Lan_xet)
                Return UDB.ExecuteSP("STU_DanhSachThiTotNghiep_Delete", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_DanhSachNoTotNghiep(ByVal obj As DanhSachLuanVanThiNoTotNghiep) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@TBCHT", obj.TBCHT)
                    para(2) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                    para(3) = New SqlParameter("@Ly_do", obj.Ly_do)
                    para(4) = New SqlParameter("@So_mon_no", obj.So_mon_no)
                    Return UDB.ExecuteSP("STU_DanhSachNoTotNghiep_Insert", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":TBCHT", obj.TBCHT)
                    para(2) = New OracleParameter(":ID_xep_loai", obj.ID_xep_loai)
                    para(3) = New OracleParameter(":Ly_do", obj.Ly_do)
                    Return UDB.ExecuteSP("STU_DanhSachNoTotNghiep_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSachNoTotNghiep(ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_DanhSachNoTotNghiep_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return UDB.ExecuteSP("STU_DanhSachNoTotNghiep_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

