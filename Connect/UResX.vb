Imports System
Imports System.Drawing
Imports System.IO
Imports System.Xml
Imports System.Resources

Public Class UResX
    Private fn As String
    Public Sub New(ByVal file_name As String)
        Me.fn = file_name
    End Sub
    Public Function GetPicture(ByVal Key As String) As System.Drawing.Image
        Try
            Dim fn As String = UCommon.Current_Path + fn
            If Not System.IO.File.Exists(fn) Then Return Nothing
            ' Mở file
            Dim res As New ResXResourceReader(fn)
            ' Lấy Dictionary
            Dim ide As System.Collections.IDictionaryEnumerator
            ide = res.GetEnumerator()
            ' Tìm đến vị trí dầu tiên. Duyệt mảng và đưa vào trong bộ nhớ
            ' Nếu không thể next được nữa có nghĩa là đã hết file
            Do While ide.MoveNext()
                If ide.Key = Key Then
                    Dim b() As Byte = ide.Value
                    Dim ms As New MemoryStream(b)
                    Dim img As System.Drawing.Image
                    img = Image.FromStream(ms)

                    Return img
                End If
            Loop
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return Nothing
    End Function
End Class
