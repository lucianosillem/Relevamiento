Imports System.Data.SqlClient
Imports System.Net
Public Class Touch
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private Sub Touch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Touch where id_CAC = " & ID_CAC & ""
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
        myCmd.CommandText = "Select * from Touch where Hostname = '" & ComboBox1.Text & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Const V As String = "NULL"

        If myReader.Read() Then
            If myReader.IsDBNull(3) Then
                Return
            Else
                txtImpresora.Text = myReader.GetString(2)
            End If

            If myReader.IsDBNull(2) Then
                Return
            Else
                txtNQflow.Text = myReader.GetString(3)
            End If
        End If

        myConn.Close()

        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=CM_AMX;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT System_DATA.Name0, Computer_System_DATA.Model00, PC_BIOS_DATA.SerialNumber00 FROM System_DATA INNER JOIN Computer_System_DATA ON System_DATA.MachineID = Computer_System_DATA.MachineID INNER JOIN PC_BIOS_DATA ON System_DATA.MachineID = PC_BIOS_DATA.MachineID WHERE System_DATA.Name0 = '" & ComboBox1.Text & "'"
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
        End If

        myConn.Close()


        ListBox1.Items.Clear()
        If txtModel.Text = "7409-1725-8801" Then
            LblModel.Text = "Rojo"
        End If
        If txtModel.Text = "7702-8315-8820" Then
            LblModel.Text = "Blanco"
        End If
        Try
            Dim strHostName As New String(CType("", Char()))
            strHostName = ComboBox1.Text
            Dim ipEntry As IPHostEntry = Dns.GetHostEntry(strHostName)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub lnkTel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkTel.LinkClicked
        Dim ProcessLink As New ProcessStartInfo With {.UseShellExecute = True, .FileName = "tel:+08008000199"}
        Process.Start(ProcessLink)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If My.Computer.Network.Ping(ListBox1.SelectedItem) Then
            Label9.Text = "Ping responde"
            Label9.ForeColor = Color.Green
        Else
            Label9.Text = "Ping no responde"
            Label9.ForeColor = Color.Red
        End If
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ControlRemotoConfigurationManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlRemotoConfigurationManagerToolStripMenuItem.Click
        Dim CMRC = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\ConfigMgr10\Setup", "UI Installation Directory", Nothing)
        Process.Start(CMRC & "bin\i386\CmRcViewer.exe", ComboBox1.Text)
    End Sub

    Private Sub ConsultarEPOToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmePO As New ePO
        Hostname = ComboBox1.Text
        frmePO.Text = Hostname
        frmePO.MdiParent = RelevamientoMenu
        frmePO.Show()
    End Sub

    Private Sub ReiniciarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReiniciarToolStripMenuItem.Click
        Process.Start("cmd", "/c shutdown -m \\" & ComboBox1.Text & " -r -t 0 -f")
    End Sub

    Private Sub EditarHostnameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarHostnameToolStripMenuItem.Click
        If ComboBox1.Text = "" Then
            MsgBox("Debe seleccionar primero un touch.", vbExclamation)
        Else
            Try
                Dim NuevoHostname As String = InputBox("Nuevo valor", "Relevamiento", ComboBox1.Text)
                myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
                myCmd = myConn.CreateCommand
                myCmd.CommandText = "Update Touch Set Hostname = '" & NuevoHostname & "' where N_Qflow = '" & txtNQflow.Text & "'"
                myConn.Open()
                myCmd.ExecuteNonQuery()
                myConn.Close()

                ComboBox1.Items.Clear()
                ComboBox1.Text = ""

                myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
                myCmd = myConn.CreateCommand
                myCmd.CommandText = "Select * from Touch where id_CAC = " & ID_CAC & ""
                myConn.Open()
                myReader = myCmd.ExecuteReader()
                Do While myReader.Read()
                    results = myReader.GetString(1)
                    ComboBox1.Items.Add(results)
                Loop

                myConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbExclamation)
            End Try
        End If
    End Sub

    Private Sub NuevoTouchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoTouchToolStripMenuItem.Click
        Try
            Dim NuevoHostname As String = InputBox("Hostname", "Relevamiento", "")
            Dim NuevaImpresora As String = InputBox("Impresora", "Relevamiento", "")
            Dim NuevoUsr_Qflow As String = InputBox("Usuario QFlow", "Relevamiento", "")
            If NuevoHostname <> "" And NuevoUsr_Qflow <> "" Then
                myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
                myCmd = myConn.CreateCommand
                myCmd.CommandText = "insert into Touch Values (" & ID_CAC & ",'" & NuevoHostname & "','" & NuevaImpresora & "','" & NuevoUsr_Qflow & "')"
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
                myCmd.CommandText = "Select * from Touch where id_CAC = " & ID_CAC & ""
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