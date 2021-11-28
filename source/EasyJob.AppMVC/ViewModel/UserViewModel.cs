using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyJob.AppMVC.ViewModel
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [DisplayName("Apelido")]
        [Required(ErrorMessage = "O campo {0} precisa ser preenchido")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Name { get; set; }

        [DisplayName("Contato telefônico")]
        [MaxLength(20, ErrorMessage = "O campo {0} precisa ter no máximo {1} caracteres")]
        public string ContactPhone { get; set; }

        [DisplayName("E-mail")]
        [EmailAddress]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Email { get; set; }

       [DisplayName("Mensagem de texto")]
        public bool Message { get; set; }

        [DisplayName("Ligação")]
        public bool Call { get; set; }

        [DisplayName("Ativo")]
        public bool Active { get; set; }

        [DisplayName("E-mail")]
        public bool Mail { get; set; }

        [DisplayName("Outra forma de contato")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Other { get; set; }

        
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreationTime { get; set; }

        [DisplayName("Data de modificação")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("Duração da vaga")] //TODO: criar radio button para 1,7 e 15 dias
        public DateTime ExpiryDate { get; set; }

        public AddressViewModel Address { get; set; }

        public ICollection<JobViewModel> Job { get; set; }

    }
}
