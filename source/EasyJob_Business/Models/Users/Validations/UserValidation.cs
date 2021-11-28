using FluentValidation;

namespace EasyJob_Business.Models.Users.Validations
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(e => e.Name)
                 .NotEmpty().WithMessage("O {PropertyName} precisa ser preenchido")
                 .Length(2, 50).WithMessage("O {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(e => e.ContactPhone)
                 .Length(0,20).WithMessage("O {PropertyName} precisa ter no máximo {PropertyValue} caracteres");
                      
            RuleFor(e => e.Email)               
                .Length(0,50).WithMessage("O {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            
        }
    }
}
