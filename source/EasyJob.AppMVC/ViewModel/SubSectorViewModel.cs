using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyJob.AppMVC.ViewModel
{
    public class SubsectorViewModel
    {
        public SubsectorViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [DisplayName("SubSetor")]
        [Required]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres ")]
        public string Title { get; set; }

    }
}