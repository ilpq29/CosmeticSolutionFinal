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

namespace CosmeticSolutionFinal
{
    public partial class Recommendation500mAreaMap : Form
    {


        public Recommendation500mAreaMap()
        {
            InitializeComponent();
        }
        private void Recommendation500mAreaMap_Load(object sender, EventArgs e)
        {

        }
        private void comboSearchAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSearchAddress.SelectedValue != null)
            {
                string stationName = Convert.ToString(comboSearchAddress.SelectedValue.ToString());
                ListStationInfo(stationName);
            }
        }
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
        public void ListCoordinatesInfo(string address, double latitude, double longitude)
        {
            List<StationModel> coordinateList = StationDao.GetCoordinates(address, latitude, longitude);
          
            comboSearchStation.SelectedValue = address;
            foreach (var x in coordinateList)
            {
                comboBox1.Items.Add(x.Latitude);
            }   
                    
        }
        private void comboSearchAddress_Click(object sender, EventArgs e)
        {
            ListAddressInfo();
        }

        private void comboSearchStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSearchStation.SelectedValue != null)
            {
                string stationName = Convert.ToString(comboSearchAddress.SelectedValue.ToString());
                double latitude, longitude;
            }
             
        }

        /*private IMapDataAdapter CreateAdapter(object source)
        {
            ListSourceDataAdapter adapter = new ListSourceDataAdapter();
            adapter.DataSource = source;

            adapter.Mappings.Latitude = "Latitude";
            adapter.Mappings.Longitude = "Longitude";

            adapter.AttributeMappings.Add(new MapItemAttributeMapping() { Member = "", Name = "" });
            adapter.AttributeMappings.Add(new MapItemAttributeMapping() { Member = "", Name = "" });


            return adapter; 
        }

        private List<Station> LoadData(string path)
        {
            return StationModel.Load(path).Element("Ships").Elements("Ship")
                .Select(e => new ShipwreckData(
                    latitude: Convert.ToDouble(e.Element("Latitude").Value, CultureInfo.InvariantCulture),
                    longitude: Convert.ToDouble(e.Element("Longitude").Value, CultureInfo.InvariantCulture)
                ))
                .ToList();
        }*/
    }
}
