'Name: Retirement Account 
'Purpose: Calculate Retirement Contributions
'Auther Eugene Surprenant on 09/28/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmesurprenant2b2_Retirement
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblemployer.Click

    End Sub

    Private Sub esurprenant2b2_Retirement_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decEmployeeCon As Decimal
        Dim decEmployerCon As Decimal
        Dim decGrosspay As Decimal
        Dim decemployeeannual As Decimal
        Dim decemployerannual As Decimal
        Dim dectotalannual As Decimal

        Dim decemployeeannual1 As Decimal
        Dim decemployerannual1 As Decimal
        Dim dectotal1 As Decimal

        Decimal.TryParse(txtgross.Text, decGrosspay)
        Decimal.TryParse(txtemployee.Text, decEmployeeCon)
        Decimal.TryParse(txtemployer.Text, decEmployerCon)
        Decimal.TryParse(txtemployeeannual.Text, decemployeeannual)
        Decimal.TryParse(txtemployerannual.Text, decemployerannual)
        Decimal.TryParse(txttotal.Text, dectotalannual)

        decemployeeannual1 = (decGrosspay * decEmployeeCon) * 52
        decemployerannual1 = (decGrosspay * decEmployerCon) * 52
        dectotal1 = (decemployeeannual1 + decemployerannual1)

        txtemployeeannual.Text = decemployeeannual1.ToString("C2")
        txtemployerannual.Text = decemployerannual1.ToString("c2")
        txttotal.Text = dectotal1.ToString("C2")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtgross.Text = String.Empty
        txtemployeeannual.Text = String.Empty
        txtemployerannual.Text = String.Empty
        txttotal.Text = String.Empty

        'place the focus to the projected increase text box
        txtgross.Focus()

    End Sub
End Class