Public Class Branch
    Dim bolFirstStep As Boolean = True
    Dim bolSecondStep As Boolean = False
    Dim bolThirdStep As Boolean = False
    Dim bolForthStep As Boolean = False
    Dim bolFifthStep As Boolean = False
    Dim bolSixththStep As Boolean = False
    Dim bolSeventhStep As Boolean = False
    Dim boleightStep As Boolean = False

    Dim intCount1 As Integer = 0
    Dim intCount2 As Integer = 0
    Dim intCount3 As Integer = 0
    Dim intCount4 As Integer = 0
    Dim intCount5 As Integer = 0
    Dim intCount6 As Integer = 0
    Dim intCount7 As Integer = 0
    Dim intCount8 As Integer = 0
    Dim intAccount As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If bolFirstStep = True Then
            Timer1.Start()
            bolFirstStep = False
            bolSecondStep = True

            Label4.Show()


        ElseIf bolSecondStep = True Then
            RectangleShape4.BorderColor = Color.Silver
            RectangleShape4.BorderWidth = 3
            LinkLabel17.LinkColor = Color.Silver

            Label5.Show()
            Label4.Hide()


            Timer2.Start()
            bolSecondStep = False
            bolThirdStep = True

        ElseIf bolThirdStep = True Then
            RectangleShape3.BorderColor = Color.Silver
            LineShape34.BorderColor = Color.Silver
            LineShape37.BorderColor = Color.Silver
            LineShape39.BorderColor = Color.Silver
            LineShape41.BorderColor = Color.Silver
            LineShape44.BorderColor = Color.Silver
            LineShape46.BorderColor = Color.Silver
            LineShape47.BorderColor = Color.Silver
            LineShape42.BorderColor = Color.Silver
            LineShape45.BorderColor = Color.Silver
            LineShape43.BorderColor = Color.Silver
            LineShape52.BorderColor = Color.Silver
            LinkLabel25.LinkColor = Color.Silver

            RectangleShape3.BorderWidth = 3
            LineShape34.BorderWidth = 3
            LineShape37.BorderWidth = 3
            LineShape39.BorderWidth = 3
            LineShape41.BorderWidth = 3
            LineShape44.BorderWidth = 3
            LineShape46.BorderWidth = 3
            LineShape47.BorderWidth = 3
            LineShape42.BorderWidth = 3
            LineShape45.BorderWidth = 3
            LineShape43.BorderWidth = 3
            LineShape52.BorderWidth = 3

            Label6.Show()
            Label5.Hide()


            Timer3.Start()
            bolThirdStep = False
            bolForthStep = True

        ElseIf bolForthStep = True Then
            LineShape38.BorderColor = Color.Silver
            LineShape68.BorderColor = Color.Silver
            LineShape27.BorderColor = Color.Silver
            LineShape3.BorderColor = Color.Silver
            OvalShape3.BorderColor = Color.Silver
            LinkLabel3.LinkColor = Color.Silver
            LinkLabel23.LinkColor = Color.Silver

            LineShape38.BorderWidth = 3
            LineShape68.BorderWidth = 3
            LineShape27.BorderWidth = 3
            LineShape3.BorderWidth = 3
            OvalShape3.BorderWidth = 3

            Label8.Show()
            Label6.Hide()


            Timer4.Start()
            bolForthStep = False
            bolFifthStep = True

        ElseIf bolFifthStep = True Then
            LineShape28.BorderColor = Color.Silver
            LineShape33.BorderColor = Color.Silver
            LineShape61.BorderColor = Color.Silver
            LineShape62.BorderColor = Color.Silver
            OvalShape5.BorderColor = Color.Silver
            LinkLabel21.LinkColor = Color.Black
            LinkLabel24.LinkColor = Color.Silver
            LinkLabel21.LinkColor = Color.Silver

            LineShape28.BorderWidth = 3
            LineShape33.BorderWidth = 3
            LineShape61.BorderWidth = 3
            LineShape62.BorderWidth = 3
            OvalShape5.BorderWidth = 3

            Label9.Show()
            Label8.Hide()

            Timer5.Start()
            bolFifthStep = False
            bolSixththStep = True

        ElseIf bolSixththStep = True Then
            LineShape49.BorderColor = Color.Silver
            LineShape48.BorderColor = Color.Silver
            LineShape50.BorderColor = Color.Silver
            LineShape54.BorderColor = Color.Silver
            LineShape66.BorderColor = Color.Silver
            LineShape56.BorderColor = Color.Silver
            LineShape57.BorderColor = Color.Silver
            LineShape67.BorderColor = Color.Silver
            LineShape55.BorderColor = Color.Silver
            LineShape53.BorderColor = Color.Silver
            LineShape30.BorderColor = Color.Silver
            LineShape58.BorderColor = Color.Silver
            LineShape63.BorderColor = Color.Silver

            LineShape49.BorderWidth = 3
            LineShape48.BorderWidth = 3
            LineShape50.BorderWidth = 3
            LineShape54.BorderWidth = 3
            LineShape66.BorderWidth = 3
            LineShape56.BorderWidth = 3
            LineShape57.BorderWidth = 3
            LineShape67.BorderWidth = 3
            LineShape55.BorderWidth = 3
            LineShape53.BorderWidth = 3
            LineShape30.BorderWidth = 3
            LineShape58.BorderWidth = 3
            LineShape63.BorderWidth = 3

            Label10.Show()
            Label9.Hide()


            Timer6.Start()
            bolSixththStep = False
            bolSeventhStep = True

        ElseIf bolSeventhStep = True Then
            LineShape99.BorderColor = Color.LightBlue
            LineShape65.BorderColor = Color.LightBlue
            LineShape64.BorderColor = Color.LightBlue
            LineShape51.BorderColor = Color.LightBlue
            OvalShape6.BorderColor = Color.LightBlue
            LineShape69.BorderColor = Color.LightBlue
            OvalShape7.BorderColor = Color.LightBlue
            OvalShape4.BorderColor = Color.Silver
            LinkLabel22.LinkColor = Color.Silver

            LineShape99.BorderWidth = 3
            LineShape65.BorderWidth = 3
            LineShape64.BorderWidth = 3
            LineShape51.BorderWidth = 3
            OvalShape6.BorderWidth = 3
            OvalShape7.BorderWidth = 3
            LineShape69.BorderWidth = 3
            OvalShape4.BorderWidth = 3

            Label11.Show()
            Label10.Hide()


            Timer7.Start()
            bolSeventhStep = False
            boleightStep = True
        ElseIf boleightStep = True Then
            LineShape59.BorderColor = Color.Silver
            LineShape60.BorderColor = Color.Silver
            LineShape40.BorderColor = Color.Silver
            LineShape35.BorderColor = Color.Silver
            LineShape36.BorderColor = Color.Silver

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If intCount1 Mod 2 = 0 Then
            RectangleShape4.BorderColor = Color.Black
            LinkLabel17.LinkColor = Color.Black

        ElseIf intCount1 Mod 2 = 1 Then
            RectangleShape4.BorderColor = Color.Silver
            LinkLabel17.LinkColor = Color.Silver

        End If
        intCount1 = intCount1 + 1
        If intCount1 = 7 Then
            Timer1.Stop()

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If intCount2 Mod 2 = 0 Then
            RectangleShape3.BorderColor = Color.Black
            LineShape34.BorderColor = Color.Black
            LineShape37.BorderColor = Color.Black
            LineShape39.BorderColor = Color.Black
            LineShape41.BorderColor = Color.Black
            LineShape44.BorderColor = Color.Black
            LineShape46.BorderColor = Color.Black
            LineShape47.BorderColor = Color.Black
            LineShape42.BorderColor = Color.Black
            LineShape45.BorderColor = Color.Black
            LineShape43.BorderColor = Color.Black
            LineShape52.BorderColor = Color.Black
            LinkLabel25.LinkColor = Color.Black

        ElseIf intCount2 Mod 2 = 1 Then
            RectangleShape3.BorderColor = Color.Silver
            LineShape34.BorderColor = Color.Silver
            LineShape37.BorderColor = Color.Silver
            LineShape39.BorderColor = Color.Silver
            LineShape41.BorderColor = Color.Silver
            LineShape44.BorderColor = Color.Silver
            LineShape46.BorderColor = Color.Silver
            LineShape47.BorderColor = Color.Silver
            LineShape42.BorderColor = Color.Silver
            LineShape45.BorderColor = Color.Silver
            LineShape43.BorderColor = Color.Silver
            LineShape52.BorderColor = Color.Silver
            LinkLabel25.LinkColor = Color.Silver

        End If

        intCount2 = intCount2 + 1
        If intCount2 = 7 Then
            Timer2.Stop()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If intcount3 Mod 2 = 0 Then
            LineShape38.BorderColor = Color.Black
            LineShape68.BorderColor = Color.Black
            LineShape27.BorderColor = Color.Black
            LineShape3.BorderColor = Color.Black
            OvalShape3.BorderColor = Color.Black
            LinkLabel3.LinkColor = Color.Black
            LinkLabel23.LinkColor = Color.Black

        ElseIf intcount3 Mod 2 = 1 Then
            LineShape38.BorderColor = Color.Silver
            LineShape68.BorderColor = Color.Silver
            LineShape27.BorderColor = Color.Silver
            LineShape3.BorderColor = Color.Silver
            OvalShape3.BorderColor = Color.Silver
            LinkLabel3.LinkColor = Color.Silver
            LinkLabel23.LinkColor = Color.Silver



        End If
        intcount3 = intcount3 + 1
        If intcount3 = 7 Then
            Timer3.Stop()

        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If intCount4 Mod 2 = 0 Then
            LineShape28.BorderColor = Color.Black
            LineShape33.BorderColor = Color.Black
            LineShape61.BorderColor = Color.Black
            LineShape62.BorderColor = Color.Black
            OvalShape5.BorderColor = Color.Black
            LinkLabel21.LinkColor = Color.Black
            LinkLabel24.LinkColor = Color.Black
            LinkLabel21.LinkColor = Color.Black

        ElseIf intCount4 Mod 2 = 1 Then
            LineShape28.BorderColor = Color.Silver
            LineShape33.BorderColor = Color.Silver
            LineShape61.BorderColor = Color.Silver
            LineShape62.BorderColor = Color.Silver
            OvalShape5.BorderColor = Color.Silver
            LinkLabel21.LinkColor = Color.Silver
            LinkLabel21.LinkColor = Color.Silver
        End If

        intCount4 = intCount4 + 1
        If intCount4 = 7 Then
            Timer4.Stop()

        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If intCount5 Mod 2 = 0 Then
            LineShape49.BorderColor = Color.Black
            LineShape48.BorderColor = Color.Black
            LineShape50.BorderColor = Color.Black
            LineShape54.BorderColor = Color.Black
            LineShape66.BorderColor = Color.Black
            LineShape56.BorderColor = Color.Black
            LineShape57.BorderColor = Color.Black
            LineShape67.BorderColor = Color.Black
            LineShape55.BorderColor = Color.Black
            LineShape53.BorderColor = Color.Black
            LineShape30.BorderColor = Color.Black
            LineShape58.BorderColor = Color.Black
            LineShape63.BorderColor = Color.Black


        ElseIf intCount5 Mod 2 = 1 Then
            LineShape49.BorderColor = Color.Silver
            LineShape48.BorderColor = Color.Silver
            LineShape50.BorderColor = Color.Silver
            LineShape54.BorderColor = Color.Silver
            LineShape66.BorderColor = Color.Silver
            LineShape56.BorderColor = Color.Silver
            LineShape57.BorderColor = Color.Silver
            LineShape67.BorderColor = Color.Silver
            LineShape55.BorderColor = Color.Silver
            LineShape53.BorderColor = Color.Silver
            LineShape30.BorderColor = Color.Silver
            LineShape58.BorderColor = Color.Silver
            LineShape63.BorderColor = Color.Silver

        End If
        intCount5 = intCount5 + 1
        If intCount5 = 7 Then
            Timer5.Stop()

        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        If intCount6 Mod 2 = 0 Then
            LineShape99.BorderColor = Color.Black
            LineShape65.BorderColor = Color.Black
            LineShape64.BorderColor = Color.Black
            LineShape51.BorderColor = Color.Black
            OvalShape6.BorderColor = Color.Black
            OvalShape7.BorderColor = Color.Black
            LineShape69.BorderColor = Color.Black

        ElseIf intCount6 Mod 2 = 1 Then
            LineShape99.BorderColor = Color.Silver
            LineShape65.BorderColor = Color.Silver
            LineShape64.BorderColor = Color.Silver
            LineShape51.BorderColor = Color.Silver
            OvalShape6.BorderColor = Color.Silver
            OvalShape7.BorderColor = Color.Silver
            LineShape69.BorderColor = Color.Silver
        End If
        intCount6 = intCount6 + 1
        If intCount6 = 7 Then
            Timer6.Stop()

        End If
    End Sub


    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If intCount7 Mod 2 = 0 Then
            LineShape59.BorderColor = Color.Black
            LineShape60.BorderColor = Color.Black
            LineShape40.BorderColor = Color.Black
            LineShape35.BorderColor = Color.Black
            LineShape36.BorderColor = Color.Black
            OvalShape4.BorderColor = Color.Black
            LinkLabel22.LinkColor = Color.Black

        ElseIf intCount7 Mod 2 = 1 Then
            LineShape59.BorderColor = Color.Silver
            LineShape60.BorderColor = Color.Silver
            LineShape40.BorderColor = Color.Silver
            LineShape35.BorderColor = Color.Silver
            LineShape36.BorderColor = Color.Silver
            OvalShape4.BorderColor = Color.Silver
            LinkLabel22.LinkColor = Color.Silver

            LineShape59.BorderWidth = 3
            LineShape60.BorderWidth = 3
            LineShape40.BorderWidth = 3
            LineShape35.BorderWidth = 3
            LineShape36.BorderWidth = 3

        End If
        intCount7 = intCount7 + 1
        If intCount7 = 6 Then
            Timer7.Stop()

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Welcome.Show()

    End Sub


    Private Sub LinkLabel17_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel17.LinkClicked
        MessageBox.Show(" A program counter is a register in a computer processor that contains the address (location) of the instruction being executed at the current time. As each instruction gets fetched, the program counter increases its stored value by 1")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MessageBox.Show("Sign extension is required for all instructions using the I-format, which includes loads, stores, and branches. The value being extended is the bits in the address field (the least significant 16 bits of the instruction). The output of the sign extension will eventually be input to some type of adder, which needs two 32-bit values as input. For loads and stores, we can have a negative displacement from the register value. For instance, negative displacements are often used when accessing local values from a stack pointer. Backward branches, such as those found in loops, will need a negative displacement from the program counter. ")
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        MessageBox.Show(" Multiplexor: Is a device which steers data lines from multiple sources by choosing from one source and steering the data from that source to its rightful detination")
    End Sub

    Private Sub LinkLabel22_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel22.LinkClicked
        MessageBox.Show(" Multiplexor: Is a device which steers data lines from multiple sources by choosing from one source and steering the data from that source to its rightful detination")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        MessageBox.Show(" Multiplexor: Is a device which steers data lines from multiple sources by choosing from one source and steering the data from that source to its rightful detination")
    End Sub

    Private Sub LinkLabel13_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        MessageBox.Show(" ALU stands for Arithmetic-logical unit, is the part of a computer processor (CPU) that carries out arithmetic and logic operations on the operands in computer instruction words")
    End Sub

    Private Sub LinkLabel12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        MessageBox.Show("A register file is a collection of registers in which any register can be read or written by specifying the number of the register in the file  ")
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Welcome.Show()

    End Sub
End Class