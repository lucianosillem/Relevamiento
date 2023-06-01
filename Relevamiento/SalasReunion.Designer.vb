<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalasReunion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtHostname = New TextBox()
        Label2 = New Label()
        txtMail = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        txtModel = New TextBox()
        Label4 = New Label()
        txtSerial = New TextBox()
        Label5 = New Label()
        txtCam = New TextBox()
        Label6 = New Label()
        txtLineURI = New TextBox()
        Label7 = New Label()
        txtObservacion = New TextBox()
        Label8 = New Label()
        txtUser = New TextBox()
        Label9 = New Label()
        txtPass = New TextBox()
        Label10 = New Label()
        lblPing = New Label()
        txtIP = New TextBox()
        Label11 = New Label()
        SuspendLayout()
        ' 
        ' txtHostname
        ' 
        txtHostname.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtHostname.Location = New Point(99, 58)
        txtHostname.Name = "txtHostname"
        txtHostname.ReadOnly = True
        txtHostname.Size = New Size(85, 22)
        txtHostname.TabIndex = 114
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(34, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 13)
        Label2.TabIndex = 113
        Label2.Text = "Hostname"
        ' 
        ' txtMail
        ' 
        txtMail.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtMail.Location = New Point(99, 32)
        txtMail.Name = "txtMail"
        txtMail.ReadOnly = True
        txtMail.Size = New Size(300, 22)
        txtMail.TabIndex = 112
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(64, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 13)
        Label3.TabIndex = 111
        Label3.Text = "Mail"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(6, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 13)
        Label1.TabIndex = 110
        Label1.Text = "Nombre de sala"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBox1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(99, 5)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(300, 21)
        ComboBox1.TabIndex = 109
        ' 
        ' txtModel
        ' 
        txtModel.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtModel.Location = New Point(99, 85)
        txtModel.Name = "txtModel"
        txtModel.ReadOnly = True
        txtModel.Size = New Size(300, 22)
        txtModel.TabIndex = 116
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(46, 89)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 13)
        Label4.TabIndex = 115
        Label4.Text = "Modelo"
        ' 
        ' txtSerial
        ' 
        txtSerial.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSerial.Location = New Point(99, 112)
        txtSerial.Name = "txtSerial"
        txtSerial.ReadOnly = True
        txtSerial.Size = New Size(300, 22)
        txtSerial.TabIndex = 118
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(2, 116)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 13)
        Label5.TabIndex = 117
        Label5.Text = "Número de serie"
        ' 
        ' txtCam
        ' 
        txtCam.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtCam.Location = New Point(99, 139)
        txtCam.Name = "txtCam"
        txtCam.ReadOnly = True
        txtCam.Size = New Size(300, 22)
        txtCam.TabIndex = 120
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(7, 143)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 13)
        Label6.TabIndex = 119
        Label6.Text = "Modelo cámara"
        ' 
        ' txtLineURI
        ' 
        txtLineURI.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtLineURI.Location = New Point(99, 166)
        txtLineURI.Name = "txtLineURI"
        txtLineURI.ReadOnly = True
        txtLineURI.Size = New Size(300, 22)
        txtLineURI.TabIndex = 122
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(47, 170)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 13)
        Label7.TabIndex = 121
        Label7.Text = "LineURI"
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtObservacion.Location = New Point(99, 193)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.ReadOnly = True
        txtObservacion.Size = New Size(300, 22)
        txtObservacion.TabIndex = 124
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(22, 197)
        Label8.Name = "Label8"
        Label8.Size = New Size(71, 13)
        Label8.TabIndex = 123
        Label8.Text = "Observación"
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtUser.Location = New Point(99, 220)
        txtUser.Name = "txtUser"
        txtUser.ReadOnly = True
        txtUser.Size = New Size(300, 22)
        txtUser.TabIndex = 126
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(46, 224)
        Label9.Name = "Label9"
        Label9.Size = New Size(47, 13)
        Label9.TabIndex = 125
        Label9.Text = "Usuario"
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPass.Location = New Point(99, 247)
        txtPass.Name = "txtPass"
        txtPass.ReadOnly = True
        txtPass.Size = New Size(300, 22)
        txtPass.TabIndex = 128
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(37, 251)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 13)
        Label10.TabIndex = 127
        Label10.Text = "Password"
        ' 
        ' lblPing
        ' 
        lblPing.AutoSize = True
        lblPing.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblPing.ForeColor = SystemColors.ControlText
        lblPing.Location = New Point(299, 62)
        lblPing.Name = "lblPing"
        lblPing.Size = New Size(0, 13)
        lblPing.TabIndex = 129
        ' 
        ' txtIP
        ' 
        txtIP.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtIP.Location = New Point(203, 58)
        txtIP.Name = "txtIP"
        txtIP.ReadOnly = True
        txtIP.Size = New Size(90, 22)
        txtIP.TabIndex = 130
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(186, 62)
        Label11.Name = "Label11"
        Label11.Size = New Size(16, 13)
        Label11.TabIndex = 131
        Label11.Text = "IP"
        ' 
        ' SalasReunion
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(408, 278)
        Controls.Add(Label11)
        Controls.Add(txtIP)
        Controls.Add(lblPing)
        Controls.Add(txtPass)
        Controls.Add(Label10)
        Controls.Add(txtUser)
        Controls.Add(Label9)
        Controls.Add(txtObservacion)
        Controls.Add(Label8)
        Controls.Add(txtLineURI)
        Controls.Add(Label7)
        Controls.Add(txtCam)
        Controls.Add(Label6)
        Controls.Add(txtSerial)
        Controls.Add(Label5)
        Controls.Add(txtModel)
        Controls.Add(Label4)
        Controls.Add(txtHostname)
        Controls.Add(Label2)
        Controls.Add(txtMail)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "SalasReunion"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Salas de reunión"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtHostname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCam As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLineURI As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPing As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Label11 As Label
End Class
