<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewReservationPage
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtBox_Phone = New System.Windows.Forms.TextBox()
        Me.TxtBox_Mail = New System.Windows.Forms.TextBox()
        Me.TxtBox_Name = New System.Windows.Forms.TextBox()
        Me.ChkBox_NewClient = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_AcceptReservation = New System.Windows.Forms.Button()
        Me.Lbl_Price = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBox_Enddate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBox_Type = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBox_Startdate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBox_Room = New System.Windows.Forms.TextBox()
        Me.Pnl_SearchClient = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtBox_ClientName = New System.Windows.Forms.TextBox()
        Me.TxtBox_ClientPhone = New System.Windows.Forms.TextBox()
        Me.TxtBox_SearchClient = New System.Windows.Forms.TextBox()
        Me.Btn_CreateClient = New System.Windows.Forms.Button()
        Me.Btn_CheckClient = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Pnl_SearchClient.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn_CreateClient)
        Me.Panel1.Controls.Add(Me.TxtBox_Phone)
        Me.Panel1.Controls.Add(Me.TxtBox_Mail)
        Me.Panel1.Controls.Add(Me.TxtBox_Name)
        Me.Panel1.Controls.Add(Me.ChkBox_NewClient)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 213)
        Me.Panel1.TabIndex = 0
        '
        'TxtBox_Phone
        '
        Me.TxtBox_Phone.Enabled = False
        Me.TxtBox_Phone.Location = New System.Drawing.Point(14, 103)
        Me.TxtBox_Phone.Name = "TxtBox_Phone"
        Me.TxtBox_Phone.Size = New System.Drawing.Size(317, 20)
        Me.TxtBox_Phone.TabIndex = 2
        '
        'TxtBox_Mail
        '
        Me.TxtBox_Mail.Enabled = False
        Me.TxtBox_Mail.Location = New System.Drawing.Point(14, 129)
        Me.TxtBox_Mail.Name = "TxtBox_Mail"
        Me.TxtBox_Mail.Size = New System.Drawing.Size(317, 20)
        Me.TxtBox_Mail.TabIndex = 3
        '
        'TxtBox_Name
        '
        Me.TxtBox_Name.Enabled = False
        Me.TxtBox_Name.Location = New System.Drawing.Point(14, 77)
        Me.TxtBox_Name.Name = "TxtBox_Name"
        Me.TxtBox_Name.Size = New System.Drawing.Size(317, 20)
        Me.TxtBox_Name.TabIndex = 1
        '
        'ChkBox_NewClient
        '
        Me.ChkBox_NewClient.AutoSize = True
        Me.ChkBox_NewClient.Location = New System.Drawing.Point(14, 15)
        Me.ChkBox_NewClient.Name = "ChkBox_NewClient"
        Me.ChkBox_NewClient.Size = New System.Drawing.Size(134, 19)
        Me.ChkBox_NewClient.TabIndex = 0
        Me.ChkBox_NewClient.Text = "Crear nuevo cliente"
        Me.ChkBox_NewClient.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Btn_AcceptReservation)
        Me.Panel2.Controls.Add(Me.Lbl_Price)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxtBox_Enddate)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TxtBox_Type)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TxtBox_Startdate)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxtBox_Room)
        Me.Panel2.Location = New System.Drawing.Point(12, 231)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(761, 184)
        Me.Panel2.TabIndex = 1
        '
        'Btn_AcceptReservation
        '
        Me.Btn_AcceptReservation.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_AcceptReservation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_AcceptReservation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_AcceptReservation.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AcceptReservation.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_AcceptReservation.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_AcceptReservation.Location = New System.Drawing.Point(618, 139)
        Me.Btn_AcceptReservation.Name = "Btn_AcceptReservation"
        Me.Btn_AcceptReservation.Size = New System.Drawing.Size(140, 42)
        Me.Btn_AcceptReservation.TabIndex = 10
        Me.Btn_AcceptReservation.Text = "Reservar"
        Me.Btn_AcceptReservation.UseVisualStyleBackColor = False
        '
        'Lbl_Price
        '
        Me.Lbl_Price.AutoSize = True
        Me.Lbl_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Price.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_Price.Location = New System.Drawing.Point(501, 56)
        Me.Lbl_Price.Name = "Lbl_Price"
        Me.Lbl_Price.Size = New System.Drawing.Size(0, 51)
        Me.Lbl_Price.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(461, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha salida"
        '
        'TxtBox_Enddate
        '
        Me.TxtBox_Enddate.Enabled = False
        Me.TxtBox_Enddate.Location = New System.Drawing.Point(173, 125)
        Me.TxtBox_Enddate.Name = "TxtBox_Enddate"
        Me.TxtBox_Enddate.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Enddate.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tipo"
        '
        'TxtBox_Type
        '
        Me.TxtBox_Type.Enabled = False
        Me.TxtBox_Type.Location = New System.Drawing.Point(173, 56)
        Me.TxtBox_Type.Name = "TxtBox_Type"
        Me.TxtBox_Type.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Type.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha entrada"
        '
        'TxtBox_Startdate
        '
        Me.TxtBox_Startdate.Enabled = False
        Me.TxtBox_Startdate.Location = New System.Drawing.Point(14, 125)
        Me.TxtBox_Startdate.Name = "TxtBox_Startdate"
        Me.TxtBox_Startdate.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Startdate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Habitación"
        '
        'TxtBox_Room
        '
        Me.TxtBox_Room.Enabled = False
        Me.TxtBox_Room.Location = New System.Drawing.Point(14, 56)
        Me.TxtBox_Room.Name = "TxtBox_Room"
        Me.TxtBox_Room.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Room.TabIndex = 0
        '
        'Pnl_SearchClient
        '
        Me.Pnl_SearchClient.Controls.Add(Me.Btn_CheckClient)
        Me.Pnl_SearchClient.Controls.Add(Me.Label6)
        Me.Pnl_SearchClient.Controls.Add(Me.TxtBox_ClientName)
        Me.Pnl_SearchClient.Controls.Add(Me.TxtBox_ClientPhone)
        Me.Pnl_SearchClient.Controls.Add(Me.TxtBox_SearchClient)
        Me.Pnl_SearchClient.Location = New System.Drawing.Point(369, 12)
        Me.Pnl_SearchClient.Name = "Pnl_SearchClient"
        Me.Pnl_SearchClient.Size = New System.Drawing.Size(346, 213)
        Me.Pnl_SearchClient.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 45)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Buscar cliente existente. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Introduce email cliente:"
        '
        'TxtBox_ClientName
        '
        Me.TxtBox_ClientName.Enabled = False
        Me.TxtBox_ClientName.Location = New System.Drawing.Point(14, 103)
        Me.TxtBox_ClientName.Name = "TxtBox_ClientName"
        Me.TxtBox_ClientName.Size = New System.Drawing.Size(317, 20)
        Me.TxtBox_ClientName.TabIndex = 2
        '
        'TxtBox_ClientPhone
        '
        Me.TxtBox_ClientPhone.Enabled = False
        Me.TxtBox_ClientPhone.Location = New System.Drawing.Point(14, 129)
        Me.TxtBox_ClientPhone.Name = "TxtBox_ClientPhone"
        Me.TxtBox_ClientPhone.Size = New System.Drawing.Size(317, 20)
        Me.TxtBox_ClientPhone.TabIndex = 3
        '
        'TxtBox_SearchClient
        '
        Me.TxtBox_SearchClient.Location = New System.Drawing.Point(14, 77)
        Me.TxtBox_SearchClient.Name = "TxtBox_SearchClient"
        Me.TxtBox_SearchClient.Size = New System.Drawing.Size(317, 20)
        Me.TxtBox_SearchClient.TabIndex = 1
        '
        'Btn_CreateClient
        '
        Me.Btn_CreateClient.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_CreateClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_CreateClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_CreateClient.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CreateClient.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_CreateClient.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_CreateClient.Location = New System.Drawing.Point(208, 168)
        Me.Btn_CreateClient.Name = "Btn_CreateClient"
        Me.Btn_CreateClient.Size = New System.Drawing.Size(140, 42)
        Me.Btn_CreateClient.TabIndex = 4
        Me.Btn_CreateClient.Text = "Crear cliente"
        Me.Btn_CreateClient.UseVisualStyleBackColor = False
        '
        'Btn_CheckClient
        '
        Me.Btn_CheckClient.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_CheckClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_CheckClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_CheckClient.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CheckClient.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_CheckClient.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_CheckClient.Location = New System.Drawing.Point(203, 168)
        Me.Btn_CheckClient.Name = "Btn_CheckClient"
        Me.Btn_CheckClient.Size = New System.Drawing.Size(140, 42)
        Me.Btn_CheckClient.TabIndex = 4
        Me.Btn_CheckClient.Text = "Buscar cliente"
        Me.Btn_CheckClient.UseVisualStyleBackColor = False
        '
        'NewReservationPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Pnl_SearchClient)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NewReservationPage"
        Me.Text = "NewReservationPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Pnl_SearchClient.ResumeLayout(False)
        Me.Pnl_SearchClient.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtBox_Phone As TextBox
    Friend WithEvents TxtBox_Mail As TextBox
    Friend WithEvents TxtBox_Name As TextBox
    Friend WithEvents ChkBox_NewClient As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Lbl_Price As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBox_Enddate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBox_Type As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBox_Startdate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBox_Room As TextBox
    Friend WithEvents Pnl_SearchClient As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtBox_ClientName As TextBox
    Friend WithEvents TxtBox_ClientPhone As TextBox
    Friend WithEvents TxtBox_SearchClient As TextBox
    Friend WithEvents Btn_AcceptReservation As Button
    Friend WithEvents Btn_CreateClient As Button
    Friend WithEvents Btn_CheckClient As Button
End Class
