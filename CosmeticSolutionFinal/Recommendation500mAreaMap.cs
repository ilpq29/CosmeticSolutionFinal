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
        private void comboSearchAddress_Click(object sender, EventArgs e)
        {
            ListAddressInfo();
        }

        private void comboSearchStation_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
