'Name:         Marshall Commission
' Purpose:      Display sales Commission
' Programmer:   Eugene Surprenant on 10/26/2016

Option Explicit On
Option Strict On
Option Infer Off


Public Class Marshall
    Private Sub btnIfElse_Click(sender As Object, e As EventArgs) Handles btnIfElse.Click
        ' calculate Commission

        lblCommisionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.00
        Dim dblCommissionOnly As Double = 0.00
        Dim dbladditional As Double = 0.00
        Dim dblTotalCommission As Double = 0.00
        Dim boolSalesOK As Boolean = Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        If dblSales >= 30000.0 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        ElseIf dblSales >= 6000.0 Then
            dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
        ElseIf dblSales >= 1 Then
            dblCommissionOnly = dblSales * 0.1
        End If

        If chkMoreThanTen.Checked Then
            dbladditional = dbladditional + 500.0
        End If

        If chktravel.Checked Then
            dbladditional = dbladditional + 700
        End If

        dblTotalCommission = dblCommissionOnly + dbladditional

        If boolSalesOK Then
            lblCommisionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dbladditional.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnIfThen_Click(sender As Object, e As EventArgs) Handles btnIfThen.Click
        ' calculate Commission

        lblCommisionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.00
        Dim dblCommissionOnly As Double = 0.00
        Dim dbladditional As Double = 0.00
        Dim dblTotalCommission As Double = 0.00
        Dim boolSalesOK As Boolean = Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        End If

        If boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCommissionOnly = dblSales * 0.1
        End If

        If boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
        End If

        If boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        End If

        If chkMoreThanTen.Checked Then
            dbladditional = dbladditional + 500.0
        End If

        If chktravel.Checked Then
            dbladditional = dbladditional + 700
        End If

        dblTotalCommission = dblCommissionOnly + dbladditional

        If boolSalesOK Then
            lblCommisionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dbladditional.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()

    End Sub

    Private Sub Marshall_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        'allows the text box to accept only numbers . and the backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso e.KeyChar = "." Then
            'cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub btnNestedIf_Click(sender As Object, e As EventArgs) Handles btnNestedIf.Click

        ' calculate Commission

        lblCommisionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.00
        Dim dblCommissionOnly As Double = 0.00
        Dim dbladditional As Double = 0.00
        Dim dblTotalCommission As Double = 0.00
        Dim boolSalesOK As Boolean = Double.TryParse(txtSales.Text, dblSales)

        If boolSalesOK Then
        Else
            MessageBox.Show("invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If dblSales >= 30000.0 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        Else
            If dblSales >= 6000.0 Then
                dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
            Else
                If dblSales >= 1.0 Then
                    dblCommissionOnly = dblSales * 0.1
                Else
                    If dblSales < 1.0 Then
                            dblCommissionOnly = 0.0
                        Else
                        End If
                    End If
                End If
            End If

        If chkMoreThanTen.Checked Then
            dbladditional = dbladditional + 500.0
        End If

        If chktravel.Checked Then
            dbladditional = dbladditional + 700
        End If

        dblTotalCommission = dblCommissionOnly + dbladditional

        If boolSalesOK Then
            lblCommisionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dbladditional.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()

    End Sub

    Private Sub txtSales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged
        'Clears labels
        lblCommisionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        'clears check box
        If TypeOf chkMoreThanTen Is CheckBox Then
            DirectCast(chkMoreThanTen, CheckBox).CheckState = CheckState.Unchecked
        End If

        If TypeOf chktravel Is CheckBox Then
            DirectCast(chktravel, CheckBox).CheckState = CheckState.Unchecked
        End If

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' calculate Commission

        lblCommisionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.00
        Dim dblCommissionOnly As Double = 0.00
        Dim dbladditional As Double = 0.00
        Dim dblTotalCommission As Double = 0.00
        Dim boolSalesOK As Boolean = Double.TryParse(txtSales.Text, dblSales)

        If boolSalesOK Then
        Else
            MessageBox.Show("invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Select Case dblSales
            Case Is < 1.0
                dblCommissionOnly = 0.0
            Case 1 To 5999.99
                dblCommissionOnly = dblSales * 0.1
            Case 6000.0 To 29999.99
                dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.1
            Case Is > 29999.99
        End Select

        If dblSales >= 30000.0 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        Else
            If dblSales >= 6000.0 Then
                dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
            Else
                If dblSales >= 1.0 Then
                    dblCommissionOnly = dblSales * 0.1
                Else
                    If dblSales < 1.0 Then
                        dblCommissionOnly = 0.0
                    Else
                    End If
                End If
            End If
        End If

        If chkMoreThanTen.Checked Then
            dbladditional = dbladditional + 500.0
        End If

        If chktravel.Checked Then
            dbladditional = dbladditional + 700
        End If

        dblTotalCommission = dblCommissionOnly + dbladditional

        If boolSalesOK Then
            lblCommisionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dbladditional.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub
End Class
