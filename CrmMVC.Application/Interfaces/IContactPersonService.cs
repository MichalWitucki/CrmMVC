using CrmMVC.Application.ViewModels.ContactPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.Interfaces
{
    public interface IContactPersonService
    {
        IEnumerable<ContactPersonVm> GetAll();
    }
}
