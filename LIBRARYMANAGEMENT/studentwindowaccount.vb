Public Class studentwindowaccount

    Private Sub studentwindowButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentwindowButton1.Click
        If (MsgBox("Do you wish to edit the information?", vbQuestion + vbYesNo, "Edit")) = vbYes Then
            studentwindowButton1.Enabled = False
            Call EnableThem()
        End If
    End Sub
    Sub EnableThem()
        studentwindowaccountname.Enabled = True
        studentwindowaccountemail.Enabled = True
        sutdentwindowaccountaddress.Enabled = True
        studentwindowaccountphonenumber.Enabled = True
        studentwindowaccountgendercmb.Enabled = True
        studentwindowButton2.Enabled = True
    End Sub
    Sub DisableThem()
        studentwindowaccountname.Enabled = False
        studentwindowaccountemail.Enabled = False
        sutdentwindowaccountaddress.Enabled = False
        studentwindowaccountphonenumber.Enabled = False
        studentwindowaccountgendercmb.Enabled = False
        studentwindowButton2.Enabled = False
    End Sub

    Private Sub studentwindowaccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        studentwindowaccountnumber.Enabled = False
        Call DisableThem()
    End Sub

    Private Sub studentwindowButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentwindowButton2.Click


        If (MsgBox("Do you like to update the record?", vbQuestion + vbYesNo, "Edit")) = vbYes Then
            MessageBox.Show("Record has been successfully updated!", "Updated")
            studentwindowButton1.Enabled = True
            Call DisableThem()
        Else
            studentwindowaccountname.Undo()
            studentwindowaccountemail.Undo()
            sutdentwindowaccountaddress.Undo()
            studentwindowaccountphonenumber.Undo()
            studentwindowaccountgendercmb.Refresh()
            studentwindowButton1.Enabled = True
            Call DisableThem()

        End If
    End Sub

    Private Sub studentwindowchangepasswordbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentwindowchangepasswordbtn.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Do you like to change the password?", vbQuestion + MsgBoxStyle.YesNoCancel, "Change Password")


        If studentwindownewpassword.Text = Nothing Or studentwindowconfirmpassword.Text = Nothing Or studentwindowoldpassword.Text = Nothing Then
            MessageBox.Show("All fields are required!", "Required")


        ElseIf ask = MsgBoxResult.Yes And studentwindownewpassword.Text = studentwindowconfirmpassword.Text And studentwindowoldpassword.Text = "student" Then
            MessageBox.Show("The password has been changed successfully!", "Password Changed")
            studentwindownewpassword.Clear()
            studentwindowconfirmpassword.Clear()
            studentwindowoldpassword.Clear()


        ElseIf studentwindownewpassword.Text <> studentwindowconfirmpassword.Text Then
            MessageBox.Show("The password does not match!", "Incorrect")

        ElseIf studentwindowoldpassword.Text <> "student" Then
            MessageBox.Show("The Old Password is Incorrect!", "Incorrect")


        ElseIf ask = MsgBoxResult.No Then
            studentwindowoldpassword.Clear()
            studentwindownewpassword.Clear()
            studentwindowconfirmpassword.Clear()

        End If

    End Sub
End Class