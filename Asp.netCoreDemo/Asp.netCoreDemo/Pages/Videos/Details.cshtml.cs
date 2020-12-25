using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Asp.netCoreDemo.Data;
using Asp.netCoreDemo.Models;

namespace Asp.netCoreDemo
{
    public class DetailsModel : PageModel
    {
        private readonly Asp.netCoreDemo.Data.AspnetCoreDemoContext _context;

        public DetailsModel(Asp.netCoreDemo.Data.AspnetCoreDemoContext context)
        {
            _context = context;
        }

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
    }
}
