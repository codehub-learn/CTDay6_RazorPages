using CTDay6.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CTDay6.Domain;
using Microsoft.EntityFrameworkCore;

namespace CTDay6.Pages.Actors
{
    public class IndexModel : PageModel
    {
        private MoviesDbContext Context { get; }
        public List<Actor> Actors { get; set; }
        
        public IndexModel(MoviesDbContext context)
        {
            Context = context;
        }

        public async Task OnGet()
        {
            Actors = await Context.Actors.ToListAsync(); 
        }
    }
}
