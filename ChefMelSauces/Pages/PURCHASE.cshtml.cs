using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ChefMelSauces.Models;

namespace ChefMelSauces.Pages
{
    public class PURCHASEModel : PageModel
    {
        private readonly ChefMelSauces.Models.ChefMelSaucesContext _context;

        public PURCHASEModel(ChefMelSauces.Models.ChefMelSaucesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ECommerce ECommerce { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ECommerce.Add(ECommerce);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}