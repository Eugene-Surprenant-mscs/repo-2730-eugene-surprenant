'Name:      You Do It
'Purpose:   Display's variable's contents in Label
'Programmer: Eugene Surprenant


Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dbltotal As Double
        Double.TryParse(txtcost.Text, dbltotal)
        lblcost.Text = dbltotal.ToString()


    End Sub
End Class
