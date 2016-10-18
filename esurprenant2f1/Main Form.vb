' Name:         Treeline Project
' Purpose:      Display the total room charge, tax, 
'               total resort fee, and total due
' Programmer:   Eugene Surprenant on 10/17/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtRooms.TextChanged, txtNights.TextChanged,
        txtAdults.TextChanged, txtChildren.TextChanged, radQueen.CheckedChanged,
        radKing.CheckedChanged, radStandard.CheckedChanged, radAtrium.CheckedChanged, chkParkingFee.CheckedChanged

        ' clear calculated amounts

        lblRoomChg.Text = String.Empty
        lblTax.Text = String.Empty
        lblResortFee.Text = String.Empty
        lblParkingFee.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate and display total room charges,
        'tax, total resort fee, and total due

        Const intMAX_PER_ROOM As Integer = 6
        Const dblDAILY_Room_CHG_QUEEN_STAND As Double = 225.5
        Const dblDAILY_ROOM_CHG_QUEEN_ATRIUM As Double = 275
        Const dblDAILY_ROOM_CHG_KING_STAND As Double = 245.5
        Const dblDAILY_ROOM_CHG_KING_ATRIUM As Double = 325
        Const dblDAILY_PARKING_FEE As Double = 8.5
        Const dblTAX_RATE As Double = 0.1625
        Const dblDAILY_RESORT_FEE As Double = 12.5
        Const strMSG As String = "You have exeeded the maximum guests per room."
        Dim intRoomsReserved As Integer
        Dim intNights As Integer
        Dim intAdults As Integer
        Dim intChildren As Integer
        Dim intNumGuests As Integer
        Dim dblRoomsRequied As Double

        Dim dblParkingFee As Double
        Dim dblDailyRoomCharge As Double
        Dim dblTotalRoomChg As Double
        Dim dblTax As Double
        Dim dblTotalResortFee As Double
        Dim dblTotalDue As Double

        'store input in variables
        Integer.TryParse(txtRooms.Text, intRoomsReserved)
        Integer.TryParse(txtNights.Text, intNights)
        Integer.TryParse(txtAdults.Text, intAdults)
        Integer.TryParse(txtChildren.Text, intChildren)

        'calculate total number of guests
        intNumGuests = intAdults + intChildren

        'calculate number of rooms required
        dblRoomsRequied = intNumGuests / intMAX_PER_ROOM

        'determine whether number of reserved rooms is
        'adequate and then either display a message or 
        'calculate and display the charges


        If intRoomsReserved < dblRoomsRequied Then
            MessageBox.Show(strMSG, "Treeline Resort",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'calculate charges
            If radQueen.Checked Then
                If radStandard.Checked Then
                    dblDailyRoomCharge = dblDAILY_Room_CHG_QUEEN_STAND
                Else
                    dblDailyRoomCharge = dblDAILY_ROOM_CHG_QUEEN_ATRIUM
            End If
            Else
            If radStandard.Checked Then
                dblDailyRoomCharge = dblDAILY_ROOM_CHG_KING_STAND
            Else
                dblDailyRoomCharge = dblDAILY_ROOM_CHG_KING_ATRIUM
            End If
        End If
            dblTotalRoomChg = intRoomsReserved * intNights * dblDailyRoomCharge
            dblTax = dblTotalRoomChg * dblTAX_RATE
            dblTotalResortFee = intRoomsReserved * intNights * dblDAILY_RESORT_FEE
            If chkParkingFee.Checked Then
                dblParkingFee = intNights * dblDAILY_PARKING_FEE
            End If

            dblTotalDue = dblTotalRoomChg + dblTax + dblTotalResortFee + dblParkingFee

        'display charges
        lblRoomChg.Text = dblTotalRoomChg.ToString("n2")
        lblTax.Text = dblTax.ToString("n2")
        lblResortFee.Text = dblTotalResortFee.ToString("n2")
        lblParkingFee.Text = dblParkingFee.ToString("n2")
        lblTotalDue.Text = dblTotalDue.ToString("c2")

        End If
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs
                           ) Handles txtRooms.KeyPress, txtNights.KeyPress,
                           txtAdults.KeyPress, txtChildren.KeyPress
        'allows the text box to accept only numbers and the backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            'cancel the key
            e.Handled = True
        End If

    End Sub

    Private Sub txtRooms_Enter(sender As Object, e As EventArgs) Handles txtRooms.Enter

        'select contents when text box receives focus

        txtRooms.SelectAll()

    End Sub

    Private Sub txtNights_Enter(sender As Object, e As EventArgs) Handles txtNights.Enter

        'select contents when text box receives focus

        txtNights.SelectAll()

    End Sub

    Private Sub txtAdults_Enter(sender As Object, e As EventArgs) Handles txtAdults.Enter

        'select contents when text box receives focus

        txtAdults.SelectAll()

    End Sub

    Private Sub txtChildren_Enter(sender As Object, e As EventArgs) Handles txtChildren.Enter

        'select contents when text box receives focus

        txtChildren.SelectAll()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub lblRoomChg_Click(sender As Object, e As EventArgs) Handles lblRoomChg.Click

    End Sub
End Class
