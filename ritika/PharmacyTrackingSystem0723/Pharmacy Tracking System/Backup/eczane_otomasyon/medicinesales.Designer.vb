<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medicinesales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(medicinesales))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_expdate = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_firm = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_mname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_barcode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnislemler = New System.Windows.Forms.ToolStripDropDownButton
        Me.Button2 = New System.Windows.Forms.ToolStripMenuItem
        Me.Button1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ArrangeButton = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteButton = New System.Windows.Forms.ToolStripMenuItem
        Me.btnbicim = New System.Windows.Forms.ToolStripDropDownButton
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.datagrid3 = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.chckinsurance = New System.Windows.Forms.CheckBox
        Me.txtsurname = New System.Windows.Forms.TextBox
        Me.txtphonenumber = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcname = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtidno = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_tp = New System.Windows.Forms.TextBox
        Me.txt_vp = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_sp = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.search = New System.Windows.Forms.TextBox
        Me.cmb1 = New System.Windows.Forms.ComboBox
        Me.FindButton = New System.Windows.Forms.Button
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.datagrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_expdate)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_firm)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_mname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_barcode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(244, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 144)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Medicine Information"
        '
        'txt_expdate
        '
        Me.txt_expdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_expdate.Location = New System.Drawing.Point(111, 111)
        Me.txt_expdate.Name = "txt_expdate"
        Me.txt_expdate.Size = New System.Drawing.Size(84, 21)
        Me.txt_expdate.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Expiration Date"
        '
        'txt_firm
        '
        Me.txt_firm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_firm.Location = New System.Drawing.Point(111, 82)
        Me.txt_firm.Name = "txt_firm"
        Me.txt_firm.Size = New System.Drawing.Size(84, 21)
        Me.txt_firm.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Grower Firm"
        '
        'txt_mname
        '
        Me.txt_mname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mname.Location = New System.Drawing.Point(111, 53)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(84, 21)
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
        Me.txt_barcode.Location = New System.Drawing.Point(111, 24)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(84, 21)
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SeaShell
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnislemler, Me.btnbicim})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(657, 25)
        Me.ToolStrip1.TabIndex = 11
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
        Me.Button2.Size = New System.Drawing.Size(111, 22)
        Me.Button2.Text = "New"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 22)
        Me.Button1.Text = "Save"
        '
        'ArrangeButton
        '
        Me.ArrangeButton.Image = CType(resources.GetObject("ArrangeButton.Image"), System.Drawing.Image)
        Me.ArrangeButton.Name = "ArrangeButton"
        Me.ArrangeButton.Size = New System.Drawing.Size(111, 22)
        Me.ArrangeButton.Text = "Arrange"
        '
        'DeleteButton
        '
        Me.DeleteButton.Image = CType(resources.GetObject("DeleteButton.Image"), System.Drawing.Image)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(111, 22)
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
        'datagrid3
        '
        Me.datagrid3.AllowUserToAddRows = False
        Me.datagrid3.AllowUserToDeleteRows = False
        Me.datagrid3.BackgroundColor = System.Drawing.Color.DarkGray
        Me.datagrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid3.Location = New System.Drawing.Point(24, 320)
        Me.datagrid3.Name = "datagrid3"
        Me.datagrid3.ReadOnly = True
        Me.datagrid3.Size = New System.Drawing.Size(607, 207)
        Me.datagrid3.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.chckinsurance)
        Me.GroupBox2.Controls.Add(Me.txtsurname)
        Me.GroupBox2.Controls.Add(Me.txtphonenumber)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtcname)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtidno)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 267)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Information"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 15)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Insurance"
        '
        'chckinsurance
        '
        Me.chckinsurance.AutoSize = True
        Me.chckinsurance.Location = New System.Drawing.Point(141, 176)
        Me.chckinsurance.Name = "chckinsurance"
        Me.chckinsurance.Size = New System.Drawing.Size(15, 14)
        Me.chckinsurance.TabIndex = 26
        Me.chckinsurance.UseVisualStyleBackColor = True
        '
        'txtsurname
        '
        Me.txtsurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsurname.Location = New System.Drawing.Point(99, 104)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(100, 21)
        Me.txtsurname.TabIndex = 25
        '
        'txtphonenumber
        '
        Me.txtphonenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtphonenumber.Location = New System.Drawing.Point(99, 133)
        Me.txtphonenumber.Name = "txtphonenumber"
        Me.txtphonenumber.Size = New System.Drawing.Size(100, 21)
        Me.txtphonenumber.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Telephone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Surname"
        '
        'txtcname
        '
        Me.txtcname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcname.Location = New System.Drawing.Point(99, 75)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(100, 21)
        Me.txtcname.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Name"
        '
        'txtidno
        '
        Me.txtidno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtidno.Location = New System.Drawing.Point(99, 46)
        Me.txtidno.Name = "txtidno"
        Me.txtidno.Size = New System.Drawing.Size(100, 21)
        Me.txtidno.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "ID No"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txt_tp)
        Me.GroupBox3.Controls.Add(Me.txt_vp)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txt_sp)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(244, 197)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(214, 117)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Total Price"
        '
        'txt_tp
        '
        Me.txt_tp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tp.Enabled = False
        Me.txt_tp.Location = New System.Drawing.Point(95, 75)
        Me.txt_tp.Name = "txt_tp"
        Me.txt_tp.Size = New System.Drawing.Size(100, 21)
        Me.txt_tp.TabIndex = 18
        '
        'txt_vp
        '
        Me.txt_vp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_vp.Enabled = False
        Me.txt_vp.Location = New System.Drawing.Point(95, 46)
        Me.txt_vp.Name = "txt_vp"
        Me.txt_vp.Size = New System.Drawing.Size(100, 21)
        Me.txt_vp.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 15)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "VAT Price"
        '
        'txt_sp
        '
        Me.txt_sp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sp.Location = New System.Drawing.Point(95, 17)
        Me.txt_sp.Name = "txt_sp"
        Me.txt_sp.Size = New System.Drawing.Size(100, 21)
        Me.txt_sp.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 15)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Sales Price"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.search)
        Me.GroupBox4.Controls.Add(Me.cmb1)
        Me.GroupBox4.Controls.Add(Me.FindButton)
        Me.GroupBox4.Location = New System.Drawing.Point(462, 47)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(169, 256)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search"
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(17, 117)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(138, 21)
        Me.search.TabIndex = 22
        '
        'cmb1
        '
        Me.cmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Items.AddRange(New Object() {"Search By ID Number", "Search By Medicine Number"})
        Me.cmb1.Location = New System.Drawing.Point(17, 88)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(138, 23)
        Me.cmb1.TabIndex = 21
        '
        'FindButton
        '
        Me.FindButton.Location = New System.Drawing.Point(105, 164)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(50, 25)
        Me.FindButton.TabIndex = 20
        Me.FindButton.Text = "Find"
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'medicinesales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(657, 535)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.datagrid3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "medicinesales"
        Me.Text = "Medicine Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.datagrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_barcode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnislemler As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Button2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents datagrid3 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_expdate As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_firm As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtsurname As System.Windows.Forms.TextBox
    Friend WithEvents txtphonenumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtidno As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chckinsurance As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_vp As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_sp As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_tp As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents search As System.Windows.Forms.TextBox
    Friend WithEvents cmb1 As System.Windows.Forms.ComboBox
    Friend WithEvents FindButton As System.Windows.Forms.Button
    Friend WithEvents btnbicim As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
End Class
