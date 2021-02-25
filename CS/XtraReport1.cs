using DevExpress.XtraReports.UI;

namespace Reporting_Export_Report_Groups_to_Separate_Excel_Sheets {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void CategoryNameLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            var categoryNameLabel = (XRLabel)sender;
            var categoryName = categoryNameLabel.Text.Split('/')[0];
            categoryNameLabel.Text = categoryName;
            categoryNameLabel.Value = categoryName;
        }
    }
}
