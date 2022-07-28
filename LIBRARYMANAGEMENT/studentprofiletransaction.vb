Public Class studentprofiletransaction

    Private Sub studentprofiletransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("Issue Number", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Book Name", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Author", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Issued Date", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Returned Date", 150, HorizontalAlignment.Left)
    End Sub
End Class