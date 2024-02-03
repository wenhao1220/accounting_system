Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Reflection.Emit

Public Class budget
    Private mysqlConnection As New Mysqlconnection1()
    Dim connection As New MySqlConnection("Server=database123.mysql.database.azure.com;UserID = wen_hao;Password=Myjane00!;Database=test4;SslMode=Required;SslCa={path_to_CA_cert};")

    Private Sub budget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 650
        Me.Height = 450

        Dim command As New MySqlCommand("SELECT `user_id` FROM `income` WHERE `user_id` = @user_id", connection)

        Dim query As String = "SELECT `month`, `budget` FROM `budget` WHERE user = '" + Form1.user_id + "'"
        Dim adapter As New MySqlDataAdapter(query, MySqlConnection.getConnection())
        Dim data As New DataTable()
        adapter.Fill(data)

        View1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        View1.DataSource = data
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        analysis.Show()
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