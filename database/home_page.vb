Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
' this is the home page of the application
Public Class home_page
    Private Sub home_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 650
        Me.Height = 450
        Label2.Text = DateTime.Today.ToString("yyyy/MM/dd")
        Label4.Text = GetIncome() - GetSpend()

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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        account.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Income.Show()
    End Sub

    Private Function GetSpend() As Int64
        Dim mysqlConnection As New Mysqlconnection1()
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("value")

        mysqlConnection.Openconnection()

        Dim cmd As New MySqlCommand("SELECT SUM(`amount`) AS spend from `income` WHERE `user_id` = '" + Form1.user_id + "' AND `in` = 'Spend' ", mysqlConnection.getConnection)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        reader.Read()
        dataTable.Rows.Add(reader("spend"))
        Dim num As Int64 = dataTable.Rows(0)("value")

        reader.Close()
        mysqlConnection.Closeconnection()
        Return num

    End Function

    Private Function GetIncome() As Int64
        Dim mysqlConnection As New Mysqlconnection1()
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("value")

        mysqlConnection.Openconnection()

        Dim cmd As New MySqlCommand("SELECT SUM(`amount`) AS spend from `income` WHERE `user_id` = '" + Form1.user_id + "' AND `in` = 'Income' ", mysqlConnection.getConnection)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        reader.Read()
        dataTable.Rows.Add(reader("spend"))
        Dim num As Int64 = dataTable.Rows(0)("value")

        reader.Close()
        mysqlConnection.Closeconnection()
        Return num

    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim conn As New Mysqlconnection1()
        If Not IsNumeric(TextBox1.Text) Then
            MessageBox.Show("請輸入數字")
        ElseIf ComboBox1.Text = "" Then
            MessageBox.Show("請選擇月份")
        Else
            If Countbudget(ComboBox1.Text) = "0" Then
                Dim command As New MySqlCommand("INSERT INTO `budget`(`month`, `budget`, `user`) VALUES (@month,@budget,@user)", conn.getConnection)
                command.Parameters.Add("@month", MySqlDbType.VarChar).Value = ComboBox1.Text
                command.Parameters.Add("@budget", MySqlDbType.Int64).Value = TextBox1.Text
                command.Parameters.Add("@user", MySqlDbType.VarChar).Value = Form1.user_id
                conn.Openconnection()
                If command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("預算已加入")
                    conn.Closeconnection()
                Else
                    MessageBox.Show("預算加入失敗")
                    conn.Closeconnection()
                End If
            Else
                Dim command As New MySqlCommand("UPDATE `budget` SET `budget`=@budget WHERE `month`=@month AND `user`=@user", conn.getConnection)
                command.Parameters.Add("@month", MySqlDbType.VarChar).Value = ComboBox1.Text
                command.Parameters.Add("@budget", MySqlDbType.Int64).Value = TextBox1.Text
                command.Parameters.Add("@user", MySqlDbType.VarChar).Value = Form1.user_id
                conn.Openconnection()
                If command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("預算已更新")
                    conn.Closeconnection()
                Else
                    MessageBox.Show("預算更新失敗")
                    conn.Closeconnection()
                End If
            End If
        End If
    End Sub

    Private Function Countbudget(ByVal x As String) As String
        Dim mysqlConnection As New Mysqlconnection1()
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("value")

        mysqlConnection.Openconnection()

        Dim cmd As New MySqlCommand("select COUNT(*) as count from budget where month = " + x + " and user = '" + Form1.user_id + "'", mysqlConnection.getConnection)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        reader.Read()
        dataTable.Rows.Add(reader("count"))
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