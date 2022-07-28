Public Class Form2
    
    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub StudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem.Click
        switchPanel(StudentForm)
    End Sub

    Private Sub BooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksToolStripMenuItem.Click
        switchPanel(Books)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        If (MsgBox("Are you sure you want to log out?", vbQuestion + vbYesNo, "Log Out")) = vbYes Then
            Form1.Show()
            Form1.usernametxt.Clear()
            Form1.passwordtxt.Clear()
            Me.Hide()

        End If
    End Sub

    Private Sub AccountSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountSettingsToolStripMenuItem.Click
        switchPanel(Form3)
    End Sub
End Class