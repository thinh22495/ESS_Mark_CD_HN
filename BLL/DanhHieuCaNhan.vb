Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class DanhHieuThiDuaCaNhan_BLL
        Private arrDanhHieuCaNhan As New ArrayList
        Private dsXepLoaiHocTap As XepLoaiHocTap
        Private dtXLRL As DataTable
        Private clsDanhHieu As DanhHieu_BLL
#Region "Constructor"
        Public Sub New()
        End Sub
        Public Sub New(ByVal dsID_lops As String)
            Try
                ' Danh hiệu cá nhân
                clsDanhHieu = New DanhHieu_BLL
                ' Xếp loại ht và rèn luyện
                Dim clsXepLoaiHT As New Xeploaihoctap_thangdiem10
                Dim clsDHCN As New DanhHieuThiDuaCaNhan_DAL
                dtXLRL = clsDHCN.Load_XLRenLuyen()
                Dim dtXLHT As DataTable = clsDHCN.Load_XepLoaiHocTap()
                dsXepLoaiHocTap = New XepLoaiHocTap
                For i As Integer = 0 To dtXLHT.Rows.Count - 1
                    Dim objXepLoaiHocTap As New XepLoaiHocTap
                    objXepLoaiHocTap.ID_xep_loai = dtXLHT.Rows(i)("ID_xep_loai")
                    objXepLoaiHocTap.Tu_diem = dtXLHT.Rows(i)("Tu_diem")
                    objXepLoaiHocTap.Den_diem = dtXLHT.Rows(i)("Den_diem")
                    objXepLoaiHocTap.Xep_loai = dtXLHT.Rows(i)("Xep_loai")
                    dsXepLoaiHocTap.Add(objXepLoaiHocTap)
                Next

                Dim obj As DanhHieuThiDuaCaNhan_DAL = New DanhHieuThiDuaCaNhan_DAL
                Dim dt As DataTable = obj.Load_DanhHieuThiDuaCaNhan_List(dsID_lops)
                Dim objDanhHieuThiDuaCaNhan As DanhHieuThiDuaCaNhan = Nothing
                For i As Integer = 0 To dt.Rows.Count - 1
                    objDanhHieuThiDuaCaNhan = New DanhHieuThiDuaCaNhan
                    objDanhHieuThiDuaCaNhan = Converting(dt.Rows(i))
                    arrDanhHieuCaNhan.Add(objDanhHieuThiDuaCaNhan)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region
#Region "Function"
        ' Load danh sách sinh viên đủ điều kiện xét danh hiệu thi đua
        Public Function DanhSach_XetDanhHieu(ByVal dtDiem As DataTable, ByVal dtKl As DataTable, ByVal dtRL As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataView
            Try
                Dim dt As DataTable
                dt = dtDiem.Copy                                                
                dt.Columns.Add("Tong_diem_rl", GetType(Double))
                dt.Columns.Add("Xep_loai_rl", GetType(String))
                dt.Columns.Add("DiemRLQD", GetType(Double))
                dt.Columns.Add("TBCMR", GetType(Double))
                dt.Columns.Add("Danh_hieu", GetType(String))
                dt.Columns.Add("ID_danh_hieu", GetType(Integer))
                For i As Integer = 0 To dt.Rows.Count - 1                    
                    ' Lọc điểm rèn luyện của sinh viên
                    dtRL.DefaultView.RowFilter = "ID_sv=" & dt.Rows(i)("ID_sv")
                    ' Lọc sinh viên kỷ luật
                    dtKl.DefaultView.RowFilter = "ID_sv=" & dt.Rows(i)("ID_sv")
                    ' Chỉ xếp loại danh hiệu cho những sinh viên có điểm học tập và điểm rèn luyện và không bị kỷ luật
                    If dtRL.DefaultView.Count > 0 And dtKl.DefaultView.Count <= 0 Then
                        ' Không nợ môn và  ID_xep_loai >=1 and ID_xep_loai <= 3(từ khá trở lên) 
                        ' và tổng  điểm ID_xep_loai >=1 ID_xep_loai <=3 từ khá trở lên
                        If IIf(IsDBNull(dtDiem.Rows(i)("So_mon_no")), 0, dtDiem.Rows(i)("So_mon_no")) = 0 And _
                        IIf(IsDBNull(dtDiem.Rows(i)("ID_xep_loai")), 0, dtDiem.Rows(i)("ID_xep_loai")) >= 1 And _
                        IIf(IsDBNull(dtDiem.Rows(i)("ID_xep_loai")), 0, dtDiem.Rows(i)("ID_xep_loai")) <= 3 And _
                        IIf(IsDBNull(dtRL.DefaultView.Item(0).Item("ID_xep_loai")), 0, dtRL.DefaultView.Item(0).Item("ID_xep_loai")) >= 1 And _
                        IIf(IsDBNull(dtRL.DefaultView.Item(0).Item("ID_xep_loai")), 0, dtRL.DefaultView.Item(0).Item("ID_xep_loai")) <= 3 Then                            
                            dt.Rows(i)("DiemRLQD") = CDbl(dtRL.DefaultView.Item(0).Item("Diem_quy_doi"))
                            dt.Rows(i)("Tong_diem_rl") = CDbl(dtRL.DefaultView.Item(0).Item("Tong_diem_rl"))
                            dt.Rows(i)("Xep_loai_rl") = dtRL.DefaultView.Item(0).Item("Xep_loai").ToString
                            dt.Rows(i)("TBCMR") = CDbl(dt.Rows(i)("TBCHT1") + dt.Rows(i)("DiemRLQD"))
                            ' Xếp loại danh hiệu
                            If dtDiem.Rows(i)("ID_xep_loai") = 1 And dtRL.DefaultView.Item(0).Item("ID_xep_loai") = 1 Then
                                dt.Rows(i)("Danh_hieu") = clsDanhHieu.Danh_hieu(1).ToString
                                dt.Rows(i)("ID_danh_hieu") = 1
                            ElseIf dtDiem.Rows(i)("ID_xep_loai") <= 2 And dtDiem.Rows(i)("ID_xep_loai") > 0 And dtRL.DefaultView.Item(0).Item("ID_xep_loai") <= 2 Then ' Xếp loại hb giỏi
                                dt.Rows(i)("Danh_hieu") = clsDanhHieu.Danh_hieu(2).ToString
                                dt.Rows(i)("ID_danh_hieu") = 2
                            ElseIf dtDiem.Rows(i)("ID_xep_loai") <= 3 And dtDiem.Rows(i)("ID_xep_loai") > 0 And dtRL.DefaultView.Item(0).Item("ID_xep_loai") <= 3 Then ' Xếp loại hb khá
                                dt.Rows(i)("Danh_hieu") = clsDanhHieu.Danh_hieu(3).ToString
                                dt.Rows(i)("ID_danh_hieu") = 3
                            End If
                        End If
                    End If
                Next
                ' Loại bỏ những sinh viên không đạt danh hiệu gì
                For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                    If IIf(dt.Rows(i)("ID_danh_hieu").ToString = "", 0, dt.Rows(i)("ID_danh_hieu")) = 0 Then
                        dt.Rows(i).Delete()
                        dt.AcceptChanges()
                    End If
                Next
                ' Loại bỏ những sinh viên đã xét 
                Dim dtDaXet As DataTable
                dtDaXet = DanhSach_DaXet(dtDiem, Hoc_ky, Nam_hoc)
                For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                    For j As Integer = 0 To dtDaXet.Rows.Count - 1
                        If dt.Rows(i)("ID_sv") = dtDaXet.Rows(j)("ID_sv") Then
                            dt.Rows(i).Delete()
                            dt.AcceptChanges()
                            Exit For
                        End If
                    Next
                Next
                Return dt.DefaultView
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách các sinh viên đã được xết danh hiệu thi đua
        Public Function DanhSach_DaXet(ByVal dtDSSV As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try                                
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("TBCHT1", GetType(Double))
                dt.Columns.Add("Xep_loai", GetType(String))
                dt.Columns.Add("Tong_diem_rl", GetType(Double))
                dt.Columns.Add("Xep_loai_rl", GetType(String))
                dt.Columns.Add("DiemRLQD", GetType(Double))
                dt.Columns.Add("TBCMR", GetType(Double))
                dt.Columns.Add("Danh_hieu", GetType(String))
                dt.Columns.Add("ID_danh_hieu", GetType(Integer))
                dt.Columns.Add("ID_lop", GetType(Integer))
                Dim row As DataRow
                Dim DH As New DanhHieuThiDuaCaNhan
                For i As Integer = 0 To dtDSSV.Rows.Count - 1
                    For j As Integer = 0 To arrDanhHieuCaNhan.Count - 1
                        DH = arrDanhHieuCaNhan(j)
                        If dtDSSV.Rows(i)("ID_sv") = DH.ID_sv And DH.Hoc_ky = Hoc_ky And DH.Nam_hoc = Nam_hoc Then
                            row = dt.NewRow
                            row("Chon") = False
                            row("ID_sv") = DH.ID_sv
                            row("Ma_sv") = dtDSSV.Rows(i)("Ma_sv")
                            row("Ho_ten") = dtDSSV.Rows(i)("Ho_ten")
                            row("Ngay_sinh") = dtDSSV.Rows(i)("Ngay_sinh")
                            row("Ten_lop") = dtDSSV.Rows(i)("Ten_lop")
                            row("TBCHT1") = DH.TBCHT
                            row("Xep_loai") = dsXepLoaiHocTap.XepLoaiHocTap(DH.TBCHT)
                            row("DiemRLQD") = DH.DRL
                            row("Tong_diem_rl") = DH.DRL * 100
                            Dim Xep_loai_rl As String = ""
                            For k As Integer = 0 To dtXLRL.Rows.Count - 1
                                If row("Tong_diem_rl") >= dtXLRL.Rows(k).Item("Tu_diem") And row("Tong_diem_rl") <= dtXLRL.Rows(k).Item("Den_diem") Then
                                    Xep_loai_rl = dtXLRL.Rows(k).Item("Xep_loai")
                                End If
                            Next
                            row("Xep_loai_rl") = Xep_loai_rl
                            row("TBCMR") = DH.TBCMR
                            row("ID_danh_hieu") = DH.ID_danh_hieu
                            row("Danh_hieu") = clsDanhHieu.Danh_hieu(DH.ID_danh_hieu).ToString
                            row("ID_lop") = DH.ID_lop
                            dt.Rows.Add(row)
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh hieu thi dua ca nhan cua 1 sinh vien (Dung load trong ho so)
        Public Function DanhHieuCaNhan(ByVal ID_sv As Integer) As DataTable
            Try                              
                Dim dt As New DataTable
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Hoc_ky1", GetType(String))
                dt.Columns.Add("Hoc_ky2", GetType(String))
                dt.Columns.Add("Ca_nam", GetType(String))
                Dim row As DataRow
                Dim DH As New DanhHieuThiDuaCaNhan
                For j As Integer = 0 To arrDanhHieuCaNhan.Count - 1
                    DH = arrDanhHieuCaNhan(j)
                    If DH.ID_sv = ID_sv Then
                        row = dt.NewRow
                        row("Nam_hoc") = DH.Nam_hoc
                        If DH.Hoc_ky = 1 Then row("Hoc_ky1") = clsDanhHieu.Danh_hieu(DH.ID_danh_hieu).ToString
                        If DH.Hoc_ky = 2 Then
                            row("Hoc_ky2") = clsDanhHieu.Danh_hieu(DH.ID_danh_hieu).ToString
                            row("Ca_nam") = clsDanhHieu.Danh_hieu(DH.ID_danh_hieu).ToString
                        End If
                        dt.Rows.Add(row)
                    End If
                Next
                Dim dt1 As New DataTable
                dt1.Columns.Add("Nam_hoc")
                dt1.Columns.Add("Hoc_ky1")
                dt1.Columns.Add("Hoc_ky2")
                dt1.Columns.Add("Ca_nam")
                Dim dr As DataRow
                Dim Temp As String = ""
                For Each r As DataRow In dt.Rows
                    If Temp <> r("Nam_hoc") Then
                        dr = dt1.NewRow
                        dr("Nam_hoc") = r("Nam_hoc")
                        Dim Hoc_ky1 As String = ""
                        Dim Hoc_ky2 As String = ""
                        Dim Ca_nam As String = ""
                        For Each r1 As DataRow In dt.Rows
                            If r1("Nam_hoc") = r("Nam_hoc") Then
                                Hoc_ky1 += r1("Hoc_ky1").ToString
                                Hoc_ky2 += r1("Hoc_ky2").ToString
                                Ca_nam += r1("Ca_nam").ToString
                            End If
                        Next
                        dr("Hoc_ky1") = Hoc_ky1
                        dr("Hoc_ky2") = Hoc_ky2
                        dr("Ca_nam") = Ca_nam
                        dt1.Rows.Add(dr)
                        Temp = r("Nam_hoc")
                    End If
                Next
                Return dt1
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DanhHieuThiDuaCaNhan(ByVal objDanhHieuThiDuaCaNhan As DanhHieuThiDuaCaNhan) As Integer
            Try
                Dim obj As DanhHieuThiDuaCaNhan_DAL = New DanhHieuThiDuaCaNhan_DAL
                Return obj.Insert_DanhHieuThiDuaCaNhan(objDanhHieuThiDuaCaNhan)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhHieuThiDuaCaNhan(ByVal objDanhHieuThiDuaCaNhan As DanhHieuThiDuaCaNhan) As Integer
            Try
                Dim obj As DanhHieuThiDuaCaNhan_DAL = New DanhHieuThiDuaCaNhan_DAL
                Return obj.Update_DanhHieuThiDuaCaNhan(objDanhHieuThiDuaCaNhan)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhHieuThiDuaCaNhan(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                Dim obj As DanhHieuThiDuaCaNhan_DAL = New DanhHieuThiDuaCaNhan_DAL
                Return obj.Delete_DanhHieuThiDuaCaNhan(ID_sv, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svDanhHieuThiDuaCaNhan(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Try
                Dim obj As DanhHieuThiDuaCaNhan_DAL = New DanhHieuThiDuaCaNhan_DAL
                Return obj.CheckExist_DanhHieuThiDuaCaNhan(ID_sv, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drDanhHieuThiDuaCaNhan As DataRow) As DanhHieuThiDuaCaNhan
            Dim result As DanhHieuThiDuaCaNhan
            Try
                result = New DanhHieuThiDuaCaNhan
                If drDanhHieuThiDuaCaNhan("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhHieuThiDuaCaNhan("ID_sv").ToString(), Integer)
                If drDanhHieuThiDuaCaNhan("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drDanhHieuThiDuaCaNhan("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drDanhHieuThiDuaCaNhan("Nam_hoc").ToString()
                If drDanhHieuThiDuaCaNhan("TBCHT").ToString() <> "" Then result.TBCHT = CType(drDanhHieuThiDuaCaNhan("TBCHT").ToString(), Double)
                If drDanhHieuThiDuaCaNhan("DRL").ToString() <> "" Then result.DRL = CType(drDanhHieuThiDuaCaNhan("DRL").ToString(), Double)
                If drDanhHieuThiDuaCaNhan("TBCMR").ToString() <> "" Then result.TBCMR = CType(drDanhHieuThiDuaCaNhan("TBCMR").ToString(), Double)
                If drDanhHieuThiDuaCaNhan("ID_danh_hieu").ToString() <> "" Then result.ID_danh_hieu = CType(drDanhHieuThiDuaCaNhan("ID_danh_hieu").ToString(), Integer)
                If drDanhHieuThiDuaCaNhan("ID_lop").ToString() <> "" Then result.ID_lop = CType(drDanhHieuThiDuaCaNhan("ID_lop").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace

