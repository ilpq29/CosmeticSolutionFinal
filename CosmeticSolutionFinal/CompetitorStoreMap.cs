using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmeticSolutionFinal
{
    public partial class CompetitorStoreMap : Form
    {
        public CompetitorStoreMap()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            webBroswerCompetitorStore();
        }

        private void webBroswerCompetitorStore()
        {
            string stationName = txtSubwayStation.Text;
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/maps?q=");
                if (stationName != string.Empty)
                {
                    queryaddress.Append(stationName + "," + "+" + "화장품");
                }

                webBrowser.Navigate(queryaddress.ToString());

                webBrowser.ScriptErrorsSuppressed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "지하철역을 입력해주세요");
            }
        }


       
    }
}
