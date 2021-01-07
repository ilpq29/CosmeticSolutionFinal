using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionFinal.Data
{
    public class StationDao : SingleKeyDao<Station, int>
    {
        protected override Expression<Func<Station, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<Station, bool>> IsKey(int key)
        {
            throw new NotImplementedException();
        }
        
        public List<StationModel> GetStations()
        {
            using (CosmeticFinalEntities context = (CosmeticFinalEntities)DbContextCreator.Create())
            {
                return context.Stations.Select(x => x.Address).ToList();               
            }
        }
        
    }
}

