Public Class startup
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progressbar.Increment(10)
        percentagelbl.Text = progressbar.Value
        If progressbar.Value = 100 Then
            Me.Hide()
            Dim frm = New Form1
            frm.Show()
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class