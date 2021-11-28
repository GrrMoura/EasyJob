using EasyJob_Business.Models.Addresses.Service;
using FluentValidation;

namespace EasyJob_Business.Models.Addresses.Validations
{
    public class AdressValidation : AbstractValidator<Adress>
    {
        public AdressValidation()
        {
            RuleFor(a => a.Country)
                .NotEmpty().WithMessage("o {PropertyName} precisa ser preenchido")
                .Length(2, 100).WithMessage("o {PropertyName} precisa ter entre {MinLength} e {MaxLength}");

            RuleFor(a => a.State)
                .NotEmpty().WithMessage("o {PropertyName} precisa ser preenchido")
                .Length(2, 100).WithMessage("o {PropertyName} precisa ter entre {MinLength} e {MaxLength}");

            RuleFor(a => a.City)
               .NotEmpty().WithMessage("o {PropertyName} precisa ser preenchido")
               .Length(2, 100).WithMessage("o {PropertyName} precisa ter entre {MinLength} e {MaxLength}");

           


        }
    }
}
