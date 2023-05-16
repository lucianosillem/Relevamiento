<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Impresoras
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Impresoras))
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label10 = New Label()
        Label5 = New Label()
        txtSerial = New TextBox()
        Label2 = New Label()
        txtModel = New TextBox()
        Label3 = New Label()
        txtMAC = New TextBox()
        Label4 = New Label()
        lnkIP = New LinkLabel()
        Label6 = New Label()
        Label7 = New Label()
        lnkCMS = New LinkLabel()
        lnkDFM = New LinkLabel()
        txtComment = New TextBox()
        lblComment = New Label()
        ToolStrip1 = New ToolStrip()
        ToolStripButtonAdd = New ToolStripButton()
        ToolStripButtonObtain = New ToolStripButton()
        ToolStripButtonEdit = New ToolStripButton()
        ToolStripButtonChangeIP = New ToolStripButton()
        ToolStripButton1 = New ToolStripButton()
        ToolStripButtonOK = New ToolStripButton()
        ToolStripButtonCancel = New ToolStripButton()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        txtFirmware = New TextBox()
        Label8 = New Label()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(10, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 13)
        Label1.TabIndex = 3
        Label1.Text = "Cola de impresión"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBox1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(107, 12)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(200, 21)
        ComboBox1.TabIndex = 2
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.Green
        Label10.Location = New Point(197, 95)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 13)
        Label10.TabIndex = 35
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(38, 95)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 13)
        Label5.TabIndex = 33
        Label5.Text = "Dirección IP"
        ' 
        ' txtSerial
        ' 
        txtSerial.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSerial.Location = New Point(107, 65)
        txtSerial.Name = "txtSerial"
        txtSerial.ReadOnly = True
        txtSerial.Size = New Size(200, 21)
        txtSerial.TabIndex = 32
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(16, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 13)
        Label2.TabIndex = 31
        Label2.Text = "Número de serie"
        ' 
        ' txtModel
        ' 
        txtModel.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtModel.Location = New Point(107, 39)
        txtModel.Name = "txtModel"
        txtModel.ReadOnly = True
        txtModel.Size = New Size(200, 21)
        txtModel.TabIndex = 30
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(60, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 13)
        Label3.TabIndex = 29
        Label3.Text = "Modelo"
        ' 
        ' txtMAC
        ' 
        txtMAC.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtMAC.Location = New Point(107, 119)
        txtMAC.Name = "txtMAC"
        txtMAC.ReadOnly = True
        txtMAC.Size = New Size(200, 21)
        txtMAC.TabIndex = 37
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(26, 122)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 13)
        Label4.TabIndex = 36
        Label4.Text = "Dirección MAC"
        ' 
        ' lnkIP
        ' 
        lnkIP.AutoSize = True
        lnkIP.Location = New Point(107, 95)
        lnkIP.Name = "lnkIP"
        lnkIP.Size = New Size(0, 13)
        lnkIP.TabIndex = 38
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(45, 246)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 13)
        Label6.TabIndex = 40
        Label6.Text = "Insumos"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(21, 273)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 13)
        Label7.TabIndex = 41
        Label7.Text = "Serv. técnico"
        ' 
        ' lnkCMS
        ' 
        lnkCMS.AutoSize = True
        lnkCMS.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        lnkCMS.Location = New Point(107, 246)
        lnkCMS.Name = "lnkCMS"
        lnkCMS.Size = New Size(136, 13)
        lnkCMS.TabIndex = 42
        lnkCMS.TabStop = True
        lnkCMS.Text = "dfmcms@lexmark.com"
        ' 
        ' lnkDFM
        ' 
        lnkDFM.AutoSize = True
        lnkDFM.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        lnkDFM.Location = New Point(107, 273)
        lnkDFM.Name = "lnkDFM"
        lnkDFM.Size = New Size(177, 13)
        lnkDFM.TabIndex = 43
        lnkDFM.TabStop = True
        lnkDFM.Text = "dfm.vip@lexmarksoporte.com"
        ' 
        ' txtComment
        ' 
        txtComment.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtComment.Location = New Point(107, 173)
        txtComment.Multiline = True
        txtComment.Name = "txtComment"
        txtComment.ReadOnly = True
        txtComment.Size = New Size(200, 70)
        txtComment.TabIndex = 45
        ' 
        ' lblComment
        ' 
        lblComment.AutoSize = True
        lblComment.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblComment.Location = New Point(39, 176)
        lblComment.Name = "lblComment"
        lblComment.Size = New Size(62, 13)
        lblComment.TabIndex = 44
        lblComment.Text = "Comentario"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Dock = DockStyle.Right
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButtonAdd, ToolStripButtonObtain, ToolStripButtonEdit, ToolStripButtonChangeIP, ToolStripButton1, ToolStripButtonOK, ToolStripButtonCancel})
        ToolStrip1.Location = New Point(317, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(24, 299)
        ToolStrip1.TabIndex = 46
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripButtonAdd
        ' 
        ToolStripButtonAdd.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButtonAdd.Image = CType(resources.GetObject("ToolStripButtonAdd.Image"), Image)
        ToolStripButtonAdd.ImageTransparentColor = Color.Magenta
        ToolStripButtonAdd.Name = "ToolStripButtonAdd"
        ToolStripButtonAdd.Size = New Size(21, 20)
        ToolStripButtonAdd.Text = "Agregar impresora"
        ' 
        ' ToolStripButtonObtain
        ' 
        ToolStripButtonObtain.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButtonObtain.Image = CType(resources.GetObject("ToolStripButtonObtain.Image"), Image)
        ToolStripButtonObtain.ImageTransparentColor = Color.Magenta
        ToolStripButtonObtain.Name = "ToolStripButtonObtain"
        ToolStripButtonObtain.Size = New Size(21, 20)
        ToolStripButtonObtain.Text = "Obtener datos"
        ' 
        ' ToolStripButtonEdit
        ' 
        ToolStripButtonEdit.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButtonEdit.Image = CType(resources.GetObject("ToolStripButtonEdit.Image"), Image)
        ToolStripButtonEdit.ImageTransparentColor = Color.Magenta
        ToolStripButtonEdit.Name = "ToolStripButtonEdit"
        ToolStripButtonEdit.Size = New Size(21, 20)
        ToolStripButtonEdit.Text = "Editar"
        ' 
        ' ToolStripButtonChangeIP
        ' 
        ToolStripButtonChangeIP.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButtonChangeIP.Image = CType(resources.GetObject("ToolStripButtonChangeIP.Image"), Image)
        ToolStripButtonChangeIP.ImageTransparentColor = Color.Magenta
        ToolStripButtonChangeIP.Name = "ToolStripButtonChangeIP"
        ToolStripButtonChangeIP.Size = New Size(21, 20)
        ToolStripButtonChangeIP.Text = "Editar IP"
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(21, 20)
        ToolStripButton1.Text = "Panel del operador remoto"
        ' 
        ' ToolStripButtonOK
        ' 
        ToolStripButtonOK.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButtonOK.Enabled = False
        ToolStripButtonOK.Image = CType(resources.GetObject("ToolStripButtonOK.Image"), Image)
        ToolStripButtonOK.ImageTransparentColor = Color.Magenta
        ToolStripButtonOK.Name = "ToolStripButtonOK"
        ToolStripButtonOK.Size = New Size(21, 20)
        ToolStripButtonOK.Text = "Guardar"
        ' 
        ' ToolStripButtonCancel
        ' 
        ToolStripButtonCancel.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButtonCancel.Enabled = False
        ToolStripButtonCancel.Image = CType(resources.GetObject("ToolStripButtonCancel.Image"), Image)
        ToolStripButtonCancel.ImageTransparentColor = Color.Magenta
        ToolStripButtonCancel.Name = "ToolStripButtonCancel"
        ToolStripButtonCancel.Size = New Size(21, 20)
        ToolStripButtonCancel.Text = "Cancelar"
        ' 
        ' txtFirmware
        ' 
        txtFirmware.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtFirmware.Location = New Point(107, 146)
        txtFirmware.Name = "txtFirmware"
        txtFirmware.ReadOnly = True
        txtFirmware.Size = New Size(200, 21)
        txtFirmware.TabIndex = 48
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(40, 149)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 13)
        Label8.TabIndex = 47
        Label8.Text = "Versión FW"
        ' 
        ' Impresoras
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(341, 299)
        Controls.Add(txtFirmware)
        Controls.Add(Label8)
        Controls.Add(ToolStrip1)
        Controls.Add(txtComment)
        Controls.Add(lblComment)
        Controls.Add(lnkDFM)
        Controls.Add(lnkCMS)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(lnkIP)
        Controls.Add(txtMAC)
        Controls.Add(Label4)
        Controls.Add(Label10)
        Controls.Add(Label5)
        Controls.Add(txtSerial)
        Controls.Add(Label2)
        Controls.Add(txtModel)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "Impresoras"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Impresoras"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMAC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lnkIP As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lnkCMS As LinkLabel
    Friend WithEvents lnkDFM As LinkLabel
    Friend WithEvents txtComment As TextBox
    Friend WithEvents lblComment As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButtonOK As ToolStripButton
    Friend WithEvents ToolStripButtonCancel As ToolStripButton
    Friend WithEvents ToolStripButtonEdit As ToolStripButton
    Friend WithEvents ToolStripButtonChangeIP As ToolStripButton
    Friend WithEvents ToolStripButtonObtain As ToolStripButton
    Friend WithEvents ToolStripButtonAdd As ToolStripButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents txtFirmware As TextBox
    Friend WithEvents Label8 As Label
End Class
