﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionFinal.Data.Dao
{
    public class Dao
    {

        public static OrderDao order = new OrderDao();

        public static OrderDao ooder = new OrderDao();
        public static OpenCloseDao openClose = new OpenCloseDao();
        public static StationDao station = new StationDao();

    }
}
