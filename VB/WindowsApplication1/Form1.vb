Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Excel
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Diagnostics
Imports DevExpress.XtraPrinting.Native
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Control
Imports DevExpress.XtraReports.UI
Imports System.IO

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Const CategoriesCount As Integer = 8
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim report As New XtraReport1()
			report.FilterString = ""
			report.CreateDocument()
			report.PrintingSystem.AddCommandHandler(New ExportToXlsCommandHandler())
			report.ShowPreviewDialog()
		End Sub
	End Class


	Public Class ExportToXlsCommandHandler
		Implements ICommandHandler
		Public Overridable Sub HandleCommand(ByVal command As PrintingSystemCommand, ByVal args() As Object, ByVal control As PrintControl, ByRef handled As Boolean) Implements ICommandHandler.HandleCommand
			If (Not CanHandleCommand(command,control)) Then
				Return
			End If
			handled = True
			Dim exportOptionsForm As New XtraForm1()
			If exportOptionsForm.ShowDialog() = DialogResult.OK Then
				If exportOptionsForm.ExportToDiffrentSheets Then
					SeparateSheetsExportHelper.Export("XtraReport5.xls",exportOptionsForm.ExportOptions)
				Else
					control.PrintingSystem.ExportToXls("XtraReport5.xls",exportOptionsForm.ExportOptions)
				End If
			End If
			If File.Exists("XtraReport5.xls") Then
				Process.Start("XtraReport5.xls")
			End If
		End Sub

		Public Overridable Function CanHandleCommand(ByVal command As PrintingSystemCommand, ByVal control As PrintControl) As Boolean Implements ICommandHandler.CanHandleCommand
			' This handler is used for the ExportGraphic command.
			Return command = PrintingSystemCommand.ExportXls

		End Function
	End Class
	Public Class SeparateSheetsExportHelper
		Public Sub New()
		End Sub
		Friend Shared Sub Export(ByVal fileName As String, ByVal xlsExportOptions As XlsExportOptions)
			Dim report As New XtraReport1()
			Dim ds As New nwindDataSet()
			Dim cta As nwindDataSetTableAdapters.CategoriesTableAdapter = New WindowsApplication1.nwindDataSetTableAdapters.CategoriesTableAdapter()
			cta.Fill(ds.Categories)

			report.Category.Value = ds.Categories(0).CategoryID
			report.PrintingSystem.ExportOptions.PrintPreview.ShowOptionsBeforeExport = False
			report.CreateDocument()
			report.ExportToXls(fileName,xlsExportOptions)

			Dim ObjExcel As New Excel.Application()
			Dim ObjWorkBookGeneral As Workbook
			Dim ObjWorkSheet As Worksheet
			Dim ObjWorkBookTemp As Workbook = ObjExcel.Workbooks.Open(Environment.CurrentDirectory & "\" & fileName,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing)
			ObjWorkBookGeneral = ObjExcel.Workbooks.Open(Environment.CurrentDirectory & "\" & fileName,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing)
			If ds.Categories(0).Description.Length > 30 Then
				CType(ObjWorkBookGeneral.Sheets(1), Worksheet).Name = ds.Categories(0).Description.Substring(0,30)
			Else
				CType(ObjWorkBookGeneral.Sheets(1), Worksheet).Name = ds.Categories(0).Description
			End If

			Dim isObjWorkBookTempClosed As Boolean = False
			Try
				For i As Integer = 1 To ds.Categories.Count - 1
					report.Category.Value = ds.Categories(i).CategoryID
					report.CreateDocument()
					report.ExportToXls("temp_" & fileName & ".xls")
					ObjWorkBookTemp = ObjExcel.Workbooks.Open(Environment.CurrentDirectory & "\temp_" & fileName & ".xls",Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing)
					isObjWorkBookTempClosed = False
					ObjWorkSheet = CType(ObjWorkBookTemp.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
					If ds.Categories(i).Description.Length > 30 Then
						ObjWorkSheet.Name = ds.Categories(i).Description.Substring(0,30)
					Else
						ObjWorkSheet.Name = ds.Categories(i).Description
					End If
					ObjWorkSheet.Copy(Type.Missing,ObjWorkBookGeneral.Sheets(ObjWorkBookGeneral.Sheets.Count))
					ObjWorkBookTemp.Close(Microsoft.Office.Interop.Excel.XlSaveAction.xlSaveChanges,Type.Missing,Type.Missing)
					isObjWorkBookTempClosed = True
				Next i
			Finally
				If (Not isObjWorkBookTempClosed) Then
					ObjWorkBookTemp.Close(Microsoft.Office.Interop.Excel.XlSaveAction.xlSaveChanges,Type.Missing,Type.Missing)
				End If
				ObjWorkBookGeneral.Close(Microsoft.Office.Interop.Excel.XlSaveAction.xlSaveChanges,Type.Missing,Type.Missing)
				ObjExcel.Quit()
				File.Delete(Environment.CurrentDirectory & "\temp_" & fileName & ".xls")
			End Try
		End Sub
	End Class
End Namespace