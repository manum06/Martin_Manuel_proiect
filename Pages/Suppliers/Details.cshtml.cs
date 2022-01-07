using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Martin_Manuel_proiect.Data;
using Martin_Manuel_proiect.Models;

namespace Martin_Manuel_proiect.Pages.Suppliers
{
    public class DetailsModel : PageModel
    {
        private readonly Martin_Manuel_proiect.Data.Martin_Manuel_proiectContext _context;

        public DetailsModel(Martin_Manuel_proiect.Data.Martin_Manuel_proiectContext context)
        {
            _context = context;
        }

        public Supplier Supplier { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Supplier = await _context.Supplier.FirstOrDefaultAsync(m => m.ID == id);

            if (Supplier == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
