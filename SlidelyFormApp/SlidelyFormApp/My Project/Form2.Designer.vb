<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.textbox1 = New System.Windows.Forms.TextBox()
        Me.textbox2 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textbox3 = New System.Windows.Forms.TextBox()
        Me.textbox4 = New System.Windows.Forms.TextBox()
        Me.textbox5 = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(187, 127)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Name"
        '
        'textbox1
        '
        Me.textbox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.textbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textbox1.Location = New System.Drawing.Point(313, 125)
        Me.textbox1.Name = "textbox1"
        Me.textbox1.ReadOnly = True
        Me.textbox1.Size = New System.Drawing.Size(234, 22)
        Me.textbox1.TabIndex = 1
        '
        'textbox2
        '
        Me.textbox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.textbox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textbox2.Location = New System.Drawing.Point(313, 177)
        Me.textbox2.Name = "textbox2"
        Me.textbox2.Size = New System.Drawing.Size(234, 22)
        Me.textbox2.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(185, 179)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(41, 16)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Email"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(185, 238)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(97, 16)
        Me.label3.TabIndex = 7
        Me.label3.Text = "Phone Number"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(185, 295)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(75, 16)
        Me.label4.TabIndex = 8
        Me.label4.Text = "GitHub Link"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(185, 354)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(106, 16)
        Me.label5.TabIndex = 9
        Me.label5.Text = "Stopwatch Time."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label6.Location = New System.Drawing.Point(174, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(454, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Anish, Slidely Task-2 - View Submissions"
        '
        'textbox3
        '
        Me.textbox3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.textbox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textbox3.Location = New System.Drawing.Point(313, 236)
        Me.textbox3.Name = "textbox3"
        Me.textbox3.Size = New System.Drawing.Size(234, 22)
        Me.textbox3.TabIndex = 11
        '
        'textbox4
        '
        Me.textbox4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.textbox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textbox4.Location = New System.Drawing.Point(313, 295)
        Me.textbox4.Name = "textbox4"
        Me.textbox4.Size = New System.Drawing.Size(234, 22)
        Me.textbox4.TabIndex = 12
        '
        'textbox5
        '
        Me.textbox5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.textbox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textbox5.Location = New System.Drawing.Point(313, 354)
        Me.textbox5.Name = "textbox5"
        Me.textbox5.Size = New System.Drawing.Size(234, 22)
        Me.textbox5.TabIndex = 13
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.LightYellow
        Me.btnPrevious.Location = New System.Drawing.Point(71, 403)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(160, 35)
        Me.btnPrevious.TabIndex = 14
        Me.btnPrevious.Text = "Previous (CTRL + P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.LightBlue
        Me.btnNext.Location = New System.Drawing.Point(576, 403)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(177, 35)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = "Next (CTRL + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.textbox5)
        Me.Controls.Add(Me.textbox4)
        Me.Controls.Add(Me.textbox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textbox2)
        Me.Controls.Add(Me.textbox1)
        Me.Controls.Add(Me.label1)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents textbox1 As TextBox
    Friend WithEvents textbox2 As TextBox
    Friend WithEvents label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents textbox3 As TextBox
    Friend WithEvents textbox4 As TextBox
    Friend WithEvents textbox5 As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
