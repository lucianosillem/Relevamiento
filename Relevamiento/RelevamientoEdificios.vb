Public Class RelevamientoEdificios
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Dim ActiveText As TextBox
    Dim Dato, DatoNuevo As String
    Dim User, RemitoRemitente, RemitoDestinatario, RemitoDireccion, RemitoLocalidad, RemitoProvincia, RemitoCP As String
    Dim CurPage, NroCaja As Integer
    'Dim Andreani As Boolean

    Private Sub EditarValorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarValorToolStripMenuItem.Click
        Try
            ActiveText = Me.ActiveControl
            Dato = ActiveText.Text
            DatoNuevo = InputBox("Introduzca el nuevo valor:",, Dato)
            If DatoNuevo <> "" Then
                ActiveText.Text = DatoNuevo
                myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
                myConn.Open()
                myCmd = myConn.CreateCommand
                myCmd.CommandText = "Update Edificios set Direccion='" & TextBox1.Text & "',Localidad='" & TextBox2.Text & "',Provincia='" & TextBox3.Text & "',CP='" & TextBox5.Text & " where id_Edificio='" & ID_Edificio & "'"
                myCmd.ExecuteNonQuery()
                myConn.Close()
                MsgBox("Cambios guardados.", vbInformation)
            Else
                MsgBox("No se guardó ningún cambio.", vbInformation)
            End If
        Catch ex As Exception
            MsgBox("Este campo no se puede editar", vbExclamation)
        End Try

    End Sub

    Private Sub RelevamientoEdificios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Edificios order by Nombre"
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
        myCmd.CommandText = "Select * from Edificios where nombre = '" & ComboBox1.Text & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        ID_Edificio = myReader.GetInt32(0)
        ID_CAC = ID_Edificio
        TextBox1.Text = myReader.GetString(2) ' Dirección
        TextBox2.Text = myReader.GetString(3) ' Localidad
        TextBox3.Text = myReader.GetString(4) ' Provincia
        TextBox5.Text = myReader.GetString(5) ' CP
        myConn.Close()
        DireccionCAC = TextBox1.Text & ", " & TextBox2.Text & ", " & TextBox3.Text & ", CP " & TextBox5.Text
    End Sub

    Private Sub CopiarDirecciónCompletaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarDirecciónCompletaToolStripMenuItem.Click
        If ComboBox1.Text = "" Then
            MsgBox("Debe seleccionar un edificio primero.", vbExclamation)
        Else
            My.Computer.Clipboard.SetText(DireccionCAC)
            MsgBox("Dirección completa: " & vbCrLf & DireccionCAC & vbCrLf & "Copiada al portapapeles.")
        End If
    End Sub

    Private Sub ImpresorasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpresorasToolStripMenuItem.Click
        If ComboBox1.Text = "" Then
            MsgBox("Debe seleccionar un edificio primero.", vbExclamation)
        Else
            Table = "ImpresorasEdificios"
            Column = "ID_Edificio"
            Dim frmImpresoras As New Impresoras With {
                .Text = "Impresoras " & ComboBox1.Text,
                .MdiParent = RelevamientoMenu
            }
            frmImpresoras.Show()
        End If
    End Sub

    Private Sub SalasTeamsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalasTeamsToolStripMenuItem.Click
        If ComboBox1.Text = "" Then
            MsgBox("Debe seleccionar un edificio primero.", vbExclamation)
        Else
            Table = "TabletsEdificios"
            Column = "ID_Edificio"
            Dim frmSalas As New SalasReunion With {
                .Text = "Salas de reunión " & ComboBox1.Text,
                .MdiParent = RelevamientoMenu
            }
            frmSalas.Show()
        End If
    End Sub

    Private Sub ImprimirEtiquetaDeEnvíoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirEtiquetaDeEnvíoToolStripMenuItem.Click
        'msgAndreani = MsgBox("¿Va por Andreani? (No: Correo Argentino)", vbQuestion + vbYesNo)
#Disable Warning CA1416
        RemitoDestinatario = StrConv(InputBox("Destinatario:"), vbProperCase)
        'If msgAndreani = vbYes Then
        ' Andreani = True
        ' RemitoNro = InputBox("Número de remito", "", "1042-0000XXXX")
        ' Else
        ' Andreani = False
        ' RemitoNro = InputBox("Número de caja", "", "1")
        ' End If
        NroCaja = InputBox("Cantidad de cajas", "", "1")
        RemitoDireccion = TextBox1.Text
        RemitoLocalidad = TextBox2.Text
        RemitoProvincia = TextBox3.Text
        RemitoCP = TextBox5.Text
        User = UCase(Environment.UserName)
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Usuarios where NUsuario = '" & User & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        RemitoRemitente = myReader.GetString(1)
        myReader.Close()

        CurPage = 1

        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        With PrintDocument1.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 50
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub ImprimirEtiquetaDeEnvíodomicilioParticularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirEtiquetaDeEnvíodomicilioParticularToolStripMenuItem.Click
#Disable Warning CA1416
        'msgAndreani = MsgBox("¿Va por Andreani? (No: Correo Argentino)", vbQuestion + vbYesNo)
        RemitoDestinatario = StrConv(InputBox("Destinatario:"), vbProperCase)
        RemitoDireccion = StrConv(InputBox("Dirección:"), vbProperCase)
        RemitoLocalidad = StrConv(InputBox("Localidad:"), vbProperCase)
        RemitoProvincia = StrConv(InputBox("Provincia:"), vbProperCase)
        RemitoCP = InputBox("CP:")
        'If msgAndreani = vbYes Then
        ' Andreani = True
        ' RemitoNro = InputBox("Número de remito", "", "1042-0000XXXX")
        ' Else
        ' Andreani = False
        ' RemitoNro = InputBox("Número de caja", "", "1")
        ' End If
        NroCaja = InputBox("Cantidad de cajas", "", "1")
        User = UCase(Environment.UserName)
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Usuarios where NUsuario = '" & User & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        RemitoRemitente = myReader.GetString(1)
        myReader.Close()

        CurPage = 1

        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        With PrintDocument1.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 50
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        CurPage = 1
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
#Disable Warning CA1416
        Dim fntLabel As New Font("Gotham Light", 36, FontStyle.Bold)
        Dim fntText As New Font("Gotham Light", 36, FontStyle.Regular)
        Dim fntDireccion As New Font("Gotham Light", 36, FontStyle.Regular)
        Dim fntCaja As New Font("Gotham Light", 24, FontStyle.Bold)
        Dim fntRemito As New Font("Gotham Light", 12, FontStyle.Bold)
        Dim fntRemitoNro As New Font("Gotham Light", 12, FontStyle.Regular)
        Dim LineSpace As Integer = 140
        Dim LeftMargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Left
        Dim RightMargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Right
        Dim TopMargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Top
        Dim PageWidth As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width - LeftMargin - RightMargin
        Dim Format As New StringFormat With {
            .Alignment = StringAlignment.Center
        }

        Dim StringSize1 As SizeF = e.Graphics.MeasureString(RemitoDestinatario, fntText)
        Dim StringSize2 As SizeF ' = e.Graphics.MeasureString(RemitoDireccion, fntText)
        Dim StringSize3 As SizeF = e.Graphics.MeasureString(RemitoLocalidad, fntText)
        Dim StringSize4 As SizeF = e.Graphics.MeasureString(RemitoProvincia, fntText)
        Dim StringSize5 As SizeF = e.Graphics.MeasureString(RemitoCP, fntText)
        'Dim StringSize6 As SizeF = e.Graphics.MeasureString("2411 (Claro AR - AMX)", fntRemitoNro)
        'Dim StringSize7 As SizeF = e.Graphics.MeasureString(RemitoNro, fntRemitoNro)
        Dim RemitoRect As New Rectangle()
        Dim Hoy As Date = Today.ToShortDateString

        For i = 36 To 20 Step -1
            fntDireccion = New Font("Gotham Light", i, FontStyle.Regular)
            StringSize2 = e.Graphics.MeasureString(RemitoDireccion, fntDireccion)
            If StringSize2.Width < 1100 Then
                Exit For
            End If
        Next

        e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds)

        e.Graphics.DrawString("Destinatario:", fntLabel, Brushes.Black, 585, TopMargin, Format)
        e.Graphics.DrawString(RemitoDestinatario, fntText, Brushes.Black, 585, TopMargin + StringSize1.Height - 5, Format)

        e.Graphics.DrawString("Dirección:", fntLabel, Brushes.Black, 585, TopMargin + LineSpace, Format)
        e.Graphics.DrawString(RemitoDireccion, fntDireccion, Brushes.Black, 585, TopMargin + LineSpace + StringSize1.Height - 5, Format)

        e.Graphics.DrawString("Localidad:", fntLabel, Brushes.Black, 585, TopMargin + LineSpace * 2, Format)
        e.Graphics.DrawString(RemitoLocalidad, fntText, Brushes.Black, 585, TopMargin + LineSpace * 2 + StringSize3.Height - 5, Format)

        e.Graphics.DrawString("Provincia:", fntLabel, Brushes.Black, 585, TopMargin + LineSpace * 3, Format)
        e.Graphics.DrawString(RemitoProvincia, fntText, Brushes.Black, 585, TopMargin + LineSpace * 3 + StringSize4.Height - 5, Format)

        e.Graphics.DrawString("CP:", fntLabel, Brushes.Black, 585, TopMargin + LineSpace * 4, Format)
        e.Graphics.DrawString(RemitoCP, fntText, Brushes.Black, 585, TopMargin + LineSpace * 4 + StringSize5.Height - 5, Format)

        'If Andreani = True Then
        'RemitoRect.X = 752
        'RemitoRect.Y = 700
        'RemitoRect.Width = 365
        'RemitoRect.Height = 60
        'e.Graphics.DrawRectangle(Pens.Black, RemitoRect)
        'e.Graphics.DrawLine(Pens.Black, 900, 700, 900, 760)
        '
        'e.Graphics.DrawString("Remitente", fntRemito, Brushes.Black, 808, 700)
        'e.Graphics.DrawString(RemitoRemitente, fntRemitoNro, Brushes.Black, 900, 700)
        '
        'e.Graphics.DrawString("Cuenta corriente ", fntRemito, Brushes.Black, 752, 720)
        'e.Graphics.DrawString("2411 (Claro AR - AMX)", fntRemitoNro, Brushes.Black, 900, 720)
        '
        'e.Graphics.DrawString("Remito", fntRemito, Brushes.Black, 835, 740)
        'e.Graphics.DrawString(RemitoNro, fntRemitoNro, Brushes.Black, 900, 740)
        'Else
        RemitoRect.X = 752
        RemitoRect.Y = 720
        RemitoRect.Width = 365
        RemitoRect.Height = 40
        e.Graphics.DrawRectangle(Pens.Black, RemitoRect)
        e.Graphics.DrawLine(Pens.Black, 900, 720, 900, 760)
        e.Graphics.DrawString("Remitente", fntRemito, Brushes.Black, 808, 720)
        e.Graphics.DrawString(RemitoRemitente, fntRemitoNro, Brushes.Black, 900, 720)

        'e.Graphics.DrawString("Caja N°", fntRemito, Brushes.Black, 830, 740)
        'e.Graphics.DrawString(RemitoNro, fntRemitoNro, Brushes.Black, 900, 740)
        e.Graphics.DrawString("Fecha", fntRemito, Brushes.Black, 843, 740)
        e.Graphics.DrawString(Hoy, fntRemitoNro, Brushes.Black, 900, 740)
        'End If

        e.Graphics.DrawString("Caja " & CurPage & "/" & NroCaja, fntLabel, Brushes.Black, 60, 720)

        If NroCaja > 1 Then
            CurPage += 1
            e.HasMorePages = CurPage <= NroCaja
        End If

    End Sub
End Class