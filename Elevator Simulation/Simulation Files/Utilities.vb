Module Utilities
    Public Const SECONDS_IN_DAY As Double = 86400

    Function TimeFormatFromDayPart(dayPart As Double) As String
        Dim secondsElapsed As Double = (dayPart / 24.0) * SECONDS_IN_DAY
        Dim currentDate As DateTime = DateTime.Today
        currentDate = currentDate.AddSeconds(secondsElapsed)
        Return (currentDate.ToString("HH:mm:ss"))
    End Function
End Module
