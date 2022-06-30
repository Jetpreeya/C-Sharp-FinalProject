using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalPizzaProject.Data;
using FinalPizzaProject.Models;

namespace FinalPizzaProject.Pages
{
    public class CreateModel : PageModel
    {
        private readonly FinalPizzaProject.Data.ApplicationDbContext _context;

        public CreateModel(FinalPizzaProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PizzaOrder PizzaOrder { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.PizzaOrders == null || PizzaOrder == null)
            {
                return Page();
            }

            _context.PizzaOrders.Add(PizzaOrder);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
