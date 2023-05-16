<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tablet
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
        Label10 = New Label()
        Label5 = New Label()
        txtSerial = New TextBox()
        Label2 = New Label()
        txtModel = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        txtIP = New TextBox()
        lblPing = New Label()
        MenuStrip1 = New MenuStrip()
        AccionesToolStripMenuItem = New ToolStripMenuItem()
        ControlRemotoConfigurationManagerToolStripMenuItem = New ToolStripMenuItem()
        ConsultarEPOToolStripMenuItem = New ToolStripMenuItem()
        CerrarToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.Green
        Label10.Location = New Point(227, 102)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 13)
        Label10.TabIndex = 100
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(51, 90)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 13)
        Label5.TabIndex = 99
        Label5.Text = "Dirección IP"
        ' 
        ' txtSerial
        ' 
        txtSerial.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSerial.Location = New Point(122, 60)
        txtSerial.Margin = New Padding(4, 3, 4, 3)
        txtSerial.Name = "txtSerial"
        txtSerial.ReadOnly = True
        txtSerial.Size = New Size(148, 21)
        txtSerial.TabIndex = 98
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(29, 63)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 13)
        Label2.TabIndex = 97
        Label2.Text = "Número de serie"
        ' 
        ' txtModel
        ' 
        txtModel.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtModel.Location = New Point(122, 33)
        txtModel.Margin = New Padding(4, 3, 4, 3)
        txtModel.Name = "txtModel"
        txtModel.ReadOnly = True
        txtModel.Size = New Size(148, 21)
        txtModel.TabIndex = 96
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(73, 36)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 13)
        Label3.TabIndex = 95
        Label3.Text = "Modelo"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(26, 9)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 13)
        Label1.TabIndex = 94
        Label1.Text = "Tablet Hostname"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBox1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(122, 6)
        ComboBox1.Margin = New Padding(4, 3, 4, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(148, 21)
        ComboBox1.TabIndex = 93
        ' 
        ' txtIP
        ' 
        txtIP.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtIP.Location = New Point(122, 87)
        txtIP.Margin = New Padding(4, 3, 4, 3)
        txtIP.Name = "txtIP"
        txtIP.ReadOnly = True
        txtIP.Size = New Size(148, 21)
        txtIP.TabIndex = 107
        ' 
        ' lblPing
        ' 
        lblPing.AutoSize = True
        lblPing.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblPing.ForeColor = SystemColors.ControlText
        lblPing.Location = New Point(278, 103)
        lblPing.Margin = New Padding(4, 0, 4, 0)
        lblPing.Name = "lblPing"
        lblPing.Size = New Size(0, 13)
        lblPing.TabIndex = 108
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {AccionesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(411, 28)
        MenuStrip1.TabIndex = 109
        MenuStrip1.Text = "MenuStrip1"
        MenuStrip1.Visible = False
        ' 
        ' AccionesToolStripMenuItem
        ' 
        AccionesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ControlRemotoConfigurationManagerToolStripMenuItem, ConsultarEPOToolStripMenuItem, CerrarToolStripMenuItem})
        AccionesToolStripMenuItem.Name = "AccionesToolStripMenuItem"
        AccionesToolStripMenuItem.Size = New Size(67, 24)
        AccionesToolStripMenuItem.Text = "&Acciones"
        ' 
        ' ControlRemotoConfigurationManagerToolStripMenuItem
        ' 
        ControlRemotoConfigurationManagerToolStripMenuItem.Name = "ControlRemotoConfigurationManagerToolStripMenuItem"
        ControlRemotoConfigurationManagerToolStripMenuItem.Size = New Size(291, 22)
        ControlRemotoConfigurationManagerToolStripMenuItem.Text = "&Control remoto (Configuration Manager)"
        ' 
        ' ConsultarEPOToolStripMenuItem
        ' 
        ConsultarEPOToolStripMenuItem.Name = "ConsultarEPOToolStripMenuItem"
        ConsultarEPOToolStripMenuItem.Size = New Size(291, 22)
        ConsultarEPOToolStripMenuItem.Text = "Consultar &ePO"
        ' 
        ' CerrarToolStripMenuItem
        ' 
        CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        CerrarToolStripMenuItem.Size = New Size(291, 22)
        CerrarToolStripMenuItem.Text = "Cerra&r"
        ' 
        ' Tablet
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(411, 116)
        Controls.Add(MenuStrip1)
        Controls.Add(lblPing)
        Controls.Add(txtIP)
        Controls.Add(Label10)
        Controls.Add(Label5)
        Controls.Add(txtSerial)
        Controls.Add(Label2)
        Controls.Add(txtModel)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Tablet"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tablet"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtIP As TextBox
    Friend WithEvents lblPing As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlRemotoConfigurationManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarEPOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
End Class
