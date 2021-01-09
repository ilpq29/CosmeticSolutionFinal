using CosmeticSolutionFinal.Data.Models;
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionFinal.Data.Dao
{
    public class PassengerInfoDao : DualKeyDao<PassengerInfo, DateTime, int>
    {
        protected override Expression<Func<PassengerInfo, bool>> IsKey(DateTime key1, int key2)
        {
            return x => x.Date == key1 && x.StationId == key2;
        }

        public static List<PopulationOfFemalePassenger> GetPopulationOfFemalePassenger(int year, int count=225)
        {
            DateTime @from = new DateTime(year, 1, 1 );
            DateTime to = from.AddYears(1);

            using(CosmeticFinalEntities context = (CosmeticFinalEntities)DbContextCreator.Create())
            {
                var query = (from x in context.PassengerInfoes
                            where x.Date >= @from && x.Date <= to
                            group x by new
                            {
                                x.StationId,
                            } into g
                            select new
                            {
                                Id = g.Key.StationId,
                                Year = g.FirstOrDefault().Date.Year,
                                Name = g.FirstOrDefault().Station.Name,
                                PassengerNumber = g.Sum(x => x.PopulationPerMonth)
                            }).OrderByDescending( x => x.PassengerNumber ).Take( count );
                
                var list = query.ToList();

                List<PopulationOfFemalePassenger> listPopulation = new List<PopulationOfFemalePassenger>();

                foreach (var x in list)
                {
                    listPopulation.Add(new PopulationOfFemalePassenger(x.Year, x.PassengerNumber, x.Id, x.Name));
                }

                return listPopulation;
            }
        }
    }
}
