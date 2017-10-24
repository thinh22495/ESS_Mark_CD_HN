Imports ESS.BLL.Business
Module EnumNConst
    Public Ngay_tuan As Integer = Thu_ket_thuc - Thu_bat_dau + 1
    Public So_tiet_ca As Integer
    Public So_tiet_ngay As Integer
    Public Tong_so_sk_tuan_ca As Integer
    Public So_ca_hoc As Integer
    Public Nhom_tiet_donvi As Integer
    Public Thu_bat_dau As eTHU
    Public Thu_ket_thuc As eTHU
    Public Distance As Integer = 2
    Public Sub Doc_tham_so_he_thong()
        Try
            Thu_bat_dau = Doc_tham_so("Thu_bat_dau")
            Thu_ket_thuc = Doc_tham_so("Thu_ket_thuc")
            So_tiet_ca = Doc_tham_so("So_tiet_ca")
            So_ca_hoc = Doc_tham_so("So_ca_hoc")
            So_tiet_ngay = Doc_tham_so("So_tiet_ngay")
            Nhom_tiet_donvi = Doc_tham_so("Nhom_tiet_donvi")
            Distance = Doc_tham_so("Distance")
            Ngay_tuan = Thu_ket_thuc - Thu_bat_dau + 1
            Tong_so_sk_tuan_ca = Ngay_tuan * 2
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function Doc_tham_so(ByVal key As String) As Object
        Try
            Dim cls As New ThamSoHeThong_BLL
            Return cls.Doc_tham_so(key)
        Catch ex As Exception
            Throw New Exception("KeyName:" & key & vbCrLf & ex.Message)
        End Try
    End Function
End Module

Public Enum eCA_HOC As Integer
    KHONG_XAC_DINH = -1

    SANG = 0
    CHIEU = 1
    TOI = 2
End Enum

Public Enum eLOAI_TIET As Integer
    KHONG_XAC_DINH = -1

    LY_THUYET = 0
    THUC_HANH = 1
End Enum
Public Enum eTHU As Integer
    KHONG_XAC_DINH = -1

    THU_HAI = 0
    THU_BA = 1
    THU_TU = 2
    THU_NAM = 3
    THU_SAU = 4
    THU_BAY = 5
    CHU_NHAT = 6
End Enum
Public Enum REPORT_TYPE As Integer
    THEO_SUKIEN = 1
    THEO_PHONG = 2
    THEO_LOP = 3
    THEO_GIAOVIEN = 4
End Enum
Public Class my_Cell
    Private _row As Integer
    Private _col As Integer
    Public Sub New()
        _row = -1
        _col = -1
    End Sub
    Public Sub New(ByVal row As Integer, ByVal col As Integer, ByVal copy As Boolean)
        _row = row
        _col = col
    End Sub
    Public Property Row() As Integer
        Get
            Return _row
        End Get
        Set(ByVal Value As Integer)
            _row = Value
        End Set
    End Property
    Public Property Col() As Integer
        Get
            Return _col
        End Get
        Set(ByVal Value As Integer)
            _col = Value
        End Set
    End Property
End Class


