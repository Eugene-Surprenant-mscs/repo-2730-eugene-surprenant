' Name:         Conversion Solution
' Purpose:      Convert a measurement to either centimeters or inches
' Programmer:   Eugene Surprenant on 11/29/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    'converts user input inches to centimeters using a sub procedure

    Private Sub CalcCentimetersSub(ByVal dblMeasurement As Double,
                          ByRef dblResult As Double)
        dblResult = dblMeasurement * 2.54
    End Sub


    'converts user input centimeters to inches using a sub procedure

    Private Sub CalcInchesSub(ByVal dblMeasurement As Double,
                          ByRef dblResult As Double)
        dblResult = dblMeasurement / 2.54
    End Sub

    'converts user input inches to centimeters using a function

    Private Function CalcCentimetersFunc(ByVal dblMeasurement As Double) As Double

        Dim dblResult As Double = dblMeasurement * 2.54
        Return dblResult
    End Function

    'converts user input centimeters to inches using a sub procedure

    Private Function CalcInchesFunc(ByVal dblMeasurement As Double) As Double

        Dim dblResult As Double = dblMeasurement / 2.54
        Return dblResult
    End Function

    'calculates earth weight on selected planet using a sub procedure

    Private Sub CalcWeightSub(ByVal intWeight As Integer,
                          ByRef dblWeight As Double)

        'do some calculations here

        Dim dblGravity As Double

        Select Case cboPlanets.Text
            Case "Mercury", "Mars"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Earth"
                dblGravity = 1
            Case "Jupiter"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
        End Select

        dblWeight = intWeight * dblGravity
    End Sub

    'calculates earth weight on selected planet using a function

    Private Function CalcWeightFunc(ByVal intEarthWeight As Integer) As Double


        Dim dblGravity As Double

        Select Case cboPlanets.Text
            Case "Mercury", "Mars"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Earth"
                dblGravity = 1
            Case "Jupiter"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
        End Select

        Dim dblWeight As Double = intEarthWeight * dblGravity

        Return dblWeight
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMeasurement_Enter(sender As Object, e As EventArgs) Handles txtMeasurement.Enter
        txtMeasurement.SelectAll()
    End Sub

    Private Sub txtMeasurement_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeasurement.KeyPress

        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs) _
    Handles txtMeasurement.TextChanged, radFuncCentimeters.CheckedChanged, radFuncInches.CheckedChanged,
    radSubCentimeters.CheckedChanged, radSubInches.CheckedChanged

        Dim dblMeasurement As Double = 0.0
        Dim dblResult As Double = 0.0


        Double.TryParse(txtMeasurement.Text, dblMeasurement)



        If radSubCentimeters.Checked Then
            CalcCentimetersSub(dblMeasurement, dblResult)

        ElseIf radSubInches.Checked Then
            CalcInchesSub(dblMeasurement, dblResult)

        ElseIf radFuncCentimeters.Checked Then
            dblResult = CalcCentimetersFunc(dblMeasurement)

        ElseIf radFuncInches.Checked Then
            dblResult = CalcInchesFunc(dblMeasurement)

        End If

        'displays the converted result

        lblResult.Text = dblResult.ToString("n2")

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'uses 10.00 for the initial value for txtMeasreument.text

        txtMeasurement.Text = "10.00"

        'loads planets to cboPlanets

        cboPlanets.Items.Add("Mercury")
        cboPlanets.Items.Add("Mars")
        cboPlanets.Items.Add("Venus")
        cboPlanets.Items.Add("Earth")
        cboPlanets.Items.Add("Jupiter")
        cboPlanets.Items.Add("Saturn")
        cboPlanets.Items.Add("Uranus")
        cboPlanets.Items.Add("Neptune")
        cboPlanets.Items.Add("Pluto")
        cboPlanets.SelectedItem = "Earth"
        txtEarthweight.Text = "100"

    End Sub

    Private Sub txtWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEarthweight.KeyPress

        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtWeight_Enter(sender As Object, e As EventArgs) Handles txtEarthweight.Enter

        'selects all the text 

        txtEarthweight.SelectAll()
    End Sub

    Private Sub InputsChanged(sender As Object, e As EventArgs) _
    Handles txtEarthweight.TextChanged, cboPlanets.SelectedIndexChanged,
    RadPlanetFunc.CheckedChanged, RadPlanetSub.CheckedChanged

        Dim intEarthWeight As Integer
        Dim dblWeight As Double

        Integer.TryParse(txtEarthweight.Text, intEarthWeight)

        If RadPlanetSub.Checked Then
            CalcWeightSub(intEarthWeight, dblWeight)

        ElseIf RadPlanetFunc.Checked Then
            dblWeight = CalcWeightFunc(intEarthWeight)
        End If

        'displays the converted result

        lblweight.Text = dblWeight.ToString("n2")

    End Sub

End Class
