<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medicineinformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(medicineinformation))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnislemler = New System.Windows.Forms.ToolStripDropDownButton
        Me.Button2 = New System.Windows.Forms.ToolStripMenuItem
        Me.Button1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ArrangeButton = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteButton = New System.Windows.Forms.ToolStripMenuItem
        Me.btnbicim = New System.Windows.Forms.ToolStripDropDownButton
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.search = New System.Windows.Forms.TextBox
        Me.cmb2 = New System.Windows.Forms.ComboBox
        Me.FindButton = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_expdate = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_firm = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_sp = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_bp = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_mtype = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_mname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_barcode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.datagrid1 = New System.Windows.Forms.DataGridView
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SeaShell
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnislemler, Me.btnbicim})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(657, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnislemler
        '
        Me.btnislemler.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Button2, Me.Button1, Me.ArrangeButton, Me.DeleteButton})
        Me.btnislemler.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnislemler.Image = CType(resources.GetObject("btnislemler.Image"), System.Drawing.Image)
        Me.btnislemler.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnislemler.Name = "btnislemler"
        Me.btnislemler.Size = New System.Drawing.Size(97, 22)
        Me.btnislemler.Text = "Transactions"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 22)
        Me.Button2.Text = "New"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 22)
        Me.Button1.Text = "Save"
        '
        'ArrangeButton
        '
        Me.ArrangeButton.Image = CType(resources.GetObject("ArrangeButton.Image"), System.Drawing.Image)
        Me.ArrangeButton.Name = "ArrangeButton"
        Me.ArrangeButton.Size = New System.Drawing.Size(152, 22)
        Me.ArrangeButton.Text = "Arrange"
        '
        'DeleteButton
        '
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Image = CType(resources.GetObject("DeleteButton.Image"), System.Drawing.Image)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(152, 22)
        Me.DeleteButton.Text = "Delete"
        '
        'btnbicim
        '
        Me.btnbicim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnbicim.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem})
        Me.btnbicim.Image = CType(resources.GetObject("btnbicim.Image"), System.Drawing.Image)
        Me.btnbicim.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnbicim.Name = "btnbicim"
        Me.btnbicim.Size = New System.Drawing.Size(52, 22)
        Me.btnbicim.Text = "Format"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.search)
        Me.GroupBox2.Controls.Add(Me.cmb2)
        Me.GroupBox2.Controls.Add(Me.FindButton)
        Me.GroupBox2.Location = New System.Drawing.Point(297, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 233)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Medicine Search"
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(30, 111)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(219, 21)
        Me.search.TabIndex = 22
        '
        'cmb2
        '
        Me.cmb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb2.FormattingEnabled = True
        Me.cmb2.Items.AddRange(New Object() {"Search By Medicine Barcode Number", "Search By Medicine Name"})
        Me.cmb2.Location = New System.Drawing.Point(30, 82)
        Me.cmb2.Name = "cmb2"
        Me.cmb2.Size = New System.Drawing.Size(219, 23)
        Me.cmb2.TabIndex = 21
        '
        'FindButton
        '
        Me.FindButton.Location = New System.Drawing.Point(252, 109)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(50, 25)
        Me.FindButton.TabIndex = 20
        Me.FindButton.Text = "Find"
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_expdate)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_firm)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_sp)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_bp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_mtype)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_mname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_barcode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 233)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Medicine Information"
        '
        'txt_expdate
        '
        Me.txt_expdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_expdate.Location = New System.Drawing.Point(132, 198)
        Me.txt_expdate.Name = "txt_expdate"
        Me.txt_expdate.Size = New System.Drawing.Size(100, 21)
        Me.txt_expdate.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Expiration Date"
        '
        'txt_firm
        '
        Me.txt_firm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_firm.Location = New System.Drawing.Point(132, 169)
        Me.txt_firm.Name = "txt_firm"
        Me.txt_firm.Size = New System.Drawing.Size(100, 21)
        Me.txt_firm.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Grower Firm"
        '
        'txt_sp
        '
        Me.txt_sp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sp.Location = New System.Drawing.Point(132, 140)
        Me.txt_sp.Name = "txt_sp"
        Me.txt_sp.Size = New System.Drawing.Size(100, 21)
        Me.txt_sp.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sales Price"
        '
        'txt_bp
        '
        Me.txt_bp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bp.Location = New System.Drawing.Point(132, 111)
        Me.txt_bp.Name = "txt_bp"
        Me.txt_bp.Size = New System.Drawing.Size(100, 21)
        Me.txt_bp.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Buying Price"
        '
        'cmb_mtype
        '
        Me.cmb_mtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mtype.FormattingEnabled = True
        Me.cmb_mtype.Items.AddRange(New Object() {"Medicine", "Cosmetic", "Veterinary", "Medical Supplies"})
        Me.cmb_mtype.Location = New System.Drawing.Point(132, 82)
        Me.cmb_mtype.Name = "cmb_mtype"
        Me.cmb_mtype.Size = New System.Drawing.Size(100, 23)
        Me.cmb_mtype.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Material Type"
        '
        'txt_mname
        '
        Me.txt_mname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mname.Location = New System.Drawing.Point(132, 53)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(100, 21)
        Me.txt_mname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Medicine Name"
        '
        'txt_barcode
        '
        Me.txt_barcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_barcode.Location = New System.Drawing.Point(132, 24)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(100, 21)
        Me.txt_barcode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Medicine Barcode"
        '
        'datagrid1
        '
        Me.datagrid1.AllowUserToAddRows = False
        Me.datagrid1.AllowUserToDeleteRows = False
        Me.datagrid1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid1.Location = New System.Drawing.Point(33, 273)
        Me.datagrid1.Name = "datagrid1"
        Me.datagrid1.ReadOnly = True
        Me.datagrid1.Size = New System.Drawing.Size(589, 565)
        Me.datagrid1.TabIndex = 10
        '
        'medicineinformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(657, 535)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.datagrid1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "medicineinformation"
        Me.Text = "Medicine Registration and Following"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnislemler As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Button2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_firm As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_sp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_bp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_mtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_barcode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents datagrid1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_expdate As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents FindButton As System.Windows.Forms.Button
    Friend WithEvents ArrangeButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmb2 As System.Windows.Forms.ComboBox
    Friend WithEvents search As System.Windows.Forms.TextBox
    Friend WithEvents btnbicim As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog

End Class
