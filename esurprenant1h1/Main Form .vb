'Name:       Photo Project
'Purpose:    Displays the gross pay, FWT, FiCA, state income tax, and net pay
'Programmer: Eugene Surprenant

Option Strict On

Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate gross, withholdings, and net pay


        lblgrosspay.Text = Format(Val(txtHours.Text) * Val(txtPay.Text), "fixed")
        lblfedwith.Text = Format(Val(lblgrosspay.Text) * 0.2, "fixed")
        lblSocSecTax.Text = Format(Val(lblgrosspay.Text) * 0.08, "fixed")
        lblStateTax.Text = Format(Val(lblgrosspay.Text) * 0.03, "fixed")
        lblNetPay.Text = Format(Val(lblgrosspay.Text) - Val(lblfedwith.Text) - Val(lblSocSecTax.Text) - Val(lblStateTax.Text), "fixed")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtHours_TextChanged(sender As Object, e As EventArgs) Handles txtHours.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear the form's user entries
        txtName.Text = String.Empty
        txtHours.Text = String.Empty
        txtPay.Text = String.Empty
        lblgrosspay.Text = String.Empty
        lblfedwith.Text = String.Empty
        lblSocSecTax.Text = String.Empty
        lblStateTax.Text = String.Empty
        lblNetPay.Text = String.Empty

        'place the focus to the projected increase text box
        txtName.Focus()
    End Sub
End Class
