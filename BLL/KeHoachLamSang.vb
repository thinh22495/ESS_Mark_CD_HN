'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Friday, July 24, 2009
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class KeHoachLamSang_BLL
        Private arrKeHoachLamSang As New ArrayList
#Region "Constructor"
        Public Sub New()

        End Sub
        Public Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Try
                Dim obj As KeHoachLamSang_DAL = New KeHoachLamSang_DAL
                Dim dt As DataTable = obj.Load_KeHoachLamSang(Hoc_ky, Nam_hoc)
                Dim objKeHoachLamSang As KeHoachLamSang = Nothing
                For i As Integer = 0 To dt.Rows.Count - 1
                    objKeHoachLamSang = Converting(dt.Rows(i))
                    arrKeHoachLamSang.Add(objKeHoachLamSang)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        Private ReadOnly Property Count() As Integer
            Get
                Return Me.arrKeHoachLamSang.Count
            End Get
        End Property
        Private Property KehoachMonChiTiet(ByVal idx As Integer) As KeHoachLamSang
            Get
                Return CType(Me.arrKeHoachLamSang(idx), KeHoachLamSang)
            End Get
            Set(ByVal Value As KeHoachLamSang)
                Me.arrKeHoachLamSang(idx) = Value
            End Set
        End Property
        Public Function Load_KeHoachLamSang(ByVal ID_kh As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Dim dtKHLS As New DataTable
            Dim khTuan As New KeHoachTuan_BLL(ID_kh)
            dtKHLS.Columns.Add("ID_bm", GetType(Integer))
            dtKHLS.Columns.Add("Nhom", GetType(Integer))
            dtKHLS.Columns.Add("Bo_mon", GetType(String))
            'Add các tuần trong 1 học kỳ của năm
            For i As Integer = 0 To khTuan.Count - 1
                If Hoc_ky = 1 Then
                    If khTuan.KeHoachTuan(i).Tuan_thu <= 26 Then
                        dtKHLS.Columns.Add("T." + khTuan.KeHoachTuan(i).Tuan_thu.ToString, GetType(String))
                    End If
                ElseIf Hoc_ky = 2 Then
                    If khTuan.KeHoachTuan(i).Tuan_thu > 26 Then
                        dtKHLS.Columns.Add("T." + khTuan.KeHoachTuan(i).Tuan_thu.ToString, GetType(String))
                    End If
                End If
            Next
            Dim dtBM As DataTable = Load_BoMonLamSang(Hoc_ky, Nam_hoc)
            For i As Integer = 0 To dtBM.Rows.Count - 1
                For nhom As Integer = 1 To dtBM.Rows(i)("So_nhom")
                    Dim dr As DataRow
                    dr = dtKHLS.NewRow
                    dr("ID_bm") = dtBM.Rows(i)("ID_bm")
                    dr("Bo_mon") = dtBM.Rows(i)("Bo_mon")
                    dr("nhom") = nhom
                    dtKHLS.Rows.Add(dr)
                Next
            Next
            'Add thông tin về kế hoạch lâm sàng
            For i As Integer = 0 To arrKeHoachLamSang.Count - 1
                Dim objKHLS As New KeHoachLamSang
                objKHLS = CType(arrKeHoachLamSang(i), KeHoachLamSang)
                For j As Integer = 0 To dtKHLS.Rows.Count - 1
                    If objKHLS.ID_bm = dtKHLS.Rows(j)("ID_bm") And objKHLS.Nhom = dtKHLS.Rows(j)("Nhom") Then
                        'Gán dữ liệu lớp-môn lâm sàng
                        For t As Integer = objKHLS.Tu_tuan To objKHLS.Den_tuan
                            dtKHLS.Rows(j)("T." + t.ToString) = objKHLS.Ten_lop
                        Next
                    End If
                Next
            Next
            Return dtKHLS
        End Function
        Public Function Load_MonHocLamSang(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_bm As Integer) As DataTable
            Try
                Dim dt As DataTable
                Dim obj As KeHoachLamSang_DAL = New KeHoachLamSang_DAL
                dt = obj.Load_KeHoachLamSang_MonHoc(Hoc_ky, Nam_hoc, ID_bm)
                'Update kế hoạch đã xếp
                For i As Integer = 0 To dt.Rows.Count - 1
                    For j As Integer = 0 To arrKeHoachLamSang.Count - 1
                        Dim objKHLS As New KeHoachLamSang
                        objKHLS = CType(arrKeHoachLamSang(j), KeHoachLamSang)
                        If dt.Rows(i)("ID_kh_mon") = objKHLS.ID_kh_mon Then
                            dt.Rows(i)("ID_kh_ls") = objKHLS.ID_kh_ls
                            dt.Rows(i)("Tu_tuan") = objKHLS.Tu_tuan
                            dt.Rows(i)("Den_tuan") = objKHLS.Den_tuan
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_TrungKeHoach(ByVal ID_bm As Integer, ByVal Nhom As Integer, ByVal Tu_tuan As Integer, ByVal So_tuan As Integer) As Boolean
            For t As Integer = Tu_tuan To Tu_tuan + So_tuan
                For i As Integer = 0 To arrKeHoachLamSang.Count - 1
                    Dim objKHLS As New KeHoachLamSang
                    objKHLS = CType(arrKeHoachLamSang(i), KeHoachLamSang)
                    If (t >= objKHLS.Tu_tuan And t <= objKHLS.Den_tuan) And objKHLS.ID_bm = ID_bm And Nhom = objKHLS.Nhom Then
                        Return True
                    End If
                Next
            Next
            Return False
        End Function
        Public Sub XepKeHoachLamSang(ByVal objKHLS As KeHoachLamSang)
            For i As Integer = 0 To arrKeHoachLamSang.Count - 1
                Dim objKH As KeHoachLamSang = CType(arrKeHoachLamSang(i), KeHoachLamSang)
                If objKH.ID_kh_mon = objKHLS.ID_kh_mon Then
                    'Update kế hoạch đã tồn tại
                    objKH.Tu_tuan = objKHLS.Tu_tuan
                    objKH.Den_tuan = objKHLS.Den_tuan
                    objKH.Nhom = objKHLS.Nhom
                    Exit Sub
                End If
            Next
            'Add thêm kế hoạch mới
            arrKeHoachLamSang.Add(objKHLS)
        End Sub
        Public Sub LuuKeHoach()
            For i As Integer = 0 To arrKeHoachLamSang.Count - 1
                Dim objKH As KeHoachLamSang = CType(arrKeHoachLamSang(i), KeHoachLamSang)
                If objKH.ID_kh_ls > 0 Then
                    'Update database
                    Update_KeHoachLamSang(objKH, objKH.ID_kh_ls)
                Else
                    'Insert database
                    Insert_KeHoachLamSang(objKH)
                End If
            Next
        End Sub
        Public Sub XoaKeHoach(ByVal ID_kh_ls As Integer)
            For i As Integer = arrKeHoachLamSang.Count - 1 To 0 Step -1
                Dim obj As KeHoachLamSang = CType(arrKeHoachLamSang(i), KeHoachLamSang)
                If obj.ID_kh_ls = ID_kh_ls Then
                    'Xóa trong Database 
                    Delete_KeHoachLamSang(ID_kh_ls)
                    'Xóa trên bộ nhớ
                    arrKeHoachLamSang.RemoveAt(i)
                    Exit Sub
                End If
            Next
        End Sub
        Private Function Load_BoMonLamSang(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As KeHoachLamSang_DAL = New KeHoachLamSang_DAL
                Return obj.Load_KeHoachLamSang_BoMon(Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_KeHoachLamSang(ByVal objKeHoachLamSang As KeHoachLamSang) As Integer
            Try
                Dim obj As KeHoachLamSang_DAL = New KeHoachLamSang_DAL
                Return obj.Insert_KeHoachLamSang(objKeHoachLamSang)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_KeHoachLamSang(ByVal objKeHoachLamSang As KeHoachLamSang, ByVal ID_kh_ls As Integer) As Integer
            Try
                Dim obj As KeHoachLamSang_DAL = New KeHoachLamSang_DAL
                Return obj.Update_KeHoachLamSang(objKeHoachLamSang, ID_kh_ls)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_KeHoachLamSang(ByVal ID_kh_ls As Integer) As Integer
            Try
                Dim obj As KeHoachLamSang_DAL = New KeHoachLamSang_DAL
                Return obj.Delete_KeHoachLamSang(ID_kh_ls)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drKeHoachLamSang As DataRow) As KeHoachLamSang
            Dim result As KeHoachLamSang
            Try
                result = New KeHoachLamSang
                If drKeHoachLamSang("ID_kh_ls").ToString() <> "" Then result.ID_kh_ls = CType(drKeHoachLamSang("ID_kh_ls").ToString(), Integer)
                If drKeHoachLamSang("ID_kh_mon").ToString() <> "" Then result.ID_kh_mon = CType(drKeHoachLamSang("ID_kh_mon").ToString(), Integer)
                If drKeHoachLamSang("ID_bm").ToString() <> "" Then result.ID_bm = CType(drKeHoachLamSang("ID_bm").ToString(), Integer)
                If drKeHoachLamSang("Nhom").ToString() <> "" Then result.Nhom = CType(drKeHoachLamSang("Nhom").ToString(), Integer)
                If drKeHoachLamSang("Tu_tuan").ToString() <> "" Then result.Tu_tuan = CType(drKeHoachLamSang("Tu_tuan").ToString(), Integer)
                If drKeHoachLamSang("Den_tuan").ToString() <> "" Then result.Den_tuan = CType(drKeHoachLamSang("Den_tuan").ToString(), Integer)
                result.Ten_lop = drKeHoachLamSang("Ten_lop").ToString
                If drKeHoachLamSang("Ca_hoc").ToString() <> "" Then result.Ca_hoc = CType(drKeHoachLamSang("Ca_hoc").ToString(), Integer)
                result.Ten_lop = drKeHoachLamSang("Ten_lop").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
