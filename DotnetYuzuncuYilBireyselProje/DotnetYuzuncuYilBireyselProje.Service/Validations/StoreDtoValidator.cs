using DotnetYuzuncuYilBireyselProje.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilBireyselProje.Service.Validations
{
    public class StoreDtoValidator:AbstractValidator<StoreDto>
    {
        public StoreDtoValidator()
        {
            RuleFor(x => x.StoreName).NotNull().WithMessage("{PropertyName} null geçilemez.").NotEmpty().WithMessage("{PropertyName} boş geçilemez");
        }
    }
}
