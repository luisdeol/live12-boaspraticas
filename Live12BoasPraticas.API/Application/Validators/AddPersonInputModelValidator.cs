using FluentValidation;
using Live12BoasPraticas.API.Application.InputModels;

namespace Live12BoasPraticas.API.Application.Validators
{
    public class AddPersonInputModelValidator : AbstractValidator<AddPersonInputModel>
    {
        public AddPersonInputModelValidator()
        {
            RuleFor(im => im.Name)
                .Length(3, 50)
                .WithMessage("Name length should be between 3 and 50.");
        }
    }
}
