Public Class DiemThiChiTiet_DAL

    Public Sub New()

    End Sub
    ''' <summary>
    ''' Load tất cả thành phần thi
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function LoadAll() As DataTable
        Return ESS.Machine.UDB.SelectTable("Select * FROM MARK_ThanhPhanDiemThi")
    End Function
    ''' <summary>
    ''' Load danh sách các thành phần thi của 1 môn trong chuyên lớp vd: Viết, Vấn đáp,...
    ''' </summary>
    ''' <param name="dsID_lop">ds ID lớp</param>
    ''' <param name="ID_mon">ID môn</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function LoadThanhPhanThi(ByVal dsID_lop As String, ByVal ID_mon As Integer) As DataTable
        Try
            Dim param(1) As SqlClient.SqlParameter
            param(0) = New SqlClient.SqlParameter("@dsID_lop", dsID_lop)
            param(1) = New SqlClient.SqlParameter("@ID_mon", ID_mon)
            Return ESS.Machine.UDB.SelectTableSP("MARK_ThanhPhanThi_LoadByMon", param)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Load các điểm chi tiết
    ''' </summary>
    ''' <param name="dsID_lop"></param>
    ''' <param name="Hoc_ky"></param>
    ''' <param name="Nam_hoc"></param>
    ''' <param name="dsID_sv"></param>
    ''' <param name="ID_mon"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function LoadDiemThiChiTiet(ByVal dsID_lop As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_sv As String, ByVal ID_mon As Integer) As DataTable
        Try
            Dim param(4) As SqlClient.SqlParameter
            param(0) = New SqlClient.SqlParameter("@dsID_lop", dsID_lop)
            param(1) = New SqlClient.SqlParameter("@Hoc_ky", Hoc_ky)
            param(2) = New SqlClient.SqlParameter("@Nam_hoc", Nam_hoc)
            param(3) = New SqlClient.SqlParameter("@dsID_sv", dsID_sv)
            param(4) = New SqlClient.SqlParameter("@ID_mon", ID_mon)
            Return ESS.Machine.UDB.SelectTableSP("MARK_DiemThi_ChiTiet_LoadByMon", param)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Insert hoặc update điểm thi chi tiết
    ''' </summary>
    ''' <param name="obj"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UpdateDiemThi(ByVal obj As Entity.DiemThiChiTiet) As Integer
        Try
            Dim param(2) As SqlClient.SqlParameter
            param(0) = New SqlClient.SqlParameter("@ID_diem_thi", obj.ID_diem_thi)
            param(1) = New SqlClient.SqlParameter("@Diem", obj.Diem)
            param(2) = New SqlClient.SqlParameter("@ID_thanh_phan", obj.ThanhPhanThi.ID_thanh_phan)
            Return ESS.Machine.UDB.ExecuteSP("MARK_DiemThi_ChiTiet_Update", param)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
