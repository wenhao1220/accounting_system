Imports MySql.Data.MySqlClient

Public Class bill
    Private mysqlConnection As New Mysqlconnection1()
    Private a1(8) As Integer
    Private a2(8) As Integer
    Private a3(8) As Integer
    Private b1(8) As Integer
    Private b2(8) As Integer
    Private b3(8) As Integer
    Private a(8) As Integer

    Private Sub bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 650
        Me.Height = 450
        Dim award1 As Integer = Form1.this3
        Dim award2 As Integer = Form1.this4
        Dim award3 As Integer = Form1.this5
        Dim award4 As Integer = Form1.last3
        Dim award5 As Integer = Form1.last4
        Dim award6 As Integer = Form1.last5

        ComboBox2.Items.Add(Form1.year1)
        ComboBox2.Items.Add(Form1.year2)
        ComboBox2.SelectedItem = Form1.year1

        ComboBox1.Items.Add(Form1.month1)
        ComboBox1.Items.Add(Form1.month2)
        ComboBox1.SelectedItem = Form1.month1

        Label5.Text = Form1.this1
        Label6.Text = Form1.this2
        Label7.Text = Form1.this3
        Label8.Text = Form1.this4
        Label9.Text = Form1.this5


        Label10.Text = Form1.last1
        Label11.Text = Form1.last2
        Label12.Text = Form1.last3
        Label13.Text = Form1.last4
        Label14.Text = Form1.last5

        'this month
        For i As Integer = 0 To 7
            a1(i) = award1 Mod 10
            award1 = award1 \ 10
        Next

        For i As Integer = 0 To 7
            a2(i) = award2 Mod 10
            award2 = award2 \ 10
        Next

        For i As Integer = 0 To 7
            a3(i) = award3 Mod 10
            award3 = award3 \ 10
        Next

        'last month
        For i As Integer = 0 To 7
            b1(i) = award4 Mod 10
            award4 = award4 \ 10
        Next

        For i As Integer = 0 To 7
            b2(i) = award5 Mod 10
            award5 = award5 \ 10
        Next

        For i As Integer = 0 To 7
            b3(i) = award6 Mod 10
            award6 = award6 \ 10
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        home_page.Show()
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim award As Integer
        Dim i As Integer = 0
        a = {0, 0, 0, 0, 0, 0, 0, 0}

        If IsNumeric(TextBox2.Text) And (TextBox2.Text.Length = 8 AndAlso IsNumeric(TextBox2.Text)) Then
            Label4.Text = TextBox2.Text
            award = TextBox2.Text

            While award <> 0
                a(i) = award Mod 10
                award = award \ 10
                i = i + 1
            End While
        Else
            MessageBox.Show("請輸入正確發票序號", "")
        End If

        If IsNumeric(TextBox2.Text) And (TextBox2.Text.Length = 8 AndAlso IsNumeric(TextBox2.Text)) Then
            If ComboBox2.Text = Form1.year1 And ComboBox1.Text = Form1.month1 Then
                'this month
                If TextBox2.Text = Label5.Text Then
                    Label2.Text = "10,000,000"
                    Label2.Visible = True
                    Label4.Visible = True
                    Label16.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = False
                ElseIf TextBox2.Text = Label6.Text Then
                    Label2.Text = "2,000,000"
                    Label2.Visible = True
                    Label4.Visible = True
                    Label16.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = False
                ElseIf TextBox2.Text = Label7.Text Or TextBox2.Text = Label8.Text Or TextBox2.Text = Label9.Text Then
                    Label2.Text = "200,000"
                    Label2.Visible = True
                    Label4.Visible = True
                    Label16.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = False
                ElseIf (a(0) = a1(0) And a(1) = a1(1) And a(2) = a1(2) And a(3) = a1(3) And a(4) = a1(4) And a(5) = a1(5) And a(6) = a1(6)) Or (a(0) = a2(0) And a(1) = a2(1) And a(2) = a2(2) And a(3) = a2(3) And a(4) = a2(4) And a(5) = a2(5) And a(6) = a2(6)) Or (a(0) = a3(0) And a(1) = a3(1) And a(2) = a3(2) And a(3) = a3(3) And a(4) = a3(4) And a(5) = a3(5) And a(6) = a3(6)) Then
                    Label2.Text = "40,000"
                    Label2.Visible = True
                    Label4.Visible = True
                    Label16.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = False
                ElseIf (a(0) = a1(0) And a(1) = a1(1) And a(2) = a1(2) And a(3) = a1(3) And a(4) = a1(4) And a(5) = a1(5)) Or (a(0) = a2(0) And a(1) = a2(1) And a(2) = a2(2) And a(3) = a2(3) And a(4) = a2(4) And a(5) = a2(5)) Or (a(0) = a3(0) And a(1) = a3(1) And a(2) = a3(2) And a(3) = a3(3) And a(4) = a3(4) And a(5) = a3(5)) Then
                    Label2.Text = "10,000"
                    Label2.Visible = True
                    Label4.Visible = True
                    Label16.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = False
                ElseIf (a(0) = a1(0) And a(1) = a1(1) And a(2) = a1(2) And a(3) = a1(3) And a(4) = a1(4)) Or (a(0) = a2(0) And a(1) = a2(1) And a(2) = a2(2) And a(3) = a2(3) And a(4) = a2(4)) Or (a(0) = a3(0) And a(1) = a3(1) And a(2) = a3(2) And a(3) = a3(3) And a(4) = a3(4)) Then
                    Label2.Text = "4,000"
                    Label2.Visible = True
                    Label4.Visible = True
                    Label16.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = False
                ElseIf (a(0) = a1(0) And a(1) = a1(1) And a(2) = a1(2) And a(3) = a1(3)) Or (a(0) = a2(0) And a(1) = a2(1) And a(2) = a2(2) And a(3) = a2(3)) Or (a(0) = a3(0) And a(1) = a3(1) And a(2) = a3(2) And a(3) = a3(3)) Then
                    Label2.Text = "1,000"
                    Label2.Visible = True
                    Label4.Visible = True
                    Label16.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = False
                ElseIf (a(0) = a1(0) And a(1) = a1(1) And a(2) = a1(2)) Or (a(0) = a2(0) And a(1) = a2(1) And a(2) = a2(2)) Or (a(0) = a3(0) And a(1) = a3(1) And a(2) = a3(2)) Then
                    Label2.Text = "200"
                    Label2.Visible = True
                    Label4.Visible = True
                    Label16.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = False
                Else
                    Label2.Visible = False
                    Label4.Visible = False
                    Label16.Visible = False
                    Label18.Visible = False
                    Label19.Visible = False
                    Label20.Visible = True
                End If

            ElseIf ComboBox2.Text = Form1.year2 And ComboBox1.Text = Form1.month2 Then

                'last Month
                If TextBox2.Text = Label10.Text Then
                    Label2.Text = "10,000,000"
                    Label2.Visible = True
                    Label4.Visible = True
                    Label16.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = False
                ElseIf TextBox2.Text = Label11.Text Then
                    Label2.Text = "2,000,000"
                    Label2.Visible = True
                    Label4.Visible = True
                    Label16.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = False
                ElseIf TextBox2.Text = Label12.Text Or TextBox2.Text = Label13.Text Or TextBox2.Text = Label14.Text Then
                    Label2.Text = "200,000"
                    Label2.Visible = True
                    Label4.Visible = True
                    Label16.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = False
                ElseIf (a(0) = b1(0) And a(1) = b1(1) And a(2) = b1(2) And a(3) = b1(3) And a(4) = b1(4) And a(5) = b1(5) And a(6) = b1(6)) Or (a(0) = b2(0) And a(1) = b2(1) And a(2) = b2(2) And a(3) = b2(3) And a(4) = b2(4) And a(5) = b2(5) And a(6) = b2(6)) Or (a(0) = b3(0) And a(1) = b3(1) And a(2) = b3(2) And a(3) = b3(3) And a(4) = b3(4) And a(5) = b3(5) And a(6) = b3(6)) Then
                    Label2.Text = "40,000"
                    Label2.Visible = True
                    Label4.Visible = True
                    Label16.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = False
                ElseIf (a(0) = b1(0) And a(1) = b1(1) And a(2) = b1(2) And a(3) = b1(3) And a(4) = b1(4) And a(5) = b1(5)) Or (a(0) = b2(0) And a(1) = b2(1) And a(2) = b2(2) And a(3) = b2(3) And a(4) = b2(4) And a(5) = b2(5)) Or (a(0) = b3(0) And a(1) = b3(1) And a(2) = b3(2) And a(3) = b3(3) And a(4) = b3(4) And a(5) = b3(5)) Then
                    Label2.Text = "10,000"
                    Label2.Visible = True
                    Label4.Visible = True
                    Label16.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = False
                ElseIf (a(0) = b1(0) And a(1) = b1(1) And a(2) = b1(2) And a(3) = b1(3) And a(4) = b1(4)) Or (a(0) = b2(0) And a(1) = b2(1) And a(2) = b2(2) And a(3) = b2(3) And a(4) = b2(4)) Or (a(0) = b3(0) And a(1) = b3(1) And a(2) = b3(2) And a(3) = b3(3) And a(4) = b3(4)) Then
                    Label2.Text = "4,000"
                    Label2.Visible = True
                    Label4.Visible = True
                    Label16.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = False
                ElseIf (a(0) = b1(0) And a(1) = b1(1) And a(2) = b1(2) And a(3) = b1(3)) Or (a(0) = b2(0) And a(1) = b2(1) And a(2) = b2(2) And a(3) = b2(3)) Or (a(0) = b3(0) And a(1) = b3(1) And a(2) = b3(2) And a(3) = b3(3)) Then
                    Label2.Text = "1,000"
                    Label2.Visible = True
                    Label4.Visible = True
                    Label16.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = False
                ElseIf (a(0) = b1(0) And a(1) = b1(1) And a(2) = b1(2)) Or (a(0) = b2(0) And a(1) = b2(1) And a(2) = b2(2)) Or (a(0) = b3(0) And a(1) = b3(1) And a(2) = b3(2)) Then
                    Label2.Text = "200"
                    Label2.Visible = True
                    Label4.Visible = True
                    Label16.Visible = True
                    Label18.Visible = True
                    Label19.Visible = True
                    Label20.Visible = False
                Else
                    Label2.Visible = False
                    Label4.Visible = False
                    Label16.Visible = False
                    Label18.Visible = False
                    Label19.Visible = False
                    Label20.Visible = True
                End If

            End If
        End If
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