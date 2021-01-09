using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionFinal.Data.Dao
{
    public class InfoNearStationDao : SingleKeyDao<InformationNearStation, int>
    {
        protected override Expression<Func<InformationNearStation, int>> KeySelector => x => x.Id;

        protected override Expression<Func<InformationNearStation, bool>> IsKey(int key)
        {
            throw new NotImplementedException();
        }

        public List<InformationNearStation> GetCompetitorStoreNumber(int stationId)
        {
            using(CosmeticFinalEntities context = DbContextCreator.Create())
            {
                var query = from x in context.InformationNearStations
                            where x.StationId == stationId
                            select x;
                return query.ToList();
            }
        }
    }
}
