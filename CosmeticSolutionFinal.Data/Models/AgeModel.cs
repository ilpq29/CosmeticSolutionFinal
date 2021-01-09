using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionFinal.Data.Models
{
    public class AgeModel
    {
        private string address;
        private double? longitude;
        private double? latitude;

        public AgeModel(int birth, int totalPrice, DateTime date)
        {
            Date = date;
            Birth = birth;
            TotalPrice = totalPrice;
        }

        public AgeModel(string address, double? longitude, double? latitude)
        {
            this.address = address;
            this.longitude = longitude;
            this.latitude = latitude;
        }

        //private object date;

        //public AgeModel(int birth, int totalPrice)
        //{
        //    //this.date = date;
        //    Birth = birth;
        //    TotalPrice = totalPrice;
        //}

        public DateTime Date { get; set; }
        public int Birth { get; set; }
        public int TotalPrice { get; set; }
    }
}