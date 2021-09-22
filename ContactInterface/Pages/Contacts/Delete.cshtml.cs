using System;
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
    public class DeleteModel : PageModel
    {
        private readonly ContactsInterface.Data.ContactContext _context;

        public DeleteModel(ContactsInterface.Data.ContactContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Contact Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact = await _context.Contacts.FirstOrDefaultAsync(m => m.Id == id);

            if (Contact == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact = await _context.Contacts.FindAsync(id);

            if (Contact != null)
            {
                _context.Contacts.Remove(Contact);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
