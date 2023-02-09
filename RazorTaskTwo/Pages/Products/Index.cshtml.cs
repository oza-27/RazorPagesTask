using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorTaskTwo.Data;
using RazorTaskTwo.Model;

namespace RazorTaskTwo.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly RazorTaskTwo.Data.ApplicationDbContext _context;

        public IndexModel(RazorTaskTwo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products
                .Include(p => p.Category).ToListAsync();
            }
        }
    }
}
