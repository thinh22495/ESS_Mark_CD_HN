'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : 04/21/2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class VaiTro
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_vai_tro As Integer = 0
        Private mTen_vai_tro As String = ""
        Private mMo_ta As String = ""
        Private mVaiTroQuyen As New VaiTroQuyen
        Private mVaiTro As New ArrayList
#End Region
        Public Sub Add(ByVal vaiTro As VaiTro)
            mVaiTro.Add(vaiTro)
        End Sub
        Public Sub Remove(ByVal idx_vai_tro As Integer)
            mVaiTro.RemoveAt(idx_vai_tro)
        End Sub
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mVaiTro.Count
            End Get
        End Property
        Public Property VaiTro(ByVal idx As Integer) As VaiTro
            Get
                Return CType(mVaiTro(idx), VaiTro)
            End Get
            Set(ByVal Value As VaiTro)
                mVaiTro(idx) = Value
            End Set
        End Property
        Public Property ID_vai_tro() As Integer
            Get
                Return mID_vai_tro
            End Get
            Set(ByVal Value As Integer)
                mID_vai_tro = Value
            End Set
        End Property
        Public Property Ten_vai_tro() As String
            Get
                Return mTen_vai_tro
            End Get
            Set(ByVal Value As String)
                mTen_vai_tro = Value
            End Set
        End Property
        Public Property Mo_ta() As String
            Get
                Return mMo_ta
            End Get
            Set(ByVal Value As String)
                mMo_ta = Value
            End Set
        End Property
        Public Property VaiTroQuyen() As VaiTroQuyen
            Get
                Return mVaiTroQuyen
            End Get
            Set(ByVal Value As VaiTroQuyen)
                mVaiTroQuyen = Value
            End Set
        End Property

        'Public Function DanhSachVaiTroQuyen() As DataTable
        '    Dim dt As New DataTable
        '    dt.Columns.Add("Chon", GetType(Boolean))
        '    dt.Columns.Add("ID_ph", GetType(Integer))
        '    dt.Columns.Add("ID_Quyen", GetType(Integer))
        '    dt.Columns.Add("Ten_Quyen", GetType(String))
        '    dt.Columns.Add("Them", GetType(Boolean))
        '    dt.Columns.Add("Sua", GetType(Boolean))
        '    dt.Columns.Add("Xoa", GetType(Boolean))
        '    For i As Integer = 0 To VaiTroQuyen.Count - 1
        '        Dim gvaitroquyen As VaiTroQuyen = CType(VaiTroQuyen.VaiTroQuyen(i), VaiTroQuyen)
        '        Dim row As DataRow = dt.NewRow()
        '        row("Chon") = False
        '        row("ID_ph") = gvaitroquyen.ID_ph
        '        row("ID_Quyen") = gvaitroquyen.ID_quyen
        '        row("Ten_Quyen") = gvaitroquyen.Ten_quyen
        '        row("Them") = False
        '        row("Sua") = False
        '        row("Xoa") = False
        '        dt.Rows.Add(row)
        '    Next
        '    Return dt
        'End Function
#End Region
    End Class
End Namespace
