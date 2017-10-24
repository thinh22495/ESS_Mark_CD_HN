Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DanhMucMon_DAL
#Region "Constructor"
        Public Sub New()
        End Sub
#End Region
#Region "Function"
        Public Function MonHoc_Load_List() As DataTable
            Try
                Return UDB.SelectTableSP("[MARK_DMMonHoc_Load_List]")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Public Function Update_DMMon(ByVal phong As DanhMucMon) As Integer
        '    Try
        '        Dim obj As DanhMucMon_DAL = New DanhMucMon_DAL
        '        Return obj.Update_DMMon(phong)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        Public Function Update_DMMon(ByVal obj As DanhMucMon, ByVal mId_mon As Integer) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Id_mon", obj.ID_mon)
                para(1) = New SqlParameter("@ID_he_dt", obj.ID_he_dt)
                para(2) = New SqlParameter("@Id_bm", obj.Id_bm)
                para(3) = New SqlParameter("@Ky_hieu", obj.Ky_hieu)
                para(4) = New SqlParameter("@Ten_mon", obj.Ten_mon)
                para(5) = New SqlParameter("@Ten_tieng_anh", obj.Ten_tieng_anh)
                Return UDB.ExecuteSP("MARK_DMMon_Update", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DMMon(ByVal obj As DanhMucMon) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_he_dt", obj.ID_he_dt)
                para(1) = New SqlParameter("@Id_bm", obj.Id_bm)
                para(2) = New SqlParameter("@Ky_hieu", obj.Ky_hieu)
                para(3) = New SqlParameter("@Ten_mon", obj.Ten_mon)
                para(4) = New SqlParameter("@Ten_tieng_anh", obj.Ten_tieng_anh)
                Return UDB.ExecuteSP("MARK_DMMon_Insert", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DMMon_DEL(ByVal mId_mon As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Id_mon", mId_mon)
                Return UDB.SelectTableSP("MARK_DMMon_Del", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Check_Exist_MonHoc(ByVal Ky_hieu As String, ByVal Ten_mon As String) As Boolean
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ky_hieu", Ky_hieu)
                para(1) = New SqlParameter("@Ten_mon", Ten_mon)
                If UDB.SelectTableSP("Mark_Check_Exist_MonHoc", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
