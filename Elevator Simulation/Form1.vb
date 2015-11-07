Public Class Form1
    'Simulation Engine
    Private WithEvents mSimulator As New ElevatorSimulator

    'Data structures to store results
    Dim dsResults As New DataSet

    'Set up data structures
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtResultsHeader As New DataTable
        With dtResultsHeader
            .TableName = "ResultsHeader"
            .Columns.Add("SimulationID", System.Type.GetType("System.Guid"))
            .Columns.Add("MeanArrivalWaitTime", System.Type.GetType("System.Double"))
        End With
        Me.dgvResultsHeader.DataSource = dtResultsHeader
        Me.dsResults.Tables.Add(dtResultsHeader)
    End Sub

    Private Sub btnSimulate_Click(sender As Object, e As EventArgs) Handles btnSimulate.Click
        Me.gbSettings.Enabled = False
        Me.lblSimulating.Visible = True
        Me.lblSimulating.Text = "Simulating...."
        Me.Cursor = Cursors.WaitCursor
        Me.bwSimulate.RunWorkerAsync(Me.nudIterations.Value)
    End Sub

#Region "Controls to set up simulation"
    Private Sub nudEmployeeCount_ValueChanged(sender As Object, e As EventArgs) Handles nudEmployeeCount.ValueChanged
        Me.mSimulator.EmployeeCount = Me.nudEmployeeCount.Value
    End Sub

    Private Sub nudFloorCount_ValueChanged(sender As Object, e As EventArgs) Handles nudFloorCount.ValueChanged
        Me.mSimulator.FloorCount = Me.nudFloorCount.Value
    End Sub

    Private Sub nudElevatorCount_ValueChanged(sender As Object, e As EventArgs) Handles nudElevatorCount.ValueChanged
        Me.mSimulator.ElevatorCount = Me.nudElevatorCount.Value
    End Sub

    Private Sub dtMeanArriveTime_ValueChanged(sender As Object, e As EventArgs) Handles dtMeanArriveTime.ValueChanged
        Me.mSimulator.MeanArrivalTime = Me.dtMeanArriveTime.Value.TimeOfDay.Hours + (Me.dtMeanArriveTime.Value.TimeOfDay.Minutes / 60.0)
    End Sub

    Private Sub nudArriveTimeStDev_ValueChanged(sender As Object, e As EventArgs) Handles nudArriveTimeStDev.ValueChanged
        Me.mSimulator.ArrivateTimeStandardDeviation = Me.nudArriveTimeStDev.Value / 60.0
    End Sub
#End Region

#Region "Simulation Background Worker"
    Private Sub bwSimulate_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwSimulate.DoWork
        Dim results As String = ""
        For i As Integer = 0 To Convert.ToInt32(e.Argument) - 1
            Me.mSimulator.Simulate()
            results &= Me.mSimulator.SimulationID.ToString & ControlChars.Tab & Me.mSimulator.MeanArrivalWaitTime.ToString & Environment.NewLine
            Me.bwSimulate.ReportProgress((Convert.ToDouble(i + 1) / (Convert.ToDouble(e.Argument))) * 100)
        Next
        e.Result = results.Trim
    End Sub

    Private Sub bwSimulate_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwSimulate.ProgressChanged
        Me.lblSimulating.Text = "Simulating...." & e.ProgressPercentage.ToString() & "%"
    End Sub

    Private Sub bwSimulate_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwSimulate.RunWorkerCompleted
        Me.gbSettings.Enabled = True
        Me.lblSimulating.Visible = False
        Me.Cursor = Cursors.Default

        'Add results to the datatable
        For Each row As String In e.Result.ToString.Split(Environment.NewLine)
            Dim dr As DataRow = Me.dsResults.Tables(0).NewRow
            dr.Item(0) = row.Split(ControlChars.Tab)(0)
            dr.Item(1) = row.Split(ControlChars.Tab)(1)
            Me.dsResults.Tables(0).Rows.Add(dr)
        Next

    End Sub
#End Region



End Class
