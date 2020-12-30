using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionFinal.Data.Dao
{
    public class BrandDao : SingleKeyDao<Brand, int>
    {
        protected override Expression<Func<Brand, int>> KeySelector => x => x.BrandId;

        protected override Expression<Func<Brand, bool>> IsKey(int key)
        {
            throw new NotImplementedException();
        }

        public static List<Brand> GetBrands()
        {
            using( CosmeticFinalEntities context = (CosmeticFinalEntities)DbContextCreator.Create())
            {
                var query = from x in context.Brands
                            select x;

                return query.ToList(); // ToList() 함수가 호출될 때 쿼리가 실제로 날아간다(실행된다).
            }
        }
    }
}
