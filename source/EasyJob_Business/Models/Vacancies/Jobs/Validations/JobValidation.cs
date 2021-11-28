using FluentValidation;

namespace EasyJob_Business.Models.Vacancies.Jobs.Validations
{
    public class JobValidation : AbstractValidator<Job>
    {
        public JobValidation()
        {
            RuleFor(v => v.Title)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
               .Length(2, 50).WithMessage("O {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(v => v.Note)
  .Length(0, 1000).WithMessage("O {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");




        }
    }
}
