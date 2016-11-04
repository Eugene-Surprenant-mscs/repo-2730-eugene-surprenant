' Name:         Chapter 8, String functions, list boxes
' Purpose:      #2: Interprets color code
'               #5: Sets proper upper/lower case
'               #6: Interprets shipping code
' Programmer:   Eugene Surprenant 11/4/2016

Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ItemNumbers_TextChanged(sender As Object, e As EventArgs) _
            Handles txtItem1.TextChanged, txtItem2.TextChanged, txtItem3.TextChanged, txtItem4.TextChanged, txtItem5.TextChanged
        lstColors.Items.Clear()
    End Sub

    Private Sub btnDisplayColor_Click(sender As Object, e As EventArgs) Handles btnDisplayColor.Click
        DisplayColor(txtItem1.Text)
        DisplayColor(txtItem2.Text)
        DisplayColor(txtItem3.Text)
        DisplayColor(txtItem4.Text)
        DisplayColor(txtItem5.Text)
    End Sub

    Private Sub DisplayColor(ByVal itemNum As String)

        ' #2  Color Solution

        If itemNum.Length = 7 Then
            Select Case itemNum.Substring(3, 1).ToUpper
                Case "B"
                    lstColors.Items.Add(itemNum & ": Blue")
                Case "G"
                    lstColors.Items.Add(itemNum & ": Green")
                Case "R"
                    lstColors.Items.Add(itemNum & ": Red")
                Case "W"
                    lstColors.Items.Add(itemNum & ": White")
                Case Else
                    lstColors.Items.Add("Invalid:" & itemNum)
            End Select
        Else
            lstColors.Items.Add("Invalid:" & itemNum)
        End If
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lblName.Text = String.Empty
    End Sub

    Private Sub btnDisplayDelivery_Click(sender As Object, e As EventArgs) Handles btnDisplayDelivery.Click
        DisplayDelivery(txtPartNum1.Text)
        DisplayDelivery(txtPartNum2.Text)
        DisplayDelivery(txtPartNum3.Text)
        DisplayDelivery(txtPartNum4.Text)
        DisplayDelivery(txtPartNum5.Text)
        DisplayDelivery(txtPartNum6.Text)
    End Sub

    Private Sub DisplayDelivery(ByVal partNum As String)

        ' #6 Shipping Solution

        If partNum.Length >= 3 AndAlso partNum.Length <= 4 AndAlso partNum.Substring(0, 2) Like "##" Then
            Dim strDelivery As String = partNum.Substring(2).ToUpper
            Select Case strDelivery
                Case "MS"
                    lstDelivery.Items.Add("Mail - Standard")
                Case "MP"
                    lstDelivery.Items.Add("Mail - Priority")
                Case "FS"
                    lstDelivery.Items.Add("FedEx - Standard")
                Case "FO"
                    lstDelivery.Items.Add("FedEx - Overnight")
                Case "U"
                    lstDelivery.Items.Add("UPS")
                Case Else
                    lstDelivery.Items.Add("Invalid: " & partNum)
            End Select
        Else
            lstDelivery.Items.Add("Invalid: " & partNum)
        End If
    End Sub

    Private Sub PartNum_TextChanged(sender As Object, e As EventArgs) _
            Handles txtPartNum1.TextChanged, txtPartNum2.TextChanged, txtPartNum3.TextChanged, txtPartNum4.TextChanged, txtPartNum5.TextChanged, txtPartNum6.TextChanged
        lstDelivery.Items.Clear()
    End Sub

    'btnProper_Click pseudocode:
    '1) Convert txtName to lower case, store in strName
    '2) Use strName.Substring() to get first character of strName, convert to upper case, store in strFirstChar
    '3) Remove first character of strName
    '4) Insert strFirstChar at beginning of strName
    '5) Use strName.IndexOf() to find the space character. Add 1 and store in index
    '6) Repeat steps 2 - 4 to remove/insert first letter of last name

    ' #5 Proper Name Solution

    Private Sub btnProper_Click(sender As Object, e As EventArgs) Handles btnProper.Click
        Dim strName As String = txtName.Text.ToLower
        Dim strFirstChar As String = strName.Substring(0, 1).ToUpper
        strName = strName.Remove(0, 1)
        strName = strName.Insert(0, strFirstChar)
        Dim index As Integer = strName.IndexOf(" "c) + 1
        strFirstChar = strName.Substring(index, 1).ToUpper
        strName = strName.Remove(index, 1)
        strName = strName.Insert(index, strFirstChar)
        lblName.Text = strName
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
