﻿using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.ContactPerson
{
    public class AddContactPersonVm
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string Role { get; set; }
        public int RoleId { get; set; }
        public List<PersonRole> Roles { get; set; }
        public int CompanyId { get; set; }
    }
}
