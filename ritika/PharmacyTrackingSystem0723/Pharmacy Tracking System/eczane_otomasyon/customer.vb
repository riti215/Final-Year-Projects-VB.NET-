Imports System.IO
Imports System.Data.OleDb
Public Class costumer
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
        Dim ab As Integer = 0
        Dim sSQL As String = ""
        sSQL = "INSERT INTO Customer_Information VALUES (@aId_No,@aC_Name,@aC_SrName,@aPhoneNumber,@aAddress,@aInsurance)"
        BaglantiAc()
        Dim cmd As New OleDbCommand()
        cmd.Connection = cnn
        cmd.CommandText = sSQL
        cmd.Parameters.Add(New OleDbParameter("aId_No", txtidno.Text))
        cmd.Parameters.Add(New OleDbParameter("aC_Name", txtcname.Text))
        cmd.Parameters.Add(New OleDbParameter("aC_SrName", txtsurname.Text))
        cmd.Parameters.Add(New OleDbParameter("aPhoneNumber", txtphonenumber.Text))
        cmd.Parameters.Add(New OleDbParameter("aAddress", txtaddress.Text))
        cmd.Parameters.Add(New OleDbParameter("aInsurance", chckinsurance.Checked))

        Try
            ab = cmd.ExecuteNonQuery()

            MsgBox("Registration Added")
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
        datagrid2.DataSource = Nothing
        BaglantiAc()
        Dim sSQL As String = "select * from Customer_Information"
        Dim cmd As New OleDbCommand(sSQL, cnn)
        adapt.SelectCommand = cmd
        adapt.Fill(DS, "Customer_Information")
        datagrid2.DataSource = DS.Tables("Customer_Information").DefaultView
        datagrid2.Columns(0).Width = 40
        datagrid2.Columns(1).Width = 60
        datagrid2.Columns(2).Width = 80
        datagrid2.Columns(3).Width = 40
        datagrid2.Columns(4).Width = 100
        datagrid2.Columns(5).Width = 89
        'datagrid2.Columns(6).Width = 60
        'datagrid2.Columns(7).Width = 60
        If cnn.State = ConnectionState.Open Then cnn.Close()
        datagrid2.Columns(0).HeaderText = "Id_No"
        datagrid2.Columns(1).HeaderText = "C_Name"
        datagrid2.Columns(2).HeaderText = "C_SrName"
        datagrid2.Columns(3).HeaderText = "PhoneNumber"
        datagrid2.Columns(4).HeaderText = "Address"
        datagrid2.Columns(5).HeaderText = "Insurance"
        datagrid2.ReadOnly = False
        txtidno.Text = ""
        txtcname.Text = ""
        txtsurname.Text = ""
        txtphonenumber.Text = ""
        txtaddress.Text = ""
        chckinsurance.Checked = False
        ArrangeButton.Enabled = False
        txtidno.Focus()
    End Sub

    Private Sub Customer_Information_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        New_Info()
        ArrangeButton.Enabled = False
    End Sub

    Private Sub ArrangeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArrangeButton.Click
        Dim sUpdate As String
        sUpdate = "Update Customer_Information SET Id_No='" & txtidno.Text & "',C_Name='" & txtcname.Text & "',C_SrName='" & txtsurname.Text & "',PhoneNumber='" & txtphonenumber.Text & "',Address='" & txtaddress.Text & "',Insurance=" & chckinsurance.Checked & " Where Id_No=" & "'" & txtidno.Text & "'"
        Dim cmdd As New OleDbCommand(sUpdate, cnn)
        BaglantiAc()
        Try
            cmdd.ExecuteNonQuery()
            MsgBox("Update Done")
        Catch ex As Exception
            MsgBox("Error During Operation" & Environment.NewLine & ex.Message)
        End Try

        New_Info()
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        Dim bc As Integer = 0
        Dim sSQL As String = ""
        sSQL = "DELETE * FROM Customer_Information WHERE Id_No=" & "'" & txtidno.Text & "'"
        BaglantiAc()
        Dim cmd As New OleDbCommand(sSQL, cnn)
        Try
            bc = cmd.ExecuteNonQuery()
            MsgBox(bc & "Registration deleted")
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
        If cmb1.Text = "Search by Customer ID" Then
            sSQL = "Select * from Customer_Information where Id_No = @Id_No"
        Else
            sSQL = "Select * from Customer_Information where C_Name = @C_Name "
        End If
        Dim da As New OleDbCommand(sSQL, cnn)
        da.Parameters.Add(New OleDbParameter("Id_No", search.Text))
        da.Parameters.Add(New OleDbParameter("C_Name", search.Text))
        Dim dr As New OleDbDataAdapter(da)
        dr.Fill(dt)
        con_close()
        Return dt

    End Function

    Private Sub FindButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindButton.Click
        dt = GetFromDataTable()
        datagrid2.DataSource = dt
        txtidno.Text = datagrid2.CurrentRow.Cells(0).Value
        txtcname.Text = datagrid2.CurrentRow.Cells(1).Value
        txtsurname.Text = datagrid2.CurrentRow.Cells(2).Value
        txtphonenumber.Text = datagrid2.CurrentRow.Cells(3).Value
        txtaddress.Text = datagrid2.CurrentRow.Cells(4).Value
        chckinsurance.Checked = datagrid2.CurrentRow.Cells(5).Value
        ArrangeButton.Enabled = True
        DeleteButton.Enabled = True
    End Sub

    Private Sub datagrid2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagrid2.CellClick
        txtidno.Text = datagrid2.CurrentRow.Cells(0).Value
        txtcname.Text = datagrid2.CurrentRow.Cells(1).Value
        txtsurname.Text = datagrid2.CurrentRow.Cells(2).Value
        txtphonenumber.Text = datagrid2.CurrentRow.Cells(3).Value
        txtaddress.Text = datagrid2.CurrentRow.Cells(4).Value
        chckinsurance.Checked = datagrid2.CurrentRow.Cells(5).Value
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
