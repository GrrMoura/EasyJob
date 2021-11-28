using EasyJob_Business.Core.Model;
using EasyJob_Business.Models.Sectors;
using System;

namespace EasyJob_Business.Models.Subsectors
{
    public class Subsector : SectorAndSubsector
    {
        public Sector Sector { get; set; }

        public Guid? SectorId { get; set; }
        public Guid JobId { get; set; }

     
        //BUSSINESS
        //butchery 
        //internalSales
        //foreignSales 
        //hairdresser 
        //manicure 
        //beautician
        //generalAssistant 

        //CAREASSISTENTE
        //elderCaregiver 
        //babysitter

        //CARREPAIRSHOP
        //elderCaregiver
        //babysitter 

        //CLEANING
        //houseCleaner,
        //BusinessCleaner,
        //retirementHomeCleaner,
        //Driver,

        //CONSTRUCCTION
        //painter
        //generalAssistant 
        //carpenter
        //mason 
        //siding 
        //electrician
        //Plumber
        //tile
        //floors

        //RESTAURNT
        //     dishMaker 
        //cleaner
        //dishwasher
        //cooker 
        //waiter 
        //packer 
        //shopAssistant 
        //deliveryman 
        //manager 
    }
}
