Imports MySql.Data.MySqlClient

Public Class Form1
    Dim mysqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim adp As MySqlDataAdapter
    Dim ds As DataSet

    Private Sub loginbttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginbttn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=login"


        Try
            mysqlconn.Open()
            ds = New DataSet
            adp = New MySqlDataAdapter("select * from login.logininfo where idUsername='" & usernametxt.Text & "' and idPassword='" & passwordtxt.Text & "'", mysqlconn)
            adp.Fill(ds, "Login")

            If (ds.Tables("Login").Rows.Count > 0) Then
                progressbar.Show()
                Me.Hide()

            Else
                MessageBox.Show("Invalid Username and Password Combination", "Invalid")

            End If

            mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()
        End Try



    End Sub

    Private Sub closebttn_Click_1(sender As Object, e As EventArgs) Handles closebttn.Click
        Application.Exit()
    End Sub
End Class
