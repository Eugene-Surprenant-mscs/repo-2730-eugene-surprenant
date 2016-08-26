Public Class mainform


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        frmStarWars.Show()
        Timer1.Enabled = False


        'Me.Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
