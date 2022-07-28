Imports MySql.Data.MySqlClient
Public Class Books
    Dim mysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim adp As MySqlDataAdapter
    Dim adp1 As MySqlDataAdapter
    Dim adp2 As MySqlDataAdapter
    Dim ds As DataSet


    Private Sub bbadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbadd.Click
        bbnew.Enabled = True
        bbedit.Enabled = False
        bbdelete.Enabled = False
        Call EnableThem()
        Call ClearField()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged

        Dim i As Integer

        For i = 0 To ListView2.Items.Count - 1

            If ListView2.Items(i).Selected = True Then
                bookid.Text = ListView2.Items(i).SubItems(0).Text
                bookname.Text = ListView2.Items(i).SubItems(1).Text
                author.Text = ListView2.Items(i).SubItems(2).Text
                publisher.Text = ListView2.Items(i).SubItems(3).Text
                DateTimePicker1.Text = ListView2.Items(i).SubItems(4).Text
                quantity.Text = ListView2.Items(i).SubItems(5).Text
                Exit For
            End If

        Next

        ListView2.Focus()
        ListView2.FullRowSelect = True
        Call DisableThem()
        bbdelete.Enabled = True
        bbedit.Enabled = True
        bookid.Enabled = True


    End Sub

    Private Sub Books_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ListView1.Columns.Add("Issue Number", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Student ID", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Student Name", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Book ID", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Book Name", 135, HorizontalAlignment.Left)
        ListView1.Columns.Add("Author", 135, HorizontalAlignment.Left)
        ListView1.Columns.Add("Issued Date", 130, HorizontalAlignment.Left)
        ListView1.Columns.Add("Quantity", 80, HorizontalAlignment.Left)


        ListView2.Columns.Add("Book ID", 80, HorizontalAlignment.Left)
        ListView2.Columns.Add("Book Name", 200, HorizontalAlignment.Left)
        ListView2.Columns.Add("Author", 200, HorizontalAlignment.Left)
        ListView2.Columns.Add("Publisher", 200, HorizontalAlignment.Left)
        ListView2.Columns.Add("Publication Date", 150, HorizontalAlignment.Left)
        ListView2.Columns.Add("Quantity", 80, HorizontalAlignment.Left)

        ListView3.Columns.Add("Issue Number", 80, HorizontalAlignment.Left)
        ListView3.Columns.Add("Student ID", 80, HorizontalAlignment.Left)
        ListView3.Columns.Add("Student Name", 150, HorizontalAlignment.Left)
        ListView3.Columns.Add("Book ID", 80, HorizontalAlignment.Left)
        ListView3.Columns.Add("Book Name", 135, HorizontalAlignment.Left)
        ListView3.Columns.Add("Author", 85, HorizontalAlignment.Left)
        ListView3.Columns.Add("Issued Date", 130, HorizontalAlignment.Left)
        ListView3.Columns.Add("Quantity", 80, HorizontalAlignment.Left)
        ListView3.Columns.Add("Returned Date", 130, HorizontalAlignment.Left)


        Call DisableThem()
        bbdelete.Enabled = False
        bbupdate.Enabled = False
        bbedit.Enabled = False

        Timer1.Enabled = True
        Timer2.Enabled = True

        returnstudentid.Enabled = False
        returnstudentname.Enabled = False
        returnbookid.Enabled = False
        returnbookname.Enabled = False
        returnbookauthor.Enabled = False
        returnissuedate.Enabled = False
        returnbookquantity.Enabled = False
        bookstudentname.Enabled = False
        TextBox1.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox2.Enabled = False
        TextBox5.Enabled = False
        Textbox6.Enabled = False
        Textbox6.ResetText()


        Dim rn As New Random

        Label20.Text = (rn.Next(1000, 10000))


        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"
        adp = New MySqlDataAdapter("select * from login.book_list", mysqlConn)
        adp1 = New MySqlDataAdapter("select * from login.issue_book", mysqlConn)
        adp2 = New MySqlDataAdapter("select * from login.return_book", mysqlConn)

        Dim dt As New DataTable

        Dim dt1 As New DataTable

        Dim dt2 As New DataTable

        adp.Fill(dt)
        adp1.Fill(dt1)
        adp2.Fill(dt2)
        ListView1.Items.Clear()
        ListView2.Items.Clear()
        ListView3.Items.Clear()

        For Each drow As DataRow In dt1.Rows

            ListView1.Items.Add(drow(0).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(1).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(2).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(3).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(4).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(5).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(6).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(7).ToString())

        Next

        For Each drow As DataRow In dt.Rows

            ListView2.Items.Add(drow(0).ToString())
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(drow(1).ToString())
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(drow(2).ToString())
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(drow(3).ToString())
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(drow(4).ToString())
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(drow(5).ToString())

        Next

        For Each drow As DataRow In dt2.Rows

            ListView3.Items.Add(drow(0).ToString())
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(drow(1).ToString())
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(drow(2).ToString())
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(drow(3).ToString())
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(drow(4).ToString())
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(drow(5).ToString())
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(drow(6).ToString())
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(drow(7).ToString())
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(drow(8).ToString())
        Next



        mysqlConn.Close()

    End Sub

    Private Sub bbnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbnew.Click
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"

        Dim READER As MySqlDataReader

        Dim newitem As New ListViewItem(bookid.Text)

        newitem.SubItems.Add(bookname.Text)
        newitem.SubItems.Add(author.Text)
        newitem.SubItems.Add(publisher.Text)
        newitem.SubItems.Add(DateTimePicker1.Text)
        newitem.SubItems.Add(quantity.Text)

        Try

            mysqlConn.Open()

            Dim cmd1 As String

            cmd1 = "select * from login.book_list where idbook='" & bookid.Text & "' or bookname='" & bookname.Text & "' "

            COMMAND = New MySqlCommand(cmd1, mysqlConn)

            COMMAND.Parameters.Add("idbook", MySqlDbType.Int64).Value = bookid.Text

            READER = COMMAND.ExecuteReader

            If READER.HasRows Then
                MsgBox("The Information your trying to save is already exist", MsgBoxStyle.Exclamation, "Duplication Found")
                mysqlConn.Close()

            Else
                saveBooks()
                ListView2.Items.Add(newitem)
                Call ClearField()
                Call DisableThem()
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlConn.Dispose()
        End Try

    End Sub

    Private Sub saveBooks()

        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"

        Dim READER As MySqlDataReader

        Try

            mysqlConn.Open()
            Dim query As String
            query = "insert into login.book_list (idbook,bookname,author,publisher,publication_date,book_quantity) values ('" & bookid.Text & "','" & bookname.Text & "','" & author.Text & "','" & publisher.Text & "','" & DateTimePicker1.Text & "','" & quantity.Text & "')"
            COMMAND = New MySqlCommand(query, mysqlConn)
            READER = COMMAND.ExecuteReader

            If bookid.Text = "" Or bookname.Text = "" Or author.Text = "" Or publisher.Text = "" Or DateTimePicker1.Text = "" Or quantity.Text = "" Then
                MessageBox.Show("Please fill up all the field", "Add")

            Else
                MsgBox("Record has been successfully saved!", vbInformation, "Saved")
                mysqlConn.Close()
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlConn.Dispose()
        End Try



    End Sub
    Sub EnableThem()
        bookname.Enabled = True
        author.Enabled = True
        publisher.Enabled = True
        DateTimePicker1.Enabled = True
        bbadd.Enabled = True
        quantity.Enabled = True
    End Sub
    Sub DisableThem()
        bookname.Enabled = False
        author.Enabled = False
        publisher.Enabled = False
        DateTimePicker1.Enabled = False
        bbnew.Enabled = False
        quantity.Enabled = False
    End Sub
    Sub ClearField()
        bookid.Clear()
        bookname.Clear()
        author.Clear()
        publisher.Clear()
        DateTimePicker1.Refresh()
        quantity.Clear()
    End Sub
    Private Sub bbupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbupdate.Click
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"

        Dim READER As MySqlDataReader

        Try

            mysqlConn.Open()

            Dim query As String

            query = "update login.book_list set idbook='" & bookid.Text & "',bookname='" & bookname.Text & "',author='" & author.Text & "',publisher='" & publisher.Text & "',publication_date='" & DateTimePicker1.Text & "',book_quantity='" & quantity.Text & "' where idbook='" & bookid.Text & "'"
            COMMAND = New MySqlCommand(query, mysqlConn)
            READER = COMMAND.ExecuteReader

            Dim ask As MsgBoxResult

            ask = MsgBox("Do you like to update the record?", MsgBoxStyle.YesNo, "Update")

            If ask = MsgBoxResult.Yes And ListView2.SelectedItems.Count > 0 Then

                ListView2.SelectedItems(0).SubItems(0).Text = bookid.Text
                ListView2.SelectedItems(0).SubItems(1).Text = bookname.Text
                ListView2.SelectedItems(0).SubItems(2).Text = author.Text
                ListView2.SelectedItems(0).SubItems(3).Text = publisher.Text
                ListView2.SelectedItems(0).SubItems(4).Text = DateTimePicker1.Text
                ListView2.SelectedItems(0).SubItems(5).Text = quantity.Text
                MsgBox("Record has been successfully updated!", vbInformation, "Updated")

            Else

                Call ClearField()
                bbupdate.Enabled = False
                bbdelete.Enabled = False

            End If

            mysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlConn.Dispose()
        End Try


    End Sub

    Private Sub bbdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbdelete.Click

        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"

        Dim READER As MySqlDataReader

        Try
            mysqlConn.Open()

            Dim query As String

            query = "Delete from login.book_list where idbook='" & bookid.Text & "'"
            COMMAND = New MySqlCommand(query, mysqlConn)
            READER = COMMAND.ExecuteReader

            Dim ask As MsgBoxResult

            ask = MsgBox("Do you like to delete the record?", MsgBoxStyle.OkCancel, "Delete")

            If ask = MsgBoxResult.Ok Then

                ListView2.Items.Remove(ListView2.SelectedItems(0))
                MsgBox("Record has been successfully deleted!", vbInformation, "Deleted")
                bbdelete.Enabled = False
                bbupdate.Enabled = False
                bbedit.Enabled = False
                Call ClearField()

            End If

            mysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlConn.Dispose()
        End Try

    End Sub

    Private Sub bookid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles bookid.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
            MsgBox("This field will accept numbers only", MsgBoxStyle.Critical, "Error")

        End If

    End Sub

    Private Sub booksearchbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles booksearchbutton.Click

        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"

        Dim COMMAND As New MySqlCommand("Select * from login.book_list where idbook='" & bookid.Text & "'", mysqlConn)

        COMMAND.Parameters.Add("idbook", MySqlDbType.Int64).Value = bookid.Text

        Dim READER As MySqlDataReader

        mysqlConn.Open()

        READER = COMMAND.ExecuteReader()

        ListView2.SelectedItems.Clear()

        For i = 0 To ListView2.Items.Count - 1

            If ListView2.Items(i).SubItems(0).Text = bookid.Text Then
                ListView2.Items(i).Selected = True

            End If

        Next

        ListView2.Focus()
        Call DisableThem()

        If READER.Read() Then
            bookname.Text = READER(1)
            author.Text = READER(2)
            publisher.Text = READER(3)
            DateTimePicker1.Text = READER(4)
            quantity.Text = READER(5)

        Else
            MsgBox("Book ID is not Registered", MsgBoxStyle.Exclamation, "Not Found")

        End If

        mysqlConn.Close()

    End Sub

    Private Sub issuebookidbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles issuebookidbtn.Click

        'mysqlConn = New MySqlConnection
        ' mysqlConn.ConnectionString = "server=localhost;userid=root;password=NEWdelmer1213!!;database=login"

        'Dim COMMAND As New MySqlCommand("Select * from login.book_list where idbook='" & bookidissue.Text & "'", mysqlConn)

        ' COMMAND.Parameters.Add("idbook", MySqlDbType.Int64).Value = bookidissue.Text

        ' Dim READER As MySqlDataReader


        'mysqlConn.Open()

        'READER = COMMAND.ExecuteReader()



        'If READER.Read() Then
        'TextBox4.Text = READER(1)
        'TextBox2.Text = READER(2)
        'TextBox5.Text = READER(3)
        'Label24.Text = READER(5)
        'box6.Enabled = True
        'End If
        'mysqlConn.Close()


        Dim y As Integer = ListView2.Items.IndexOf(ListView2.FindItemWithText(bookidissue.Text))
        Dim xy As Integer = ListView2.Items(y).SubItems(5).Text
        Label24.Text = xy

        ListView2.SelectedItems.Clear()
        For i = 0 To ListView2.Items.Count - 1



            If ListView2.Items(i).SubItems(0).Text = bookidissue.Text Then
                ListView2.Items(i).Selected = True
                TextBox4.Text = ListView2.SelectedItems(0).SubItems(1).Text
                TextBox2.Text = ListView2.SelectedItems(0).SubItems(2).Text
                TextBox5.Text = ListView2.SelectedItems(0).SubItems(3).Text
                Label24.Text = ListView2.SelectedItems(0).SubItems(5).Text

                Textbox6.Maximum = ListView2.Items(ListView2.SelectedIndices(0)).SubItems(5).Text - 1
                bookid.Clear()
                bookname.Clear()
                author.Clear()
                publisher.Clear()
                DateTimePicker1.ResetText()
                quantity.Clear()


            ElseIf Val(Label24.text) = 1 Then

                Label22.Text = "Unavailable"
                Textbox6.Enabled = False
                issuebookaddbtn.Enabled = False
            ElseIf Val(Label24.text) <> 1 Then

                Label22.Text = "Available"
                Textbox6.Enabled = True
                issuebookaddbtn.Enabled = True

            End If
            MsgBox("Book ID is not Registered")
        Next
        ListView2.Focus()


    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label18.Text = Date.Now.ToString("MM/dd/yyyy hh:mm:ss")
    End Sub

    Private Sub issuebookaddbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles issuebookaddbtn.Click
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"


        Dim rn As New Random

        Dim y As Integer = ListView2.Items.IndexOf(ListView2.FindItemWithText(bookidissue.Text))

        Dim xy As Integer = ListView2.Items(y).SubItems(5).Text - Textbox6.Value

        Dim newitem As New ListViewItem(Label20.Text)

        newitem.SubItems.Add(bookstudentid.Text)
        newitem.SubItems.Add(bookstudentname.Text)
        newitem.SubItems.Add(bookidissue.Text)
        newitem.SubItems.Add(TextBox4.Text)
        newitem.SubItems.Add(TextBox2.Text)
        newitem.SubItems.Add(Label18.Text)
        newitem.SubItems.Add(Textbox6.Text)
        newitem.SubItems.Add(Label15.Text)

        countbook()

        Try


            If bookstudentid.Text = "" Or bookidissue.Text = "" Or Textbox6.Text = "" Or bookstudentname.Text = "" Or TextBox4.Text = "" Or Textbox6.Value = 0 Then
                MessageBox.Show("Please fill up all the field", "Add")

            ElseIf num = 1 Then
                MsgBox("Student cant borrow book, return the first one", vbCritical, "Error")

            Else
                Dim query As String = "insert into login.issue_book (idissue,studentID,studentNAME,bookID,bookNAME,author,issuedDATE,quantity) values ('" & Label20.Text & "','" & bookstudentid.Text & "','" & bookstudentname.Text & "','" & bookidissue.Text & "','" & TextBox4.Text & "','" & TextBox2.Text & "','" & Label18.Text & "','" & Textbox6.Text & "')"
                Dim query2 As String = "update login.book_list set book_quantity='" & xy & "' where idbook='" & bookidissue.Text & "'"
                Dim querystring As String = String.Concat(query, ";", query2)

                Dim COMMAND As New MySqlCommand(querystring, mysqlConn)
                COMMAND.Connection.Open()
                COMMAND.ExecuteNonQuery()

                ListView1.Items.Add(newitem)
                MsgBox("Book Issued!", vbInformation, "Issued")
                Label20.Text = (rn.Next(1000, 10000))
                bookstudentid.Clear()
                bookidissue.Clear()
                bookstudentname.Clear()
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                Textbox6.ResetText()
                ListView2.Items(y).SubItems(5).Text = xy
                mysqlConn.Close()


            End If

            mysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlConn.Dispose()
        End Try

    End Sub
    Private Sub bookstudentid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles bookstudentid.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If

    End Sub

    Private Sub bookidissue_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles bookidissue.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label23.Text = Date.Now.ToString("MM/dd/yyyy hh:mm:ss")
    End Sub

    Private Sub bbedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbedit.Click

        If (MsgBox("Do you wish to edit the information?", vbQuestion + vbYesNo, "Edit")) = vbYes Then
            bbupdate.Enabled = True
            Call EnableThem()
            bbedit.Enabled = False
            bbadd.Enabled = False
            bookid.Enabled = False

        Else
            Call ClearField()
            Call DisableThem()
        End If

    End Sub

    Private Sub issuestudentidbttn_Click(sender As Object, e As EventArgs) Handles issuestudentidbttn.Click
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"

        Dim COMMAND As New MySqlCommand("Select * from login.student_list where studentid='" & bookstudentid.Text & "'", mysqlConn)

        COMMAND.Parameters.Add("studentid", MySqlDbType.Int64).Value = bookstudentid.Text

        Dim READER As MySqlDataReader

        mysqlConn.Open()

        READER = COMMAND.ExecuteReader()

        If READER.Read() Then
            bookstudentname.Text = READER(1)
            TextBox1.Text = READER(3)
            TextBox3.Text = READER(4)

        Else
            MsgBox("Student ID is not Registered", MsgBoxStyle.Exclamation, "Not Found")

        End If

        mysqlConn.Close()

    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged


        If ListView1.SelectedItems.Count > 0 Then
            returnissuenumber.Text = ListView1.SelectedItems(0).Text
            returnstudentid.Text = ListView1.SelectedItems(0).SubItems(1).Text
            returnstudentname.Text = ListView1.SelectedItems(0).SubItems(2).Text
            returnbookid.Text = ListView1.SelectedItems(0).SubItems(3).Text
            returnbookname.Text = ListView1.SelectedItems(0).SubItems(4).Text
            returnbookauthor.Text = ListView1.SelectedItems(0).SubItems(5).Text
            returnissuedate.Text = ListView1.SelectedItems(0).SubItems(6).Text
            returnbookquantity.Text = ListView1.SelectedItems(0).SubItems(7).Text
        End If

        ListView1.Focus()
        ListView1.FullRowSelect = True

    End Sub
    Dim num = 0
    Private Sub countbook()

        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"

        Try
            mysqlConn.Open()
            Dim query As String
            query = "select count(*) from login.issue_book where studentID='" & bookstudentid.Text & "'"
            COMMAND = New MySqlCommand(query, mysqlConn)
            num = COMMAND.ExecuteScalar

            mysqlConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"

        Dim COMMAND As New MySqlCommand("Select * from login.issue_book where idissue='" & returnissuenumber.Text & "'", mysqlConn)

        COMMAND.Parameters.Add("idissue", MySqlDbType.Int64).Value = returnissuenumber.Text

        Dim READER As MySqlDataReader

        mysqlConn.Open()

        READER = COMMAND.ExecuteReader()

        ListView1.SelectedItems.Clear()
        For c = 0 To ListView1.Items.Count - 1

            If ListView1.Items(c).SubItems(0).Text = returnissuenumber.Text Then
                ListView1.Items(c).Selected = True
            End If

        Next

        If READER.Read() Then
            returnstudentid.Text = READER(1)
            returnstudentname.Text = READER(2)
            returnissuedate.Text = READER(6)
            returnbookid.Text = READER(3)
            returnbookname.Text = READER(4)
            returnbookauthor.Text = READER(5)
            returnbookquantity.Text = READER(7)

        Else
            MsgBox("No Borrowed Book Found", MsgBoxStyle.Exclamation, "Not Found")

        End If

        mysqlConn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=login"

        Dim newitem As New ListViewItem(returnissuenumber.Text)

        newitem.SubItems.Add(returnstudentid.Text)
        newitem.SubItems.Add(returnstudentname.Text)
        newitem.SubItems.Add(returnbookid.Text)
        newitem.SubItems.Add(returnbookname.Text)
        newitem.SubItems.Add(returnbookauthor.Text)
        newitem.SubItems.Add(returnissuedate.Text)
        newitem.SubItems.Add(returnbookquantity.Text)
        newitem.SubItems.Add(Label23.Text)


        Dim y As Integer = ListView2.Items.IndexOf(ListView2.FindItemWithText(returnbookid.Text))
        Dim xy As Integer = Val(ListView2.Items(y).SubItems(5).Text) + Val(returnbookquantity.Text)





        If returnissuenumber.Text = "" Then
            MsgBox("Empty filed", vbInformation, "Fill up the required field")

        Else
            Try

                Dim query As String = "insert into login.return_book (idissue,studentid,studentname,bookid,bookname,bookauthor,issueDate,quantity,returnDate) values ('" & returnissuenumber.Text & "','" & returnstudentid.Text & "','" & returnstudentname.Text & "','" & returnbookid.Text & "','" & returnbookname.Text & "','" & returnbookauthor.Text & "','" & returnissuedate.Text & "','" & returnbookquantity.Text & "','" & Label23.Text & "')"
                Dim query2 As String = "update login.book_list set book_quantity='" & xy & "' where idbook='" & returnbookid.Text & "'"
                Dim query3 As String = "Delete from login.issue_book where idissue='" & returnissuenumber.Text & "'"
                Dim querystring As String = String.Concat(query, ";", query2, ";", query3)

                Dim COMMAND As New MySqlCommand(querystring, mysqlConn)
                COMMAND.Connection.Open()
                COMMAND.ExecuteNonQuery()


                ListView3.Items.Add(newitem)
                ListView1.Items.Remove(ListView1.SelectedItems(0))
                MsgBox("Book has been successfully returned", vbInformation, "Book Returned")
                returnissuenumber.Clear()
                returnstudentid.Clear()
                returnstudentname.Clear()
                returnissuedate.Clear()
                returnbookid.Clear()
                returnbookname.Clear()
                returnbookauthor.Clear()
                returnbookquantity.Clear()

                ListView2.Items(y).SubItems(5).Text = xy
                mysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)

            End Try
        End If


    End Sub
End Class