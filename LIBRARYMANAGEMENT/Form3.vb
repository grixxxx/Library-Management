Imports MySql.Data.MySqlClient

Public Class Form3

    Dim mysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim adp As MySqlDataAdapter
    Dim uname As String
    Dim pass As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (MsgBox("Do you wish to edit the information?", vbQuestion + vbYesNo, "Edit")) = vbYes Then
            Button1.Enabled = False
            Call EnableThem()
        End If
    End Sub
    Sub EnableThem()
        accountusername.Enabled = True
        accountname.Enabled = True
        accountemail.Enabled = True
        accountaddress.Enabled = True
        accountphonenumber.Enabled = True
        accountgendercmb.Enabled = True
        Button2.Enabled = True
    End Sub
    Sub DisableThem()
        accountusername.Enabled = False
        accountname.Enabled = False
        accountemail.Enabled = False
        accountaddress.Enabled = False
        accountphonenumber.Enabled = False
        accountgendercmb.Enabled = False
        Button2.Enabled = False
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call DisableThem()
        uname = Form1.usernametxt.Text
        pass = Form1.passwordtxt.Text
        mysqlConn = New MySqlConnection("server=localhost;userid=root;password=root;database=login")
        mysqlConn.Open()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        If (MsgBox("Do you like to update the record?", vbQuestion + vbYesNo, "Edit")) = vbYes Then
            MessageBox.Show("Record has been successfully updated!", "Updated")
            Button1.Enabled = True
            Call DisableThem()
        Else
            accountusername.Undo()
            accountname.Undo()
            accountemail.Undo()
            accountaddress.Undo()
            accountphonenumber.Undo()
            accountgendercmb.Refresh()
            Button1.Enabled = True
            Call DisableThem()

        End If
    End Sub


    Private Sub changepasswordbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changepasswordbtn.Click


        If newpassword.Text = Nothing Or confirmpassword.Text = Nothing Or oldpassword.Text = Nothing Then
            MessageBox.Show("All fields are required!", "Required")
        ElseIf oldpassword.Text <> pass Then
            MsgBox("Invalid Old Password", MsgBoxStyle.Critical, "Invalid")
        ElseIf newpassword.Text <> confirmpassword.Text Then
            MsgBox("New Password and Confirmation Password didn't matched", MsgBoxStyle.Exclamation, "Invalid")
        Else
            COMMAND = New MySqlCommand()
            COMMAND.CommandText = "update login.logininfo set idPassword='" & confirmpassword.Text & "' where idUsername='" & uname & "' "
            COMMAND.Connection = mysqlConn
            COMMAND.ExecuteNonQuery()
            MsgBox("Password Changed", vbInformation, "Password Changed")
            newpassword.Clear()
            confirmpassword.Clear()
            oldpassword.Clear()
        End If











    End Sub
End Class