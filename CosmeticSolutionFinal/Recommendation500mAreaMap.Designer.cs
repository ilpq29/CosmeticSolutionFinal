
namespace CosmeticSolutionFinal
{
    partial class Recommendation500mAreaMap
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.buttonSearch = new DevExpress.XtraEditors.SimpleButton();
            this.comboSearchStation = new System.Windows.Forms.ComboBox();
            this.comboSearchAddress = new System.Windows.Forms.ComboBox();
            this.BingMap = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.지역검색 = new DevExpress.XtraLayout.LayoutControlItem();
            this.지하철검색 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.stationModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BingMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.지역검색)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.지하철검색)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.buttonSearch);
            this.layoutControl1.Controls.Add(this.comboSearchStation);
            this.layoutControl1.Controls.Add(this.comboSearchAddress);
            this.layoutControl1.Controls.Add(this.BingMap);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(520, 222, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1150, 562);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 42);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(1126, 27);
            this.buttonSearch.StyleController = this.layoutControl1;
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboSearchStation
            // 
            this.comboSearchStation.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stationModelBindingSource, "Name", true));
            this.comboSearchStation.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.stationModelBindingSource, "Name", true));
            this.comboSearchStation.FormattingEnabled = true;
            this.comboSearchStation.Location = new System.Drawing.Point(637, 12);
            this.comboSearchStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboSearchStation.Name = "comboSearchStation";
            this.comboSearchStation.Size = new System.Drawing.Size(501, 23);
            this.comboSearchStation.TabIndex = 6;
            this.comboSearchStation.SelectedIndexChanged += new System.EventHandler(this.comboSearchStation_SelectedIndexChanged);
            // 
            // comboSearchAddress
            // 
            this.comboSearchAddress.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stationModelBindingSource, "Address", true));
            this.comboSearchAddress.DisplayMember = "Address";
            this.comboSearchAddress.FormattingEnabled = true;
            this.comboSearchAddress.Location = new System.Drawing.Point(89, 12);
            this.comboSearchAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboSearchAddress.Name = "comboSearchAddress";
            this.comboSearchAddress.Size = new System.Drawing.Size(467, 23);
            this.comboSearchAddress.TabIndex = 5;
            this.comboSearchAddress.ValueMember = "Address";
            this.comboSearchAddress.SelectedIndexChanged += new System.EventHandler(this.comboSearchAddress_SelectedIndexChanged);
            this.comboSearchAddress.Click += new System.EventHandler(this.comboSearchAddress_Click);
            // 
            // BingMap
            // 
            this.BingMap.CenterPoint = new DevExpress.XtraMap.GeoPoint(37.559418939678949D, 126.99192828380393D);
            this.BingMap.Layers.Add(this.imageLayer1);
            this.BingMap.Location = new System.Drawing.Point(12, 73);
            this.BingMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BingMap.MinZoomLevel = 4D;
            this.BingMap.Name = "BingMap";
            this.BingMap.Size = new System.Drawing.Size(1126, 477);
            this.BingMap.TabIndex = 4;
            this.BingMap.ZoomLevel = 10D;
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "AnarxWHrNxOAE7_aT1ydFrZ1eVvFqxq_9-ZyigJYu-aRDeOzuKGysCRsbiBRKkAU";
            this.bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.Road;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.지역검색,
            this.지하철검색,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1150, 562);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.BingMap;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 61);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1130, 481);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // 지역검색
            // 
            this.지역검색.Control = this.comboSearchAddress;
            this.지역검색.Location = new System.Drawing.Point(0, 0);
            this.지역검색.Name = "지역검색";
            this.지역검색.Size = new System.Drawing.Size(548, 30);
            this.지역검색.TextSize = new System.Drawing.Size(65, 18);
            // 
            // 지하철검색
            // 
            this.지하철검색.Control = this.comboSearchStation;
            this.지하철검색.Location = new System.Drawing.Point(548, 0);
            this.지하철검색.Name = "지하철검색";
            this.지하철검색.Size = new System.Drawing.Size(582, 30);
            this.지하철검색.TextSize = new System.Drawing.Size(65, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.buttonSearch;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1130, 31);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // stationModelBindingSource
            // 
            this.stationModelBindingSource.DataSource = typeof(CosmeticSolutionFinal.Data.Models.StationModel);
            // 
            // Recommendation500mAreaMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 562);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Recommendation500mAreaMap";
            this.Text = "500m 이내 입점 추천 정보 맵";
            this.Load += new System.EventHandler(this.Recommendation500mAreaMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BingMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.지역검색)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.지하철검색)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraMap.MapControl BingMap;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private System.Windows.Forms.ComboBox comboSearchStation;
        private System.Windows.Forms.ComboBox comboSearchAddress;
        private System.Windows.Forms.BindingSource stationModelBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem 지역검색;
        private DevExpress.XtraLayout.LayoutControlItem 지하철검색;
        private DevExpress.XtraEditors.SimpleButton buttonSearch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}