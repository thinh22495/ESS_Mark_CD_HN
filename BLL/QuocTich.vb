'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Monday, April 21, 2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ThienAn.Entity.Entity

Imports ThienAn.DAL.DBManager
Namespace Business
    Public Class QuocTich_BLL
        Inherits QuocTich        

#Region "Constructor"
        Public Sub New()
            
        End Sub
#End Region

#Region "Function"
        ' Get Quoc Tich
        Public Function GetQuocTich() As DataTable
            Try
                Dim obj As QuocTich_DAL = New QuocTich_DAL
                Dim dt As DataTable = obj.Load_QuocTich()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drQuocTich As DataRow) As QuocTich
            Dim result As QuocTich
            Try
                result = New QuocTich
                If drQuocTich("ID_quoc_tich").ToString() <> "" Then result.ID_quoc_tich = CType(drQuocTich("ID_quoc_tich").ToString(), Integer)
                result.Ma_quoc_tich = drQuocTich("Ma_quoc_tich").ToString()
                result.Quoc_tich = drQuocTich("Quoc_tich").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
