<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfigPage
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigPage))
        Me.ListBox_Users = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_NewUser = New System.Windows.Forms.Button()
        Me.Pnl_NewRole = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBox_Email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckedListBox_Roles = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBox_Password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBox_Name = New System.Windows.Forms.TextBox()
        Me.Btn_EditUser = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PB_DayMode = New System.Windows.Forms.PictureBox()
        Me.PB_NightMode = New System.Windows.Forms.PictureBox()
        Me.Pnl_NewRole.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_DayMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_NightMode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox_Users
        '
        Me.ListBox_Users.FormattingEnabled = True
        Me.ListBox_Users.ItemHeight = 16
        Me.ListBox_Users.Location = New System.Drawing.Point(57, 72)
        Me.ListBox_Users.Name = "ListBox_Users"
        Me.ListBox_Users.Size = New System.Drawing.Size(237, 164)
        Me.ListBox_Users.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuarios disponibles"
        '
        'Btn_NewUser
        '
        Me.Btn_NewUser.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_NewUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_NewUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_NewUser.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_NewUser.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_NewUser.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Btn_NewUser.Location = New System.Drawing.Point(322, 72)
        Me.Btn_NewUser.Name = "Btn_NewUser"
        Me.Btn_NewUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_NewUser.Size = New System.Drawing.Size(237, 65)
        Me.Btn_NewUser.TabIndex = 10
        Me.Btn_NewUser.Text = "Crear nuevo usuario"
        Me.Btn_NewUser.UseVisualStyleBackColor = False
        '
        'Pnl_NewRole
        '
        Me.Pnl_NewRole.Controls.Add(Me.Label5)
        Me.Pnl_NewRole.Controls.Add(Me.TxtBox_Email)
        Me.Pnl_NewRole.Controls.Add(Me.Label4)
        Me.Pnl_NewRole.Controls.Add(Me.CheckedListBox_Roles)
        Me.Pnl_NewRole.Controls.Add(Me.Label3)
        Me.Pnl_NewRole.Controls.Add(Me.TxtBox_Password)
        Me.Pnl_NewRole.Controls.Add(Me.Label2)
        Me.Pnl_NewRole.Controls.Add(Me.TxtBox_Name)
        Me.Pnl_NewRole.Location = New System.Drawing.Point(57, 268)
        Me.Pnl_NewRole.Name = "Pnl_NewRole"
        Me.Pnl_NewRole.Size = New System.Drawing.Size(237, 375)
        Me.Pnl_NewRole.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Email de usuario"
        '
        'TxtBox_Email
        '
        Me.TxtBox_Email.Location = New System.Drawing.Point(26, 161)
        Me.TxtBox_Email.Name = "TxtBox_Email"
        Me.TxtBox_Email.Size = New System.Drawing.Size(183, 22)
        Me.TxtBox_Email.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Pertenencia a rol de permisos"
        '
        'CheckedListBox_Roles
        '
        Me.CheckedListBox_Roles.CheckOnClick = True
        Me.CheckedListBox_Roles.FormattingEnabled = True
        Me.CheckedListBox_Roles.Items.AddRange(New Object() {"Administrador", "Gerencia", "Recepcion", "Mantenimiento", "Limpieza"})
        Me.CheckedListBox_Roles.Location = New System.Drawing.Point(26, 219)
        Me.CheckedListBox_Roles.MultiColumn = True
        Me.CheckedListBox_Roles.Name = "CheckedListBox_Roles"
        Me.CheckedListBox_Roles.Size = New System.Drawing.Size(183, 140)
        Me.CheckedListBox_Roles.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Contraseña de usuario"
        '
        'TxtBox_Password
        '
        Me.TxtBox_Password.Location = New System.Drawing.Point(26, 93)
        Me.TxtBox_Password.Name = "TxtBox_Password"
        Me.TxtBox_Password.Size = New System.Drawing.Size(183, 22)
        Me.TxtBox_Password.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre de usuario"
        '
        'TxtBox_Name
        '
        Me.TxtBox_Name.Location = New System.Drawing.Point(26, 28)
        Me.TxtBox_Name.Name = "TxtBox_Name"
        Me.TxtBox_Name.Size = New System.Drawing.Size(183, 22)
        Me.TxtBox_Name.TabIndex = 0
        '
        'Btn_EditUser
        '
        Me.Btn_EditUser.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_EditUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_EditUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_EditUser.Enabled = False
        Me.Btn_EditUser.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EditUser.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_EditUser.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Btn_EditUser.Location = New System.Drawing.Point(322, 171)
        Me.Btn_EditUser.Name = "Btn_EditUser"
        Me.Btn_EditUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_EditUser.Size = New System.Drawing.Size(237, 65)
        Me.Btn_EditUser.TabIndex = 12
        Me.Btn_EditUser.Text = "Editar usuario"
        Me.Btn_EditUser.UseVisualStyleBackColor = False
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(597, 72)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(527, 437)
        Me.Chart1.TabIndex = 13
        Me.Chart1.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "VENTAS 2024"
        Me.Chart1.Titles.Add(Title1)
        '
        'PB_DayMode
        '
        Me.PB_DayMode.Image = CType(resources.GetObject("PB_DayMode.Image"), System.Drawing.Image)
        Me.PB_DayMode.Location = New System.Drawing.Point(964, 645)
        Me.PB_DayMode.Name = "PB_DayMode"
        Me.PB_DayMode.Size = New System.Drawing.Size(160, 81)
        Me.PB_DayMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_DayMode.TabIndex = 14
        Me.PB_DayMode.TabStop = False
        '
        'PB_NightMode
        '
        Me.PB_NightMode.Image = CType(resources.GetObject("PB_NightMode.Image"), System.Drawing.Image)
        Me.PB_NightMode.Location = New System.Drawing.Point(964, 645)
        Me.PB_NightMode.Name = "PB_NightMode"
        Me.PB_NightMode.Size = New System.Drawing.Size(160, 81)
        Me.PB_NightMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_NightMode.TabIndex = 15
        Me.PB_NightMode.TabStop = False
        '
        'ConfigPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1136, 738)
        Me.Controls.Add(Me.PB_NightMode)
        Me.Controls.Add(Me.PB_DayMode)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Btn_EditUser)
        Me.Controls.Add(Me.Pnl_NewRole)
        Me.Controls.Add(Me.Btn_NewUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox_Users)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfigPage"
        Me.Text = "Panel de configuración "
        Me.TopMost = True
        Me.Pnl_NewRole.ResumeLayout(False)
        Me.Pnl_NewRole.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_DayMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_NightMode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox_Users As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_NewUser As Button
    Friend WithEvents Pnl_NewRole As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBox_Name As TextBox
    Friend WithEvents Btn_EditUser As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBox_Password As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckedListBox_Roles As CheckedListBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents PB_DayMode As PictureBox
    Friend WithEvents PB_NightMode As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBox_Email As TextBox
End Class
