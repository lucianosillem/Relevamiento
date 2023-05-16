<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RelevamientoMenu
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(RelevamientoMenu))
        MenuStrip = New MenuStrip()
        MenuToolStripMenuItem = New ToolStripMenuItem()
        RelevamientoCACsToolStripMenuItem = New ToolStripMenuItem()
        RelevamientoEdificiosCorporativosToolStripMenuItem = New ToolStripMenuItem()
        ToolsMenu = New ToolStripMenuItem()
        ConsolaADToolStripMenuItem = New ToolStripMenuItem()
        ConsolaDHCPToolStripMenuItem = New ToolStripMenuItem()
        ConsultaGarantíaDellToolStripMenuItem = New ToolStripMenuItem()
        ToolTip = New ToolTip(components)
        Timer1 = New Timer(components)
        MenuStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem, ToolsMenu})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Size = New Size(632, 24)
        MenuStrip.TabIndex = 5
        MenuStrip.Text = "MenuStrip"
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RelevamientoCACsToolStripMenuItem, RelevamientoEdificiosCorporativosToolStripMenuItem})
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Size = New Size(49, 20)
        MenuToolStripMenuItem.Text = "&Menú"
        ' 
        ' RelevamientoCACsToolStripMenuItem
        ' 
        RelevamientoCACsToolStripMenuItem.Name = "RelevamientoCACsToolStripMenuItem"
        RelevamientoCACsToolStripMenuItem.Size = New Size(193, 22)
        RelevamientoCACsToolStripMenuItem.Text = "Relevamiento &CACs"
        ' 
        ' RelevamientoEdificiosCorporativosToolStripMenuItem
        ' 
        RelevamientoEdificiosCorporativosToolStripMenuItem.Name = "RelevamientoEdificiosCorporativosToolStripMenuItem"
        RelevamientoEdificiosCorporativosToolStripMenuItem.Size = New Size(193, 22)
        RelevamientoEdificiosCorporativosToolStripMenuItem.Text = "Relevamiento &Edificios"
        ' 
        ' ToolsMenu
        ' 
        ToolsMenu.DropDownItems.AddRange(New ToolStripItem() {ConsolaADToolStripMenuItem, ConsolaDHCPToolStripMenuItem, ConsultaGarantíaDellToolStripMenuItem})
        ToolsMenu.Name = "ToolsMenu"
        ToolsMenu.Size = New Size(90, 20)
        ToolsMenu.Text = "&Herramientas"
        ' 
        ' ConsolaADToolStripMenuItem
        ' 
        ConsolaADToolStripMenuItem.Name = "ConsolaADToolStripMenuItem"
        ConsolaADToolStripMenuItem.Size = New Size(190, 22)
        ConsolaADToolStripMenuItem.Text = "Consola &AD"
        ' 
        ' ConsolaDHCPToolStripMenuItem
        ' 
        ConsolaDHCPToolStripMenuItem.Name = "ConsolaDHCPToolStripMenuItem"
        ConsolaDHCPToolStripMenuItem.Size = New Size(190, 22)
        ConsolaDHCPToolStripMenuItem.Text = "Consola &DHCP"
        ' 
        ' ConsultaGarantíaDellToolStripMenuItem
        ' 
        ConsultaGarantíaDellToolStripMenuItem.Name = "ConsultaGarantíaDellToolStripMenuItem"
        ConsultaGarantíaDellToolStripMenuItem.Size = New Size(190, 22)
        ConsultaGarantíaDellToolStripMenuItem.Text = "Consulta &garantía Dell"
        ' 
        ' RelevamientoMenu
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(632, 453)
        Controls.Add(MenuStrip)
        Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip
        Name = "RelevamientoMenu"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Relevamiento"
        WindowState = FormWindowState.Maximized
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelevamientoCACsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelevamientoEdificiosCorporativosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsolaDHCPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ConsolaADToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaGarantíaDellToolStripMenuItem As ToolStripMenuItem
End Class
