<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class change_pw
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
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(144, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 81)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "更改密碼"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(610, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 67)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "原密碼"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(610, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 67)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "新密碼"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(736, 440)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(155, 47)
        Me.Button9.TabIndex = 60
        Me.Button9.Text = "確認"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(817, 316)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(282, 65)
        Me.TextBox2.TabIndex = 61
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(817, 203)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(282, 65)
        Me.TextBox1.TabIndex = 62
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(736, 522)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 47)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "返回"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'change_pw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.database.My.Resources.Resources.更改密碼
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1375, 835)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "change_pw"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spending tracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
