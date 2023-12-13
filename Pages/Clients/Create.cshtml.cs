using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Beauty_Bar_by_ANN.Data;
using Beauty_Bar_by_ANN.Models;

namespace Beauty_Bar_by_ANN.Pages.Clients
{
    public class CreateModel : PageModel
    {
        private readonly Beauty_Bar_by_ANN.Data.Beauty_Bar_by_ANNContext _context;

        public CreateModel(Beauty_Bar_by_ANN.Data.Beauty_Bar_by_ANNContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Client Client { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Client.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
