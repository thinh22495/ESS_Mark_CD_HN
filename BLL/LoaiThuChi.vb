'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Friday, August 29, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class LoaiThuChi_BLL        
        Private arrLoaiThuChi As New ArrayList
#Region "Constructor"
        Public Sub New()
            Try
                Dim obj As LoaiThuChi_DAL = New LoaiThuChi_DAL
                Dim dt As DataTable = obj.Load_LoaiThuChi_List()
                Dim objLoaiThuChi As LoaiThuChi = Nothing
                If dt.Rows.Count > 0 Then objLoaiThuChi = New LoaiThuChi
                For Each r As DataRow In dt.Rows
                    objLoaiThuChi = Converting(r)
                    arrLoaiThuChi.Add(objLoaiThuChi)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function Load_LoaiThuChi() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_thu_chi")
                dt.Columns.Add("Ten_thu_chi")
                dt.Columns.Add("Thu_chi")
                dt.Columns.Add("So_tien", GetType(Integer))
                dt.Columns.Add("Thu_bat_buoc")
                dt.Columns.Add("Theo_nien_khoa")
                dt.Columns.Add("Hoc_phi")
                dt.Columns.Add("ID_he")
                Dim dr As DataRow
                Dim obj As New LoaiThuChi
                For i As Integer = 0 To arrLoaiThuChi.Count - 1
                    obj = CType(arrLoaiThuChi(i), LoaiThuChi)
                    dr = dt.NewRow
                    dr("ID_thu_chi") = obj.ID_thu_chi
                    dr("Ten_thu_chi") = obj.Ten_thu_chi
                    dr("Thu_chi") = obj.Thu_chi
                    dr("So_tien") = obj.So_tien
                    dr("Thu_bat_buoc") = obj.Thu_bat_buoc
                    dr("Theo_nien_khoa") = obj.Theo_nien_khoa
                    dr("Hoc_phi") = obj.Hoc_phi
                    dr("ID_he") = obj.ID_he
                    dt.Rows.Add(dr)
                Next
                dt.DefaultView.AllowDelete = False
                dt.DefaultView.AllowEdit = False
                dt.DefaultView.AllowNew = False
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub Insert_Object(ByVal objLoaiThuChi As LoaiThuChi)
            Try
                arrLoaiThuChi.Add(objLoaiThuChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function Insert_LoaiThuChi(ByVal objLoaiThuChi As LoaiThuChi) As Integer
            Try
                Dim obj As LoaiThuChi_DAL = New LoaiThuChi_DAL
                Return obj.Insert_LoaiThuChi(objLoaiThuChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub Update_Object(ByVal objLoaiThuChi As LoaiThuChi, ByVal idx As Integer)
            Try
                arrLoaiThuChi(idx) = objLoaiThuChi
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function Update_LoaiThuChi(ByVal objLoaiThuChi As LoaiThuChi) As Integer
            Try
                Dim obj As LoaiThuChi_DAL = New LoaiThuChi_DAL
                Return obj.Update_LoaiThuChi(objLoaiThuChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_LoaiThuChi(ByVal ID_thu_chi As Integer) As Integer
            Try
                Dim obj As LoaiThuChi_DAL = New LoaiThuChi_DAL
                Return obj.Delete_LoaiThuChi(ID_thu_chi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_Object(ByVal Idx As Integer) As Integer
            Try
                arrLoaiThuChi.RemoveAt(Idx)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_LoaiThuChi(ByVal Ten_thu_chi As String) As Boolean
            Try
                Dim obj As LoaiThuChi_DAL = New LoaiThuChi_DAL
                Return obj.CheckExist_LoaiThuChi(Ten_thu_chi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drLoaiThuChi As DataRow) As LoaiThuChi
            Dim result As LoaiThuChi
            Try
                result = New LoaiThuChi
                If drLoaiThuChi("ID_thu_chi").ToString() <> "" Then result.ID_thu_chi = CType(drLoaiThuChi("ID_thu_chi").ToString(), Integer)
                result.Ten_thu_chi = drLoaiThuChi("Ten_thu_chi").ToString()
                result.Thu_chi = drLoaiThuChi("Thu_chi").ToString()
                result.So_tien = drLoaiThuChi("So_tien").ToString()
                result.Thu_bat_buoc = drLoaiThuChi("Thu_bat_buoc").ToString()
                result.Theo_nien_khoa = drLoaiThuChi("Theo_nien_khoa").ToString()
                result.Hoc_phi = drLoaiThuChi("Hoc_phi").ToString()
                result.ID_he = IIf(drLoaiThuChi("ID_he").ToString() = "", 0, drLoaiThuChi("ID_he"))
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
