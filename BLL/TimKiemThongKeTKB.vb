'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/05/2008
'---------------------------------------------------------------------------
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class TimKiemThongKeTKB_BLL
        Sub New()

        End Sub
        Public Function TimKiemLopDangHoc(ByVal strSQL_Where As String) As DataTable
            Try
                Dim cls As New TimKiemThongKeTKB_DAL
                Return cls.TimKiemLopDangHoc(strSQL_Where)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TimKiemLopRoi(ByVal strSQL_Where_thoi_gian As String, ByVal strSQL_Where_lop As String) As DataTable
            Try
                Dim cls As New TimKiemThongKeTKB_DAL
                Return cls.TimKiemLopRoi(strSQL_Where_thoi_gian, strSQL_Where_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TimKiemGiaoVienDangDay(ByVal strSQL_Where As String) As DataTable
            Try
                Dim cls As New TimKiemThongKeTKB_DAL
                Return cls.TimKiemGiaoVienDangDay(strSQL_Where)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TimKiemGiaoVienRoi(ByVal strSQL_Where_thoi_gian As String, ByVal strSQL_Where_giao_vien As String) As DataTable
            Try
                Dim cls As New TimKiemThongKeTKB_DAL
                Return cls.TimKiemGiaoVienRoi(strSQL_Where_thoi_gian, strSQL_Where_giao_vien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TimKiemPhongDangHoc(ByVal strSQL_Where As String) As DataTable
            Try
                Dim cls As New TimKiemThongKeTKB_DAL
                Return cls.TimKiemPhongDangHoc(strSQL_Where)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TimKiemPhongRoi(ByVal strSQL_Where_thoi_gian As String, ByVal strSQL_Where_phong As String) As DataTable
            Try
                Dim cls As New TimKiemThongKeTKB_DAL
                Return cls.TimKiemPhongRoi(strSQL_Where_thoi_gian, strSQL_Where_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKeGioGiangTKB(ByVal strSQL_Where As String) As DataTable
            Try
                Dim cls As New TimKiemThongKeTKB_DAL
                Return cls.ThongKeGioGiangTKB(strSQL_Where)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKeGioGiangKeHoach(ByVal strSQL_Where As String) As DataTable
            Try
                Dim cls As New TimKiemThongKeTKB_DAL
                Return cls.ThongKeGioGiangKeHoach(strSQL_Where)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

