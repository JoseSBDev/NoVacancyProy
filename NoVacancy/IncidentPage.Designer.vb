<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncidentPage
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
        Me.RTB_Description = New System.Windows.Forms.RichTextBox()
        Me.CB_Type = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_Room = New System.Windows.Forms.ComboBox()
        Me.Btn_CreateIncident = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RTB_Description
        '
        Me.RTB_Description.Location = New System.Drawing.Point(28, 207)
        Me.RTB_Description.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RTB_Description.Name = "RTB_Description"
        Me.RTB_Description.Size = New System.Drawing.Size(484, 146)
        Me.RTB_Description.TabIndex = 0
        Me.RTB_Description.Text = ""
        '
        'CB_Type
        '
        Me.CB_Type.FormattingEnabled = True
        Me.CB_Type.Location = New System.Drawing.Point(255, 30)
        Me.CB_Type.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_Type.Name = "CB_Type"
        Me.CB_Type.Size = New System.Drawing.Size(121, 24)
        Me.CB_Type.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label1.Location = New System.Drawing.Point(15, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo de incidencia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label2.Location = New System.Drawing.Point(28, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label3.Location = New System.Drawing.Point(28, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Observaciones"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label4.Location = New System.Drawing.Point(15, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Num. Habitacion"
        '
        'CB_Room
        '
        Me.CB_Room.FormattingEnabled = True
        Me.CB_Room.Location = New System.Drawing.Point(255, 96)
        Me.CB_Room.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_Room.Name = "CB_Room"
        Me.CB_Room.Size = New System.Drawing.Size(121, 24)
        Me.CB_Room.TabIndex = 6
        '
        'Btn_CreateIncident
        '
        Me.Btn_CreateIncident.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_CreateIncident.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_CreateIncident.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_CreateIncident.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CreateIncident.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_CreateIncident.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Btn_CreateIncident.Location = New System.Drawing.Point(143, 400)
        Me.Btn_CreateIncident.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_CreateIncident.Name = "Btn_CreateIncident"
        Me.Btn_CreateIncident.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_CreateIncident.Size = New System.Drawing.Size(237, 103)
        Me.Btn_CreateIncident.TabIndex = 16
        Me.Btn_CreateIncident.Text = "Crear incidencia"
        Me.Btn_CreateIncident.UseVisualStyleBackColor = False
        '
        'IncidentPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(541, 551)
        Me.Controls.Add(Me.Btn_CreateIncident)
        Me.Controls.Add(Me.CB_Room)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_Type)
        Me.Controls.Add(Me.RTB_Description)
        Me.ForeColor = System.Drawing.SystemColors.Window
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IncidentPage"
        Me.Text = "Crear incidencia"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RTB_Description As RichTextBox
    Friend WithEvents CB_Type As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CB_Room As ComboBox
    Friend WithEvents Btn_CreateIncident As Button
End Class
