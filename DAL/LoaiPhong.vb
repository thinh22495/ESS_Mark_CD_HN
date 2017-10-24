'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Monday, June 30, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class LoaiPhong_DAL

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Load_LoaiPhong_List() As DataTable
            Try
                Return UDB.SelectTableSP("PLAN_LoaiPhong_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_LoaiPhong(ByVal obj As LoaiPhong) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Ma_loai", obj.Ma_loai)
                    para(1) = New SqlParameter("@Ten_loai_phong", obj.Ten_loai_phong)
                    para(2) = New SqlParameter("@Thuc_hanh", obj.Thuc_hanh)
                    Return UDB.ExecuteSP("PLAN_LoaiPhong_Insert", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Ma_loai", obj.Ma_loai)
                    para(1) = New OracleParameter(":Ten_loai_phong", obj.Ten_loai_phong)
                    para(2) = New OracleParameter(":Thuc_hanh", obj.Thuc_hanh)
                    Return UDB.ExecuteSP("PLAN_LoaiPhong_Insert", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_LoaiPhong(ByVal obj As LoaiPhong, ByVal ID_loai_phong As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_loai_phong", ID_loai_phong)
                    para(1) = New SqlParameter("@Ma_loai", obj.Ma_loai)
                    para(2) = New SqlParameter("@Ten_loai_phong", obj.Ten_loai_phong)
                    para(3) = New SqlParameter("@Thuc_hanh", obj.Thuc_hanh)
                    Return UDB.ExecuteSP("PLAN_LoaiPhong_Update", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_loai_phong", ID_loai_phong)
                    para(1) = New OracleParameter(":Ma_loai", obj.Ma_loai)
                    para(2) = New OracleParameter(":Ten_loai_phong", obj.Ten_loai_phong)
                    para(3) = New OracleParameter(":Thuc_hanh", obj.Thuc_hanh)
                    Return UDB.ExecuteSP("PLAN_LoaiPhong_Update", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_LoaiPhong(ByVal ID_loai_phong As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_loai_phong", ID_loai_phong)
                    Return UDB.ExecuteSP("PLAN_LoaiPhong_Delete", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_loai_phong", ID_loai_phong)
                    Return UDB.ExecuteSP("PLAN_LoaiPhong_Delete", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_LoaiPhong(ByVal ID_loai_phong As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_loai_phong", ID_loai_phong)
                    Return UDB.ExecuteScalar("PLAN_LoaiPhong_CheckExist", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_loai_phong", ID_loai_phong)
                    Return UDB.ExecuteScalar("PLAN_LoaiPhong_CheckExist", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace


