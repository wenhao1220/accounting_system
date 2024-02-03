Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class analysis
    Private mysqlConnection As New Mysqlconnection1()
    Private Sub analysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 650
        Me.Height = 450

        FromMonthComboBox.Text = "01"
        ToMonthCombobox.Text = "12"
        Dim dtChartData As DataTable = GetMonthlySpend()
        Dim dtChartData2 As DataTable = GetBudget()
        Chart1.DataSource = dtChartData

        Chart1.Series.Clear()
        Chart1.Series.Add("月總支出")
        Chart1.Series("月總支出").BorderWidth = 5
        Chart1.Series("月總支出").XValueMember = "month"
        Chart1.Series("月總支出").YValueMembers = "monthly_total"
        Chart1.Series("月總支出").ChartType = SeriesChartType.Line
        Chart1.DataBind()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        home_page.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        bill.Show()
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

    Private Function GetMonthlySpend() As DataTable
        Dim dtChartData As New DataTable()

        MySqlConnection.Openconnection()


        Dim command As New MySqlCommand("GetMonthlySpend", MySqlConnection.getConnection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("startDate", "2023" + "-" + FromMonthComboBox.Text + "-" + "01")

        If ToMonthCombobox.Text = "02" Then
            command.Parameters.AddWithValue("endDate", "2023" + "-" + ToMonthCombobox.Text + "-" + "28")
        ElseIf ToMonthCombobox.Text = "01" Or ToMonthCombobox.Text = "03" Or ToMonthCombobox.Text = "05" Or ToMonthCombobox.Text = "07" Or ToMonthCombobox.Text = "08" Or ToMonthCombobox.Text = "10" Or ToMonthCombobox.Text = "12" Then
            command.Parameters.AddWithValue("endDate", "2023" + "-" + ToMonthCombobox.Text + "-" + "31")
        Else
            command.Parameters.AddWithValue("endDate", "2023" + "-" + ToMonthCombobox.Text + "-" + "30")
        End If

        command.Parameters.AddWithValue("id", Form1.user_id)
        Dim reader As MySqlDataReader = command.ExecuteReader()
        dtChartData.Load(reader)

        MySqlConnection.Closeconnection()

        Return dtChartData
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim dtChartData As DataTable = GetMonthlySpend()
        Chart1.DataSource = dtChartData
        Chart1.Series("月總支出").Points.Clear()
        Chart1.Series("月總支出").XValueMember = "month"
        Chart1.Series("月總支出").YValueMembers = "monthly_total"
    End Sub

    Private Function GetBudget() As DataTable
        Dim dtChartData As New DataTable()

        mysqlConnection.Openconnection()


        Dim command As New MySqlCommand("Select `budget` from `budget` where `month` >= " + FromMonthComboBox.Text + " and `month` <= " + ToMonthCombobox.Text + " and user = '" + Form1.user_id + "'", mysqlConnection.getConnection)

        Dim reader As MySqlDataReader = command.ExecuteReader()
        dtChartData.Load(reader)

        mysqlConnection.Closeconnection()

        Return dtChartData
    End Function

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
        budget.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        question.Show()
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