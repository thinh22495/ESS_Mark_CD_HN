'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Saturday, May 03, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DanhSach_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region
#Region "Function Bồi hoàn kinh phí"
        Public Function Load_DanhSach_BoiHoan(ByVal ID_lop As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", ID_lop)
                Return UDB.SelectTableSP("STU_DanhSachBoiHoan_Load", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DanhSach_BoiHoan(ByVal obj As DanhSach) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@So_tien_hoan_tra", obj.So_tien_hoan_tra)
                    para(4) = New SqlParameter("@So_nam_dao_tao", obj.So_nam_dao_tao)
                    Return UDB.ExecuteSP("STU_DanhSachBoiHoan_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":So_tien_hoan_tra", obj.So_tien_hoan_tra)
                    para(4) = New OracleParameter(":So_nam_dao_tao", obj.So_nam_dao_tao)
                    Return UDB.ExecuteSP("STU_DanhSachBoiHoan_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSach_BoiHoan(ByVal obj As DanhSach) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@So_tien_hoan_tra", obj.So_tien_hoan_tra)
                    para(4) = New SqlParameter("@So_nam_dao_tao", obj.So_nam_dao_tao)
                    Return UDB.ExecuteSP("STU_DanhSachBoiHoan_Update", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":So_tien_hoan_tra", obj.So_tien_hoan_tra)
                    para(4) = New OracleParameter(":So_nam_dao_tao", obj.So_nam_dao_tao)
                    Return UDB.ExecuteSP("STU_DanhSachBoiHoan_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSach_BoiHoan(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.ExecuteSP("STU_DanhSachBoiHoan_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.ExecuteSP("STU_DanhSachBoiHoan_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExits_DanhSach_BoiHoan(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    If UDB.SelectTableSP("STU_DanhSachBoiHoan_CheckExits", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    If UDB.SelectTableSP("STU_DanhSachBoiHoan_CheckExits", para).Rows.Count > 0 Then
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
#Region "Function HocBu"
        Public Function Load_DanhSach_HocBu(ByVal ID_lop As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", ID_lop)
                Return UDB.SelectTableSP("STU_DanhSachHocBu_Load", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DanhSach_HocBu(ByVal obj As DanhSach) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@So_tien_hoc_bu", obj.So_tien_hoc_bu)
                    para(4) = New SqlParameter("@So_tiet_hoc_bu", obj.So_tiet_hoc_bu)
                    Return UDB.ExecuteSP("STU_DanhSachHocBu_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":So_tien_hoc_bu", obj.So_tien_hoc_bu)
                    para(4) = New OracleParameter(":So_tiet_hoc_bu", obj.So_tiet_hoc_bu)
                    Return UDB.ExecuteSP("STU_DanhSachHocBu_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSach_HocBu(ByVal obj As DanhSach) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@So_tien_hoc_bu", obj.So_tien_hoc_bu)
                    para(4) = New SqlParameter("@So_tiet_hoc_bu", obj.So_tiet_hoc_bu)
                    Return UDB.ExecuteSP("STU_DanhSachHocBu_Update", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":So_tien_hoc_bu", obj.So_tien_hoc_bu)
                    para(4) = New OracleParameter(":So_tiet_hoc_bu", obj.So_tiet_hoc_bu)
                    Return UDB.ExecuteSP("STU_DanhSachHocBu_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSach_HocBu(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    Return UDB.ExecuteSP("STU_DanhSachHocBu_Delete", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    Return UDB.ExecuteSP("STU_DanhSachHocBu_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExits_DanhSach_HocBu(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    If UDB.SelectTableSP("STU_DanhSachHocBu_CheckExits", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    If UDB.SelectTableSP("STU_DanhSachHocBu_CheckExits", para).Rows.Count > 0 Then
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
#Region "Function"
        Public Function Load_DanhSach(ByVal ID_lop As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", ID_lop)
                Return UDB.SelectTableSP("STU_DanhSach_Load", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSach_List() As DataTable
            Try
                Return UDB.SelectTableSP("DanhSach_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DanhSach(ByVal obj As DanhSach) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop", obj.ID_lop)
                    para(1) = New SqlParameter("@Mat_khau", obj.Mat_khau)
                    para(2) = New SqlParameter("@Active", SqlDbType.Bit)
                    para(2).Value = obj.Active
                    para(3) = New SqlParameter("@Da_tot_nghiep", SqlDbType.Bit)
                    para(3).Value = obj.Da_tot_nghiep
                    para(4) = New SqlParameter("@ID_sv", obj.ID_sv)
                    Return UDB.ExecuteSP("STU_DanhSach_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop", obj.ID_lop)
                    para(1) = New OracleParameter(":Mat_khau", obj.Mat_khau)
                    para(2) = New OracleParameter(":Active", obj.Active)
                    para(3) = New OracleParameter(":Da_tot_nghiep", obj.Da_tot_nghiep)
                    para(4) = New OracleParameter(":ID_sv", obj.ID_sv)
                    Return UDB.ExecuteSP("STU_DanhSach_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSach(ByVal obj As DanhSach, ByVal ID_svs As String, ByVal ID_lop As Integer) As Integer
            Try
                Dim ID_dt As Integer = getID_dt_ID_SVs(ID_lop)
                'If ID_dt <= 0 Then Return 0
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_svs", ID_svs)
                    para(1) = New SqlParameter("@ID_lop", ID_lop)
                    para(2) = New SqlParameter("@ID_dt", ID_dt)
                    Return UDB.ExecuteSP("STU_DanhSach_ChuyenLop_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_svs", ID_svs)
                    para(1) = New OracleParameter(":ID_lop", ID_lop)
                    para(2) = New OracleParameter(":ID_dt", ID_dt)
                    Return UDB.ExecuteSP("STU_DanhSach_ChuyenLop_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSach_NhapHoc(ByVal obj As DanhSach, ByVal ID_svs As String, ByVal ID_lop As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_svs", ID_svs)
                    para(1) = New SqlParameter("@ID_lop", ID_lop)
                    para(2) = New SqlParameter("@ID_dt", 0)
                    Return UDB.ExecuteSP("STU_DanhSach_ChuyenLop_Update", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_svs", ID_svs)
                    para(1) = New OracleParameter(":ID_lop", ID_lop)
                    para(2) = New OracleParameter(":ID_dt", 0)
                    Return UDB.ExecuteSP("STU_DanhSach_ChuyenLop_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function getID_dt_ID_SVs(ByVal ID_lop As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop", ID_lop)
                    Return UDB.ExecuteSP("STU_GetID_dts", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop", ID_lop)
                    Return UDB.ExecuteSP("STU_GetID_dts", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSach(ByVal ID_sv As Integer, ByVal ID_lop As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    para(1) = New SqlParameter("@ID_lop", ID_lop)
                    Return UDB.ExecuteSP("STU_DanhSach_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    para(1) = New OracleParameter(":ID_lop", ID_lop)
                    Return UDB.ExecuteSP("STU_DanhSach_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSach_SinhVien(ByVal ID_lop As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lop", ID_lop)
                    Return UDB.ExecuteSP("STU_DanhSach_SinhVien_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_lop", ID_lop)
                    Return UDB.ExecuteSP("STU_DanhSach_SinhVien_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


