
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.BingMap = new DevExpress.XtraMap.MapControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.comboAddress = new DevExpress.XtraEditors.ComboBoxEdit();
            this.지역 = new DevExpress.XtraLayout.LayoutControlItem();
            this.comboStation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.지하철 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BingMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.지역)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboStation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.지하철)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.comboStation);
            this.layoutControl1.Controls.Add(this.comboAddress);
            this.layoutControl1.Controls.Add(this.BingMap);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(520, 222, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1150, 562);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.지역,
            this.지하철});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1150, 562);
            this.Root.TextVisible = false;
            // 
            // BingMap
            // 
            this.BingMap.CenterPoint = new DevExpress.XtraMap.GeoPoint(37.559418939678949D, 126.99192828380393D);
            this.BingMap.Layers.Add(this.imageLayer1);
            this.BingMap.Location = new System.Drawing.Point(12, 40);
            this.BingMap.MinZoomLevel = 4D;
            this.BingMap.Name = "BingMap";
            this.BingMap.Size = new System.Drawing.Size(1126, 510);
            this.BingMap.TabIndex = 4;
            this.BingMap.ZoomLevel = 10D;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.BingMap;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1130, 514);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            this.bingMapDataProvider1.BingKey = "AnarxWHrNxOAE7_aT1ydFrZ1eVvFqxq_9-ZyigJYu-aRDeOzuKGysCRsbiBRKkAU";
            this.bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.Road;
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            // 
            // comboAddress
            // 
            this.comboAddress.Location = new System.Drawing.Point(63, 12);
            this.comboAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboAddress.Name = "comboAddress";
            this.comboAddress.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboAddress.Size = new System.Drawing.Size(462, 24);
            this.comboAddress.StyleController = this.layoutControl1;
            this.comboAddress.TabIndex = 5;
            this.comboAddress.Click += new System.EventHandler(this.comboAddress_Click);
            // 
            // 지역
            // 
            this.지역.Control = this.comboAddress;
            this.지역.Location = new System.Drawing.Point(0, 0);
            this.지역.Name = "지역";
            this.지역.Size = new System.Drawing.Size(517, 28);
            this.지역.TextSize = new System.Drawing.Size(39, 18);
            // 
            // comboStation
            // 
            this.comboStation.Location = new System.Drawing.Point(580, 12);
            this.comboStation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboStation.Name = "comboStation";
            this.comboStation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboStation.Size = new System.Drawing.Size(558, 24);
            this.comboStation.StyleController = this.layoutControl1;
            this.comboStation.TabIndex = 6;
            // 
            // 지하철
            // 
            this.지하철.Control = this.comboStation;
            this.지하철.Location = new System.Drawing.Point(517, 0);
            this.지하철.Name = "지하철";
            this.지하철.Size = new System.Drawing.Size(613, 28);
            this.지하철.TextSize = new System.Drawing.Size(39, 18);
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
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BingMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.지역)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboStation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.지하철)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraMap.MapControl BingMap;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraEditors.ComboBoxEdit comboStation;
        private DevExpress.XtraEditors.ComboBoxEdit comboAddress;
        private DevExpress.XtraLayout.LayoutControlItem 지역;
        private DevExpress.XtraLayout.LayoutControlItem 지하철;
    }
}