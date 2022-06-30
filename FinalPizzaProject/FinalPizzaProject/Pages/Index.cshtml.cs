using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalPizzaProject.Data;
using FinalPizzaProject.Models;

namespace FinalPizzaProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly FinalPizzaProject.Data.ApplicationDbContext _context;

        public IndexModel(FinalPizzaProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<PizzaOrder> PizzaOrder { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.PizzaOrders != null)
            {
                PizzaOrder = await _context.PizzaOrders.ToListAsync();
            }
        }
    }
}
