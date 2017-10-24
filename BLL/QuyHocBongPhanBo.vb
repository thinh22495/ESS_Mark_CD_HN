'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Friday, August 01, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class QuyHocBongPhanBo_BLL
        Private ArrQuyHocBongPhanBo As New ArrayList
        Private mdtLop As DataTable  ' Các lớp đã phân bổ
#Region "Constructor"
        Public Sub New()
        End Sub
        Public Sub New(ByVal ID_hb As Integer)
            Dim obj_DAL As QuyHocBongPhanBo_DAL = New QuyHocBongPhanBo_DAL
            Dim obj As New QuyHocBongPhanBo
            Dim dt As DataTable = obj_DAL.Load_QuyHocBongPhanBo_List(ID_hb)
            For i As Integer = 0 To dt.Rows.Count - 1
                obj = Converting(dt.Rows(i))
                ArrQuyHocBongPhanBo.Add(obj)
            Next
            ' Lớp đã phân bổ
            mdtLop = obj_DAL.Load_QuyHocBongPhanBoLop_List(ID_hb)
        End Sub
#End Region

#Region "Function"
        ' Danh sách sinh viên được trợ cấp xã hội
        Public Function DanhSach_TroCap(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                Dim obj As New DanhSachHocBong_DAL
                Dim dt As DataTable
                dt = obj.Load_DanhSachTroCap(Hoc_ky, Nam_hoc, dsID_lop)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách phân bổ quỹ học bổng 
        Public Function DanhSach_QuyHocBongPhanBo() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_phan_bo")
                dt.Columns.Add("Ten_phan_bo")
                dt.Columns.Add("ID_hb")
                dt.Columns.Add("So_sv")
                dt.Columns.Add("So_tien")
                dt.Columns.Add("Phan_dac_biet")
                dt.Columns.Add("Kieu_phan_bo")
                Dim obj As New QuyHocBongPhanBo
                Dim dr As DataRow
                For i As Integer = 0 To ArrQuyHocBongPhanBo.Count - 1
                    obj = CType(ArrQuyHocBongPhanBo(i), QuyHocBongPhanBo)
                    dr = dt.NewRow
                    dr("ID_phan_bo") = obj.ID_phan_bo
                    dr("Ten_phan_bo") = obj.Ten_phan_bo
                    dr("ID_hb") = obj.ID_hb
                    dr("So_sv") = obj.So_sv
                    dr("So_tien") = Format(obj.So_tien, "###,##0")
                    dr("Phan_dac_biet") = obj.Phan_dac_biet
                    If obj.Phan_dac_biet = 0 Then
                        dr("Kieu_phan_bo") = "Phân tự động"
                    Else
                        dr("Kieu_phan_bo") = "Phân thủ công"
                    End If
                    dt.Rows.Add(dr)
                Next
                dt.DefaultView.AllowNew = False
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ' Quỹ hb phân bổ quỹ học bổng 
        Public Function Load_QuyHocBongPhanBo(ByVal ID_phan_bo As Integer) As QuyHocBongPhanBo
            Try
                Dim objQ As New QuyHocBongPhanBo
                Dim obj As New QuyHocBongPhanBo
                For i As Integer = 0 To ArrQuyHocBongPhanBo.Count - 1
                    obj = CType(ArrQuyHocBongPhanBo(i), QuyHocBongPhanBo)
                    If obj.ID_phan_bo = ID_phan_bo Then
                        objQ = obj
                    End If
                Next
                Return objQ
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách lớp chưa phân bổ
        Public Function Lop_Chua_PhanBo(ByVal dtLop As DataTable, ByVal dtSv As DataTable, ByVal Tu_khoa As Integer, ByVal Den_khoa As Integer) As DataTable
            Try
                Dim dt As DataTable
                dt = dtLop.Copy
                ' Loại bỏ các lớp đã phân bổ và những lớp ngoài khóa học được phân
                For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                    If dt.Rows(i)("Khoa_hoc") < Tu_khoa Or dt.Rows(i)("Khoa_hoc") > Den_khoa Then
                        dt.Rows(i).Delete()
                        GoTo Nxt
                    End If
                    For Each dr As DataRow In mdtLop.Rows
                        If dr("ID_lop") = dt.Rows(i)("ID_lop") Then
                            dt.Rows(i).Delete()
                            Exit For
                        End If
                    Next
Nxt:
                Next
                dt.AcceptChanges()
                ' Create Lớp với cẩ số sinh viên thực của mỗi lớp
                Dim data As New DataTable
                data.Columns.Add("Chon")
                data.Columns.Add("Ten_he")
                data.Columns.Add("ID_he")
                data.Columns.Add("ID_lop")
                data.Columns.Add("Ten_lop")
                data.Columns.Add("Ten_khoa")
                data.Columns.Add("Khoa_hoc")
                data.Columns.Add("Ten_nganh")
                data.Columns.Add("Chuyen_nganh")
                data.Columns.Add("So_sv")
                Dim row As DataRow
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim dvSV As DataView
                    dvSV = dtSv.DefaultView
                    dvSV.RowFilter = "Ten_lop='" & dt.Rows(i)("Ten_lop") & "'"
                    row = data.NewRow
                    row("Chon") = False
                    row("Ten_he") = dt.Rows(i)("Ten_he")
                    row("ID_he") = dt.Rows(i)("ID_he")
                    row("ID_lop") = dt.Rows(i)("ID_lop")
                    row("Ten_lop") = dt.Rows(i)("Ten_lop")
                    row("Ten_khoa") = dt.Rows(i)("Ten_khoa")
                    row("Khoa_hoc") = dt.Rows(i)("Khoa_hoc")
                    row("Ten_nganh") = dt.Rows(i)("Ten_nganh")
                    row("Chuyen_nganh") = dt.Rows(i)("Chuyen_nganh")
                    row("So_sv") = dvSV.Count
                    data.Rows.Add(row)
                Next
                data.DefaultView.AllowNew = False
                data.DefaultView.Sort = "Ten_lop"
                Return data
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách lớp đã phân theo hình thức thủ công
        Public Function Lop_PhanBo_ThuCong() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_lop")
                Dim dr As DataRow
                For Each row As DataRow In mdtLop.Rows
                    If row("Phan_dac_biet") Then
                        dr = dt.NewRow
                        dr("ID_lop") = row("ID_lop")
                        dt.Rows.Add(dr)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách lơp đã phân bổ theo ID_phan_bo
        Public Function Lop_Phan_Bo(ByVal ID_phan_bo As Integer) As String
            Try
                Dim dsID_lop As String = "0"
                For Each row As DataRow In mdtLop.Rows
                    If row("ID_phan_bo") = ID_phan_bo Then
                        dsID_lop += "," & row("ID_lop")
                    End If
                Next
                Return dsID_lop
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Add các lớp phân bổ
        Public Function CheckExits_QuyHocBongPhanBoLop(ByVal ID_phan_bo As Integer, ByVal ID_lop As Integer) As Boolean
            Try
                Dim obj As QuyHocBongPhanBo_DAL = New QuyHocBongPhanBo_DAL
                If obj.Load_QuyHocBongPhanBoLop_List(ID_phan_bo, ID_lop).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Add các lớp phân bổ
        Public Function Insert_QuyHocBongPhanBoLop(ByVal ID_phan_bo As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As QuyHocBongPhanBo_DAL = New QuyHocBongPhanBo_DAL
                Return obj.Insert_QuyHocBongPhanBoLop(ID_phan_bo, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_QuyHocBongPhanBo(ByVal objQuyHocBongPhanBo As QuyHocBongPhanBo) As Integer
            Try
                Dim obj As QuyHocBongPhanBo_DAL = New QuyHocBongPhanBo_DAL
                Return obj.Insert_QuyHocBongPhanBo(objQuyHocBongPhanBo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_QuyHocBongPhanBo_Memory(ByVal objQuyHocBongPhanBo As QuyHocBongPhanBo) As Integer
            Try
                ArrQuyHocBongPhanBo.Add(objQuyHocBongPhanBo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_QuyHocBongPhanBo(ByVal objQuyHocBongPhanBo As QuyHocBongPhanBo, ByVal ID_phan_bo As Integer) As Integer
            Try
                Dim obj As QuyHocBongPhanBo_DAL = New QuyHocBongPhanBo_DAL
                Return obj.Update_QuyHocBongPhanBo(objQuyHocBongPhanBo, ID_phan_bo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_QuyHocBongPhanBoLop(ByVal ID_phan_bo As Integer) As Integer
            Try
                Dim obj As QuyHocBongPhanBo_DAL = New QuyHocBongPhanBo_DAL
                Return obj.Delete_QuyHocBongPhanBoLop(ID_phan_bo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_QuyHocBongPhanBo(ByVal ID_phan_bo As Integer) As Integer
            Try
                Dim obj As QuyHocBongPhanBo_DAL = New QuyHocBongPhanBo_DAL
                Return obj.Delete_QuyHocBongPhanBo(ID_phan_bo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drQuyHocBongPhanBo As DataRow) As QuyHocBongPhanBo
            Dim result As QuyHocBongPhanBo
            Try
                result = New QuyHocBongPhanBo
                If drQuyHocBongPhanBo("ID_phan_bo").ToString() <> "" Then result.ID_phan_bo = CType(drQuyHocBongPhanBo("ID_phan_bo").ToString(), Integer)
                result.Ten_phan_bo = drQuyHocBongPhanBo("Ten_phan_bo").ToString()
                If drQuyHocBongPhanBo("ID_hb").ToString() <> "" Then result.ID_hb = CType(drQuyHocBongPhanBo("ID_hb").ToString(), Integer)
                If drQuyHocBongPhanBo("So_sv").ToString() <> "" Then result.So_sv = CType(drQuyHocBongPhanBo("So_sv").ToString(), Integer)
                result.So_tien = drQuyHocBongPhanBo("So_tien").ToString()
                result.Phan_dac_biet = drQuyHocBongPhanBo("Phan_dac_biet").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
