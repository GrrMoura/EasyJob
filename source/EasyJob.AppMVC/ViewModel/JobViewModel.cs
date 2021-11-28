using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyJob.AppMVC.ViewModel
{
    public class JobViewModel
    {

        public JobViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }


        [DisplayName("Título da Vaga")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Title { get; set; }

        public SectorViewModel Sector { get; set; }

        public SubsectorViewModel Subsector { get; set; }

        public AddressViewModel Adress { get; set; }

        [DisplayName("Salário Mínimo por hora")]
        [Required(ErrorMessage = "O campo {0} precisa ser preenchido")]
        public decimal MinSalaryPerHour { get; set; }

        [DisplayName("Salário Máximo por hora")]
        public decimal MaxSalaryPerHour { get; set; }

        [DisplayName("Horas por Semana")]
        [Required(ErrorMessage = "O campo {0} precisa ser preenchido")]
        public decimal HourPerWeek { get; set; }

        [DisplayName("Salário Semanal")]
        public decimal WeeklySalary { get; set; }

        [DisplayName("Salário Quinzenal")]
        public decimal BiWeeklySalary { get; set; }

        [DisplayName("Salário Mensal")]
        public decimal MonthlySalary { get; set; }

        [DisplayName("Pagamento Semanal ?")]
        public bool WeeklySalaryPayment { get; set; }

        [DisplayName("Pagamento Quinzenal ?")]
        public bool BiWeeklySalaryPayment { get; set; }

        [DisplayName("Pagamento Mensal ?")]
        public bool MonthlyPayment { get; set; }

        [DisplayName("Experiência ?")]
        public bool NeedExp { get; set; }

        [DisplayName("Carro ?")]
        public bool NeedCar { get; set; }

        [DisplayName("Ferramentas ?")]
        public bool NeedTools { get; set; }

        [DisplayName("Carona ?")]
        public bool Ride { get; set; }

        [DisplayName("ativo ?")]
        public bool Active { get; set; }

        [DisplayName("Observações")]
        [MaxLength(1000, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres")]
        public string Note { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM}", ApplyFormatInEditMode = true)]
        public DateTime CreationTime { get; set; }

        [ScaffoldColumn(false)]
        public DateTime ExpiryDate { get; set; }


        public Guid UserId { get; set; }

        public Guid AdressId { get; set; }
        public Guid SubsectorId { get; set; }

        public UserViewModel User { get; set; }
    }
}
