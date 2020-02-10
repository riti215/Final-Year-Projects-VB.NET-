<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class costumer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(costumer))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnislemler = New System.Windows.Forms.ToolStripDropDownButton
        Me.Button2 = New System.Windows.Forms.ToolStripMenuItem
        Me.Button1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ArrangeButton = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteButton = New System.Windows.Forms.ToolStripMenuItem
        Me.btnbicim = New System.Windows.Forms.ToolStripDropDownButton
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtsurname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.chckinsurance = New System.Windows.Forms.CheckBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtphonenumber = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.datagrid2 = New System.Windows.Forms.DataGridView
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtidno = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.search = New System.Windows.Forms.TextBox
        Me.cmb1 = New System.Windows.Forms.ComboBox
        Me.FindButton = New System.Windows.Forms.Button
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.ToolStrip1.SuspendLayout()
        CType(Me.datagrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.ToolStrip1.TabIndex = 4
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
        'txtsurname
        '
        Me.txtsurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsurname.Location = New System.Drawing.Point(107, 80)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(100, 21)
        Me.txtsurname.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Insurance"
        '
        'chckinsurance
        '
        Me.chckinsurance.AutoSize = True
        Me.chckinsurance.Location = New System.Drawing.Point(151, 198)
        Me.chckinsurance.Name = "chckinsurance"
        Me.chckinsurance.Size = New System.Drawing.Size(15, 14)
        Me.chckinsurance.TabIndex = 10
        Me.chckinsurance.UseVisualStyleBackColor = True
        '
        'txtaddress
        '
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaddress.Location = New System.Drawing.Point(107, 138)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(100, 57)
        Me.txtaddress.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Address"
        '
        'txtphonenumber
        '
        Me.txtphonenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtphonenumber.Location = New System.Drawing.Point(107, 109)
        Me.txtphonenumber.Name = "txtphonenumber"
        Me.txtphonenumber.Size = New System.Drawing.Size(100, 21)
        Me.txtphonenumber.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Surname"
        '
        'datagrid2
        '
        Me.datagrid2.AllowUserToAddRows = False
        Me.datagrid2.AllowUserToDeleteRows = False
        Me.datagrid2.BackgroundColor = System.Drawing.Color.DarkGray
        Me.datagrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid2.Location = New System.Drawing.Point(52, 305)
        Me.datagrid2.Name = "datagrid2"
        Me.datagrid2.ReadOnly = True
        Me.datagrid2.Size = New System.Drawing.Size(552, 212)
        Me.datagrid2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Telephone"
        '
        'txtcname
        '
        Me.txtcname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcname.Location = New System.Drawing.Point(107, 51)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(100, 21)
        Me.txtcname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'txtidno
        '
        Me.txtidno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtidno.Location = New System.Drawing.Point(107, 22)
        Me.txtidno.Name = "txtidno"
        Me.txtidno.Size = New System.Drawing.Size(100, 21)
        Me.txtidno.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtsurname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.chckinsurance)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtphonenumber)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtidno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 256)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID No"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.search)
        Me.GroupBox2.Controls.Add(Me.cmb1)
        Me.GroupBox2.Controls.Add(Me.FindButton)
        Me.GroupBox2.Location = New System.Drawing.Point(360, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 256)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Search"
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(17, 117)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(159, 21)
        Me.search.TabIndex = 22
        '
        'cmb1
        '
        Me.cmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Items.AddRange(New Object() {"Search by ID Number", "Search by Name"})
        Me.cmb1.Location = New System.Drawing.Point(17, 88)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(159, 23)
        Me.cmb1.TabIndex = 21
        '
        'FindButton
        '
        Me.FindButton.Location = New System.Drawing.Point(182, 114)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(50, 25)
        Me.FindButton.TabIndex = 20
        Me.FindButton.Text = "Find"
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'costumer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(657, 535)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.datagrid2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "costumer"
        Me.Text = "Customer Registration and Tracking"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.datagrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnislemler As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Button2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtsurname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chckinsurance As System.Windows.Forms.CheckBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtphonenumber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents datagrid2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtidno As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents search As System.Windows.Forms.TextBox
    Friend WithEvents cmb1 As System.Windows.Forms.ComboBox
    Friend WithEvents FindButton As System.Windows.Forms.Button
    Friend WithEvents btnbicim As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
End Class
