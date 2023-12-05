using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project.Models;

namespace Final_Project.Pages;

public class IndexModel : PageModel
{
    private readonly AnimeContext _context;
    private readonly ILogger<IndexModel> _logger;
    public List<Anime> Animes {get; set;} = default!;

    public IndexModel(AnimeContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
       Animes = _context.Anime.ToList();
    }
}
