using CosmeticSolutionFinal.Data;
using CosmeticSolutionFinal.Data.Dao;
using DevExpress.XtraCharts;
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
    public partial class RecommendStoreOpenCloseTime : Form
    {
        public RecommendStoreOpenCloseTime()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            openCloseModelBindingSource.DataSource = Dao.openClose.GetOpenClose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //openCloseModelBindingSource.DataSource = Dao.openClose.GetOpenClose(string StationAddress);
        }
    }
}
