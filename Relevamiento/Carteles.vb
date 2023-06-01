Imports System.Net

Public Class Carteles
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private Sub Carteles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Carteles where id_CAC = " & ID_CAC & ""
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
        myCmd.CommandText = "Select * from Carteles where Hostname = '" & ComboBox1.Text & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Const V As String = "NULL"
        If myReader.Read() Then

            If myReader.IsDBNull(2) Then
                txtNQflow.Text = V
            Else
                txtNQflow.Text = myReader.GetString(2) ' UsuarioQflow
            End If

        End If

        myConn.Close()

        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=CM_AMX;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT System_DATA.Name0, Computer_System_DATA.Model00, PC_BIOS_DATA.SerialNumber00, PHYSICAL_DISK_DATA.Model00 FROM System_DATA INNER JOIN Computer_System_DATA ON System_DATA.MachineID = Computer_System_DATA.MachineID INNER JOIN PC_BIOS_DATA ON System_DATA.MachineID = PC_BIOS_DATA.MachineID INNER JOIN PHYSICAL_DISK_DATA ON System_DATA.MachineID = PHYSICAL_DISK_DATA.MachineID WHERE Name0 = '" & ComboBox1.Text & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        If myReader.Read() Then

            If myReader.IsDBNull(1) Then
                txtModel.Text = V
            Else
                txtModel.Text = myReader.GetString(1) ' Modelo
            End If

            If myReader.IsDBNull(2) Then
                txtSerial.Text = V
            Else
                txtSerial.Text = myReader.GetString(2) ' Serial
            End If

            If myReader.IsDBNull(3) Then
                txtDisco.Text = V
            Else
                txtDisco.Text = myReader.GetString(3) ' Disco
            End If
        End If

        myConn.Close()

        ListBox1.Items.Clear()
        Label9.Text = ""
        Try
            Dim ipEntry As IPHostEntry = Dns.GetHostEntry(ComboBox1.Text)
            Dim addr As IPAddress() = ipEntry.AddressList
            Dim i As Integer = 0
            While i < addr.Length
                ListBox1.Items.Add(addr(i).ToString())
                i += 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            If My.Computer.Network.Ping(ListBox1.SelectedItem) Then
                Label9.Text = "Ping responde"
                Label9.ForeColor = Color.Green
                ReiniciarToolStripMenuItem.Enabled = True
            Else
                Label9.Text = "Ping no responde"
                Label9.ForeColor = Color.Red
                ReiniciarToolStripMenuItem.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ControlRemotoConfigurationManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlRemotoConfigurationManagerToolStripMenuItem.Click
        Dim CMRC = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\ConfigMgr10\Setup", "UI Installation Directory", Nothing)
        Process.Start(CMRC & "bin\i386\CmRcViewer.exe", ComboBox1.Text)
    End Sub

    Private Sub ReiniciarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReiniciarToolStripMenuItem.Click
        If ComboBox1.Text = "" Then
            MsgBox("Debe seleccionar primero un cartel.", vbExclamation)
        Else
            Process.Start("cmd", "/c shutdown -m \\" & ComboBox1.Text & " -r -t 0 -f")
            MsgBox("Se envió el comando de reinicio a " & ComboBox1.Text & ".", vbInformation)
        End If
    End Sub

    Private Sub EditarHostnameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarHostnameToolStripMenuItem.Click
        If ComboBox1.Text = "" Then
            MsgBox("Debe seleccionar primero un cartel.", vbExclamation)
        Else
            Try
                Dim NuevoHostname As String = InputBox("Nuevo valor", "Relevamiento", ComboBox1.Text)
                If NuevoHostname <> "" Then
                    myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
                    myCmd = myConn.CreateCommand
                    myCmd.CommandText = "Update Carteles Set Hostname = '" & NuevoHostname & "' where N_Qflow = '" & txtNQflow.Text & "'"
                    myConn.Open()
                    myCmd.ExecuteNonQuery()
                    myConn.Close()

                    ComboBox1.Items.Clear()
                    ComboBox1.Text = ""
                    txtModel.Text = ""
                    txtSerial.Text = ""
                    txtNQflow.Text = ""

                    myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
                    myCmd = myConn.CreateCommand
                    myCmd.CommandText = "Select * from Carteles where id_CAC = " & ID_CAC & ""
                    myConn.Open()
                    myReader = myCmd.ExecuteReader()
                    Do While myReader.Read()
                        results = myReader.GetString(1)
                        ComboBox1.Items.Add(results)
                    Loop

                    myConn.Close()
                Else
                    MsgBox("Debe ingresar un valor.", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbExclamation)
            End Try
        End If
    End Sub

    Private Sub NuevoCartelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoCartelToolStripMenuItem.Click
        Try
            Dim NuevoHostname As String = InputBox("Hostname", "Relevamiento", "")
            Dim NuevoUsr_Qflow As String = InputBox("Usuario QFlow", "Relevamiento", "")
            If NuevoHostname <> "" And NuevoUsr_Qflow <> "" Then
                myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
                myCmd = myConn.CreateCommand
                myCmd.CommandText = "insert into Carteles Values (" & ID_CAC & ",'" & NuevoHostname & "','" & NuevoUsr_Qflow & "')"
                myConn.Open()
                myCmd.ExecuteNonQuery()
                myConn.Close()

                ComboBox1.Items.Clear()
                ComboBox1.Text = ""
                txtModel.Text = ""
                txtSerial.Text = ""
                txtNQflow.Text = ""

                myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
                myCmd = myConn.CreateCommand
                myCmd.CommandText = "Select * from Carteles where id_CAC = " & ID_CAC & ""
                myConn.Open()
                myReader = myCmd.ExecuteReader()
                Do While myReader.Read()
                    results = myReader.GetString(1)
                    ComboBox1.Items.Add(results)
                Loop
                myConn.Close()
            Else
                MsgBox("Debe ingresar un valor.", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub
End Class