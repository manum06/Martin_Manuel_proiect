using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Martin_Manuel_proiect.Data;
using Martin_Manuel_proiect.Models;

namespace Martin_Manuel_proiect.Pages.Phones
{
    public class EditModel : PageModel
    {
        private readonly Martin_Manuel_proiect.Data.Martin_Manuel_proiectContext _context;

        public EditModel(Martin_Manuel_proiect.Data.Martin_Manuel_proiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Phone Phone { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Phone = await _context.Phone.FirstOrDefaultAsync(m => m.ID == id);

            if (Phone == null)
            {
                return NotFound();
            }
            ViewData["Supplier"] = new SelectList(_context.Set<Supplier>(), "ID", "SupplierName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Phone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhoneExists(Phone.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PhoneExists(int id)
        {
            return _context.Phone.Any(e => e.ID == id);
        }
    }
}
