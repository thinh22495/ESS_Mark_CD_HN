<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TreeViewChuyenNganh
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TreeViewChuyenNganh))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.trvLop = New System.Windows.Forms.TreeView
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.trvLop)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 622)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CHUYÊN NGÀNH ĐÀO TẠO"
        '
        'trvLop
        '
        Me.trvLop.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trvLop.ImageIndex = 0
        Me.trvLop.ImageList = Me.ImageList
        Me.trvLop.Location = New System.Drawing.Point(7, 23)
        Me.trvLop.Name = "trvLop"
        Me.trvLop.SelectedImageIndex = 0
        Me.trvLop.Size = New System.Drawing.Size(257, 590)
        Me.trvLop.TabIndex = 0
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "He.ico")
        Me.ImageList.Images.SetKeyName(1, "He_open.ico")
        Me.ImageList.Images.SetKeyName(2, "Khoa.ico")
        Me.ImageList.Images.SetKeyName(3, "Khoa_open.ico")
        Me.ImageList.Images.SetKeyName(4, "Khoa_hoc.ico")
        Me.ImageList.Images.SetKeyName(5, "Khoa_hoc_open.ico")
        Me.ImageList.Images.SetKeyName(6, "Chuyen_nganh.ico")
        Me.ImageList.Images.SetKeyName(7, "Chuyen_nganh_open.ico")
        Me.ImageList.Images.SetKeyName(8, "Lop.ico")
        '
        'TreeViewChuyenNganh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "TreeViewChuyenNganh"
        Me.Size = New System.Drawing.Size(279, 629)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents trvLop As System.Windows.Forms.TreeView
    Friend WithEvents ImageList As System.Windows.Forms.ImageList

End Class
