Public Class home
    Dim sidebar As String = "close"

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If sidebar = "open" Then
            GunaPanel1.Width += 35
            If GunaPanel1.Width >= 250 Then
                sidebar = "close"
                Timer1.Stop()
            End If
        Else
            GunaPanel1.Width -= 35
            If GunaPanel1.Width <= 50 Then
                sidebar = "open"
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        Timer1.Start()
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub
    'Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles Btn_about.Click
    '    DisplaySystemInformation()
    'End Sub

    ''Public Property LblAbout As Object
    '' Method to display information about the system on the label
    'Public Sub DisplaySystemInformation()
    '    lblabout.Text = "Junkyard Management System" & vbCrLf & vbCrLf &
    '                    "Version: 1.0" & vbCrLf &
    '                    "Developed by: Your Name" & vbCrLf &
    '                    "Description: This system helps in managing junkyard inventory and operations."
    'End Sub

End Class
