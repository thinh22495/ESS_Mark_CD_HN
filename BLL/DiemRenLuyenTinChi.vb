'---------------------------------------------------------------------------
' Author : Thien An ESS
' Company : Thiên An ESS
' Created Date : Tuesday, November 03, 2011
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class DiemRenLuyenTinChi_BLL
        Inherits DiemRenLuyenTinChi
        Private arr As New ArrayList

#Region "Constructor"
        Public Sub New()
        End Sub
        Public Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon_tc As Integer)
            Try
                Dim obj As New DiemRenLuyenTinChi_DAL
                Dim dt As DataTable = obj.Load_DiemRenLuyenTinChi_List(Hoc_ky, Nam_hoc, ID_mon_tc)
                Dim objDiem As New DiemRenLuyenTinChi
                For Each dr As DataRow In dt.Rows
                    objDiem = Converting(dr)
                    arr.Add(objDiem)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function DanhSachTongHop_DiemRenLuyenTinChi(ByVal dvSv As DataView) As DataView
            Try
                Dim obj As New DiemRenLuyenTinChi
                For i As Integer = 0 To dvSv.Count - 1
                    Dim Diem As Integer = 0
                    Dim count As Integer = 0
                    For j As Integer = 0 To arr.Count - 1
                        obj = arr(j)
                        If obj.ID_sv = dvSv.Item(i)("ID_sv") Then
                            Diem += obj.Diem
                            count += 1
                        End If
                    Next
                    If Diem > 0 Then
                        dvSv.Item(i)("Diem") = Diem / count
                    End If
                Next
                Return dvSv
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSachSinhVien_DiemRenLuyenTinChi(ByVal dtSv As DataTable) As DataTable
            Try
                Dim dt As DataTable
                dt = dtSv.Copy
                dt.Columns.Add("ID_diem_rl")
                dt.Columns.Add("Hoc_ky")
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("ID_mon_tc")
                dt.Columns.Add("Diem")
                Dim obj As New DiemRenLuyenTinChi
                For Each r As DataRow In dt.Rows
                    For j As Integer = 0 To arr.Count - 1
                        obj = arr(j)
                        If obj.ID_sv = r("ID_sv") Then
                            r("ID_diem_rl") = obj.ID_diem_rl
                            r("Hoc_ky") = obj.Hoc_ky
                            r("Nam_hoc") = obj.Nam_hoc
                            r("ID_mon_tc") = obj.ID_mon_tc
                            r("Diem") = obj.Diem
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DiemRenLuyenTinChi() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_diem_rl")
                dt.Columns.Add("Hoc_ky")
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("ID_mon_tc")
                dt.Columns.Add("Diem")
                Dim obj As New DiemRenLuyenTinChi
                Dim r As DataRow
                For i As Integer = 0 To arr.Count - 1
                    obj = arr(i)
                    r = dt.NewRow
                    r("ID_diem_rl") = obj.ID_diem_rl
                    r("Hoc_ky") = obj.Hoc_ky
                    r("Nam_hoc") = obj.Nam_hoc
                    r("ID_sv") = obj.ID_sv
                    r("ID_mon_tc") = obj.ID_mon_tc
                    r("Diem") = obj.Diem
                    dt.Rows.Add(r)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_DiemRenLuyenTinChi(ByVal objDiemRenLuyenTinChi As DiemRenLuyenTinChi) As Integer
            Try
                Dim obj As DiemRenLuyenTinChi_DAL = New DiemRenLuyenTinChi_DAL
                Return obj.Insert_DiemRenLuyenTinChi(objDiemRenLuyenTinChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DiemRenLuyenTinChi(ByVal objDiemRenLuyenTinChi As DiemRenLuyenTinChi) As Integer
            Try
                Dim obj As DiemRenLuyenTinChi_DAL = New DiemRenLuyenTinChi_DAL
                Return obj.Update_DiemRenLuyenTinChi(objDiemRenLuyenTinChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DiemRenLuyenTinChi(ByVal ID_diem_rl As Integer) As Integer
            Try
                Dim obj As DiemRenLuyenTinChi_DAL = New DiemRenLuyenTinChi_DAL
                Return obj.Delete_DiemRenLuyenTinChi(ID_diem_rl)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svDiemRenLuyenTinChi(ByVal objD As DiemRenLuyenTinChi) As Boolean
            Try
                Dim obj As DiemRenLuyenTinChi_DAL = New DiemRenLuyenTinChi_DAL
                obj.CheckExist_DiemRenLuyenTinChi(objD)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drDiemRenLuyenTinChi As DataRow) As DiemRenLuyenTinChi
            Dim result As DiemRenLuyenTinChi
            Try
                result = New DiemRenLuyenTinChi
                If drDiemRenLuyenTinChi("ID_diem_rl").ToString() <> "" Then result.ID_diem_rl = CType(drDiemRenLuyenTinChi("ID_diem_rl").ToString(), Integer)
                If drDiemRenLuyenTinChi("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drDiemRenLuyenTinChi("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drDiemRenLuyenTinChi("Nam_hoc").ToString()
                If drDiemRenLuyenTinChi("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDiemRenLuyenTinChi("ID_sv").ToString(), Integer)
                If drDiemRenLuyenTinChi("ID_mon_tc").ToString() <> "" Then result.ID_mon_tc = CType(drDiemRenLuyenTinChi("ID_mon_tc").ToString(), Integer)
                If drDiemRenLuyenTinChi("Diem").ToString() <> "" Then result.Diem = CType(drDiemRenLuyenTinChi("Diem").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
