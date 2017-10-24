Imports ESS.Entity
Imports ESS.DAL.DBManager
Imports System.Collections.Generic
Namespace Business
    Public Class TongHopChung_HHT_BLL
        Public Function GetTienDoNhapDiem(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsIDLop As String, ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As DataTable
            Dim dtMain As DataTable = New DataTable
            dtMain.Columns.Add("ID_dt", GetType(Integer))
            dtMain.Columns.Add("ID_he", GetType(String))
            dtMain.Columns.Add("Ten_he", GetType(String))
            dtMain.Columns.Add("ID_lop", GetType(String))
            dtMain.Columns.Add("Ten_lop", GetType(String))
            dtMain.Columns.Add("ID_khoa", GetType(String))
            dtMain.Columns.Add("Ten_khoa", GetType(String))
            dtMain.Columns.Add("Khoa_hoc", GetType(String))
            dtMain.Columns.Add("Nien_khoa", GetType(String))
            dtMain.Columns.Add("TongSoMon", GetType(Integer))
            dtMain.Columns.Add("SoMonHoanThanh", GetType(Integer))
            dtMain.Columns.Add("SoMonChuaHoanThanh", GetType(Integer))
            dtMain.Columns.Add("TenMonChuaHoanThanh", GetType(String))
            Try
                Dim cls As New TongHopChung_HHT_DAL
                Dim dv As DataView = cls.GetTienDoNhapDiem(Hoc_ky, Nam_hoc, dsIDLop, Lan_hoc, Lan_thi).DefaultView
                Dim listIDLop() As String = dsIDLop.Split(",")
                For Each s As String In listIDLop
                    dv.RowFilter = "ID_lop=" + s
                    If dv.Count > 0 Then
                        Dim dr As DataRow = dtMain.NewRow
                        dr("ID_dt") = dv(0).Item("ID_dt")
                        dr("ID_he") = dv(0).Item("ID_he")
                        dr("Ten_he") = dv(0).Item("Ten_he")
                        dr("ID_lop") = dv(0).Item("ID_lop")
                        dr("Ten_lop") = dv(0).Item("Ten_lop")
                        dr("ID_khoa") = dv(0).Item("ID_khoa")
                        dr("Ten_khoa") = dv(0).Item("Ten_khoa")
                        dr("Khoa_hoc") = dv(0).Item("Khoa_hoc")
                        dr("Nien_khoa") = dv(0).Item("Nien_khoa")

                        Dim Ky_thu As Integer = getKy(Hoc_ky, Nam_hoc, dv(0).Item("Nien_khoa").ToString)
                        dv.RowFilter = "ID_lop=" + s + " and Ky_thu=" + Ky_thu.ToString
                        Dim dtFilter As DataTable = dv.ToTable
                        Dim dvJoin As DataView = cls.GetTienDoNhapDiem_DiemThi(Hoc_ky, Nam_hoc, dsIDLop, Lan_hoc, Lan_thi).DefaultView
                        dvJoin.RowFilter = "ID_lop=" + s
                        Dim dtJoin As DataTable = dvJoin.ToTable

                        dr("TongSoMon") = dtFilter.Rows.Count
                        dr("SoMonChuaHoanThanh") = 0
                        For Each r As DataRow In dtFilter.Rows
                            If Not check(dtJoin, r("ID_mon").ToString) Then
                                dr("SoMonChuaHoanThanh") = dr("SoMonChuaHoanThanh") + 1
                                dr("TenMonChuaHoanThanh") = dr("TenMonChuaHoanThanh") + r("Ten_mon") + vbCrLf
                            Else
                                For Each r1 As DataRow In dtJoin.Rows
                                    If r1("ID_mon") = r("ID_mon") Then
                                        If r1("Locked").ToString = "0" Or r1("Locked").ToString.Length <= 0 Then
                                            dr("SoMonChuaHoanThanh") = dr("SoMonChuaHoanThanh") + 1
                                            dr("TenMonChuaHoanThanh") = dr("TenMonChuaHoanThanh") + r("Ten_mon") + vbCrLf
                                        End If
                                    End If
                                Next
                            End If


                        Next
                        dr("SoMonHoanThanh") = dr("TongSoMon") - dr("SoMonChuaHoanThanh")
                        dtMain.Rows.Add(dr)
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
            Return dtMain
        End Function
        Function check(ByVal dt As DataTable, ByVal s As String) As Boolean
            For Each dr As DataRow In dt.Rows
                If dr("ID_mon") = s Then
                    Return True
                End If
            Next
            Return False
        End Function
        Public Function getKy(ByVal Hoc_ky As Byte, ByVal Nam_hoc As String, ByVal Nien_khoa As String) As Integer
            Try
                If Nien_khoa <> "" And Nam_hoc <> "" Then
                    Return (CInt(Left(Nam_hoc, 4)) - CInt(Left(Nien_khoa, 4))) * 2 + Hoc_ky
                Else
                    Return -1
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
