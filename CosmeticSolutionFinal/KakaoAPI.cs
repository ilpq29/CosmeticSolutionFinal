using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmeticSolutionFinal
{
    public class KakaoAPI
    {
        public KakaoAPI()
        {
            LoadHTML();
        }

        WebClient webClient = new WebClient();
        WebBrowser browser = new WebBrowser();
        private string url;

        public void LoadHTML()
        {
            url = ".\\KakaoAPI.HTML";
            browser.Navigate( url );
        }

        public int GetPlaceCount(string place = "")
        {
            object x = browser.Document.InvokeScript("getPlaceCount()");

            return 1;
        }
    }
}
