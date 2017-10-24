'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Saturday, May 03, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class DanhSach_BLL        
        Private mID_lop As Integer
        Private arrHocBu As New ArrayList
        Private arrBoiHoan As New ArrayList
#Region "Constructor"
        Public Sub New()
        End Sub
        Public Sub New(ByVal ID_lop As Integer)
            mID_lop = ID_lop
        End Sub
        ' Danh sách Xác định sinh viên học bù
        Public Sub New(ByVal ID_lop As String)
            Try
                Dim dtHocBu As DataTable
                Dim obj As New DanhSach_DAL
                dtHocBu = obj.Load_DanhSach_HocBu(ID_lop)
                Dim objDS As New DanhSach
                For Each r As DataRow In dtHocBu.Rows
                    objDS = Converting_SinhVien_HocBu(r)
                    arrHocBu.Add(objDS)
                Next                
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        ' Danh sách Bồi hoàn kinh phí đào tạo
        Public Sub New(ByVal ID_lop As String, ByVal BoiHoan As Boolean)
            Try
                Dim dtBoiHoan As DataTable
                Dim obj As New DanhSach_DAL
                dtBoiHoan = obj.Load_DanhSach_BoiHoan(ID_lop)
                Dim objDS As New DanhSach
                For Each r As DataRow In dtBoiHoan.Rows
                    objDS = Converting_SinhVien_BoiHoan(r)
                    arrBoiHoan.Add(objDS)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"        
        Public Function GetMa_sv() As String
            Dim ID_he As Integer = 0
            Dim ID_khoa As Integer = 0
            Dim Khoa_hoc As Integer = 0
            Dim ID_cn As Integer = 0
            Dim Max_ma As String = ""
            Dim strBegin As String = ""
            Dim strEnd As String = ""
            Dim strMa As String = ""
            Dim Arr() As String = Nothing
            Dim tmp As Double
            Dim i As Integer
            Try
                MaSV_Max(Arr, strBegin, strEnd)
                tmp = Arr(0)
                For i = 1 To Arr.Length - 1
                    If tmp < Arr(i) Then tmp = Arr(i)
                Next
                strMa = strBegin & tmp + 1 & strEnd
                If strMa.Length > 20 Then
                    MsgBox("Do mã phức tạp nên chương trình không sinh mã tự động được!")
                    strMa = ""
                End If
                Return strMa
            Catch ex As Exception
                Return ""
            End Try
        End Function
        Public Sub MaSV_Max(ByRef Arr() As String, ByRef strBegin As String, ByRef strEnd As String)
            Dim Xau As String
            Dim i As Integer = Nothing
            Dim j As Integer = Nothing
            Dim Pos As Integer = Nothing
            Dim objDanhSach_DAL As New DanhSach_DAL
            Dim objDanhSach As New DanhSach
            Dim dt As DataTable = objDanhSach_DAL.Load_DanhSach(mID_lop)
            If dt.Rows.Count <= 0 Then Exit Sub
            Xau = ""
            strEnd = ""
            strBegin = ""
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("Ma_SV").ToString <> "" Then
                    Dim flg As Byte = 0
                    Dim MaSV_tmp As String = dt.Rows(i).Item("Ma_SV").ToString
                    For j = 1 To Len(MaSV_tmp)
                        'Cuối xâu bắt đầu là kí tự chữ
                        If flg = 0 And Not IsNumeric(Right(MaSV_tmp, j)) Then
                            MaSV_tmp = Left(MaSV_tmp, Len(MaSV_tmp) - 1)
                            strEnd = Right(dt.Rows(i).Item("Ma_SV").ToString, j)
                        End If
                        If IsNumeric(Right(MaSV_tmp, j)) Then flg = 1 'Gặp kí tự dạng số
                        If flg = 1 And Not IsNumeric(Right(MaSV_tmp, j)) Then 'Gặp ký tự chữ
                            flg = 2
                            strBegin = Left(MaSV_tmp, Len(Right(MaSV_tmp, j - 1)))
                            Exit For
                        End If
                    Next
                    If flg = 2 Then 'Xâu có chứa ký tự ở đầu xâu
                        If Xau.Trim = "" Then
                            Xau = Right(Right(MaSV_tmp, j), Len(Right(MaSV_tmp, j)) - 1)
                        Else
                            Xau = Xau & "," & Right(Right(MaSV_tmp, j), Len(Right(MaSV_tmp, j)) - 1)
                        End If
                    Else 'Tất cả xâu là số
                        If Xau.Trim = "" Then
                            Xau = Right(MaSV_tmp, j)
                        Else
                            Xau = Xau & "," & Right(MaSV_tmp, j)
                        End If
                    End If
                End If
                'For j = Len(dt.Rows(i).Item("Ma_SV")) To 0 Step -1
            Next
            Arr = Split(Xau, ",", , CompareMethod.Binary)
        End Sub
        Public Function Insert_DanhSach(ByVal objDanhSach As DanhSach) As Integer
            Try
                Dim obj As DanhSach_DAL = New DanhSach_DAL
                Return obj.Insert_DanhSach(objDanhSach)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSach(ByVal objDanhSach As DanhSach, ByVal ID_svs As String, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As DanhSach_DAL = New DanhSach_DAL
                Return obj.Update_DanhSach(objDanhSach, ID_svs, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSach_NhapHoc(ByVal objDanhSach As DanhSach, ByVal ID_svs As String, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As DanhSach_DAL = New DanhSach_DAL
                Return obj.Update_DanhSach_NhapHoc(objDanhSach, ID_svs, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSach(ByVal ID_sv As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As DanhSach_DAL = New DanhSach_DAL
                Return obj.Delete_DanhSach(ID_sv, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSach_SinhVien(ByVal ID_lop As String) As Integer
            Try
                Dim obj As DanhSach_DAL = New DanhSach_DAL
                Return obj.Delete_DanhSach_SinhVien(ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drDanhSach As DataRow) As DanhSach
            Dim result As DanhSach
            Try
                result = New DanhSach
                If drDanhSach("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSach("ID_sv").ToString(), Integer)
                If drDanhSach("Ma_sv").ToString() <> "" Then result.Ma_sv = CType(drDanhSach("Ma_sv").ToString(), String)
                If drDanhSach("ID_lop").ToString() <> "" Then result.ID_lop = CType(drDanhSach("ID_lop").ToString(), Integer)
                result.Mat_khau = drDanhSach("Mat_khau").ToString()
                result.Active = drDanhSach("Active").ToString()
                result.Da_tot_nghiep = drDanhSach("Da_tot_nghiep").ToString()
                result.Ma_sv = drDanhSach("Ma_sv").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function        
#End Region
#Region "Function Danh Sach Hoc Bu"
        Public Function Insert_DanhSach_HocBu(ByVal objDanhSach As DanhSach) As Integer
            Try
                Dim obj As DanhSach_DAL = New DanhSach_DAL
                Return obj.Insert_DanhSach_HocBu(objDanhSach)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSach_HocBu(ByVal objDanhSach As DanhSach) As Integer
            Try
                Dim obj As DanhSach_DAL = New DanhSach_DAL
                Return obj.Update_DanhSach_HocBu(objDanhSach)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSach_HocBu(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                Dim obj As DanhSach_DAL = New DanhSach_DAL
                Return obj.Delete_DanhSach_HocBu(ID_sv, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExits_DanhSach_HocBu(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Try
                Dim obj As DanhSach_DAL = New DanhSach_DAL
                Return obj.CheckExits_DanhSach_HocBu(ID_sv, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSach_HocBu(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("ID_lop")
                dt.Columns.Add("Ten_lop")
                dt.Columns.Add("So_tiet_hoc_bu")
                dt.Columns.Add("So_tien_hoc_bu", GetType(Double))
                dt.Columns.Add("Hoc_ky")
                dt.Columns.Add("Nam_hoc")
                Dim r As DataRow
                Dim obj As New DanhSach
                For i As Integer = 0 To arrHocBu.Count - 1
                    obj = arrHocBu.Item(i)
                    If obj.Hoc_ky = Hoc_ky And obj.Nam_hoc = Nam_hoc Then
                        r = dt.NewRow
                        r("Chon") = False
                        r("ID_sv") = obj.ID_sv
                        r("Ma_sv") = obj.Ma_sv
                        r("Ho_ten") = obj.Ho_ten
                        r("Ngay_sinh") = obj.Ngay_sinh
                        r("ID_lop") = obj.ID_lop
                        r("Ten_lop") = obj.Ten_lop
                        r("Hoc_ky") = obj.Hoc_ky
                        r("Nam_hoc") = obj.Nam_hoc
                        r("So_tien_hoc_bu") = Format(obj.So_tien_hoc_bu, "###,###")
                        r("So_tiet_hoc_bu") = obj.So_tiet_hoc_bu
                        dt.Rows.Add(r)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting_SinhVien_HocBu(ByVal drDanhSach As DataRow) As DanhSach
            Dim result As DanhSach
            Try
                result = New DanhSach
                If drDanhSach("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSach("ID_sv").ToString(), Integer)
                If drDanhSach("Ho_ten").ToString() <> "" Then result.Ho_ten = CType(drDanhSach("Ho_ten").ToString(), String)
                If drDanhSach("Ma_sv").ToString() <> "" Then result.Ma_sv = CType(drDanhSach("Ma_sv").ToString(), String)
                If drDanhSach("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSach("Ngay_sinh").ToString(), String)
                If drDanhSach("ID_lop").ToString() <> "" Then result.ID_lop = CType(drDanhSach("ID_lop").ToString(), Integer)
                If drDanhSach("Ten_lop").ToString() <> "" Then result.Ten_lop = CType(drDanhSach("Ten_lop").ToString(), String)
                If drDanhSach("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drDanhSach("Hoc_ky").ToString(), Integer)
                If drDanhSach("Nam_hoc").ToString() <> "" Then result.Nam_hoc = CType(drDanhSach("Nam_hoc").ToString(), String)
                If drDanhSach("So_tien_hoc_bu").ToString() <> "" Then result.So_tien_hoc_bu = CType(drDanhSach("So_tien_hoc_bu").ToString(), Integer)
                If drDanhSach("So_tiet_hoc_bu").ToString() <> "" Then result.So_tiet_hoc_bu = CType(drDanhSach("So_tiet_hoc_bu").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
#Region "Function Danh Sach Bồi hoàn kinh phí"
        Public Function Insert_DanhSach_BoiHoan(ByVal objDanhSach As DanhSach) As Integer
            Try
                Dim obj As DanhSach_DAL = New DanhSach_DAL
                Return obj.Insert_DanhSach_BoiHoan(objDanhSach)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_DanhSach_BoiHoan(ByVal objDanhSach As DanhSach) As Integer
            Try
                Dim obj As DanhSach_DAL = New DanhSach_DAL
                Return obj.Update_DanhSach_BoiHoan(objDanhSach)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_DanhSach_BoiHoan(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                Dim obj As DanhSach_DAL = New DanhSach_DAL
                Return obj.Delete_DanhSach_BoiHoan(ID_sv, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExits_DanhSach_BoiHoan(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Try
                Dim obj As DanhSach_DAL = New DanhSach_DAL
                Return obj.CheckExits_DanhSach_BoiHoan(ID_sv, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_DanhSach_BoiHoan(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("ID_lop")
                dt.Columns.Add("Ten_lop")
                dt.Columns.Add("So_nam_dao_tao")
                dt.Columns.Add("So_tien_hoan_tra", GetType(Double))
                dt.Columns.Add("Hoc_ky")
                dt.Columns.Add("Nam_hoc")
                Dim r As DataRow
                Dim obj As New DanhSach
                For i As Integer = 0 To arrBoiHoan.Count - 1
                    obj = arrBoiHoan.Item(i)
                    If obj.Hoc_ky = Hoc_ky And obj.Nam_hoc = Nam_hoc Then
                        r = dt.NewRow
                        r("Chon") = False
                        r("ID_sv") = obj.ID_sv
                        r("Ma_sv") = obj.Ma_sv
                        r("Ho_ten") = obj.Ho_ten
                        r("Ngay_sinh") = obj.Ngay_sinh
                        r("ID_lop") = obj.ID_lop
                        r("Ten_lop") = obj.Ten_lop
                        r("Hoc_ky") = obj.Hoc_ky
                        r("Nam_hoc") = obj.Nam_hoc
                        r("So_nam_dao_tao") = obj.So_nam_dao_tao
                        r("So_tien_hoan_tra") = Format(obj.So_tien_hoan_tra, "###,###")
                        dt.Rows.Add(r)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting_SinhVien_BoiHoan(ByVal drDanhSach As DataRow) As DanhSach
            Dim result As DanhSach
            Try
                result = New DanhSach
                If drDanhSach("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSach("ID_sv").ToString(), Integer)
                If drDanhSach("Ho_ten").ToString() <> "" Then result.Ho_ten = CType(drDanhSach("Ho_ten").ToString(), String)
                If drDanhSach("Ma_sv").ToString() <> "" Then result.Ma_sv = CType(drDanhSach("Ma_sv").ToString(), String)
                If drDanhSach("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSach("Ngay_sinh").ToString(), String)
                If drDanhSach("ID_lop").ToString() <> "" Then result.ID_lop = CType(drDanhSach("ID_lop").ToString(), Integer)
                If drDanhSach("Ten_lop").ToString() <> "" Then result.Ten_lop = CType(drDanhSach("Ten_lop").ToString(), String)
                If drDanhSach("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drDanhSach("Hoc_ky").ToString(), Integer)
                If drDanhSach("Nam_hoc").ToString() <> "" Then result.Nam_hoc = CType(drDanhSach("Nam_hoc").ToString(), String)
                If drDanhSach("So_nam_dao_tao").ToString() <> "" Then result.So_nam_dao_tao = CType(drDanhSach("So_nam_dao_tao").ToString(), Integer)
                If drDanhSach("So_tien_hoan_tra").ToString() <> "" Then result.So_tien_hoan_tra = CType(drDanhSach("So_tien_hoan_tra").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
