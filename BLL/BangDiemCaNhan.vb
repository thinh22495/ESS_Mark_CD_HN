'---------------------------------------------------------------------------
' Author : Nguyễn Khánh Tùng
' Company : Thiên An ESS
' Created Date : Thursday, May 08, 2008
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Entity.Entity
Imports ESS.DAL.DBManager
Namespace Business
    Public Class BangDiemCaNhan_BLL
        
        Private dtBangDiem As DataTable
        Private clsDiem As Diem_BLL
        Sub New(ByVal ID_he As Integer, ByVal ID_dv As String, ByVal dv As DataView, ByVal ID_dt As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            clsDiem = New Diem_BLL(ID_he, ID_dv, dv.Item(0)("ID_sv"), ID_dt, Hoc_ky, Nam_hoc)
            dtBangDiem = clsDiem.BangDiemSinhVien(dv, ID_dt)
        End Sub
        Public Function BangDiem() As System.Data.DataTable
            Return dtBangDiem
        End Function
    End Class
End Namespace

