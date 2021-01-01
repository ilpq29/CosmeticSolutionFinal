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
    public class OrderDao : SingleKeyDao<Order, int>
    {
        protected override Expression<Func<Order, int>> KeySelector => x => x.OrderId;

        protected override Expression<Func<Order, bool>> IsKey(int key)
        {
            throw new NotImplementedException();
        }

        public static List<Order> GetOrders()
        {
            using (CosmeticFinalEntities context = (CosmeticFinalEntities)DbContextCreator.Create())
            {
                var query = from x in context.Orders
                            select x;

                return query.ToList(); // ToList() 함수가 호출될 때 쿼리가 실제로 날아간다(실행된다).
            }
        }

        public List<AgeModel> AgeRank(int year){
            
            DateTime @from = DateTime.Today.AddMonths(year * -1);
            DateTime to = DateTime.Today;

            using(var context = new CosmeticFinalEntities())
            {
                var query = from x in context.Orders
                            where x.SelledAt >= @from && x.SelledAt <= to
                            select new
                            {
                                Date = x.SelledAt,
                                Age = x.Customer.Birth,
                                TotalPrice = x.TotalPrice
                            };
                var list = query.ToList();

                List<AgeModel> models = new List<AgeModel>();

                foreach(var item in list)
                {
                    AgeModel model = models.Find(x => x.Date == item.Date && x.Age == item.Age);

                    if(model != null)
                    {
                        model.TotalPrice += item.TotalPrice;
                    }
                    else
                    {
                        model = new AgeModel();
                        model.Date = item.Date;
                        model.Age = item.Age;
                        model.TotalPrice = item.TotalPrice;

                        models.Add(model);
                    }
                }
                return models;
            }
        }

    }
}