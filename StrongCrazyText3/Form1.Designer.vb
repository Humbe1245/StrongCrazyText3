<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.LblVolumen = New System.Windows.Forms.Label()
        Me.TbVolumen = New System.Windows.Forms.TrackBar()
        Me.LblVelocidad = New System.Windows.Forms.Label()
        Me.TbVelocidad = New System.Windows.Forms.TrackBar()
        Me.CbVoz = New System.Windows.Forms.ComboBox()
        Me.LblVoz = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.TxtTitulo = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TxtTexto = New System.Windows.Forms.TextBox()
        Me.TxtCall = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.BtnHablar = New System.Windows.Forms.Button()
        CType(Me.TbVolumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbVelocidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblVolumen
        '
        Me.LblVolumen.AutoSize = True
        Me.LblVolumen.Location = New System.Drawing.Point(428, 41)
        Me.LblVolumen.Name = "LblVolumen"
        Me.LblVolumen.Size = New System.Drawing.Size(48, 13)
        Me.LblVolumen.TabIndex = 24
        Me.LblVolumen.Text = "Volumen"
        '
        'TbVolumen
        '
        Me.TbVolumen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbVolumen.Location = New System.Drawing.Point(482, 37)
        Me.TbVolumen.Maximum = 100
        Me.TbVolumen.Name = "TbVolumen"
        Me.TbVolumen.Size = New System.Drawing.Size(267, 45)
        Me.TbVolumen.TabIndex = 21
        Me.TbVolumen.TickFrequency = 5
        Me.TbVolumen.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TbVolumen.Value = 100
        '
        'LblVelocidad
        '
        Me.LblVelocidad.AutoSize = True
        Me.LblVelocidad.Location = New System.Drawing.Point(12, 42)
        Me.LblVelocidad.Name = "LblVelocidad"
        Me.LblVelocidad.Size = New System.Drawing.Size(54, 13)
        Me.LblVelocidad.TabIndex = 22
        Me.LblVelocidad.Text = "Velocidad"
        '
        'TbVelocidad
        '
        Me.TbVelocidad.LargeChange = 1
        Me.TbVelocidad.Location = New System.Drawing.Point(72, 37)
        Me.TbVelocidad.Minimum = -10
        Me.TbVelocidad.Name = "TbVelocidad"
        Me.TbVelocidad.Size = New System.Drawing.Size(350, 45)
        Me.TbVelocidad.TabIndex = 17
        Me.TbVelocidad.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'CbVoz
        '
        Me.CbVoz.AllowDrop = True
        Me.CbVoz.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbVoz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbVoz.FormattingEnabled = True
        Me.CbVoz.Location = New System.Drawing.Point(459, 12)
        Me.CbVoz.Name = "CbVoz"
        Me.CbVoz.Size = New System.Drawing.Size(290, 21)
        Me.CbVoz.TabIndex = 20
        '
        'LblVoz
        '
        Me.LblVoz.AutoSize = True
        Me.LblVoz.Location = New System.Drawing.Point(428, 15)
        Me.LblVoz.Name = "LblVoz"
        Me.LblVoz.Size = New System.Drawing.Size(25, 13)
        Me.LblVoz.TabIndex = 19
        Me.LblVoz.Text = "Voz"
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Location = New System.Drawing.Point(12, 15)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(33, 13)
        Me.LblTitulo.TabIndex = 18
        Me.LblTitulo.Text = "Titulo"
        '
        'TxtTitulo
        '
        Me.TxtTitulo.Location = New System.Drawing.Point(51, 13)
        Me.TxtTitulo.Name = "TxtTitulo"
        Me.TxtTitulo.Size = New System.Drawing.Size(371, 20)
        Me.TxtTitulo.TabIndex = 16
        '
        'TxtTexto
        '
        Me.TxtTexto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTexto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTexto.Location = New System.Drawing.Point(-2, 85)
        Me.TxtTexto.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtTexto.Multiline = True
        Me.TxtTexto.Name = "TxtTexto"
        Me.TxtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtTexto.Size = New System.Drawing.Size(993, 342)
        Me.TxtTexto.TabIndex = 23
        '
        'TxtCall
        '
        Me.TxtCall.Location = New System.Drawing.Point(13, 62)
        Me.TxtCall.Name = "TxtCall"
        Me.TxtCall.Size = New System.Drawing.Size(409, 20)
        Me.TxtCall.TabIndex = 28
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 427)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(989, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 29
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.BackgroundImage = Global.StrongCrazyText3.My.Resources.Resources.save_icon
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(755, 12)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(70, 70)
        Me.BtnGuardar.TabIndex = 27
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnStop.BackgroundImage = Global.StrongCrazyText3.My.Resources.Resources._stop
        Me.BtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnStop.FlatAppearance.BorderSize = 0
        Me.BtnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStop.Location = New System.Drawing.Point(831, 12)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(70, 70)
        Me.BtnStop.TabIndex = 26
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BtnHablar
        '
        Me.BtnHablar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnHablar.BackgroundImage = Global.StrongCrazyText3.My.Resources.Resources.play
        Me.BtnHablar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnHablar.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnHablar.FlatAppearance.BorderSize = 0
        Me.BtnHablar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnHablar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnHablar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHablar.Location = New System.Drawing.Point(907, 12)
        Me.BtnHablar.Name = "BtnHablar"
        Me.BtnHablar.Size = New System.Drawing.Size(70, 70)
        Me.BtnHablar.TabIndex = 25
        Me.BtnHablar.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 450)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TxtCall)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnHablar)
        Me.Controls.Add(Me.LblVolumen)
        Me.Controls.Add(Me.TbVolumen)
        Me.Controls.Add(Me.TxtTexto)
        Me.Controls.Add(Me.LblVelocidad)
        Me.Controls.Add(Me.TbVelocidad)
        Me.Controls.Add(Me.CbVoz)
        Me.Controls.Add(Me.LblVoz)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.TxtTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPrincipal"
        Me.Text = "StrongCrazyText"
        CType(Me.TbVolumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbVelocidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnStop As Button
    Friend WithEvents BtnHablar As Button
    Friend WithEvents LblVolumen As Label
    Friend WithEvents TbVolumen As TrackBar
    Friend WithEvents LblVelocidad As Label
    Friend WithEvents TbVelocidad As TrackBar
    Friend WithEvents CbVoz As ComboBox
    Friend WithEvents LblVoz As Label
    Friend WithEvents LblTitulo As Label
    Friend WithEvents TxtTitulo As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents TxtTexto As TextBox
    Friend WithEvents TxtCall As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
