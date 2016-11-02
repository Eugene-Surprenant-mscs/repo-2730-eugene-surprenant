'Name:         Exercise 2I
' Purpose:      String Methods
' Programmer:   Eugene Surprenant on 11/02/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        '#03: Insert

        Dim strWord As String = txt03.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03.Text = strWord

        '#04: Substring

        Dim strItem As String = txt04.Text
        strItem = strItem.Substring(2, 4)
        lbl04.Text = strItem

        '#05a: Lenght

        Dim strMsg As String = txt05a.Text
        strMsg = CType(strMsg.Length, String)
        lbl05a.Text = strMsg

        '#05b: Trim

        Dim strState As String = txt5b.Text
        strState = txt5b.Text.Trim
        lbl05b.Text = strState

        '#5c: Remove/Insert

        Dim strwrd As String = txt05c.Text
        strwrd = strwrd.Remove(1, 1)
        strwrd = strwrd.Insert(1, "rit")
        lbl05c.Text = strwrd

        '#05d: Insert

        Dim strDay As String
        strDay = txt05d.Text
        strDay = strDay.Insert(0, "Mon")
        lbl05d.Text = strDay

        '#05e: Pad
        Dim strPay As String
        strPay = txt05e.Text
        lbl05e.Text = strPay.PadLeft(10, "*"c)

        '#06: Remove

        Dim strAmount As String
        strAmount = txt06.Text
        strAmount = strAmount.Remove(1, 1)
        strAmount = strAmount.Remove(4, 1)
        lbl06.Text = strAmount

        '#07: Contains

        Dim strAddress As String
        Dim blnIsContained As Boolean
        strAddress = txt07.Text
        blnIsContained = strAddress.ToLower.Contains("jefferson street")
        If blnIsContained Then
            lbl07.Text = "Jeff St. Found"
        Else
            lbl07.Text = "Jeff St. Not found"
        End If

        '#12: Len/Remove

        Dim strRate As String
        Dim intLength As Integer
        Dim dblRate As Double
        strRate = txt12.Text
        intLength = strRate.Length
        strRate = strRate.Remove(intLength - 2, 2)
        Double.TryParse(strRate, dblRate)
        lbl12.Text = (dblRate * 1000 * 0.01).ToString("c2")

        '#13: Like

        Dim strZip As String
        strZip = txt13.Text
        If strZip Like "605##" Then
            lbl13.Text = "Shipping $25"
        ElseIf strZip Like "606##" Then
            lbl13.Text = "Shipping $30"
        Else
            lbl13.Text = "Invalid Zip"
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
