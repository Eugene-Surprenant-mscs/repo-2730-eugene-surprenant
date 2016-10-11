' Name:        Ch4 Lession B, If Statements, Message boxes
' Purpose:      Currency, Tea, Electric, Quotient
' Programmer:   Eugene Surprenant on 10/11/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtAmDollar.TextChanged, txtPrice.TextChanged, txtPounds.TextChanged,
        txtPrevious.TextChanged, txtCurrent.TextChanged, txtFirst.TextChanged, txtSecond.TextChanged
        ' clear calculated amounts

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty
        lblTotalDue.Text = String.Empty
        lblMonthlyBill.Text = String.Empty
        lblQuotient.Text = String.Empty
    End Sub
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConverteq.Click
        'convert American dollors to the Euro, the British pound, and the South African rand
        ' declare variables
        Const dblEURO_RATE As Double = 0.8976D
        Const dblPOUND_RATE As Double = 0.8049D
        Const dblRAND_RATE As Double = 13.9071D
        Const strMSG As String = "Please enter an American dollar amount"
        Dim dblDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        Double.TryParse(txtAmDollar.Text, dblDollar)

        If txtAmDollar.Text = String.Empty Then
            MessageBox.Show(strMSG, "Currecy Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' calculate conversions
            dblEuro = dblDollar * dblEURO_RATE
            dblPound = dblDollar * dblPOUND_RATE
            dblRand = dblDollar * dblRAND_RATE

            ' display results
            lblEuro.Text = dblEuro.ToString("c2")
            lblPound.Text = dblPound.ToString("c2")
            lblRand.Text = dblRand.ToString("c2")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConvertne.Click
        ' declare variables
        Const dblEURO_RATE As Double = 0.8976D
        Const dblPOUND_RATE As Double = 0.8049D
        Const dblRAND_RATE As Double = 13.9071D
        Const strMSG As String = "Please enter an American dollar amount"
        Dim dblDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        Double.TryParse(txtAmDollar.Text, dblDollar)

        If txtAmDollar.Text <> String.Empty Then
            ' calculate conversions
            dblEuro = dblDollar * dblEURO_RATE
            dblPound = dblDollar * dblPOUND_RATE
            dblRand = dblDollar * dblRAND_RATE

            ' display results
            lblEuro.Text = dblEuro.ToString("c2")
            lblPound.Text = dblPound.ToString("c2")
            lblRand.Text = dblRand.ToString("c2")


        Else
            MessageBox.Show(strMSG, "Currecy Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub btncalculate1_Click(sender As Object, e As EventArgs) Handles btncalculate1.Click
        ' declare variables
        Const dblSHIPING_FEE As Double = 15
        Const strSHIPPING_MSG As String = "Should the customber be charged $15 for shipping?"
        Dim dblPounds As Double
        Dim dblPrice As Double
        Dim dblTotal As Double
        Dim dlgButton As DialogResult

        ' convert text to numbers
        Double.TryParse(txtPounds.Text, dblPounds)
        Double.TryParse(txtPrice.Text, dblPrice)

        ' calculate total
        dblTotal = dblPounds * dblPrice

        ' ask user if customer shouold be charged for shipping and apply accordingly. Then display result
        dlgButton = MessageBox.Show(strSHIPPING_MSG, "Tea Time", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        If dlgButton = DialogResult.Yes Then
            dblTotal = dblTotal + dblSHIPING_FEE
            lblTotalDue.Text = dblTotal.ToString()
        Else
            lblTotalDue.Text = dblTotal.ToString()
        End If
    End Sub

    Private Sub btnCalculate2_Click(sender As Object, e As EventArgs) Handles btnCalculate2.Click
        ' declare variables
        Const dblCHG_PER_UNIT As Double = 0.13
        Const strMSG As String = "Current reading must be greater than or equal to the previous reading."
        Dim dblCurrent As Double
        Dim dblPrevious As Double
        Dim dblBill As Double

        ' convert text to numbers
        Double.TryParse(txtCurrent.Text, dblCurrent)
        Double.TryParse(txtPrevious.Text, dblPrevious)

        ' display error message if text boxes are empty or the current reading is less thean the previous.
        ' Otherwise caculate and display the result
        If dblPrevious >= dblCurrent OrElse
            txtPrevious.Text = String.Empty OrElse
            txtCurrent.Text = String.Empty Then

            MessageBox.Show(strMSG, "Triple County Electric",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            dblBill = (dblCurrent - dblPrevious) * dblCHG_PER_UNIT
            lblMonthlyBill.Text = dblBill.ToString
        End If
    End Sub

    Private Sub btncalculate3_Click(sender As Object, e As EventArgs) Handles btncalculate3.Click
        Dim dblFirst As Double
        Dim dblSecond As Double
        Dim dblQuotient As Double

        ' convert text to numbers
        Double.TryParse(txtFirst.Text, dblFirst)
        Double.TryParse(txtSecond.Text, dblSecond)

        ' swap numbers if necessary.
        If dblFirst < dblSecond Then
            Dim dblTemp As Double
            dblTemp = dblFirst
            dblFirst = dblSecond
            dblSecond = dblTemp
        End If

        ' display error when smaller number is 0. Otherwise calculate.
        If dblSecond = 0 Then
            MessageBox.Show("Cannot divide by 0", "Quotient", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            dblQuotient = dblFirst / dblSecond
            lblQuotient.Text = dblQuotient.ToString()
        End If
    End Sub

    Private Sub txtPounds_TextChanged(sender As Object, e As EventArgs) Handles txtPounds.TextChanged

    End Sub
End Class
