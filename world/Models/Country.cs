using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace world.Models
{
    public class Country
    {
        [DisplayName("Country")]
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Flag { get; set; }
        public static List<string> CountryNames { get; set; }
    }
}
