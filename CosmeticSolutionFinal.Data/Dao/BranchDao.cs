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
    public class BranchDao : SingleKeyDao<Branch, int>
    {
        protected override Expression<Func<Branch, int>> KeySelector => x => x.BranchId;

        protected override Expression<Func<Branch, bool>> IsKey(int key)
        {
            throw new NotImplementedException();
        }

        public static List<BranchModel> GetBranch(int stationId)
        {
            using (CosmeticFinalEntities context = (CosmeticFinalEntities)DbContextCreator.Create())
            {
                var query = from x in context.Branches
                            where x.StationId == stationId
                            select new
                            {
                                x.Name,
                                x.Latitude,
                                x.Longitude
                            };
                var list = query.ToList();

                List<BranchModel> model = new List<BranchModel>();

                foreach (var x in list)
                {
                    model.Add(new BranchModel(x.Name, x.Latitude, x.Longitude));
                }

                return model;
            }

        }
    }
}
