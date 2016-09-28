'Name:       Cranston Berries
'Purpose:   Calculate the projected sales for upcoming year
'Author:     Eugene Surprenant on 09/27/2016


Option Explicit On
Option Infer Off
Option Strict On


Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim decProjIncrease As Decimal
        Dim intStraw As Integer
        Dim intBlue As Integer
        Dim intRas As Integer

        Dim decStraw As Decimal
        Dim decBlue As Decimal
        Dim decRas As Decimal



        Decimal.TryParse(txtProjIncrease.Text, decProjIncrease)
        Integer.TryParse(txtStraw.Text, intStraw)
        Integer.TryParse(txtBlue.Text, intBlue)
        Integer.TryParse(txtRas.Text, intRas)



        decStraw = intStraw * decProjIncrease + intStraw
        decBlue = intBlue * decProjIncrease + intBlue
        decRas = intRas * decProjIncrease + intRas

        lblProjStraw.Text = decStraw.ToString("C2")
        lblProjBlue.Text = decBlue.ToString("C2")
        lblProjRas.Text = decRas.ToString("C2")



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear the form's user entries
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRas.Text = String.Empty
        lblProjStraw.Text = String.Empty
        lblProjBlue.Text = String.Empty
        lblProjRas.Text = String.Empty
        txtProjIncrease.Text = String.Empty

        'place the focus to the projected increase text box
        txtProjIncrease.Focus()

    End Sub


    Private Sub txtStraw_TextChanged(sender As Object, e As EventArgs) Handles txtStraw.TextChanged

    End Sub

    Private Sub lblProjincrease_Click(sender As Object, e As EventArgs) Handles lblProjincrease.Click

    End Sub

    Private Sub btnRetirement_Click(sender As Object, e As EventArgs) Handles btnRetirement.Click
        frmesurprenant2b2_Retirement.Show()
    End Sub
End Class