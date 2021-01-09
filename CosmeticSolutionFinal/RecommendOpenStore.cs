using CosmeticSolutionFinal.Data;
using CosmeticSolutionFinal.Data.Dao;
using CosmeticSolutionFinal.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CosmeticSolutionFinal
{
    public partial class RecommendOpenStore : Form
    {
        private static System.Windows.Forms.Timer aTimer = new System.Windows.Forms.Timer();
        //KakaoAPI kakao = new KakaoAPI();
        private BackgroundWorker backgroundWorker1;
        private InfoNearStationDao infoNearStationDao = new InfoNearStationDao();
        List<PopulationOfFemalePassenger> listFemale = null;
        List<InformationNearStation> informationNearStationList = null;
        bool timerStop = false;

        public RecommendOpenStore()
        {
            InitializeComponent();

            labelProgress.Text = "분석중";
            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += new DoWorkEventHandler(BackgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            GetAnalysisData();
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetAnalysisData();

            SetProgressLabelAnalyzeFinished();
        }

        private void SetProgressLabelAnalyzeFinished()
        {
            timerStop = true;
            labelProgress.Text = "분석 완료";
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            SetProgressLabelAnalyzeStart();
            backgroundWorker1.RunWorkerAsync();
        }

        private void SetProgressLabelAnalyzeStart()
        {
            labelProgress.Text = "분석중";
            labelProgress.Show();

            timerStop = false;

            aTimer.Start();
        }

        private void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            if (timerStop == true)
            {
                aTimer.Stop();
                return;
            }

            SetProgressLabel();
        }

        private void SetProgressLabel()
        {
            labelProgress.Text += ".";
        }

        private void SetAnalysisData()
        {
            dataGridAnalysisResult.Rows.Clear();

            int i = 0;
            foreach (var x in listFemale)
            {
                dataGridAnalysisResult.Rows.Add(x.Name, x.GetFormattedStringFloatingPopulation(),
                    informationNearStationList[i].GetFormattedStringNumberOfCompetitor(),
                    informationNearStationList[i].GetFormattedStringBuildArea(),
                    informationNearStationList[i].GetFormattedStringNumberOfStore(),
                    (x.GetScoreOfFloatingPopulation() + informationNearStationList[i].GetScoreNumberOfCompetitor() +
                    informationNearStationList[i].GetScoreBuildArea() +
                    informationNearStationList[i].GetScoreNumberOfStore()).ToString() + "점"

                    );
                i++;
            }
        }

        private void GetAnalysisData()
        {
            // 주 매출 연령을 찾아낸다
            //List<OrderAnalysis> list = OrderDao.GetOrderAnalysisResult(dateTimePicker.Value.Year);

            //foreach (var x in list)
            //{
            //    dataGridAnalysisResult.Rows.Add(x.GetFormattedDate(), x.GetFormattedAge(), x.GetFormattedNumberOfOrder());
            //}

            // 여성 유동 인구 비중 높은 역을 찾아낸다
            // 주 매출 연령을 찾아낸다

            if (listFemale != null && listFemale.Count() > 0)
                listFemale.Clear();

            listFemale = PassengerInfoDao.GetPopulationOfFemalePassenger(dateTimePicker.Value.Year);

            if (informationNearStationList == null)
                informationNearStationList = new List<InformationNearStation>();
            else
                informationNearStationList.Clear();

            foreach (var x in listFemale)
                informationNearStationList.Add(GetInformationNearStation(x.Id));

            // 매장 평수 데이터??? 어디에?

            // 입점 매장 수??? 어디에?
        }

        private InformationNearStation GetInformationNearStation(int stationId)
        {
            List<InformationNearStation> list = infoNearStationDao.GetCompetitorStoreNumber(stationId);

            return list[0];
        }

        private void RunScript(string stationName)
        {
            int idx = stationName.IndexOf("역");
            string data;
            if (idx > -1)
            {
                data = stationName.Substring(0, idx);
            }
            else
                data = stationName;

            idx = data.IndexOf("(");

            if (idx > -1)
            {
                data = data.Substring(0, idx);
            }

            data += "역";
            // 입점 매장 수??? 어디에?
            MainForm form = this.MdiParent as MainForm;
            KakaoAPITest apiForm;

            if (form != null)
            {
                apiForm = form.childformDict["KakaoAPITest"] as KakaoAPITest;

                if(apiForm != null)
                    apiForm.RunScriptFunc(data);
            }
        }

        private int GetCompetitorStoreNum()
        {
            MainForm form = this.MdiParent as MainForm;
            KakaoAPITest apiForm;

            if (form != null)
            {
                apiForm = form.childformDict["KakaoAPITest"] as KakaoAPITest;

                if (apiForm != null)
                    return apiForm.GetPlaceCount();
            }

            return 0;
        }

        private void RecommendOpenStore_SizeChanged(object sender, EventArgs e)
        {
            dataGridAnalysisResult.Location = new Point(0, tableLayoutPanel.Height + 8 + 8);
            dataGridAnalysisResult.Width = this.Width;
            dataGridAnalysisResult.Height = this.Height - tableLayoutPanel.Height - 8 - 8;
        }

        private void RecommendOpenStore_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = new DateTime(2020, 1, 1);
            labelProgress.Hide();

            aTimer.Interval = 100;
            aTimer.Start();
            aTimer.Tick += new EventHandler(TimerEventProcessor);
        }

        private void dateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetProgressLabelAnalyzeStart();
                backgroundWorker1.RunWorkerAsync();
            }
        }
    }
}
