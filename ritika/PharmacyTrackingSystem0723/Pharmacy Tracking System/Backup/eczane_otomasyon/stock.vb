Imports System.IO
Imports System.Data.OleDb
Public Class stock
    Dim DS As New DataSet
    Dim adapt As New OleDbDataAdapter
    Private cnnString As String
    Dim cnn As New OleDbConnection()
    Dim dt As DataTable
    Private Sub con_close()
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
            MsgBox("Error in Connection" & Environment.NewLine & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt_ar.Text = txt_intake.Text - txt_qs.Text
        Dim ab As Integer = 0
        Dim sSQL As String = ""
        sSQL = "INSERT INTO Stock VALUES (@aBarcode,@aM_Name,@aExpiry_Date,@aIntake,@aQuantity_Sold,@aAmount_Remaining)"
        BaglantiAc()
        Dim cmd As New OleDbCommand()
        cmd.Connection = cnn
        cmd.CommandText = sSQL
        cmd.Parameters.Add(New OleDbParameter("aBarcode", txt_barcode.Text))
        cmd.Parameters.Add(New OleDbParameter("aM_Name", txt_mname.Text))
        cmd.Parameters.Add(New OleDbParameter("aExpiry_Ddate", txt_expdate.Text))
        cmd.Parameters.Add(New OleDbParameter("aIntake", txt_intake.Text))
        cmd.Parameters.Add(New OleDbParameter("aQuantity_Sold", txt_qs.Text))
        cmd.Parameters.Add(New OleDbParameter("aAmount_Remaining", txt_ar.Text))
        Try
            ab = cmd.ExecuteNonQuery()

            MsgBox("Registration Added")
            new_info()
        Catch ex As Exception
            MsgBox("Error During Operation" & Environment.NewLine & ex.Message)
        End Try
        FindButton.Enabled = True
        ArrangeButton.Enabled = True
        con_close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        new_info()
    End Sub
    Private Sub new_info()
        DS.Tables.Clear()
        datagrid4.DataSource = Nothing
        BaglantiAc()
        Dim sSQL As String = "select * from Stock"
        Dim cmd As New OleDbCommand(sSQL, cnn)
        adapt.SelectCommand = cmd
        adapt.Fill(DS, "Stock")
        datagrid4.DataSource = DS.Tables("Stock").DefaultView
        datagrid4.Columns(0).Width = 60
        datagrid4.Columns(1).Width = 60
        datagrid4.Columns(2).Width = 80
        datagrid4.Columns(3).Width = 100
        datagrid4.Columns(4).Width = 100
        datagrid4.Columns(5).Width = 100
        If cnn.State = ConnectionState.Open Then cnn.Close()
        datagrid4.Columns(0).HeaderText = "Barcode"
        datagrid4.Columns(1).HeaderText = "M_Name"
        datagrid4.Columns(2).HeaderText = "Expiry_Date"
        datagrid4.Columns(3).HeaderText = "Intake"
        datagrid4.Columns(4).HeaderText = "Quantity_Sold"
        datagrid4.Columns(5).HeaderText = "Amount_Remaining"
        txt_barcode.ReadOnly = False
        ArrangeButton.Enabled = False
        DeleteButton.Enabled = False
        txt_barcode.Text = ""
        txt_mname.Text = ""
        txt_expdate.Text = ""
        txt_intake.Text = ""
        txt_qs.Text = ""
        txt_ar.Text = ""
        cmb1.Text = ""
        search.Text = ""
        ArrangeButton.Enabled = False
    End Sub

    Private Sub Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        new_info()
        ArrangeButton.Enabled = False
        DeleteButton.Enabled = False
    End Sub

    Private Sub ArrangeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArrangeButton.Click
        txt_ar.Text = txt_intake.Text - txt_qs.Text
        Dim sUpdate As String
        sUpdate = "Update Stock SET M_Name='" & txt_mname.Text & "',Expiry_Date='" & txt_expdate.Text & "',Intake='" & txt_intake.Text & "',Quantity_Sold='" & txt_qs.Text & "',Amount_Remaining='" & txt_ar.Text & "' Where Barcode=" & "'" & txt_barcode.Text & "'"
        Dim cmdd As New OleDbCommand(sUpdate, cnn)
        BaglantiAc()
        Try
            cmdd.ExecuteNonQuery()
            MsgBox("Update Done")
        Catch ex As Exception
            MsgBox("Error during operation" & Environment.NewLine & ex.Message)
        End Try
        new_info()
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        Dim bc = 0
        Dim sSQL As String = ""
        sSQL = "DELETE * FROM Stock WHERE Barcode=" & "'" & txt_barcode.Text & "'"
        BaglantiAc()
        Dim cmd As New OleDbCommand(sSQL, cnn)
        Try
            bc = cmd.ExecuteNonQuery()
            MsgBox(bc & "Registration Deleted")
        Catch ex As Exception
            MsgBox("Error in operation" & Environment.NewLine & ex.Message)
        End Try
        con_close()
        new_info()
    End Sub
    Public Function GetFromDataTable() As DataTable
        Dim sSQL As String
        Dim dt As New DataTable
        BaglantiAc()
        Dim barkod As String = txt_barcode.Text
        If cmb1.Text = "Search by Barcode number" Then
            sSQL = "Select * from Stock where Barcode = @Barcode "
        Else
            sSQL = "Select * from Stock where M_Name = @M_Name "
        End If
        Dim da As New OleDbCommand(sSQL, cnn)
        da.Parameters.Add(New OleDbParameter("Barcode", search.Text))
        da.Parameters.Add(New OleDbParameter("M_Name", search.Text))
        Dim dr As New OleDbDataAdapter(da)
        dr.Fill(dt)
        con_close()
        Return dt
    End Function

    Private Sub FindButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindButton.Click
        dt = GetFromDataTable()
        datagrid4.DataSource = dt
        txt_barcode.Text = datagrid4.CurrentRow.Cells(0).Value
        txt_mname.Text = datagrid4.CurrentRow.Cells(1).Value
        txt_expdate.Text = datagrid4.CurrentRow.Cells(2).Value
        txt_intake.Text = datagrid4.CurrentRow.Cells(3).Value
        txt_qs.Text = datagrid4.CurrentRow.Cells(4).Value
        txt_ar.Text = datagrid4.CurrentRow.Cells(5).Value
        ArrangeButton.Enabled = True
        DeleteButton.Enabled = True
    End Sub

    Private Sub datagrid4_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagrid4.CellClick
        txt_barcode.Text = datagrid4.CurrentRow.Cells(0).Value
        txt_mname.Text = datagrid4.CurrentRow.Cells(1).Value
        txt_expdate.Text = datagrid4.CurrentRow.Cells(2).Value
        txt_intake.Text = datagrid4.CurrentRow.Cells(3).Value
        txt_qs.Text = datagrid4.CurrentRow.Cells(4).Value
        txt_ar.Text = datagrid4.CurrentRow.Cells(5).Value
        ArrangeButton.Enabled = True
        DeleteButton.Enabled = True
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        Me.Font = FontDialog1.Font
    End Sub
End Class