
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class NopGiayTo_QuyDinh_BLL
        Private cls As New NopGiayTo_QuyDinh_DAL
        Function getLoai_GiayTo_TheoHe(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Return cls.getLoai_GiayTo_TheoHe(ID_he, Khoa_hoc)
        End Function

        Function Insert_Loai_GiayTo_TheoHe(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_giay_to As Integer) As Integer
            Return cls.Insert_Loai_GiayTo_TheoHe(ID_he, Khoa_hoc, ID_giay_to)
        End Function
        Public Function Delete_GiayTo_TheoHe(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_giay_to As Integer) As Integer
            Return cls.Delete_GiayTo_TheoHe(ID_he, Khoa_hoc, ID_giay_to)
        End Function
        Public Function CheckExist_GiayTo_TheoHe(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_giay_to As Integer) As Boolean
            Return cls.CheckExist_GiayTo_TheoHe(ID_he, Khoa_hoc, ID_giay_to)
        End Function

        Function getLop_TheoDK(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Return cls.getLop_TheoDK(ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh)
        End Function
    End Class
End Namespace

