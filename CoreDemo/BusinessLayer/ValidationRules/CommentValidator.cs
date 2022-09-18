using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CommentValidator : AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.CommentUserName).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz.");
            RuleFor(x => x.CommentContent).MaximumLength(150).WithMessage("Lüttfen 150 karakterden daha az veri girişi yapınız.");
            RuleFor(x => x.CommentTitle).MinimumLength(5).WithMessage("Lüttfen 4 karakterden daha fazla veri girişi yapınız.");
            RuleFor(x => x.CommentContent).MinimumLength(5).WithMessage("Lüttfen 4 karakterden daha fazla veri girişi yapınız.");
            RuleFor(x => x.CommentTitle).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz.");
            RuleFor(x => x.CommentContent).NotEmpty().WithMessage("Bu alanı boş geçemezsiniz.");
        }
    }
}
