' Name:         Area Calculator Project
' Purpose:      Displays the area of a circle
' Programmer:   Eugene Surprenant on 09/15/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculates and displays the area of a circle

        'declare named constant and variables

        Const dblPI As Double = 3.141593
        Dim dblRadius As Double
        Dim dblArea As Double

        'calculate and display area
        Double.TryParse(txtRadius.Text, dblRadius)
        dblArea = dblPI * dblRadius * dblRadius
        lblArea.Text = Format(dblArea, "standard")


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
