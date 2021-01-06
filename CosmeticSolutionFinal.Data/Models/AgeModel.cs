using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionFinal.Data.Models
{
    public class AgeModel
    {
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