Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business    
    Public Class LapMa_BLL        
        Private strUnicode As String = "AÁÀẢẠÃaáàảạãĂẮẰẲẶẴăắằẳặẵÂẤẨẬẪâấầậẫBbCcDĐđEÉÈẺẼẸeéèẻẽẹÊẾỀỂỄỆêếềểễệFfGgHhIÍÌỈĨỊiíìỉĩịJjKkLlMmNnOÓÒỎÕỌoóòỏõọÔỐỒỔỖỘôốồổỗộƠỚỜỞỠỢơớờởỡợUÚÙỦŨỤuúùủũụƯỨỪỬỮỰưứừửựPpQqSsTtRrXxVvYÝỲỶỸỴyýỳỷỹỵ"
#Region "Constructor"
        Public Sub New()
        End Sub
#End Region

#Region "Function"
        ' Chuyển đổi một xâu ký tụ về dạng số duc ga
        Public Function ConvertToNumber(ByVal strUnicode As String, ByVal strConvert As String) As String
            Dim i As Integer, str As String = ""
            Dim pos As Object = InStrRev(strConvert, " ")
            If pos > 0 Then
                strConvert = Right(strConvert, Len(strConvert) - pos) + " " + Left(strConvert, pos)
            End If
            For i = 1 To Len(strConvert)
                str = str & Right("00" & InStr(strUnicode, Mid(strConvert, i, 1)), 3)
            Next
            Return str
        End Function
        ' Sắp xếp theo họ tên
        Public Function TableSortHo_ten(ByVal dt As DataTable, Optional ByVal Sorted As Boolean = False) As DataView
            Try
                If Sorted Then Return dt.DefaultView
                dt.Columns.Add("Sort", GetType(Object))
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Sort") = ConvertToNumber(strUnicode, dt.Rows(i).Item("Ho_ten"))
                Next
                dt.DefaultView.Sort = "Sort"
                Return dt.DefaultView
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub UpdateMa_sv(ByVal ID_sv As Integer, ByVal Ma_sv As String)
            Try
                Dim obj As New LapMa_DAL
                obj.UpdateMa_sv(ID_sv, Ma_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function Check_Ma_sv(ByVal Ma_sv As String) As Boolean
            Try
                Dim obj As New LapMa_DAL
                Return obj.Check_Ma_sv(Ma_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
