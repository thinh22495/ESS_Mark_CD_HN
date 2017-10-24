'Written by Do Huy Loc
Imports System.IO
Imports ThienAn.Machine
Imports System.Windows.Forms
Public Class clsConnect_data
    Dim ServerName, DatabaseName As String

    Sub New()
        Dim ds As DataSet = New DataSet
        Dim strFileName As String = Path.GetDirectoryName(Application.ExecutablePath).ToLower() & "\UniSoftSetup.ini"

        If File.Exists(strFileName) = True Then
            Try
                Dim ini As New ThienAn.Machine.IniFile(strFileName)
                gDBType = ini.ReadValue("UNISOFT_SERVER", "DBType").Trim
                ServerName = ini.ReadValue("UNISOFT_SERVER", "ServerName").Trim
                DatabaseName = ini.ReadValue("UNISOFT_SERVER", "DatabaseName").Trim
            Catch ex As Exception
                Thongbao("Không mở được file UNISOFTSetup.ini", MsgBoxStyle.Critical)
            End Try
        Else
            Thongbao("Không tìm thấy file UNISOFTSetup.ini trong thư mục chạy", MsgBoxStyle.Critical)
        End If
    End Sub
    'Connect to database
    Function Load_Connection_data() As Boolean
        Dim sConnString As String
        If gDBType = DatabaseType.SQLServer Then
            sConnString = "Data Source=" & ServerName & ";" & _
                                        "Initial Catalog=" & DatabaseName & ";" & _
                                        "User Id=" & gUserLogin & ";" & _
                                        "Password=" & gPwd
        Else
            sConnString = "Data Source=" + ServerName + ";User Id=" + DatabaseName + ";Password=" + gPwd
        End If
        UDB.SetConnectionString(sConnString)
        UDB.SetDBType(gDBType)
        Return True
    End Function
End Class



