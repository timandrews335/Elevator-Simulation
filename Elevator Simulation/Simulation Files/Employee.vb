Friend Class Employee
    Private mArriveTime As Double
    Private mArriveEndTime As Double
    Private mLeaveTime As Double
    Private mFloor As Integer
    Private mFloorSize As Integer
    Private mEmployeeID As Integer
    Private mArrivedOnboarded As Boolean = False


    Sub New(FloorSize As Integer, EmployeeID As Integer)
        Me.mFloorSize = FloorSize
        Me.mEmployeeID = EmployeeID
    End Sub

    Public Property ArrivedOnboarded As Boolean
        Get
            Return Me.mArrivedOnboarded
        End Get
        Set(value As Boolean)
            Me.mArrivedOnboarded = value
        End Set
    End Property
    Public Property ArriveTime As Double
        Get
            Return Me.mArriveTime
        End Get
        Set(value As Double)
            Me.mArriveTime = value
        End Set
    End Property
    Public Property ArriveEndTime As Double
        Get
            Return Me.mArriveEndTime
        End Get
        Set(value As Double)
            Me.mArriveEndTime = value
        End Set
    End Property
    Public Property LeaveTime As Double
        Get
            Return Me.mLeaveTime
        End Get
        Set(value As Double)
            Me.mLeaveTime = value
        End Set
    End Property
    Public Property Floor As Integer
        Get
            Return Me.mFloor
        End Get
        Set(value As Integer)
            If value > Me.mFloorSize Or value < 1 Then
                Throw New Exception("Invalid Floor Size")
            End If
            Me.mFloor = value
        End Set
    End Property
    Public ReadOnly Property ArrivalWaitTime As Double
        Get
            Return Me.mArriveEndTime - Me.mArriveTime
        End Get
    End Property

    Public ReadOnly Property FloorSize As Integer
        Get
            Return Me.mFloorSize
        End Get
    End Property
    Public ReadOnly Property EmployeeID
        Get
            Return Me.mEmployeeID
        End Get
    End Property

    'Formatted in hh:mm
    Public ReadOnly Property ArriveTime2 As String
        Get
            'Return Math.Floor(Me.ArriveTime).ToString("#").PadLeft(2, "0") & ":" & (((Me.ArriveTime - Math.Floor(Me.ArriveTime)) * 60)).ToString("#").PadLeft(2, "0")
            Return TimeFormatFromDayPart(Me.ArriveTime)
        End Get
    End Property
    Public ReadOnly Property LeaveTime2 As String
        Get
            'Return Math.Floor(Me.LeaveTime).ToString("#").PadLeft(2, "0") & ":" & (((Me.LeaveTime - Math.Floor(Me.LeaveTime)) * 60)).ToString("#").PadLeft(2, "0")
            Return TimeFormatFromDayPart(Me.LeaveTime)
        End Get
    End Property
    Public ReadOnly Property ArriveEndTime2 As String
        Get
            'Return Math.Floor(Me.ArriveEndTime).ToString("#").PadLeft(2, "0") & ":" & (((Me.ArriveEndTime - Math.Floor(Me.ArriveEndTime)) * 60)).ToString("#").PadLeft(2, "0")
            Return TimeFormatFromDayPart(Me.ArriveEndTime)
        End Get
    End Property



End Class



