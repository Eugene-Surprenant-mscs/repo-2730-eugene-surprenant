' Name:         Chapter 6, Counting Loops, Loop Sum, and Average
' Purpose:      #13: displays the even integers from 2 through 20
'               #22: Displays the nuber of integers entered and the average integer entered
' Programmer:   Eugene Surprenant 11/16/2016

Option Strict On
Option Explicit On
Option Infer Off



Public Class Form1

    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click

        lblEven.Text = "Pretest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop

    End Sub

    Private Sub btnLoopWhile_Click(sender As Object, e As EventArgs) Handles btnLoopWhile.Click

        lblEven.Text = "Pretest Loop While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop

    End Sub

    Private Sub btnLoopUntil_Click(sender As Object, e As EventArgs) Handles btnLoopUntil.Click

        lblEven.Text = "Pretest Loop Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop Until i > 20

    End Sub

    Private Sub btnFor_Click(sender As Object, e As EventArgs) Handles btnFor.Click

        lblEven.Text = "Pretest For" & ControlChars.NewLine
        For i As Integer = 2 To 20 Step 2

            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
        Next i


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnDoUntil_Click(sender As Object, e As EventArgs) Handles btnDoUntil.Click

        lblEven.Text = "Pretest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do Until i > 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop

    End Sub

    Private Sub btnSumDoWhile_Click(sender As Object, e As EventArgs) Handles btnSumDoWhile.Click
        'Clear Screen

        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        'Calculates average

        Const strPrompt As String = "Enter a number." & ControlChars.NewLine & "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"

        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        'get first sales amount

        strNum = InputBox(strPrompt, strTITLE, "0")

        'convert the input to a number

        If strNum Is "" Then
            intNum = 0

        Else
            Int32.TryParse(strNum, intNum)
        End If

        '*** Begin loop here: repeat as long as input is not empty

        Do While intNum > 0

            'display the input in the text box

            txtList.Text = txtList.Text & intNum.ToString & ControlChars.NewLine

            'update the counter and accumulator

            intCount = intCount + 1
            intSum = intSum + intNum

            '*** Update control variable

            strNum = InputBox(strPrompt, strTITLE, "0")

            If strNum Is "" Then
                intNum = 0

            Else
                Int32.TryParse(strNum, intNum)
            End If

            '*** End loop here
        Loop

        lblCount.Text = intCount.ToString

        'verify that the counter is greater than 0

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
        lblAvg.Text = "N/A"
        End If


    End Sub

    Private Sub btnSumLoopUntil_Click(sender As Object, e As EventArgs) Handles btnSumLoopUntil.Click

        'Clear Screen

        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        'Calculates average

        Const strPrompt As String = "Enter a number." & ControlChars.NewLine & "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"

        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        'get first sales amount

        strNum = InputBox(strPrompt, strTITLE, "0")


        'convert the input to a number
        If strNum Is "" Then
            intNum = 0

        Else
            Int32.TryParse(strNum, intNum)
        End If

        '*** Begin loop here: repeat as long as input is not empty
        Do

            'display the input in the text box

            txtList.Text = txtList.Text & intNum.ToString & ControlChars.NewLine

            'update the counter and accumulator

            intCount = intCount + 1
            intSum = intSum + intNum

            '*** Update control variable

            strNum = InputBox(strPrompt, strTITLE, "0")

            If strNum Is "" Then
                intNum = 0

            Else
                Int32.TryParse(strNum, intNum)
            End If

            '*** End loop here
        Loop Until intNum = 0

        lblCount.Text = intCount.ToString

        'verify that the counter is greater than 0

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSumForNext_Click(sender As Object, e As EventArgs) Handles btnSumForNext.Click

        'Clear Screen

        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        'Calculates average

        Const strPrompt As String = "Enter a number." & ControlChars.NewLine & "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"
        Dim strCount As String = "Enter Quantity of numbers"

        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double


        'get first sales amount

        strCount = InputBox(strCount)

        If strCount Is "" Then
            intCount = 0

        Else
            Int32.TryParse(strCount, intCount)
        End If

        '*** Begin loop here: repeat as long as input is not empty

        For intCounter As Integer = 1 To intCount

            '*** Update control variable

            strNum = InputBox(strPrompt, strTITLE, "0")

            If strNum Is "" Then
                intNum = 0

            Else
                Int32.TryParse(strNum, intNum)
            End If

            'update the counter and accumulator

            intSum = intSum + intNum

            'display the input in the text box

            txtList.Text = txtList.Text & intNum.ToString & ControlChars.NewLine

            '*** End loop here

        Next intCounter

        lblCount.Text = intCount.ToString

        'verify that the counter is greater than 0

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub
End Class
