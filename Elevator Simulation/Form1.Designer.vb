<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.nudArriveTimeStDev = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtMeanArriveTime = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudIterations = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSimulate = New System.Windows.Forms.Button()
        Me.nudElevatorCount = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudFloorCount = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudEmployeeCount = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSimulating = New System.Windows.Forms.Label()
        Me.bwSimulate = New System.ComponentModel.BackgroundWorker()
        Me.dgvResultsHeader = New System.Windows.Forms.DataGridView()
        Me.btnCopyHeader = New System.Windows.Forms.Button()
        Me.dgvResultsDetail = New System.Windows.Forms.DataGridView()
        Me.btnCopyDetail = New System.Windows.Forms.Button()
        Me.gbSettings.SuspendLayout()
        CType(Me.nudArriveTimeStDev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIterations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudElevatorCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFloorCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEmployeeCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResultsHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResultsDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSettings
        '
        Me.gbSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.gbSettings.Size = New System.Drawing.Size(246, 384)
        Me.gbSettings.TabIndex = 0
        Me.gbSettings.TabStop = False
        Me.gbSettings.Text = "Settings"
        '
        'nudArriveTimeStDev
        '
        Me.nudArriveTimeStDev.DecimalPlaces = 1
        Me.nudArriveTimeStDev.Location = New System.Drawing.Point(108, 87)
        Me.nudArriveTimeStDev.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.nudArriveTimeStDev.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudArriveTimeStDev.Name = "nudArriveTimeStDev"
        Me.nudArriveTimeStDev.Size = New System.Drawing.Size(87, 20)
        Me.nudArriveTimeStDev.TabIndex = 7
        Me.nudArriveTimeStDev.Value = New Decimal(New Integer() {45, 0, 0, 0})
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
        'dtMeanArriveTime
        '
        Me.dtMeanArriveTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtMeanArriveTime.Location = New System.Drawing.Point(108, 35)
        Me.dtMeanArriveTime.Name = "dtMeanArriveTime"
        Me.dtMeanArriveTime.Size = New System.Drawing.Size(129, 20)
        Me.dtMeanArriveTime.TabIndex = 3
        Me.dtMeanArriveTime.Value = New Date(2015, 11, 7, 7, 50, 0, 0)
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
        'nudIterations
        '
        Me.nudIterations.Location = New System.Drawing.Point(6, 308)
        Me.nudIterations.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudIterations.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudIterations.Name = "nudIterations"
        Me.nudIterations.Size = New System.Drawing.Size(81, 20)
        Me.nudIterations.TabIndex = 11
        Me.nudIterations.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        Me.btnSimulate.Location = New System.Drawing.Point(6, 346)
        Me.btnSimulate.Name = "btnSimulate"
        Me.btnSimulate.Size = New System.Drawing.Size(231, 32)
        Me.btnSimulate.TabIndex = 12
        Me.btnSimulate.Text = "Simulate"
        Me.btnSimulate.UseVisualStyleBackColor = True
        '
        'nudElevatorCount
        '
        Me.nudElevatorCount.Location = New System.Drawing.Point(6, 143)
        Me.nudElevatorCount.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudElevatorCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudElevatorCount.Name = "nudElevatorCount"
        Me.nudElevatorCount.Size = New System.Drawing.Size(81, 20)
        Me.nudElevatorCount.TabIndex = 9
        Me.nudElevatorCount.Value = New Decimal(New Integer() {2, 0, 0, 0})
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
        'nudFloorCount
        '
        Me.nudFloorCount.Location = New System.Drawing.Point(6, 88)
        Me.nudFloorCount.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudFloorCount.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudFloorCount.Name = "nudFloorCount"
        Me.nudFloorCount.Size = New System.Drawing.Size(81, 20)
        Me.nudFloorCount.TabIndex = 5
        Me.nudFloorCount.Value = New Decimal(New Integer() {5, 0, 0, 0})
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
        'nudEmployeeCount
        '
        Me.nudEmployeeCount.Location = New System.Drawing.Point(6, 36)
        Me.nudEmployeeCount.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudEmployeeCount.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudEmployeeCount.Name = "nudEmployeeCount"
        Me.nudEmployeeCount.Size = New System.Drawing.Size(81, 20)
        Me.nudEmployeeCount.TabIndex = 1
        Me.nudEmployeeCount.Value = New Decimal(New Integer() {500, 0, 0, 0})
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
        Me.dgvResultsHeader.Location = New System.Drawing.Point(266, 33)
        Me.dgvResultsHeader.Name = "dgvResultsHeader"
        Me.dgvResultsHeader.ReadOnly = True
        Me.dgvResultsHeader.Size = New System.Drawing.Size(458, 184)
        Me.dgvResultsHeader.TabIndex = 2
        '
        'btnCopyHeader
        '
        Me.btnCopyHeader.Location = New System.Drawing.Point(266, 223)
        Me.btnCopyHeader.Name = "btnCopyHeader"
        Me.btnCopyHeader.Size = New System.Drawing.Size(146, 23)
        Me.btnCopyHeader.TabIndex = 3
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
        Me.dgvResultsDetail.Size = New System.Drawing.Size(458, 153)
        Me.dgvResultsDetail.TabIndex = 4
        '
        'btnCopyDetail
        '
        Me.btnCopyDetail.Location = New System.Drawing.Point(266, 419)
        Me.btnCopyDetail.Name = "btnCopyDetail"
        Me.btnCopyDetail.Size = New System.Drawing.Size(146, 23)
        Me.btnCopyDetail.TabIndex = 5
        Me.btnCopyDetail.Text = "Copy results to clipboard"
        Me.btnCopyDetail.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 447)
        Me.Controls.Add(Me.btnCopyDetail)
        Me.Controls.Add(Me.dgvResultsDetail)
        Me.Controls.Add(Me.btnCopyHeader)
        Me.Controls.Add(Me.dgvResultsHeader)
        Me.Controls.Add(Me.lblSimulating)
        Me.Controls.Add(Me.gbSettings)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elevator Simulation"
        Me.gbSettings.ResumeLayout(False)
        Me.gbSettings.PerformLayout()
        CType(Me.nudArriveTimeStDev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIterations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudElevatorCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFloorCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEmployeeCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResultsHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResultsDetail, System.ComponentModel.ISupportInitialize).EndInit()
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

End Class
