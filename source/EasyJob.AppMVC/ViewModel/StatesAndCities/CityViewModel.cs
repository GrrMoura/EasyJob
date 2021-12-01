using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyJob.AppMVC.ViewModel.StatesAndCities
{
    public class CityViewModel
    {
        [Key]
        public int Id { get; set; }
        public int IdState { get; set; }

        [Required]
        [DisplayName("Nome da cidade")]
        public string CityName { get; set; }
    }
}
