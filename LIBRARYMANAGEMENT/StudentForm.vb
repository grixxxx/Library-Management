Imports MySql.Data.MySqlClient

Public Class StudentForm

    Dim mysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim adp As MySqlDataAdapter
    Dim dt As New DataTable


    Private Sub StudentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ListView1.Columns.Add("ID Number", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Name", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Phone Number", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Course", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Year", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Birthday", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Age", 100, HorizontalAlignment.Left)

        Call DisableThem()
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        studentbirthday.Enabled = False

        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"
        adp = New MySqlDataAdapter("select * from login.student_list", mysqlConn)
        Dim dt As New DataTable
        adp.Fill(dt)
        ListView1.Items.Clear()

        For Each drow As DataRow In dt.Rows
            ListView1.Items.Add(drow(0).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(1).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(2).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(3).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(4).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(5).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(6).ToString())
        Next

        studentbirthday.Format = DateTimePickerFormat.Custom

        studentbirthday.CustomFormat = "yyyy/MM/dd"

        mysqlConn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"
        Dim READER As MySqlDataReader

        Dim newitem As New ListViewItem(idnumber.Text.Trim)
        newitem.SubItems.Add(studentname.Text.Trim)
        newitem.SubItems.Add(phonenumber.Text.Trim)
        newitem.SubItems.Add(coursecmb.Text.Trim)
        newitem.SubItems.Add(yrcmb.Text.Trim)
        newitem.SubItems.Add(studentbirthday.Text.Trim)
        newitem.SubItems.Add(studentage.Text.Trim)


        Try

            mysqlConn.Open()
            Dim cmd1 As String
            cmd1 = "select * from login.student_list where studentid='" & idnumber.Text & "' or studentname='" & studentname.Text & "' or studentphonenumber='" & phonenumber.Text & "'"
            COMMAND = New MySqlCommand(cmd1, mysqlConn)
            COMMAND.Parameters.Add("studentid", MySqlDbType.Int64).Value = idnumber.Text
            READER = COMMAND.ExecuteReader

            If READER.HasRows Then
                MsgBox("The Information your trying to save is already exist", MsgBoxStyle.Exclamation, "Duplication Found")
                mysqlConn.Close()

            Else
                saveStudent()
                ListView1.Items.Add(newitem)
                Call ClearField()
                Call DisableThem()
                studentbirthday.Enabled = False
                mysqlConn.Close()
                coursecmb.Text=""
                yrcmb.Text=""
                studentbirthday.ResetText()

            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlConn.Dispose()
        End Try

    End Sub
    Private Sub saveStudent()
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"
        Dim READER As MySqlDataReader


        Try
            mysqlConn.Open()
            Dim query As String
            query = "insert into login.student_list (studentid,studentname,studentphonenumber,studentcourse,yearlevel,birthday,age) values ('" & idnumber.Text & "','" & studentname.Text & "','" & phonenumber.Text & "','" & coursecmb.Text & "','" & yrcmb.Text & "','" & studentbirthday.Text & "','" & studentage.Text & "')"
            COMMAND = New MySqlCommand(query, mysqlConn)
            READER = COMMAND.ExecuteReader

            If idnumber.Text = "" Or studentname.Text = "" Or phonenumber.Text = "" Or coursecmb.Text = "" Then
                MsgBox("All fields are required", MsgBoxStyle.Exclamation, "Required")
            ElseIf phonenumber.TextLength < 11 Then
                MsgBox("Enter Correct Phone Number", MsgBoxStyle.Exclamation, "Incorrect Phone Number")
                phonenumber.Focus()
            ElseIf Not phonenumber.Text.StartsWith(0) Then
                MsgBox("Phone Number should start with 0", MsgBoxStyle.Exclamation, "Incorrect Phone Number")
                phonenumber.Focus()
            Else
                MsgBox("Record has been successfully saved!", MsgBoxStyle.Information, "Saved")
                mysqlConn.Close()
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlConn.Dispose()
        End Try

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call EnableThem()
        Call ClearField()
        Button4.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = False
    End Sub
    Sub EnableThem()
        studentname.Enabled = True
        phonenumber.Enabled = True
        coursecmb.Enabled = True
        yrcmb.Enabled = True
        Button1.Enabled = True
        studentbirthday.Enabled = True
    End Sub
    Sub DisableThem()
        studentname.Enabled = False
        phonenumber.Enabled = False
        coursecmb.Enabled = False
        yrcmb.Enabled = False
        Button1.Enabled = False
        studentage.Enabled = False
    End Sub
    Sub ClearField()
        idnumber.Clear()
        studentname.Clear()
        phonenumber.Clear()
        coursecmb.ResetText()
        yrcmb.ResetText()
        studentage.Text = "0"
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click

        If idnumber.Text = ListView1.SelectedItems(0).SubItems(0).Text Then
            studentname.Text = ListView1.SelectedItems(0).SubItems(1).Text
            phonenumber.Text = ListView1.SelectedItems(0).SubItems(2).Text
            coursecmb.Text = ListView1.SelectedItems(0).SubItems(3).Text
            yrcmb.Text = ListView1.SelectedItems(0).SubItems(4).Text
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"
        Dim READER As MySqlDataReader
        Try
            mysqlConn.Open()
            Dim query As String
            query = "Delete from login.student_list where studentid='" & idnumber.Text & "'"
            COMMAND = New MySqlCommand(query, mysqlConn)
            READER = COMMAND.ExecuteReader

            Dim ask As MsgBoxResult
            ask = MsgBox("Do you like to delete the record?", MsgBoxStyle.OkCancel, "Delete")
            If ask = MsgBoxResult.Ok Then
                ListView1.Items.Remove(ListView1.SelectedItems(0))
                MessageBox.Show("Record has been successfully deleted!", "Deleted")
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                studentbirthday.Enabled = False
                Call ClearField()
                Call DisableThem()
            Else
                Call ClearField()
                Button3.Enabled = False
                Button5.Enabled = False
            End If

            mysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlConn.Dispose()
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"
        Dim READER As MySqlDataReader
        Try
            mysqlConn.Open()
            Dim query As String
            query = "update login.student_list set studentid='" & idnumber.Text & "',studentname='" & studentname.Text & "',studentphonenumber='" & phonenumber.Text & "',studentcourse='" & coursecmb.Text & "',yearlevel='" & yrcmb.Text & "',birthday='" & studentbirthday.Text & "',age='" & studentage.Text & "' where studentid='" & idnumber.Text & "'"
            COMMAND = New MySqlCommand(query, mysqlConn)
            READER = COMMAND.ExecuteReader

            Dim ask As MsgBoxResult
            ask = MsgBox("Do you like to update the record?", MsgBoxStyle.YesNo, "Update")
            If ask = MsgBoxResult.Yes Then
                ListView1.SelectedItems(0).SubItems(0).Text = idnumber.Text
                ListView1.SelectedItems(0).SubItems(1).Text = studentname.Text
                ListView1.SelectedItems(0).SubItems(2).Text = phonenumber.Text
                ListView1.SelectedItems(0).SubItems(3).Text = coursecmb.Text
                ListView1.SelectedItems(0).SubItems(4).Text = yrcmb.Text
                ListView1.SelectedItems(0).SubItems(5).Text = studentbirthday.Text
                ListView1.SelectedItems(0).SubItems(6).Text = studentage.Text
                MessageBox.Show("Record has been successfully updated!", "Updated")
                Call ClearField()
                Button4.Enabled = False
                Button5.Enabled = False
                Button3.Enabled = False
                coursecmb.Text = ""
                yrcmb.Text = ""
                Call DisableThem()
                studentbirthday.Enabled = False

            Else
                Call ClearField()
                Button4.Enabled = False
                Button5.Enabled = False
                Button3.Enabled = False
                coursecmb.ResetText()
                yrcmb.ResetText()
                Call DisableThem()
            End If

            mysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlConn.Dispose()
        End Try

    End Sub

    Private Sub idnumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idnumber.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only", "ID Number")
        End If
    End Sub


    Private Sub phonenumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phonenumber.KeyPress
        If phonenumber.Text.Length >= 11 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Phone Number should not be more than 11 numbers", "Phone Number")
            End If
        End If
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only", "Phone Number")
        End If
    End Sub

    Private Sub studentsearchbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentsearchbutton.Click
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"

        Dim COMMAND As New MySqlCommand("Select * from login.student_list where studentid='" & idnumber.Text & "'", mysqlConn)

        COMMAND.Parameters.Add("studentid", MySqlDbType.Int64).Value = idnumber.Text

        Dim READER As MySqlDataReader

        mysqlConn.Open()

        READER = COMMAND.ExecuteReader()

        ListView1.SelectedItems.Clear()
        For c = 0 To ListView1.Items.Count - 1
            If ListView1.Items(c).SubItems(0).Text = idnumber.Text Then
                ListView1.Items(c).Selected = True
            End If
        Next

        If READER.Read() Then
            studentname.Text = READER(1)
            phonenumber.Text = READER(2)
            coursecmb.Text = READER(3)
            yrcmb.Text = READER(4)
            studentbirthday.Text = READER(5)
            studentage.Text = READER(6)
            Button5.Enabled = True


        Else
            MsgBox("Student ID is not Registered", vbInformation, "Not Registered")
            End If



        mysqlConn.Close()


    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

        If ListView1.SelectedItems.Count > 0 Then
            idnumber.Text = ListView1.SelectedItems(0).Text
            studentname.Text = ListView1.SelectedItems(0).SubItems(1).Text
            phonenumber.Text = ListView1.SelectedItems(0).SubItems(2).Text
            coursecmb.Text = ListView1.SelectedItems(0).SubItems(3).Text
            yrcmb.Text = ListView1.SelectedItems(0).SubItems(4).Text
            studentbirthday.Text = ListView1.SelectedItems(0).SubItems(5).Text
            studentage.Text = ListView1.SelectedItems(0).SubItems(6).Text

        End If

        ListView1.Focus()
        ListView1.FullRowSelect = True

        Button5.Enabled = True
        Button3.Enabled = True
        Call DisableThem()
        studentbirthday.Enabled = False

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If (MsgBox("Do you wish to edit the information?", vbQuestion + vbYesNo, "Edit")) = vbYes Then
            Button4.Enabled = True
            Call EnableThem()
            Button5.Enabled = False
            Button1.Enabled = False
        Else
            Call ClearField()
            Call DisableThem()
        End If
    End Sub

    Private Sub studentage_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only", "Age")
        End If
    End Sub

    Private Sub studentname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles studentname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only", "Student Name")
        End If
    End Sub

    Private Sub studentbirthday_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentbirthday.ValueChanged
        studentbirthday.CustomFormat = "yyyy-MM-dd"

        Dim offset = New Date(1, 1, 1)

        Dim dateOne = studentbirthday.Value
        Dim dateTwo = Date.Now

        Dim diff As TimeSpan = dateTwo - dateOne

        Dim years = (offset + diff).Year - 1
        studentage.Text = years.ToString


    End Sub
End Class