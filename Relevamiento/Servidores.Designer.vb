<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Servidores
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
        Label3 = New Label()
        txtModel = New TextBox()
        Label1 = New Label()
        txtServiceTag = New TextBox()
        Label2 = New Label()
        txtOS = New TextBox()
        Label4 = New Label()
        txtIP = New TextBox()
        Label5 = New Label()
        txtFinGtia = New TextBox()
        Label7 = New Label()
        txtObservaciones = New TextBox()
        Label8 = New Label()
        DataSet1 = New DataSet()
        Label9 = New Label()
        txtDias = New TextBox()
        lnkIDRAC = New LinkLabel()
        Label10 = New Label()
        Label11 = New Label()
        MenuStrip1 = New MenuStrip()
        AccionesToolStripMenuItem = New ToolStripMenuItem()
        AbrirRDPToolStripMenuItem = New ToolStripMenuItem()
        InfoGarantiaToolStripMenuItem = New ToolStripMenuItem()
        Label12 = New Label()
        Label6 = New Label()
        Label13 = New Label()
        txtGateway = New TextBox()
        txtPassRoot = New TextBox()
        Label14 = New Label()
        CType(DataSet1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtHostname
        ' 
        txtHostname.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtHostname.Location = New Point(95, 6)
        txtHostname.Name = "txtHostname"
        txtHostname.ReadOnly = True
        txtHostname.Size = New Size(127, 21)
        txtHostname.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(34, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 13)
        Label3.TabIndex = 6
        Label3.Text = "Hostname"
        ' 
        ' txtModel
        ' 
        txtModel.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtModel.Location = New Point(95, 32)
        txtModel.Name = "txtModel"
        txtModel.ReadOnly = True
        txtModel.Size = New Size(127, 21)
        txtModel.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(48, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 13)
        Label1.TabIndex = 8
        Label1.Text = "Modelo"
        ' 
        ' txtServiceTag
        ' 
        txtServiceTag.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtServiceTag.Location = New Point(95, 58)
        txtServiceTag.Name = "txtServiceTag"
        txtServiceTag.ReadOnly = True
        txtServiceTag.Size = New Size(80, 21)
        txtServiceTag.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(26, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 13)
        Label2.TabIndex = 10
        Label2.Text = "Service Tag"
        ' 
        ' txtOS
        ' 
        txtOS.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtOS.Location = New Point(95, 84)
        txtOS.Name = "txtOS"
        txtOS.ReadOnly = True
        txtOS.Size = New Size(127, 21)
        txtOS.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(10, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 13)
        Label4.TabIndex = 12
        Label4.Text = "Sist. Operativo"
        ' 
        ' txtIP
        ' 
        txtIP.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtIP.Location = New Point(95, 110)
        txtIP.Name = "txtIP"
        txtIP.ReadOnly = True
        txtIP.Size = New Size(80, 21)
        txtIP.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(72, 113)
        Label5.Name = "Label5"
        Label5.Size = New Size(17, 13)
        Label5.TabIndex = 14
        Label5.Text = "IP"
        ' 
        ' txtFinGtia
        ' 
        txtFinGtia.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtFinGtia.Location = New Point(95, 186)
        txtFinGtia.Name = "txtFinGtia"
        txtFinGtia.ReadOnly = True
        txtFinGtia.Size = New Size(80, 21)
        txtFinGtia.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(25, 189)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 13)
        Label7.TabIndex = 18
        Label7.Text = "Fin garantía"
        ' 
        ' txtObservaciones
        ' 
        txtObservaciones.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtObservaciones.Location = New Point(95, 212)
        txtObservaciones.Name = "txtObservaciones"
        txtObservaciones.ReadOnly = True
        txtObservaciones.Size = New Size(199, 21)
        txtObservaciones.TabIndex = 21
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(11, 215)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 13)
        Label8.TabIndex = 20
        Label8.Text = "Observaciones"
        ' 
        ' DataSet1
        ' 
        DataSet1.DataSetName = "NewDataSet"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(189, 189)
        Label9.Name = "Label9"
        Label9.Size = New Size(27, 13)
        Label9.TabIndex = 23
        Label9.Text = "Días"
        ' 
        ' txtDias
        ' 
        txtDias.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtDias.Location = New Point(222, 186)
        txtDias.Name = "txtDias"
        txtDias.ReadOnly = True
        txtDias.Size = New Size(37, 21)
        txtDias.TabIndex = 24
        txtDias.TextAlign = HorizontalAlignment.Center
        ' 
        ' lnkIDRAC
        ' 
        lnkIDRAC.AutoSize = True
        lnkIDRAC.Location = New Point(95, 139)
        lnkIDRAC.Name = "lnkIDRAC"
        lnkIDRAC.Size = New Size(0, 13)
        lnkIDRAC.TabIndex = 26
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.Green
        Label10.Location = New Point(185, 113)
        Label10.Name = "Label10"
        Label10.Size = New Size(31, 13)
        Label10.TabIndex = 28
        Label10.Text = "Ping"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.Green
        Label11.Location = New Point(185, 139)
        Label11.Name = "Label11"
        Label11.Size = New Size(31, 13)
        Label11.TabIndex = 29
        Label11.Text = "Ping"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AccionesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(306, 24)
        MenuStrip1.TabIndex = 30
        MenuStrip1.Text = "MenuStrip1"
        MenuStrip1.Visible = False
        ' 
        ' AccionesToolStripMenuItem
        ' 
        AccionesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AbrirRDPToolStripMenuItem, InfoGarantiaToolStripMenuItem})
        AccionesToolStripMenuItem.Name = "AccionesToolStripMenuItem"
        AccionesToolStripMenuItem.Size = New Size(67, 20)
        AccionesToolStripMenuItem.Text = "&Acciones"
        ' 
        ' AbrirRDPToolStripMenuItem
        ' 
        AbrirRDPToolStripMenuItem.Name = "AbrirRDPToolStripMenuItem"
        AbrirRDPToolStripMenuItem.Size = New Size(144, 22)
        AbrirRDPToolStripMenuItem.Text = "&Abrir RDP"
        ' 
        ' InfoGarantiaToolStripMenuItem
        ' 
        InfoGarantiaToolStripMenuItem.Name = "InfoGarantiaToolStripMenuItem"
        InfoGarantiaToolStripMenuItem.Size = New Size(144, 22)
        InfoGarantiaToolStripMenuItem.Text = "&Info Garantía"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.Green
        Label12.Location = New Point(185, 163)
        Label12.Name = "Label12"
        Label12.Size = New Size(31, 13)
        Label12.TabIndex = 33
        Label12.Text = "Ping"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(39, 139)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 13)
        Label6.TabIndex = 16
        Label6.Text = "IP iDRAC"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(26, 163)
        Label13.Name = "Label13"
        Label13.Size = New Size(63, 13)
        Label13.TabIndex = 31
        Label13.Text = "IP Gateway"
        ' 
        ' txtGateway
        ' 
        txtGateway.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtGateway.Location = New Point(95, 159)
        txtGateway.Name = "txtGateway"
        txtGateway.ReadOnly = True
        txtGateway.Size = New Size(80, 21)
        txtGateway.TabIndex = 34
        ' 
        ' txtPassRoot
        ' 
        txtPassRoot.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassRoot.Location = New Point(95, 239)
        txtPassRoot.Name = "txtPassRoot"
        txtPassRoot.ReadOnly = True
        txtPassRoot.Size = New Size(199, 21)
        txtPassRoot.TabIndex = 36
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(13, 242)
        Label14.Name = "Label14"
        Label14.Size = New Size(76, 13)
        Label14.TabIndex = 35
        Label14.Text = "Password root"
        ' 
        ' Servidores
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(306, 269)
        Controls.Add(txtPassRoot)
        Controls.Add(Label14)
        Controls.Add(txtGateway)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(lnkIDRAC)
        Controls.Add(txtDias)
        Controls.Add(Label9)
        Controls.Add(txtObservaciones)
        Controls.Add(Label8)
        Controls.Add(txtFinGtia)
        Controls.Add(Label7)
        Controls.Add(MenuStrip1)
        Controls.Add(Label6)
        Controls.Add(txtIP)
        Controls.Add(Label5)
        Controls.Add(txtOS)
        Controls.Add(Label4)
        Controls.Add(txtServiceTag)
        Controls.Add(Label2)
        Controls.Add(txtModel)
        Controls.Add(Label1)
        Controls.Add(txtHostname)
        Controls.Add(Label3)
        Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "Servidores"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Servidores"
        CType(DataSet1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtHostname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtServiceTag As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFinGtia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDias As TextBox
    Friend WithEvents lnkIDRAC As LinkLabel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirRDPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoGarantiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtGateway As TextBox
    Friend WithEvents txtPassRoot As TextBox
    Friend WithEvents Label14 As Label
End Class
