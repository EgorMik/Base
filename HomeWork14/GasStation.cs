using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    class GasStation
    {
        private class Fuel
        {
            public int FuelGrade { get; set; }
            public double PriceForGallone { get; set; }
        }
        public enum CompanyList
        {
            Unknown,
            Wawa,
            QuikTrip,
            Sheetz
        }

        public enum StreetList
        {
            Unknown,
            Lincoln,
            Freemont,
            Portland
        }


        private Fuel fuel92 = new Fuel()
        {
            FuelGrade = 92,
            PriceForGallone = 0.00
        };

        private Fuel fuel95 = new Fuel()
        {
            FuelGrade = 95,
            PriceForGallone = 0.00
        };

        private Fuel fuel98 = new Fuel()
        {
            FuelGrade = 98,
            PriceForGallone = 0.00
        };

        public StreetList Street { get; set; }
        public double PriceForGallone92 { get => fuel92.PriceForGallone; set => fuel92.PriceForGallone = value; }
        public double PriceForGallone95 { get => fuel95.PriceForGallone; set => fuel95.PriceForGallone = value; }
        public double PriceForGallone98 { get => fuel98.PriceForGallone; set => fuel98.PriceForGallone = value; }
        public CompanyList Company { get; set; }

    }
}
