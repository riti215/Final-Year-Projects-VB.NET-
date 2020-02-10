Imports System.IO
Imports System.Data.OleDb
Public Class medicineinformation
    Dim DS As New DataSet
    Dim adapt As New OleDbDataAdapter
    Private cnnString As String
    Dim cnn As New OleDbConnection()
    Dim dt As DataTable
    Private Sub close_con()
        If cnn.State = ConnectionState.Open Then cnn.Close()
    End Sub
    Private Sub BaglantiAc()
        cnnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & GetFileName() & ";User Id=admin;Password=;"
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.ConnectionString = cnnString
                cnn.Open()
            End If

        Catch ex As Exception
            MsgBox("Connection Error" & Environment.NewLine & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ab As Integer = 0
        Dim sSQL As String = ""
        sSQL = "INSERT INTO Medicine_Information VALUES (@aBarcode,@aM_Name,@aMaterial_Type,@aBuying_Price,@aSelling_Price,@aFirm,@aExpiry_Date)"
        BaglantiAc()
        Dim cmd As New OleDbCommand()
        cmd.Connection = cnn
        cmd.CommandText = sSQL
        cmd.Parameters.Add(New OleDbParameter("aBarcode", txt_barcode.Text))
        cmd.Parameters.Add(New OleDbParameter("aM_Name", txt_mname.Text))
        cmd.Parameters.Add(New OleDbParameter("aMaterial_Type", cmb_mtype.Text))
        cmd.Parameters.Add(New OleDbParameter("aBuying_Price", txt_bp.Text))
        cmd.Parameters.Add(New OleDbParameter("aSelling_Price", txt_sp.Text))
        cmd.Parameters.Add(New OleDbParameter("aFirm", txt_firm.Text))
        cmd.Parameters.Add(New OleDbParameter("aExpiry_Date", txt_expdate.Text))
        Try
            ab = cmd.ExecuteNonQuery()

            MsgBox(" Added Registration   ")
            NewInfo()
        Catch ex As Exception
            MsgBox(" Error During Operation   " & Environment.NewLine & ex.Message)
        End Try
        FindButton.Enabled = True
        ArrangeButton.Enabled = True
        close_con()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        NewInfo()
    End Sub
    Private Sub NewInfo()
        DS.Tables.Clear()
        datagrid1.DataSource = Nothing
        BaglantiAc()
        Dim sSQL As String = "select * from Medicine_Information"
        Dim cmd As New OleDbCommand(sSQL, cnn)
        adapt.SelectCommand = cmd
        adapt.Fill(DS, "Medicine_Information")
        datagrid1.DataSource = DS.Tables("Medicine_Information").DefaultView
        datagrid1.Columns(0).Width = 40
        datagrid1.Columns(1).Width = 60
        datagrid1.Columns(2).Width = 80
        datagrid1.Columns(3).Width = 40
        datagrid1.Columns(4).Width = 100
        datagrid1.Columns(5).Width = 89
        datagrid1.Columns(6).Width = 60
        If cnn.State = ConnectionState.Open Then cnn.Close()
        datagrid1.Columns(0).HeaderText = "Barcode"
        datagrid1.Columns(1).HeaderText = "M_Name"
        datagrid1.Columns(2).HeaderText = "Material_Type"
        datagrid1.Columns(3).HeaderText = "Buying_Price"
        datagrid1.Columns(4).HeaderText = "Selling_Price"
        datagrid1.Columns(5).HeaderText = "Firm"
        datagrid1.Columns(6).HeaderText = "Expiry_Date"
        txt_barcode.ReadOnly = False
        txt_barcode.Text = ""
        txt_mname.Text = ""
        cmb_mtype.Text = ""
        txt_bp.Text = ""
        txt_sp.Text = ""
        txt_firm.Text = ""
        txt_expdate.Text = ""
        ArrangeButton.Enabled = False
        txt_barcode.Focus()

    End Sub
    Private Sub Medicine_Information_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NewInfo()
        ArrangeButton.Enabled = False
    End Sub

    Private Sub ArrangeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArrangeButton.Click
        Dim sUpdate As String
        sUpdate = "Update Medicine_Information SET Barcode='" & txt_barcode.Text & "',M_Name='" & txt_mname.Text & "',Material_Type='" & cmb_mtype.Text & "',Buying_Price='" & txt_bp.Text & "',Selling_Price='" & txt_sp.Text & "',Firm='" & txt_firm.Text & "',Expiry_Date='" & txt_expdate.Text & "' Where Barcode=" & "'" & txt_barcode.Text & "'"
        Dim cmdd As New OleDbCommand(sUpdate, cnn)
        BaglantiAc()
        Try
            cmdd.ExecuteNonQuery()
            MsgBox("Update Done  ")
        Catch ex As Exception
            MsgBox("Error During Operation" & Environment.NewLine & ex.Message)
        End Try

        NewInfo()
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        Dim bc As Integer = 0
        Dim sSQL As String = ""
        sSQL = "DELETE * FROM Medicine_Information WHERE Barcode=" & "'" & txt_barcode.Text & "'"
        BaglantiAc()
        Dim cmd As New OleDbCommand(sSQL, cnn)
        Try
            bc = cmd.ExecuteNonQuery()
            MsgBox(bc & "Registration Deleted")
        Catch ex As Exception
            MsgBox("Error During Operation" & Environment.NewLine & ex.Message)
        End Try
        close_con()
        NewInfo()
    End Sub
    Public Function GetFromDataTable() As DataTable
        Dim sSQL As String
        Dim dt As New DataTable
        BaglantiAc()
        Dim Barcode As String = txt_barcode.Text
        If cmb2.Text = "Search By Barcode Number" Then
            sSQL = "Select * from Medicine_Information where Barcode = @Barcode "
        Else
            sSQL = "Select * from Medicine_Information where M_Name = @M_Name "
        End If
        Dim da As New OleDbCommand(sSQL, cnn)
        da.Parameters.Add(New OleDbParameter("Barcode", search.Text))
        da.Parameters.Add(New OleDbParameter("M_Name", search.Text))
        Dim dr As New OleDbDataAdapter(da)
        dr.Fill(dt)
        close_con()
        Return dt

    End Function
    Private Sub FindButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindButton.Click


        dt = GetFromDataTable()
        datagrid1.DataSource = dt
        txt_barcode.Text = datagrid1.CurrentRow.Cells(0).Value
        txt_mname.Text = datagrid1.CurrentRow.Cells(1).Value
        cmb_mtype.Text = datagrid1.CurrentRow.Cells(2).Value
        txt_bp.Text = datagrid1.CurrentRow.Cells(3).Value
        txt_sp.Text = datagrid1.CurrentRow.Cells(4).Value
        txt_firm.Text = datagrid1.CurrentRow.Cells(5).Value
        txt_expdate.Text = datagrid1.CurrentRow.Cells(6).Value
        ArrangeButton.Enabled = True
        DeleteButton.Enabled = True
    End Sub

    Private Sub datagrid1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagrid1.CellClick
        txt_barcode.Text = datagrid1.CurrentRow.Cells(0).Value
        txt_mname.Text = datagrid1.CurrentRow.Cells(1).Value
        cmb_mtype.Text = datagrid1.CurrentRow.Cells(2).Value
        txt_bp.Text = datagrid1.CurrentRow.Cells(3).Value
        txt_sp.Text = datagrid1.CurrentRow.Cells(4).Value
        txt_firm.Text = datagrid1.CurrentRow.Cells(5).Value
        txt_expdate.Text = datagrid1.CurrentRow.Cells(6).Value
        ArrangeButton.Enabled = True
        DeleteButton.Enabled = True
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        Me.Font = FontDialog1.Font
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class
