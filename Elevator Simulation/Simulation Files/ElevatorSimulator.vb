Public Class ElevatorSimulator
    Private mEmployees As New List(Of Employee)
    Private mElevators As New List(Of Elevator)
    Private mElevatorCount As Integer = 2
    Private mEmployeeCount As Integer = 500
    Private mFloorCount As Integer = 5
    Private mCurrentIteration As Integer = 0
    Private mSimulationLog As String
    Private mMeanArrivalWaitTime As Double
    Private mMeanArrivalTime As Double 'Hour of day with decimals
    Private mArrivalTimeStandardDeviation As Double 'Percentage of an hour
    Private mSimulationID As Guid


    Friend Sub Simulate()
        'Reset the SimulationID
        Me.mSimulationID = System.Guid.NewGuid

        'Get list of employees 
        Me.GetEmployees2()


        'Reset array of elevators
        Me.mElevators.Clear()
        For i As Integer = 1 To Me.mElevatorCount
            Me.mElevators.Add(New Elevator(i))
        Next
        For Each el As Elevator In Me.mElevators
            el.CurrentFloor = 1
        Next


        Dim TimeStart As Double = 6 'Static value to start at - 6 AM
        Dim CurrentTime As Double = TimeStart 'Display the time of day of the current iteration in hour doubles
        Dim CurrentTimeString As String = "" 'Display the time of day of the current iteration in hh:mm
        Dim ArrivalWaits As New Queue(Of Employee) 'Queue to store the arrival employees waiting


        Dim simString As String = ""

        'For every 10 seconds of the day
        For i As Integer = 0 To SECONDS_IN_DAY / 10 '10 seconds per iteration of simulation, start as 6 AM
            'Get the current time
            CurrentTime = (Double.Parse(i * 10) / SECONDS_IN_DAY) * 24
            CurrentTimeString = TimeFormatFromDayPart(CurrentTime)


            For Each el As Elevator In Me.mElevators
                'If the elevator is currently paused to let passengers out, decrease pause time by 1
                If el.PauseTime > 0 Then el.PauseTime -= 1

                If el.CurrentFloor > 1 Then
                    For Each passenger As Employee In el.CurrentOccupants.ToArray()
                        If passenger.Floor = el.CurrentFloor Then 'Passenger must get off
                            el.CurrentOccupants.Remove(passenger)
                            el.PauseTime += 1
                            For Each emp As Employee In Me.mEmployees
                                If emp.EmployeeID = passenger.EmployeeID Then
                                    emp.ArriveEndTime = CurrentTime
                                End If
                            Next
                            simString &= CurrentTimeString & "   .Employee " & passenger.EmployeeID & " got off elevator " & el.ElevatorID.ToString & " at floor " & el.CurrentFloor.ToString & Environment.NewLine '***************
                        End If
                    Next
                End If
            Next


            'See which employees have arrived at this time 
            For Each emp As Employee In Me.mEmployees
                If emp.ArriveTime2 <= CurrentTimeString And emp.ArrivedOnboarded = False Then
                    'If the employee works on floor 1, they do not wait
                    If emp.Floor = 1 Then
                        emp.ArriveEndTime = CurrentTime
                    Else 'If the employee needs to travel, add them to the queue
                        ArrivalWaits.Enqueue(emp)
                    End If
                    emp.ArrivedOnboarded = True
                End If
            Next


            'See what floor the elevator is on.  If it is on floor 1, then employees can get on it (dequeue)
            For Each el As Elevator In Me.mElevators
                If el.CurrentFloor = 1 And ArrivalWaits.Count > 0 Then
                    While el.OccupantCount < el.MaxOccupants And ArrivalWaits.Count > 0
                        'Add the employee to the elevator
                        Dim passenger As Employee = ArrivalWaits.Dequeue
                        el.Add(passenger)
                        simString &= CurrentTimeString & "   .Employee " & passenger.EmployeeID & " got on elevator " & el.ElevatorID.ToString & Environment.NewLine '***************
                    End While
                End If
            Next



            For Each el As Elevator In Me.mElevators
                'If the elevator has employees on it, then send it up
                If el.OccupantCount > 0 And el.CurrentFloor < el.MaxFloorNeeded Then
                    If el.PauseTime = 0 Then el.CurrentFloor += 1
                End If

                'If the elevator has no employees on it, and is not on floor 1, and employees are waiting to get on
                If el.OccupantCount = 0 And el.CurrentFloor > 1 And ArrivalWaits.Count > 0 Then
                    If el.PauseTime = 0 Then el.CurrentFloor -= 1
                End If
            Next

            RaiseEvent SimulationCounter(i)
        Next


        'Calculate the average wait time 
        Dim Diff As Double
        For Each em As Employee In Me.mEmployees
            Diff += (em.ArriveEndTime - em.ArriveTime) * 60
        Next
        Diff = Diff / Me.mEmployeeCount
        Me.mMeanArrivalWaitTime = Diff
        Me.mSimulationLog = simString


        RaiseEvent SimulationFinished()
    End Sub

    'Get a normally distributed number
    Private Function BoxMuller(Sigma As Double, Mean As Double) As Double
        Static r As Random
        If r Is Nothing Then r = New Random

        Dim s As Double = 0
        Dim u1 As Double = 0
        Dim u2 As Double = 0
        Static xTurn As Boolean = False

        While s = 0 Or s >= 1
            u1 = r.NextDouble * (1.0 - -1.0) + -1.0
            u2 = r.NextDouble * (1.0 - -1.0) + -1.0
            s = Math.Pow(u1, 2) + Math.Pow(u2, 2)
        End While

        Dim d As Double = Math.Sqrt(-2 * Math.Log(s) / s)
        Dim z1 As Double = u1 * d
        Dim z2 As Double = u2 * d


        Dim RandomValue1 As Double = 0
        xTurn = Not xTurn
        If xTurn Then
            RandomValue1 = z1 * Sigma + Mean
        Else
            RandomValue1 = z2 * Sigma + Mean
        End If
        Return RandomValue1
    End Function

    'Get a random list of employess via Box–Muller
    Private Sub GetEmployees2()
        'Reset the counter
        Me.mCurrentIteration = 0

        'Random number generator
        Dim r As New Random

        mEmployees.Clear()

        For i As Integer = 1 To Me.mEmployeeCount
            Dim em As New Employee(Me.mFloorCount, i)
            With em
                'Generate a random arrive time with Excel (mean of 7:50 AM, std of 45 minutes)
                .ArriveTime = BoxMuller(Me.mArrivalTimeStandardDeviation, Me.mMeanArrivalTime)

                'Generate a random arrive time with Excel (mean of 5:00 PM, std of 30 minutes)
                .LeaveTime = BoxMuller(0.5, 17)

                'The floor they work on is uniformly distributed
                .Floor = r.Next(1, em.FloorSize + 1)
            End With
            mEmployees.Add(em)
            'Update the interface
            'Application.DoEvents()
            Me.mCurrentIteration += 1
            RaiseEvent EmployeeCreationCounter(Me.mCurrentIteration)
        Next
    End Sub

    'Get a random list of employees via Excel & Late-Binding
    Private Sub GetEmployees()
        'Reset the counter
        Me.mCurrentIteration = 0

        'Random number generator
        Dim r As New Random

        'Excel objects
        Dim XL As Object
        Dim WB As Object
        Dim WS As Object

        'We may to to throw an exception if we get any errors
        Dim ex1 As Exception = Nothing

        Try
            XL = CreateObject("Excel.Application")
            WB = XL.Workbooks.Add
            WS = WB.Worksheets(1)
            XL.Visible = False
            XL.DisplayAlerts = False
        Catch ex As Exception
            'Dispose of Excel objects
            WB.Close()
            WB = Nothing
            XL.Quit()
            XL = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(WS)
            Throw New Exception("Could not create Excel objects.")
        End Try



        'Generate a bunch of random employees
        Try
            mEmployees.Clear()

            For i As Integer = 1 To Me.mEmployeeCount
                Dim em As New Employee(Me.mFloorCount, i)
                With em
                    'Generate a random arrive time with Excel (mean of 7:50 AM, std of 45 minutes)
                    WS.cells(1, 1).Formula = "=NORMINV(RAND(),7.83,0.75)"
                    .ArriveTime = WS.cells(1, 1).value

                    'Generate a random arrive time with Excel (mean of 5:00 PM, std of 30 minutes)
                    WS.cells(1, 1).Formula = "=NORMINV(RAND(),17,0.5)"
                    .LeaveTime = WS.cells(1, 1).value

                    'The floor they work on is uniformly distributed
                    .Floor = r.Next(1, em.FloorSize + 1)
                End With
                mEmployees.Add(em)
                'Update the interface
                Application.DoEvents()
                Me.mCurrentIteration += 1
                RaiseEvent EmployeeCreationCounter(Me.mCurrentIteration)
            Next
        Catch ex As Exception
            ex1 = New Exception(ex.Message)
        Finally
            'Dispose of Excel objects
            WB.Close()
            WB = Nothing
            XL.Quit()
            XL = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(WS)
            If Not ex1 Is Nothing Then Throw ex1
        End Try
    End Sub

    'Event to update the progress
    Friend Event SimulationCounter(CurrIteration As Integer)

    'Event to show the simulation is finished
    Friend Event SimulationFinished()

    'Event to update the progress of generationg random employees
    Friend Event EmployeeCreationCounter(CurrIteration As Integer)


#Region "Properties"
    Friend ReadOnly Property SimulationID As Guid
        Get
            Return Me.mSimulationID
        End Get
    End Property
    Friend Property ArrivateTimeStandardDeviation As Double
        Get
            Return Me.mArrivalTimeStandardDeviation
        End Get
        Set(value As Double)
            Me.mArrivalTimeStandardDeviation = value
        End Set
    End Property
    Friend Property MeanArrivalTime As Double
        Get
            Return Me.mMeanArrivalTime
        End Get
        Set(value As Double)
            Me.mMeanArrivalTime = value
        End Set
    End Property
    Friend Property CurrentIteration
        Get
            Return Me.mCurrentIteration
        End Get
        Set(value)
            Me.mCurrentIteration = value
        End Set
    End Property
    Friend Property ElevatorCount As Integer
        Get
            Return Me.mElevatorCount
        End Get
        Set(value As Integer)
            Me.mElevatorCount = value
            Me.mEmployees.Clear()
        End Set
    End Property
    Friend Property EmployeeCount As Integer
        Get
            Return Me.mEmployeeCount
        End Get
        Set(value As Integer)
            Me.mEmployeeCount = value
            Me.mEmployees.Clear()
        End Set
    End Property
    Friend Property FloorCount As Integer
        Get
            Return Me.mFloorCount
        End Get
        Set(value As Integer)
            Me.mFloorCount = value
            Me.mEmployees.Clear()
        End Set
    End Property
    Friend ReadOnly Property Employees As List(Of Employee)
        Get
            Return Me.mEmployees
        End Get
    End Property
    Friend ReadOnly Property SimulationLog() As String
        Get
            Return Me.mSimulationLog
        End Get
    End Property
    Friend ReadOnly Property MeanArrivalWaitTime As Double
        Get
            Return Me.mMeanArrivalWaitTime
        End Get
    End Property

#End Region

End Class
