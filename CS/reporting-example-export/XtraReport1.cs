using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace reporting_example_export {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void CategoryNameLabel_BeforePrint(object sender, CancelEventArgs e) {
            var categoryNameLabel = (XRLabel)sender;
            var categoryName = categoryNameLabel.Text.Split('/')[0];
            categoryNameLabel.Text = categoryName;
            categoryNameLabel.Value = categoryName;
        }
    }
}
