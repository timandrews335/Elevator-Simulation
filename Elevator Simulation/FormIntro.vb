Public Class FormIntro

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FormIntro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.Text = "Elevator Simulation allows the user to simulate the time it takes for workers arriving to an office at the first floor to make it to their assigned floors.  Currently, only arrival metrics are supported.  A future enhancement will be to include metrics on wait times to leave the building.  " & Environment.NewLine & Environment.NewLine & _
"Inputs are configurable by the end-user for employee count, number of floors in the building, number of elevators available to use, the mean arrival time, the standard deviation of arrival times, and the maximum occupants per elevator." & Environment.NewLine & Environment.NewLine & _
"The time of travel between floors, and the time it takes for an employee to leave an elevator, are set statically at 10 seconds." & Environment.NewLine & Environment.NewLine & _
"Output may be copied to the clipboard for generated a tab-delimited data file."
        Me.Button1.Focus()
    End Sub

 
End Class