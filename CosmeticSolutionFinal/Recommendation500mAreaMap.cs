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
    public partial class Recommendation500mAreaMap : Form
    {
        public Recommendation500mAreaMap()
        {
            InitializeComponent();
        }

        private void Recommendation500mAreaMap_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("www.google.co.kr");/*"https://maps.googleapis.com/maps/api/staticmap?center=Brooklyn+Bridge,New+York,NY&zoom=13&size=600x300&maptype=roadmap&markers=color:blue%7Clabel:S%7C40.702147,-74.015794&markers=color:green%7Clabel:G%7C40.711614,-74.012318&markers=color:red%7Clabel:C%7C40.718217,-73.998284&key=AIzaSyAENM67H18NwY6zTBdyB6M1oRedclmjbsc");*/
            
        }
    }
}
