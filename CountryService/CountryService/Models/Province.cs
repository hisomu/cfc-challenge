using System;

namespace CountryService.Models
{
    public class Province
    {
        public string Name { get; set; }

        public string Short { get; set; }

        public string Rank { get; set; }

        public long Population { get; set; }

        public string Capital { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }
    }
}
