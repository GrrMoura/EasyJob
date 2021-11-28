using EasyJob_Business.Core.Model;
using EasyJob_Business.Models.Addresses;
using EasyJob_Business.Models.Subsectors;
using EasyJob_Business.Models.Users;
using System;

namespace EasyJob_Business.Models.Vacancies.Jobs
{
    public class Job : Entity
    {
        public string Title { get; set; }

        public Subsector Subsector { get; set; }
        //TODO: criar um enum de sector e subsector
        public Adress Adress { get; set; }

        public decimal MinSalaryPerHour { get; set; }
        public decimal MaxSalaryPerHour { get; set; }

        public decimal HourPerWeek { get; set; }
        public decimal WeeklySalary { get; set; }
        public decimal BiWeeklySalary { get; set; }
        public decimal MonthlySalary { get; set; }

        public bool WeeklySalaryPayment { get; set; }
        public bool BiWeeklySalaryPayment { get; set; }
        public bool MonthlyPayment { get; set; }
        public bool Active { get; set; }

        public bool NeedExp { get; set; }
        public bool NeedCar { get; set; }
        public bool NeedTools { get; set; }
        public bool Ride { get; set; }

        public string Note { get; set; }

        public DateTime CreationTime { get; set; }
        public DateTime? ExpiryDate { get; set; }           
        public DateTime? ModifiedDate { get; set; }

        public User? User { get; set; }
        public Guid? UserId { get; set; }
              
        

    }
}
