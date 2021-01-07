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


        public List<AgeModel> AgeRank()
        {

            DateTime start = DateTime.Today.AddYears(-1);
            DateTime end = DateTime.Today.AddYears(1); // 기간을 1년으로 설정
            int yyy = start.Year;

            using (var context = new CosmeticFinalEntities())
            {
                var query = (from x in context.Orders
                             where x.SelledAt >= start && x.SelledAt <= end
                             select new
                             {
                                 Date = x.SelledAt,
                                 Birth = (((yyy - x.Customer.Birth) / 10) * 10),
                                 TotalPrice = x.TotalPrice
                             }).GroupBy(x => x.Birth).Select(
                   group => new { Birth = group.FirstOrDefault().Birth, TotalPrice = group.Sum(x => x.TotalPrice), Date = group.FirstOrDefault().Date});

                var list = query.ToList();

                List<AgeModel> model = new List<AgeModel>();

                foreach (var x in list)
                {
                    model.Add(new AgeModel(x.Birth, x.TotalPrice, x.Date));
                }

                return model;
            }
        }

        public static List<OrderAnalysis> GetOrderAnalysisResult(int year, int month = 1, int day = 1)
        {
            DateTime @from = new DateTime(year, month, day);
            DateTime to = from.AddYears(1);

            using (CosmeticFinalEntities context = DbContextCreator.Create())
            {
                // 판매 데이터 테이블과 고객 테이블을 조인하여 고객의 생일을 가져온다. 생일은 연령대 계산에 사용한다.
                //var query = from x in context.Orders
                //             where x.SelledAt >= @from && x.SelledAt <= to
                //             select new
                //             {
                //                    Id = x.OrderId,
                //                    Birth = x.Customer.Birth,
                //             };

                var query = (from x in context.Orders
                             where x.SelledAt >= @from && x.SelledAt <= to
                             select new
                             {
                                 OrderDate = x.SelledAt.Year,
                                 Quantity = 1,
                                 AgeGroup = (DateTime.Now.Year - x.Customer.Birth - 1) >= 60 ? 4 :
                                 ((DateTime.Now.Year - x.Customer.Birth - 1) < 60 && (DateTime.Now.Year - x.Customer.Birth - 1) >= 40) ? 3 :
                                 ((DateTime.Now.Year - x.Customer.Birth - 1) < 40 && (DateTime.Now.Year - x.Customer.Birth - 1) >= 20) ? 2 : 1
                             }).GroupBy(x => x.AgeGroup)
                                .Select
                                (
                                    group =>
                                    new
                                    {
                                        group.FirstOrDefault().OrderDate,
                                        group.FirstOrDefault().AgeGroup,
                                        NumberOrder = group.Sum(x => x.Quantity)
                                    }
                                ).OrderByDescending(x => x.NumberOrder).Take(1);

                var queryY = query.ToList();

                List<OrderAnalysis> list = new List<OrderAnalysis>();

                foreach (var y in queryY)
                {
                    list.Add(new OrderAnalysis(y.AgeGroup, new DateTime(y.OrderDate, 1, 1), y.NumberOrder));
                }

                return list;
            }
        }

        public static int GetRangeGroup(int age)
        {
            if (age < 20)
                return 1;
            else if (age >= 20 && age < 40)
                return 2;
            else if (age >= 40 && age < 60)
                return 3;
            else if (age < 20)
                return 4;

            return 0;
        }



        //public List<AgeModel> AgeRank()
        //{
        //    using (var context = new CosmeticFinalEntities())
        //    {
        //        ////new DateTime(year.Year - 1, 1, 1);
        //        DateTime @from = DateTime.Today.AddYears(-1);
        //        DateTime to = DateTime.Today.AddYears(1); //기간 1년

        //        var query = from x in context.Orders
        //                    where x.SelledAt >= @from && x.SelledAt <= to
        //                    select new
        //                    {
        //                        Date = x.SelledAt,
        //                        Birth = ((@from.Year - x.Customer.Birth) / 10) * 10,
        //                       // x.Customer.Birth,
        //                        TotalPrice = x.TotalPrice
        //                    };
        //        var list = query.ToList();

        //        List<AgeModel> models = new List<AgeModel>();

        //        foreach (var item in list)
        //        {
        //            AgeModel model = models.Find(x => x.Date == item.Date && x.Birth == item.Birth);

        //            if (model != null)
        //            {
        //                model.TotalPrice += item.TotalPrice;
        //            }
        //            else
        //            {
        //                model = new AgeModel();
        //                model.Date = item.Date;
        //                model.Birth = item.Birth;
        //                model.TotalPrice = item.TotalPrice;

        //                models.Add(model);
        //            }
        //        }
        //        return models;
        //    }
        //}

    }
}