<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoomsPage
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
        Me.DataGridViewRooms = New System.Windows.Forms.DataGridView()
        Me.ComboBoxRoomStat = New System.Windows.Forms.ComboBox()
        Me.TextBoxRoomNumber = New System.Windows.Forms.TextBox()
        Me.ComboBoxRoomType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_UpdateRooms = New System.Windows.Forms.Button()
        CType(Me.DataGridViewRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewRooms
        '
        Me.DataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRooms.Location = New System.Drawing.Point(348, 194)
        Me.DataGridViewRooms.Name = "DataGridViewRooms"
        Me.DataGridViewRooms.RowHeadersWidth = 51
        Me.DataGridViewRooms.RowTemplate.Height = 24
        Me.DataGridViewRooms.Size = New System.Drawing.Size(656, 422)
        Me.DataGridViewRooms.TabIndex = 0
        '
        'ComboBoxRoomStat
        '
        Me.ComboBoxRoomStat.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ComboBoxRoomStat.FormattingEnabled = True
        Me.ComboBoxRoomStat.Location = New System.Drawing.Point(745, 59)
        Me.ComboBoxRoomStat.Name = "ComboBoxRoomStat"
        Me.ComboBoxRoomStat.Size = New System.Drawing.Size(218, 24)
        Me.ComboBoxRoomStat.TabIndex = 1
        '
        'TextBoxRoomNumber
        '
        Me.TextBoxRoomNumber.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxRoomNumber.Location = New System.Drawing.Point(263, 59)
        Me.TextBoxRoomNumber.Name = "TextBoxRoomNumber"
        Me.TextBoxRoomNumber.Size = New System.Drawing.Size(47, 22)
        Me.TextBoxRoomNumber.TabIndex = 2
        '
        'ComboBoxRoomType
        '
        Me.ComboBoxRoomType.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ComboBoxRoomType.FormattingEnabled = True
        Me.ComboBoxRoomType.Location = New System.Drawing.Point(402, 57)
        Me.ComboBoxRoomType.Name = "ComboBoxRoomType"
        Me.ComboBoxRoomType.Size = New System.Drawing.Size(218, 24)
        Me.ComboBoxRoomType.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Num. Habitacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(665, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Estado"
        '
        'Btn_UpdateRooms
        '
        Me.Btn_UpdateRooms.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_UpdateRooms.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_UpdateRooms.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_UpdateRooms.Enabled = False
        Me.Btn_UpdateRooms.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_UpdateRooms.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_UpdateRooms.Location = New System.Drawing.Point(60, 551)
        Me.Btn_UpdateRooms.Name = "Btn_UpdateRooms"
        Me.Btn_UpdateRooms.Size = New System.Drawing.Size(197, 65)
        Me.Btn_UpdateRooms.TabIndex = 7
        Me.Btn_UpdateRooms.Text = "Actualizar"
        Me.Btn_UpdateRooms.UseVisualStyleBackColor = False
        '
        'RoomsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1016, 628)
        Me.Controls.Add(Me.Btn_UpdateRooms)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxRoomType)
        Me.Controls.Add(Me.TextBoxRoomNumber)
        Me.Controls.Add(Me.ComboBoxRoomStat)
        Me.Controls.Add(Me.DataGridViewRooms)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RoomsPage"
        Me.Text = "RoomsPage"
        Me.TopMost = True
        CType(Me.DataGridViewRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewRooms As DataGridView
    Friend WithEvents ComboBoxRoomStat As ComboBox
    Friend WithEvents TextBoxRoomNumber As TextBox
    Friend WithEvents ComboBoxRoomType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_UpdateRooms As Button
End Class
