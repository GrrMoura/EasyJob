using EasyJob_Business.Core.Model;
using EasyJob_Business.Models.Subsectors;
using EasyJob_Business.Models.Users;
using EasyJob_Business.Models.Vacancies.Jobs;
using System;
using System.Collections.Generic;

namespace EasyJob_Business.Models.Addresses
{
    public class Adress : Entity
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        public DateTime CreationTime { get; set; }
        public Guid? UserId { get; set; }
        public Guid? JobId { get; set; }

              
        public User User { get; set; }
        public Job Job { get; set; }

        
                     
       
    }
}
