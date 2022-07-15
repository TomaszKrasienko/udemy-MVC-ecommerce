using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class MovieService : EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDbContext _context;
        public MovieService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movies
                .Include(c => c.Cinema)
                .Include(p => p.Producer)
                .Include(a => a.Actors_Movies).ThenInclude(a => a.Actor)
                .SingleOrDefaultAsync(x => x.Id == id);
            return movieDetails;
        }

        public async Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues()
        {
            var respone = new NewMovieDropdownsVM()
            {
                Actors = await _context.Actors.OrderBy(x => x.FullName).ToListAsync(),
                Cinemas = await _context.Cinemas.OrderBy(x => x.Name).ToListAsync(),
                Producers = await _context.Producers.OrderBy(x => x.FullName).ToListAsync()
            };
            return respone;
        }
    }
}