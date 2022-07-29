<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.arbol = New System.Windows.Forms.TreeView()
        Me.carpetas = New System.Windows.Forms.ImageList(Me.components)
        Me.lista = New System.Windows.Forms.ListView()
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tamaño = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Iconos = New System.Windows.Forms.ImageList(Me.components)
        Me.Icopec = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.View1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.View2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.View3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.View4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDePkgViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetPKGStudioToOpenAllPKGFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.extract = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SourceExtractMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropiedadesDelPkgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.noselec = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PropiedadesDelPkgToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.od = New System.Windows.Forms.OpenFileDialog()
        Me.sd = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.extract.SuspendLayout()
        Me.noselec.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.arbol)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lista)
        Me.SplitContainer1.Size = New System.Drawing.Size(1038, 561)
        Me.SplitContainer1.SplitterDistance = 343
        Me.SplitContainer1.TabIndex = 3
        '
        'arbol
        '
        Me.arbol.AllowDrop = True
        Me.arbol.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.arbol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.arbol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.arbol.ForeColor = System.Drawing.Color.White
        Me.arbol.ImageIndex = 0
        Me.arbol.ImageList = Me.carpetas
        Me.arbol.Location = New System.Drawing.Point(0, 0)
        Me.arbol.Name = "arbol"
        Me.arbol.SelectedImageIndex = 0
        Me.arbol.Size = New System.Drawing.Size(343, 561)
        Me.arbol.TabIndex = 0
        '
        'carpetas
        '
        Me.carpetas.ImageStream = CType(resources.GetObject("carpetas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.carpetas.TransparentColor = System.Drawing.Color.Transparent
        Me.carpetas.Images.SetKeyName(0, "folderClosed.ico")
        Me.carpetas.Images.SetKeyName(1, "folderOpen.ico")
        '
        'lista
        '
        Me.lista.AllowDrop = True
        Me.lista.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lista.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nombre, Me.Tamaño})
        Me.lista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lista.ForeColor = System.Drawing.Color.White
        Me.lista.HideSelection = False
        Me.lista.LargeImageList = Me.Iconos
        Me.lista.Location = New System.Drawing.Point(0, 0)
        Me.lista.Name = "lista"
        Me.lista.Size = New System.Drawing.Size(691, 561)
        Me.lista.SmallImageList = Me.Icopec
        Me.lista.TabIndex = 0
        Me.lista.UseCompatibleStateImageBehavior = False
        Me.lista.View = System.Windows.Forms.View.List
        '
        'Nombre
        '
        Me.Nombre.Text = "Name"
        Me.Nombre.Width = 276
        '
        'Tamaño
        '
        Me.Tamaño.Text = "Size"
        Me.Tamaño.Width = 100
        '
        'Iconos
        '
        Me.Iconos.ImageStream = CType(resources.GetObject("Iconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Iconos.TransparentColor = System.Drawing.Color.Transparent
        Me.Iconos.Images.SetKeyName(0, "folderOpenbig.ico")
        '
        'Icopec
        '
        Me.Icopec.ImageStream = CType(resources.GetObject("Icopec.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Icopec.TransparentColor = System.Drawing.Color.Transparent
        Me.Icopec.Images.SetKeyName(0, "folderClosed.ico")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ViewToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1038, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.AbrirToolStripMenuItem, Me.ToolStripSeparator2, Me.GuardarToolStripMenuItem, Me.GuardarComoToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ArchivoToolStripMenuItem.Text = "File"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Enabled = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(121, 22)
        Me.ToolStripTextBox1.Text = "New"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.AbrirToolStripMenuItem.Text = "Open..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(118, 6)
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Enabled = False
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.GuardarToolStripMenuItem.Text = "Save"
        '
        'GuardarComoToolStripMenuItem
        '
        Me.GuardarComoToolStripMenuItem.Enabled = False
        Me.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        Me.GuardarComoToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.GuardarComoToolStripMenuItem.Text = "Save as..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(118, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.SalirToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.View1ToolStripMenuItem, Me.View2ToolStripMenuItem, Me.View3ToolStripMenuItem, Me.View4ToolStripMenuItem})
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'View1ToolStripMenuItem
        '
        Me.View1ToolStripMenuItem.Name = "View1ToolStripMenuItem"
        Me.View1ToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.View1ToolStripMenuItem.Text = "View - 1"
        '
        'View2ToolStripMenuItem
        '
        Me.View2ToolStripMenuItem.Name = "View2ToolStripMenuItem"
        Me.View2ToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.View2ToolStripMenuItem.Text = "View  - 2"
        '
        'View3ToolStripMenuItem
        '
        Me.View3ToolStripMenuItem.Name = "View3ToolStripMenuItem"
        Me.View3ToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.View3ToolStripMenuItem.Text = "View - 3"
        '
        'View4ToolStripMenuItem
        '
        Me.View4ToolStripMenuItem.Name = "View4ToolStripMenuItem"
        Me.View4ToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.View4ToolStripMenuItem.Text = "View - 4"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDePkgViewToolStripMenuItem, Me.SetPKGStudioToOpenAllPKGFilesToolStripMenuItem})
        Me.AyudaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AyudaToolStripMenuItem.Text = "Help"
        '
        'AcercaDePkgViewToolStripMenuItem
        '
        Me.AcercaDePkgViewToolStripMenuItem.Name = "AcercaDePkgViewToolStripMenuItem"
        Me.AcercaDePkgViewToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.AcercaDePkgViewToolStripMenuItem.Text = "About PKG Studio"
        '
        'SetPKGStudioToOpenAllPKGFilesToolStripMenuItem
        '
        Me.SetPKGStudioToOpenAllPKGFilesToolStripMenuItem.Name = "SetPKGStudioToOpenAllPKGFilesToolStripMenuItem"
        Me.SetPKGStudioToOpenAllPKGFilesToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.SetPKGStudioToOpenAllPKGFilesToolStripMenuItem.Text = "Set PKG Studio to open all PKG files"
        '
        'extract
        '
        Me.extract.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SourceExtractMenuItem, Me.ExtraerToolStripMenuItem, Me.ToolStripSeparator4, Me.PropiedadesDelPkgToolStripMenuItem})
        Me.extract.Name = "context"
        Me.extract.Size = New System.Drawing.Size(197, 76)
        '
        'SourceExtractMenuItem
        '
        Me.SourceExtractMenuItem.Name = "SourceExtractMenuItem"
        Me.SourceExtractMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.SourceExtractMenuItem.Text = "Extract to source folder"
        '
        'ExtraerToolStripMenuItem
        '
        Me.ExtraerToolStripMenuItem.Name = "ExtraerToolStripMenuItem"
        Me.ExtraerToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ExtraerToolStripMenuItem.Text = "Extract..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(193, 6)
        '
        'PropiedadesDelPkgToolStripMenuItem
        '
        Me.PropiedadesDelPkgToolStripMenuItem.Enabled = False
        Me.PropiedadesDelPkgToolStripMenuItem.Name = "PropiedadesDelPkgToolStripMenuItem"
        Me.PropiedadesDelPkgToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.PropiedadesDelPkgToolStripMenuItem.Text = "Pkg properties"
        '
        'noselec
        '
        Me.noselec.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PropiedadesDelPkgToolStripMenuItem1})
        Me.noselec.Name = "noselec"
        Me.noselec.Size = New System.Drawing.Size(151, 26)
        '
        'PropiedadesDelPkgToolStripMenuItem1
        '
        Me.PropiedadesDelPkgToolStripMenuItem1.Enabled = False
        Me.PropiedadesDelPkgToolStripMenuItem1.Name = "PropiedadesDelPkgToolStripMenuItem1"
        Me.PropiedadesDelPkgToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.PropiedadesDelPkgToolStripMenuItem1.Text = "Pkg properties"
        '
        'od
        '
        Me.od.FileName = "OpenFileDialog1"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1038, 585)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PKG Studio - UltimateCraft Edition"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.extract.ResumeLayout(False)
        Me.noselec.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents arbol As System.Windows.Forms.TreeView
    Friend WithEvents lista As System.Windows.Forms.ListView
    Friend WithEvents Iconos As System.Windows.Forms.ImageList
    Friend WithEvents carpetas As System.Windows.Forms.ImageList
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDePkgViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents extract As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExtraerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Icopec As System.Windows.Forms.ImageList
    Friend WithEvents Nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tamaño As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PropiedadesDelPkgToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents noselec As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PropiedadesDelPkgToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents od As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SourceExtractMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents View1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents View2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents View3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents View4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetPKGStudioToOpenAllPKGFilesToolStripMenuItem As ToolStripMenuItem
End Class
