'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/21/2008
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class VaiTro_BLL
#Region "Variable"
        Public aVaiTro As ArrayList
#End Region
#Region "Constructor"
        Public Sub New()

        End Sub
        Public Sub New(ByVal ID_vai_tro As Integer)
            Try
                Dim obj As VaiTro_DAL = New VaiTro_DAL
                Dim dt As DataTable = obj.Load_VaiTroQuyen(ID_vai_tro)
                Dim objsVaiTro As New VaiTro
                Dim dr As DataRow = Nothing
                If dt.Rows.Count > 0 Then
                    objsVaiTro = Converting(dt.Rows(0))
                    For Each dr In dt.Rows
                        Dim objVaitroQuyen As New VaiTroQuyen
                        objVaitroQuyen.ID_ph = dr("ID_ph")
                        objVaitroQuyen.ID_quyen = dr("ID_quyen")
                        objVaitroQuyen.ID_nhom_quyen = dr("ID_nhom_quyen")
                        objVaitroQuyen.Ten_quyen = dr("Ten_quyen")
                        objVaitroQuyen.Them = dr("Them")
                        objVaitroQuyen.Sua = dr("Sua")
                        objVaitroQuyen.Xoa = dr("Xoa")
                        'Add Quyen cua VaiTro
                        objsVaiTro.VaiTroQuyen.Add(objVaitroQuyen)
                    Next
                End If
                'Add đối tượng VaiTro vào danh sách
                aVaiTro = New ArrayList
                aVaiTro.Add(objsVaiTro)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Function"
        ''Load các quyền đã được gán cho vai trò
        Public Function Load_VaiTroQuyenGan_List() As DataTable
            Try
                Dim dt As DataTable = New DataTable
                Dim i As Integer, j As Integer
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_ph", GetType(Integer))
                dt.Columns.Add("ID_Quyen", GetType(Integer))
                dt.Columns.Add("Ten_Quyen", GetType(String))
                dt.Columns.Add("Them", GetType(Boolean))
                dt.Columns.Add("Sua", GetType(Boolean))
                dt.Columns.Add("Xoa", GetType(Boolean))
                For i = 0 To aVaiTro.Count - 1
                    Dim vaitro As VaiTro = CType(aVaiTro(i), VaiTro)
                    If Not vaitro Is Nothing Then
                        For j = 0 To vaitro.VaiTroQuyen.Count - 1
                            Dim row As DataRow = dt.NewRow()
                            row("Chon") = False
                            row("ID_ph") = vaitro.VaiTroQuyen.VaiTroQuyen(j).ID_ph
                            row("ID_Quyen") = vaitro.VaiTroQuyen.VaiTroQuyen(j).ID_quyen
                            row("Ten_Quyen") = vaitro.VaiTroQuyen.VaiTroQuyen(j).Ten_quyen
                            row("Them") = CovertingIntToBool(vaitro.VaiTroQuyen.VaiTroQuyen(j).Them)
                            row("Sua") = CovertingIntToBool(vaitro.VaiTroQuyen.VaiTroQuyen(j).Sua)
                            row("Xoa") = CovertingIntToBool(vaitro.VaiTroQuyen.VaiTroQuyen(j).Xoa)
                            dt.Rows.Add(row)
                        Next
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        '' Load các vai trò của một User
        Public Function Load_VaiTro(ByVal UserID As Integer) As DataTable
            Try
                Dim obj As VaiTro_DAL = New VaiTro_DAL
                Return obj.Load_VaiTro_List(UserID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ''Load các quyền của một User theo một vai trò
        Public Function Load_UsersQuyen_List(ByVal User As Users, ByVal ID_vai_tro As Integer) As DataTable
            Try
                Dim obj As VaiTro_DAL = New VaiTro_DAL
                Dim dtUsersQuyen As DataTable = obj.Load_UserQuyen(User.UserID, ID_vai_tro)
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_ph", GetType(Integer))
                dt.Columns.Add("ID_Quyen", GetType(Integer))
                dt.Columns.Add("Ten_Quyen", GetType(String))
                dt.Columns.Add("Them", GetType(Boolean))
                dt.Columns.Add("Sua", GetType(Boolean))
                dt.Columns.Add("Xoa", GetType(Boolean))
                For j As Integer = 0 To dtUsersQuyen.Rows.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("ID_ph") = dtUsersQuyen.Rows(j)("ID_ph")
                    row("ID_Quyen") = dtUsersQuyen.Rows(j)("ID_Quyen")
                    row("Ten_Quyen") = dtUsersQuyen.Rows(j)("Ten_Quyen")
                    row("Them") = False
                    row("Sua") = False
                    row("Xoa") = False
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ''Load các phân hệ của một User
        Public Function Load_PhanHe_List(ByVal User As Users) As DataTable
            Try
                Dim obj As VaiTro_DAL = New VaiTro_DAL
                If User.UserGroup = -1 Then
                    Return obj.Load_PhanHe()
                Else
                    Return obj.Load_PhanHe_List(User)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function


   

        ''Thêm mới một vai trò
        Public Function Insert_VaiTro(ByVal objVaiTro As VaiTro) As Integer
            Try
                Dim obj As VaiTro_DAL = New VaiTro_DAL
                Return obj.Insert_VaiTro(objVaiTro)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Sửa lại một vai trò
        Public Function Update_VaiTro(ByVal objVaiTro As VaiTro, ByVal ID_vai_tro As Integer) As Integer
            Try
                Dim obj As VaiTro_DAL = New VaiTro_DAL
                Return obj.Update_VaiTro(objVaiTro, ID_vai_tro)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''Xóa Một Vai trò
        Public Function Delete_VaiTro(ByVal ID_vai_tro As Integer) As Integer
            Try
                Dim obj As VaiTro_DAL = New VaiTro_DAL
                Return obj.Delete_VaiTro(ID_vai_tro)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ''Thêm các quyền cho một vai trò
        Public Function Insert_VaiTroQuyen(ByVal idx As Integer) As Integer
            Try
                Dim objVaiTro As New VaiTro
                objVaiTro = CType(aVaiTro(idx), VaiTro)
                For i As Integer = 0 To objVaiTro.VaiTroQuyen.Count - 1
                    Insert_VaiTroQuyen(objVaiTro.VaiTroQuyen.VaiTroQuyen(i), objVaiTro.ID_vai_tro)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''Thêm mới các quyền cho một vai trò
        Public Function Insert_VaiTroQuyen(ByVal objVaiTroQuyen As VaiTroQuyen, ByVal ID_Vai_tro As Integer) As Integer
            Try
                Dim obj As VaiTro_DAL = New VaiTro_DAL
                Return obj.Insert_VaiTroQuyen(objVaiTroQuyen, ID_Vai_tro)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''Xóa Hết các quyền của một vai trò
        Public Function Delete_VaiTroQuyen(ByVal ID_vai_tro As Integer) As Integer
            Try
                Dim obj As VaiTro_DAL = New VaiTro_DAL
                Return obj.Delete_VaiTroQuyen(ID_vai_tro)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''Thêm mới một vai trò cho User
        Public Function Insert_UsersVaiTro(ByVal UserID As Integer, ByVal ID_vai_tro As Integer) As Integer
            Try
                Dim obj As VaiTro_DAL = New VaiTro_DAL
                Return obj.Insert_UsersVaiTro(UserID, ID_vai_tro)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Xóa một vai trò của User
        Public Function Delete_UsersVaitro(ByVal UserID As Integer, ByVal ID_vai_tro As Integer) As Integer
            Try
                Dim obj As VaiTro_DAL = New VaiTro_DAL
                Return obj.Delete_UsersVaitro(UserID, ID_vai_tro)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        '' Kiểm tra vai trò đã được gán quyền chưa?
        Public Function CheckExist_htVaiTroQuyen(ByVal ID_vai_tro As Integer) As Boolean
            Try
                Dim obj As VaiTro_DAL = New VaiTro_DAL
                Return obj.CheckExist_VaiTroQuyen(ID_vai_tro)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Property VaiTro(ByVal idx As Integer) As VaiTro
            Get
                Return CType(Me.aVaiTro(idx), VaiTro)
            End Get
            Set(ByVal Value As VaiTro)
                Me.aVaiTro(idx) = Value
            End Set
        End Property

    
#Region "Convert Function" '' Các hàm Convert
        '' Convert sang Kiểu VaiTro
        Private Function Converting(ByVal drVaiTro As DataRow) As VaiTro
            Dim result As VaiTro
            Try
                result = New VaiTro
                If drVaiTro("ID_vai_tro").ToString() <> "" Then result.ID_vai_tro = CType(drVaiTro("ID_vai_tro").ToString(), Integer)
                result.Ten_vai_tro = drVaiTro("Ten_vai_tro").ToString()
                result.Mo_ta = drVaiTro("Mo_ta").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        '' Convert sang kiểu Vaitro nhưng có thêm các trường Thêm, Sửa, Xóa, Chọn
        Private Function ConvertingVaiTro(ByVal drVaiTro As DataRow) As VaiTro
            Dim result As VaiTro
            Try
                result = New VaiTro
                If drVaiTro("ID_vai_tro").ToString() <> "" Then result.ID_vai_tro = CType(drVaiTro("ID_vai_tro").ToString(), Integer)
                If drVaiTro("ID_ph").ToString() <> "" Then result.VaiTroQuyen.ID_ph = CType(drVaiTro("ID_ph").ToString(), Integer)
                If drVaiTro("ID_quyen").ToString() <> "" Then result.VaiTroQuyen.ID_quyen = CType(drVaiTro("ID_quyen").ToString(), Integer)
                If drVaiTro("Ten_Quyen").ToString() <> "" Then result.VaiTroQuyen.Ten_quyen = CType(drVaiTro("Ten_Quyen").ToString(), String)
                If drVaiTro("Them").ToString() <> "" Then result.VaiTroQuyen.Them = CType(CovertingBoolToInt(drVaiTro("Them").ToString()), Integer)
                If drVaiTro("Sua").ToString() <> "" Then result.VaiTroQuyen.Sua = CType(CovertingBoolToInt(drVaiTro("Sua").ToString()), Integer)
                If drVaiTro("Xoa").ToString() <> "" Then result.VaiTroQuyen.Xoa = CType(CovertingBoolToInt(drVaiTro("Xoa").ToString()), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result

        End Function
        '' Convert sang kiểu VaiTroQuyen
        Private Function ConvertingVaiTroQuyen(ByVal drVaiTroQuyen As DataRow) As VaiTroQuyen
            Dim result As VaiTroQuyen
            Try
                result = New VaiTroQuyen
                If drVaiTroQuyen("ID_quyen").ToString() <> "" Then result.ID_quyen = CType(drVaiTroQuyen("ID_quyen").ToString(), Integer)
                If drVaiTroQuyen("Them").ToString() <> "" Then result.Them = CType(CovertingBoolToInt(drVaiTroQuyen("Them").ToString()), Integer)
                If drVaiTroQuyen("Sua").ToString() <> "" Then result.Sua = CType(CovertingBoolToInt(drVaiTroQuyen("Sua").ToString()), Integer)
                If drVaiTroQuyen("Xoa").ToString() <> "" Then result.Xoa = CType(CovertingBoolToInt(drVaiTroQuyen("Xoa").ToString()), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        '' Covert Từ Boolean sang Integer
        Public Function CovertingBoolToInt(ByVal Int As Boolean) As Integer
            If Int Then
                Return 1
            Else
                Return 0
            End If
        End Function
        '' Convert từ Integer sang Boolean
        Private Function CovertingIntToBool(ByVal Int As Integer) As Boolean
            If Int = 1 Then
                Return True
            ElseIf Int = 0 Then
                Return False
            End If
        End Function
#End Region

#End Region
    End Class
End Namespace
