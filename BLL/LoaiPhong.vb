'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Monday, June 30, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class LoaiPhong_BLL
        Private arrLoaiPhong As ArrayList

#Region "Constructor"
        Public Sub New()
            'Add tat ca Loại phòng
            Try
                arrLoaiPhong = New ArrayList
                Dim objLoaiPhong_dal As New LoaiPhong_DAL
                Dim dt As DataTable = objLoaiPhong_dal.Load_LoaiPhong_List()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objLoaiPhong As New LoaiPhong
                        objLoaiPhong = Converting(dt.Rows(i))
                        arrLoaiPhong.Add(objLoaiPhong)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Function"
        Public Function DanhMucLoaiPhong() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_loai_phong", GetType(Integer))
                dt.Columns.Add("Ten_loai_phong", GetType(String))
                For i As Integer = 0 To arrLoaiPhong.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objLoaiPhong As LoaiPhong = CType(arrLoaiPhong(i), LoaiPhong)
                    row("ID_loai_phong") = objLoaiPhong.ID_loai_phong
                    row("Ten_loai_phong") = objLoaiPhong.Ten_loai_phong
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Insert_LoaiPhong(ByVal objLoaiPhong As LoaiPhong) As Integer
            Try
                Dim obj As LoaiPhong_DAL = New LoaiPhong_DAL
                Return obj.Insert_LoaiPhong(objLoaiPhong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_LoaiPhong(ByVal objLoaiPhong As LoaiPhong, ByVal ID_loai_phong As Integer) As Integer
            Try
                Dim obj As LoaiPhong_DAL = New LoaiPhong_DAL
                Return obj.Update_LoaiPhong(objLoaiPhong, ID_loai_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_LoaiPhong(ByVal ID_loai_phong As Integer) As Integer
            Try
                Dim obj As LoaiPhong_DAL = New LoaiPhong_DAL
                Return obj.Delete_LoaiPhong(ID_loai_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_LoaiPhong(ByVal ID_loai_phong As Integer) As Boolean
            Try
                Dim obj As LoaiPhong_DAL = New LoaiPhong_DAL
                obj.CheckExist_LoaiPhong(ID_loai_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drLoaiPhong As DataRow) As LoaiPhong
            Dim result As LoaiPhong
            Try
                result = New LoaiPhong
                If drLoaiPhong("ID_loai_phong").ToString() <> "" Then result.ID_loai_phong = CType(drLoaiPhong("ID_loai_phong").ToString(), Integer)
                result.Ma_loai = drLoaiPhong("Ma_loai").ToString()
                result.Ten_loai_phong = drLoaiPhong("Ten_loai_phong").ToString()
                result.Thuc_hanh = drLoaiPhong("Thuc_hanh").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
