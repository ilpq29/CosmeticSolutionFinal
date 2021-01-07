using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmeticSolutionFinal
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Form> childformDict = new Dictionary<string, Form>();
        List<Form> childformList = new List<Form>();
        List<string> childformNameList = new List<string>();
        List<string> tabItemList = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void RegisterChildForm(string keyString, Form _form)
        {
            childformDict.Add(keyString, _form);
            childformList.Add(_form);
            childformNameList.Add(keyString);
            _form.WindowState = FormWindowState.Maximized;
            _form.MdiParent = this;
            _form.Show();
        }

        private void ShowChildForm(string key)
        {
            childformDict[key].MdiParent = this;
            childformDict[key].Show();
            childformDict[key].Activate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Form form = null;

            // 1. 입점 추천 결과 화면
            form = new AnalysisResult();
            RegisterChildForm("AnalysisResult", form);

            // 2. 경쟁 업체 맵 화면
            form = new CompetitorStoreMap();
            RegisterChildForm("CompetitorStoreMap", form);

            // 3. 500m 이내 입점 추천 정보 맵 화면
            form = new Recommendation500mAreaMap();
            RegisterChildForm("Recommendation500mAreaMap", form);

            // 4. 입점 추천 점수 화면
            form = new RecommendOpenStore();
            RegisterChildForm("RecommendOpenStore", form);

            // 5. Open Close 시간 추천 화면
            form = new RecommendStoreOpenCloseTime();
            RegisterChildForm("RecommendStoreOpenCloseTime", form);

            //6 kakao map
            form = new KakaoMap();
            RegisterChildForm("Kakaomap", form);

            //7. 내맘대로홈
            form = new MyChoice();
            RegisterChildForm("MyChoice", form);

            ShowChildForm(childformNameList[0]);
        }

        //private void SetControlSize(object _control)
        //{
        //    Control control = _control as Control;
        //    control.Location = new Point(0, 0);
        //    control.Size = new Size(this.Size.Width, 20);
        //}

        //private void SetControlSize(Control _control, Control tab)
        //{
        //    Control control = _control as Control;
        //    if (control == null)
        //        return;

        //    control.Location = new Point(0, tab.Height);
        //    control.Size = new Size(this.Size.Width, this.Size.Height - tab.Height);
        //}

        //ShowChildForm(e.ClickedItem.Text);


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 1. 입점 추천 결과 화면
            ShowChildForm(childformNameList[0]);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 2. 경쟁 업체 맵 화면
            ShowChildForm(childformNameList[1]);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 3. 500m 이내 입점 추천 정보 맵 화면
            ShowChildForm(childformNameList[2]);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 4. 입점 추천 화면
            ShowChildForm(childformNameList[3]);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 5. Open Close 시간 추천 화면
            ShowChildForm(childformNameList[4]);
        }
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //6
            ShowChildForm(childformNameList[5]);
        }

        private void barButtonItem6_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 7 MyChoice
            ShowChildForm(childformNameList[6]);
        }
    }
}
