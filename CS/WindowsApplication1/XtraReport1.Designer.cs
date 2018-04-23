namespace WindowsApplication1 {
    partial class XtraReport1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.nwindDataSet1 = new WindowsApplication1.nwindDataSet();
            this.categoriesTableAdapter = new WindowsApplication1.nwindDataSetTableAdapters.CategoriesTableAdapter();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.productsTableAdapter = new WindowsApplication1.nwindDataSetTableAdapters.ProductsTableAdapter();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.Category = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.Height = 23;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0,0,0,0,100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Height = 30;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0,0,0,0,100F);
            this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 30;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0,0,0,0,100F);
            this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "nwindDataSet";
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // xrTable1
            // 
            this.xrTable1.Location = new System.Drawing.Point(0,0);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.Size = new System.Drawing.Size(646,23);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Size = new System.Drawing.Size(646,23);
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.CategoryID", "")});
            this.xrTableCell1.Location = new System.Drawing.Point(0,0);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Size = new System.Drawing.Size(213,23);
            this.xrTableCell1.Text = "xrTableCell1";
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.CategoryName", "")});
            this.xrTableCell2.Location = new System.Drawing.Point(213,0);
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Size = new System.Drawing.Size(213,23);
            this.xrTableCell2.Text = "xrTableCell2";
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.Description", "")});
            this.xrTableCell3.Location = new System.Drawing.Point(426,0);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Size = new System.Drawing.Size(220,23);
            this.xrTableCell3.Text = "xrTableCell3";
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.ReportFooter});
            this.DetailReport.DataAdapter = this.productsTableAdapter;
            this.DetailReport.DataMember = "Categories.CategoriesProducts";
            this.DetailReport.DataSource = this.nwindDataSet1;
            this.DetailReport.Name = "DetailReport";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail1.Height = 23;
            this.Detail1.Name = "Detail1";
            // 
            // xrTable2
            // 
            this.xrTable2.Location = new System.Drawing.Point(0,0);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.Size = new System.Drawing.Size(646,23);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Size = new System.Drawing.Size(646,23);
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.CategoriesProducts.CategoryID", "")});
            this.xrTableCell4.Location = new System.Drawing.Point(0,0);
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Size = new System.Drawing.Size(129,23);
            this.xrTableCell4.Text = "xrTableCell4";
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.CategoriesProducts.ProductID", "")});
            this.xrTableCell5.Location = new System.Drawing.Point(129,0);
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Size = new System.Drawing.Size(129,23);
            this.xrTableCell5.Text = "xrTableCell5";
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.CategoriesProducts.ProductName", "")});
            this.xrTableCell6.Location = new System.Drawing.Point(258,0);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Size = new System.Drawing.Size(129,23);
            this.xrTableCell6.Text = "xrTableCell6";
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.CategoriesProducts.QuantityPerUnit", "")});
            this.xrTableCell7.Location = new System.Drawing.Point(387,0);
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Size = new System.Drawing.Size(129,23);
            this.xrTableCell7.Text = "xrTableCell7";
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.CategoriesProducts.UnitPrice", "")});
            this.xrTableCell8.Location = new System.Drawing.Point(516,0);
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Size = new System.Drawing.Size(130,23);
            this.xrTableCell8.Text = "xrTableCell8";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Height = 0;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // Category
            // 
            this.Category.Name = "Category";
            this.Category.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.Int32;
            this.Category.Value = 0;
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter,
            this.DetailReport});
            this.DataAdapter = this.categoriesTableAdapter;
            this.DataMember = "Categories";
            this.DataSource = this.nwindDataSet1;
            this.FilterString = "[CategoryID] = [Parameters.Category]";
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Category});
            this.RequestParameters = false;
            this.Version = "8.3";
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private nwindDataSet nwindDataSet1;
        private WindowsApplication1.nwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private WindowsApplication1.nwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        public DevExpress.XtraReports.Parameters.Parameter Category;
    }
}
