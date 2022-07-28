Public Class progressbarstudent
    Dim i As Integer
    Private Sub progressbarstudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ProgressBar1.Maximum = 50
        i = 1
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1
        i += 1
        If i > 50 Then
            Timer1.Enabled = False
            Me.Hide()
            studentwindow.Show()
        End If
    End Sub
End Class