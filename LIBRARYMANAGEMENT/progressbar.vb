Public Class progressbar
    Dim i As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ProgressBar1.Value = ProgressBar1.Value + 1
        i += 1
        If i > 20 Then
            Timer1.Enabled = False
            Me.Hide()
            Form2.Show()
        End If


    End Sub

    Private Sub progressbar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ProgressBar1.Maximum = 20
        i = 1
        
    End Sub
End Class