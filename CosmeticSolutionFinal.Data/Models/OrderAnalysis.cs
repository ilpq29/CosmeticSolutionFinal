using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionFinal.Data.Models
{
    public class OrderAnalysis
    {
        public OrderAnalysis(int _age, DateTime _date, int _numberoforder)
        {
            Age = _age;
            date = _date;
            NumberOfOrder = _numberoforder;
        }

        public string GetFormattedAge()
        {
            if (Age == 4)
                return String.Format($"60대 이상");
            else if (Age == 3)
                return String.Format($"40 ~ 50대");
            else if (Age == 2)
                return String.Format($"20 ~ 30대");
            else if (Age == 1)
                return String.Format($"10대");

            return "";
        }

        public string GetFormattedNumberOfOrder()
        {
            return String.Format($"{NumberOfOrder} 건");
        }

        public string GetFormattedDate()
        {
            return String.Format($"{date.Year} 년");
        }

        public int Age { get; set; } // 연령대

        public DateTime date { get; set; } // 날짜

        public int NumberOfOrder { get; set; } // 연간 매출 건수
    }
}
