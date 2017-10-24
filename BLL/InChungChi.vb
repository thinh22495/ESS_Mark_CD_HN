Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class InChungChi_BLL
        Public Function InChungChi_Load_List() As DataTable
            Try
                Dim obj As InChungChi_DAL = New InChungChi_DAL
                Return obj.InChungChi_Load_List()
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_SoHieu(ByVal So_hieu As String, ByVal ID_sv As Integer, ByVal Ten_cc As String) As Integer
            Try
                Dim obj As InChungChi_DAL = New InChungChi_DAL
                Return obj.CapNhat_SoHieu(So_hieu, ID_sv, Ten_cc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_SoVaoSo(ByVal So_vao_so As String, ByVal ID_sv As Integer, ByVal Ten_cc As String) As Integer
            Try
                Dim obj As InChungChi_DAL = New InChungChi_DAL
                Return obj.CapNhat_SoVaoSo(So_vao_so, ID_sv, Ten_cc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_ChungChi(ByVal ID_sv As Integer, ByVal Ten_cc As String) As DataTable
            Try
                Dim obj As InChungChi_DAL = New InChungChi_DAL
                Return obj.Load_ChungChi(ID_sv, Ten_cc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_InChungChi(ByVal objChungChi As InChungChi, ByVal ID_sv As Integer, ByVal Ten_cc As String) As Integer
            Try
                Dim obj As InChungChi_DAL = New InChungChi_DAL
                Return obj.Update_InChungChi(objChungChi, ID_sv, Ten_cc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Insert_InChungChi(ByVal objChungChi As InChungChi) As Integer
            Try
                Dim obj As InChungChi_DAL = New InChungChi_DAL
                Return obj.Insert_InChungChi(objChungChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Delete_InChungChi(ByVal ID_sv As Integer, ByVal Ten_cc As String) As Integer
            Try
                Dim obj As InChungChi_DAL = New InChungChi_DAL
                Return obj.Delete_InChungChi(ID_sv, Ten_cc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

