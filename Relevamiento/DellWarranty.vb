Imports System.Data.SqlClient
Public Class DellWarranty
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Dim results, ItemNumber As String
    Dim CSVTable(5, 13) As String
    Dim col, row As Integer
    Dim DWProcess As Process
    Private Sub DellWarranty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DWCLIPath, ServiceTagPath, ExportPath, Arguments As String
        row = 0
        col = 0
        DWCLIPath = FileSystem.CurDir & "\DellWarranty\DellWarranty-CLI.exe"
        ServiceTagPath = Environment.GetEnvironmentVariable("Temp") & "\ServiceTag.csv"
        ExportPath = Environment.GetEnvironmentVariable("Temp") & "\Export.csv"
        Arguments = "/I=""" & ServiceTagPath & """ /E=""" & ExportPath & """"
        If Hostname = "" Then
            Hostname = InputBox("Service Tag:")
        End If
        If My.Computer.FileSystem.FileExists(ServiceTagPath) Then
            My.Computer.FileSystem.DeleteFile(ServiceTagPath)
        End If
        FileOpen(1, ServiceTagPath, OpenMode.Output)
        Write(1, Hostname)
        FileClose()
        Dim DWStartInfo As New ProcessStartInfo(DWCLIPath, Arguments)
        DWStartInfo.WindowStyle = ProcessWindowStyle.Hidden
        DWProcess = Process.Start(DWStartInfo)
        DWProcess.WaitForExit()

        Dim CSVReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(ExportPath)
        CSVReader.TextFieldType = FileIO.FieldType.Delimited
        CSVReader.SetDelimiters(",")
        Dim currentRow As String()

        row = 0
        While Not CSVReader.EndOfData
            Try
                currentRow = CSVReader.ReadFields()
                Dim currentField As String
                col = 0
                For Each currentField In currentRow
                    CSVTable(row, col) = currentField
                    col += 1
                Next
                row += 1
            Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
            End Try
        End While

        For row = 1 To 5
            If CSVTable(row, 7) <> "" Then
                results = CSVTable(row, 7) + " " + CSVTable(row, 10)
                ComboBox1.Items.Add(results)
            Else
                Exit For
            End If
        Next
        Me.ActiveControl = ComboBox1
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://techdirect.dell.com/Portal/ServiceRequest.aspx")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim dShipDate, dEndDate As DateTime
        ItemNumber = Strings.Left(ComboBox1.Text, 8)
        For row = 1 To 5
            If CSVTable(row, 7) = ItemNumber Then
                Exit For
            End If
        Next
        Try
            TextBox1.Text = CSVTable(row, 0) 'Service Tag
            TextBox2.Text = CSVTable(row, 5) 'MachineDescription
            TextBox3.Text = CSVTable(row, 3) 'CountryCode
            dShipDate = DateTime.ParseExact(CSVTable(row, 6), "MM/dd/yyyy hh:mm:ss tt", Nothing) 'ShipDate
            dEndDate = DateTime.ParseExact(CSVTable(row, 9), "MM/dd/yyyy hh:mm:ss tt", Nothing) 'EndDate
            TextBox4.Text = FormatDateTime(dShipDate, DateFormat.ShortDate)
            TextBox5.Text = FormatDateTime(dEndDate, DateFormat.ShortDate)
            Dim TimeDiff1 As TimeSpan = dEndDate - Now
            Dim TimeDiff2 As TimeSpan = Now - dShipDate
            Label8.Text = "Hace " & Math.Round(TimeDiff2.TotalDays / 30) & " meses."
            If Math.Round(TimeDiff1.TotalDays) > 1 Then
                Label7.ForeColor = Color.Green
                If Math.Round(TimeDiff1.TotalDays) >= 60 Then
                    Label7.Text = "Restan " & Math.Round(TimeDiff1.TotalDays / 30) & " meses."
                Else
                    Label7.Text = "Restan " & Math.Round(TimeDiff1.TotalDays) & " días."
                End If
            Else
                Label7.ForeColor = Color.Red
                Label7.Text = "Garantía expirada hace " & Math.Round(TimeDiff1.TotalDays / 30) * -1 & " meses."
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try

    End Sub
End Class