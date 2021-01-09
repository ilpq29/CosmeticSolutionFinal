using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CosmeticSolutionFinal
{
    public partial class KakaoAPITest : Form
    {

        //private static System.Timers.Timer aTimer;
        public int StoreCount {get; set;}

        public KakaoAPITest()
        {
            InitializeComponent();
        }

        //private string url;

        private void LoadHTML()
        {
            string html = "kakaoAPI.html";
            string dir = System.IO.Directory.GetCurrentDirectory();
            string path = System.IO.Path.Combine(dir, html);
            webBrowser.Navigate(path);
        }

        public void RunScriptFunc(string stationName)
        {
            int idx = textboxStationName.Text.IndexOf("역");
            string data;
            if (idx > -1)
            {
                data = textboxStationName.Text.Substring(0, idx);
            }
            else
                data = textboxStationName.Text;

            idx = data.IndexOf("(");

            if (idx > -1)
            {
                data = data.Substring(0, idx);
            }

            data += "역";

            try
            {
                string cosmetic = " 화장품";
                object[] arr = new object[] { data + cosmetic };

                webBrowser.Document.InvokeScript("geo", arr ); // html의 geo 자바스크립트 함수 호출. 
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public int GetPlaceCount()
        {
            int count = 0;
            try
            {
                object y = webBrowser.Document.InvokeScript("GetPlaceCount"); // html의 GetPlaceCount 자바스크립트 함수 호출.

                if (y == null)
                    count = 0;
                else
                    count = (int)y;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            MessageBox.Show("경쟁 업체 입점 매장 수" + count.ToString());

            return count;
        }

        

        

        private void KakaoAPITest_Load(object sender, EventArgs e)
        {
            LoadHTML();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunScriptFunc("종로3가역");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetPlaceCount();
        }
    }
}
