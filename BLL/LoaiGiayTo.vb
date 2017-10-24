'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Sunday, May 04, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class LoaiGiayTo_BLL
        Inherits LoaiGiayTo
        Private arrLoaiGiayTo As ArrayList
        Private dtDoiTuongGT As DataTable  ' Danh sách các giấy tờ cần nộp theo đối tượng học bổng
#Region "Constructor"
        'Public Sub New()
        '    Try
        '        Dim obj As LoaiGiayTo_DAL = New LoaiGiayTo_DAL
        '        Dim dt As DataTable = obj.Load_LoaiGiayTo_List()
        '        Dim objLoaiGiayTo As New LoaiGiayTo
        '        Dim dr As DataRow = Nothing
        '        arrLoaiGiayTo = New ArrayList
        '        For Each dr In dt.Rows
        '            objLoaiGiayTo = Converting(dr)
        '            arrLoaiGiayTo.Add(objLoaiGiayTo)
        '        Next
        '        ' Khởi tạo đối tượng giấy tờ cần nộp
        '        dtDoiTuongGT = obj.Load_DoiTuongGiayTo_List()            
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Sub

        Public Sub New(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer)
            Try
                Dim obj As LoaiGiayTo_DAL = New LoaiGiayTo_DAL
                Dim dt As DataTable = obj.Load_LoaiGiayTo_List(ID_he, Khoa_hoc)
                Dim objLoaiGiayTo As New LoaiGiayTo
                Dim dr As DataRow = Nothing
                arrLoaiGiayTo = New ArrayList
                For Each dr In dt.Rows
                    objLoaiGiayTo = Converting(dr)
                    arrLoaiGiayTo.Add(objLoaiGiayTo)
                Next
                'Khởi tạo đối tượng giấy tờ cần nộp
                dtDoiTuongGT = obj.Load_DoiTuongGiayTo_List()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"        
        Public Function DanhSach_GiayTo() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_giay_to", GetType(Integer))
                dt.Columns.Add("Ma_giay_to", GetType(String))
                dt.Columns.Add("Ten_giay_to", GetType(String))
                dt.Columns.Add("Ghi_chu_nop", GetType(String))
                For i As Integer = 0 To arrLoaiGiayTo.Count - 1
                    Dim gt As LoaiGiayTo = CType(arrLoaiGiayTo(i), LoaiGiayTo)
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("ID_giay_to") = gt.ID_giay_to
                    row("Ma_giay_to") = gt.Ma_giay_to
                    row("Ten_giay_to") = gt.Ten_giay_to
                    row("Ghi_chu_nop") = ""
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Loai_GiayTo_TheoHeKhoaHoc() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_giay_to", GetType(Integer))
                dt.Columns.Add("Ten_giay_to", GetType(String))
                For i As Integer = 0 To arrLoaiGiayTo.Count - 1
                    Dim gt As LoaiGiayTo = CType(arrLoaiGiayTo(i), LoaiGiayTo)
                    Dim row As DataRow = dt.NewRow()
                    row("ID_giay_to") = gt.ID_giay_to
                    row("Ten_giay_to") = gt.Ten_giay_to
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_LoaiGiayTo(ByVal ID_giay_to As Integer) As LoaiGiayTo
            Try
                Dim obj As LoaiGiayTo_DAL = New LoaiGiayTo_DAL
                Dim dt As DataTable = obj.Load_LoaiGiayTo(ID_giay_to)
                Dim objLoaiGiayTo As LoaiGiayTo = Nothing
                If dt.Rows.Count > 0 Then
                    objLoaiGiayTo = Converting(dt.Rows(0))
                End If
                Return objLoaiGiayTo
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ' Cac loai giay to da nop
        Public Function Load_LoaiGiayTo_DaNop(ByVal ID_sv As Integer) As DataTable
            Try
                Dim obj As LoaiGiayTo_DAL = New LoaiGiayTo_DAL
                Return obj.Load_LoaiGiayTo_DaNop(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cac Loai Giay to con thieu
        Public Function Load_LoaiGiayTo_ConThieu(ByVal ID_sv As Integer) As DataTable
            Try
                ' Ho so đã nop
                Dim obj As New HoSoNop_BLL
                Dim dtNop As DataTable = obj.Load_TableHoSoNop(ID_sv)
                ' Ho so nộp
                Dim dtGiayTo As DataTable = DanhSach_GiayTo()
                For i As Integer = 0 To dtNop.Rows.Count - 1
                    Dim idx As Integer = dtGiayTo.Rows.Count - 1
                    For j As Integer = 0 To idx
                        If j > idx Then Exit For
                        If dtNop.Rows(i).Item("ID_giay_to") = dtGiayTo.Rows(j).Item("ID_giay_to") Then
                            dtGiayTo.Rows(j).Delete()
                            dtGiayTo.AcceptChanges()
                            idx -= 1
                        End If
                    Next
                Next
                Return dtGiayTo
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cac Loai Giay đã nộp và chưa nộp của sinh viên
        Public Function LoadGiayTo(ByVal ID_sv As Integer) As DataTable
            Try
                ' Ho so đã nop
                Dim obj As New HoSoNop_BLL
                Dim dtNop As DataTable = obj.Load_TableHoSoNop(ID_sv)

                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_giay_to", GetType(Integer))
                dt.Columns.Add("Ma_giay_to", GetType(String))
                dt.Columns.Add("Ten_giay_to", GetType(String))
                dt.Columns.Add("Ghi_chu_nop", GetType(String))
                For i As Integer = 0 To arrLoaiGiayTo.Count - 1
                    Dim gt As LoaiGiayTo = CType(arrLoaiGiayTo(i), LoaiGiayTo)
                    Dim row As DataRow = dt.NewRow()
                    If dtNop Is Nothing Then
                        row("Chon") = False
                    Else
                        Dim dk As String = "ID_giay_to=" & gt.ID_giay_to
                        dtNop.DefaultView.RowFilter = dk
                        If dtNop.DefaultView.Count > 0 Then
                            row("Chon") = True
                        Else
                            row("Chon") = False
                        End If
                    End If
                    row("ID_giay_to") = gt.ID_giay_to
                    row("Ma_giay_to") = gt.Ma_giay_to
                    row("Ten_giay_to") = gt.Ten_giay_to
                    If dtNop.DefaultView.Count > 0 Then row("Ghi_chu_nop") = dtNop.DefaultView.Item(0)("Ghi_chu_nop")
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ' Cac Loai Giay To thay the
        Public Function LoadGiayTo_ThayThe() As DataTable
            Try
                ' Ho so đã nop
                Dim obj As New HoSoNop_BLL
                Return obj.Load_GiayTo_ThayThe
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_LoaiGiayTo(ByVal objLoaiGiayTo As LoaiGiayTo) As Integer
            Try
                Dim obj As LoaiGiayTo_DAL = New LoaiGiayTo_DAL
                Return obj.Insert_LoaiGiayTo(objLoaiGiayTo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_LoaiGiayTo(ByVal objLoaiGiayTo As LoaiGiayTo, ByVal ID_giay_to As Integer) As Integer
            Try
                Dim obj As LoaiGiayTo_DAL = New LoaiGiayTo_DAL
                Return obj.Update_LoaiGiayTo(objLoaiGiayTo, ID_giay_to)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_LoaiGiayTo(ByVal ID_giay_to As Integer) As Integer
            Try
                Dim obj As LoaiGiayTo_DAL = New LoaiGiayTo_DAL
                Return obj.Delete_LoaiGiayTo(ID_giay_to)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drLoaiGiayTo As DataRow) As LoaiGiayTo
            Dim result As LoaiGiayTo
            Try
                result = New LoaiGiayTo
                If drLoaiGiayTo("ID_giay_to").ToString() <> "" Then result.ID_giay_to = CType(drLoaiGiayTo("ID_giay_to").ToString(), Integer)
                result.Ma_giay_to = drLoaiGiayTo("Ma_giay_to").ToString()
                result.Ten_giay_to = drLoaiGiayTo("Ten_giay_to").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#Region " Giấy tờ cần nộp theo đối tượng học bổng"
        ' Danh sách giấy tờ cần nộp theo đối tượng học bổng
        Public Function DoiTuong_GiayTo(ByVal Ma_dt As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Ma_dt", GetType(String))
                dt.Columns.Add("ID_giay_to", GetType(Integer))
                dt.Columns.Add("Ten_giay_to", GetType(String))
                Dim dr As DataRow
                Dim obj As New LoaiGiayTo
                For i As Integer = 0 To arrLoaiGiayTo.Count - 1
                    obj = CType(arrLoaiGiayTo(i), LoaiGiayTo)
                    For j As Integer = 0 To dtDoiTuongGT.Rows.Count - 1
                        If obj.ID_giay_to = dtDoiTuongGT.Rows(j)("ID_giay_to") And dtDoiTuongGT.Rows(j)("Ma_dt").ToString = Ma_dt Then
                            dr = dt.NewRow
                            dr("Ma_dt") = Ma_dt
                            dr("ID_giay_to") = obj.ID_giay_to
                            dr("Ten_giay_to") = obj.Ten_giay_to.ToString
                            dt.Rows.Add(dr)
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DoiTuongGiayTo(ByVal Ma_dt As String, ByVal ID_giay_to As Integer) As Integer
            Try
                Dim obj As LoaiGiayTo_DAL = New LoaiGiayTo_DAL
                Return obj.Insert_DoiTuongGiayTo(Ma_dt, ID_giay_to)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DoiTuongGiayTo(ByVal Ma_dt As String, ByVal ID_giay_to As Integer) As Integer
            Try
                Dim obj As LoaiGiayTo_DAL = New LoaiGiayTo_DAL
                Return obj.Update_DoiTuongGiayTo(Ma_dt, ID_giay_to)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DoiTuongGiayTo(ByVal Ma_dt As String, ByVal ID_giay_to As Integer) As Integer
            Try
                Dim obj As LoaiGiayTo_DAL = New LoaiGiayTo_DAL
                Return obj.Delete_DoiTuongGiayTo(Ma_dt, ID_giay_to)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_DoiTuongGiayTo(ByVal Ma_dt As String, ByVal ID_giay_to As Integer) As Boolean
            Try
                Dim obj As LoaiGiayTo_DAL = New LoaiGiayTo_DAL
                Return obj.Check_DoiTuongGiayTo(Ma_dt, ID_giay_to)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#End Region
    End Class
End Namespace
