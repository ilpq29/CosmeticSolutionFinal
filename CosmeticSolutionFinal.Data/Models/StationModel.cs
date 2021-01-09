﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionFinal.Data.Models
{
    public class StationModel
    {
        public StationModel(string address, double latitude, double longitude)
        {
            this.Address = address;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
        public int StationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
