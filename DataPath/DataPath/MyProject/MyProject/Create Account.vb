Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Username = TextBox1.Text
        My.Settings.Password = TextBox2.Text
        My.Settings.Save()
        MsgBox(" Created Account!", MsgBoxStyle.Information, "Create")
        Me.Hide()
        Login.Show()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Login.Show()

    End Sub
End Class