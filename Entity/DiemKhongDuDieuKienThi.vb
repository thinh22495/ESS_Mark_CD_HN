'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Friday, May 02, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class DiemKhongDuDieuKienThi
#Region "Constructor"
#End Region

#Region "Var"
        Private mLan_hoc As Integer = 0
        Private mKhong_du_dieu_kien_thi As Integer = 0
        Private mLy_do_khong_du_dieu_kien_thi As String = ""
        Private mDiemKDDKThi As New ArrayList
#End Region
#Region "Function"
        Public Sub Add(ByVal kddkThi As DiemKhongDuDieuKienThi)
            mDiemKDDKThi.Add(kddkThi)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mDiemKDDKThi.RemoveAt(idx)
        End Sub
        Public Function Khong_du_dieu_kien_thi_lan(ByVal Lan_hoc As Integer) As Integer
            For i As Integer = 0 To mDiemKDDKThi.Count - 1
                If CType(mDiemKDDKThi(i), DiemKhongDuDieuKienThi).Lan_hoc = Lan_hoc Then
                    Return CType(mDiemKDDKThi(i), DiemKhongDuDieuKienThi).Khong_du_dieu_kien_thi
                End If
            Next
            Return 0
        End Function
        Public Function Ly_do_khong_du_dieu_kien_thi_lan(ByVal Lan_hoc As Integer) As String
            For i As Integer = 0 To mDiemKDDKThi.Count - 1
                If CType(mDiemKDDKThi(i), DiemKhongDuDieuKienThi).Lan_hoc = Lan_hoc Then
                    Return CType(mDiemKDDKThi(i), DiemKhongDuDieuKienThi).Ly_do_khong_du_dieu_kien_thi
                End If
            Next
            Return ""
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mDiemKDDKThi.Count
            End Get
        End Property
        Public Property Lan_hoc() As Integer
            Get
                Return mLan_hoc
            End Get
            Set(ByVal Value As Integer)
                mLan_hoc = Value
            End Set
        End Property
        Public Property Khong_du_dieu_kien_thi() As Integer
            Get
                Return mKhong_du_dieu_kien_thi
            End Get
            Set(ByVal Value As Integer)
                mKhong_du_dieu_kien_thi = Value
            End Set
        End Property
        Public Property Ly_do_khong_du_dieu_kien_thi() As String
            Get
                Return mLy_do_khong_du_dieu_kien_thi
            End Get
            Set(ByVal Value As String)
                mLy_do_khong_du_dieu_kien_thi = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
