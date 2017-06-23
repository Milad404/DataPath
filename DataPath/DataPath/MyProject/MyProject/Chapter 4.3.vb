Public Class Form6
    Dim bol1 As Boolean = False
    Dim bol2 As Boolean = True
    Dim bol3 As Boolean = False
    Dim bol4 As Boolean = False
    Dim bol5 As Boolean = False
    Dim bol6 As Boolean = False
    Dim bol7 As Boolean = False
    Dim bol8 As Boolean = False
    Dim bol9 As Boolean = False
    Dim bol10 As Boolean = False
    Dim bol11 As Boolean = False
    Dim bol12 As Boolean = False
    Dim bol13 As Boolean = False
    Dim bol14 As Boolean = False
    Dim bol15 As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If bol1 = True Then

            bol1 = False
            bol2 = True
            PictureBox1.Hide()
            PictureBox2.Show()

        ElseIf bol2 = True Then

            bol2 = False
            bol3 = True
            PictureBox1.Hide()
            PictureBox2.Show()

        ElseIf bol3 = True Then

            bol3 = False
            bol4 = True
            PictureBox2.Hide()
            PictureBox3.Show()

        ElseIf bol4 = True Then

            bol4 = False
            bol5 = True
            PictureBox3.Hide()
            PictureBox4.Show()

        ElseIf bol5 = True Then

            bol5 = False
            bol6 = True
            PictureBox4.Hide()
            PictureBox5.Show()

        ElseIf bol6 = True Then

            bol6 = False
            bol7 = True
            PictureBox5.Hide()
            PictureBox6.Show()

        ElseIf bol7 = True Then

            bol7 = False
            bol8 = True
            PictureBox6.Hide()
            PictureBox7.Show()

        ElseIf bol8 = True Then

            bol8 = False
            bol9 = True
            PictureBox7.Hide()
            PictureBox8.Show()

        ElseIf bol9 = True Then

            bol9 = False
            bol10 = True
            PictureBox8.Hide()
            PictureBox9.Show()

        ElseIf bol10 = True Then

            bol10 = False
            bol11 = True
            PictureBox9.Hide()
            PictureBox10.Show()

        ElseIf bol11 = True Then

            bol11 = False
            bol12 = True
            PictureBox10.Hide()
            PictureBox11.Show()

        ElseIf bol12 = True Then

            bol12 = False
            bol13 = True
            PictureBox11.Hide()
            PictureBox12.Show()
        ElseIf bol13 = True Then

            bol13 = False
            bol14 = True
            PictureBox12.Hide()
            PictureBox13.Show()
        ElseIf bol14 = True Then

            bol14 = False
            bol15 = True
            PictureBox13.Hide()
            PictureBox14.Show()

        ElseIf bol15 = True Then

            PictureBox14.Hide()
            PictureBox15.Show()
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Welcome.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If bol15 = True Then
            bol15 = False
            bol14 = True
            PictureBox14.Show()
            PictureBox15.Hide()

        ElseIf bol14 = True Then

            bol14 = False
            bol13 = True
            PictureBox14.Hide()
            PictureBox13.Show()
        ElseIf bol13 = True Then
            bol13 = False
            bol12 = True
            PictureBox13.Hide()
            PictureBox12.Show()

        ElseIf bol12 = True Then
            bol12 = False
            bol11 = True
            PictureBox12.Hide()
            PictureBox11.Show()

        ElseIf bol11 = True Then
            bol11 = False
            bol10 = True
            PictureBox11.Hide()
            PictureBox10.Show()

        ElseIf bol10 = True Then
            bol10 = False
            bol9 = True
            PictureBox10.Hide()
            PictureBox9.Show()

        ElseIf bol9 = True Then
            bol9 = False
            bol8 = True
            PictureBox9.Hide()
            PictureBox8.Show()

        ElseIf bol8 = True Then
            bol8 = False
            bol7 = True
            PictureBox8.Hide()
            PictureBox7.Show()

        ElseIf bol7 = True Then
            bol7 = False
            bol6 = True
            PictureBox7.Hide()
            PictureBox6.Show()

        ElseIf bol6 = True Then
            bol6 = False
            bol5 = True
            PictureBox6.Hide()
            PictureBox5.Show()

        ElseIf bol5 = True Then
            bol5 = False
            bol4 = True
            PictureBox5.Hide()
            PictureBox4.Show()

        ElseIf bol4 = True Then
            bol4 = False
            bol3 = True
            PictureBox4.Hide()
            PictureBox3.Show()

        ElseIf bol3 = True Then
            bol3 = False
            bol2 = True
            PictureBox3.Hide()
            PictureBox2.Show()
        ElseIf bol2 = True Then
            bol2 = False
            bol1 = True
            PictureBox2.Hide()
            PictureBox1.Show()

        
        End If

    End Sub

 
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub
End Class