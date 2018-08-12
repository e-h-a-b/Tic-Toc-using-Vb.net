Imports System.Speech.Recognition     ' Add reference Assemblies Framework System.Speech
Imports System.Security.Permissions
Imports System.IO

Public Class TicToc
    Dim sapi = CreateObject("sapi.spvoice")
    Dim play As Boolean = False
    Dim tellbot As Boolean = False
    Function additem()
        Dim sett As String
        sett = Button1.Text & " " & Button2.Text & " " & Button3.Text & " " & Button4.Text & " " & Button5.Text & " " & Button6.Text & " " & Button7.Text & " " & Button8.Text & " " & Button9.Text
        Return sett
    End Function
    Sub disable(ByVal st As Boolean)
        Button1.Enabled = st
        Button2.Enabled = st
        Button3.Enabled = st
        Button4.Enabled = st
        Button5.Enabled = st
        Button6.Enabled = st
        Button7.Enabled = st
        Button8.Enabled = st
        Button9.Enabled = st
        tellbot = True
    End Sub
    Sub reset()
        Button1.Text = "0" : Button2.Text = "0" : Button3.Text = "0" : Button4.Text = "0" : Button5.Text = "0" : Button6.Text = "0" : Button7.Text = "0" : Button8.Text = "0" : Button9.Text = "0"
        Button1.BackColor = Color.Gainsboro : Button2.BackColor = Color.Gainsboro : Button3.BackColor = Color.Gainsboro
        : Button4.BackColor = Color.Gainsboro : Button5.BackColor = Color.Gainsboro : Button6.BackColor = Color.Gainsboro
        : Button7.BackColor = Color.Gainsboro : Button8.BackColor = Color.Gainsboro : Button9.BackColor = Color.Gainsboro
        disable(True)
        tellbot = False
        play = False
        ListBox1.Items.Clear()
        Label1.Text = "Status :"
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        tes = False
    End Sub
    Sub check()
        'won
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then Label1.Text = Label1.Text + "won" : disable(False) : sapi.Speak("good") : Label4.Text = Label4.Text + 1 : ListBox1.Items.Add(additem() & " Winner") '------' 
        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then Label1.Text = Label1.Text + "won" : disable(False) : sapi.Speak("good") : Label4.Text = Label4.Text + 1 : ListBox1.Items.Add(additem() & " Winner") '------'
        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then Label1.Text = Label1.Text + "won" : disable(False) : sapi.Speak("good") : Label4.Text = Label4.Text + 1 : ListBox1.Items.Add(additem() & " Winner") '------'

        If Button1.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then Label1.Text = Label1.Text + "won" : disable(False) : sapi.Speak("Funny game") : Label4.Text = Label4.Text + 1 : ListBox1.Items.Add(additem() & " Winner") ' \ '
        If Button3.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then Label1.Text = Label1.Text + "won" : disable(False) : sapi.Speak("Funny game") : Label4.Text = Label4.Text + 1 : ListBox1.Items.Add(additem() & " Winner") ' / '

        If Button1.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then Label1.Text = Label1.Text + "won" : disable(False) : sapi.Speak("good game") : Label4.Text = Label4.Text + 1 : ListBox1.Items.Add(additem() & " Winner") ' | '
        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then Label1.Text = Label1.Text + "won" : disable(False) : sapi.Speak("good game") : Label4.Text = Label4.Text + 1 : ListBox1.Items.Add(additem() & " Winner") ' | '
        If Button3.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then Label1.Text = Label1.Text + "won" : disable(False) : sapi.Speak("good game") : Label4.Text = Label4.Text + 1 : ListBox1.Items.Add(additem() & " Winner") ' | '

        'looser
        If Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then Label1.Text = Label1.Text + "Lose" : disable(False) : sapi.Speak("Bad should learn") : Label5.Text = Label5.Text + 1 : ListBox1.Items.Add(additem() & " Loser") '------' 
        If Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then Label1.Text = Label1.Text + "Lose" : disable(False) : sapi.Speak("Bad should learn") : Label5.Text = Label5.Text + 1 : ListBox1.Items.Add(additem() & " Loser") '------'
        If Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then Label1.Text = Label1.Text + "Lose" : disable(False) : sapi.Speak("Bad should learn") : Label5.Text = Label5.Text + 1 : ListBox1.Items.Add(additem() & " Loser") '------'

        If Button1.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then Label1.Text = Label1.Text + "Lose" : disable(False) : sapi.Speak("Funny learn then play") : Label5.Text = Label5.Text + 1 : ListBox1.Items.Add(additem() & " Loser") ' \ '
        If Button3.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then Label1.Text = Label1.Text + "Lose" : disable(False) : sapi.Speak("Funny learn then play") : Label5.Text = Label5.Text + 1 : ListBox1.Items.Add(additem() & " Loser") ' / '

        If Button1.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then Label1.Text = Label1.Text + "Lose" : disable(False) : sapi.Speak("Looser") : Label5.Text = Label5.Text + 1 : ListBox1.Items.Add(additem() & " Loser") ' | '
        If Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then Label1.Text = Label1.Text + "Lose" : disable(False) : sapi.Speak("Looser") : Label5.Text = Label5.Text + 1 : ListBox1.Items.Add(additem() & " Loser") ' | '
        If Button3.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then Label1.Text = Label1.Text + "Lose" : disable(False) : sapi.Speak("Looser") : Label5.Text = Label5.Text + 1 : ListBox1.Items.Add(additem() & " Loser") ' | '

    End Sub
    Sub define()

        Dim nm As Integer = 0
        Dim dfnm As String
        If Button1.Text = "0" Then dfnm = dfnm & "1" : nm = nm + 1
        If Button2.Text = "0" Then dfnm = dfnm & "2" : nm = nm + 1
        If Button3.Text = "0" Then dfnm = dfnm & "3" : nm = nm + 1
        If Button4.Text = "0" Then dfnm = dfnm & "4" : nm = nm + 1
        If Button5.Text = "0" Then dfnm = dfnm & "5" : nm = nm + 1
        If Button6.Text = "0" Then dfnm = dfnm & "6" : nm = nm + 1
        If Button7.Text = "0" Then dfnm = dfnm & "7" : nm = nm + 1
        If Button8.Text = "0" Then dfnm = dfnm & "8" : nm = nm + 1
        If Button9.Text = "0" Then dfnm = dfnm & "9" : nm = nm + 1

        Dim randoms(nm) As String
        For i = 0 To randoms.Length - 1
            If randoms.Length - 1 = 0 Then
            Else
                Dim chars = dfnm
                Dim random = New Random(Guid.NewGuid().GetHashCode())
                Dim randomString = New String(Enumerable.Repeat(chars, 1).[Select](Function(s) s(random.[Next](s.Length))).ToArray())
                randoms(i) = randomString
                If tellbot = True Then
                Else
                    generate()
                    If tes = True Then
                        computerplay(randoms(i))


                    End If


                End If
            End If

        Next

    End Sub
    Dim tes As Boolean = False
    Sub generate()
        '1
        If Button1.Text <> "X" And Button2.Text <> "X" Then tes = True '------' 
        If Button3.Text <> "X" And Button2.Text <> "X" Then tes = True '------' 
        If Button1.Text <> "X" And Button3.Text <> "X" Then tes = True '------' 
        '2
        If Button4.Text <> "X" And Button5.Text <> "X" Then tes = True '------'
        If Button6.Text <> "X" And Button5.Text <> "X" Then tes = True '------'
        If Button4.Text <> "X" And Button6.Text <> "X" Then tes = True '------'
        '3
        If Button7.Text <> "X" And Button8.Text <> "X" Then tes = True '------'
        If Button9.Text <> "X" And Button8.Text <> "X" Then tes = True '------'
        If Button7.Text <> "X" And Button9.Text <> "X" Then tes = True '------'
        '4
        If Button1.Text <> "X" And Button5.Text <> "X" Then tes = True ' \ '
        If Button7.Text <> "X" And Button5.Text <> "X" Then tes = True ' \ '
        If Button1.Text <> "X" And Button7.Text <> "X" Then tes = True ' \ '
        '5
        If Button3.Text <> "X" And Button5.Text <> "X" Then tes = True ' / '
        If Button9.Text <> "X" And Button5.Text <> "X" Then tes = True ' / '
        If Button3.Text <> "X" And Button9.Text <> "X" Then tes = True ' / '
        '6
        If Button1.Text <> "X" And Button6.Text <> "X" Then tes = True ' | '
        If Button9.Text <> "X" And Button6.Text <> "X" Then tes = True ' | '
        If Button1.Text <> "X" And Button9.Text <> "X" Then tes = True ' | '
        '7
        If Button2.Text <> "X" And Button5.Text <> "X" Then tes = True ' | '
        If Button8.Text <> "X" And Button5.Text <> "X" Then tes = True ' | '
        If Button2.Text <> "X" And Button8.Text <> "X" Then tes = True ' | '
        '8
        If Button3.Text <> "X" And Button4.Text <> "X" Then tes = True ' | '
        If Button7.Text <> "X" And Button4.Text <> "X" Then tes = True ' | '
        If Button3.Text <> "X" And Button7.Text <> "X" Then tes = True ' | '
    End Sub
    Sub stratgy()

        For m = 0 To ListBox1.Items.Count - 1
            Dim strSplit() As String
            Dim cont As Integer
            strSplit = TextBox1.Text.Split(CChar(" "))
            For i As Integer = 0 To strSplit.Length - 1
                'X 0 0 0 X 0 X O O
                '0 0 X O X O 0 0 X

                'X X X O 0 O 0 0 0
                '0 0 O X X X 0 O 0
                '0 0 0 O O 0 X X X

                'X 0 O O 0 X 0 0 X
                'O X O 0 X 0 0 X 0
                '0 0 X X O 0 X O 0
                '*****************
                'computer play won
                Dim df1 = "O 0 0 0 O 0 O X X"
                Dim df2 = "0 0 O X O X 0 0 O"

                Dim df3 = "O O O X 0 X 0 0 0"
                Dim df4 = "0 0 X O O O 0 X 0"
                Dim df5 = "0 0 0 X X 0 O O O"

                Dim df6 = "O 0 X X 0 O 0 0 O"
                Dim df7 = "X O X 0 O 0 0 O 0"
                Dim df8 = "0 0 O O X 0 O X 0"
                If strSplit.GetValue(i) = "X" Then
                    cont = cont + 1
                End If

            Next
        Next
    End Sub
    Sub analysis()


        Dim strSplit() As String
        Dim cont As Integer
        Dim i As Integer
        Dim item(ListBox1.SelectedItems.Count - 1) As String

        For i = 0 To ListBox1.SelectedItems.Count - 1

            TextBox1.Text = ListBox1.SelectedItem(i).ToString()
            strSplit = TextBox1.Text.Split(CChar(" "))
            For s As Integer = 0 To strSplit.Length - 1

                If strSplit.GetValue(s) = "X" Then
                    sapi.speak("good")
                    cont = cont + 1
                End If

            Next
            i += 1
        Next
        define()
        'If cont = 1 Then
        '    sapi.Speak("i think its my game")
        'ElseIf cont = 2 Then
        '    sapi.Speak("its my game")
        'ElseIf cont = 3 Then
        '    sapi.Speak("I am not silly")
        'End If

    End Sub
    Sub think()
        '1
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text <> "X" And Button3.Text <> "O" Then Button3.Text = "O" : Button3.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False '------' 
        If Button3.Text = "X" And Button2.Text = "X" And Button1.Text <> "X" And Button1.Text <> "O" Then Button1.Text = "O" : Button1.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False '------'  1
        If Button1.Text = "X" And Button3.Text = "X" And Button2.Text <> "X" And Button2.Text <> "O" Then Button2.Text = "O" : Button2.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False '------' 
        '2
        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text <> "X" And Button6.Text <> "O" Then Button6.Text = "O" : Button6.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False '------'
        If Button6.Text = "X" And Button5.Text = "X" And Button4.Text <> "X" And Button4.Text <> "O" Then Button4.Text = "O" : Button4.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False '------'
        If Button4.Text = "X" And Button6.Text = "X" And Button5.Text <> "X" And Button5.Text <> "O" Then Button5.Text = "O" : Button5.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False '------'
        '3
        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text <> "X" And Button9.Text <> "O" Then Button9.Text = "O" : Button9.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False '------'
        If Button9.Text = "X" And Button8.Text = "X" And Button7.Text <> "X" And Button7.Text <> "O" Then Button7.Text = "O" : Button7.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False '------'
        If Button7.Text = "X" And Button9.Text = "X" And Button8.Text <> "X" And Button8.Text <> "O" Then Button8.Text = "O" : Button8.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False '------'
        '4
        If Button1.Text = "X" And Button5.Text = "X" And Button7.Text <> "X" And Button7.Text <> "O" Then Button7.Text = "O" : Button7.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False ' \ '
        If Button7.Text = "X" And Button5.Text = "X" And Button1.Text <> "X" And Button1.Text <> "O" Then Button1.Text = "O" : Button1.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False ' \ '       1
        If Button1.Text = "X" And Button7.Text = "X" And Button5.Text <> "X" And Button5.Text <> "O" Then Button5.Text = "O" : Button5.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False ' \ '
        '5
        If Button3.Text = "X" And Button5.Text = "X" And Button9.Text <> "X" And Button9.Text <> "O" Then Button9.Text = "O" : Button9.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False ' / '
        If Button9.Text = "X" And Button5.Text = "X" And Button3.Text <> "X" And Button3.Text <> "O" Then Button3.Text = "O" : Button3.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False ' / '
        If Button3.Text = "X" And Button9.Text = "X" And Button5.Text <> "X" And Button5.Text <> "O" Then Button5.Text = "O" : Button5.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False ' / '
        '6
        If Button1.Text = "X" And Button6.Text = "X" And Button9.Text <> "X" And Button9.Text <> "O" Then Button9.Text = "O" : Button9.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False ' | '
        If Button9.Text = "X" And Button6.Text = "X" And Button1.Text <> "X" And Button1.Text <> "O" Then Button1.Text = "O" : Button1.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False ' | '       1
        If Button1.Text = "X" And Button9.Text = "X" And Button6.Text <> "X" And Button6.Text <> "O" Then Button6.Text = "O" : Button6.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False ' | '       6
        '7
        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text <> "X" And Button8.Text <> "O" Then Button8.Text = "O" : Button8.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False ' | '
        If Button8.Text = "X" And Button5.Text = "X" And Button2.Text <> "X" And Button2.Text <> "O" Then Button2.Text = "O" : Button2.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False ' | '
        If Button2.Text = "X" And Button8.Text = "X" And Button5.Text <> "X" And Button5.Text <> "O" Then Button5.Text = "O" : Button5.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False ' | '
        '8
        If Button3.Text = "X" And Button4.Text = "X" And Button7.Text <> "X" And Button7.Text <> "O" Then Button7.Text = "O" : Button7.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False ' | '
        If Button7.Text = "X" And Button4.Text = "X" And Button3.Text <> "X" And Button3.Text <> "O" Then Button3.Text = "O" : Button3.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False ' | '
        If Button3.Text = "X" And Button7.Text = "X" And Button4.Text <> "X" And Button4.Text <> "O" Then Button4.Text = "O" : Button4.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False ' | '
        check()
    End Sub
    Sub computerplay(ByVal st As Integer)
        If CheckBox1.Checked Then
            think()
            CheckBox1.Text = "Thinking"
        Else
            CheckBox1.Text = "Not Thinking"
        End If

        RadioButton1.Checked = False
        If play = True Then
            If Button1.Text = "0" And st = 1 Then Button1.Text = "O" : Button1.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False
            If Button2.Text = "0" And st = 2 Then Button2.Text = "O" : Button2.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False
            If Button3.Text = "0" And st = 3 Then Button3.Text = "O" : Button3.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False
            If Button4.Text = "0" And st = 4 Then Button4.Text = "O" : Button4.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False
            If Button5.Text = "0" And st = 5 Then Button5.Text = "O" : Button5.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False
            If Button6.Text = "0" And st = 6 Then Button6.Text = "O" : Button6.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False
            If Button7.Text = "0" And st = 7 Then Button7.Text = "O" : Button7.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False
            If Button8.Text = "0" And st = 8 Then Button8.Text = "O" : Button8.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False
            If Button9.Text = "0" And st = 9 Then Button9.Text = "O" : Button9.BackColor = Color.Yellow : ListBox1.Items.Add(additem()) : play = False

            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            TextBox1.Text = ListBox1.SelectedItem.ToString
            check()
            If RadioButton1.Checked = True Then

            Else
                define()
            End If

            RadioButton1.Enabled = False
            RadioButton2.Enabled = False

        End If
    End Sub
    Sub checkplay(ByVal st As Integer)

        If play = False Then
            If Button1.Text = "0" And st = 1 Then Button1.Text = "X" : Button1.BackColor = Color.Green : ListBox1.Items.Add(additem()) : play = True
            If Button2.Text = "0" And st = 2 Then Button2.Text = "X" : Button2.BackColor = Color.Green : ListBox1.Items.Add(additem()) : play = True
            If Button3.Text = "0" And st = 3 Then Button3.Text = "X" : Button3.BackColor = Color.Green : ListBox1.Items.Add(additem()) : play = True
            If Button4.Text = "0" And st = 4 Then Button4.Text = "X" : Button4.BackColor = Color.Green : ListBox1.Items.Add(additem()) : play = True
            If Button5.Text = "0" And st = 5 Then Button5.Text = "X" : Button5.BackColor = Color.Green : ListBox1.Items.Add(additem()) : play = True
            If Button6.Text = "0" And st = 6 Then Button6.Text = "X" : Button6.BackColor = Color.Green : ListBox1.Items.Add(additem()) : play = True
            If Button7.Text = "0" And st = 7 Then Button7.Text = "X" : Button7.BackColor = Color.Green : ListBox1.Items.Add(additem()) : play = True
            If Button8.Text = "0" And st = 8 Then Button8.Text = "X" : Button8.BackColor = Color.Green : ListBox1.Items.Add(additem()) : play = True
            If Button9.Text = "0" And st = 9 Then Button9.Text = "X" : Button9.BackColor = Color.Green : ListBox1.Items.Add(additem()) : play = True
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            TextBox1.Text = ListBox1.SelectedItem.ToString
            check()
            define()

            RadioButton1.Enabled = False
            RadioButton2.Enabled = False

        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "X" Or Button1.Text = "O" Then

        Else
            checkplay(1)
        End If

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "X" Or Button2.Text = "O" Then

        Else
            checkplay(2)
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "X" Or Button3.Text = "O" Then

        Else
            checkplay(3)
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "X" Or Button4.Text = "O" Then

        Else
            checkplay(4)
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Button5.Text = "X" Or Button5.Text = "O" Then

        Else
            checkplay(5)
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Button6.Text = "X" Or Button6.Text = "O" Then

        Else
            checkplay(6)
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Button7.Text = "X" Or Button7.Text = "O" Then

        Else
            checkplay(7)
        End If
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Button8.Text = "X" Or Button8.Text = "O" Then

        Else
            checkplay(8)
        End If
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Button9.Text = "X" Or Button9.Text = "O" Then

        Else
            checkplay(9)
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        reset()
        If RadioButton1.Checked = True Then
            play = True
            Dim r As Random = New Random
            computerplay(r.Next(1, 9))
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        play = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        play = True
        Dim r As Random = New Random
        computerplay(r.Next(1, 9))
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        analysis()
    End Sub

End Class