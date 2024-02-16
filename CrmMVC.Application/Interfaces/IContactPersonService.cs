using CrmMVC.Application.ViewModels.ContactPerson;
using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.Interfaces
{
    public interface IContactPersonService
    {
        void AddContactPerson(AddContactPersonVm person);
        IEnumerable<ContactPersonVm> GetAll();
        IEnumerable<PersonRole> GetPersonRoles();
    }
}
