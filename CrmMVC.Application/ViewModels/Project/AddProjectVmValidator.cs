using CrmMVC.Application.ViewModels.ContactPerson;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.Project
{
	public class AddProjectVmValidator : AbstractValidator<AddProjectVm>
	{
		public AddProjectVmValidator()
		{
			RuleFor(p => p.FullName)
				.NotEmpty().WithMessage("Pole jest wymagane");
			RuleFor(p => p.ShortName)
				.NotEmpty().WithMessage("Pole jest wymagane");
			RuleFor(p => p.City)
				.NotEmpty().WithMessage("Pole jest wymagane");
			RuleFor(c => c.VoivodeshipId)
				.NotEmpty().WithMessage("Pole jest wymagane");
			RuleFor(c => c.TypeId)
				.NotEmpty().WithMessage("Pole jest wymagane");
			RuleFor(c => c.StatusId)
				.NotEmpty().WithMessage("Pole jest wymagane");
		}
	}
}
