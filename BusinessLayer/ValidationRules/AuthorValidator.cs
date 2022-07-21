using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Author Name Not Empty!").MinimumLength(2).MaximumLength(50);
            RuleFor(x => x.AuthorSurname).NotEmpty().WithMessage("Author Surname Not Empty !").MinimumLength(2).MaximumLength(50);
            RuleFor(x => x.AuthorAbout).NotEmpty().WithMessage("Author About Not Empty!").MinimumLength(2).MaximumLength(200);
            RuleFor(x => x.AuthorTitle).NotEmpty().WithMessage("Author Title Not Empty!").MinimumLength(2).MaximumLength(50);
        }   
    }
}
