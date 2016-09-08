'Name: Bakery Project
'Purpose: Calculates the total number of items sold and the total sales
'Programer: Eugene Surprenant on 8/29/2016

Public Class frmMain
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Prepare Screen for the next sale
        txtDonuts.Text = String.Empty
        TxtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        'Send the focus to the Doughnut box
        txtDonuts.Focus()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Print the sales receipt

        btnCalc.Visible = False
        btnClear.Visible = False
        btnExit.Visible = False
        btnPrint.Visible = False

        PrintForm1.Print()

        btnCalc.Visible = True
        btnClear.Visible = True
        btnExit.Visible = True
        btnPrint.Visible = True

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate number of items sold and total sales
        lblTotalItems.Text = Val(txtDonuts.Text) + Val(TxtMuffins.Text)
        lblTotalSales.Text = Val(lblTotalItems.Text) * 0.5
        lblTotalSales.Text = Format(lblTotalSales.Text, "currency")
    End Sub

    Private Sub lblTotalSales_Click(sender As Object, e As EventArgs) Handles lblTotalSales.Click

    End Sub

    Private Sub lblTotalItems_Click(sender As Object, e As EventArgs) Handles lblTotalItems.Click

    End Sub
End Class
