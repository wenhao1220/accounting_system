Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Windows

Public Class Form1
    Dim connection As New MySqlConnection("Server=database123.mysql.database.azure.com;UserID = wen_hao;Password=Myjane00!;Database=test4;SslMode=Required;SslCa={path_to_CA_cert};")
    Dim pythonPath As String = "C:\Users\user\anaconda3\python.exe" ' 請替換成你的 Python 解釋器路徑
    Dim scriptPath As String = "C:\Users\user\Desktop\lottery_check\lottery.py" ' 請替換成你的 Python 檔案路徑
    Dim scriptPath2 As String = "C:\Users\user\Desktop\lottery_check\lottery_month.py" ' 請替換成你的 Python 檔案路徑
    Public Shared this1, this2, this3, this4, this5 As String
    Public Shared last1, last2, last3, last4, last5 As String
    Public Shared year1, year2, month1, month2 As String
    Public Shared user_id As String
    Public Shared user_password As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim processStartInfo As New ProcessStartInfo(pythonPath, scriptPath)
        processStartInfo.UseShellExecute = False
        processStartInfo.CreateNoWindow = True

        Dim process As Process = Process.Start(processStartInfo)
        process.WaitForExit()

        Dim processStartInfo2 As New ProcessStartInfo(pythonPath, scriptPath2)
        processStartInfo2.UseShellExecute = False
        processStartInfo2.CreateNoWindow = True

        Dim process2 As Process = Process.Start(processStartInfo2)
        process2.WaitForExit()

        Me.Width = 650
        Me.Height = 450

        year1 = GetYear1()
        year2 = GetYear2()
        month1 = GetMonth1()
        month2 = GetMonth2()

        this1 = GetNumbers1(0)
        this2 = GetNumbers1(1)
        this3 = GetNumbers1(2) + GetNumbers1(3)
        this4 = GetNumbers1(4) + GetNumbers1(5)
        this5 = GetNumbers1(6) + GetNumbers1(7)

        last1 = GetNumbers2(0)
        last2 = GetNumbers2(1)
        last3 = GetNumbers2(2) + GetNumbers2(3)
        last4 = GetNumbers2(4) + GetNumbers2(5)
        last5 = GetNumbers2(6) + GetNumbers2(7)
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



    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox_password.Enter
        Dim pass As String = TextBox_password.Text

        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            TextBox_password.Text = ""
            TextBox_password.ForeColor = Color.Black
            TextBox_password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox_password.Leave
        Dim pass As String = TextBox_password.Text

        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            TextBox_password.Text = "password"
            TextBox_password.ForeColor = Color.LightGray
            TextBox_password.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox_password.UseSystemPasswordChar = True Then
            TextBox_password.UseSystemPasswordChar = False
        Else
            TextBox_password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        register.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New MySqlCommand("SELECT `id`, `password` FROM `users` WHERE `id` = @username AND `password` = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = TextBox_username.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBox_password.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        adapter.SelectCommand = command

        If table.Rows.Count = 0 Then
            MessageBox.Show("帳號和密碼輸入錯誤")
        Else
            user_id = TextBox_username.Text
            user_password = TextBox_password.Text
            MessageBox.Show("登入成功")
            Me.Hide()
            home_page.Show()
        End If

    End Sub

    Private Function GetNumbers1(ByVal x As String) As String
        Dim mysqlConnection As New Mysqlconnection1()
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("value")

        mysqlConnection.Openconnection()

        Dim cmd As New MySqlCommand("select numbers from this_month_numbers LIMIT 1 offset " + x, mysqlConnection.getConnection)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        reader.Read()
        dataTable.Rows.Add(reader("numbers"))
        Dim num As String = dataTable.Rows(0)("value")

        reader.Close()
        mysqlConnection.Closeconnection()
        Return num

    End Function

    Private Function GetNumbers2(ByVal x As String) As String
        Dim mysqlConnection As New Mysqlconnection1()
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("value")

        mysqlConnection.Openconnection()

        Dim cmd As New MySqlCommand("select numbers from last_month_numbers LIMIT 1 offset " + x, mysqlConnection.getConnection)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        reader.Read()
        dataTable.Rows.Add(reader("numbers"))
        Dim num As String = dataTable.Rows(0)("value")

        reader.Close()
        mysqlConnection.Closeconnection()
        Return num

    End Function

    Private Function GetYear1() As String
        Dim mysqlConnection As New Mysqlconnection1()
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("value")

        mysqlConnection.Openconnection()

        Dim cmd As New MySqlCommand("select year from this_month_numbers LIMIT 1", mysqlConnection.getConnection)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        reader.Read()
        dataTable.Rows.Add(reader("year"))
        Dim num As String = dataTable.Rows(0)("value")

        reader.Close()
        mysqlConnection.Closeconnection()
        Return num

    End Function

    Private Function GetYear2() As String
        Dim mysqlConnection As New Mysqlconnection1()
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("value")

        mysqlConnection.Openconnection()

        Dim cmd As New MySqlCommand("select year from last_month_numbers LIMIT 1", mysqlConnection.getConnection)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        reader.Read()
        dataTable.Rows.Add(reader("year"))
        Dim num As String = dataTable.Rows(0)("value")

        reader.Close()
        mysqlConnection.Closeconnection()
        Return num

    End Function

    Private Function GetMonth1() As String
        Dim mysqlConnection As New Mysqlconnection1()
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("value")

        mysqlConnection.Openconnection()

        Dim cmd As New MySqlCommand("select month from this_month_numbers LIMIT 1", mysqlConnection.getConnection)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        reader.Read()
        dataTable.Rows.Add(reader("month"))
        Dim num As String = dataTable.Rows(0)("value")

        reader.Close()
        mysqlConnection.Closeconnection()
        Return num

    End Function

    Private Function GetMonth2() As String
        Dim mysqlConnection As New Mysqlconnection1()
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("value")

        mysqlConnection.Openconnection()

        Dim cmd As New MySqlCommand("select month from last_month_numbers LIMIT 1", mysqlConnection.getConnection)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        reader.Read()
        dataTable.Rows.Add(reader("month"))
        Dim num As String = dataTable.Rows(0)("value")

        reader.Close()
        mysqlConnection.Closeconnection()
        Return num

    End Function

    Dim result As Byte
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = 161 And m.WParam = 20 Then
            result = MessageBox.Show("是否離開？", "", MessageBoxButtons.YesNo)
            If result = 6 Then
                Me.Close()
            ElseIf result = 7 Then
            End If
        Else
            MyBase.WndProc(m)
        End If
    End Sub
End Class
