'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Tuesday, June 10, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class GiangVienMonDay_BLL
        Inherits GiangVienMonDay

#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        Public Function Insert_GiangVienMonDay(ByVal objGiangVienMonDay As GiangVienMonDay) As Integer
            Try
                Dim obj As GiangVienMonDay_DAL = New GiangVienMonDay_DAL
                Return obj.Insert_GiangVienMonDay(objGiangVienMonDay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_GiangVienMonDay(ByVal ID_cb As Integer, ByVal ID_mon As Integer, ByVal ID_bm As Integer) As Integer
            Try
                Dim obj As GiangVienMonDay_DAL = New GiangVienMonDay_DAL
                Return obj.Delete_GiangVienMonDay(ID_cb, ID_mon, ID_bm)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_GiangVienMonDay(ByVal ID_cb As Integer, ByVal ID_mon As Integer, ByVal ID_bm As Integer) As Boolean
            Try
                Dim obj As GiangVienMonDay_DAL = New GiangVienMonDay_DAL
                Return obj.CheckExist_GiangVienMonDay(ID_cb, ID_mon, ID_bm)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drGiangVienMonDay As DataRow) As GiangVienMonDay
            Dim result As GiangVienMonDay
            Try
                result = New GiangVienMonDay
                If drGiangVienMonDay("ID_cb").ToString() <> "" Then result.ID_cb = CType(drGiangVienMonDay("ID_cb").ToString(), Integer)
                If drGiangVienMonDay("ID_mon").ToString() <> "" Then result.ID_mon = CType(drGiangVienMonDay("ID_mon").ToString(), Integer)
                If drGiangVienMonDay("ID_bm").ToString() <> "" Then result.ID_bm = CType(drGiangVienMonDay("ID_bm").ToString(), Integer)
                result.Ky_hieu = drGiangVienMonDay("Ky_hieu").ToString()
                result.Ten_mon = drGiangVienMonDay("Ten_mon").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
