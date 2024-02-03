<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class budget
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.View1 = New System.Windows.Forms.DataGridView()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.View1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'View1
        '
        Me.View1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View1.Location = New System.Drawing.Point(563, 135)
        Me.View1.Name = "View1"
        Me.View1.RowHeadersWidth = 82
        Me.View1.RowTemplate.Height = 38
        Me.View1.Size = New System.Drawing.Size(758, 572)
        Me.View1.TabIndex = 60
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(479, 744)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(213, 54)
        Me.Button8.TabIndex = 61
        Me.Button8.Text = "返回預算介面"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("新細明體", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(204, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 53)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "預算"
        '
        'budget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.database.My.Resources.Resources.預算
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1375, 834)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.View1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "budget"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spending tracker"
        CType(Me.View1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents View1 As DataGridView
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
End Class
