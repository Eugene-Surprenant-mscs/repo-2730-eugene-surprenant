' Name:       Exercise 3E1
' Purpose:    Display counts of salespeople commissions
' Programmer: Eugene Surprenant on 12/06/2016

Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1
    Private intCommissions() As Integer = {300, 500, 200, 150, 600, 750, 900, 150, 100, 200,
                                           250, 650, 300, 750, 800, 350, 250, 150, 100, 300}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCommissions()
        cboSearchValues.SelectedIndex = 0
        cboSearchRanges.SelectedIndex = 0
    End Sub

    Private Sub DisplayCommissions()

        ' display values

        For intSub As Integer = 0 To intCommissions.GetUpperBound(0)
            lblValues.Text &= intCommissions(intSub) & ", "
        Next intSub

        If lblValues.Text.EndsWith(", ") Then
            lblValues.Text = lblValues.Text.Substring(0, lblValues.Text.Length - 2)
        End If
    End Sub

    Private Sub cboSearchValues_TextChanged(sender As Object, e As EventArgs) Handles cboSearchValues.TextChanged
        Dim intValue As Integer = 0

        Integer.TryParse(cboSearchValues.Text, intValue)

        If intValue > 0 AndAlso intValue <= 1000 Then
            lblValueCount.Text = CountValue(intValue).ToString()
        Else
            '     Display message box

            MessageBox.Show("Input not Valid", "Commission Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function CountValue(intSearchValue As Integer) As Integer

        ' Convert input to intSearchValue
        ' If intSearchValue is valid
        ' Call CountValue, display result in lblValueCount

        Dim intCounter As Integer = 0

        For Each intElement As Integer In intCommissions
            If intElement = intSearchValue Then
                intCounter += 1
            End If
        Next intElement

        Return intCounter
    End Function

    Private Sub cboSearchRanges_TextChanged(sender As Object, e As EventArgs) Handles cboSearchRanges.TextChanged

        lblRangeCount.Text = String.Empty
        Dim intSearchMin As Integer = 0
        Dim intSearchMax As Integer = 0
        Dim intHyphenIndex As Integer = cboSearchRanges.Text.IndexOf("-")

        If intHyphenIndex >= 0 AndAlso cboSearchRanges.Text.Length > intHyphenIndex + 1 Then
            Dim strSearchMin As String =
                cboSearchRanges.Text.Substring(0, intHyphenIndex).Trim()
            Dim strSearchMax As String =
                cboSearchRanges.Text.Substring(intHyphenIndex + 1).Trim()
            Int32.TryParse(strSearchMin, intSearchMin)
            Int32.TryParse(strSearchMax, intSearchMax)
            If intSearchMax >= intSearchMin Then
                lblRangeCount.Text = CountRange(intSearchMin, intSearchMax).ToString
            End If
        End If
    End Sub

    Private Function CountRange(intSearchMin As Integer, intSearchMax As Integer) As Integer

        ' find and return count of values in range

        Dim intCounter As Integer = 0

        For Each intElement As Integer In intCommissions
            If intElement >= intSearchMin AndAlso intElement <= intSearchMax Then
                intCounter += 1
            End If
        Next intElement

        Return intCounter
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
