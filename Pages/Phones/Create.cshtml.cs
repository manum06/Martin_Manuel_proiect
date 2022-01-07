using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Martin_Manuel_proiect.Data;
using Martin_Manuel_proiect.Models;

namespace Martin_Manuel_proiect.Pages.Phones
{
    public class CreateModel : PageModel
    {
        private readonly Martin_Manuel_proiect.Data.Martin_Manuel_proiectContext _context;

        public CreateModel(Martin_Manuel_proiect.Data.Martin_Manuel_proiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["Supplier"] = new SelectList(_context.Set<Supplier>(), "ID", "SupplierName");
            return Page();
        }

        [BindProperty]
        public Phone Phone { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Phone.Add(Phone);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
