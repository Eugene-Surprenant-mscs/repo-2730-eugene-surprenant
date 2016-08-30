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

        PrintForm1.Print()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
