Imports System.IO
Imports System.Data.OleDb
Module genel
    Public Function GetFileName() As String
        Dim dAd As String = Directory.GetCurrentDirectory() & "\Data\eczane.mdb"
        Return dAd
    End Function
End Module
