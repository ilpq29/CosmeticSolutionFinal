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


namespace CosmeticSolutionFinal
{
    public partial class KakaoMap : Form
    {
       
        public KakaoMap()
        {
            InitializeComponent();
        }
        private void KakaoMap_Load(object sender, EventArgs e)
        {
            // WebBrowser 컨트롤에 "kakaoMap.html" 을 표시한다. 
            Version ver = webBrowser1.Version;
            string name = webBrowser1.ProductName;
            string str = webBrowser1.ProductVersion;
            string html = "kakaoMap.html";
            string dir = System.IO.Directory.GetCurrentDirectory();
            string path = System.IO.Path.Combine(dir, html);
            webBrowser1.Navigate(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cosmetic = "화장품";
                object[] arr = new object[] { textBox1.Text + cosmetic };
                webBrowser1.Document.InvokeScript("geo", arr); // html 의 geo 자바스크립트 함수 호출. 
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        
    }
}
