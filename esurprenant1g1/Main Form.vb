
'Purpose: Average 3 test scores
'Aauthor: Eeugene Surprenant on 09/07/16

Option Strict On


Public Class frmmain
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        'clear the form's user entries

        txttest1.Text = String.Empty
        txttest2.Text = String.Empty
        txttest3.Text = String.Empty
        lbltestaverage.Text = String.Empty

        'place the focus to the projected increase text box
        txttest1.Focus()

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        'make buttons invisible for printing
        btncalc.Visible = False
        btnprint.Visible = False
        btnclear.Visible = False
        btnexit.Visible = False

        'print the form to preview
        PrintForm1.Print()

        'make buttons visible after printing
        btncalc.Visible = True
        btnprint.Visible = True
        btnclear.Visible = True
        btnexit.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        'Calculate the test average

        lbltestaverage.Text = Format((Val(txttest1.Text) + Val(txttest2.Text) + Val(txttest3.Text)) / 3, "fixed")

    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
