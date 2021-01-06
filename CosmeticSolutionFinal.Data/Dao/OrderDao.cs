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


        //public List<AgeModel> AgeRank(int topCount, DateTime year){

        //    //new DateTime(year.Year - 1, 1, 1);
        //    DateTime @from = DateTime.Today.AddYears(-1);
        //    DateTime to = from.AddYears(1); //기간 1년

        //    using(var context = new CosmeticFinalEntities())
        //    {
        //        var query = (from x in context.Orders
        //                    where x.SelledAt >= @from && x.SelledAt <= to
        //                    select new
        //                    {
        //                        Age = x.Customer.Birth,
        //                        TotalPrice = x.TotalPrice
        //                    }).GroupBy(x => x.Age).Select(
        //            group => new { group.FirstOrDefault().Age, TotalPrice = group.Sum(x => x.TotalPrice) }).OrderByDescending(x=>x.TotalPrice).Take(topCount);

        //        var list = query.ToList();

        //        List<AgeModel> model = new List<AgeModel>();

        //        foreach(var x in list)
        //        {
        //            model.Add(new AgeModel(x.Age, x.TotalPrice));
        //        }
        //        return model;
        //    }
        //}


        //public List<AgeModel> AgeRank(int year)
        //{

        //    DateTime start = DateTime.Today.AddYears(year * -1);
        //    DateTime end = DateTime.Today; // 기간을 1년으로 설정
        //    int yyy = start.Year;

        //    using (var context = new CosmeticFinalEntities())
        //    {
        //        var query = (from x in context.Orders
        //                     where x.SelledAt >= start && x.SelledAt <= end
        //                     select new
        //                     {
        //                        // Date = x.SelledAt,
        //                         Birth = (((yyy - x.Customer.Birth) / 10) * 10),
        //                         TotalPrice = x.TotalPrice
        //                     }).GroupBy(x => x.Birth).Select(
        //           group => new { group.FirstOrDefault().Birth, TotalPrice = group.Sum(x => x.TotalPrice) });

        //        var list = query.ToList();

        //        List<AgeModel> model = new List<AgeModel>();

        //        foreach (var x in list)
        //        {
        //            model.Add(new AgeModel(x.Birth, x.TotalPrice));
        //        }

        //        return model;
        //    }
        //}



        public List<AgeModel> AgeRank(int year)
        {
            using (var context = new CosmeticFinalEntities())
            {
                ////new DateTime(year.Year - 1, 1, 1);
                DateTime @from = DateTime.Today.AddYears(year * -1);
                DateTime to = DateTime.Today; //기간 1년

                var query = from x in context.Orders
                            where x.SelledAt >= @from && x.SelledAt <= to
                            select new
                            {
                                Date = x.SelledAt,
                                Birth = x.Customer.Birth,//((@from.Year - x.Customer.Birth) / 10) * 10,
                                TotalPrice = x.TotalPrice
                            };
                var list = query.ToList();

                List<AgeModel> models = new List<AgeModel>();

                foreach (var item in list)
                {
                    AgeModel model = models.Find(x => x.Date == item.Date && x.Birth == item.Birth);

                    if (model != null)
                    {
                        model.TotalPrice += item.TotalPrice;
                    }
                    else
                    {
                        model = new AgeModel();
                        model.Date = item.Date;
                        model.Birth = item.Birth;
                        model.TotalPrice = item.TotalPrice;

                        models.Add(model);
                    }
                }
                return models;
            }
        }

    }
}