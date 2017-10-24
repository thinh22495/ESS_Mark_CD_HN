'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : 04/02/2008
'---------------------------------------------------------------------------


Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESS.Machine
Imports ESS.Entity.Entity
Namespace DBManager
    Public Class DanhMuc_DAL
        Function LoadTieuDe_BaoCao(ByVal ID_dv As String) As DataTable
            Try
                Dim strSQl As String
                strSQl = "Select * from SYS_BaoCaoTieuDe where ID_dv=N'" & ID_dv & "'"
                Return UDB.SelectTable(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function LoadTieuDe_BaoCao(ByVal ID_dv As String, ByVal UserID As Integer) As DataTable
            Try
                Dim strSQl As String
                strSQl = "Select * from SYS_BaoCaoTieuDe where ID_dv=N'" & ID_dv & "' AND UserID=" & UserID
                Return UDB.SelectTable(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Sub UpdateTieuDe_BaoCao(ByVal ID_dv As String, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Chuc_danh3 As String, ByVal Chuc_danh4 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Nguoi_ky3 As String, ByVal Nguoi_ky4 As String, ByVal Noi_ky As String)
            Try
                Dim strSQl As String
                strSQl = "UPDATE SYS_BaoCaoTieuDe Set " & _
                         " Tieu_de_ten_bo=N'" & Ten_bo & "'," & _
                         " Tieu_de_Ten_truong=N'" & Ten_truong & "'," & _
                         " Tieu_de_chuc_danh1=N'" & Chuc_danh1 & "'," & _
                         " Tieu_de_chuc_danh2=N'" & Chuc_danh2 & "'," & _
                         " Tieu_de_chuc_danh3=N'" & Chuc_danh3 & "'," & _
                         " Tieu_de_chuc_danh4=N'" & Chuc_danh4 & "'," & _
                         " Tieu_de_nguoi_ky1=N'" & Nguoi_ky1 & "'," & _
                         " Tieu_de_nguoi_ky2=N'" & Nguoi_ky2 & "'," & _
                         " Tieu_de_nguoi_ky3=N'" & Nguoi_ky3 & "'," & _
                         " Tieu_de_nguoi_ky4=N'" & Nguoi_ky4 & "'," & _
                         " Tieu_de_noi_ky=N'" & Noi_ky & "'" & _
                         " WHERE ID_dv=N'" & ID_dv & "'"
                UDB.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Sub UpdateTieuDe_BaoCao(ByVal ID_dv As String, ByVal UserID As Integer, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Chuc_danh3 As String, ByVal Chuc_danh4 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Nguoi_ky3 As String, ByVal Nguoi_ky4 As String, ByVal Noi_ky As String)
            Try
                Dim strSQl As String
                strSQl = "UPDATE SYS_BaoCaoTieuDe Set " & _
                         " Tieu_de_ten_bo=N'" & Ten_bo & "'," & _
                         " Tieu_de_Ten_truong=N'" & Ten_truong & "'," & _
                         " Tieu_de_chuc_danh1=N'" & Chuc_danh1 & "'," & _
                         " Tieu_de_chuc_danh2=N'" & Chuc_danh2 & "'," & _
                         " Tieu_de_chuc_danh3=N'" & Chuc_danh3 & "'," & _
                         " Tieu_de_chuc_danh4=N'" & Chuc_danh4 & "'," & _
                         " Tieu_de_nguoi_ky1=N'" & Nguoi_ky1 & "'," & _
                         " Tieu_de_nguoi_ky2=N'" & Nguoi_ky2 & "'," & _
                         " Tieu_de_nguoi_ky3=N'" & Nguoi_ky3 & "'," & _
                         " Tieu_de_nguoi_ky4=N'" & Nguoi_ky4 & "'," & _
                         " Tieu_de_noi_ky=N'" & Noi_ky & "'" & _
                         " WHERE ID_dv=N'" & ID_dv & "' AND UserID=" & UserID
                UDB.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Sub UpdateTieuDe_BaoCao(ByVal ID_dv As String, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Noi_ky As String)
            Try
                Dim strSQl As String
                strSQl = "UPDATE SYS_BaoCaoTieuDe Set " & _
                         " Tieu_de_ten_bo=N'" & Ten_bo & "'," & _
                         " Tieu_de_Ten_truong=N'" & Ten_truong & "'," & _
                         " Tieu_de_chuc_danh1=N'" & Chuc_danh1 & "'," & _
                         " Tieu_de_chuc_danh2=N'" & Chuc_danh2 & "'," & _
                         " Tieu_de_nguoi_ky1=N'" & Nguoi_ky1 & "'," & _
                         " Tieu_de_nguoi_ky2=N'" & Nguoi_ky2 & "'," & _
                         " Tieu_de_noi_ky=N'" & Noi_ky & "'" & _
                         " WHERE ID_dv=N'" & ID_dv & "'"
                UDB.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Sub InsertTieuDe_BaoCao(ByVal ID_dv As String, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Chuc_danh3 As String, ByVal Chuc_danh4 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Nguoi_ky3 As String, ByVal Nguoi_ky4 As String, ByVal Noi_ky As String)
            Try
                Dim strSQl As String
                strSQl = "INSERT INTO SYS_BaoCaoTieuDe(ID_dv,Tieu_de_ten_bo,Tieu_de_Ten_truong,Tieu_de_chuc_danh1,Tieu_de_chuc_danh2,Tieu_de_chuc_danh3,Tieu_de_chuc_danh4,Tieu_de_nguoi_ky1,Tieu_de_nguoi_ky2,Tieu_de_nguoi_ky3,Tieu_de_nguoi_ky4,Tieu_de_noi_ky) Values(" & _
                         " N'" & ID_dv & "'," & _
                         " N'" & Ten_bo & "'," & _
                         " N'" & Ten_truong & "'," & _
                         " N'" & Chuc_danh1 & "'," & _
                         " N'" & Chuc_danh2 & "'," & _
                         " N'" & Chuc_danh3 & "'," & _
                         " N'" & Chuc_danh4 & "'," & _
                         " N'" & Nguoi_ky1 & "'," & _
                         " N'" & Nguoi_ky2 & "'," & _
                         " N'" & Nguoi_ky3 & "'," & _
                         " N'" & Nguoi_ky4 & "'," & _
                         " N'" & Noi_ky & "')"
                UDB.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Sub InsertTieuDe_BaoCao(ByVal ID_dv As String, ByVal UserID As Integer, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Chuc_danh3 As String, ByVal Chuc_danh4 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Nguoi_ky3 As String, ByVal Nguoi_ky4 As String, ByVal Noi_ky As String)
            Try
                Dim strSQl As String
                strSQl = "INSERT INTO SYS_BaoCaoTieuDe(ID_dv,UserID,Tieu_de_ten_bo,Tieu_de_Ten_truong,Tieu_de_chuc_danh1,Tieu_de_chuc_danh2,Tieu_de_chuc_danh3,Tieu_de_chuc_danh4,Tieu_de_nguoi_ky1,Tieu_de_nguoi_ky2,Tieu_de_nguoi_ky3,Tieu_de_nguoi_ky4,Tieu_de_noi_ky) Values(" & _
                         " N'" & ID_dv & "'," & _
                         " " & UserID & "," & _
                         " N'" & Ten_bo & "'," & _
                         " N'" & Ten_truong & "'," & _
                         " N'" & Chuc_danh1 & "'," & _
                         " N'" & Chuc_danh2 & "'," & _
                         " N'" & Chuc_danh3 & "'," & _
                         " N'" & Chuc_danh4 & "'," & _
                         " N'" & Nguoi_ky1 & "'," & _
                         " N'" & Nguoi_ky2 & "'," & _
                         " N'" & Nguoi_ky3 & "'," & _
                         " N'" & Nguoi_ky4 & "'," & _
                         " N'" & Noi_ky & "')"
                UDB.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Sub InsertTieuDe_BaoCao(ByVal ID_dv As String, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Noi_ky As String)
            Try
                Dim strSQl As String
                strSQl = "INSERT INTO SYS_BaoCaoTieuDe(ID_dv,Tieu_de_ten_bo,Tieu_de_Ten_truong,Tieu_de_chuc_danh1,Tieu_de_chuc_danh2,Tieu_de_chuc_danh3,Tieu_de_nguoi_ky1,Tieu_de_nguoi_ky2,Tieu_de_nguoi_ky3,Tieu_de_noi_ky) Values(" & _
                         " N'" & ID_dv & "'," & _
                         " N'" & Ten_bo & "'," & _
                         " N'" & Ten_truong & "'," & _
                         " N'" & Chuc_danh1 & "'," & _
                         " N'" & Chuc_danh2 & "'," & _
                         " N'" & Nguoi_ky1 & "'," & _
                         " N'" & Nguoi_ky2 & "'," & _
                         " N'" & Noi_ky & "')"
                UDB.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Function CheckTieuDe_BaoCao(ByVal ID_dv As String) As Boolean
            Try
                Dim strSQl As String
                strSQl = "SELECT * FROM SYS_BaoCaoTieuDe WHERE ID_dv=N'" & ID_dv & "'"
                If UDB.SelectTable(strSQl).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function CheckTieuDe_BaoCao(ByVal ID_dv As String, ByVal UserID As Integer) As Boolean
            Try
                Dim strSQl As String
                strSQl = "SELECT * FROM SYS_BaoCaoTieuDe WHERE ID_dv=N'" & ID_dv & "' AND UserID=" & UserID
                If UDB.SelectTable(strSQl).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
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
                Dim strField As String = FieldName
                If FieldName1 <> "" Then strField += "," & FieldName1
                If FieldName2 <> "" Then strField += "," & FieldName2
                If FieldName3 <> "" Then strField += "," & FieldName3
                If FieldName4 <> "" Then strField += "," & FieldName4
                If FieldName5 <> "" Then strField += "," & FieldName5
                Dim strValue As String = "N'" & Value & "'"
                If Value1 <> "" Then strValue += ",N'" & Value1 & "'"
                If Value2 <> "" Then strValue += ",N'" & Value2 & "'"
                If Value3 <> "" Then strValue += ",N'" & Value3 & "'"
                If Value4 <> "" Then strValue += ",N'" & Value4 & "'"
                If Value5 <> "" Then strValue += ",N'" & Value5 & "'"
                Dim strSQl As String
                strSQl = "INSERT INTO " & TableName & "(" & strField & ") VALUES(" & strValue & ")"
                UDB.Execute(strSQl)
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
                Dim strField As String = ""
                strField += FieldName & "=N'" & Value & "'"
                If FieldName1 <> "" Then strField += "," & FieldName1 & "=N'" & Value1 & "'"
                If FieldName2 <> "" Then strField += "," & FieldName2 & "=N'" & Value2 & "'"
                If FieldName3 <> "" Then strField += "," & FieldName3 & "=N'" & Value3 & "'"
                If FieldName4 <> "" Then strField += "," & FieldName4 & "=N'" & Value4 & "'"
                If FieldName5 <> "" Then strField += "," & FieldName5 & "=N'" & Value5 & "'"
                Dim strSQl As String
                strSQl = "UPDATE " & TableName & " SET " & strField & " WHERE " & FieldWhere & "=N'" & ValueWhere & "'"
                UDB.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Sub DanhMuc_Delete(ByVal TableName As String, ByVal FieldWhere As Object, ByVal ValueWhere As Object)
            Try
                Dim strSQl As String
                strSQl = "DELETE " & TableName & " WHERE " & FieldWhere & "=N'" & ValueWhere & "'"
                UDB.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Function DanhMuc_CheckName(ByVal TableName As String, ByVal FieldName As String, ByVal ValueName As String) As Boolean
            Try
                Dim strSQl As String
                strSQl = "SELECT * FROM " & TableName & " WHERE " & FieldName & "=N'" & ValueName & "'"
                If UDB.SelectTable(strSQl).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Function DanhMuc_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String) As DataTable
            Dim strSQL As String = "SELECT DISTINCT " + ValueMember + "," + DisplayMember + " FROM " + TableName + " ORDER BY " + DisplayMember
            Dim dt As DataTable = UDB.SelectTable(strSQL)
            Return dt
        End Function

        Function DanhMucSoSanh_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal Bien_DieuKien As String, ByVal DieuKienNhoHon_Input As Integer) As DataTable
            Dim strSQL As String = "SELECT DISTINCT " & ValueMember & "," & DisplayMember & " FROM " & TableName & " WHERE " & Bien_DieuKien & ">=" & DieuKienNhoHon_Input
            Dim dt As DataTable = UDB.SelectTable(strSQL)
            Return dt
        End Function

        Function DanhMuc_Load(ByVal strSQL As String) As DataTable
            Dim dt As DataTable = UDB.SelectTable(strSQL)
            Return dt
        End Function

        Function DanhMuc_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal Bien_DieuKien As String, ByVal DieuKien_Input As String) As DataTable
            Dim strSQL As String = "SELECT DISTINCT " + ValueMember + "," + DisplayMember + " FROM " + TableName + " WHERE " + Bien_DieuKien + "=N'" + DieuKien_Input + "'"
            Dim dt As DataTable = UDB.SelectTable(strSQL)
            Return dt
        End Function

        Function DanhMuc_DKKhac_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal Bien_DieuKien As String, ByVal DieuKien_Input As String) As DataTable
            Dim strSQL As String = "SELECT DISTINCT " + ValueMember + "," + DisplayMember + " FROM " + TableName + " WHERE " + Bien_DieuKien + " not in (" + DieuKien_Input + ")"
            Dim dt As DataTable = UDB.SelectTable(strSQL)
            Return dt
        End Function

        Function DanhMuc_ChuyenNganh_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal Bien_DieuKien As String, ByVal DieuKien_Input As String) As DataTable
            Dim strSQL As String = "SELECT DISTINCT " + ValueMember + "," + DisplayMember + " + '(' + Ma_chuyen_nganh + ')' AS Chuyen_nganh FROM " + TableName + " WHERE " + Bien_DieuKien + " in (" + DieuKien_Input + ")"
            Dim dt As DataTable = UDB.SelectTable(strSQL)
            Return dt
        End Function

        Function DanhMuc_Khoa_Load(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Dim strSQL As String = "SELECT DISTINCT a.ID_khoa,Ten_khoa FROM STU_Khoa a INNER JOIN STU_Lop b ON a.ID_khoa=b.ID_khoa WHERE 1=1 "
            If ID_he > 0 Then strSQL += " AND ID_he=" & ID_he
            If Khoa_hoc > 0 Then strSQL += " AND Khoa_hoc=" & Khoa_hoc
            Dim dt As DataTable = UDB.SelectTable(strSQL)
            Return dt
        End Function

        Function getID_Nganh_Load(ByVal ID_chuyen_nganh As Integer) As Integer
            Dim strSQL As String = "SELECT DISTINCT ID_nganh FROM STU_ChuyenNganh WHERE ID_chuyen_nganh=" & ID_chuyen_nganh & ""
            Dim dt As DataTable = UDB.SelectTable(strSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("ID_nganh")
            Else
                Return 0
            End If
        End Function
        Function getMaNganh(ByVal ID_nganh As Integer) As String
            Dim strSQL As String = "SELECT DISTINCT Ma_nganh FROM STU_Nganh WHERE ID_nganh=" & ID_nganh & ""
            Dim dt As DataTable = UDB.SelectTable(strSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("Ma_nganh")
            Else
                Return "000"
            End If
        End Function
        Function getMaHe(ByVal ID_he As Integer) As String
            Dim strSQL As String = "SELECT DISTINCT Ma_he FROM STU_He WHERE ID_he=" & ID_he & ""
            Dim dt As DataTable = UDB.SelectTable(strSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("Ma_he")
            Else
                Return "0"
            End If
        End Function
        Public Function LoadDanhMuc(ByVal SQL As String) As DataTable
            Return UDB.SelectTable(SQL)
        End Function
        Public Function LoadNienKhoa(ByVal ID_sv As Integer) As String
            Dim sql As String = " select Nien_khoa from STU_Lop l " & _
                                " inner join STU_DanhSach ds On l.ID_lop = ds.ID_lop " & _
                                " where ds.ID_sv=" & ID_sv
            Dim dt As DataTable = UDB.SelectTable(sql)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item(0).ToString
            Else
                Return ""
            End If
        End Function
        Public Function Xep_loai_HB(ByVal ID_xep_loai_hb As Integer) As String
            Dim sql As String = " select * from STU_XepLoaiHocBong " & _
                                " where ID_xep_loai_hb=" & ID_xep_loai_hb
            Dim dt As DataTable = UDB.SelectTable(sql)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("Ten_xep_loai").ToString
            Else
                Return ""
            End If
        End Function
        Public Function GetMaNganh(ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As String
            Dim SQL As String = " select Ma_nganh from STU_Nganh where ID_nganh=" & ID_nganh
            If ID_chuyen_nganh > 0 Then
                SQL = " select Ma_chuyen_nganh from STU_ChuyenNganh where ID_chuyen_nganh=" & ID_chuyen_nganh
            End If
            Dim dt As DataTable = UDB.SelectTable(SQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item(0).ToString
            Else
                Return ""
            End If
        End Function
        Function CheckVerSion() As Boolean
            Dim SQL As String
            Dim dt As DataTable
            SQL = "SELECT ID_sv FROM STU_DanhSachsv"
            dt = UDB.SelectTable(SQL)
            Dim ID_sv As Integer = dt.Rows(0).Item(0)

            If ID_sv = 3 Then
                Return True
            Else
                'Update ID_sv neu dung la ngay cuoi
                SQL = "SELECT getdate()"
                dt = UDB.SelectTable(SQL)
                If Format(dt.Rows(0).Item(0), "dd/MM/yyyy") = "18/08/2008" Then
                    SQL = "UPDATE STU_DanhSachsv set ID_sv=3"
                    UDB.Execute(SQL)
                End If
            End If
            Return False
        End Function
        Public Sub Execute(ByVal SQL As String)
            Try
                UDB.Execute(SQL)
            Catch ex As Exception
            End Try
        End Sub

#Region "Tim kiem"
        ' Load truong tim kiem
        Function LoadFields(ByVal gID_phan_he As Integer, ByVal gObjectID As Integer, ByVal FieldGroup As Integer, Optional ByVal Lua_chon As Boolean = False, Optional ByVal FieldSelect As Boolean = False) As DataTable
            Try
                Dim strSQL As String, strSQLWHERE As String = ""
                If InStr(FieldGroup.ToString, "00") = 0 Then
                    strSQLWHERE = " WHERE FieldGroup=" & FieldGroup
                End If
                strSQL = "SELECT ID, FieldName, FieldID, FieldGroup, FieldType, DTable, DFieldID, DFieldName, WTable, LTable, MTable, RTable, LField, MField, M1Field, RField " & _
                              "FROM SYS_SearchField" & strSQLWHERE
                If FieldSelect Then strSQL += " AND FieldSelect=1"
                strSQL += " ORDER BY FieldGroup, STT"
                Return UDB.SelectTable(strSQL)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load truong hien thi
        Function LoadFieldsShow(ByVal gID_phan_he As Integer, ByVal gObjectID As Integer, ByVal FieldGroup As Integer) As DataTable
            Try
                Dim strSQL As String, strSQLWHERE As String = ""
                If InStr(FieldGroup.ToString, "00") = 0 Then
                    strSQLWHERE = " WHERE FieldGroup=" & FieldGroup
                End If
                strSQL = "SELECT FieldName, FieldID " & _
                              "FROM SYS_FieldShow" & strSQLWHERE
                strSQL += " ORDER BY FieldGroup, STT"
                Return UDB.SelectTable(strSQL)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace


