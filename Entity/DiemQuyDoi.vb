'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Tuesday, July 01, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class DiemQuyDoi
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_xep_loai As Integer = 0
        Private mXep_loai As String = ""
        Private mDiem_chu As String = ""
        Private mDiem_so As Double = 0
        Private mTu_diem As Double = 0
        Private mDen_diem As Double = 0
        Private mTich_luy As Boolean = 0
        Private mDiemQuyDoi As New ArrayList
#End Region
#Region "Function"
        Public Sub Add(ByVal DiemQuyDoi As DiemQuyDoi)
            mDiemQuyDoi.Add(DiemQuyDoi)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mDiemQuyDoi.RemoveAt(idx)
        End Sub
        Public Function QuyDoiDiemChu(ByVal TBCMH As Double) As String
            For i As Integer = 0 To mDiemQuyDoi.Count - 1
                If Math.Round(CType(mDiemQuyDoi(i), DiemQuyDoi).Tu_diem, 2) <= TBCMH And _
                    Math.Round(CType(mDiemQuyDoi(i), DiemQuyDoi).Den_diem, 2) > TBCMH Then
                    Return CType(mDiemQuyDoi(i), DiemQuyDoi).Diem_chu
                End If
            Next
            Return ""
        End Function
        Public Function TichLuy(ByVal Diem_chu As String) As Boolean
            For i As Integer = 0 To mDiemQuyDoi.Count - 1
                If CType(mDiemQuyDoi(i), DiemQuyDoi).Diem_chu = Diem_chu Then
                    Return CType(mDiemQuyDoi(i), DiemQuyDoi).Tich_luy
                End If
            Next
            Return False
        End Function

        Public Function IDXepLoaiDiemQuyDoi(ByVal TBCHT As Double) As String
            For i As Integer = 0 To mDiemQuyDoi.Count - 1
                If CType(mDiemQuyDoi(i), DiemQuyDoi).Tu_diem <= TBCHT And _
                    CType(mDiemQuyDoi(i), DiemQuyDoi).Den_diem > TBCHT Then
                    Return CType(mDiemQuyDoi(i), DiemQuyDoi).ID_xep_loai
                End If
            Next
            Return 0
        End Function

        Public Function IDXepLoaiDiemQuyDoiDiemSo(ByVal TBCMH As Double) As String
            For i As Integer = 0 To mDiemQuyDoi.Count - 1
                If CType(mDiemQuyDoi(i), DiemQuyDoi).Diem_so = TBCMH Then
                    Return CType(mDiemQuyDoi(i), DiemQuyDoi).ID_xep_loai
                End If
            Next
            Return 0
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mDiemQuyDoi.Count
            End Get
        End Property
        Public Property DiemQuyDoi(ByVal idx As Integer) As DiemQuyDoi
            Get
                Return CType(mDiemQuyDoi(idx), DiemQuyDoi)
            End Get
            Set(ByVal Value As DiemQuyDoi)
                mDiemQuyDoi(idx) = Value
            End Set
        End Property
        Public Property ID_xep_loai() As Integer
            Get
                Return mID_xep_loai
            End Get
            Set(ByVal Value As Integer)
                mID_xep_loai = Value
            End Set
        End Property
        Public Property Xep_loai() As String
            Get
                Return mXep_loai
            End Get
            Set(ByVal Value As String)
                mXep_loai = Value
            End Set
        End Property
        Public Property Diem_chu() As String
            Get
                Return mDiem_chu
            End Get
            Set(ByVal Value As String)
                mDiem_chu = Value
            End Set
        End Property
        Public Property Diem_so() As Double
            Get
                Return mDiem_so
            End Get
            Set(ByVal Value As Double)
                mDiem_so = Value
            End Set
        End Property
        Public Property Tu_diem() As Double
            Get
                Return mTu_diem
            End Get
            Set(ByVal Value As Double)
                mTu_diem = Value
            End Set
        End Property
        Public Property Den_diem() As Double
            Get
                Return mDen_diem
            End Get
            Set(ByVal Value As Double)
                mDen_diem = Value
            End Set
        End Property
        Public Property Tich_luy() As Boolean
            Get
                Return mTich_luy
            End Get
            Set(ByVal Value As Boolean)
                mTich_luy = Value
            End Set
        End Property
#End Region
    End Class
End Namespace