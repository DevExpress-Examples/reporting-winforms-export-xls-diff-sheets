using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraReports.UI;
using System.IO;

namespace WindowsApplication1 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }
        const int CategoriesCount = 8;
        private void button1_Click(object sender,EventArgs e) {
            XtraReport1 report = new XtraReport1();
            report.FilterString = "";
            report.CreateDocument(false);

            ReportPrintTool tool = new ReportPrintTool(report);
            tool.PrintingSystem.AddCommandHandler(new ExportToXlsCommandHandler());
            tool.ShowPreviewDialog();
        }
    }

    
    public class ExportToXlsCommandHandler: ICommandHandler {
        public virtual void HandleCommand(PrintingSystemCommand command,object[] args,IPrintControl control,ref bool handled) {
            if(!CanHandleCommand(command,control)) return;
            handled = true;
            XtraForm1 exportOptionsForm = new XtraForm1();
            if(exportOptionsForm.ShowDialog() == DialogResult.OK) {
                if(exportOptionsForm.ExportToDiffrentSheets) {
                    SeparateSheetsExportHelper.Export("XtraReport5.xls",exportOptionsForm.ExportOptions);
                } 
                else {
                    control.PrintingSystem.ExportToXls("XtraReport5.xls",exportOptionsForm.ExportOptions);
                }
            }
            if(File.Exists("XtraReport5.xls"))
                Process.Start("XtraReport5.xls");
        }

        public virtual bool CanHandleCommand(PrintingSystemCommand command, IPrintControl control) {
            // This handler is used for the ExportGraphic command.
            return command == PrintingSystemCommand.ExportXls;

        }
    }
    public class SeparateSheetsExportHelper {
        public SeparateSheetsExportHelper() {
        }
        internal static void Export(string fileName,XlsExportOptions xlsExportOptions) {
            XtraReport1 report = new XtraReport1();
            nwindDataSet ds = new nwindDataSet();
            nwindDataSetTableAdapters.CategoriesTableAdapter cta = new WindowsApplication1.nwindDataSetTableAdapters.CategoriesTableAdapter();
            cta.Fill(ds.Categories);

            report.Category.Value = ds.Categories[0].CategoryID;
            report.PrintingSystem.ExportOptions.PrintPreview.ShowOptionsBeforeExport = false ;
            report.CreateDocument();
            report.ExportToXls(fileName,xlsExportOptions);

            Excel.Application ObjExcel = new Excel.Application();
            Workbook ObjWorkBookGeneral;
            Worksheet ObjWorkSheet;
            Workbook ObjWorkBookTemp = ObjExcel.Workbooks.Open(Environment.CurrentDirectory + "\\" + fileName,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing);
            ObjWorkBookGeneral = ObjExcel.Workbooks.Open(Environment.CurrentDirectory + "\\" + fileName,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing);
            ((Worksheet)ObjWorkBookGeneral.Sheets[1]).Name = ds.Categories[0].Description.Length > 30 ? ds.Categories[0].Description.Substring(0,30) : ds.Categories[0].Description;

            bool isObjWorkBookTempClosed = false;
            try {
                for(int i = 1;i < ds.Categories.Count;i++) {
                    report.Category.Value = ds.Categories[i].CategoryID;
                    report.CreateDocument();
                    report.ExportToXls("temp_"+fileName+".xls");
                    ObjWorkBookTemp = ObjExcel.Workbooks.Open(Environment.CurrentDirectory + "\\temp_"+fileName+".xls",Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing);
                    isObjWorkBookTempClosed = false;
                    ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBookTemp.Sheets[1];
                    ObjWorkSheet.Name = ds.Categories[i].Description.Length > 30 ? ds.Categories[i].Description.Substring(0,30) : ds.Categories[i].Description;
                    ObjWorkSheet.Copy(Type.Missing,ObjWorkBookGeneral.Sheets[ObjWorkBookGeneral.Sheets.Count]);
                    ObjWorkBookTemp.Close(Microsoft.Office.Interop.Excel.XlSaveAction.xlSaveChanges,Type.Missing,Type.Missing);
                    isObjWorkBookTempClosed = true;
                }
            } finally {
                if(!isObjWorkBookTempClosed)
                    ObjWorkBookTemp.Close(Microsoft.Office.Interop.Excel.XlSaveAction.xlSaveChanges,Type.Missing,Type.Missing);
                ObjWorkBookGeneral.Close(Microsoft.Office.Interop.Excel.XlSaveAction.xlSaveChanges,Type.Missing,Type.Missing);
                ObjExcel.Quit();
                File.Delete(Environment.CurrentDirectory + "\\temp_" + fileName + ".xls");
            }
        }
    }
}