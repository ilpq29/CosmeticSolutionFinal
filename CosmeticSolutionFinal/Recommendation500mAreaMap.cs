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
        public void ListCoordinatesInfo(string station)
        {
            List<StationModel> coordinatesList = StationDao.GetInfo(station);

/*            comboSearchStation.Items.Clear();
*/            foreach (var x in coordinatesList)
            {
                MessageBox.Show(x.Latitude.ToString());
                MessageBox.Show(x.Longitude.ToString());
            }
        }
            
        private void comboSearchAddress_Click(object sender, EventArgs e)
        {
            ListAddressInfo();
        }

        private void comboSearchStation_SelectedIndexChanged(object sender, EventArgs e)
        {          
                 
        }

        /*private List<StationModel> LoadData(string address)
        {
            List<StationModel> coordinatesList = StationDao.GetInfo(address);          
            if (comboSearchStation.SelectedValue != null)
            {
                address = Convert.ToString(comboSearchStation.SelectedValue);

            }

            return XDocument.Load(path).Element("Ships").Elements("Ship")
                .Select(e => new ShipwreckData(
                    year: Convert.ToInt32(e.Element("Year").Value, CultureInfo.InvariantCulture),
                    name: e.Element("Name").Value,
                    description: e.Element("Description").Value,
                    latitude: Convert.ToDouble(e.Element("Latitude").Value, CultureInfo.InvariantCulture),
                    longitude: Convert.ToDouble(e.Element("Longitude").Value, CultureInfo.InvariantCulture)
                ))
                .ToList();
        }*/
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboSearchStation.SelectedItem != null)
            {
                string stationName = Convert.ToString(comboSearchStation.SelectedItem.ToString());
                ListCoordinatesInfo(stationName);
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
        
                
            
        }
    }
}
