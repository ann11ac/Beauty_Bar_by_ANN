using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Beauty_Bar_by_ANN.Data;
using Beauty_Bar_by_ANN.Models;

namespace Beauty_Bar_by_ANN.Pages.Clients
{
    public class DetailsModel : PageModel
    {
        private readonly Beauty_Bar_by_ANN.Data.Beauty_Bar_by_ANNContext _context;

        public DetailsModel(Beauty_Bar_by_ANN.Data.Beauty_Bar_by_ANNContext context)
        {
            _context = context;
        }

        public Client Client { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Client.FirstOrDefaultAsync(m => m.ID == id);
            if (client == null)
            {
                return NotFound();
            }
            else
            {
                Client = client;
            }
            return Page();
        }
    }
}
