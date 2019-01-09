using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDFCore.Models.ViewModelValidators
{
    public class EventoValidator : AbstractValidator<Evento>
    {
        public EventoValidator()
        {

            RuleFor(x => x.Nome)
                .MaximumLength(200).WithMessage("O valor maximo é 100")
                .MinimumLength(2).WithMessage("O valor minimo é 2")
                //.Must(x => !string.IsNullOrEmpty(x)).WithMessage("O nome é obrigatorio");
                .NotEmpty().NotNull().WithMessage("O nome é obrigatorio");

            RuleFor(x => x.Valor)
                //.NotEmpty().WithMessage("O Valor é obrigatório")
                .InclusiveBetween(10, 100).WithMessage("Valor permitido entre 10 - 1000");
                //.Length(10, 1000).WithMessage("Valor permitido entre 10 - 1000");

            RuleFor(x => x.Descricao)
                .NotEmpty().WithMessage("A Descricao é obrigatorio")
                .MaximumLength(200).WithMessage("O valor maximo é 200");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email obrigatorio")
                .EmailAddress();

            
        }
    }
}
