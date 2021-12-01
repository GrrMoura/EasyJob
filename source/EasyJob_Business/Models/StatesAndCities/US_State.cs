using System.Collections;
using System.Collections.Generic;

namespace EasyJob_Business.Models.StatesAndCities
{
    public class US_State
    {
        public int Id { get; set; }
        public int aidi { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }

        public IList<US_City> Cities { get; set; }

    }
}
