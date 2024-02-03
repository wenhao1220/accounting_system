Public Class account
    Private Sub account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 650
        Me.Height = 450

        Label4.Text = Form1.user_id
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        home_page.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        bill.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        analysis.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Income.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Income.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim result As DialogResult = MessageBox.Show("確定登出?", "登出", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
            Form1.Show()
            Form1.TextBox_username.Text = "username"
            Form1.TextBox_username.ForeColor = Color.LightGray
            Form1.TextBox_password.Text = "password"
            Form1.TextBox_password.ForeColor = Color.LightGray
            Form1.TextBox_password.UseSystemPasswordChar = False
        End If
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        change_pw.Show()
    End Sub

    Dim result As Byte
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = 161 And m.WParam = 20 Then
            result = MessageBox.Show("是否離開？", "", MessageBoxButtons.YesNo)
            If result = 6 Then
                Me.Close()
                Form1.Close()
            ElseIf result = 7 Then
            End If
        Else
            MyBase.WndProc(m)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        question.Show()
    End Sub
End Class