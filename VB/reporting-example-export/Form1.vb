Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Partial Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        Dim report = New XtraReport1()

        ' Set the DetailReport band's PageBreak property to AfterBand
        ' to print each product category on a new report page.
        report.Bands(BandKind.DetailReport).PageBreak = PageBreak.AfterBand

        ' Set the report's RollPaper property to true
        ' to fit each product category to one report page.
        report.RollPaper = True

        ' Use SingleFilePageByPage mode
        ' to export each page of the report to a separate sheet.
        Dim xlsxExportOptions = New XlsxExportOptions With {
                .ExportMode = XlsxExportMode.SingleFilePageByPage,
                .ShowGridLines = True
            }

        ' Use the label's PrintOnPage event to save the names of all the categories to a list.
        Dim categoriesNames = New List(Of String)()

        AddHandler report.Bands(BandKind.Detail).Controls("CategoryNameLabel").PrintOnPage, Sub(s1, e1)
                                                                                                Dim categoryNameLabel = CType(s1, XRLabel)
                                                                                                categoriesNames.Add(categoryNameLabel.Text)
                                                                                            End Sub

        ' Use the XlSheetCreated event to change the default name of each sheet
        ' to the category name.
        AddHandler report.PrintingSystem.XlSheetCreated, Sub(s2, e2)
                                                             e2.SheetName = categoriesNames(e2.Index)
                                                         End Sub

        ' Export the report to Excel format. Save the exported file
        ' to the project directory.
        Dim projectDirPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))

        Dim xlsxFilePath = Path.Combine(projectDirPath, "ProductCategories.xlsx")

        report.ExportToXlsx(xlsxFilePath, xlsxExportOptions)

        ' Open the exported file in the default Excel viewer.
        Dim process As New Process()

        Try
            process.StartInfo.FileName = xlsxFilePath
            process.Start()
            process.WaitForInputIdle()
        Catch
        End Try

    End Sub
End Class
