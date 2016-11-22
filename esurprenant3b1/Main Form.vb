' Name:         Multiplication Project
' Purpose:      Display a multiplication table that shows
'               the multiplicand, multiplier, and product
' Programmer:   Eugene Surprenant on 11/21/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Const dblTaxRate As Double = 0.05

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click

        ' displays a multiplication table

        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For loop:")
        Integer.TryParse(txtNumber.Text, number)
        count = 1

        'Do While loop 

        Do While count <= 9

            product = number * count
            Dim strOutput As String = "    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString()
            lstMultTable.Items.Add(strOutput)
            count = count + 1
        Loop


    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click

        ' displays a multiplication table

        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For loop:")
        Integer.TryParse(txtNumber.Text, number)

        'For loop 

        For count = 1 To 9

            product = number * count
            Dim strOutput As String = "    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString()
            lstMultTable.Items.Add(strOutput)

        Next


    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress

        ' allows only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged

        lstMultTable.Items.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim strSelectedItem As String
        Dim dblSelectedPrice As Double
        Dim dblTotalPrice As Double
        Dim dblPreTaxTotal As Double = 0
        Dim dblTaxAmount As Double

        'LOOPS AND loads data into listbox 1 THRU 4

        For intLoadNum As Integer = 1 To 4
            lstPrices.Items.Add(intLoadNum.ToString("N2"))
        Next


        'LOOPS TO ADD PRICES IN LIST BOX FOR PRETAX TOTAL

        For intIndex As Integer = 0 To lstPrices.Items.Count - 1
            lstPrices.SelectedIndex = intIndex
            strSelectedItem = lstPrices.SelectedItem.ToString()
            Double.TryParse(strSelectedItem.ToString, dblSelectedPrice)
            dblPreTaxTotal = dblSelectedPrice + dblPreTaxTotal
        Next

        'CALCULATES PRETAX TOTAL, TAX, TOTAL PRICE

        lblPretax.Text = dblPreTaxTotal.ToString("N2")
        dblTaxAmount = (dblPreTaxTotal * dblTaxRate)
        lblTax.Text = (dblTaxAmount + dblPreTaxTotal).ToString("C2")
        dblTotalPrice = dblTaxAmount + dblPreTaxTotal
        lblTotal.Text = dblTotalPrice.ToString("C2")
        lstPrices.SelectedIndex = -1

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'adds another value to be calculated in the list prices

        Dim strPrice As String = "Enter a Price" & ControlChars.NewLine &
            "Valid prices: 1.00 to 9.99"
        Dim strPrice2 As String = "Enter a Price" & ControlChars.NewLine &
            "Valid prices: 1.00 to 9.99"
        Dim strTitleValid As String = "Price Entry"
        Dim strTitleInvalid As String = "Invalid Price"
        Dim dblPrice As Double
        Dim dblPreTaxTotal As Double
        Dim dblTotalPrice As Double
        Dim strSelectedItem As String
        Dim dblSelectedPrice As Double
        Dim dblTaxAmount As Double

        'USE THIS INPUT BOX TO STORE STRPRICE

        strPrice = InputBox(strPrice, strTitleValid, "0")
        Double.TryParse(strPrice, dblPrice)

        'CHECK CALCULATIONS AND LOOP INPUT BOX FOR CORRECT BEHAVIOR

        Do While dblPrice < 1 OrElse dblPrice > 9.99
            strPrice = InputBox(strPrice2, strTitleInvalid, "0")
            Double.TryParse(strPrice, dblPrice)
        Loop

        'ADDS NEW USER ENTERED PRICE TO LISTBOX

        lstPrices.Items.Add(dblPrice.ToString("N2"))

        'LOOPS TO ADD PRICES IN LIST BOX FOR PRETAX TOTAL

        For intIndex As Integer = 0 To lstPrices.Items.Count - 1
            lstPrices.SelectedIndex = intIndex
            strSelectedItem = lstPrices.SelectedItem.ToString()
            Double.TryParse(strSelectedItem.ToString, dblSelectedPrice)
            dblPreTaxTotal = dblSelectedPrice + dblPreTaxTotal
        Next

        'CALCULATES PRETAX TOTAL, TAX, TOTAL PRICE

        lblPretax.Text = dblPreTaxTotal.ToString("N2")
        dblTaxAmount = (dblPreTaxTotal * dblTaxRate)
        lblTax.Text = (dblTaxAmount + dblPreTaxTotal).ToString("C2")
        dblTotalPrice = dblTaxAmount + dblPreTaxTotal
        lblTotal.Text = dblTotalPrice.ToString("C2")
        lstPrices.SelectedIndex = -1

    End Sub

    Private Sub lstPrices_KeyDown(sender As Object, e As KeyEventArgs) Handles lstPrices.KeyDown

        'ALLOWS PRICE ITEMS TO BE REMOVED FROM LIST BOX 

        Dim intCurIndex As Integer
        Dim strSelectedItem As String
        Dim dblSelectedPrice As Double
        Dim dblPreTaxTotal As Double
        Dim dblTotalPrice As Double
        Dim dblTaxAmount As Double

        If e.KeyData = Keys.Back OrElse e.KeyData = Keys.Delete Then
            intCurIndex = lstPrices.SelectedIndex
            lstPrices.Items.Remove(lstPrices.SelectedItem)

            'LOOPS TO ADD PRICES IN LIST BOX FOR PRETAX TOTAL

            For intIndex As Integer = 0 To lstPrices.Items.Count - 1
                lstPrices.SelectedIndex = intIndex
                strSelectedItem = lstPrices.SelectedItem.ToString()
                Double.TryParse(strSelectedItem.ToString, dblSelectedPrice)
                dblPreTaxTotal = dblSelectedPrice + dblPreTaxTotal
            Next

            'CALCULATES PRETAX TOTAL, TAX, TOTAL PRICE

            lblPretax.Text = dblPreTaxTotal.ToString("N2")
            dblTaxAmount = (dblPreTaxTotal * dblTaxRate)
            lblTax.Text = (dblTaxAmount + dblPreTaxTotal).ToString("C2")
            dblTotalPrice = dblTaxAmount + dblPreTaxTotal
            lblTotal.Text = dblTotalPrice.ToString("C2")
            lstPrices.SelectedIndex = -1

        Else


        End If

    End Sub
End Class
