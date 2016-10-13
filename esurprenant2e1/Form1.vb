' Name:        Ch4 Lession B, AndAlso, OrElse
' Purpose:     Determines whether a customer is entitled to free shipping, Commision for sales
' Programmer:   Eugene Surprenant on 10/13/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub btnCalcAnd_Click(sender As Object, e As EventArgs) Handles btnCalcAnd.Click

        ' declare variables
        Const dblSHIPPING_FEE As Double = 9
        Const dblNO_SHIPPING_FEE As Double = 0
        Dim dblOrder As Double
        Dim strCreditCard As String

        ' convert text to numbers
        Double.TryParse(txtOrder.Text, dblOrder)
        strCreditCard = txtCreditCard.Text

        If dblOrder >= 100 AndAlso strCreditCard.ToUpper = "Y" Then

            ' display results
            lblShipping.Text = dblNO_SHIPPING_FEE.ToString("c2")
        Else

            ' display results
            lblShipping.Text = dblSHIPPING_FEE.ToString("c2")
        End If

        If txtCreditCard.Text = String.Empty OrElse txtOrder.Text = String.Empty Then
            MessageBox.Show("Please enter an order amount!", "Savannah's website", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCalcOr_Click(sender As Object, e As EventArgs) Handles btnCalcOr.Click

        ' declare variable
        Const dblSHIPPING_FEE As Double = 9
        Const dblNO_SHIPPING_FEE As Double = 0
        Dim dblOrder As Double
        Dim strCreditCard As String

        ' convert text to numbers
        Double.TryParse(txtOrder.Text, dblOrder)
        strCreditCard = txtCreditCard.Text

        If dblOrder < 100 OrElse strCreditCard.ToUpper <> "Y" Then

            ' display results
            lblShipping.Text = dblSHIPPING_FEE.ToString("c2")
        Else
            ' display results
            lblShipping.Text = dblNO_SHIPPING_FEE.ToString("c2")
        End If

        If txtCreditCard.Text = String.Empty OrElse txtOrder.Text = String.Empty Then
            MessageBox.Show("Please enter an order amount!", "Savannah's website", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ChangedText(sender As Object, e As EventArgs
                            ) Handles txtOrder.TextChanged, txtCreditCard.TextChanged
        lblShipping.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalcEqual_Click(sender As Object, e As EventArgs) Handles btnCalcEqual.Click

        ' declare variable
        Const dblMORE_ID_COM As Double = 0.15
        Const dblLESS_ID_COM As Double = 0.12
        Dim strId As String
        Dim dblSales As Double
        Dim dblCommission As Double

        ' convert text to numbers
        Double.TryParse(txtSales.Text, dblSales)
        strId = txtId.Text

        If (dblSales >= 25000) AndAlso
            (strId.ToUpper = "A1" OrElse strId.ToUpper = "B2" OrElse strId.ToUpper = "C3") Then
            ' calculate
            dblCommission = (dblSales * dblMORE_ID_COM)

            ' display results
            lblCommission.Text = dblCommission.ToString("c2")
        Else
            ' calculate
            dblCommission = (dblSales * dblLESS_ID_COM)

            ' display results
            lblCommission.Text = dblCommission.ToString("c2")
        End If
    End Sub

    Private Sub btnNotEqual_Click(sender As Object, e As EventArgs) Handles btnNotEqual.Click

        ' declare variable
        Const dblMORE_ID_COM As Double = 0.15
        Const dblLESS_ID_COM As Double = 0.12
        Dim strId As String
        Dim dblSales As Double
        Dim dblCommission As Double

        ' convert text to numbers
        Double.TryParse(txtSales.Text, dblSales)
        strId = txtId.Text

        If (strId.ToUpper <> "A1" AndAlso strId.ToUpper <> "B2" AndAlso strId.ToUpper <> "C3") OrElse
            ((strId.ToUpper = "A1" OrElse strId.ToUpper = "B2" OrElse strId.ToUpper = "C3") AndAlso
            (dblSales < 25000)) Then

            ' calculate
            dblCommission = (dblSales * dblLESS_ID_COM)

            ' display results
            lblCommission.Text = dblCommission.ToString("c2")
        Else
            ' calculate
            dblCommission = (dblSales * dblMORE_ID_COM)

            ' display results
            lblCommission.Text = dblCommission.ToString("c2")
        End If
    End Sub

    Private Sub ComTextChange(sender As Object, e As EventArgs) Handles txtId.TextChanged, txtSales.TextChanged
        lblCommission.Text = String.Empty
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
