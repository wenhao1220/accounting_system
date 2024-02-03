<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class question
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(127, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 81)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "問答系統"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(185, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 81)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Q:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(185, 429)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 81)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "A:"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ComboBox1.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"我可以從哪裡進行記帳?", "分析包含哪些內容?", "是否能更新密碼?"})
        Me.ComboBox1.Location = New System.Drawing.Point(314, 311)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(750, 69)
        Me.ComboBox1.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(304, 444)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 61)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "金額"
        '
        'question
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.database.My.Resources.Resources.問答
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1375, 835)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "question"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spendind tracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
End Class
