Imports System
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class LopTKB_BLL
        Dim alops As ArrayList
        Public Sub New(ByVal ID_kh_tuan As Integer)
            Try
                Dim clsLop As New LopTKB_DAL
                alops = New ArrayList

                Dim dt As DataTable = clsLop.Load_LopTKB_List(ID_kh_tuan)

                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim ID_lop As Integer = CInt(dt.Rows(i)("ID_lop"))
                    Dim ID_lop_khoi As Integer = CInt("0" + dt.Rows(i)("ID_lop_khoi").ToString)
                    Dim ID_khoa As Integer = CInt(dt.Rows(i)("ID_khoa"))
                    Dim Ten_lop As String = dt.Rows(i)("Ten_lop").ToString()
                    Dim So_sv As String = CInt(IIf(dt.Rows(i)("So_sv").ToString = "", 0, dt.Rows(i)("So_sv").ToString))
                    Dim Ca_hoc As String = CInt(IIf(dt.Rows(i)("Ca_hoc").ToString = "", 0, dt.Rows(i)("Ca_hoc").ToString))
                    Dim Ten_phong As String = dt.Rows(i)("So_phong").ToString
                    Dim khoi As Boolean = dt.Rows(i)("khoi")
                    Dim lp As New Lop(Ngay_tuan, So_tiet_ngay, ID_lop, ID_lop_khoi, ID_khoa, Ten_lop, Ca_hoc, So_sv, khoi, Ten_phong)
                    alops.Add(lp)
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub
        Public Function Tim_Ten_lop(ByVal ID_lop As Integer) As String
            For i As Integer = 0 To alops.Count - 1
                Dim lp As Lop = CType(alops(i), Lop)
                If lp.ID_lop = ID_lop Then
                    Return lp.Ten_lop
                End If
            Next
            Return ""
        End Function
        Public Function Tim_ID_lop(ByVal Ten_lop As String) As Integer
            For i As Integer = 0 To alops.Count - 1
                Dim lp As Lop = CType(alops(i), Lop)
                If lp.Ten_lop = Ten_lop Then
                    Return lp.ID_lop
                End If
            Next
            Return -1
        End Function
        Public Function Tim_chi_so(ByVal Ten_lop As String) As Integer
            For i As Integer = 0 To alops.Count - 1
                Dim lp As Lop = CType(alops(i), Lop)
                If lp.Ten_lop = Ten_lop Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Tim_chi_so(ByVal ID_lop As Integer) As Integer
            For i As Integer = 0 To alops.Count - 1
                Dim lp As Lop = CType(alops(i), Lop)
                If lp.ID_lop = ID_lop Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.alops.Count
            End Get
        End Property
        Public Property Lop(ByVal idx As Integer) As Lop
            Get
                Return CType(Me.alops(idx), Lop)
            End Get
            Set(ByVal Value As Lop)
                Me.alops(idx) = Value
            End Set
        End Property
    End Class
End Namespace

