Imports MySql.Data.MySqlClient
Imports System.Data.Odbc
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim da As New MySqlDataAdapter("select * from tbl_provinsi", KonekDb)
        Dim dt As New DataTable
        Dim KonekDB As New 
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

End Class