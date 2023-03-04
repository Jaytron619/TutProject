Public Class splashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        loadingPanel.Width += 1
        If loadingPanel.Width >= 557 Then
            Timer1.Stop()
            MainForm.Show()
            Me.Hide()
        End If
    End Sub
End Class
