<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.VentasToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.ListadpToolStripMenuItem})
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuarioToolStripMenuItem.Text = "Usuarios"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'ListadpToolStripMenuItem
        '
        Me.ListadpToolStripMenuItem.Name = "ListadpToolStripMenuItem"
        Me.ListadpToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListadpToolStripMenuItem.Text = "Listado"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem1, Me.ListadoToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'AgregarToolStripMenuItem1
        '
        Me.AgregarToolStripMenuItem1.Name = "AgregarToolStripMenuItem1"
        Me.AgregarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AgregarToolStripMenuItem1.Text = "Agregar"
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListadoToolStripMenuItem.Text = "Listado"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem2, Me.ListadoToolStripMenuItem1})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AgregarToolStripMenuItem2
        '
        Me.AgregarToolStripMenuItem2.Name = "AgregarToolStripMenuItem2"
        Me.AgregarToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.AgregarToolStripMenuItem2.Text = "Agregar"
        '
        'ListadoToolStripMenuItem1
        '
        Me.ListadoToolStripMenuItem1.Name = "ListadoToolStripMenuItem1"
        Me.ListadoToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ListadoToolStripMenuItem1.Text = "Listado"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem3, Me.ListadoToolStripMenuItem2})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'AgregarToolStripMenuItem3
        '
        Me.AgregarToolStripMenuItem3.Name = "AgregarToolStripMenuItem3"
        Me.AgregarToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.AgregarToolStripMenuItem3.Text = "Agregar"
        '
        'ListadoToolStripMenuItem2
        '
        Me.ListadoToolStripMenuItem2.Name = "ListadoToolStripMenuItem2"
        Me.ListadoToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ListadoToolStripMenuItem2.Text = "Listado"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem2 As ToolStripMenuItem
End Class
