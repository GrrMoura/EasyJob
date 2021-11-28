using EasyJob_Business.Models.Addresses;
using System;

namespace EasyJob_Business.Core.Model
{
    public abstract class Payment : Entity
    {
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }

        public string Payer { get; set; }

        public string Email { get; set; }
        public Adress Adress { get; set; }
    }
}
