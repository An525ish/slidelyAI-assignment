Imports System.Net
Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As JArray

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.KeyPreview = True ' Ensure that KeyPreview is set to True
    End Sub

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set text boxes to read-only
        textbox1.ReadOnly = True
        textbox2.ReadOnly = True
        textbox3.ReadOnly = True
        textbox4.ReadOnly = True
        textbox5.ReadOnly = True

        LoadAllSubmissions()
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub LoadAllSubmissions()
        Try
            Dim request As HttpWebRequest = CType(WebRequest.Create("http://localhost:3000/read"), HttpWebRequest)
            request.Method = "GET"

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                If response.StatusCode = HttpStatusCode.OK Then
                    Using reader As New StreamReader(response.GetResponseStream())
                        Dim jsonResponse As String = reader.ReadToEnd()
                        submissions = JArray.Parse(jsonResponse)
                    End Using
                Else
                    MessageBox.Show("Failed to load submissions!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission As JObject = submissions(index)
            textbox1.Text = submission("name").ToString()
            textbox2.Text = submission("email").ToString()
            textbox3.Text = submission("phone").ToString()
            textbox4.Text = submission("github_link").ToString()
            textbox5.Text = submission("stopwatch_time").ToString()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub
End Class
