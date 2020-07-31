Public Class Form1


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TrackBar1.Value <= 99 Then
            TrackBar1.Value = TrackBar1.Value + 1
        Else
            TrackBar1.Value = 0
        End If


    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged
        Label2.Text = TrackBar1.Value
        If TrackBar1.Value < (Setpoint.Text - Hysteresis.Value) Then
            PumpOn.Checked = True
        Else
            PumpOn.Checked = False

        End If

        If TrackBar1.Value > Setpoint.Text Then
            PumpOn.Checked = False

        End If
    End Sub
End Class
