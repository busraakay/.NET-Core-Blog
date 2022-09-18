using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz.");
            RuleFor(x => x.BlogContent).MinimumLength(5).WithMessage("Lüttfen 4 karakterden daha fazla veri girişi yapınız.");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Lüttfen 4 karakterden daha fazla veri girişi yapınız.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz.");
        }
    }
}
