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
        void Add(ContactPerson person);
        void Delete(int id);
        IQueryable<ContactPerson> GetAll();
        ContactPerson? Get(int id);
        IQueryable<PersonRole> GetPersonRoles();
        void Update(ContactPerson contactPerson);
    }
}
