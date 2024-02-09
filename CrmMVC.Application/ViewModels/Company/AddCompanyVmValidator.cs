using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.Company
{
    public class AddCompanyVmValidator : AbstractValidator<AddCompanyVm>
    {
        public AddCompanyVmValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Pole jest wymagane");

            RuleFor(c => c.City)
                .NotEmpty().WithMessage("Pole jest wymagane");

            RuleFor(c => c.VoivodeshipId)
                .NotEmpty().WithMessage("Pole jest wymagane");

            RuleFor(c => c.CompanyTypeId)
                .NotEmpty().WithMessage("Pole jest wymagane");
        }
    }
}
