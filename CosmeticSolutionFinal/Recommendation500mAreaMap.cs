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

        private void comboAddress_Click(object sender, EventArgs e)
        {

            List<StationModel> model = StationDao.GetAddress();
            comboAddress.Properties.Items.AddRange(model);       

        }
    }
}
