﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionFinal.Data.Models
{
    public class StationModel
    {
        private double? longitude;
        private double? latitude;

        public StationModel(string address, double? longitude, double? latitude)
        {
            Address = address;
            this.longitude = longitude;
            this.latitude = latitude;
        }

        //private double? longitude;
        //private double? latitude;


        //public StationModel(string address, double? longitude, double? latitude) : this(address)
        //{
        //    Address = address;
        //    this.longitude = longitude;
        //    this.latitude = latitude;
        //}

        public int StationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
