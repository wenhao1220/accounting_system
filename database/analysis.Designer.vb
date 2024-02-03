<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class analysis
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.FromMonthComboBox = New System.Windows.Forms.ComboBox()
        Me.ToMonthCombobox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 25.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(185, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 87)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "分析"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(200, 212)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(950, 507)
        Me.Chart1.TabIndex = 45
        Me.Chart1.Text = "Chart1"
        '
        'FromMonthComboBox
        '
        Me.FromMonthComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.FromMonthComboBox.Font = New System.Drawing.Font("新細明體", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FromMonthComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.FromMonthComboBox.FormattingEnabled = True
        Me.FromMonthComboBox.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.FromMonthComboBox.Location = New System.Drawing.Point(645, 62)
        Me.FromMonthComboBox.Name = "FromMonthComboBox"
        Me.FromMonthComboBox.Size = New System.Drawing.Size(159, 45)
        Me.FromMonthComboBox.TabIndex = 56
        '
        'ToMonthCombobox
        '
        Me.ToMonthCombobox.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ToMonthCombobox.Font = New System.Drawing.Font("新細明體", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ToMonthCombobox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ToMonthCombobox.FormattingEnabled = True
        Me.ToMonthCombobox.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.ToMonthCombobox.Location = New System.Drawing.Point(645, 141)
        Me.ToMonthCombobox.Name = "ToMonthCombobox"
        Me.ToMonthCombobox.Size = New System.Drawing.Size(159, 45)
        Me.ToMonthCombobox.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("新細明體", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(828, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 53)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "月"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("新細明體", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(924, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 53)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "~"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("新細明體", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(829, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 53)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "月"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Font = New System.Drawing.Font("新細明體", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(975, 140)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(175, 45)
        Me.Button8.TabIndex = 58
        Me.Button8.Text = "確定"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(1130, 725)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(217, 95)
        Me.Button7.TabIndex = 42
        Me.Button7.Text = "帳戶"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(857, 725)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(217, 95)
        Me.Button6.TabIndex = 41
        Me.Button6.Text = "收支明細"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(576, 725)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(217, 95)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "分析"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(313, 725)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(217, 95)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "發票載具"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(62, 725)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(215, 95)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "主頁"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("新細明體", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(1236, 581)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 95)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("新細明體", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1236, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 95)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "?"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.Font = New System.Drawing.Font("新細明體", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(961, 631)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(175, 45)
        Me.Button9.TabIndex = 62
        Me.Button9.Text = "查看預算"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'analysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.database.My.Resources.Resources.分析
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1375, 835)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.ToMonthCombobox)
        Me.Controls.Add(Me.FromMonthComboBox)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "analysis"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spending Tracker"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents FromMonthComboBox As ComboBox
    Friend WithEvents ToMonthCombobox As ComboBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button9 As Button
End Class
