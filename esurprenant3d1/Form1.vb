' Name:         Exercise 3D: Array subscripts, totals, avg, min
' Purpose:      Display the average number sold
' Programmer:   Eugene Surprenant on 12/05/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private intSold() As Integer = {250, 225, 193, 260}
    Private dblWholesale() As Double = {17.5, 9, 10.5, 18.75, 26, 8.5, 5.65, 12.25, 10, 30}

    ' Declare and initialize daysInMonth array
    ' If month entered by user is valid
    '     Display days in selected month
    ' Otherwise
    '     Display error message
    ' End If
    ' Set focus to txtMonth and select all text
    Private Sub btnDisplayDays_Click(sender As Object, e As EventArgs) Handles btnDisplayDays.Click
        Dim daysInMonth() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Dim month As Integer
        If Integer.TryParse(txtMonth.Text, month) AndAlso month >= 1 AndAlso month <= 12 Then
            'Display number of days in daysLabel
            lblDays.Text = daysInMonth(month - 1).ToString()
        Else
            MessageBox.Show("Invalid month.  Enter a number from 1 to 12.", "Month", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        txtMonth.Focus()
        txtMonth.SelectAll()
    End Sub



    '     If lblLessThanAvg.Text.EndsWith(", ") Then
    '        lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
    '     End If
    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click

        ' Displays the average number sold
        ' Clear labels
        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty
        Dim intSum As Integer = 0
        Dim dblAvg As Double = 0.0
        Dim intMin As Integer = 0

        ' Use loop to calculate total of elements in intSold array

        For intSub As Integer = 0 To intSold.GetUpperBound(0)
            intSum += intSold(intSub)
        Next intSub
        dblAvg = intSum / intSold.Length
        lblAvg.Text = dblAvg.ToString

        ' Display values < avg

        For intSub As Integer = 0 To intSold.GetUpperBound(0)
            If intSold(intSub) < dblAvg Then
                lblLessThanAvg.Text &= intSold(intSub).ToString & ", "
            End If

            ' Remove extra ", " from lblLessThanAvt.Text:

        Next
        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If
    End Sub

    Private Sub btnForEachNext_Click(sender As Object, e As EventArgs) Handles btnForEachNext.Click

        ' Displays the average number sold

        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty
        Dim intSum As Integer = 0
        Dim dblAvg As Double = 0.0

        For Each intElement As Integer In intSold
            intSum += intElement
        Next intElement
        dblAvg = intSum / intSold.Length
        lblAvg.Text = dblAvg.ToString

        ' Display values < avg

        For Each intElement As Integer In intSold
            If intElement < dblAvg Then
                lblLessThanAvg.Text &= intElement.ToString & ", "
            End If

            ' Remove extra ", " from lblLessThanAvt.Text:

        Next
        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If
    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click

        ' Displays the average number sold

        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty
        Dim intSum As Integer
        Dim dblAvg As Double
        Dim intSub As Integer

        Do While intSub <= intSold.GetUpperBound(0)
            intSum += intSold(intSub)
            intSub += 1
        Loop
        dblAvg = intSum / intSold.Length
        lblAvg.Text = dblAvg.ToString

        ' Display values < avg

        intSub = 0
        Do While intSub <= intSold.GetUpperBound(0)
            If intSold(intSub) < dblAvg Then
                lblLessThanAvg.Text &= intSold(intSub).ToString & ", "
            End If
            intSub += 1
        Loop

        ' Remove extra ", " from lblLessThanAvt.Text:

        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If

    End Sub


    Private Sub btnRetail_Click(sender As Object, e As EventArgs) Handles btnRetail.Click

        ' Updates each array value and displays the updated values in lstRetail

        Dim dblMarkupRate As Double = 0.0
        Double.TryParse(InputBox("Markup Rate", "Enter markup rate", "50"), dblMarkupRate)
        lstRetail.Items.Clear()

        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            dblWholesale(intSub) *= 1 + dblMarkupRate / 100
            lstRetail.Items.Add(dblWholesale(intSub).ToString("n2").PadLeft(6))
        Next

    End Sub

    Private Sub btnWholesale_Click(sender As Object, e As EventArgs) Handles btnWholesale.Click

        ' Returns array to the original wholesale prices

        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            dblWholesale(intSub) = Convert.ToDouble(lstWholesale.Items(intSub))
        Next intSub
        lstRetail.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Fill lstWholesale with array values

        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            lstWholesale.Items.Add(dblWholesale(intSub).ToString("n2").PadLeft(6))
        Next intSub
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

End Class
