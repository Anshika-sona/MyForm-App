Imports System.Windows.Forms

Public Class CreateSubmissionsForm
    Inherits Form

    Private txtName As TextBox
    Private txtEmail As TextBox
    Private txtPhoneNumber As TextBox
    Private txtGithubLink As TextBox
    Private txtStopWatchTime As TextBox
    Private button1 As Button
    Private button2 As Button

    Public Sub New()
        InitializeComponents()
    End Sub

    Private Sub InitializeComponents()
        Me.Text = "Create Submission"

        txtName = New TextBox() With {.PlaceholderText = "Name", .Location = New Point(50, 50)}
        txtEmail = New TextBox() With {.PlaceholderText = "Email", .Location = New Point(50, 100)}
        txtPhoneNumber = New TextBox() With {.PlaceholderText = "Phone Number", .Location = New Point(50, 150)}
        txtGithubLink = New TextBox() With {.PlaceholderText = "GitHub Link", .Location = New Point(50, 200)}
        txtStopWatchTime = New TextBox() With {.PlaceholderText = "Stop Watch Time", .Location = New Point(50, 250)}

        button1 = New Button()
        button1.Text = "Previous"
        button1.Location = New Point(50, 300)
        AddHandler button1.Click, AddressOf Me.Button1_Click

        button2 = New Button()
        button2.Text = "Next"
        button2.Location = New Point(150, 300)
        AddHandler button2.Click, AddressOf Me.Button2_Click

        Me.Controls.Add(txtName)
        Me.Controls.Add(txtEmail)
        Me.Controls.Add(txtPhoneNumber)
        Me.Controls.Add(txtGithubLink)
        Me.Controls.Add(txtStopWatchTime)
        Me.Controls.Add(button1)
        Me.Controls.Add(button2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim mainForm As New MainForm()
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ' Store the submission data logic here

        ' Clear fields after storing
        txtName.Clear()
        txtEmail.Clear()
        txtPhoneNumber.Clear()
        txtGithubLink.Clear()
        txtStopWatchTime.Clear()
    End Sub
End Class
