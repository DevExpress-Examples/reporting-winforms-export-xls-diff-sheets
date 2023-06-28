Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Excel
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Diagnostics
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System.IO

Namespace WindowsApplication1

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Const CategoriesCount As Integer = 8

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As XtraReport1 = New XtraReport1()
            report.FilterString = ""
            report.CreateDocument(False)
            Dim tool As ReportPrintTool = New ReportPrintTool(report)
            tool.PrintingSystem.AddCommandHandler(New ExportToXlsCommandHandler())
            tool.ShowPreviewDialog()
        End Sub
    End Class

    Public Class ExportToXlsCommandHandler
        Implements ICommandHandler

        Public Overridable Sub HandleCommand(ByVal command As PrintingSystemCommand, ByVal args As Object(), ByVal control As IPrintControl, ByRef handled As Boolean) Implements ICommandHandler.HandleCommand
            If Not CanHandleCommand(command, control) Then Return
            handled = True
            Dim exportOptionsForm As XtraForm1 = New XtraForm1()
            If exportOptionsForm.ShowDialog() = DialogResult.OK Then
                If exportOptionsForm.ExportToDiffrentSheets Then
                    SeparateSheetsExportHelper.Export("XtraReport5.xls", exportOptionsForm.ExportOptions)
                Else
                    control.PrintingSystem.ExportToXls("XtraReport5.xls", exportOptionsForm.ExportOptions)
                End If
            End If

            If File.Exists("XtraReport5.xls") Then Call Process.Start("XtraReport5.xls")
        End Sub

        Public Overridable Function CanHandleCommand(ByVal command As PrintingSystemCommand, ByVal control As IPrintControl) As Boolean Implements ICommandHandler.CanHandleCommand
            ' This handler is used for the ExportGraphic command.
            Return command = PrintingSystemCommand.ExportXls
        End Function
    End Class

    Public Class SeparateSheetsExportHelper

        Public Sub New()
        End Sub

        Friend Shared Sub Export(ByVal fileName As String, ByVal xlsExportOptions As XlsExportOptions)
            Dim report As XtraReport1 = New XtraReport1()
            Dim ds As nwindDataSet = New nwindDataSet()
            Dim cta As nwindDataSetTableAdapters.CategoriesTableAdapter = New nwindDataSetTableAdapters.CategoriesTableAdapter()
            cta.Fill(ds.Categories)
            report.Category.Value = ds.Categories(0).CategoryID
            report.PrintingSystem.ExportOptions.PrintPreview.ShowOptionsBeforeExport = False
            report.CreateDocument()
            report.ExportToXls(fileName, xlsExportOptions)
            Dim ObjExcel As Excel.Application = New Excel.Application()
            Dim ObjWorkBookGeneral As Workbook
            Dim ObjWorkSheet As Worksheet
            Dim ObjWorkBookTemp As Workbook = ObjExcel.Workbooks.Open(Environment.CurrentDirectory & "\" & fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            ObjWorkBookGeneral = ObjExcel.Workbooks.Open(Environment.CurrentDirectory & "\" & fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            CType(ObjWorkBookGeneral.Sheets(1), Worksheet).Name = If(ds.Categories(0).Description.Length > 30, ds.Categories(0).Description.Substring(0, 30), ds.Categories(0).Description)
            Dim isObjWorkBookTempClosed As Boolean = False
            Try
                For i As Integer = 1 To ds.Categories.Count - 1
                    report.Category.Value = ds.Categories(i).CategoryID
                    report.CreateDocument()
                    report.ExportToXls("temp_" & fileName & ".xls")
                    ObjWorkBookTemp = ObjExcel.Workbooks.Open(Environment.CurrentDirectory & "\temp_" & fileName & ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
                    isObjWorkBookTempClosed = False
                    ObjWorkSheet = CType(ObjWorkBookTemp.Sheets(1), Worksheet)
                    ObjWorkSheet.Name = If(ds.Categories(i).Description.Length > 30, ds.Categories(i).Description.Substring(0, 30), ds.Categories(i).Description)
                    ObjWorkSheet.Copy(Type.Missing, ObjWorkBookGeneral.Sheets(ObjWorkBookGeneral.Sheets.Count))
                    ObjWorkBookTemp.Close(XlSaveAction.xlSaveChanges, Type.Missing, Type.Missing)
                    isObjWorkBookTempClosed = True
                Next
            Finally
                If Not isObjWorkBookTempClosed Then ObjWorkBookTemp.Close(XlSaveAction.xlSaveChanges, Type.Missing, Type.Missing)
                ObjWorkBookGeneral.Close(XlSaveAction.xlSaveChanges, Type.Missing, Type.Missing)
                ObjExcel.Quit()
                File.Delete(Environment.CurrentDirectory & "\temp_" & fileName & ".xls")
            End Try
        End Sub
    End Class
End Namespace
