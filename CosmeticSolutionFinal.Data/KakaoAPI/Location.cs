using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionFinal.Data
{
    internal class Location
    {
        internal string Name { get; set; }
        internal double Lattitude { get; set; }
        internal double Longit { get; set; }
        internal Location(string name, double lat, double lng)
        {
            Name = name;
            Lattitude = lat;
            Longit = lng;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
