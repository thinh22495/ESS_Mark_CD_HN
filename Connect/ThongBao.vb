Public Class frmThongBao
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Private Sub QuanLyNut(ByVal Nut As NutHienThi)
        Select Case Nut
            Case NutHienThi.DongY
                btnBoQua.Visible = False
                btnKhong.Visible = False
                btnDongY.Left = btnKhong.Left
            Case NutHienThi.DongYKhong
                btnBoQua.Visible = False
                Dim space As Integer = CInt(btnDongY.Width / 2)
                btnDongY.Left = btnKhong.Left - space
                btnKhong.Left += space
            Case NutHienThi.DongYKhongHuy
        End Select
    End Sub

    Private Sub QuanLyAnh(ByVal Anh As AnhThongBao)
        Select Case Anh
            Case AnhThongBao.ThongBao
                Pic.Image = PictureBox1.Image
            Case AnhThongBao.Loi
                Pic.Image = PictureBox2.Image
            Case AnhThongBao.Hoi
                Pic.Image = PictureBox3.Image
            Case AnhThongBao.CanhBao
                Pic.Image = PictureBox4.Image
            Case AnhThongBao.Dung
                Pic.Image = PictureBox5.Image
        End Select
    End Sub

    Public Sub New(ByVal TieuDe As String, ByVal ThongDiep As String, ByVal Nut As NutHienThi, ByVal Anh As AnhThongBao, ByVal align As System.Drawing.ContentAlignment)
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        Me.Text = TieuDe
        lblMsg.Text = ThongDiep
        lblMsg.TextAlign = align
        QuanLyNut(Nut)
        QuanLyAnh(Anh)
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnDongY As System.Windows.Forms.Button
    Friend WithEvents btnKhong As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents Pic As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBoQua As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmThongBao))
        Me.btnDongY = New System.Windows.Forms.Button
        Me.btnKhong = New System.Windows.Forms.Button
        Me.btnBoQua = New System.Windows.Forms.Button
        Me.lblMsg = New System.Windows.Forms.Label
        Me.Pic = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'btnDongY
        '
        Me.btnDongY.Location = New System.Drawing.Point(80, 152)
        Me.btnDongY.Name = "btnDongY"
        Me.btnDongY.Size = New System.Drawing.Size(96, 32)
        Me.btnDongY.TabIndex = 0
        Me.btnDongY.Text = "Đồng Ý"
        '
        'btnKhong
        '
        Me.btnKhong.Location = New System.Drawing.Point(176, 152)
        Me.btnKhong.Name = "btnKhong"
        Me.btnKhong.Size = New System.Drawing.Size(96, 32)
        Me.btnKhong.TabIndex = 1
        Me.btnKhong.Text = "Không"
        '
        'btnBoQua
        '
        Me.btnBoQua.Location = New System.Drawing.Point(272, 152)
        Me.btnBoQua.Name = "btnBoQua"
        Me.btnBoQua.Size = New System.Drawing.Size(96, 32)
        Me.btnBoQua.TabIndex = 2
        Me.btnBoQua.Text = "Bỏ Qua"
        '
        'lblMsg
        '
        Me.lblMsg.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblMsg.Location = New System.Drawing.Point(72, 32)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(352, 96)
        Me.lblMsg.TabIndex = 3
        Me.lblMsg.Text = "Msg"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pic
        '
        Me.Pic.Image = CType(resources.GetObject("Pic.Image"), System.Drawing.Image)
        Me.Pic.Location = New System.Drawing.Point(12, 56)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(52, 48)
        Me.Pic.TabIndex = 4
        Me.Pic.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(88, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 48)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(136, 64)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 48)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(192, 64)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(52, 48)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(248, 64)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(52, 48)
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(304, 64)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(52, 48)
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'frmThongBao
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(450, 199)
        Me.ControlBox = False
        Me.Controls.Add(Me.Pic)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnBoQua)
        Me.Controls.Add(Me.btnKhong)
        Me.Controls.Add(Me.btnDongY)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmThongBao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThongBao"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmThongBao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnDongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDongY.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnKhong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKhong.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnBoQua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoQua.Click
        Me.DialogResult = DialogResult.Abort
    End Sub
End Class
