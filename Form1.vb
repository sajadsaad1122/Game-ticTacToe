Public Class tictac
    Dim checker As Boolean
    Dim plusone As Integer
    Public Sub enable_false()
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
    End Sub
    Private Sub tictac_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub score()
        '1
        If (btn1.Text = "x" And btn2.Text = "x" And btn3.Text = "x") Then
            btn1.BackColor = Color.PowderBlue
            btn2.BackColor = Color.PowderBlue
            btn3.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is player x ", "TicTacToe")
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        '2
        If (btn1.Text = "x" And btn4.Text = "x" And btn7.Text = "x") Then
            btn1.BackColor = Color.Purple
            btn4.BackColor = Color.Purple
            btn7.BackColor = Color.Purple
            MessageBox.Show("The winner is player x ", "TicTacToe")
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        '3
        If (btn7.Text = "x" And btn8.Text = "x" And btn9.Text = "x") Then
            btn7.BackColor = Color.AliceBlue
            btn8.BackColor = Color.AliceBlue
            btn9.BackColor = Color.AliceBlue
            MessageBox.Show("The winner is player x ", "TicTacToe")
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        '4
        If (btn9.Text = "x" And btn6.Text = "x" And btn3.Text = "x") Then
            btn9.BackColor = Color.HotPink
            btn6.BackColor = Color.HotPink
            btn3.BackColor = Color.HotPink
            MessageBox.Show("The winner is player x ", "TicTacToe")
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        '5
        If (btn2.Text = "x" And btn5.Text = "x" And btn8.Text = "x") Then
            btn2.BackColor = Color.Gold
            btn5.BackColor = Color.Gold
            btn8.BackColor = Color.Gold
            MessageBox.Show("The winner is player x ", "TicTacToe")
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        '6
        If (btn4.Text = "x" And btn5.Text = "x" And btn6.Text = "x") Then
            btn4.BackColor = Color.Cyan
            btn5.BackColor = Color.Cyan
            btn6.BackColor = Color.Cyan
            MessageBox.Show("The winner is player x ", "TicTacToe")
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        '7
        If (btn1.Text = "x" And btn5.Text = "x" And btn9.Text = "x") Then
            btn1.BackColor = Color.Crimson
            btn5.BackColor = Color.Crimson
            btn9.BackColor = Color.Crimson
            MessageBox.Show("The winner is player x ", "TicTacToe")
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        '8
        If (btn3.Text = "x" And btn5.Text = "x" And btn7.Text = "x") Then
            btn3.BackColor = Color.Coral
            btn5.BackColor = Color.Coral
            btn7.BackColor = Color.Coral
            MessageBox.Show("The winner is player x ", "TicTacToe")
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        '==================================
        '1
        If (btn1.Text = "o" And btn2.Text = "o" And btn3.Text = "o") Then
            btn1.BackColor = Color.PowderBlue
            btn2.BackColor = Color.PowderBlue
            btn3.BackColor = Color.PowderBlue
            MessageBox.Show("The winner is player o ", "TicTacToe")
            plusone = Convert.ToInt64(Label5.Text)
            Label5.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        '2
        If (btn1.Text = "o" And btn4.Text = "o" And btn7.Text = "o") Then
            btn1.BackColor = Color.Purple
            btn4.BackColor = Color.Purple
            btn7.BackColor = Color.Purple
            MessageBox.Show("The winner is player o ", "TicTacToe")
            plusone = Convert.ToInt64(Label5.Text)
            Label5.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        '3
        If (btn7.Text = "o" And btn8.Text = "o" And btn9.Text = "o") Then
            btn7.BackColor = Color.AliceBlue
            btn8.BackColor = Color.AliceBlue
            btn9.BackColor = Color.AliceBlue
            MessageBox.Show("The winner is player o ", "TicTacToe")
            plusone = Convert.ToInt64(Label5.Text)
            Label5.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        '4
        If (btn9.Text = "o" And btn6.Text = "o" And btn3.Text = "o") Then
            btn9.BackColor = Color.HotPink
            btn6.BackColor = Color.HotPink
            btn3.BackColor = Color.HotPink
            MessageBox.Show("The winner is player o ", "TicTacToe")
            plusone = Convert.ToInt64(Label5.Text)
            Label5.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        '5
        If (btn2.Text = "o" And btn5.Text = "o" And btn8.Text = "o") Then
            btn2.BackColor = Color.Gold
            btn5.BackColor = Color.Gold
            btn8.BackColor = Color.Gold
            MessageBox.Show("The winner is player o ", "TicTacToe")
            plusone = Convert.ToInt64(Label5.Text)
            Label5.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        '6
        If (btn4.Text = "o" And btn5.Text = "o" And btn6.Text = "o") Then
            btn4.BackColor = Color.Cyan
            btn5.BackColor = Color.Cyan
            btn6.BackColor = Color.Cyan
            MessageBox.Show("The winner is player o", "TicTacToe")
            plusone = Convert.ToInt64(Label5.Text)
            Label5.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        '7
        If (btn1.Text = "o" And btn5.Text = "o" And btn9.Text = "o") Then
            btn1.BackColor = Color.Crimson
            btn5.BackColor = Color.Crimson
            btn9.BackColor = Color.Crimson
            MessageBox.Show("The winner is player o ", "TicTacToe")
            plusone = Convert.ToInt64(Label5.Text)
            Label5.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        '8
        If (btn3.Text = "o" And btn5.Text = "o" And btn7.Text = "o") Then
            btn3.BackColor = Color.Coral
            btn5.BackColor = Color.Coral
            btn7.BackColor = Color.Coral
            MessageBox.Show("The winner is player o ", "TicTacToe")
            plusone = Convert.ToInt64(Label5.Text)
            Label5.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If checker = False Then
            btn1.Text = "x"
            checker = True
        Else
            btn1.Text = "o"
            checker = False

        End If
        score()
        btn1.Enabled = False
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If checker = False Then
            btn2.Text = "x"
            checker = True
        Else
            btn2.Text = "o"
            checker = False

        End If
        score()
        btn2.Enabled = False
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If checker = False Then
            btn3.Text = "x"
            checker = True
        Else
            btn3.Text = "o"
            checker = False

        End If
        score()
        btn3.Enabled = False
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If checker = False Then
            btn4.Text = "x"
            checker = True
        Else
            btn4.Text = "o"
            checker = False

        End If
        score()
        btn4.Enabled = False
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If checker = False Then
            btn5.Text = "x"
            checker = True
        Else
            btn5.Text = "o"
            checker = False

        End If
        score()
        btn5.Enabled = False
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If checker = False Then
            btn6.Text = "x"
            checker = True
        Else
            btn6.Text = "o"
            checker = False

        End If
        score()
        btn6.Enabled = False
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If checker = False Then
            btn7.Text = "x"
            checker = True
        Else
            btn7.Text = "o"
            checker = False

        End If
        score()
        btn7.Enabled = False
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If checker = False Then
            btn8.Text = "x"
            checker = True
        Else
            btn8.Text = "o"
            checker = False

        End If
        score()
        btn8.Enabled = False
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If checker = False Then
            btn9.Text = "x"
            checker = True
        Else
            btn9.Text = "o"
            checker = False

        End If
        score()
        btn9.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True

        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
        Label4.Text = "0"
        Label5.Text = "0"
        btn1.BackColor = Color.White
        btn2.BackColor = Color.White
        btn3.BackColor = Color.White
        btn4.BackColor = Color.White
        btn5.BackColor = Color.White
        btn6.BackColor = Color.White
        btn7.BackColor = Color.White
        btn8.BackColor = Color.White
        btn9.BackColor = Color.White

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True

        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
        Button1.Enabled = True

        btn1.BackColor = Color.White
        btn2.BackColor = Color.White
        btn3.BackColor = Color.White
        btn4.BackColor = Color.White
        btn5.BackColor = Color.White
        btn6.BackColor = Color.White
        btn7.BackColor = Color.White
        btn8.BackColor = Color.White
        btn9.BackColor = Color.White
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class