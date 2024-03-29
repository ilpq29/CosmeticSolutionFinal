﻿using CosmeticSolutionFinal.Data.Models;
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

        public static List<string> GetAddress()
        {
            using (CosmeticFinalEntities context = (CosmeticFinalEntities)DbContextCreator.Create())
            {
                var query = from x in context.Stations
                            select x.Address;

                var list = query.Distinct().ToList();
                return list;
            }
        }
        public static List<Station> GetStation(string address)
        {
            using (CosmeticFinalEntities context = (CosmeticFinalEntities)DbContextCreator.Create())
            {
                var query = from x in context.Stations
                            where x.Address == address
                            select x;
                var list = query.ToList();
                return list;
            }
        }
        public static List<StationModel> GetInfo(string station)
        {
            using (var context = new CosmeticFinalEntities())
            {
                var query = from x in context.Stations
                            where x.Name == station
                            select new
                            {
                                x.Latitude,
                                x.Longitude
                            };
                var list = query.ToList();
                List<StationModel> model = new List<StationModel>();
                foreach (var x in list)
                {
                    model.Add(new StationModel(x.Latitude, x.Longitude));
                }
                return model.ToList();
            }
        }
    }
}


