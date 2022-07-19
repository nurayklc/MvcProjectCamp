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
            RuleFor(x => x.AuthorName).NotEmpty().MinimumLength(2).MaximumLength(50).WithMessage("Author Name Not Empty!");
            RuleFor(x => x.AuthorSurname).NotEmpty().MinimumLength(2).MaximumLength(50).WithMessage("Author Surname Not Empty !");
            RuleFor(x => x.AuthorAbout).NotEmpty().MinimumLength(2).MaximumLength(50).WithMessage("author About Not Empty!");
        }   
    }
}
