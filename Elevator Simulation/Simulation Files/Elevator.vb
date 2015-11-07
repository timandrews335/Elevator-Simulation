Friend Class Elevator
    Private mCurrentFloor As Integer
    Private mDestination As Integer
    Private mOccupantCount As Integer
    Private mMaxOccupants As Integer = 6
    Private mCurrentOccupants As New List(Of Employee)
    Private mPauseTime As Integer = 0
    Private mElevatorID As Integer

    Public Sub Add(e As Employee)
        If Me.mCurrentOccupants.Count < Me.mMaxOccupants Then Me.mCurrentOccupants.Add(e)
    End Sub
    Public Sub New(ID As Integer)
        Me.mElevatorID = ID
    End Sub
    Public ReadOnly Property CurrentOccupants As List(Of Employee)
        Get
            Return Me.mCurrentOccupants
        End Get
    End Property
    Public Property ElevatorID
        Get
            Return Me.mElevatorID
        End Get
        Set(value)
            Me.mElevatorID = value
        End Set
    End Property
    Public Property PauseTime
        Get
            Return Me.mPauseTime
        End Get
        Set(value)
            Me.mPauseTime = value
        End Set
    End Property
    Public Property CurrentFloor As Integer
        Get
            Return Me.mCurrentFloor
        End Get
        Set(value As Integer)
            Me.mCurrentFloor = value
        End Set
    End Property
    Public Property Destination As Integer
        Get
            Return Me.mDestination
        End Get
        Set(value As Integer)
            Me.mDestination = value
        End Set
    End Property
    Public ReadOnly Property OccupantCount
        Get
            Return Me.mCurrentOccupants.Count
        End Get
    End Property
    Public ReadOnly Property MaxFloorNeeded
        Get
            Dim MaxFloor As Integer = 0
            For Each e As Employee In Me.mCurrentOccupants
                If e.Floor > MaxFloor Then
                    MaxFloor = e.Floor
                End If
            Next
            Return MaxFloor
        End Get
    End Property
    Public Property MaxOccupants
        Get
            Return Me.mMaxOccupants
        End Get
        Set(value)
            Me.mMaxOccupants = value
        End Set
    End Property
    'The minimum floor the elevator will need to travel to, based on employees on that need to get off on that floor
    Public ReadOnly Property MinimumFloor As Integer
        Get
            Dim MinFloor As Integer = 99
            For Each e As Employee In Me.mCurrentOccupants
                If e.Floor < MinimumFloor Then
                    MinFloor = e.Floor
                End If
            Next
            Return MinFloor
        End Get
    End Property
End Class