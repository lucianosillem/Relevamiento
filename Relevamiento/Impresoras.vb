Imports System.Data.SqlClient
Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Reflection
Imports System.ComponentModel
Imports System.Net.Http
Imports System.Diagnostics.Eventing.Reader

Public Class Impresoras
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Dim ActiveText As TextBox
    Dim PosModelo1 As Long = 1
    Dim PosModelo2 As Long = 1
    Dim PosSerie1 As Long = 1
    Dim PosSerie2 As Long = 1
    Dim PosMAC1 As Long = 1
    Dim PosMAC2 As Long = 1
    Dim PosFW1 As Long = 1
    Dim PosFW2 As Long = 1
    Dim Dato, DatoNuevo, Modelo, Serie, MAC, Nombre_Cola, Firmware, IP As String

    Private Sub Impresoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from " & Table & " where " & Column & "= " & ID_CAC & " order by Nombre_Cola"
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
        myCmd.CommandText = "Select * from " & Table & " where Nombre_Cola = '" & ComboBox1.Text & "'"
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

            If myReader.IsDBNull(4) Then
                Return
            Else
                lnkIP.Text = myReader.GetString(4) 'IP
            End If

            If myReader.IsDBNull(5) Then
                Return
            Else
                txtMAC.Text = myReader.GetString(5) ' MAC
            End If

            If myReader.IsDBNull(6) Then
                txtComment.Text = ""
            Else
                txtComment.Text = myReader.GetString(6) ' Comentario
            End If

        End If
        myConn.Close()
        Try
            lnkIP.Links.Clear()
            lnkIP.Links.Add(0, 13, "http://" & lnkIP.Text)
            If My.Computer.Network.Ping(lnkIP.Text) Then
                Label10.Text = "Ping responde"
                Label10.ForeColor = Color.Green
                lnkCMS.Enabled = True
                lnkDFM.Enabled = True
            Else
                Label10.Text = "Ping no responde"
                Label10.ForeColor = Color.Red
                lnkCMS.Enabled = False
                lnkDFM.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkIP.LinkClicked
        Dim ProcessLink As New ProcessStartInfo With {
            .UseShellExecute = True,
            .FileName = e.Link.LinkData.ToString()
        }
        Process.Start(ProcessLink)
    End Sub

    Private Sub lnkDFM_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDFM.LinkClicked
        If lnkIP.Text = "" Then
            MsgBox("Debe seleccionar una impresora primero.", vbCritical)
        Else
            Dim body As String
            Dim direccion As String
            Dim strURL As String = "http://" & lnkIP.Text & "/cgi-bin/history"
            Dim FILE_NAME As String = Environment.GetEnvironmentVariable("Temp") & "\" & txtSerial.Text & ".txt"
            Dim webClient1 As New WebClient()
            direccion = DireccionCAC
            body = "Contacto de visita: " & JefeCAC & vbCrLf & "Dirección de visita: " & direccion & vbCrLf & "Tel del contacto de visita: " & vbCrLf & "Horarios de visita: " & vbCrLf & "Modelo de la impresora: " & txtModel.Text & vbCrLf & "Número de serie de la impresora: " & txtSerial.Text & vbCrLf & "Falla: "
            If My.Computer.Network.Ping(lnkIP.Text) Then
                webClient1.Encoding = Encoding.ASCII
                webClient1.DownloadFile(strURL, FILE_NAME)
                Dim OutlookProcess As New ProcessStartInfo With {.UseShellExecute = True, .FileName = "outlook.exe /c ipm.note /m ""dfm.vip@lexmarksoporte.com?subject=Empresa Claro&body=" & body & """ /a " & FILE_NAME}
                Process.Start(OutlookProcess)
            Else
                Dim OutlookProcess As New ProcessStartInfo With {.UseShellExecute = True, .FileName = "outlook.exe /c ipm.note /m ""dfm.vip@lexmarksoporte.com?subject=Empresa Claro&body=" & body & """"}
                Process.Start(OutlookProcess)
            End If
        End If
    End Sub

    Private Sub lnkCMS_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCMS.LinkClicked
        If lnkIP.Text = "" Then
            MsgBox("Debe seleccionar una impresora primero.", vbCritical)
        Else
            Dim body As String
            Dim direccion As String
            Dim URLstats As String = "http://" & lnkIP.Text & "/cgi-bin/dynamic/printer/config/reports/devicestatistics.html"
            Dim FILE_NAME As String = Environment.GetEnvironmentVariable("Temp") & "\" & txtSerial.Text & "_stats.html"
            Dim webClient1 As New WebClient()
            Dim OutlookProcess As New ProcessStartInfo With {
                .UseShellExecute = True
            }
            direccion = DireccionCAC
            body = "Contacto de visita: " & JefeCAC & vbCrLf & "Dirección de visita: " & direccion & vbCrLf & "Tel del contacto de visita: " & vbCrLf & "Horarios de visita: " & vbCrLf & "Modelo de la impresora: " & txtModel.Text & vbCrLf & "Número de serie de la impresora: " & txtSerial.Text & vbCrLf & "Falla: "
            If My.Computer.Network.Ping(lnkIP.Text) Then
                webClient1.Encoding = Encoding.ASCII
                webClient1.DownloadFile(URLstats, FILE_NAME)
                OutlookProcess.FileName = "outlook.exe /c ipm.note /m ""dfmcms@lexmark.com?subject=Empresa Claro&body=" & body & """ /a " & FILE_NAME
                Process.Start(OutlookProcess)
            Else
                OutlookProcess.FileName = "outlook.exe /c ipm.note /m ""dfmcms@lexmark.com?subject=Empresa Claro&body=" & body & """"
                Process.Start(OutlookProcess)
            End If
        End If
    End Sub

    Private Sub ToolStripButtonEdit_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEdit.Click
        Try
            ActiveText = Me.ActiveControl
            If ActiveText Is txtComment Then
                ToolStripButtonOK.Enabled = True
                ToolStripButtonCancel.Enabled = True
                ActiveText.ReadOnly = False
                Dato = ActiveText.Text
            Else
                ToolStripButtonOK.Enabled = True
                ToolStripButtonCancel.Enabled = True
                Dato = ActiveText.Text
                DatoNuevo = InputBox("Introduzca el nuevo valor:",, Dato)
                If DatoNuevo <> "" Then
                    ActiveText.Text = DatoNuevo
                Else
                    ToolStripButtonOK.Enabled = False
                    ToolStripButtonCancel.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox("La edición de este campo no está permitida.", vbExclamation, "Relevamiento")
        End Try
    End Sub

    Private Sub ToolStripButtonCancel_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCancel.Click
        ActiveText.Text = Dato
        ToolStripButtonOK.Enabled = False
        ToolStripButtonCancel.Enabled = False
        ActiveText.ReadOnly = True
    End Sub

    Private Sub ToolStripButtonOK_Click(sender As Object, e As EventArgs) Handles ToolStripButtonOK.Click
        Dim Confirmation As Integer
        Confirmation = MsgBox("¿Desea guardar los cambios realizados?", vbYesNo + vbQuestion)
        If Confirmation = 6 Then
            myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
            myConn.Open()
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "Update " & Table & " set Modelo='" & txtModel.Text & "',Serie='" & txtSerial.Text & "',IP='" & lnkIP.Text & "',MAC='" & txtMAC.Text & "',Comentario='" & txtComment.Text & "' where Nombre_Cola='" & ComboBox1.Text & "'"
            myCmd.ExecuteNonQuery()
            myConn.Close()
            ToolStripButtonOK.Enabled = False
            ToolStripButtonCancel.Enabled = False
            txtComment.ReadOnly = True
            MsgBox("Cambios guardados.", vbInformation)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButtonChangeIP.Click
        Dim Confirmation As Integer
        Dato = lnkIP.Text
        DatoNuevo = InputBox("Introduzca el nuevo valor:",, Dato)
        If DatoNuevo <> "" Then
            lnkIP.Text = DatoNuevo
            Confirmation = MsgBox("¿Confirma la edición?" + vbCrLf + "Se guardará el cambio ahora.", vbYesNo + vbQuestion)
            If Confirmation = 6 Then
                myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
                myConn.Open()
                myCmd = myConn.CreateCommand
                myCmd.CommandText = "Update " & Table & " set IP='" & lnkIP.Text & "' where Nombre_Cola='" & ComboBox1.Text & "'"
                myCmd.ExecuteNonQuery()
                myConn.Close()
            Else
                lnkIP.Text = Dato
            End If
        End If
    End Sub

    Private Sub ToolStripButtonObtain_Click(sender As Object, e As EventArgs) Handles ToolStripButtonObtain.Click
        IP = lnkIP.Text
        Try
            If My.Computer.Network.Ping(IP) Then
                Dim request As WebRequest = WebRequest.Create("http://" & IP & "/cgi-bin/dynamic/printer/config/reports/MenusPage.html")
                Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Dim datastream As Stream = response.GetResponseStream
                Dim reader As New StreamReader(datastream)
                Dim strData As String = reader.ReadToEnd
                PosModelo1 = InStr(strData, "Lexmark")
                PosModelo1 = InStr(PosModelo1, strData, "", vbTextCompare)
                PosModelo2 = InStr(PosModelo1, strData, "</FONT>", vbTextCompare)
                Modelo = strData.Substring(PosModelo1 - 1, PosModelo2 - PosModelo1)
                PosSerie1 = InStr(strData, "serie")
                PosSerie1 = InStr(PosSerie1, strData, "", vbTextCompare)
                PosSerie2 = InStr(PosSerie1, strData, " </p>", vbTextCompare)
                Serie = strData.Substring(PosSerie1 + 24, PosSerie2 - PosSerie1 - 25)
                PosMAC1 = InStr(strData, "UAA")
                PosMAC1 = InStr(PosMAC1 + 1, strData, "", vbTextCompare)
                PosMAC2 = InStr(PosMAC1 + 1, strData, " </p>", vbTextCompare)
                MAC = strData.Substring(PosMAC1 + 21, PosMAC2 - PosMAC1 - 22)

                'PosFW1 = InStr(strData, "Cargador")
                'PosFW1 = InStr(PosFW1 + 1, strData, "", vbTextCompare)
                'PosFW2 = InStr(PosFW1 + 1, strData, " </p>", vbTextCompare)
                'Firmware = strData.Substring(PosFW1 + 21, PosMAC2 - PosFW1 - 22)

                'txtFirmware.Text = Firmware
                txtModel.Text = Modelo
                txtSerial.Text = Serie
                txtMAC.Text = MAC
                MsgBox("Datos obtenidos satisfactoriamente, presione Guardar para actualizarlos en la base de datos." + Environment.NewLine + "Para cancelar, cierre el formulario o elija otra impresora.", vbInformation)
                ToolStripButtonOK.Enabled = True
            Else
                MsgBox("El equipo no responde, no se pueden obtener los datos.", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButtonAdd.Click
        Nombre_Cola = InputBox("Ingrese el nombre de la cola de impresión:")
        IP = InputBox("Ingrese la IP de la impresora")
        Try
            If My.Computer.Network.Ping(IP) Then
                Dim request As WebRequest = WebRequest.Create("http://" & IP & "/cgi-bin/dynamic/printer/config/reports/MenusPage.html")
                Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Dim datastream As Stream = response.GetResponseStream
                Dim reader As New StreamReader(datastream)
                Dim strData As String = reader.ReadToEnd
                PosModelo1 = InStr(strData, "Lexmark")
                PosModelo1 = InStr(PosModelo1, strData, "", vbTextCompare)
                PosModelo2 = InStr(PosModelo1, strData, "</FONT>", vbTextCompare)
                Modelo = strData.Substring(PosModelo1 - 1, PosModelo2 - PosModelo1)
                PosSerie1 = InStr(strData, "serie")
                PosSerie1 = InStr(PosSerie1, strData, "", vbTextCompare)
                PosSerie2 = InStr(PosSerie1, strData, " </p>", vbTextCompare)
                Serie = strData.Substring(PosSerie1 + 24, PosSerie2 - PosSerie1 - 25)
                PosMAC1 = InStr(strData, "UAA")
                PosMAC1 = InStr(PosMAC1 + 1, strData, "", vbTextCompare)
                PosMAC2 = InStr(PosMAC1 + 1, strData, " </p>", vbTextCompare)
                MAC = strData.Substring(PosMAC1 + 21, PosMAC2 - PosMAC1 - 22)
                lnkIP.Text = IP
                txtModel.Text = Modelo
                txtSerial.Text = Serie
                txtMAC.Text = MAC
                ComboBox1.Text = Nombre_Cola
                ID_CAC = ID_Edificio
                myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
                myConn.Open()
                myCmd = myConn.CreateCommand
                myCmd.CommandText = "insert into " & Table & " values('" & ID_CAC & "','" & Nombre_Cola & "','" & Modelo & "','" & Serie & "','" & IP & "','" & MAC & "','')"
                myCmd.ExecuteNonQuery()
                myConn.Close()
                MsgBox("Insertado en la base.", vbInformation)
                ComboBox1.Items.Add(Nombre_Cola)
            Else
                MsgBox("El equipo no responde, no se agregó la impresora.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim PrinterVNC As New ProcessStartInfo With {.UseShellExecute = True, .FileName = "http://" & lnkIP.Text & "/cgi-bin/dynamic/printer/config/vncviewer.html"}
        Process.Start(PrinterVNC)
    End Sub
End Class