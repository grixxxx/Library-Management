Public Class studentprofilebook

    Private Sub studentprofilebook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("Book Name", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Author", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Publisher", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Published Date", 150, HorizontalAlignment.Left)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListView1.SelectedItems.Clear()
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(0).Text = TextBox1.Text Or ListView1.Items(i).SubItems(1).Text = TextBox1.Text Then
                ListView1.Items(i).Selected = True
            End If
        Next
        ListView1.Focus()
    End Sub
End Class