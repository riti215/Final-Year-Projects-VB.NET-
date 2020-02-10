Public Class anaform
    Private Function isformopen(ByVal formname As String) As Boolean
        Dim f As Form
        For Each f In Me.MdiChildren
            If f.Name = formname Then Return True
        Next
        Return False
    End Function

    Private Sub MedicineInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedicineInformationToolStripMenuItem.Click
        If isformopen("Medicine_Information") Then Exit Sub
        Dim frm As New medicineinformation
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CustomerInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerInformationToolStripMenuItem.Click
        If isformopen("Customer_Information") Then Exit Sub
        Dim frm As New costumer
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StokBilgileriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StokBilgileriToolStripMenuItem.Click
        If isformopen("Stock") Then Exit Sub
        Dim frm As New stock
        frm.MdiParent = Me
        frm.Show()
    End Sub


   

    Private Sub İlaçSatışToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles İlaçSatışToolStripMenuItem.Click
        If isformopen("ilacsatis") Then Exit Sub
        Dim frm As New medicinesales
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub HakkındaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HakkındaToolStripMenuItem.Click
        If isformopen("hakkinda") Then Exit Sub
        Dim frm As New about
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class