<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditReservationForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBox_Enddate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBox_Type = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBox_Startdate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBox_Room = New System.Windows.Forms.TextBox()
        Me.Btn_EditReservation = New System.Windows.Forms.Button()
        Me.Btn_DeleteReservation = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(576, 82)
        Me.DataGridView1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(171, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Fecha salida"
        '
        'TxtBox_Enddate
        '
        Me.TxtBox_Enddate.Location = New System.Drawing.Point(171, 231)
        Me.TxtBox_Enddate.Name = "TxtBox_Enddate"
        Me.TxtBox_Enddate.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Enddate.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tipo"
        '
        'TxtBox_Type
        '
        Me.TxtBox_Type.Enabled = False
        Me.TxtBox_Type.Location = New System.Drawing.Point(171, 162)
        Me.TxtBox_Type.Name = "TxtBox_Type"
        Me.TxtBox_Type.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Type.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha entrada"
        '
        'TxtBox_Startdate
        '
        Me.TxtBox_Startdate.Location = New System.Drawing.Point(12, 231)
        Me.TxtBox_Startdate.Name = "TxtBox_Startdate"
        Me.TxtBox_Startdate.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Startdate.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Habitación"
        '
        'TxtBox_Room
        '
        Me.TxtBox_Room.Enabled = False
        Me.TxtBox_Room.Location = New System.Drawing.Point(12, 162)
        Me.TxtBox_Room.Name = "TxtBox_Room"
        Me.TxtBox_Room.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Room.TabIndex = 8
        '
        'Btn_EditReservation
        '
        Me.Btn_EditReservation.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_EditReservation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_EditReservation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_EditReservation.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EditReservation.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_EditReservation.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_EditReservation.Location = New System.Drawing.Point(12, 410)
        Me.Btn_EditReservation.Name = "Btn_EditReservation"
        Me.Btn_EditReservation.Size = New System.Drawing.Size(197, 65)
        Me.Btn_EditReservation.TabIndex = 16
        Me.Btn_EditReservation.Text = "Editar reserva"
        Me.Btn_EditReservation.UseVisualStyleBackColor = False
        '
        'Btn_DeleteReservation
        '
        Me.Btn_DeleteReservation.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_DeleteReservation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_DeleteReservation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_DeleteReservation.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_DeleteReservation.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_DeleteReservation.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_DeleteReservation.Location = New System.Drawing.Point(404, 410)
        Me.Btn_DeleteReservation.Name = "Btn_DeleteReservation"
        Me.Btn_DeleteReservation.Size = New System.Drawing.Size(197, 65)
        Me.Btn_DeleteReservation.TabIndex = 17
        Me.Btn_DeleteReservation.Text = "Borrar reserva"
        Me.Btn_DeleteReservation.UseVisualStyleBackColor = False
        '
        'EditReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 487)
        Me.Controls.Add(Me.Btn_DeleteReservation)
        Me.Controls.Add(Me.Btn_EditReservation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtBox_Enddate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtBox_Type)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBox_Startdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBox_Room)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EditReservationForm"
        Me.Text = "Editar reserva"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBox_Enddate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBox_Type As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBox_Startdate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBox_Room As TextBox
    Friend WithEvents Btn_EditReservation As Button
    Friend WithEvents Btn_DeleteReservation As Button
End Class
