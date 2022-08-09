using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            //Olmayan bir kuralı eklemek için
            //RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A haarfi ile başlamalı");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
