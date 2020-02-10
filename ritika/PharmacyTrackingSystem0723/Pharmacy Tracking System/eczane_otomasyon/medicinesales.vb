Imports System.IO
Imports System.Data.OleDb
Public Class medicinesales
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
            MsgBox("Connection Error" & Environment.NewLine & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt_vp.Text = (txt_sp.Text * 18%) / 100
        txt_tp.Text = (txt_sp.Text) + (txt_sp.Text) / 100 * 18%
        Dim ab As Integer = 0
        Dim sSQL As String = ""
        sSQL = "INSERT INTO Medicine_Sales VALUES (@aId_No,@aC_Name,@aC_SrName,@aPhoneNumber,@aInsurance,@aBarcode,@aM_Name,@aFirm,@aExpiry_Date,@aSelling_Price,@aVat_Price,@aTotal_Price)"
        BaglantiAc()
        Dim cmd As New OleDbCommand()
        cmd.Connection = cnn
        cmd.CommandText = sSQL
        cmd.Parameters.Add(New OleDbParameter("aId_No", txtidno.Text))
        cmd.Parameters.Add(New OleDbParameter("aC_Name", txtcname.Text))
        cmd.Parameters.Add(New OleDbParameter("aC_SrName", txtsurname.Text))
        cmd.Parameters.Add(New OleDbParameter("aPhoneNumber", txtphonenumber.Text))
        cmd.Parameters.Add(New OleDbParameter("aInsurance", chckinsurance.Checked))
        cmd.Parameters.Add(New OleDbParameter("aBarcode", txt_barcode.Text))
        cmd.Parameters.Add(New OleDbParameter("aM_Name", txt_mname.Text))
        cmd.Parameters.Add(New OleDbParameter("aFirm", txt_firm.Text))
        cmd.Parameters.Add(New OleDbParameter("aExpiry_Date", txt_expdate.Text))
        cmd.Parameters.Add(New OleDbParameter("aSelling_Price", txt_sp.Text))
        cmd.Parameters.Add(New OleDbParameter("aVat_Price", txt_vp.Text))
        cmd.Parameters.Add(New OleDbParameter("aTotal_Price", txt_tp.Text))
        Try
            ab = cmd.ExecuteNonQuery()

            MsgBox("Added Registration")
            New_Info()
        Catch ex As Exception
            MsgBox("Error During Operation" & Environment.NewLine & ex.Message)
        End Try
        ArrangeButton.Enabled = True
        con_close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        New_Info()

    End Sub
    Private Sub New_Info()
        DS.Tables.Clear()
        datagrid3.DataSource = Nothing
        BaglantiAc()
        Dim sSQL As String = "select * from Medicine_Sales"
        Dim cmd As New OleDbCommand(sSQL, cnn)
        adapt.SelectCommand = cmd
        adapt.Fill(DS, "Medicine_Sales")
        datagrid3.DataSource = DS.Tables("Medicine_Sales").DefaultView
        If cnn.State = ConnectionState.Open Then cnn.Close()
        datagrid3.Columns(0).HeaderText = "Id_No"
        datagrid3.Columns(1).HeaderText = "C_Name"
        datagrid3.Columns(2).HeaderText = "C_SrName"
        datagrid3.Columns(3).HeaderText = "PhoneNumber"
        datagrid3.Columns(4).HeaderText = "Insurance"
        datagrid3.Columns(7).HeaderText = "Barcode"
        datagrid3.Columns(8).HeaderText = "M_Name"
        datagrid3.Columns(9).HeaderText = "Firm"
        datagrid3.Columns(10).HeaderText = "Expiry_Date"
        datagrid3.Columns(11).HeaderText = "Selling_Price"
        'datagrid3.Columns(12).HeaderText = "Vat_Price"
        'datagrid3.Columns(13).HeaderText = "Total_Price"
        txt_barcode.ReadOnly = False
        txtidno.Text = ""
        txtcname.Text = ""
        txtsurname.Text = ""
        txtphonenumber.Text = ""
        chckinsurance.Checked = False
        txt_barcode.Text = ""
        txt_mname.Text = ""
        txt_firm.Text = ""
        txt_expdate.Text = ""
        txt_sp.Text = ""
        txt_vp.Text = ""
        txt_tp.Text = ""
        ArrangeButton.Enabled = False
        txtidno.Focus()

    End Sub

    Private Sub Medicine_Sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        New_Info()
        ArrangeButton.Enabled = False
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        Dim bc As Integer = 0
        Dim sSQL As String = ""
        sSQL = "DELETE * FROM Medicine_Sales WHERE Id_No=" & "'" & txtidno.Text & "'"
        BaglantiAc()
        Dim cmd As New OleDbCommand(sSQL, cnn)
        Try
            bc = cmd.ExecuteNonQuery()
            MsgBox(bc & "Registration Deleted")
        Catch ex As Exception
            MsgBox("Error During Operation" & Environment.NewLine & ex.Message)
        End Try
        con_close()
        New_Info()
    End Sub
    Public Function GetFromDataTable() As DataTable
        Dim sSQL As String
        Dim dt As New DataTable
        BaglantiAc()
        Dim Id_No As String = txtidno.Text
        If cmb1.Text = "Search by ID" Then
            sSQL = "Select * from Customer_Information where Id_No = @Id_No "
        Else
            sSQL = "Select * from Customer_Information where C_Name = @C_Name "
        End If
        Dim da As New OleDbCommand(sSQL, cnn)
        da.Parameters.Add(New OleDbParameter("tckimlik", search.Text))
        da.Parameters.Add(New OleDbParameter("barkod", search.Text))
        Dim dr As New OleDbDataAdapter(da)
        dr.Fill(dt)
        con_close()
        Return dt

    End Function
    Private Sub datagrid3_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagrid3.CellClick
        txtidno.Text = datagrid3.CurrentRow.Cells(0).Value
        txtcname.Text = datagrid3.CurrentRow.Cells(1).Value
        txtsurname.Text = datagrid3.CurrentRow.Cells(2).Value
        txtphonenumber.Text = datagrid3.CurrentRow.Cells(3).Value
        chckinsurance.Checked = datagrid3.CurrentRow.Cells(4).Value
        txt_barcode.Text = datagrid3.CurrentRow.Cells(7).Value
        txt_mname.Text = datagrid3.CurrentRow.Cells(8).Value
        txt_firm.Text = datagrid3.CurrentRow.Cells(9).Value
        txt_expdate.Text = datagrid3.CurrentRow.Cells(10).Value
        txt_sp.Text = datagrid3.CurrentRow.Cells(11).Value
        txt_vp.Text = datagrid3.CurrentRow.Cells(12).Value
        txt_tp.Text = datagrid3.CurrentRow.Cells(13).Value
        ArrangeButton.Enabled = True
        DeleteButton.Enabled = True
    End Sub

    Private Sub FindButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindButton.Click
        dt = GetFromDataTable()
        datagrid3.DataSource = dt
        txtidno.Text = datagrid3.CurrentRow.Cells(0).Value
        txtcname.Text = datagrid3.CurrentRow.Cells(1).Value
        txtsurname.Text = datagrid3.CurrentRow.Cells(2).Value
        txtphonenumber.Text = datagrid3.CurrentRow.Cells(3).Value
        chckinsurance.Checked = datagrid3.CurrentRow.Cells(4).Value
        txt_barcode.Text = datagrid3.CurrentRow.Cells(7).Value
        txt_mname.Text = datagrid3.CurrentRow.Cells(8).Value
        txt_firm.Text = datagrid3.CurrentRow.Cells(9).Value
        txt_expdate.Text = datagrid3.CurrentRow.Cells(10).Value
        txt_sp.Text = datagrid3.CurrentRow.Cells(11).Value
        txt_vp.Text = datagrid3.CurrentRow.Cells(12).Value
        txt_tp.Text = datagrid3.CurrentRow.Cells(13).Value
        ArrangeButton.Enabled = True
        DeleteButton.Enabled = True
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        Me.Font = FontDialog1.Font
    End Sub

    Private Sub ArrangeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArrangeButton.Click
        Dim sUpdate As String
        sUpdate = "Update Medicine_Sales SET Id_No='" & txtidno.Text & "',C_Name='" & txtcname.Text & "',C_SrName='" & txtsurname.Text & "',PhoneNumber='" & txtphonenumber.Text & "',Insurance=" & chckinsurance.Checked & ",Barcode='" & txt_barcode.Text & "',M_Name='" & txt_mname.Text & "',Firm='" & txt_firm.Text & "',Expiry_Date='" & txt_expdate.Text & "',Selling_Price='" & txt_sp.Text & "',Vat_Price='" & txt_vp.Text & "',Total_Price='" & txt_tp.Text & "' Where Id_No=" & "'" & txtidno.Text & "'"
        Dim cmdd As New OleDbCommand(sUpdate, cnn)
        BaglantiAc()
        Try
            cmdd.ExecuteNonQuery()
            MsgBox("Update Done")
        Catch ex As Exception
            MsgBox("Exception During Operation" & Environment.NewLine & ex.Message)
        End Try

        New_Info()
    End Sub
  

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub txt_vp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_vp.TextChanged

    End Sub

    Private Sub txt_tp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_tp.TextChanged

    End Sub
End Class