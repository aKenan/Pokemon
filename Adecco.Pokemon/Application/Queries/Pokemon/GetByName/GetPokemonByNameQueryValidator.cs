using FluentValidation;

namespace Adecco.Pokemon.Application.Queries.Pokemon.GetByName
{
    /// <summary>
    /// Validator for <see cref="GetPokemonByNameQuery"/>.
    /// </summary>
    public class GetPokemonByNameQueryValidator : AbstractValidator<GetPokemonByNameQuery>
    {
        /// <summary>
        /// 
        /// </summary>
        public GetPokemonByNameQueryValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("Name is required");
        }
    }
}
