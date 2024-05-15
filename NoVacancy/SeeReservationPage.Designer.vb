<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SeeReservationPage
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_Products = New System.Windows.Forms.ComboBox()
        Me.TxtBox_Quantity = New System.Windows.Forms.TextBox()
        Me.Btn_Plus = New System.Windows.Forms.Button()
        Me.Btn_Minus = New System.Windows.Forms.Button()
        Me.ListBox_ReservationProds = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_EndReservation = New System.Windows.Forms.Button()
        Me.Btn_AddProducts = New System.Windows.Forms.Button()
        Me.TxtBox_TotalAmount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_DeleteProduct = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(768, 101)
        Me.DataGridView1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 244)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Fecha salida"
        '
        'TxtBox_Enddate
        '
        Me.TxtBox_Enddate.Location = New System.Drawing.Point(228, 270)
        Me.TxtBox_Enddate.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBox_Enddate.Name = "TxtBox_Enddate"
        Me.TxtBox_Enddate.Size = New System.Drawing.Size(132, 22)
        Me.TxtBox_Enddate.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(228, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tipo"
        '
        'TxtBox_Type
        '
        Me.TxtBox_Type.Enabled = False
        Me.TxtBox_Type.Location = New System.Drawing.Point(228, 157)
        Me.TxtBox_Type.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBox_Type.Name = "TxtBox_Type"
        Me.TxtBox_Type.Size = New System.Drawing.Size(132, 22)
        Me.TxtBox_Type.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 244)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha entrada"
        '
        'TxtBox_Startdate
        '
        Me.TxtBox_Startdate.Location = New System.Drawing.Point(16, 270)
        Me.TxtBox_Startdate.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBox_Startdate.Name = "TxtBox_Startdate"
        Me.TxtBox_Startdate.Size = New System.Drawing.Size(132, 22)
        Me.TxtBox_Startdate.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 132)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Habitación"
        '
        'TxtBox_Room
        '
        Me.TxtBox_Room.Enabled = False
        Me.TxtBox_Room.Location = New System.Drawing.Point(16, 157)
        Me.TxtBox_Room.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBox_Room.Name = "TxtBox_Room"
        Me.TxtBox_Room.Size = New System.Drawing.Size(132, 22)
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
        Me.Btn_EditReservation.Location = New System.Drawing.Point(6, 558)
        Me.Btn_EditReservation.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_EditReservation.Name = "Btn_EditReservation"
        Me.Btn_EditReservation.Size = New System.Drawing.Size(263, 80)
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
        Me.Btn_DeleteReservation.Location = New System.Drawing.Point(565, 561)
        Me.Btn_DeleteReservation.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_DeleteReservation.Name = "Btn_DeleteReservation"
        Me.Btn_DeleteReservation.Size = New System.Drawing.Size(263, 80)
        Me.Btn_DeleteReservation.TabIndex = 17
        Me.Btn_DeleteReservation.Text = "Borrar reserva"
        Me.Btn_DeleteReservation.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(452, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Productos"
        '
        'CB_Products
        '
        Me.CB_Products.FormattingEnabled = True
        Me.CB_Products.Location = New System.Drawing.Point(455, 153)
        Me.CB_Products.Name = "CB_Products"
        Me.CB_Products.Size = New System.Drawing.Size(329, 24)
        Me.CB_Products.TabIndex = 19
        '
        'TxtBox_Quantity
        '
        Me.TxtBox_Quantity.Location = New System.Drawing.Point(597, 208)
        Me.TxtBox_Quantity.Name = "TxtBox_Quantity"
        Me.TxtBox_Quantity.Size = New System.Drawing.Size(44, 22)
        Me.TxtBox_Quantity.TabIndex = 20
        '
        'Btn_Plus
        '
        Me.Btn_Plus.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_Plus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Plus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_Plus.Enabled = False
        Me.Btn_Plus.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Plus.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_Plus.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_Plus.Location = New System.Drawing.Point(648, 199)
        Me.Btn_Plus.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Plus.Name = "Btn_Plus"
        Me.Btn_Plus.Size = New System.Drawing.Size(39, 34)
        Me.Btn_Plus.TabIndex = 21
        Me.Btn_Plus.Text = "+"
        Me.Btn_Plus.UseVisualStyleBackColor = False
        '
        'Btn_Minus
        '
        Me.Btn_Minus.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_Minus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Minus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_Minus.Enabled = False
        Me.Btn_Minus.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Minus.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_Minus.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_Minus.Location = New System.Drawing.Point(551, 199)
        Me.Btn_Minus.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Minus.Name = "Btn_Minus"
        Me.Btn_Minus.Size = New System.Drawing.Size(39, 34)
        Me.Btn_Minus.TabIndex = 22
        Me.Btn_Minus.Text = "-"
        Me.Btn_Minus.UseVisualStyleBackColor = False
        '
        'ListBox_ReservationProds
        '
        Me.ListBox_ReservationProds.FormattingEnabled = True
        Me.ListBox_ReservationProds.ItemHeight = 16
        Me.ListBox_ReservationProds.Location = New System.Drawing.Point(455, 264)
        Me.ListBox_ReservationProds.Name = "ListBox_ReservationProds"
        Me.ListBox_ReservationProds.Size = New System.Drawing.Size(329, 100)
        Me.ListBox_ReservationProds.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(452, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Productos de la reserva"
        '
        'Btn_EndReservation
        '
        Me.Btn_EndReservation.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_EndReservation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_EndReservation.BackColor = System.Drawing.SystemColors.Info
        Me.Btn_EndReservation.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EndReservation.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_EndReservation.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_EndReservation.Location = New System.Drawing.Point(6, 440)
        Me.Btn_EndReservation.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_EndReservation.Name = "Btn_EndReservation"
        Me.Btn_EndReservation.Size = New System.Drawing.Size(263, 80)
        Me.Btn_EndReservation.TabIndex = 25
        Me.Btn_EndReservation.Text = "Finalizar reserva"
        Me.Btn_EndReservation.UseVisualStyleBackColor = False
        '
        'Btn_AddProducts
        '
        Me.Btn_AddProducts.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_AddProducts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_AddProducts.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_AddProducts.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AddProducts.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_AddProducts.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_AddProducts.Location = New System.Drawing.Point(419, 371)
        Me.Btn_AddProducts.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_AddProducts.Name = "Btn_AddProducts"
        Me.Btn_AddProducts.Size = New System.Drawing.Size(171, 48)
        Me.Btn_AddProducts.TabIndex = 26
        Me.Btn_AddProducts.Text = "Añadir productos"
        Me.Btn_AddProducts.UseVisualStyleBackColor = False
        '
        'TxtBox_TotalAmount
        '
        Me.TxtBox_TotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBox_TotalAmount.ForeColor = System.Drawing.Color.Red
        Me.TxtBox_TotalAmount.Location = New System.Drawing.Point(288, 511)
        Me.TxtBox_TotalAmount.Name = "TxtBox_TotalAmount"
        Me.TxtBox_TotalAmount.Size = New System.Drawing.Size(251, 61)
        Me.TxtBox_TotalAmount.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(306, 484)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 24)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Total reserva:"
        '
        'Btn_DeleteProduct
        '
        Me.Btn_DeleteProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_DeleteProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_DeleteProduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_DeleteProduct.Enabled = False
        Me.Btn_DeleteProduct.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_DeleteProduct.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_DeleteProduct.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_DeleteProduct.Location = New System.Drawing.Point(648, 371)
        Me.Btn_DeleteProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_DeleteProduct.Name = "Btn_DeleteProduct"
        Me.Btn_DeleteProduct.Size = New System.Drawing.Size(171, 48)
        Me.Btn_DeleteProduct.TabIndex = 29
        Me.Btn_DeleteProduct.Text = "Borrar producto"
        Me.Btn_DeleteProduct.UseVisualStyleBackColor = False
        '
        'SeeReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(841, 654)
        Me.Controls.Add(Me.Btn_DeleteProduct)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtBox_TotalAmount)
        Me.Controls.Add(Me.Btn_AddProducts)
        Me.Controls.Add(Me.Btn_EndReservation)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox_ReservationProds)
        Me.Controls.Add(Me.Btn_Minus)
        Me.Controls.Add(Me.Btn_Plus)
        Me.Controls.Add(Me.TxtBox_Quantity)
        Me.Controls.Add(Me.CB_Products)
        Me.Controls.Add(Me.Label5)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SeeReservationForm"
        Me.Text = "Editar reserva"
        Me.TopMost = True
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
    Friend WithEvents Label5 As Label
    Friend WithEvents CB_Products As ComboBox
    Friend WithEvents TxtBox_Quantity As TextBox
    Friend WithEvents Btn_Plus As Button
    Friend WithEvents Btn_Minus As Button
    Friend WithEvents ListBox_ReservationProds As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn_EndReservation As Button
    Friend WithEvents Btn_AddProducts As Button
    Friend WithEvents TxtBox_TotalAmount As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Btn_DeleteProduct As Button
End Class
