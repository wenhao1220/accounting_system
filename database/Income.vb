Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Income
    Private mysqlConnection As New Mysqlconnection1()
    Dim connection As New MySqlConnection("Server=database123.mysql.database.azure.com;UserID = wen_hao;Password=Myjane00!;Database=test4;SslMode=Required;SslCa={path_to_CA_cert};")
    Private Sub Income_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New MySqlCommand("SELECT `user_id` FROM `income` WHERE `user_id` = @user_id", connection)
        Me.Width = 650
        Me.Height = 450
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"

        ComboBox1.Items.Add("Income")
        ComboBox1.Items.Add("Spend")
        ComboBox1.SelectedItem = "支出"

        Dim query As String = "SELECT `date`, `in` as Income_Spend, `type`, `amount` FROM income WHERE user_id = '" + Form1.user_id + "' order by `date` limit 4, 100"
        Dim adapter As New MySqlDataAdapter(query, mysqlConnection.getConnection())
        Dim data As New DataTable()
        adapter.Fill(data)

        View1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        View1.DataSource = data

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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        account.Show()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()

        Select Case ComboBox1.SelectedItem.ToString()
            Case "Spend"
                ComboBox2.Items.Add("Diet")
                ComboBox2.Items.Add("Clothing")
                ComboBox2.Items.Add("Entertainment")
                ComboBox2.Items.Add("Traffic")
                ComboBox2.Items.Add("Others")
                ComboBox2.SelectedItem = "Diet"
            Case "Income"
                ComboBox2.Items.Add("Salary")
                ComboBox2.Items.Add("Others")
                ComboBox2.SelectedItem = "Salary"
        End Select
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If DateTimePicker1.Text().Trim() = "" Or ComboBox1.Text.Trim() = "" Or ComboBox2.Text().Trim() = "" Or TextBox4.Text.Trim() = "" Then
            MessageBox.Show("不能為空值")
        ElseIf Not Integer.TryParse(TextBox4.Text, 0) Then
            MessageBox.Show("金額請輸入數字")
        Else
            Dim conn As New Mysqlconnection1()
            Dim command As New MySqlCommand("INSERT INTO `income`(`date`, `in`, `type`, `amount`, `user_id`) VALUES (@date,@in,@type,@amount,@user_id)", conn.getConnection)
            command.Parameters.Add("@date", MySqlDbType.Date).Value = DateTimePicker1.Text
            command.Parameters.Add("@in", MySqlDbType.VarChar).Value = ComboBox1.Text
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = ComboBox2.Text
            command.Parameters.Add("@amount", MySqlDbType.Int64).Value = TextBox4.Text
            command.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = Form1.user_id
            conn.Openconnection()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("加入成功")
                conn.Closeconnection()
                Me.Close()
                reloading.Show()
            End If
        End If
    End Sub

    Private Function Getype() As String
        Dim mysqlConnection As New Mysqlconnection1()
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("value")

        mysqlConnection.Openconnection()

        Dim cmd As New MySqlCommand("select `type` from income LIMIT 1", mysqlConnection.getConnection)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        reader.Read()
        dataTable.Rows.Add(reader("type"))
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