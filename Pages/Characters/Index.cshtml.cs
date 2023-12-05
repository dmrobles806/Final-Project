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
            CurrentSort = "first_asc";
        }

        public IList<Character> Character { get;set; } = default!;

        [BindProperty(SupportsGet = true)]

        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        [BindProperty(SupportsGet = true)]

        public string CurrentSort {get; set;}

        [BindProperty(SupportsGet = true)]

        public string? SearchString {get; set;}

        public async Task OnGetAsync()
        {
            var query = _context.Character.Select(c => c);

            if (!string.IsNullOrEmpty(SearchString))
            {
                query = query.Where(c => c.CharacterName.Contains(SearchString));
            }

            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(c => c.CharacterName);
                    break;
                case "first_desc":
                    query = query.OrderBy(c => c.CharacterName);
                    break;
            }
            if (_context.Character != null)
            {
                Character = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            }
        }
    }
}
