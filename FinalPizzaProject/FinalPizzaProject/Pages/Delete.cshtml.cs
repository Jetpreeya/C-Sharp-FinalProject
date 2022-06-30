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
    public class DeleteModel : PageModel
    {
        private readonly FinalPizzaProject.Data.ApplicationDbContext _context;

        public DeleteModel(FinalPizzaProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public PizzaOrder PizzaOrder { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.PizzaOrders == null)
            {
                return NotFound();
            }

            var pizzaorder = await _context.PizzaOrders.FirstOrDefaultAsync(m => m.Id == id);

            if (pizzaorder == null)
            {
                return NotFound();
            }
            else 
            {
                PizzaOrder = pizzaorder;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.PizzaOrders == null)
            {
                return NotFound();
            }
            var pizzaorder = await _context.PizzaOrders.FindAsync(id);

            if (pizzaorder != null)
            {
                PizzaOrder = pizzaorder;
                _context.PizzaOrders.Remove(PizzaOrder);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
