Public Class Form4
    Dim bolFirstStep As Boolean = True
    Dim bolSecondStep As Boolean = False
    Dim bolThirdStep As Boolean = False
    Dim bolForthStep As Boolean = False
    Dim bolFifthStep As Boolean = False
    Dim bolSixththStep As Boolean = False
    Dim bolSeventhStep As Boolean = False

    Dim intCount1 As Integer = 0
    Dim intCount2 As Integer = 0
    Dim intCount3 As Integer = 0
    Dim intCount4 As Integer = 0
    Dim intCount5 As Integer = 0
    Dim intCount6 As Integer = 0
    Dim intAccount As Integer = 1

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If bolFirstStep = True Then
            Timer1.Start()
            bolFirstStep = False
            bolSecondStep = True

            Label18.Show()

        ElseIf bolSecondStep = True Then
            LineShape1.BorderColor = Color.Red
            LineShape1.BorderWidth = 2
            LineShape4.BorderColor = Color.Blue
            LineShape4.BorderWidth = 2

            Timer2.Start()
            bolSecondStep = False
            bolThirdStep = True

            Label19.Show()
            Label18.Hide()

        ElseIf bolThirdStep = True Then
            RectangleShape1.BorderColor = Color.Silver
            RectangleShape1.BorderWidth = 1
            LinkLabel1.LinkColor = Color.Red
            LinkLabel2.LinkColor = Color.Blue

            Label19.Hide()
            Label20.Show()

            Timer3.Start()
            bolThirdStep = False
            bolForthStep = True

        ElseIf bolForthStep = True Then
            LineShape14.BorderColor = Color.Red
            LineShape13.BorderColor = Color.Blue
            LineShape15.BorderColor = Color.Blue
            OvalShape1.BorderColor = Color.Silver
            LinkLabel7.LinkColor = Color.Red
            LinkLabel8.LinkColor = Color.Blue
            LinkLabel4.LinkColor = Color.Silver

            Label20.Hide()
            label21.Show()



            Timer4.Start()
            bolForthStep = False
            bolFifthStep = True

        ElseIf bolFifthStep = True Then
            LineShape2.BorderColor = Color.Silver
            LineShape11.BorderColor = Color.Silver
            LineShape8.BorderColor = Color.Silver
            LineShape9.BorderColor = Color.Silver
            LineShape12.BorderColor = Color.Silver
            LineShape10.BorderColor = Color.Silver
            LineShape7.BorderColor = Color.Silver
            LinkLabel13.LinkColor = Color.Blue

            Label21.Hide()
            Label22.Show()

            Timer5.Start()
            bolFifthStep = False
            bolSixththStep = True

        ElseIf bolSixththStep = True Then
            LineShape16.BorderColor = Color.Green
            LineShape19.BorderColor = Color.Green
            LineShape20.BorderColor = Color.Green
            LineShape21.BorderColor = Color.Green
            LineShape18.BorderColor = Color.Green
            OvalShape2.BorderColor = Color.Silver
            LinkLabel5.LinkColor = Color.Silver

            Label22.Hide()
            label23.show()

            Timer6.Start()
            bolSixththStep = False
            bolSeventhStep = True

      

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If intCount1 Mod 2 = 0 Then
            LineShape1.BorderColor = Color.Black
            LineShape1.BorderWidth = 2
            LineShape4.BorderColor = Color.Black
            LineShape4.BorderWidth = 2

        ElseIf intCount1 Mod 2 = 1 Then
            LineShape1.BorderColor = Color.Silver
            LineShape1.BorderWidth = 1
            LineShape4.BorderColor = Color.Silver
            LineShape4.BorderWidth = 1

        End If

        intCount1 = intCount1 + 1
        If intCount1 = 7 Then
            Timer1.Stop()

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If intCount2 Mod 2 = 0 Then
            RectangleShape1.BorderColor = Color.Black
            LinkLabel1.LinkColor = Color.Black
            LinkLabel2.LinkColor = Color.Black

        ElseIf intCount2 Mod 2 = 1 Then
            RectangleShape1.BorderColor = Color.Silver
            LinkLabel1.LinkColor = Color.Silver
            LinkLabel2.LinkColor = Color.Silver

        End If

        intCount2 = intCount2 + 1
        If intCount2 = 7 Then
            Timer2.Stop()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If intcount3 Mod 2 = 0 Then
            LineShape14.BorderColor = Color.Black
            LineShape13.BorderColor = Color.Black
            LineShape15.BorderColor = Color.Black
            OvalShape1.BorderColor = Color.Black
            LinkLabel7.LinkColor = Color.Black
            LinkLabel8.LinkColor = Color.Black
            LinkLabel4.LinkColor = Color.Black

        ElseIf intcount3 Mod 2 = 1 Then
            LineShape14.BorderColor = Color.Silver
            LineShape13.BorderColor = Color.Silver
            LineShape15.BorderColor = Color.Silver
            OvalShape1.BorderColor = Color.Silver
            LinkLabel4.LinkColor = Color.Silver
            LinkLabel7.LinkColor = Color.Silver
            LinkLabel8.LinkColor = Color.Silver

        End If
        intcount3 = intcount3 + 1
        If intcount3 = 7 Then
            Timer3.Stop()

        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If intCount4 Mod 2 = 0 Then
            LineShape2.BorderColor = Color.Black
            LineShape11.BorderColor = Color.Black
            LineShape8.BorderColor = Color.Black
            LineShape9.BorderColor = Color.Black
            LineShape12.BorderColor = Color.Black
            LineShape10.BorderColor = Color.Black
            LineShape7.BorderColor = Color.Black
            LinkLabel13.LinkColor = Color.Black

        ElseIf intCount4 Mod 2 = 1 Then
            LineShape2.BorderColor = Color.Silver
            LineShape11.BorderColor = Color.Silver
            LineShape8.BorderColor = Color.Silver
            LineShape9.BorderColor = Color.Silver
            LineShape12.BorderColor = Color.Silver
            LineShape10.BorderColor = Color.Silver
            LineShape7.BorderColor = Color.Silver
            LinkLabel13.LinkColor = Color.Silver

        End If

        intCount4 = intCount4 + 1
        If intCount4 = 7 Then
            Timer4.Stop()

        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If intCount5 Mod 2 = 0 Then
            LineShape16.BorderColor = Color.Black
            LineShape19.BorderColor = Color.Black
            LineShape20.BorderColor = Color.Black
            LineShape21.BorderColor = Color.Black
            LineShape18.BorderColor = Color.Black
            OvalShape2.BorderColor = Color.Black
            LinkLabel5.LinkColor = Color.Black

        ElseIf intCount5 Mod 2 = 1 Then
            LineShape16.BorderColor = Color.Silver
            LineShape19.BorderColor = Color.Silver
            LineShape20.BorderColor = Color.Silver
            LineShape21.BorderColor = Color.Silver
            LineShape18.BorderColor = Color.Silver
            OvalShape2.BorderColor = Color.Silver
            LinkLabel5.LinkColor = Color.Silver

        End If

        intCount5 = intCount5 + 1
        If intCount5 = 7 Then
            Timer5.Stop()

        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        If intCount6 Mod 2 = 0 Then
            LineShape22.BorderColor = Color.Black
            LineShape23.BorderColor = Color.Black
            LineShape24.BorderColor = Color.Black
            LineShape25.BorderColor = Color.Black
            LineShape6.BorderColor = Color.Black
            LinkLabel16.LinkColor = Color.Black



        ElseIf intCount6 Mod 2 = 1 Then
            LineShape22.BorderColor = Color.Silver
            LineShape23.BorderColor = Color.Silver
            LineShape24.BorderColor = Color.Silver
            LineShape25.BorderColor = Color.Silver
            LineShape6.BorderColor = Color.Silver
            LinkLabel16.LinkColor = Color.Black

            LineShape22.BorderColor = Color.Teal
            LineShape23.BorderColor = Color.Teal
            LineShape24.BorderColor = Color.Teal
            LineShape25.BorderColor = Color.Teal
            LineShape6.BorderColor = Color.Teal

        End If
        intCount6 = intCount6 + 1
        If intCount6 = 6 Then
            Timer6.Stop()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If intAccount = 1 Then
            Label2.Show()
            Label5.Show()

            intAccount = intAccount + 1

        ElseIf intAccount = 2 Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MessageBox.Show("Please Input a number for  $t1 and $t2")
            Else
                Dim dblInput1 As Double = CDbl(TextBox1.Text)
                Dim dblInput2 As Double = CDbl(TextBox2.Text)
                Dim dblinput3 As Double = dblInput1 + dblInput2

                Label3.Text = dblInput2.ToString
                Label4.Text = dblInput1.ToString
                Label13.Text = dblInput2.ToString

                Label3.Show()
                Label4.Show()
                Label13.Show()

                intAccount = intAccount + 1

            End If

        ElseIf intAccount = 3 Then
            Dim dblInput1 As Double = CDbl(TextBox1.Text)
            Dim dblInput2 As Double = CDbl(TextBox2.Text)
            Dim dblinput3 As Double = dblInput1 + dblInput2

            Label15.Text = dblinput3.ToString
            Label14.Text = dblInput1.ToString & "+" & dblInput2.ToString & "=" & dblinput3.ToString
            TextBox3.Text = dblinput3.ToString

            Label14.Show()
            Label15.Show()

            intAccount = intAccount + 1
        ElseIf intAccount = 4 Then
            Dim dblInput1 As Double = CDbl(TextBox1.Text)
            Dim dblInput2 As Double = CDbl(TextBox2.Text)
            Dim dblinput3 As Double = dblInput1 + dblInput2

            Label17.Text = dblinput3.ToString
            Label17.Show()

            intAccount = intAccount + 1

        ElseIf intAccount = 5 Then
            Dim dblInput1 As Double = CDbl(TextBox1.Text)
            Dim dblInput2 As Double = CDbl(TextBox2.Text)
            Dim dblinput3 As Double = dblInput1 + dblInput2

            Label16.Text = dblinput3.ToString
            Label16.Show()

            End If
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked, LinkLabel5.LinkClicked
        MessageBox.Show(" Multiplexor: Is a device which steers data lines from multiple sources by choosing from one source and steering the data from that source to its rightful detination")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MessageBox.Show("Sign extension is required for all instructions using the I-format, which includes loads, stores, and branches. The value being extended is the bits in the address field (the least significant 16 bits of the instruction). The output of the sign extension will eventually be input to some type of adder, which needs two 32-bit values as input. For loads and stores, we can have a negative displacement from the register value. For instance, negative displacements are often used when accessing local values from a stack pointer. Backward branches, such as those found in loops, will need a negative displacement from the program counter. ")
    End Sub

    Private Sub LinkLabel12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        MessageBox.Show("A register file is a collection of registers in which any register can be read or written by specifying the number of the register in the file  ")

    End Sub

    Private Sub LinkLabel13_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        MessageBox.Show(" ALU stands for Arithmetic-logical unit, is the part of a computer processor (CPU) that carries out arithmetic and logic operations on the operands in computer instruction words")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Welcome.Show()

    End Sub

    Private Sub LinkLabel17_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)


    End Sub

    Private Sub LinkLabel18_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        MessageBox.Show(" The instruction memory need only provide read access because the datapath does not write instructions")

    End Sub

    Private Sub LinkLabel20_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        MessageBox.Show("")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Welcome.Show()

    End Sub
End Class




















