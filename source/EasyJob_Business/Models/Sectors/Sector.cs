using EasyJob_Business.Core.Model;
using EasyJob_Business.Models.Subsectors;
using System.Collections.Generic;

namespace EasyJob_Business.Models.Sectors
{
    public class Sector : SectorAndSubsector
    {
        public ICollection<Subsector> Subsector { get; set; }

        //TODO -- Fazer um dropDown para poder escolher os setores e assim como criar uma chave estrangeria para cada setor
       
        

        //Health = 1,
        //restaurant = 2,
        //Building = 3,
        //landscaping = 4,
        //HelpCare = 5,
        //Cleaning = 6
    }
}
