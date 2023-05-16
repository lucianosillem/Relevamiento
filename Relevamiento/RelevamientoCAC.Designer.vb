<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelevamientoCAC
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(RelevamientoCAC))
        ComboBox1 = New ComboBox()
        DataSet1 = New DataSet()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtDireccion = New TextBox()
        txtLocalidad = New TextBox()
        txtProvincia = New TextBox()
        Label4 = New Label()
        txtCP = New TextBox()
        Label6 = New Label()
        txtJefe = New TextBox()
        Label7 = New Label()
        txtSuperv1 = New TextBox()
        Label8 = New Label()
        txtSuperv2 = New TextBox()
        Label9 = New Label()
        GroupBox1 = New GroupBox()
        txtRegion = New TextBox()
        Label14 = New Label()
        Label13 = New Label()
        txtTecnico = New TextBox()
        Label12 = New Label()
        txtTecnico2 = New TextBox()
        txtJefeNb = New TextBox()
        Label11 = New Label()
        txtGerente = New TextBox()
        Label10 = New Label()
        MenuStrip1 = New MenuStrip()
        VerToolStripMenuItem = New ToolStripMenuItem()
        ServidorToolStripMenuItem = New ToolStripMenuItem()
        CartelesToolStripMenuItem = New ToolStripMenuItem()
        TouchToolStripMenuItem = New ToolStripMenuItem()
        ImpresorasToolStripMenuItem = New ToolStripMenuItem()
        TabletsToolStripMenuItem = New ToolStripMenuItem()
        AccionesToolStripMenuItem = New ToolStripMenuItem()
        CopiarDirecciónCompletaToolStripMenuItem = New ToolStripMenuItem()
        EditarValorToolStripMenuItem = New ToolStripMenuItem()
        ImprimirEtiquetaDeEnvíoToolStripMenuItem = New ToolStripMenuItem()
        txtCentroCosto = New TextBox()
        Label5 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDialog1 = New PrintDialog()
        txtHorario = New TextBox()
        Label15 = New Label()
        CType(DataSet1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AutoCompleteMode = AutoCompleteMode.Append
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBox1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(68, 6)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(397, 21)
        ComboBox1.TabIndex = 0
        ' 
        ' DataSet1
        ' 
        DataSet1.DataSetName = "NewDataSet"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(35, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(28, 13)
        Label1.TabIndex = 1
        Label1.Text = "CAC"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(13, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 13)
        Label2.TabIndex = 2
        Label2.Text = "Dirección"
        Label2.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 13)
        Label3.TabIndex = 3
        Label3.Text = "Localidad"
        Label3.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtDireccion.Location = New Point(68, 33)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.ReadOnly = True
        txtDireccion.Size = New Size(397, 21)
        txtDireccion.TabIndex = 4
        ' 
        ' txtLocalidad
        ' 
        txtLocalidad.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtLocalidad.Location = New Point(69, 60)
        txtLocalidad.Name = "txtLocalidad"
        txtLocalidad.ReadOnly = True
        txtLocalidad.Size = New Size(158, 21)
        txtLocalidad.TabIndex = 5
        ' 
        ' txtProvincia
        ' 
        txtProvincia.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtProvincia.Location = New Point(287, 60)
        txtProvincia.Name = "txtProvincia"
        txtProvincia.ReadOnly = True
        txtProvincia.Size = New Size(178, 21)
        txtProvincia.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(231, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 13)
        Label4.TabIndex = 6
        Label4.Text = "Provincia"
        Label4.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtCP
        ' 
        txtCP.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtCP.Location = New Point(69, 87)
        txtCP.Name = "txtCP"
        txtCP.ReadOnly = True
        txtCP.Size = New Size(65, 21)
        txtCP.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(43, 91)
        Label6.Name = "Label6"
        Label6.Size = New Size(20, 13)
        Label6.TabIndex = 14
        Label6.Text = "CP"
        Label6.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtJefe
        ' 
        txtJefe.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtJefe.Location = New Point(62, 20)
        txtJefe.Name = "txtJefe"
        txtJefe.ReadOnly = True
        txtJefe.Size = New Size(169, 21)
        txtJefe.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(28, 23)
        Label7.Name = "Label7"
        Label7.Size = New Size(28, 13)
        Label7.TabIndex = 16
        Label7.Text = "Jefe"
        Label7.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtSuperv1
        ' 
        txtSuperv1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSuperv1.Location = New Point(62, 74)
        txtSuperv1.Name = "txtSuperv1"
        txtSuperv1.ReadOnly = True
        txtSuperv1.Size = New Size(169, 21)
        txtSuperv1.TabIndex = 19
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(2, 77)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 13)
        Label8.TabIndex = 18
        Label8.Text = "Superv. 1"
        Label8.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtSuperv2
        ' 
        txtSuperv2.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSuperv2.Location = New Point(290, 74)
        txtSuperv2.Name = "txtSuperv2"
        txtSuperv2.ReadOnly = True
        txtSuperv2.Size = New Size(169, 21)
        txtSuperv2.TabIndex = 21
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(233, 77)
        Label9.Name = "Label9"
        Label9.Size = New Size(54, 13)
        Label9.TabIndex = 20
        Label9.Text = "Superv. 2"
        Label9.TextAlign = ContentAlignment.TopRight
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtRegion)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(txtTecnico)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(txtTecnico2)
        GroupBox1.Controls.Add(txtJefeNb)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(txtGerente)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(txtJefe)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(txtSuperv2)
        GroupBox1.Controls.Add(txtSuperv1)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(6, 144)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(469, 129)
        GroupBox1.TabIndex = 22
        GroupBox1.TabStop = False
        GroupBox1.Text = "Personal del CAC"
        ' 
        ' txtRegion
        ' 
        txtRegion.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtRegion.Location = New Point(62, 47)
        txtRegion.Name = "txtRegion"
        txtRegion.ReadOnly = True
        txtRegion.Size = New Size(169, 21)
        txtRegion.TabIndex = 31
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(16, 50)
        Label14.Name = "Label14"
        Label14.Size = New Size(40, 13)
        Label14.TabIndex = 30
        Label14.Text = "Región"
        Label14.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(4, 104)
        Label13.Name = "Label13"
        Label13.Size = New Size(52, 13)
        Label13.TabIndex = 28
        Label13.Text = "Técnico 1"
        Label13.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtTecnico
        ' 
        txtTecnico.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtTecnico.Location = New Point(62, 101)
        txtTecnico.Name = "txtTecnico"
        txtTecnico.ReadOnly = True
        txtTecnico.Size = New Size(169, 21)
        txtTecnico.TabIndex = 29
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(235, 104)
        Label12.Name = "Label12"
        Label12.Size = New Size(52, 13)
        Label12.TabIndex = 26
        Label12.Text = "Técnico 2"
        Label12.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtTecnico2
        ' 
        txtTecnico2.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtTecnico2.Location = New Point(290, 101)
        txtTecnico2.Name = "txtTecnico2"
        txtTecnico2.ReadOnly = True
        txtTecnico2.Size = New Size(169, 21)
        txtTecnico2.TabIndex = 27
        ' 
        ' txtJefeNb
        ' 
        txtJefeNb.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtJefeNb.Location = New Point(290, 20)
        txtJefeNb.Name = "txtJefeNb"
        txtJefeNb.ReadOnly = True
        txtJefeNb.Size = New Size(169, 21)
        txtJefeNb.TabIndex = 25
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(243, 23)
        Label11.Name = "Label11"
        Label11.Size = New Size(44, 13)
        Label11.TabIndex = 24
        Label11.Text = "Jefe Nb"
        Label11.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtGerente
        ' 
        txtGerente.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtGerente.Location = New Point(290, 47)
        txtGerente.Name = "txtGerente"
        txtGerente.ReadOnly = True
        txtGerente.Size = New Size(169, 21)
        txtGerente.TabIndex = 23
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(241, 50)
        Label10.Name = "Label10"
        Label10.Size = New Size(46, 13)
        Label10.TabIndex = 22
        Label10.Text = "Gerente"
        Label10.TextAlign = ContentAlignment.TopRight
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.Items.AddRange(New ToolStripItem() {VerToolStripMenuItem, AccionesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(480, 24)
        MenuStrip1.TabIndex = 24
        MenuStrip1.Text = "MenuStrip1"
        MenuStrip1.Visible = False
        ' 
        ' VerToolStripMenuItem
        ' 
        VerToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ServidorToolStripMenuItem, CartelesToolStripMenuItem, TouchToolStripMenuItem, ImpresorasToolStripMenuItem, TabletsToolStripMenuItem})
        VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        VerToolStripMenuItem.Size = New Size(38, 20)
        VerToolStripMenuItem.Text = "&Ver"
        ' 
        ' ServidorToolStripMenuItem
        ' 
        ServidorToolStripMenuItem.Name = "ServidorToolStripMenuItem"
        ServidorToolStripMenuItem.Size = New Size(133, 22)
        ServidorToolStripMenuItem.Text = "&Servidor"
        ' 
        ' CartelesToolStripMenuItem
        ' 
        CartelesToolStripMenuItem.Name = "CartelesToolStripMenuItem"
        CartelesToolStripMenuItem.Size = New Size(133, 22)
        CartelesToolStripMenuItem.Text = "&Carteles"
        ' 
        ' TouchToolStripMenuItem
        ' 
        TouchToolStripMenuItem.Name = "TouchToolStripMenuItem"
        TouchToolStripMenuItem.Size = New Size(133, 22)
        TouchToolStripMenuItem.Text = "&Touch"
        ' 
        ' ImpresorasToolStripMenuItem
        ' 
        ImpresorasToolStripMenuItem.Name = "ImpresorasToolStripMenuItem"
        ImpresorasToolStripMenuItem.Size = New Size(133, 22)
        ImpresorasToolStripMenuItem.Text = "&Impresoras"
        ' 
        ' TabletsToolStripMenuItem
        ' 
        TabletsToolStripMenuItem.Name = "TabletsToolStripMenuItem"
        TabletsToolStripMenuItem.Size = New Size(133, 22)
        TabletsToolStripMenuItem.Text = "&Tablets"
        ' 
        ' AccionesToolStripMenuItem
        ' 
        AccionesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarDirecciónCompletaToolStripMenuItem, EditarValorToolStripMenuItem, ImprimirEtiquetaDeEnvíoToolStripMenuItem})
        AccionesToolStripMenuItem.Name = "AccionesToolStripMenuItem"
        AccionesToolStripMenuItem.Size = New Size(67, 20)
        AccionesToolStripMenuItem.Text = "&Acciones"
        ' 
        ' CopiarDirecciónCompletaToolStripMenuItem
        ' 
        CopiarDirecciónCompletaToolStripMenuItem.Name = "CopiarDirecciónCompletaToolStripMenuItem"
        CopiarDirecciónCompletaToolStripMenuItem.Size = New Size(218, 22)
        CopiarDirecciónCompletaToolStripMenuItem.Text = "&Copiar dirección completa"
        ' 
        ' EditarValorToolStripMenuItem
        ' 
        EditarValorToolStripMenuItem.Name = "EditarValorToolStripMenuItem"
        EditarValorToolStripMenuItem.Size = New Size(218, 22)
        EditarValorToolStripMenuItem.Text = "&Editar valor"
        ' 
        ' ImprimirEtiquetaDeEnvíoToolStripMenuItem
        ' 
        ImprimirEtiquetaDeEnvíoToolStripMenuItem.Name = "ImprimirEtiquetaDeEnvíoToolStripMenuItem"
        ImprimirEtiquetaDeEnvíoToolStripMenuItem.Size = New Size(218, 22)
        ImprimirEtiquetaDeEnvíoToolStripMenuItem.Text = "&Imprimir etiqueta de envío"
        ' 
        ' txtCentroCosto
        ' 
        txtCentroCosto.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtCentroCosto.Location = New Point(287, 90)
        txtCentroCosto.Name = "txtCentroCosto"
        txtCentroCosto.ReadOnly = True
        txtCentroCosto.Size = New Size(178, 21)
        txtCentroCosto.TabIndex = 26
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(190, 93)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 13)
        Label5.TabIndex = 25
        Label5.Text = "Centro de Costos"
        Label5.TextAlign = ContentAlignment.TopRight
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' txtHorario
        ' 
        txtHorario.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtHorario.Location = New Point(287, 117)
        txtHorario.Name = "txtHorario"
        txtHorario.ReadOnly = True
        txtHorario.Size = New Size(178, 21)
        txtHorario.TabIndex = 28
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(180, 120)
        Label15.Name = "Label15"
        Label15.Size = New Size(101, 13)
        Label15.TabIndex = 27
        Label15.Text = "Horario de atención"
        Label15.TextAlign = ContentAlignment.TopRight
        ' 
        ' RelevamientoCAC
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 277)
        Controls.Add(MenuStrip1)
        Controls.Add(txtHorario)
        Controls.Add(Label15)
        Controls.Add(txtCentroCosto)
        Controls.Add(Label5)
        Controls.Add(GroupBox1)
        Controls.Add(txtCP)
        Controls.Add(Label6)
        Controls.Add(txtProvincia)
        Controls.Add(Label4)
        Controls.Add(txtLocalidad)
        Controls.Add(txtDireccion)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "RelevamientoCAC"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Relevamiento CACs"
        CType(DataSet1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCP As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtJefe As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSuperv1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSuperv2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServidorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CartelesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TouchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpresorasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabletsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarDirecciónCompletaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtGerente As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtJefeNb As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCentroCosto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents EditarValorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirEtiquetaDeEnvíoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTecnico2 As TextBox
    Friend WithEvents txtRegion As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTecnico As TextBox
    Friend WithEvents txtHorario As TextBox
    Friend WithEvents Label15 As Label
End Class
