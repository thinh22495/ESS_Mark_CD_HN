Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ThienAn.Machine
Imports ThienAn.Entity.Entity
Namespace DBManager
    Public Class He_Khoa_Khoa_Lop_DAL

#Region "Constructor"
        Public Sub New()
            'UDB.SetConnectionString(".", "UniSoft_new", "UnisoftAdmin", "taUnisoft032003")
        End Sub
#End Region

        Public Function Load_He_List() As DataTable
            Try
                Return UDB.SelectTableSP("sp_STU_He_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ChuyenNganh_List() As DataTable
            Try
                Return UDB.SelectTableSP("sp_STU_ChuyenNganh_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Public Function Load_ChuyenNganh_Nganh_List() As DataTable
        '    Try
        '        Return UDB.SelectTableSP("sp_STU_ChuyenNganh_Nganh_Load_List")
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        Public Function Load_CoSo_List() As DataTable
            Try
                Return UDB.SelectTableSP("sp_PLAN_CoSoDaoTao_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Nganh_List() As DataTable
            Try
                Return UDB.SelectTableSP("sp_STU_Nganh_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_Khoa_List() As DataTable
            Try
                Return UDB.SelectTableSP("sp_STU_Khoa_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_KhoaHoc_List() As DataTable
            Try
                Return UDB.SelectTableSP("sp_STU_KhoaHoc_Load_List")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class


End Namespace

