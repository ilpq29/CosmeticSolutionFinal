using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CosmeticSolutionFinal.Data;
using CosmeticSolutionFinal.Data.Models;
using DevExpress.XtraMap;
using DevExpress.XtraEditors;

namespace CosmeticSolutionFinal
{
    public partial class Recommendation500mAreaMap : Form
    {
        private string bingKey = "AnarxWHrNxOAE7_aT1ydFrZ1eVvFqxq_9-ZyigJYu-aRDeOzuKGysCRsbiBRKkAU";
        public Recommendation500mAreaMap()
        {
            InitializeComponent();
            this.bingMapDataProvider1.BingKey = this.bingKey;
            this.bingGeocodeDataProvider.BingKey = this.bingKey;
/*            this.buttonSearch.Click += buttonSearch_Click;
*/        }
        #region 버튼 이벤트
        private void comboSearchAddress_Click(object sender, EventArgs e)
        {
            ListAddressInfo();
            return;
        }
        private void comboSearchAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSearchAddress.SelectedValue != null)
            {
                string stationName = Convert.ToString(comboSearchAddress.SelectedValue.ToString());
                ListStationInfo(stationName);
              
            }
            return;
        }    
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboSearchStation.SelectedItem != null)
            {
                string stationName = Convert.ToString(comboSearchStation.SelectedItem.ToString());
                ListCoordinatesInfo(stationName);
                BingMap.Zoom(15);
                BingMap.ZoomToFitLayerItems(BingMap.Layers.Where(l => l is VectorItemsLayer));               
            }
            return;      
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {         
            // 지도에 표시한 범위 삭제
            BingMap.CenterPoint = new GeoPoint(37.559418939678949, 126.991928283803932);
            BingMap.ZoomLevel = 10;
            for (int i = this.BingMap.Layers.Count - 1; i > 1; i--)
            {
                if (this.BingMap.Layers[i] is VectorItemsLayer)
                {
                    this.BingMap.Layers.Remove(this.BingMap.Layers[i]);
                }
            }          
        }
        #endregion

        #region 지역 / 지하철 역 / 좌표 class
        public void ListAddressInfo()
        {
            comboSearchAddress.DataSource = StationDao.GetAddress();
        }
        public void ListStationInfo(string address)
        {
            List<Station> stationList = StationDao.GetStation(address);
            comboSearchStation.Items.Clear();
            foreach (var x in stationList)
            {
                comboSearchStation.Items.Add(x.Name);
            }
        }
        public void ListCoordinatesInfo(string station)
        {
            List<StationModel> coordinatesList = StationDao.GetInfo(station);           
            double? latitude, longitude;
            foreach (var x in coordinatesList)
            {            
                latitude = x.Latitude;
                longitude = x.Longitude;
                
                this.bingGeocodeDataProvider.RequestLocationInformation(new GeoPoint((double)latitude, (double)longitude), null);

                MapBubble((double)latitude, (double)longitude);
            }
        }
        #endregion

        #region MapControl 지도에 범위 표시
        public void MapBubble(double latitude, double longitude)
        {
            MapItemStorage itemStorage = new MapItemStorage();

            itemStorage.Items.Add
                (
                    new MapBubble()
                    {
                        Argument = "A",
                        Value = 100,
                        Location = new GeoPoint(latitude, longitude),
                        Size = 100,
                        Group = 1,
                        MarkerType = MarkerType.Circle
                    }
                );

            KeyColorColorizer keyColorColorizer = new KeyColorColorizer();
            keyColorColorizer.ItemKeyProvider = new ArgumentItemKeyProvider();
            keyColorColorizer.Colors.Add(Color.FromArgb(75, Color.Red));
            keyColorColorizer.Keys.Add(new ColorizerKeyItem() { Key = "A", Name = "Category A" });

            VectorItemsLayer vectorItemsLayer = new VectorItemsLayer();
            vectorItemsLayer.Data = itemStorage;
            vectorItemsLayer.Colorizer = keyColorColorizer;
            this.BingMap.Layers.Add(vectorItemsLayer);

/*            ColorListLegend colorListLegend = new ColorListLegend();
            colorListLegend.Layer = vectorItemsLayer;
            this.mapControl.Legends.Add(colorListLegend);*/
        }
        #endregion
      
    }
}
