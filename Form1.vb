Public Class Form1
#Region "SET_VALUE"
    Public SV As Double
    Public Door1 As Boolean
    Public Door2 As Boolean
    Public Crush1 As Boolean
    Public Crush2 As Boolean
    Public Val1 As Boolean
    Public Val2 As Boolean
#End Region
#Region "GET_VALUE"
    Public PV As Double
    Public DrPos1 As Integer
    Public DrPos2 As Integer
#End Region
#Region "PROCESS_VALUE"
    Public TotalTime As TimeSpan
    Public CurrentTime As TimeSpan
    Public node(6, 6) As Double
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim S As New CLS_VALVE_TIMER
        S.Location = New Point(10, 10)
        S.Width = 700
        S.Height = 300
        Me.Controls.Add(S)
    End Sub


    'Tester-------------------------------------------------------------------------------
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        CurrentTime = TimeSpan.FromMinutes(TrackBar1.Value)
        Label1.Text = CurrentTime.ToString("hh\:mm\:ss")
    End Sub
End Class
