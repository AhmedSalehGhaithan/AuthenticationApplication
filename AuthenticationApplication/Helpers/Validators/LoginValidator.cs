namespace AuthenticationApplication.Helpers.Validators;

using AuthenticationApplication.Helpers.Dtos;
using FluentValidation;

public class LoginValidator : AbstractValidator<LoginViewModel>
{
    public LoginValidator()
    {
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
        RuleFor(x => x.Password).NotEmpty();
    }
}