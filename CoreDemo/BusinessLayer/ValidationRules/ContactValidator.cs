using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.ContactUserName).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz.");
            RuleFor(x => x.ContactMessage).MaximumLength(150).WithMessage("Lüttfen 150 karakterden daha az veri girişi yapınız.");
            RuleFor(x => x.ContactSubject).MinimumLength(5).WithMessage("Lüttfen 4 karakterden daha fazla veri girişi yapınız.");
            RuleFor(x => x.ContactMessage).MinimumLength(5).WithMessage("Lüttfen 4 karakterden daha fazla veri girişi yapınız.");
            RuleFor(x => x.ContactMessage).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz.");
            RuleFor(x => x.ContactSubject).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz.");
            RuleFor(x => x.ContactMail).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz.");
        }
    }
}
