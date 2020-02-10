<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class anaform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MedicineInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StokBilgileriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.İlaçSatışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HakkındaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MedicineInformationToolStripMenuItem, Me.CustomerInformationToolStripMenuItem, Me.StokBilgileriToolStripMenuItem, Me.İlaçSatışToolStripMenuItem, Me.HakkındaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(746, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MedicineInformationToolStripMenuItem
        '
        Me.MedicineInformationToolStripMenuItem.Name = "MedicineInformationToolStripMenuItem"
        Me.MedicineInformationToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.MedicineInformationToolStripMenuItem.Text = "Medicine Information"
        '
        'CustomerInformationToolStripMenuItem
        '
        Me.CustomerInformationToolStripMenuItem.Name = "CustomerInformationToolStripMenuItem"
        Me.CustomerInformationToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.CustomerInformationToolStripMenuItem.Text = "Customer Information"
        '
        'StokBilgileriToolStripMenuItem
        '
        Me.StokBilgileriToolStripMenuItem.Name = "StokBilgileriToolStripMenuItem"
        Me.StokBilgileriToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.StokBilgileriToolStripMenuItem.Text = "Stock Information"
        '
        'İlaçSatışToolStripMenuItem
        '
        Me.İlaçSatışToolStripMenuItem.Name = "İlaçSatışToolStripMenuItem"
        Me.İlaçSatışToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.İlaçSatışToolStripMenuItem.Text = "Medicine Sales"
        '
        'HakkındaToolStripMenuItem
        '
        Me.HakkındaToolStripMenuItem.Name = "HakkındaToolStripMenuItem"
        Me.HakkındaToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.HakkındaToolStripMenuItem.Text = "About"
        '
        'anaform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(746, 451)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "anaform"
        Me.Text = "Pharmacy Tracking System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MedicineInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StokBilgileriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents İlaçSatışToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HakkındaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
