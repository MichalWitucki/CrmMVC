using CrmMVC.Application.ViewModels.Company;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.ContactPerson
{
    public class AddContactPersonVmValidator : AbstractValidator<AddContactPersonVm>
    {
        public AddContactPersonVmValidator()
        {
            RuleFor(cp => cp.FirstName)
                .NotEmpty().WithMessage("Pole jest wymagane");

            RuleFor(cp => cp.LastName)
                .NotEmpty().WithMessage("Pole jest wymagane");

            RuleFor(cp => cp.RoleId)
                .NotEmpty().WithMessage("Pole jest wymagane");

            RuleFor(cp => cp.PhoneNumber)
                .NotEmpty().WithMessage("Pole jest wymagane")
                .Length(9).WithMessage("Pole powinno składać się z 9 cyfr");

            RuleFor(cp => cp.Email)
                .EmailAddress().WithMessage("Pole nie zawiera poprawnego adresu email");             
        }
    }
}
