'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/02/2008
'---------------------------------------------------------------------------


Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class DanhMuc_BLL
        Private clsDM As New DanhMuc_DAL
        Public Function GetDateServer() As Date
            Try
                Dim dt As DataTable
                dt = clsDM.DanhMuc_Load("select getDate() as timeserver")
                Return dt.Rows(0)(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Select Tiêu đề báo cáo
        'Public Function TieuDe_BaoCao(ByVal ID_dv As String) As DataTable
        '    Try
        '        Return clsDM.LoadTieuDe_BaoCao(ID_dv)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function

        Public Function TieuDe_BaoCao(ByVal ID_dv As String, ByVal UserID As Integer) As DataTable
            Try
                Return clsDM.LoadTieuDe_BaoCao(ID_dv, UserID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        '' Update Tiêu đề báo cáo
        'Public Sub UpdateTieuDe_BaoCao(ByVal ID_dv As String, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Chuc_danh3 As String, ByVal Chuc_danh4 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Nguoi_ky3 As String, ByVal Nguoi_ky4 As String, ByVal Noi_ky As String)
        '    Try
        '        clsDM.UpdateTieuDe_BaoCao(ID_dv, Ten_bo, Ten_truong, Chuc_danh1, Chuc_danh2, Chuc_danh3, Chuc_danh4, Nguoi_ky1, Nguoi_ky2, Nguoi_ky3, Nguoi_ky4, Noi_ky)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Sub

        ' Update Tiêu đề báo cáo
        Public Sub UpdateTieuDe_BaoCao(ByVal ID_dv As String, ByVal UserID As Integer, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Chuc_danh3 As String, ByVal Chuc_danh4 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Nguoi_ky3 As String, ByVal Nguoi_ky4 As String, ByVal Noi_ky As String)
            Try
                clsDM.UpdateTieuDe_BaoCao(ID_dv, UserID, Ten_bo, Ten_truong, Chuc_danh1, Chuc_danh2, Chuc_danh3, Chuc_danh4, Nguoi_ky1, Nguoi_ky2, Nguoi_ky3, Nguoi_ky4, Noi_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub UpdateTieuDe_BaoCao(ByVal ID_dv As String, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Noi_ky As String)
            Try
                clsDM.UpdateTieuDe_BaoCao(ID_dv, Ten_bo, Ten_truong, Chuc_danh1, Chuc_danh2, Nguoi_ky1, Nguoi_ky2, Noi_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        '' Insert Tiêu đề báo cáo
        'Public Sub InsertTieuDe_BaoCao(ByVal ID_dv As String, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Chuc_danh3 As String, ByVal Chuc_danh4 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Nguoi_ky3 As String, ByVal Nguoi_ky4 As String, ByVal Noi_ky As String)
        '    Try
        '        clsDM.InsertTieuDe_BaoCao(ID_dv, Ten_bo, Ten_truong, Chuc_danh1, Chuc_danh2, Chuc_danh3, Chuc_danh4, Nguoi_ky1, Nguoi_ky2, Nguoi_ky3, Nguoi_ky4, Noi_ky)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Sub

        ' Insert Tiêu đề báo cáo
        Public Sub InsertTieuDe_BaoCao(ByVal ID_dv As String, ByVal UserID As Integer, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Chuc_danh3 As String, ByVal Chuc_danh4 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Nguoi_ky3 As String, ByVal Nguoi_ky4 As String, ByVal Noi_ky As String)
            Try
                clsDM.InsertTieuDe_BaoCao(ID_dv, UserID, Ten_bo, Ten_truong, Chuc_danh1, Chuc_danh2, Chuc_danh3, Chuc_danh4, Nguoi_ky1, Nguoi_ky2, Nguoi_ky3, Nguoi_ky4, Noi_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub InsertTieuDe_BaoCao(ByVal ID_dv As String, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Noi_ky As String)
            Try
                clsDM.InsertTieuDe_BaoCao(ID_dv, Ten_bo, Ten_truong, Chuc_danh1, Chuc_danh2, Nguoi_ky1, Nguoi_ky2, Noi_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        '' Check Tiêu đề báo cáo
        'Public Function CheckTieuDe_BaoCao(ByVal ID_dv As String) As Boolean
        '    Try
        '        Return clsDM.CheckTieuDe_BaoCao(ID_dv)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function

        ' Check Tiêu đề báo cáo
        Public Function CheckTieuDe_BaoCao(ByVal ID_dv As String, ByVal UserID As Integer) As Boolean
            Try
                Return clsDM.CheckTieuDe_BaoCao(ID_dv, UserID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Sub DanhMuc_Insert(ByVal TableName As String, ByVal FieldName As String, ByVal Value As String, _
        Optional ByVal FieldName1 As String = "", Optional ByVal Value1 As String = "", _
        Optional ByVal FieldName2 As String = "", Optional ByVal Value2 As String = "", _
        Optional ByVal FieldName3 As String = "", Optional ByVal Value3 As String = "", _
        Optional ByVal FieldName4 As String = "", Optional ByVal Value4 As String = "", _
        Optional ByVal FieldName5 As String = "", Optional ByVal Value5 As String = "")
            Try
                clsDM.DanhMuc_Insert(TableName, FieldName, Value, FieldName1, Value1, FieldName2, Value2, FieldName3, Value3, FieldName4, Value4, FieldName5, Value5)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Sub DanhMuc_Update(ByVal TableName As String, ByVal FieldWhere As Object, ByVal ValueWhere As Object, ByVal FieldName As String, ByVal Value As String, _
        Optional ByVal FieldName1 As String = "", Optional ByVal Value1 As String = "", _
        Optional ByVal FieldName2 As String = "", Optional ByVal Value2 As String = "", _
        Optional ByVal FieldName3 As String = "", Optional ByVal Value3 As String = "", _
        Optional ByVal FieldName4 As String = "", Optional ByVal Value4 As String = "", _
        Optional ByVal FieldName5 As String = "", Optional ByVal Value5 As String = "")
            Try
                clsDM.DanhMuc_Update(TableName, FieldWhere, ValueWhere, FieldName, Value, FieldName1, Value1, FieldName2, Value2, FieldName3, Value3, FieldName4, Value4, FieldName5, Value5)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Sub DanhMuc_Delete(ByVal TableName As String, ByVal FieldWhere As Object, ByVal ValueWhere As Object)
            Try
                clsDM.DanhMuc_Delete(TableName, FieldWhere, ValueWhere)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Function DanhMuc_CheckName(ByVal TableName As String, ByVal FieldName As String, ByVal Value As String) As Boolean
            Try
                Return clsDM.DanhMuc_CheckName(TableName, FieldName, Value)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function DanhMuc_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String) As DataTable
            Dim dt As DataTable = clsDM.DanhMuc_Load(TableName, ValueMember, DisplayMember)
            Return dt
        End Function

        Function DanhMucSoSanh_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal Bien_DieuKien As String, ByVal DieuKien_Input As Integer) As DataTable
            Dim dt As DataTable = clsDM.DanhMucSoSanh_Load(TableName, ValueMember, DisplayMember, Bien_DieuKien, DieuKien_Input)
            Return dt
        End Function

        Function DanhMuc_Load(ByVal strSQL As String) As DataTable
            Dim dt As DataTable = clsDM.DanhMuc_Load(strSQL)
            Return dt
        End Function

        Function DanhMuc_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal Bien_DieuKien As String, ByVal DieuKien_Input As String) As DataTable
            Dim dt As DataTable = clsDM.DanhMuc_Load(TableName, ValueMember, DisplayMember, Bien_DieuKien, DieuKien_Input)
            Return dt
        End Function

        Function DanhMuc_ChuyenNganh_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal Bien_DieuKien As String, ByVal DieuKien_Input As String) As DataTable
            Dim dt As DataTable = clsDM.DanhMuc_ChuyenNganh_Load(TableName, ValueMember, DisplayMember, Bien_DieuKien, DieuKien_Input)
            Return dt
        End Function

        Function DanhMuc_Khoa_Load(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Dim dt As DataTable = clsDM.DanhMuc_Khoa_Load(ID_he, Khoa_hoc)
            Return dt
        End Function

        Function DanhMuc_DKKhac_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal Bien_DieuKien As String, ByVal DieuKien_Input As String) As DataTable
            Dim dt As DataTable = clsDM.DanhMuc_DKKhac_Load(TableName, ValueMember, DisplayMember, Bien_DieuKien, DieuKien_Input)
            Return dt
        End Function

        Function getID_nganh(ByVal ID_chuyen_nganh As Integer) As Integer
            Return clsDM.getID_Nganh_Load(ID_chuyen_nganh)
        End Function
        Function getMa_nganh(ByVal ID_nganh As Integer) As String
            Return clsDM.getMaNganh(ID_nganh)
        End Function
        Function getMa_He(ByVal ID_he As Integer) As String
            Return clsDM.getMaHe(ID_he)
        End Function
        Public Function LoadDanhMuc(ByVal SQL As String) As DataTable
            Return clsDM.LoadDanhMuc(SQL)
        End Function
        ' Load niên khóa của sinh viên 
        Public Function LoadNienKhoa(ByVal ID_sv As Integer) As String
            Return clsDM.LoadNienKhoa(ID_sv)
        End Function
        'Load xep loại hoc bổng
        Public Function LoadXepLoai_HocBong(ByVal ID_xep_loai_hb As Integer) As String
            Return clsDM.Xep_loai_HB(ID_xep_loai_hb)
        End Function
        Public Function GetMaCN(ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As String
            Return clsDM.getMaNganh(ID_nganh, ID_chuyen_nganh)
        End Function

        'Public Function CheckVerSion() As Boolean
        '    Return clsDM.CheckVerSion
        'End Function
        Public Sub Execute(ByVal SQL As String)
            clsDM.Execute(SQL)
        End Sub
#Region "Tim kiem"
        Function LoadFields(ByVal gID_phan_he As Integer, ByVal gObjectID As Integer, ByVal FieldGroup As Integer, Optional ByVal Lua_chon As Boolean = False, Optional ByVal FieldSelect As Boolean = False) As DataTable
            Try
                Return clsDM.LoadFields(gID_phan_he, gObjectID, FieldGroup, Lua_chon, FieldSelect)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Function LoadFieldsShow(ByVal gID_phan_he As Integer, ByVal gObjectID As Integer, ByVal FieldGroup As Integer, Optional ByVal Lua_chon As Boolean = False, Optional ByVal FieldSelect As Boolean = False) As DataTable
            Try
                Return clsDM.LoadFieldsShow(gID_phan_he, gObjectID, FieldGroup)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region
    End Class
End Namespace