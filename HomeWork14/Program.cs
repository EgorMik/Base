using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GasStation> gasStations = new List<GasStation>();
            gasStations.Add(new GasStation()
            {
                Company = GasStation.CompanyList.QuikTrip,
                Street = GasStation.StreetList.Lincoln,
                PriceForGallone92 = 1.00,
                PriceForGallone95 = 1.25,
                PriceForGallone98 = 1.50
            });

            gasStations.Add(new GasStation()
            {
                Company = GasStation.CompanyList.Wawa,
                Street = GasStation.StreetList.Lincoln,
                PriceForGallone92 = 1.01,
                PriceForGallone95 = 1.24,
                PriceForGallone98 = 1.60
            });

            gasStations.Add(new GasStation()
            {
                Company = GasStation.CompanyList.Wawa,
                Street = GasStation.StreetList.Freemont,
                PriceForGallone92 = 0.99,
                PriceForGallone95 = 1.20,
                PriceForGallone98 = 1.50
            });

            gasStations.Add(new GasStation()
            {
                Company = GasStation.CompanyList.Sheetz,
                Street = GasStation.StreetList.Freemont,
                PriceForGallone92 = 1.09,
                PriceForGallone98 = 1.41
            });

            gasStations.Add(new GasStation()
            {
                Company = GasStation.CompanyList.QuikTrip,
                Street = GasStation.StreetList.Portland,
                PriceForGallone92 = 0.80,
                PriceForGallone95 = 1.10,
                PriceForGallone98 = 1.25
            });

            gasStations.Add(new GasStation()
            {
                Company = GasStation.CompanyList.Sheetz,
                Street = GasStation.StreetList.Portland,
                PriceForGallone92 = 0.82,
                PriceForGallone95 = 1.15,
            });

            gasStations.Add(new GasStation()
            {
                Company = GasStation.CompanyList.Wawa,
                Street = GasStation.StreetList.Portland,
                PriceForGallone92 = 0.99,
                PriceForGallone95 = 1.2,
                PriceForGallone98 = 1.6
            });

            var streets = gasStations.OrderBy(gasStation => gasStation.Street.ToString())
                                    .GroupBy(gasStation => gasStation.Street)
                                    .Select(street => new { Street = street.Key, NumberOfStations = street.Count() });

            foreach (var street in streets)
            {
                Console.WriteLine($"On the {street.Street}-Street are {street.NumberOfStations} gas stations");
            }

        }
    }
}
   