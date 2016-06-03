namespace QLBH.Formsss
{
    partial class SLSPDaBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SLSPDaBan));
            this.qLBANHANGDataSet = new QLBH.QLBANHANGDataSet();
            this.SLSPDaBan_gridcontrol = new DevExpress.XtraGrid.GridControl();
            this.SLSPDaBan_gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.thongKeSLSPDaBanTableAdapter = new QLBH.QLBANHANGDataSetTableAdapters.ThongKeSLSPDaBanTableAdapter();
            this.thongKeSLSPDaBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.qLBANHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLSPDaBan_gridcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLSPDaBan_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeSLSPDaBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qLBANHANGDataSet
            // 
            this.qLBANHANGDataSet.DataSetName = "QLBANHANGDataSet";
            this.qLBANHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SLSPDaBan_gridcontrol
            // 
            this.SLSPDaBan_gridcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SLSPDaBan_gridcontrol.Location = new System.Drawing.Point(186, 90);
            this.SLSPDaBan_gridcontrol.MainView = this.SLSPDaBan_gridview;
            this.SLSPDaBan_gridcontrol.Name = "SLSPDaBan_gridcontrol";
            this.SLSPDaBan_gridcontrol.Size = new System.Drawing.Size(891, 373);
            this.SLSPDaBan_gridcontrol.TabIndex = 0;
            this.SLSPDaBan_gridcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SLSPDaBan_gridview});
            // 
            // SLSPDaBan_gridview
            // 
            this.SLSPDaBan_gridview.GridControl = this.SLSPDaBan_gridcontrol;
            this.SLSPDaBan_gridview.Name = "SLSPDaBan_gridview";
            this.SLSPDaBan_gridview.OptionsBehavior.Editable = false;
            this.SLSPDaBan_gridview.OptionsBehavior.ReadOnly = true;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.labelControl7.Location = new System.Drawing.Point(489, 22);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(289, 31);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "Số lượng sản phẩm đã bán";
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.AppearanceNameSerializable = "In A Fog";
            this.chartControl1.DataAdapter = this.thongKeSLSPDaBanTableAdapter;
            this.chartControl1.DataSource = this.thongKeSLSPDaBanBindingSource;
            xyDiagram1.AxisX.Range.AlwaysShowZeroLevel = true;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.AlwaysShowZeroLevel = true;
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Location = new System.Drawing.Point(186, 89);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "ThongKeSLSPDaBan.Tên sản phẩm";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            series1.DataSource = this.qLBANHANGDataSet;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "Sản phẩm";
            series1.ValueDataMembersSerializable = "ThongKeSLSPDaBan. Số lượng đã bán được";
            sideBySideBarSeriesView1.BarWidth = 0.5D;
            series1.View = sideBySideBarSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(891, 374);
            this.chartControl1.TabIndex = 4;
            chartTitle1.Text = "";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // thongKeSLSPDaBanTableAdapter
            // 
            this.thongKeSLSPDaBanTableAdapter.ClearBeforeFill = true;
            // 
            // thongKeSLSPDaBanBindingSource
            // 
            this.thongKeSLSPDaBanBindingSource.DataMember = "ThongKeSLSPDaBan";
            this.thongKeSLSPDaBanBindingSource.DataSource = this.qLBANHANGDataSet;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Location = new System.Drawing.Point(867, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(210, 75);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Views";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(113, 32);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(77, 34);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Chart";
            this.simpleButton2.Click += new System.EventHandler(this.Chart_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(16, 32);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(77, 34);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "List";
            this.simpleButton1.Click += new System.EventHandler(this.list_Click);
            // 
            // SLSPDaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 517);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.SLSPDaBan_gridcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SLSPDaBan";
            this.Text = "SLSPDaBan";
            this.Load += new System.EventHandler(this.SLSPDaBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBANHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLSPDaBan_gridcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLSPDaBan_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeSLSPDaBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl SLSPDaBan_gridcontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView SLSPDaBan_gridview;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private QLBANHANGDataSetTableAdapters.ThongKeSLSPDaBanTableAdapter thongKeSLSPDaBanTableAdapter;
        private QLBANHANGDataSet qLBANHANGDataSet;
        private System.Windows.Forms.BindingSource thongKeSLSPDaBanBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}