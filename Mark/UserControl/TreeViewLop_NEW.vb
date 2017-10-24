Imports ESS.BLL.Business
Public Class TreeViewLop_NEW
#Region "Var"
    Private mdtLop As DataTable
    Private mID_he As Integer
    Private mKhoa_hoc As Integer
    Private mID_chuyen_nganh As Integer
    Private mID_lop As Integer
    Private mID_dt_list As String
    Private mNode As New TreeNode
#End Region

#Region "Events"
    Public Event TreeNodeSelected_()
#End Region

#Region "Event Control"
    Private Sub trvLop_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvLop.AfterSelect
        If e.Node Is Nothing Then Exit Sub
        Dim Arr() As String
        Arr = Split(e.Node.Tag, "#")
        mNode.BackColor = trvLop.BackColor
        mNode = e.Node
        mNode.BackColor = System.Drawing.Color.DeepSkyBlue
        e.Node.BackColor = Color.FromArgb(100, 0, 102, 204)
        Me.mKhoa_hoc = 0
        If Arr.Length <= 2 Then
            If Arr.Length >= 1 Then Me.mID_he = Arr(0)
            If Arr.Length >= 2 Then Me.mKhoa_hoc = Arr(1)
            Me.mID_chuyen_nganh = 0
            Me.mID_lop = 0
            Me.mID_dt_list = "0"
        ElseIf Arr.Length <= 3 Then 'Chọn đến chuyên ngành
            Me.mID_he = Arr(0)
            Me.mKhoa_hoc = Arr(1)
            Me.mID_chuyen_nganh = Arr(2)
            'Lấy danh sách các lớp và ID_dt
            mID_lop = 0
            mID_dt_list = ""
            For i As Integer = 0 To dtLop.Rows.Count - 1
                If dtLop.Rows(i)("ID_he").ToString = mID_he And dtLop.Rows(i)("Khoa_hoc").ToString = mKhoa_hoc And dtLop.Rows(i)("ID_chuyen_nganh").ToString = mID_chuyen_nganh Then
                    If InStr(mID_dt_list, dtLop.Rows(i)("ID_dt").ToString + ",") <= 0 Then
                        mID_dt_list += dtLop.Rows(i)("ID_dt").ToString + ","
                    End If
                End If
            Next
            If mID_dt_list <> "" Then mID_dt_list = Mid(mID_dt_list, 1, Len(mID_dt_list) - 1)
        Else 'Chọn đến Lớp
            Me.mID_lop = Arr(3)
            Me.mID_dt_list = Arr(4).ToString
            For i As Integer = 0 To dtLop.Rows.Count - 1
                If dtLop.Rows(i)("ID_lop").ToString = Arr(3).ToString Then
                    Me.mID_he = dtLop.Rows(i)("ID_he").ToString
                    Me.mKhoa_hoc = dtLop.Rows(i)("Khoa_hoc").ToString
                    Me.mID_chuyen_nganh = dtLop.Rows(i)("ID_chuyen_nganh").ToString
                End If
            Next
        End If
        RaiseEvent TreeNodeSelected_()
    End Sub
#End Region

#Region "Function"
    Public Sub Load_TreeView_Theo_HocLai(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
        If Not trvLop Is Nothing Then
            Dim objLop As New DNU_Lop_BLL()
            'mdtLop = objLop.Load
            mdtLop = objLop.Load_LopCoSVHocLai(Hoc_ky, Nam_hoc)
            TreeView_Lop(trvLop, mdtLop)
        End If
    End Sub

    Public Sub Load_TreeView()
        If Not trvLop Is Nothing Then
            'Lấy danh sách các lớp mà User được phép truy cập
            Dim dsID_lop As String = "0"
            For i As Integer = 0 To gobjUser.LopAaccess.Count - 1
                dsID_lop += "," + gobjUser.LopAaccess.UsersLopAcess(i).ToString
            Next
            Dim objLop As New DNU_Lop_BLL(dsID_lop, False)
            mdtLop = objLop.Danh_sach_lop_dang_hoc()
            TreeView_Lop(trvLop, mdtLop)
        End If
    End Sub
    Private Sub TreeView_Lop(ByVal trvLop As TreeView, ByVal dtLop As DataTable, Optional ByVal SelectAll As Boolean = False)
        trvLop.Nodes.Clear()
        Dim dr As DataRow
        Dim ID_He As Integer = 0, Khoa_hoc As Integer = 0, ID_chuyen_nganh As Integer = 0
        Dim i As Integer = -1, k As Integer = -1, l As Integer = -1, m As Integer = -1
        Dim kt_Lop As Boolean = False
        Dim node As TreeNode = Nothing
        For Each dr In dtLop.Rows
            If ID_He = dr.Item("ID_he") Then
Khoa_hoc:
                If Khoa_hoc = dr.Item("Khoa_hoc") Then
Chuyen_nganh:
                    If ID_chuyen_nganh = dr.Item("ID_chuyen_nganh") Then
                        'Add node 4, Lop
Lop_hoc:
                        trvLop.Nodes.Item(i).Nodes.Item(k).Nodes(l).Nodes.Add(dr.Item("Ten_lop"))
                        trvLop.Nodes(i).Nodes(k).Nodes(l).Nodes(m).Tag = dr.Item("ID_he") & "#" & dr.Item("Khoa_hoc") & "#" & dr.Item("ID_chuyen_nganh") & "#" & dr.Item("ID_lop") & "#" & dr.Item("ID_dt")
                        trvLop.Nodes(i).Nodes(k).Nodes(l).Nodes(m).ImageIndex = 8
                        trvLop.Nodes(i).Nodes(k).Nodes(l).Nodes(m).SelectedImageIndex = 8
                        m += 1
                    Else 'Add node 3, Chuyen nganh
                        l += 1
                        trvLop.Nodes.Item(i).Nodes.Item(k).Nodes.Add("C.Ngành: " & dr.Item("Chuyen_nganh"))
                        trvLop.Nodes(i).Nodes(k).Nodes(l).Tag = dr.Item("ID_he") & "#" & dr.Item("Khoa_hoc") & "#" & dr.Item("ID_chuyen_nganh")
                        trvLop.Nodes(i).Nodes(k).Nodes(l).ImageIndex = 6
                        trvLop.Nodes(i).Nodes(k).Nodes(l).SelectedImageIndex = 7
                        m = 0
                        'Add node 4, Lop hoc
                        GoTo Lop_hoc
                    End If
                Else 'Add node 2, Khoa
                    k += 1
                    trvLop.Nodes.Item(i).Nodes.Add("Khoá: " & dr.Item("Khoa_hoc"))
                    trvLop.Nodes(i).Nodes(k).Tag = dr.Item("ID_he") & "#" & dr.Item("Khoa_hoc")
                    trvLop.Nodes(i).Nodes(k).ImageIndex = 4
                    trvLop.Nodes(i).Nodes(k).SelectedImageIndex = 5
                    l = -1
                    ID_chuyen_nganh = 0
                    'Add node 3, Chuyen nganh
                    GoTo Chuyen_nganh
                End If
            Else 'Add node 0, He
                i = i + 1
                trvLop.Nodes.Add("Trình độ: " & dr.Item("Ten_he"))
                trvLop.Nodes(i).Tag = dr.Item("ID_he")
                trvLop.Nodes.Item(i).ImageIndex = 0
                trvLop.Nodes.Item(i).SelectedImageIndex = 1
                trvLop.Nodes.Item(i).Expand()
                k = -1
                Khoa_hoc = 0
                GoTo Khoa_hoc
            End If
            ID_He = dr.Item("ID_he")
            Khoa_hoc = dr.Item("khoa_hoc")
            ID_chuyen_nganh = dr.Item("ID_chuyen_nganh")
        Next
    End Sub
#End Region

#Region "Property"
    Public Property dtLop() As DataTable
        Get
            Return mdtLop
        End Get
        Set(ByVal Value As DataTable)
            mdtLop = Value
        End Set
    End Property
    Public ReadOnly Property ID_he() As Integer
        Get
            Return mID_he
        End Get
    End Property
    Public ReadOnly Property Khoa_hoc() As Integer
        Get
            Return mKhoa_hoc
        End Get
    End Property
    Public ReadOnly Property ID_chuyen_nganh() As Integer
        Get
            Return mID_chuyen_nganh
        End Get
    End Property
    Public ReadOnly Property ID_lop() As Integer
        Get
            Return mID_lop
        End Get
    End Property
    Public ReadOnly Property ID_dt_list() As String
        Get
            Return mID_dt_list
        End Get
    End Property
    ' Lấy tiêu đề báo cáo
    Public ReadOnly Property Tieu_de() As String
        Get
            Dim Arr() As String, strTieu_de As String = ""
            Arr = Split(trvLop.SelectedNode.FullPath, "\")
            If Arr.Length > 4 Then
                strTieu_de = "Lớp: " + Arr(4)
            Else
                For i As Integer = 0 To Arr.Length - 1
                    ' Bỏ tiêu đề khoa
                    If i <> 1 Then strTieu_de += Arr(i) + ", "
                Next
                If strTieu_de <> "" Then strTieu_de = Mid(strTieu_de, 1, Len(strTieu_de) - 2)
            End If
            Return strTieu_de
        End Get
    End Property
    ' Lấy tiêu đề báo cáo
    Public ReadOnly Property Ten_he() As String
        Get
            Dim Arr() As String, strTieu_de As String = ""
            Arr = Split(trvLop.SelectedNode.FullPath, "\")
            If Arr.Length > 1 Then
                strTieu_de = Arr(0)
            End If
            Return strTieu_de
        End Get
    End Property
#End Region
End Class
