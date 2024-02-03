Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class change_pw
    Dim connection As New MySqlConnection("Server=database123.mysql.database.azure.com;UserID = wen_hao;Password=Myjane00!;Database=test4;SslMode=Required;SslCa={path_to_CA_cert};")

    Private Sub change_pw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 650
        Me.Height = 450
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim conn As New Mysqlconnection1()
        Dim result As DialogResult = MessageBox.Show("確定修改密碼?", "修改", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) Then
                MessageBox.Show("不能為空值")
            ElseIf TextBox1.Text = TextBox2.Text Then
                MessageBox.Show("新密碼不能與原密碼相同")
            Else
                If TextBox1.Text = Form1.user_password Then
                    Dim command As New MySqlCommand("UPDATE `users` SET `password` = @password", conn.getConnection)

                    command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBox2.Text

                    Dim adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()

                    adapter.Fill(table)
                    adapter.SelectCommand = command

                    MessageBox.Show("密碼修改成功", "")
                    Me.Close()
                    Form1.Show()
                    Form1.TextBox_username.Text = "username"
                    Form1.TextBox_username.ForeColor = Color.LightGray
                    Form1.TextBox_password.Text = "password"
                    Form1.TextBox_password.ForeColor = Color.LightGray
                    Form1.TextBox_password.UseSystemPasswordChar = False
                Else
                    MessageBox.Show("原密碼輸入錯誤", "")
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        account.Show()
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
End Class