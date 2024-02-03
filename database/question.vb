Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Mysqlx.XDevAPI.Common

Public Class question
    Private Sub question_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 650
        Me.Height = 450

        Label6.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem.ToString()
            Case "我可以從哪裡進行記帳?"
                Label6.Text = "您可以點選畫面中的加號按鈕進行" + Environment.NewLine + "記帳，也可以點選收支明細安鈕進" + Environment.NewLine + "行記帳與相關編輯修改。"
            Case "分析包含哪些內容?"
                Label6.Text = "於分析頁面您可以選擇查看不同月份" + Environment.NewLine + "的支出圖表，並可點選查看預算案鈕" + Environment.NewLine + "查看各月份預算，以協助您了解每個" + Environment.NewLine + "月的支出是否超出預算。"
            Case "是否能更新密碼?"
                Label6.Text = "您可以點選帳戶按鈕查看此帳戶密" + Environment.NewLine + "碼，並且可以點選更改密碼按鈕以" + Environment.NewLine + "更改密碼。"
        End Select
    End Sub

    Dim result As Byte
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = 161 And m.WParam = 20 Then
            Me.Close()
        Else
            MyBase.WndProc(m)
        End If
    End Sub
End Class