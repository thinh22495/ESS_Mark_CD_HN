'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Friday, August 01, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class QuyHocBongPhanBo_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_QuyHocBongPhanBo_List(ByVal ID_hb As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_hb", ID_hb)                    
                    Return UDB.SelectTableSP("STU_QuyHocBongPhanBo_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_hb", ID_hb)
                    Return UDB.SelectTableSP("STU_QuyHocBongPhanBo_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_QuyHocBongPhanBoLop_List(ByVal ID_hb As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_hb", ID_hb)
                    Return UDB.SelectTableSP("STU_QuyHocBongPhanBoLop_Load_List", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_hb", ID_hb)
                    Return UDB.SelectTableSP("STU_QuyHocBongPhanBoLop_Load_List", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_QuyHocBongPhanBoLop_List(ByVal ID_phan_bo As Integer, ByVal ID_lop As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                    para(1) = New SqlParameter("@ID_lop", ID_lop)
                    Return UDB.SelectTableSP("STU_QuyHocBongPhanBoLop_CheckExits", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_phan_bo", ID_phan_bo)
                    para(0) = New OracleParameter(":ID_lop", ID_lop)
                    Return UDB.SelectTableSP("STU_QuyHocBongPhanBoLop_CheckExits", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_QuyHocBongPhanBoLop(ByVal ID_phan_bo As Integer, ByVal ID_lop As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                    para(1) = New SqlParameter("@ID_lop", ID_lop)
                    Return UDB.ExecuteSP("STU_QuyHocBongPhanBoLop_Insert", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_phan_bo", ID_phan_bo)
                    para(1) = New OracleParameter(":ID_lop", ID_lop)
                    Return UDB.ExecuteSP("STU_QuyHocBongPhanBoLop_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_QuyHocBongPhanBo(ByVal obj As QuyHocBongPhanBo) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(4) As SqlParameter
                    para(0) = New SqlParameter("@Ten_phan_bo", obj.Ten_phan_bo)
                    para(1) = New SqlParameter("@ID_hb", obj.ID_hb)
                    para(2) = New SqlParameter("@So_sv", obj.So_sv)
                    para(3) = New SqlParameter("@So_tien", obj.So_tien)
                    para(4) = New SqlParameter("@Phan_dac_biet", obj.Phan_dac_biet)
                    Return UDB.ExecuteSP("STU_QuyHocBongPhanBo_Insert", para)
                Else
                    Dim para(4) As OracleParameter
                    para(0) = New OracleParameter(":Ten_phan_bo", obj.Ten_phan_bo)
                    para(1) = New OracleParameter(":ID_hb", obj.ID_hb)
                    para(2) = New OracleParameter(":So_sv", obj.So_sv)
                    para(3) = New OracleParameter(":So_tien", obj.So_tien)
                    para(4) = New OracleParameter(":Phan_dac_biet", obj.Phan_dac_biet)
                    Return UDB.ExecuteSP("STU_QuyHocBongPhanBo_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_QuyHocBongPhanBo(ByVal obj As QuyHocBongPhanBo, ByVal ID_phan_bo As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(5) As SqlParameter
                    para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                    para(1) = New SqlParameter("@Ten_phan_bo", obj.Ten_phan_bo)
                    para(2) = New SqlParameter("@ID_hb", obj.ID_hb)
                    para(3) = New SqlParameter("@So_sv", obj.So_sv)
                    para(4) = New SqlParameter("@So_tien", obj.So_tien)
                    para(5) = New SqlParameter("@Phan_dac_biet", obj.Phan_dac_biet)
                    Return UDB.ExecuteSP("STU_QuyHocBongPhanBo_Update", para)
                Else
                    Dim para(5) As OracleParameter
                    para(0) = New OracleParameter(":ID_phan_bo", ID_phan_bo)
                    para(1) = New OracleParameter(":Ten_phan_bo", obj.Ten_phan_bo)
                    para(2) = New OracleParameter(":ID_hb", obj.ID_hb)
                    para(3) = New OracleParameter(":So_sv", obj.So_sv)
                    para(4) = New OracleParameter(":So_tien", obj.So_tien)
                    para(5) = New OracleParameter(":Phan_dac_biet", obj.Phan_dac_biet)
                    Return UDB.ExecuteSP("STU_QuyHocBongPhanBo_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_QuyHocBongPhanBoLop(ByVal ID_phan_bo As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                    Return UDB.ExecuteSP("STU_QuyHocBongPhanBoLop_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_phan_bo", ID_phan_bo)
                    Return UDB.ExecuteSP("STU_QuyHocBongPhanBoLop_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_QuyHocBongPhanBo(ByVal ID_phan_bo As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                    Return UDB.ExecuteSP("STU_QuyHocBongPhanBo_Delete", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_phan_bo", ID_phan_bo)
                    Return UDB.ExecuteSP("STU_QuyHocBongPhanBo_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


