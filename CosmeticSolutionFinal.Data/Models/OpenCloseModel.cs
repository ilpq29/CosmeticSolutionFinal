using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionFinal.Data.Models
{
    public class OpenCloseModel
    {
        public DateTime Date { get; set; }
        public string StationName { get; set; }
        public string StationAddress { get; set; }
        public int Year { get; set; }
        public int StationId { get; set; }
        public int OpenTime { get; set; }
        public string Open { get; set; }
        public string Close { get; set; }
        public int TotalOpenNine { get; set; }
        public int TotalOpenEight { get; set; }
        public int TotalCloseNine { get; set; }
        public int TotalCloseTen { get; set; }
        // public int OpenTimeNine { get; set; }
        public int CloseTime { get; set; }
        //public int CloseTimeTen { get; set; }
    }
}
