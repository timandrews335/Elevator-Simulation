﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbSettings = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSimulate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSimulating = New System.Windows.Forms.Label()
        Me.bwSimulate = New System.ComponentModel.BackgroundWorker()
        Me.dgvResultsHeader = New System.Windows.Forms.DataGridView()
        Me.btnCopyHeader = New System.Windows.Forms.Button()
        Me.dgvResultsDetail = New System.Windows.Forms.DataGridView()
        Me.btnCopyDetail = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudMaxOccupants = New System.Windows.Forms.NumericUpDown()
        Me.nudArriveTimeStDev = New System.Windows.Forms.NumericUpDown()
        Me.dtMeanArriveTime = New System.Windows.Forms.DateTimePicker()
        Me.nudIterations = New System.Windows.Forms.NumericUpDown()
        Me.nudElevatorCount = New System.Windows.Forms.NumericUpDown()
        Me.nudFloorCount = New System.Windows.Forms.NumericUpDown()
        Me.nudEmployeeCount = New System.Windows.Forms.NumericUpDown()
        Me.colSimulationID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmployeeCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFloorCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colElevatorCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaxOccupantsPerElevator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMeanArriveTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colArriveTimeStandardDeviation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMeanArrivalWaitTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbSettings.SuspendLayout()
        CType(Me.dgvResultsHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResultsDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaxOccupants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudArriveTimeStDev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIterations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudElevatorCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFloorCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEmployeeCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSettings
        '
        Me.gbSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbSettings.Controls.Add(Me.nudMaxOccupants)
        Me.gbSettings.Controls.Add(Me.Label8)
        Me.gbSettings.Controls.Add(Me.nudArriveTimeStDev)
        Me.gbSettings.Controls.Add(Me.Label6)
        Me.gbSettings.Controls.Add(Me.dtMeanArriveTime)
        Me.gbSettings.Controls.Add(Me.Label5)
        Me.gbSettings.Controls.Add(Me.nudIterations)
        Me.gbSettings.Controls.Add(Me.Label4)
        Me.gbSettings.Controls.Add(Me.btnSimulate)
        Me.gbSettings.Controls.Add(Me.nudElevatorCount)
        Me.gbSettings.Controls.Add(Me.Label3)
        Me.gbSettings.Controls.Add(Me.nudFloorCount)
        Me.gbSettings.Controls.Add(Me.Label2)
        Me.gbSettings.Controls.Add(Me.nudEmployeeCount)
        Me.gbSettings.Controls.Add(Me.Label1)
        Me.gbSettings.Location = New System.Drawing.Point(13, 13)
        Me.gbSettings.Name = "gbSettings"
        Me.gbSettings.Size = New System.Drawing.Size(246, 393)
        Me.gbSettings.TabIndex = 0
        Me.gbSettings.TabStop = False
        Me.gbSettings.Text = "Settings"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(105, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Arrive Time Std Dev minute"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Mean Arrive Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Iterations"
        '
        'btnSimulate
        '
        Me.btnSimulate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSimulate.Location = New System.Drawing.Point(6, 355)
        Me.btnSimulate.Name = "btnSimulate"
        Me.btnSimulate.Size = New System.Drawing.Size(231, 32)
        Me.btnSimulate.TabIndex = 12
        Me.btnSimulate.Text = "Simulate"
        Me.btnSimulate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Elevator Count"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Floor Count"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Count"
        '
        'lblSimulating
        '
        Me.lblSimulating.AutoSize = True
        Me.lblSimulating.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimulating.Location = New System.Drawing.Point(15, 414)
        Me.lblSimulating.Name = "lblSimulating"
        Me.lblSimulating.Size = New System.Drawing.Size(131, 24)
        Me.lblSimulating.TabIndex = 1
        Me.lblSimulating.Text = "Simulating...."
        Me.lblSimulating.Visible = False
        '
        'bwSimulate
        '
        Me.bwSimulate.WorkerReportsProgress = True
        '
        'dgvResultsHeader
        '
        Me.dgvResultsHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultsHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultsHeader.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSimulationID, Me.colEmployeeCount, Me.colFloorCount, Me.colElevatorCount, Me.colMaxOccupantsPerElevator, Me.colMeanArriveTime, Me.colArriveTimeStandardDeviation, Me.colMeanArrivalWaitTime})
        Me.dgvResultsHeader.Location = New System.Drawing.Point(266, 33)
        Me.dgvResultsHeader.Name = "dgvResultsHeader"
        Me.dgvResultsHeader.ReadOnly = True
        Me.dgvResultsHeader.Size = New System.Drawing.Size(533, 184)
        Me.dgvResultsHeader.TabIndex = 3
        '
        'btnCopyHeader
        '
        Me.btnCopyHeader.Location = New System.Drawing.Point(266, 223)
        Me.btnCopyHeader.Name = "btnCopyHeader"
        Me.btnCopyHeader.Size = New System.Drawing.Size(146, 23)
        Me.btnCopyHeader.TabIndex = 4
        Me.btnCopyHeader.Text = "Copy results to clipboard"
        Me.btnCopyHeader.UseVisualStyleBackColor = True
        '
        'dgvResultsDetail
        '
        Me.dgvResultsDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultsDetail.Location = New System.Drawing.Point(266, 260)
        Me.dgvResultsDetail.Name = "dgvResultsDetail"
        Me.dgvResultsDetail.ReadOnly = True
        Me.dgvResultsDetail.Size = New System.Drawing.Size(533, 153)
        Me.dgvResultsDetail.TabIndex = 5
        '
        'btnCopyDetail
        '
        Me.btnCopyDetail.Location = New System.Drawing.Point(266, 419)
        Me.btnCopyDetail.Name = "btnCopyDetail"
        Me.btnCopyDetail.Size = New System.Drawing.Size(146, 23)
        Me.btnCopyDetail.TabIndex = 6
        Me.btnCopyDetail.Text = "Copy results to clipboard"
        Me.btnCopyDetail.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(265, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Results"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(418, 419)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear all results"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(721, 419)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(105, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Max occupants per elevator"
        '
        'nudMaxOccupants
        '
        Me.nudMaxOccupants.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Elevator_Simulation.My.MySettings.Default, "MaxOccupantsPerElevator", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nudMaxOccupants.Location = New System.Drawing.Point(108, 143)
        Me.nudMaxOccupants.Maximum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.nudMaxOccupants.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudMaxOccupants.Name = "nudMaxOccupants"
        Me.nudMaxOccupants.Size = New System.Drawing.Size(81, 20)
        Me.nudMaxOccupants.TabIndex = 14
        Me.nudMaxOccupants.Value = Global.Elevator_Simulation.My.MySettings.Default.MaxOccupantsPerElevator
        '
        'nudArriveTimeStDev
        '
        Me.nudArriveTimeStDev.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Elevator_Simulation.My.MySettings.Default, "ArriveTimeStandardDeviation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nudArriveTimeStDev.DecimalPlaces = 1
        Me.nudArriveTimeStDev.Location = New System.Drawing.Point(108, 87)
        Me.nudArriveTimeStDev.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.nudArriveTimeStDev.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudArriveTimeStDev.Name = "nudArriveTimeStDev"
        Me.nudArriveTimeStDev.Size = New System.Drawing.Size(87, 20)
        Me.nudArriveTimeStDev.TabIndex = 7
        Me.nudArriveTimeStDev.Value = Global.Elevator_Simulation.My.MySettings.Default.ArriveTimeStandardDeviation
        '
        'dtMeanArriveTime
        '
        Me.dtMeanArriveTime.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Elevator_Simulation.My.MySettings.Default, "MeanArriveTime", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtMeanArriveTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtMeanArriveTime.Location = New System.Drawing.Point(108, 35)
        Me.dtMeanArriveTime.Name = "dtMeanArriveTime"
        Me.dtMeanArriveTime.Size = New System.Drawing.Size(129, 20)
        Me.dtMeanArriveTime.TabIndex = 3
        Me.dtMeanArriveTime.Value = Global.Elevator_Simulation.My.MySettings.Default.MeanArriveTime
        '
        'nudIterations
        '
        Me.nudIterations.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Elevator_Simulation.My.MySettings.Default, "Iterations", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nudIterations.Location = New System.Drawing.Point(6, 308)
        Me.nudIterations.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudIterations.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudIterations.Name = "nudIterations"
        Me.nudIterations.Size = New System.Drawing.Size(81, 20)
        Me.nudIterations.TabIndex = 11
        Me.nudIterations.Value = Global.Elevator_Simulation.My.MySettings.Default.Iterations
        '
        'nudElevatorCount
        '
        Me.nudElevatorCount.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Elevator_Simulation.My.MySettings.Default, "ElevatorCount", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nudElevatorCount.Location = New System.Drawing.Point(6, 143)
        Me.nudElevatorCount.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudElevatorCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudElevatorCount.Name = "nudElevatorCount"
        Me.nudElevatorCount.Size = New System.Drawing.Size(81, 20)
        Me.nudElevatorCount.TabIndex = 9
        Me.nudElevatorCount.Value = Global.Elevator_Simulation.My.MySettings.Default.ElevatorCount
        '
        'nudFloorCount
        '
        Me.nudFloorCount.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Elevator_Simulation.My.MySettings.Default, "FloorCount", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nudFloorCount.Location = New System.Drawing.Point(6, 88)
        Me.nudFloorCount.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudFloorCount.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudFloorCount.Name = "nudFloorCount"
        Me.nudFloorCount.Size = New System.Drawing.Size(81, 20)
        Me.nudFloorCount.TabIndex = 5
        Me.nudFloorCount.Value = Global.Elevator_Simulation.My.MySettings.Default.FloorCount
        '
        'nudEmployeeCount
        '
        Me.nudEmployeeCount.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Elevator_Simulation.My.MySettings.Default, "EmployeeCount", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nudEmployeeCount.Location = New System.Drawing.Point(6, 36)
        Me.nudEmployeeCount.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudEmployeeCount.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudEmployeeCount.Name = "nudEmployeeCount"
        Me.nudEmployeeCount.Size = New System.Drawing.Size(81, 20)
        Me.nudEmployeeCount.TabIndex = 1
        Me.nudEmployeeCount.Value = Global.Elevator_Simulation.My.MySettings.Default.EmployeeCount
        '
        'colSimulationID
        '
        Me.colSimulationID.DataPropertyName = "SimulationID"
        Me.colSimulationID.HeaderText = "ID"
        Me.colSimulationID.Name = "colSimulationID"
        Me.colSimulationID.ReadOnly = True
        Me.colSimulationID.Width = 50
        '
        'colEmployeeCount
        '
        Me.colEmployeeCount.DataPropertyName = "EmployeeCount"
        Me.colEmployeeCount.HeaderText = "Employees"
        Me.colEmployeeCount.Name = "colEmployeeCount"
        Me.colEmployeeCount.ReadOnly = True
        Me.colEmployeeCount.Width = 70
        '
        'colFloorCount
        '
        Me.colFloorCount.DataPropertyName = "FloorCount"
        Me.colFloorCount.HeaderText = "Floors"
        Me.colFloorCount.Name = "colFloorCount"
        Me.colFloorCount.ReadOnly = True
        Me.colFloorCount.Width = 40
        '
        'colElevatorCount
        '
        Me.colElevatorCount.DataPropertyName = "ElevatorCount"
        Me.colElevatorCount.HeaderText = "Elevators"
        Me.colElevatorCount.Name = "colElevatorCount"
        Me.colElevatorCount.ReadOnly = True
        Me.colElevatorCount.Width = 60
        '
        'colMaxOccupantsPerElevator
        '
        Me.colMaxOccupantsPerElevator.DataPropertyName = "MaxOccupantsPerElevator"
        Me.colMaxOccupantsPerElevator.HeaderText = "Max per Elevator"
        Me.colMaxOccupantsPerElevator.Name = "colMaxOccupantsPerElevator"
        Me.colMaxOccupantsPerElevator.ReadOnly = True
        Me.colMaxOccupantsPerElevator.Width = 70
        '
        'colMeanArriveTime
        '
        Me.colMeanArriveTime.DataPropertyName = "MeanArriveTime"
        Me.colMeanArriveTime.HeaderText = "Mean Arrive Time"
        Me.colMeanArriveTime.Name = "colMeanArriveTime"
        Me.colMeanArriveTime.ReadOnly = True
        Me.colMeanArriveTime.Width = 65
        '
        'colArriveTimeStandardDeviation
        '
        Me.colArriveTimeStandardDeviation.DataPropertyName = "ArriveTimeStandardDeviation"
        Me.colArriveTimeStandardDeviation.HeaderText = "Arrive SD"
        Me.colArriveTimeStandardDeviation.Name = "colArriveTimeStandardDeviation"
        Me.colArriveTimeStandardDeviation.ReadOnly = True
        Me.colArriveTimeStandardDeviation.Width = 65
        '
        'colMeanArrivalWaitTime
        '
        Me.colMeanArrivalWaitTime.DataPropertyName = "MeanArrivalWaitTime"
        Me.colMeanArrivalWaitTime.HeaderText = "Mean Arrival Wait Time"
        Me.colMeanArrivalWaitTime.Name = "colMeanArrivalWaitTime"
        Me.colMeanArrivalWaitTime.ReadOnly = True
        Me.colMeanArrivalWaitTime.Width = 70
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 456)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCopyDetail)
        Me.Controls.Add(Me.dgvResultsDetail)
        Me.Controls.Add(Me.btnCopyHeader)
        Me.Controls.Add(Me.dgvResultsHeader)
        Me.Controls.Add(Me.lblSimulating)
        Me.Controls.Add(Me.gbSettings)
        Me.MinimumSize = New System.Drawing.Size(752, 486)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elevator Simulation"
        Me.gbSettings.ResumeLayout(False)
        Me.gbSettings.PerformLayout()
        CType(Me.dgvResultsHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResultsDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaxOccupants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudArriveTimeStDev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIterations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudElevatorCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFloorCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEmployeeCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbSettings As System.Windows.Forms.GroupBox
    Friend WithEvents nudElevatorCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudFloorCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudEmployeeCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSimulate As System.Windows.Forms.Button
    Friend WithEvents lblSimulating As System.Windows.Forms.Label
    Friend WithEvents bwSimulate As System.ComponentModel.BackgroundWorker
    Friend WithEvents nudIterations As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtMeanArriveTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nudArriveTimeStDev As System.Windows.Forms.NumericUpDown
    Friend WithEvents dgvResultsHeader As System.Windows.Forms.DataGridView
    Friend WithEvents btnCopyHeader As System.Windows.Forms.Button
    Friend WithEvents dgvResultsDetail As System.Windows.Forms.DataGridView
    Friend WithEvents btnCopyDetail As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents nudMaxOccupants As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents colSimulationID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEmployeeCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFloorCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colElevatorCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMaxOccupantsPerElevator As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMeanArriveTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colArriveTimeStandardDeviation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMeanArrivalWaitTime As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
