using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyJob.AppMVC.ViewModel
{
    public class SectorViewModel
    {

        public SectorViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [DisplayName("Setor")]
        [Required]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres ")]
        public string Title { get; set; }

        public ICollection<SubsectorViewModel> Subsector { get; set; }
    }
}