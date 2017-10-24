'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Thursday, July 31, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class QuyHocBong_BLL
        Private arrQuyHocBong As New ArrayList
        Private arrLoaiQuy As New ArrayList ' Loại quỹ học bổng
#Region "Constructor"
        Public Sub New()

        End Sub
        Public Sub New(ByVal LoaiQuy_hb As Boolean)
            Try
                Dim obj_DAL As New QuyHocBong_DAL
                Dim dt As DataTable
                dt = obj_DAL.Load_LoaiQuy_List()
                Dim obj As New LoaiQuy
                For Each dr As DataRow In dt.Rows
                    obj = Converting_LoaiQuy(dr)
                    arrLoaiQuy.Add(obj)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Try
                Dim obj_DAL As New QuyHocBong_DAL
                Dim dt As DataTable
                dt = obj_DAL.Load_QuyHocBong_List(Hoc_ky, Nam_hoc)
                Dim obj As New QuyHocBong
                For Each dr As DataRow In dt.Rows
                    obj = Converting(dr)
                    arrQuyHocBong.Add(obj)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        ' Danh sác quỹ học bổng
        Public Function DanhSach_QuyHocBong() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_hb")
                dt.Columns.Add("ID_quy")
                dt.Columns.Add("ID_he")
                dt.Columns.Add("Hoc_ky")
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("Tu_khoa")
                dt.Columns.Add("Den_khoa")
                dt.Columns.Add("Sotien_ngansach")
                dt.Columns.Add("Sotien_khac")
                dt.Columns.Add("Ghi_chu")
                dt.Columns.Add("Loai_quy")
                Dim row As DataRow
                Dim obj As New QuyHocBong
                For i As Integer = 0 To arrQuyHocBong.Count - 1
                    obj = CType(arrQuyHocBong(i), QuyHocBong)
                    row = dt.NewRow
                    row("ID_hb") = obj.ID_hb
                    row("ID_quy") = obj.ID_quy
                    row("ID_he") = obj.ID_he
                    row("Hoc_ky") = obj.Hoc_ky
                    row("Nam_hoc") = obj.Nam_hoc
                    row("Tu_khoa") = obj.Tu_khoa
                    row("Den_khoa") = obj.Den_khoa
                    row("Sotien_ngansach") = Format(obj.Sotien_ngansach, "###,##0")
                    row("Sotien_khac") = Format(obj.Sotien_khac, "###,##0")
                    row("Ghi_chu") = obj.Ghi_chu
                    row("Loai_quy") = obj.Loai_quy
                    dt.Rows.Add(row)
                Next
                dt.DefaultView.AllowDelete = True
                dt.DefaultView.AllowEdit = False
                dt.DefaultView.AllowNew = False
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Quỹ học bổng theo kỳ , năm học, hệ đào tạo,loại quỹ
        Public Function Load_QuyHocBong(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_quy As Integer) As QuyHocBong
            Try
                Dim objQHB As New QuyHocBong
                Dim obj As New QuyHocBong
                For i As Integer = 0 To arrQuyHocBong.Count - 1
                    obj = CType(arrQuyHocBong(i), QuyHocBong)
                    If obj.Hoc_ky = Hoc_ky And obj.Nam_hoc = Nam_hoc And obj.ID_he = ID_he And obj.ID_quy = ID_quy Then
                        objQHB = obj
                    End If
                Next
                Return objQHB
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Quỹ học bổng thữ idx trong mảng
        Public Function QuyHocBong_Index(ByVal idx As Integer) As QuyHocBong
            Try
                Dim obj As New QuyHocBong
                obj = CType(arrQuyHocBong(idx), QuyHocBong)
                Return obj
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub UpdateMemory_QuyHocBong(ByVal obj As QuyHocBong, ByVal idx As Integer)
            Try
                arrQuyHocBong(idx) = obj
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function Insert_QuyHocBong(ByVal objQuyHocBong As QuyHocBong) As Integer
            Try
                Dim obj As QuyHocBong_DAL = New QuyHocBong_DAL
                Return obj.Insert_QuyHocBong(objQuyHocBong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_QuyHocBong(ByVal objQuyHocBong As QuyHocBong, ByVal ID_hb As Integer) As Integer
            Try
                Dim obj As QuyHocBong_DAL = New QuyHocBong_DAL
                Return obj.Update_QuyHocBong(objQuyHocBong, ID_hb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_QuyHocBong(ByVal ID_hb As Integer) As Integer
            Try
                Dim obj As QuyHocBong_DAL = New QuyHocBong_DAL
                Return obj.Delete_QuyHocBong(ID_hb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_QuyHocBong_Memory(ByVal Idx As Integer) As Integer
            Try
                arrQuyHocBong.RemoveAt(Idx)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_QuyHocBong(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_quy As Integer) As Boolean
            Try
                Dim obj As QuyHocBong_DAL = New QuyHocBong_DAL
                Return obj.CheckExist_QuyHocBong(Hoc_ky, Nam_hoc, ID_quy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drQuyHocBong As DataRow) As QuyHocBong
            Dim result As QuyHocBong
            Try
                result = New QuyHocBong
                If drQuyHocBong("ID_hb").ToString() <> "" Then result.ID_hb = CType(drQuyHocBong("ID_hb").ToString(), Integer)
                If drQuyHocBong("ID_quy").ToString() <> "" Then result.ID_quy = CType(drQuyHocBong("ID_quy").ToString(), Integer)
                If drQuyHocBong("ID_he").ToString() <> "" Then result.ID_he = CType(drQuyHocBong("ID_he").ToString(), Integer)
                If drQuyHocBong("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drQuyHocBong("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drQuyHocBong("Nam_hoc").ToString()
                If drQuyHocBong("Tu_khoa").ToString() <> "" Then result.Tu_khoa = CType(drQuyHocBong("Tu_khoa").ToString(), Integer)
                If drQuyHocBong("Den_khoa").ToString() <> "" Then result.Den_khoa = CType(drQuyHocBong("Den_khoa").ToString(), Integer)
                result.Sotien_ngansach = drQuyHocBong("Sotien_ngansach").ToString()
                result.Sotien_khac = drQuyHocBong("Sotien_khac").ToString()
                result.Ghi_chu = drQuyHocBong("Ghi_chu").ToString()
                result.Loai_quy = drQuyHocBong("Loai_quy").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
#Region "Function loại quỹ học bổng"
        Public Function Load_LoaiQuy() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_quy")
                dt.Columns.Add("Loai_quy")
                dt.Columns.Add("Ghi_chu")                
                Dim dr As DataRow
                Dim obj As New LoaiQuy
                For i As Integer = 0 To arrLoaiQuy.Count - 1
                    obj = CType(arrLoaiQuy(i), LoaiQuy)
                    dr = dt.NewRow
                    dr("ID_quy") = obj.ID_quy
                    dr("Loai_quy") = obj.Loai_quy
                    dr("Ghi_chu") = obj.Ghi_chu
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
        Public Function Insert_LoaiQuy(ByVal objLoaiQuy As LoaiQuy) As Integer
            Try
                Dim obj As QuyHocBong_DAL = New QuyHocBong_DAL
                Return obj.Insert_LoaiQuy(objLoaiQuy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_Object(ByVal objLoaiQuy As LoaiQuy) As Integer
            Try
                arrLoaiQuy.Add(objLoaiQuy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_LoaiQuy(ByVal objLoaiQuy As LoaiQuy) As Integer
            Try
                Dim obj As QuyHocBong_DAL = New QuyHocBong_DAL
                Return obj.Update_LoaiQuy(objLoaiQuy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Objec(ByVal objLoaiQuy As LoaiQuy, ByVal idx As Integer) As Integer
            Try
                arrLoaiQuy(idx) = objLoaiQuy
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_LoaiQuy(ByVal ID_quy As Integer) As Integer
            Try
                Dim obj As QuyHocBong_DAL = New QuyHocBong_DAL
                Return obj.Delete_LoaiQuy(ID_quy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_Object(ByVal Idx As Integer) As Integer
            Try
                arrLoaiQuy.RemoveAt(Idx)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svLoaiQuy(ByVal Loai_quy As String) As Boolean
            Try
                Dim obj As QuyHocBong_DAL = New QuyHocBong_DAL
                Return obj.CheckExist_LoaiQuy(Loai_quy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting_LoaiQuy(ByVal drLoaiQuy As DataRow) As LoaiQuy
            Dim result As LoaiQuy
            Try
                result = New LoaiQuy
                If drLoaiQuy("ID_quy").ToString() <> "" Then result.ID_quy = CType(drLoaiQuy("ID_quy").ToString(), Integer)
                result.Loai_quy = drLoaiQuy("Loai_quy").ToString()
                result.Ghi_chu = drLoaiQuy("Ghi_chu").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
