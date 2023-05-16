Imports System.Data.SqlClient
Public Class Servidores
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private Sub Servidores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FinGtia As Date
        Dim DiasGtia As Long
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Servidores where id_CAC = " & ID_CAC & ""
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        txtHostname.Text = myReader.GetString(1)
        txtModel.Text = myReader.GetString(2)
        txtServiceTag.Text = myReader.GetString(3)
        txtOS.Text = myReader.GetString(4)
        txtIP.Text = myReader.GetString(5)
        lnkIDRAC.Text = myReader.GetString(6)
        FinGtia = myReader.GetDateTime(7)
        txtFinGtia.Text = FinGtia
        txtObservaciones.Text = myReader.GetString(8)
        txtGateway.Text = myReader.GetString(9)
        myConn.Close()
        lnkIDRAC.Links.Add(0, 12, "http://" & lnkIDRAC.Text)
        DiasGtia = DateDiff(DateInterval.DayOfYear, Now.Date, FinGtia)
        txtDias.Text = DiasGtia
        'If DiasGtia < 0 Then
        '    MsgBox("Garantía Expirada")
        'End If

        If My.Computer.Network.Ping(txtIP.Text) Then
            Label10.Text = "Ping responde"
        Else
            Label10.Text = "Ping no responde"
            Label10.ForeColor = Color.Red
        End If

        If My.Computer.Network.Ping(txtGateway.Text) Then
            Label12.Text = "Ping responde"
        Else
            Label12.Text = "Ping no responde"
            Label12.ForeColor = Color.Red
        End If

        If My.Computer.Network.Ping(lnkIDRAC.Text) Then
            Label11.Text = "Ping responde"
        Else
            Label11.Text = "Ping no responde"
            Label11.ForeColor = Color.Red
        End If
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkIDRAC.LinkClicked
        Dim ProcessLink As New ProcessStartInfo With {
            .UseShellExecute = True,
            .FileName = e.Link.LinkData.ToString()
        }
        Process.Start(ProcessLink)
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub InfoGarantiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoGarantiaToolStripMenuItem.Click
        Try
            Dim frmGarantia As New DellWarranty
            Hostname = txtServiceTag.Text
            frmGarantia.MdiParent = RelevamientoMenu
            frmGarantia.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AbrirRDPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirRDPToolStripMenuItem.Click
        Process.Start("C:\Windows\System32\mstsc.exe", "/v:" & txtHostname.Text)
    End Sub
End Class