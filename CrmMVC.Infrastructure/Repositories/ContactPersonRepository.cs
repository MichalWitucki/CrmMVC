using CrmMVC.Domain.Interfaces;
using CrmMVC.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Infrastructure.Repositories
{
    public class ContactPersonRepository : IContactPersonRepository
    {
        private readonly CRMDbContext _context;

        public ContactPersonRepository(CRMDbContext context)
        {
            _context = context;
        }

        public void AddContactPerson(ContactPerson person)
        {
            _context.ContactPeople.Add(person);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            ContactPerson? contactPerson = _context.ContactPeople.Find(id);
            _context.ContactPeople.Remove(contactPerson);
            _context.SaveChanges();
        }

        public IQueryable<ContactPerson> GetAll()
        {
            return _context.ContactPeople
                .Include(cp => cp.Company)
                .Include(cp => cp.Role);
        }

        public ContactPerson? GetContactPerson(int id)
        {
            return _context.ContactPeople
                .Include(cp => cp.Company)
                .Include(cp => cp.Role)
                .FirstOrDefault(cp => cp.Id == id);
        }

        public IQueryable<PersonRole> GetPersonRoles()
        {
            return _context.PersonRoles;
        }
    }
}
