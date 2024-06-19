<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.fullname = New System.Windows.Forms.TextBox()
        Me.link = New System.Windows.Forms.TextBox()
        Me.number = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.time = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label6.Location = New System.Drawing.Point(123, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(354, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Anish, Slidely Task-2 - View Submissions"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(161, 88)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(35, 13)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Name"
        '
        'fullname
        '
        Me.fullname.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fullname.Location = New System.Drawing.Point(256, 86)
        Me.fullname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.fullname.Name = "fullname"
        Me.fullname.Size = New System.Drawing.Size(176, 20)
        Me.fullname.TabIndex = 13
        '
        'link
        '
        Me.link.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.link.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.link.Location = New System.Drawing.Point(256, 222)
        Me.link.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.link.Name = "link"
        Me.link.Size = New System.Drawing.Size(176, 20)
        Me.link.TabIndex = 16
        '
        'number
        '
        Me.number.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.number.Location = New System.Drawing.Point(256, 174)
        Me.number.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.number.Name = "number"
        Me.number.Size = New System.Drawing.Size(176, 20)
        Me.number.TabIndex = 17
        '
        'email
        '
        Me.email.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.email.Location = New System.Drawing.Point(256, 132)
        Me.email.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(176, 20)
        Me.email.TabIndex = 18
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(161, 133)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(32, 13)
        Me.label2.TabIndex = 19
        Me.label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 176)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(161, 223)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Github Link"
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.BackColor = System.Drawing.Color.LightYellow
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(78, 273)
        Me.btnToggleStopwatch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(190, 28)
        Me.btnToggleStopwatch.TabIndex = 22
        Me.btnToggleStopwatch.Text = "Toggle Stopwatch (CTRL + T)"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = False
        '
        'time
        '
        Me.time.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.time.Location = New System.Drawing.Point(359, 279)
        Me.time.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(91, 20)
        Me.time.TabIndex = 23
        Me.time.Text = "00:00:00"
        Me.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LightBlue
        Me.btnSubmit.Location = New System.Drawing.Point(222, 327)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(172, 28)
        Me.btnSubmit.TabIndex = 24
        Me.btnSubmit.Text = "Submit (CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.number)
        Me.Controls.Add(Me.link)
        Me.Controls.Add(Me.fullname)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Label6)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents fullname As TextBox
    Friend WithEvents link As TextBox
    Friend WithEvents number As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents time As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Timer1 As Timer
End Class
