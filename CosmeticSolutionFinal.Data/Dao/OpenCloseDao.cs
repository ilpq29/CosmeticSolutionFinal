using CosmeticSolutionFinal.Data;
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
    public class OpenCloseDao : SingleKeyDao<PassengerInfo, int>
    {
        protected override Expression<Func<PassengerInfo, int>> KeySelector => x => x.StationId;

        protected override Expression<Func<PassengerInfo, bool>> IsKey(int key)
        {
            throw new NotImplementedException();
        }

        public List<OpenCloseModel> GetOpenClose()
        {

            DateTime start = DateTime.Today.AddYears(-1);
            DateTime end = DateTime.Today.AddYears(1); // 기간을 1년으로 설정
            int yyy = start.Year;

            using (var context = new CosmeticFinalEntities())
            {
                var query = (from x in context.PassengerInfoes
                             where x.Date >= start && x.Date <= end
                             select new
                             {
                                 Date = x.Date.Year,
                                 StationName = x.Station.Name,
                                 StationId = x.StationId,
                                 StationAddress = x.Station.Address,
                                 TotalOpenEight = x.OpenTimeEight,
                                 TotalOpenNine = x.OpenTimeNine,
                                 TotalCloseNine = x.CloseTimeNine,
                                 TotalCloseTen = x.CloseTimeTen
                             }).GroupBy(x=>x.StationId).Select(
                   group => new { Date = group.FirstOrDefault().Date, StationId = group.FirstOrDefault().StationId, StationName = group.FirstOrDefault().StationName, StationAddress = group.FirstOrDefault().StationAddress, TotalOpenEight = group.Sum(x => x.TotalOpenEight), TotalOpenNine = group.Sum(x => x.TotalOpenNine), TotalCloseNine = group.Sum(x => x.TotalCloseNine), TotalCloseTen = group.Sum(x => x.TotalCloseTen)});

                var list = query.ToList();

                List<OpenCloseModel> models = new List<OpenCloseModel>();
                OpenCloseModel model;
                foreach (var item in list)
                {
                    model = new OpenCloseModel();
                    //model.Year = item.Date;
                    model.StationId = item.StationId;
                    model.StationName = item.StationName;
                    model.StationAddress = item.StationAddress;
                    if(item.TotalOpenEight > item.TotalOpenNine)
                    {
                        model.OpenTime = (int)item.TotalOpenEight;
                        model.Open = "8시";
                    }
                    else
                    {
                        model.OpenTime = (int)item.TotalOpenNine;
                        model.Open = "9시";
                    }

                    if (item.TotalCloseNine > item.TotalCloseTen)
                    {
                        model.CloseTime = (int)item.TotalCloseNine;
                        model.Close = "9시";
                    }
                    else
                    {
                        model.CloseTime = (int)item.TotalCloseTen;
                        model.Close = "10시";
                    }

                    models.Add(model);

                }
                return models;
            }
        }
    }
}
