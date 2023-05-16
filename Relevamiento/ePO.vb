Imports System.Data.SqlClient
Imports System.Net
Public Class ePO
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private Sub ePO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LastUpdate As DateTime
        Dim UTC3 As DateTime
        Dim d As String

        myConn = New SqlConnection("Data Source=CORPBA-SQL1;Initial Catalog=ePO_CORPBA-EPO;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "select OSType, ProductVersion, DATVer, DATDate FROM EPOComputerProperties LEFT JOIN EPOProductProperties ON EPOProductProperties.ParentID = EPOComputerProperties.ParentID where ComputerName = '" & Hostname & "' and ProductCode = 'ENDP_AM_1070'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        Try
            TextBox1.Text = myReader.GetString(0) 'Sistema Operativo
            TextBox4.Text = myReader.GetString(1) 'Versión de Endpoint Security TP
            TextBox5.Text = myReader.GetString(2) 'Versión de AMCore Content
            d = myReader.GetString(3) 'Fecha de AMCore Content
            Dim dt = DateTime.ParseExact(d, "yyyy-MM-ddThh:mm:ssZ", Nothing)
            TextBox6.Text = FormatDateTime(dt, DateFormat.ShortDate)
            Dim TimeDiff1 As TimeSpan = Now - dt
            If Math.Round(TimeDiff1.TotalDays) > 1 Then
                Label7.Text = "Hace " & Math.Round(TimeDiff1.TotalDays) & " días"
            Else
                If Math.Round(TimeDiff1.TotalDays) = 1 Then
                    Label7.Text = "Ayer"
                Else
                    Label7.Text = "Hoy"
                End If
            End If
            myConn.Close()
            myConn = New SqlConnection("Data Source=CORPBA-SQL1;Initial Catalog=ePO_CORPBA-EPO;Integrated Security=True")
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "select ProductVersion
                             from EPOProductProperties
                             left join EPOComputerProperties
                             on EPOProductProperties.ParentID = EPOComputerProperties.ParentID
                             where ComputerName = '" & Hostname & "'
                             and ProductCode = 'EPOAGENT3000'"
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            myReader.Read()
            TextBox3.Text = myReader.GetString(0) 'Versión del agente

            myConn = New SqlConnection("Data Source=CORPBA-SQL1;Initial Catalog=ePO_CORPBA-EPO;Integrated Security=True")
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT LastUpdate FROM EPOLeafNodeMT WHERE NodeName = '" & Hostname & "'"
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            myReader.Read()
            If myReader.IsDBNull(0) Then
                TextBox2.Text = "N/A"
            Else
                LastUpdate = myReader.GetDateTime(0) 'Última comunicación
                UTC3 = LastUpdate.Subtract(New TimeSpan(3, 0, 0))
                TextBox2.Text = UTC3
                Dim TimeDiff2 As TimeSpan = Now - UTC3
                Label8.Text = "Hace " & TimeDiff2.Days & " días, " & TimeDiff2.Hours & " horas, " & TimeDiff2.Minutes & " minutos."
            End If
            myReader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub
End Class