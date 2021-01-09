using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionFinal.Data.Models
{
    public class PopulationOfFemalePassenger
    {
        public PopulationOfFemalePassenger(int year, int passengernumber, int id, string name)
        {
            Year = year;
            PassengerNumber = passengernumber;
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public int PassengerNumber { get; set; }
        public int GetScoreOfFloatingPopulation()
        {
            return (int)(55 * ((double)PassengerNumber / 25000000));
        }

        public string GetFormattedStringFloatingPopulation()
        {
            return string.Format("{0:###,###,###,###}명 ({1}점)", PassengerNumber, (int)(55 * ((double)PassengerNumber / 25000000)));
        }
        //25 * 1달간 유동인구 / 1,000,000 (월간 유동인구수 25백만명이면 25점 만점)
    }
}
