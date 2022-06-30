using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalPizzaProject.Data;
using FinalPizzaProject.Models;

namespace FinalPizzaProject.Pages
{
    public class EditModel : PageModel
    {
        private readonly FinalPizzaProject.Data.ApplicationDbContext _context;

        public EditModel(FinalPizzaProject.Data.ApplicationDbContext context)
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

            var pizzaorder =  await _context.PizzaOrders.FirstOrDefaultAsync(m => m.Id == id);
            if (pizzaorder == null)
            {
                return NotFound();
            }
            PizzaOrder = pizzaorder;
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

            _context.Attach(PizzaOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PizzaOrderExists(PizzaOrder.Id))
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

        private bool PizzaOrderExists(int id)
        {
          return (_context.PizzaOrders?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
