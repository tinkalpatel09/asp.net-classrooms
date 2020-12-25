using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Asp.netCoreDemo.Data;
using Asp.netCoreDemo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Asp.netCoreDemo
{
    public class IndexModel : PageModel
    {
        private readonly Asp.netCoreDemo.Data.AspnetCoreDemoContext _context;

        public IndexModel(Asp.netCoreDemo.Data.AspnetCoreDemoContext context)
        {
            _context = context;
        }

        public IList<Video> Video { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        //required using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string VideoGenre { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from v in _context.Video
                                            orderby v.Genre
                                            select v.Genre;
            var videos = from v in _context.Video
                         select v;
            if (!string.IsNullOrEmpty(SearchString))
            {
                videos = videos.Where(s => s.Title.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(VideoGenre))
            {
                videos = videos.Where(s => s.Genre.Contains(VideoGenre));
            }
            // Video = await _context.Video.ToListAsync();
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Video = await videos.ToListAsync();
         
        }
    }
}
