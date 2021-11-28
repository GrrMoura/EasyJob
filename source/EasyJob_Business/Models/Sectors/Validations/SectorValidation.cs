using FluentValidation;

namespace EasyJob_Business.Models.Sectors.Validations
{
    public class SectorValidation : AbstractValidator<Sector>
    {
        public SectorValidation()
        {
            RuleFor(s => s.Title)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
               .Length(2, 20).WithMessage("O {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}
