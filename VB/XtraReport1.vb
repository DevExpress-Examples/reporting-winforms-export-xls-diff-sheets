Imports DevExpress.XtraReports.UI

Namespace Reporting_Export_Report_Groups_to_Separate_Excel_Sheets
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub CategoryNameLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles CategoryNameLabel.BeforePrint
'INSTANT VB NOTE: The variable categoryNameLabel was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim categoryNameLabel_Renamed = DirectCast(sender, XRLabel)
			Dim categoryName = categoryNameLabel_Renamed.Text.Split("/"c)(0)
			categoryNameLabel_Renamed.Text = categoryName
			categoryNameLabel_Renamed.Value = categoryName
		End Sub
	End Class
End Namespace
