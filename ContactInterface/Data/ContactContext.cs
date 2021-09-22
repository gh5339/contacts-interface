using ContactsInterface.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsInterface.Data
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions options) : base(options) // DbContextOptions options
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
