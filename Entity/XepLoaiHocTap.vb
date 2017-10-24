'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Monday, June 16, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class XepLoaiHocTap
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_xep_loai As Integer = 0
        Private mXep_loai As String = ""
        Private mTu_diem As Double = 0
        Private mDen_diem As Double = 0
        Private mGhi_chu As String = ""
        Private mXepLoaiHocTap As New ArrayList
#End Region
#Region "Function"
        Public Sub Add(ByVal xeploai As XepLoaiHocTap)
            mXepLoaiHocTap.Add(xeploai)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mXepLoaiHocTap.RemoveAt(idx)
        End Sub
        Public Function XepLoaiHocTap(ByVal TBCHT As Double) As String
            For i As Integer = 0 To mXepLoaiHocTap.Count - 1
                If CType(mXepLoaiHocTap(i), XepLoaiHocTap).Tu_diem <= TBCHT And _
                    CType(mXepLoaiHocTap(i), XepLoaiHocTap).Den_diem > TBCHT Then
                    Return CType(mXepLoaiHocTap(i), XepLoaiHocTap).Xep_loai
                End If
            Next
            Return ""
        End Function
        Public Function IDXepLoaiHocTap(ByVal TBCHT As Double) As String
            For i As Integer = 0 To mXepLoaiHocTap.Count - 1
                If CType(mXepLoaiHocTap(i), XepLoaiHocTap).Tu_diem <= TBCHT And _
                    CType(mXepLoaiHocTap(i), XepLoaiHocTap).Den_diem > TBCHT Then
                    Return CType(mXepLoaiHocTap(i), XepLoaiHocTap).ID_xep_loai
                End If
            Next
            Return 0
        End Function
        Public Function XeploaihoctapHaBac(ByVal TBCHT As Double) As String
            For i As Integer = 0 To mXepLoaiHocTap.Count - 1
                If CType(mXepLoaiHocTap(i), Xeploaihoctap_thangdiem10).Tu_diem <= TBCHT And _
                    CType(mXepLoaiHocTap(i), Xeploaihoctap_thangdiem10).Den_diem > TBCHT Then
                    If i <= 2 And i < mXepLoaiHocTap.Count - 1 Then
                        'Nếu sinh viên vi phạm 2 điều: Số dvht thi lại >20% tongso dvht 
                        'Chi ap dung cho 3 xep loai dau tien: Gioi, Xuat sac va Kha
                        Return CType(mXepLoaiHocTap(i + 1), Xeploaihoctap_thangdiem10).Xep_loai
                    Else
                        Return CType(mXepLoaiHocTap(i), Xeploaihoctap_thangdiem10).Xep_loai
                    End If
                End If
            Next
            Return ""
        End Function
        Public Function IDXepLoaiHocTapHaBac(ByVal TBCHT As Double) As String
            For i As Integer = 0 To mXepLoaiHocTap.Count - 1
                If CType(mXepLoaiHocTap(i), Xeploaihoctap_thangdiem10).Tu_diem <= TBCHT And _
                    CType(mXepLoaiHocTap(i), Xeploaihoctap_thangdiem10).Den_diem > TBCHT Then
                    If i <= 2 And i < mXepLoaiHocTap.Count - 1 Then
                        'Nếu sinh viên vi phạm 2 điều: Số dvht thi lại >20% tongso dvht 
                        'Chi ap dung cho 3 xep loai dau tien: Gioi, Xuat sac va Kha
                        Return CType(mXepLoaiHocTap(i + 1), Xeploaihoctap_thangdiem10).ID_xep_loai
                    Else
                        Return CType(mXepLoaiHocTap(i), Xeploaihoctap_thangdiem10).ID_xep_loai
                    End If
                End If
            Next
            Return 0
        End Function
#End Region
#Region "Property"
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
        Public Property Ghi_chu() As String
            Get
                Return mGhi_chu
            End Get
            Set(ByVal Value As String)
                mGhi_chu = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
