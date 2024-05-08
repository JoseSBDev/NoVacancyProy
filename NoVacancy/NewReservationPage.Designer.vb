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
        Me.Btn_CreateClient = New System.Windows.Forms.Button()
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
        Me.Btn_CheckClient = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtBox_ClientName = New System.Windows.Forms.TextBox()
        Me.TxtBox_ClientPhone = New System.Windows.Forms.TextBox()
        Me.TxtBox_SearchClient = New System.Windows.Forms.TextBox()
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
        Me.Panel1.Location = New System.Drawing.Point(16, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 262)
        Me.Panel1.TabIndex = 0
        '
        'Btn_CreateClient
        '
        Me.Btn_CreateClient.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_CreateClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_CreateClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_CreateClient.Enabled = False
        Me.Btn_CreateClient.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CreateClient.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_CreateClient.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_CreateClient.Location = New System.Drawing.Point(277, 207)
        Me.Btn_CreateClient.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_CreateClient.Name = "Btn_CreateClient"
        Me.Btn_CreateClient.Size = New System.Drawing.Size(187, 52)
        Me.Btn_CreateClient.TabIndex = 4
        Me.Btn_CreateClient.Text = "Crear cliente"
        Me.Btn_CreateClient.UseVisualStyleBackColor = False
        '
        'TxtBox_Phone
        '
        Me.TxtBox_Phone.Enabled = False
        Me.TxtBox_Phone.Location = New System.Drawing.Point(19, 127)
        Me.TxtBox_Phone.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBox_Phone.Name = "TxtBox_Phone"
        Me.TxtBox_Phone.Size = New System.Drawing.Size(421, 22)
        Me.TxtBox_Phone.TabIndex = 2
        '
        'TxtBox_Mail
        '
        Me.TxtBox_Mail.Enabled = False
        Me.TxtBox_Mail.Location = New System.Drawing.Point(19, 159)
        Me.TxtBox_Mail.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBox_Mail.Name = "TxtBox_Mail"
        Me.TxtBox_Mail.Size = New System.Drawing.Size(421, 22)
        Me.TxtBox_Mail.TabIndex = 3
        '
        'TxtBox_Name
        '
        Me.TxtBox_Name.Enabled = False
        Me.TxtBox_Name.Location = New System.Drawing.Point(19, 95)
        Me.TxtBox_Name.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBox_Name.Name = "TxtBox_Name"
        Me.TxtBox_Name.Size = New System.Drawing.Size(421, 22)
        Me.TxtBox_Name.TabIndex = 1
        '
        'ChkBox_NewClient
        '
        Me.ChkBox_NewClient.AutoSize = True
        Me.ChkBox_NewClient.Location = New System.Drawing.Point(19, 18)
        Me.ChkBox_NewClient.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkBox_NewClient.Name = "ChkBox_NewClient"
        Me.ChkBox_NewClient.Size = New System.Drawing.Size(153, 21)
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
        Me.Panel2.Location = New System.Drawing.Point(16, 284)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1015, 226)
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
        Me.Btn_AcceptReservation.Location = New System.Drawing.Point(824, 171)
        Me.Btn_AcceptReservation.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_AcceptReservation.Name = "Btn_AcceptReservation"
        Me.Btn_AcceptReservation.Size = New System.Drawing.Size(187, 52)
        Me.Btn_AcceptReservation.TabIndex = 10
        Me.Btn_AcceptReservation.Text = "Reservar"
        Me.Btn_AcceptReservation.UseVisualStyleBackColor = False
        '
        'Lbl_Price
        '
        Me.Lbl_Price.AutoSize = True
        Me.Lbl_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Price.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_Price.Location = New System.Drawing.Point(668, 69)
        Me.Lbl_Price.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Price.Name = "Lbl_Price"
        Me.Lbl_Price.Size = New System.Drawing.Size(0, 51)
        Me.Lbl_Price.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(615, 42)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 128)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha salida"
        '
        'TxtBox_Enddate
        '
        Me.TxtBox_Enddate.Enabled = False
        Me.TxtBox_Enddate.Location = New System.Drawing.Point(231, 154)
        Me.TxtBox_Enddate.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBox_Enddate.Name = "TxtBox_Enddate"
        Me.TxtBox_Enddate.Size = New System.Drawing.Size(132, 22)
        Me.TxtBox_Enddate.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tipo"
        '
        'TxtBox_Type
        '
        Me.TxtBox_Type.Enabled = False
        Me.TxtBox_Type.Location = New System.Drawing.Point(231, 69)
        Me.TxtBox_Type.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBox_Type.Name = "TxtBox_Type"
        Me.TxtBox_Type.Size = New System.Drawing.Size(132, 22)
        Me.TxtBox_Type.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha entrada"
        '
        'TxtBox_Startdate
        '
        Me.TxtBox_Startdate.Enabled = False
        Me.TxtBox_Startdate.Location = New System.Drawing.Point(19, 154)
        Me.TxtBox_Startdate.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBox_Startdate.Name = "TxtBox_Startdate"
        Me.TxtBox_Startdate.Size = New System.Drawing.Size(132, 22)
        Me.TxtBox_Startdate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Habitación"
        '
        'TxtBox_Room
        '
        Me.TxtBox_Room.Enabled = False
        Me.TxtBox_Room.Location = New System.Drawing.Point(19, 69)
        Me.TxtBox_Room.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBox_Room.Name = "TxtBox_Room"
        Me.TxtBox_Room.Size = New System.Drawing.Size(132, 22)
        Me.TxtBox_Room.TabIndex = 0
        '
        'Pnl_SearchClient
        '
        Me.Pnl_SearchClient.Controls.Add(Me.Btn_CheckClient)
        Me.Pnl_SearchClient.Controls.Add(Me.Label6)
        Me.Pnl_SearchClient.Controls.Add(Me.TxtBox_ClientName)
        Me.Pnl_SearchClient.Controls.Add(Me.TxtBox_ClientPhone)
        Me.Pnl_SearchClient.Controls.Add(Me.TxtBox_SearchClient)
        Me.Pnl_SearchClient.Location = New System.Drawing.Point(492, 15)
        Me.Pnl_SearchClient.Margin = New System.Windows.Forms.Padding(4)
        Me.Pnl_SearchClient.Name = "Pnl_SearchClient"
        Me.Pnl_SearchClient.Size = New System.Drawing.Size(461, 262)
        Me.Pnl_SearchClient.TabIndex = 4
        '
        'Btn_CheckClient
        '
        Me.Btn_CheckClient.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_CheckClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_CheckClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_CheckClient.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CheckClient.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_CheckClient.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_CheckClient.Location = New System.Drawing.Point(271, 207)
        Me.Btn_CheckClient.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_CheckClient.Name = "Btn_CheckClient"
        Me.Btn_CheckClient.Size = New System.Drawing.Size(187, 52)
        Me.Btn_CheckClient.TabIndex = 4
        Me.Btn_CheckClient.Text = "Buscar cliente"
        Me.Btn_CheckClient.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 21)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 51)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Buscar cliente existente. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Introduce email cliente:"
        '
        'TxtBox_ClientName
        '
        Me.TxtBox_ClientName.Enabled = False
        Me.TxtBox_ClientName.Location = New System.Drawing.Point(19, 127)
        Me.TxtBox_ClientName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBox_ClientName.Name = "TxtBox_ClientName"
        Me.TxtBox_ClientName.Size = New System.Drawing.Size(421, 22)
        Me.TxtBox_ClientName.TabIndex = 2
        '
        'TxtBox_ClientPhone
        '
        Me.TxtBox_ClientPhone.Enabled = False
        Me.TxtBox_ClientPhone.Location = New System.Drawing.Point(19, 159)
        Me.TxtBox_ClientPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBox_ClientPhone.Name = "TxtBox_ClientPhone"
        Me.TxtBox_ClientPhone.Size = New System.Drawing.Size(421, 22)
        Me.TxtBox_ClientPhone.TabIndex = 3
        '
        'TxtBox_SearchClient
        '
        Me.TxtBox_SearchClient.Location = New System.Drawing.Point(19, 95)
        Me.TxtBox_SearchClient.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBox_SearchClient.Name = "TxtBox_SearchClient"
        Me.TxtBox_SearchClient.Size = New System.Drawing.Size(421, 22)
        Me.TxtBox_SearchClient.TabIndex = 1
        '
        'NewReservationPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Pnl_SearchClient)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewReservationPage"
        Me.Text = "Nueva reserva"
        Me.TopMost = True
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
