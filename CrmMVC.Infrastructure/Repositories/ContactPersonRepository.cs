﻿using CrmMVC.Domain.Interfaces;
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

        public IQueryable<ContactPerson> GetAll()
        {
            return _context.ContactPeople
                .Include(cp => cp.Company)
                .Include(cp => cp.Role);
        }
    }
}