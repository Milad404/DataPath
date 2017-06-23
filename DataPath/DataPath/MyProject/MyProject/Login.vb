Public Class Login

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form2.ShowDialog()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = My.Settings.Username And
            TextBox2.Text = My.Settings.Password Then
            Welcome.show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username or Password!", MsgBoxStyle.Information, "Error")


        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()


    End Sub
End Class
