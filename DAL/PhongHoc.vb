'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/25/2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class PhongHoc_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_PhongHoc_List() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_PhongHoc_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_PhongHoc_List_User(ByVal UserID As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@UserID", UserID)
                    Return UDB.SelectTableSP("PhongHoc_Load_List_User", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":UserID", UserID)
                    Return UDB.SelectTableSP("PhongHoc_Load_List_User", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_PhongHoc(ByVal obj As PhongHoc) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_co_so", obj.ID_co_so)
                    para(1) = New SqlParameter("@ID_nha", obj.ID_nha)
                    para(2) = New SqlParameter("@ID_tang", obj.ID_tang)
                    para(3) = New SqlParameter("@So_phong", obj.So_phong)
                    para(4) = New SqlParameter("@Suc_chua", obj.Suc_chua)
                    para(5) = New SqlParameter("@So_sv", obj.So_sv)
                    para(6) = New SqlParameter("@ID_loai_phong", obj.ID_loai_phong)
                    para(7) = New SqlParameter("@Thiet_bi", obj.Thiet_bi)
                    Return UDB.ExecuteSP("PLAN_PhongHoc_Insert", para)
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":ID_co_so", obj.ID_co_so)
                    para(1) = New OracleParameter(":ID_nha", obj.ID_nha)
                    para(2) = New OracleParameter(":ID_tang", obj.ID_tang)
                    para(3) = New OracleParameter(":So_phong", obj.So_phong)
                    para(4) = New OracleParameter(":Suc_chua", obj.Suc_chua)
                    para(5) = New OracleParameter(":So_sv", obj.So_sv)
                    para(6) = New OracleParameter(":ID_loai_phong", obj.ID_loai_phong)
                    para(7) = New OracleParameter(":Thiet_bi", obj.Thiet_bi)
                    Return UDB.ExecuteSP("PLAN_PhongHoc_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_PhongHoc(ByVal obj As PhongHoc, ByVal ID_phong As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(8) As SqlParameter
                    para(0) = New SqlParameter("@ID_co_so", obj.ID_co_so)
                    para(1) = New SqlParameter("@ID_phong", ID_phong)
                    para(2) = New SqlParameter("@ID_nha", obj.ID_nha)
                    para(3) = New SqlParameter("@ID_tang", obj.ID_tang)
                    para(4) = New SqlParameter("@So_phong", obj.So_phong)
                    para(5) = New SqlParameter("@Suc_chua", obj.Suc_chua)
                    para(6) = New SqlParameter("@So_sv", obj.So_sv)
                    para(7) = New SqlParameter("@ID_loai_phong", obj.ID_loai_phong)
                    para(8) = New SqlParameter("@Thiet_bi", obj.Thiet_bi)
                    Return UDB.ExecuteSP("PLAN_PhongHoc_Update", para)
                Else
                    Dim para(8) As OracleParameter
                    para(0) = New OracleParameter(":ID_co_so", obj.ID_co_so)
                    para(1) = New OracleParameter(":ID_phong", ID_phong)
                    para(2) = New OracleParameter(":ID_nha", obj.ID_nha)
                    para(3) = New OracleParameter(":ID_tang", obj.ID_tang)
                    para(4) = New OracleParameter(":So_phong", obj.So_phong)
                    para(5) = New OracleParameter(":Suc_chua", obj.Suc_chua)
                    para(6) = New OracleParameter(":So_sv", obj.So_sv)
                    para(7) = New OracleParameter(":ID_loai_phong", obj.ID_loai_phong)
                    para(8) = New OracleParameter(":Thiet_bi", obj.Thiet_bi)
                    Return UDB.ExecuteSP("PLAN_PhongHoc_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_PhongHoc(ByVal ID_phong As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_phong", ID_phong)
                    Return UDB.ExecuteSP("PLAN_PhongHoc_Delete", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_phong", ID_phong)
                    Return UDB.ExecuteSP("PLAN_PhongHoc_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_TenPhongHoc(ByVal ID_co_so As Integer, ByVal ID_nha As Integer, ByVal ID_tang As Integer, ByVal So_phong As String) As Boolean
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_co_so", ID_co_so)
                    para(1) = New SqlParameter("@ID_nha", ID_nha)
                    para(2) = New SqlParameter("@ID_tang", ID_tang)
                    para(3) = New SqlParameter("@So_phong", So_phong)
                    dt = UDB.SelectTableSP("PLAN_PhongHoc_CheckExist_Ten", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_co_so", ID_co_so)
                    para(1) = New OracleParameter(":ID_nha", ID_nha)
                    para(2) = New OracleParameter(":ID_tang", ID_tang)
                    para(3) = New OracleParameter(":So_phong", So_phong)
                    dt = UDB.SelectTableSP("PLAN_PhongHoc_CheckExist_Ten", para)
                End If
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


