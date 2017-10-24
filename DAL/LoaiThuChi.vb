'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Friday, August 29, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class LoaiThuChi_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_LoaiThuChi_List() As DataTable
            Try
                Return UDB.SelectTableSP("ACC_LoaiThuChi_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_LoaiThuChi(ByVal obj As LoaiThuChi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@Ten_thu_chi", obj.Ten_thu_chi)
                    para(1) = New SqlParameter("@Thu_chi", obj.Thu_chi)
                    para(2) = New SqlParameter("@So_tien", obj.So_tien)
                    para(3) = New SqlParameter("@Thu_bat_buoc", obj.Thu_bat_buoc)
                    para(4) = New SqlParameter("@Theo_nien_khoa", obj.Theo_nien_khoa)
                    para(5) = New SqlParameter("@Hoc_phi", obj.Hoc_phi)
                    para(6) = New SqlParameter("@ID_he", obj.ID_he)
                    Return UDB.ExecuteSP("ACC_LoaiThuChi_Insert", para)
                Else
                    Dim para(6) As OracleParameter
                    para(0) = New OracleParameter(":Ten_thu_chi", obj.Ten_thu_chi)
                    para(1) = New OracleParameter(":Thu_chi", obj.Thu_chi)
                    para(2) = New OracleParameter(":So_tien", obj.So_tien)
                    para(3) = New OracleParameter(":Thu_bat_buoc", obj.Thu_bat_buoc)
                    para(4) = New OracleParameter(":Theo_nien_khoa", obj.Theo_nien_khoa)
                    para(5) = New OracleParameter(":Hoc_phi", obj.Hoc_phi)
                    para(6) = New OracleParameter(":ID_he", obj.ID_he)
                    Return UDB.ExecuteSP("ACC_LoaiThuChi_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_LoaiThuChi(ByVal obj As LoaiThuChi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_thu_chi", obj.ID_thu_chi)
                    para(1) = New SqlParameter("@Ten_thu_chi", obj.Ten_thu_chi)
                    para(2) = New SqlParameter("@Thu_chi", obj.Thu_chi)
                    para(3) = New SqlParameter("@So_tien", obj.So_tien)
                    para(4) = New SqlParameter("@Thu_bat_buoc", obj.Thu_bat_buoc)
                    para(5) = New SqlParameter("@Theo_nien_khoa", obj.Theo_nien_khoa)
                    para(6) = New SqlParameter("@Hoc_phi", obj.Hoc_phi)
                    para(7) = New SqlParameter("@ID_he", obj.ID_he)
                    Return UDB.ExecuteSP("ACC_LoaiThuChi_Update", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":ID_thu_chi", obj.ID_thu_chi)
                    para(1) = New OracleParameter(":Ten_thu_chi", obj.Ten_thu_chi)
                    para(2) = New OracleParameter(":Thu_chi", obj.Thu_chi)
                    para(3) = New OracleParameter(":So_tien", obj.So_tien)
                    para(4) = New OracleParameter(":Thu_bat_buoc", obj.Thu_bat_buoc)
                    para(5) = New OracleParameter(":Theo_nien_khoa", obj.Theo_nien_khoa)
                    para(6) = New OracleParameter(":Hoc_phi", obj.Hoc_phi)
                    para(7) = New OracleParameter(":ID_he", obj.ID_he)
                    Return UDB.ExecuteSP("ACC_LoaiThuChi_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_LoaiThuChi(ByVal ID_thu_chi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_thu_chi", ID_thu_chi)
                    Return UDB.ExecuteSP("ACC_LoaiThuChi_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_thu_chi", ID_thu_chi)
                    Return UDB.ExecuteSP("ACC_LoaiThuChi_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_LoaiThuChi(ByVal Ten_thu_chi As String) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@Ten_thu_chi", Ten_thu_chi)
                    If UDB.SelectTableSP("ACC_LoaiThuChi_CheckExist", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":Ten_thu_chi", Ten_thu_chi)
                    If UDB.SelectTableSP("ACC_LoaiThuChi_CheckExist", para).Rows.Count > 0 Then
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


