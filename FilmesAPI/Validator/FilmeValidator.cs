using System.ComponentModel.DataAnnotations;
using FilmesAPI.Models;
using FluentValidation;

namespace FilmesAPI.Validator
{
    //private FilmeValidator _filmeValidator;

    //_filmeValidator = new FilmeValidator();

    //var validationResult = _filmeValidator.Validate(filme);
    //if (!validationResult.IsValid) return BadRequest(validationResult.Errors);
    public class FilmeValidator : AbstractValidator<Filme>
    {
        public FilmeValidator()
        {
            //Não pode ser vazio ou maior que 200 caracteres
            RuleFor(x => x.Titulo).
                NotEmpty().WithMessage("O título do filme é obrigatório").
                MaximumLength(200).WithMessage("O título do filme não pode exceder 200 caracteres");

            //Genero - Não pode ser vazio ou maior que 200 caracteres
            RuleFor(x => x.Genero).
                NotEmpty().WithMessage("O gênero do filme é obrigatório").
                MaximumLength(20).WithMessage("O gênero do filme não pode exceder 30 caracteres");

            //Não pode ser vazio, e precisa ter o valor entre 70 e 240
            RuleFor(x => x.Duracao).
                NotEmpty().WithMessage("A duração do filme é obrigatória").
                GreaterThan(70).WithMessage("O valor da duração do filme deve ser maior que 70 minutos").
                LessThan(240).WithMessage("O valor da duração do filme deve ser maior que 240 minutos");
        }
    }
}
