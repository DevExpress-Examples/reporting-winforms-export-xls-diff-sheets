Imports DevExpress.XtraReports.UI

Public Class XtraReport1
	Private Sub CategoryNameLabel_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CategoryNameLabel.BeforePrint
		Dim categoryNameLabel = CType(sender, XRLabel)
		Dim categoryName = categoryNameLabel.Text.Split("/"c)(0)
		categoryNameLabel.Text = categoryName
		categoryNameLabel.Value = categoryName
	End Sub
End Class
