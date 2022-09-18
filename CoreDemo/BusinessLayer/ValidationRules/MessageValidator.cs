using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message2>
    {
        public MessageValidator()
        {
            RuleFor(x => x.MessageDetails).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz.");
            RuleFor(x => x.MessageDetails).MaximumLength(150).WithMessage("Lüttfen 150 karakterden daha az veri girişi yapınız.");
            RuleFor(x => x.MessageDetails).MinimumLength(5).WithMessage("Lüttfen 4 karakterden daha fazla veri girişi yapınız.");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Lüttfen 4 karakterden daha fazla veri girişi yapınız.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz.");
            
        }
    }
}
