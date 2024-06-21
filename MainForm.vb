Imports System.Windows.Forms

Public Class MainForm
    Inherits Form

    Private button1 As Button
    Private button2 As Button

    Public Sub New()
        InitializeComponents()
    End Sub

    Private Sub InitializeComponents()
        Me.Text = "Main Form"

        button1 = New Button()
        button1.Text = "Create Submission"
        button1.Location = New Point(50, 50)
        AddHandler button1.Click, AddressOf Me.Button1_Click

        button2 = New Button()
        button2.Text = "View Submissions"
        button2.Location = New Point(50, 100)
        AddHandler button2.Click, AddressOf Me.Button2_Click

        Me.Controls.Add(button1)
        Me.Controls.Add(button2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim createForm As New CreateSubmissionsForm()
        createForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
        Me.Hide()
    End Sub
End Class
