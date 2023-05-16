<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Touch
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
        txtSerial = New TextBox()
        Label2 = New Label()
        txtModel = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label9 = New Label()
        Label4 = New Label()
        txtNQflow = New TextBox()
        Label6 = New Label()
        lnkTel = New LinkLabel()
        Label7 = New Label()
        txtImpresora = New TextBox()
        ListBox1 = New ListBox()
        Label5 = New Label()
        LblModel = New Label()
        MenuStrip1 = New MenuStrip()
        AccionesToolStripMenuItem = New ToolStripMenuItem()
        ControlRemotoConfigurationManagerToolStripMenuItem = New ToolStripMenuItem()
        ReiniciarToolStripMenuItem = New ToolStripMenuItem()
        NuevoTouchToolStripMenuItem = New ToolStripMenuItem()
        EditarHostnameToolStripMenuItem = New ToolStripMenuItem()
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
        Label10.TabIndex = 51
        ' 
        ' txtSerial
        ' 
        txtSerial.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSerial.Location = New Point(122, 60)
        txtSerial.Margin = New Padding(4, 3, 4, 3)
        txtSerial.Name = "txtSerial"
        txtSerial.ReadOnly = True
        txtSerial.Size = New Size(148, 21)
        txtSerial.TabIndex = 49
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(81, 63)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 13)
        Label2.TabIndex = 48
        Label2.Text = "Serial"
        ' 
        ' txtModel
        ' 
        txtModel.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtModel.Location = New Point(122, 33)
        txtModel.Margin = New Padding(4, 3, 4, 3)
        txtModel.Name = "txtModel"
        txtModel.ReadOnly = True
        txtModel.Size = New Size(148, 21)
        txtModel.TabIndex = 47
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(73, 36)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 13)
        Label3.TabIndex = 46
        Label3.Text = "Modelo"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(78, 9)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 13)
        Label1.TabIndex = 45
        Label1.Text = "Touch"
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
        ComboBox1.TabIndex = 44
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.ControlText
        Label9.Location = New Point(234, 103)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(0, 13)
        Label9.TabIndex = 63
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(40, 173)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 13)
        Label4.TabIndex = 52
        Label4.Text = "Usuario Qflow"
        ' 
        ' txtNQflow
        ' 
        txtNQflow.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtNQflow.Location = New Point(122, 169)
        txtNQflow.Margin = New Padding(4, 3, 4, 3)
        txtNQflow.Name = "txtNQflow"
        txtNQflow.ReadOnly = True
        txtNQflow.Size = New Size(233, 21)
        txtNQflow.TabIndex = 53
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(33, 205)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 13)
        Label6.TabIndex = 56
        Label6.Text = "Teléfono NCR"
        ' 
        ' lnkTel
        ' 
        lnkTel.AutoSize = True
        lnkTel.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        lnkTel.Location = New Point(122, 205)
        lnkTel.Margin = New Padding(4, 0, 4, 0)
        lnkTel.Name = "lnkTel"
        lnkTel.Size = New Size(94, 13)
        lnkTel.TabIndex = 58
        lnkTel.TabStop = True
        lnkTel.Text = "0800-800-0199"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(18, 147)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(96, 13)
        Label7.TabIndex = 59
        Label7.Text = "Nombre Impresora"
        ' 
        ' txtImpresora
        ' 
        txtImpresora.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtImpresora.Location = New Point(122, 142)
        txtImpresora.Margin = New Padding(4, 3, 4, 3)
        txtImpresora.Name = "txtImpresora"
        txtImpresora.ReadOnly = True
        txtImpresora.Size = New Size(233, 21)
        txtImpresora.TabIndex = 60
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(122, 87)
        ListBox1.Margin = New Padding(4, 3, 4, 3)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(104, 49)
        ListBox1.TabIndex = 89
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(40, 102)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 13)
        Label5.TabIndex = 88
        Label5.Text = "Direcciones IP"
        ' 
        ' LblModel
        ' 
        LblModel.AutoSize = True
        LblModel.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblModel.Location = New Point(285, 42)
        LblModel.Margin = New Padding(4, 0, 4, 0)
        LblModel.Name = "LblModel"
        LblModel.Size = New Size(0, 13)
        LblModel.TabIndex = 90
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.GripStyle = ToolStripGripStyle.Visible
        MenuStrip1.Items.AddRange(New ToolStripItem() {AccionesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(370, 24)
        MenuStrip1.TabIndex = 94
        MenuStrip1.Text = "MenuStrip1"
        MenuStrip1.Visible = False
        ' 
        ' AccionesToolStripMenuItem
        ' 
        AccionesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ControlRemotoConfigurationManagerToolStripMenuItem, ReiniciarToolStripMenuItem, NuevoTouchToolStripMenuItem, EditarHostnameToolStripMenuItem})
        AccionesToolStripMenuItem.Name = "AccionesToolStripMenuItem"
        AccionesToolStripMenuItem.Size = New Size(67, 20)
        AccionesToolStripMenuItem.Text = "&Acciones"
        ' 
        ' ControlRemotoConfigurationManagerToolStripMenuItem
        ' 
        ControlRemotoConfigurationManagerToolStripMenuItem.Name = "ControlRemotoConfigurationManagerToolStripMenuItem"
        ControlRemotoConfigurationManagerToolStripMenuItem.Size = New Size(291, 22)
        ControlRemotoConfigurationManagerToolStripMenuItem.Text = "&Control remoto (Configuration Manager)"
        ' 
        ' ReiniciarToolStripMenuItem
        ' 
        ReiniciarToolStripMenuItem.Name = "ReiniciarToolStripMenuItem"
        ReiniciarToolStripMenuItem.Size = New Size(291, 22)
        ReiniciarToolStripMenuItem.Text = "&Reiniciar"
        ' 
        ' NuevoTouchToolStripMenuItem
        ' 
        NuevoTouchToolStripMenuItem.Name = "NuevoTouchToolStripMenuItem"
        NuevoTouchToolStripMenuItem.Size = New Size(291, 22)
        NuevoTouchToolStripMenuItem.Text = "&Nuevo touch..."
        ' 
        ' EditarHostnameToolStripMenuItem
        ' 
        EditarHostnameToolStripMenuItem.Name = "EditarHostnameToolStripMenuItem"
        EditarHostnameToolStripMenuItem.Size = New Size(291, 22)
        EditarHostnameToolStripMenuItem.Text = "&Editar hostname..."
        ' 
        ' Touch
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 228)
        Controls.Add(MenuStrip1)
        Controls.Add(LblModel)
        Controls.Add(ListBox1)
        Controls.Add(Label5)
        Controls.Add(Label9)
        Controls.Add(txtImpresora)
        Controls.Add(Label7)
        Controls.Add(lnkTel)
        Controls.Add(Label6)
        Controls.Add(txtNQflow)
        Controls.Add(Label4)
        Controls.Add(Label10)
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
        Name = "Touch"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Touch"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNQflow As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lnkTel As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtImpresora As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LblModel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlRemotoConfigurationManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReiniciarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarHostnameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoTouchToolStripMenuItem As ToolStripMenuItem
End Class
