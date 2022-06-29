using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category Name Not Empty!");
            RuleFor(x => x.CategoryName).MinimumLength(3).MaximumLength(20).WithMessage("Category Name !");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Category Description Not Empty!");
        }
    }
}
