using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;

namespace WindowsApplication1 {
    public partial class XtraForm1: DevExpress.XtraEditors.XtraForm {
        public XtraForm1() {
            InitializeComponent();
        }
        public XlsExportOptions ExportOptions {
            get {
                return new XlsExportOptions((checkEdit2.Checked?TextExportMode.Value:TextExportMode.Text),checkEdit1.Checked,checkEdit3.Checked);
            }
        }
        public string SheetName {
            get {
                return textEdit1.Text;
            }
        }
        public bool ExportToDiffrentSheets {
            get {
                return checkEdit4.Checked;
            }
        }
        private void checkEdit4_CheckedChanged(object sender,EventArgs e) {
            textEdit1.Enabled = !checkEdit4.Checked;
        }

        private void simpleButton2_Click(object sender,EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        private void simpleButton1_Click(object sender,EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
