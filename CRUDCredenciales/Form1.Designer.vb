<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelCarrera = New System.Windows.Forms.Label()
        Me.LabelControl = New System.Windows.Forms.Label()
        Me.LabelNSS = New System.Windows.Forms.Label()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TextControl = New System.Windows.Forms.TextBox()
        Me.TextNSS = New System.Windows.Forms.TextBox()
        Me.ButtonCrear = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonLeer = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBoxCarrera = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.BackColor = System.Drawing.Color.Chocolate
        Me.LabelNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNombre.Location = New System.Drawing.Point(24, 96)
        Me.LabelNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(92, 24)
        Me.LabelNombre.TabIndex = 0
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelCarrera
        '
        Me.LabelCarrera.AutoSize = True
        Me.LabelCarrera.BackColor = System.Drawing.Color.Chocolate
        Me.LabelCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelCarrera.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelCarrera.Location = New System.Drawing.Point(24, 166)
        Me.LabelCarrera.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCarrera.Name = "LabelCarrera"
        Me.LabelCarrera.Size = New System.Drawing.Size(89, 24)
        Me.LabelCarrera.TabIndex = 1
        Me.LabelCarrera.Text = "Carrera"
        '
        'LabelControl
        '
        Me.LabelControl.AutoSize = True
        Me.LabelControl.BackColor = System.Drawing.Color.Chocolate
        Me.LabelControl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelControl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelControl.Location = New System.Drawing.Point(6, 242)
        Me.LabelControl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelControl.Name = "LabelControl"
        Me.LabelControl.Size = New System.Drawing.Size(128, 24)
        Me.LabelControl.TabIndex = 2
        Me.LabelControl.Text = "No. Control"
        '
        'LabelNSS
        '
        Me.LabelNSS.AutoSize = True
        Me.LabelNSS.BackColor = System.Drawing.Color.Chocolate
        Me.LabelNSS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelNSS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNSS.Location = New System.Drawing.Point(41, 312)
        Me.LabelNSS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNSS.Name = "LabelNSS"
        Me.LabelNSS.Size = New System.Drawing.Size(54, 24)
        Me.LabelNSS.TabIndex = 3
        Me.LabelNSS.Text = "NSS"
        '
        'TextNombre
        '
        Me.TextNombre.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextNombre.Location = New System.Drawing.Point(18, 123)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(100, 23)
        Me.TextNombre.TabIndex = 4
        '
        'TextControl
        '
        Me.TextControl.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextControl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextControl.Location = New System.Drawing.Point(18, 269)
        Me.TextControl.Name = "TextControl"
        Me.TextControl.Size = New System.Drawing.Size(100, 26)
        Me.TextControl.TabIndex = 6
        '
        'TextNSS
        '
        Me.TextNSS.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextNSS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextNSS.Location = New System.Drawing.Point(18, 339)
        Me.TextNSS.Name = "TextNSS"
        Me.TextNSS.Size = New System.Drawing.Size(100, 25)
        Me.TextNSS.TabIndex = 7
        '
        'ButtonCrear
        '
        Me.ButtonCrear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCrear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonCrear.ForeColor = System.Drawing.Color.Chocolate
        Me.ButtonCrear.Location = New System.Drawing.Point(205, 447)
        Me.ButtonCrear.Name = "ButtonCrear"
        Me.ButtonCrear.Size = New System.Drawing.Size(89, 29)
        Me.ButtonCrear.TabIndex = 8
        Me.ButtonCrear.Text = "Crear"
        Me.ButtonCrear.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEliminar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonEliminar.ForeColor = System.Drawing.Color.Chocolate
        Me.ButtonEliminar.Location = New System.Drawing.Point(565, 447)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(84, 29)
        Me.ButtonEliminar.TabIndex = 9
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonActualizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonActualizar.ForeColor = System.Drawing.Color.Chocolate
        Me.ButtonActualizar.Location = New System.Drawing.Point(439, 447)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(93, 29)
        Me.ButtonActualizar.TabIndex = 10
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = False
        '
        'ButtonLeer
        '
        Me.ButtonLeer.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonLeer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonLeer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonLeer.ForeColor = System.Drawing.Color.Chocolate
        Me.ButtonLeer.Location = New System.Drawing.Point(331, 447)
        Me.ButtonLeer.Name = "ButtonLeer"
        Me.ButtonLeer.Size = New System.Drawing.Size(76, 29)
        Me.ButtonLeer.TabIndex = 11
        Me.ButtonLeer.Text = "Leer"
        Me.ButtonLeer.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(205, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(444, 269)
        Me.DataGridView1.TabIndex = 12
        '
        'ComboBoxCarrera
        '
        Me.ComboBoxCarrera.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxCarrera.FormattingEnabled = True
        Me.ComboBoxCarrera.Items.AddRange(New Object() {"Industrial", "Industrias Alimentarias", "Desarrollo Comunitario", "Informática", "Energías Renovables", "Civil"})
        Me.ComboBoxCarrera.Location = New System.Drawing.Point(6, 193)
        Me.ComboBoxCarrera.Name = "ComboBoxCarrera"
        Me.ComboBoxCarrera.Size = New System.Drawing.Size(128, 20)
        Me.ComboBoxCarrera.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(730, 497)
        Me.Controls.Add(Me.ComboBoxCarrera)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonLeer)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonCrear)
        Me.Controls.Add(Me.TextNSS)
        Me.Controls.Add(Me.TextControl)
        Me.Controls.Add(Me.TextNombre)
        Me.Controls.Add(Me.LabelNSS)
        Me.Controls.Add(Me.LabelControl)
        Me.Controls.Add(Me.LabelCarrera)
        Me.Controls.Add(Me.LabelNombre)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credencial Universitaria"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelCarrera As Label
    Friend WithEvents LabelNSS As Label
    Private WithEvents LabelControl As Label
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TextControl As TextBox
    Friend WithEvents TextNSS As TextBox
    Friend WithEvents ButtonCrear As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents ButtonLeer As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBoxCarrera As ComboBox
End Class
