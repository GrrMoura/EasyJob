using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyJob.AppMVC.ViewModel.StatesAndCities
{
    public class US_StateViewModel
    {
        [Key]
        public int Id { get; set; }
        

        [Required]
        [DisplayName("Nome da cidade")]
        public string StateName { get; set; }

        public string StateCode { get; set; } 
    }
}
