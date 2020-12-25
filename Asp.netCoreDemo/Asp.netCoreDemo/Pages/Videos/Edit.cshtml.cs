using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Asp.netCoreDemo.Data;
using Asp.netCoreDemo.Models;

namespace Asp.netCoreDemo
{
    public class EditModel : PageModel
    {
        private readonly Asp.netCoreDemo.Data.AspnetCoreDemoContext _context;

        public EditModel(Asp.netCoreDemo.Data.AspnetCoreDemoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Video Video { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Video = await _context.Video.FirstOrDefaultAsync(m => m.Id == id);

            if (Video == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Video).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VideoExists(Video.Id))
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

        private bool VideoExists(int id)
        {
            return _context.Video.Any(e => e.Id == id);
        }
    }
}
