using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Domain.Interfaces
{
    public interface IContactPersonRepository
    {
        IQueryable<ContactPerson> GetAll();
        IQueryable<PersonRole> GetPersonRoles();
    }
}
