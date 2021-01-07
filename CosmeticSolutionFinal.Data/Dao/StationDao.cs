using CosmeticSolutionFinal.Data.Models;
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
        protected override Expression<Func<Station, int>> KeySelector => x => x.StationId;

        protected override Expression<Func<Station, bool>> IsKey(int key)
        {
            throw new NotImplementedException();
        }

        public static List<StationModel> GetAddress()
        {
            using (CosmeticFinalEntities context = (CosmeticFinalEntities)DbContextCreator.Create())
            {
                var list = context.Stations.OrderBy(x => x.Address).ToList();

                List<StationModel> model = new List<StationModel>();

                foreach(var x in list)
                {
                    model.Add(new StationModel(x.Address));
                }
                return model;
            }
       
        }
    }
}

