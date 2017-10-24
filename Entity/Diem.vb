'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Friday, May 02, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class Diem
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_diem As Integer = 0
        Private mID_dv As String = ""
        Private mID_sv As Integer = 0
        Private mID_mon As Integer = 0
        Private mSo_tiet As Integer = 0
        Private mSo_tiet_th As Integer = 0 'So tiet thuc hanh
        Private mID_dt As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mNo_mon As Integer = 0
        Private mDiemDanh As New DiemDanh
        Private mDiemThanhPhan As New DiemThanhPhan
        Private mDiemThi As New DiemThi
        Private mDiemKhongDuDKThi As New DiemKhongDuDieuKienThi
        Private mDiemHocLai As New DiemHocLai
        Private mDiemThiLai As New DiemThiLai
#End Region

#Region "Property"
        Public Property ID_diem() As Integer
            Get
                Return mID_diem
            End Get
            Set(ByVal Value As Integer)
                mID_diem = Value
            End Set
        End Property
        Public Property ID_dv() As String
            Get
                Return mID_dv
            End Get
            Set(ByVal Value As String)
                mID_dv = Value
            End Set
        End Property
        Public Property ID_sv() As Integer
            Get
                Return mID_sv
            End Get
            Set(ByVal Value As Integer)
                mID_sv = Value
            End Set
        End Property
        Public Property ID_mon() As Integer
            Get
                Return mID_mon
            End Get
            Set(ByVal Value As Integer)
                mID_mon = Value
            End Set
        End Property
        Public Property So_tiet() As Integer
            Get
                Return mSo_tiet
            End Get
            Set(ByVal Value As Integer)
                mSo_tiet = Value
            End Set
        End Property

        Public Property So_tiet_th() As Integer
            Get
                Return mSo_tiet_th
            End Get
            Set(ByVal Value As Integer)
                mSo_tiet_th = Value
            End Set
        End Property
        Public Property ID_dt() As Integer
            Get
                Return mID_dt
            End Get
            Set(ByVal Value As Integer)
                mID_dt = Value
            End Set
        End Property
        Public Property Hoc_ky() As Integer
            Get
                Return mHoc_ky
            End Get
            Set(ByVal Value As Integer)
                mHoc_ky = Value
            End Set
        End Property
        Public Property Nam_hoc() As String
            Get
                Return mNam_hoc
            End Get
            Set(ByVal Value As String)
                mNam_hoc = Value
            End Set
        End Property
        Public Property dsDiemDanh() As DiemDanh
            Get
                Return mDiemDanh
            End Get
            Set(ByVal Value As DiemDanh)
                mDiemDanh = Value
            End Set
        End Property
        Public Property dsDiemThanhPhan() As DiemThanhPhan
            Get
                Return mDiemThanhPhan
            End Get
            Set(ByVal Value As DiemThanhPhan)
                mDiemThanhPhan = Value
            End Set
        End Property
        Public Property dsDiemThi() As DiemThi
            Get
                Return mDiemThi
            End Get
            Set(ByVal Value As DiemThi)
                mDiemThi = Value
            End Set
        End Property
        Public Property dsDiemKhongDuDKThi() As DiemKhongDuDieuKienThi
            Get
                Return mDiemKhongDuDKThi
            End Get
            Set(ByVal Value As DiemKhongDuDieuKienThi)
                mDiemKhongDuDKThi = Value
            End Set
        End Property
        Public Property dsDiemHocLai() As DiemHocLai
            Get
                Return mDiemHocLai
            End Get
            Set(ByVal Value As DiemHocLai)
                mDiemHocLai = Value
            End Set
        End Property
        Public Property dsDiemThiLai() As DiemThiLai
            Get
                Return mDiemThiLai
            End Get
            Set(ByVal Value As DiemThiLai)
                mDiemThiLai = Value
            End Set
        End Property
        Public ReadOnly Property Check_hien_thi(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Boolean
            Get
                If Lan_hoc = 1 Then
                    'Chỉ hiển thị những sinh viên thi lại
                    If Lan_thi > 1 Then
                        If dsDiemThiLai.Thi_lai_lan(Lan_hoc, Lan_thi - 1) > 0 And dsDiemKhongDuDKThi.Khong_du_dieu_kien_thi_lan(Lan_hoc) = 0 Then
                            If (dsDiemThiLai.Thi_lai_lan(Lan_hoc, Lan_thi - 1) > 0 And dsDiemThi.Ghi_chu_lan(Lan_hoc, Lan_thi - 1) <> "K") Then
                                Return True
                            End If
                        End If
                    End If
                Else
                    'Chỉ hiển thị những sinh viên học lại
                    If dsDiemKhongDuDKThi.Khong_du_dieu_kien_thi_lan(Lan_hoc - 1) Or (Lan_thi > 1 AndAlso dsDiemThiLai.Thi_lai_lan(Lan_hoc, Lan_thi - 1) > 0 And dsDiemThi.Ghi_chu_lan(Lan_hoc, Lan_thi - 1) <> "K") Or (Lan_thi = 1 AndAlso dsDiemHocLai.Hoc_lai_lan(Lan_hoc - 1)) Then
                        Return True
                    End If
                End If
                Return False
            End Get
        End Property

        Public ReadOnly Property Check_hien_thi(ByVal Lan_hoc As Integer) As Boolean
            Get
                If dsDiemKhongDuDKThi.Khong_du_dieu_kien_thi_lan(Lan_hoc - 1) Or dsDiemHocLai.Hoc_lai_lan(Lan_hoc - 1) Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_R() As Boolean
            Get
                If dsDiemThi.Count > 0 Then
                    If dsDiemThi.DiemThi(0).Ghi_chu.ToUpper = "R" Then
                        Return True
                    End If
                End If
                Return False
            End Get
        End Property
        '----------------Các ghi chú Fix, cần sửa khi đi triển khai--------------------------
        Public ReadOnly Property GhiChu_KhongDuDKDT(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_hoc, Lan_thi).ToUpper = "K" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_CanhCao(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_hoc, Lan_thi).ToUpper = "C" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_BaoLuu(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_hoc, Lan_thi).ToUpper = "B" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_DinhChi(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_hoc, Lan_thi).ToUpper = "D" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_HSGioi(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_hoc, Lan_thi).ToUpper = "G" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_MienThi(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_hoc, Lan_thi).ToUpper = "M" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_ThiOlympic(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_hoc, Lan_thi).ToUpper = "O" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_VangThiCoPhep(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_hoc, Lan_thi).ToUpper = "P" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_VangThiKoPhep(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_hoc, Lan_thi).ToUpper = "V" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_KhienTrach(ByVal Lan_hoc As Integer, ByVal Lan_thi As Integer) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_hoc, Lan_thi).ToUpper = "T" Then
                    Return True
                End If
                Return False
            End Get
        End Property

#End Region
    End Class
End Namespace
