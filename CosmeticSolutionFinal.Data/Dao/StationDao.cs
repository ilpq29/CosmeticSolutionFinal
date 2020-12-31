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

        public static List<Station> GetStation(string name, string address)
        {
            using (CosmeticFinalEntities context = (CosmeticFinalEntities)DbContextCreator.Create())
            {
                var query = from x in context.Stations
                            where x.Name.Contains(name) && x.Address.Contains(address)
                            select x;
                return query.ToList();
            }

        }    
    }
}

