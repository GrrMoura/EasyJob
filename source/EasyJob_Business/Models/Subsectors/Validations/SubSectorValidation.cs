using FluentValidation;

namespace EasyJob_Business.Models.Subsectors.Validations
{
    public class SubsectorValidation : AbstractValidator<Subsector>
    {
        public SubsectorValidation()
        {
            RuleFor(su => su.Title)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
               .Length(2, 50).WithMessage("O {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}
