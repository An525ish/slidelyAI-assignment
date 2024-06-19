Public Class CreateSubmissionForm

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.KeyPreview = True ' Ensure that KeyPreview is set to True
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private stopwatchRunning As Boolean = False
    Private stopwatchTime As TimeSpan = TimeSpan.Zero

    Private Sub BtnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        stopwatchRunning = Not stopwatchRunning
        If stopwatchRunning Then
            Timer1.Start()
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If stopwatchRunning Then
            stopwatchTime = stopwatchTime.Add(TimeSpan.FromSeconds(1))
            time.Text = stopwatchTime.ToString("hh\:mm\:ss")
        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Collect data from textboxes
        Dim nameValue As String = fullname.Text
        Dim emailValue As String = email.Text
        Dim phoneValue As String = number.Text
        Dim githubLinkValue As String = link.Text
        Dim stopwatchTimeValue As String = time.Text

        ' Create JSON object
        Dim submission As String = "{" & """name"":""" & nameValue & """," &
                                   """email"":""" & emailValue & """," &
                                   """phone"":""" & phoneValue & """," &
                                   """github_link"":""" & githubLinkValue & """," &
                                   """stopwatch_time"":""" & stopwatchTimeValue & """}"

        ' Make API call to submit the form
        Dim request As Net.HttpWebRequest = Net.HttpWebRequest.Create("http://localhost:3000/submit")
        request.Method = "POST"
        request.ContentType = "application/json"

        Using writer As New IO.StreamWriter(request.GetRequestStream())
            writer.Write(submission)
            writer.Flush()
            writer.Close()
        End Using

        Dim response As Net.HttpWebResponse = request.GetResponse()
        If response.StatusCode = Net.HttpStatusCode.OK Then
            ' Show success message
            MessageBox.Show("Submission successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Show error message
            MessageBox.Show("Submission failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class