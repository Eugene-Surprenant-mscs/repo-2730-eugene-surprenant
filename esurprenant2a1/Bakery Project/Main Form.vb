' Name:         Bakery Project
' Purpose:      Calculates the total number of
'               items sold and the total sales
' Programmer:   Eugene Surprenant on 09/21/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain




    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'get the salesclerk's name

        Const strPROMPT As String = "Salesclerk's name:"
        Const strTITLE As String = "Name Entry"

        ' calculate number of items sold and total sales
        Const decITEM_PRICE As Decimal = 0.5D
        Const decTAX_RATE As Decimal = 0.02D
        Dim intDonuts As Integer
        Dim intMuffins As Integer
        Dim intTotalItems As Integer
        Dim decSubtotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotalSales As Decimal
        Static strClerk As String

        'assign name to variable

        strClerk = InputBox(strPROMPT, strTITLE, strClerk)

        'calculate total number of items sold

        Integer.TryParse(txtDonuts.Text, intDonuts)
        Integer.TryParse(txtMuffins.Text, intMuffins)
        intTotalItems = intDonuts + intMuffins

        'calculate the subtotal

        decSubtotal = intTotalItems * decITEM_PRICE

        'calculate the sales tax

        decSalesTax = decSubtotal * decTAX_RATE

        'calculate the total sales

        decTotalSales = decSubtotal + decSalesTax

        'display total amounts

        lblTotalItems.Text = Convert.ToString(intTotalItems)
        lblTotalSales.Text = decTotalSales.ToString("C2")

        'display tax and salesclerk's name
        lblMsg.Text = "The Sales tax was " & decSalesTax.ToString("C2") & "." &
            ControlChars.NewLine & strClerk

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale

        txtDonuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty
        ' send the focus to the Doughnuts box
        txtDonuts.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' print the sales receipt

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

    Private Sub frmMain_DockChanged(sender As Object, e As EventArgs) Handles Me.DockChanged

    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtDonuts.TextChanged, txtMuffins.TextChanged
        'clear the total items, total sales, and message

        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty

    End Sub
End Class
