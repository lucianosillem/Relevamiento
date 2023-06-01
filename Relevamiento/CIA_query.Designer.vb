<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIA_query
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
        txtSerial = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        LinkLabel1 = New LinkLabel()
        Button1 = New Button()
        TextBox3 = New TextBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSerial
        ' 
        txtSerial.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSerial.Location = New Point(144, 9)
        txtSerial.Name = "txtSerial"
        txtSerial.Size = New Size(200, 22)
        txtSerial.TabIndex = 34
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 13)
        Label2.TabIndex = 33
        Label2.Text = "Service Tag"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(144, 36)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 22)
        TextBox1.TabIndex = 36
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 13)
        Label1.TabIndex = 35
        Label1.Text = "Usuario"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(144, 63)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 22)
        TextBox2.TabIndex = 38
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 13)
        Label3.TabIndex = 37
        Label3.Text = "Hostname"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.Location = New Point(350, 9)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(24, 13)
        LinkLabel1.TabIndex = 39
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "CIA"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(144, 147)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 40
        Button1.Text = "&Buscar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(144, 91)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(200, 22)
        TextBox3.TabIndex = 42
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 91)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 13)
        Label4.TabIndex = 41
        Label4.Text = "Modelo"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(144, 119)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(200, 22)
        TextBox4.TabIndex = 44
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(12, 119)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 13)
        Label5.TabIndex = 43
        Label5.Text = "Nombre y Apellido"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.Location = New Point(380, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.ShowEditingIcon = False
        DataGridView1.Size = New Size(755, 155)
        DataGridView1.TabIndex = 45
        ' 
        ' CIA_query
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1147, 179)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(LinkLabel1)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(txtSerial)
        Controls.Add(Label2)
        Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "CIA_query"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Consulta CIA (experimental)"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSerial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
