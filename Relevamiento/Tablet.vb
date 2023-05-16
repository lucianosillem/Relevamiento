Imports System.Data.SqlClient
Imports System.Net
Public Class Tablet
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private Sub Tablet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Tablets where id_CAC = " & ID_CAC & ""
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            results = myReader.GetString(1)
            ComboBox1.Items.Add(results)
        Loop
        myConn.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Tablets where Hostname = '" & ComboBox1.Text & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()

        If myReader.Read() Then
            If myReader.IsDBNull(2) Then
                Return
            Else
                txtModel.Text = myReader.GetString(2) ' Modelo
            End If

            If myReader.IsDBNull(3) Then
                Return
            Else
                txtSerial.Text = myReader.GetString(3) ' Serial
            End If
        End If
        myConn.Close()
        Try
            Dim strHostName As New String(CType("", Char()))
            strHostName = ComboBox1.Text
            Dim ipEntry As IPHostEntry = Dns.GetHostEntry(strHostName)
            Dim addr As IPAddress() = ipEntry.AddressList
            txtIP.Text = addr(0).ToString()
            If My.Computer.Network.Ping(txtIP.Text) Then
                lblPing.Text = "Ping responde"
                lblPing.ForeColor = Color.Green
            Else
                lblPing.Text = "Ping no responde"
                lblPing.ForeColor = Color.Red
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub ConsultarEPOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarEPOToolStripMenuItem.Click
        Dim frmePO As New ePO
        Hostname = ComboBox1.Text
        frmePO.Text = Hostname
        frmePO.MdiParent = RelevamientoMenu
        frmePO.Show()
    End Sub

    Private Sub ControlRemotoConfigurationManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlRemotoConfigurationManagerToolStripMenuItem.Click
        Dim CMRC = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\ConfigMgr10\Setup", "UI Installation Directory", Nothing)
        Process.Start(CMRC & "bin\i386\CmRcViewer.exe", ComboBox1.Text)
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class