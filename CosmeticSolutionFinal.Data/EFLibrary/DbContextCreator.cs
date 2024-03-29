﻿using CosmeticSolutionFinal.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary
{
    public class DbContextCreator
    {
        private const string ConnectionString = "metadata=res://*/CosmeticFinalModel.csdl|res://*/CosmeticFinalModel.ssdl|res://*/CosmeticFinalModel.msl;provider=System.Data.SqlClient;provider connection string=\"data source=cn76.ipdisk.co.kr,3423;initial catalog=CosmeticFinal;persist security info=True;user id=8F;password=1;MultipleActiveResultSets=True;App=EntityFramework\"";

        public static CosmeticFinalEntities Create()
        {
            CosmeticFinalEntities context = new CosmeticFinalEntities(ConnectionString);

            context.Configuration.ProxyCreationEnabled = false;

            return context;
        }
    }
}

namespace CosmeticSolutionFinal.Data
{
    public partial class CosmeticFinalEntities
    {
        public CosmeticFinalEntities(string connectionString) : base(connectionString)
        {
        }
    }
}
