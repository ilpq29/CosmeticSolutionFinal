using CosmeticSolutionFinal.Data;
using CosmeticSolutionFinal.Data.Dao;
using CosmeticSolutionFinal.Data.Models;
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
//using System.CosmeticSolutionFinal.Data;

namespace CosmeticSolutionFinal
{
    public partial class AnalysisResult : Form
    {

        public AnalysisResult AgeGroup;
        int DDate = DateTime.Today.Year;
        ChartControl pieChart;
        public AnalysisResult()
        {
            InitializeComponent();
        }
        private void AnalysisResult_Load(object sender, EventArgs e)
        {

            AgeGroup = new AnalysisResult();
            ageModelBindingSource.DataSource = Dao.ooder.AgeRank(DDate - 1);
            pieChart = new ChartControl();

        }

    }
}
