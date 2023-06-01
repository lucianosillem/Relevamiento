Imports MySql.Data.MySqlClient
Public Class CIA_query
    Dim ConnectionString As String = "server=corpba-cia;database=cia;uid=root;pwd="

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://corpba-cia/reports/")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New MySqlConnection(ConnectionString)
        Try
            connection.Open()
            'Dim query As String = "SELECT * FROM logs WHERE service_tag = " & txtSerial.Text
            'Dim command As New MySqlCommand(query, connection)
            'Dim adapter As New MySqlDataAdapter(command)
            'Dim dataSet As New DataSet()

            'adapter.Fill(dataSet)
            'DataGridView1.DataSource = dataSet.Tables(0)
            MsgBox("Conectado.", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub
End Class