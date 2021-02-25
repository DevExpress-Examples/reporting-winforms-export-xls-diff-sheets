Namespace Reporting_Export_Report_Groups_to_Separate_Excel_Sheets
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim sqLiteConnectionParameters1 As New DevExpress.DataAccess.ConnectionParameters.SQLiteConnectionParameters()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column6 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim selectQuery2 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column7 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table2 As New DevExpress.DataAccess.Sql.Table()
			Dim column8 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column9 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column10 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column11 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column12 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column13 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression13 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column14 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression14 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column15 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression15 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column16 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression16 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column17 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression17 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim masterDetailInfo1 As New DevExpress.DataAccess.Sql.MasterDetailInfo()
			Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.CategoryNameLabel = New DevExpress.XtraReports.UI.XRLabel()
			Me.DescriptionLabel = New DevExpress.XtraReports.UI.XRLabel()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.ProductNameLabel = New DevExpress.XtraReports.UI.XRLabel()
			Me.UnitPriceLabel = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.CategoryNameLabel, Me.DescriptionLabel})
			Me.Detail.Name = "Detail"
			' 
			' CategoryNameLabel
			' 
			Me.CategoryNameLabel.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
			Me.CategoryNameLabel.Font = New System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold)
			Me.CategoryNameLabel.ForeColor = System.Drawing.Color.LightSkyBlue
			Me.CategoryNameLabel.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.CategoryNameLabel.Multiline = True
			Me.CategoryNameLabel.Name = "CategoryNameLabel"
			Me.CategoryNameLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.CategoryNameLabel.SizeF = New System.Drawing.SizeF(650F, 49.95832F)
			Me.CategoryNameLabel.StylePriority.UseFont = False
			Me.CategoryNameLabel.StylePriority.UseForeColor = False
			Me.CategoryNameLabel.Text = "CategoryNameLabel"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.CategoryNameLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.CategoryNameLabel_BeforePrint);
			' 
			' DescriptionLabel
			' 
			Me.DescriptionLabel.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")})
			Me.DescriptionLabel.Font = New System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic)
			Me.DescriptionLabel.LocationFloat = New DevExpress.Utils.PointFloat(0F, 49.95832F)
			Me.DescriptionLabel.Multiline = True
			Me.DescriptionLabel.Name = "DescriptionLabel"
			Me.DescriptionLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.DescriptionLabel.SizeF = New System.Drawing.SizeF(650F, 50F)
			Me.DescriptionLabel.StylePriority.UseFont = False
			Me.DescriptionLabel.Text = "DescriptionLabel"
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "nwind"
			sqLiteConnectionParameters1.FileName = "C:\Docs\Examples\2020.2\Examples\XtraReports\Win\Reporting-Export-Report-Groups-t" & "o-Separate-Excel-Sheets\Data\nwind.db"
			Me.sqlDataSource1.ConnectionParameters = sqLiteConnectionParameters1
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "CategoryID"
			table1.Name = "Categories"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "CategoryName"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "Description"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "Picture"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "Icon17"
			columnExpression5.Table = table1
			column5.Expression = columnExpression5
			columnExpression6.ColumnName = "Icon25"
			columnExpression6.Table = table1
			column6.Expression = columnExpression6
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Columns.Add(column6)
			selectQuery1.MetaSerializable = "<Meta X=""20"" Y=""20"" Width=""107"" Height=""161"" />"
			selectQuery1.Name = "Categories"
			selectQuery1.Tables.Add(table1)
			columnExpression7.ColumnName = "ProductID"
			table2.Name = "Products"
			columnExpression7.Table = table2
			column7.Expression = columnExpression7
			columnExpression8.ColumnName = "ProductName"
			columnExpression8.Table = table2
			column8.Expression = columnExpression8
			columnExpression9.ColumnName = "SupplierID"
			columnExpression9.Table = table2
			column9.Expression = columnExpression9
			columnExpression10.ColumnName = "CategoryID"
			columnExpression10.Table = table2
			column10.Expression = columnExpression10
			columnExpression11.ColumnName = "QuantityPerUnit"
			columnExpression11.Table = table2
			column11.Expression = columnExpression11
			columnExpression12.ColumnName = "UnitPrice"
			columnExpression12.Table = table2
			column12.Expression = columnExpression12
			columnExpression13.ColumnName = "UnitsInStock"
			columnExpression13.Table = table2
			column13.Expression = columnExpression13
			columnExpression14.ColumnName = "UnitsOnOrder"
			columnExpression14.Table = table2
			column14.Expression = columnExpression14
			columnExpression15.ColumnName = "ReorderLevel"
			columnExpression15.Table = table2
			column15.Expression = columnExpression15
			columnExpression16.ColumnName = "Discontinued"
			columnExpression16.Table = table2
			column16.Expression = columnExpression16
			columnExpression17.ColumnName = "EAN13"
			columnExpression17.Table = table2
			column17.Expression = columnExpression17
			selectQuery2.Columns.Add(column7)
			selectQuery2.Columns.Add(column8)
			selectQuery2.Columns.Add(column9)
			selectQuery2.Columns.Add(column10)
			selectQuery2.Columns.Add(column11)
			selectQuery2.Columns.Add(column12)
			selectQuery2.Columns.Add(column13)
			selectQuery2.Columns.Add(column14)
			selectQuery2.Columns.Add(column15)
			selectQuery2.Columns.Add(column16)
			selectQuery2.Columns.Add(column17)
			selectQuery2.MetaSerializable = "<Meta X=""147"" Y=""20"" Width=""114"" Height=""261"" />"
			selectQuery2.Name = "Products"
			selectQuery2.Tables.Add(table2)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1, selectQuery2})
			masterDetailInfo1.DetailQueryName = "Products"
			relationColumnInfo1.NestedKeyColumn = "CategoryID"
			relationColumnInfo1.ParentKeyColumn = "CategoryID"
			masterDetailInfo1.KeyColumns.Add(relationColumnInfo1)
			masterDetailInfo1.MasterQueryName = "Categories"
			Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() { masterDetailInfo1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1})
			Me.DetailReport.DataMember = "Categories.CategoriesProducts"
			Me.DetailReport.DataSource = Me.sqlDataSource1
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.ProductNameLabel, Me.UnitPriceLabel})
			Me.Detail1.Name = "Detail1"
			' 
			' ProductNameLabel
			' 
			Me.ProductNameLabel.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
			Me.ProductNameLabel.Font = New System.Drawing.Font("Arial", 14F)
			Me.ProductNameLabel.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.ProductNameLabel.Multiline = True
			Me.ProductNameLabel.Name = "ProductNameLabel"
			Me.ProductNameLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.ProductNameLabel.SizeF = New System.Drawing.SizeF(325F, 100F)
			Me.ProductNameLabel.StylePriority.UseFont = False
			Me.ProductNameLabel.StylePriority.UseTextAlignment = False
			Me.ProductNameLabel.Text = "ProductNameLabel"
			Me.ProductNameLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' UnitPriceLabel
			' 
			Me.UnitPriceLabel.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
			Me.UnitPriceLabel.Font = New System.Drawing.Font("Arial", 14F)
			Me.UnitPriceLabel.LocationFloat = New DevExpress.Utils.PointFloat(325F, 0F)
			Me.UnitPriceLabel.Multiline = True
			Me.UnitPriceLabel.Name = "UnitPriceLabel"
			Me.UnitPriceLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.UnitPriceLabel.SizeF = New System.Drawing.SizeF(325F, 100F)
			Me.UnitPriceLabel.StylePriority.UseFont = False
			Me.UnitPriceLabel.StylePriority.UseTextAlignment = False
			Me.UnitPriceLabel.Text = "UnitPriceLabel"
			Me.UnitPriceLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.UnitPriceLabel.TextFormatString = "{0:$0}"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.Detail, Me.DetailReport})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "Categories"
			Me.DataSource = Me.sqlDataSource1
			Me.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.Version = "20.2"
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private WithEvents CategoryNameLabel As DevExpress.XtraReports.UI.XRLabel
		Private DescriptionLabel As DevExpress.XtraReports.UI.XRLabel
		Private ProductNameLabel As DevExpress.XtraReports.UI.XRLabel
		Private UnitPriceLabel As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
