Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtAssessed.TextChanged

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Calculate property tax

        lblTax.Text = Val(txtAssessed.Text) / 100 * 1.5

        lblTax.Text = Format(lblTax.Text, "currency")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintForm1.Print()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Prepare Screen for the next tax calculation

        txtAssessed.Text = String.Empty
        lblTax.Text = String.Empty

        'Send the focus to the Doughnut box

        txtAssessed.Focus()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblTax_Click(sender As Object, e As EventArgs) Handles lblTax.Click

    End Sub
End Class
