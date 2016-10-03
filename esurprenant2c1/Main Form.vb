'Name: Variable Storing of Information
'Author: Eugene Surprenant
'Date:   Created on 10/03/2016

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain

    Private String1, String2, String3 As String
    Private Byte1, Byte2, Byte3 As Byte
    Private Short1, Short2, Short3 As Short
    Private Integer1, Integer2, Integer3 As Integer
    Private Long1, Long2, Long3 As Long
    Private Single1, Single2, Single3 As Single
    Private Double1, Double2, Double3 As Double
    Private Decimal1, Decimal2, Decimal3 As Decimal
    Private Date1, Date2, Date3 As Date
    Private TimeSpan2 As TimeSpan

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        'This will display the return values of the user input per data type

        'Variables get an initial value
        String1 = String.Empty
        String2 = String.Empty
        String3 = String.Empty
        Byte1 = 0
        Byte2 = 0
        Byte3 = 0
        Short1 = 0S
        Short2 = 0S
        Short3 = 0S
        Integer1 = 0
        Integer2 = 0
        Integer3 = 0
        Long1 = 0L
        Long2 = 0L
        Long3 = 0L
        Single1 = 0.0F
        Single2 = 0.0F
        Single3 = 0.0F
        Double1 = 0.0F
        Double2 = 0.0F
        Double3 = 0.0F
        Decimal1 = 0.0D
        Decimal2 = 0.0D
        Decimal3 = 0.0D
        Date1 = Date.MinValue
        Date2 = Date.MinValue
        Date3 = Date.MinValue

        'Clears all lbl3 contents if Display is clicked
        lblString3.Text = String.Empty
        lblByte3.Text = String.Empty
        lblShort3.Text = String.Empty
        lblInteger3.Text = String.Empty
        lblLong3.Text = String.Empty
        lblSingle3.Text = String.Empty
        lblDouble3.Text = String.Empty
        lblDecimal3.Text = String.Empty
        lblDate3.Text = String.Empty
        lblDate3.Text = String.Empty

        'converts the text input to the desired data type and then back to a string for display. 
        String1 = txtInput1.Text
        String2 = txtInput2.Text
        lblString1.Text = String1
        lblString2.Text = String2


        Byte.TryParse(txtInput1.Text, Byte1)
        Byte.TryParse(txtInput2.Text, Byte2)
        lblByte1.Text = Byte1.ToString()
        lblByte2.Text = Byte2.ToString()

        Short.TryParse(txtInput1.Text, Short1)
        Short.TryParse(txtInput2.Text, Short2)
        lblShort1.Text = Short1.ToString()
        lblShort2.Text = Short2.ToString()

        Integer.TryParse(txtInput1.Text, Integer1)
        Integer.TryParse(txtInput2.Text, Integer2)
        lblInteger1.Text = Integer1.ToString()
        lblInteger2.Text = Integer2.ToString()

        Long.TryParse(txtInput1.Text, Long1)
        Long.TryParse(txtInput2.Text, Long2)
        lblLong1.Text = Long1.ToString()
        lblLong2.Text = Long2.ToString()

        Single.TryParse(txtInput1.Text, Single1)
        Single.TryParse(txtInput2.Text, Single2)
        lblSingle1.Text = Single1.ToString()
        lblSingle2.Text = Single2.ToString()

        Double.TryParse(txtInput1.Text, Double1)
        Double.TryParse(txtInput2.Text, Double2)
        lblDouble1.Text = Double1.ToString()
        lblDouble2.Text = Double2.ToString()

        Decimal.TryParse(txtInput1.Text, Decimal1)
        Decimal.TryParse(txtInput2.Text, Decimal2)
        lblDecimal1.Text = Decimal1.ToString()
        lblDecimal2.Text = Decimal2.ToString()

        Date.TryParse(txtInput1.Text, Date1)
        Date.TryParse(txtInput2.Text, Date2)
        TimeSpan.TryParse(txtInput2.Text, TimeSpan2)
        lblDate1.Text = Date1.ToString()
        lblDate2.Text = Date2.ToString()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'this will take the user input from txtbox 1 and 2, add them, and display the result in the last column


        btnDisplay_Click(Nothing, Nothing)
        On Error Resume Next

        String3 = String1 + String2
        lblString3.Text = String3
        Byte3 = Byte1 + Byte2
        lblByte3.Text = Byte3.ToString()
        Short3 = Short1 + Short2
        lblShort3.Text = Short3.ToString()
        Integer3 = Integer1 + Integer2
        lblInteger3.Text = Integer3.ToString()
        Long3 = Long1 + Long2
        lblLong3.Text = Long3.ToString()
        Single3 = Single1 + Single2
        lblSingle3.Text = Single3.ToString()
        Double3 = Double1 + Double2
        lblDouble3.Text = Double3.ToString
        Decimal3 = Decimal1 + Decimal2
        lblDecimal3.Text = Decimal3.ToString()
        lblDate3.Text = Date1.Add(TimeSpan2).ToString

    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click

        'this will take the user input from txtbox 1 and 2, subtract them, and display the result in the last column


        btnDisplay_Click(Nothing, Nothing)
        On Error Resume Next

        lblString3.Text = String3
        Byte3 = Byte1 - Byte2
        lblByte3.Text = Byte3.ToString()
        Short3 = Short1 - Short2
        lblShort3.Text = Short3.ToString()
        Integer3 = Integer1 - Integer2
        lblInteger3.Text = Integer3.ToString()
        Long3 = Long1 - Long2
        lblLong3.Text = Long3.ToString()
        Single3 = Single1 - Single2
        lblSingle3.Text = Single3.ToString()
        Double3 = Double1 - Double2
        lblDouble3.Text = Double3.ToString
        Decimal3 = Decimal1 - Decimal2
        lblDecimal3.Text = Decimal3.ToString()
        lblDate3.Text = Date1.Subtract(TimeSpan2).ToString

    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click

        'this will take the user input from txtbox 1 and 2, multiply them, and display the result in the last column


        btnDisplay_Click(Nothing, Nothing)
        On Error Resume Next

        lblString3.Text = String3
        Byte3 = Byte1 * Byte2
        lblByte3.Text = Byte3.ToString()
        Short3 = Short1 * Short2
        lblShort3.Text = Short3.ToString()
        Integer3 = Integer1 * Integer2
        lblInteger3.Text = Integer3.ToString()
        Long3 = Long1 * Long2
        lblLong3.Text = Long3.ToString()
        Single3 = Single1 * Single2
        lblSingle3.Text = Single3.ToString()
        Double3 = Double1 * Double2
        lblDouble3.Text = Double3.ToString
        Decimal3 = Decimal1 * Decimal2
        lblDecimal3.Text = Decimal3.ToString()


    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click

        'this will take the user input from txtbox 1 and 2, divide them, and display the result in the last column


        btnDisplay_Click(Nothing, Nothing)
        On Error Resume Next

        lblString3.Text = String3
        Byte3 = Byte1 \ Byte2
        lblByte3.Text = Byte3.ToString()
        Short3 = Short1 \ Short2
        lblShort3.Text = Short3.ToString()
        Integer3 = Integer1 \ Integer2
        lblInteger3.Text = Integer3.ToString()
        Long3 = Long1 \ Long2
        lblLong3.Text = Long3.ToString()
        Single3 = Single1 / Single2
        lblSingle3.Text = Single3.ToString()
        Double3 = Double1 / Double2
        lblDouble3.Text = Double3.ToString
        Decimal3 = Decimal1 / Decimal2
        lblDecimal3.Text = Decimal3.ToString()

    End Sub
End Class
