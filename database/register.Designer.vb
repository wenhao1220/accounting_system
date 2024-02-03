<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_passwd = New System.Windows.Forms.TextBox()
        Me.TextBox_username = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(44, 720)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(513, 80)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Spending Tracker"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(190, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 81)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "註冊"
        '
        'TextBox_passwd
        '
        Me.TextBox_passwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TextBox_passwd.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox_passwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.TextBox_passwd.Location = New System.Drawing.Point(770, 313)
        Me.TextBox_passwd.Name = "TextBox_passwd"
        Me.TextBox_passwd.Size = New System.Drawing.Size(310, 65)
        Me.TextBox_passwd.TabIndex = 15
        Me.TextBox_passwd.Text = "password"
        '
        'TextBox_username
        '
        Me.TextBox_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TextBox_username.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.TextBox_username.Location = New System.Drawing.Point(770, 193)
        Me.TextBox_username.Name = "TextBox_username"
        Me.TextBox_username.Size = New System.Drawing.Size(310, 65)
        Me.TextBox_username.TabIndex = 14
        Me.TextBox_username.Text = "username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("新細明體", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(613, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 53)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "密碼"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("新細明體", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(613, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 53)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "帳號"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.CheckBox1.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(770, 407)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(138, 28)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "顯示密碼"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(765, 581)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 43)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "返回登入"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(764, 504)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 43)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "註冊"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.database.My.Resources.Resources.登入_註冊頁面底圖
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1317, 835)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox_passwd)
        Me.Controls.Add(Me.TextBox_username)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "register"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spending tracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_passwd As TextBox
    Friend WithEvents TextBox_username As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
