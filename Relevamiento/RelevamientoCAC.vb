Imports System.Data.SqlClient

Public Class RelevamientoCAC
    Inherits Form
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Dim ActiveText As TextBox
    Dim Dato, DatoNuevo As String
    Dim User, RemitoRemitente, RemitoDestinatario, RemitoDireccion, RemitoLocalidad, RemitoProvincia, RemitoCP, RemitoNro, RemitoTicket As String
    Dim CurPage, NroCaja, msgAndreani As Integer
    Dim Andreani As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from CACs order by Nombre"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            results = myReader.GetString(1)
            ComboBox1.Items.Add(results)
        Loop
        myConn.Close()
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        CurPage = 1
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from CACs where nombre = '" & ComboBox1.Text & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        ID_CAC = myReader.GetInt32(0)
        Try
            txtDireccion.Text = myReader.GetString(2) ' Dirección
            txtLocalidad.Text = myReader.GetString(3) ' Localidad
            txtProvincia.Text = myReader.GetString(4) ' Provincia
            txtCP.Text = myReader.GetString(6) ' CP
            JefeCAC = myReader.GetString(7) ' Jefe
            txtJefe.Text = JefeCAC
            txtSuperv1.Text = myReader.GetString(8) ' Supervisor 1
            txtSuperv2.Text = myReader.GetString(9) ' Supervisor 2
            txtJefeNb.Text = myReader.GetString(10) ' Jefe Notebook
            txtGerente.Text = myReader.GetString(11) ' Gerente
            txtCentroCosto.Text = myReader.GetString(12) ' Centro de costos
            txtTecnico.Text = myReader.GetString(13)
            txtTecnico2.Text = myReader.GetString(14)
            txtRegion.Text = myReader.GetString(15)
            txtHorario.Text = myReader.GetString(16)
            DireccionCAC = txtDireccion.Text & ", " & txtLocalidad.Text & ", " & txtProvincia.Text & ", CP " & txtCP.Text
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
        myConn.Close()
    End Sub

    Private Sub CopiarDirecciónCompletaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarDirecciónCompletaToolStripMenuItem.Click
        If ComboBox1.Text = "" Then
            MsgBox("Debe seleccionar un CAC primero.", vbExclamation)
        Else
            My.Computer.Clipboard.SetText(DireccionCAC)
            MsgBox("Dirección completa: " & vbCrLf & DireccionCAC & vbCrLf & "Copiada al portapapeles.")
        End If
    End Sub

    Private Sub ServidorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServidorToolStripMenuItem.Click
        If ComboBox1.Text = "" Then
            MsgBox("Debe seleccionar un CAC primero.", vbExclamation)
        Else
            Dim frmServidores As New Servidores With {
                .Text = "CAC " & ComboBox1.Text,
                .MdiParent = RelevamientoMenu
            }
            frmServidores.Show()
        End If
    End Sub

    Private Sub CartelesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CartelesToolStripMenuItem.Click
        If ComboBox1.Text = "" Then
            MsgBox("Debe seleccionar un CAC primero.", vbExclamation)
        Else
            Dim frmCarteles As New Carteles With {
                .Text = "CAC " & ComboBox1.Text,
                .MdiParent = RelevamientoMenu
            }
            frmCarteles.Show()
        End If
    End Sub

    Private Sub TouchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TouchToolStripMenuItem.Click
        If ComboBox1.Text = "" Then
            MsgBox("Debe seleccionar un CAC primero.", vbExclamation)
        Else
            Dim frmTouch As New Touch With {
                .Text = "CAC " & ComboBox1.Text,
                .MdiParent = RelevamientoMenu
            }
            frmTouch.Show()
        End If
    End Sub

    Private Sub ImpresorasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpresorasToolStripMenuItem.Click
        If ComboBox1.Text = "" Then
            MsgBox("Debe seleccionar un CAC primero.", vbExclamation)
        Else
            Table = "Impresoras"
            Column = "ID_CAC"
            Dim frmImpresoras As New Impresoras With {
                .Text = "CAC " & ComboBox1.Text,
                .MdiParent = RelevamientoMenu
            }
            frmImpresoras.Show()
        End If
    End Sub

    Private Sub TabletsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabletsToolStripMenuItem.Click
        If ComboBox1.Text = "" Then
            MsgBox("Debe seleccionar un CAC primero.", vbExclamation)
        Else
            Table = "Tablets"
            Column = "ID_CAC"
            Dim frmTablets As New Tablet With {
                .Text = "CAC " & ComboBox1.Text,
                .MdiParent = RelevamientoMenu
            }
            frmTablets.Show()
        End If
    End Sub

    Private Sub ImprimirEtiquetaDeEnvíoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirEtiquetaDeEnvíoToolStripMenuItem.Click
        'msgAndreani = MsgBox("¿Va por Andreani? (No: Correo Argentino)", vbQuestion + vbYesNo)
        Dim msgJefe As Integer = MsgBox("¿El destinatario es el jefe del CAC?", vbQuestion + vbYesNo)
        If msgJefe = vbYes Then
            RemitoDestinatario = StrConv(JefeCAC, vbProperCase)
        Else
            RemitoDestinatario = StrConv(InputBox("Destinatario:"), vbProperCase)
        End If

        'If msgAndreani = vbYes Then
        ' Andreani = True
        ' RemitoNro = InputBox("Número de remito", "", "1042-0000XXXX")
        ' Else
        ' Andreani = False
        'InputBox("Número de caja", "", "1")
        ' End If

        NroCaja = InputBox("Cantidad de cajas", "", "1")
        RemitoDireccion = txtDireccion.Text
        RemitoLocalidad = txtLocalidad.Text
        RemitoProvincia = txtProvincia.Text
        RemitoCP = txtCP.Text
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

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
#Disable Warning CA1416 ' Validate platform compatibility
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
        Dim StringSize6 As SizeF = e.Graphics.MeasureString("2411 (Claro AR - AMX)", fntRemitoNro)
        Dim StringSize7 As SizeF = e.Graphics.MeasureString(RemitoNro, fntRemitoNro)
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
        ' RemitoRect.X = 752
        ' RemitoRect.Y = 700
        ' RemitoRect.Width = 365
        ' RemitoRect.Height = 60
        ' e.Graphics.DrawRectangle(Pens.Black, RemitoRect)
        ' e.Graphics.DrawLine(Pens.Black, 900, 700, 900, 760)
        '
        'e.Graphics.DrawString("Remitente", fntRemito, Brushes.Black, 808, 700)
        'e.Graphics.DrawString(RemitoRemitente, fntRemitoNro, Brushes.Black, 900, 700)
        'e.Graphics.DrawString("Cuenta corriente ", fntRemito, Brushes.Black, 752, 720)
        'e.Graphics.DrawString("2411 (Claro AR - AMX)", fntRemitoNro, Brushes.Black, 900, 720)
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

        e.Graphics.DrawString("Fecha", fntRemito, Brushes.Black, 843, 740)
        e.Graphics.DrawString(Hoy, fntRemitoNro, Brushes.Black, 900, 740)
        'End If
        e.Graphics.DrawString("Caja " & CurPage & "/" & NroCaja, fntLabel, Brushes.Black, 60, 720)

        If NroCaja > 1 Then
            CurPage += 1
            e.HasMorePages = CurPage <= NroCaja
        End If
#Enable Warning CA1416 ' Validate platform compatibility
    End Sub

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
                myCmd.CommandText = "Update CACs set Direccion='" & txtDireccion.Text & "', Jefe='" & txtJefe.Text & "', Sup1='" & txtSuperv1.Text & "', Sup2='" & txtSuperv2.Text & "', JefeNotebook='" & txtJefeNb.Text & "', Gerente='" & txtGerente.Text & "', CentroCostos='" & txtCentroCosto.Text & "', Horario='" & txtHorario.Text & "' where id_CAC='" & ID_CAC & "'"
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
End Class