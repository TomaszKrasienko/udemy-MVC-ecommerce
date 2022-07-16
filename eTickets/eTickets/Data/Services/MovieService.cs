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

        public async Task AddNewMovieAsync(NewMovieVM data)
        {
            var newMovie = new Movie()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageUrl = data.ImageUrl,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                ProducerId = data.ProducerId,
                CinemaId = data.CinemaId
            };
            await _context.Movies.AddAsync(newMovie);
            await _context.SaveChangesAsync();
            foreach (var actorId in data.ActorsIds)
            {
                var newActorMovie = new Actor_Movie()
                {
                    MovieId = newMovie.Id,
                    ActorId = actorId
                };
                await _context.ActorsMovies.AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMovieAsync(int id, NewMovieVM data)
        {
            var dbMovie = await _context.Movies
                .SingleOrDefaultAsync(x => x.Id == data.Id);
            if (dbMovie != null)
            {
                dbMovie.Name = data.Name;
                dbMovie.Description = data.Description; 
                dbMovie.Price = data.Price; 
                dbMovie.ImageUrl = data.ImageUrl;
                dbMovie.StartDate = data.StartDate;
                dbMovie.EndDate = data.EndDate;
                dbMovie.ProducerId = data.ProducerId;
                dbMovie.CinemaId = data.CinemaId;
                await _context.SaveChangesAsync();
            }

            var existingActorsDb = await _context.ActorsMovies
                .Where(x => x.MovieId == data.Id)
                .ToListAsync();
            _context.ActorsMovies.RemoveRange(existingActorsDb);
            await _context.SaveChangesAsync();
            foreach (var actorId in data.ActorsIds)
            {
                var newActorMovie = new Actor_Movie()
                {
                    MovieId = data.Id,
                    ActorId = actorId
                };
                await _context.ActorsMovies.AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();
        }
    }
}