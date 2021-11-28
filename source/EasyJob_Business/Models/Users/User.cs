
using EasyJob_Business.Core.Model;
using EasyJob_Business.Models.Addresses;
using EasyJob_Business.Models.Vacancies.Jobs;
using System;
using System.Collections.Generic;

namespace EasyJob_Business.Models.Users
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }


        public bool Message { get; set; }
        public bool Call { get; set; }
        public bool Active { get; set; }
        public bool Mail { get; set; }


        public DateTime CreationTime { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        

        public Adress Address { get; set; }

        public ICollection<Job>? Jobs { get; set; }


    }
}
