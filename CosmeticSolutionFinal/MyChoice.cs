using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using CosmeticSolutionFinal.Data;
using CosmeticSolutionFinal.Data.Models;

namespace CosmeticSolutionFinal
{
    public partial class MyChoice : Form
    {

        public MyChoice()
        {
            InitializeComponent();
        }
        private void MyChoice_Load(object sender, EventArgs e)
        {
            Version ver = webBrowser1.Version;
            string name = webBrowser1.ProductName;
            string str = webBrowser1.ProductVersion;
            string html = "MyChoice.html";
            string dir = System.IO.Directory.GetCurrentDirectory();
            string path = System.IO.Path.Combine(dir, html);
            webBrowser1.Navigate(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string address = comboSearchStation.Text;//comboSearchAddress.Text+ " " +;
                object[] arr = new object[] {address};
                //MessageBox.Show(address);
                webBrowser1.Document.InvokeScript("geo", arr); // html 의 geo 자바스크립트 함수 호출. 
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
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
