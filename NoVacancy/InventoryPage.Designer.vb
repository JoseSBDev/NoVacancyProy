<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryPage
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
        Me.ListBox_Alerts = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_UpdateStock = New System.Windows.Forms.Button()
        Me.TxtBox_Product = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBox_Stock = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(619, 530)
        Me.DataGridView1.TabIndex = 0
        '
        'ListBox_Alerts
        '
        Me.ListBox_Alerts.FormattingEnabled = True
        Me.ListBox_Alerts.ItemHeight = 16
        Me.ListBox_Alerts.Location = New System.Drawing.Point(664, 51)
        Me.ListBox_Alerts.Name = "ListBox_Alerts"
        Me.ListBox_Alerts.Size = New System.Drawing.Size(494, 180)
        Me.ListBox_Alerts.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(658, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Alertas de stock"
        '
        'Btn_UpdateStock
        '
        Me.Btn_UpdateStock.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btn_UpdateStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_UpdateStock.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_UpdateStock.Enabled = False
        Me.Btn_UpdateStock.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_UpdateStock.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Btn_UpdateStock.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Btn_UpdateStock.Location = New System.Drawing.Point(664, 276)
        Me.Btn_UpdateStock.Name = "Btn_UpdateStock"
        Me.Btn_UpdateStock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_UpdateStock.Size = New System.Drawing.Size(237, 65)
        Me.Btn_UpdateStock.TabIndex = 13
        Me.Btn_UpdateStock.Text = "Actualizar stock"
        Me.Btn_UpdateStock.UseVisualStyleBackColor = False
        '
        'TxtBox_Product
        '
        Me.TxtBox_Product.Enabled = False
        Me.TxtBox_Product.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBox_Product.Location = New System.Drawing.Point(664, 371)
        Me.TxtBox_Product.Name = "TxtBox_Product"
        Me.TxtBox_Product.Size = New System.Drawing.Size(149, 22)
        Me.TxtBox_Product.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(661, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(661, 405)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Cantidad"
        '
        'TxtBox_Stock
        '
        Me.TxtBox_Stock.Location = New System.Drawing.Point(664, 425)
        Me.TxtBox_Stock.Name = "TxtBox_Stock"
        Me.TxtBox_Stock.Size = New System.Drawing.Size(149, 22)
        Me.TxtBox_Stock.TabIndex = 16
        '
        'InventoryPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 554)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtBox_Stock)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBox_Product)
        Me.Controls.Add(Me.Btn_UpdateStock)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox_Alerts)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "InventoryPage"
        Me.Text = "InventoryPage"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ListBox_Alerts As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_UpdateStock As Button
    Friend WithEvents TxtBox_Product As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBox_Stock As TextBox
End Class
