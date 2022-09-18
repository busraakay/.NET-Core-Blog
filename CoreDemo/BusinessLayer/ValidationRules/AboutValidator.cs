using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.AboutDetails1).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz.");
            RuleFor(x => x.AboutDetails2).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz.");
            RuleFor(x => x.AboutDetails1).MaximumLength(150).WithMessage("Lüttfen 150 karakterden daha az veri girişi yapınız.");
            RuleFor(x => x.AboutDetails2).MinimumLength(5).WithMessage("Lüttfen 4 karakterden daha fazla veri girişi yapınız.");
            RuleFor(x => x.AboutDetails1).MinimumLength(5).WithMessage("Lüttfen 4 karakterden daha fazla veri girişi yapınız.");
            RuleFor(x => x.AboutMapLocation).NotEmpty().WithMessage("EditMessage");
        }
    }
}
