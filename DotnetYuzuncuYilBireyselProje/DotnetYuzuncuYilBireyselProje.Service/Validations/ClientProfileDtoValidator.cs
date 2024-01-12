using DotnetYuzuncuYilBireyselProje.Core.DTOs;
using DotnetYuzuncuYilBireyselProje.Core.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilBireyselProje.Service.Validations
{
    public class ClientProfileDtoValidator : AbstractValidator<ClientProfileDto>
    {
        public ClientProfileDtoValidator() 
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Kullanıcının adı boş olamaz.")
               .NotNull().WithMessage("Kullanıcının adı null olamaz.");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Kullanıcının soyadı boş olamaz.")
              .NotNull().WithMessage("Kullanıcının soyadı null olamaz.");
        }
    }
}
