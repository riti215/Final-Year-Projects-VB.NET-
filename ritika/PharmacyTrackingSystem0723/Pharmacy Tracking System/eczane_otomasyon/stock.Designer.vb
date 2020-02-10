<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stock))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_ar = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_qs = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_intake = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_expdate = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.search = New System.Windows.Forms.TextBox
        Me.cmb1 = New System.Windows.Forms.ComboBox
        Me.FindButton = New System.Windows.Forms.Button
        Me.datagrid4 = New System.Windows.Forms.DataGridView
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datagrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_ar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_qs)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_intake)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_expdate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_mname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_barcode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 290)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Medicine Stock Information"
        '
        'txt_ar
        '
        Me.txt_ar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ar.Enabled = False
        Me.txt_ar.ForeColor = System.Drawing.Color.White
        Me.txt_ar.Location = New System.Drawing.Point(119, 218)
        Me.txt_ar.Name = "txt_ar"
        Me.txt_ar.Size = New System.Drawing.Size(84, 21)
        Me.txt_ar.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Amount Remaining"
        '
        'txt_qs
        '
        Me.txt_qs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qs.Location = New System.Drawing.Point(119, 189)
        Me.txt_qs.Name = "txt_qs"
        Me.txt_qs.Size = New System.Drawing.Size(84, 21)
        Me.txt_qs.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Quantity Sold"
        '
        'txt_intake
        '
        Me.txt_intake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_intake.Location = New System.Drawing.Point(119, 160)
        Me.txt_intake.Name = "txt_intake"
        Me.txt_intake.Size = New System.Drawing.Size(84, 21)
        Me.txt_intake.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Intake"
        '
        'txt_expdate
        '
        Me.txt_expdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_expdate.Location = New System.Drawing.Point(119, 131)
        Me.txt_expdate.Name = "txt_expdate"
        Me.txt_expdate.Size = New System.Drawing.Size(84, 21)
        Me.txt_expdate.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Expiration Date"
        '
        'txt_mname
        '
        Me.txt_mname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mname.Location = New System.Drawing.Point(119, 102)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(84, 21)
        Me.txt_mname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Medicine Name"
        '
        'txt_barcode
        '
        Me.txt_barcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_barcode.Location = New System.Drawing.Point(119, 73)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(84, 21)
        Me.txt_barcode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 81)
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
        Me.GroupBox2.Controls.Add(Me.cmb1)
        Me.GroupBox2.Controls.Add(Me.FindButton)
        Me.GroupBox2.Location = New System.Drawing.Point(276, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 290)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Medicine Search"
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(56, 131)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(185, 21)
        Me.search.TabIndex = 25
        '
        'cmb1
        '
        Me.cmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Items.AddRange(New Object() {"Search By Barcode", "Search By Medicine Name"})
        Me.cmb1.Location = New System.Drawing.Point(56, 102)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(185, 23)
        Me.cmb1.TabIndex = 24
        '
        'FindButton
        '
        Me.FindButton.Location = New System.Drawing.Point(244, 129)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(50, 25)
        Me.FindButton.TabIndex = 23
        Me.FindButton.Text = "Find"
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'datagrid4
        '
        Me.datagrid4.AllowUserToAddRows = False
        Me.datagrid4.AllowUserToDeleteRows = False
        Me.datagrid4.BackgroundColor = System.Drawing.Color.DarkGray
        Me.datagrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid4.Location = New System.Drawing.Point(56, 338)
        Me.datagrid4.Name = "datagrid4"
        Me.datagrid4.ReadOnly = True
        Me.datagrid4.Size = New System.Drawing.Size(545, 189)
        Me.datagrid4.TabIndex = 14
        '
        'stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(657, 535)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.datagrid4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "stock"
        Me.Text = "Stock Entry And Following"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datagrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ar As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_qs As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_intake As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_expdate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents datagrid4 As System.Windows.Forms.DataGridView
    Friend WithEvents search As System.Windows.Forms.TextBox
    Friend WithEvents cmb1 As System.Windows.Forms.ComboBox
    Friend WithEvents FindButton As System.Windows.Forms.Button
    Friend WithEvents btnbicim As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
End Class
