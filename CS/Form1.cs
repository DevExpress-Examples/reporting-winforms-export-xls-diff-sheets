using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace Reporting_Export_Report_Groups_to_Separate_Excel_Sheets {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var report = new XtraReport1();

            // Set the DetailReport band's PageBreak property to AfterBand
            // to print each product category on a new report page.
            report.Bands[BandKind.DetailReport].PageBreak = PageBreak.AfterBand;

            // Set the report's RollPaper property to true
            // to fit each product category to one report page.
            report.RollPaper = true;

            // Use SingleFilePageByPage mode
            // to export each page of the report to a separate sheet.
            var xlsxExportOptions = new XlsxExportOptions {
                ExportMode = XlsxExportMode.SingleFilePageByPage,
                ShowGridLines = true
            };

            // Use the label's PrintOnPage event to save the names of all the categories to a list.
            var categoriesNames = new List<string>();

            report.Bands[BandKind.Detail].Controls["CategoryNameLabel"].PrintOnPage += (s1, e1) => {
                var categoryNameLabel = (XRLabel)s1;
                categoriesNames.Add(categoryNameLabel.Text);
            };

            // Use the XlSheetCreated event to change the default name of each sheet
            // to the category name.
            report.PrintingSystem.XlSheetCreated += (s2, e2) => {
                e2.SheetName = categoriesNames[e2.Index];
            };

            // Export the report to Excel format. Save the exported file
            // to the project directory.
            var projectDirPath = Path.GetDirectoryName(
                Path.GetDirectoryName(
                    System.IO.Directory.GetCurrentDirectory()
                )
            );

            var xlsxFilePath = Path.Combine(projectDirPath, "ProductCategories.xlsx");

            report.ExportToXlsx(xlsxFilePath, xlsxExportOptions);

            // Open the exported file in the default Excel viewer.
            Process process = new Process();

            try {
                process.StartInfo.FileName = xlsxFilePath;
                process.Start();
                process.WaitForInputIdle();
            } catch { }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
