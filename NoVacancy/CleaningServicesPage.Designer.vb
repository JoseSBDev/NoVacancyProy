<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CleaningServicesPage
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_EditMaintenance = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBox_Description = New System.Windows.Forms.RichTextBox()
        Me.CB_State = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBox_Date = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBox_Room = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(400, 325)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(397, 299)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Fecha de limpieza"
        '
        'Btn_EditMaintenance
        '
        Me.Btn_EditMaintenance.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_EditMaintenance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_EditMaintenance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_EditMaintenance.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EditMaintenance.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_EditMaintenance.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_EditMaintenance.Location = New System.Drawing.Point(631, 352)
        Me.Btn_EditMaintenance.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_EditMaintenance.Name = "Btn_EditMaintenance"
        Me.Btn_EditMaintenance.Size = New System.Drawing.Size(263, 80)
        Me.Btn_EditMaintenance.TabIndex = 32
        Me.Btn_EditMaintenance.Text = "Editar registro"
        Me.Btn_EditMaintenance.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 384)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Descripción"
        '
        'TxtBox_Description
        '
        Me.TxtBox_Description.Location = New System.Drawing.Point(222, 410)
        Me.TxtBox_Description.Name = "TxtBox_Description"
        Me.TxtBox_Description.Size = New System.Drawing.Size(347, 96)
        Me.TxtBox_Description.TabIndex = 30
        Me.TxtBox_Description.Text = ""
        '
        'CB_State
        '
        Me.CB_State.FormattingEnabled = True
        Me.CB_State.Location = New System.Drawing.Point(222, 325)
        Me.CB_State.Name = "CB_State"
        Me.CB_State.Size = New System.Drawing.Size(129, 24)
        Me.CB_State.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(219, 303)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Estado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 384)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Fecha de entrada"
        '
        'TxtBox_Date
        '
        Me.TxtBox_Date.Enabled = False
        Me.TxtBox_Date.Location = New System.Drawing.Point(13, 410)
        Me.TxtBox_Date.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBox_Date.Name = "TxtBox_Date"
        Me.TxtBox_Date.Size = New System.Drawing.Size(132, 22)
        Me.TxtBox_Date.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 299)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Habitación"
        '
        'TxtBox_Room
        '
        Me.TxtBox_Room.Enabled = False
        Me.TxtBox_Room.Location = New System.Drawing.Point(13, 325)
        Me.TxtBox_Room.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBox_Room.Name = "TxtBox_Room"
        Me.TxtBox_Room.Size = New System.Drawing.Size(132, 22)
        Me.TxtBox_Room.TabIndex = 24
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 11)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(915, 273)
        Me.DataGridView1.TabIndex = 23
        '
        'CleaningServicesPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 517)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Btn_EditMaintenance)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtBox_Description)
        Me.Controls.Add(Me.CB_State)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBox_Date)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBox_Room)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "CleaningServicesPage"
        Me.Text = "CleaningServicesPage"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Btn_EditMaintenance As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBox_Description As RichTextBox
    Friend WithEvents CB_State As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBox_Date As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBox_Room As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
