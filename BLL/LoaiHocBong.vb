'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Wednesday, August 06, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class LoaiHocBong_BLL
        Inherits LoaiHocBong
        Private arrLoaiHocBong As New ArrayList
        Private mdtDT_HocBong As DataTable
#Region "Constructor"
        Public Sub New()
            Try
                Dim obj As LoaiHocBong_DAL = New LoaiHocBong_DAL
                Dim dt As DataTable = obj.Load_LoaiHocBong_List()
                Dim objLHB As LoaiHocBong = Nothing
                For Each dr As DataRow In dt.Rows
                    objLHB = Converting(dr)
                    arrLoaiHocBong.Add(objLHB)
                Next
                ' Load Dối tượng học bổng
                mdtDT_HocBong = obj.Load_DoiTuongHocBong()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        ' Loại học bổng
        Public Function Load_LoaiHocBong(ByVal Ma_dt As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Ma_dt")
                dt.Columns.Add("ID_he")
                dt.Columns.Add("Ten_he")
                dt.Columns.Add("ID_xep_loai_hb")
                dt.Columns.Add("Ten_xep_loai")
                dt.Columns.Add("HB_HT")
                Dim dr As DataRow
                Dim obj As New LoaiHocBong
                For i As Integer = 0 To arrLoaiHocBong.Count - 1
                    obj = CType(arrLoaiHocBong(i), LoaiHocBong)
                    If obj.Ma_dt = Ma_dt Then
                        dr = dt.NewRow
                        dr("Ma_dt") = obj.Ma_dt
                        dr("ID_he") = obj.ID_he
                        dr("Ten_he") = obj.Ten_he
                        dr("ID_xep_loai_hb") = obj.ID_xep_loai_hb
                        dr("Ten_xep_loai") = obj.Ten_xep_loai
                        dr("HB_HT") = Format(obj.HB_HT, "###,##0")
                        dt.Rows.Add(dr)
                    End If
                Next                
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Loại học bổng
        Public Function Load_LoaiHocBong() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Ma_dt")
                dt.Columns.Add("ID_he")
                dt.Columns.Add("Ten_he")
                dt.Columns.Add("ID_xep_loai_hb")
                dt.Columns.Add("Ten_xep_loai")
                dt.Columns.Add("HB_HT")
                Dim dr As DataRow
                Dim obj As New LoaiHocBong
                For i As Integer = 0 To arrLoaiHocBong.Count - 1
                    obj = CType(arrLoaiHocBong(i), LoaiHocBong)                    
                    dr = dt.NewRow
                    dr("Ma_dt") = obj.Ma_dt
                    dr("ID_he") = obj.ID_he
                    dr("Ten_he") = obj.Ten_he
                    dr("ID_xep_loai_hb") = obj.ID_xep_loai_hb
                    dr("Ten_xep_loai") = obj.Ten_xep_loai
                    dr("HB_HT") = Format(obj.HB_HT, "###,##0")
                    dt.Rows.Add(dr)                    
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load đối tượng học bổng
        Public Function Load_DoiTuongHocBong() As DataTable
            Try
                mdtDT_HocBong.DefaultView.AllowDelete = False
                mdtDT_HocBong.DefaultView.AllowEdit = False
                mdtDT_HocBong.DefaultView.AllowNew = False
                Return mdtDT_HocBong
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_LoaiHocBong(ByVal objLoaiHocBong As LoaiHocBong) As Integer
            Try
                Dim obj As LoaiHocBong_DAL = New LoaiHocBong_DAL
                Return obj.Insert_LoaiHocBong(objLoaiHocBong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_LoaiHocBong(ByVal objLoaiHocBong As LoaiHocBong) As Integer
            Try
                Dim obj As LoaiHocBong_DAL = New LoaiHocBong_DAL
                Return obj.Update_LoaiHocBong(objLoaiHocBong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_LoaiHocBong(ByVal Ma_dt As String, ByVal ID_he As Integer, ByVal ID_xep_loai_hb As Integer) As Integer
            Try
                Dim obj As LoaiHocBong_DAL = New LoaiHocBong_DAL
                Return obj.Delete_LoaiHocBong(Ma_dt, ID_he, ID_xep_loai_hb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_LoaiHocBong(ByVal Ma_dt As String, ByVal ID_he As Integer, ByVal ID_xep_loai_hb As Integer) As Boolean
            Try
                Dim obj As LoaiHocBong_DAL = New LoaiHocBong_DAL
                Return obj.CheckExist_LoaiHocBong(Ma_dt, ID_he, ID_xep_loai_hb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drLoaiHocBong As DataRow) As LoaiHocBong
            Dim result As LoaiHocBong
            Try
                result = New LoaiHocBong
                result.Ma_dt = drLoaiHocBong("Ma_dt").ToString()
                result.ID_he = drLoaiHocBong("ID_he").ToString()
                result.Ten_he = drLoaiHocBong("Ten_he").ToString()
                result.ID_xep_loai_hb = drLoaiHocBong("ID_xep_loai_hb").ToString()
                result.Ten_xep_loai = drLoaiHocBong("Ten_xep_loai").ToString()                
                If drLoaiHocBong("HB_HT").ToString() <> "" Then result.HB_HT = CType(drLoaiHocBong("HB_HT").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
