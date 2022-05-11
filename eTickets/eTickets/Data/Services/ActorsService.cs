using System.Collections.Generic;
using System.Linq;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Actor> GetAll()
        {
            var result = _context.Actors.ToList();
            return result;
        }

        public Actor GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Actor actor)
        {
            throw new System.NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}