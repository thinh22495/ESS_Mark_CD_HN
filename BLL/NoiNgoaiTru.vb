'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Sunday, 25 May, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class NoiNgoaiTru_BLL
        Inherits NoiNgoaiTru
#Region "Var"
        Private aNoiNgoaiTrus As ArrayList
#End Region
#Region "Constructor"
        Public Sub New()

        End Sub
        Public Sub New(ByVal ID_sv As Integer)
            Try
                aNoiNgoaiTrus = New ArrayList
                Dim obj As New NoiNgoaiTru_DAL
                Dim dtNoiNgoaiTru As DataTable = obj.Load_NoiNgoaiTru(ID_sv)
                Dim objNoiNgoaiTru As New NoiNgoaiTru
                Dim dr As DataRow = Nothing
                For Each dr In dtNoiNgoaiTru.Rows
                    objNoiNgoaiTru = ConvertingSV(dr)
                    aNoiNgoaiTrus.Add(objNoiNgoaiTru)
                Next
            Catch ex As Exception
                Throw (ex)
            End Try
        End Sub
        Public Sub New(ByVal ID_lops As String)
            Try
                aNoiNgoaiTrus = New ArrayList
                Dim obj As New NoiNgoaiTru_DAL
                Dim dtNoiNgoaiTru As DataTable = obj.Load_NoiNgoaiTru(ID_lops)
                Dim objNoiNgoaiTru As New NoiNgoaiTru
                Dim dr As DataRow = Nothing
                For Each dr In dtNoiNgoaiTru.Rows
                    objNoiNgoaiTru = Converting(dr)
                    aNoiNgoaiTrus.Add(objNoiNgoaiTru)
                Next
            Catch ex As Exception
                Throw (ex)
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function Load_NoiNgoaiTru(ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As NoiNgoaiTru
            Try
                Dim obj As NoiNgoaiTru_DAL = New NoiNgoaiTru_DAL
                Dim dt As DataTable = obj.Load_NoiNgoaiTru(ID_sv, Tu_ngay)
                Dim objNoiNgoaiTru As NoiNgoaiTru = Nothing
                If dt.Rows.Count > 0 Then
                    objNoiNgoaiTru = Converting(dt.Rows(0))
                End If
                Return objNoiNgoaiTru
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_PhongKyTucXa() As DataTable
            Try
                Dim obj As NoiNgoaiTru_DAL = New NoiNgoaiTru_DAL
                Dim dt As DataTable = obj.Load_PhongKyTucXa()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_NoiNgoaiTru() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Tu_ngay", GetType(Date))
                dt.Columns.Add("Den_ngay", GetType(Date))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("ID_phong_ktx", GetType(Integer))
                dt.Columns.Add("So_phong_ktx", GetType(String))
                dt.Columns.Add("ID_tang", GetType(Integer))
                dt.Columns.Add("ID_nha_KTX", GetType(Integer))
                dt.Columns.Add("Ten_nha", GetType(String))
                dt.Columns.Add("Dia_chi", GetType(String))
                dt.Columns.Add("Dien_thoai", GetType(String))
                dt.Columns.Add("Ten_chu_ho", GetType(String))
                dt.Columns.Add("Ghi_chu", GetType(String))
                dt.Columns.Add("Noi_o", GetType(String))
                dt.Columns.Add("Trang_thai", GetType(Integer))
                For i As Integer = 0 To aNoiNgoaiTrus.Count - 1
                    Dim Noingoaitru As NoiNgoaiTru = CType(aNoiNgoaiTrus(i), NoiNgoaiTru)
                    Dim row As DataRow = dt.NewRow()
                    row("ID_sv") = Noingoaitru.ID_sv
                    row("ID_lop") = Noingoaitru.ID_lop
                    row("Ten_lop") = Noingoaitru.Ten_lop
                    row("Ma_sv") = Noingoaitru.Ma_sv
                    row("Ho_ten") = Noingoaitru.Ho_ten
                    row("Ngay_sinh") = Format(Noingoaitru.Ngay_sinh.Date.ToString)
                    If Noingoaitru.Den_ngay <> Nothing Then row("Den_ngay") = Noingoaitru.Den_ngay
                    If Noingoaitru.Tu_ngay <> Nothing Then row("Tu_ngay") = Noingoaitru.Tu_ngay
                    row("ID_phong_ktx") = Noingoaitru.ID_phong_ktx
                    row("So_phong_ktx") = Noingoaitru.So_phong_KTX
                    row("ID_tang") = Noingoaitru.ID_tang
                    row("Ho_ten") = Noingoaitru.Ho_ten
                    row("Ngay_sinh") = Format(Noingoaitru.Ngay_sinh.Date.ToString)
                    row("ID_nha_KTX") = Noingoaitru.ID_nha_KTX
                    row("Ten_nha") = Noingoaitru.Ten_nha
                    row("Dia_chi") = Noingoaitru.Dia_chi
                    row("Dien_thoai") = Noingoaitru.Dien_thoai
                    row("Ten_chu_ho") = Noingoaitru.Ten_chu_ho
                    row("Ghi_chu") = Noingoaitru.Ghi_chu
                    row("Noi_o") = Noingoaitru.Noi_o
                    row("Trang_thai") = Noingoaitru.Trang_thai
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load noi ngoai tru cua mot sinh vien đã ở và đang ỏ
        Public Function Load_NoiNgoaiTruSV() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Tu_ngay", GetType(Date))
                dt.Columns.Add("Den_ngay", GetType(Date))
                dt.Columns.Add("So_phong_ktx", GetType(String))
                dt.Columns.Add("Dia_chi", GetType(String))
                dt.Columns.Add("Ghi_chu", GetType(String))
                dt.Columns.Add("Trang_thai", GetType(Integer))
                dt.Columns.Add("Noi_o", GetType(String))                
                For i As Integer = 0 To aNoiNgoaiTrus.Count - 1
                    Dim Noingoaitru As NoiNgoaiTru = CType(aNoiNgoaiTrus(i), NoiNgoaiTru)
                    Dim row As DataRow = dt.NewRow()
                    row("ID_sv") = Noingoaitru.ID_sv
                    If Noingoaitru.Den_ngay <> Nothing Then row("Den_ngay") = Noingoaitru.Den_ngay
                    If Noingoaitru.Tu_ngay <> Nothing Then row("Tu_ngay") = Noingoaitru.Tu_ngay
                    row("So_phong_ktx") = Noingoaitru.So_phong_KTX
                    row("Dia_chi") = Noingoaitru.Dia_chi
                    row("Ghi_chu") = Noingoaitru.Ghi_chu
                    row("Trang_thai") = Noingoaitru.Trang_thai
                    row("Noi_o") = Noingoaitru.Noi_o & Noingoaitru.So_phong_KTX & Noingoaitru.Dia_chi
                    If Noingoaitru.Trang_thai = -1 Then
                        dt.Rows.Add(row)
                    Else
                        If Noingoaitru.Trang_thai = 1 Then
                            dt.Rows.Add(row)
                        End If
                    End If                    
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load noi tru cua mot sinh viên hiện tại đang ở
        Public Function Load_NoiNgoaiTruSV_DangO() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Tu_ngay", GetType(Date))
                dt.Columns.Add("Den_ngay", GetType(Date))
                dt.Columns.Add("So_phong_ktx", GetType(String))
                dt.Columns.Add("Dia_chi", GetType(String))
                dt.Columns.Add("Ghi_chu", GetType(String))
                dt.Columns.Add("Trang_thai", GetType(Integer))
                dt.Columns.Add("Noi_o", GetType(String))
                dt.Columns.Add("So_tien_mot_nguoi", GetType(Integer))
                For i As Integer = 0 To aNoiNgoaiTrus.Count - 1
                    Dim Noingoaitru As NoiNgoaiTru = CType(aNoiNgoaiTrus(i), NoiNgoaiTru)
                    ' Nếu còn đang ở và ở nội trú
                    If Noingoaitru.Trang_thai = 1 And Noingoaitru.So_phong_KTX <> "" Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_sv") = Noingoaitru.ID_sv
                        If Noingoaitru.Den_ngay <> Nothing Then row("Den_ngay") = Noingoaitru.Den_ngay
                        If Noingoaitru.Tu_ngay <> Nothing Then row("Tu_ngay") = Noingoaitru.Tu_ngay
                        row("So_phong_ktx") = Noingoaitru.So_phong_KTX
                        row("Dia_chi") = Noingoaitru.Dia_chi
                        row("Ghi_chu") = Noingoaitru.Ghi_chu
                        row("Trang_thai") = Noingoaitru.Trang_thai
                        row("Noi_o") = Noingoaitru.Noi_o & Noingoaitru.So_phong_KTX & Noingoaitru.Dia_chi
                        If Noingoaitru.Trang_thai = -1 Then
                            dt.Rows.Add(row)
                        Else
                            If Noingoaitru.Trang_thai = 1 Then
                                dt.Rows.Add(row)
                            End If
                        End If
                        row("So_tien_mot_nguoi") = Noingoaitru.So_tien_mot_nguoi
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_NoiNgoaiTru_List() As NoiNgoaiTru
            Try
                Dim obj As NoiNgoaiTru_DAL = New NoiNgoaiTru_DAL
                Dim dt As DataTable = obj.Load_NoiNgoaiTru_List()
                Dim objNoiNgoaiTru As NoiNgoaiTru = Nothing
                If dt.Rows.Count > 0 Then
                    objNoiNgoaiTru = Converting(dt.Rows(0))
                End If
                Return objNoiNgoaiTru
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_NgoaiTru(ByVal objNoiNgoaiTru As NoiNgoaiTru) As Integer
            Try
                Dim obj As NoiNgoaiTru_DAL = New NoiNgoaiTru_DAL
                Return obj.Insert_NgoaiTru(objNoiNgoaiTru)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_NoiTru(ByVal objNoiNgoaiTru As NoiNgoaiTru) As Integer
            Try
                Dim obj As NoiNgoaiTru_DAL = New NoiNgoaiTru_DAL
                Return obj.Insert_NoiTru(objNoiNgoaiTru)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_NoiNgoaiTru(ByVal objNoiNgoaiTru As NoiNgoaiTru, ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As Integer
            Try
                Dim obj As NoiNgoaiTru_DAL = New NoiNgoaiTru_DAL
                Return obj.Update_NoiNgoaiTru(objNoiNgoaiTru, ID_sv, Tu_ngay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_NoiNgoaiTru_TrangThai(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As NoiNgoaiTru_DAL = New NoiNgoaiTru_DAL
                Return obj.Update_NoiNgoaiTru_TrangThai(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_NoiNgoaiTru_DenNgay(ByVal ID_sv As Integer, ByVal Den_ngay As Date) As Integer
            Try
                Dim obj As NoiNgoaiTru_DAL = New NoiNgoaiTru_DAL
                Return obj.Update_NoiNgoaiTru_DenNgay(ID_sv, Den_ngay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_NoiNgoaiTru(ByVal ID_sv As Integer, ByVal Tu_ngay As Date, ByVal ID_phong_ktx As Integer, ByVal Trang_thai As Integer) As Integer
            Try
                Dim obj As NoiNgoaiTru_DAL = New NoiNgoaiTru_DAL
                Return obj.Delete_NoiNgoaiTru(ID_sv, Tu_ngay, ID_phong_ktx, Trang_thai)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svNoiNgoaiTru(ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As Boolean
            Try
                Dim obj As NoiNgoaiTru_DAL = New NoiNgoaiTru_DAL
                Return obj.CheckExist_NoiNgoaiTru(ID_sv, Tu_ngay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svNoiNgoaiTru(ByVal ID_sv As Integer) As Boolean
            Try
                Dim obj As NoiNgoaiTru_DAL = New NoiNgoaiTru_DAL
                Return obj.CheckExist_NoiNgoaiTru(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_svNoiNgoaiTru(ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As Integer
            Try
                Dim obj As NoiNgoaiTru_DAL = New NoiNgoaiTru_DAL
                obj.GetMaxID_NoiNgoaiTru(ID_sv, Tu_ngay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drNoiNgoaiTru As DataRow) As NoiNgoaiTru
            Dim result As NoiNgoaiTru
            Try
                result = New NoiNgoaiTru
                If drNoiNgoaiTru("ID_lop").ToString() <> "" Then result.ID_lop = CType(drNoiNgoaiTru("ID_lop").ToString(), Integer)
                result.Ten_lop = drNoiNgoaiTru("Ten_lop").ToString()
                If drNoiNgoaiTru("ID_sv").ToString() <> "" Then result.ID_sv = CType(drNoiNgoaiTru("ID_sv").ToString(), Integer)
                result.Ma_sv = drNoiNgoaiTru("Ma_sv").ToString()
                result.Ho_ten = drNoiNgoaiTru("Ho_ten").ToString()
                If drNoiNgoaiTru("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drNoiNgoaiTru("Ngay_sinh").ToString(), Date)
                If drNoiNgoaiTru("Tu_ngay").ToString() <> "" Then result.Tu_ngay = CType(drNoiNgoaiTru("Tu_ngay").ToString(), Date)
                If drNoiNgoaiTru("Den_ngay").ToString() <> "" Then result.Den_ngay = CType(drNoiNgoaiTru("Den_ngay").ToString(), Date)
                If drNoiNgoaiTru("ID_phong_ktx").ToString() <> "" Then result.ID_phong_ktx = CType(drNoiNgoaiTru("ID_phong_ktx").ToString(), Integer)
                result.So_phong_KTX = drNoiNgoaiTru("So_phong_KTX").ToString()
                If drNoiNgoaiTru("ID_tang").ToString() <> "" Then result.ID_tang = CType(drNoiNgoaiTru("ID_tang").ToString(), Integer)
                If drNoiNgoaiTru("ID_nha_KTX").ToString() <> "" Then result.ID_nha_KTX = CType(drNoiNgoaiTru("ID_nha_KTX").ToString(), Integer)
                result.Ten_nha = drNoiNgoaiTru("Ten_nha").ToString()
                result.Dia_chi = drNoiNgoaiTru("Dia_chi").ToString()
                result.Dien_thoai = drNoiNgoaiTru("Dien_thoai").ToString()
                result.Ten_chu_ho = drNoiNgoaiTru("Ten_chu_ho").ToString()
                result.Ghi_chu = drNoiNgoaiTru("Ghi_chu").ToString()
                result.Noi_o = drNoiNgoaiTru("Noi_o").ToString()
                If drNoiNgoaiTru("Trang_thai").ToString() <> "" Then result.Trang_thai = CType(drNoiNgoaiTru("Trang_thai").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function ConvertingSV(ByVal drNoiNgoaiTru As DataRow) As NoiNgoaiTru
            Dim result As NoiNgoaiTru
            Try
                result = New NoiNgoaiTru
                If drNoiNgoaiTru("ID_sv").ToString() <> "" Then result.ID_sv = CType(drNoiNgoaiTru("ID_sv").ToString(), Integer)
                If drNoiNgoaiTru("Tu_ngay").ToString() <> "" Then result.Tu_ngay = CType(drNoiNgoaiTru("Tu_ngay").ToString(), Date)
                If drNoiNgoaiTru("Den_ngay").ToString() <> "" Then result.Den_ngay = CType(drNoiNgoaiTru("Den_ngay").ToString(), Date)
                result.So_phong_KTX = drNoiNgoaiTru("So_phong_KTX").ToString()
                result.Dia_chi = drNoiNgoaiTru("Dia_chi").ToString()
                result.Ghi_chu = drNoiNgoaiTru("Ghi_chu").ToString()
                If drNoiNgoaiTru("Trang_thai").ToString() <> "" Then result.Trang_thai = IIf(drNoiNgoaiTru("Trang_thai") = True, 1, 0)
                If drNoiNgoaiTru("So_tien_mot_nguoi").ToString() <> "" Then result.So_tien_mot_nguoi = drNoiNgoaiTru("So_tien_mot_nguoi")
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
