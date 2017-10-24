'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Thursday, July 31, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class MucHocPhiTinChi_BLL
        Private arrMucHocPhiTinChi As New ArrayList
#Region "Constructor"
        Public Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer)
            Try
                Dim obj As MucHocPhiTinChi_DAL = New MucHocPhiTinChi_DAL
                Dim dt As DataTable = obj.Load_MucHocPhiTinChi(Hoc_ky, Nam_hoc, ID_he)
                Dim objMucHocPhiTinChi As MucHocPhiTinChi = Nothing
                If dt.Rows.Count > 0 Then
                    objMucHocPhiTinChi = Converting(dt.Rows(0))
                    arrMucHocPhiTinChi.Add(objMucHocPhiTinChi)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.arrMucHocPhiTinChi.Count
            End Get
        End Property
        Public Property MucHocPhiTinChi(ByVal idx As Integer) As MucHocPhiTinChi
            Get
                Return CType(Me.arrMucHocPhiTinChi(idx), MucHocPhiTinChi)
            End Get
            Set(ByVal Value As MucHocPhiTinChi)
                Me.arrMucHocPhiTinChi(idx) = Value
            End Set
        End Property
        Public Function Insert_MucHocPhiTinChi(ByVal objMucHocPhiTinChi As MucHocPhiTinChi) As Integer
            Try
                Dim obj As MucHocPhiTinChi_DAL = New MucHocPhiTinChi_DAL
                Return obj.Insert_MucHocPhiTinChi(objMucHocPhiTinChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_MucHocPhiTinChi(ByVal objMucHocPhiTinChi As MucHocPhiTinChi, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As Integer
            Try
                Dim obj As MucHocPhiTinChi_DAL = New MucHocPhiTinChi_DAL
                Return obj.Update_MucHocPhiTinChi(objMucHocPhiTinChi, Hoc_ky, Nam_hoc, ID_he)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_MucHocPhiTinChi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As Integer
            Try
                Dim obj As MucHocPhiTinChi_DAL = New MucHocPhiTinChi_DAL
                Return obj.Delete_MucHocPhiTinChi(Hoc_ky, Nam_hoc, ID_he)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drMucHocPhiTinChi As DataRow) As MucHocPhiTinChi
            Dim result As MucHocPhiTinChi
            Try
                result = New MucHocPhiTinChi
                If drMucHocPhiTinChi("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drMucHocPhiTinChi("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drMucHocPhiTinChi("Nam_hoc").ToString()
                If drMucHocPhiTinChi("ID_he").ToString() <> "" Then result.ID_he = CType(drMucHocPhiTinChi("ID_he").ToString(), Integer)
                If drMucHocPhiTinChi("So_tien").ToString() <> "" Then result.So_tien = CType(drMucHocPhiTinChi("So_tien").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
