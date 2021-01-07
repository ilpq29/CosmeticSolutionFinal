using CosmeticSolutionFinal.Data;
using CosmeticSolutionFinal.Data.Models;
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
    public partial class RecommendOpenStore : Form
    {
        public RecommendOpenStore()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            // 주 매출 연령을 찾아낸다
            List<OrderAnalysis> list = OrderDao.GetOrderAnalysisResult(dateTimePicker.Value.Year);

            foreach (var x in list)
            {
                dataGridAnalysisResult.Rows.Add(x.GetFormattedDate(), x.GetFormattedAge(), x.GetFormattedNumberOfOrder());
            }
        }
    }
}
