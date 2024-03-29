<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.Btn_Reservations = New System.Windows.Forms.Button()
        Me.Btn_Rooms = New System.Windows.Forms.Button()
        Me.Btn_Inventory = New System.Windows.Forms.Button()
        Me.Btn_Config = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_exit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Reservations
        '
        Me.Btn_Reservations.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_Reservations.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Reservations.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_Reservations.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Reservations.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_Reservations.Location = New System.Drawing.Point(12, 377)
        Me.Btn_Reservations.Name = "Btn_Reservations"
        Me.Btn_Reservations.Size = New System.Drawing.Size(197, 65)
        Me.Btn_Reservations.TabIndex = 0
        Me.Btn_Reservations.Text = "Reservas"
        Me.Btn_Reservations.UseVisualStyleBackColor = False
        '
        'Btn_Rooms
        '
        Me.Btn_Rooms.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_Rooms.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Rooms.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_Rooms.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Rooms.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_Rooms.Location = New System.Drawing.Point(12, 472)
        Me.Btn_Rooms.Name = "Btn_Rooms"
        Me.Btn_Rooms.Size = New System.Drawing.Size(197, 65)
        Me.Btn_Rooms.TabIndex = 5
        Me.Btn_Rooms.Text = "Habitaciones"
        Me.Btn_Rooms.UseVisualStyleBackColor = False
        '
        'Btn_Inventory
        '
        Me.Btn_Inventory.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_Inventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Inventory.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_Inventory.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Inventory.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_Inventory.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_Inventory.Location = New System.Drawing.Point(12, 570)
        Me.Btn_Inventory.Name = "Btn_Inventory"
        Me.Btn_Inventory.Size = New System.Drawing.Size(197, 65)
        Me.Btn_Inventory.TabIndex = 6
        Me.Btn_Inventory.Text = "Inventario"
        Me.Btn_Inventory.UseVisualStyleBackColor = False
        '
        'Btn_Config
        '
        Me.Btn_Config.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_Config.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Config.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_Config.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Config.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_Config.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Btn_Config.Location = New System.Drawing.Point(844, 472)
        Me.Btn_Config.Name = "Btn_Config"
        Me.Btn_Config.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Config.Size = New System.Drawing.Size(237, 65)
        Me.Btn_Config.TabIndex = 7
        Me.Btn_Config.Text = "Configuración"
        Me.Btn_Config.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.NoVacancy.My.Resources.Resources.Black_Gold_Simple_Modern_Villa___Homestay_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(319, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 500)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Btn_exit
        '
        Me.Btn_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_exit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_exit.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_exit.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_exit.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Btn_exit.Location = New System.Drawing.Point(844, 575)
        Me.Btn_exit.Name = "Btn_exit"
        Me.Btn_exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_exit.Size = New System.Drawing.Size(237, 65)
        Me.Btn_exit.TabIndex = 9
        Me.Btn_exit.Text = "Salir"
        Me.Btn_exit.UseVisualStyleBackColor = False
        '
        'MainPage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1093, 652)
        Me.Controls.Add(Me.Btn_exit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Config)
        Me.Controls.Add(Me.Btn_Inventory)
        Me.Controls.Add(Me.Btn_Rooms)
        Me.Controls.Add(Me.Btn_Reservations)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Reservations As Button
    Friend WithEvents Btn_Rooms As Button
    Friend WithEvents Btn_Inventory As Button
    Friend WithEvents Btn_Config As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_exit As Button
End Class
