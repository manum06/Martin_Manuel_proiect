using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Martin_Manuel_proiect.Data;
using Martin_Manuel_proiect.Models;

namespace Martin_Manuel_proiect.Pages.Phones
{
    public class IndexModel : PageModel
    {
        private readonly Martin_Manuel_proiect.Data.Martin_Manuel_proiectContext _context;

        public IndexModel(Martin_Manuel_proiect.Data.Martin_Manuel_proiectContext context)
        {
            _context = context;
        }

        public IList<Phone> Phone { get;set; }

        public async Task OnGetAsync()
        {
            Phone = await _context.Phone
                .ToListAsync();

        }
    }
}
