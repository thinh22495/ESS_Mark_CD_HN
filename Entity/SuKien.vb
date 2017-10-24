Namespace Entity
    Public Class Su_kien
        Private _ID As Long
        Private _ID_kh_tuan As Integer
        Private _ID_phong As Integer
        Private _ID_mon As Integer
        Private _ID_bm As Integer
        Private _ID_cb As Integer
        Private _ID_lop As Integer
        Private _Ten_phong As String
        Private _Ky_hieu As String
        Private _Ten_mon As String
        Private _Ten As String
        Private _Hoten_giaovien As String
        Private _Ten_lop As String
        Private _Ca_hoc As eCA_HOC
        Private _Thu As eTHU
        Private _Tiet As Integer
        Private _So_tiet As Integer
        Private _Loai_tiet As eLOAI_TIET
        Private _Top_thu As Integer
        Private _Da_xep_lich As Boolean
        Private _Thieu_dulieu As Boolean
        Private _Locked As Boolean

        Public Sub New()
            Me._ID = -1
            Me._ID_kh_tuan = -1
            Me._ID_phong = -1
            Me._ID_mon = -1
            Me._ID_bm = -1
            Me._ID_cb = -1
            Me._ID_lop = -1
            Me._Ten_phong = ""
            Me._Ky_hieu = ""
            Me._Ten_mon = ""
            Me._Ten = ""
            Me._Hoten_giaovien = ""
            Me._Ten_lop = ""
            Me._Ca_hoc = eCA_HOC.KHONG_XAC_DINH
            Me._Thu = eTHU.KHONG_XAC_DINH
            Me._Tiet = -1
            Me._So_tiet = 0
            Me._Loai_tiet = eLOAI_TIET.KHONG_XAC_DINH
            Me._Top_thu = 0
            Me._Da_xep_lich = False
            Me._Thieu_dulieu = False
            Me._Locked = False
        End Sub

        Public Sub New(ByVal ID As Long, ByVal ID_kh_tuan As Integer, ByVal ID_phong As Integer, _
           ByVal ID_mon As Integer, ByVal ID_bm As Integer, ByVal _ID_cb As Integer, _
           ByVal ID_lop As Integer, ByVal Ten_phong As String, _
           ByVal Ten_mon As String, ByVal Ten_giaovien As String, ByVal Hoten_giaovien As String, _
           ByVal Ten_lop As String, ByVal Ca_hoc As eCA_HOC, _
           ByVal Thu As eTHU, ByVal Tiet As Integer, _
           ByVal So_tiet As Integer, ByVal Loai_tiet As eLOAI_TIET, ByVal Top_thu As Integer, ByVal Ky_hieu As String, _
           ByVal Da_xep_lich As Boolean, ByVal Locked As Boolean)

            Me._ID = ID
            Me._ID_kh_tuan = ID_kh_tuan
            Me._ID_phong = ID_phong
            Me._ID_mon = ID_mon
            Me._ID_bm = ID_bm
            Me._ID_cb = _ID_cb
            Me._ID_lop = ID_lop
            Me._Ten_phong = Ten_phong
            Me._Ky_hieu = Ky_hieu
            Me._Ten_mon = Ten_mon
            Me._Ten = Ten_giaovien
            Me._Hoten_giaovien = Hoten_giaovien
            Me._Ten_lop = Ten_lop
            Me._Ca_hoc = Ca_hoc
            Me._Thu = Thu
            Me._Tiet = Tiet
            Me._So_tiet = So_tiet
            Me._Loai_tiet = Loai_tiet
            Me._Top_thu = Top_thu
            Me._Da_xep_lich = Da_xep_lich
            Me._Thieu_dulieu = False
            Me._Locked = Locked
        End Sub

        Public Property ID() As Long
            Get
                Return Me._ID
            End Get
            Set(ByVal Value As Long)
                Me._ID = Value
            End Set
        End Property
        Public Property ID_kh_tuan() As Long
            Get
                Return Me._ID_kh_tuan
            End Get
            Set(ByVal Value As Long)
                Me._ID_kh_tuan = Value
            End Set
        End Property
        Public Property ID_lop() As Integer
            Get
                Return Me._ID_lop
            End Get
            Set(ByVal Value As Integer)
                Me._ID_lop = Value
            End Set
        End Property
        Public Property ID_phong() As Integer
            Get
                Return Me._ID_phong
            End Get
            Set(ByVal Value As Integer)
                Me._ID_phong = Value
            End Set
        End Property
        Public Property ID_cb() As Integer
            Get
                Return Me._ID_cb
            End Get
            Set(ByVal Value As Integer)
                Me._ID_cb = Value
            End Set
        End Property
        Public Property ID_mon() As Integer
            Get
                Return Me._ID_mon
            End Get
            Set(ByVal Value As Integer)
                Me._ID_mon = Value
            End Set
        End Property
        Public Property ID_bm() As Integer
            Get
                Return Me._ID_bm
            End Get
            Set(ByVal Value As Integer)
                Me._ID_bm = Value
            End Set
        End Property
        Public Property Ten_lop() As String
            Get
                Return Me._Ten_lop
            End Get
            Set(ByVal Value As String)
                Me._Ten_lop = Value
            End Set
        End Property
        Public Property Ten_phong() As String
            Get
                Return Me._Ten_phong
            End Get
            Set(ByVal Value As String)
                Me._Ten_phong = Value
            End Set
        End Property
        Public Property Ten() As String
            Get
                Return Me._Ten
            End Get
            Set(ByVal Value As String)
                Me._Ten = Value
            End Set
        End Property

        Public Property Hoten_giaovien() As String
            Get
                Return Me._Hoten_giaovien
            End Get
            Set(ByVal Value As String)
                Me._Hoten_giaovien = Value
            End Set
        End Property

        Public Property Ky_hieu() As String
            Get
                Return Me._Ky_hieu
            End Get
            Set(ByVal Value As String)
                Me._Ky_hieu = Value
            End Set
        End Property
        Public Property Ten_mon() As String
            Get
                Return Me._Ten_mon
            End Get
            Set(ByVal Value As String)
                Me._Ten_mon = Value
            End Set
        End Property
        Public Property Ca_hoc() As eCA_HOC
            Get
                Return Me._Ca_hoc
            End Get
            Set(ByVal Value As eCA_HOC)
                Me._Ca_hoc = Value
            End Set
        End Property
        Public Property Thu() As eTHU
            Get
                Return Me._Thu
            End Get
            Set(ByVal Value As eTHU)
                Me._Thu = Value
            End Set
        End Property
        Public Property Tiet() As Integer
            Get
                Return Me._Tiet
            End Get
            Set(ByVal Value As Integer)
                Me._Tiet = Value
            End Set
        End Property
        Public Property So_tiet() As Integer
            Get
                Return Me._So_tiet
            End Get
            Set(ByVal Value As Integer)
                Me._So_tiet = Value
            End Set
        End Property
        Public Property Loai_tiet() As eLOAI_TIET
            Get
                Return Me._Loai_tiet
            End Get
            Set(ByVal Value As eLOAI_TIET)
                Me._Loai_tiet = Value
            End Set
        End Property
        Public Property Top_thu() As Integer
            Get
                Return Me._Top_thu
            End Get
            Set(ByVal Value As Integer)
                Me._Top_thu = Value
            End Set
        End Property
        Public Property Da_xep_lich() As Boolean
            Get
                Return Me._Da_xep_lich
            End Get
            Set(ByVal Value As Boolean)
                Me._Da_xep_lich = Value
            End Set
        End Property
        Public Property Thieu_dulieu() As Boolean
            Get
                Return Me._Thieu_dulieu
            End Get
            Set(ByVal Value As Boolean)
                Me._Thieu_dulieu = Value
            End Set
        End Property
        Public Property Locked() As Boolean
            Get
                Return Me._Locked
            End Get
            Set(ByVal Value As Boolean)
                Me._Locked = Value
            End Set
        End Property
        Public Function Clone() As Su_kien
            Dim sk As New Su_kien

            sk.ID = Me.ID
            sk.ID_kh_tuan = Me.ID_kh_tuan
            sk.ID_phong = Me.ID_phong
            sk.ID_mon = Me.ID_mon
            sk.ID_bm = Me.ID_bm
            sk.ID_cb = Me.ID_cb
            sk.ID_lop = Me.ID_lop
            sk.Ten_phong = Me.Ten_phong
            sk.Ky_hieu = Me.Ky_hieu
            sk.Ten_mon = Me.Ten_mon
            sk.Ten = Me.Ten
            sk.Hoten_giaovien = Me.Hoten_giaovien
            sk.Ten_lop = Me.Ten_lop
            sk.Ca_hoc = Me.Ca_hoc
            sk.Thu = Me.Thu
            sk.Tiet = Me.Tiet
            sk.So_tiet = Me.So_tiet
            sk.Loai_tiet = Me.Loai_tiet
            sk.Top_thu = Me.Top_thu
            sk.Da_xep_lich = Me.Da_xep_lich
            sk.Thieu_dulieu = Me.Thieu_dulieu
            sk.Locked = Me.Locked
            Return sk
        End Function
    End Class
End Namespace