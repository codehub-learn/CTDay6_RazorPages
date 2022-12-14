using CTDay6.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CTDay6.Domain;
using Microsoft.EntityFrameworkCore;

namespace CTDay6.Pages.Actors
{
    public class DetailsModel : PageModel
    {
        private MoviesDbContext Context { get; }
        public Actor? Actor { get; set; }
        public List<Movie> ActorMovies { get; set; }

        public DetailsModel(MoviesDbContext context)
        {
            Context = context;
        }

        public async Task<ActionResult> OnGet(int id)
        {
            Actor = await Context.Actors.SingleOrDefaultAsync(a => a.Id == id);
            if (Actor is null) return BadRequest();
            ActorMovies = await Context.Movies.Where(m => m.Actors.Contains(Actor)).ToListAsync();
            return Page();
        }

    }
}
