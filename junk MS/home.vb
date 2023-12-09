Public Class home
    Dim sidebar As String = "close"

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If sidebar = "open" Then
            GunaPanel1.Width += 25
            If GunaPanel1.Width >= 250 Then
                sidebar = "close"
                Timer1.Stop()
            End If
        Else
            GunaPanel1.Width -= 25
            If GunaPanel1.Width <= 50 Then
                sidebar = "open"
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        Timer1.Start()
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub
End Class
