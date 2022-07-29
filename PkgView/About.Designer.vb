<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.button4 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button4
        '
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button4.Image = CType(resources.GetObject("button4.Image"), System.Drawing.Image)
        Me.button4.Location = New System.Drawing.Point(342, 211)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(138, 87)
        Me.button4.TabIndex = 9
        Me.button4.Text = "YouTube"
        Me.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.button4.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Image = CType(resources.GetObject("button2.Image"), System.Drawing.Image)
        Me.button2.Location = New System.Drawing.Point(198, 211)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(138, 87)
        Me.button2.TabIndex = 8
        Me.button2.Text = "Discord"
        Me.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
        Me.button1.Location = New System.Drawing.Point(54, 211)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(138, 87)
        Me.button1.TabIndex = 7
        Me.button1.Text = "GitHub"
        Me.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.button1.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(209, 31)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(280, 100)
        Me.label1.TabIndex = 6
        Me.label1.Text = "PKG Studio - UltimateCrat Edition" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Version: 1.1.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Created by: EternalModz"
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(46, 31)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(157, 157)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox1.TabIndex = 5
        Me.pictureBox1.TabStop = False
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(535, 317)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button4 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
End Class
