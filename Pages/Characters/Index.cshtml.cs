using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project.Models;

namespace Final_Project.Pages_Characters
{
    public class IndexModel : PageModel
    {
        private readonly Final_Project.Models.AnimeContext _context;

        public IndexModel(Final_Project.Models.AnimeContext context)
        {
            _context = context;
        }

        public IList<Character> Character { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Character != null)
            {
                Character = await _context.Character.ToListAsync();
            }
        }
    }
}
