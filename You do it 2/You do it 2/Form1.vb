' Name:         You Do It 2
' Purpose:      Displays the Number plus 1
' Programmer:   Eugene Surprenant on 09/15/16

Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        ' Adds 1 to the number entered by the user 

        ' procedure-level variable for getting the number

        Dim decNumber As Decimal

        'static variable for accumulating the score

        Static dectotal As Decimal

        'total the scores and display the results

        Decimal.TryParse(txtNumber.Text, decNumber)
        dectotal = decNumber + 1
        lbltotal.Text = Convert.ToString(decTotal)

        txtNumber.Focus()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub secondlabel_Click(sender As Object, e As EventArgs)
        Label1.Text = "message" & "1"

    End Sub
End Class
