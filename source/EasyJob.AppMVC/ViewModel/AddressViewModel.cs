using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyJob.AppMVC.ViewModel
{
    public class AddressViewModel
    {
        public AddressViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [DisplayName("País")]
        [Required]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Country { get; set; }

        [DisplayName("Estado")]
        [Required]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string State { get; set; }

        [DisplayName("Cidade")]
        [Required]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string City { get; set; }

        public Guid? JobId { get; set; }
        public Guid? UserId { get; set; }
        public ICollection<JobViewModel> Vacancies { get; set; }


        public JobViewModel Job { get; set; }
        public UserViewModel User { get; set; }
    }
}