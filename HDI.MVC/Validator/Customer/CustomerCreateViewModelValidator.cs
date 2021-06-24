using FluentValidation;
using HDI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HDI.MVC.Validator
{
    public class CustomerCreateViewModelValidator : AbstractValidator<CustomerCreateViewModel>
    {
        public CustomerCreateViewModelValidator()
        {

        }
    }
}
