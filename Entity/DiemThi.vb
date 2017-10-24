'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Friday, May 02, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace Entity
    Public Class DiemThi
#Region "Constructor"
#End Region

#Region "Var"
        Private mLan_hoc As Integer = 0
        Private mLan_thi As Integer = 0
        Private mDiem_thi As Double = 0
        Private mDiem_chu As String = ""
        Private mDiem_so As Double = -1
        Private mTBCHP As Double = -1
        Private mGhi_chu As String = ""
        Private mHash_code As Integer = 0
        Private mLocked As Integer = 0
        Private mDiemThi As New ArrayList
        Private mDiemThiChiTiet As Generic.List(Of DiemThiChiTiet)
        Public Property DiemThiChiTiet() As Generic.List(Of DiemThiChiTiet)
            Get
                Return mDiemThiChiTiet
            End Get
            Set(ByVal value As Generic.List(Of DiemThiChiTiet))
                mDiemThiChiTiet = value
            End Set
        End Property

#End Region
#Region "Function"
        Public Sub Add(ByVal diem As DiemThi)
            mDiemThi.Add(diem)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mDiemThi.RemoveAt(idx)
        End Sub
        Public Function idx_diem_thi(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Double
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), DiemThi).Lan_hoc = Lan_hoc And _
                    CType(mDiemThi(i), DiemThi).Lan_thi = Lan_thi Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Diem_thi_lan1_view(ByVal Ghi_chu As Boolean) As String
            Dim Diem_thi_view As String = ""
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), DiemThi).Lan_hoc = 1 And _
                   CType(mDiemThi(i), DiemThi).Lan_thi = 1 Then
                    'Diem_thi_view = CType(mDiemThi(i), DiemThi).Diem_thi.ToString
                    If Ghi_chu And CType(mDiemThi(i), DiemThi).Ghi_chu <> "" Then
                        Diem_thi_view = "(" + CType(mDiemThi(i), DiemThi).Ghi_chu + ")"
                    End If
                End If
            Next
            Return Diem_thi_view
        End Function
        Public Function Diem_thi_lan_cac_lan_view(ByVal Ghi_chu As Boolean) As String
            Dim Diem_thi_view As String = ""
            For i As Integer = 0 To mDiemThi.Count - 1
                'Diem_thi_view += CType(mDiemThi(i), DiemThi).Diem_thi.ToString
                If Ghi_chu And CType(mDiemThi(i), DiemThi).Ghi_chu <> "" Then
                    If Diem_thi_view = "" Then
                        Diem_thi_view = "(" + CType(mDiemThi(i), DiemThi).Ghi_chu + ")"
                    Else
                        Diem_thi_view = Diem_thi_view & "-" & "(" + CType(mDiemThi(i), DiemThi).Ghi_chu + ")"
                    End If
                End If
                'Diem_thi_view += "-"
            Next
            'If Diem_thi_view <> "" Then Diem_thi_view = Left(Diem_thi_view, Len(Diem_thi_view) - 1)
            Return Diem_thi_view
        End Function
        Public Function Diem_thi_lan(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Double
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), DiemThi).Lan_hoc = Lan_hoc And _
                   CType(mDiemThi(i), DiemThi).Lan_thi = Lan_thi Then
                    Return CType(mDiemThi(i), DiemThi).Diem_thi
                End If
            Next
            Return -1
        End Function
        Public Function Diem_thi_max(ByVal Lan_hoc As Integer) As Double
            Dim DiemMax As Double = -1
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), DiemThi).Lan_hoc > Lan_hoc And _
                    CType(mDiemThi(i), DiemThi).Diem_thi > DiemMax Then
                    DiemMax = CType(mDiemThi(i), DiemThi).Diem_thi
                End If
            Next
            Return DiemMax
        End Function
        Public Function TBCHP_lan(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Double
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), DiemThi).Lan_hoc = Lan_hoc And _
                    CType(mDiemThi(i), DiemThi).Lan_thi = Lan_thi Then
                    Return CType(mDiemThi(i), DiemThi).TBCHP
                End If
            Next
            Return -1
        End Function
        Public Function TBCHP_max() As Double
            Dim DiemMax As Double = -1
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), DiemThi).TBCHP > DiemMax Then
                    DiemMax = CType(mDiemThi(i), DiemThi).TBCHP
                End If
            Next
            Return DiemMax
        End Function

        Public Function Diem_thi_max() As Double
            Dim DiemThi_Max As Double = -1
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), DiemThi).Diem_thi > DiemThi_Max Then
                    DiemThi_Max = CType(mDiemThi(i), DiemThi).Diem_thi
                End If
            Next
            Return DiemThi_Max
        End Function
        'Public Function TBCHP_CoDiemKhacLan1_max() As Double
        '    Dim DiemMax As Double = -1
        '    For i As Integer = 0 To mDiemThi.Count - 1
        '        If CType(mDiemThi(i), DiemThi).TBCHP > DiemMax And CType(mDiemThi(i), DiemThi).Lan_hoc > 1 Or (CType(mDiemThi(i), DiemThi).Lan_hoc = 1 And CType(mDiemThi(i), DiemThi).Lan_thi > 1) Then
        '            DiemMax = CType(mDiemThi(i), DiemThi).TBCHP
        '        End If
        '    Next
        '    Return DiemMax
        'End Function

        Public Function TBCHP_CoDiemKhacLan1_max() As Double
            Dim DiemMax As Double = -1
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), DiemThi).TBCHP > DiemMax Then
                    DiemMax = CType(mDiemThi(i), DiemThi).TBCHP
                End If
            Next
            Return DiemMax
        End Function
        Public Function TBCHP_max_LanHoc(ByVal Lan_hoc As Integer) As Double
            Dim DiemMax As Double = -1
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), DiemThi).Lan_hoc = Lan_hoc AndAlso CType(mDiemThi(i), DiemThi).TBCHP > DiemMax Then
                    DiemMax = CType(mDiemThi(i), DiemThi).TBCHP
                End If
            Next
            Return DiemMax
        End Function
        Public Function Ghi_chu_lan(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As String
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), DiemThi).Lan_hoc = Lan_hoc And _
                    CType(mDiemThi(i), DiemThi).Lan_thi = Lan_thi Then
                    Return CType(mDiemThi(i), DiemThi).Ghi_chu
                End If
            Next
            Return ""
        End Function
        Public Function Diem_thi_lan_Locked(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Boolean
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), DiemThi).Lan_hoc = Lan_hoc And _
                    CType(mDiemThi(i), DiemThi).Lan_thi = Lan_thi Then
                    Return CType(mDiemThi(i), DiemThi).Locked
                End If
            Next
            Return False
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mDiemThi.Count
            End Get
        End Property
        Public Property DiemThi(ByVal idx As Integer) As DiemThi
            Get
                Return CType(mDiemThi(idx), DiemThi)
            End Get
            Set(ByVal Value As DiemThi)
                mDiemThi(idx) = Value
            End Set
        End Property
        Public Property Lan_hoc() As Integer
            Get
                Return mLan_hoc
            End Get
            Set(ByVal Value As Integer)
                mLan_hoc = Value
            End Set
        End Property
        Public Property Lan_thi() As Integer
            Get
                Return mLan_thi
            End Get
            Set(ByVal Value As Integer)
                mLan_thi = Value
            End Set
        End Property
        Public Property Diem_thi() As Double
            Get
                Return mDiem_thi
            End Get
            Set(ByVal Value As Double)
                mDiem_thi = Value
            End Set
        End Property
        Public Property TBCHP() As Double
            Get
                Return mTBCHP
            End Get
            Set(ByVal Value As Double)
                mTBCHP = Value
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
        Public Property Hash_code() As Integer
            Get
                Return mHash_code
            End Get
            Set(ByVal Value As Integer)
                mHash_code = Value
            End Set
        End Property
        Public Property Locked() As Integer
            Get
                Return mLocked
            End Get
            Set(ByVal Value As Integer)
                mLocked = Value
            End Set
        End Property
        Private mID_diem_thi As Integer
        Public Property ID_diem_thi() As Integer
            Get
                Return mID_diem_thi
            End Get
            Set(ByVal value As Integer)
                mID_diem_thi = value
            End Set
        End Property

#End Region

        Public Sub New()
            Me.DiemThiChiTiet = New Generic.List(Of DiemThiChiTiet)
        End Sub
    End Class
End Namespace
