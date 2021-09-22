﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactsInterface.Data;
using ContactsInterface.Models;

namespace ContactsInterface.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly ContactsInterface.Data.ContactContext _context;

        public IndexModel(ContactsInterface.Data.ContactContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; }

        public async Task OnGetAsync()
        {
            Contact = await _context.Contacts.ToListAsync();
        }
    }
}
