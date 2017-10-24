Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class PhanLoaiKetQuaHocTap_BLL
        Sub New()
        End Sub

        Public Function Load_XepLoaiHocTap() As DataTable
            Dim clsDAL As New Diem_DAL
            Return clsDAL.Load_XepLoaiHocTap
        End Function
    End Class
End Namespace