<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RelevamientoEdificios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(RelevamientoEdificios))
        txtCP = New TextBox()
        Label6 = New Label()
        txtProvincia = New TextBox()
        Label4 = New Label()
        txtLocalidad = New TextBox()
        txtDireccion = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        MenuStrip1 = New MenuStrip()
        VerToolStripMenuItem = New ToolStripMenuItem()
        ImpresorasToolStripMenuItem = New ToolStripMenuItem()
        SalasTeamsToolStripMenuItem = New ToolStripMenuItem()
        AccionesToolStripMenuItem = New ToolStripMenuItem()
        CopiarDirecciónCompletaToolStripMenuItem = New ToolStripMenuItem()
        EditarValorToolStripMenuItem = New ToolStripMenuItem()
        ImprimirEtiquetaDeEnvíoToolStripMenuItem = New ToolStripMenuItem()
        ImprimirEtiquetaDeEnvíodomicilioParticularToolStripMenuItem = New ToolStripMenuItem()
        PrintDialog1 = New PrintDialog()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtCP
        ' 
        txtCP.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtCP.Location = New Point(82, 107)
        txtCP.Margin = New Padding(4, 3, 4, 3)
        txtCP.Name = "txtCP"
        txtCP.ReadOnly = True
        txtCP.Size = New Size(75, 21)
        txtCP.TabIndex = 35
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(51, 111)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(20, 13)
        Label6.TabIndex = 34
        Label6.Text = "CP"
        Label6.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtProvincia
        ' 
        txtProvincia.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtProvincia.Location = New Point(335, 76)
        txtProvincia.Margin = New Padding(4, 3, 4, 3)
        txtProvincia.Name = "txtProvincia"
        txtProvincia.ReadOnly = True
        txtProvincia.Size = New Size(209, 21)
        txtProvincia.TabIndex = 31
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(270, 80)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 13)
        Label4.TabIndex = 30
        Label4.Text = "Provincia"
        Label4.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtLocalidad
        ' 
        txtLocalidad.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtLocalidad.Location = New Point(82, 76)
        txtLocalidad.Margin = New Padding(4, 3, 4, 3)
        txtLocalidad.Name = "txtLocalidad"
        txtLocalidad.ReadOnly = True
        txtLocalidad.Size = New Size(184, 21)
        txtLocalidad.TabIndex = 29
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtDireccion.Location = New Point(82, 45)
        txtDireccion.Margin = New Padding(4, 3, 4, 3)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.ReadOnly = True
        txtDireccion.Size = New Size(462, 21)
        txtDireccion.TabIndex = 28
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(15, 80)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 13)
        Label3.TabIndex = 27
        Label3.Text = "Localidad"
        Label3.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(16, 48)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 13)
        Label2.TabIndex = 26
        Label2.Text = "Dirección"
        Label2.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(28, 17)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 13)
        Label1.TabIndex = 25
        Label1.Text = "Edificio"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AutoCompleteMode = AutoCompleteMode.Append
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBox1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(82, 14)
        ComboBox1.Margin = New Padding(4, 3, 4, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(462, 21)
        ComboBox1.TabIndex = 24
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.Items.AddRange(New ToolStripItem() {VerToolStripMenuItem, AccionesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(560, 28)
        MenuStrip1.TabIndex = 49
        MenuStrip1.Text = "MenuStrip1"
        MenuStrip1.Visible = False
        ' 
        ' VerToolStripMenuItem
        ' 
        VerToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ImpresorasToolStripMenuItem, SalasTeamsToolStripMenuItem})
        VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        VerToolStripMenuItem.Size = New Size(38, 24)
        VerToolStripMenuItem.Text = "&Ver"
        ' 
        ' ImpresorasToolStripMenuItem
        ' 
        ImpresorasToolStripMenuItem.Name = "ImpresorasToolStripMenuItem"
        ImpresorasToolStripMenuItem.Size = New Size(163, 22)
        ImpresorasToolStripMenuItem.Text = "&Impresoras"
        ' 
        ' SalasTeamsToolStripMenuItem
        ' 
        SalasTeamsToolStripMenuItem.Name = "SalasTeamsToolStripMenuItem"
        SalasTeamsToolStripMenuItem.Size = New Size(163, 22)
        SalasTeamsToolStripMenuItem.Text = "&Salas de reunión"
        ' 
        ' AccionesToolStripMenuItem
        ' 
        AccionesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarDirecciónCompletaToolStripMenuItem, EditarValorToolStripMenuItem, ImprimirEtiquetaDeEnvíoToolStripMenuItem, ImprimirEtiquetaDeEnvíodomicilioParticularToolStripMenuItem})
        AccionesToolStripMenuItem.Name = "AccionesToolStripMenuItem"
        AccionesToolStripMenuItem.Size = New Size(67, 24)
        AccionesToolStripMenuItem.Text = "&Acciones"
        ' 
        ' CopiarDirecciónCompletaToolStripMenuItem
        ' 
        CopiarDirecciónCompletaToolStripMenuItem.Name = "CopiarDirecciónCompletaToolStripMenuItem"
        CopiarDirecciónCompletaToolStripMenuItem.Size = New Size(330, 22)
        CopiarDirecciónCompletaToolStripMenuItem.Text = "&Copiar dirección completa"
        ' 
        ' EditarValorToolStripMenuItem
        ' 
        EditarValorToolStripMenuItem.Name = "EditarValorToolStripMenuItem"
        EditarValorToolStripMenuItem.Size = New Size(330, 22)
        EditarValorToolStripMenuItem.Text = "&Editar valor"
        ' 
        ' ImprimirEtiquetaDeEnvíoToolStripMenuItem
        ' 
        ImprimirEtiquetaDeEnvíoToolStripMenuItem.Name = "ImprimirEtiquetaDeEnvíoToolStripMenuItem"
        ImprimirEtiquetaDeEnvíoToolStripMenuItem.Size = New Size(330, 22)
        ImprimirEtiquetaDeEnvíoToolStripMenuItem.Text = "&Imprimir etiqueta de envío"
        ' 
        ' ImprimirEtiquetaDeEnvíodomicilioParticularToolStripMenuItem
        ' 
        ImprimirEtiquetaDeEnvíodomicilioParticularToolStripMenuItem.Name = "ImprimirEtiquetaDeEnvíodomicilioParticularToolStripMenuItem"
        ImprimirEtiquetaDeEnvíodomicilioParticularToolStripMenuItem.Size = New Size(330, 22)
        ImprimirEtiquetaDeEnvíodomicilioParticularToolStripMenuItem.Text = "I&mprimir etiqueta de envío (domicilio particular)"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
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
        ' PrintDocument1
        ' 
        ' 
        ' RelevamientoEdificios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 141)
        Controls.Add(MenuStrip1)
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
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "RelevamientoEdificios"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = " Relevamiento Edificios"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtCP As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpresorasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarDirecciónCompletaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalasTeamsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirEtiquetaDeEnvíoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ImprimirEtiquetaDeEnvíodomicilioParticularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarValorToolStripMenuItem As ToolStripMenuItem
End Class
