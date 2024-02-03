Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
'Imports Microsoft.AspNet.SignalR.Infrastructure
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI

Public Class register
    Dim connection As New MySqlConnection("Server=database123.mysql.database.azure.com;UserID = wen_hao;Password=Myjane00!;Database=test4;SslMode=Required;SslCa={path_to_CA_cert};")
    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 650
        Me.Height = 450
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox_username.Enter
        Dim username As String = TextBox_username.Text

        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            TextBox_username.Text = ""
            TextBox_username.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox_username.Leave
        Dim username As String = TextBox_username.Text

        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            TextBox_username.Text = "username"
            TextBox_username.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox_passwd.Enter
        Dim pass As String = TextBox_passwd.Text

        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            TextBox_passwd.Text = ""
            TextBox_passwd.ForeColor = Color.Black
            TextBox_passwd.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox_passwd.Leave
        Dim pass As String = TextBox_passwd.Text

        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            TextBox_passwd.Text = "password"
            TextBox_passwd.ForeColor = Color.LightGray
            TextBox_passwd.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox_passwd.UseSystemPasswordChar = True Then
            TextBox_passwd.UseSystemPasswordChar = False
        Else
            TextBox_passwd.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox_username.Text().Trim() = "" Or TextBox_passwd.Text.Trim() = "" Or TextBox_username.Text().Trim() = "username" Or TextBox_passwd.Text.Trim() = "password" Then
            MessageBox.Show("帳號或密碼不能為空值")
        ElseIf username_exit(TextBox_username.Text().Trim()) Then
            MessageBox.Show("帳號已存在")
        Else
            Dim username As String = TextBox_username.Text
            Dim passwd As String = TextBox_passwd.Text
            Dim conn As New Mysqlconnection1()
            Dim command As New MySqlCommand("INSERT INTO `users`(`id`, `password`) VALUES (@username,@password)", conn.getConnection)
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = TextBox_username.Text
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBox_passwd.Text
            conn.Openconnection()

            If command.ExecuteNonQuery() = 1 Then
                Dim command1 As New MySqlCommand("INSERT INTO `income`(`date`, `in`, `type`, `amount`, `user_id`) VALUES (@date,@in,@type,@amount,@user_id), (@date2,@in2,@type2,@amount2,@user_id2)", conn.getConnection)
                command1.Parameters.Add("@date", MySqlDbType.Date).Value = "2023-01-01"
                command1.Parameters.Add("@in", MySqlDbType.VarChar).Value = "Spend"
                command1.Parameters.Add("@type", MySqlDbType.VarChar).Value = "diet"
                command1.Parameters.Add("@amount", MySqlDbType.Int64).Value = 0
                command1.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = TextBox_username.Text
                command1.Parameters.Add("@date2", MySqlDbType.Date).Value = "2023-01-01"
                command1.Parameters.Add("@in2", MySqlDbType.VarChar).Value = "Income"
                command1.Parameters.Add("@type2", MySqlDbType.VarChar).Value = "salary"
                command1.Parameters.Add("@amount2", MySqlDbType.Int64).Value = 0
                command1.Parameters.Add("@user_id2", MySqlDbType.VarChar).Value = TextBox_username.Text
                conn.Openconnection()

                If command1.ExecuteNonQuery() = 1 And command1.ExecuteNonQuery() = 1 Then
                    conn.Closeconnection()
                End If

                MessageBox.Show("用戶加入成功")
                Me.Close()
                Form1.Show()
            Else
                MessageBox.Show("用戶加入失敗")
                conn.Closeconnection()
            End If
        End If
    End Sub

    Public Function username_exit(ByVal username As String) As Boolean

        Dim con As New Mysqlconnection1()
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `users` WHERE `id` = @usn", con.getConnection())
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

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