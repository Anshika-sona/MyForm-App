Imports System.Windows.Forms

Public Class ViewSubmissionsForm
    Inherits Form

    Private lstSubmissions As ListBox
    Private button1 As Button
    Private button2 As Button

    Public Sub New()
        InitializeComponents()
    End Sub

    Private Sub InitializeComponents()
        Me.Text = "View Submissions"

        lstSubmissions = New ListBox() With {.Location = New Point(50, 50), .Size = New Size(200, 200)}

        button1 = New Button()
        button1.Text = "Previous"
        button1.Location = New Point(50, 300)
        AddHandler button1.Click, AddressOf Me.Button1_Click

        button2 = New Button()
        button2.Text = "Next"
        button2.Location = New Point(150, 300)
        AddHandler button2.Click, AddressOf Me.Button2_Click

        Me.Controls.Add(lstSubmissions)
        Me.Controls.Add(button1)
        Me.Controls.Add(button2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim mainForm As New MainForm()
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ' Handle next logic
    End Sub
End Class
