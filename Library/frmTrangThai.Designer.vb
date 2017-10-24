<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrangThai
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.prgSlave = New System.Windows.Forms.ProgressBar
        Me.prgMaster = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'prgSlave
        '
        Me.prgSlave.Location = New System.Drawing.Point(0, 35)
        Me.prgSlave.Name = "prgSlave"
        Me.prgSlave.Size = New System.Drawing.Size(373, 34)
        Me.prgSlave.TabIndex = 3
        '
        'prgMaster
        '
        Me.prgMaster.Location = New System.Drawing.Point(0, 0)
        Me.prgMaster.Name = "prgMaster"
        Me.prgMaster.Size = New System.Drawing.Size(373, 34)
        Me.prgMaster.TabIndex = 2
        '
        'frmTrangThai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 69)
        Me.Controls.Add(Me.prgSlave)
        Me.Controls.Add(Me.prgMaster)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTrangThai"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTrangThai"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents prgSlave As System.Windows.Forms.ProgressBar
    Friend WithEvents prgMaster As System.Windows.Forms.ProgressBar
End Class
