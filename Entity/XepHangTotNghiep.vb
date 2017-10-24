'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Wednesday, July 02, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class XepHangTotNghiep
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_xep_hang As Integer = 0
        Private mTu_diem As Double = 0
        Private mDen_diem As Double = 0
        Private mXep_hang As String = ""
        Private mXepHangTotNghiep As New ArrayList
#End Region
#Region "Function"
        Public Sub Add(ByVal xephang As XepHangTotNghiep)
            mXepHangTotNghiep.Add(xephang)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mXepHangTotNghiep.RemoveAt(idx)
        End Sub
        Public Function XepHangTotNghiep(ByVal TBCHT As Double, ByVal Ha_XepLoai As Boolean) As String
            For i As Integer = 0 To mXepHangTotNghiep.Count - 1
                If CType(mXepHangTotNghiep(i), XepHangTotNghiep).Tu_diem <= TBCHT And _
                    CType(mXepHangTotNghiep(i), XepHangTotNghiep).Den_diem > TBCHT Then
                    If Ha_XepLoai AndAlso (i <= 1 And i < mXepHangTotNghiep.Count - 1) Then
                        'Nếu sinh viên vi phạm 2 điều: Quá Số học trình thi lại cho phép và Kỷ luật trên mức cảnh cáo 
                        'Chi ap dung cho 2 xep loai dau tien: Gioi va Xuat sac
                        Return CType(mXepHangTotNghiep(i + 1), XepHangTotNghiep).Xep_hang
                    Else
                        Return CType(mXepHangTotNghiep(i), XepHangTotNghiep).Xep_hang
                    End If
                End If
            Next
            Return ""
        End Function

        Function ID_XepHangTotNghiep(ByVal TBCHT As Double, ByVal Ha_XepLoai As Boolean) As Integer
            For i As Integer = 0 To mXepHangTotNghiep.Count - 1
                If CType(mXepHangTotNghiep(i), XepHangTotNghiep).Tu_diem <= TBCHT And _
                    CType(mXepHangTotNghiep(i), XepHangTotNghiep).Den_diem > TBCHT Then
                    If Ha_XepLoai AndAlso (i <= 1 And i < mXepHangTotNghiep.Count - 1) Then
                        'Nếu sinh viên vi phạm 2 điều: Quá Số học trình thi lại cho phép và Kỷ luật trên mức cảnh cáo
                        'Chi ap dung cho 2 xep loai dau tien: Gioi va Xuat sac
                        Return CType(mXepHangTotNghiep(i + 1), XepHangTotNghiep).ID_xep_hang
                    Else
                        Return CType(mXepHangTotNghiep(i), XepHangTotNghiep).ID_xep_hang
                    End If
                End If
            Next
            Return -1
        End Function
#End Region
#Region "Property"
        Public Property ID_xep_hang() As Integer
            Get
                Return mID_xep_hang
            End Get
            Set(ByVal Value As Integer)
                mID_xep_hang = Value
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
        Public Property Xep_hang() As String
            Get
                Return mXep_hang
            End Get
            Set(ByVal Value As String)
                mXep_hang = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
