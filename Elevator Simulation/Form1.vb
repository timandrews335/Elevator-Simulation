Public Class Form1
    'Simulation Engine
    Private WithEvents mSimulator As New ElevatorSimulator

    'Data structures to store results
    Dim dsResults As New DataSet


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set up data structures
        Dim dtResultsHeader As New DataTable
        With dtResultsHeader
            .TableName = "ResultsHeader"
            .Columns.Add("SimulationID", System.Type.GetType("System.Guid"))
            .Columns.Add("MeanArrivalWaitTime", System.Type.GetType("System.Double"))
            .Columns.Add("EmployeeCount", System.Type.GetType("System.Int32"))
            .Columns.Add("FloorCount", System.Type.GetType("System.Int32"))
            .Columns.Add("ElevatorCount", System.Type.GetType("System.Int32"))
            .Columns.Add("MeanArriveTime", System.Type.GetType("System.Double"))
            .Columns.Add("ArriveTimeStandardDeviation", System.Type.GetType("System.Double"))
            .Columns(0).Caption = "Sim ID"
            .Columns(1).Caption = "Mean Arrival Wait Time"
            .Columns(2).Caption = "Employee Count"
            .Columns(3).Caption = "Floor Count"
            .Columns(4).Caption = "Elevator Count"
            .Columns(5).Caption = "Mean Arrive Time"
            .Columns(6).Caption = "Arrive Time Standard Deviation"
        End With
        Me.dgvResultsHeader.DataSource = dtResultsHeader
        Me.dsResults.Tables.Add(dtResultsHeader)

        Dim dtResultsDetail As New DataTable
        With dtResultsDetail
            .TableName = "ResultsDetail"
            .Columns.Add("SimulationID", System.Type.GetType("System.Guid"))
            .Columns.Add("EmployeeID ", System.Type.GetType("System.Int32"))
            .Columns.Add("Floor ", System.Type.GetType("System.Int32"))
            .Columns.Add("ArriveTime ", System.Type.GetType("System.Double"))
            .Columns.Add("ArriveEndTime ", System.Type.GetType("System.Double"))
            .Columns.Add("ArrivalWaitTime ", System.Type.GetType("System.Double"))
        End With
        Me.dgvResultsDetail.DataSource = dtResultsDetail
        Me.dsResults.Tables.Add(dtResultsDetail)

        'Relate the tables together
        Dim dr As New DataRelation("Results", dtResultsHeader.Columns(0), dtResultsDetail.Columns(0))
    End Sub

    Private Sub btnSimulate_Click(sender As Object, e As EventArgs) Handles btnSimulate.Click
        Me.gbSettings.Enabled = False
        Me.lblSimulating.Visible = True
        Me.lblSimulating.Text = "Simulating...."
        Me.Cursor = Cursors.WaitCursor
        Me.bwSimulate.RunWorkerAsync(Me.nudIterations.Value)
    End Sub

    Private Sub btnCopyHeader_Click(sender As Object, e As EventArgs) Handles btnCopyHeader.Click
        My.Computer.Clipboard.SetText(CopyDataTable(Me.dsResults.Tables(0)))
    End Sub

    Private Sub btnCopyDetail_Click(sender As Object, e As EventArgs) Handles btnCopyDetail.Click
        My.Computer.Clipboard.SetText(CopyDataTable(Me.dsResults.Tables(1)))
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
        Dim results(1) As String
        results(0) = ""
        results(1) = ""
        For i As Integer = 0 To Convert.ToInt32(e.Argument) - 1
            Me.mSimulator.Simulate()

            'String to store tab-delimeted header information
            results(0) &= Me.mSimulator.SimulationID.ToString & _
                ControlChars.Tab & Me.mSimulator.MeanArrivalWaitTime.ToString & ControlChars.Tab & _
                Me.mSimulator.EmployeeCount.ToString & ControlChars.Tab & Me.mSimulator.FloorCount.ToString & _
                ControlChars.Tab & Me.mSimulator.ElevatorCount.ToString & _
                ControlChars.Tab & Me.mSimulator.MeanArrivalTime.ToString & _
                ControlChars.Tab & Me.mSimulator.ArrivateTimeStandardDeviation.ToString & Environment.NewLine


            'String to store tab-delimeted detail information
            For Each em As Employee In Me.mSimulator.Employees
                results(1) &= Me.mSimulator.SimulationID.ToString & ControlChars.Tab & _
                em.EmployeeID.ToString & ControlChars.Tab & _
                em.Floor.ToString & ControlChars.Tab & _
                em.ArriveTime.ToString & ControlChars.Tab & _
                em.ArriveEndTime.ToString & ControlChars.Tab & _
                (em.ArrivalWaitTime * 60).ToString & ControlChars.Tab & Environment.NewLine
            Next

            Me.bwSimulate.ReportProgress((Convert.ToDouble(i + 1) / (Convert.ToDouble(e.Argument))) * 100)
        Next
        results(0) = results(0).Trim
        results(1) = results(1).Trim
        e.Result = results
    End Sub

    Private Sub bwSimulate_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwSimulate.ProgressChanged
        Me.lblSimulating.Text = "Simulating...." & e.ProgressPercentage.ToString() & "%"
    End Sub

    Private Sub bwSimulate_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwSimulate.RunWorkerCompleted
        Me.gbSettings.Enabled = True
        Me.lblSimulating.Visible = False
        Me.Cursor = Cursors.Default

        'Add results to the header datatable
        For Each row As String In e.Result(0).ToString.Split(Environment.NewLine)
            Dim dr As DataRow = Me.dsResults.Tables(0).NewRow
            dr.Item(0) = row.Split(ControlChars.Tab)(0)
            dr.Item(1) = row.Split(ControlChars.Tab)(1)
            dr.Item(2) = row.Split(ControlChars.Tab)(2)
            dr.Item(3) = row.Split(ControlChars.Tab)(3)
            dr.Item(4) = row.Split(ControlChars.Tab)(4)
            dr.Item(5) = row.Split(ControlChars.Tab)(5)
            dr.Item(6) = row.Split(ControlChars.Tab)(6)
            Me.dsResults.Tables(0).Rows.Add(dr)
        Next

        'Add results to the detail datatable
        For Each row As String In e.Result(1).ToString.Split(Environment.NewLine)
            Dim dr As DataRow = Me.dsResults.Tables(1).NewRow
            dr.Item(0) = row.Split(ControlChars.Tab)(0)
            dr.Item(1) = row.Split(ControlChars.Tab)(1)
            dr.Item(2) = row.Split(ControlChars.Tab)(2)
            dr.Item(3) = row.Split(ControlChars.Tab)(3)
            dr.Item(4) = row.Split(ControlChars.Tab)(4)
            dr.Item(5) = row.Split(ControlChars.Tab)(5)
            Me.dsResults.Tables(1).Rows.Add(dr)
        Next

    End Sub
#End Region

    'Copies a DataTable contents to the clipboard
    Private Function CopyDataTable(dt As DataTable) As String
        Dim s As String = ""
        For Each dc As DataColumn In dt.Columns
            s &= dc.ColumnName & ControlChars.Tab
        Next
        s = s.Trim
        s &= Environment.NewLine
        For Each dr As DataRow In dt.Rows
            For Each dc As DataColumn In dt.Columns
                s &= dr.Item(dc.ColumnName).ToString & ControlChars.Tab
            Next
            s = s.Trim
            s &= Environment.NewLine
        Next
        Return s
    End Function





End Class
