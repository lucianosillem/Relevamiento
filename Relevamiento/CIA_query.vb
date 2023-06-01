Imports MySql.Data.MySqlClient
Public Class CIA_query
    Dim ConnectionString As String = "server=corpba-cia;database=cia;uid=queryuser;pwd=Vgp4km67"
    Dim MySQLConn As New MySqlConnection(ConnectionString)

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://corpba-cia/reports/")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MySQLConn.Open()
            MsgBox("Conexión abierta.", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub
End Class