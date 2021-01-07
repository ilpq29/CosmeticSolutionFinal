
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
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.listSourceDataAdapter1 = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.informationLayer1 = new DevExpress.XtraMap.InformationLayer();
            this.bingGeocodeDataProvider1 = new DevExpress.XtraMap.BingGeocodeDataProvider();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.txtSearch = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(37.5665D, 126.978D);
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
            this.mapControl1.Layers.Add(this.informationLayer1);
            this.mapControl1.Location = new System.Drawing.Point(12, 42);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(941, 508);
            this.mapControl1.TabIndex = 2;
            this.mapControl1.ZoomLevel = 10D;
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "AnarxWHrNxOAE7_aT1ydFrZ1eVvFqxq_9-ZyigJYu-aRDeOzuKGysCRsbiBRKkAU";
            this.bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.Road;
            this.vectorItemsLayer1.Data = this.listSourceDataAdapter1;
            this.listSourceDataAdapter1.DataSource = this.branchesBindingSource;
            this.listSourceDataAdapter1.Mappings.Latitude = "Latitude";
            this.listSourceDataAdapter1.Mappings.Longitude = "Longitude";
            this.listSourceDataAdapter1.Mappings.Text = "Name";
            this.listSourceDataAdapter1.Mappings.Type = "BranchId";
            this.informationLayer1.DataProvider = this.bingGeocodeDataProvider1;
            this.bingGeocodeDataProvider1.BingKey = "AnarxWHrNxOAE7_aT1ydFrZ1eVvFqxq_9-ZyigJYu-aRDeOzuKGysCRsbiBRKkAU";
            this.bingGeocodeDataProvider1.ProcessMouseEvents = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.comboBox1);
            this.layoutControl1.Controls.Add(this.mapControl1);
            this.layoutControl1.Controls.Add(this.txtSearch);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(849, 276, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1150, 562);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.simpleLabelItem1,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1150, 562);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(779, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(351, 30);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.mapControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(945, 512);
            this.layoutControlItem1.Text = "Map";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtSearch;
            this.layoutControlItem2.CustomizationFormText = "txtSearch";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(429, 30);
            this.layoutControlItem2.Text = "지하철역 검색";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(181, 18);
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(945, 30);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(185, 512);
            this.simpleLabelItem1.Text = "순위별로 지하철 역 뜨는 결과 ";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(181, 18);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(205, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSearch.Size = new System.Drawing.Size(232, 24);
            this.txtSearch.StyleController = this.layoutControl1;
            this.txtSearch.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(634, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.comboBox1;
            this.layoutControlItem3.Location = new System.Drawing.Point(429, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(350, 30);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(181, 18);
            // 
            // branchesBindingSource
            // 
            this.branchesBindingSource.DataSource = typeof(CosmeticSolutionFinal.Data.Branch);
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
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1;
        private DevExpress.XtraMap.ListSourceDataAdapter listSourceDataAdapter1;
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraMap.InformationLayer informationLayer1;
        private DevExpress.XtraMap.BingGeocodeDataProvider bingGeocodeDataProvider1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraEditors.ComboBoxEdit txtSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}