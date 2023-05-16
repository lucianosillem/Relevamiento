Imports System.Data.SqlClient
Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Reflection
Imports System.ComponentModel
Public Class SalasReunion
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private Sub SalasReunion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from " & Table & " where " & Column & "= " & ID_Edificio & " order by NombreSala"
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
        myCmd.CommandText = "Select * from " & Table & " where NombreSala = '" & ComboBox1.Text & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()

        If myReader.Read() Then
            If myReader.IsDBNull(2) Then
                Return
            Else
                txtMail.Text = myReader.GetString(2)
            End If

            If myReader.IsDBNull(3) Then
                Return
            Else
                txtHostname.Text = myReader.GetString(3)
            End If

            If myReader.IsDBNull(4) Then
                Return
            Else
                txtModel.Text = myReader.GetString(4)
            End If

            If myReader.IsDBNull(5) Then
                Return
            Else
                txtSerial.Text = myReader.GetString(5)
            End If

            If myReader.IsDBNull(6) Then
                Return
            Else
                txtCam.Text = myReader.GetString(6)
            End If

            If myReader.IsDBNull(7) Then
                Return
            Else
                txtLineURI.Text = myReader.GetString(7)
            End If

            If myReader.IsDBNull(8) Then
                Return
            Else
                txtObservacion.Text = myReader.GetString(8)
            End If

            If myReader.IsDBNull(9) Then
                Return
            Else
                txtUser.Text = myReader.GetString(9)
            End If

            If myReader.IsDBNull(10) Then
                Return
            Else
                txtPass.Text = myReader.GetString(10)
            End If

        End If
        myConn.Close()

        Try

            Dim strHostName As New String(CType("", Char()))
            strHostName = txtHostname.Text
            Dim ipEntry As IPHostEntry = Dns.GetHostEntry(strHostName)
            Dim addr As IPAddress() = ipEntry.AddressList
            txtIP.Text = addr(0).ToString()
            If strHostName <> "" Then
                If My.Computer.Network.Ping(strHostName) Then
                    lblPing.Text = "Ping responde"
                    lblPing.ForeColor = Color.Green
                Else
                    lblPing.Text = "Ping no responde"
                    lblPing.ForeColor = Color.Red
                End If
            Else
                lblPing.Text = ""
                txtIP.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub
End Class